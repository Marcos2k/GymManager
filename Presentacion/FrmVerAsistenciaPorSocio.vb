Public Class FrmVerAsistenciaPorSocio

    Private Sub FrmVerAsistenciaPorSocio_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'GimnasioDataSet3.VerAsistenciaPorSocio' Puede moverla o quitarla según sea necesario.
        Me.VerAsistenciaPorSocioTableAdapter.Fill(Me.GimnasioDataSet3.VerAsistenciaPorSocio, TBIDSocio.Text)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class