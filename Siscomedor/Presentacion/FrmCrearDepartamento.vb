Public Class FrmCrearDepartamento
    Private dt As New DataTable
    Private Sub btnCrearDep_Click(sender As Object, e As EventArgs) Handles btnCrearDep.Click
        If txtCodigoDep.Text <> "" And txtDescripcionDep.Text <> "" And txtCuentaContable.Text <> "" Then

            Try
                'Dim name As String
                Dim dts As New VCreaDeps
                Dim func As New FCreaDeps
                'dts.gidepartamento = txtIdDsecuencial.Text
                dts.gcodigodepartamento = txtCodigoDep.Text
                dts.gdescripcion = txtDescripcionDep.Text
                dts.gidarea = cboArea.SelectedValue
                dts.gcuentacontable = txtCuentaContable.Text
                'name = txtDescripcionDep.Text

                If func.InsertarDepartamento(dts) = True Then
                    'MsgBox("Departamento", name, "Creado")\
                    MsgBox("DEP CREADO")
                    mostrardepartamentos()


                End If
            Catch ex As Exception
                MsgBox(ex.Message)

            End Try

        End If
        limpiar()
    End Sub

    Private Sub limpiar()
        txtIdDsecuencial.Text = ""
        txtCodigoDep.Text = ""
        txtDescripcionDep.Text = ""
        cboArea.Text = ""
        txtCuentaContable.Text = ""
    End Sub

    Private Sub mostrardepartamentos()
        Dim fun As New FCreaDeps
        dt = fun.mostrarDep
        FrmCreaDeps.dgvDepartamentos.DataSource = dt
    End Sub

    Private Sub mostrar_areas()
        Dim db As New FCreaDeps
        cboArea.DataSource = db.mostrarArea
        cboArea.ValueMember = "ID"
        cboArea.DisplayMember = "NOMBRE AREA"
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

        mostrar_areas()

    End Sub

    Private Sub btnnuevo_Click(sender As Object, e As EventArgs) Handles btnnuevo.Click
        limpiar()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()

    End Sub
End Class
