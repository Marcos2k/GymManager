Public Class FrmModuloInformes

    Private Sub BtnSalir_Click(sender As System.Object, e As System.EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub

    Private Sub FrmModuloInformes_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'Deshabilitamos los controles de mostrar pagos por socio especifico
        TBNombre.Enabled = False
        BtnBuscar.Enabled = False
        'Deshabilitamos los controles de mostrar pagos por socio especifico
        DTFechaDesde.Enabled = False
        DTFechaHasta.Enabled = False
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

    Private Sub OptMontos_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles OptMontos.CheckedChanged
       
        If OptMontos.Checked = True Then
            DTFechaDesde.Enabled = True
            DTFechaHasta.Enabled = True
        Else
            DTFechaDesde.Enabled = False
            DTFechaHasta.Enabled = False
        End If
    End Sub

    Private Sub BtnBuscar_Click(sender As System.Object, e As System.EventArgs) Handles BtnBuscar.Click

        Dim Formulario As New FrmSocios 'creamos un objeto instanciano a la clase socios

        Formulario.TBFlag.Text = 2
        Formulario.ShowDialog()
    End Sub

    Private Sub BtnConsultar_Click(sender As System.Object, e As System.EventArgs) Handles BtnConsultar.Click
        If OptTodosSocios.Checked = False And OptSociosespecifico.Checked = False And OptMontos.Checked = False Then
            MessageBox.Show("Elija una tarea", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            If OptTodosSocios.Checked Then
                Dim Funcion As New FModuloInformes
                Funcion.MostrarTodosLosSocios(Grilla)
            End If
            If OptSociosespecifico.Checked Then
                If LblID.Text = "" Then
                    MessageBox.Show("Seleccione a un socio", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Else
                    Dim Funcion As New FModuloInformes
                    Dim Dato As New VSocios
                    Dato.GID = LblID.Text
                    Funcion.ObtenerPagosPorSocio(Grilla, Dato)
                End If
            End If
            If OptMontos.Checked Then
                'calcula las fechas y luego los montos
                Dim Funcion As New FModuloInformes
                Dim Desde As Date = DTFechaDesde.Text
                Dim Hasta As Date = DTFechaHasta.Text
                Funcion.MostrarPagosPorFecha(Grilla, Desde, Hasta)
            End If
        End If
    End Sub

    Private Sub BtnLimpiar_Click(sender As System.Object, e As System.EventArgs) Handles BtnLimpiar.Click
        Grilla.DataSource = Nothing
    End Sub

    Private Sub BtnGenerarInforme_Click(sender As System.Object, e As System.EventArgs) Handles BtnGenerarInforme.Click
        If OptTodosSocios.Checked = False And OptMontos.Checked = False And OptSociosespecifico.Checked = False Then
            'se aseguara que haya una accion seleccionada
            MessageBox.Show("Seleccione a una accion a realizar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            'abre los formularios con los informes ya generados
            If OptTodosSocios.Checked Then
                FrmListado.ShowDialog()
            Else
                If OptMontos.Checked Then
                    FrmBalancedepagosporfecha.ShowDialog()
                ElseIf OptSociosespecifico.Checked Then
                    'Se asegura que el socio es elegido
                    If LblID.Text = "" Then
                        MessageBox.Show("Seleccione a un socio", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Else
                        FrmPagoporSocio.ShowDialog()
                    End If
                End If
            End If
        End If
    End Sub
End Class