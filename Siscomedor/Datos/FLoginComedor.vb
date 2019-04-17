Imports System.Data.SqlClient
Public Class FLoginComedor
    Inherits conexion
    Dim cmd As SqlCommand

    Public Function LoginComedor(ByVal dts As VLoginComedor) As Boolean
        Try
            Conectado()

            cmd = New SqlCommand("login_comedor")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            'cmd.Parameters.AddWithValue("@UsuarioNombre", dts.gusuariologincomedor)
            cmd.Parameters.AddWithValue("@CodigoUsuario", dts.gusuariocodigo)
            Dim dr As SqlDataReader
            dr = cmd.ExecuteReader

            If dr.HasRows = True Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception

            MsgBox(ex.Message)
            Return False
        End Try
    End Function
    Public Function Mostrartiempos() As DataTable
        Try
            Conectado()
            cmd = New SqlCommand("select TOP (3) [IdComida] as SECUENCIAL
      ,[ComidaDescripcion] as DESCRIPCION
      ,[HoraInicio] as INICIA
      ,[HoraFinalizacion] as TERMINA
  from [dbo].[Comida]
go")
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
        End Try
    End Function


End Class
