Imports System.Data.SqlClient


Public Class Fdepartamento
    Inherits conexion

    Dim cmd As New SqlCommand
    Public Function mostrardepartamentos() As DataTable
        Try
            Conectado()
            cmd = New SqlCommand("SELECT [IdDepartamento] as ID
      ,[DepartamentoCodigo] as Codigo
      ,[DepartamentoDescripcion] as Nombre
, [CuentaContable] as Cuenta
      FROM [dbo].[Departamento]")

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
