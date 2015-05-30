create proc BuscarIdUsuario
@Usuario varchar(20),
@Contraseña varchar(16)
as
Select ID_Usuario from Usuarios Where Usuario=@Usuario And Contraseña=@Contraseña
go