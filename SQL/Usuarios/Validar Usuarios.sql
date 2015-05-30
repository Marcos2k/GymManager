create proc Validar_usuarios
@Usuario varchar(50),
@Contraseña varchar(50),
@Acceso varchar(2)
as
Select *from Usuarios
Where Usuario = @Usuario and Contraseña = @Contraseña and Acceso=@Acceso
go