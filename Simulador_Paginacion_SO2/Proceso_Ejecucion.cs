using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulador_Paginacion_SO2
{
    class Proceso_Ejecucion
    {
        private String id_proceso = "";
        private String nombre_proceso = "";

        public Proceso_Ejecucion(String id_proceso, String nombre_proceso)
        {
            Id_proceso = id_proceso;
            Nombre_proceso = nombre_proceso;
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
    }
}
