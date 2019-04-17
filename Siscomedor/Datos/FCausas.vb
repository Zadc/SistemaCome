Imports System.Data.SqlClient

Public Class FCausas
    Inherits conexion
    Dim cmd As New SqlCommand

    Public Function MostrarCausas() As DataTable

        Try
            Conectado()
            cmd = New SqlCommand("SELECT [IdCausaInhabilita] as 'SECUENCIAL'
      ,[CausaInhabilita] AS DESCRIPCION
  FROM [dbo].[Causa_Inhabilita]
")
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
End Class
