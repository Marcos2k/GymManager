Create proc MostrarAsistenciasPorFecha
@Desde date,
@Hasta date
as
Select S.Nombre, S.Apellido,A.Fecha,A.Hora from Socios S INNER JOIN
Asistencias A on S.ID=A.ID_Socio Where A.Fecha Between @Desde and @Hasta
go