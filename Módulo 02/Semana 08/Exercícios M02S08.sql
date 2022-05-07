--EXERCÍCIOS MÓDULO 02 - SEMANA 08

--Exercícios 03 e 04
CREATE TABLE Cliente (
	 IdCliente INT PRIMARY KEY IDENTITY (1,1) NOT NULL
	,Nome VARCHAR (100) NOT NULL
	,Endereco VARCHAR (200) NOT NULL
	,Bairro VARCHAR (100) NOT NULL
	,CEP VARCHAR (10) NOT NULL
	,Cidade VARCHAR(100) NOT NULL
	,Estado VARCHAR (50) NOT NULL
	,Telefone VARCHAR (50) NOT NULL
)
INSERT INTO Cliente (Nome, Endereco, Bairro, CEP, Cidade, Estado, Telefone) VALUES ('Jonocléssio das Candongas', 'Rua das Piraporinhas, 25', 'Boitexburgo', '88.888-888', 'Major Gercino', 'Santa Catarina', '(48)99999-9999')
INSERT INTO Cliente (Nome, Endereco, Bairro, CEP, Cidade, Estado, Telefone) VALUES ('Biribalda Silvelia', 'Avenida Kuduairo, 1737', 'Porto da Galera', '65873368', 'Canelinha', 'Santa Catarina', '(48)98765-4321')
INSERT INTO Cliente (Nome, Endereco, Bairro, CEP, Cidade, Estado, Telefone) VALUES ('Renoil Almerst', 'Praça da Ampléia, 903', 'Loeffelscheidt', '98765-432', 'Águas Mornas', 'Santa Catarina', '48-995446587')
INSERT INTO Cliente (Nome, Endereco, Bairro, CEP, Cidade, Estado, Telefone) VALUES ('Tabiraldo Jeneci', 'Rua Geral, SN', 'Rio do Meio', '01.234-567', 'Anitápolis', 'Santa Catarina', '48-988749987')
INSERT INTO Cliente (Nome, Endereco, Bairro, CEP, Cidade, Estado, Telefone) VALUES ('Zenilda Paratts', 'Rua das Ingazeiras, 447', 'Pinguirito', '97846-555', 'Alfredo Wagner', 'Santa Catarina', '48-999663322')
SELECT * FROM ClinicaVeterinaria.dbo.Cliente

CREATE TABLE Especie (
	 IdEspecie INT PRIMARY KEY IDENTITY (1,1) NOT NULL
	,Descricao VARCHAR (300) NOT NULL
	,Nome VARCHAR (100) NOT NULL
)
INSERT INTO Especie (Descricao, Nome) VALUES ('Animal da família dos canídeos, tudo sem vergonha!', 'Cachorro')
INSERT INTO Especie (Descricao, Nome) VALUES ('Animal da família dos felídeos, tudo safado!', 'Gato')
INSERT INTO Especie (Descricao, Nome) VALUES ('LUGAR DE PASSARINHO É FORA DA GAIOLA!', 'Passarinho')
INSERT INTO Especie (Descricao, Nome) VALUES ('LUGAR DE PEIXE É NO OCEANO OU RIO OU LAGO OU LAGOA', 'Peixe')
INSERT INTO Especie (Descricao, Nome) VALUES ('Ué, por que não?', 'Vaca')
INSERT INTO Especie (Descricao, Nome) VALUES ('Eita, pera lá companheiro!', 'Girafa')
SELECT * FROM ClinicaVeterinaria.dbo.Especie

