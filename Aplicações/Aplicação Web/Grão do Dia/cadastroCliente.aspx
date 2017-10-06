<%@ Page Language="C#" AutoEventWireup="true" CodeFile="cadastroCliente.aspx.cs" Inherits="cadastroCliente" Debug="true" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Grão do Dia - Cadastro</title>
    <link rel="stylesheet" type="text/css" href="css/estilo.css"/>
	<script type="text/javascript" src="js/javascript.js"></script>
    <script type="text/javascript" src="js/jquery-2.1.3.js"></script>
	<link rel="icon" type="image/png" href="img/icon.png"/>
    
</head>
<body class="center">
    <header>
		<div id="hamburguer" onclick="menuMobile()">
		    <div class="lhamburguer"></div>
		    <div class="lhamburguer"></div>
		    <div class="lhamburguer"></div>
		</div>
		<nav id="menuprincipal" class="fixo">
	        <a href="index.aspx"><img src="img/grao2.png"/></a>
            <ul>
			    <li><a href="index.aspx">HOME</a></li>
				<li><a href="produtos.aspx">NOSSOS PRODUTOS</a></li>
				<li><a href="cadastroCliente.aspx">CADASTRO</a></li>
				<li><a href="contato.aspx" >CONTATO</a></li>
                <li><a href="meuEspaco.aspx" >MEU ESPAÇO</a></li>
                <li><a href="sobre.aspx" >SOBRE</a></li>
			</ul>
		</nav>
	</header>
    <article>
		<div class="blockcad" id="cadastroBlock" style="background:url(../img/fundocadastro.jpg)">
            <img src="img/fundocadastro.jpg" />
            

            <form id="cadastro" runat="server">
              
                
                    <p class="tit">CADASTRE-SE</p>
                <img src="img/cadastroImg.png" class="imgForm" />
                
                <p><asp:Label ID="Label2" runat="server" Text="Nome Completo(*)"></asp:Label></p>
                <asp:TextBox ID="nomeCompletoCliente" runat="server" ></asp:TextBox><asp:Label ID="erroNome" runat="server" Text="" class="alerta"></asp:Label><br /><br />

                <p><asp:Label ID="Label3" runat="server" Text="CPF (Somente números) (*)"></asp:Label></p>
                <asp:TextBox ID="cpfCliente" runat="server" onkeypress="mascara(this,soNumeros)" maxlength="11" name="cpf"></asp:TextBox><asp:Label ID="erroCpf" class="alerta" runat="server" Text=""></asp:Label><br /><br />

                <p><asp:Label ID="Label5" runat="server" Text="Data de Nascimento (dd/mm/aaaa)"></asp:Label></p>
                <asp:TextBox ID="dtNasc" runat="server" type="date"></asp:TextBox><asp:Label ID="erroDtNasc" class="alerta" runat="server" Text=""></asp:Label><br /><br />

                <p><asp:Label ID="Label1" runat="server" Text="Sexo(*)"></asp:Label></p>
                <asp:RadioButton ID="rdMasc" runat="server" Checked="true" name="sexo" value="Masc" GroupName="sexo" /><asp:Label ID="Label4" runat="server" Text="Masculino"></asp:Label> 
                <asp:RadioButton ID="rdFem" runat="server"  name="sexo"  value="Fem" GroupName="sexo" /><asp:Label ID="Label7" runat="server"  Text="Feminino"></asp:Label><br /><br />

                <p><asp:Label ID="Label8" runat="server" Text="E-Mail(*)"></asp:Label></p>
                <asp:TextBox ID="emailCliente" runat="server" ></asp:TextBox><asp:Label ID="erroEmail" class="alerta" runat="server" Text=""></asp:Label><br /><br />

                <p><asp:Label ID="Label6" runat="server" Text="Telefone"></asp:Label></p>
                (OXX<asp:TextBox ID="telefoneCliente1" runat="server" MaxLength="2" onkeypress="mascara(this,soNumeros)"></asp:TextBox>)
                <asp:TextBox ID="telefoneCliente2" runat="server" MaxLength="5" onkeypress="mascara(this,soNumeros)"></asp:TextBox> -
                <asp:TextBox ID="telefoneCliente3" runat="server" MaxLength="4" onkeypress="mascara(this,soNumeros)"></asp:TextBox><asp:Label ID="erroTelefone" class="alerta" runat="server" Text=""></asp:Label><br />

                <p><asp:Label ID="Label9" runat="server" Text="Nome de Usuário(Login)"></asp:Label></p>
                <asp:TextBox ID="usernameCliente" runat="server"></asp:TextBox><asp:Label ID="erroUsername" class="alerta"  runat="server" Text=""/><br />

                <p><asp:Label ID="Label11" runat="server" Text="Senha(*)"></asp:Label></p>
                <asp:TextBox ID="senhaCliente" runat="server" type="password"></asp:TextBox><asp:Label ID="erroSenha" class="alerta" runat="server" Text=""></asp:Label><br />

                <p><asp:Label ID="Label12" runat="server" Text="Confirmar Senha(*)"></asp:Label></p>
                <asp:TextBox ID="confirmarCliente" runat="server" type="password"></asp:TextBox><asp:Label ID="erroConf" class="alerta" runat="server" Text=""></asp:Label><br />


                <asp:Button ID="submitCadastro" runat="server" Text="Cadastrar" OnClick="submitCadastro_Click"/>
                <asp:Button ID="lmpCadastro" runat="server" Text="Limpar" OnClick="lmpCadastro_Click" />

                <asp:Label ID="Label10" runat="server" Text="(*)Campos Obrigatórios"></asp:Label><br />

            </form>
		</div>
	</article>
    <footer id="footerCadastro">
		<h3>Contato</h3><br/>
		<p>Telefone: (11)2597-5542</p></br>
		<p>E-mail: contato@graododia.com</p></br>
	</footer>
</body>
</html>

