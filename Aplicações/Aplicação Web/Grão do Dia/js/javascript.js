
window.onload = function () {
    $('.fotoPrincipalLegenda, .imgForm').fadeIn(800);
    $('form,#tit').fadeIn(400);
    $('.block, .blockvertical').fadeIn(600);
}

window.onscroll = function () {
    var top = window.pageYOffset || document.documentElement.scrollTop
    var nav = document.getElementsByClassName("bannerMenu");
    if (top > 200) {
        $('.bannerMenu').removeClass("bannerMenu")
        .addClass("fixo1");
    }
    else {
        $('.fixo1').removeClass("fixo1")
        .addClass("bannerMenu");
    }
}


function mostrarAltSenha() {

    //var blocoSenha = document.getElementById('alteracaoSenha');
    //var blocoCadastrais = document.getElementById('alteracaoCadastrais');
    $('#alteracaoSenha').show(300);
    $('#alteracaoCadastrais').fadeOut(1);
    $('#Mensagens').fadeOut(1);
}

function mostrarAltDados() {

    //var blocoSenha = document.getElementById('alteracaoSenha');
    //var blocoCadastrais = document.getElementById('alteracaoCadastrais');
    $('#alteracaoCadastrais').show(300);
    $('#alteracaoSenha').fadeOut(1);
    $('#Mensagens').fadeOut(1);
}

function mostrarMensagem() {

    //var blocoSenha = document.getElementById('alteracaoSenha');
    //var blocoCadastrais = document.getElementById('alteracaoCadastrais');
    $('#Mensagens').show(300);
    $('#alteracaoCadastrais').fadeOut(1);
    $('#alteracaoSenha').fadeOut(1);
}


/*function mostrar() {
    var blocoSenha = document.getElementById('alteracaoSenha');
    var blocoCadastrais = document.getElementById('alteracaoCadastrais');

    if (blocoSenha.style.display == "none") {
        mostrarAltSenha();
    }
}*/


function menuMobile(){
    var menu = document.getElementById('menuprincipal');

	
	if(menu.style.display =="block")
	{
	    
	    $(menu).fadeOut(500);
	}
	else
	{
	    $(menu).fadeIn(500);
	}
}


function fotoExpresso()
{
    var fotoCafe = document.getElementById('imgCafe');
    fotoCafe.style.display="none";
    fotoCafe.src = "img/produtos/expresso.png";
    fotoCafe.style.display = "";


    

    

}
function fotoFiltro() {
    var fotoCafe = document.getElementById("imgCafe");
    $(fotoCafe).fadeOut(1);
    $(fotoCafe).fadeIn(500);
    fotoCafe.src = "img/produtos/cafe.jpg";
    


}
function fotoGeladoLeite() {
    var fotoCafe = document.getElementById("imgCafe");
    $(fotoCafe).fadeOut(1);
    fotoCafe.src = "img/produtos/cafeleiteGelado.jpg";
    $(fotoCafe).fadeIn(500);

}
function fotoCap() {
    var fotoCafe = document.getElementById("imgCafe");
    $(fotoCafe).fadeOut(1);
    fotoCafe.src = "img/produtos/cappuccino.jpg";
    $(fotoCafe).fadeIn(500);

}
function fotoCapChoc() {
    var fotoCafe = document.getElementById("imgCafe");
    $(fotoCafe).fadeOut(1);
    fotoCafe.src = "img/produtos/cappuccinoChocolate.jpg";
    $(fotoCafe).fadeIn(500);

}
function fotoChocQ() {
    var fotoCafe = document.getElementById("imgCafe");
    $(fotoCafe).fadeOut(1);
    fotoCafe.src = "img/produtos/chocolateQuente.jpg";
    $(fotoCafe).fadeIn(500);


}
function fotoChocBQ() {
    var fotoCafe = document.getElementById("imgCafe");
    $(fotoCafe).fadeOut(1);
    fotoCafe.src = "img/produtos/chocolateBrancoQuente.jpg";
    $(fotoCafe).fadeIn(500);

}
function fotoRosquinha() {
    var fotoCafe = document.getElementById("imgComida");
    $(fotoCafe).fadeOut(1);
    fotoCafe.src = "img/produtos/rosquinha.jpg";
    $(fotoCafe).fadeIn(500);

}
function fotoEsfiha() {
    var fotoCafe = document.getElementById("imgComida");
    $(fotoCafe).fadeOut(1);
    fotoCafe.src = "img/produtos/esfiha.jpg";
    $(fotoCafe).fadeIn(500);

}
function fotoCoxinha() {
    var fotoCafe = document.getElementById("imgComida");
    $(fotoCafe).fadeOut(1);
    fotoCafe.src = "img/produtos/coxinha.jpg";
    $(fotoCafe).fadeIn(500);

}
function fotoBolo() {
    var fotoCafe = document.getElementById("imgComida");
    $(fotoCafe).fadeOut(1);
    fotoCafe.src = "img/produtos/bolo.jpg";
    $(fotoCafe).fadeIn(500);

}
function fotoBrownie() {
    var fotoCafe = document.getElementById("imgComida");
    $(fotoCafe).fadeOut(1);
    fotoCafe.src = "img/produtos/brownie.jpg";
    $(fotoCafe).fadeIn(500);

}
function fotoCookie() {
    var fotoCafe = document.getElementById("imgComida");
    $(fotoCafe).fadeOut(1);
    fotoCafe.src = "img/produtos/cookie.jpg";
    $(fotoCafe).fadeIn(500);

}
function fotoCupcake() {
    var fotoCafe = document.getElementById("imgComida");
    $(fotoCafe).fadeOut(1);
    fotoCafe.src = "img/produtos/cupcake.jpg";
    $(fotoCafe).fadeIn(500);
}

$(document).onload(function () {
    $('.fotoPrincipalLegenda').fadeOut(500);
});

function mascara(o, f) {
    v_obj = o
    v_fun = f
    setTimeout("execmascara()", 1)
}

function execmascara() {
    v_obj.value = v_fun(v_obj.value)
}


function soNumeros(v) {
    return v.replace(/\D/g, "")
}



function slide1(){
    $("#bannerCaption").fadeIn(500);
    document.getElementById('imgBanner').src = "img/homeimg.JPG";
    document.getElementById('bannerCaption').innerHTML = "<a href='cadastroCliente.aspx'>CADASTRE-SE E FIQUE POR DENTRO DAS NOSSAS NOVIDADES</a>";
    setTimeout("slide2()", 6000)
    $("#bannerCaption").fadeOut(5000);
}
 
function slide2(){
    $("#bannerCaption").fadeIn(500);
    document.getElementById('imgBanner').src = "img/homeimg1.JPG";
    document.getElementById('bannerCaption').innerHTML = "<a href='sobre.aspx'>FAZEMOS MUITO MAIS DO QUE APENAS VENDER CAFÉS, CLIQUE E SAIBA MAIS!</a>";
    setTimeout("slide3()", 6000)
    $("#bannerCaption").fadeOut(5000);
}
 
function slide3(){
    $("#bannerCaption").fadeIn(500);
    document.getElementById('imgBanner').src = "img/homeimg2.JPG";
    document.getElementById('bannerCaption').innerHTML = "<a href='produtos.aspx'>CLIQUE E CONHEÇA UM POUCO DOS NOSSOS PRODUTOS</a>";
    setTimeout("slide1()", 6000)
    $("#bannerCaption").fadeOut(5000);

}
