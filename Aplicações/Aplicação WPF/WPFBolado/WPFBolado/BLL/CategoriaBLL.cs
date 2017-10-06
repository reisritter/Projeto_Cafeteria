using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Controls;
using WPFBolado.DTO;

namespace WPFBolado.BLL
{
    class CategoriaBLL
    {
        Acesso bd = new Acesso();
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
                cb.DataContext = dt;
                cb.SelectedValuePath = "id_categoria";
                cb.DisplayMemberPath = "descricao";
                
            }
            catch (SqlException ex)
            {
                throw new Exception("Erro no carregamento de dados de categoria : " + ex.Message);
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
                bd.comm.Parameters.AddWithValue("@descricao", dto.Nome);
                ret = Convert.ToInt32(bd.comm.ExecuteScalar());
            }
            catch (SqlException ex)
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
