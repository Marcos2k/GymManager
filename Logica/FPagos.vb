Imports System.Data.SqlClient
Public Class FPagos
    Inherits Conexion
    Dim Comando As New SqlCommand
    ''' <summary>
    ''' Registra el pago en la base de datos
    ''' </summary>
    ''' <param name="Dato"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function RegistrarPago(ByVal Dato As VPago) As Boolean
        Try
            Dim Consulta As String = "RegistrarPago"
            Conectar()
            Comando = New SqlCommand(Consulta)
            Comando.CommandType = CommandType.StoredProcedure
            Comando.Connection = Conector

            Comando.Parameters.AddWithValue("@ID_Socio", Dato.GID_Socio)
            Comando.Parameters.AddWithValue("@Fecha", Dato.GFecha)
            Comando.Parameters.AddWithValue("@Monto", Dato.GMonto)

            If Comando.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Return False
            MsgBox(ex.Message)
        Finally
            Desconectar()
        End Try
    End Function

    Public Function MostrarPagos()
        Try
            Dim Consulta As String = "MostrarPagos"
            Conectar()
            Comando = New SqlCommand(Consulta)
            Comando.CommandType = CommandType.StoredProcedure
            Comando.Connection = Conector

            If Comando.ExecuteNonQuery() Then
                Dim Tabla As New DataTable
                Dim Adaptador As New SqlDataAdapter(Comando)

                Adaptador.Fill(Tabla)
                Return Tabla
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox("Error " & ex.Message)
            Return Nothing
        Finally
            Desconectar()
        End Try
    End Function
    ''' <summary>
    ''' Obtenemos el ID del pago reciente para cargarlo al detalle
    ''' </summary>
    ''' <returns>Devuelve un dato tipo Integer</returns>
    ''' <remarks></remarks>
    Public Function ObtenerUltimoPago()
        Try
            Dim Consulta As String = "ObtenerUltimoPago"
            Conectar()
            Comando = New SqlCommand(Consulta)
            Comando.CommandType = CommandType.StoredProcedure
            Comando.Connection = Conector

            Dim ID As String
            ID = Comando.ExecuteScalar 'Obtenemos unicamente el primer registro
            Return ID
        Catch ex As Exception
            MsgBox("Error " & ex.Message)
            Return Nothing
        Finally
            Desconectar()
        End Try
    End Function

    Public Function GuardarDetalle(ByVal Dato As VPago)
        Try
            Dim Consulta As String = "GuardarDetalle"
            Conectar()
            Comando = New SqlCommand(Consulta)
            Comando.CommandType = CommandType.StoredProcedure
            Comando.Connection = Conector

            Comando.Parameters.AddWithValue("@ID_Pago", Dato.GID_Pago)
            Comando.Parameters.AddWithValue("@Concepto", Dato.GConcepto)

            If Comando.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Return False
            MsgBox(ex.Message)
        Finally
            Desconectar()
        End Try
    End Function
    ''' <summary>
    ''' Obtiene los pagos de un socio especifico
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function ObtenerPagoPorSocio(Dato As VSocios)
        Try
            Dim Consulta As String = "ObtenerPagoPorSocio"
            Conectar()
            Comando = New SqlCommand(Consulta)
            Comando.CommandType = CommandType.StoredProcedure
            Comando.Connection = Conector

            Comando.Parameters.AddWithValue("@ID_Socio", Dato.GID)
            If Comando.ExecuteNonQuery() Then
                Dim Tabla As New DataTable
                Dim Adaptador As New SqlDataAdapter(Comando)

                Adaptador.Fill(Tabla)
                Return Tabla
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox("Error " & ex.Message)
            Return Nothing
        End Try
    End Function
    ''' <summary>
    ''' Muestra los pagos realizados tomando 2 fechas, una desde y otra hasta
    ''' </summary>
    ''' <param name="Desde"></param>
    ''' <param name="Hasta"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function MostrarPagosPorFecha(Desde As Date, Hasta As Date)
        Try
            Dim Consulta As String = "MostrarPagoPorFechas"
            Conectar()
            Comando = New SqlCommand(Consulta)
            Comando.CommandType = CommandType.StoredProcedure
            Comando.Connection = Conector

            Comando.Parameters.AddWithValue("@Desde", Desde)
            Comando.Parameters.AddWithValue("@Hasta", Hasta)
            If Comando.ExecuteNonQuery() Then
                Dim Tabla As New DataTable
                Dim Adaptador As New SqlDataAdapter(Comando)

                Adaptador.Fill(Tabla)
                Return Tabla
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox("Error " & ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function ActualizarDeuda(ByVal Dato As VSocios) As Boolean
        Try
            Dim Consulta As String = "ActualizarDeuda"
            Conectar()
            Comando = New SqlCommand(Consulta)
            Comando.CommandType = CommandType.StoredProcedure
            Comando.Connection = Conector

            Comando.Parameters.AddWithValue("@ID", Dato.GID)

            If Comando.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Return False
            MsgBox(ex.Message)
        Finally
            Desconectar()
        End Try
    End Function
End Class
