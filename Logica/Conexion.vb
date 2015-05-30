Imports System.Data.SqlClient
Public Class Conexion
    Protected Conector As New SqlConnection
    Dim Cadena As String = "Data Source=(local);Initial Catalog=Gimnasio;Integrated Security=True"
    ''' <summary>
    ''' Se conecta a una base de datos en SQL Server
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Protected Function Conectar()
        Try
            Conector = New SqlConnection(Cadena)
            Conector.Open()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function
    ''' <summary>
    ''' Se desconecta de la base de datos
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Protected Function Desconectar()
        Try
            If Conector.State = ConnectionState.Open Then
                Conector.Close()
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return True
        End Try
    End Function
End Class
