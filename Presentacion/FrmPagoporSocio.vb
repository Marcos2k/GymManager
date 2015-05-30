Public Class FrmPagoporSocio

    Private Sub FrmPagoporSocio_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'EquilibriumDataSet2.ObtenerPagoPorSocio' Puede moverla o quitarla según sea necesario.
        Me.ObtenerPagoPorSocioTableAdapter.Fill(Me.EquilibriumDataSet2.ObtenerPagoPorSocio, ID_Socio:=FrmModuloInformes.LblID.Text)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class