USE PASTELERIA
GO

------ PROCEDIMIENTOS ALMACENADOS
-- Usuarios
CREATE PROCEDURE SPU_USUARIOS_LISTAR
AS BEGIN
	SELECT  USUARIOS.idusuario, 
			PERSONAS.apellidos, PERSONAS.nombres,
			ROLES.rol,USUARIOS.nombreusuario, USUARIOS.fechaalta, USUARIOS.fechabaja
	FROM USUARIOS
	INNER JOIN PERSONAS ON PERSONAS.idpersona = USUARIOS.idpersona
	INNER JOIN ROLES ON ROLES.idrol = USUARIOS.idrol
END 
GO

--EXEC SPU_USUARIOS_LISTAR
--GO

CREATE PROCEDURE SPU_USUARIOS_INSERTAR
@idpersona		INT,
@idrol			INT,
@nombreusuario	VARCHAR(30),
@claveacceso	VARCHAR(200),
@fechabaja		DATE
AS
BEGIN
	INSERT INTO USUARIOS (idpersona, idrol, nombreusuario, claveacceso, fechabaja) 
		VALUES(@idpersona, @idrol, @nombreusuario, @claveacceso, @fechabaja)
END
GO

CREATE PROCEDURE SPU_USUARIOS_EDITAR
@idusuario		INT,
@idpersona		INT,
@idrol			INT,
@nombreusuario	VARCHAR(30),
@claveacceso	VARCHAR(200),
@fechabaja		DATE
AS
BEGIN
	UPDATE USUARIOS SET
		idpersona = @idpersona,
		idrol = @idrol,
		nombreusuario = @nombreusuario,
		claveacceso = @claveacceso,
		fechabaja = @fechabaja
	WHERE idusuario = @idusuario
END
GO

CREATE PROCEDURE SPU_USUARIOS_BUSCAR
@idusuario	INT
AS
BEGIN
	SELECT USUARIOS.idusuario, 
			PERSONAS.apellidos, PERSONAS.nombres,
			ROLES.rol,USUARIOS.nombreusuario, USUARIOS.fechaalta, USUARIOS.fechabaja
	FROM USUARIOS
	INNER JOIN PERSONAS ON PERSONAS.idpersona = USUARIOS.idpersona
	INNER JOIN ROLES ON ROLES.idrol = USUARIOS.idrol
	WHERE idusuario = @idusuario
END
GO

-- exec SPU_USUARIOS_BUSCAR 1

CREATE PROCEDURE SPU_USUARIOS_ELIMINAR
@idusuario	 INT
AS
BEGIN
	UPDATE USUARIOS SET
		estado = 0
	WHERE idusuario = @idusuario
END
GO

-- EXEC SPU_USUARIOS_ELIMINAR 2

CREATE PROCEDURE SPU_USUARIOS_LOGIN
@nombreusuario	VARCHAR(30)
AS BEGIN
	SELECT	USUARIOS.idusuario, PERSONAS.nombres, PERSONAS.apellidos,
			USUARIOS.nombreusuario, USUARIOS.claveacceso, ROLES.rol
	FROM	usuarios
	INNER JOIN PERSONAS ON USUARIOS.idpersona = PERSONAS.idpersona
	INNER JOIN ROLES ON USUARIOS.idrol = ROLES.idrol
	WHERE USUARIOS.nombreusuario = @nombreusuario AND 
			USUARIOS.estado = 1
END
GO

-- EXEC SPU_USUARIOS_LOGIN 'PATRICIA'

--PERSONAS 
CREATE PROCEDURE SPU_PERSONAS_LISTAR
AS
BEGIN
	SELECT * FROM PERSONAS
END 
GO

--EXEC SPU_PERSONAS_LISTAR
--GO

CREATE PROCEDURE SPU_PERSONAS_INSERTAR
@apellidos		VARCHAR(40),
@nombres		VARCHAR(40),
@dni			CHAR(8),
@direccion		VARCHAR(100),
@telefono		CHAR(9),
@email			VARCHAR(100)
AS
BEGIN
	INSERT INTO PERSONAS (apellidos, nombres, dni, direccion, telefono, email) 
		VALUES (@apellidos, @nombres, @dni, @direccion, @telefono, @email)
END
GO

--EXEC SPU_PERSONAS_INSERTAR 'Suarez Cotrina', 'Eradio', '18202124', 'av. pilpa', '990004139', 'escbardales@gmail.com'
--GO

CREATE PROCEDURE SPU_PERSONAS_EDITAR
@idpersona		INT,
@apellidos		VARCHAR(40),
@nombres		VARCHAR(40),
@dni			CHAR(8),
@direccion		VARCHAR(100),
@telefono		CHAR(9),
@email			VARCHAR(100)
AS
BEGIN
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

