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
    class MovimentacaoBLL
    {
        Acesso bd = new Acesso();
        DataTable dt;
        SqlDataAdapter da;

        public int selecionarId()
        {
            int ret = 0;

            try
            {
                bd.Conectar();
                bd.comm.CommandText = "Select top 1 id_movimentacao from movimentacao order by data desc, hora desc";
                ret = (int)bd.comm.ExecuteScalar();
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

        public void Inserir(MovimentacaoDTO mDTO,CaixaDTO cDTO)
        {
            try
            {
                bd.Conectar();
                bd.comm.CommandText = "insert into Movimentacao values(convert(varchar,getdate(),3),convert(varchar,getdate(),108),@valor,@descricao,@tipo,@id_caixa)";
                bd.comm.Parameters.AddWithValue("@valor",mDTO.Valor);
                bd.comm.Parameters.AddWithValue("@descricao",mDTO.Descricao);
                bd.comm.Parameters.AddWithValue("@tipo",mDTO.Tipo);
                bd.comm.Parameters.AddWithValue("@id_caixa",cDTO.Id);
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

        public DataTable selecionarMov(CaixaDTO cDTO)
        {
            try
            {
                bd.Conectar();
                bd.comm.CommandText = "Select convert(varchar,data,103) as Data, hora as Hora, descricao as Descricao,valor as Valor,tipo as Tipo from Movimentacao where id_caixa = @id";
                bd.comm.Parameters.AddWithValue("@id",cDTO.Id);
                dt = new DataTable();
                da = new SqlDataAdapter(bd.comm);
                da.Fill(dt);
            }
            catch (Exception ex)
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
