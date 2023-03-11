USE PASTELERIA
GO

------ PROCEDIMIENTOS ALMACENADOS
-- USUARIOS
-- LISTAR
CREATE PROCEDURE SPU_USUARIOS_LISTAR
@estado			BIT
AS BEGIN
	SELECT  USUARIOS.idusuario, 
			PERSONAS.apellidos, PERSONAS.nombres,
			ROLES.rol,USUARIOS.nombreusuario
		FROM USUARIOS
		INNER JOIN PERSONAS ON PERSONAS.idpersona = USUARIOS.idpersona
		INNER JOIN ROLES ON ROLES.idrol = USUARIOS.idrol
		WHERE USUARIOS.estado = @estado
		ORDER BY idusuario DESC
END 
GO

-- INSERTAR
CREATE PROCEDURE SPU_USUARIOS_INSERTAR
@idpersona		INT,
@idrol			INT,
@nombreusuario	VARCHAR(30),
@claveacceso	VARCHAR(200)
AS BEGIN
	INSERT INTO USUARIOS (idpersona, idrol, nombreusuario, claveacceso) 
		VALUES (@idpersona, @idrol, @nombreusuario, @claveacceso)
END
GO

-- EDITAR
CREATE PROCEDURE SPU_USUARIOS_EDITAR
@idusuario		INT,
@idpersona		INT,
@idrol			INT,
@nombreusuario	VARCHAR(30),
@claveacceso	VARCHAR(200)
AS BEGIN
	UPDATE USUARIOS SET
		idpersona = @idpersona,
		idrol = @idrol,
		nombreusuario = @nombreusuario,
		claveacceso = @claveacceso
	WHERE idusuario = @idusuario
END
GO

-- BUSCAR
CREATE PROCEDURE SPU_USUARIOS_BUSCAR
@idusuario		INT
AS BEGIN
	SELECT *
		FROM USUARIOS
		WHERE idusuario = @idusuario
END
GO

-- ELIMINAR
CREATE PROCEDURE SPU_USUARIOS_ELIMINAR
@idusuario		INT
AS BEGIN
	UPDATE USUARIOS SET
		estado = 0
	WHERE idusuario = @idusuario
END
GO

-- ACTIVAR
CREATE PROCEDURE SPU_USUARIOS_ACTIVAR
@idusuario		INT
AS BEGIN
	UPDATE USUARIOS SET
		estado = 1
	WHERE idusuario = @idusuario
END
GO

-- LOGIN
CREATE PROCEDURE SPU_USUARIOS_LOGIN
@nombreusuario	VARCHAR(30)
AS BEGIN
	SELECT	USUARIOS.idusuario, PERSONAS.nombres, PERSONAS.apellidos,
			USUARIOS.nombreusuario, USUARIOS.claveacceso, ROLES.rol
		FROM usuarios
		INNER JOIN PERSONAS ON USUARIOS.idpersona = PERSONAS.idpersona
		INNER JOIN ROLES ON USUARIOS.idrol = ROLES.idrol
		WHERE USUARIOS.nombreusuario = @nombreusuario AND USUARIOS.estado = 1
END
GO

------------------------------------
-- PERSONAS 
-- LISTAR
CREATE PROCEDURE SPU_PERSONAS_LISTAR
@estado			BIT
AS BEGIN
	SELECT  idpersona, apellidos, nombres, dni, direccion, telefono, email,
			apellidos + ' ' + nombres as nombrecompleto
		FROM PERSONAS
		WHERE estado = @estado
		ORDER BY idpersona DESC
END 
GO

-- INSERTAR
CREATE PROCEDURE SPU_PERSONAS_INSERTAR
@apellidos		VARCHAR(40),
@nombres		VARCHAR(40),
@dni			CHAR(8),
@direccion		VARCHAR(100),
@telefono		CHAR(9),
@email			VARCHAR(100)
AS BEGIN
	-- Posibles campos vacíos
	IF @direccion = '' SET @direccion = NULL	
	IF @telefono = '' SET @telefono = NULL 
	IF @email = '' SET @email = NULL 
	INSERT INTO PERSONAS (apellidos, nombres, dni, direccion, telefono, email) 
		VALUES (@apellidos, @nombres, @dni, @direccion, @telefono, @email)
END
GO

