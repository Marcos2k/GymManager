Public Class FrmLogin
    Private Sub BtnSalir_Click(sender As System.Object, e As System.EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub
    Private Sub BtnIngresar_Click(sender As System.Object, e As System.EventArgs) Handles BtnIngresar.Click
        EntrarAlSistema()
    End Sub

    Private Sub SalirDelSistema()
        Dim Seguridad As New FSeguridad
        If Seguridad.SalirDelSistema = True Then
            Me.Close()
        End If
    End Sub
    Private Sub Limpiar()
        TBUsuario.Text = ""
        TBContraseña.Text = ""
        TBUsuario.Focus()
    End Sub

    Private Sub EntrarAlSistema()
        If TBUsuario.Text <> "" And TBContraseña.Text <> "" Then
            Try
                Dim Seguridad As New FSeguridad
                Dim Dato As New VUsuarios

                Dim Usuario As String = TBUsuario.Text
                Dim Contraseña As String = Seguridad.Encriptar(TBContraseña.Text) 'encriptamos contraseña
                'variables para controlar los accesos
                Dim Acceso_total As Integer = 1
                Dim Acceso_limitado As Integer = 2

                Dato.GNombre = Usuario
                Dato.GContraseña = Contraseña
                Dato.GAcceso = Acceso_total
                'intentamos loguearnos con los permiso total del sistema primero
                If Acceso_total = 1 Then
                    If Seguridad.Login(Dato) Then
                        Me.Visible = False
                        FrmMenu.ShowDialog()
                    Else
                        Dato.GAcceso = Acceso_limitado
                        If Acceso_limitado = 2 Then
                            If Seguridad.Login(Dato) Then
                                'Se restringen permisos del usuario
                                Seguridad.RestringirPermisos()
                                Me.Visible = False
                                FrmMenu.ShowDialog()
                            Else
                                MessageBox.Show("Usuario y/o contraseña incorrectos, intente nuevamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                Limpiar()
                                Exit Sub 'Sale del procedimiento directamente con Exit Sub
                            End If
                        End If
                    End If
                Else
                    MessageBox.Show("Usuario y/o contraseña incorrectos, intente nuevamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Limpiar()
                    Exit Sub
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
                Limpiar()
            End Try
        Else
            MessageBox.Show("Por favor completa los campos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Limpiar()
            Exit Sub
        End If

        SalirDelSistema() 'Sale del sistema
    End Sub

    Private Sub TBContraseña_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TBContraseña.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            EntrarAlSistema()
        End If
    End Sub
End Class