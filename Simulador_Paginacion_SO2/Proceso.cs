using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulador_Paginacion_SO2
{
    class Proceso
    {
        private String id_proceso = "";
        private String nombre_proceso = "";
        private int tamanio_proceso = 0;
        private int numero_paginas_utilizar = 0;
        private int proceso_utilizado = 0;
        private String color = "";

        public Proceso()
        {

        }

        public Proceso(String id_proceso, String nombre_proceso, int tamanio_proceso, int numero_paginas_utilizar, int proceso_utilizado, String color)
        {
            Id_proceso = id_proceso;
            Nombre_proceso = nombre_proceso;
            Tamanio_proceso = tamanio_proceso;
            Numero_paginas_utilizar = numero_paginas_utilizar;
            Proceso_utilizado = proceso_utilizado;
            Color = color;
        }

        public string Id_proceso
        {
            get
            {
                return id_proceso;
            }

            set
            {
                id_proceso = value;
            }
        }

        public string Nombre_proceso
        {
            get
            {
                return nombre_proceso;
            }

            set
            {
                nombre_proceso = value;
            }
        }

        public int Tamanio_proceso
        {
            get
            {
                return tamanio_proceso;
            }

            set
            {
                tamanio_proceso = value;
            }
        }

        public int Numero_paginas_utilizar
        {
            get
            {
                return numero_paginas_utilizar;
            }

            set
            {
                numero_paginas_utilizar = value;
            }
        }

        public string Color
        {
            get
            {
                return color;
            }

            set
            {
                color = value;
            }
        }

        public int Proceso_utilizado
        {
            get
            {
                return proceso_utilizado;
            }

            set
            {
                proceso_utilizado = value;
            }
        }
    }
}
