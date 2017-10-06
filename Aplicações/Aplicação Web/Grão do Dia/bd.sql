create database Cafeteria
go 
use Cafeteria
go
CREATE TABLE Categoria (
id_categoria int identity PRIMARY KEY,
descricao VARCHAR(30)
)
go
CREATE TABLE Produto (
id_produto int identity PRIMARY KEY,
preco DECIMAL(10,2),
status_produto VARCHAR(10),
descricao VARCHAR(30),
id_categoria int foreign key references Categoria(id_categoria)
)
go
CREATE TABLE Cargo (
id_cargo int identity PRIMARY KEY,
descricao VARCHAR(30),
permissao VARCHAR(10)
)
go
CREATE TABLE Login_ (
id_login int identity PRIMARY KEY,
usuario VARCHAR(30),
senha VARCHAR(30),
tipo VARCHAR(15)
)
go
CREATE TABLE Funcionario (
id_funcionario int identity PRIMARY KEY,
nome VARCHAR(30),
email VARCHAR(30),
endereco VARCHAR(30),
numero VARCHAR(10),
telefone VARCHAR(15),
cpf VARCHAR(15),
cep VARCHAR(10),
id_cargo int foreign key references Cargo(id_cargo),
id_login int foreign key references Login_(id_login)
)
go
CREATE TABLE Pagamento (
id_pagamento int identity PRIMARY KEY,
descricao VARCHAR(30)
)
go
CREATE TABLE Caixa (
id_caixa int identity PRIMARY KEY,
hora_abertura time,
data_fechamento date,
saldo_inicial DECIMAL(10,2),
data_abertura date,
hora_fechamento time,
id_funcionario int foreign key references Funcionario(id_funcionario)
)
go
CREATE TABLE Movimentacao (
id_movimentacao int identity PRIMARY KEY,
data date,
hora time,
valor DECIMAL(10,2),
descricao VARCHAR(30),
tipo VARCHAR(20),
id_caixa int foreign key references Caixa(id_caixa),
id_pagamento int foreign key references Pagamento(id_pagamento)
)
go
CREATE TABLE Pedido (
id_pedido int identity PRIMARY KEY,
hora_pedido time,
data_pedido date,
id_caixa int foreign key references Caixa(id_caixa),
id_funcionario int foreign key references Funcionario(id_funcionario)
)
go
CREATE TABLE Fornecedor (
id_fornecedor int identity PRIMARY KEY,
telefone VARCHAR(15),
cnpj VARCHAR(20),
email VARCHAR(30),
razao_social VARCHAR(30),
endereco VARCHAR(30),
cep VARCHAR(10),
gerente VARCHAR(30),
complemento VARCHAR(30),
numero VARCHAR(10)
)
go
CREATE TABLE Cliente (
id_cliente int identity PRIMARY KEY,
nome VARCHAR(30),
data_nascimento date,
cpf VARCHAR(15),
email VARCHAR(30),
sexo CHAR(1),
id_login int foreign key references Login_(id_login),
telefone numeric(11)
)
go
CREATE TABLE Contato (
id_contato int identity PRIMARY KEY,
nome VARCHAR(30),
tipo VARCHAR(20),
telefone VARCHAR(15),
mensagem VARCHAR(200),
email VARCHAR(30),
data datetime ,
status_ char
)
go
CREATE TABLE Pedido_Pagamento (
id_pagamento int foreign key references Pagamento(id_pagamento),
id_pedido int foreign key references Pedido(id_pedido),
valor_pagamento DECIMAL(10,2)
)
go
CREATE TABLE Pedido_Produto (
id_pedido int foreign key references Pedido(id_pedido),
id_produto int foreign key references Produto(id_produto),
preco DECIMAL(10,2),
quantidade_produto int
)
go
CREATE TABLE Fornecedor_Produto (
id_produto int foreign key references Produto(id_produto),
id_fornecedor int foreign key references Fornecedor(id_fornecedor),
validade date,
data_entrada date,
quantidade int,
quantidade_minima int,
preco DECIMAL(10,2)

)



select nome, email, telefone, tipo, data, mensagem, status_ from contato

delete from contato

delete from cliente

delete from login_cliente

drop table Cliente

drop table login_cliente

select * from cliente

select * from login_

select count(*) from login_cliente where usuario='Beea' and senha='cebolitos'

select nome_cliente, cpf_cliente, data_nascimento, email_cliente, telefone_cliente  from cliente c inner join login_cliente l
on l.id_login_site=c.id_login_site
where l.usuario='joedsonsts13' and l.senha=123456

select *  from cliente c inner join login_cliente l
on l.id_login_site=c.id_login_site
where l.usuario='joedsonsts13' and l.senha=123456

select count(email_cliente)  from cliente c inner join login_cliente l
on l.id_login_site=c.id_login_site
where l.usuario='joedsonsts13' and c.email_cliente='joedsonsts13@live.com'


update cliente
set email_cliente='joedsonsts13@gmail.com', nome_cliente='Joedson Santana', telefone_cliente=11982247666
from cliente c inner join login_cliente l
on l.id_login_site=c.id_login_site
where l.usuario='joedsonsts13' and l.senha=123456


select senha from login_cliente where usuario='joedsonsts13' and senha=82247666

update login_cliente set senha=123456789 where usuario='joedsonsts13' and senha=82247666


select count(*) from login_cliente where usuario='joedsonsts13' and senha=123456789

insert into Login_(usuario, senha, tipo)
values ('daniel123',1234, 'f')

insert into Funcionario (nome, cpf, email, telefone, id_login)
values ('Daniel', 53880878323, 'daniel123@outlook.com', 1121544438,1)


select * from Login_
select * from Funcionario

update Funcionario set id_login=2 where nome='Daniel'
drop database cafeteria
use master

drop table contato