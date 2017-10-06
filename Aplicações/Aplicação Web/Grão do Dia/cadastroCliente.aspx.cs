using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class cadastroCliente : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["New"] != null)
        {
            
        }
        else
        {
            
        }
    }
    protected void submitCadastro_Click(object sender, EventArgs e)
    {

        string nome;
        string cpf;
        string sexo;
        string email;
        string telefone;
        string username;
        string senha;
        string confSenha;

        if(rdMasc.Checked==true)
        {
            sexo = "M";
        }
        else
        {
            sexo = "F";
        }

        nome = nomeCompletoCliente.Text;
        cpf = cpfCliente.Text;
        email = emailCliente.Text;
        telefone = telefoneCliente1.Text + "" + telefoneCliente2.Text + "" + telefoneCliente3.Text;
        username = usernameCliente.Text;
        senha = senhaCliente.Text;
        confSenha = confirmarCliente.Text;

         int pos = email.IndexOf("@");
         int ponto = email.IndexOf(".");
         int tamanho = email.Length;

        string dtNasci = dtNasc.Text;
        string dtDefault = "1900-01-01";

        if (dtNasci == "")
        {
            
            dtNasc.Text = dtDefault;
        }

         DateTime dataNasc = DateTime.Parse(dtNasc.Text);
         int anoNasc = dataNasc.Year;



         DateTime dtD = DateTime.Parse(dtDefault);
        
         
        string nomeVazio;
        string cpfVazio;
        string cpfValido;
        string dataNascVazio;
        string dataDefault;
        string emailVazio;
        string emailInvalido;
        string telefoneVazio;
        string usernameVazio;
        string senhaVazio;
        string confSenhaVazio;
        string senhaN;
        string usernameExiste;
        string emailExiste;
        string cpfExiste;



        if (string.IsNullOrWhiteSpace(nome) ||
            Validacao.ValidaCPF.IsCpf(cpf) == false || cadastrado.ValidaUsernameCpf.ValidaCpfExiste(cpf) == true
            || dataNasc == dtD
            ||telefone.Length<10 || !((pos >= 2) && (ponto >= 5) && (tamanho >= 8)) || cadastrado.ValidaUsernameCpf.ValidaEmailExiste(email) == true ||
            string.IsNullOrWhiteSpace(username)|| cadastrado.ValidaUsernameCpf.ValidaUsername(username) == true || senha.Length<6 || confSenha.Length<6
            || senha!=confSenha)
         {
             if (string.IsNullOrWhiteSpace(nome))
             {
                 nomeVazio = "  Preencha este Campo";
                 nomeCompletoCliente.Focus();
                 nomeCompletoCliente.BackColor = System.Drawing.ColorTranslator.FromHtml("#ffb3aa");
                 erroNome.Text = nomeVazio;
                 
             }
             else
             {
                 nomeVazio = "";
                 erroNome.Text = nomeVazio;
                 nomeCompletoCliente.BackColor = System.Drawing.Color.White;
             }


             if (cadastrado.ValidaUsernameCpf.ValidaCpfExiste(cpf) == true)
             {
                 cpfExiste = "  CPF Já Cadastrado";
                 cpfCliente.Focus();
                 cpfCliente.BackColor = System.Drawing.ColorTranslator.FromHtml("#ffb3aa");
                 erroCpf.Text = cpfExiste;
             }
             else if (Validacao.ValidaCPF.IsCpf(cpf) == false)
             {
                 cpfValido = "  O número é um CPF Inválido";
                 cpfCliente.Focus();
                 cpfCliente.BackColor = System.Drawing.ColorTranslator.FromHtml("#ffb3aa");
                 erroCpf.Text = cpfValido;
             }
             else
             {
                 cpfExiste = "";
                 cpfValido = "";
                 erroCpf.Text = cpfExiste;
                 cpfCliente.BackColor = System.Drawing.Color.White;
             }

             if (dataNasc == dtD)
             {
                 dataDefault = "Digite sua Data de Nascimento";
                 dtNasc.Focus();
                 dtNasc.BackColor = System.Drawing.ColorTranslator.FromHtml("#ffb3aa");
                 erroDtNasc.Text = dataDefault;
             }
             else
             {
                 dataDefault = "";
                 erroDtNasc.Text = dataDefault;
                 dtNasc.BackColor = System.Drawing.Color.White;
                 dataNascVazio = "";
                 erroDtNasc.Text = dataNascVazio;
             }


      
             if (!((pos >= 2) && (ponto >= 5) && (tamanho >= 8)))
             {
                 emailVazio = "  Email Inválido";
                 emailCliente.Focus();
                 emailCliente.BackColor = System.Drawing.ColorTranslator.FromHtml("#ffb3aa");
                 erroEmail.Text = emailVazio;
             }

             else if (cadastrado.ValidaUsernameCpf.ValidaEmailExiste(email) == true)
             {
                 emailExiste = "  Email Já Cadastrado";
                 emailCliente.Focus();
                 emailCliente.BackColor = System.Drawing.ColorTranslator.FromHtml("#ffb3aa");
                 erroEmail.Text = emailExiste;
             }
             else
             {
                 emailVazio = "";
                 emailCliente.BackColor = System.Drawing.Color.White;
                 erroEmail.Text = emailVazio;
                 emailExiste = "";
             }


             if (telefone.Length < 10)
             {
                 telefoneVazio = "  Preencha este Campo Corretamente";
                 telefoneCliente1.BackColor = System.Drawing.ColorTranslator.FromHtml("#ffb3aa");
                 telefoneCliente2.BackColor = System.Drawing.ColorTranslator.FromHtml("#ffb3aa");
                 telefoneCliente3.BackColor = System.Drawing.ColorTranslator.FromHtml("#ffb3aa");
                 erroTelefone.Text = telefoneVazio;
             }
             else
             {
                 telefoneVazio = "";
                 telefoneCliente1.BackColor = System.Drawing.Color.White;
                 telefoneCliente2.BackColor = System.Drawing.Color.White;
                 telefoneCliente3.BackColor = System.Drawing.Color.White;
                 erroTelefone.Text = telefoneVazio;
             }


             if (cadastrado.ValidaUsernameCpf.ValidaUsername(username) == true)
             {
                 usernameExiste = "  O Nome de Usuário já existe";
                 usernameCliente.Focus();
                 usernameCliente.BackColor = System.Drawing.ColorTranslator.FromHtml("#ffb3aa");
                 erroUsername.Text = usernameExiste;
             }
             else if (string.IsNullOrWhiteSpace(username))
             {
                 usernameVazio = "  Digite um Nome de Usuário";
                 usernameCliente.Focus();
                 usernameCliente.BackColor = System.Drawing.ColorTranslator.FromHtml("#ffb3aa");
                 erroUsername.Text = usernameVazio;
             }
             else
             {
                 usernameExiste = "";
                 usernameVazio = "";
                 usernameCliente.BackColor = System.Drawing.ColorTranslator.FromHtml("#ffb3aa");
                 erroUsername.Text = usernameExiste;
             }


             if (senha.Length < 6)
             {
                 senhaVazio = "  Digite uma senha de no mínimo 6 caracteres";
                 senhaCliente.Focus();
                 senhaCliente.BackColor = System.Drawing.ColorTranslator.FromHtml("#ffb3aa");
                 erroSenha.Text = senhaVazio;
             }
             else if (confSenha.Length < 6)
             {
                 confSenhaVazio = "  Digite uma senha de no mínimo 6 caracteres";
                 confirmarCliente.Focus();
                 confirmarCliente.BackColor = System.Drawing.ColorTranslator.FromHtml("#ffb3aa");
                 erroConf.Text = confSenhaVazio;
                 senhaVazio = "";
                 senhaCliente.BackColor = System.Drawing.Color.White;
                 erroSenha.Text = senhaVazio;
             }

             else if (senha != confSenha)
             {
                 senhaN = "  Senhas não Correspondem";
                 confirmarCliente.Focus();
                 confirmarCliente.BackColor = System.Drawing.ColorTranslator.FromHtml("#ffb3aa");
                 senhaCliente.BackColor = System.Drawing.ColorTranslator.FromHtml("#ffb3aa");
                 erroSenha.Text = senhaN;
                 erroConf.Text = senhaN;
             }
             else
             {
                 senhaVazio = "";
                 confSenhaVazio = "";
                 senhaCliente.BackColor = System.Drawing.Color.White;
                 erroSenha.Text = senhaVazio;
                 confirmarCliente.BackColor = System.Drawing.Color.White;
                 erroConf.Text = confSenhaVazio;
                 senhaN = "";
                 erroSenha.Text = senhaN;
                 erroConf.Text = senhaN;
             }
         }
        else 
        {


        Conexao c = new Conexao();
        
        c.conectar();

        c.command.CommandText = "insert into Login_(usuario, senha, tipo)" +
            "values(@usuario, @senha, 'cli') select scope_identity()";

        c.command.Parameters.Add("@usuario", SqlDbType.VarChar).Value = username;
        c.command.Parameters.Add("@senha", SqlDbType.VarChar).Value = senha;

        int idLogin = Convert.ToInt32(c.command.ExecuteScalar());



        c.fechaConexao();

        c.conectar();

        c.command.CommandText = "insert into Cliente(nome, cpf, sexo, data_nascimento, email, telefone, id_login)" +
            "values(@nome_cliente, @cpf_cliente, @sexo_cliente, @data_nascimento, @email_cliente,@telefone_cliente,@id_login_site)";
        c.command.Parameters.Add("@nome_cliente", SqlDbType.VarChar).Value = nome;
        c.command.Parameters.Add("cpf_cliente", SqlDbType.NChar).Value = cpf;
        c.command.Parameters.Add("@sexo_cliente", SqlDbType.VarChar).Value = sexo;
        c.command.Parameters.Add("@data_nascimento", SqlDbType.VarChar).Value = dataNasc;
        c.command.Parameters.Add("@email_cliente", SqlDbType.VarChar).Value = email;
        c.command.Parameters.Add("@telefone_cliente", SqlDbType.VarChar).Value = telefone;
        c.command.Parameters.Add("@id_login_site", SqlDbType.Int).Value = idLogin;
        

        c.command.ExecuteNonQuery();

        c.fechaConexao();

        limparCadastro();

        Response.Write("<script>alert('Cadastro Realizado com Sucesso!');</script>");

        }
        
        

    }

    public void limparCadastro()
    {
        nomeCompletoCliente.Text="";
        nomeCompletoCliente.BackColor = System.Drawing.Color.White;
        erroNome.Text ="";
        cpfCliente.Text="";
        cpfCliente.BackColor = System.Drawing.Color.White;
        erroCpf.Text = "";
        dtNasc.Text="";
        dtNasc.BackColor = System.Drawing.Color.White;
        erroDtNasc.Text = "";
        emailCliente.Text="";
        emailCliente.BackColor = System.Drawing.Color.White;
        telefoneCliente1.Text = "";
        telefoneCliente2.Text = "";
        telefoneCliente3.Text = "";
        telefoneCliente1.BackColor = System.Drawing.Color.White;
        telefoneCliente2.BackColor = System.Drawing.Color.White;
        telefoneCliente3.BackColor = System.Drawing.Color.White;
        erroTelefone.Text = "";
        erroEmail.Text = "";
        usernameCliente.Text="";
        usernameCliente.BackColor = System.Drawing.Color.White;
        erroUsername.Text = "";
        senhaCliente.Text="";
        senhaCliente.BackColor = System.Drawing.Color.White;
        erroSenha.Text = "";
        confirmarCliente.Text="";
        confirmarCliente.BackColor = System.Drawing.Color.White;
        erroConf.Text = "";
    }
    protected void lmpCadastro_Click(object sender, EventArgs e)
    {
        limparCadastro();
    }
}


