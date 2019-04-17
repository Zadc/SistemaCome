Public Class FrmCreaVisita
    Dim dt As New DataTable
    Private Sub FrmCreaVisita_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrarDepartamentos()
        mostrargruposprivate()
    End Sub

    Private Sub mostrarDepartamentos()
        Dim db As New Fdepartamento
        cbodepartamento.DataSource = db.mostrardepartamentos
        cbodepartamento.ValueMember = "ID"
        cbodepartamento.DisplayMember = "Nombre"
    End Sub

    Private Sub btnInhabilitar_Click(sender As Object, e As EventArgs) Handles btnInhabilitar.Click
        Me.Hide()
        FrmInactivaactivauser.Show()
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

    Private Sub btnGuardarVisita_Click(sender As Object, e As EventArgs) Handles btnGuardarVisita.Click
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
            MsgBox("No puede dejaar campos obliagtorios como vacios", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub btnAtras_Click(sender As Object, e As EventArgs) Handles btnAtras.Click
        Me.Close()
        FrmEditaVisitas.BringToFront()
    End Sub



    Private Sub muestrarvisitasonly()
        Try

            Dim func As New fUsuario

            dt = func.mostrarsolovisitas
            FrmEditaVisitas.dgvmiravisitas.DataSource = dt


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class