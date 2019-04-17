Imports System.Data.SqlClient
Public Class FProductos
    Inherits conexion
    Dim cmd As New SqlCommand
    Public Function InsertarProductos(ByVal dts As VProductos) As Boolean
        Try
            Conectado()

            cmd = New SqlCommand("Insertar_Productos")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            'cmd.Parameters.AddWithValue("@IdProducto",dts.gidProducto)
            cmd.Parameters.AddWithValue("@CodigoProducto", dts.gcodigoproducto)
            cmd.Parameters.AddWithValue("@DescripcionProducto", dts.gdescripcionproducto)
            cmd.Parameters.AddWithValue("@IdProveedor", dts.gidproveedor)
            cmd.Parameters.AddWithValue("@PrecioProducto", dts.gprecioproducto)
            cmd.Parameters.AddWithValue("@Stock", dts.gstock)
            cmd.Parameters.AddWithValue("@EstadoProducto", dts.gestadoptroducto)
            cmd.Parameters.AddWithValue("@FechaCreacion", dts.gfechacrea)
            cmd.Parameters.AddWithValue("@FechaModificacion", dts.gfechamod)

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

    Public Function ModificarProducto(ByVal dts As VProductos) As Boolean

        Try
            Conectado()

            cmd = New SqlCommand("Modificar_Productos")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@IdProducto", dts.gidProducto)
            cmd.Parameters.AddWithValue("@CodigoProducto", dts.gcodigoproducto)
            cmd.Parameters.AddWithValue("@DescripcionProducto", dts.gdescripcionproducto)
            cmd.Parameters.AddWithValue("@IdProveedor", dts.gidproveedor)
            cmd.Parameters.AddWithValue("@PrecioProducto", dts.gprecioproducto)
            cmd.Parameters.AddWithValue("@Stock", dts.gstock)
            cmd.Parameters.AddWithValue("@EstadoProducto", dts.gestadoptroducto)
            cmd.Parameters.AddWithValue("@FechaCreacion", dts.gfechacrea)
            cmd.Parameters.AddWithValue("@FechaModificacion", dts.gfechamod)

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


    Public Function EliminarProducto(ByVal dts As VProductos) As Boolean

        Try
            Conectado()
            cmd = New SqlCommand("Eliminar_Producto")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn



            cmd.Parameters.AddWithValue("@IdProducto", dts.idProducto)

            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try

    End Function



    Public Function MostrarProductos() As DataTable
        Try
            Conectado()
            cmd = New SqlCommand("Mostrar_Productos")

            cmd.CommandType = CommandType.StoredProcedure
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
