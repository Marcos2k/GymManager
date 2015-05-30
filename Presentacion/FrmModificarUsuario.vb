Public Class FrmModificarUsuario
    Private Sub FrmModificarUsuario_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        LlenarAcceso(CBAcceso)
    End Sub


    Private Sub BtnAgregar_Click(sender As System.Object, e As System.EventArgs) Handles BtnAgregar.Click
        If Me.ValidateChildren = True And TBUsuario.Text <> "" And TBContraseña.Text <> "" And TBContraseñaValidar.Text <> "" Then
            Dim Dato As New VUsuarios
            Dim Funcion As New FUsuarios

            Dato.GNombre = TBUsuario.Text.Trim
            If Funcion.ComprobarUsuario(Dato) = False Then
                'En caso de que el usuario  exista procede
                'Encriptamos la contraseña antigua
                Dim Seguridad As New FSeguridad
                Dim Contraseña_antigua = Seguridad.Encriptar(TBContraseñaValidar.Text)
                'Comprobamos si la contraseña es la correcta
                If Funcion.ComprobarContraseña(Contraseña_antigua) = True Then
                    'Si la clave es correcta y nos da un valor verdadero
                    Dim Contraseña_nueva As String = Seguridad.Encriptar(TBContraseña.Text) 'encripta la contraseña nueva
                    'Buscamos el ID del usuario
                    Dato.GNombre = TBUsuario.Text
                    Dato.GContraseña = Contraseña_antigua
                    Dim ID_Usuario As Integer = Funcion.BuscarIdUsuario(Dato)
                    'una vez logrado procedemos a realizar el UPDATE
                    Dato.GNombre = TBUsuario.Text
                    Dato.GContraseña = Contraseña_nueva 'introducimos la contraseña nueva
                    'Define los tipos de acceso
                    If CBAcceso.Text = "Total" Then
                        Dato.GAcceso = 1
                    ElseIf CBAcceso.Text = "Limitado" Then
                        Dato.GAcceso = 2
                    End If
                    Dato.GID_Usuario = ID_Usuario

                    If Funcion.ModificarUsuario(Dato) Then
                        MessageBox.Show("Usuario modificado con exito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Limpiar()
                    Else
                        MessageBox.Show("Error al registrar usuario,intenta nuevamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Else
                    MessageBox.Show("El usuario o contraseña son incorrectos, verifica que los datos sean correctos", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End If
            Else
                MessageBox.Show("El usuario o contraseña son incorrectos, verifica que los datos sean correctos", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
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