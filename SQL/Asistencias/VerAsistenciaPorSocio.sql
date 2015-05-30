Create proc VerAsistenciaPorSocio
@ID_Socio int
as
Select S.Nombre, S.Apellido,A.Fecha,A.Hora from Socios S INNER JOIN
Asistencias A on S.ID=A.ID_Socio Where A.ID_Socio = @ID_Socio
go