Public Class FrmComprobante


    Private Sub FrmComprobante_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'EquilibriumDataSet.GenerarComprobante' Puede moverla o quitarla según sea necesario
        FrmDetalle.BtnFinalizar.Text = "Cerrar"
        FrmDetalle.TBDetalle.Enabled = False
        Dim Reporte As New FReporte
        Dim ID_Pago As Integer = Reporte.Generar_Pago
        Try
            Me.GenerarComprobanteTableAdapter.Fill(Me.EquilibriumDataSet.GenerarComprobante, ID_Pago:=ID_Pago)
            Me.ReportViewer1.RefreshReport()
        Catch ex As Exception
            Me.ReportViewer1.RefreshReport()
        End Try

    End Sub
End Class