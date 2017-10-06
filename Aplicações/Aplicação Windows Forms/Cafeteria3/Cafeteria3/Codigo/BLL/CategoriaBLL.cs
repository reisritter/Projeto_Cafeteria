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
    class CategoriaBLL
    {
        AcessoBancoDados bd = new AcessoBancoDados();
        DataTable dt;
        SqlDataAdapter da;

        public void Carregar(ComboBox cb) 
        {            
            try
            {
                bd.Conectar();
                bd.comm.CommandText = "Select * from Categoria";
                dt = new DataTable();
                da = new SqlDataAdapter(bd.comm);
                da.Fill(dt);
                cb.DataSource = dt;
                cb.ValueMember ="id_categoria";
                cb.DisplayMember = "descricao";
                cb.Refresh();                

            }
            catch(SqlException ex)
            {
                throw new Exception("Erro no carregamento de dados de categoria : "+ex.Message);
            }
            finally
            {
                bd.Fechar();
                cb.SelectedIndex = -1;
            }
        }

        public int SelecionarId(CategoriaDTO dto) 
        {
            int ret = 0;

            try 
            {
                bd.Conectar();
                bd.comm.CommandText = "select id_categoria from Categoria where descricao = @descricao";
                bd.comm.Parameters.AddWithValue("@descricao",dto.Nome);
                ret = Convert.ToInt32(bd.comm.ExecuteScalar());
            }
            catch(SqlException ex)
            {
                throw new Exception("Erro na categoria : " + ex.Message);
            }
            finally
            {
                bd.Fechar();
            }

            return ret;
        }

    }
}
