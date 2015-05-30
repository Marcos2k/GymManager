Public Class FrmDetalle

    Private Sub BtnFinalizar_Click(sender As System.Object, e As System.EventArgs) Handles BtnFinalizar.Click
        If BtnFinalizar.Text = "Finalizar" Then
            If Me.ValidateChildren = True And TBDetalle.Text <> "" Then
                'Comprobamos que no inserten espacios
                If String.IsNullOrWhiteSpace(TBDetalle.Text) Then
                    MessageBox.Show("No se admiten campos vacios o espacios por favor complete", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Else
                    Dim Dato As New VPago

                    Dato.GID_Pago = LblIDPago.Text
                    Dato.GConcepto = TBDetalle.Text

                    If Clase.Pagos.GuardarDetalle(Dato) Then

                        Dim Pregunta As DialogResult
                        Pregunta = MessageBox.Show("Pago emitido con exito, desea imprimir comprobante", "Aviso!", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                        If Pregunta = DialogResult.Yes Then
                            'Si acepta imprime comprobante
                            Dim Reporte As New FReporte
                            Reporte.Generar_Pago()  'muestra el reporte con el pago
                            Limpiar()
                            FrmComprobante.ShowDialog()
                        Else
                            'Limpia los controles
                            Limpiar()
                            'Si no acepta sale
                            Me.Close()
                        End If
                    Else
                        MessageBox.Show("Error al guardar detaller intente nuevamente", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End If
            Else
                MessageBox.Show("Por favor complete los campos para finalizar", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        ElseIf BtnFinalizar.Text = "Cerrar" Then
            Me.Close()
        End If

    End Sub
    Private Sub Limpiar()
        FrmPagos.TBNombre.Text = ""
        FrmPagos.LblID.Visible = False
        FrmPagos.TBMonto.Text = ""
    End Sub
    Private Sub FrmDetalle_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        LblIDPago.Visible = False
        TBDetalle.Text = ""
    End Sub
End Class