	USE [FACULTAD]
	GO

	SET ANSI_NULLS ON
	GO
	SET QUOTED_IDENTIFIER ON
	GO	

	CREATE OR ALTER PROCEDURE [dbo].[REGISTRAR_USUARIO]
	@NOMBRE_USUARIO NVARCHAR(50),
	@PASSWORD NVARCHAR(50),
	@id int

	AS 
	BEGIN

	INSERT INTO ProyectoLUG.Usuarios(idUsuario, nombreUsuario, password)
	VALUES(@id,@NOMBRE_USUARIO,@PASSWORD)

	END;