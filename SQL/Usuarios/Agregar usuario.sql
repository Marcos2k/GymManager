Create proc AgregarUsuario
@Usuario varchar(20),
@Contrase�a varchar(16),
@Acceso int
As
INSERT INTO Usuarios(Usuario,Contrase�a,Acceso) values(@Usuario,@Contrase�a,@Acceso)
go