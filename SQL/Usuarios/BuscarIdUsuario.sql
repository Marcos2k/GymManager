create proc BuscarIdUsuario
@Usuario varchar(20),
@Contraseņa varchar(16)
as
Select ID_Usuario from Usuarios Where Usuario=@Usuario And Contraseņa=@Contraseņa
go