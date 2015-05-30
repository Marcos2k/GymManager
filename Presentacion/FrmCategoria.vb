Public Class FrmCategoria
    Private Sub FrmCategoria_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        LlenarGrilla()
    End Sub
    Private Sub LlenarGrilla()
        Dim Tabla As New DataTable
        Dim Categoria As New FCategorias
        Tabla = Categoria.MostrarCategoria
        Try
            If Tabla.Rows.Count <> 0 Then
                Grilla.DataSource = Tabla
                Grilla.ColumnHeadersVisible = True
                LblInexistente.Visible = False
            Else
                Grilla.DataSource = Nothing
                Grilla.ColumnHeadersVisible = False
                LblInexistente.Visible = True
            End If
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        End Try
    End Sub
    Private Sub BtnAceptar_Click(sender As System.Object, e As System.EventArgs) Handles BtnAceptar.Click
        If TBNombre.Text <> "" Then
            If String.IsNullOrWhiteSpace(TBNombre.Text) Then 'controla que no haya espacios en blanco o nulos
                MessageBox.Show("No se admiten campos vacios o espacios por favor complete", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                Dim Pregunta As DialogResult
                Pregunta = MessageBox.Show("Deseas agregar una categoria", "Agregar categoria", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

                If Pregunta = DialogResult.OK Then
                    'Si confirma proceda, caso contrario no
                    Dim Nombre As String = TBNombre.Text
                    Dim Funcion As New FCategorias
                    If Funcion.InsertarCategoria(Nombre) Then
                        MessageBox.Show("Categoria agregada con exito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        TBNombre.Text = ""
                        LlenarGrilla() 'refrescamos la grilla
                    Else
                        MessageBox.Show("Error al guardar registrar categoria, intente nuevamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        TBNombre.Text = ""
                    End If
                Else
                    MessageBox.Show("Se ha cancelado la operacion", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        Else
            MessageBox.Show("Ingrese el categoria de la categoria", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub
End Class