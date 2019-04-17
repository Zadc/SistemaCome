<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCrearDepartamento
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
        Me.btnCrearDep = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnnuevo = New System.Windows.Forms.Button()
        Me.txtCodigoDep = New System.Windows.Forms.TextBox()
        Me.Secuencial = New System.Windows.Forms.Label()
        Me.txtDescripcionDep = New System.Windows.Forms.TextBox()
        Me.txtIdDsecuencial = New System.Windows.Forms.TextBox()
        Me.LblCientaCont = New System.Windows.Forms.Label()
        Me.txtCuentaContable = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboArea = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnCrearDep
        '
        Me.btnCrearDep.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnCrearDep.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnCrearDep.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCrearDep.Location = New System.Drawing.Point(44, 388)
        Me.btnCrearDep.Name = "btnCrearDep"
        Me.btnCrearDep.Size = New System.Drawing.Size(75, 23)
        Me.btnCrearDep.TabIndex = 0
        Me.btnCrearDep.Text = "Crear"
        Me.btnCrearDep.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.btnCrearDep)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.btnnuevo)
        Me.Panel2.Controls.Add(Me.txtCodigoDep)
        Me.Panel2.Controls.Add(Me.Secuencial)
        Me.Panel2.Controls.Add(Me.txtDescripcionDep)
        Me.Panel2.Controls.Add(Me.txtIdDsecuencial)
        Me.Panel2.Controls.Add(Me.LblCientaCont)
        Me.Panel2.Controls.Add(Me.txtCuentaContable)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.cboArea)
        Me.Panel2.Location = New System.Drawing.Point(-5, 1)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(279, 450)
        Me.Panel2.TabIndex = 17
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(39, 157)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(172, 19)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Nombre del Departamento"
        '
        'btnnuevo
        '
        Me.btnnuevo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnnuevo.BackColor = System.Drawing.Color.LightGray
        Me.btnnuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnnuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnnuevo.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnnuevo.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnnuevo.Location = New System.Drawing.Point(43, 296)
        Me.btnnuevo.Name = "btnnuevo"
        Me.btnnuevo.Size = New System.Drawing.Size(86, 29)
        Me.btnnuevo.TabIndex = 7
        Me.btnnuevo.Text = "Limpiar"
        Me.btnnuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnnuevo.UseVisualStyleBackColor = False
        '
        'txtCodigoDep
        '
        Me.txtCodigoDep.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtCodigoDep.Location = New System.Drawing.Point(43, 124)
        Me.txtCodigoDep.Name = "txtCodigoDep"
        Me.txtCodigoDep.Size = New System.Drawing.Size(65, 20)
        Me.txtCodigoDep.TabIndex = 6
        '
        'Secuencial
        '
        Me.Secuencial.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Secuencial.AutoSize = True
        Me.Secuencial.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Secuencial.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Secuencial.Location = New System.Drawing.Point(37, 48)
        Me.Secuencial.Name = "Secuencial"
        Me.Secuencial.Size = New System.Drawing.Size(70, 19)
        Me.Secuencial.TabIndex = 9
        Me.Secuencial.Text = "secuencial"
        '
        'txtDescripcionDep
        '
        Me.txtDescripcionDep.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtDescripcionDep.Location = New System.Drawing.Point(41, 179)
        Me.txtDescripcionDep.Name = "txtDescripcionDep"
        Me.txtDescripcionDep.Size = New System.Drawing.Size(169, 20)
        Me.txtDescripcionDep.TabIndex = 5
        '
        'txtIdDsecuencial
        '
        Me.txtIdDsecuencial.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtIdDsecuencial.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtIdDsecuencial.Location = New System.Drawing.Point(41, 70)
        Me.txtIdDsecuencial.Name = "txtIdDsecuencial"
        Me.txtIdDsecuencial.ReadOnly = True
        Me.txtIdDsecuencial.Size = New System.Drawing.Size(55, 20)
        Me.txtIdDsecuencial.TabIndex = 8
        '
        'LblCientaCont
        '
        Me.LblCientaCont.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LblCientaCont.AutoSize = True
        Me.LblCientaCont.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.LblCientaCont.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCientaCont.Location = New System.Drawing.Point(39, 202)
        Me.LblCientaCont.Name = "LblCientaCont"
        Me.LblCientaCont.Size = New System.Drawing.Size(111, 19)
        Me.LblCientaCont.TabIndex = 14
        Me.LblCientaCont.Text = "Cuenta Contable"
        '
        'txtCuentaContable
        '
        Me.txtCuentaContable.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtCuentaContable.Location = New System.Drawing.Point(41, 224)
        Me.txtCuentaContable.Name = "txtCuentaContable"
        Me.txtCuentaContable.Size = New System.Drawing.Size(162, 20)
        Me.txtCuentaContable.TabIndex = 13
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(39, 102)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(144, 19)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Codigo Departamento"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(39, 247)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 19)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Area"
        '
        'cboArea
        '
        Me.cboArea.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cboArea.FormattingEnabled = True
        Me.cboArea.Location = New System.Drawing.Point(43, 269)
        Me.cboArea.Name = "cboArea"
        Me.cboArea.Size = New System.Drawing.Size(162, 21)
        Me.cboArea.TabIndex = 7
        '
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(168, 388)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "Cerrar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'FrmCrearDepartamento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(274, 450)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "FrmCrearDepartamento"
        Me.Text = "Form1"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnCrearDep As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents btnnuevo As Button
    Friend WithEvents txtCodigoDep As TextBox
    Friend WithEvents Secuencial As Label
    Friend WithEvents txtDescripcionDep As TextBox
    Friend WithEvents txtIdDsecuencial As TextBox
    Friend WithEvents LblCientaCont As Label
    Friend WithEvents txtCuentaContable As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cboArea As ComboBox
End Class
