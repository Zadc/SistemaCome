Imports System.Data.SqlClient
Public Class FProveedor
    Inherits conexion
    Dim cmd As New SqlCommand
    Public Function InsertarProveedor(ByVal dts As VProveedor) As Boolean
        Try
            Conectado()

            cmd = New SqlCommand("insert into dbo.Proveedor
values
(@ProveedorDescripcion, @ProveedorRTN, @ProveedorCorreo, @ProveedorTelefono, @ProveedorDireccion  
  , getdate() 
  , getdate() )")
            cmd.CommandType = CommandType.Text
            cmd.Connection = cnn

            'cmd.Parameters.AddWithValue("@IdProducto",dts.gidProducto)
            cmd.Parameters.AddWithValue("@ProveedorDescripcion", dts.gDeescripcion)
            cmd.Parameters.AddWithValue("@ProveedorRTN", dts.gRTN)
            cmd.Parameters.AddWithValue("@ProveedorCorreo", dts.gCorreo)
            cmd.Parameters.AddWithValue("@ProveedorTelefono", dts.gTelefono)
            cmd.Parameters.AddWithValue("@ProveedorDireccion ", dts.gDireccion)


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

    Public Function ModificarPROVEEDOR(ByVal dts As VProveedor) As Boolean

        Try
            Conectado()

            cmd = New SqlCommand("update [dbo].[Proveedor]
   set [ProveedorDescripcion] = @ProveedorDescripcion,
      ,[ProveedorRTN] = @ProveedorRTN, 
      ,[ProveedorCorreo] = @ProveedorCorreo, 
      ,[ProveedorTelefono] = @ProveedorTelefono,
      ,[ProveedorDireccion] =  @ProveedorDireccion,
     ,[ProveedorFechaModificacion] = getdate()
 where IdProveedor = @IdProveedor
")
            cmd.CommandType = CommandType.Text
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@IdProveedor", dts.gIDPROVEEDOR)
            cmd.Parameters.AddWithValue("@ProveedorDescripcion", dts.gDeescripcion)
            cmd.Parameters.AddWithValue("@ProveedorRTN", dts.gRTN)
            cmd.Parameters.AddWithValue("@ProveedorCorreo", dts.gCorreo)
            cmd.Parameters.AddWithValue("@ProveedorTelefono", dts.gTelefono)
            cmd.Parameters.AddWithValue("@@ProveedorDireccion", dts.gDireccion)

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


    Public Function EliminarProveedor(ByVal dts As VProveedor) As Boolean

        Try
            Conectado()
            cmd = New SqlCommand("delete from dbo.Proveedor
where IdProveedor = @IdProveedor")
            cmd.CommandType = CommandType.Text
            cmd.Connection = cnn



            cmd.Parameters.AddWithValue("@IdProveedor", dts.gIDPROVEEDOR)

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
