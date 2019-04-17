Public Class VticketMasivo
    Public idusuario As Integer
    Public NumeroTicketMAsivo As String
    Public Diasagenerar As Integer
    'setter y getters
    Public Property gid_Usuario
        Get
            Return idusuario

        End Get
        Set(value)
            idusuario = value
        End Set

    End Property
    Public Property getNumeroticketMasivo
        Get
            Return NumeroTicketMAsivo

        End Get
        Set(value)
            NumeroTicketMAsivo = value
        End Set

    End Property
    Public Property getdiasagenerar
        Get
            Return Diasagenerar

        End Get
        Set(value)
            Diasagenerar = value
        End Set

    End Property
    Public Sub New()

    End Sub

    Public Sub New(ByVal idusuario As Integer, ByVal NumeroTicketMAsivo As String, ByVal Diasagenerar As Integer)
        gid_Usuario = idusuario
        getNumeroticketMasivo = NumeroTicketMAsivo
        getdiasagenerar = Diasagenerar
    End Sub
End Class
