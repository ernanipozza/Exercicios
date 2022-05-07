SELECT * FROM [ClinicaVeterinaria].[dbo].[Cliente]
SELECT * FROM [ClinicaVeterinaria].[dbo].[Animal]
SELECT * FROM [ClinicaVeterinaria].[dbo].[Especie]
SELECT * FROM [ClinicaVeterinaria].[dbo].[Consulta]
SELECT * FROM [ClinicaVeterinaria].[dbo].[Exame]
SELECT * FROM [ClinicaVeterinaria].[dbo].[Tratamento]


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

