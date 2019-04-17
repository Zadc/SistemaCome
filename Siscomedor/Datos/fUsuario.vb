Imports System.Data.SqlClient

Public Class fUsuario
    Inherits conexion
    'Variable cmd Enviar peticiones a la base de datos
    Dim cmd As New SqlCommand

    Public Function mostrar() As DataTable
        Try
            Conectado()
            cmd = New SqlCommand("MOSTRA_RUSER")

            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            If cmd.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New SqlClient.SqlDataAdapter(cmd)
                da.Fill(dt)
                Return dt
            Else
                Return Nothing

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function
    Public Function validacodigousuario(ByVal Codigousuario As String) As DataTable
        Try
            Conectado()
            cmd = New SqlCommand("select IdUsuario from dbo.TUsuarios
where CodigoUsuario = @CodigoUsuario")

            cmd.CommandType = CommandType.Text
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@CodigoUsuario", Codigousuario)
            If cmd.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New SqlClient.SqlDataAdapter(cmd)
                da.Fill(dt)
                Return dt
                'If dt.Rows.Count > Then
                '    MessageBox.Show("Ya existe un registro con el codigo asignado", "ERROR",, MsgBoxStyle.Critical)
                'End If
            Else
                Return Nothing

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function
    Public Function mostrarGrupo() As DataTable
        Try
            Conectado()
            cmd = New SqlCommand("SELECT [Id.Grupo] as Id 
      ,[Descripcion.Grupo] Descripcion
  FROM [comedordb].[dbo].[Grupo.Usuarios]")

            cmd.CommandType = CommandType.Text
            cmd.Connection = cnn

            If cmd.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New SqlClient.SqlDataAdapter(cmd)
                da.Fill(dt)
                Return dt
            Else
                Return Nothing

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

    'Public Function Insertar(ByVal dts As vUsuario) As Boolean
    '    mostrar()
    '    Try
    '        Conectado()
    '        cmd = New SqlCommand("insertar_Usuario")
    '        cmd.CommandType = CommandType.StoredProcedure
    '        cmd.Connection = cnn
    '        cmd.Parameters.AddWithValue("@CodigoUsuario", dts.gcodigousuario)
    '        cmd.Parameters.AddWithValue("@UsuarioNombre", dts.gnombre)
    '        cmd.Parameters.AddWithValue("@UsuarioApellido", dts.gapellido)
    '        cmd.Parameters.AddWithValue("@UsuarioNick", dts.gusuarionick)
    '        cmd.Parameters.AddWithValue("@UsuarioPassword", dts.gpassword)
    '        cmd.Parameters.AddWithValue("@TipoUsuario", dts.gtipousuario)
    '        cmd.Parameters.AddWithValue("@UPermiso_agregar", dts.gpermisoagregar)
    '        cmd.Parameters.AddWithValue("@UPermiso_modificar", dts.gpermisomodificar)
    '        cmd.Parameters.AddWithValue("@UPermiso_eliminar", dts.gpermisoeliminar)
    '        cmd.Parameters.AddWithValue("@UPermiso_admin", dts.gpermisoadmin)
    '        cmd.Parameters.AddWithValue("@UPermiso_secretaria", dts.gpermisocrealista)
    '        cmd.Parameters.AddWithValue("@UPermiso_cocina", dts.gpermisococina)
    '        cmd.Parameters.AddWithValue("@Permiso_digitador", dts.gpermisodigitador)
    '        cmd.Parameters.AddWithValue("@UPermiso_transportista", dts.gpermisotransportista)
    '        cmd.Parameters.AddWithValue("@IdDepartamento", dts.giddepartamento)
    '        cmd.Parameters.AddWithValue("@UsuarioEstado", dts.gestado)
    '        cmd.Parameters.AddWithValue("@UFechacreacion", dts.gfechacreacion)
    '        cmd.Parameters.AddWithValue("@UFechaModificacion", dts.gfechamodificacion)
    '        cmd.Parameters.AddWithValue("@UFechaContrato", dts.gfechacontrato)
    '        If cmd.ExecuteNonQuery Then
    '            Return True
    '        Else
    '            Return False

    '        End If

    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '        Return False

    '    End Try
    '    Return desconectado()
    'End Function

    Public Function InsertarUser(ByVal dts As vUsuario) As Boolean

        Try
            Conectado()
            cmd = New SqlCommand("Insertar_User")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            'cmd.Parameters.AddWithValue("@CodigoUsuario", dts.gcodigousuario)
            cmd.Parameters.AddWithValue("@CodigoUsuario", dts.gcodigousuario)
            cmd.Parameters.AddWithValue("@UsuarioNombre", dts.gnombre)
            cmd.Parameters.AddWithValue("@UsuarioApellido", dts.gapellido)
            cmd.Parameters.AddWithValue("@UsuarioNick", dts.gusuarionick)
            cmd.Parameters.AddWithValue("@UsuarioPassword", dts.gpassword)
            cmd.Parameters.AddWithValue("@TipoUsuario", dts.gtipousuario)
            cmd.Parameters.AddWithValue("@UPermisoAgregar", dts.gpermisoagregar)
            cmd.Parameters.AddWithValue("@UPermisoModificar", dts.gpermisomodificar)
            cmd.Parameters.AddWithValue("@UPermisoEliminar", dts.gpermisoeliminar)
            cmd.Parameters.AddWithValue("@UPermisoAdmin", dts.gpermisoadmin)
            cmd.Parameters.AddWithValue("@UPermisoCrealista", dts.gpermisocrealista)
            cmd.Parameters.AddWithValue("@UPermisoCocina", dts.gpermisococina)
            cmd.Parameters.AddWithValue("@UPermisoDigitador", dts.gpermisodigitador)
            cmd.Parameters.AddWithValue("@UPermisoTransportista", dts.gpermisotransportista)
            cmd.Parameters.AddWithValue("@CodigoDepartamento", dts.giddepartamento)
            cmd.Parameters.AddWithValue("@UsuarioEstado", dts.gestado)
            cmd.Parameters.AddWithValue("@UFechaCreacion", dts.gfechacreacion)
            cmd.Parameters.AddWithValue("@UFechaModificacion", dts.gfechamodificacion)
            cmd.Parameters.AddWithValue("@UfechaContratacion", dts.gfechacontrato)
            cmd.Parameters.AddWithValue("@Idturno", dts.gidturno)
            cmd.Parameters.AddWithValue("@UpermisoSuperintendente", dts.gPermisoSuperintendente)
            cmd.Parameters.AddWithValue("@validapeticion", dts.gValidaPeticion)
            cmd.Parameters.AddWithValue("@Numerogrupo", dts.gNumeroGrupo)

            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False

            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False

        End Try
        Return desconectado()
    End Function



    Public Function ModificarUsuario(ByVal dts As vUsuario) As Boolean
        Try
            Conectado()
            cmd = New SqlCommand("Modificar_Usuario")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn


            cmd.Parameters.AddWithValue("@IdUsuario", dts.gidusuario)
            cmd.Parameters.AddWithValue("@CodigoUsuario", dts.gcodigousuario)
            cmd.Parameters.AddWithValue("@UsuarioNombre", dts.gnombre)
            cmd.Parameters.AddWithValue("@UsuarioApellido", dts.gapellido)
            cmd.Parameters.AddWithValue("@UsuarioNick", dts.gusuarionick)
            cmd.Parameters.AddWithValue("@UsuarioPassword", dts.gpassword)
            cmd.Parameters.AddWithValue("@TipoUsuario", dts.gtipousuario)
            cmd.Parameters.AddWithValue("@UPermisoAgregar", dts.gpermisoagregar)
            cmd.Parameters.AddWithValue("@UPermisoModificar", dts.gpermisomodificar)
            cmd.Parameters.AddWithValue("@UPermisoEliminar", dts.gpermisoeliminar)
            cmd.Parameters.AddWithValue("@UPermisoAdmin", dts.gpermisoadmin)
            cmd.Parameters.AddWithValue("@UPermisoCrealista", dts.gpermisocrealista)
            cmd.Parameters.AddWithValue("@UPermisoCocina", dts.gpermisococina)
            cmd.Parameters.AddWithValue("@UPermisoDigitador", dts.gpermisodigitador)
            cmd.Parameters.AddWithValue("@UPermisoTransportista", dts.gpermisotransportista)
            cmd.Parameters.AddWithValue("@IdDepartamento", dts.giddepartamento)
            cmd.Parameters.AddWithValue("@UsuarioEstado", dts.gestado)
            cmd.Parameters.AddWithValue("@UFechaCreacion", dts.gfechacreacion)
            cmd.Parameters.AddWithValue("@UFechaModificacion", dts.gfechamodificacion)
            cmd.Parameters.AddWithValue("@UfechaContratacion", dts.gfechacontrato)
            cmd.Parameters.AddWithValue("@Idturno", dts.gidturno)
            cmd.Parameters.AddWithValue("@UpermisoSuperintendente", dts.gPermisoSuperintendente)
            cmd.Parameters.AddWithValue("@validapeticion", dts.gValidaPeticion)
            cmd.Parameters.AddWithValue("@Numerogrupo", dts.gNumeroGrupo)

            If cmd.ExecuteNonQuery Then
                Return True

            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return desconectado()
    End Function
    'ELIMINAR
    Public Function EliminarUsuario(ByVal dts As vUsuario) As Boolean
        Try
            Conectado()
            cmd = New SqlCommand("Eliminar_Usuario")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn



            cmd.Parameters.AddWithValue("@IdUsuario", dts.gidusuario)

            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    'MOSTRAR TURNOS
    Public Function mostraturnos() As DataTable
        Try
            Conectado()
            cmd = New SqlCommand("select [Turno.Id] as ID
      ,[Turno.Descripcion] as Descripcion
  from [dbo].[Turnos]")

            cmd.CommandType = CommandType.Text
            cmd.Connection = cnn

            If cmd.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New SqlClient.SqlDataAdapter(cmd)
                da.Fill(dt)
                Return dt
            Else
                Return Nothing

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function CambiarEstadoUsuario(ByVal dts As vUsuario) As Boolean
        Try
            Conectado()
            cmd = New SqlCommand("iNACTIVA_ACTIVA_USUARIO")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@Estado", dts.gestado)
            cmd.Parameters.AddWithValue("@IdUsuario", dts.idusuario)

            If cmd.ExecuteNonQuery Then
                Return True

            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return desconectado()
    End Function
    Public Function InsertarHistorico(ByVal FECHAINICIA As Date, ByVal FECHATERMINA As Date, ByVal IDUSUARIO As Integer,
                                     ByVal IDCAUSAINACTIVA As Integer, ByVal SEACTIVAAUTOMATICAMENTE As Integer) As DataTable

        Try
            Conectado()
            cmd = New SqlCommand("insert into [dbo].[Historico.Inactivaciones] values
           (@FechaInicia ,@FechaTermina,@IdUsuario,@Id_CausaInactiva,@SeActivaAutomaticamente, 1) ")
            ''
            cmd.Parameters.AddWithValue("@FechaInicia", FECHAINICIA)
            cmd.Parameters.AddWithValue("@FechaTermina", FECHATERMINA)
            cmd.Parameters.AddWithValue("@IdUsuario", IDUSUARIO)
            cmd.Parameters.AddWithValue("@Id_CausaInactiva", IDCAUSAINACTIVA)
            cmd.Parameters.AddWithValue("@SeActivaAutomaticamente", SEACTIVAAUTOMATICAMENTE)
            cmd.CommandType = CommandType.Text
            cmd.Connection = cnn
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)

        Finally

            desconectado()

        End Try
        Return Nothing
    End Function
    Public Function MuestraEstadoUsuario(ByVal idusuario As Integer) As DataTable
        Try
            Conectado()
            cmd = New SqlCommand("select dbo.TUsuarios.UsuarioEstado
from dbo.TUsuarios
where IdUsuario = @IdUsuario")
            cmd.Parameters.AddWithValue("@IdUsuario", idusuario)
            cmd.CommandType = CommandType.Text
            cmd.Connection = cnn

            If cmd.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New SqlClient.SqlDataAdapter(cmd)
                da.Fill(dt)
                Return dt
            Else
                Return Nothing

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function ValidaLoginComedor(ByVal dts As vUsuario) As DataTable
        Conectado()
        cmd = New SqlCommand("select IdUsuario,CodigoUsuario,UsuarioNombre,UsuarioApellido from tusuarios 
where CodigoUsuario = @CodigoUsuario")
        cmd.CommandType = CommandType.Text
        cmd.Parameters.AddWithValue("@CodigoUsuario", dts.gcodigousuario)

        cmd.Connection = cnn
        If cmd.ExecuteNonQuery Then
            Using dt As New DataTable
                Using da As New SqlDataAdapter(cmd)
                    da.Fill(dt)
                    Return dt
                End Using
            End Using
        Else
            Return Nothing
        End If
    End Function


    Public Function muestraturnospf(ByVal dts As vUsuario) As DataTable
        Try
            Conectado()
            cmd = New SqlCommand("select dbo.TUsuarios.IdTurno
from dbo.TUsuarios
where IdUsuario = @IdUsuario")
            cmd.Parameters.AddWithValue("@IdUsuario", dts.gcodigousuario)
            cmd.CommandType = CommandType.Text
            cmd.Connection = cnn

            If cmd.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New SqlClient.SqlDataAdapter(cmd)
                da.Fill(dt)
                Return dt
            Else
                Return Nothing

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try

    End Function
    'FRM VISITAS
    Public Function mostrarsolovisitas() As DataTable
        Try
            Conectado()
            cmd = New SqlCommand("SELECT U.IdUsuario, U.CodigoUsuario AS 'CODIGO EMPLEADO', U.UsuarioNombre 'NOMBRE', U.UsuarioApellido 'APELLIDO', U.TipoUsuario AS 'TIPO DE USUARIO',
D.DepartamentoDescripcion AS 'DEPARTAMETO',a.DescripcionArea AS 'AREA',UsuarioEstado AS'ESTADO',U.UFechaCreacion AS 'FECHA CREACION', U.UfechaContratacion AS 'FECHA CONTRATACION',
T.[Turno.Descripcion] AS 'TURNO',u.ValidaPeticion AS 'LLEVA/NO LLEVA', G.[Descripcion.Grupo] AS 'GRUPO' 
FROM dbo.TUsuarios U 
inner join dbo.Departamento D on D.IdDepartamento = U.IdDepartamento
inner join dbo.Areas A on a.IdArea = d.IdArea
inner join dbo.Turnos T on T.[Turno.Id]=u.IdTurno
inner join dbo.[Grupo.Usuarios] G on G.[Id.Grupo] = U.[NUMERO.GRUPO] 
WHERE TipoUsuario = 'VISITA'ORDER BY IdUsuario DESC
--,CONCAT (u.UsuarioNombre,' ',UsuarioApellido) AS 'Nombre Completo'")

            cmd.CommandType = CommandType.Text
            cmd.Connection = cnn

            If cmd.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New SqlClient.SqlDataAdapter(cmd)
                da.Fill(dt)
                Return dt
            Else
                Return Nothing

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function InsertarUserVisita(ByVal dts As vUsuario) As Boolean

        Try
            Conectado()
            cmd = New SqlCommand("INSERT INTO [dbo].[TUsuarios] VALUES
(@CodigoUsuario
,@UsuarioNombre
,@UsuarioApellido
,''
,''
,'VISITA'
,0
,0
,0
,0
,0
,0
,0
,0
,@IdDepartamento
,1
,CONVERT(DATE,GETDATE())
,CONVERT(DATE,GETDATE())
,@UfechaContratacion
,1
,0
,@ValidaPeticion
,@NUMEROGRUPO)")
            cmd.CommandType = CommandType.Text
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@CodigoUsuario", dts.gcodigousuario)
            cmd.Parameters.AddWithValue("@UsuarioNombre", dts.gnombre)
            cmd.Parameters.AddWithValue("@UsuarioApellido", dts.gapellido)
            'cmd.Parameters.AddWithValue("@UsuarioNick", dts.gusuarionick)
            'cmd.Parameters.AddWithValue("@UsuarioPassword", dts.gpassword)
            ''cmd.Parameters.AddWithValue("@TipoUsuario", dts.gtipousuario)
            'cmd.Parameters.AddWithValue("@UPermisoAgregar", dts.gpermisoagregar)
            'cmd.Parameters.AddWithValue("@UPermisoModificar", dts.gpermisomodificar)
            'cmd.Parameters.AddWithValue("@UPermisoEliminar", dts.gpermisoeliminar)
            'cmd.Parameters.AddWithValue("@UPermisoAdmin", dts.gpermisoadmin)
            'cmd.Parameters.AddWithValue("@UPermisoCrealista", dts.gpermisocrealista)
            'cmd.Parameters.AddWithValue("@UPermisoCocina", dts.gpermisococina)
            'cmd.Parameters.AddWithValue("@UPermisoDigitador", dts.gpermisodigitador)
            'cmd.Parameters.AddWithValue("@UPermisoTransportista", dts.gpermisotransportista)
            cmd.Parameters.AddWithValue("@IdDepartamento", dts.giddepartamento)
            'cmd.Parameters.AddWithValue("@UsuarioEstado", dts.gestado)
            cmd.Parameters.AddWithValue("@UFechaCreacion", dts.gfechacreacion)
            cmd.Parameters.AddWithValue("@UFechaModificacion", dts.gfechamodificacion)
            cmd.Parameters.AddWithValue("@UfechaContratacion", dts.gfechacontrato)
            'cmd.Parameters.AddWithValue("@Idturno", dts.gidturno)
            'cmd.Parameters.AddWithValue("@UpermisoSuperintendente", dts.gPermisoSuperintendente)
            cmd.Parameters.AddWithValue("@validapeticion", dts.gValidaPeticion)
            cmd.Parameters.AddWithValue("@NUMEROGRUPO", dts.gNumeroGrupo)

            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False

            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False

        End Try
        Return desconectado()
    End Function

    Public Function mostrargrupos() As DataTable
        Try
            Conectado()
            cmd = New SqlCommand("SELECT [Id.Grupo] AS ID
,[Descripcion.Grupo] AS DESCRIPCION
FROM [dbo].[Grupo.Usuarios]")

            cmd.CommandType = CommandType.Text
            cmd.Connection = cnn

            If cmd.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New SqlClient.SqlDataAdapter(cmd)
                da.Fill(dt)
                Return dt
            Else
                Return Nothing

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function EditaUserVisita(ByVal dts As vUsuario) As Boolean

        Try
            Conectado()
            cmd = New SqlCommand("UPDATE TUsuarios set
CodigoUsuario = @CodigoUsuario, 
UsuarioNombre = @UsuarioNombre, 
UsuarioApellido = @UsuarioApellido, 
IdDepartamento  = @IdDepartamento,
UFechaModificacion = @UFechaModificacion,
[ValidaPeticion] = @validapeticion,
[NUMERO.GRUPO] = @NUMEROGRUPO
Where IdUsuario  = @IdUsuario")
            cmd.CommandType = CommandType.Text
            cmd.Connection = cnn
            'cmd.Parameters.AddWithValue("@IdUsuario", dts.gidusuario)
            cmd.Parameters.AddWithValue("@CodigoUsuario", dts.gcodigousuario)
            cmd.Parameters.AddWithValue("@UsuarioNombre", dts.gnombre)
            cmd.Parameters.AddWithValue("@UsuarioApellido", dts.gapellido)
            cmd.Parameters.AddWithValue("@IdDepartamento", dts.giddepartamento)
            cmd.Parameters.AddWithValue("@UFechaModificacion", dts.gfechamodificacion)
            cmd.Parameters.AddWithValue("@validapeticion", dts.gValidaPeticion)
            cmd.Parameters.AddWithValue("@NUMEROGRUPO", dts.gNumeroGrupo)
            cmd.Parameters.AddWithValue("@IdUsuario", dts.gidusuario)
            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False

            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False

        End Try
        Return desconectado()
    End Function
End Class

'Parar bola
'Dim idusuario As Integer
'Dim codigo_empleado
'Dim nombre, apellido, password, permiso_agregar, permiso_modificar, permiso_eliminar,
'        permiso_admin, permiso_secretaria, permiso_cocina, permiso_digitador, permiso_transportista As String
'Dim iddepartamento As Integer
'Dim fecha_creacion As DateTime = DateTime.Now, fecha_modificacion As DateTime = DateTime.Now, fecha_contrato As Date
''Dim estado As String 