Imports System.Data.SqlClient
Public Class FSocios
    Inherits Conexion 'heradamos la clase conexion
    Dim Comando As New SqlCommand


    Public Function ObtenerEstado(CBEstado As ComboBox)

        Try
            Dim Consulta As String = "ObtenerEstados"
            Conectar()
            Comando = New SqlCommand(Consulta)
            Comando.CommandType = CommandType.StoredProcedure
            Comando.Connection = Conector

            If Comando.ExecuteNonQuery Then
                Dim Tabla As New DataTable
                Dim Adaptador As New SqlDataAdapter(Comando)

                Adaptador.Fill(Tabla)

                CBEstado.DisplayMember = "Estado"
                CBEstado.ValueMember = "ID_Estado"
                CBEstado.DataSource = Tabla
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
            Return False
        Finally
            Desconectar()
        End Try
    End Function

    Public Function ObtenerCategorias(CBCategoria As ComboBox)
        Try
            Dim Consulta As String = "ObtenerCategorias"
            Conectar()
            Comando = New SqlCommand(Consulta)
            Comando.CommandType = CommandType.StoredProcedure
            Comando.Connection = Conector

            If Comando.ExecuteNonQuery Then
                Dim Tabla As New DataTable
                Dim Adaptador As New SqlDataAdapter(Comando)

                Adaptador.Fill(Tabla)

                CBCategoria.DisplayMember = "Categoria"
                CBCategoria.ValueMember = "ID_Categoria"
                CBCategoria.DataSource = Tabla
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
            Return False
        Finally
            Desconectar()
        End Try
    End Function
    ''' <summary>
    ''' Llena la grilla con los soccios
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function MostrarSocios()
        Try
            Dim Consulta As String = "MostrarSocios"
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

    Public Function RegistrarSocio(Dato As VSocios)
        Try
            Dim Consulta As String = "RegistrarSocio"
            Conectar()
            Comando = New SqlCommand(Consulta)
            Comando.CommandType = CommandType.StoredProcedure
            Comando.Connection = Conector

            Comando.Parameters.AddWithValue("@Nombre", Dato.GNombre)
            Comando.Parameters.AddWithValue("@Apellido", Dato.GApellido)
            Comando.Parameters.AddWithValue("@Direccion", Dato.GDireccion)
            Comando.Parameters.AddWithValue("@Dni", Dato.GDni)
            Comando.Parameters.AddWithValue("@Edad", Dato.GEdad)
            Comando.Parameters.AddWithValue("@Telefono", Dato.GTelefono)
            Comando.Parameters.AddWithValue("@Observaciones", Dato.GObservaciones)
            Comando.Parameters.AddWithValue("@Categoria", Dato.GCategoria)
            Comando.Parameters.AddWithValue("@Estado", Dato.GEstado)
            Comando.Parameters.AddWithValue("@Vencimiento", Dato.GVencimiento)
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

    Public Function ModificarSocio(Dato As VSocios)
        Try
            Dim Consulta As String = "ModificarSocio"
            Conectar()
            Comando = New SqlCommand(Consulta)
            Comando.CommandType = CommandType.StoredProcedure
            Comando.Connection = Conector

            Comando.Parameters.AddWithValue("@ID", Dato.GID)
            Comando.Parameters.AddWithValue("@Nombre", Dato.GNombre)
            Comando.Parameters.AddWithValue("@Apellido", Dato.GApellido)
            Comando.Parameters.AddWithValue("@Direccion", Dato.GDireccion)
            Comando.Parameters.AddWithValue("@Dni", Dato.GDni)
            Comando.Parameters.AddWithValue("@Edad", Dato.GEdad)
            Comando.Parameters.AddWithValue("@Telefono", Dato.GTelefono)
            Comando.Parameters.AddWithValue("@Observaciones", Dato.GObservaciones)
            Comando.Parameters.AddWithValue("@Categoria", Dato.GCategoria)
            Comando.Parameters.AddWithValue("@Estado", Dato.GEstado)
            Comando.Parameters.AddWithValue("@Vencimiento", Dato.GVencimiento)
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

    Public Function ConsultarDeudoresAlDia()
        Try
            Dim Consulta As String = "MostrarDeudoresAlDia"
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
    ''' <summary>
    ''' Consulta los deudores usando el numero de dia como filtro 
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function ConsultarDeudoresPorFecha(Dato As VSocios)
        Try
            Dim Consulta As String = "ConsultarDeudoresPorFecha"
            Conectar()
            Comando = New SqlCommand(Consulta)
            Comando.CommandType = CommandType.StoredProcedure
            Comando.Connection = Conector

            Comando.Parameters.AddWithValue("@Vencimiento", Dato.GVencimiento)
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

    Public Function ActulizarDeudores()
        Try
            Dim Consulta As String = "ActualizarDeudores"
            Conectar()
            Comando = New SqlCommand(Consulta)
            Comando.CommandType = CommandType.StoredProcedure
            Comando.Connection = Conector

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
    ''' <summary>
    ''' Incrementa la cantidad de cuotas que debe un cliente de 1 en 1
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function IncrementarCantidadCuota()
        Try
            Dim Consulta As String = "IncrementarCantidadCuota"
            Conectar()
            Comando = New SqlCommand(Consulta)
            Comando.CommandType = CommandType.StoredProcedure
            Comando.Connection = Conector

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
    ''' <summary>
    ''' Muestra todos los deudores totales
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function SeleccionarDeudoresTotales() As DataTable
        Try
            Dim Consulta As String = "SeleccionarDeudoresTotales"
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


    Public Function GenerarInformeTodosLosDeudores() As DataTable
        Try
            Dim Consulta As String = "GenerarInformeTodosLosDeudores"
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
End Class
