<%@ Page Language="C#" AutoEventWireup="true" CodeFile="contato.aspx.cs" Inherits="contato" Debug="true" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Grão do Dia - Contato</title>
    <link rel="stylesheet" type="text/css" href="css/estilo.css"/>
	<script type="text/javascript" src="js/javascript.js"></script>
    <script type="text/javascript" src="js/jquery-2.1.3.js"></script>
	<link rel="icon" type="image/png" href="img/icon.png"/>
</head>
<body class="center" >
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
		<div class="blockcont" id="contatoblock" style="background:url(../img/fundocontato.jpg)">
            <img src="img/fundocontato.jpg" />
             

            <form id="formContato" runat="server" onsubmit="validaFormContato()">
                <p class="tit">FALE CONOSCO!</p>
                
                

                <img src="img/contatoimg.jpg" class="imgForm"/>

                <p><asp:Label ID="Label1" runat="server" Text="Nome(*)"></asp:Label></p>
                <asp:TextBox ID="nomeContato" runat="server" MaxLength="30"></asp:TextBox><asp:Label ID="erroNome" runat="server" Text="" class="alerta"></asp:Label><br /><br />

                <p><asp:Label ID="Label2" runat="server" Text="E-mail(*)"></asp:Label></p>
                <asp:TextBox ID="emailContato" runat="server"></asp:TextBox><asp:Label ID="erroEmail" runat="server" Text="" class="alerta"></asp:Label><br /><br />

                <p><asp:Label ID="Label5" runat="server" Text="Telefone"></asp:Label></p>
                (OXX<asp:TextBox ID="telefoneContato1" runat="server" MaxLength="2" onkeypress="mascara(this,soNumeros)"></asp:TextBox>)
                <asp:TextBox ID="telefoneContato2" runat="server" MaxLength="5" onkeypress="mascara(this,soNumeros)"></asp:TextBox> -
                <asp:TextBox ID="telefoneContato3" runat="server" MaxLength="4" onkeypress="mascara(this,soNumeros)"></asp:TextBox><br />

                <p><asp:Label ID="Label3" runat="server" Text="Tipo de Contato(*)"></asp:Label></p>
                <asp:DropDownList ID="tipoContato" runat="server">
                    <asp:ListItem Value="selecione">Selecione</asp:ListItem>
                    <asp:ListItem Value="sujestao">Sugestão</asp:ListItem>
                    <asp:ListItem Value="reclamacao">Reclamação</asp:ListItem>
                    <asp:ListItem Value="contaUsuario">Conta de Usuário</asp:ListItem>
                </asp:DropDownList><asp:Label ID="erroTipo" runat="server" Text="" class="alerta"></asp:Label><br /><br />

                <asp:Label ID="Label4" runat="server" Text="Mensagem(*)"></asp:Label><br />
                <asp:TextBox ID="mensagemContato" runat="server" TextMode="MultiLine" MaxLength="150"></asp:TextBox><asp:Label ID="erroMsg" runat="server" Text="" class="alerta"></asp:Label>

                <asp:Button ID="submit" runat="server" Text="Enviar" OnClick="submit_Click"/>
                <asp:Button ID="limpar" runat="server" Text="Limpar" OnClick="limpar_Click" /><br />

                <asp:Label ID="Label6" runat="server" Text="(*)Campos Obrigatórios"></asp:Label><br />

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

