using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFBolado.DTO;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Controls;

namespace WPFBolado.BLL
{
    class LoginBLL
    {
        Acesso bd = new Acesso();
        DataTable dt;
        SqlDataAdapter da;

        public string selecionarSenha(LoginDTO dto)
        {
            string ret = "";

            try
            {
                bd.Conectar();
                bd.comm.CommandText = "select senha from login_ where id_login = @id";
                bd.comm.Parameters.AddWithValue("@id",dto.Id);
                dt = new DataTable();
                da = new SqlDataAdapter(bd.comm);
                da.Fill(dt);
                ret = dt.Rows[0]["senha"].ToString();
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

        public void updateSemUser(LoginDTO dto)
        {
            try
            {
                bd.Conectar();
                bd.comm.CommandText = "Update login_ set senha = @senha , lembrete = @lembrete where id_login = @id";                
                bd.comm.Parameters.AddWithValue("@lembrete", dto.Lembrete);
                bd.comm.Parameters.AddWithValue("@senha", dto.Senha);
                bd.comm.Parameters.AddWithValue("@id", dto.Id);
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

        public void update(LoginDTO dto)
        {
            try
            {
                bd.Conectar();
                bd.comm.CommandText = "Update login_ set usuario = @usuario , senha = @senha , lembrete = @lembrete where id_login = @id";
                bd.comm.Parameters.AddWithValue("@usuario",dto.Usuario);
                bd.comm.Parameters.AddWithValue("@lembrete",dto.Lembrete);
                bd.comm.Parameters.AddWithValue("@senha",dto.Senha);
                bd.comm.Parameters.AddWithValue("@id",dto.Id);
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

        public int ProcurarLogin(TextBox txt, string nome)
        {
            int ret = 0;
            try
            {
                bd.Conectar();
                bd.comm.CommandText = "Select id_login from login_ where " + nome + " = @nome";
                bd.comm.Parameters.AddWithValue("@nome", txt.Text);
                ret = Convert.ToInt32(bd.comm.ExecuteScalar());
            }
            catch (SqlException ex)
            {
                throw new Exception("Erro na procura : " + ex.Message);
            }
            finally
            {
                bd.Fechar();
            }

            return ret;
        }

        public int SelecionarIdporNome(LoginDTO dto)
        {
            int ret = 0;

            try
            {
                bd.Conectar();
                bd.comm.CommandText = "select id_login from login_ where usuario = @nome and senha = @senha";
                bd.comm.Parameters.AddWithValue("@nome", dto.Usuario);
                bd.comm.Parameters.AddWithValue("@senha", dto.Senha);
                dt = new DataTable();
                da = new SqlDataAdapter(bd.comm);
                da.Fill(dt);

                ret = Convert.ToInt16(dt.Rows[0]["id_login"].ToString());
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

        public int SelecionarId()
        {
            int ret = 0;

            try
            {
                bd.Conectar();
                bd.comm.CommandText = "select top 1 id_login from login_ order by id_login desc";
                dt = new DataTable();
                da = new SqlDataAdapter(bd.comm);
                da.Fill(dt);

                ret = Convert.ToInt16(dt.Rows[0]["id_login"].ToString());

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

        public int Selecionar(LoginDTO dto)
        {
            try
            {
                bd.Conectar();
                bd.comm.CommandText = "Select id_login from login_ where usuario=@usuario and senha=@senha and tipo='func'";
                bd.comm.Parameters.AddWithValue("@usuario", dto.Usuario);
                bd.comm.Parameters.AddWithValue("@senha", dto.Senha);
                int ret = 0;                
                try
                {
                    ret = (int)bd.comm.ExecuteScalar();
                }
                catch (Exception ex)
                {
                    ret = 0;
                    ex.ToString();
                }

                return ret;
            }
            catch (SqlException ex)
            {
                throw new Exception("Erro no login : " + ex.Message);
            }
            finally
            {
                bd.Fechar();
            }
        }       

        public void Inserir(LoginDTO dto)
        {
            try
            {
                bd.Conectar();
                bd.comm.CommandText = "insert into Login_ values(@usuario,@senha,'func',@lembrete)";
                bd.comm.Parameters.AddWithValue("@usuario", dto.Usuario);
                bd.comm.Parameters.AddWithValue("senha", dto.Senha);
                bd.comm.Parameters.AddWithValue("@lembrete",dto.Lembrete);
                bd.comm.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw new Exception("Erro no login : " + ex.Message);
            }
            finally
            {
                bd.Fechar();
            }
        }
    }
}
