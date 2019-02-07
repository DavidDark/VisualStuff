Public Class Datos
    Dim cliente As String
    Public Property idcliente()
        Get
            Return cliente
        End Get
        Set(ByVal value)
            cliente = value
        End Set
    End Property
    Public Sub New(ByVal usuario As String, ByVal password As String)
        idcliente = cliente
    End Sub
    Public Sub New()
    End Sub
End Class