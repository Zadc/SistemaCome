Public Class FrmEditaVisitas
    Dim dt As New DataTable
    Private ListSortDirection
    Public validapeticion As Integer
    Private Sub FrmCreaVisitas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        muestrarvisitasonly()
        txtAlias.Visible = False
        txtPassword.Visible = False
        'txtsecuencial.Visible = False
        txtAlias.Enabled = True
        txtPassword.Enabled = True

        mostrarDepartamentos()
        mostrargruposprivate()
        btnguardar.Enabled = True
        btnguardar.Visible = False
        cboTipoUsuario.Visible = False
        lblRolUsuario.Visible = False
        Label3.Visible = False
        Label4.Visible = False
        lblapellido.Visible = False
        CbxTurno.Visible = False
        CbxTurno.Enabled = True
        cboTipoUsuario.Visible = False
        cboTipoUsuario.Enabled = True
        dgvmiravisitas.Columns(0).Visible = False
        dgvmiravisitas.Sort(dgvmiravisitas.Columns(1), ListSortDirection.Descending)
    End Sub


    'Private Sub validarvisita()
    '    Try
    '        If FrmLogin._UpermisoSuperintendente Then
    '            cboTipoUsuario.SelectedValue = 3
    '        Else
    '            cboTipoUsuario.Enabled = True

    '        End If

    '    Catch ex As Exception

    '    End Try
    'End Sub
    Private Sub mostrarDepartamentos()
        Dim db As New Fdepartamento
        cbodepartamento.DataSource = db.mostrardepartamentos
        cbodepartamento.ValueMember = "ID"
        cbodepartamento.DisplayMember = "Nombre"
    End Sub
    Private Sub mostrarTurnos()
        Dim db As New fUsuario
        CbxTurno.DataSource = db.mostraturnos
        CbxTurno.ValueMember = "ID"
        CbxTurno.DisplayMember = "Descripcion"
    End Sub

    Private Sub btnInhabilitar_Click(sender As Object, e As EventArgs) Handles btnInhabilitar.Click
        Me.Hide()
        FrmInactivaactivauser.Show()
    End Sub

    Private Sub muestrarvisitasonly()
        Try

            Dim func As New fUsuario

            dt = func.mostrarsolovisitas
            dgvmiravisitas.DataSource = dt


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub LlenarTextBox()
        Try
            'TXT
            txtsecuencial.Text = dgvmiravisitas.CurrentRow.Cells(0).Value
            txtCodigo.Text = dgvmiravisitas.CurrentRow.Cells(1).Value
            txtNombre.Text = dgvmiravisitas.CurrentRow.Cells(2).Value
            txtapellido.Text = dgvmiravisitas.CurrentRow.Cells(3).Value
            ChkvalidaPeticion.CheckState = dgvmiravisitas.CurrentRow.Cells(11).Value
            cbxGrupo.Text = dgvmiravisitas.CurrentRow.Cells(12).Value
            'CbxTurno.Text = dgvmiravisitas.CurrentRow.Cells(21).Value
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        If txtNombre.Text <> "" And txtCodigo.Text <> "" And txtapellido.Text <> "" Then
            Dim fun2 As New fUsuario
            dt = fun2.validacodigousuario(txtCodigo.Text)
            If dt.Rows.Count > 0 Then
                MsgBox("EL CODIGO DE USUARIO NO PUEDE SER UN CODIGO REPETIDO YA QUE SE CONSIDERA UN INDENTIFICADOR", MsgBoxStyle.Critical)
            Else
                Try
                    Dim dts As New vUsuario
                    Dim func As New fUsuario
                    dts.gcodigousuario = txtCodigo.Text
                    dts.gnombre = txtNombre.Text
                    dts.gapellido = txtapellido.Text
                    dts.giddepartamento = cbodepartamento.SelectedValue

                    dts.gfechacreacion = Today.Date
                    dts.gfechamodificacion = Today.Date
                    dts.gfechacontrato = dtpFechaContrato.Value.Date

                    dts.gValidaPeticion = ChkvalidaPeticion.CheckState
                    dts.gNumeroGrupo = cbxGrupo.SelectedValue
                    'Date.ToString("yyyy-MM-dd") 'Esto estaba cambiando

                    If func.InsertarUserVisita(dts) = True Then
                        limpiar()
                        MsgBox("Usuario Registrado")
                        muestrarvisitasonly()

                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)

                End Try

            End If
        Else
            MsgBox("No puede dejar campos obliagtorios como vacios", MsgBoxStyle.Critical)
        End If
    End Sub
    Private Sub limpiar()
        txtNombre.Text = ""
        txtapellido.Text = ""
        txtCodigo.Text = ""
    End Sub

    Private Sub mostrargruposprivate()
        Dim db As New fUsuario
        cbxGrupo.DataSource = db.mostrargrupos
        cbxGrupo.ValueMember = "ID"
        cbxGrupo.DisplayMember = "Descripcion"
    End Sub

    Private Sub btnnNuevoUsuarioVisita_Click(sender As Object, e As EventArgs) Handles btnnNuevoUsuarioVisita.Click
        Me.SendToBack()
        FrmCreaVisita.Show()

    End Sub

    Private Sub btnEditarVisita_Click(sender As Object, e As EventArgs) Handles btnEditarVisita.Click
        If txtCodigo.Text <> "" And txtNombre.Text <> "" And txtapellido.Text <> "" Then
            MsgBox(txtsecuencial.Text) 'este valor te falta man XD
            MsgBox(ChkvalidaPeticion.CheckState.ToString)
            MsgBox(cbxGrupo.SelectedValue.ToString)
            'Dim fun2 As New fUsuario
            'dt = fun2.validacodigousuario(txtCodigo.Text)
            'If dt.Rows.Count > 0 Then
            '    MsgBox("EL CODIGO DE USUARIO NO PUEDE SER UN CODIGO REPETIDO YA QUE SE CONSIDERA UN INDENTIFICADOR", MsgBoxStyle.Critical)
            'Else
            Try
                    Dim dts As New vUsuario
                    Dim func As New fUsuario

                    dts.gidusuario = txtsecuencial.Text
                    dts.gcodigousuario = txtCodigo.Text
                    dts.gnombre = txtNombre.Text
                    dts.gapellido = txtapellido.Text
                dts.giddepartamento = cbodepartamento.SelectedValue
                dts.gfechamodificacion = Today.Date
                    dts.gValidaPeticion = validapeticion
                    dts.gNumeroGrupo = cbxGrupo.SelectedValue.ToString
                    If func.EditaUserVisita(dts) = True Then
                    MsgBox("Registro Modificado")
                    limpiar()
                        muestrarvisitasonly()
                    Else
                    MsgBox("Se producido un ERROR :(")

                End If
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.Critical)

                End Try
            End If


        'End If
    End Sub

    Private Sub dgvmiravisitas_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvmiravisitas.CellClick
        LlenarTextBox()
    End Sub

    Private Sub dgvmiravisitas_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvmiravisitas.CellContentClick

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
                dgvmiravisitas.DataSource = dv
                dgvmiravisitas.Columns(0).Visible = False

            Else
                dgvmiravisitas.DataSource = Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        buscar()
    End Sub

    Private Sub btnEliminarVisita_Click(sender As Object, e As EventArgs) Handles btnEliminarVisita.Click
        If txtsecuencial.Text <> "" Then
            Dim fun As New fUsuario
            Dim dts As New vUsuario

            dts.gidusuario = txtsecuencial.Text
            If fun.EliminarUsuario(dts) = True Then
                limpiar()
                muestrarvisitasonly()
                MsgBox("Usuario ha sido eliminado")
            Else
                MsgBox("")
            End If
        End If

    End Sub

End Class
