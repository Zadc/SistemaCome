Public Class VCausas
    Public idCausa As Integer
    Public Descripcion As String

    'setter y getters
    Public Property gid_Causa
        Get
            Return idCausa

        End Get
        Set(value)
            idCausa = value
        End Set

    End Property
    Public Property getDescripcion
        Get
            Return Descripcion

        End Get
        Set(value)
            Descripcion = value
        End Set

    End Property
    Public Sub New()

    End Sub

    Public Sub New(ByVal idCausa As Integer, ByVal Descripcion As String)
        gid_Causa = idCausa
        getDescripcion = Descripcion

    End Sub
End Class
