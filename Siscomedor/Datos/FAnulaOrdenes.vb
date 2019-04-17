Imports System.Data.SqlClient
Public Class FAnulaOrdenes
    Inherits conexion
    Dim cmd As New SqlCommand
    Public Function ModificarUsuario(ByVal dts As vUsuario) As Boolean
        Try
            Conectado()
            cmd = New SqlCommand("")
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


    Public Function mostrarordenes(ByVal IdArea As Integer) As DataTable
        Try
            Conectado()
            cmd = New SqlCommand("select
pd.IdListaAlimentacion as [SECUENCIAL],
concat(U.UsuarioNombre,' ',U. UsuarioApellido) as [NOMBRE EMPLEADO],
C.ComidaDescripcion as [TIEMPO],
convert(date,PD.FechaAsignada) as [FECHA ASIGNADA],
E.EstadoDescripcion as [ESTADO DE LA ORDEN]
from dbo.Pedidodepartamento pd
inner join dbo.TUsuarios U on U.IdUsuario = Pd.IdUsuarioAsignaticket
inner join dbo.Comida C on C.IdComida = Pd.IdComida
inner join dbo.Estado E on E.IdEstado = pd.IdEstadoTicket
inner join Departamento D on D.IdDepartamento= U.IdDepartamento 
inner join Areas a on a.IdArea = D.IdArea 
where pd.FechaAsignada >= convert(date, getdate())
and a.IdArea = @IdArea")
            cmd.Parameters.AddWithValue("@IdArea", IdArea)
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
End Class
