using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class meuEspaco : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }
    protected void btnEntrar_Click(object sender, EventArgs e)
    {
        Conexao conn = new Conexao();

        conn.conectar();
        conn.command.CommandText = "select count(tipo) from Login_ where usuario=@usuario and senha=@senha and tipo='cli'";
        conn.command.Parameters.Add("@usuario", SqlDbType.VarChar).Value = txtUsuario.Text;
        conn.command.Parameters.Add("@senha", SqlDbType.VarChar).Value = txtSenha.Text;

        int retornoTipo = (int)conn.command.ExecuteScalar();

        
        int retornoLogar;

        retornoLogar = cafeteria.LoginCliente.LogarCliente(txtUsuario.Text, txtSenha.Text);

        if (retornoLogar>0 && retornoTipo>0)
        {
            Session["usuario"] = txtUsuario.Text;
            Session["senha"] = txtSenha.Text;
            Session["tipo"] = "cliente";
            
            Response.Redirect("meuEspaco.aspx");


        }

        else if (retornoLogar > 0 && retornoTipo == 0)
        {
            Session["usuario"] = txtUsuario.Text;
            Session["senha"] = txtSenha.Text;
            Session["tipo"] = "funcionario";

            Response.Redirect("meuEspacoF.aspx");
        }
        else
        {
            Response.Write("<script>alert('Usuário ou Senha Incorretos');</script>");
        }
    }
}