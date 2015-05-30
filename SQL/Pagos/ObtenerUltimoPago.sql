create proc ObtenerUltimoPago
as
Select *from Pagos order by ID_Pago desc
go