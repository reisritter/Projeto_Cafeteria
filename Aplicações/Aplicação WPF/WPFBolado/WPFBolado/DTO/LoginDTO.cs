using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFBolado.DTO
{
    class LoginDTO
    {
        private int id;
        private string usuario;
        private string tipo;
        private string senha;
        private string lembrete;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }

        public string Senha
        {
            get { return senha; }
            set { senha = value; }
        }

        public string Tipo
        {
            get
            {
                return tipo;
            }

            set
            {
                tipo = value;
            }
        }

        public string Lembrete
        {
            get
            {
                return lembrete;
            }

            set
            {
                lembrete = value;
            }
        }
    }
}