CREATE TABLE Animal (
	 IdAnimal INT PRIMARY KEY IDENTITY (1,1) NOT NULL
	,Nome VARCHAR (100) NOT NULL
	,Idade INT NOT NULL
	,Sexo VARCHAR (20) NOT NULL
	,IdEspecie INT NOT NULL
	,IdCliente INT NOT NULL
	,CONSTRAINT fk_IdEspecie FOREIGN KEY (IdEspecie) REFERENCES Especie(IdEspecie)
	,CONSTRAINT fk_IdCliente FOREIGN KEY (IdCliente) REFERENCES Cliente(IdCliente)
)
INSERT INTO Animal (Nome, Idade, Sexo, IdEspecie, IdCliente) VALUES ('Bodocks', 12, 'M', 1, 1)
INSERT INTO Animal (Nome, Idade, Sexo, IdEspecie, IdCliente) VALUES ('Canélis', 7, 'M', 2, 2)
INSERT INTO Animal (Nome, Idade, Sexo, IdEspecie, IdCliente) VALUES ('Bibiribs', 4, 'F', 2, 3)
INSERT INTO Animal (Nome, Idade, Sexo, IdEspecie, IdCliente) VALUES ('Arya', 3, 'F', 3, 4)
INSERT INTO Animal (Nome, Idade, Sexo, IdEspecie, IdCliente) VALUES ('Senegas', 8, 'M', 4, 5)
INSERT INTO Animal (Nome, Idade, Sexo, IdEspecie, IdCliente) VALUES ('Zenóbio', 25, 'F', 6, 1)
INSERT INTO Animal (Nome, Idade, Sexo, IdEspecie, IdCliente) VALUES ('Gantigo', 9, 'F', 5, 2)
INSERT INTO Animal (Nome, Idade, Sexo, IdEspecie, IdCliente) VALUES ('Madruga', 4, 'M', 4, 3)
INSERT INTO Animal (Nome, Idade, Sexo, IdEspecie, IdCliente) VALUES ('Elesbão', 19, 'M', 6, 4)
INSERT INTO Animal (Nome, Idade, Sexo, IdEspecie, IdCliente) VALUES ('Findol', 1, 'F', 3, 5)
SELECT * FROM ClinicaVeterinaria.dbo.Animal

CREATE TABLE Veterinario (
	 IdVeterinario INT PRIMARY KEY IDENTITY (1,1) NOT NULL
	,Nome VARCHAR (100) NOT NULL
	,Endereco VARCHAR (200) NOT NULL
	,Telefone VARCHAR (50) NOT NULL
)
INSERT INTO Veterinario (Nome, Endereco, Telefone) VALUES ('Joilson das Neves', 'Rua Ali Perto, 25', '48987412365')
INSERT INTO Veterinario (Nome, Endereco, Telefone) VALUES ('Anne Dupont', 'Avenida das Camélias, 498', '48-998550236')
INSERT INTO Veterinario (Nome, Endereco, Telefone) VALUES ('Djeimes Sullivon', 'Rua do Intizico, SN', '48-966632587')
INSERT INTO Veterinario (Nome, Endereco, Telefone) VALUES ('Renildo Ronivelson', 'Barco Z11', 'S/N')
INSERT INTO Veterinario (Nome, Endereco, Telefone) VALUES ('Pedrita Silvelina', 'Avenida Dr. Caratildes, 4777', '32323235')
SELECT * FROM ClinicaVeterinaria.dbo.Veterinario

