SELECT MIN(Tratamento.DataInicial) AS 'Menor Data de Tratamento'
	, Animal.Nome AS 'Nome do Animal'
	 FROM Animal
	 INNER JOIN Consulta ON Consulta.IdAnimal = Animal.IdAnimal
	 INNER JOIN Exame ON Exame.IdConsulta = Consulta.IdConsulta
	 INNER JOIN Tratamento ON Tratamento.IdExame = Exame.IdExame
	 WHERE Tratamento.DataInicial IS NOT NULL
	 GROUP BY Animal.Nome