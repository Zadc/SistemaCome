Public Class FrmAnulaOrdenes
    Private dt As New DataTable

    Private Sub FrmAnulaOrdenes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Visible = 0
        mostrarordenesolicitadas()
    End Sub

    Private Sub mostrarordenesolicitadas()
        Dim fun As New FAnulaOrdenes
        dt = fun.mostrarordenes(FrmLogin._IdArea)
        dgvMostrarOrdenes.DataSource = dt
        For Each ROW As DataGridViewRow In dgvMostrarOrdenes.Rows
            If ROW.Cells("ESTADO DE LA ORDEN").Value = "ANULADO" Then
                ROW.DefaultCellStyle.BackColor = Color.Orange
            End If
        Next

    End Sub

    Private Sub picCambiarAnular_Click(sender As Object, e As EventArgs) Handles picCambiarAnular.Click
        Dim ESTADO As Integer
        Dim ESTADOTEXTO As String
        If ComboBox1.Text = "ANULADO" Then
            ESTADO = 3
            ESTADOTEXTO = "ANULADO"
        ElseIf ComboBox1.Text = "SOLICITADO" Then
            ESTADO = 1
            ESTADOTEXTO = "SOLICITADO"
        End If


        Try
            Dim fun As New fOrden
            Dim VE As New vOrden
            VE.gid_Orden = TextBox1.Text
            VE.gidestadoticket = ESTADO
            If fun.CAMBIAESTADOORDENES(VE) = True Then
                MsgBox("ORDEN CAMBIO A ESTADO " & ESTADOTEXTO & " EXITOSAMENTE", MsgBoxStyle.Information)
            Else
                MsgBox("ORDEN NO SE HA PODIDO SER CAMBIADA DE ESTADO", MsgBoxStyle.Critical)
            End If
            mostrarordenesolicitadas()

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
    End Sub

    Private Sub dgvMostrarOrdenes_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvMostrarOrdenes.CellContentClick
        TextBox1.Text = dgvMostrarOrdenes.SelectedCells(0).Value
        If dgvMostrarOrdenes.SelectedCells(4).Value = "ANULADO" Then
            ComboBox1.Text = "ANULADO"
        ElseIf dgvMostrarOrdenes.SelectedCells(4).Value = "SOLICITADO" Then
            ComboBox1.Text = "SOLICITADO"
            [txtmuestrausuario].Text = dgvMostrarOrdenes.CurrentRow.Cells(1).Value
        End If
    End Sub

    Private Sub txtmuestrausuario_TextChanged(sender As Object, e As EventArgs) Handles txtmuestrausuario.TextChanged

    End Sub

    Private Sub picboxback_Click(sender As Object, e As EventArgs) Handles picboxback.Click
        Me.Close()
        FrmSecretaria.Show()
    End Sub
End Class