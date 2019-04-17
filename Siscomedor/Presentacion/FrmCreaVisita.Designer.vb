<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCreaVisita
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCreaVisita))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnAtras = New System.Windows.Forms.Button()
        Me.btnGuardarVisita = New System.Windows.Forms.Button()
        Me.ChkvalidaPeticion = New System.Windows.Forms.CheckBox()
        Me.cbxGrupo = New System.Windows.Forms.ComboBox()
        Me.btnInhabilitar = New System.Windows.Forms.Button()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.txtapellido = New System.Windows.Forms.TextBox()
        Me.lblnombre = New System.Windows.Forms.Label()
        Me.lblcodigo = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.cbodepartamento = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtxlimpiar = New System.Windows.Forms.Button()
        Me.txtsecuencial = New System.Windows.Forms.TextBox()
        Me.txtAlias = New System.Windows.Forms.TextBox()
        Me.dtpFechaContrato = New System.Windows.Forms.DateTimePicker()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblFechaContrato = New System.Windows.Forms.Label()
        Me.lblapellido = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.cboTipoUsuario = New System.Windows.Forms.ComboBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.CbxTurno = New System.Windows.Forms.ComboBox()
        Me.lblRolUsuario = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GroupBox2.Controls.Add(Me.btnAtras)
        Me.GroupBox2.Controls.Add(Me.btnGuardarVisita)
        Me.GroupBox2.Controls.Add(Me.ChkvalidaPeticion)
        Me.GroupBox2.Controls.Add(Me.btnInhabilitar)
        Me.GroupBox2.Controls.Add(Me.txtNombre)
        Me.GroupBox2.Controls.Add(Me.txtCodigo)
        Me.GroupBox2.Controls.Add(Me.txtapellido)
        Me.GroupBox2.Controls.Add(Me.lblnombre)
        Me.GroupBox2.Controls.Add(Me.lblcodigo)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Panel5)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Panel1)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(9, 40)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GroupBox2.Size = New System.Drawing.Size(573, 398)
        Me.GroupBox2.TabIndex = 24
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Crear un Usuario Visita"
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.cbxGrupo)
        Me.Panel1.Location = New System.Drawing.Point(104, 227)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(153, 28)
        Me.Panel1.TabIndex = 45
        '
        'btnAtras
        '
        Me.btnAtras.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnAtras.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAtras.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAtras.Image = CType(resources.GetObject("btnAtras.Image"), System.Drawing.Image)
        Me.btnAtras.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnAtras.Location = New System.Drawing.Point(341, 316)
        Me.btnAtras.Name = "btnAtras"
        Me.btnAtras.Size = New System.Drawing.Size(109, 50)
        Me.btnAtras.TabIndex = 44
        Me.btnAtras.Text = "Cancelar"
        Me.btnAtras.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAtras.UseVisualStyleBackColor = True
        '
        'btnGuardarVisita
        '
        Me.btnGuardarVisita.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnGuardarVisita.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnGuardarVisita.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardarVisita.Image = CType(resources.GetObject("btnGuardarVisita.Image"), System.Drawing.Image)
        Me.btnGuardarVisita.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnGuardarVisita.Location = New System.Drawing.Point(131, 316)
        Me.btnGuardarVisita.Name = "btnGuardarVisita"
        Me.btnGuardarVisita.Size = New System.Drawing.Size(109, 50)
        Me.btnGuardarVisita.TabIndex = 42
        Me.btnGuardarVisita.Text = "Guardar"
        Me.btnGuardarVisita.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnGuardarVisita.UseVisualStyleBackColor = True
        '
        'ChkvalidaPeticion
        '
        Me.ChkvalidaPeticion.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ChkvalidaPeticion.AutoSize = True
        Me.ChkvalidaPeticion.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkvalidaPeticion.Location = New System.Drawing.Point(324, 227)
        Me.ChkvalidaPeticion.Name = "ChkvalidaPeticion"
        Me.ChkvalidaPeticion.Size = New System.Drawing.Size(117, 23)
        Me.ChkvalidaPeticion.TabIndex = 41
        Me.ChkvalidaPeticion.Text = "Valida Peticion"
        Me.ChkvalidaPeticion.UseVisualStyleBackColor = True
        '
        'cbxGrupo
        '
        Me.cbxGrupo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cbxGrupo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbxGrupo.FormattingEnabled = True
        Me.cbxGrupo.Location = New System.Drawing.Point(-1, 0)
        Me.cbxGrupo.Name = "cbxGrupo"
        Me.cbxGrupo.Size = New System.Drawing.Size(152, 27)
        Me.cbxGrupo.TabIndex = 40
        '
        'btnInhabilitar
        '
        Me.btnInhabilitar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnInhabilitar.BackColor = System.Drawing.Color.White
        Me.btnInhabilitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInhabilitar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInhabilitar.Location = New System.Drawing.Point(321, 135)
        Me.btnInhabilitar.Name = "btnInhabilitar"
        Me.btnInhabilitar.Size = New System.Drawing.Size(120, 43)
        Me.btnInhabilitar.TabIndex = 23
        Me.btnInhabilitar.Text = "CAMBIAR " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "ESTADO"
        Me.btnInhabilitar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnInhabilitar.UseVisualStyleBackColor = False
        '
        'txtNombre
        '
        Me.txtNombre.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNombre.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Location = New System.Drawing.Point(103, 119)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(154, 25)
        Me.txtNombre.TabIndex = 2
        '
        'txtCodigo
        '
        Me.txtCodigo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodigo.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigo.Location = New System.Drawing.Point(104, 65)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(89, 25)
        Me.txtCodigo.TabIndex = 1
        '
        'txtapellido
        '
        Me.txtapellido.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtapellido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtapellido.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtapellido.Location = New System.Drawing.Point(104, 173)
        Me.txtapellido.Name = "txtapellido"
        Me.txtapellido.Size = New System.Drawing.Size(153, 25)
        Me.txtapellido.TabIndex = 3
        '
        'lblnombre
        '
        Me.lblnombre.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblnombre.AutoSize = True
        Me.lblnombre.BackColor = System.Drawing.Color.Transparent
        Me.lblnombre.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnombre.Location = New System.Drawing.Point(100, 102)
        Me.lblnombre.Name = "lblnombre"
        Me.lblnombre.Size = New System.Drawing.Size(60, 19)
        Me.lblnombre.TabIndex = 5
        Me.lblnombre.Text = "Nombre"
        '
        'lblcodigo
        '
        Me.lblcodigo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblcodigo.AutoSize = True
        Me.lblcodigo.BackColor = System.Drawing.Color.Transparent
        Me.lblcodigo.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcodigo.Location = New System.Drawing.Point(100, 48)
        Me.lblcodigo.Name = "lblcodigo"
        Me.lblcodigo.Size = New System.Drawing.Size(54, 19)
        Me.lblcodigo.TabIndex = 0
        Me.lblcodigo.Text = "Codigo"
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(102, 156)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 19)
        Me.Label5.TabIndex = 34
        Me.Label5.Text = "Apellido"
        '
        'Panel5
        '
        Me.Panel5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel5.BackColor = System.Drawing.Color.White
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Controls.Add(Me.cbodepartamento)
        Me.Panel5.Location = New System.Drawing.Point(319, 62)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(187, 28)
        Me.Panel5.TabIndex = 38
        '
        'cbodepartamento
        '
        Me.cbodepartamento.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cbodepartamento.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbodepartamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbodepartamento.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbodepartamento.FormattingEnabled = True
        Me.cbodepartamento.Location = New System.Drawing.Point(1, 1)
        Me.cbodepartamento.Name = "cbodepartamento"
        Me.cbodepartamento.Size = New System.Drawing.Size(185, 25)
        Me.cbodepartamento.TabIndex = 6
        Me.cbodepartamento.Text = "Asigne Departamento"
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(317, 42)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(95, 19)
        Me.Label6.TabIndex = 35
        Me.Label6.Text = "Departamento"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(105, 210)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 19)
        Me.Label2.TabIndex = 43
        Me.Label2.Text = "Grupo "
        '
        'txtxlimpiar
        '
        Me.txtxlimpiar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtxlimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.txtxlimpiar.Location = New System.Drawing.Point(253, 298)
        Me.txtxlimpiar.Name = "txtxlimpiar"
        Me.txtxlimpiar.Size = New System.Drawing.Size(75, 40)
        Me.txtxlimpiar.TabIndex = 39
        Me.txtxlimpiar.Text = "[Limpiar]"
        Me.txtxlimpiar.UseVisualStyleBackColor = True
        Me.txtxlimpiar.Visible = False
        '
        'txtsecuencial
        '
        Me.txtsecuencial.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtsecuencial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtsecuencial.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsecuencial.Location = New System.Drawing.Point(125, 118)
        Me.txtsecuencial.Name = "txtsecuencial"
        Me.txtsecuencial.ReadOnly = True
        Me.txtsecuencial.Size = New System.Drawing.Size(50, 25)
        Me.txtsecuencial.TabIndex = 31
        Me.txtsecuencial.Visible = False
        '
        'txtAlias
        '
        Me.txtAlias.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtAlias.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAlias.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAlias.Location = New System.Drawing.Point(184, 119)
        Me.txtAlias.Name = "txtAlias"
        Me.txtAlias.Size = New System.Drawing.Size(132, 25)
        Me.txtAlias.TabIndex = 24
        Me.txtAlias.Visible = False
        '
        'dtpFechaContrato
        '
        Me.dtpFechaContrato.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.dtpFechaContrato.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaContrato.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaContrato.Location = New System.Drawing.Point(186, 280)
        Me.dtpFechaContrato.Name = "dtpFechaContrato"
        Me.dtpFechaContrato.Size = New System.Drawing.Size(130, 25)
        Me.dtpFechaContrato.TabIndex = 25
        Me.dtpFechaContrato.Visible = False
        '
        'txtPassword
        '
        Me.txtPassword.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPassword.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(184, 164)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(132, 25)
        Me.txtPassword.TabIndex = 17
        Me.txtPassword.UseSystemPasswordChar = True
        Me.txtPassword.Visible = False
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(181, 147)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 19)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Contraseña"
        Me.Label1.Visible = False
        '
        'lblFechaContrato
        '
        Me.lblFechaContrato.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblFechaContrato.AutoSize = True
        Me.lblFechaContrato.BackColor = System.Drawing.Color.Transparent
        Me.lblFechaContrato.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaContrato.Location = New System.Drawing.Point(182, 263)
        Me.lblFechaContrato.Name = "lblFechaContrato"
        Me.lblFechaContrato.Size = New System.Drawing.Size(123, 19)
        Me.lblFechaContrato.TabIndex = 26
        Me.lblFechaContrato.Text = "Fecha de Contrato"
        Me.lblFechaContrato.Visible = False
        '
        'lblapellido
        '
        Me.lblapellido.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblapellido.AutoSize = True
        Me.lblapellido.BackColor = System.Drawing.Color.Transparent
        Me.lblapellido.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblapellido.Location = New System.Drawing.Point(181, 102)
        Me.lblapellido.Name = "lblapellido"
        Me.lblapellido.Size = New System.Drawing.Size(71, 19)
        Me.lblapellido.TabIndex = 4
        Me.lblapellido.Text = "Nickname"
        Me.lblapellido.Visible = False
        '
        'Panel3
        '
        Me.Panel3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.cboTipoUsuario)
        Me.Panel3.Location = New System.Drawing.Point(185, 207)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(122, 29)
        Me.Panel3.TabIndex = 28
        Me.Panel3.Visible = False
        '
        'cboTipoUsuario
        '
        Me.cboTipoUsuario.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cboTipoUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboTipoUsuario.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTipoUsuario.FormattingEnabled = True
        Me.cboTipoUsuario.Items.AddRange(New Object() {"Visita"})
        Me.cboTipoUsuario.Location = New System.Drawing.Point(3, 0)
        Me.cboTipoUsuario.Name = "cboTipoUsuario"
        Me.cboTipoUsuario.Size = New System.Drawing.Size(116, 27)
        Me.cboTipoUsuario.TabIndex = 29
        Me.cboTipoUsuario.Text = "Visita"
        '
        'Panel4
        '
        Me.Panel4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel4.BackColor = System.Drawing.Color.White
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.CbxTurno)
        Me.Panel4.Location = New System.Drawing.Point(186, 325)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(126, 28)
        Me.Panel4.TabIndex = 37
        Me.Panel4.Visible = False
        '
        'CbxTurno
        '
        Me.CbxTurno.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CbxTurno.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CbxTurno.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbxTurno.FormattingEnabled = True
        Me.CbxTurno.Location = New System.Drawing.Point(1, 1)
        Me.CbxTurno.Name = "CbxTurno"
        Me.CbxTurno.Size = New System.Drawing.Size(121, 23)
        Me.CbxTurno.TabIndex = 30
        '
        'lblRolUsuario
        '
        Me.lblRolUsuario.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblRolUsuario.AutoSize = True
        Me.lblRolUsuario.BackColor = System.Drawing.Color.Transparent
        Me.lblRolUsuario.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRolUsuario.Location = New System.Drawing.Point(187, 185)
        Me.lblRolUsuario.Name = "lblRolUsuario"
        Me.lblRolUsuario.Size = New System.Drawing.Size(30, 19)
        Me.lblRolUsuario.TabIndex = 36
        Me.lblRolUsuario.Text = "Rol"
        Me.lblRolUsuario.Visible = False
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(182, 309)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 19)
        Me.Label4.TabIndex = 33
        Me.Label4.Text = "Turno"
        Me.Label4.Visible = False
        '
        'FrmCreaVisita
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(590, 450)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblRolUsuario)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.lblapellido)
        Me.Controls.Add(Me.lblFechaContrato)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.dtpFechaContrato)
        Me.Controls.Add(Me.txtAlias)
        Me.Controls.Add(Me.txtsecuencial)
        Me.Controls.Add(Me.txtxlimpiar)
        Me.Name = "FrmCreaVisita"
        Me.Text = ".: CREAR VISITA :."
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnAtras As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents btnGuardarVisita As Button
    Friend WithEvents ChkvalidaPeticion As CheckBox
    Friend WithEvents cbxGrupo As ComboBox
    Friend WithEvents txtxlimpiar As Button
    Friend WithEvents btnInhabilitar As Button
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtsecuencial As TextBox
    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents txtAlias As TextBox
    Friend WithEvents txtapellido As TextBox
    Friend WithEvents dtpFechaContrato As DateTimePicker
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cbodepartamento As ComboBox
    Friend WithEvents lblnombre As Label
    Friend WithEvents lblcodigo As Label
    Friend WithEvents lblFechaContrato As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblapellido As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents cboTipoUsuario As ComboBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents CbxTurno As ComboBox
    Friend WithEvents lblRolUsuario As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel1 As Panel
End Class
