Public Class FrmInformeVerAsistencias

    Private Sub FrmInformeVerAsistencias_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'GimnasioDataSet3.VerAsistencias' Puede moverla o quitarla según sea necesario.
        Me.VerAsistenciasTableAdapter.Fill(Me.GimnasioDataSet3.VerAsistencias)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class