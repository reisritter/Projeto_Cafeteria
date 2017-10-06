using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFBolado.DTO;
using System.Data;
using System.Data.SqlClient;

namespace WPFBolado.BLL
{    
    class PedidoBLL
    {
        Acesso bd = new Acesso();
        SqlDataAdapter da;
        DataTable dt;

        public int selecionarId()
        {
            int ret = 0;

            try
            {
                bd.Conectar();
                bd.comm.CommandText = "select top 1 id_pedido from pedido order by data_pedido desc,hora_pedido desc";
                ret = (int)bd.comm.ExecuteScalar();
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                bd.Fechar();
            }

            return ret;
        }

        public void Inserir(PedidoDTO dto)
        {
            try
            {
                bd.Conectar();
                bd.comm.CommandText = "Insert into Pedido values(convert(varchar, getdate(), 108),convert(varchar,GETDATE(),103),@id_caixa,@id_func)";
                bd.comm.Parameters.AddWithValue("@id_caixa",dto.Id_caixa);
                bd.comm.Parameters.AddWithValue("@id_func",dto.Id_func);
                bd.comm.ExecuteNonQuery();

            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                bd.Fechar();
            }
        }


        public DataTable SelecionarTudo()
        {
            try
            {
                bd.Conectar();
                bd.comm.CommandText = "Select * from Pedido";
                dt = new DataTable();
                da = new SqlDataAdapter(bd.comm);
                da.Fill(dt);
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                bd.Fechar();
            }

            return dt;
        }
    }
}
