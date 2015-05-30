/*Procedimiento realizado para el informe de todos los deudores
Marcos Gonzalez */
create proc GenerarInformeTodosLosDeudores
as
Select Nombre,Apellido,Dni,Edad,Cuotas from Socios where Cuotas > 0
go