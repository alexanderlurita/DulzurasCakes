-- INYECCIONES A LAS TABLAS

USE PASTELERIA
GO

-- PERSONAS
INSERT INTO PERSONAS (apellidos, nombres, dni, direccion, telefono, email) VALUES
	('Tasayco Pachas', 'Patricia', '76364011','av rosales 258', '990004142', 'tasaycopatricia@gmail.com'),
	('Atuncar Gutierrez', 'Carlos', '76364012',null, null, 'agcarlos@gmail.com'),
	('Neyra Luna', 'Liliana', '76364013','calle lima 520', '990004143', 'lilineyra12@gmail.com'),
	('Felipa Pachas', 'Andrew', '76364014',null, '990004144', null),
	('Abregu Sotelo', 'Yuli', '76364015','pasaje santa rita 140', null, 'yulisotelo@gmail.com')
GO

-- EMPRESAS
INSERT INTO EMPRESAS(razonSocial, ruc, direccion, telefono, email) VALUES
	('AGROLIGHT PERU S.A.C.','20552103816',  NULL, '999999999', 'AGROLIGHT@GMAIL.COM'),
	('AGROSORIA E.I.R.L','20538856674',  NULL, '999999999', 'AGROSORIA@GMAIL.COM'),
	( 'AGRINOVA DEL PERU S.R.L','20553856451', NULL, '999999999', 'AGRINOVA@GMAIL.COM'),
	('BI GRAND CONFECCIONES S.A.C.', '20480316259', NULL, '999999999', 'BIGRANDCONFECCIONES@GMAIL.COM')
GO

-- ROLES
INSERT INTO ROLES(rol) VALUES
	('Administrador'),
	('Empleado')
GO

-- USUARIOS
INSERT INTO USUARIOS (idpersona, idrol, nombreusuario, claveacceso) VALUES
	(1,2,'PATRICIA', '123456'),
	(3,1,'LILIANA', '123456')
GO

-- CATEGORIAS
INSERT INTO CATEGORIAS (categoria) VALUES
	('Postres'),
	('Pasteles'),
	('Bizcochos'),
	('Galletas'),
	('Vegetarianos')
GO
INSERT INTO CATEGORIAS (categoria) VALUES
	('Bocaditos')
GO

-- PRODUCTOS
INSERT INTO PRODUCTOS (idcategoria, nombreproducto, descripcion, precio, stock) VALUES
	(2, 'Mini Torta', 'Chocolate, cremam volteada', 45.0, 6),
	(3, 'Queque', NULL, 2.0, 12),
	(4, 'ChocoChip', 'Chocolate con pecas', 1.5, 20),
	(1, 'Arroz con leche', NULL, 5.0, 20),
	(1, 'Gelatina', 'Con flan', 2.0, 15)
GO
INSERT INTO PRODUCTOS (idcategoria, nombreproducto, descripcion, precio, stock) VALUES
	(1, 'brownie', 'porcion bañado en chocolate con pecanas', 3.5, 9),
	(1, 'pye de manzana', 'Porción', 3.50, 12),
	(1, 'chessecake', 'Porcion sabor a maracuya', 6.50, 15),
	(1, 'torta de galleta', 'Porcion, sabor chocolate y vainilla', 3.50, 20),
	(1, 'Torta de chocolate', 'Porcion, Rellena y bañada con fudge', 6, 12),
	(2, 'Torta tres leches', 'torta de 1/2 kg',65.00 , 4),
	(2, 'Torta de chocolate', 'torta de 1/2 kg', 68.00, 4),
	(2, 'Torta selva negra', 'Torta de 1/2 kg', 58, 4),
	(2, 'carrot cake', 'Torta de 1/2 kg', 58, 12),
	(2, 'Pye de manzana', 'Tamaño mediano', 6, 12),
	(6, 'Pitipanes', '25 unidades',23, 2),
	(6, 'cocadas', '25 unidades', 18, 3),
	(6, 'piernitas y alitas', '25 unidades', 35, 3),
	(6, 'empanadas de pollo', '25 unidades', 22, 5)
GO

-- TIPO_PAGOS
INSERT INTO TIPO_PAGOS (tipopago) VALUES
	('Yape'),
	('Efectivo'),
	('Tarjeta'),
	('Plim')
GO

-- VENTAS
INSERT INTO VENTAS (idusuario, idpersona, idempresa, idtipopago, tipodocumento, nrodocumento) VALUES
	(2, 1, NULL, 1, 'B', '0000000001'),
	(1, NULL, 1, 2, 'B', '0000000002'),
	(1, 4, NULL, 4, 'F', '0000000003'),
	(1, 3, NULL, 4, 'B', '0000000004'),
	(1, 2, NULL, 1, 'B', '0000000005')
GO

-- DETALLE_VENTAS
INSERT INTO DETALLE_VENTAS (idventa, idproducto, cantidad, precioventa) VALUES
	(1, 2, 3, 1.5),
	(1, 3, 5, 20.0),
	(1, 1, 6, 45.0),
	(1, 3, 8, 1.5),
	(1, 4, 2, 5.0),
	(2, 2, 4, 2.0),
	(2, 3, 1, 1.5),
	(2, 4, 1, 5.0),
	(2, 5, 10, 2.0),
	(2, 1, 1, 45.5),
	(2, 2, 1, 1.0),
	(3, 5, 1, 2.0),
	(3, 4, 10, 5.0),
	(3, 1, 1, 45.5),
	(3, 1, 1, 45.5),
	(3, 2, 6, 2.0),
	(3, 2, 2, 2.0),
	(4, 3, 6, 1.5),
	(4, 2, 7, 2.0),
	(4, 5, 4, 2.0),
	(4, 1, 1, 45.5),
	(4, 2, 10, 2.0),
	(4, 2, 10, 2.0),
	(4, 1, 1, 45.5),
	(4, 1, 1, 45.5),
	(5, 5, 11, 2.0),
	(5, 4, 20, 5.0),
	(5, 3, 6, 1.5),
	(5, 1, 2, 45.5),
	(5, 2, 2, 2.0),
	(5, 5, 4, 2.0)
GO