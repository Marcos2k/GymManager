USE [Equilibrium]
GO
/****** Object:  StoredProcedure [dbo].[ObtenerPagoPorSocio]    Script Date: 26/11/2014 16:04:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER proc [dbo].[ObtenerPagoPorSocio]
@ID_Socio int
as
SELECT        dbo.Socios.ID As Socio,dbo.Pagos.ID_Pago,dbo.Socios.Nombre, dbo.Socios.Apellido, dbo.Pagos.Fecha, dbo.Pagos.Monto, dbo.Detalle_Pago.Concepto
FROM            dbo.Detalle_Pago INNER JOIN
                         dbo.Pagos ON dbo.Detalle_Pago.ID_Pago = dbo.Pagos.ID_Pago INNER JOIN
                         dbo.Socios ON dbo.Pagos.ID_Socio = dbo.Socios.ID 
						 Where dbo.Socios.ID = @ID_Socio
						 order by ID_Pago desc
						 go
