Public Class FrmRegistrarAsistencias

    Private Sub FrmRegistrarAsistencias_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        LblFecha.Text = Today 'mostramos la fecha de hoy
        LblHora.Text = TimeOfDay
        LblID.Visible = False
        Temporizador.Start() 'iniciamos el temporizador
        BtnRegistrar.Enabled = False
    End Sub

    Private Sub Temporizador_Tick(sender As System.Object, e As System.EventArgs) Handles Temporizador.Tick
        LblHora.Text = TimeOfDay
    End Sub

    Private Sub TBNombre_TextChanged(sender As System.Object, e As System.EventArgs) Handles TBNombre.TextChanged
        If TBNombre.Text <> "" And LblID.Text <> "" Then
            BtnRegistrar.Enabled = True
        Else
            BtnRegistrar.Enabled = False
        End If
    End Sub

    Private Sub BtnRegistrar_Click(sender As System.Object, e As System.EventArgs) Handles BtnRegistrar.Click
        If TBNombre.Text <> "" And LblID.Text <> "" Then
            'Procemos a grabar la asistencia
            Dim Funcion As New FAsistencias
            Dim Fecha As Date = LblFecha.Text
            Dim Hora As String = LblHora.Text
            Dim ID As Integer = LblID.Text

            If Funcion.RegistrarAsistencia(ID, Fecha, Hora) Then
                MessageBox.Show("Asistencia registrada con exito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                TBNombre.Text = ""
                LblID.Text = ""
            Else
                MessageBox.Show("Error al registrar asistencia, intente nuevamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Else
            MessageBox.Show("Debe seleccionar a un socio", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
    Private Sub BtnBuscar_Click(sender As System.Object, e As System.EventArgs) Handles BtnBuscar.Click
        'Llamamos al formulario de socios
        FrmSocios.TBFlag.Text = 3
        FrmSocios.Show()
    End Sub
End Class