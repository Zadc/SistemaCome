Public Class VLoginComedor
    'Dim usuariologingcomedor, usuriocodigo As String
    Dim usuriocodigo As String

    'Public Property gusuariologincomedor
    '    Get
    '        Return usuariologingcomedor
    '    End Get
    '    Set(value)
    '        usuariologingcomedor = value
    '    End Set
    'End Property

    Public Property gusuariocodigo
        Get
            Return usuriocodigo
        End Get
        Set(value)
            usuriocodigo = value
        End Set
    End Property
    Public Sub New()

    End Sub
    Public Sub New(ByVal usuariologincomedor As String, ByVal usuariocodigo As String)
        'Public Sub New(ByVal usuariologincomedor As String, ByVal passwordcomedor As String)

        'gusuariologincomedor = usuariologincomedor
        gusuariocodigo = usuariocodigo
    End Sub

End Class

