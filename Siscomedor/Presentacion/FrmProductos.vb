Public Class FrmProductos
    Dim dts As New VProductos
    Dim func As New FProductos

    Private Sub FrmProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrarprod()
    End Sub


    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If txtCodigoProducto.Text <> "" And txtDescripcion.Text <> "" And txtPrecio.Text <> "" And txtStock.Text <> "" Then

            Try

                dts.codigoproducto = txtCodigoProducto.Text
                dts.gdescripcionproducto = txtDescripcion.Text
                dts.gidproveedor = cboProveedores.SelectedValue
                dts.gprecioproducto = txtPrecio.Text
                dts.gstock = txtStock.Text
                dts.gfechacrea = Today.Date
                dts.gfechamod = Today.Date

                If func.InsertarProductos(dts) = True Then
                    MsgBox("Nice")

                End If
            Catch ex As Exception

            End Try
        End If

        CleanTxt()
    End Sub


    Private Sub CleanTxt()
        txtCodigoProducto.Text = ""
        txtDescripcion.Text = ""
        cboProveedores.Text = ""
        txtPrecio.Text = ""
        txtStock.Text = ""

    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If txtIdProducto.Text <> "" Then
            Dim fun As New FProductos
            Dim dts As New VProductos

            dts.gidProducto = txtIdProducto.Text
            If fun.EliminarProducto(dts) = True Then
                MsgBox("pRODUCTO ha sido eliminado")
            Else
                MsgBox("Joder Tio")
            End If
        End If
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        If txtCodigoProducto.Text <> "" And txtDescripcion.Text <> "" And txtPrecio.Text <> "" And txtStock.Text <> "" Then

            Try
                Dim dts As New VProductos
                Dim func As New FProductos


                dts.codigoproducto = txtCodigoProducto.Text
                dts.gdescripcionproducto = txtDescripcion.Text
                dts.gidproveedor = cboProveedores.SelectedValue
                dts.gprecioproducto = txtPrecio.Text
                dts.gstock = txtStock.Text
                dts.gfechacrea = Today.Date
                dts.gfechamod = Today.Date


                If func.ModificarProducto(dts) = True Then
                    MsgBox("Modificado correctamente")

                Else
                    MsgBox("fUCK U")

                End If
            Catch ex As Exception

            End Try



        End If
    End Sub

    Private Sub mostrarprod()
        Try
            Dim fun As New FProductos
            Dim dt As New DataTable
            dt = func.MostrarProductos

            If dt.Rows.Count <> 0 Then
                dgvProductos.DataSource = dt
                'txtBuscar.Enabled = True
                'dgvusuario.ColumnHeadersVisible = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    Private Sub dgvProductos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProductos.CellContentClick

    End Sub

    Private Sub dgvProductos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProductos.CellClick

        Llenartxprod()

    End Sub


    Private Sub Llenartxprod()
        Try
            txtIdProducto = dgvProductos.CurrentRow.Cells(0).Value
            txtCodigoProducto.Text = dgvProductos.CurrentRow.Cells(1).Value
            txtDescripcion.Text = dgvProductos.CurrentRow.Cells(2).Value
            cboProveedores.Text = dgvProductos.CurrentRow.Cells(3).Value
            txtPrecio.Text = dgvProductos.CurrentRow.Cells(3).Value
            txtStock.Text = dgvProductos.CurrentRow.Cells(3).Value

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cboProveedores_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboProveedores.SelectedIndexChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub picregreasar_Click(sender As Object, e As EventArgs) Handles picregreasar.Click
        Me.Close()
        FrmMenu.Show()
        FrmMenu.ShowDialog("Te saliste weon")



    End Sub
End Class