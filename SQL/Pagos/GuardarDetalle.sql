create proc GuardarDetalle
@ID_Pago int,
@Concepto varchar(255)
as
INSERT INTO Detalle_Pago(ID_Pago,Concepto) VALUES(@ID_Pago,@Concepto)
GO