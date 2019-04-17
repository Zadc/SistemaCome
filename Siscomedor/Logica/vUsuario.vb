Public Class vUsuario
    Public idusuario As Integer
    Public codigo_usuario As Integer
    Public nombre As String
    Public apellido As String
    Public usuarionick As String
    Public password As String
    Public tipousuario As String
    'variables permisos
    Public permiso_agregar As Integer
    Public permiso_modificar As Integer
    Public permiso_eliminar As Integer
    Public permiso_admin As Integer
    Public permiso_crealista As Integer
    Public permiso_cocina As Integer
    Public permiso_digitador As Integer
    Public permiso_transportista As Integer
    Public iddepartamento As Integer
    Public estado As Integer

    Public fecha_creacion As Date
    Public fecha_modificacion As Date
    Public fecha_contrato As Date
    Public IDturno As Integer
    Public PermisoSuperintendente As Integer
    Public validaPeticion As Integer
    Public NumeroGrupo As Integer

    'setter y getters
    'usuario
    Public Property gidusuario

        Get
            Return idusuario

        End Get
        Set(value)
            idusuario = value
        End Set

    End Property

    'codigo_empleado
    Public Property gcodigousuario

        Get
            Return codigo_usuario

        End Get
        Set(value)
            codigo_usuario = value
        End Set

    End Property

    'nombre
    Public Property gnombre
        Get
            Return nombre
        End Get
        Set(value)
            nombre = value
        End Set
    End Property

    'apellido
    Public Property gapellido
        Get
            Return apellido
        End Get
        Set(value)
            apellido = value
        End Set
    End Property
    'Usuarionick
    Public Property gusuarionick

        Get
            Return usuarionick

        End Get
        Set(value)
            usuarionick = value
        End Set

    End Property


    'password'
    Public Property gpassword

        Get
            Return password

        End Get
        Set(value)
            password = value
        End Set
    End Property
    'tipo usuario
    Public Property gtipousuario

        Get
            Return tipousuario

        End Get
        Set(value)
            tipousuario = value
        End Set
    End Property

    'permiso_agregar
    Public Property gpermisoagregar

        Get
            Return permiso_agregar

        End Get
        Set(value)
            permiso_agregar = value
        End Set
    End Property

    'permiso_modificar
    Public Property gpermisomodificar

        Get
            Return permiso_modificar

        End Get
        Set(value)
            permiso_modificar = value
        End Set
    End Property

    'permiso_eliminar
    Public Property gpermisoeliminar

        Get
            Return permiso_eliminar

        End Get
        Set(value)
            permiso_eliminar = value
        End Set
    End Property

    'permiso_admin
    Public Property gpermisoadmin

        Get
            Return permiso_admin

        End Get
        Set(value)
            permiso_admin = value
        End Set
    End Property

    'permiso_secretaria
    Public Property gpermisocrealista

        Get
            Return permiso_crealista

        End Get
        Set(value)
            permiso_crealista = value
        End Set
    End Property

    'permiso_cocina
    Public Property gpermisococina

        Get
            Return permiso_cocina

        End Get
        Set(value)
            permiso_cocina = value
        End Set
    End Property

    'permiso_digitador
    Public Property gpermisodigitador

        Get
            Return permiso_digitador

        End Get
        Set(value)
            permiso_digitador = value
        End Set
    End Property

    'permiso_transportista
    Public Property gpermisotransportista

        Get
            Return permiso_transportista

        End Get
        Set(value)
            permiso_transportista = value
        End Set
    End Property

    'iddepartamento 
    Public Property giddepartamento

        Get
            Return iddepartamento

        End Get
        Set(value)
            iddepartamento = value
        End Set
    End Property
    'estado
    Public Property gestado

        Get
            Return estado

        End Get
        Set(value)
            estado = value
        End Set
    End Property

    'fecha_creacion
    Public Property gfechacreacion

        Get
            Return fecha_creacion

        End Get
        Set(value)
            fecha_creacion = value
        End Set
    End Property

    'fecha_modificacion
    Public Property gfechamodificacion

        Get
            Return fecha_modificacion

        End Get
        Set(value)
            fecha_modificacion = value
        End Set
    End Property

    'fecha_contratacion
    Public Property gfechacontrato

        Get
            Return fecha_contrato

        End Get
        Set(value)
            fecha_contrato = value
        End Set
    End Property
    Public Property gidturno
        Get
            Return IDturno
        End Get
        Set(value)
            IDturno = value
        End Set
    End Property
    Public Property gPermisoSuperintendente
        Get
            Return PermisoSuperintendente
        End Get
        Set(value)
            PermisoSuperintendente = value
        End Set
    End Property
    Public Property gValidaPeticion
        Get
            Return validaPeticion
        End Get
        Set(value)
            validaPeticion = value
        End Set
    End Property
    Public Property gNumeroGrupo
        Get
            Return NumeroGrupo
        End Get
        Set(value)
            NumeroGrupo = value
        End Set
    End Property

    'CONSTRUCTORES
    Public Sub New()


    End Sub

    Public Sub New(ByVal idusuario As Integer, ByVal codigo_empleado As Integer, ByVal nombre As String, ByVal apellido As String, ByVal usuarionick As String,
                   ByVal password As String, ByVal tipousuario As String, ByVal permiso_agregar As Integer, ByVal permiso_modificar As Integer,
                   ByVal permiso_eliminar As Integer, ByVal permiso_admin As Integer, ByVal permiso_crealista As Integer,
                   ByVal permiso_cocina As Integer, ByVal permiso_digitador As Integer, ByVal permiso_transportista As Integer,
                   ByVal iddepartamento As Integer, ByVal estado As Integer, ByVal fecha_creacion As Date,
                   ByVal fecha_modificacion As Date, ByVal fecha_contrato As Date, ByVal Idturno As Integer, ByVal PermisoSuperintendente As Integer,
                   ByVal validapeticion As Integer, ByVal Numerogrupo As Integer)
        gidusuario = idusuario
        gcodigousuario = codigo_empleado
        gnombre = nombre
        gapellido = apellido
        gusuarionick = usuarionick
        gpassword = password
        gtipousuario = tipousuario
        gpermisoagregar = permiso_agregar
        gpermisomodificar = permiso_modificar
        gpermisoeliminar = permiso_eliminar
        gpermisocrealista = permiso_crealista
        gpermisococina = permiso_cocina
        gpermisodigitador = permiso_digitador
        gpermisotransportista = permiso_transportista
        giddepartamento = iddepartamento
        gestado = estado
        gfechacreacion = fecha_creacion
        gfechamodificacion = fecha_modificacion
        gfechacontrato = fecha_contrato
        gidturno = Idturno
        gPermisoSuperintendente = PermisoSuperintendente
        gValidaPeticion = validapeticion
        gNumeroGrupo = Numerogrupo

    End Sub
End Class