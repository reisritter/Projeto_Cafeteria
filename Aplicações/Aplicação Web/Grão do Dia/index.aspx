<%@ Page Language="C#" AutoEventWireup="true" CodeFile="index.aspx.cs" Inherits="index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Grão do Dia</title>
		<link rel="stylesheet" type="text/css" href="css/estilo.css">
		<script type="text/javascript" src="js/javascript.js"></script>
        <script type="text/javascript" src="js/jquery-2.1.3.js"></script>
		<link rel="icon" type="image/png" href="img/icon.png"/>
        <link rel="stylesheet" media="screen" href="css/sequencejs-theme.modern-slide-in.css" />
		<script src="js/jquery.ba-hashchange.min.js"></script>
		<script src="js/jquery.sequence-min.js"></script>
		<script src="sequencejs-options.modern-slide-in.js"></script>
</head>
<body class="center" onLoad="slide1()">
        <header>
				<div id="logo">
					<a href="index.aspx"><img src="img/logoCoffe.png"/></a>
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
                        <img id="imgBanner" src="" />
                        <figcaption id="bannerCaption" class="fotoPrincipalLegenda"></figcaption>
                    </figure>
                </div>
				<div id="sobre" class="block">
					<div id="sobretext" class="sublock1 blocktext">
						<p>
							Buscando trazer uma experiência única aos nossos clientes nos unimos para trazer o melhor conjunto para apreciação de um bom café, desde o ambiente e localidade até o tipo do grão usado no preparo dos cafés que faz com que seja prazeroso estar conosco, e isso vale tanto para eventuais clientes como para os nossos mais fiéis
						</p>
					
					</div>
					<div id="sobreimg"class="sublock2">
					<figure id="casa">
						<a href="sobre.aspx"><img src="img/imgCasa.png"/></a>
						<figcaption><a href="sobre.aspx">Saiba ainda mais sobre o seu Grão do Dia!</a></figcaption>
					</figure>
					</div>
				</div>
				<div class="block" id="block2">
					<div id="salgado" class="sublock2" style="background-color: #fff">
						<a href="produtos.aspx"><img src="img/imgBolo.png"/></a><br/>
                        <a href="produtos.aspx">Ir Para Produtos</a>
					</div>
					<div id="salgadotext"class="sublock2 blocktext" style="background-color: #fff;">
					<figure id="casa">
						<p>Além dos nossos deliciosos cafés, temos uma variedade de acompanhamentos que podem se dar muito bem ao lado deles, com destaque aos nossos bolos e salgados, além de serem feitos com ingredientes de primeira, eles são feitos com amor, que consideramos como ingrediente especial e essencial para que tenham um sabor inesquecível</p><br/><br/>
					</figure>
					</div>
				</div>
			</article>
		
			<footer>
				<h3>Contato</h3><br/>
				<p>Telefone: (11)2597-5542</p></br>
				<p>E-mail: contato@graododia.com</p></br>
				
			</footer>

    
</body>
</html>
