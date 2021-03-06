﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cafeteria3.Codigo.DAL;
using Cafeteria3.Codigo.BLL;
using Cafeteria3.Codigo.DTO;
using System.Data;
using System.Data.SqlClient;

namespace Cafeteria3.Codigo.BLL
{
    class LoginBLL
    {
        AcessoBancoDados bd = new AcessoBancoDados();
        //DataTable dt;
        //SqlDataAdapter da;

        public int Selecionar(LoginDTO dto)
        {
            try 
            {
                bd.Conectar();
                bd.comm.CommandText = "Select id_login from login_ where usuario=@usuario and senha=@senha and tipo='func'";
                bd.comm.Parameters.AddWithValue("@usuario",dto.Usuario);
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
            catch(SqlException ex)
            {
                throw new Exception("Erro no login : "+ex.Message);
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
                bd.comm.CommandText = "insert into Login_ values(@usuario,@senha,'func')";
                bd.comm.Parameters.AddWithValue("@usuario",dto.Usuario);
                bd.comm.Parameters.AddWithValue("senha",dto.Senha);
                bd.comm.ExecuteNonQuery();
            }
            catch(SqlException ex)
            {
                throw new Exception("Erro no login : "+ex.Message);
            }
            finally
            {
                bd.Fechar();
            }
        }
    }
}