-- EDITAR
CREATE PROCEDURE SPU_PERSONAS_EDITAR
@idpersona		INT,
@apellidos		VARCHAR(40),
@nombres		VARCHAR(40),
@dni			CHAR(8),
@direccion		VARCHAR(100),
@telefono		CHAR(9),
@email			VARCHAR(100)
AS BEGIN
	IF @direccion = '' SET @direccion = NULL	
	IF @telefono = '' SET @telefono = NULL 
	IF @email = '' SET @email = NULL 
	UPDATE PERSONAS SET
		apellidos	= @apellidos,
		nombres		= @nombres,
		dni			= @dni,
		direccion	= @direccion,
		telefono	= @telefono,
		email		= @email
	WHERE idpersona = @idpersona
END
GO

-- BUSCAR
CREATE PROCEDURE SPU_PERSONAS_BUSCAR
@idpersona		INT
AS BEGIN
	SELECT  *
		FROM PERSONAS
		WHERE idpersona = @idpersona 
END
GO

--Buscar dni
CREATE PROCEDURE SPU_PERSONAS_BUSCARDNI
@dni		char(8)
AS BEGIN
	SELECT  idpersona, apellidos + ' ' +nombres as nombrecompleto
		FROM PERSONAS
		WHERE dni = @dni 
END
GO


-- ELIMINAR
CREATE PROCEDURE SPU_PERSONAS_ELIMINAR
@idpersona		INT
AS BEGIN
	UPDATE PERSONAS SET
		estado = 0
	WHERE idpersona = @idpersona
END 
GO

-- ACTIVAR
CREATE PROCEDURE SPU_PERSONAS_ACTIVAR
@idpersona		INT
AS BEGIN
	UPDATE PERSONAS SET
		estado = 1
	WHERE idpersona = @idpersona
END 
GO

------------------------------------
-- EMPRESAS
-- LISTAR
CREATE PROCEDURE SPU_EMPRESAS_LISTAR
@estado			BIT
AS BEGIN
	SELECT *
		FROM EMPRESAS
		WHERE estado = @estado
END 
GO

-- INSERTAR
CREATE PROCEDURE SPU_EMPRESAS_INSERTAR
@razonSocial	VARCHAR(80),
@ruc			CHAR(11),
@direccion		VARCHAR(100),
@telefono		CHAR(9),
@email			VARCHAR(100)
AS BEGIN
	IF @direccion = '' SET @direccion = NULL	
	IF @telefono = '' SET @telefono = NULL 
	IF @email = '' SET @email = NULL 
	INSERT INTO EMPRESAS(razonSocial, ruc, direccion, telefono, email) 
		VALUES (@razonSocial,@ruc, @direccion, @telefono, @email)
END
GO

-- EDITAR
CREATE PROCEDURE SPU_EMPRESAS_EDITAR
@idempresa		INT,
@razonSocial	VARCHAR(80),
@ruc			CHAR(11),
@direccion		VARCHAR(100),
@telefono		CHAR(9),
@email			VARCHAR(100)
AS BEGIN
	UPDATE EMPRESAS SET
		razonSocial = @razonSocial,
		ruc			= @ruc,
		direccion	= @direccion,
		telefono	= @telefono,
		email		= @email
	WHERE idempresa = @idempresa
END
GO

-- BUSCAR
CREATE PROCEDURE SPU_EMPRESAS_BUSCAR
@ruc   			CHAR(11)
AS BEGIN
    SELECT *
    FROM EMPRESAS
    WHERE ruc = @ruc 
END
GO

------------------------------------
-- ROLES
-- LISTAR
CREATE PROCEDURE SPU_ROLES_LISTAR
AS BEGIN
	SELECT * 
		FROM ROLES
END 
GO

-- INSERTAR
CREATE PROCEDURE SPU_ROLES_INSERTAR
@rol			VARCHAR(20)
AS BEGIN
	INSERT INTO ROLES (rol) 
		VALUES (@rol)
END
GO

-- EDITAR
CREATE PROCEDURE SPU_ROLES_EDITAR
@idrol			INT,
@rol			VARCHAR(20)
AS BEGIN
	UPDATE ROLES SET
		rol = @rol
	WHERE idrol = @idrol
END
GO

