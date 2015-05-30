Imports System.Data.SqlClient
Public Class FModuloInformes
    Inherits Conexion
    Dim Comando As New SqlCommand
    ''' <summary>
    ''' Muestra todos los socios inscriptos desde la base de datos
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks>Recibe como parametro un objeto DataGridView</remarks>
    '''
    Public Function MostrarTodosLosSocios(Grilla As DataGridView)
        Dim Tabla As New DataTable
        Dim Socios As New FSocios
        Tabla = Socios.MostrarSocios
        Try
            If Tabla.Rows.Count <> 0 Then
                Grilla.DataSource = Tabla
                Grilla.ColumnHeadersVisible = True
                Return True
            Else
                Grilla.DataSource = Nothing
                Grilla.ColumnHeadersVisible = False
                Return False
            End If
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
            Return False
        End Try
    End Function

    Public Function ObtenerPagosPorSocio(Grilla As DataGridView, Dato As VSocios)
        Dim Tabla As New DataTable
        Dim Pagos As New FPagos
        Tabla = Pagos.ObtenerPagoPorSocio(Dato)
        Try
            If Tabla.Rows.Count <> 0 Then
                Grilla.DataSource = Tabla
                Grilla.ColumnHeadersVisible = True
                Return True
            Else
                Grilla.DataSource = Nothing
                Grilla.ColumnHeadersVisible = False
                Return False
            End If
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
            Return False
        End Try
    End Function

    Public Function MostrarPagosPorFecha(Grilla As DataGridView, Desde As Date, Hasta As Date)
        Dim Tabla As New DataTable
        Dim Pagos As New FPagos
        Tabla = Pagos.MostrarPagosPorFecha(Desde, Hasta)
        Try
            If Tabla.Rows.Count <> 0 Then
                Grilla.DataSource = Tabla
                Grilla.ColumnHeadersVisible = True
                Return True
            Else
                Grilla.DataSource = Nothing
                Grilla.ColumnHeadersVisible = False
                Return False
            End If
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
            Return False
        End Try
    End Function

    Public Function MostrarDeudoresAlDia(Grilla As DataGridView, LblInexistente As LinkLabel)
        Dim Tabla As New DataTable
        Dim Socios As New FSocios
        Tabla = Socios.ConsultarDeudoresAlDia
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

    Public Function MostrarDeudoresPorFecha(Grilla As DataGridView, LblInexistente As LinkLabel, Dato As VSocios)
        Dim Tabla As New DataTable
        Dim Socios As New FSocios
        Tabla = Socios.ConsultarDeudoresPorFecha(Dato)
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

    Public Function SeleccionarDeudoresTotales(Grilla As DataGridView, LblInexistente As LinkLabel)
        Dim Tabla As New DataTable
        Dim Socios As New FSocios
        Tabla = Socios.SeleccionarDeudoresTotales
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

    Public Function GenerarInformeTodosLosDeudores(Grilla As DataGridView, LblInexistente As LinkLabel)
        Dim Tabla As New DataTable
        Dim Socios As New FSocios
        Tabla = Socios.GenerarInformeTodosLosDeudores
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
End Class
