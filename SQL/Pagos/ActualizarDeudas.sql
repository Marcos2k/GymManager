/*Este script se encarga de restar el numero de mes que adeuda, ejemplo si debia 3 meses de deuda
entonces se hace 3 - 1 = 2
Marcos Gonzalez 17-02-2015*/
create proc ActualizarDeuda
@ID int
as
Update Socios set Cuotas = Cuotas - 1 Where ID = @ID
go