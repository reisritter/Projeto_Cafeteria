using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafeteria3.Codigo.DTO
{
    class FuncionarioDTO
    {
        private string nome;
        private string cpf;
        private string telefone;
        private string email;
        private string endereco;
        private string cidade;
        private string bairro;
        private string uf;
        private string complemento;
        private string numero;
        private string cep;
        private int id;                
        private DateTime dt_Nascimento;


        public DateTime Dt_Nascimento
        {
            get { return dt_Nascimento; }
            set { dt_Nascimento = value; }
        }        

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        
        public string Cpf
        {
            get { return cpf; }
            set { cpf = value; }
        }
       
        public string Telefone
        {
            get { return telefone; }
            set { telefone = value; }
        }
        
        public string Email
        {
            get { return email; }
            set { email = value; }
        }        

        public string Endereco
        {
            get { return endereco; }
            set { endereco = value; }
        }
        
        public string Cidade
        {
            get { return cidade; }
            set { cidade = value; }
        }
        
        public string Bairro
        {
            get { return bairro; }
            set { bairro = value; }
        }
        
        public string Uf
        {
            get { return uf; }
            set { uf = value; }
        }
        
        public string Complemento
        {
            get { return complemento; }
            set { complemento = value; }
        }
        
        public string Numero
        {
            get { return numero; }
            set { numero = value; }
        }
        
        public string Cep
        {
            get { return cep; }
            set { cep = value; }
        }
        
        public int Id
        {
            get { return id; }
            set { id = value; }
        }               
    }
}
