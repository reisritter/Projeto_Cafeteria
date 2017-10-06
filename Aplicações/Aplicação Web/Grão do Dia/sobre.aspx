<%@ Page Language="C#" AutoEventWireup="true" CodeFile="sobre.aspx.cs" Inherits="sobre" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Grão do Dia - Sobre</title>
    <link rel="stylesheet" type="text/css" href="css/estilo.css">
    <script type="text/javascript" src="js/javascript.js"></script>
    <script type="text/javascript" src="js/jquery-2.1.3.js"></script>
    <script type="text/javascript" src="js/jquery-1.1.1.js"></script>
    <link href='http://fonts.googleapis.com/css?family=Raleway:300' rel='stylesheet' type='text/css'>
    <link rel="icon" type="image/png" href="img/icon.png" />
</head>
<body class="center">
<header>
        <div id="logo">
            <a href="index.aspx"><img src="img/logoCoffe.png" /></a>
        </div>
        <div id="hamburguer" onclick="menuMobile()">
            <div class="lhamburguer"></div>
            <div class="lhamburguer"></div>
            <div class="lhamburguer"></div>
        </div>
        <nav id="menuprincipal" class="bannerMenu">
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
        <form id="log" runat="server">
            
        </form>
    </header>
    <article>
        <div class="blockimgprincipal" id="fblock">
            <figure id="slide" class="fblockimg">
                <img src="img/sobre.jpg" />
                <figcaption class="fotoPrincipalLegenda">NÓS :)</figcaption>
            </figure>
        </div>
        <div id="sobre" class="blockvertical blocktext produto">
						<p>
							Há um tempo estávamos sentindo falta de um espaço agradável onde fosse possível apreciar um café de primeira, com grãos cuidadosamente selecionados para que os clientes pudessem desfrutar do momento, sentir prazer em estar na casa e assim nasceu o Grão do Dia, trazendo o que há de melhor no mercado de cafés no país, com o melhor quando se trata de espaço, ingredientes, sabores e principalmente quando se trata de contar com uma equipe altamente qualificada para atendê-los sempre  
						</p>
                        <p>
                            Além de atuarmos servindo e atendendo nossos clientes, nós também participamos do processo de torrefação do seu Grão do Dia, mantendo um controle de qualidade intenso e preciso para elevar ainda mais a satisfação de nossos clientes
                        </p>
            <p><div id="flashContent">
			<object classid="clsid:d27cdb6e-ae6d-11cf-96b8-444553540000" width="500" height="250" id="Untitled-1" align="middle">
				<param name="movie" value="Untitled-1.swf" />
				<param name="quality" value="high" />
				<param name="bgcolor" value="#ffffff" />
				<param name="play" value="true" />
				<param name="loop" value="true" />
				<param name="wmode" value="window" />
				<param name="scale" value="showall" />
				<param name="menu" value="true" />
				<param name="devicefont" value="false" />
				<param name="salign" value="" />
				<param name="allowScriptAccess" value="sameDomain" />
				<!--[if !IE]>-->
				<object type="application/x-shockwave-flash" data="Untitled-1.swf" width="500" height="250">
					<param name="movie" value="Untitled-1.swf" />
					<param name="quality" value="high" />
					<param name="bgcolor" value="#ffffff" />
					<param name="play" value="true" />
					<param name="loop" value="true" />
					<param name="wmode" value="window" />
					<param name="scale" value="showall" />
					<param name="menu" value="true" />
					<param name="devicefont" value="false" />
					<param name="salign" value="" />
					<param name="allowScriptAccess" value="sameDomain" />
				<!--<![endif]-->
					<a href="http://www.adobe.com/go/getflash">
						<img src="http://www.adobe.com/images/shared/download_buttons/get_flash_player.gif" alt="Get Adobe Flash player" />
					</a>
				<!--[if !IE]>-->
				</object>
				<!--<![endif]-->
			</object>
		</div></p>
					
				</div>
				<div class="blockvertical blocktext" id="block2" style="background-color:rgb(240,240,240);">
				    <img src="img/sobre/sobreimg1.jpg" class="imgsobre1" />
				</div>
        <article>

            <footer id="footerSobre">
                <h3>Contato</h3><br/>
				<p>Telefone: (11)2597-5542</p></br>
				<p>E-mail: contato@graododia.com</p></br>

            </footer>
</body>
</html>