CREATE PROCEDURE SPU_PERSONAS_BUSCAR
@idpersona	INT
AS
BEGIN
	SELECT *
	FROM PERSONAS
	WHERE idpersona = @idpersona 
END
GO

--EXEC SPU_PERSONAS_BUSCAR 5
--GO

--EMPRESAS
CREATE PROCEDURE SPU_EMPRESAS_LISTAR
AS
BEGIN
	SELECT * FROM EMPRESAS
END 
GO

--EXEC SPU_EMPRESAS_LISTAR
--GO

CREATE PROCEDURE SPU_EMPRESAS_INSERTAR
@razonSocial	VARCHAR(80),
@ruc			char(11),
@direccion		VARCHAR(100),
@telefono		CHAR(9),
@email			VARCHAR(100)
AS
BEGIN
	INSERT INTO EMPRESAS(razonSocial, ruc, direccion, telefono, email) 
		VALUES (@razonSocial,@ruc, @direccion, @telefono, @email)
END
GO


CREATE PROCEDURE SPU_EMPRESAS_EDITAR
@idempresa		INT,
@razonSocial	VARCHAR(80),
@ruc			char(11),
@direccion		VARCHAR(100),
@telefono		CHAR(9),
@email			VARCHAR(100)
AS
BEGIN
	UPDATE EMPRESAS SET
		razonSocial = @razonSocial,
		ruc			= @ruc,
		direccion	= @direccion,
		telefono	= @telefono,
		email		= @email
	WHERE idempresa = @idempresa
END
GO

CREATE PROCEDURE SPU_EMPRESAS_BUSCAR
@idempresa	INT
AS
BEGIN
	SELECT *
	FROM EMPRESAS
	WHERE idempresa = @idempresa 
END

exec SPU_EMPRESAS_BUSCAR 2
GO

--roles
CREATE PROCEDURE SPU_ROLES_LISTAR
AS
BEGIN
	SELECT * FROM ROLES
END 
GO

--EXEC SPU_ROLES_LISTAR
--GO

CREATE PROCEDURE SPU_ROLES_INSERTAR
@rol	VARCHAR(20)
AS
BEGIN
	INSERT INTO ROLES (rol) VALUES (@rol)
END
GO

CREATE PROCEDURE SPU_ROLES_EDITAR
@idrol	INT,
@rol	VARCHAR(20)
AS
BEGIN
	UPDATE ROLES SET
		rol = @rol
	WHERE idrol = @idrol
END
GO

CREATE PROCEDURE SPU_ROL_BUSCAR
@idrol	INT
AS
BEGIN
	SELECT *
	FROM ROLES
	WHERE idrol = @idrol 
END
GO
----------------------------------------------------------

-- CATEGORIAS
--LISTAR
CREATE PROCEDURE SPU_CATEGORIAS_LISTAR
AS BEGIN
	SELECT * 
	FROM CATEGORIAS
	ORDER BY idcategoria
END
GO

-- BUSCAR
CREATE PROCEDURE SPU_CATEGORIAS_BUSCAR
	@id int
AS BEGIN
	SELECT * 
	FROM CATEGORIAS
	WHERE idcategoria = @id
END
GO

-- Registrar
CREATE PROCEDURE SPU_CATEGORIA_REGISTRAR
	@categoria		VARCHAR(50)
AS BEGIN
	INSERT INTO CATEGORIAS(categoria) VALUES
	(@categoria)
END
GO	

-- EDITAR
CREATE PROCEDURE SPU_CATEGORIA_EDITAR
	@id				INT,
	@categoria		VARCHAR(50)
AS BEGIN
	UPDATE CATEGORIAS SET
		categoria = @categoria
	WHERE idcategoria = @id
END
GO

-- TIPOS PAGOS
-- Listar
CREATE PROCEDURE SPU_TIPOPAGOS_LISTAR
AS BEGIN
	SELECT * 
		FROM TIPO_PAGOS
		ORDER BY idtipopago
END
GO

-- Buscar
CREATE PROCEDURE SPU_TIPOPAGOS_BUSCAR
	@id			INT
AS BEGIN
	SELECT * 
		FROM TIPO_PAGOS
		WHERE idtipopago  = @id
END
GO

-- Registrar
CREATE PROCEDURE SPU_TIPOPAGOS_REGISTRAR
	@tipopago	VARCHAR(30)
AS BEGIN
	INSERT INTO TIPO_PAGOS(tipopago) VALUES
	(@tipopago)
END
GO

-- Editar
CREATE PROCEDURE SPU_TIPOPAGOS_EDITAR
	@ID			INT,	
	@tipopago	VARCHAR(30)
