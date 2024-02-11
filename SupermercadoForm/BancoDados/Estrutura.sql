DROP TABLE IF EXISTS estoques;
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
	('Sabonete Dove', 4.99, 3), -- Categoria Higiene que possuí o id 3
	('Shampoo Dove', 4.99, 3), -- Categoria Higiene que possuí o id 3
	('Pão francês', 43.99, 1), -- Categoria Padaria que possuí o id 3
	('Sabonete Lux', 4.99, 3), -- Categoria Higiene que possuí o id 3
	('Pasta de dente Colgate', 14.99, 3), -- Categoria Higiene que possuí o id 3
	('Pasta de dente Soriso', 24.99, 3), -- Categoria Higiene que possuí o id 3
	('Escova de dente Condor', 34.99, 3), -- Categoria Higiene que possuí o id 3
	('Pastel de carne', 45.0, 1), -- Categoria Padaria que possuí o id 3
	('Escova de dente Soriso', 44.99, 3), -- Categoria Higiene que possuí o id 3
	('Manga', 4.99, 4), -- Categoria Frutas que possuí o id 4
	('Pão integral', 41.99, 1), -- Categoria Padaria que possuí o id 3
	('Shampoo Seda', 4.99, 3), -- Categoria Higiene que possuí o id 3
	('Melancia', 3.99, 4), -- Categoria Frutas que possuí o id 4
	('Cebola', 3.99, 5), -- Categoria Verduras que possuí o id 5
	('Pastel de frango', 3.99, 1), -- Categoria Padaria que possuí o id 3
	('Cenoura', 3.99, 5), -- Categoria Verduras que possuí o id 5
	('Batata', 3.99, 5), -- Categoria Verduras que possuí o id 5
	('Pastel de pizza', 41.99, 1), -- Categoria Padaria que possuí o id 3
	('Maça', 24.99, 4), -- Categoria Frutas que possuí o id 4
	('Uva', 3.99, 4), -- Categoria Frutas que possuí o id 4
	('Laranja', 7.99, 4), -- Categoria Frutas que possuí o id 4
	('Mamão', 9.99, 4), -- Categoria Frutas que possuí o id 4
	('Morango', 2.99, 4), -- Categoria Frutas que possuí o id 4
	('Pimentão', 3.99, 5); -- Categoria Verduras que possuí o id 5
SELECT * FROM produtos;
SELECT * FROM categorias;

CREATE TABLE estoques(
	id INT PRIMARY KEY IDENTITY(1, 1),
	quantidade INT NOT NULL,
	id_produto INT NOT NULL, -- coluna para referenciar a outra tabela

	FOREIGN KEY (id_produto) REFERENCES produtos(id)
);
