
Public Class vCocina
    Dim tiempo, nombreu, apellidou, descripcioncomplemento As String

    Public Property gtiempo
        Get
            Return tiempo
        End Get
        Set(value)
            tiempo = value
        End Set
    End Property

    Public Property gnombreu
        Get
            Return nombreu
        End Get
        Set(value)
            nombreu = value
        End Set
    End Property

    Public Property gapellidou
        Get
            Return apellidou
        End Get
        Set(value)
            apellidou = value
        End Set
    End Property

    Public Property gdescripcioncomplemento
        Get
            Return descripcioncomplemento
        End Get
        Set(value)
            descripcioncomplemento = value
        End Set
    End Property
    Public Sub New()

    End Sub
    Public Sub New(ByVal tiempo As String, ByVal nombreu As String, ByVal apellidou As String,
                   ByVal descripcioncomplemento As String)
        gtiempo = tiempo
        gnombreu = nombreu
        gapellidou = apellidou
        gdescripcioncomplemento = gdescripcioncomplemento
    End Sub
End Class

