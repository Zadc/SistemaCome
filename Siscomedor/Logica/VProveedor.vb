Public Class VProveedor
    Public IdProveedor As Integer
    Public ProveedorDescripcion As String
    Public ProveedorRTN As String
    Public ProveedorCorreo As String
    Public ProveedorTelefono As String
    Public ProveedorDireccion As String
    Public ProveedorFechaIngreso As Date
    Public ProveedorFechaModificacion As Date

    Public Property gIDPROVEEDOR
        Get
            Return IdProveedor
        End Get
        Set(value)
            IdProveedor = value
        End Set
    End Property
    Public Property gDeescripcion
        Get
            Return ProveedorDescripcion
        End Get
        Set(value)
            ProveedorDescripcion = value
        End Set
    End Property
    Public Property gRTN
        Get
            Return ProveedorRTN
        End Get
        Set(value)
            ProveedorRTN = value
        End Set
    End Property
    Public Property gCorreo
        Get
            Return ProveedorCorreo
        End Get
        Set(value)
            ProveedorCorreo = value
        End Set
    End Property
    Public Property gTelefono
        Get
            Return ProveedorTelefono
        End Get
        Set(value)
            ProveedorTelefono = value
        End Set
    End Property
    Public Property gDireccion
        Get
            Return ProveedorDireccion
        End Get
        Set(value)
            ProveedorDireccion = value
        End Set
    End Property
    Public Property gFechaIngreso
        Get
            Return ProveedorFechaIngreso
        End Get
        Set(value)
            ProveedorFechaIngreso = value
        End Set
    End Property
    Public Property gFechaModificacion
        Get
            Return ProveedorFechaModificacion
        End Get
        Set(value)
            ProveedorFechaModificacion = value
        End Set
    End Property
    Public Sub New()

    End Sub
    Public Sub New(ByVal idProveedor As Integer, ByVal ProveedorDescripcion As String, ByVal ProveedorRTN As String,
                   ByVal ProveedorCorreo As String, ByVal ProveedorTelefono As String, ByVal ProveedorDireccion As String,
                   ByVal ProveedorFechaIngreso As Date, ByVal ProveedorFechaModificacion As Date)
        gIDPROVEEDOR = idProveedor
        gDeescripcion = ProveedorDescripcion
        gRTN = ProveedorRTN
        gCorreo = ProveedorCorreo
        gTelefono = ProveedorTelefono
        gDireccion = ProveedorDireccion
        gFechaIngreso = ProveedorFechaIngreso
        gFechaModificacion = ProveedorFechaModificacion

    End Sub
End Class
