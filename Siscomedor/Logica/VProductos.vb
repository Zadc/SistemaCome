Public Class VProductos
    Public idProducto As Integer
    Public codigoproducto As String
    Public descripcionproducto As String
    Public idproveedor As Integer
    Public precioproducto As Double
    Public stock As Integer
    Public estadoptroducto As Integer
    Public fechacrea As Date
    Public fechamod As Date

    'setter y getters
    Public Property gidProducto
        Get
            Return idProducto

        End Get
        Set(value)
            idProducto = value
        End Set

    End Property
    Public Property gcodigoproducto
        Get
            Return codigoproducto

        End Get
        Set(value)
            codigoproducto = value
        End Set

    End Property

    Public Property gdescripcionproducto
        Get
            Return descripcionproducto

        End Get
        Set(value)
            descripcionproducto = value
        End Set

    End Property
    Public Property gidproveedor
        Get
            Return idproveedor

        End Get
        Set(value)
            idproveedor = value
        End Set

    End Property

    Public Property gprecioproducto
        Get
            Return precioproducto
        End Get
        Set(value)
            precioproducto = value
        End Set

    End Property
    Public Property gstock
        Get
            Return stock
        End Get
        Set(value)
            stock = value
        End Set

    End Property

    Public Property gestadoptroducto
        Get
            Return estadoptroducto

        End Get
        Set(value)
            estadoptroducto = value
        End Set

    End Property

    Public Property gfechacrea
        Get
            Return fechacrea

        End Get
        Set(value)
            fechacrea = value
        End Set

    End Property

    Public Property gfechamod
        Get
            Return fechamod

        End Get
        Set(value)
            fechamod = value
        End Set

    End Property


    Public Sub New()

    End Sub

    Public Sub New(ByVal idProducto As Integer, ByVal codigoproducto As String, ByVal descripcionproducto As String,
                   ByVal ideproveedor As Integer, ByVal precioproducto As Double, ByVal stock As Integer, ByVal estadoproducto As Integer,
                   ByVal fechacrea As Date, ByVal fechamod As Date)
        gidProducto = idProducto
        gcodigoproducto = codigoproducto
        gdescripcionproducto = descripcionproducto
        gidproveedor = idproveedor
        gprecioproducto = precioproducto
        gstock = stock
        gestadoptroducto = estadoproducto
        gfechacrea = fechacrea
        gfechamod = fechamod

    End Sub

End Class
