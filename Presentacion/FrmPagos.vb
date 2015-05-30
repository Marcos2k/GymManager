Public Class FrmPagos

    Private Sub BtnBuscar_Click(sender As System.Object, e As System.EventArgs) Handles BtnBuscar.Click
        Dim Formulario As New FrmSocios 'creamos un objeto instanciano a la clase socios

        Formulario.TBFlag.Text = 1
        Formulario.ShowDialog()
    End Sub

    Private Sub BtnSiguiente_Click(sender As System.Object, e As System.EventArgs) Handles BtnSiguiente.Click
        If Me.ValidateChildren = True And LblID.Text <> "" And TBNombre.Text <> "" And DTFecha.Text <> "" And TBMonto.Text <> "" Then
            If String.IsNullOrWhiteSpace(TBMonto.Text) Then
                MessageBox.Show("No se admiten campos vacios o espacios por favor complete", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            Else
                Dim Dato As New VPago

                Dato.GID_Socio = LblID.Text
                Dato.GFecha = DTFecha.Text
                Dim Precio As String = TBMonto.Text
                Dim MontoFinal As Decimal = Replace(Precio, ".", ",")
                Dato.GMonto = MontoFinal

                Dim Pregunta As DialogResult
                Pregunta = MessageBox.Show("Deseas confirmar la operacion?", "Emitir cobro", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

                If Pregunta = DialogResult.OK Then
                    If Clase.Pagos.RegistrarPago(Dato) Then
                        MessageBox.Show("Pago registrado con exito, vamos a añadir el detalle/concepto", "Registrando pago", MessageBoxButtons.OK, MessageBoxIcon.Question)
                        Ir_aDetalle() 'nos dirigimos al siguiente formulario
                        ActualizarDeuda() 'Actualiza la cantidad de meses que debe el socio
                        TBBuscar.Text = ""
                        LlenarGrillaPagos(Grilla, LblInexistente, TBBuscar, CBFiltro)
                        OcultarColumnas()
                    Else
                        MessageBox.Show("Error al emitir el cobro, intente nuevamente", "Cancelando cobro", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                Else
                    MessageBox.Show("Se ha cancelado el cobro", "Cancelando cobro", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
            
        Else
            MessageBox.Show("Por favor complete los campos para continuar", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub FrmPagos_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        LlenarFiltro()
        LlenarGrillaPagos(Grilla, LblInexistente, TBBuscar, CBFiltro)
        OcultarColumnas()
    End Sub
    Private Sub LlenarFiltro()
        CBFiltro.Items.Clear()
        CBFiltro.Items.Add("Nombre")
        CBFiltro.Items.Add("Apellido")
    End Sub
    Private Sub OcultarColumnas()
        Try
            Grilla.Columns.Item(0).Visible = False
        Catch ex As Exception

        End Try
    End Sub

    Private Sub TBBuscar_TextChanged(sender As System.Object, e As System.EventArgs) Handles TBBuscar.TextChanged
        Try
            LlenarGrillaPagos(Grilla, LblInexistente, TBBuscar, CBFiltro)
            OcultarColumnas()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Ir_aDetalle()
        FrmDetalle.LblIDPago.Text = Clase.Pagos.ObtenerUltimoPago
        FrmDetalle.ShowDialog()
    End Sub
    Private Sub ActualizarDeuda()
        Dim Dato As New VSocios
        Dim Funcion As New FPagos
        Dato.GID = CInt(LblID.Text)
        Funcion.ActualizarDeuda(Dato) 'Ejecuta la actualizacion de la deuda
        LblID.Text = ""
        LblID.Visible = True
    End Sub
    Private Sub TBMonto_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TBMonto.KeyPress
        If Char.IsLetter(e.KeyChar) Then 'No permitimos que se ingresen letras
            e.Handled = True
        End If
    End Sub
End Class