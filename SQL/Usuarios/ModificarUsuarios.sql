create proc ModificarUsuarios
@Contrase�a varchar(16),
@Acceso int,
@ID int
As
Update Usuarios set Contrase�a=@Contrase�a, Acceso=@Acceso Where ID_Usuario=@ID
go
