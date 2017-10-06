using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFBolado.DTO
{
    class CargoDTO
    {        
        private int id;
        private string permissao;
        private string descricao;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }

        public string Permissao
        {
            get { return permissao; }
            set { permissao = value; }
        }
    }
}
