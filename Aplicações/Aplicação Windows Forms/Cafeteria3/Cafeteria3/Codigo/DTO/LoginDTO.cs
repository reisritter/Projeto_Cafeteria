using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafeteria3.Codigo.DTO
{
    class LoginDTO
    {
        private int id;        
        private string usuario;
        private string status;
        private string senha;

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

        public string Status
        {
            get { return status; }
            set { status = value; }
        }
    }
}
