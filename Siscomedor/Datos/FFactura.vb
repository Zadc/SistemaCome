Imports System.Data.SqlClient

Public Class FFactura
    Inherits conexion
    Public cmd As New SqlCommand

    Public Function guardarfactura(ByVal dts As vFacturas) As Boolean
        Try
            Conectado()
            cmd = New SqlCommand("")
            cmd.CommandType = CommandType.Text
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@Idfactura", dts.gidfactura)
            cmd.Parameters.AddWithValue("@Numerofactura", dts.gnumerofactura)
            cmd.Parameters.AddWithValue("@Fechafactura", dts.gfechafactura)
            cmd.Parameters.AddWithValue("@Idusuario", dts.gidusuario)

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


    Public Function editarfactura(ByVal dts As vFacturas) As Boolean
        Try
            Conectado()
            cmd = New SqlCommand("")
            cmd.CommandType = CommandType.Text
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@Idfactura", dts.gidfactura)
            cmd.Parameters.AddWithValue("@Numerofactura", dts.gnumerofactura)
            cmd.Parameters.AddWithValue("@Fechafactura", dts.gfechafactura)
            cmd.Parameters.AddWithValue("@Idusuario", dts.gidusuario)

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
'FECHA DE Modificacion?