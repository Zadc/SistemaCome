
Public Class vLogin
    Dim usuariologin, password As String

    Public Property gusuariologin
        Get
            Return usuariologin
        End Get
        Set(value)
            usuariologin = value
        End Set
    End Property

    Public Property gpassword
        Get
            Return password
        End Get
        Set(value)
            password = value
        End Set
    End Property


    Public Sub New()

    End Sub
    Public Sub New(ByVal usuariologin As String, ByVal password As String)
        gusuariologin = usuariologin
        gpassword = password
    End Sub
End Class
