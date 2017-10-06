<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="meuEspaco" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Grão do Dia - Login</title>
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
            <form id="formLogin" runat="server">
                <div id="divLoginCliente">
                    <asp:Label ID="Label1" runat="server" Text="Usuário"></asp:Label>
                    <asp:TextBox ID="txtUsuario" runat="server"></asp:TextBox><br /><br />

                    <asp:Label ID="Label2" runat="server" Text="Senha"></asp:Label>
                    <asp:TextBox ID="txtSenha" runat="server" type="password"></asp:TextBox><br /><br />

                    <asp:Button ID="btnEntrar" runat="server" Text="Entrar" OnClick="btnEntrar_Click" />


                    <asp:Label ID="lblSaudacao" runat="server" Text=""></asp:Label>
                </div>
                

                

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
