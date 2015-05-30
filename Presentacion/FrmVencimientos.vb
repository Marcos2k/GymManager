Public Class FrmVencimientos

    Private Sub FrmVencimientos_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        OptVencimientopordia.Checked = True
        CargarDias()
        Socios.ActulizarDeudores()
        Socios.IncrementarCantidadCuota()
        MostrarDeudoresAlDia()
    End Sub
    ''' <summary>
    ''' Se encarga de mostrar los vendores que vencen el dia de hoy por ejemplo si es 3 febrero muestra todos los que deben los dias 3 de cada mes
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub MostrarDeudoresAlDia()
        Dim Funcion As New FModuloInformes
        Funcion.MostrarDeudoresAlDia(Grilla, LblInexistente)
    End Sub
    Private Sub CargarDias()
        NupDias.ReadOnly = True 'Indica que unicamente se puede cambiar con los controles arriba y abajo, no se pueden introducir valores
        NupDias.Minimum = 1
        NupDias.Maximum = 31
        NupDias.Value = CInt(Today.Day)
    End Sub
    Private Sub BtnConsultar_Click(sender As System.Object, e As System.EventArgs) Handles BtnConsultar.Click
        If OptVencimientopordia.Checked Then
            'Realiza la consulta se cuales se vencen en el dia por fecha
            Dim Vencimiento As Integer = NupDias.Value
            Dim Dato As New VSocios
            Dim Funcion As New FModuloInformes
            Dato.GVencimiento = Vencimiento
            Funcion.MostrarDeudoresPorFecha(Grilla, LblInexistente, Dato)
        ElseIf OptTodoslosdeudores.Checked Then
            'Lista todos los deudores desde 2014 hasta el dia de hoy
            Dim Funcion As New FModuloInformes
            Funcion.SeleccionarDeudoresTotales(Grilla, LblInexistente)
        Else
            MessageBox.Show("Debe elegir una accion a realizar", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub BtnSalir_Click(sender As System.Object, e As System.EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub

    Private Sub BtnLimpiar_Click(sender As System.Object, e As System.EventArgs) Handles BtnLimpiar.Click
        Grilla.DataSource = Nothing
    End Sub

    Private Sub BtnGenerarInforme_Click(sender As System.Object, e As System.EventArgs) Handles BtnGenerarInforme.Click
        If OptVencimientopordia.Checked Then
            FrmInformeVencimientos.TBDia.Text = NupDias.Value
            FrmInformeVencimientos.ShowDialog()
        ElseIf OptTodoslosdeudores.Checked Then
            FrmListadoDeudoresTotales.ShowDialog()
        End If
    End Sub
End Class