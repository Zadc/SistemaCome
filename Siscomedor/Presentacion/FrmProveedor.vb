Public Class FrmProveedor

    Private Sub FrmProveedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If TxtDescripcion.Text <> "" Then
            Dim dts As New VProveedor
            Dim func As New FProveedor
            Try

                dts.gDeescripcion = TxtDescripcion.Text
                dts.gRTN = txtRTN.Text
                dts.gCorreo = TxtCorreo
                dts.gTelefono = txtTelefono
                dts.gDireccion = TxtDireccion.Text


                If func.InsertarProveedor(dts) = True Then
                    MsgBox("REGISTRO AGREGADO EXITOSAMENTE")
                Else
                    MsgBox("SE PRODUJO UN ERROR", MsgBoxStyle.Critical)

                End If
            Catch ex As Exception

            End Try
        End If

    End Sub

    Private Sub DtgvMostrarProveedor_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DtgvMostrarProveedor.CellContentClick

    End Sub

    Private Sub FrmProveedor_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        FrmMenu.Show()

    End Sub
End Class