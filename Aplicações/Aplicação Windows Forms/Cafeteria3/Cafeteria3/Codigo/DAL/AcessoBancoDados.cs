using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Cafeteria3.Codigo.DAL
{
    class AcessoBancoDados
    {
        string strCon = "Server=localhost;DataBase=Cafeteria;user id=sa;password=senha123";
        SqlConnection conn;
        public SqlCommand comm ;       
                        

        public void Conectar()
        {                        
            try 
            {
                conn = new SqlConnection(strCon);
                comm = new SqlCommand();
                comm.Connection = conn;
                conn.Open();
            }
            catch(SqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Fechar()
        {
            conn.Close();
            conn = null;
            comm = null;
        }                     
    }
}
