<%@ Page Language="C#" AutoEventWireup="true" CodeFile="meuEspaco.aspx.cs" Inherits="meuEspaco" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Grão do Dia - Meu Espaço</title>
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
		<div class="blockcont" id="contatoblock">
		    <figure id="fundocontato">
				<img src="img/fundoMeuEspaco.jpg"/>
			</figure>
            <form id="formAltDados" runat="server">
                <input type="button" id="alteraSenha" onclick="mostrarAltSenha()" value="Alterar Senha" class="homeButtonEspDados" />
                <div id="alteracaoSenha">
                    <p><asp:Label ID="Label1" runat="server" Text="Senha Antiga"></asp:Label></p>
                    <asp:TextBox ID="senhaAntiga" runat="server" type="password"></asp:TextBox><br />
                    <p><asp:Label ID="Label2" runat="server" Text="Nova Senha"></asp:Label></p>
                    <asp:TextBox ID="senhaNova" runat="server" type="password"></asp:TextBox><br />
                    <p><asp:Label ID="Label3" runat="server" Text="Confirmar Nova Senha"></asp:Label></p>
                    <asp:TextBox ID="confSenhaNova" runat="server" type="password"></asp:TextBox><br />

                    <asp:Button ID="Button3" runat="server" Text="Alterar" OnClick="Button3_Click" />
                   
                </div>
                <input type="button" id="alteraDados" onclick="mostrarAltDados()" value="Alterar Dados" class="homeButtonEspDados" />
                <div id="alteracaoCadastrais">
                    <p><asp:Label ID="Label4" runat="server" Text="Nome"></asp:Label></p>
                    <asp:TextBox ID="txtNomeAlt" runat="server"></asp:TextBox><asp:Label ID="erroNome" runat="server" Text="" class="alerta"></asp:Label><br />
                    <p><asp:Label ID="Label7" runat="server" Text="CPF (Somente números) (*)"></asp:Label></p>
                    <asp:TextBox ID="cpfClienteAlt" runat="server" onkeypress="mascara(this,soNumeros)" maxlength="11" name="cpf"></asp:TextBox><br />
                    <p><asp:Label ID="Label5" runat="server" Text="E-Mail"></asp:Label></p>
                    <asp:TextBox ID="txtEmailAlt" runat="server"></asp:TextBox><asp:Label ID="erroEmail" runat="server" Text="" class="alerta"></asp:Label><br />
                    <p><asp:Label ID="Label6" runat="server" Text="Telefone"></asp:Label></p>
                    <asp:TextBox ID="txtTelAlt" MaxLength="11" runat="server" onkeypress="mascara(this,soNumeros)"></asp:TextBox><asp:Label ID="erroTelefone" runat="server" Text="" class="alerta"></asp:Label><br />

                    <asp:Button ID="btnAlteraDados" runat="server" Text="Alterar" OnClick="btnAlteraDados_Click" />
                   
                </div>







                <asp:Button ID="logout" runat="server" Text="Sair" class="homeButtonEspDados" OnClick="logout_Click"/>
                
            </form>
		</div>
	</article>
    <footer id="footerContato">
		<h3>Contato</h3><br/>
	    <p>Telefone: (11)2597-5542</p><br/>
		<p>E-mail: contato@graododia.com</p><br/>	
	</footer>
</body>
</html>