<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEditaVisitas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmEditaVisitas))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cbxGrupo = New System.Windows.Forms.ComboBox()
        Me.btnguardar = New System.Windows.Forms.Button()
        Me.ChkvalidaPeticion = New System.Windows.Forms.CheckBox()
        Me.btnInhabilitar = New System.Windows.Forms.Button()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtsecuencial = New System.Windows.Forms.TextBox()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.txtAlias = New System.Windows.Forms.TextBox()
        Me.txtapellido = New System.Windows.Forms.TextBox()
        Me.dtpFechaContrato = New System.Windows.Forms.DateTimePicker()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbodepartamento = New System.Windows.Forms.ComboBox()
        Me.lblnombre = New System.Windows.Forms.Label()
        Me.lblcodigo = New System.Windows.Forms.Label()
        Me.lblFechaContrato = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblapellido = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.cboTipoUsuario = New System.Windows.Forms.ComboBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.CbxTurno = New System.Windows.Forms.ComboBox()
        Me.lblRolUsuario = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnnNuevoUsuarioVisita = New System.Windows.Forms.Button()
        Me.dgvmiravisitas = New System.Windows.Forms.DataGridView()
        Me.btnEditarVisita = New System.Windows.Forms.Button()
        Me.btnEliminarVisita = New System.Windows.Forms.Button()
        Me.cbobuscarpor = New System.Windows.Forms.ComboBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.GroupBox2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.dgvmiravisitas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GroupBox2.Controls.Add(Me.Panel1)
        Me.GroupBox2.Controls.Add(Me.btnguardar)
        Me.GroupBox2.Controls.Add(Me.ChkvalidaPeticion)
        Me.GroupBox2.Controls.Add(Me.btnInhabilitar)
        Me.GroupBox2.Controls.Add(Me.txtNombre)
        Me.GroupBox2.Controls.Add(Me.txtsecuencial)
        Me.GroupBox2.Controls.Add(Me.txtCodigo)
        Me.GroupBox2.Controls.Add(Me.txtAlias)
        Me.GroupBox2.Controls.Add(Me.txtapellido)
        Me.GroupBox2.Controls.Add(Me.dtpFechaContrato)
        Me.GroupBox2.Controls.Add(Me.txtPassword)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.cbodepartamento)
        Me.GroupBox2.Controls.Add(Me.lblnombre)
        Me.GroupBox2.Controls.Add(Me.lblcodigo)
        Me.GroupBox2.Controls.Add(Me.lblFechaContrato)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.lblapellido)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Panel3)
        Me.GroupBox2.Controls.Add(Me.Panel4)
        Me.GroupBox2.Controls.Add(Me.lblRolUsuario)
        Me.GroupBox2.Controls.Add(Me.Panel5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(63, 41)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GroupBox2.Size = New System.Drawing.Size(459, 315)
        Me.GroupBox2.TabIndex = 23
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "VISITAS"
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.cbxGrupo)
        Me.Panel1.Location = New System.Drawing.Point(285, 43)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(122, 28)
        Me.Panel1.TabIndex = 44
        '
        'cbxGrupo
        '
        Me.cbxGrupo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cbxGrupo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbxGrupo.FormattingEnabled = True
        Me.cbxGrupo.Location = New System.Drawing.Point(0, 0)
        Me.cbxGrupo.Name = "cbxGrupo"
        Me.cbxGrupo.Size = New System.Drawing.Size(121, 27)
        Me.cbxGrupo.TabIndex = 40
        '
        'btnguardar
        '
        Me.btnguardar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnguardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnguardar.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnguardar.Image = CType(resources.GetObject("btnguardar.Image"), System.Drawing.Image)
        Me.btnguardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnguardar.Location = New System.Drawing.Point(478, 279)
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.Size = New System.Drawing.Size(109, 50)
        Me.btnguardar.TabIndex = 42
        Me.btnguardar.Text = "Guardar"
        Me.btnguardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnguardar.UseVisualStyleBackColor = True
        '
        'ChkvalidaPeticion
        '
        Me.ChkvalidaPeticion.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ChkvalidaPeticion.AutoSize = True
        Me.ChkvalidaPeticion.Location = New System.Drawing.Point(286, 90)
        Me.ChkvalidaPeticion.Name = "ChkvalidaPeticion"
        Me.ChkvalidaPeticion.Size = New System.Drawing.Size(113, 23)
        Me.ChkvalidaPeticion.TabIndex = 41
        Me.ChkvalidaPeticion.Text = " Come Afuera"
        Me.ChkvalidaPeticion.UseVisualStyleBackColor = True
        '
        'btnInhabilitar
        '
        Me.btnInhabilitar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnInhabilitar.BackColor = System.Drawing.Color.White
        Me.btnInhabilitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInhabilitar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInhabilitar.Location = New System.Drawing.Point(77, 259)
        Me.btnInhabilitar.Name = "btnInhabilitar"
        Me.btnInhabilitar.Size = New System.Drawing.Size(109, 50)
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
        Me.txtNombre.Location = New System.Drawing.Point(74, 91)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(177, 25)
        Me.txtNombre.TabIndex = 2
        '
        'txtsecuencial
        '
        Me.txtsecuencial.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtsecuencial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtsecuencial.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsecuencial.Location = New System.Drawing.Point(201, 46)
        Me.txtsecuencial.Name = "txtsecuencial"
        Me.txtsecuencial.ReadOnly = True
        Me.txtsecuencial.Size = New System.Drawing.Size(50, 25)
        Me.txtsecuencial.TabIndex = 31
        '
        'txtCodigo
        '
        Me.txtCodigo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodigo.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigo.Location = New System.Drawing.Point(75, 46)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(120, 25)
        Me.txtCodigo.TabIndex = 1
        '
        'txtAlias
        '
        Me.txtAlias.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtAlias.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAlias.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAlias.Location = New System.Drawing.Point(466, 10)
        Me.txtAlias.Name = "txtAlias"
        Me.txtAlias.Size = New System.Drawing.Size(132, 25)
        Me.txtAlias.TabIndex = 24
        '
        'txtapellido
        '
        Me.txtapellido.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtapellido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtapellido.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtapellido.Location = New System.Drawing.Point(75, 141)
        Me.txtapellido.Name = "txtapellido"
        Me.txtapellido.Size = New System.Drawing.Size(176, 25)
        Me.txtapellido.TabIndex = 3
        '
        'dtpFechaContrato
        '
        Me.dtpFechaContrato.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.dtpFechaContrato.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaContrato.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaContrato.Location = New System.Drawing.Point(468, 171)
        Me.dtpFechaContrato.Name = "dtpFechaContrato"
        Me.dtpFechaContrato.Size = New System.Drawing.Size(130, 25)
        Me.dtpFechaContrato.TabIndex = 25
        '
        'txtPassword
        '
        Me.txtPassword.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPassword.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(466, 55)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(132, 25)
        Me.txtPassword.TabIndex = 17
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(463, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 19)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Contraseña"
        '
        'cbodepartamento
        '
        Me.cbodepartamento.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cbodepartamento.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbodepartamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbodepartamento.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbodepartamento.FormattingEnabled = True
        Me.cbodepartamento.Location = New System.Drawing.Point(78, 212)
        Me.cbodepartamento.Name = "cbodepartamento"
        Me.cbodepartamento.Size = New System.Drawing.Size(172, 25)
        Me.cbodepartamento.TabIndex = 6
        '
        'lblnombre
        '
        Me.lblnombre.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblnombre.AutoSize = True
        Me.lblnombre.BackColor = System.Drawing.Color.Transparent
        Me.lblnombre.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnombre.Location = New System.Drawing.Point(71, 74)
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
        Me.lblcodigo.Location = New System.Drawing.Point(71, 29)
        Me.lblcodigo.Name = "lblcodigo"
        Me.lblcodigo.Size = New System.Drawing.Size(54, 19)
        Me.lblcodigo.TabIndex = 0
        Me.lblcodigo.Text = "Codigo"
        '
        'lblFechaContrato
        '
        Me.lblFechaContrato.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblFechaContrato.AutoSize = True
        Me.lblFechaContrato.BackColor = System.Drawing.Color.Transparent
        Me.lblFechaContrato.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaContrato.Location = New System.Drawing.Point(464, 154)
        Me.lblFechaContrato.Name = "lblFechaContrato"
        Me.lblFechaContrato.Size = New System.Drawing.Size(123, 19)
        Me.lblFechaContrato.TabIndex = 26
        Me.lblFechaContrato.Text = "Fecha de Contrato"
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(73, 124)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 19)
        Me.Label5.TabIndex = 34
        Me.Label5.Text = "Apellido"
        '
        'lblapellido
        '
        Me.lblapellido.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblapellido.AutoSize = True
        Me.lblapellido.BackColor = System.Drawing.Color.Transparent
        Me.lblapellido.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblapellido.Location = New System.Drawing.Point(463, -7)
        Me.lblapellido.Name = "lblapellido"
        Me.lblapellido.Size = New System.Drawing.Size(71, 19)
        Me.lblapellido.TabIndex = 4
        Me.lblapellido.Text = "Nickname"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(461, 247)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 19)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "Secuencial"
        '
        'Panel3
        '
        Me.Panel3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.cboTipoUsuario)
        Me.Panel3.Location = New System.Drawing.Point(467, 98)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(122, 29)
        Me.Panel3.TabIndex = 28
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
        Me.Panel4.Location = New System.Drawing.Point(468, 216)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(126, 28)
        Me.Panel4.TabIndex = 37
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
        Me.lblRolUsuario.Location = New System.Drawing.Point(469, 76)
        Me.lblRolUsuario.Name = "lblRolUsuario"
        Me.lblRolUsuario.Size = New System.Drawing.Size(30, 19)
        Me.lblRolUsuario.TabIndex = 36
        Me.lblRolUsuario.Text = "Rol"
        '
        'Panel5
        '
        Me.Panel5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel5.BackColor = System.Drawing.Color.White
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Location = New System.Drawing.Point(76, 210)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(175, 28)
        Me.Panel5.TabIndex = 38
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(464, 200)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 19)
        Me.Label4.TabIndex = 33
        Me.Label4.Text = "Turno"
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(73, 188)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(95, 19)
        Me.Label6.TabIndex = 35
        Me.Label6.Text = "Departamento"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(281, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 19)
        Me.Label2.TabIndex = 43
        Me.Label2.Text = "Grupo "
        '
        'btnnNuevoUsuarioVisita
        '
        Me.btnnNuevoUsuarioVisita.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnnNuevoUsuarioVisita.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnnNuevoUsuarioVisita.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnnNuevoUsuarioVisita.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnnNuevoUsuarioVisita.Image = CType(resources.GetObject("btnnNuevoUsuarioVisita.Image"), System.Drawing.Image)
        Me.btnnNuevoUsuarioVisita.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnnNuevoUsuarioVisita.Location = New System.Drawing.Point(529, 60)
        Me.btnnNuevoUsuarioVisita.Name = "btnnNuevoUsuarioVisita"
        Me.btnnNuevoUsuarioVisita.Size = New System.Drawing.Size(112, 50)
        Me.btnnNuevoUsuarioVisita.TabIndex = 44
        Me.btnnNuevoUsuarioVisita.Text = "Nuevo"
        Me.btnnNuevoUsuarioVisita.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnnNuevoUsuarioVisita.UseVisualStyleBackColor = False
        '
        'dgvmiravisitas
        '
        Me.dgvmiravisitas.AllowUserToAddRows = False
        Me.dgvmiravisitas.AllowUserToDeleteRows = False
        Me.dgvmiravisitas.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.dgvmiravisitas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvmiravisitas.Location = New System.Drawing.Point(63, 362)
        Me.dgvmiravisitas.Name = "dgvmiravisitas"
        Me.dgvmiravisitas.ReadOnly = True
        Me.dgvmiravisitas.Size = New System.Drawing.Size(930, 287)
        Me.dgvmiravisitas.TabIndex = 24
        '
        'btnEditarVisita
        '
        Me.btnEditarVisita.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnEditarVisita.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnEditarVisita.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnEditarVisita.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditarVisita.Image = CType(resources.GetObject("btnEditarVisita.Image"), System.Drawing.Image)
        Me.btnEditarVisita.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnEditarVisita.Location = New System.Drawing.Point(528, 173)
        Me.btnEditarVisita.Name = "btnEditarVisita"
        Me.btnEditarVisita.Size = New System.Drawing.Size(112, 50)
        Me.btnEditarVisita.TabIndex = 45
        Me.btnEditarVisita.Text = "Editar"
        Me.btnEditarVisita.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnEditarVisita.UseVisualStyleBackColor = False
        '
        'btnEliminarVisita
        '
        Me.btnEliminarVisita.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnEliminarVisita.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnEliminarVisita.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnEliminarVisita.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminarVisita.Image = CType(resources.GetObject("btnEliminarVisita.Image"), System.Drawing.Image)
        Me.btnEliminarVisita.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnEliminarVisita.Location = New System.Drawing.Point(529, 288)
        Me.btnEliminarVisita.Name = "btnEliminarVisita"
        Me.btnEliminarVisita.Size = New System.Drawing.Size(112, 50)
        Me.btnEliminarVisita.TabIndex = 46
        Me.btnEliminarVisita.Text = "Eliminar"
        Me.btnEliminarVisita.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnEliminarVisita.UseVisualStyleBackColor = False
        '
        'cbobuscarpor
        '
        Me.cbobuscarpor.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cbobuscarpor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbobuscarpor.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbobuscarpor.FormattingEnabled = True
        Me.cbobuscarpor.Items.AddRange(New Object() {"Nombre", "Apellido"})
        Me.cbobuscarpor.Location = New System.Drawing.Point(758, 273)
        Me.cbobuscarpor.Name = "cbobuscarpor"
        Me.cbobuscarpor.Size = New System.Drawing.Size(132, 27)
        Me.cbobuscarpor.TabIndex = 47
        Me.cbobuscarpor.Text = "Nombre"
        '
        'PictureBox3
        '
        Me.PictureBox3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox3.BackColor = System.Drawing.Color.White
        Me.PictureBox3.BackgroundImage = CType(resources.GetObject("PictureBox3.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.PictureBox3.Location = New System.Drawing.Point(757, 241)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(29, 26)
        Me.PictureBox3.TabIndex = 49
        Me.PictureBox3.TabStop = False
        '
        'txtBuscar
        '
        Me.txtBuscar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBuscar.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscar.Location = New System.Drawing.Point(786, 241)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(172, 26)
        Me.txtBuscar.TabIndex = 48
        Me.txtBuscar.Tag = "BUSCAR"
        '
        'FrmEditaVisitas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1016, 693)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.txtBuscar)
        Me.Controls.Add(Me.cbobuscarpor)
        Me.Controls.Add(Me.btnnNuevoUsuarioVisita)
        Me.Controls.Add(Me.btnEliminarVisita)
        Me.Controls.Add(Me.btnEditarVisita)
        Me.Controls.Add(Me.dgvmiravisitas)
        Me.Controls.Add(Me.GroupBox2)
        Me.DoubleBuffered = True
        Me.Name = "FrmEditaVisitas"
        Me.Text = ".: CREAR VISITAS :."
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        CType(Me.dgvmiravisitas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnInhabilitar As Button
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtsecuencial As TextBox
    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents txtapellido As TextBox
    Friend WithEvents dtpFechaContrato As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents cbodepartamento As ComboBox
    Friend WithEvents lblnombre As Label
    Friend WithEvents lblcodigo As Label
    Friend WithEvents lblFechaContrato As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblapellido As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents cboTipoUsuario As ComboBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents lblRolUsuario As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents dgvmiravisitas As DataGridView
    Friend WithEvents cbxGrupo As ComboBox
    Friend WithEvents ChkvalidaPeticion As CheckBox
    Friend WithEvents btnguardar As Button
    Friend WithEvents txtAlias As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents CbxTurno As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnnNuevoUsuarioVisita As Button
    Friend WithEvents btnEditarVisita As Button
    Friend WithEvents btnEliminarVisita As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents cbobuscarpor As ComboBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents txtBuscar As TextBox
End Class
