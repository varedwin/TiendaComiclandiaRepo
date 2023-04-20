	USE TiendaComiclandia
	GO

	IF EXISTS( SELECT * FROM sys.objects WHERE name = 'GuardarActualizarCliente' AND OBJECTPROPERTY(object_id, 'IsProcedure') = 1)
	BEGIN
		DROP PROCEDURE [dbo].[GuardarActualizarCliente]
	END
	GO

	CREATE PROCEDURE dbo.GuardarActualizarCliente
	@nombre AS VARCHAR(50),
	@apellido AS VARCHAR(50),
	@cedula AS  VARCHAR(50),
	@direccion AS VARCHAR(50)
	AS
	DECLARE @cedulaConsulta AS NUMERIC(18,0);
	DECLARE @direccionConsulta AS VARCHAR(50);

	SELECT @cedulaConsulta = Cedula, @direccionConsulta = Direccion
	FROM dbo.Clientes
	WHERE Cedula = CAST(@cedula AS NUMERIC(18,0));

	IF @cedulaConsulta IS NULL
	BEGIN
		INSERT INTO dbo.Clientes(Nombre, Apellido, Cedula, Direccion)
		VALUES(@nombre, @apellido, CAST(@cedula AS NUMERIC(18,0)), @direccion)
	END
	ELSE 
	BEGIN
	IF @direccionConsulta <> @direccion
	BEGIN
		UPDATE dbo.Clientes
		SET Direccion = @direccion
		WHERE Cedula = @cedula
	END

	END

	GO
