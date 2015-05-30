Public Class FrmSocios
    Private Sub TBBuscar_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        TBFlag.Visible = False
        CargarEdad(CBEdad)
        CargarDias()
        Clase.Socios.ObtenerEstado(CBEstado)
        Clase.Socios.ObtenerCategorias(CBCategoria)
        CargarFiltro(CBFiltro)
        LlenarGrilla(Grilla, LblInexistente, TBBuscar, CBFiltro)
        OcultarColumnas()

        'Bloquemos los controles al inicio del formulario
        BtnModificar.Enabled = False
        BtnRegistrar.Enabled = False
    End Sub

    Private Sub BtnNuevo_Click(sender As System.Object, e As System.EventArgs) Handles BtnNuevo.Click
        Limpiar()

        BtnRegistrar.Enabled = True
        BtnModificar.Enabled = False
        CBEstado.Enabled = False
    End Sub

    Private Sub Limpiar()
        LblID.Text = ""
        TBNombre.Text = ""
        TBApellido.Text = ""
        TBTelefono.Text = ""
        TBDni.Text = ""
        TBDireccion.Text = ""
        TBObservaciones.Text = ""

        CBEdad.SelectedIndex = 0
        CBEstado.SelectedIndex = 0 'vuelve al estado activo
        NupDias.Value = 1
    End Sub

    Private Sub OcultarColumnas()
        Grilla.Columns.Item(0).Visible = False
    End Sub

    Private Sub TBBuscar_TextChanged(sender As System.Object, e As System.EventArgs) Handles TBBuscar.TextChanged
        Try
            LlenarGrilla(Grilla, LblInexistente, TBBuscar, CBFiltro)
            OcultarColumnas()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Grilla_CellClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Grilla.CellClick

        Try
            LblID.Text = Grilla.SelectedCells.Item(0).Value
            TBNombre.Text = Grilla.SelectedCells.Item(1).Value
            TBApellido.Text = Grilla.SelectedCells.Item(2).Value
            TBDireccion.Text = Grilla.SelectedCells.Item(3).Value
            TBDni.Text = Grilla.SelectedCells.Item(4).Value
            CBEdad.Text = Grilla.SelectedCells.Item(5).Value
            TBTelefono.Text = Grilla.SelectedCells.Item(6).Value
            TBObservaciones.Text = Grilla.SelectedCells.Item(7).Value
            CBCategoria.Text = Grilla.SelectedCells.Item(8).Value
            CBEstado.Text = Grilla.SelectedCells.Item(9).Value
            NupDias.Value = Grilla.SelectedCells.Item(10).Value

            BtnRegistrar.Enabled = False
            BtnModificar.Enabled = True

            CBEstado.Enabled = True
        Catch ex As Exception
            ' Si una celda un valor NULL no pasa nada
        End Try
    End Sub
    Private Sub BtnRegistrar_Click(sender As System.Object, e As System.EventArgs) Handles BtnRegistrar.Click

        Dim Pregunta As DialogResult
        Pregunta = MessageBox.Show("Deseas confirmar el registro?", "Registrar socio", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        Try
            If Me.ValidateChildren = True And TBNombre.Text <> "" And TBApellido.Text <> "" And TBDireccion.Text <> "" And TBTelefono.Text <> "" And TBDni.Text <> "" Then
                Dim Dato As New VSocios

                Dato.GNombre = TBNombre.Text
                Dato.GApellido = TBApellido.Text
                Dato.GDireccion = TBDireccion.Text
                Dato.GDni = TBDni.Text
                Dato.GEdad = CInt(CBEdad.SelectedItem) 'Convierte el dato a int 
                Dato.GTelefono = TBTelefono.Text

                If TBObservaciones.Text = "" Then
                    Dato.GObservaciones = "Ninguna"
                ElseIf TBObservaciones.Text <> "" Then
                    Dato.GObservaciones = TBObservaciones.Text
                End If

                Dato.GCategoria = CInt(CBCategoria.SelectedValue)
                Dato.GEstado = CInt(CBEstado.SelectedValue)
                Dato.GVencimiento = CInt(NupDias.Value)
                'Pregunta si quiere grabar el dato
                If Pregunta = DialogResult.OK Then
                    If Clase.Socios.RegistrarSocio(Dato) Then
                        MessageBox.Show("Socio registrado con exito", "Enhorabuena", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Limpiar()
                        LlenarGrilla(Grilla, LblInexistente, TBBuscar, CBFiltro)

                        BtnRegistrar.Enabled = False
                    Else
                        MessageBox.Show("No se pudo registrar el socio", "Intente nuevamente", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Else
                    'En caso de que no
                    MessageBox.Show("El registro de socios ha sido cancelado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Else
                MessageBox.Show("Por favor completa los campos", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub BtnModificar_Click(sender As System.Object, e As System.EventArgs) Handles BtnModificar.Click

        Dim Pregunta As DialogResult
        Pregunta = MessageBox.Show("Deseas modificar los datos seleccionados?", "Modificando registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        Try
            If Me.ValidateChildren = True And TBNombre.Text <> "" And TBApellido.Text <> "" And TBDireccion.Text <> "" And TBTelefono.Text <> "" And TBDni.Text <> "" And LblID.Text <> "" Then
                Dim Dato As New VSocios

                Dato.GID = LblID.Text
                Dato.GNombre = TBNombre.Text
                Dato.GApellido = TBApellido.Text
                Dato.GDireccion = TBDireccion.Text
                Dato.GDni = TBDni.Text
                Dato.GEdad = CInt(CBEdad.SelectedItem) 'Convierte el dato a int 
                Dato.GTelefono = TBTelefono.Text

                If TBObservaciones.Text = "" Then
                    Dato.GObservaciones = "Ninguna"
                ElseIf TBObservaciones.Text <> "" Then
                    Dato.GObservaciones = TBObservaciones.Text
                End If

                Dato.GCategoria = CInt(CBCategoria.SelectedValue)
                Dato.GEstado = CInt(CBEstado.SelectedValue)
                Dato.GVencimiento = CInt(NupDias.Value)
                If Pregunta = DialogResult.OK Then
                    If Clase.Socios.ModificarSocio(Dato) Then
                        MessageBox.Show("Socio modificado con exito", "Enhorabuena", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Limpiar()
                        LlenarGrilla(Grilla, LblInexistente, TBBuscar, CBFiltro)

                        BtnRegistrar.Enabled = False
                    Else
                        MessageBox.Show("No se pudo modificar el socio", "Intente nuevamente", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Else
                    MessageBox.Show("La modificacion de registros ha sido cancelada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Else
                MessageBox.Show("Por favor completa los campos", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Grilla_CellDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Grilla.CellDoubleClick
        If TBFlag.Text = 1 Then
            FrmPagos.LblID.Text = Grilla.SelectedCells.Item(0).Value
            FrmPagos.TBNombre.Text = Grilla.SelectedCells.Item(1).Value & " " & Grilla.SelectedCells.Item(2).Value 'pasamos el nombre y el apellido concatenando
            Dim Estado As String = Grilla.SelectedCells.Item(9).Value
            Dim Aviso As String = "El estado actual de este socio es " & Estado
            MessageBox.Show(Aviso, "Estado del actual del socio", MessageBoxButtons.OK, MessageBoxIcon.Information)
            FrmPagos.LblEstado.Text = Aviso
            Me.Close() 'Cierra el formulario
        End If

        If TBFlag.Text = 2 Then
            FrmModuloInformes.LblID.Text = Grilla.SelectedCells.Item(0).Value
            FrmModuloInformes.TBNombre.Text = Grilla.SelectedCells.Item(1).Value & " " & Grilla.SelectedCells.Item(2).Value 'pasamos el nombre y el apellido concatenando

            Me.Close() 'Cierra el formulario
        End If

        If TBFlag.Text = 3 Then
            FrmRegistrarAsistencias.LblID.Text = Grilla.SelectedCells.Item(0).Value
            FrmRegistrarAsistencias.TBNombre.Text = Grilla.SelectedCells.Item(1).Value & " " & Grilla.SelectedCells.Item(2).Value 'pasamos el nombre y el apellido concatenando
            Me.Close()
            Exit Sub 'Salimos del evento de manera forzada por que si no continua ejecutando y genera error 
        End If

        If TBFlag.Text = 4 Then
            FrmVerAsistencias.LblID.Text = Grilla.SelectedCells.Item(0).Value
            FrmVerAsistencias.TBNombre.Text = Grilla.SelectedCells.Item(1).Value & " " & Grilla.SelectedCells.Item(2).Value 'pasamos el nombre y el apellido concatenando
            Me.Close()
        End If
    End Sub
    Private Sub CargarDias()
        NupDias.ReadOnly = True 'Indica que unicamente se puede cambiar con los controles arriba y abajo, no se pueden introducir valores
        NupDias.Minimum = 1
        NupDias.Maximum = 31
    End Sub

    Private Sub Grilla_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Grilla.CellContentClick

    End Sub
End Class