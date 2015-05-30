Create proc RegistrarPago
@ID_Socio int,
@Fecha date,
@Monto decimal(7,2)
As 
INSERT INTO Pagos(ID_Socio,Fecha,Monto) VALUES(@ID_Socio,@Fecha,@Monto)
GO