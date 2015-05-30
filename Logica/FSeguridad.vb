Imports System.Data.SqlClient
Public Class FSeguridad
    Inherits Conexion
    Dim Comando As New SqlCommand
    ''' <summary>
    ''' Metodo para encriptar una cadena de caracteres
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Encriptar(Dato As String)
        Try
            Dim Cadena As String
            Dim Posicion As Integer 'indice que va a realizar el recorrido
            Dim Encriptado As String = Nothing 'inicializamos la variable como nula
            'Algoritmo usando el bucle For
            For Posicion = 1 To Len(Dato)
                Cadena = Mid(Dato, Posicion, 1) 'ASC = Permite extraer el codigo ASCII de un caracter en forma numerica
                Cadena = Asc(Cadena) + 1 'Muestra el codigo encriptado, ChrW devuelve el Codigo ASCII convertido en letras
                Encriptado = Encriptado & ChrW(Cadena)
            Next

            Return Encriptado
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function
    ''' <summary>
    ''' Metodo para encriptar una cadena de caracteres
    ''' </summary>
    ''' <param name="Dato"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Descencriptar(Dato As String)
        Try
            Dim Cadena As String
            Dim Posicion As Integer
            Dim Descencriptado As String = Nothing

            For Posicion = 1 To Len(Dato)
                Cadena = Mid(Dato, Posicion, 1) 'ASC = Permite extraer el codigo ASCII de un caracter en forma numerica
                Cadena = Asc(Cadena) - 1 'Muestra el codigo encriptado, ChrW devuelve el Codigo ASCII convertido en letras
                Descencriptado = Descencriptado & ChrW(Cadena)
            Next

            Return Descencriptado
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Public Function Login(Dato As VUsuarios)
        Conectar()
        Comando = New SqlCommand("Validar_usuarios")
        Comando.CommandType = CommandType.StoredProcedure
        Comando.Connection = Conector

        Comando.Parameters.AddWithValue("@Usuario", Dato.GNombre)
        Comando.Parameters.AddWithValue("@Contraseña", Dato.GContraseña)
        Comando.Parameters.AddWithValue("@Acceso", Dato.GAcceso)

        Dim DR As SqlDataReader

        Try
            DR = Comando.ExecuteReader

            If DR.HasRows Then
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

    Public Sub RestringirPermisos()
        FrmMenu.MantenimientoToolStripMenuItem.Visible = False
        FrmMenu.InformesToolStripMenuItem.Visible = False
    End Sub

    Public Function SalirDelSistema()
        Return True
    End Function
End Class
