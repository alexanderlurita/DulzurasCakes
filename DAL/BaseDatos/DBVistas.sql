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

USE master
GO