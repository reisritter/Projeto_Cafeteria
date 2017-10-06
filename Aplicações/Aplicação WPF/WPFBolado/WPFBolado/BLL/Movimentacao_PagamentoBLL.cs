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
    class Movimentacao_PagamentoBLL
    {
        Acesso bd = new Acesso();
        DataTable dt;
        SqlDataAdapter da;        

        public void inserir(MovimentacaoDTO mDTO,PagamentoDTO pDTO)
        {
            try
            {
                bd.Conectar();
                bd.comm.CommandText = "insert into Movimentacao_Pagamento values(@id_movimentacao,@id_pagamento,@valor)";
                bd.comm.Parameters.AddWithValue("@id_movimentacao",mDTO.Id);
                bd.comm.Parameters.AddWithValue("@id_pagamento",pDTO.Id);
                bd.comm.Parameters.AddWithValue("@valor",pDTO.Valor);
                bd.comm.ExecuteNonQuery();
            }
            catch (Exception ex)
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
