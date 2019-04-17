Public Class FrmTurnos
    Private dt As DataTable
    Dim PARALLEVAR As String
    Dim paraLLevarComer As Integer = 1
    Public validapeticion As Integer

    Private Sub FrmTurnos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        showturnos()
        mostrarTurnos()
        dgvShowTurnos.Columns(0).Visible = False
        
    End Sub
    Private Sub showturnos()
        Dim dt As DataTable
        Dim func As New fTurnos
        Try
            dt = func.MostrarTurnos(FrmLogin._Numerogrupo)
            If dt.Rows.Count > 0 Then
                dgvShowTurnos.DataSource = dt
                'For Each row As DataGridViewRow In dgvShowTurnos.Rows
                '    If row.Cells("Pedido para llevar").Value = 1 Then
                '        row.Cells("Pedido para llevar").Value = "PARA LLEVAR"
                '    Else
                '        row.Cells("Pedido para llevar").Value = "PARA COMER EN COMEDOR"
                '    End If
                'Next
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub mostrarTurnos()
        Dim db As New fUsuario
        CbxTurno.DataSource = db.mostraturnos
        CbxTurno.ValueMember = "ID"
        CbxTurno.DisplayMember = "Descripcion"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnmodturnos.Click
        Try
            Dim dts As New vUsuario
            Dim func As New fTurnos
            dts.idusuario = TxtIdusuario.Text
            'dts.gfechamodificacion = Today.Date.ToShortDateString
            dts.gidturno = CbxTurno.SelectedValue.ToString
            dts.gValidaPeticion = validapeticion

            'revisar PROBAR (its ok 5/03/19
            If func.ModificaUserSecretaria(dts) = True Then

                MsgBox("Registrado")
                MsgBox("modificado")
                showturnos()
            Else
                MsgBox("se ha producido un error")

            End If
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub dgvShowTurnos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvShowTurnos.CellContentClick
        'TxtIdusuario.Text = dgvShowTurnos.SelectedCells(0).Value
        'ChkvalidaPeticion.Checked = dgvShowTurnos.SelectedCells(4).Value
    End Sub

    Private Sub dgvShowTurnos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvShowTurnos.CellClick

        llenartextturnos()

    End Sub

    Private Sub llenartextturnos()
        Try
            TxtIdusuario.Text = dgvShowTurnos.CurrentRow.Cells(0).Value
            If dgvShowTurnos.CurrentRow.Cells(5).Value = "SI" Then
                ChkvalidaPeticion.CheckState = CheckState.Checked
            Else
                ChkvalidaPeticion.CheckState = CheckState.Unchecked
            End If
            ' ChkvalidaPeticion.CheckState = dgvShowTurnos.CurrentRow.Cells(5).Value
            CbxTurno.Text = dgvShowTurnos.CurrentRow.Cells(2).Value
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub


    Private Sub LLEVARCOMERchk()
        If ChkvalidaPeticion.CheckState Then

            ChkvalidaPeticion.Checked = 1

        End If
        ChkvalidaPeticion.Checked = 0
    End Sub

    Private Sub picboxregresar_Click(sender As Object, e As EventArgs) Handles picboxregresar.Click
        Me.Close()
        Me.Finalize()
        FrmSecretaria.Show()
    End Sub

    Private Sub ChkvalidaPeticion_CheckedChanged(sender As Object, e As EventArgs) Handles ChkvalidaPeticion.CheckedChanged
        If ChkvalidaPeticion.CheckState = CheckState.Checked Then
            validapeticion = 1
        Else
            validapeticion = 0
        End If


    End Sub


    Private Sub buscar()
        Try

            Dim ds As New DataSet
            ds.Tables.Add(dt.Copy)
            Dim dv As New DataView(ds.Tables(0))

            dv.RowFilter = cbobuscarpor.Text & " like'" & txtBuscar.Text & "%'"

            If dv.Count <> 0 Then
                dgvShowTurnos.DataSource = dv
                '   dgvShowTurnos.Columns(0).Visible = False

            Else
                dgvShowTurnos.DataSource = Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        buscar()
    End Sub


End Class