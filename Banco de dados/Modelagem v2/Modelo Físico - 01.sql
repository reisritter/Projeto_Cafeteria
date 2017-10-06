CREATE TABLE Produto (
id_produto int identity PRIMARY KEY,
preco DECIMAL(10,2),
status VARCHAR(10),
descricao VARCHAR(30),
id_categoria int
)

CREATE TABLE Categoria (
id_categoria int identity PRIMARY KEY,
descricao VARCHAR(30)
)

CREATE TABLE Pedido (
id_pedido int identity PRIMARY KEY,
hora_pedido time,
data_pedido date,
id_caixa int,
id_funcionario int
)

CREATE TABLE Cargo (
id_cargo int identity PRIMARY KEY,
descricao VARCHAR(30),
permissao VARCHAR(10)
)

CREATE TABLE Login (
id_login int identity PRIMARY KEY,
usuario VARCHAR(30),
senha VARCHAR(30),
tipo VARCHAR(15)
)

CREATE TABLE Movimentacao (
id_movimentacao int identity PRIMARY KEY,
data date,
hora time,
valor DECIMAL(10,2),
descricao VARCHAR(30),
tipo VARCHAR(20),
id_caixa int,
id_pagamento int
)

CREATE TABLE Caixa (
id_caixa int identity PRIMARY KEY,
hora_abertura time,
data_fechamento date,
saldo_inicial DECIMAL(10,2),
data_abertura date,
hora_fechamento time,
id_funcionario int
)

CREATE TABLE Funcionario (
id_funcionario int identity PRIMARY KEY,
nome VARCHAR(30),
email VARCHAR(30),
endereco VARCHAR(30),
numero VARCHAR(10),
telefone VARCHAR(15),
cpf VARCHAR(15),
cep VARCHAR(10),
id_cargo int,
id_login int,
FOREIGN KEY(id_cargo) REFERENCES Cargo (id_cargo),
FOREIGN KEY(id_login) REFERENCES Login (id_login)
)

CREATE TABLE Pagamento (
id_pagamento int identity PRIMARY KEY,
descricao VARCHAR(30)
)

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

CREATE TABLE Cliente (
id_cliente int identity PRIMARY KEY,
nome VARCHAR(30),
data_nascimento date,
cpf VARCHAR(15),
email VARCHAR(30),
sexo CHAR(1),
id_login int,
FOREIGN KEY(id_login) REFERENCES Login (id_login)
)

CREATE TABLE Contato (
id_contato int identity PRIMARY KEY,
nome VARCHAR(30),
tipo VARCHAR(20),
telefone VARCHAR(15),
mensagem VARCHAR(100),
email VARCHAR(30)
)

CREATE TABLE Pedido_Pagamento (
id_pagamento int,
id_pedido int,
valor_pagamento DECIMAL(10,2),
FOREIGN KEY(id_pagamento) REFERENCES Pagamento (id_pagamento),
FOREIGN KEY(id_pedido) REFERENCES Pedido (id_pedido)
)

CREATE TABLE Pedido_Produto (
id_pedido int,
id_produto int,
preco DECIMAL(10,2),
quantidade_produto int,
FOREIGN KEY(id_pedido) REFERENCES Pedido (id_pedido),
FOREIGN KEY(id_produto) REFERENCES Produto (id_produto)
)

CREATE TABLE Fornecedor_Produto (
id_produto int,
id_fornecedor int,
validade date,
data_entrada date,
quantidade int,
quantidade_minima int,
preco DECIMAL(10,2),
FOREIGN KEY(id_produto) REFERENCES Produto (id_produto),
FOREIGN KEY(id_fornecedor) REFERENCES Fornecedor (id_fornecedor)
)

ALTER TABLE Produto ADD FOREIGN KEY(id_categoria) REFERENCES Categoria (id_categoria)
ALTER TABLE Pedido ADD FOREIGN KEY(id_caixa) REFERENCES Caixa (id_caixa)
ALTER TABLE Pedido ADD FOREIGN KEY(id_funcionario) REFERENCES Funcionario (id_funcionario)
ALTER TABLE Movimentacao ADD FOREIGN KEY(id_caixa) REFERENCES Caixa (id_caixa)
ALTER TABLE Movimentacao ADD FOREIGN KEY(id_pagamento) REFERENCES Pagamento (id_pagamento)
ALTER TABLE Caixa ADD FOREIGN KEY(id_funcionario) REFERENCES Funcionario (id_funcionario)
