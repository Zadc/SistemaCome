<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmCreaDeps
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCreaDeps))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.txtDescripcionDep = New System.Windows.Forms.TextBox()
        Me.txtCodigoDep = New System.Windows.Forms.TextBox()
        Me.cboArea = New System.Windows.Forms.ComboBox()
        Me.txtIdDsecuencial = New System.Windows.Forms.TextBox()
        Me.Secuencial = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCuentaContable = New System.Windows.Forms.TextBox()
        Me.LblCientaCont = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.dgvDepartamentos = New System.Windows.Forms.DataGridView()
        Me.picback = New System.Windows.Forms.PictureBox()
        Me.ComedordbDataSet = New Siscomedor.comedordbDataSet()
        Me.ComedordbDataSet1 = New Siscomedor.comedordbDataSet1()
        Me.Panel2.SuspendLayout()
        CType(Me.dgvDepartamentos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picback, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComedordbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComedordbDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnEditar
        '
        Me.btnEditar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnEditar.BackColor = System.Drawing.Color.LightGray
        Me.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditar.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditar.Image = CType(resources.GetObject("btnEditar.Image"), System.Drawing.Image)
        Me.btnEditar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnEditar.Location = New System.Drawing.Point(281, 535)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(119, 52)
        Me.btnEditar.TabIndex = 1
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnEditar.UseVisualStyleBackColor = False
        '
        'btnEliminar
        '
        Me.btnEliminar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnEliminar.BackColor = System.Drawing.Color.LightGray
        Me.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminar.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.Image = CType(resources.GetObject("btnEliminar.Image"), System.Drawing.Image)
        Me.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnEliminar.Location = New System.Drawing.Point(517, 535)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(119, 52)
        Me.btnEliminar.TabIndex = 2
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'btnGuardar
        '
        Me.btnGuardar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnGuardar.BackColor = System.Drawing.Color.LightGray
        Me.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.Image = CType(resources.GetObject("btnGuardar.Image"), System.Drawing.Image)
        Me.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnGuardar.Location = New System.Drawing.Point(11, 535)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(119, 51)
        Me.btnGuardar.TabIndex = 3
        Me.btnGuardar.Text = "Nuevo"
        Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'txtDescripcionDep
        '
        Me.txtDescripcionDep.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtDescripcionDep.Location = New System.Drawing.Point(33, 161)
        Me.txtDescripcionDep.Name = "txtDescripcionDep"
        Me.txtDescripcionDep.ReadOnly = True
        Me.txtDescripcionDep.Size = New System.Drawing.Size(169, 20)
        Me.txtDescripcionDep.TabIndex = 5
        '
        'txtCodigoDep
        '
        Me.txtCodigoDep.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtCodigoDep.Location = New System.Drawing.Point(35, 106)
        Me.txtCodigoDep.Name = "txtCodigoDep"
        Me.txtCodigoDep.ReadOnly = True
        Me.txtCodigoDep.Size = New System.Drawing.Size(65, 20)
        Me.txtCodigoDep.TabIndex = 6
        '
        'cboArea
        '
        Me.cboArea.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cboArea.Enabled = False
        Me.cboArea.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cboArea.FormattingEnabled = True
        Me.cboArea.Location = New System.Drawing.Point(35, 251)
        Me.cboArea.Name = "cboArea"
        Me.cboArea.Size = New System.Drawing.Size(162, 21)
        Me.cboArea.TabIndex = 7
        '
        'txtIdDsecuencial
        '
        Me.txtIdDsecuencial.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtIdDsecuencial.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtIdDsecuencial.Location = New System.Drawing.Point(33, 52)
        Me.txtIdDsecuencial.Name = "txtIdDsecuencial"
        Me.txtIdDsecuencial.ReadOnly = True
        Me.txtIdDsecuencial.Size = New System.Drawing.Size(55, 20)
        Me.txtIdDsecuencial.TabIndex = 8
        '
        'Secuencial
        '
        Me.Secuencial.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Secuencial.AutoSize = True
        Me.Secuencial.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Secuencial.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Secuencial.Location = New System.Drawing.Point(29, 30)
        Me.Secuencial.Name = "Secuencial"
        Me.Secuencial.Size = New System.Drawing.Size(70, 19)
        Me.Secuencial.TabIndex = 9
        Me.Secuencial.Text = "secuencial"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(31, 84)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(144, 19)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Codigo Departamento"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(31, 139)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(172, 19)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Nombre del Departamento"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(31, 229)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 19)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Area"
        '
        'txtCuentaContable
        '
        Me.txtCuentaContable.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtCuentaContable.Location = New System.Drawing.Point(33, 206)
        Me.txtCuentaContable.Name = "txtCuentaContable"
        Me.txtCuentaContable.ReadOnly = True
        Me.txtCuentaContable.Size = New System.Drawing.Size(162, 20)
        Me.txtCuentaContable.TabIndex = 13
        '
        'LblCientaCont
        '
        Me.LblCientaCont.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LblCientaCont.AutoSize = True
        Me.LblCientaCont.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.LblCientaCont.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCientaCont.Location = New System.Drawing.Point(31, 184)
        Me.LblCientaCont.Name = "LblCientaCont"
        Me.LblCientaCont.Size = New System.Drawing.Size(111, 19)
        Me.LblCientaCont.TabIndex = 14
        Me.LblCientaCont.Text = "Cuenta Contable"
        '
        'Panel2
        '
        Me.Panel2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.txtCodigoDep)
        Me.Panel2.Controls.Add(Me.Secuencial)
        Me.Panel2.Controls.Add(Me.txtDescripcionDep)
        Me.Panel2.Controls.Add(Me.txtIdDsecuencial)
        Me.Panel2.Controls.Add(Me.LblCientaCont)
        Me.Panel2.Controls.Add(Me.txtCuentaContable)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.cboArea)
        Me.Panel2.Location = New System.Drawing.Point(10, 115)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(262, 414)
        Me.Panel2.TabIndex = 16
        '
        'dgvDepartamentos
        '
        Me.dgvDepartamentos.AllowUserToAddRows = False
        Me.dgvDepartamentos.AllowUserToDeleteRows = False
        Me.dgvDepartamentos.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.dgvDepartamentos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvDepartamentos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dgvDepartamentos.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.dgvDepartamentos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        Me.dgvDepartamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDepartamentos.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.dgvDepartamentos.Location = New System.Drawing.Point(278, 115)
        Me.dgvDepartamentos.Name = "dgvDepartamentos"
        Me.dgvDepartamentos.ReadOnly = True
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvDepartamentos.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvDepartamentos.Size = New System.Drawing.Size(719, 414)
        Me.dgvDepartamentos.TabIndex = 0
        '
        'picback
        '
        Me.picback.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.picback.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.picback.BackgroundImage = CType(resources.GetObject("picback.BackgroundImage"), System.Drawing.Image)
        Me.picback.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.picback.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picback.Location = New System.Drawing.Point(912, 588)
        Me.picback.Name = "picback"
        Me.picback.Size = New System.Drawing.Size(119, 52)
        Me.picback.TabIndex = 17
        Me.picback.TabStop = False
        '
        'ComedordbDataSet
        '
        Me.ComedordbDataSet.DataSetName = "comedordbDataSet"
        Me.ComedordbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ComedordbDataSet1
        '
        Me.ComedordbDataSet1.DataSetName = "comedordbDataSet1"
        Me.ComedordbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FrmCreaDeps
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(1016, 693)
        Me.Controls.Add(Me.picback)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.dgvDepartamentos)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "FrmCreaDeps"
        Me.Text = "Administrar Departamentos"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.dgvDepartamentos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picback, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComedordbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComedordbDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents txtDescripcionDep As TextBox
    Friend WithEvents txtCodigoDep As TextBox
    Friend WithEvents cboArea As ComboBox
    Friend WithEvents txtIdDsecuencial As TextBox
    Friend WithEvents Secuencial As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtCuentaContable As TextBox
    Friend WithEvents LblCientaCont As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents dgvDepartamentos As DataGridView
    Friend WithEvents picback As PictureBox
    Friend WithEvents ComedordbDataSet As comedordbDataSet
    Friend WithEvents ComedordbDataSet1 As comedordbDataSet1
End Class
