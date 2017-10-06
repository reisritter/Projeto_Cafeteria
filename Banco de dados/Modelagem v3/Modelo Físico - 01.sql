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
usuario VARCHAR(30) unique,
senha VARCHAR(30) ,
tipo VARCHAR(15)
)
go
CREATE TABLE Funcionario (
id_funcionario int identity PRIMARY KEY,
nome VARCHAR(30),
email VARCHAR(30) unique,
endereco VARCHAR(30),
numero VARCHAR(10),
telefone VARCHAR(15),
cpf VARCHAR(15) unique,
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
cnpj VARCHAR(20) unique,
email VARCHAR(30) unique,
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
cpf VARCHAR(15) unique,
email VARCHAR(30) unique,
sexo CHAR(1),
id_login int foreign key references Login_(id_login)
)
go
CREATE TABLE Contato (
id_contato int identity PRIMARY KEY,
nome VARCHAR(30),
tipo VARCHAR(20),
telefone VARCHAR(15),
mensagem VARCHAR(100),
email VARCHAR(30)
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

