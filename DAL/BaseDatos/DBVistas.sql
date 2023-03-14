USE PASTELERIA
GO

CREATE VIEW REPORTE_VENTAS
AS
	SELECT	VEN.idventa, PER.apellidos+' '+PER.nombres 'cliente', EMP.razonsocial 'empresa',
			USU.nombreusuario 'vendedor', VEN.fechaventa, SUM(DET.precioventa * DET.cantidad) 'TOTAL'
		FROM VENTAS VEN
		INNER JOIN USUARIOS USU ON VEN.idusuario = USU.idusuario
		LEFT JOIN PERSONAS PER ON VEN.idpersona = PER.idpersona
		LEFT JOIN EMPRESAS EMP ON VEN.idempresa = EMP.idempresa 
		RIGHT JOIN DETALLE_VENTAS DET ON VEN.idventa = DET.idventa
		GROUP BY VEN.idventa, PER.apellidos, PER.nombres, EMP.razonsocial,USU.nombreusuario, VEN.fechaventa
GO

-- REPORTE 01
CREATE VIEW REPORTE_VENTA_01
AS     
	SELECT	USU.nombreusuario 'Vendedor', DATENAME(MONTH,CONVERT(date,VEN.fechaventa)) 'Mes',
			COUNT(VEN.idventa) 'Ventas realizadas'
    	FROM VENTAS VEN            
       	INNER JOIN USUARIOS USU ON VEN.idusuario = USU.idusuario
        GROUP BY usu.nombreusuario, DATENAME(MONTH,CONVERT(date,VEN.fechaventa))
GO

--SELECT * FROM REPORTE_VENTA_01

-- REPORTE 02
CREATE VIEW REPORTE_VENTA_02
AS
	SELECT	USU.idusuario 'ID Usuario', USU.nombreusuario 'Vendedor',
			DATENAME(WEEK,CONVERT(date,VEN.fechaventa)) 'Semana',
			COUNT(PRO.nombreproducto) 'Cantidad de productos',
			SUM(DET.precioventa * DET.cantidad) 'Total'
            FROM VENTAS VEN            
            INNER JOIN USUARIOS USU ON VEN.idusuario = USU.idusuario
            LEFT JOIN PERSONAS PER ON VEN.idpersona = PER.idpersona
            LEFT JOIN EMPRESAS EMP ON VEN.idempresa = EMP.idempresa 
            RIGHT JOIN DETALLE_VENTAS DET ON VEN.idventa = DET.idventa
            INNER JOIN PRODUCTOS PRO ON DET.idproducto = PRO.idproducto
            GROUP BY USU.idusuario, USU.nombreusuario, DATENAME(WEEK,CONVERT(date,VEN.fechaventa))
GO

/*
SELECT * 
	FROM REPORTE_VENTA_02
	ORDER BY 3 DESC
GO
*/

-- REPORTE 03
CREATE VIEW REPORTE_VENTA_03
AS
	SELECT	DATENAME(WEEKDAY,CONVERT(DATE,VNT.fechaventa)) 'Dias',
			COUNT(VNT.idventa) 'N° Ventas'
            FROM VENTAS VNT
            GROUP BY DATENAME(WEEKDAY,CONVERT(DATE,VNT.fechaventa))
GO

/*
	SELECT * 
		FROM REPORTE_VENTA_03
			
*/

-- REPORTE 04
CREATE PROCEDURE REPORTE_VENTA_04
AS
	SELECT	TOP 5 PRO.idproducto 'ID Producto', PRO.nombreproducto 'Nombre producto', 
			SUM(DET.cantidad) 'Productos vendidos'
		FROM DETALLE_VENTAS DET
		INNER JOIN VENTAS VNT ON DET.idventa = VNT.idventa
		INNER JOIN PRODUCTOS PRO ON DET.idproducto = PRO.idproducto
		WHERE VNT.fechaventa BETWEEN DATEADD(DAY, -7, GETDATE()) AND GETDATE()
		GROUP BY PRO.idproducto, nombreproducto
		ORDER BY 3 DESC
GO

/*	
EXEC REPORTE_VENTA_04
SELECT idproducto, sum(cantidad) FROM DETALLE_VENTAS group by idproducto
*/

USE master
GO