CREATE TABLE Consulta (
	 IdConsulta INT PRIMARY KEY IDENTITY (1,1) NOT NULL
	,DataConsulta DATETIME NOT NULL
	,IdAnimal INT NOT NULL
	,IdVeterinario INT NOT NULL
	,CONSTRAINT fk_IdAnimal FOREIGN KEY (IdAnimal) REFERENCES Animal(IdAnimal)
	,CONSTRAINT fk_IdVeterinario FOREIGN KEY (IdVeterinario) REFERENCES Veterinario(IdVeterinario)
)
INSERT INTO Consulta (DataConsulta, IdAnimal, IdVeterinario) VALUES ('2022-03-25', 4, 1)
INSERT INTO Consulta (DataConsulta, IdAnimal, IdVeterinario) VALUES ('2022-03-25', 6, 2)
INSERT INTO Consulta (DataConsulta, IdAnimal, IdVeterinario) VALUES ('2022-03-25', 5, 3)
INSERT INTO Consulta (DataConsulta, IdAnimal, IdVeterinario) VALUES ('2022-03-25', 3, 4)
INSERT INTO Consulta (DataConsulta, IdAnimal, IdVeterinario) VALUES ('2022-03-25', 7, 5)
INSERT INTO Consulta (DataConsulta, IdAnimal, IdVeterinario) VALUES ('2022-03-25', 10, 1)
INSERT INTO Consulta (DataConsulta, IdAnimal, IdVeterinario) VALUES ('2022-03-25', 2, 2)
INSERT INTO Consulta (DataConsulta, IdAnimal, IdVeterinario) VALUES ('2022-03-25', 9, 3)
INSERT INTO Consulta (DataConsulta, IdAnimal, IdVeterinario) VALUES ('2022-03-25', 8, 4)
INSERT INTO Consulta (DataConsulta, IdAnimal, IdVeterinario) VALUES ('2022-03-25', 1, 5)
SELECT * FROM ClinicaVeterinaria.dbo.Consulta

CREATE TABLE Exame (
	 IdExame INT PRIMARY KEY IDENTITY (1,1) NOT NULL
	,Descricao VARCHAR (300) NOT NULL
	,IdConsulta INT NOT NULL
	,CONSTRAINT fk_IdConsulta FOREIGN KEY (IdConsulta) REFERENCES Consulta(IdConsulta)
)
INSERT INTO Exame (Descricao, IdConsulta) VALUES ('Raio-X da pata', 10)
INSERT INTO Exame (Descricao, IdConsulta) VALUES ('Exame de sangue', 2)
INSERT INTO Exame (Descricao, IdConsulta) VALUES ('Ultrassonografia', 4)
INSERT INTO Exame (Descricao, IdConsulta) VALUES ('Raio-X da coluna', 9)
INSERT INTO Exame (Descricao, IdConsulta) VALUES ('Cultura bacteriológica', 10)
INSERT INTO Exame (Descricao, IdConsulta) VALUES ('Exame de sangue', 5)
INSERT INTO Exame (Descricao, IdConsulta) VALUES ('Ultrassonografia', 3)
INSERT INTO Exame (Descricao, IdConsulta) VALUES ('Exame de Sangue', 1)
SELECT * FROM ClinicaVeterinaria.dbo.Exame

CREATE TABLE Tratamento (
	 IdTratamento INT PRIMARY KEY IDENTITY (1,1) NOT NULL
	,DataInicial DATETIME NOT NULL
	,DataFinal DATETIME NOT NULL
	,IdConsulta INT NOT NULL
	,IdExame INT NOT NULL
	,Descricao VARCHAR (300) NOT NULL
	,CONSTRAINT fk_IdConsulta2 FOREIGN KEY (IdConsulta) REFERENCES Consulta(IdConsulta)
	,CONSTRAINT fk_IdExame FOREIGN KEY (IdExame) REFERENCES Exame(IdExame)
)
INSERT INTO Tratamento (DataInicial, DataFinal, IdConsulta, IdExame, Descricao) VALUES ('2022-03-25', '2022-07-25', 10, 1, 'Fisioterapia')
INSERT INTO Tratamento (DataInicial, DataFinal, IdConsulta, IdExame, Descricao) VALUES ('2022-03-25', '2022-03-30', 4, 3, 'Anti-inflamatório')
INSERT INTO Tratamento (DataInicial, DataFinal, IdConsulta, IdExame, Descricao) VALUES ('2022-03-25', '2022-04-10', 1, 8, 'Antibiótico')
INSERT INTO Tratamento (DataInicial, DataFinal, IdConsulta, IdExame, Descricao) VALUES ('2022-03-25', '2022-03-26', 9, 4, 'Sacrificar, tadinho.')
INSERT INTO Tratamento (DataInicial, DataFinal, IdConsulta, IdExame, Descricao) VALUES ('2022-03-25', '2022-05-03', 5, 6, 'Antifúngico')
SELECT * FROM ClinicaVeterinaria.dbo.Tratamento

