Public Class FrmAgregar_usuario
    Private Sub FrmAgregar_usuario_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        LlenarAcceso(CBAcceso)
    End Sub

    Private Sub BtnAgregar_Click(sender As System.Object, e As System.EventArgs) Handles BtnAgregar.Click

        If Me.ValidateChildren = True And TBUsuario.Text <> "" And TBContraseña.Text <> "" And TBContraseñaValidar.Text <> "" Then
            Dim Dato As New VUsuarios
            Dim Funcion As New FUsuarios
            Dato.GNombre = TBUsuario.Text.Trim
            If Funcion.ComprobarUsuario(Dato) = False Then
                MessageBox.Show("El nombre de usuario ya existe, intenta otro", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Limpiar()
                Exit Sub 'Sale del if
            Else
                'En caso de que el usuario no exista procede
                If TBContraseña.Text = TBContraseñaValidar.Text Then ' las contraseñas coinciden
                    Dim Seguridad As New FSeguridad
                    Dim Contraseña As String = Seguridad.Encriptar(TBContraseña.Text) 'encripta la contraseña
                    Dato.GNombre = TBUsuario.Text
                    Dato.GContraseña = Contraseña 'es la contraseña ya encriptada
                    'Define los tipos de acceso
                    If CBAcceso.Text = "Total" Then
                        Dato.GAcceso = 1
                    ElseIf CBAcceso.Text = "Limitado" Then
                        Dato.GAcceso = 2
                    End If

                    If Funcion.RegistrarUsuario(Dato) Then
                        MessageBox.Show("Usuario registrado con exito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Limpiar()
                    Else
                        MessageBox.Show("Error al registrar usuario,intenta nuevamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Else
                    MessageBox.Show("Las contraseñas no coinciden", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Limpiar()
                End If
            End If
        Else
            MessageBox.Show("Por favor completa los campos", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub
    Private Sub Limpiar()
        TBUsuario.Text = ""
        TBContraseña.Text = ""
        TBContraseñaValidar.Text = ""
        CBAcceso.SelectedIndex = 0
    End Sub
End Class