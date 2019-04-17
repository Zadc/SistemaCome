Imports System.Data.SqlClient
Public Class FComplemento
    Inherits conexion
    Private cmd As New SqlCommand


    Public Function InsertComplemento(ByVal dts As VComplementos) As Boolean
        Try
            Conectado()

            cmd = New SqlCommand("INSERT INTO [dbo].[Complemento]
           ([ComplementoDescripcion]
           ,[ComplementoFechaCreacion]
           ,[ComplementoFechaModificacion]
           ,[ComplementoEstado]
           ,[ComplementoStock])
     VALUES
           (@ComplementoDescripcion
           ,@ComplementoFechaCreacion
           ,@ComplementoFechaModificacion
           ,@ComplementoEstado 
           ,@ComplementoStock)")
            cmd.CommandType = CommandType.Text
            cmd.Connection = cnn

            'cmd.Parameters.AddWithValue("@IdProducto",dts.gidProducto)
            cmd.Parameters.AddWithValue("@ComplementoDescripcion", dts.gvdesccomplemento)
            cmd.Parameters.AddWithValue("@ComplementoFechaCreacion", dts.gvcomplementofechacrea)
            cmd.Parameters.AddWithValue("@ComplementoFechaModificacion", dts.gvcomplementofechamod)
            cmd.Parameters.AddWithValue("@ComplementoEstado", dts.gvcomplementoestado)
            cmd.Parameters.AddWithValue("@ComplementoStock", dts.gvcomplemetoestock)

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

    Public Function ModificarComplemento(ByVal dts As VComplementos) As Boolean
        Try
            Conectado()

            cmd = New SqlCommand("")
            cmd.CommandType = CommandType.Text
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@IdComplemento", dts.gvidcomplemento)
            cmd.Parameters.AddWithValue("@ComplementoDescripcion", dts.gvdesccomplemento)
            cmd.Parameters.AddWithValue("@ComplementoFechaCreacion", dts.gvcomplementofechacrea)
            cmd.Parameters.AddWithValue("@ComplementoFechaModificacion", dts.gvcomplementofechamod)
            cmd.Parameters.AddWithValue("@ComplementoEstado", dts.gvcomplementoestado)
            cmd.Parameters.AddWithValue("@ComplementoStock", dts.gvcomplemetoestock)

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
