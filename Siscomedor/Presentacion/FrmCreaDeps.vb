Public Class FrmCreaDeps

    'EVENTO LOAD
    Private Sub FrmCreaDeps_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ComedordbDataSet1.Departamento' table. You can move, or remove it, as needed.

        mostrar_areas()
        mostrardepartamentos()

        cboArea.Enabled = False

    End Sub


    Private dt As New DataTable

    Private Sub LlenarTextBox()
        Try
            txtIdDsecuencial.Text = dgvDepartamentos.CurrentRow.Cells(0).Value
            txtCodigoDep.Text = dgvDepartamentos.CurrentRow.Cells(1).Value
            txtDescripcionDep.Text = dgvDepartamentos.CurrentRow.Cells(2).Value
            cboArea.Text = dgvDepartamentos.CurrentRow.Cells(3).Value
            txtCuentaContable.Text = dgvDepartamentos.CurrentRow.Cells(4).Value


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub mostrardepartamentos()
        Dim fun As New FCreaDeps
        dt = fun.mostrarDep
        dgvDepartamentos.DataSource = dt
    End Sub

    Private Sub mostrar_areas()
        Dim db As New FCreaDeps
        cboArea.DataSource = db.mostrarArea
        cboArea.ValueMember = "ID"
        cboArea.DisplayMember = "NOMBRE AREA"
    End Sub


    Private Sub dgvDepartamentos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDepartamentos.CellClick
        LlenarTextBox()

    End Sub
    'BOTON GUARDAR
    'Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
    '    If txtCodigoDep.Text <> "" And txtDescripcionDep.Text <> "" And txtCuentaContable.Text <> "" Then

    '        Try
    '            'Dim name As String
    '            Dim dts As New VCreaDeps
    '            Dim func As New FCreaDeps
    '            'dts.gidepartamento = txtIdDsecuencial.Text
    '            dts.gcodigodepartamento = txtCodigoDep.Text
    '            dts.gdescripcion = txtDescripcionDep.Text
    '            dts.gidarea = cboArea.SelectedValue
    '            dts.gcuentacontable = txtCuentaContable.Text
    '            'name = txtDescripcionDep.Text

    '            If func.InsertarDepartamento(dts) = True Then
    '                'MsgBox("Departamento", name, "Creado")\
    '                MsgBox("DEP CREADO")
    '                mostrardepartamentos()


    '            End If
    '        Catch ex As Exception
    '            MsgBox(ex.Message)

    '        End Try

    '    End If
    '    limpiar()

    'End Sub
    Private Sub limpiar()
        txtIdDsecuencial.Text = ""
        txtCodigoDep.Text = ""
        txtDescripcionDep.Text = ""
        cboArea.Text = ""
        txtCuentaContable.Text = ""



    End Sub
    'BOTON MODIFICAR
    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        If txtCodigoDep.Text <> "" And txtDescripcionDep.Text <> "" And txtCuentaContable.Text <> "" Then

            Try
                Dim dts As New VCreaDeps
                Dim func As New FCreaDeps

                dts.gidepartamento = txtIdDsecuencial.Text
                dts.gcodigodepartamento = txtCodigoDep.Text
                dts.gdescripcion = txtDescripcionDep.Text
                dts.gidarea = cboArea.SelectedValue
                dts.gcuentacontable = txtCuentaContable.Text


                If func.Modificar_Dep(dts) = True Then
                    MsgBox("Registro Modificado")
                    limpiar()
                    mostrardepartamentos()

                Else
                    MsgBox("Error")
                End If

            Catch ex As Exception
                MsgBox(ex.Message)

            End Try

        End If
    End Sub
    'BOTON ELIMINAR
    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If txtIdDsecuencial.Text <> "" Then
            Dim fun As New FCreaDeps
            Dim dts As New VCreaDeps
            Try


                dts.gidepartamento = txtIdDsecuencial.Text
                If fun.Eliminar_Dep(dts) = True Then
                    MsgBox("Departamento Eliminado")
                    mostrardepartamentos()

                    limpiar()
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End If


    End Sub


    Private Sub picback_Click(sender As Object, e As EventArgs) Handles picback.Click
        Me.Close()
        FrmMenu.Show()




    End Sub

    Private Sub dgvDepartamentos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDepartamentos.CellContentClick
        dgvDepartamentos.Columns(0).Width = 50
        dgvDepartamentos.Columns(1).Width = 200
        dgvDepartamentos.Columns(2).Width = 200
        dgvDepartamentos.Columns(3).Width = 500
        dgvDepartamentos.Columns(4).Width = 50

     

    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Me.SendToBack()
        FrmCrearDepartamento.Show()

    End Sub


End Class