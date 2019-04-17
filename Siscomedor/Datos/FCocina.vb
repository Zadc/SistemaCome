Imports System.Data.SqlClient

Public Class FCocina
    Inherits conexion
    Dim cmd As New SqlCommand
    'MODIFICADA EL 5 DE  ABRIL
    Public Function mostrarOrdenesDETALLE(ByVal IDCOMIDA As String, ByVal FECHA As Date) As DataTable

        Try
            Conectado()
            cmd = New SqlCommand("select 
   CONCAT(U.UsuarioNombre, ' ', U.UsuarioApellido) AS 'EMPLEADO',
        a.DescripcionArea as 'AREA',
	 d.DepartamentoDescripcion as 'DEPARTAMENTO',
 cc.ComidaDescripcion as 'TIEMPO'
      from Pedidodepartamento PD
    inner join TUsuarios u on u.IdUsuario = pd.IdUsuarioAsignaticket
    inner join Complemento c on c.IdComplemento = pd.IdComplemento
    inner join Comida CC on cc.IdComida = pd.IdComida
    inner join dbo.Departamento d on d.IdDepartamento = u.IdDepartamento
    inner join dbo.Areas A on a.IdArea = d.IdArea
	where pd.IdComida = @IdComida
	and pd.FechaAsignada = convert(date,@FechaAsignada)
	ORDER BY C.IdComplemento ASC")
            cmd.Parameters.AddWithValue("@IdComida", IDCOMIDA)
            cmd.Parameters.AddWithValue("@FechaAsignada", Today.Date)
            cmd.CommandType = CommandType.Text

            cmd.Connection = cnn


            If cmd.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)
                Return dt
            Else
                Return Nothing

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally

            desconectado()
        End Try
    End Function
    Public Function mostrarOrdenes(ByVal FECHA As Date, ByVal idcomida As Integer) As DataTable

        Try
            Conectado()
            'fALTA MOSTRAR EL DISCTINCT
            cmd = New SqlCommand("select distinct D.DepartamentoDescripcion, A.DescripcionArea,
(select count(*)  from dbo.Pedidodepartamento PD2
inner join dbo.TUsuarios U2 on U2.IdUsuario = PD2.IdUsuarioAsignaticket
inner join dbo.Comida C2 on C2.IdComida = PD2.IdComida
inner join dbo.Complemento CC2 on CC2.IdComplemento = PD2.IdComplemento
inner join dbo.Departamento D2 on D2.IdDepartamento = U2.IdDepartamento
inner join dbo.Areas A2 on A2.IdArea = D2.IdArea
inner join dbo.Estado E2 on E2.IdEstado = PD2.IdEstadoTicket
where PD2.FechaAsignada = pd.fechaasignada
and D2.IdArea = D.IdArea
and d2.IdDepartamento = d.IdDepartamento
and PD2.IdEstadoTicket = PD.IdEstadoTicket
AND PD2.IdComida =@IdComida
) as 'CANTIDAD  DE PLATOS'
 from dbo.Pedidodepartamento PD
inner join dbo.TUsuarios U on U.IdUsuario = PD.IdUsuarioAsignaticket
inner join dbo.Comida C on C.IdComida = PD.IdComida
inner join dbo.Complemento CC on CC.IdComplemento = PD.IdComplemento
inner join dbo.Departamento D on D.IdDepartamento = U.IdDepartamento
inner join dbo.Areas A on A.IdArea = D.IdArea
inner join dbo.Estado E on E.IdEstado = PD.IdEstadoTicket
WHERE e.IdEstado =1 and PD.FechaAsignada = @FechaAsignada
AND A.DescripcionArea IN (SELECT DISTINCT A3.DescripcionArea FROM Areas A3)
AND C.IdComida = @IdComida")
            cmd.Parameters.AddWithValue("@FechaAsignada", FECHA)
            cmd.Parameters.AddWithValue("@IdComida", idcomida)
            cmd.CommandType = CommandType.Text

            cmd.Connection = cnn


            If cmd.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)
                Return dt
            Else
                Return Nothing

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally

            desconectado()
        End Try
    End Function
    Public Function mostrarOrdenesdetalleasreas(ByVal fecha As Date, ByVal Area As String) As DataTable

        Try
            Conectado()
            cmd = New SqlCommand("select  concat(u.UsuarioNombre,' ',u.UsuarioApellido) as [EMPLEADO], A.DescripcionArea as [AREA],
d.DepartamentoDescripcion AS [DEPARTAMENTO], C.ComidaDescripcion AS [TIEMPO]

 from dbo.Pedidodepartamento PD
inner join dbo.TUsuarios U on U.IdUsuario = PD.IdUsuarioAsignaticket
inner join dbo.Comida C on C.IdComida = PD.IdComida
inner join dbo.Complemento CC on CC.IdComplemento = PD.IdComplemento
inner join dbo.Departamento D on D.IdDepartamento = U.IdDepartamento
inner join dbo.Areas A on A.IdArea = D.IdArea
inner join dbo.Estado E on E.IdEstado = PD.IdEstadoTicket

--where PD.NumeroTicketMasivo = @NumeroTicketMasivo   or u.CodigoUsuario = @CodigoUsuario
WHERE e.CodigoEstado = 'S' --and PD.FechaAsignada = @FechaAsignada
and PD.FechaAsignada = convert(datetime,@fecha)
and a.DescripcionArea = @DescripcionArea 
order by c.IdComida asc")
            cmd.Parameters.AddWithValue("@fecha", fecha)
            cmd.Parameters.AddWithValue("@DescripcionArea ", Area)
            cmd.CommandType = CommandType.Text
            cmd.Connection = cnn


            If cmd.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)
                Return dt
            Else
                Return Nothing

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally

            desconectado()
        End Try
    End Function
    '    Public Function MostrarenListb() As DataTable
    '        Try
    '            Dim dt As New DataTable
    '            Dim da As New SqlDataAdapter(cmd)
    '            Conectado()
    '            cmd = New SqlCommand("select NumOrden as ID, 
    'cc.ComidaDescripcion as 'TIEMPO', CONCAT(U.UsuarioNombre, ' ', U.UsuarioApellido) AS 'EMPLEADO',
    ' C.ComplementoDescripcion as 'COMPLEMENTO',
    ' a.DescripcionArea as 'AREA'
    '  from Pedidodepartamento PD
    'inner join TUsuarios u on u.IdUsuario = pd.IdUsuarioAsignaticket
    'inner join Complemento c on c.IdComplemento = pd.IdComplemento
    'inner join Comida CC on cc.IdComida = pd.IdComida
    'inner join dbo.Departamento d on d.IdDepartamento = u.IdDepartamento
    'inner join dbo.Areas A on a.IdArea = d.IdArea
    'WHERE CC.HoraInicio >= @HORAINICIA AND CC.HoraFinalizacion <= @HORAFINALIZA")
    '            'cmd.Parameters.AddWithValue("@HORAINICIA", Inicia)
    '            'cmd.Parameters.AddWithValue("@HORAFINALIZA", Termina)
    '            cmd.CommandType = CommandType.Text

    '            cmd.Connection = cnn


    '            If cmd.ExecuteNonQuery Then

    '                da.Fill(dt)
    '                Return dt
    '            Else
    '                Return Nothing

    '            End If
    '        Catch ex As Exception
    '            MsgBox(ex.Message)
    '            Return Nothing
    '        Finally

    '            desconectado()
    '        End Try

    '    End Function

End Class



