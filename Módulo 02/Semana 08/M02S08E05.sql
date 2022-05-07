SELECT * FROM [ClinicaVeterinaria].[dbo].[Veterinario]
SELECT * FROM [ClinicaVeterinaria].[dbo].[Consulta]
SELECT * FROM [ClinicaVeterinaria].[dbo].[Exame]
SELECT * FROM [ClinicaVeterinaria].[dbo].[Tratamento]

SELECT * FROM [ClinicaVeterinaria].[dbo].[Veterinario] WHERE Nome LIKE '%a%'

SELECT * FROM Veterinario
	JOIN Consulta ON Veterinario.IdVeterinario = Consulta.IdVeterinario
	JOIN Exame ON Consulta.IdConsulta = Exame.IdConsulta
	JOIN Tratamento ON Exame.IdConsulta = Tratamento.IdExame
	WHERE Veterinario.Nome LIKE '%a%'