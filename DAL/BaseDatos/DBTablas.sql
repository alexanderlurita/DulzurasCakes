USE master
GO

IF DB_ID ('PASTELERIA') IS NOT NULL
	DROP DATABASE PASTELERIA
GO

CREATE DATABASE PASTELERIA
GO

USE PASTELERIA
GO

CREATE TABLE PERSONAS
(
	idpersona		INT IDENTITY(1,1) PRIMARY KEY,
	apellidos		VARCHAR(40)		NOT NULL,
	nombres			VARCHAR(40)		NOT NULL,
	dni				CHAR(8)			NOT NULL,
	direccion		VARCHAR(100)	NULL,
	telefono		CHAR(9)			NULL,
	email			VARCHAR(100)	NULL,
	estado			BIT				NOT NULL DEFAULT 1,
	CONSTRAINT uk_dni_per UNIQUE (dni),
	CONSTRAINT ck_dni_per CHECK (dni LIKE('[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]')),
	CONSTRAINT ck_telefono_per CHECK (telefono LIKE('[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]'))
)
GO

CREATE TABLE EMPRESAS
(
	idempresa			INT IDENTITY(1,1) PRIMARY KEY,
	razonsocial			VARCHAR(80)		NOT NULL,
	ruc					CHAR(11)		NOT NULL,
	direccion			VARCHAR(100)	NULL,
	telefono			CHAR(9)			NULL,
	email				VARCHAR(100)	NULL,
	estado				BIT				NOT NULL DEFAULT 1,
	CONSTRAINT uk_ruc_emp UNIQUE (ruc),
	CONSTRAINT ck_telefono_emp CHECK (telefono LIKE('[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]')),
	CONSTRAINT ck_ruc_emp CHECK (ruc LIKE ('[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]'))
)
GO

CREATE TABLE ROLES
(
	idrol			INT IDENTITY(1,1) PRIMARY KEY,
	rol					VARCHAR(20)		NOT NULL,
	CONSTRAINT uk_rol UNIQUE (rol)
)
GO

CREATE TABLE USUARIOS
(
	idusuario			INT IDENTITY(1,1) PRIMARY KEY,
	idpersona			INT				NOT NULL,
	idrol				INT				NOT NULL,
	nombreusuario		VARCHAR(30) 	NOT NULL,
	claveacceso			VARCHAR(200) 	NOT NULL,
	fechaalta			DATE			NOT NULL DEFAULT GETDATE(),
	fechabaja			DATE			NULL,
	estado				BIT				NOT NULL DEFAULT 1,
	CONSTRAINT fk_idpersona_usu FOREIGN KEY (idpersona) REFERENCES PERSONAS(idpersona),
	CONSTRAINT fk_idrol_usu FOREIGN KEY (idrol) REFERENCES ROLES(idrol),
	CONSTRAINT uk_nombreusu_usu UNIQUE (nombreusuario)
)
GO

-------------------------------------

CREATE TABLE CATEGORIAS 
(
	idcategoria			INT IDENTITY(1,1) PRIMARY KEY,
	categoria			VARCHAR(50) 	NOT NULL,
	CONSTRAINT uk_categoria_cat UNIQUE(categoria)
)
GO

CREATE TABLE PRODUCTOS
(	
	idproducto			INT IDENTITY(1,1) PRIMARY KEY,
	idcategoria			INT 			NOT NULL,
	nombreproducto		VARCHAR(40) 	NOT NULL,
	descripcion			VARCHAR(100) 	NULL,
	fechaelaboracion	DATETIME 		NOT NULL DEFAULT GETDATE(),
	precio				DECIMAL(7,2) 	NOT NULL,
	stock				TINYINT 		NOT NULL,
	estado				BIT 			NOT NULL DEFAULT 1,
	CONSTRAINT fk_idcategoria_pro FOREIGN KEY (idcategoria) REFERENCES categorias (idcategoria),
	CONSTRAINT ck_precio_pro CHECK (precio > 0),
)
GO

CREATE TABLE TIPO_PAGOS
(
	idtipopago			INT IDENTITY(1,1) PRIMARY KEY,
	tipopago			VARCHAR(30) 	NOT NULL,
	CONSTRAINT uk_tipopago_tip UNIQUE(tipopago)
)
GO

CREATE TABLE VENTAS
(
	idventa				INT IDENTITY(1,1) PRIMARY KEY,
	idpersona			INT 			NULL,
	idempresa			INT 			NULL,
	idusuario			INT 			NOT NULL,
	idtipopago			INT			 	NOT NULL,
	tipodocumento 		CHAR(1)	 		NOT NULL, -- B = Boleta F = Factura
	nrodocumento		VARCHAR(10) 	NOT NULL,
	fechaventa			DATETIME 		NOT NULL DEFAULT GETDATE(),
	CONSTRAINT fk_idpersona_ven FOREIGN KEY (idpersona) REFERENCES personas (idpersona),
	CONSTRAINT fk_idempresa_ven FOREIGN KEY (idempresa) REFERENCES empresas (idempresa),
	CONSTRAINT fk_idusuario_ven FOREIGN KEY (idusuario) REFERENCES usuarios (idusuario),
	CONSTRAINT fk_idpago_ven FOREIGN KEY (idtipopago) REFERENCES tipo_pagos (idtipopago),
	CONSTRAINT ck_tipdoc_ven CHECK (tipodocumento IN('B', 'F'))
)
GO

CREATE TABLE DETALLE_VENTAS
(
	iddetventa			INT IDENTITY(1,1) PRIMARY KEY,
	idventa				INT				NOT NULL,
	idproducto			INT 			NOT NULL,
	cantidad			TINYINT 		NOT NULL,
	precioventa			DECIMAL(7,2) 	NOT NULL,
	CONSTRAINT fk_idventa_det FOREIGN KEY (idventa) REFERENCES ventas (idventa),
	CONSTRAINT fk_idproducto_det FOREIGN KEY (idproducto) REFERENCES productos (idproducto),
	CONSTRAINT ck_precio_det CHECK (precioventa >= 0),
)
GO