-- BUSCAR
CREATE PROCEDURE SPU_ROL_BUSCAR
@idrol			INT
AS BEGIN
	SELECT *
		FROM ROLES
		WHERE idrol = @idrol 
END
GO

------------------------------------
-- CATEGORIAS
-- LISTAR
CREATE PROCEDURE SPU_CATEGORIAS_LISTAR
AS BEGIN
	SELECT * 
		FROM CATEGORIAS
		ORDER BY idcategoria DESC
END
GO

-- BUSCAR
CREATE PROCEDURE SPU_CATEGORIAS_BUSCAR
@idcategoria		INT
AS BEGIN
	SELECT * 
		FROM CATEGORIAS
		WHERE idcategoria = @idcategoria
END
GO

-- REGISTRAR
CREATE PROCEDURE SPU_CATEGORIAS_REGISTRAR
@categoria			VARCHAR(50)
AS BEGIN
	INSERT INTO CATEGORIAS(categoria) VALUES
		(@categoria)
END
GO	

-- EDITAR
CREATE PROCEDURE SPU_CATEGORIAS_EDITAR
@idcategoria		INT,
@categoria			VARCHAR(50)
AS BEGIN
	UPDATE CATEGORIAS SET
		categoria = @categoria
	WHERE idcategoria = @idcategoria
END
GO

------------------------------------
-- TIPOS PAGOS
-- LISTAR
CREATE PROCEDURE SPU_TIPOPAGOS_LISTAR
AS BEGIN
	SELECT * 
		FROM TIPO_PAGOS
		ORDER BY idtipopago
END
GO

-- BUSCAR
CREATE PROCEDURE SPU_TIPOPAGOS_BUSCAR
@id					INT
AS BEGIN
	SELECT * 
		FROM TIPO_PAGOS
		WHERE idtipopago  = @id
END
GO

-- REGISTRAR
CREATE PROCEDURE SPU_TIPOPAGOS_REGISTRAR
@tipopago			VARCHAR(30)
AS BEGIN
	INSERT INTO TIPO_PAGOS(tipopago) VALUES
	(@tipopago)
END
GO

-- EDITAR
CREATE PROCEDURE SPU_TIPOPAGOS_EDITAR
@ID					INT,	
@tipopago			VARCHAR(30)
AS BEGIN
	UPDATE TIPO_PAGOS SET
		tipopago = @tipopago
	WHERE idtipopago = @ID
END
GO

------------------------------------
-- PRODUCTOS
-- LISTAR
CREATE PROCEDURE SPU_PRODUCTOS_LISTAR
@estado				BIT
AS BEGIN
	SELECT	PROD.idproducto, CATE.categoria, PROD.nombreproducto, 
			PROD.descripcion, PROD.fechaelaboracion, PROD.precio, 
			PROD.stock 
		FROM PRODUCTOS PROD
		INNER JOIN CATEGORIAS CATE ON PROD.idcategoria = CATE.idcategoria
		WHERE estado = @estado
		ORDER BY PROD.nombreproducto
END
GO

-- BUSCAR
CREATE PROCEDURE SPU_PRODUCTOS_BUSCAR
@idproducto			INT
AS BEGIN
	SELECT *
		FROM PRODUCTOS
		WHERE idproducto = @idproducto
END
GO

-- REGISTRAR
CREATE PROCEDURE SPU_PRODUCTOS_REGISTRAR
@idcategoria		INT,
@nombreproducto		VARCHAR(40),
@descripcion		VARCHAR(100),
@fechaelaboracion	DATETIME,
@precio				DECIMAL(7,2),
@stock				TINYINT
AS BEGIN
	INSERT INTO PRODUCTOS(idcategoria,nombreproducto, descripcion, fechaelaboracion, precio, stock) VALUES
		(@idcategoria, @nombreproducto, @descripcion, @fechaelaboracion, @precio, @stock)
END
GO

-- EDITAR
CREATE PROCEDURE SPU_PRODUCTOS_EDITAR
@idproducto			INT,
@idcategoria		INT,
@nombreproducto		VARCHAR(40),
@descripcion		VARCHAR(100),
@fechaelaboracion	DATETIME,
@precio				DECIMAL(7,2),
@stock				TINYINT
AS BEGIN
	UPDATE PRODUCTOS SET
		idcategoria = @idcategoria,
		nombreproducto = @nombreproducto,
		descripcion = @descripcion,
		fechaelaboracion = @fechaelaboracion,
		precio = @precio,
		stock = @stock
	WHERE idproducto = @idproducto
