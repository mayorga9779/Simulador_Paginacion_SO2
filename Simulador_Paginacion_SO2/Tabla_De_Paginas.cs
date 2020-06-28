using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulador_Paginacion_SO2
{
    class Tabla_De_Paginas
    {
        private String id_proceso = "";
        private String nombre_proceso = "";
        private String numero_pagina = "";
        private String numero_marco = "";
        private int bit_validez = 0;    //0 no esta la pagina en el marco, 1 la pagina esta en el marco

        public Tabla_De_Paginas()
        {

        }

        public Tabla_De_Paginas(String id_proceso, String nombre_proceso, String numero_pagina, String numero_marco, int bit_validez)
        {
            Id_proceso = id_proceso;
            Nombre_proceso = nombre_proceso;
            Numero_pagina = numero_pagina;
            Numero_marco = numero_marco;
            Bit_validez = bit_validez;
        }

        public string Numero_pagina
        {
            get
            {
                return numero_pagina;
            }

            set
            {
                numero_pagina = value;
            }
        }

        public string Numero_marco
        {
            get
            {
                return numero_marco;
            }

            set
            {
                numero_marco = value;
            }
        }

        public int Bit_validez
        {
            get
            {
                return bit_validez;
            }

            set
            {
                bit_validez = value;
            }
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
