using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

namespace cafeteria{
    public class LoginCliente
    {
	    public static int LogarCliente(string username, string senha)
	    {

            int retornoLogar = 0;

            Conexao conn = new Conexao();
            conn.conectar();

            conn.command.CommandText = "select count(*) from Login_ where usuario=@username and senha=@senha";

            conn.command.Parameters.Add("@username", SqlDbType.VarChar).Value=username;
            conn.command.Parameters.Add("@senha", SqlDbType.VarChar).Value = senha;

            retornoLogar = (int)conn.command.ExecuteScalar();

            conn.fechaConexao();

            return retornoLogar;

	    }
}
}