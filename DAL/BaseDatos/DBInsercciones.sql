-- INYECCIONES A LAS TABLAS

USE PASTELERIA
GO

-- PERSONAS
INSERT INTO PERSONAS (apellidos, nombres, dni, direccion, telefono, email) VALUES
	('Tasayco Pachas', 'Patricia', '76364011','av rosales 258', '990004142', 'tasaycopatricia@gmail.com'),
	('Atuncar Gutierrez', 'Carlos', '76364012',null, null, 'agcarlos@gmail.com'),
	('Neyra Luna', 'Liliana', '76364013','calle lima 520', '990004143', 'lilineyra12@gmail.com'),
	('Felipa Pachas', 'Andrew', '76364014',null, '990004144', null),
	('Abregu Sotelo', 'Yuli', '76364015','pasaje santa rita 140', null, 'yulisotelo@gmail.com'),
	('Cabrera Napa', 'Anny', '73737374', NULL, NULL, NULL),
	('Luque Ramos', 'Johan', '74747272', NULL, NULL, NULL),
	('Lurita Chávez', 'Alexander', '73790885', NULL, NULL, NULL),
	('Suarez Matias', 'Irene', '73727371', NULL, NULL, NULL)
GO

-- SELECT * FROM PRODUCTOS;
-- SELECT * FROM VENTAS;
-- SELECT * FROM DETALLE_VENTAS

-- EMPRESAS
INSERT INTO EMPRESAS(razonsocial, ruc, direccion, telefono, email) VALUES
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
	(6, 1,'ANNY', '$2a$06$ARAC36bi02mOka7l4snlUO0AUSJKA9sspXCAsFysLf8uoAEYTktbm'), -- 123456
	(7, 1,'JOHAN', '$2a$06$BkyhyuW1ntwos8CubstCZuFDx'),	-- 123456
	(8, 1, 'ALEXANDER', '$2a$06$Pgq2Ep7X1l.hMBzFF8aykOITEQ/psGw7KRw1yyg4brl9LuE8oBFkG'), -- 123456
	(9, 1, 'IRENE', '$2a$06$YOiRzdxpZQekmqZbIK8YjOGwVie8NxkkMkPz/O4kXpZ0qkQICFw6G') -- 123456
GO

-- CATEGORIAS
INSERT INTO CATEGORIAS (categoria) VALUES
	('Postres'),
	('Pasteles'),
	('Bizcochos'),
	('Galletas'),
	('Vegetarianos'),
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
	(1, 'Brownie', 'Porción bañado en chocolate con pecanas', 3.5, 9),
	(1, 'Pye de manzana', 'Porción', 3.50, 12),
	(1, 'Chessecake', 'Porción sabor a maracuya', 6.50, 15),
	(1, 'Torta de galleta', 'Porción, sabor chocolate y vainilla', 3.50, 20),
	(1, 'Torta de chocolate', 'Porción, Rellena y bañada con fudge', 6, 12),
	(2, 'Torta tres leches', 'Torta de 1/2 kg',65.00 , 4),
	(2, 'Torta de chocolate', 'Torta de 1/2 kg', 68.00, 4),
	(2, 'Torta selva negra', 'Torta de 1/2 kg', 58, 4),
	(2, 'Carrot Cake', 'Torta de 1/2 kg', 58, 12),
	(2, 'Pye de manzana', 'Tamaño mediano', 6, 12),
	(6, 'Pitipanes', '25 unidades',23, 2),
	(6, 'Cocadas', '25 unidades', 18, 3),
	(6, 'Piernitas y alitas', '25 unidades', 35, 3),
	(6, 'Empanadas de pollo', '25 unidades', 22, 5)
GO

-- TIPO_PAGOS
INSERT INTO TIPO_PAGOS (tipopago) VALUES
	('Efectivo'),
	('Tarjeta'),
	('Yape'),
	('Plim')
GO

-- VENTAS
INSERT INTO VENTAS (idusuario, idpersona, idempresa, idtipopago, tipodocumento, nrodocumento) VALUES
	(2, 1, NULL, 1, 'B', 'BLT0000001'),
	(1, NULL, 1, 2, 'F', 'FCT0000002'),
	(1, 4, NULL, 4, 'B', 'BLT0000003'),
	(1, 3, NULL, 4, 'B', 'BLT0000004'),
	(1, 2, NULL, 1, 'B', 'BLT0000005')
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

USE master
GO