Public Class VPago

    Dim ID_Pago As Integer
    Dim ID_Socio As Integer
    Dim Fecha As Date
    Dim Monto As Decimal

    Dim Concepto As String

    Public Property GID_Pago
        Get
            Return ID_Pago
        End Get
        Set(value)
            ID_Pago = value
        End Set
    End Property

    Public Property GID_Socio
        Get
            Return ID_Socio
        End Get
        Set(value)
            ID_Socio = value
        End Set
    End Property

    Public Property GFecha
        Get
            Return Fecha
        End Get
        Set(value)
            Fecha = value
        End Set
    End Property

    Public Property GMonto
        Get
            Return Monto
        End Get
        Set(value)
            Monto = value
        End Set
    End Property

    Public Property GConcepto
        Get
            Return Concepto
        End Get
        Set(value)
            Concepto = value
        End Set
    End Property
    Public Sub New(ByVal ID_Pago, ID_Socio, Fecha, Monto, Concepto)
        ID_Pago = GID_Pago
        ID_Socio = GID_Socio
        Fecha = GFecha
        Monto = GMonto
        Concepto = GConcepto
    End Sub

    Public Sub New()
        'dejamos contructor en blanco
    End Sub
End Class
