	USE TiendaComiclandia
	GO

	IF EXISTS( SELECT * FROM sys.objects WHERE name = 'GuardarPedido' AND OBJECTPROPERTY(object_id, 'IsProcedure') = 1)
	BEGIN
		DROP PROCEDURE [dbo].[GuardarPedido]
	END
	GO

	CREATE PROCEDURE dbo.GuardarPedido
	@cedula AS VARCHAR(50),
	@producto AS INT,
	@cantidad AS INT
	AS
	DECLARE @idCliente AS INT;

	SELECT @idCliente = Id
	FROM dbo.Clientes
	WHERE Cedula = CAST(@cedula AS NUMERIC(18,0));

	INSERT INTO dbo.Pedidos(IdCliente, IdProducto, Cantidad)
	VALUES(@idCliente, @producto, @cantidad)

	GO
