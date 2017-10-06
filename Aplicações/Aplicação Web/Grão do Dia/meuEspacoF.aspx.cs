using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class meuEspacoF : System.Web.UI.Page
{
    public int retornoAlt = 0;

    protected void Page_Load(object sender, EventArgs e)
    {
        
      
        
        SqlDataAdapter dAdapter = new SqlDataAdapter();
        DataSet dtSet = new DataSet();

        String sql = "select nome, email, telefone, tipo, data, mensagem from contato";
        Conexao c = new Conexao();
        c.conectar();
        c.command.CommandText = sql;
        dAdapter.SelectCommand = c.command;
        dAdapter.Fill(dtSet);
        c.fechaConexao();
        GridMsg.DataSource = dtSet;
        GridMsg.DataBind();
   


        
        if (Session["usuario"] == null)
            Response.Redirect("Login.aspx");

        if (Session["tipo"] == "cliente")
            Response.Redirect("meuEspaco.aspx");



        cpfAlt.Enabled = false;

        if (!Page.IsPostBack)
        {
            if (retornoAlt > 0)
            {
            }
            else
            {

                string usuarioDados = Session["usuario"].ToString();
                string senhaDados = Session["senha"].ToString();
                string nome = txtNomeAlt.Text;
                string email = txtEmailAlt.Text;
                string telefone = txtTelAlt.Text;
                string cpf = cpfAlt.Text;

                Conexao conn = new Conexao();

                string sqlStringVerificar = "select nome, cpf, email, telefone  from Funcionario c inner join Login_ l on l.id_login=c.id_login where l.usuario=@usuario and l.senha=@senha";

                conn.conectar();

                conn.command.CommandText = sqlStringVerificar;
                conn.command.Parameters.Add("@usuario", SqlDbType.VarChar).Value = usuarioDados;
                conn.command.Parameters.Add("@senha", SqlDbType.VarChar).Value = senhaDados;

                conn.dr = conn.command.ExecuteReader();



                while (conn.dr.Read())
                {
                    txtNomeAlt.Text = conn.dr[0].ToString();
                    cpfAlt.Text = conn.dr[1].ToString();
                    txtEmailAlt.Text = conn.dr[2].ToString();
                    txtTelAlt.Text = conn.dr[3].ToString();
                    break;
                }
                conn.fechaConexao();
            }
        }






    }






    protected void Button3_Click(object sender, EventArgs e)
    {

        string novaSenha = senhaNova.Text;
        string confNovaSenha = confSenhaNova.Text;

        if (novaSenha == confNovaSenha)
        {

            int retornoSenhaN;
            string usuarioAltSenha = (string)Session["usuario"];
            string senhaAltSenha = (string)Session["senha"];

            retornoSenhaN = cafeteria.alterarDados.alterarSenha(senhaAntiga.Text, senhaNova.Text, usuarioAltSenha, senhaAltSenha);

            if (retornoSenhaN > 0)
            {
                Response.Write("<script>alert('Senha Alterada');</script>");
            }
            else
            {
                Response.Write("<script>alert('Senha antiga incorreta');</script>");
            }

        }
        else
        {
            Response.Write("<script>alert('A senha não é igual a confirmação');</script>");
        }

    }
    protected void logout_Click(object sender, EventArgs e)
    {
        Session.RemoveAll();
        Response.Redirect("login.aspx");
        retornoAlt = 0;
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
    }




    public void btnAlteraDados_Click(object sender, EventArgs e)
    {


        string usuarioAltDados = Session["usuario"].ToString();
        string senhaAltDados = Session["senha"].ToString();
        string nome = txtNomeAlt.Text;
        string email = txtEmailAlt.Text;
        string telefone = txtTelAlt.Text;

        int pos = email.IndexOf("@");
        int ponto = email.IndexOf(".");
        int tamanho = email.Length;

        string nomeVazio;


        string emailVazio;
        string telefoneVazio;
        string emailExiste;


        if (string.IsNullOrWhiteSpace(nome)
             || telefone.Length < 10 || !((pos >= 2) && (ponto >= 5) && (tamanho >= 8)) || (cadastrado.ValidaUsernameCpf.ValidaEmailExiste(email) == true && cadastrado.ValidaUsernameCpf.ValidaEmailAlt(usuarioAltDados, email) == false))
        {
            if (string.IsNullOrWhiteSpace(nome))
            {
                nomeVazio = "  Preencha este Campo";
                txtNomeAlt.Focus();
                txtNomeAlt.BackColor = System.Drawing.ColorTranslator.FromHtml("#ffb3aa");
                erroNome.Text = nomeVazio;

            }
            else
            {
                nomeVazio = "";
                erroNome.Text = nomeVazio;
                txtNomeAlt.BackColor = System.Drawing.Color.White;
            }

            if (!((pos >= 2) && (ponto >= 5) && (tamanho >= 8)))
            {
                emailVazio = "  Email Inválido";
                txtEmailAlt.Focus();
                txtEmailAlt.BackColor = System.Drawing.ColorTranslator.FromHtml("#ffb3aa");
                erroEmail.Text = emailVazio;
            }

            else if (cadastrado.ValidaUsernameCpf.ValidaEmailExiste(email) == true && cadastrado.ValidaUsernameCpf.ValidaEmailAlt(usuarioAltDados, email) == false)
            {
                emailExiste = "  Email Já Cadastrado";
                txtEmailAlt.Focus();
                txtEmailAlt.BackColor = System.Drawing.ColorTranslator.FromHtml("#ffb3aa");
                erroEmail.Text = emailExiste;
            }
            else
            {
                emailVazio = "";
                txtEmailAlt.BackColor = System.Drawing.Color.White;
                erroEmail.Text = emailVazio;
                emailExiste = "";
            }


            if (telefone.Length < 10)
            {
                telefoneVazio = "  Preencha este Campo Corretamente";
                txtTelAlt.BackColor = System.Drawing.ColorTranslator.FromHtml("#ffb3aa");
                erroTelefone.Text = telefoneVazio;
            }
            else
            {
                telefoneVazio = "";
                txtTelAlt.BackColor = System.Drawing.Color.White;
                erroTelefone.Text = telefoneVazio;
            }

        }
        else
        {
            retornoAlt = cafeteria.alterarDados.alterarDCadastraisF(nome, email, telefone, usuarioAltDados);

            if (retornoAlt > 0)
            {
                Response.Write("<script>alert('Dados Alterados com Sucesso');</script>");
            }
            else
            {
                Response.Write("<script>alert('Houve algum erro Durante a Gravação');</script>");
            }
        }



    }


    protected void GridMsg_SelectedIndexChanged(object sender, EventArgs e)
    {
        Conexao conStatus = new Conexao();
        string sql = "insert into contato (status_) values ('l')";
        conStatus.conectar();
        conStatus.command.CommandText = sql;
        conStatus.command.ExecuteNonQuery();

    }
    protected void GridMsg_RowEditing(object sender, GridViewEditEventArgs e)
    {

    }
}