using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulador_Paginacion_SO2
{
    class Marco
    {
        private int numero_marco = 0;
        private int tamanio_marco = 0;
        private int estado_marco = 0;
        private String id_proceso = "";
        private String color_proceso = "";

        public Marco(int numero_marco, int tamanio_marco, int estado_marco, String id_proceso, String color_proceso)
        {
            Numero_marco = numero_marco;
            Tamanio_marco = tamanio_marco;
            Estado_marco = estado_marco;
            Id_proceso = id_proceso;
            Color_proceso = color_proceso;
        }

        public int Numero_marco
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

        public int Tamanio_marco
        {
            get
            {
                return tamanio_marco;
            }

            set
            {
                tamanio_marco = value;
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

        public string Color_proceso
        {
            get
            {
                return color_proceso;
            }

            set
            {
                color_proceso = value;
            }
        }

        public int Estado_marco
        {
            get
            {
                return estado_marco;
            }

            set
            {
                estado_marco = value;
            }
        }
    }
}
