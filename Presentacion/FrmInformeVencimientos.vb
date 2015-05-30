Public Class FrmInformeVencimientos

    Private Sub FrmInformeVencimientos_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        TBDia.Visible = False
        'TODO: esta línea de código carga datos en la tabla 'GimnasioDataSet.ConsultarDeudoresPorFecha' Puede moverla o quitarla según sea necesario.
        Me.ConsultarDeudoresPorFechaTableAdapter.Fill(Me.GimnasioDataSet.ConsultarDeudoresPorFecha, Vencimiento:=TBDia.Text)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class