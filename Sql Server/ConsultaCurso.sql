USE Prueba 
GO

BEGIN TRANSACTION

DELETE FROM Personas
WHERE Id = 8

COMMIT

ROLLBACK

SELECT Id,Nombre,Edad 
FROM Personas

--Insertar registros en la tabla 
INSERT INTO Personas(Nombre, Edad)
VALUES('Carlos', 43)

--Insertar varios registros
INSERT INTO Personas(Nombre, Edad)
VALUES ('Juan', 54),
	   ('Heymar', 22)

INSERT INTO Personas(Nombre)
VALUES ('Pedro')

--selecciona nombre 
SELECT Nombre FROM Personas

SELECT * FROM Personas

--Apodar columnas
SELECT Id as Identificacion, Nombre as nombrePersona FROM Personas

--Where 
SELECT * FROM Personas
WHERE Edad > 22

--Null
SELECT * FROM Personas
WHERE Edad IS NULL

--IN
SELECT Id as Identificacion,Nombre FROM Personas 
WHERE Id IN(1,3) AND Nombre = 'Carlos'

SELECT * FROM Personas
WHERE Id = 4

--DELETE FROM
DELETE Personas
WHERE Id = 4

--Actualizar campo 
UPDATE Personas
SET Edad = 43
WHERE Nombre = 'Pedro'


--Seleccionamos paises
SELECT * FROM Paises

--Seleccionamos personas 
SELECT persona.Id,Nombre,Edad,Pais FROM Personas persona 
INNER JOIN Paises pais
ON persona.IdPais = pais.IdPais


--Insertar nuevo registro de Persona
INSERT INTO Personas(Nombre,Edad,IdPais)
VALUES('Jairo', 32, 5)

--Filtrar
SELECT * FROM Personas 
WHERE IdPais = 5
