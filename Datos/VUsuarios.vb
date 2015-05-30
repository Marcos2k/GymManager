Public Class VUsuarios
    Dim ID_Usuario As Integer
    Dim Nombre As String
    Dim Contraseña As String
    Dim Acceso As Integer

    Public Property GID_Usuario
        Get
            Return ID_Usuario
        End Get
        Set(value)
            ID_Usuario = value
        End Set
    End Property

    Public Property GNombre
        Get
            Return Nombre
        End Get
        Set(value)
            Nombre = value
        End Set
    End Property

    Public Property GContraseña
        Get
            Return Contraseña
        End Get
        Set(value)
            Contraseña = value
        End Set
    End Property

    Public Property GAcceso
        Get
            Return Acceso
        End Get
        Set(value)
            Acceso = value
        End Set
    End Property
End Class
