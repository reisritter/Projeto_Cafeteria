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
    class CaixaBLL
    {
        Acesso bd = new Acesso();
        DataTable dt;
        SqlDataAdapter da;

        public string SelecionarFunc(LoginDTO dto)
        {
            string nome = "";

            try
            {
                bd.Conectar();
                bd.comm.CommandText = "select f.nome from Funcionario f inner join login_ l on f.id_login = l.id_login and l.id_login = @id";
                bd.comm.Parameters.AddWithValue("@id",dto.Id);
                dt = new DataTable();
                da = new SqlDataAdapter(bd.comm);
                da.Fill(dt);

                nome = dt.Rows[0]["nome"].ToString();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                bd.Fechar();
            }

            return nome;
        }

        public void Inserir(CaixaDTO cDTO,FuncionarioDTO fDTO)
        {
            try
            {
                bd.Conectar();
                bd.comm.CommandText = "insert into Caixa(data_abertura,hora_abertura,saldo_inicial,id_funcionario) values(GETDATE(),Convert(varchar,GetDate(),108),@saldo,@idFunc)";
                bd.comm.Parameters.AddWithValue("@saldo",cDTO.SaldoInicial);
                bd.comm.Parameters.AddWithValue("@idFunc",fDTO.Id);
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

        public int SelecionarId()
        {
            int ret = 0;

            try
            {
                bd.Conectar();
                bd.comm.CommandText = "Select top 1 id_caixa from Caixa order by data_abertura desc, hora_abertura desc";
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

        public void UpdateData(CaixaDTO cDTO)
        {
            try
            {
                bd.Conectar();
                bd.comm.CommandText = "Update Caixa set data_fechamento= GETDATE(),hora_fechamento= convert(varchar,GETDATE(),108) where id_caixa = @id";                
                bd.comm.Parameters.AddWithValue("@id",cDTO.Id);
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
