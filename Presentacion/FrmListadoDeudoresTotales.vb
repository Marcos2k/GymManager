Public Class FrmListadoDeudoresTotales

    Private Sub FrmListadoDeudoresTotales_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'GimnasioDataSet2.GenerarInformeTodosLosDeudores' Puede moverla o quitarla según sea necesario.
        Me.GenerarInformeTodosLosDeudoresTableAdapter.Fill(Me.GimnasioDataSet2.GenerarInformeTodosLosDeudores)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class