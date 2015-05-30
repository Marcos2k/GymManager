create proc ModificarUsuarios
@Contraseña varchar(16),
@Acceso int,
@ID int
As
Update Usuarios set Contraseña=@Contraseña, Acceso=@Acceso Where ID_Usuario=@ID
go
