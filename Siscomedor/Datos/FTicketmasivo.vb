Imports System.Data.SqlClient



Public Class FTicketmasivo
    Inherits conexion
    Dim cmd As New SqlCommand
    Public Function ValidaNUMEROTICKETMASIVO(ByVal dts As VticketMasivo) As DataTable
        Conectado()
        cmd = New SqlCommand("select [NumeroTicketMasivo] as [NUMEROTICKETMASIVO]
  from [dbo].[SECRETARIA.TICKETMASIVO]
  where IdUsuario = @IdUsuario")
        cmd.CommandType = CommandType.Text
        cmd.Parameters.AddWithValue("@IdUsuario", dts.gid_Usuario)

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
    Public Function ValidapARANOREPETIRCODIGOMASIVO(ByVal dts As VticketMasivo) As DataTable
        Conectado()
        cmd = New SqlCommand("select NumeroTicketMasivo from dbo.[SECRETARIA.TICKETMASIVO]
where NumeroTicketMasivo = @NumeroTicketMasivo")
        cmd.CommandType = CommandType.Text
        ' cmd.Parameters.AddWithValue("@IdUsuario", dts.gid_Usuario)
        cmd.Parameters.AddWithValue("@NumeroTicketMasivo", dts.getNumeroticketMasivo)
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
    Public Function InserTAR_ACTUALIZAR_USUARIOTICKETMASIVO(ByVal dts As VticketMasivo) As Boolean
        Try
            Conectado()
            cmd = New SqlCommand("declare @iduser as integer
begin
set @iduser = (select IdUsuario from
dbo.[SECRETARIA.TICKETMASIVO]
where IdUsuario = @IdUsuario)
if @iduser is  null
insert into dbo.[SECRETARIA.TICKETMASIVO]
values
(@IdUsuario, @NumeroTicketMasivo,  @DiasaGenerar)
end
if @iduser > 0
update dbo.[SECRETARIA.TICKETMASIVO]
set NumeroTicketMasivo = @NumeroTicketMasivo,
,[DiasaGenerar] = @DiasaGenerar
where IdUsuario = @iduser")
            cmd.CommandType = CommandType.Text
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@IdUsuario", dts.gid_Usuario)
            cmd.Parameters.AddWithValue("@NumeroTicketMasivo", dts.getNumeroticketMasivo)
            cmd.Parameters.AddWithValue("@@DiasaGenerar", dts.getdiasagenerar)
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

End Class
