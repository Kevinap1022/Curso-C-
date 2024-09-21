--EXEC SP_BuscarPersonaXPais 5

USE Prueba
GO

--Crear variable de pais
DECLARE @IdPais INT
SET @IdPais =5

--Filtrar persona 
SELECT * FROM Personas
WHERE IdPais = @IdPais


