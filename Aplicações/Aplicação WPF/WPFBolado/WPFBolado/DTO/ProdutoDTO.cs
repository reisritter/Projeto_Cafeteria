using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFBolado.DTO
{
    class ProdutoDTO
    {
        private int id;
        private string nome;
        private decimal preco;
        private string status;
        private string tipo;
        private string foto;

        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }

        public string Status
        {
            get { return status; }
            set { status = value; }
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public decimal Preco
        {
            get { return preco; }
            set { preco = value; }
        }

        public string Foto
        {
            get
            {
                return foto;
            }

            set
            {
                foto = value;
            }
        }
    }
}
