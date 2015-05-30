Create proc SeleccionarDeudoresTotales
as
Select Nombre,Apellido,Dni,Edad,Cuotas as [Cuotas a pagar] from Socios where Cuotas > 0
go