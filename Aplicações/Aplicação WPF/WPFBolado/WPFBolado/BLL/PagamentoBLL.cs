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
    class PagamentoBLL
    {
        Acesso bd = new Acesso();
        DataTable dt;
        SqlDataAdapter da;        

        public void inserir(PedidoDTO peDto, PagamentoDTO paDto)
        {
            try
            {
                bd.Conectar();
                bd.comm.CommandText = "insert into Pedido_Pagamento values(@id_pagamento,@id_pedido,@valor)";
                bd.comm.Parameters.AddWithValue("@id_pagamento",paDto.Id);
                bd.comm.Parameters.AddWithValue("@id_pedido",peDto.Id);
                bd.comm.Parameters.AddWithValue("@valor",paDto.Valor);
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
