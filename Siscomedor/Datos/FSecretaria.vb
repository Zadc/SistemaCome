Imports System.Data.SqlClient
Public Class FSecretaria



    Inherits conexion
    Dim cmd As New SqlCommand

    Public Function OBTENERRANGO(ByVal Idusuario As Integer) As DataTable

        Try
            Conectado()
            cmd = New SqlCommand("select tm.IdUsuario, tm.diasagenerar  from dbo.[SECRETARIA.TICKETMASIVO] tm
where tm.IdUsuario = @IdUsuario")
            cmd.CommandType = CommandType.Text

            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@IdUsuario", Idusuario)
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

    Public Function MostrarEmpleadosDepartamento(ByVal IDgrupo As Integer) As DataTable

        Try
            Conectado()
            '            cmd = New SqlCommand("create TABLE #TIEMPOS(DESAYUNO BIT not NULL,ALMUERZO BIT not NULL,CENA BIT not NULL,PEDIRORDEN BIT not null)
            ' insert into #TIEMPOS
            ' (DESAYUNO, ALMUERZO, CENA, PEDIRORDEN)
            ' values(1,1,0,1)
            'select  u.IdUsuario as 'SECUENCIAL' ,concat(U.UsuarioNombre,' ',U.UsuarioApellido) as 'NOMBRE EMPLEADO',
            '(select DESAYUNO from #TIEMPOS) as DESAYUNO,
            '(select ALMUERZO from #TIEMPOS) as ALMUERZO,
            '(select CENA from #TIEMPOS) as CENA,
            '(select PEDIRORDEN from #TIEMPOS) as 'SOLICITAR ORDEN'
            'from dbo.TUsuarios U
            'inner join dbo.Departamento D on d.IdDepartamento = u.IdDepartamento
            ' inner join dbo.Areas A on a.IdArea = D.IdArea
            ' where A.IdArea = @IDAREA and u.UsuarioEstado = 1
            ' drop table #TIEMPOS")
            cmd = New SqlCommand("create TABLE #TIEMPOS(DESAYUNO BIT not NULL,ALMUERZO BIT not NULL,CENA BIT not NULL,PEDIRORDEN BIT not null)
 insert into #TIEMPOS
 (DESAYUNO, ALMUERZO, CENA, PEDIRORDEN)
 values(1,1,0,1)
select  u.IdUsuario as 'SECUENCIAL' ,concat(U.UsuarioNombre,' ',U.UsuarioApellido) as 'NOMBRE EMPLEADO',
(select DESAYUNO from #TIEMPOS) as DESAYUNO,
(select ALMUERZO from #TIEMPOS) as ALMUERZO,
(select CENA from #TIEMPOS) as CENA,
(select PEDIRORDEN from #TIEMPOS) as 'SOLICITAR ORDEN'
from dbo.TUsuarios U
inner join dbo.Departamento D on d.IdDepartamento = u.IdDepartamento
 inner join dbo.Areas A on a.IdArea = D.IdArea
 where u.[numero.grupo] =@Numerogrupo and u.UsuarioEstado = 1
 and u.ValidaPeticion = 1
 drop table #TIEMPOS")

            cmd.CommandType = CommandType.Text

            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@Numerogrupo", IDgrupo)


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

    Public Function InsertarORDEN(ByVal dts As vOrden) As Boolean
        Try
            Conectado()
            cmd = New SqlCommand("GenerarOrden")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@IdUsuarioCrea", dts.gOidusuariocrea)
            cmd.Parameters.AddWithValue("@IdUsuarioAsignaticket", dts.gOidusuarioasigna)
            cmd.Parameters.AddWithValue("@IdComida", dts.gidcomida)
            cmd.Parameters.AddWithValue("@IdComplemento", dts.gidComplemento)
            cmd.Parameters.AddWithValue("@FechaAsignada", dts.gFechaasignada)
            cmd.Parameters.AddWithValue("@IdEstadoTicket", dts.gidestadoticket)
            cmd.Parameters.AddWithValue("@NumeroTicketMasivo", dts.gNumeroticketMasivo)

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

    '    Public Function ModificarCausa(ByVal dts As VCausas) As Boolean
    '        Try
    '            Conectado()
    '            cmd = New SqlCommand("ModificarCausa")
    '            cmd.CommandType = CommandType.StoredProcedure
    '            cmd.Connection = cnn

    '            cmd.Parameters.AddWithValue("@CausaId", dts.CausaId)
    '            cmd.Parameters.AddWithValue("@CausaNombre", dts.CausaNombre)
    '            cmd.Parameters.AddWithValue("@IncidenciaId", dts.IncidenciaId)



    '            If cmd.ExecuteNonQuery Then

    '                Return True

    '            Else
    '                Return False
    '            End If
    '        Catch ex As Exception
    '            MsgBox(ex.Message)
    '        End Try
    '        Return desconectado()
    '    End Function

    '    Public Function EliminarCausa(ByVal dts As VCausas) As Boolean
    '        Try
    '            Conectado()
    '            cmd = New SqlCommand("EliminarCausa")
    '            cmd.CommandType = CommandType.StoredProcedure
    '            cmd.Connection = cnn



    '            cmd.Parameters.AddWithValue("@CausaId", dts.CausaId)

    '            If cmd.ExecuteNonQuery Then
    '                Return True
    '            Else
    '                Return False
    '            End If
    '        Catch ex As Exception
    '            MsgBox(ex.Message)
    '            Return False
    '        End Try

    '    End Function



End Class