AS BEGIN
	UPDATE TIPO_PAGOS SET
		tipopago = @tipopago
	WHERE idtipopago = @ID
END
GO

-- PRODUCTOS
-- Listar
CREATE PROCEDURE SPU_PRODUCTOS_LISTAR
AS BEGIN
	SELECT idproducto, idcategoria,	nombreproducto, descripcion, fechaelaboracion, precio, stock 
		FROM PRODUCTOS
END
GO

-- Buscar
CREATE PROCEDURE SPU_PRODUCTOS_BUSCAR
	@id		INT
AS BEGIN
	SELECT idproducto, idcategoria,	nombreproducto, descripcion, fechaelaboracion, precio, stock 
		FROM PRODUCTOS
	WHERE idproducto = @id 
END
GO

-- Registrar
CREATE PROCEDURE SPU_PRODUCTOS_REGISTRAR
	@idcategoria	INT,
	@nombre			VARCHAR(40),
	@descripcion	VARCHAR(100),
	@precio			DECIMAL(7,2),
	@stock			TINYINT
AS BEGIN
	INSERT INTO PRODUCTOS (idcategoria,nombreproducto, descripcion, precio, stock)
	VALUES(@idcategoria, @nombre, @descripcion, @precio, @stock)
END
GO

-- Editar
CREATE PROCEDURE SPU_PRODUCTOS_EDITAR
	@id				INT,
	@idcategoria	INT,
	@nombre			VARCHAR(40),
	@descripcion	VARCHAR(100),
	@precio			DECIMAL(7,2),
	@fecha			DATETIME,
	@stock			TINYINT
AS BEGIN
	UPDATE PRODUCTOS SET
		idcategoria = @idcategoria,
		nombreproducto = @nombre,
		descripcion = @descripcion,
		fechaelaboracion = @fecha,
		precio = @precio,
		stock = @stock
	WHERE idproducto=  @id
END
GO

-- Eliminar(0)
CREATE PROCEDURE SPU_PRODUCTOS_ELIMINAR
	@id		INT
AS BEGIN
	UPDATE PRODUCTOS SET
		estado = 0
	WHERE idproducto = @id
END
GO

-- Activar(1)
CREATE PROCEDURE SPU_PRODUCTOS_ACTIVAR
	@id		INT
AS BEGIN
	UPDATE PRODUCTOS SET
		estado = 1
	WHERE idproducto = @id
END
GO

-- VENTAS
-- Listar
CREATE PROCEDURE SPU_VENTAS_LISTAR
AS BEGIN
	SELECT idventa, idusuario, idpersona, idtipopago, tipodocumento, nrodocumento, fechaventa
		FROM  VENTAS
END
GO

-- Buscar
CREATE PROCEDURE SPU_VENTAS_BUSCAR
	@id		 INT 
AS BEGIN
	SELECT idventa, idusuario, idpersona, idtipopago, tipodocumento, nrodocumento, fechaventa
		FROM  VENTAS
	WHERE idventa = @id
END
GO

-- Registrar
CREATE PROCEDURE SPU_VENTAS_REGISTRAR
	@idusuario		INT,
	@idpersona		INT,
	@idempresa		INT,
	@idtipopago		INT,
	@tipodocumento	CHAR(1),
	@nrodocumento	CHAR(11)
AS BEGIN
	INSERT INTO VENTAS(idusuario, idpersona, idempresa, idtipopago, tipodocumento, nrodocumento)
	VALUES(@idusuario, @idpersona, @idempresa, @idtipopago, @tipodocumento, @nrodocumento)
END
GO

-- Editar
CREATE PROCEDURE SPU_VENTAS_EDITAR
	@id				INT,
	@idusuario		INT,
	@idpersona		INT,
	@idempresa		INT,
	@idtipopago		INT,
	@tipodocumento	CHAR(1),
	@nrodocumento	CHAR(11),
	@fechaventa		DATETIME
AS BEGIN
	UPDATE VENTAS SET
		idusuario = @idusuario,
		idpersona = @idpersona,
		idempresa = @idempresa,
		idtipopago =@idtipopago,
		tipodocumento = @tipodocumento,
		nrodocumento = @nrodocumento,
		fechaventa = @fechaventa
	WHERE idventa = @id
END
GO

-- Detalle Ventas
-- Listar
CREATE PROCEDURE SPU_DETVENTA_LISTAR
AS BEGIN
	SELECT * FROM DETALLE_VENTAS
	ORDER BY iddetventa DESC
END
GO

-- Buscar
CREATE PROCEDURE SPU_DETVENTA_BUSCAR
	@id		INT
AS BEGIN
	SELECT * FROM DETALLE_VENTAS
END
GO