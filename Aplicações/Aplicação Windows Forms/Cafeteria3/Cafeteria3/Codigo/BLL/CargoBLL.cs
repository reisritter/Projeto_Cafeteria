using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cafeteria3.Codigo.DAL;
using Cafeteria3.Codigo.DTO;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace Cafeteria3.Codigo.BLL
{
    class CargoBLL
    {
        AcessoBancoDados bd = new AcessoBancoDados();
        DataTable dt;
        SqlDataAdapter da;

        public DataTable SelecionarNome(ComboBox cmb) 
        {
            try 
            {
                bd.Conectar();
                bd.comm.CommandText = "Select id_cargo,descricao from Cargo";
                dt = new DataTable();
                da = new SqlDataAdapter(bd.comm);
                da.Fill(dt);
                cmb.DataSource = dt;
                cmb.ValueMember = "id_cargo";
                cmb.DisplayMember = "descricao";
                bd.comm.ExecuteNonQuery();
            }
            catch(SqlException ex)
            {
                throw new Exception("Erro no cargo : "+ex.Message);
            }
            finally
            {
                bd.Fechar();
            }

            return dt;
        }
    }
}
