Create proc AgregarUsuario
@Usuario varchar(20),
@Contraseņa varchar(16),
@Acceso int
As
INSERT INTO Usuarios(Usuario,Contraseņa,Acceso) values(@Usuario,@Contraseņa,@Acceso)
go