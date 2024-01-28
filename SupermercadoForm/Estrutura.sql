DROP TABLE IF EXISTS produtos;
DROP TABLE IF EXISTS estantes;
DROP TABLE IF EXISTS categorias;


CREATE TABLE categorias(
	id INT PRIMARY KEY IDENTITY(1,1),
	NOME VARCHAR(25)
);


SELECT id, nome FROM categorias;

CREATE TABLE estantes (
	id INT PRIMARY KEY IDENTITY (1, 1),
	nome  VARCHAR (50) NOT NULL,
	sigla VARCHAR(3) NOT NULL -- NOT NULL é um campo obrigatorio, ou seja,  no cadastro usuario tera que informar
);

INSERT INTO ESTANTES (NOME, SIGLA) VALUES
('Temperos' , 'A01'),
('Massa' , 'A02');

CREATE TABLE produtos(
	id INT PRIMARY KEY IDENTITY(1, 1),
	nome VARCHAR (150) NOT NULL,
	preco_unitario DECIMAL (10, 2) NOT NULL,
	id_categoria INT NOT NULL, -- colua para referenciar a outra tabela

	-- Criando a referencia (dependencia) da tabela de produtos com categorias
	FOREIGN KEY (id_categoria) REFERENCES categorias(id)
);
INSERT INTO categorias (nome) VALUES
	('Padaria'),
	('Limpeza'),
	('Higiene'),
	('Frutas'),
	('Verduras');

INSERT INTO produtos (nome, preco_unitario, id_categoria) VALUES
	('Ajax multiuso', 16.00, 2), -- Categoria Limpeza que possuí o id 2
	('Sabonete Dove', 4.99, 3); -- Categoria Higiene que possuí o id 3

SELECT * FROM produtos;
SELECT * FROM categorias;