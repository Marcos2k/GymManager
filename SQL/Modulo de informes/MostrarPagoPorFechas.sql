create proc MostrarPagoPorFechas
@Desde date,
@Hasta date
as
SELECT        dbo.Pagos.ID_Pago,dbo.Socios.Nombre, dbo.Socios.Apellido, dbo.Pagos.Fecha, dbo.Pagos.Monto, dbo.Detalle_Pago.Concepto
FROM            dbo.Detalle_Pago INNER JOIN
                         dbo.Pagos ON dbo.Detalle_Pago.ID_Pago = dbo.Pagos.ID_Pago INNER JOIN
                         dbo.Socios ON dbo.Pagos.ID_Socio = dbo.Socios.ID
						 WHERE Pagos.Fecha BETWEEN @Desde And @Hasta
						 go