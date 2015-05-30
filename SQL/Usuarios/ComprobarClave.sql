create proc ComprobarClave
@Contraseña varchar(20)
as
Select Contraseña from Usuarios Where Usuario=@Contraseña
go