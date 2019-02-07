Public Class Datos
    Dim usuario As String
    Dim password As String
    Public Property idempleado()
        Get
            Return usuario
        End Get
        Set(ByVal value)
            usuario = value
        End Set
    End Property
    Public Property contraseña()
        Get
            Return password
        End Get
        Set(ByVal value)
            password = value
        End Set
    End Property
    Public Sub New(ByVal usuario As String, ByVal password As String)
        idempleado = usuario
        contraseña = password
    End Sub
    Public Sub New()
    End Sub
End Class