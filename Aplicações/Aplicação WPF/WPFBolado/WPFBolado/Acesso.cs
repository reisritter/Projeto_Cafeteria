using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace WPFBolado
{
    class Acesso
    {
        string conectionString = ConfigurationManager.ConnectionStrings["a"].ToString();
        public SqlConnection con;
        public SqlCommand comm;

        public void Conectar()
        {
            try
            {
                con = new SqlConnection(conectionString);
                comm = new SqlCommand();
                comm.Connection = con;
                con.Open();
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                
            }
        }

        public void Fechar()
        {
            con.Close();
        }
    }
}
