using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Data.SqlClient;

public class Conexao
{
    public SqlConnection conexao;
    public SqlCommand command;
    public SqlDataReader dr;
    string strConexao = "Server=localhost;DataBase=Cafeteria;user id=aluno; password=etesp";

	public Conexao()
	{
		
	}

    public void conectar()
    {

        conexao = new SqlConnection(strConexao);
        conexao.Open();
        command = new SqlCommand();
        command.Connection = conexao;



    }

    public void fechaConexao()
    {
        conexao.Close();
        conexao = null;
        command = null;

    }
}
