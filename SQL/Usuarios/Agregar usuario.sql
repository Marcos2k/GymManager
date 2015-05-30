Create proc AgregarUsuario
@Usuario varchar(20),
@Contraseña varchar(16),
@Acceso int
As
INSERT INTO Usuarios(Usuario,Contraseña,Acceso) values(@Usuario,@Contraseña,@Acceso)
go