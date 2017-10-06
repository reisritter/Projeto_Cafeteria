using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFBolado.DTO
{
    class PedidoDTO
    {
        private int id;
        private DateTime data;
        private DateTime hora;
        private int id_caixa;
        private int id_func;

        public DateTime Data
        {
            get
            {
                return data;
            }

            set
            {
                data = value;
            }
        }

        public DateTime Hora
        {
            get
            {
                return hora;
            }

            set
            {
                hora = value;
            }
        }

        public int Id_caixa
        {
            get
            {
                return id_caixa;
            }

            set
            {
                id_caixa = value;
            }
        }

        public int Id_func
        {
            get
            {
                return id_func;
            }

            set
            {
                id_func = value;
            }
        }

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }
    }
}
