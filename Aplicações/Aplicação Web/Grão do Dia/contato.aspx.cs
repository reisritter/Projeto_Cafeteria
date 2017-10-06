using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class contato : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void submit_Click(object sender, EventArgs e)
    {
        string nome;
        string email;
        string telefone;
        string mensagem;
        string tipo;



        nome = nomeContato.Text;
        email = emailContato.Text;
        telefone = telefoneContato1.Text + "" + telefoneContato2.Text + "" + telefoneContato3.Text;
        mensagem = mensagemContato.Text;
        tipo = tipoContato.SelectedItem.Text;


         int pos = email.IndexOf("@");
         int ponto = email.IndexOf(".");
         int tamanho = email.Length;

        string nomeVazio;
        string emailVazio;
        string tipoVazio;
        string msgVazio;


        if (string.IsNullOrWhiteSpace(nome) || !((pos >= 2) && (ponto >= 5) && (tamanho >= 8)) || tipo == "Selecione" || string.IsNullOrWhiteSpace(mensagem))
        {
            if (string.IsNullOrWhiteSpace(nome))
            {
                nomeVazio = "  Preencha este Campo";
                nomeContato.Focus();
                nomeContato.BackColor = System.Drawing.ColorTranslator.FromHtml("#ffb3aa");
                erroNome.Text = nomeVazio;

            }
            else
            {
                nomeVazio = "";
                erroNome.Text = nomeVazio;
                nomeContato.BackColor = System.Drawing.Color.White;
            }

            if (!((pos >= 2) && (ponto >= 5) && (tamanho >= 8)))
            {
                emailVazio = "  Email Inválido";
                emailContato.Focus();
                emailContato.BackColor = System.Drawing.ColorTranslator.FromHtml("#ffb3aa");
                erroEmail.Text = emailVazio;
            }
            else
            {
                emailVazio = "";
                emailContato.BackColor = System.Drawing.Color.White;
                erroEmail.Text = emailVazio;
            }

            if (tipo=="Selecione")
            {
                tipoVazio = "Selecione o tipo de Contato";
                tipoContato.BackColor = System.Drawing.ColorTranslator.FromHtml("#ffb3aa");
                erroTipo.Text = tipoVazio;
            }
            else
            {
                tipoVazio = "";
                tipoContato.BackColor = System.Drawing.Color.White;
                erroTipo.Text = tipoVazio;
            }

            if (string.IsNullOrWhiteSpace(mensagem))
            {
                msgVazio = "Digite uma Mensagem";
                mensagemContato.BackColor = System.Drawing.ColorTranslator.FromHtml("#ffb3aa");
                erroMsg.Text = msgVazio;
            }
            else
            {
                msgVazio = "";
                mensagemContato.BackColor = System.Drawing.Color.White;
                erroMsg.Text = msgVazio;
            }
        }
        else 
        {

            DateTime dateAgora = DateTime.Now;
            
        Conexao c = new Conexao();

        c.conectar();
        c.command.CommandText = "insert into contato(nome, tipo, email, telefone, mensagem, data)" +
        "values(@nome_contato, @tipo_contato, @email_contato, @telefone_contato, @mensagem_contato, @data)";

        c.command.Parameters.Add("@nome_contato", SqlDbType.VarChar).Value = nome;
        c.command.Parameters.Add("@email_contato", SqlDbType.VarChar).Value = email;
        c.command.Parameters.Add("@telefone_contato", SqlDbType.VarChar).Value = telefone;
        c.command.Parameters.Add("@tipo_contato", SqlDbType.VarChar).Value = tipo;
        c.command.Parameters.Add("@mensagem_contato", SqlDbType.VarChar).Value = mensagem;
        c.command.Parameters.Add("@data", SqlDbType.DateTime).Value = dateAgora;
        c.command.ExecuteNonQuery();

        c.fechaConexao();

        limparContato();

        Response.Write("<script>alert('Mensagem Enviada com Sucesso');</script>");

        }

    }

    public void limparContato()
    {
        nomeContato.Text = "";
        nomeContato.BackColor = System.Drawing.Color.White;
        erroNome.Text = "";
        emailContato.Text="";
        emailContato.BackColor = System.Drawing.Color.White;
        erroEmail.Text = "";
        telefoneContato1.Text = "";
        telefoneContato2.Text = "";
        telefoneContato3.Text = "";
        mensagemContato.Text = "";
        mensagemContato.BackColor = System.Drawing.Color.White;
        erroMsg.Text = "";
        tipoContato.SelectedIndex=0;
        tipoContato.BackColor = System.Drawing.Color.White;
        erroTipo.Text = "";

    }
    protected void limpar_Click(object sender, EventArgs e)
    {
        limparContato();
    }
}