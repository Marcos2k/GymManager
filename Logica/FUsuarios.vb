Imports System.Data.SqlClient
Public Class FUsuarios
    Inherits Conexion
    Dim Comando As New SqlCommand
    ''' <summary>
    ''' Registra un usuario en la base de datos
    ''' </summary>
    ''' <param name="Dato"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function RegistrarUsuario(Dato As VUsuarios)
        Try
            Dim Consulta As String = "AgregarUsuario"
            Conectar()
            Comando = New SqlCommand(Consulta)
            Comando.CommandType = CommandType.StoredProcedure
            Comando.Connection = Conector

            Comando.Parameters.AddWithValue("@Usuario", Dato.GNombre)
            Comando.Parameters.AddWithValue("@Contraseña", Dato.GContraseña)
            Comando.Parameters.AddWithValue("@Acceso", Dato.GAcceso)
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

    Public Function ModificarUsuario(Dato As VUsuarios)
        Try
            Dim Consulta As String = "ModificarUsuarios"
            Conectar()
            Comando = New SqlCommand(Consulta)
            Comando.CommandType = CommandType.StoredProcedure
            Comando.Connection = Conector


            Comando.Parameters.AddWithValue("@Contraseña", Dato.GContraseña)
            Comando.Parameters.AddWithValue("@Acceso", Dato.GAcceso)
            Comando.Parameters.AddWithValue("@ID", Dato.GID_Usuario)

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

    Public Function ComprobarUsuario(Dato As VUsuarios)
        Try
            Dim Consulta As String = "BuscarUsuario"
            Conectar()
            Comando = New SqlCommand(Consulta)
            Comando.CommandType = CommandType.StoredProcedure
            Comando.Connection = Conector


            Comando.Parameters.AddWithValue("@Nombre", Dato.GNombre)

            Dim UsuarioExistente As String = Comando.ExecuteScalar() 'Busca y devuelve el primer valor de la consulta

            If UsuarioExistente = Dato.GNombre Then 'pregunta si son iguales, si se cumple avisa que ya existe
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            MsgBox("Error " & ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function ComprobarContraseña(Dato As String)
        Try
            Dim Consulta As String = "ComprobarClave"
            Conectar()
            Comando = New SqlCommand(Consulta)
            Comando.CommandType = CommandType.StoredProcedure
            Comando.Connection = Conector

            Comando.Parameters.AddWithValue("@Contraseña", Dato)

            Dim ContraseñaExistente As String = Comando.ExecuteScalar() 'Busca y devuelve el primer valor de la consulta

            If ContraseñaExistente = Dato Then 'pregunta si son iguales, si se cumple avisa que ya existe
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox("Error " & ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function BuscarIdUsuario(Dato As VUsuarios)
        Try
            Dim Consulta As String = "BuscarIdUsuario"
            Conectar()
            Comando = New SqlCommand(Consulta)
            Comando.CommandType = CommandType.StoredProcedure
            Comando.Connection = Conector

            Comando.Parameters.AddWithValue("@Usuario", Dato.GNombre)
            Comando.Parameters.AddWithValue("@Contraseña", Dato.GContraseña)

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
End Class