--Exercício 05
SELECT * FROM Veterinario
	JOIN Consulta ON Veterinario.IdVeterinario = Consulta.IdVeterinario
	JOIN Exame ON Consulta.IdConsulta = Exame.IdConsulta
	JOIN Tratamento ON Exame.IdConsulta = Tratamento.IdExame
	WHERE Veterinario.Nome LIKE '%a%'

--Exercício 06
SELECT Animal.Nome AS 'Nome do Animal'
	 , Animal.Sexo AS 'Sexo do Animal'
	 , Animal.Idade AS 'Idade do Animal'
	 , Cliente.IdCliente
	 , Cliente.Nome AS 'Nome do Cliente'
	 , Cliente.Telefone
	 , Consulta.DataConsulta AS 'Data da Consulta'
	 , Tratamento.Descricao AS 'Tipo de Tratamento'
	 FROM  Animal
	 LEFT JOIN Cliente ON Cliente.IdCliente = Animal.IdCliente
	 LEFT JOIN Consulta ON Consulta.IdAnimal = Animal.IdAnimal
	 LEFT JOIN Exame ON Exame.IdConsulta = Consulta.IdConsulta
	 LEFT JOIN Tratamento on Tratamento.IdExame = Exame.IdExame
	 WHERE Tratamento.Descricao IS NOT NULL
	 ORDER BY Cliente.IdCliente

--Exercício 07
SELECT COUNT(IdAnimal) AS 'Total de Animais Cadastrados' FROM Animal

--Exercício 08
SELECT MIN(Tratamento.DataInicial) AS 'Menor Data de Tratamento'
	, Animal.Nome AS 'Nome do Animal'
	 FROM Animal
	 INNER JOIN Consulta ON Consulta.IdAnimal = Animal.IdAnimal
	 INNER JOIN Exame ON Exame.IdConsulta = Consulta.IdConsulta
	 INNER JOIN Tratamento ON Tratamento.IdExame = Exame.IdExame
	 WHERE Tratamento.DataInicial IS NOT NULL
	 GROUP BY Animal.Nome

--Exercício 09
SELECT Animal.Nome AS 'Nome do Animal'
	 , Animal.Sexo AS 'Sexo do Animal'
	 , Animal.Idade AS 'Idade do Animal'
	 , Cliente.IdCliente
	 , Cliente.Nome AS 'Nome do Cliente'
	 , Cliente.Telefone
	 , Consulta.DataConsulta AS 'Data da Consulta'
	 FROM  Animal
	 FULL OUTER JOIN Cliente ON Cliente.IdCliente = Animal.IdCliente
	 FULL OUTER JOIN Consulta ON Consulta.IdAnimal = Animal.IdAnimal
	 FULL OUTER JOIN Exame ON Exame.IdConsulta = Consulta.IdConsulta
	 FULL OUTER JOIN Tratamento on Tratamento.IdExame = Exame.IdExame
	 WHERE Animal.Nome IS NOT NULL
	 ORDER BY Cliente.IdCliente

--Exercício 10
SELECT Animal.Nome AS 'Nome do Animal'
	 , Animal.Sexo AS 'Sexo do Animal'
	 , Animal.Idade AS 'Idade do Animal'
	 , Cliente.IdCliente
	 , Cliente.Nome AS 'Nome do Cliente'
	 , Cliente.Telefone
	 , Consulta.DataConsulta AS 'Data da Consulta'
	 FROM  Animal
	 RIGHT JOIN Cliente ON Cliente.IdCliente = Animal.IdCliente
	 RIGHT JOIN Consulta ON Consulta.IdAnimal = Animal.IdAnimal
	 RIGHT JOIN Exame ON Exame.IdConsulta = Consulta.IdConsulta
	 RIGHT JOIN Tratamento on Tratamento.IdExame = Exame.IdExame
	 WHERE Animal.Nome IS NOT NULL
	 ORDER BY Cliente.IdCliente