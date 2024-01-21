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