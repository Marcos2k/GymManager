Public Class FrmListado

    Private Sub FrmListado_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'EquilibriumDataSet2.MostrarSocios' Puede moverla o quitarla según sea necesario.
        Me.MostrarSociosTableAdapter.Fill(Me.EquilibriumDataSet2.MostrarSocios)

        Me.ReportViewer1.RefreshReport()
    End Sub

   
End Class