<%@ Page Language="C#" AutoEventWireup="true" CodeFile="produtos.aspx.cs" Inherits="produtos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Grão do Dia - Produtos</title>
    <link rel="stylesheet" type="text/css" href="css/estilo.css">
    <script type="text/javascript" src="js/javascript.js"></script>
     <script type="text/javascript" src="js/jquery-2.1.3.js"></script>
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
                <img src="img/produtos.jpg" />
                <figcaption class="fotoPrincipalLegenda">COMBINAÇÕES PARA UM EXCELENTE CAFÉ A QUALQUER MOMENTO DO DIA</figcaption>
            </figure>
        </div>
        <div class="block" id="blockProduto">
            <div id="nossosProdutosimg" class="sublock1 produto1" style="background-color: #fff">
                <figure>
                    <img src="img/produtos/cafe.jpg" class="produtoImg1" id="imgCafe"/>
                    <figcaption>
                        <p>
                        </p>
                    </figcaption>
				</figure>
                <figure>
                    <img src="img/salgado2.jpg" class="produtoImg2" id="imgComida"/>
                    <figcaption>
                        <p>
                        </p>
                    </figcaption>
                </figure>
            </div>
            <div id="produtosText" class="sublock2 blocktextProduto" style="background-color: #fff;">
                    <p style="margin-top:60px"><a id="exp" onclick="fotoExpresso()">Café Expresso</a></p>
                    <p><a  onclick="fotoFiltro()" >Café Filtrado</a></p>
                    <p><a  onclick="fotoGeladoLeite()">Café Gelado com Leite</a></p>
                    <p><a  onclick="fotoCap()">Cappuccino</a></p>
                    <p><a  onclick="fotoCapChoc()">Cappuccino de Chocolate</a></p>
                    <p><a  onclick="fotoChocQ()">Chocolate Quente</a></p>
                    <p><a  onclick="fotoChocBQ()">Chocolate Branco Quente</a></p>

                <div id="alimentos">
                    <p style="margin-top:60px"><a id="exp" onclick="fotoRosquinha()">Rosquinhas</a></p>
                    <p><a  onclick="fotoEsfiha()" >Esfihas</a></p>
                    <p><a  onclick="fotoCoxinha()">Coxinha </a></p>
                    <p><a  onclick="fotoBolo()">Bolos</a></p>
                    <p><a  onclick="fotoBrownie()">Brownie</a></p>
                    <p><a  onclick="fotoCupcake()">CupCake</a></p>
                    <p><a  onclick="fotoCookie()">Cookies</a></p>
                </div>
                    
            </div>
        </div>
        <article>

            <footer id="footerProdutos">
                <h3>Contato</h3><br/>
				<p>Telefone: (11)2597-5542</p></br>
				<p>E-mail: contato@graododia.com</p></br>
            </footer>
</body>
</html>
