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
    class ProdPedidoBLL
    {
        Acesso bd = new Acesso();
        DataTable dt;
        SqlDataAdapter da;

        public void Inserir(ProdPedido ppDto,PedidoDTO peDto,ProdutoDTO proDto)
        {
            try
            {
                bd.Conectar();
                bd.comm.CommandText = "insert into Pedido_Produto values(@id_pedido,@id_produto,@preco,@qtde)";
                bd.comm.Parameters.AddWithValue("@id_pedido",peDto.Id);
                bd.comm.Parameters.AddWithValue("@id_produto",proDto.Id);
                bd.comm.Parameters.AddWithValue("@preco",ppDto.Preco);
                bd.comm.Parameters.AddWithValue("@qtde",ppDto.Qtd);
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
    }
}
