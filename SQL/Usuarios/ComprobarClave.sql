create proc ComprobarClave
@Contrase�a varchar(20)
as
Select Contrase�a from Usuarios Where Usuario=@Contrase�a
go