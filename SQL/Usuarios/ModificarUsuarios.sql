create proc ModificarUsuarios
@Contraseņa varchar(16),
@Acceso int,
@ID int
As
Update Usuarios set Contraseņa=@Contraseņa, Acceso=@Acceso Where ID_Usuario=@ID
go
