using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace cadastrado
{

    public static class ValidaUsernameCpf
    {
        public static bool ValidaUsername(string username)
        {
            Conexao conn = new Conexao();



            conn.conectar();

            conn.command.CommandText = "select count(*) from Login_ where usuario=@username";
            conn.command.Parameters.Add("@username", SqlDbType.VarChar).Value = username;

            int iCount = (int)conn.command.ExecuteScalar();

            if (iCount > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool ValidaCpfExiste(string cpf)
        {
            Conexao conn = new Conexao();

            conn.conectar();

            conn.command.CommandText = "select count(*) from Cliente where cpf=@cpf";
            conn.command.Parameters.Add("@cpf", SqlDbType.VarChar).Value = cpf;

            
            int iCount = (int)conn.command.ExecuteScalar();

            if (iCount > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool ValidaEmailExiste(string email)
        {
            Conexao conn = new Conexao();

            conn.conectar();

            conn.command.CommandText = "select count(*) from cliente where email=@email";
            conn.command.Parameters.Add("@email", SqlDbType.VarChar).Value = email;

            int iCount = (int)conn.command.ExecuteScalar();

            if (iCount > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool ValidaEmailAlt(string usuario, string email)
        {
            Conexao conn = new Conexao();

            conn.conectar();

            conn.command.CommandText = "select count(email)  from Cliente c inner join Login_ l on l.id_login=c.id_login where l.usuario=@usuario and c.email=@email";
            conn.command.Parameters.Add("@usuario", SqlDbType.VarChar).Value = usuario;
            conn.command.Parameters.Add("@email", SqlDbType.VarChar).Value = email;

            int iCount = (int)conn.command.ExecuteScalar();

            if (iCount > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}