END
GO

-- ELIMINAR(0)
CREATE PROCEDURE SPU_PRODUCTOS_ELIMINAR
@idproducto			INT
AS BEGIN
	UPDATE PRODUCTOS SET
		estado = 0
	WHERE idproducto = @idproducto
END
GO

-- ACTIVAR(1)
CREATE PROCEDURE SPU_PRODUCTOS_ACTIVAR
@idproducto			INT
AS BEGIN
	UPDATE PRODUCTOS SET
		estado = 1
	WHERE idproducto = @idproducto
END
GO

------------------------------------
-- VENTAS
-- LISTAR
CREATE PROCEDURE SPU_VENTAS_LISTAR
AS BEGIN
	SELECT	VEN.idventa, PER.apellidos+' '+PER.nombres 'cliente', EMP.razonsocial 'empresa',
			USU.nombreusuario 'vendedor', VEN.fechaventa
		FROM VENTAS VEN
		INNER JOIN USUARIOS USU ON VEN.idusuario = USU.idusuario
		LEFT JOIN PERSONAS PER ON VEN.idpersona = PER.idpersona
		LEFT JOIN EMPRESAS EMP ON VEN.idempresa = EMP.idempresa
		ORDER BY VEN.idventa DESC 
END
GO

-- BUSCAR
CREATE PROCEDURE SPU_VENTAS_BUSCAR
@idventa			INT 
AS BEGIN
	SELECT *
		FROM  VENTAS
		WHERE idventa = @idventa
END
GO

-- EXEC SPU_VENTAS_BUSCAR 1

-- TRAE EL ID DE LA ULTIMA VENTA
CREATE PROCEDURE SPU_VENTAS_ULTIMA_VENTA
AS BEGIN
	SELECT TOP 1 * 
		FROM VENTAS
		ORDER BY idventa DESC
END
GO

-- REGISTRAR
CREATE PROCEDURE SPU_VENTAS_REGISTRAR
@idpersona			INT,
@idempresa			INT,
@idusuario			INT,
@idtipopago			INT,
@tipodocumento		CHAR(1)
AS BEGIN
	IF @idpersona = 0 SET @idpersona = NULL;
	IF @idempresa = 0 SET @idempresa = NULL;

	DECLARE @codedocumento VARCHAR(3) = 'BLT';
	IF @tipodocumento = 'F' SET @codedocumento = 'FCT';

	DECLARE @nrodocumento VARCHAR(10) = 
	(
		SELECT @codedocumento+RIGHT('0000000000'+CONVERT(VARCHAR,ISNULL(MAX(RIGHT(nrodocumento,7)),0)+1),7)
			FROM VENTAS
	);
	
	INSERT INTO VENTAS(idpersona, idempresa, idusuario, idtipopago, tipodocumento, nrodocumento) VALUES
		(@idpersona, @idempresa, @idusuario, @idtipopago, @tipodocumento, @nrodocumento)
END
GO

------------------------------------
-- DETALLE_VENTAS
-- LISTAR DETALLES DE UNA VENTA
CREATE PROCEDURE SPU_DETVENTA_LISTAR_DETALLES_VENTA
@idventa			INT
AS BEGIN
	SELECT	PRO.nombreproducto, DET.precioventa, DET.cantidad,
			DET.precioventa * DET.cantidad 'importe'
		FROM DETALLE_VENTAS DET
		INNER JOIN PRODUCTOS PRO ON DET.idproducto = PRO.idproducto
		WHERE DET.idventa = @idventa
END
GO
-- SELECT * FROM TIPO_pagos
-- SELECT * FROM VENTAS
-- EXEC SPU_DETVENTA_LISTAR_DETALLES_VENTA 1

-- REGISTRAR
CREATE PROCEDURE SPU_DETVENTA_REGISTRAR
@idventa			INT,
@idproducto			INT,
@cantidad			TINYINT,
@precioventa		DECIMAL(7,2)
AS BEGIN
	INSERT INTO DETALLE_VENTAS (idventa, idproducto, cantidad, precioventa) VALUES
		(@idventa, @idproducto, @cantidad, @precioventa)
END
GO

USE master
GO