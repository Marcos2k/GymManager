Public Class FrmBalancedepagosporfecha

    Private Sub FrmBalancedepagosporfecha_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'EquilibriumDataSet2.MostrarPagoPorFechas' Puede moverla o quitarla según sea necesario.
        Me.MostrarPagoPorFechasTableAdapter.Fill(Me.EquilibriumDataSet2.MostrarPagoPorFechas, Desde:=FrmModuloInformes.DTFechaDesde.Text, Hasta:=FrmModuloInformes.DTFechaHasta.Text)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class