create proc ComprobarClave
@Contraseņa varchar(20)
as
Select Contraseņa from Usuarios Where Usuario=@Contraseņa
go