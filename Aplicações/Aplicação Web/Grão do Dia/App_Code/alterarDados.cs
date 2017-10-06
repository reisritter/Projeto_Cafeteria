using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace cafeteria
{

public class alterarDados
{
		public static int alterarSenha(string senhaAnt, string senhaN, string usuario, string senha)
        {
            Conexao conn = new Conexao();
            string sqlSenhaNVerificar="select count(*) from Login_ where usuario=@usuario and senha=@senhaA";
            string sqlSenhaNAlterar = "update Login_ set senha=@senhaN where usuario=@usuario and senha=@senha";
            int retornoSenhaN;
            conn.conectar();

            conn.command.CommandText=sqlSenhaNVerificar;

            conn.command.Parameters.Add("@usuario",SqlDbType.VarChar).Value=usuario;
            conn.command.Parameters.Add("@senhaA",SqlDbType.VarChar).Value=senhaAnt;

            int retornoSenha =(int)conn.command.ExecuteScalar();

            if(retornoSenha>0)
            {
                conn.conectar();

                conn.command.CommandText=sqlSenhaNAlterar;

                conn.command.Parameters.Add("@usuario",SqlDbType.VarChar).Value=usuario;
                conn.command.Parameters.Add("@senha",SqlDbType.VarChar).Value=senha;
                conn.command.Parameters.Add("@senhaN",SqlDbType.VarChar).Value=senhaN;

                retornoSenhaN = conn.command.ExecuteNonQuery();
            }
            else
            {
                retornoSenhaN=0;
            }
            conn.fechaConexao();
            return retornoSenhaN;
        }

       
        public static int alterarDCadastrais(string nome, string email, string telefone, string usuario)
        {

            Conexao conn = new Conexao();

            string SqlUpdDados = "update cliente set email=@email, nome=@nome, telefone=@telefone from Cliente c inner join Login_ l on l.id_login=c.id_login where l.usuario=@usuario";

            conn.conectar();

            conn.command.CommandText = SqlUpdDados;

            conn.command.Parameters.Add("@email", SqlDbType.VarChar).Value = email;
            conn.command.Parameters.Add("@nome", SqlDbType.VarChar).Value = nome;
            conn.command.Parameters.Add("@telefone", SqlDbType.VarChar).Value = telefone;
            conn.command.Parameters.Add("@usuario", SqlDbType.VarChar).Value = usuario;

            int retornoAlt = conn.command.ExecuteNonQuery();


            conn.fechaConexao();
            return retornoAlt;




        }
        public static int alterarDCadastraisF(string nome, string email, string telefone, string usuario)
        {

            Conexao conn = new Conexao();

            string SqlUpdDados = "update Funcionario set email=@email, nome=@nome, telefone=@telefone from Funcionario c inner join Login_ l on l.id_login=c.id_login where l.usuario=@usuario and l.senha=@senha";

            conn.conectar();

            conn.command.CommandText = SqlUpdDados;

            conn.command.Parameters.Add("@email", SqlDbType.VarChar).Value = email;
            conn.command.Parameters.Add("@nome", SqlDbType.VarChar).Value = nome;
            conn.command.Parameters.Add("@telefone", SqlDbType.VarChar).Value = telefone;
            conn.command.Parameters.Add("@usuario", SqlDbType.VarChar).Value = usuario;


            int retornoAlt = conn.command.ExecuteNonQuery();


            conn.fechaConexao();
            return retornoAlt;




        }


}
}