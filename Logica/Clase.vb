Module Clase
    'En este modulo se agrupan las clases a utilizar
    Public Socios As New FSocios
    Public Pagos As New FPagos
    Public Asistencias As New FAsistencias
    'Metodos de acceso publico para las clases y los formularios
    Public Sub CargarEdad(CBEdad As ComboBox)
        CBEdad.Items.Clear()
        Dim Edad As Integer
        For Edad = 3 To 50
            CBEdad.Items.Add(Edad)
        Next
        CBEdad.SelectedIndex = 0
    End Sub
    Public Sub LlenarAcceso(CBAcceso As ComboBox)
        CBAcceso.Items.Clear()
        CBAcceso.Items.Add("Total")
        CBAcceso.Items.Add("Limitado")
        CBAcceso.SelectedIndex = 0
    End Sub
    Public Sub LlenarGrilla(Grilla As DataGridView, LblInexistente As LinkLabel, TBBuscar As TextBox, CBFiltro As ComboBox)
        Dim Tabla As New DataTable
        Tabla = Socios.MostrarSocios

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

        Buscar(Tabla, Grilla, TBBuscar, CBFiltro, LblInexistente)
    End Sub

    Public Sub Buscar(Tabla As DataTable, Grilla As DataGridView, TBBuscar As TextBox, CBFiltro As ComboBox, LblInexistente As LinkLabel)
        Dim DS As New DataSet
        DS.Tables.Add(Tabla.Copy) 'Le pasamos una copia de la tabla al DataSet vacio

        Dim DV As New DataView(DS.Tables(0)) ' le pasamos como parametro la tabla del indice 0 
        DV.RowFilter = CBFiltro.Text & " like'" & TBBuscar.Text & "%'"

        Try
            If DV.Count <> 0 Then
                Grilla.DataSource = DV
                LblInexistente.Visible = False
            Else
                Grilla.DataSource = Nothing
                LblInexistente.Visible = True
            End If
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        End Try
    End Sub

    Public Sub CargarFiltro(CBFiltro As ComboBox)
        CBFiltro.Items.Clear()
        CBFiltro.Items.Add("Nombre")
        CBFiltro.Items.Add("Apellido")
        CBFiltro.Items.Add("Dni")
    End Sub

    Public Sub LlenarGrillaPagos(Grilla As DataGridView, LblInexistente As LinkLabel, TBBuscar As TextBox, CBFiltro As ComboBox)
        Dim Tabla As New DataTable
        Tabla = Pagos.MostrarPagos

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

        Buscar(Tabla, Grilla, TBBuscar, CBFiltro, LblInexistente)
    End Sub

    Public Sub LlenarGrillaTodasLasAsistencias(Grilla As DataGridView, LblInexistente As LinkLabel)
        Dim Tabla As New DataTable
        Tabla = Asistencias.VerAsistencias

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
    Public Sub LlenarGrillaPorSocio(Grilla As DataGridView, LblInexistente As LinkLabel, ID_Socio As Integer)
        Dim Tabla As New DataTable
        Tabla = Asistencias.VerAsistenciaPorSocio(ID_Socio)

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
    Public Function MostrarAsistenciasPorFecha(Grilla As DataGridView, LblInexistente As LinkLabel, Desde As Date, Hasta As Date)
        Dim Tabla As New DataTable
        Tabla = Asistencias.MostrarAsistenciasPorFecha(Desde, Hasta)
        Try
            If Tabla.Rows.Count <> 0 Then
                Grilla.DataSource = Tabla
                Grilla.ColumnHeadersVisible = True
                LblInexistente.Visible = False
                Return True
            Else
                Grilla.DataSource = Nothing
                Grilla.ColumnHeadersVisible = False
                LblInexistente.Visible = True
                Return False
            End If
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
            Return False
        End Try
    End Function
End Module
