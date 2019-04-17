Public Class vOrden
    Public idOrden As Integer
    Public idusuariocrea As Integer
    Public idUsuarioasigna As Integer
    Public idcomida As Integer
    Public idcomplemento As Integer
    Public fechacreacionticket As Date
    Public fechaasignada As Date
    Public idestadoticket As Integer
    Public fechausoticket As Date
    Public Numeroticketmasivo As String
    'setter y getters
    Public Property gid_Orden
        Get
            Return idOrden

        End Get
        Set(value)
            idOrden = value
        End Set

    End Property
    Public Property gOidusuariocrea
        Get
            Return idusuariocrea

        End Get
        Set(value)
            idusuariocrea = value
        End Set

    End Property
    Public Property gOidusuarioasigna
        Get
            Return idUsuarioasigna

        End Get
        Set(value)
            idUsuarioasigna = value
        End Set

    End Property
    Public Property gidcomida
        Get
            Return idcomida

        End Get
        Set(value)
            idcomida = value
        End Set
    End Property
    Public Property gidComplemento
        Get
            Return idcomplemento

        End Get
        Set(value)
            idcomplemento = value
        End Set
    End Property
    Public Property gfechacreacionticket
        Get
            Return fechacreacionticket

        End Get
        Set(value)
            fechacreacionticket = value
        End Set
    End Property
    Public Property gFechaasignada
        Get
            Return fechaasignada
        End Get
        Set(value)
            fechaasignada = value
        End Set
    End Property
    Public Property gidestadoticket
        Get
            Return idestadoticket
        End Get
        Set(value)
            idestadoticket = value
        End Set
    End Property
    Public Property gFechauso
        Get
            Return fechausoticket
        End Get
        Set(value)
            fechausoticket = value
        End Set
    End Property
    Public Property gNumeroticketMasivo
        Get
            Return Numeroticketmasivo
        End Get
        Set(value)
            Numeroticketmasivo = value
        End Set
    End Property
    Public Sub New()

    End Sub

    Public Sub New(ByVal idOrden As Integer, ByVal idusuariocrea As Integer, ByVal idusuarioasigna As Integer, ByVal idcomida As Integer,
                   ByVal idcomplemento As Integer, ByVal fechacreacionticket As Date, ByValfechaasignada As Date, ByVal idestadoticket As Integer,
                  ByVal fechausoticket As Date, ByVal Numeroticketmasivo As String)
        gid_Orden = idOrden
        gOidusuariocrea = idusuariocrea
        gOidusuarioasigna = idusuarioasigna
        gidcomida = idcomida
        gidComplemento = idcomplemento
        gfechacreacionticket = fechacreacionticket
        gFechaasignada = gFechaasignada
        gidestadoticket = idestadoticket
        gFechauso = fechausoticket
        gNumeroticketMasivo = Numeroticketmasivo
    End Sub

End Class
