create proc BuscarUsuario
@Nombre varchar(20)
as
Select Usuario from Usuarios Where Usuario=@Nombre
go