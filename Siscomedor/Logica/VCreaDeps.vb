Public Class VCreaDeps
    Public idDepartamento As Integer
    Public codigoDepartamento As Integer
    Public descripcionDep As String
    Public idarea As Integer
    Public cuentaContable As String



    Public Property gidepartamento
        Get
            Return idDepartamento

        End Get
        Set(value)
            idDepartamento = value
        End Set

    End Property
    Public Property gcodigodepartamento
        Get
            Return codigoDepartamento

        End Get
        Set(value)
            codigoDepartamento = value
        End Set

    End Property
    Public Property gdescripcion
        Get
            Return descripcionDep

        End Get
        Set(value)
            descripcionDep = value
        End Set

    End Property

    Public Property gidarea
        Get
            Return idarea

        End Get
        Set(value)
            idarea = value
        End Set

    End Property


    Public Property gcuentacontable
        Get
            Return cuentaContable

        End Get
        Set(value)
            cuentaContable = value
        End Set

    End Property





    Public Sub New(ByVal idDepartamento As Integer, ByVal codigoDepartamento As Integer, ByVal descripcionDep As String, ByVal idarea As Integer,
                   ByVal cuentaContable As String)


        gidepartamento = idDepartamento
        gcodigodepartamento = codigoDepartamento
        gdescripcion = descripcionDep
        gidarea = idarea
        gcuentacontable = cuentaContable





    End Sub

    Public Sub New()


    End Sub

End Class
