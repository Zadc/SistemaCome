<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmTurnos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmTurnos))
        Me.dgvShowTurnos = New System.Windows.Forms.DataGridView()
        Me.btnmodturnos = New System.Windows.Forms.Button()
        Me.CbxTurno = New System.Windows.Forms.ComboBox()
        Me.ChkvalidaPeticion = New System.Windows.Forms.CheckBox()
        Me.TxtIdusuario = New System.Windows.Forms.TextBox()
        Me.picboxregresar = New System.Windows.Forms.PictureBox()
        Me.lblTurno = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.cbobuscarpor = New System.Windows.Forms.ComboBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        CType(Me.dgvShowTurnos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picboxregresar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvShowTurnos
        '
        Me.dgvShowTurnos.AllowUserToAddRows = False
        Me.dgvShowTurnos.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.dgvShowTurnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvShowTurnos.Location = New System.Drawing.Point(49, 106)
        Me.dgvShowTurnos.Name = "dgvShowTurnos"
        Me.dgvShowTurnos.ReadOnly = True
        Me.dgvShowTurnos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvShowTurnos.Size = New System.Drawing.Size(799, 334)
        Me.dgvShowTurnos.TabIndex = 0
        '
        'btnmodturnos
        '
        Me.btnmodturnos.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnmodturnos.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnmodturnos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnmodturnos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnmodturnos.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnmodturnos.Image = CType(resources.GetObject("btnmodturnos.Image"), System.Drawing.Image)
        Me.btnmodturnos.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnmodturnos.Location = New System.Drawing.Point(79, 465)
        Me.btnmodturnos.Name = "btnmodturnos"
        Me.btnmodturnos.Size = New System.Drawing.Size(106, 51)
        Me.btnmodturnos.TabIndex = 1
        Me.btnmodturnos.Text = "Modificar"
        Me.btnmodturnos.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnmodturnos.UseVisualStyleBackColor = False
        '
        'CbxTurno
        '
        Me.CbxTurno.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CbxTurno.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CbxTurno.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbxTurno.FormattingEnabled = True
        Me.CbxTurno.Items.AddRange(New Object() {"SELECCIONE UN TURNO"})
        Me.CbxTurno.Location = New System.Drawing.Point(0, -1)
        Me.CbxTurno.Name = "CbxTurno"
        Me.CbxTurno.Size = New System.Drawing.Size(121, 23)
        Me.CbxTurno.TabIndex = 31
        '
        'ChkvalidaPeticion
        '
        Me.ChkvalidaPeticion.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ChkvalidaPeticion.AutoSize = True
        Me.ChkvalidaPeticion.Location = New System.Drawing.Point(230, 64)
        Me.ChkvalidaPeticion.Name = "ChkvalidaPeticion"
        Me.ChkvalidaPeticion.Size = New System.Drawing.Size(100, 17)
        Me.ChkvalidaPeticion.TabIndex = 33
        Me.ChkvalidaPeticion.Text = "Pide Para llevar"
        Me.ChkvalidaPeticion.UseVisualStyleBackColor = True
        '
        'TxtIdusuario
        '
        Me.TxtIdusuario.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TxtIdusuario.Enabled = False
        Me.TxtIdusuario.Location = New System.Drawing.Point(594, 180)
        Me.TxtIdusuario.Name = "TxtIdusuario"
        Me.TxtIdusuario.Size = New System.Drawing.Size(51, 20)
        Me.TxtIdusuario.TabIndex = 34
        '
        'picboxregresar
        '
        Me.picboxregresar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.picboxregresar.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.picboxregresar.BackgroundImage = CType(resources.GetObject("picboxregresar.BackgroundImage"), System.Drawing.Image)
        Me.picboxregresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.picboxregresar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picboxregresar.Location = New System.Drawing.Point(675, 465)
        Me.picboxregresar.Name = "picboxregresar"
        Me.picboxregresar.Size = New System.Drawing.Size(105, 51)
        Me.picboxregresar.TabIndex = 35
        Me.picboxregresar.TabStop = False
        '
        'lblTurno
        '
        Me.lblTurno.AutoSize = True
        Me.lblTurno.Location = New System.Drawing.Point(45, 47)
        Me.lblTurno.Name = "lblTurno"
        Me.lblTurno.Size = New System.Drawing.Size(46, 13)
        Me.lblTurno.TabIndex = 36
        Me.lblTurno.Text = "TURNO"
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.CbxTurno)
        Me.Panel1.Location = New System.Drawing.Point(48, 64)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(122, 24)
        Me.Panel1.TabIndex = 37
        '
        'PictureBox3
        '
        Me.PictureBox3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox3.BackColor = System.Drawing.Color.White
        Me.PictureBox3.BackgroundImage = CType(resources.GetObject("PictureBox3.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.PictureBox3.Location = New System.Drawing.Point(646, 65)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(29, 26)
        Me.PictureBox3.TabIndex = 52
        Me.PictureBox3.TabStop = False
        '
        'txtBuscar
        '
        Me.txtBuscar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBuscar.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscar.Location = New System.Drawing.Point(675, 65)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(172, 26)
        Me.txtBuscar.TabIndex = 51
        Me.txtBuscar.Tag = "BUSCAR"
        '
        'cbobuscarpor
        '
        Me.cbobuscarpor.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cbobuscarpor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbobuscarpor.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbobuscarpor.FormattingEnabled = True
        Me.cbobuscarpor.Items.AddRange(New Object() {"NOMBRE COMPLETO"})
        Me.cbobuscarpor.Location = New System.Drawing.Point(0, 1)
        Me.cbobuscarpor.Name = "cbobuscarpor"
        Me.cbobuscarpor.Size = New System.Drawing.Size(151, 25)
        Me.cbobuscarpor.TabIndex = 50
        Me.cbobuscarpor.Text = "NOMBRE COMPLETO"
        '
        'Panel2
        '
        Me.Panel2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.cbobuscarpor)
        Me.Panel2.Location = New System.Drawing.Point(441, 62)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(153, 30)
        Me.Panel2.TabIndex = 53
        '
        'FrmTurnos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(892, 539)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.txtBuscar)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lblTurno)
        Me.Controls.Add(Me.picboxregresar)
        Me.Controls.Add(Me.ChkvalidaPeticion)
        Me.Controls.Add(Me.btnmodturnos)
        Me.Controls.Add(Me.dgvShowTurnos)
        Me.Controls.Add(Me.TxtIdusuario)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "FrmTurnos"
        Me.Text = "Administrar Turnos"
        CType(Me.dgvShowTurnos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picboxregresar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvShowTurnos As DataGridView
    Friend WithEvents btnmodturnos As Button
    Friend WithEvents CbxTurno As ComboBox
    Friend WithEvents ChkvalidaPeticion As CheckBox
    Friend WithEvents TxtIdusuario As TextBox
    Friend WithEvents picboxregresar As PictureBox
    Friend WithEvents lblTurno As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents cbobuscarpor As ComboBox
    Friend WithEvents Panel2 As Panel
End Class
