<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmAdmin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAdmin))
        Me.lblcodigo = New System.Windows.Forms.Label()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtapellido = New System.Windows.Forms.TextBox()
        Me.lblapellido = New System.Windows.Forms.Label()
        Me.lblnombre = New System.Windows.Forms.Label()
        Me.btnguardar = New System.Windows.Forms.Button()
        Me.dgvusuario = New System.Windows.Forms.DataGridView()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.cbobuscarpor = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtxlimpiar = New System.Windows.Forms.Button()
        Me.btnInhabilitar = New System.Windows.Forms.Button()
        Me.txtsecuencial = New System.Windows.Forms.TextBox()
        Me.txtAlias = New System.Windows.Forms.TextBox()
        Me.cbodepartamento = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.cboTipoUsuario = New System.Windows.Forms.ComboBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.CbxTurno = New System.Windows.Forms.ComboBox()
        Me.lblRolUsuario = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cbxGrupo = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.dtpFechaContrato = New System.Windows.Forms.DateTimePicker()
        Me.lblFechaContrato = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.cboEstado = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.ChkvalidaPeticion = New System.Windows.Forms.CheckBox()
        Me.ChkSuperintendente = New System.Windows.Forms.CheckBox()
        Me.chkTransportista = New System.Windows.Forms.CheckBox()
        Me.chkDigitador = New System.Windows.Forms.CheckBox()
        Me.chkCocina = New System.Windows.Forms.CheckBox()
        Me.chkAdministrar = New System.Windows.Forms.CheckBox()
        Me.chkEliminar = New System.Windows.Forms.CheckBox()
        Me.chkCrearlistas = New System.Windows.Forms.CheckBox()
        Me.chkModificar = New System.Windows.Forms.CheckBox()
        Me.chkAgregar = New System.Windows.Forms.CheckBox()
        Me.ErrorIcon = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.btnEliminar = New System.Windows.Forms.Button()
        CType(Me.dgvusuario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.ErrorIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblcodigo
        '
        Me.lblcodigo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblcodigo.AutoSize = True
        Me.lblcodigo.BackColor = System.Drawing.Color.Transparent
        Me.lblcodigo.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcodigo.Location = New System.Drawing.Point(34, 62)
        Me.lblcodigo.Name = "lblcodigo"
        Me.lblcodigo.Size = New System.Drawing.Size(54, 19)
        Me.lblcodigo.TabIndex = 0
        Me.lblcodigo.Text = "Codigo"
        '
        'txtCodigo
        '
        Me.txtCodigo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodigo.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigo.Location = New System.Drawing.Point(38, 79)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(93, 25)
        Me.txtCodigo.TabIndex = 1
        '
        'txtNombre
        '
        Me.txtNombre.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNombre.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Location = New System.Drawing.Point(37, 124)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(152, 25)
        Me.txtNombre.TabIndex = 2
        '
        'txtapellido
        '
        Me.txtapellido.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtapellido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtapellido.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtapellido.Location = New System.Drawing.Point(38, 174)
        Me.txtapellido.Name = "txtapellido"
        Me.txtapellido.Size = New System.Drawing.Size(151, 25)
        Me.txtapellido.TabIndex = 3
        '
        'lblapellido
        '
        Me.lblapellido.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblapellido.AutoSize = True
        Me.lblapellido.BackColor = System.Drawing.Color.Transparent
        Me.lblapellido.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblapellido.Location = New System.Drawing.Point(34, 209)
        Me.lblapellido.Name = "lblapellido"
        Me.lblapellido.Size = New System.Drawing.Size(71, 19)
        Me.lblapellido.TabIndex = 4
        Me.lblapellido.Text = "Nickname"
        '
        'lblnombre
        '
        Me.lblnombre.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblnombre.AutoSize = True
        Me.lblnombre.BackColor = System.Drawing.Color.Transparent
        Me.lblnombre.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnombre.Location = New System.Drawing.Point(34, 107)
        Me.lblnombre.Name = "lblnombre"
        Me.lblnombre.Size = New System.Drawing.Size(60, 19)
        Me.lblnombre.TabIndex = 5
        Me.lblnombre.Text = "Nombre"
        '
        'btnguardar
        '
        Me.btnguardar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnguardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnguardar.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnguardar.Image = CType(resources.GetObject("btnguardar.Image"), System.Drawing.Image)
        Me.btnguardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnguardar.Location = New System.Drawing.Point(50, 657)
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.Size = New System.Drawing.Size(109, 50)
        Me.btnguardar.TabIndex = 10
        Me.btnguardar.Text = "Guardar"
        Me.btnguardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnguardar.UseVisualStyleBackColor = True
        '
        'dgvusuario
        '
        Me.dgvusuario.AllowUserToAddRows = False
        Me.dgvusuario.AllowUserToDeleteRows = False
        Me.dgvusuario.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.dgvusuario.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.dgvusuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvusuario.Location = New System.Drawing.Point(2, 62)
        Me.dgvusuario.Name = "dgvusuario"
        Me.dgvusuario.ReadOnly = True
        Me.dgvusuario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvusuario.Size = New System.Drawing.Size(924, 214)
        Me.dgvusuario.TabIndex = 9
        '
        'txtPassword
        '
        Me.txtPassword.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPassword.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(37, 271)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(152, 25)
        Me.txtPassword.TabIndex = 17
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(34, 254)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 19)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Contraseña"
        '
        'btnModificar
        '
        Me.btnModificar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnModificar.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificar.Image = CType(resources.GetObject("btnModificar.Image"), System.Drawing.Image)
        Me.btnModificar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnModificar.Location = New System.Drawing.Point(184, 657)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(109, 50)
        Me.btnModificar.TabIndex = 20
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.GroupBox1.Controls.Add(Me.PictureBox3)
        Me.GroupBox1.Controls.Add(Me.txtBuscar)
        Me.GroupBox1.Controls.Add(Me.dgvusuario)
        Me.GroupBox1.Controls.Add(Me.Panel6)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(47, 376)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(928, 276)
        Me.GroupBox1.TabIndex = 21
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Lista De Usuarios"
        '
        'PictureBox3
        '
        Me.PictureBox3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox3.BackColor = System.Drawing.Color.White
        Me.PictureBox3.BackgroundImage = CType(resources.GetObject("PictureBox3.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.PictureBox3.Location = New System.Drawing.Point(698, 30)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(29, 26)
        Me.PictureBox3.TabIndex = 23
        Me.PictureBox3.TabStop = False
        '
        'txtBuscar
        '
        Me.txtBuscar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBuscar.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscar.Location = New System.Drawing.Point(727, 30)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(172, 26)
        Me.txtBuscar.TabIndex = 22
        Me.txtBuscar.Tag = "BUSCAR"
        '
        'Panel6
        '
        Me.Panel6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel6.BackColor = System.Drawing.Color.White
        Me.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel6.Controls.Add(Me.cbobuscarpor)
        Me.Panel6.Location = New System.Drawing.Point(534, 28)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(135, 28)
        Me.Panel6.TabIndex = 38
        '
        'cbobuscarpor
        '
        Me.cbobuscarpor.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cbobuscarpor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbobuscarpor.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbobuscarpor.FormattingEnabled = True
        Me.cbobuscarpor.Items.AddRange(New Object() {"Nombre", "Apellido"})
        Me.cbobuscarpor.Location = New System.Drawing.Point(1, -1)
        Me.cbobuscarpor.Name = "cbobuscarpor"
        Me.cbobuscarpor.Size = New System.Drawing.Size(132, 27)
        Me.cbobuscarpor.TabIndex = 22
        Me.cbobuscarpor.Text = "Nombre"
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(531, 11)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(77, 19)
        Me.Label8.TabIndex = 24
        Me.Label8.Text = "Buscar Por"
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GroupBox2.Controls.Add(Me.txtxlimpiar)
        Me.GroupBox2.Controls.Add(Me.btnInhabilitar)
        Me.GroupBox2.Controls.Add(Me.txtNombre)
        Me.GroupBox2.Controls.Add(Me.txtsecuencial)
        Me.GroupBox2.Controls.Add(Me.txtCodigo)
        Me.GroupBox2.Controls.Add(Me.txtAlias)
        Me.GroupBox2.Controls.Add(Me.txtapellido)
        Me.GroupBox2.Controls.Add(Me.txtPassword)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.cbodepartamento)
        Me.GroupBox2.Controls.Add(Me.lblnombre)
        Me.GroupBox2.Controls.Add(Me.lblcodigo)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.lblapellido)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Panel3)
        Me.GroupBox2.Controls.Add(Me.Panel4)
        Me.GroupBox2.Controls.Add(Me.lblRolUsuario)
        Me.GroupBox2.Controls.Add(Me.Panel5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Panel1)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox2.Location = New System.Drawing.Point(48, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GroupBox2.Size = New System.Drawing.Size(470, 348)
        Me.GroupBox2.TabIndex = 22
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "ADMINISTRAR"
        '
        'txtxlimpiar
        '
        Me.txtxlimpiar.Location = New System.Drawing.Point(56, 319)
        Me.txtxlimpiar.Name = "txtxlimpiar"
        Me.txtxlimpiar.Size = New System.Drawing.Size(75, 23)
        Me.txtxlimpiar.TabIndex = 39
        Me.txtxlimpiar.Text = "[Limpiar]"
        Me.txtxlimpiar.UseVisualStyleBackColor = True
        '
        'btnInhabilitar
        '
        Me.btnInhabilitar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnInhabilitar.BackColor = System.Drawing.Color.White
        Me.btnInhabilitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInhabilitar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInhabilitar.Location = New System.Drawing.Point(259, 299)
        Me.btnInhabilitar.Name = "btnInhabilitar"
        Me.btnInhabilitar.Size = New System.Drawing.Size(120, 43)
        Me.btnInhabilitar.TabIndex = 23
        Me.btnInhabilitar.Text = "CAMBIAR " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "ESTADO"
        Me.btnInhabilitar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnInhabilitar.UseVisualStyleBackColor = False
        '
        'txtsecuencial
        '
        Me.txtsecuencial.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtsecuencial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtsecuencial.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsecuencial.Location = New System.Drawing.Point(38, 34)
        Me.txtsecuencial.Name = "txtsecuencial"
        Me.txtsecuencial.ReadOnly = True
        Me.txtsecuencial.Size = New System.Drawing.Size(50, 25)
        Me.txtsecuencial.TabIndex = 31
        '
        'txtAlias
        '
        Me.txtAlias.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtAlias.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAlias.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAlias.Location = New System.Drawing.Point(37, 226)
        Me.txtAlias.Name = "txtAlias"
        Me.txtAlias.Size = New System.Drawing.Size(152, 25)
        Me.txtAlias.TabIndex = 24
        '
        'cbodepartamento
        '
        Me.cbodepartamento.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cbodepartamento.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbodepartamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbodepartamento.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbodepartamento.FormattingEnabled = True
        Me.cbodepartamento.Location = New System.Drawing.Point(257, 46)
        Me.cbodepartamento.Name = "cbodepartamento"
        Me.cbodepartamento.Size = New System.Drawing.Size(132, 25)
        Me.cbodepartamento.TabIndex = 6
        Me.cbodepartamento.Text = "Asigne Departamento"
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(36, 157)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 19)
        Me.Label5.TabIndex = 34
        Me.Label5.Text = "Apellido"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(34, 17)
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
        Me.Panel3.Location = New System.Drawing.Point(254, 160)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(174, 28)
        Me.Panel3.TabIndex = 28
        '
        'cboTipoUsuario
        '
        Me.cboTipoUsuario.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cboTipoUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cboTipoUsuario.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTipoUsuario.FormattingEnabled = True
        Me.cboTipoUsuario.Items.AddRange(New Object() {"Empleado", "Visita", "Secretaria", "Administrador", "Administrador IT"})
        Me.cboTipoUsuario.Location = New System.Drawing.Point(0, -1)
        Me.cboTipoUsuario.Name = "cboTipoUsuario"
        Me.cboTipoUsuario.Size = New System.Drawing.Size(172, 27)
        Me.cboTipoUsuario.TabIndex = 29
        Me.cboTipoUsuario.Text = "Seleccione Rol de Usuario"
        '
        'Panel4
        '
        Me.Panel4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel4.BackColor = System.Drawing.Color.White
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.CbxTurno)
        Me.Panel4.Location = New System.Drawing.Point(254, 98)
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
        Me.CbxTurno.Location = New System.Drawing.Point(2, 2)
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
        Me.lblRolUsuario.Location = New System.Drawing.Point(250, 160)
        Me.lblRolUsuario.Name = "lblRolUsuario"
        Me.lblRolUsuario.Size = New System.Drawing.Size(100, 19)
        Me.lblRolUsuario.TabIndex = 36
        Me.lblRolUsuario.Text = "Rol de Usuario"
        '
        'Panel5
        '
        Me.Panel5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel5.BackColor = System.Drawing.Color.White
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Location = New System.Drawing.Point(254, 44)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(137, 28)
        Me.Panel5.TabIndex = 38
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(255, 82)
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
        Me.Label6.Location = New System.Drawing.Point(254, 22)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(95, 19)
        Me.Label6.TabIndex = 35
        Me.Label6.Text = "Departamento"
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.cbxGrupo)
        Me.Panel1.Location = New System.Drawing.Point(254, 224)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(121, 27)
        Me.Panel1.TabIndex = 40
        '
        'cbxGrupo
        '
        Me.cbxGrupo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cbxGrupo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbxGrupo.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxGrupo.FormattingEnabled = True
        Me.cbxGrupo.Location = New System.Drawing.Point(-1, -2)
        Me.cbxGrupo.Name = "cbxGrupo"
        Me.cbxGrupo.Size = New System.Drawing.Size(121, 27)
        Me.cbxGrupo.TabIndex = 19
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(257, 206)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(48, 19)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "Grupo"
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(254, 142)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(30, 19)
        Me.Label9.TabIndex = 41
        Me.Label9.Text = "Rol"
        '
        'dtpFechaContrato
        '
        Me.dtpFechaContrato.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.dtpFechaContrato.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaContrato.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaContrato.Location = New System.Drawing.Point(121, 323)
        Me.dtpFechaContrato.Name = "dtpFechaContrato"
        Me.dtpFechaContrato.Size = New System.Drawing.Size(130, 25)
        Me.dtpFechaContrato.TabIndex = 25
        '
        'lblFechaContrato
        '
        Me.lblFechaContrato.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblFechaContrato.AutoSize = True
        Me.lblFechaContrato.BackColor = System.Drawing.Color.Transparent
        Me.lblFechaContrato.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaContrato.Location = New System.Drawing.Point(117, 306)
        Me.lblFechaContrato.Name = "lblFechaContrato"
        Me.lblFechaContrato.Size = New System.Drawing.Size(123, 19)
        Me.lblFechaContrato.TabIndex = 26
        Me.lblFechaContrato.Text = "Fecha de Contrato"
        '
        'Panel2
        '
        Me.Panel2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.cboEstado)
        Me.Panel2.Location = New System.Drawing.Point(268, 319)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(137, 28)
        Me.Panel2.TabIndex = 25
        '
        'cboEstado
        '
        Me.cboEstado.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cboEstado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboEstado.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboEstado.FormattingEnabled = True
        Me.cboEstado.Items.AddRange(New Object() {"ACTIVO", "INACTIVO"})
        Me.cboEstado.Location = New System.Drawing.Point(2, 1)
        Me.cboEstado.Name = "cboEstado"
        Me.cboEstado.Size = New System.Drawing.Size(132, 23)
        Me.cboEstado.TabIndex = 27
        Me.cboEstado.Text = "ACTIVO"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(264, 302)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 19)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Estado"
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox3.Controls.Add(Me.ChkvalidaPeticion)
        Me.GroupBox3.Controls.Add(Me.ChkSuperintendente)
        Me.GroupBox3.Controls.Add(Me.chkTransportista)
        Me.GroupBox3.Controls.Add(Me.chkDigitador)
        Me.GroupBox3.Controls.Add(Me.chkCocina)
        Me.GroupBox3.Controls.Add(Me.chkAdministrar)
        Me.GroupBox3.Controls.Add(Me.chkEliminar)
        Me.GroupBox3.Controls.Add(Me.chkCrearlistas)
        Me.GroupBox3.Controls.Add(Me.chkModificar)
        Me.GroupBox3.Controls.Add(Me.dtpFechaContrato)
        Me.GroupBox3.Controls.Add(Me.chkAgregar)
        Me.GroupBox3.Controls.Add(Me.Panel2)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.lblFechaContrato)
        Me.GroupBox3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(547, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(425, 348)
        Me.GroupBox3.TabIndex = 19
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Permisos"
        '
        'ChkvalidaPeticion
        '
        Me.ChkvalidaPeticion.AutoSize = True
        Me.ChkvalidaPeticion.Location = New System.Drawing.Point(226, 160)
        Me.ChkvalidaPeticion.Name = "ChkvalidaPeticion"
        Me.ChkvalidaPeticion.Size = New System.Drawing.Size(117, 23)
        Me.ChkvalidaPeticion.TabIndex = 18
        Me.ChkvalidaPeticion.Text = "Valida Peticion"
        Me.ChkvalidaPeticion.UseVisualStyleBackColor = True
        '
        'ChkSuperintendente
        '
        Me.ChkSuperintendente.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ChkSuperintendente.AutoSize = True
        Me.ChkSuperintendente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ChkSuperintendente.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkSuperintendente.Location = New System.Drawing.Point(32, 200)
        Me.ChkSuperintendente.Name = "ChkSuperintendente"
        Me.ChkSuperintendente.Size = New System.Drawing.Size(177, 23)
        Me.ChkSuperintendente.TabIndex = 17
        Me.ChkSuperintendente.Text = "Permiso SuperIntendente"
        Me.ChkSuperintendente.UseVisualStyleBackColor = True
        '
        'chkTransportista
        '
        Me.chkTransportista.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.chkTransportista.AutoSize = True
        Me.chkTransportista.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkTransportista.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkTransportista.Location = New System.Drawing.Point(226, 114)
        Me.chkTransportista.Name = "chkTransportista"
        Me.chkTransportista.Size = New System.Drawing.Size(148, 23)
        Me.chkTransportista.TabIndex = 16
        Me.chkTransportista.Text = "Permiso Transportar"
        Me.chkTransportista.UseVisualStyleBackColor = True
        '
        'chkDigitador
        '
        Me.chkDigitador.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.chkDigitador.AutoSize = True
        Me.chkDigitador.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkDigitador.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkDigitador.Location = New System.Drawing.Point(226, 71)
        Me.chkDigitador.Name = "chkDigitador"
        Me.chkDigitador.Size = New System.Drawing.Size(134, 23)
        Me.chkDigitador.TabIndex = 15
        Me.chkDigitador.Text = "Permiso Digitador"
        Me.chkDigitador.UseVisualStyleBackColor = True
        '
        'chkCocina
        '
        Me.chkCocina.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.chkCocina.AutoSize = True
        Me.chkCocina.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkCocina.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkCocina.Location = New System.Drawing.Point(226, 36)
        Me.chkCocina.Name = "chkCocina"
        Me.chkCocina.Size = New System.Drawing.Size(75, 23)
        Me.chkCocina.TabIndex = 14
        Me.chkCocina.Text = "Cocina?"
        Me.chkCocina.UseVisualStyleBackColor = True
        '
        'chkAdministrar
        '
        Me.chkAdministrar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.chkAdministrar.AutoSize = True
        Me.chkAdministrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkAdministrar.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkAdministrar.Location = New System.Drawing.Point(32, 155)
        Me.chkAdministrar.Name = "chkAdministrar"
        Me.chkAdministrar.Size = New System.Drawing.Size(147, 23)
        Me.chkAdministrar.TabIndex = 13
        Me.chkAdministrar.Text = "Permiso Administrar"
        Me.chkAdministrar.UseVisualStyleBackColor = True
        '
        'chkEliminar
        '
        Me.chkEliminar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.chkEliminar.AutoSize = True
        Me.chkEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkEliminar.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkEliminar.Location = New System.Drawing.Point(32, 114)
        Me.chkEliminar.Name = "chkEliminar"
        Me.chkEliminar.Size = New System.Drawing.Size(126, 23)
        Me.chkEliminar.TabIndex = 12
        Me.chkEliminar.Text = "Permiso Eliminar"
        Me.chkEliminar.UseVisualStyleBackColor = True
        '
        'chkCrearlistas
        '
        Me.chkCrearlistas.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.chkCrearlistas.AutoSize = True
        Me.chkCrearlistas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkCrearlistas.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkCrearlistas.Location = New System.Drawing.Point(32, 245)
        Me.chkCrearlistas.Name = "chkCrearlistas"
        Me.chkCrearlistas.Size = New System.Drawing.Size(177, 23)
        Me.chkCrearlistas.TabIndex = 11
        Me.chkCrearlistas.Text = "Permiso Ordenar a deps "
        Me.chkCrearlistas.UseVisualStyleBackColor = True
        '
        'chkModificar
        '
        Me.chkModificar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.chkModificar.AutoSize = True
        Me.chkModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkModificar.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkModificar.Location = New System.Drawing.Point(32, 73)
        Me.chkModificar.Name = "chkModificar"
        Me.chkModificar.Size = New System.Drawing.Size(137, 23)
        Me.chkModificar.TabIndex = 10
        Me.chkModificar.Text = "Permiso Modificar"
        Me.chkModificar.UseVisualStyleBackColor = True
        '
        'chkAgregar
        '
        Me.chkAgregar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.chkAgregar.AutoSize = True
        Me.chkAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkAgregar.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkAgregar.Location = New System.Drawing.Point(32, 36)
        Me.chkAgregar.Name = "chkAgregar"
        Me.chkAgregar.Size = New System.Drawing.Size(126, 23)
        Me.chkAgregar.TabIndex = 9
        Me.chkAgregar.Text = "Permiso Agregar"
        Me.chkAgregar.UseVisualStyleBackColor = True
        '
        'ErrorIcon
        '
        Me.ErrorIcon.ContainerControl = Me
        '
        'btnEliminar
        '
        Me.btnEliminar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminar.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.Image = CType(resources.GetObject("btnEliminar.Image"), System.Drawing.Image)
        Me.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnEliminar.Location = New System.Drawing.Point(316, 658)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(109, 50)
        Me.btnEliminar.TabIndex = 24
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'FrmAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1004, 727)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnguardar)
        Me.Controls.Add(Me.GroupBox2)
        Me.DoubleBuffered = True
        Me.Name = "FrmAdmin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Administracion De Usuarios"
        CType(Me.dgvusuario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.ErrorIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblcodigo As Label
    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtapellido As TextBox
    Friend WithEvents lblapellido As Label
    Friend WithEvents lblnombre As Label
    Friend WithEvents btnguardar As Button
    Friend WithEvents dgvusuario As DataGridView
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnModificar As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents ErrorIcon As ErrorProvider
    Friend WithEvents btnInhabilitar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents cbobuscarpor As ComboBox
    Friend WithEvents txtAlias As TextBox
    Friend WithEvents cboTipoUsuario As ComboBox
    Friend WithEvents cboEstado As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lblFechaContrato As Label
    Friend WithEvents dtpFechaContrato As DateTimePicker
    Friend WithEvents cbodepartamento As ComboBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents chkTransportista As CheckBox
    Friend WithEvents chkDigitador As CheckBox
    Friend WithEvents chkCocina As CheckBox
    Friend WithEvents chkAdministrar As CheckBox
    Friend WithEvents chkEliminar As CheckBox
    Friend WithEvents chkCrearlistas As CheckBox
    Friend WithEvents chkModificar As CheckBox
    Friend WithEvents chkAgregar As CheckBox
    Friend WithEvents txtsecuencial As TextBox
    Friend WithEvents CbxTurno As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents ChkSuperintendente As CheckBox
    Friend WithEvents Label6 As Label
    Friend WithEvents lblRolUsuario As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents ChkvalidaPeticion As CheckBox
    Friend WithEvents cbxGrupo As ComboBox
    Friend WithEvents Panel6 As Panel
    Friend WithEvents txtxlimpiar As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents Label9 As Label
End Class
