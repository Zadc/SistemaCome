Public Class vFacturas
    Public idfactura
    Public numerofactura
    Public fechafactura
    Public idusuario


    Public Property gidfactura
        Get
            Return idfactura
        End Get
        Set(value)
            idfactura = value
        End Set
    End Property

    Public Property gnumerofactura
        Get
            Return numerofactura
        End Get
        Set(value)
            numerofactura = value
        End Set
    End Property

    Public Property gfechafactura
        Get
            Return fechafactura
        End Get
        Set(value)
            fechafactura = value
        End Set
    End Property

    Public Property gidusuario
        Get
            Return idusuario
        End Get
        Set(value)
            idusuario = value
        End Set
    End Property

    Public Sub New()

    End Sub
    Public Sub New(ByVal idfactura As Integer, ByVal numerofactura As Integer, ByVal fechafactura As Integer,
                   ByVal idusuraio As Integer)
        gidfactura = idusuario
        gnumerofactura = numerofactura
        gfechafactura = fechafactura
        gidusuario = idusuario


    End Sub
End Class

