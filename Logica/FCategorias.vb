Imports System.Data.SqlClient
Public Class FCategorias
    Inherits Conexion
    Dim Comando As New SqlCommand

    Public Function MostrarCategoria()
        Try
            Dim Consulta As String = "MostrarCategorias"
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

    Public Function InsertarCategoria(Nombre As String)
        Try
            Dim Consulta As String = "InsertarCategoria"
            Conectar()
            Comando = New SqlCommand(Consulta)
            Comando.CommandType = CommandType.StoredProcedure
            Comando.Connection = Conector

            Comando.Parameters.AddWithValue("@Categoria", Nombre)
            If Comando.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            Desconectar()
        End Try
    End Function
End Class
