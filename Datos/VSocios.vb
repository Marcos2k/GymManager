Public Class VSocios
    Private ID As Integer
    Private Nombre As String
    Private Apellido As String
    Private Direccion As String
    Private Dni As String
    Private Edad As Integer
    Private Telefono As String
    Private Observaciones As String
    Private Categoria As Integer
    Private Estado As Integer
    Private Vencimiento As Integer

    Public Property GID
        Get
            Return ID
        End Get
        Set(value)
            ID = value
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

    Public Property GApellido
        Get
            Return Apellido
        End Get
        Set(value)
            Apellido = value
        End Set
    End Property

    Public Property GDireccion
        Get
            Return Direccion
        End Get
        Set(value)
            Direccion = value
        End Set
    End Property

    Public Property GDni
        Get
            Return Dni
        End Get
        Set(value)
            Dni = value
        End Set
    End Property

    Public Property GEdad
        Get
            Return Edad
        End Get
        Set(value)
            Edad = value
        End Set
    End Property

    Public Property GTelefono
        Get
            Return Telefono
        End Get
        Set(value)
            Telefono = value
        End Set
    End Property

    Public Property GObservaciones
        Get
            Return Observaciones
        End Get
        Set(value)
            Observaciones = value
        End Set
    End Property

    Public Property GCategoria
        Get
            Return Categoria
        End Get
        Set(value)
            Categoria = value
        End Set
    End Property

    Public Property GEstado
        Get
            Return Estado
        End Get
        Set(value)
            Estado = value
        End Set
    End Property

    Public Property GVencimiento
        Get
            Return Vencimiento
        End Get
        Set(value)
            Vencimiento = value
        End Set
    End Property
    Public Sub New(ID As Integer, Nombre As String, Apellido As String, Direccion As String, Dni As String, Edad As Integer, Telefono As String, Observaciones As String, Categoria As Integer, Estado As Integer, Vencimiento As Integer)
        ID = GID
        Nombre = GNombre
        Apellido = GApellido
        Direccion = GDireccion
        Dni = GDni
        Edad = GEdad
        Telefono = GTelefono
        Observaciones = GObservaciones
        Categoria = GCategoria
        Estado = GEstado
        Vencimiento = GVencimiento
    End Sub

    Public Sub New()
        'Constructor en blanco
    End Sub
End Class
