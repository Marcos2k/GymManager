create proc Validar_usuarios
@Usuario varchar(50),
@Contrase�a varchar(50),
@Acceso varchar(2)
as
Select *from Usuarios
Where Usuario = @Usuario and Contrase�a = @Contrase�a and Acceso=@Acceso
go