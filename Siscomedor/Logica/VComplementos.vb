Public Class VComplementos
    Public vidcomplemento As Integer
    Public vdesccomplemento As String
    Public vcomplementofechacrea As Date
    Public vcomplementofechamod As Date
    Public vcomplementoestado As Integer
    Public vcomplemetoestock As Integer

    Public Property gvidcomplemento
        Get
            Return vidcomplemento

        End Get
        Set(value)
            vidcomplemento = value
        End Set

    End Property
    Public Property gvdesccomplemento
        Get
            Return vdesccomplemento

        End Get
        Set(value)
            vdesccomplemento = value
        End Set

    End Property
    Public Property gvcomplementofechacrea
        Get
            Return vcomplementofechacrea

        End Get
        Set(value)
            vcomplementofechacrea = value
        End Set

    End Property
    Public Property gvcomplementofechamod
        Get
            Return vcomplementofechamod

        End Get
        Set(value)
            vcomplementofechamod = value
        End Set

    End Property
    Public Property gvcomplementoestado
        Get
            Return vcomplementoestado

        End Get
        Set(value)
            vcomplementoestado = value
        End Set

    End Property
    Public Property gvcomplemetoestock
        Get
            Return vcomplemetoestock

        End Get
        Set(value)
            vcomplemetoestock = value
        End Set

    End Property


    Public Sub New()

    End Sub

    Public Sub New(ByVal vidcomplemento As Integer, ByVal cvdesccomplemento As String, ByVal vcomplementofechacrea As Date,
                   ByVal vcomplementofechamod As Date, ByVal vcomplementoestado As Integer, ByVal vcomplemetoestock As Integer)

        gvidcomplemento = vidcomplemento
        gvdesccomplemento = vdesccomplemento
        gvcomplementofechacrea = vcomplementofechacrea
        gvcomplementofechamod = vcomplementofechamod
        gvcomplementoestado = vcomplementoestado
        gvcomplemetoestock = vcomplemetoestock
    End Sub
End Class
