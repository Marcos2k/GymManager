create proc BuscarIdUsuario
@Usuario varchar(20),
@Contrase�a varchar(16)
as
Select ID_Usuario from Usuarios Where Usuario=@Usuario And Contrase�a=@Contrase�a
go