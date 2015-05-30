Public Class FrmAsistenciaPorFechas

    Private Sub FrmAsistenciaPorFechas_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'GimnasioDataSet3.MostrarAsistenciasPorFecha' Puede moverla o quitarla según sea necesario.
        Me.MostrarAsistenciasPorFechaTableAdapter.Fill(Me.GimnasioDataSet3.MostrarAsistenciasPorFecha, FrmVerAsistencias.DTFechaDesde.Text, FrmVerAsistencias.DTFechaHasta.Text)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class