Imports System.Data.SqlClient
Public Class FAsistencias
    Inherits Conexion 'heradamos la clase conexion
    Dim Comando As New SqlCommand

    Public Function RegistrarAsistencia(ID As Integer, Fecha As Date, Hora As String)
        Try
            Dim Consulta As String = "RegistrarAsistencias"
            Conectar()
            Comando = New SqlCommand(Consulta)
            Comando.CommandType = CommandType.StoredProcedure
            Comando.Connection = Conector

            Comando.Parameters.AddWithValue("ID_Socio", ID)
            Comando.Parameters.AddWithValue("Fecha", Fecha)
            Comando.Parameters.AddWithValue("Hora", Hora)
            If Comando.ExecuteNonQuery() Then
                Return True
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox("Error " & ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function VerAsistencias()
        Try
            Dim Consulta As String = "VerAsistencias"
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
        End Try
    End Function

    Public Function VerAsistenciaPorSocio(ID_Socio As Integer)
        Try
            Dim Consulta As String = "VerAsistenciaPorSocio"
            Conectar()
            Comando = New SqlCommand(Consulta)
            Comando.CommandType = CommandType.StoredProcedure
            Comando.Connection = Conector

            Comando.Parameters.AddWithValue("@ID_Socio", ID_Socio)
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

    Public Function MostrarAsistenciasPorFecha(Desde As Date, Hasta As Date)
        Try
            Dim Consulta As String = "MostrarAsistenciasPorFecha"
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
End Class
