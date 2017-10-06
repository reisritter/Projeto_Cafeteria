using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFBolado.DTO
{
    class ProdPedido
    {
        private int id;
        private string nome;
        decimal preco;
        int qtd;
        decimal subtotal;        

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

        public string Nome
        {
            get
            {
                return nome;
            }

            set
            {
                nome = value;
            }
        }

        public decimal Preco
        {
            get
            {
                return preco;
            }

            set
            {
                preco = value;
            }
        }

        public int Qtd
        {
            get
            {
                return qtd;
            }

            set
            {
                qtd = value;
            }
        }

        public decimal Subtotal
        {
            get
            {
                return subtotal;
            }

            set
            {
                subtotal = value;
            }
        }
    }
}
