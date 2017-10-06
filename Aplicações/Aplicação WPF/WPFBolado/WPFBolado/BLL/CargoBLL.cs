using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFBolado.DTO;
using System.Windows.Controls;
using System.Data;
using System.Data.SqlClient;

namespace WPFBolado.BLL
{
    class CargoBLL
    {
        Acesso bd = new Acesso();
        DataTable dt;
        SqlDataAdapter da;

        public string SelecionarPermissao(LoginDTO dto)
        {
            string ret = "";

            try
            {
                bd.Conectar();
                bd.comm.CommandText = "Select c.permissao from Funcionario f inner join Cargo c on c.id_cargo = f.id_cargo and f.id_login = @id";
                bd.comm.Parameters.AddWithValue("@id",dto.Id);
                dt = new DataTable();
                da = new SqlDataAdapter(bd.comm);
                da.Fill(dt);
                try
                {
                    ret = dt.Rows[0]["permissao"].ToString();
                }
                catch (Exception ex)
                {
                    ret = "";
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                bd.Fechar();
            }

            return ret;
        }

        public DataTable SelecionarNome(ComboBox cmb)
        {
            try
            {
                bd.Conectar();
                bd.comm.CommandText = "Select id_cargo,descricao from Cargo";
                dt = new DataTable();
                da = new SqlDataAdapter(bd.comm);
                da.Fill(dt);
                cmb.DataContext = dt;
                cmb.SelectedValuePath = "id_cargo";
                cmb.DisplayMemberPath = "descricao";
                bd.comm.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw new Exception("Erro no cargo : " + ex.Message);
            }
            finally
            {
                bd.Fechar();
            }

            return dt;
        }
    }
}
