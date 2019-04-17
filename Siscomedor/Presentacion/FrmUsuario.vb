Imports System.Data.SqlClient
Imports System.Data
Imports System.ComponentModel

Public Class FrmAdmin
    Public codigousuario As String
    Public NombreUsuario As String
    Public NOMBRECOMPLETO As String
    Private dt As New DataTable
    'colcale cero alli :)
    Dim PermisoAgregar As Integer = 0
    Dim PermisoModificar As Integer = 0
    Dim PermisoEliminar As Integer = 0
    Dim PermisoAdministrar As Integer = 0
    Dim PermisoCrealista As Integer = 0
    Dim PermisoCocina As Integer = 0
    Dim PermisoDigitador As Integer = 0
    Dim PermisoTransportista As Integer = 0
    Dim estadousuario As Integer = 1
    Dim PermisoSuperintendente As Integer = 0
    Dim validapeticion As Integer = 0
    Dim cbo As String
    'EVENTO LOAD
    Private Sub FrmAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        eventomostrar()
        mostrarDepartamentos()
        mostrarTurnos()
        MOSTRARGRUPO()
        'If cboTipoUsuario.Text = "Visita" Then


        '    chkAdministrar.Enabled = True
        '    ChkSuperintendente.Enabled = True
        '    chkCrearlistas.Enabled = True
        '    txtPassword.Enabled = True
        '    txtAlias.Enabled = True
        'Else
        '    chkAdministrar.Enabled = False
        '    ChkSuperintendente.Enabled = False
        '    chkCrearlistas.Enabled = False
        '    txtPassword.Enabled = False
        '    txtAlias.Enabled = False
        'End If
        'txtIdUsario.Visible = False
        'cnn.conexion()'MostrarDatos()
    End Sub
    'MOSTRAR GRUPO
    Private Sub MOSTRARGRUPO()
        Dim FUN As New fUsuario
        Dim db As New fUsuario
        cbxGrupo.DataSource = db.mostrarGrupo
        cbxGrupo.ValueMember = "Id"
        cbxGrupo.DisplayMember = "Descripcion"
    End Sub

    'BOTON GUARDAR
    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click

        If txtNombre.Text <> "" And txtCodigo.Text <> "" And txtapellido.Text <> "" And txtPassword.Text <> "" Then
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
                    dts.gusuarionick = txtAlias.Text
                    dts.gpassword = txtPassword.Text
                    dts.gtipousuario = cboTipoUsuario.Text
                    'dts.gpermisoagregar = chkAgregar
                    dts.gpermisoagregar = chkAgregar.CheckState
                    'dts.gpermisomodificar = chkModificar
                    dts.gpermisomodificar = chkModificar.CheckState
                    'dts.gpermisoeliminar = chkEliminar
                    dts.gpermisoeliminar = chkEliminar.CheckState
                    'dts.gpermisocrealista = chkCrearlistas
                    dts.gpermisocrealista = chkCrearlistas.CheckState
                    'dts.gpermisococina = chkCocina
                    dts.gpermisococina = chkCocina.CheckState
                    dts.gpermisodigitador = chkDigitador.CheckState
                    'dts.getPermiso1 = CheckBoxPermiso1.Checked.ToString
                    'dts.persmiso = CheckBox1.CheckState
                    'dts.gpermisotransportista = chkTransportista
                    'MsgBox(cbodepartamento.SelectedValue)
                    dts.gpermisotransportista = chkTransportista.CheckState
                    dts.giddepartamento = cbodepartamento.SelectedValue
                    dts.gestado = estadousuario
                    dts.gfechacreacion = Today.Date
                    dts.gfechamodificacion = Today.Date
                    dts.gidturno = CbxTurno.SelectedValue
                    dts.gPermisoSuperintendente = ChkSuperintendente.CheckState
                    dts.gValidaPeticion = ChkvalidaPeticion.CheckState
                    dts.gNumeroGrupo = cbxGrupo.SelectedValue
                    'revisar PROBAR (its ok 5/03/19
                    dts.gfechacontrato = dtpFechaContrato.Value.Date 'Date.ToString("yyyy-MM-dd") 'Esto estaba cambiando
                    If func.InsertarUser(dts) = True Then
                        limpiar()
                        MsgBox("Usuario Registrado")
                        eventomostrar()


                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)

                End Try

            End If
        Else
            MsgBox("No puede dejaar campos obliagtorios como vacios", MsgBoxStyle.Critical)
        End If


    End Sub
    'Private Sub bloquear()
    '    If cboTipoUsuario.Text = "Seleccione Tipo de Usuario" Then
    '        btnModificar.Enabled = False
    '    Else
    '        btnModificar.Enabled = True





    '    End If
    'End Sub


    'limpiar textbox
    Private Sub limpiar()
        txtsecuencial.Text = ""
        txtCodigo.Text = ""
        txtNombre.Text = ""
        txtapellido.Text = ""
        txtPassword.Text = ""
        txtAlias.Text = ""
        cbodepartamento.Text = ""
        cboTipoUsuario.Text = "Seleccione Tipo de Usuario"
        chkAgregar.CheckState = 0
        chkAdministrar.CheckState = 0
        chkCocina.CheckState = 0
        chkDigitador.CheckState = 0
        chkEliminar.CheckState = 0
        ChkSuperintendente.CheckState = 0
        chkCrearlistas.CheckState = 0
        chkTransportista.CheckState = 0

        'txtEstado.Text = ""

    End Sub
    'DATAGRID
    Private Sub eventomostrar()

        Try
            'variable "func" para solicitar la funcion fUsuario (instancia) con la variable amarro a la clase fUsuario
            'luego esa variable me permiter utilizar las funciones de la clase de fUsuario

            Dim func As New fUsuario

            'llamando funcion mostrar "dt" que se encuentra en la clase fUsuario
            'y que esta instancia con vaiable func
            dt = func.mostrar
            dgvusuario.DataSource = dt
            'si 
            'If dt.Rows.Count < 0 Then
            '    dgvusuario.DataSource = dt
            '    txtBuscar.Enabled = True
            '    dgvusuario.ColumnHeadersVisible = True

            'Else
            '    MessageBox.Show("No hay datos que mostrar")
            'End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    'EVENTO OCULTA COLUMNA DEL DATAGRID works
    Private Sub ocultar_columnas()
        ' dgvusuario.Columns(0).Visible = False

        'buscar()
    End Sub

    'Public Sub MostrarDatos()
    ' .Consulta("select * from Usuario", "Usuario")
    'datagridusuario.DataSource = con.ds.Tables("Usuario")
    'End Sub

    Private Sub buscar()
        Try

            Dim ds As New DataSet
            ds.Tables.Add(dt.Copy)
            Dim dv As New DataView(ds.Tables(0))

            dv.RowFilter = cbobuscarpor.Text & " like'" & txtBuscar.Text & "%'"

            If dv.Count <> 0 Then
                dgvusuario.DataSource = dv
                ocultar_columnas()

            Else
                dgvusuario.DataSource = Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtcodigo_TextChanged(sender As Object, e As EventArgs) Handles txtCodigo.TextChanged
        If txtCodigo.TextLength > 4 Then
            ErrorIcon.SetError(txtCodigo, "el numero maximo es de 4 digitos")
            txtCodigo.Clear()


        End If
    End Sub
    'Comprobacion de campos comprobando que no esten vacios
    Private Sub txtcodigo_Validating(sender As Object, e As CancelEventArgs) Handles txtCodigo.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorIcon.SetError(sender, "")
        Else
            Me.ErrorIcon.SetError(sender, "Este campo debe llenarse")

        End If
    End Sub

    Private Sub txtnombre_TextChanged(sender As Object, e As EventArgs) Handles txtNombre.TextChanged

    End Sub

    Private Sub txtnombre_Validating(sender As Object, e As CancelEventArgs) Handles txtNombre.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorIcon.SetError(sender, "")
        Else
            Me.ErrorIcon.SetError(sender, "Este campo debe llenarse")

        End If
    End Sub

    Private Sub txtapellido_TextChanged(sender As Object, e As EventArgs) Handles txtapellido.TextChanged

    End Sub

    Private Sub txtapellido_Validating(sender As Object, e As CancelEventArgs) Handles txtapellido.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorIcon.SetError(sender, "")
        Else
            Me.ErrorIcon.SetError(sender, "Este campo debe llenarse")

        End If
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged

    End Sub

    'Private Sub TextBox2_Validating(sender As Object, e As CancelEventArgs) Handles txtPassword.Validating
    '    If DirectCast(sender, TextBox).Text.Length > 0 Then
    '        Me.ErrorIcon.SetError(sender, "")
    '    Else
    '        Me.ErrorIcon.SetError(sender, "Este campo debe llenarse")

    '    End If
    'End Sub

    'Private Sub ocultarbtn()
    '    btnHabilitar.Visible = True
    '    btnInhabilitar.Visible = False
    '    txtEstado.Text = ""

    'End Sub
    'BOTONES MANDAR BALOR A TXT ESTADO Y QUE GUARDE DICHO VALOR
    'Private Sub btnInhabilitar_Click(sender As Object, e As EventArgs) Handles btnInhabilitar.Click

    '    txtEstado.Text = "Inhabilitado"

    'End Sub

    'Private Sub btnHabilitar_Click(sender As Object, e As EventArgs) Handles btnHabilitar.Click
    '    txtEstado.Text = "Habilitado"
    'End Sub
    'CARGAR POR PARAMETROS LOS DEP DE LA BASE en un cbx
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

    'Private Sub mostrarturnosps()
    '    Dim db As New Fdepartamento
    '    cbodepartamento.DataSource = db.mostrardepartamentos
    '    cbodepartamento.ValueMember = "ID"
    '    cbodepartamento.DisplayMember = "Nombre"
    'End Sub
    'Alva
    'Private Sub chkAgregar_CheckedChanged(sender As Object, e As EventArgs) Handles chkAgregar.CheckedChanged
    '    If chkAgregar.CheckState = CheckState.Checked Then
    '        PermisoAgregar = "True"
    '        ' PermisoAgregar = 1
    '    Else
    '        PermisoAgregar = "False"
    '    End If
    'End Sub
    'Modificado
    Private Sub chkAgregar_CheckedChanged(sender As Object, e As EventArgs) Handles chkAgregar.CheckedChanged
        If chkAgregar.CheckState = CheckState.Checked Then
            PermisoAgregar = 1
            ' PermisoAgregar = 1
        Else
            PermisoAgregar = 0
        End If
    End Sub

    Private Sub chkModificar_CheckedChanged(sender As Object, e As EventArgs) Handles chkModificar.CheckedChanged
        If chkModificar.CheckState = CheckState.Checked Then
            PermisoModificar = 1
            ' PermisoAgregar = 1
        Else
            PermisoModificar = 0
        End If
    End Sub

    Private Sub chkEliminar_CheckedChanged(sender As Object, e As EventArgs) Handles chkEliminar.CheckedChanged
        If chkEliminar.CheckState = CheckState.Checked Then
            PermisoEliminar = 1
        Else
            PermisoEliminar = 0
        End If
    End Sub

    Private Sub chkAdministrar_CheckedChanged(sender As Object, e As EventArgs) Handles chkAdministrar.CheckedChanged
        If chkAdministrar.CheckState = CheckState.Checked Then
            PermisoAdministrar = 1
        Else
            PermisoAdministrar = 0
        End If
    End Sub

    Private Sub chkCrearlistas_CheckedChanged(sender As Object, e As EventArgs) Handles chkCrearlistas.CheckedChanged
        If chkCrearlistas.CheckState = CheckState.Checked Then
            PermisoCrealista = 1
        Else
            PermisoCrealista = 0
        End If
    End Sub

    Private Sub chkCocina_CheckedChanged(sender As Object, e As EventArgs) Handles chkCocina.CheckedChanged
        If chkCocina.CheckState = CheckState.Checked Then
            PermisoCocina = 1
        Else
            PermisoCocina = 0

        End If
    End Sub

    Private Sub chkDigitador_CheckedChanged(sender As Object, e As EventArgs) Handles chkDigitador.CheckedChanged
        If chkDigitador.CheckState = CheckState.Checked Then
            PermisoDigitador = 1
        Else
            PermisoDigitador = 0
        End If
    End Sub

    Private Sub chkTransportista_CheckedChanged(sender As Object, e As EventArgs) Handles chkTransportista.CheckedChanged
        If chkTransportista.CheckState = CheckState.Checked Then
            PermisoTransportista = 1
        Else
            PermisoTransportista = 0

        End If
    End Sub
    'TAL PARECE ESTE NO SE VA A UTILIZAR...
    Private Sub btnInhabilitar_Click(sender As Object, e As EventArgs) Handles btnInhabilitar.Click

        Dim PRIMERNOMBRE As String = txtNombre.Text
        Dim APELLIDO As String = txtapellido.Text
        NOMBRECOMPLETO = (PRIMERNOMBRE + " " + APELLIDO).ToString
        MsgBox(NOMBRECOMPLETO)
        If txtCodigo.Text = "" Then
            MsgBox("Debe seleccionar un usuario para poder inactivarlo", MsgBoxStyle.Critical)
        Else
            Me.SendToBack()
            FrmInactivaactivauser.Show()
            codigousuario = txtCodigo.Text
            NombreUsuario = txtNombre.Text
        End If


    End Sub
    'COMBOBOX HABILITACION E INHAVILITACION DE USARIOS
    Private Sub ESTADO()
        If cboEstado.Text = "ACTIVO" Then
            estadousuario = 1
        Else
            If cboEstado.Text = "INACTIVO" Then
                estadousuario = 0
            End If
        End If
    End Sub
    'LLENAR COLUMNAS AUTOMATICAMENTE CUANDO SE SELECIONE FILA DE DATA GRID
    Private Sub LlenarTextBox()
        Try
            'TXT
            txtsecuencial.Text = dgvusuario.CurrentRow.Cells(0).Value
            txtCodigo.Text = dgvusuario.CurrentRow.Cells(1).Value
            txtNombre.Text = dgvusuario.CurrentRow.Cells(2).Value
            txtapellido.Text = dgvusuario.CurrentRow.Cells(3).Value
            txtAlias.Text = dgvusuario.CurrentRow.Cells(4).Value
            txtPassword.Text = dgvusuario.CurrentRow.Cells(5).Value
            'COMBO
            cbodepartamento.Text = dgvusuario.CurrentRow.Cells(15).Value
            'cboEstado.Text = dgvusuario.CurrentRow.Cells(16).Value
            'MsgBox(dgvusuario.CurrentRow.Cells(17).Value)
            'MsgBox(dgvusuario.CurrentRow.Cells(18).Value)
            dtpFechaContrato.Value = dgvusuario.CurrentRow.Cells(19).Value
            cboTipoUsuario.Text = dgvusuario.CurrentRow.Cells(6).Value
            CbxTurno.Text = dgvusuario.CurrentRow.Cells(21).Value
            'CHECKS
            chkAgregar.CheckState = dgvusuario.CurrentRow.Cells(7).Value
            chkModificar.CheckState = dgvusuario.CurrentRow.Cells(8).Value
            chkEliminar.CheckState = dgvusuario.CurrentRow.Cells(9).Value
            chkAdministrar.CheckState = dgvusuario.CurrentRow.Cells(10).Value
            chkCrearlistas.CheckState = dgvusuario.CurrentRow.Cells(11).Value
            chkCocina.CheckState = dgvusuario.CurrentRow.Cells(12).Value
            chkDigitador.CheckState = dgvusuario.CurrentRow.Cells(13).Value
            chkTransportista.CheckState = dgvusuario.CurrentRow.Cells(14).Value
            ChkSuperintendente.CheckState = dgvusuario.CurrentRow.Cells(22).Value
            ChkvalidaPeticion.CheckState = dgvusuario.CurrentRow.Cells(23).Value
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub dgvusuario_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvusuario.CellContentClick


    End Sub

    Private Sub dgvusuario_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvusuario.CellClick
        LlenarTextBox()
        ocultar_columnas()
        'buscar()
    End Sub
    'BOTON MODIFICAR
    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        If txtNombre.Text <> "" And txtCodigo.Text <> "" And txtapellido.Text <> "" And txtPassword.Text <> "" Then

            Try
                Dim dts As New vUsuario
                Dim func As New fUsuario

                dts.gidusuario = txtsecuencial.Text
                dts.gcodigousuario = txtCodigo.Text
                dts.gnombre = txtNombre.Text
                dts.gapellido = txtapellido.Text
                dts.gusuarionick = txtAlias.Text
                dts.gpassword = txtPassword.Text
                dts.gtipousuario = cboTipoUsuario.Text

                'CheckBox

                dts.gpermisoagregar = chkAgregar.CheckState
                dts.gpermisomodificar = chkModificar.CheckState
                dts.gpermisoeliminar = chkEliminar.CheckState
                dts.gpermisocrealista = chkCrearlistas.CheckState
                dts.gpermisoadmin = chkAdministrar.CheckState
                dts.gpermisococina = chkCocina.CheckState
                dts.gpermisodigitador = chkDigitador.CheckState

                MsgBox(cbodepartamento.SelectedValue)
                dts.gpermisotransportista = chkTransportista.CheckState
                dts.giddepartamento = cbodepartamento.SelectedValue
                dts.gestado = estadousuario
                dts.gfechacreacion = Today.Date
                dts.gfechamodificacion = Today.Date

                dts.gfechacontrato = dtpFechaContrato.Value.Date '.ToString("yyyy-MM-dd")
                dts.gidturno = CbxTurno.SelectedValue
                dts.gPermisoSuperintendente = ChkSuperintendente.CheckState
                dts.gValidaPeticion = ChkvalidaPeticion.CheckState
                dts.gNumeroGrupo = cbxGrupo.SelectedValue
                If func.ModificarUsuario(dts) = True Then
                    MsgBox("Modificado correctamente")
                    limpiar()
                    eventomostrar()
                Else
                    MsgBox("fUCK U")

                End If
            Catch ex As Exception
                MsgBox(ex.Message)

            End Try

        End If


    End Sub
    'BOTON ELIMINAR
    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If txtsecuencial.Text <> "" Then
            Dim fun As New fUsuario
            Dim dts As New vUsuario

            dts.gidusuario = txtsecuencial.Text
            If fun.EliminarUsuario(dts) = True Then
                limpiar()
                MsgBox("Usuario ha sido eliminado")
            Else
                MsgBox("")
            End If
        End If

    End Sub

    Private Sub txtIdUsario_TextChanged(sender As Object, e As EventArgs) Handles txtsecuencial.TextChanged
        'txtIdUsario.Visible = False

    End Sub

    Private Sub btnHabilitar_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub cboTipoUsuario_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTipoUsuario.SelectedIndexChanged

    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        buscar()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        eventomostrar()

    End Sub

    Private Sub cbodepartamento_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbodepartamento.SelectedIndexChanged

    End Sub

    Private Sub ChkSuperintendente_CheckedChanged(sender As Object, e As EventArgs) Handles ChkSuperintendente.CheckedChanged
        If ChkSuperintendente.CheckState = CheckState.Checked Then
            PermisoSuperintendente = 1
        Else
            PermisoSuperintendente = 0

        End If
    End Sub

    Private Sub FrmAdmin_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        FrmMenu.Show()
    End Sub

    Private Sub cbobuscarpor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbobuscarpor.SelectedIndexChanged

    End Sub

    Private Sub ChkvalidaPeticion_CheckedChanged(sender As Object, e As EventArgs) Handles ChkvalidaPeticion.CheckedChanged
        If ChkvalidaPeticion.CheckState = CheckState.Checked Then
            validapeticion = 1
        Else
            validapeticion = 0
        End If
    End Sub

    Private Sub txtxlimpiar_Click(sender As Object, e As EventArgs) Handles txtxlimpiar.Click
        limpiar()
    End Sub
    Private Sub validaanchocodigouser()
        If txtCodigo.TextLength < 4 Then
            ErrorIcon.SetError(txtCodigo, "El código de usuario debe contener como minimo 4 dígitos")
        End If
    End Sub
End Class
