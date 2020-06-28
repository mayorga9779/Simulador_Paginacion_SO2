using DevExpress.XtraGrid.Columns;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace Simulador_Paginacion_SO2
{
    public partial class Frm_Algoritmo_Fifo : Form
    {
        private static Frm_Algoritmo_Fifo instancia = null;
        private DataTable dtProcesos = new DataTable();
        private int cantidad_labels = 0;
        private int alto_contenedor = 0;
        private int ancho_contenedor = 0;
        private int alto_etiqueta = 0;
        private int ancho_etiqueta = 0;
        private int posicion_x = 0;
        private int posicion_y = 0;
        private String numero_pagina = "";
        private String numero_marco = "";
        private Boolean agregar_elemento = true;
        private Label[] etiqueta_DD;
        private Label[] etiqueta_tabla_paginas;
        private Label[] etiqueta_marcos;
        private ToolTip[] tooltip;
        private List<Proceso> lstProcesos = null;
        private List<Proceso_Ejecucion> lstProcesosEnEjecucion = null;
        private List<Proceso_Espera> lstProcesosEnEspera = null;
        private List<Marco> lstMarcos = null;
        private Proceso_Ejecucion proceso_ejecucion = null;
        private Proceso_Espera proceso_espera = null;
        private Marco marco = null;
        private static int tamanio_ram = 240;   

        public static Frm_Algoritmo_Fifo GetInstancia()
        {
            if(instancia == null || instancia.IsDisposed)
            {
                instancia = new Frm_Algoritmo_Fifo();
            }
            return instancia;
        }

        public Frm_Algoritmo_Fifo()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;    //maximizo el formulario.
            lstProcesosEnEjecucion = new List<Proceso_Ejecucion>();
            lstProcesosEnEspera = new List<Proceso_Espera>();
            lstMarcos = new List<Marco>();
        }

        public void CrearColumnas() //creo las columnas del datatable
        {
            dtProcesos.Columns.Add("Id");   //creo la columna y le digo que sea solo de lectura
            dtProcesos.Columns.Add("nombre_proceso");   //creo la columna y le digo que sea solo de lectura
            dtProcesos.Columns.Add("tamanio_proceso");   //esta columna se va a poder editar
            dtProcesos.Columns.Add("color_proceso");
        }

        public void AgregarFilas(int numero_filas)  //agrego filas al datatable
        {
            for(int i = 0; i < numero_filas; i++)
            {
                DataRow dr = dtProcesos.NewRow();
                dr[0] = "P" + (i + 1);          //id del proceso
                dr[1] = "Proceso " + (i + 1);   //nombre del proceso
                dr[2] = 1;                      //tamaño por default del proceso
                dr[3] = RandomColores();        //color que le asigno al proceso

                dtProcesos.Rows.Add(dr);
            }
        }

        public String RandomColores()
        {
            Thread.Sleep(150);   //se debe hacer una pausa antes del hacer el random, porque si no, todos los randoms sería iguales por la velocidad del procesador  //250 milisegundos 1000=1segundo
            Random aleatorio = new Random();
            int rojo = aleatorio.Next(250);
            int verde = aleatorio.Next(250);
            int azul = aleatorio.Next(250);
            //hago el random del alpha tambien entre 0 y 255
            Thread.Sleep(50);
            //Random aleatorioAlpha = new Random();
            int alpha = aleatorio.Next(0, 255);
            String color = String.Format("#{0}", Color.FromArgb(alpha, rojo, verde, azul).Name.ToUpper().Substring(0, 6));

            return color;
        }

        public void CrearListaDeLabels()
        {
            lstProcesos = new List<Proceso>();
            Proceso proceso;
            cantidad_labels = Convert.ToInt16(txtNumeroProcesos.Text.Trim());
            alto_contenedor = pnlDiscoDuro.Height;
            ancho_contenedor = pnlDiscoDuro.Width;
            alto_etiqueta = alto_contenedor / cantidad_labels;
            ancho_etiqueta = ancho_contenedor;
            posicion_x = 0;
            posicion_y = 0;
            etiqueta_DD = new Label[cantidad_labels];
            tooltip = new ToolTip[cantidad_labels];

            for (int i = 0; i < cantidad_labels; i++)
            {
                etiqueta_DD[i] = new Label();
                tooltip[i] = new ToolTip();
                tooltip[i].ToolTipIcon = ToolTipIcon.Info;
                tooltip[i].IsBalloon = true;

                etiqueta_DD[i].Name = dtProcesos.Rows[i]["Id"].ToString();
                etiqueta_DD[i].Text = "ID Proc.: " + dtProcesos.Rows[i]["Id"].ToString() + Environment.NewLine +
                    "Nombre proc.: " + dtProcesos.Rows[i]["nombre_proceso"].ToString() + Environment.NewLine +
                    "Tamaño proc.: " + dtProcesos.Rows[i]["tamanio_proceso"].ToString() + " KB";
                etiqueta_DD[i].Font = new Font("Arial", etiqueta_DD[i].Font.Size + 3, FontStyle.Bold);
                etiqueta_DD[i].TextAlign = ContentAlignment.MiddleCenter;
                etiqueta_DD[i].BackColor = ColorTranslator.FromHtml(dtProcesos.Rows[i]["color_proceso"].ToString());
                etiqueta_DD[i].SetBounds(posicion_x, posicion_y, ancho_etiqueta, alto_etiqueta);
                tooltip[i].SetToolTip(etiqueta_DD[i], etiqueta_DD[i].Text);   //agrego tooltipo a las etiquetas
                etiqueta_DD[i].Show();
                etiqueta_DD[i].Click += new EventHandler(Evento_Labels_Disco_Duro);   //agrego el evento a las etiquetas.

                pnlDiscoDuro.Controls.Add(etiqueta_DD[i]);
                posicion_y = posicion_y + alto_etiqueta;

                //agrego los datos al arraylist de procesos
                decimal tamanio_pagina = Convert.ToDecimal(cbTamanioPagina.Text.Replace(" KB", ""));  //obtengo solo el valor numerico
                decimal tamanio_proceso = Convert.ToDecimal(dtProcesos.Rows[i]["tamanio_proceso"].ToString());
                decimal paginas_x_proceso = Math.Ceiling(tamanio_proceso / tamanio_pagina); //aproximon al numero mayor
                proceso = new Proceso(dtProcesos.Rows[i]["Id"].ToString(), dtProcesos.Rows[i]["nombre_proceso"].ToString(), Convert.ToInt16(dtProcesos.Rows[i]["tamanio_proceso"].ToString()), Convert.ToInt32(paginas_x_proceso), 0, dtProcesos.Rows[i]["color_proceso"].ToString());
                lstProcesos.Add(proceso);
            }
            //imprimo la lista para ver si esta guardando los elementos.
            if (lstProcesos.Count > 0)
            {
                foreach(Proceso p in lstProcesos)
                {
                    Console.WriteLine("Proceso: " + p.Id_proceso + " Proc:" + p.Nombre_proceso + " Tamaño: " + p.Tamanio_proceso + " Paginas: " + p.Numero_paginas_utilizar + " Color: " + p.Color);
                }
            }
        }

        private void Evento_Labels_Disco_Duro(object sender, EventArgs e)
        {
            Label etiqueta = (Label)sender;
            String id_proceso = etiqueta.Name;
            String nombre_proceso = "Proceso " + etiqueta.Name.Replace("P", "");    //quito la P y la reemplazo por nada para que solo me de el numero
            
            if (VerificarProcesosEjecucion(id_proceso) == false) //verifico si el proceso esta en la lista de procesos en ejecucion
            {
                if (ObtenerTamanioProceso(id_proceso) <= ObtenerEspacioLibre()) //verificar si hay espacio libre en la memoria ram
                {
                    //envio el proceso a la memoria RAM
                    EnviarProcesoARam(id_proceso);
                    //vuelvo a cargar los marcos en la RAM, con la nueva información
                    pnlMarcos.Controls.Clear();
                    CrearMarcosRAM();
                    //creo la lista de procesos en ejecucion
                    proceso_ejecucion = new Proceso_Ejecucion(id_proceso, nombre_proceso);
                    lstProcesosEnEjecucion.Add(proceso_ejecucion);
                    //agrego los elementos de la lista de procesos de ejecucion al listbox 
                    lbProcEjecucion.Items.Clear();
                    foreach (Proceso_Ejecucion proceso in lstProcesosEnEjecucion)
                    {
                        lbProcEjecucion.Items.Add(proceso);
                    }
                    //ahora mandar a cambiar el bit de validez en la tabla de paginas
                    foreach (Proceso p in lstProcesos)
                    {
                        if (p.Id_proceso.Equals(id_proceso)) //busco el bit de validez y lo cambio por 1, que signifca que pasa a ejecución
                        {
                            p.Proceso_utilizado = 1;
                            pnlTablaPaginas.Controls.Clear();   //limpio el panel de todo lo que contiene
                            CrearTablaDePaginas();  //Vuelvo a cargar el panel con la nueva información
                        }
                    }
                }
                else
                {
                    int contador_espera = 0;
                    //valido que no se agregue el elemento a la lista, para que no se repitan en la lista de procesos en espera
                    foreach (Proceso_Espera proceso_espera in lstProcesosEnEspera)
                    {
                        if (proceso_espera.Id_proceso.Equals(id_proceso))
                        {
                            agregar_elemento = false;
                            break;
                        }
                        contador_espera++;
                        if (contador_espera == lstProcesosEnEspera.Count)
                        {
                            agregar_elemento = true;
                            break;
                        }
                    }

                    if (agregar_elemento == true)    //si no existe el elemento en la lista de procesos en espera, que lo agregue
                    {
                        proceso_espera = new Proceso_Espera(id_proceso, nombre_proceso);
                        lstProcesosEnEspera.Add(proceso_espera);
                        lbProcEspera.Items.Clear();
                        foreach (Proceso_Espera proceso in lstProcesosEnEspera)
                        {
                            lbProcEspera.Items.Add(proceso);
                        }
                    }

                    MessageBox.Show("¡El proceso es demasiado grande para ejecutarse. Pulse intercambiar páginas para hacer Swap.!",
                            "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    btnIntercambiarPaginas.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show("El proceso se encuentra en ejecución. Seleccione un proceso que no se esté ejecutando.",
                    "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void EnviarProcesoARam(String id_proceso)
        {
            int espacio_a_utilizar = 0;
            decimal tamanio_pagina = Convert.ToDecimal(cbTamanioPagina.Text.Replace(" KB", ""));  //obtengo solo el valor numerico
            decimal tamanio_proceso = Convert.ToDecimal(ObtenerTamanioProceso(id_proceso));
            decimal paginas_x_proceso = Math.Ceiling(tamanio_proceso / tamanio_pagina); //aproximon al numero mayor
            espacio_a_utilizar = Convert.ToInt32(paginas_x_proceso);
            int contador = 0;
            //recorriendo el array de marcos para ver cuales estan libres
            foreach (Marco marco in lstMarcos)
            {
                if (marco.Estado_marco == 0) //sobreescribo la información del array de marcos
                {
                    marco.Estado_marco = 1;
                    marco.Id_proceso = id_proceso;
                    marco.Color_proceso = ObtenerColorProceso(id_proceso);
                    contador++;
                    //cuando haya escrito en todos los nodos, me salgo del ciclo.
                    if (contador == espacio_a_utilizar)
                    {
                        break;
                    }
                }
            }
        }

        public int ObtenerEspacioLibre()
        {
            int espacio_libre = 0;
            foreach(Marco marco in lstMarcos)
            {
                if(marco.Estado_marco == 0)
                {
                    espacio_libre = espacio_libre + marco.Tamanio_marco;
                }
            }

            return espacio_libre;
        }

        public int ObtenerTamanioProceso(String id_proceso)
        {
            int tamanio_proceso = 0;
            foreach(Proceso proceso in lstProcesos)
            {
                if(proceso.Id_proceso.Equals(id_proceso))
                {
                    tamanio_proceso = proceso.Tamanio_proceso;
                }
            }

            return tamanio_proceso;
        }

        public String ObtenerColorProceso(String id_proceso)
        {
            String color_proceso = "";
            foreach (Proceso proceso in lstProcesos)
            {
                if (proceso.Id_proceso.Equals(id_proceso))
                {
                    color_proceso = proceso.Color;
                }
            }

            return color_proceso;
        }

        public Boolean VerificarProcesosEjecucion(String id_proceso)
        {
            bool devuelve = false;

            foreach (Proceso_Ejecucion proceso in lstProcesosEnEjecucion)
            {
                if(proceso.Id_proceso.Equals(id_proceso))
                {
                    devuelve = true;    //si existe el proceso en la lista de procesos en ejecucion
                    break;
                }
            }

            return devuelve;
        }

        public void CrearTablaDePaginas()
        {
            alto_contenedor = pnlTablaPaginas.Height;
            ancho_contenedor = pnlTablaPaginas.Width;
            alto_etiqueta = alto_contenedor / cantidad_labels;
            ancho_etiqueta = ancho_contenedor;
            posicion_x = 0;
            posicion_y = 0;
            etiqueta_tabla_paginas = new Label[cantidad_labels];
            int i = 0;

            foreach (Proceso p in lstProcesos)
            {
                etiqueta_tabla_paginas[i] = new Label();
                etiqueta_tabla_paginas[i].Text = p.Nombre_proceso + Environment.NewLine + 
                    "valida: " + p.Proceso_utilizado;
                etiqueta_tabla_paginas[i].Font = new Font("Arial", etiqueta_tabla_paginas[i].Font.Size + 3, FontStyle.Bold);
                etiqueta_tabla_paginas[i].TextAlign = ContentAlignment.MiddleCenter;
                etiqueta_tabla_paginas[i].BorderStyle = BorderStyle.Fixed3D;
                etiqueta_tabla_paginas[i].SetBounds(posicion_x, posicion_y, ancho_etiqueta, alto_etiqueta);
                etiqueta_tabla_paginas[i].Show();

                pnlTablaPaginas.Controls.Add(etiqueta_tabla_paginas[i]);
                posicion_y = posicion_y + alto_etiqueta;
                i++;
            }
        }

        public void CrearMarcosRAM()
        {
            alto_contenedor = pnlMarcos.Height;
            ancho_contenedor = pnlMarcos.Width;
            ancho_etiqueta = ancho_contenedor;
            posicion_x = 0;
            posicion_y = 0;
            int tamanio_pagina = Convert.ToInt32(cbTamanioPagina.Text.Replace(" KB", ""));
            int cantidad_marcos = tamanio_ram / tamanio_pagina;
            alto_etiqueta = alto_contenedor / cantidad_marcos;
            etiqueta_marcos = new Label[cantidad_marcos];
            int j = 0;

            //creo una lista con elementos que van a ir vacíos.
            for(int i = 0; i < cantidad_marcos; i++)
            {
                if (lstMarcos.Count < cantidad_marcos)
                {
                    marco = new Marco(i, tamanio_pagina, 0, "", "");
                    lstMarcos.Add(marco);
                }
            }
            //creo las etiquetas para mostrar la memoria RAM
            foreach(Marco marco in lstMarcos)
            {
                etiqueta_marcos[j] = new Label();
                //etiqueta_marcos[j].Text = "Marco: " + marco.Numero_marco + Environment.NewLine +
                //    "Proceso: " + marco.Id_proceso;
                etiqueta_marcos[j].Text = marco.Numero_marco + Environment.NewLine +
                    marco.Id_proceso;
                etiqueta_marcos[j].BackColor = ColorTranslator.FromHtml(marco.Color_proceso);
                etiqueta_marcos[j].Font = new Font("Courier", etiqueta_marcos[j].Font.Size);
                etiqueta_marcos[j].TextAlign = ContentAlignment.BottomLeft;
                etiqueta_marcos[j].BorderStyle = BorderStyle.Fixed3D;
                etiqueta_marcos[j].SetBounds(posicion_x, posicion_y, ancho_etiqueta, alto_etiqueta);
                etiqueta_marcos[j].Show();
                pnlMarcos.Controls.Add(etiqueta_marcos[j]);
                posicion_y = posicion_y + alto_etiqueta;
                j++;
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            
        }

        private void gvProcesos_ValidatingEditor(object sender, DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs e)
        {
            if (gvProcesos.FocusedColumn.FieldName.Equals("tamanio_proceso"))
            {
                Int16 tamanio = 0;
                if(!Int16.TryParse(e.Value as String, out tamanio))
                {
                    e.Valid = false;
                    e.ErrorText = "Solo se acepta un valor numerico";
                }
            }
        }

        private void gvProcesos_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            GridColumn colTamanio = gvProcesos.Columns["tamanio_proceso"];

            if (gvProcesos.FocusedColumn.FieldName.Equals("tamanio_proceso"))
            {
                Int32 tamanio = Convert.ToInt32(gvProcesos.GetRowCellValue(gvProcesos.FocusedRowHandle, colTamanio));

                if (tamanio < 1 || tamanio > 40)
                {
                    //gvProcesos.SetColumnError(colTamanio, "El tamaño del proceso debe ser > a 0 o <= a 40");
                    e.ErrorText = "El tamaño del proceso debe ser > a 0 o <= a 40";
                    e.Valid = false;
                }
            }
        }

        private void btnCargarProcesos_Click(object sender, EventArgs e)
        {
            DialogResult dialogoOpcion = MessageBox.Show("¿Está seguro que el tamaño de los procesos son correctos?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogoOpcion == DialogResult.Yes)
            {
                CrearListaDeLabels();
                CrearTablaDePaginas();
                CrearMarcosRAM();
                gcProcesos.Enabled = false;
                btnCargarProcesos.Enabled = false;
                btnIntercambiarPaginas.Visible = true;
            }
        }
        //La siguiente función devuelve la cantidad de paginas que va a utilizar el proceso
        public int ObtieneEspacioUtilizadoProceso(String id_proceso)
        {
            int espacio_a_utilizar = 0;
            decimal tamanio_pagina = Convert.ToDecimal(cbTamanioPagina.Text.Replace(" KB", ""));  //obtengo solo el valor numerico
            decimal tamanio_proceso = Convert.ToDecimal(ObtenerTamanioProceso(id_proceso));
            decimal paginas_x_proceso = Math.Ceiling(tamanio_proceso / tamanio_pagina); //aproximon al numero mayor
            espacio_a_utilizar = Convert.ToInt32(paginas_x_proceso);

            return espacio_a_utilizar;
        }

        public void RealizarPaginacion()    //se cargan los procesos en espera, solo cuando no hayan marcos libres, o marcos insuficientes
        {
            String id_proceso_ejecucion = lstProcesosEnEjecucion[0].Id_proceso; //obtengo el primer elemento de la lista de procesos en ejecucion
            String id_proceso_espera = lstProcesosEnEspera[0].Id_proceso;  //obtengo el primer elemento de la lista de procesos en espera
            int cantidad_marcos_libres = ObtenerCantidadMarcosLibres();
            int cantidad_marcos_libres_proceso_espera = ObtenerCantidadMarcosLibresDeProceso(id_proceso_espera);
            //verifico si hay marcos libres para utilizarlos
            if (cantidad_marcos_libres > 0)
            {
                if (cantidad_marcos_libres_proceso_espera <= cantidad_marcos_libres)
                {
                    //entonces limpio el proceso mas antiguo que esta en ejecucion, y lo sustituyo por el proceso en espera
                    SustituirProcesoEjecucionXEspera(id_proceso_ejecucion, id_proceso_espera, cantidad_marcos_libres, cantidad_marcos_libres_proceso_espera);
                    //vuelvo a cargar los marcos en la RAM, con la nueva información
                    pnlMarcos.Controls.Clear();
                    CrearMarcosRAM();
                    ActualizarTablaDePaginas(id_proceso_ejecucion, id_proceso_espera);
                    pnlTablaPaginas.Controls.Clear();
                    CrearTablaDePaginas();
                    EliminarProcesoListaEjecucion(id_proceso_ejecucion);
                    EliminarProcesoListaEspera(id_proceso_espera);
                    AgregarProcesoListaEjecucion(id_proceso_espera);
                    CargarListasDeProcesos();
                }
                else if (cantidad_marcos_libres_proceso_espera > cantidad_marcos_libres)
                {
                    TerminarProcesoEnEjecucion(id_proceso_ejecucion);
                    pnlMarcos.Controls.Clear();
                    CrearMarcosRAM();
                    ActualizarTablaDePaginas(id_proceso_ejecucion, id_proceso_espera);
                    pnlTablaPaginas.Controls.Clear();
                    CrearTablaDePaginas();
                    EliminarProcesoListaEjecucion(id_proceso_ejecucion);
                    cantidad_marcos_libres = ObtenerCantidadMarcosLibres();
                    cantidad_marcos_libres_proceso_espera = ObtenerCantidadMarcosLibresDeProceso(id_proceso_espera);

                    if(cantidad_marcos_libres_proceso_espera > cantidad_marcos_libres)
                    {
                        DialogResult dialogoOpcion = MessageBox.Show("El proceso sigue siendo muy grande para ejecutarse. ¿Desea terminar el proceso siguiente?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dialogoOpcion == DialogResult.Yes)
                        {
                            id_proceso_ejecucion = lstProcesosEnEjecucion[0].Id_proceso;
                            id_proceso_espera = lstProcesosEnEspera[0].Id_proceso;
                            RealizarPaginacion();
                        }
                    }
                    else
                    {
                        CargarProcesoEnEspera(id_proceso_espera, cantidad_marcos_libres_proceso_espera);
                        pnlMarcos.Controls.Clear();
                        CrearMarcosRAM();
                        EliminarProcesoListaEspera(id_proceso_espera);
                        AgregarProcesoListaEjecucion(id_proceso_espera);
                        CargarListasDeProcesos();
                    }
                }
            }
            else if(cantidad_marcos_libres == 0)    //si no hay marcos libres
            {
                TerminarProcesoEnEjecucion(id_proceso_ejecucion);
                pnlMarcos.Controls.Clear();
                CrearMarcosRAM();
                ActualizarTablaDePaginas(id_proceso_ejecucion, id_proceso_espera);
                pnlTablaPaginas.Controls.Clear();
                CrearTablaDePaginas();
                EliminarProcesoListaEjecucion(id_proceso_ejecucion);
                cantidad_marcos_libres = ObtenerCantidadMarcosLibres();
                cantidad_marcos_libres_proceso_espera = ObtenerCantidadMarcosLibresDeProceso(id_proceso_espera);

                if (cantidad_marcos_libres_proceso_espera <= cantidad_marcos_libres)
                {
                    CargarProcesoEnEspera(id_proceso_espera, cantidad_marcos_libres_proceso_espera);
                    pnlMarcos.Controls.Clear();
                    CrearMarcosRAM();
                    EliminarProcesoListaEspera(id_proceso_espera);
                    AgregarProcesoListaEjecucion(id_proceso_espera);
                    CargarListasDeProcesos();
                }
                else if(cantidad_marcos_libres_proceso_espera > cantidad_marcos_libres)
                {
                    DialogResult dialogoOpcion = MessageBox.Show("El proceso sigue siendo muy grande para ejecutarse. ¿Desea terminar el proceso siguiente?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogoOpcion == DialogResult.Yes)
                    {
                        id_proceso_ejecucion = lstProcesosEnEjecucion[0].Id_proceso;
                        id_proceso_espera = lstProcesosEnEspera[0].Id_proceso;
                        RealizarPaginacion();
                    }
                }
            }
        }

        public int ObtenerCantidadMarcosLibres()
        {
            int total_marcos_libres = 0;
            foreach(Marco marco in lstMarcos)
            {
                if(marco.Id_proceso.Equals(""))
                {
                    total_marcos_libres = total_marcos_libres + 1;
                }
            }

            return total_marcos_libres;
        }

        public int ObtenerCantidadMarcosLibresDeProceso(String id_proceso)
        {
            int espacio_a_utilizar = 0;
            decimal tamanio_pagina = Convert.ToDecimal(cbTamanioPagina.Text.Replace(" KB", ""));  //obtengo solo el valor numerico
            decimal tamanio_proceso = Convert.ToDecimal(ObtenerTamanioProceso(id_proceso));
            decimal paginas_x_proceso = Math.Ceiling(tamanio_proceso / tamanio_pagina); //aproximon al numero mayor
            espacio_a_utilizar = Convert.ToInt32(paginas_x_proceso);

            return espacio_a_utilizar;
        }

        public void CargarProcesoEnEspera(String id_proceso_espera, int marcos_libres_espera)
        {
            int marcos_utilizados = 0;
            int marcos_faltantes = 0;

            foreach (Marco marco in lstMarcos)
            {
                if (marco.Id_proceso.Equals(""))
                {
                    foreach (Proceso_Espera proceso_espera in lstProcesosEnEspera)   //obtengo los datos del proceso en espera
                    {
                        if (proceso_espera.Id_proceso.Equals(id_proceso_espera))
                        {
                            marco.Id_proceso = proceso_espera.Id_proceso;
                            marco.Color_proceso = ObtenerColorProceso(id_proceso_espera);
                            marco.Estado_marco = 1;
                            marcos_utilizados = marcos_utilizados + 1;
                        }
                        if (marcos_utilizados == marcos_libres_espera)
                        {
                            break;
                        }
                    }
                }
                if (marcos_utilizados == marcos_libres_espera)
                {
                    break;
                }
            }
        }

        public void SustituirProcesoEjecucionXEspera(String id_proceso_ejecucion, String id_proceso_espera, int marcos_libres, int marcos_proceso_espera)
        {
            int marcos_utilizados = 0;
            int marcos_faltantes = 0;

            foreach (Marco marco in lstMarcos)
            {
                if (marco.Id_proceso.Equals(""))
                {
                    foreach (Proceso_Espera proceso_espera in lstProcesosEnEspera)   //obtengo los datos del proceso en espera
                    {
                        if (proceso_espera.Id_proceso.Equals(id_proceso_espera))
                        {
                            marco.Id_proceso = proceso_espera.Id_proceso;
                            marco.Color_proceso = ObtenerColorProceso(id_proceso_espera);
                            marco.Estado_marco = 1;
                            marcos_utilizados = marcos_utilizados + 1;
                        }
                        if (marcos_utilizados == marcos_libres)
                        {
                            break;
                        }
                    }
                }
                if (marcos_utilizados == marcos_libres)
                {
                    break;
                }
            }

            marcos_faltantes = marcos_proceso_espera - marcos_utilizados;
            if (marcos_faltantes > 0)
            {
                foreach (Marco marco in lstMarcos)
                {
                    if (marco.Id_proceso.Equals(id_proceso_ejecucion))  //primero agarra los marcos del procesos en ejecucion
                    {
                        foreach (Proceso_Espera proceso_espera in lstProcesosEnEspera)   //obtengo los datos del proceso en espera
                        {
                            if (proceso_espera.Id_proceso.Equals(id_proceso_espera))
                            {
                                marco.Id_proceso = proceso_espera.Id_proceso;
                                marco.Color_proceso = ObtenerColorProceso(id_proceso_espera);
                                marcos_faltantes = marcos_faltantes - 1;
                            }
                            if (marcos_faltantes == 0)
                            {
                                break;
                            }
                        }
                    }
                    if (marcos_faltantes == 0)
                    {
                        //quito el resto del proceso en ejecucion de la memoria ram
                        foreach (Marco marcos in lstMarcos)
                        {
                            if (marcos.Id_proceso.Equals(id_proceso_ejecucion))
                            {
                                marcos.Id_proceso = "";
                                marcos.Color_proceso = "";
                                marcos.Estado_marco = 0;
                            }
                        }
                        break;
                    }
                }
            }
        }

        public void EliminarProcesoListaEjecucion(String id_proceso_ejecucion)
        {
            foreach (Proceso_Ejecucion proceso_ejecucion in lstProcesosEnEjecucion)
            {
                if (proceso_ejecucion.Id_proceso.Equals(id_proceso_ejecucion))
                {
                    lstProcesosEnEjecucion.Remove(proceso_ejecucion);
                    break;
                }
            }
        }

        public void EliminarProcesoListaEspera(String id_proceso_espera)
        {
            foreach (Proceso_Espera proceso_espera in lstProcesosEnEspera)
            {
                if (proceso_espera.Id_proceso.Equals(id_proceso_espera))
                {
                    lstProcesosEnEspera.Remove(proceso_espera);
                    break;
                }
            }
        }

        public void ActualizarTablaDePaginas(String id_proceso_ejecucion, String id_proceso_espera)
        {
            foreach (Proceso proceso in lstProcesos)
            {
                if (proceso.Id_proceso.Equals(id_proceso_ejecucion)) //El proceso en ejecucion pasa a terminado
                {
                    proceso.Proceso_utilizado = 0;
                }
                if (proceso.Id_proceso.Equals(id_proceso_espera))    //El proceso en espera pasa a ejecucion
                {
                    proceso.Proceso_utilizado = 1;
                }
            }
        }

        public void CargarListasDeProcesos()
        {
            lbProcEjecucion.Items.Clear();
            lbProcEspera.Items.Clear();
            //cargo los procesos en ejecucion
            foreach (Proceso_Ejecucion proceso_ejecucion in lstProcesosEnEjecucion)
            {
                lbProcEjecucion.Items.Add(proceso_ejecucion);
            }
            //cargo los procesos en espera
            foreach (Proceso_Espera proceso_espera in lstProcesosEnEspera)
            {
                lbProcEspera.Items.Add(proceso_espera);
            }
        }

        public void TerminarProcesoEnEjecucion(String id_proceso_ejecucion)
        {
            foreach(Marco marco in lstMarcos)
            {
                if(marco.Id_proceso.Equals(id_proceso_ejecucion))
                {
                    marco.Id_proceso = "";
                    marco.Color_proceso = "";
                    marco.Estado_marco = 0;
                }
            }
        }

        public void AgregarProcesoListaEjecucion(String id_proceso_espera)
        {
            String nombre_proceso = "";
            //busco el nombre del proceso que estaba en espera
            foreach (Proceso proceso in lstProcesos)
            {
                if (proceso.Id_proceso.Equals(id_proceso_espera))
                {
                    nombre_proceso = proceso.Nombre_proceso;
                    break;
                }
            }
            //agrego el proceso que estaba en espera, a la lista de procesos en ejecucion
            Proceso_Ejecucion proceso_ejecucion = new Proceso_Ejecucion(id_proceso_espera, nombre_proceso);
            lstProcesosEnEjecucion.Add(proceso_ejecucion);
        }

        private void btnIntercambiarPaginas_Click(object sender, EventArgs e)
        {
            RealizarPaginacion();
        }

        private void btnTamanio_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                int numero_filas = 0;
                if (!txtNumeroProcesos.Text.Trim().Equals("") && !cbTamanioPagina.Text.Equals(""))
                {
                    numero_filas = Convert.ToInt16(txtNumeroProcesos.Text.Trim());
                    CrearColumnas();
                    AgregarFilas(numero_filas);
                    gcProcesos.DataSource = dtProcesos;
                    //modificando las propiedades del gridcontrol despues de ser cargado
                    gcProcesos.Visible = true;
                    gvProcesos.Columns[0].Width = 40;
                    gvProcesos.Columns[1].Width = 175;
                    gvProcesos.Columns[2].Width = 175;
                    txtNumeroProcesos.Enabled = false;
                    cbTamanioPagina.Enabled = false;
                    btnCargarProcesos.Visible = true;
                    btnTamanio.Enabled = false;
                }
                else
                {
                    MessageBox.Show(null, "¡Debe llenar los campos solicitados!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(null, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }
    }
}