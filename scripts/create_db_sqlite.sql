CREATE TABLE FlorGenero
(
       IdFlorGenero INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL,
       Descricao 	VARCHAR(255) NOT NULL
);

CREATE TABLE FlorSubstrato
(
       IdFlorSubstrato INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL,
       Descricao 		VARCHAR(255) NOT NULL
);

CREATE TABLE FlorFertilizante
(
       IdFlorFertilizante 	INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL,
       Descricao 			VARCHAR(255) NOT NULL
);

CREATE TABLE FlorUmidade
(
       IdFlorUmidade INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL,
       Descricao VARCHAR(255) NOT NULL
);
CREATE TABLE FlorLuminosidade
(
       IdFlorLuminosidade 	INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL,
       Descricao 			VARCHAR(255) NOT NULL
);

CREATE TABLE FlorFloracao
(
       IdFlorFloracao 	INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL,
       Descricao 		VARCHAR(255) NOT NULL
);

CREATE TABLE FlorCrescimento
(
       IdFlorCrescimento 	INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL,
       Descricao 			VARCHAR(255) NOT NULL
);

CREATE TABLE FlorOrigem
(
       IdFlorOrigem 		INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL,
       Descricao 			VARCHAR(255) NOT NULL
);

CREATE TABLE FlorTipo
(
       IdFlorTipo 	INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL,
       Descricao 	VARCHAR(255) NOT NULL
);

CREATE TABLE FlorHabitat
(
       IdFlorHabitat 	INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL,
       Descricao 	VARCHAR(255) NOT NULL
);

CREATE TABLE FlorAdubacao
(
       IdFlorAdubacao 	INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL,
       Descricao 		VARCHAR(255) NOT NULL
);

CREATE TABLE FlorFornecedor
(
		IdFlorFornecedor	INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL,
		Nome				VARCHAR(100) NOT NULL
);

CREATE TABLE Flor(
	IdFlor				INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL,
	Especie          	VARCHAR(100) NOT NULL,
	Particularidades          	VARCHAR(1024) NULL,
	Naturalidade       	VARCHAR(40) NULL,
	Caracteristicas    	VARCHAR(1024) NULL,
	TamanhoPlanta     	VARCHAR(50) NULL,
	TamanhoFlor       	VARCHAR(50) NULL,
	Cor                	VARCHAR(50) NULL,
	Hasteal       		INTEGER NULL,
	Perfume            	INTEGER NULL,
	DuracaoFloracao   	INTEGER NULL,
	Cultivo            	VARCHAR(50) NULL,
	DiaFloracao       	DATETIME NULL,
	QuantidadeFlores  	INTEGER NULL,
	QuantidadeHastes  	INTEGER NULL,
	TrocaSubstrato    	DATETIME NULL, 	
	
	IdFlorGenero		INTEGER NOT NULL,
	IdFlorSubstrato     INTEGER NOT NULL,
	IdFlorFertilizante  INTEGER NOT NULL,
	IdFlorUmidade       INTEGER NOT NULL,
	IdFlorLuminosidade  INTEGER NOT NULL,
	IdFlorFloracao      INTEGER NOT NULL,
	IdFlorCrescimento   INTEGER NOT NULL,
	IdFlorOrigem		INTEGER NOT NULL,
	IdFlorTipo			INTEGER NOT NULL,
	IdFlorHabitat		INTEGER NOT NULL,
	IdFlorAdubacao		INTEGER NOT NULL,
	IdFlorFornecedor		INTEGER NULL,
	
	FOREIGN KEY(IdFlorGenero) REFERENCES FlorGenero(IdFlorGenero),
	FOREIGN KEY(IdFlorSubstrato) REFERENCES FlorSubstrato(IdFlorSubstrato),
	FOREIGN KEY(IdFlorFertilizante) REFERENCES FlorFertilizante(IdFlorFertilizante),
	FOREIGN KEY(IdFlorUmidade) REFERENCES FlorUmidade(IdFlorUmidade),
	FOREIGN KEY(IdFlorLuminosidade) REFERENCES FlorLuminosidade(IdFlorLuminosidade),
	FOREIGN KEY(IdFlorFloracao) REFERENCES FlorFloracao(IdFlorFloracao),
	FOREIGN KEY(IdFlorCrescimento) REFERENCES FlorCrescimento(IdFlorCrescimento),
	FOREIGN KEY(IdFlorOrigem) REFERENCES FlorOrigem(IdFlorOrigem),
	FOREIGN KEY(IdFlorTipo) REFERENCES FlorTipo(IdFlorTipo),
	FOREIGN KEY(IdFlorHabitat) REFERENCES FlorHabitat(IdFlorHabitat),
	FOREIGN KEY(IdFlorAdubacao) REFERENCES FlorAdubacao(IdFlorAdubacao),
	FOREIGN KEY(IdFlorFornecedor) REFERENCES FlorFornecedor(IdFlorFornecedor)
);

CREATE TABLE FlorFoto
(
    	IdFlorFoto		INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL,
    	IdFlor      	INTEGER NOT NULL, 
    	Conteudo	BLOB NULL,
    	DataInclusao	DATETIME NOT NULL,
	FOREIGN KEY(IdFlor) REFERENCES Flor(IdFlor)
);

CREATE TABLE FlorUf(
	IdFlorUf		INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL,
	Sigla			VARCHAR(2) NOT NULL
);


CREATE TABLE FlorMeusDados(
	IdFlorMeusDados		INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL,
	Nome          	VARCHAR(150) NOT NULL,
	Endereco       	VARCHAR(255) NULL,
	Complemento      	VARCHAR(50) NULL,
	Bairro       	VARCHAR(50) NULL,
	Cidade       	VARCHAR(50) NULL,
	Telefone    	VARCHAR(20) NULL,
	Celular       	VARCHAR(20) NULL,
	Cep       	VARCHAR(10) NULL,
	Email       	VARCHAR(150) NULL,
	Site       	VARCHAR(40) NULL,
	MSN       	VARCHAR(40) NULL,
	Skype       	VARCHAR(40) NULL,
	Imagem			BLOB NULL,
	IdFlorUf		INTEGER NOT NULL, 
	
	FOREIGN KEY(IdFlorUf) REFERENCES FlorUf(IdFlorUf)
);

CREATE TABLE FlorConfiguracao
(
       IdFlorConfiguracao INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL,
       Background			BLOB NULL       
);



