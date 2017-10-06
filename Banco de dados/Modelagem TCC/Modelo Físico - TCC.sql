create database CafeteriaTCC
use CafeteriaTCC
go
CREATE TABLE Fornecedor (
id_fornecedor int identity PRIMARY KEY,
razao_social VARCHAR(30),
cnpj VARCHAR(20),
email VARCHAR(30),
telefone VARCHAR(15),
gerente VARCHAR(30),
endereco VARCHAR(30),
bairro varchar(30),
cidade varchar(30),
uf varchar(2),
cep VARCHAR(10),
complemento VARCHAR(30),
numero VARCHAR(10)
)
go
CREATE TABLE Categoria (
id_categoria int identity PRIMARY KEY,
descricao VARCHAR(30)
)
go
CREATE TABLE Produto (
id_produto int identity PRIMARY KEY,
preco DECIMAL(6,2),
status_ VARCHAR(20),
descricao VARCHAR(30),
imagem VARCHAR(200),
id_categoria int foreign key references Categoria(id_categoria)
)
go
CREATE TABLE Fornecedor_Produto (
id_produto int foreign key references Produto(id_produto),
id_fornecedor int foreign key references Fornecedor(id_fornecedor),
data_entrada date,
quantidade int,
quantidade_minima int,
preco DECIMAL(6,2)
)
go
CREATE TABLE Login_ (
id_login int identity PRIMARY KEY,
usuario VARCHAR(30),
senha VARCHAR(30),
tipo VARCHAR(15),
lembrete varchar(200)
)
go
CREATE TABLE Cargo (
id_cargo int identity PRIMARY KEY,
descricao VARCHAR(30),
permissao VARCHAR(10)
)
go
CREATE TABLE Funcionario (
id_funcionario int identity PRIMARY KEY,
nome VARCHAR(30),
email VARCHAR(30),
endereco VARCHAR(30),
bairro varchar(30),
cidade varchar(30),
uf varchar(2),
numero VARCHAR(10),
telefone VARCHAR(15),
cpf VARCHAR(15),
cep VARCHAR(10),
id_cargo int FOREIGN KEY REFERENCES Cargo (id_cargo),
id_login int FOREIGN KEY REFERENCES Login_ (id_login)
)
go
CREATE TABLE Caixa (
id_caixa int identity PRIMARY KEY,
hora_abertura time,
data_fechamento date,
saldo_inicial DECIMAL(6,2),
data_abertura date,
hora_fechamento time,
id_funcionario int foreign key references Funcionario(id_funcionario)
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
CREATE TABLE Pedido_Produto (
id_pedido int foreign key references Pedido(id_pedido),
id_produto int foreign key references Produto(id_produto),
preco DECIMAL(6,2),
quantidade_produto int
)
go
CREATE TABLE Pagamento (
id_pagamento int identity PRIMARY KEY,
descricao VARCHAR(30)
)
go
CREATE TABLE Pedido_Pagamento (
id_pagamento int foreign key references Pagamento(id_pagamento),
id_pedido int foreign key references Pedido(id_pedido),
valor_pagamento DECIMAL(10,2)
)
go
CREATE TABLE Movimentacao (
id_movimentacao int identity PRIMARY KEY,
data date,
hora time,
valor DECIMAL(6,2),
descricao VARCHAR(30),
tipo VARCHAR(20),
id_caixa int foreign key references Caixa(id_caixa)
)
go
CREATE TABLE Movimentacao_Pagamento
(
id_movimentacao int foreign key references Movimentacao(id_movimentacao),
id_pagamento int foreign key references Pagamento(id_pagamento),
valor decimal(6,2)
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
telefone varchar(11),
novidade varchar
)
go
CREATE TABLE Contato (
id_contato int identity PRIMARY KEY,
nome VARCHAR(30),
tipo VARCHAR(20),
telefone VARCHAR(15),
mensagem VARCHAR(500),
email VARCHAR(30),
data date,
status_ char
)
go
CREATE TABLE Reserva
(
id_reserva int identity primary key,
id_cliente int foreign key references Cliente(id_cliente),
dataReserva datetime,
dataReservada datetime,
reservado varchar
)
go
CREATE TABLE opniaoCli
(
id_opniao int identity primary key,
id_cliente int foreign key references Cliente(id_cliente),
msgOpniao varchar(255),
dataOpniao datetime,
avalOpniao varchar,
statusOpniao varchar(255)
)
go
CREATE TABLE ContatoResp
(
id_ContatoResp int identity primary key,
id_contato int foreign key references Contato(id_contato),
remetente varchar(255),
mensagem_resp varchar(255),
dataResp datetime
)