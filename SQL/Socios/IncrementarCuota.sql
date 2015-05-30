/*Implementacion de cuotas para filtrar deudores - Marcos Gonzalez*/
Alter table Socios
add Cuotas int
go

Alter table Socios
ADD CONSTRAINT IncrementaCuota
DEFAULT 0 for Cuotas
go

Create proc IncrementarCantidadCuota
as
Update Socios set Cuotas = Cuotas+1 Where Estado = 2 /*El estado 2 significa debe*/
go

Update socios set Cuotas = 0
Select *from Socios where Estado= 2