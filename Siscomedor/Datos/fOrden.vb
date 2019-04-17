
Imports System.Data.SqlClient

Public Class fOrden


    Inherits conexion
    Dim cmd As New SqlCommand

    Public Function insertar() As Button
        Try
            Conectado()
            cmd = New SqlCommand("insertar_orden")

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
        Return Nothing
    End Function
    Public Function MostrarComida() As DataTable

        Try
            Conectado()
            cmd = New SqlCommand("select * from comida")
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
    Public Function Validarexistenciaordenesusuario(ByVal iduser As Integer, ByVal idcomida As Integer, ByVal fecha As Date) As DataTable

        Try
            Conectado()
            cmd = New SqlCommand("select idlistaalimentacion
      from [dbo].[Pedidodepartamento]
where IdUsuarioAsignaticket = @IdUsuarioAsignaticket
and idcomida = @IdComida
and fechaAsignada = @FechaAsignada")
            cmd.CommandType = CommandType.Text
            cmd.Parameters.AddWithValue("@IdUsuarioAsignaticket", iduser)
            cmd.Parameters.AddWithValue("@IdComida", idcomida)
            cmd.Parameters.AddWithValue("@FechaAsignada", fecha)

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

    Public Function Validarexistenciao2(ByVal dts As vOrden) As DataTable

        Conectado()
        cmd = New SqlCommand("select IdListaAlimentacion
from [dbo].[Pedidodepartamento]
where IdUsuarioAsignaticket = @IdUsuarioAsignaticket
and idcomida = @IdComida
and fechaAsignada = @FechaAsignada
and IdEstadoTicket = @estado")
        cmd.CommandType = CommandType.Text
        cmd.Parameters.AddWithValue("@IdUsuarioAsignaticket", dts.gOidusuarioasigna)
        cmd.Parameters.AddWithValue("@IdComida", dts.gidcomida)
        cmd.Parameters.AddWithValue("@FechaAsignada", dts.gFechaasignada)
        cmd.Parameters.AddWithValue("@estado", dts.gidestadoticket)
        cmd.Connection = cnn
        'cnn.Open()

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


        'cnn.Close()

        desconectado()

    End Function

    Public Function ValidarexistenciA_Masiva(ByVal dts As vOrden) As DataTable
        Conectado()
        cmd = New SqlCommand("select IdListaAlimentacion
from [dbo].[Pedidodepartamento]
where NumeroTicketMasivo = @NumeroTicketMasivo
and idcomida = @IdComida
and fechaAsignada = @FechaAsignada
and IdEstadoTicket = @estado")
        cmd.CommandType = CommandType.Text
        cmd.Parameters.AddWithValue("@NumeroTicketMasivo", dts.gNumeroticketMasivo)
        cmd.Parameters.AddWithValue("@IdComida", dts.gidcomida)
        cmd.Parameters.AddWithValue("@FechaAsignada", dts.gFechaasignada)
        cmd.Parameters.AddWithValue("@estado", dts.gidestadoticket)
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
        desconectado()
    End Function
    Public Function CAMBIAESTADOORDENES(ByVal dts As vOrden) As Boolean
        Try
            Conectado()
            cmd = New SqlCommand("UPDATE Pedidodepartamento
SET IdEstadoTicket = @IdEstadoTicket
WHERE IdListaAlimentacion = @IdListaAlimentacion")
            cmd.CommandType = CommandType.Text
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@IdEstadoTicket", dts.gidestadoticket)
            cmd.Parameters.AddWithValue("@IdListaAlimentacion", dts.gid_Orden)

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
    Public Function actualizaordenes(ByVal dts As vOrden, ByVal tipoupdate As Integer) As Boolean
        Try
            Conectado()
            cmd = New SqlCommand("begin
if @variable = 1
--actualiza masivos
update dbo.Pedidodepartamento
set 
IdEstadoTicket = 2,
FechaUsoTicket = convert(datetime, getdate())
where NumeroTicketMasivo = @NumeroTicketMasivo
and FechaAsignada = @FechaAsignada
and IdComida = @IdComida
else
if @variable = 2
--actualiza ticket individual
update dbo.Pedidodepartamento
set 
IdEstadoTicket = 2,
FechaUsoTicket = convert(datetime, getdate())
where IdUsuarioAsignaticket = @IdUsuarioAsignaticket
and FechaAsignada = @FechaAsignada
and IdComida = @IdComida
end")
            cmd.CommandType = CommandType.Text
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@variable", tipoupdate)
            cmd.Parameters.AddWithValue("@IdUsuarioAsignaticket", dts.gOidusuarioasigna)
            cmd.Parameters.AddWithValue("@IdComida", dts.gidcomida)
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
    Public Function ValidarturnoUsuario(ByVal dts As vUsuario) As DataTable
        Conectado()
        cmd = New SqlCommand("select top (1) idusuario from TUsuarios
where TUsuarios.IdTurno = 2
and Idusuario = @Idusuario")
        cmd.CommandType = CommandType.Text
        cmd.Parameters.AddWithValue("@Idusuario", dts.gidusuario)

        cmd.Connection = cnn
        'cnn.Open()

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
        'cnn.Close()

        desconectado()

    End Function
    Public Function MostrarOrdenesFinales(ByVal idcomida As Integer, ByVal Numeromasivo As String) As DataTable

        Try

            Conectado()
            cmd = New SqlCommand("MostrarOrdenesList")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@IdComida", idcomida)
            cmd.Parameters.AddWithValue("@NumeroTicketMasivo", Numeromasivo)
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



    'Private Sub cambiarmonitor(ByVal monitor As Integer)
    '    Dim pantalla As Screen
    '    Dim StartPosition As Screen
    '    Dim Hide As Screen
    '    Dim Location As Screen
    '    pantalla = Screen.AllScreens(monitor)   'le paso 0 para el monitor principal y 1 para el secundario        
    '    Me.Hide()
    '    Me.StartPosition = FormStartPosition.Manual
    '    Dim p As New Point(pantalla.Bounds.Location.X, 0)
    '    Me.Location = p
    '    Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
    '    Me.WindowState = FormWindowState.Maximized
    '    Me.Show()
    'End Sub



End Class
