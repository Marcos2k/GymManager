Public Class FrmVerAsistencias
    Private Sub FrmVerAsistencias_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'Deshabilitamos los controles de mostrar pagos por socio especifico
        TBNombre.Enabled = False
        BtnBuscar.Enabled = False
        'Deshabilitamos los controles de mostrar pagos por socio especifico
        DTFechaDesde.Enabled = False
        DTFechaHasta.Enabled = False
        OptTodasAsistencias.Checked = True 'dejamos este control activado por defecto
    End Sub

    Private Sub OptSociosespecifico_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles OptSociosespecifico.CheckedChanged
        If OptSociosespecifico.Checked Then
            TBNombre.Enabled = True
            BtnBuscar.Enabled = True
        Else
            TBNombre.Enabled = False
            BtnBuscar.Enabled = False
        End If
    End Sub

    Private Sub OptFiltro_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles OptFiltro.CheckedChanged

        If OptFiltro.Checked = True Then
            DTFechaDesde.Enabled = True
            DTFechaHasta.Enabled = True
        Else
            DTFechaDesde.Enabled = False
            DTFechaHasta.Enabled = False
        End If
    End Sub

    Private Sub BtnConsultar_Click(sender As System.Object, e As System.EventArgs) Handles BtnConsultar.Click
        If OptTodasAsistencias.Checked = True Then
            Clase.LlenarGrillaTodasLasAsistencias(Grilla, LblInexistente)
        ElseIf OptSociosespecifico.Checked = True Then
            Dim ID_Socio As Integer = LblID.Text
            Clase.LlenarGrillaPorSocio(Grilla, LblInexistente, ID_Socio)
        ElseIf OptFiltro.Checked = True Then
            'calcula las fechas y luego los montos

            Dim Desde As Date = DTFechaDesde.Text
            Dim Hasta As Date = DTFechaHasta.Text
            Clase.MostrarAsistenciasPorFecha(Grilla, LblInexistente, Desde, Hasta)
        End If
    End Sub

    Private Sub BtnLimpiar_Click(sender As System.Object, e As System.EventArgs) Handles BtnLimpiar.Click
        Grilla.DataSource = Nothing
    End Sub

    Private Sub BtnBuscar_Click(sender As System.Object, e As System.EventArgs) Handles BtnBuscar.Click
        'Llamamos al formulario de socios
        FrmSocios.TBFlag.Text = 4
        FrmSocios.Show()
    End Sub

    Private Sub BtnSalir_Click(sender As System.Object, e As System.EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub

    Private Sub BtnGenerarInforme_Click(sender As System.Object, e As System.EventArgs) Handles BtnGenerarInforme.Click
        If OptTodasAsistencias.Checked = True Then
            FrmInformeVerAsistencias.ShowDialog()
        ElseIf OptSociosespecifico.Checked = True Then
            FrmVerAsistenciaPorSocio.TBIDSocio.Text = LblID.Text
            FrmVerAsistenciaPorSocio.ShowDialog()
        ElseIf OptFiltro.Checked = True Then
            FrmAsistenciaPorFechas.ShowDialog()
        End If
    End Sub
End Class