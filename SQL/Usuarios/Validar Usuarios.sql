create proc Validar_usuarios
@Usuario varchar(50),
@Contraseņa varchar(50),
@Acceso varchar(2)
as
Select *from Usuarios
Where Usuario = @Usuario and Contraseņa = @Contraseņa and Acceso=@Acceso
go