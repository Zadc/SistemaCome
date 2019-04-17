<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmInactivaactivauser
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmInactivaactivauser))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.DTPfECHADESDE = New System.Windows.Forms.DateTimePicker()
        Me.DTPFECHAHASTA = New System.Windows.Forms.DateTimePicker()
        Me.ChkActivaAutomaticamente = New System.Windows.Forms.CheckBox()
        Me.cboEstado = New System.Windows.Forms.ComboBox()
        Me.btnCambiarEstadoForm = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DtgvEstadoUsuario = New System.Windows.Forms.DataGridView()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.DtgvEstadoUsuario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(32, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 19)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Label1"
        '
        'ComboBox1
        '
        Me.ComboBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(318, 41)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 2
        '
        'DTPfECHADESDE
        '
        Me.DTPfECHADESDE.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.DTPfECHADESDE.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTPfECHADESDE.Location = New System.Drawing.Point(22, 120)
        Me.DTPfECHADESDE.Name = "DTPfECHADESDE"
        Me.DTPfECHADESDE.Size = New System.Drawing.Size(200, 22)
        Me.DTPfECHADESDE.TabIndex = 4
        Me.DTPfECHADESDE.Value = New Date(2019, 3, 8, 0, 0, 0, 0)
        '
        'DTPFECHAHASTA
        '
        Me.DTPFECHAHASTA.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.DTPFECHAHASTA.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTPFECHAHASTA.Location = New System.Drawing.Point(239, 120)
        Me.DTPFECHAHASTA.Name = "DTPFECHAHASTA"
        Me.DTPFECHAHASTA.Size = New System.Drawing.Size(200, 22)
        Me.DTPFECHAHASTA.TabIndex = 5
        Me.DTPFECHAHASTA.Value = New Date(2019, 3, 8, 0, 0, 0, 0)
        '
        'ChkActivaAutomaticamente
        '
        Me.ChkActivaAutomaticamente.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ChkActivaAutomaticamente.AutoSize = True
        Me.ChkActivaAutomaticamente.BackColor = System.Drawing.Color.Transparent
        Me.ChkActivaAutomaticamente.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkActivaAutomaticamente.Location = New System.Drawing.Point(12, 44)
        Me.ChkActivaAutomaticamente.Name = "ChkActivaAutomaticamente"
        Me.ChkActivaAutomaticamente.Size = New System.Drawing.Size(188, 23)
        Me.ChkActivaAutomaticamente.TabIndex = 6
        Me.ChkActivaAutomaticamente.Text = "Se activa automaticamente"
        Me.ChkActivaAutomaticamente.UseVisualStyleBackColor = False
        '
        'cboEstado
        '
        Me.cboEstado.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cboEstado.FormattingEnabled = True
        Me.cboEstado.Items.AddRange(New Object() {"", "ACTIVO", "INACTIVO"})
        Me.cboEstado.Location = New System.Drawing.Point(22, 174)
        Me.cboEstado.Name = "cboEstado"
        Me.cboEstado.Size = New System.Drawing.Size(132, 21)
        Me.cboEstado.TabIndex = 28
        Me.cboEstado.Text = "Estado"
        '
        'btnCambiarEstadoForm
        '
        Me.btnCambiarEstadoForm.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnCambiarEstadoForm.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnCambiarEstadoForm.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCambiarEstadoForm.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCambiarEstadoForm.Location = New System.Drawing.Point(268, 174)
        Me.btnCambiarEstadoForm.Name = "btnCambiarEstadoForm"
        Me.btnCambiarEstadoForm.Size = New System.Drawing.Size(127, 44)
        Me.btnCambiarEstadoForm.TabIndex = 29
        Me.btnCambiarEstadoForm.Text = "Cambiar Estado"
        Me.btnCambiarEstadoForm.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(115, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 13)
        Me.Label2.TabIndex = 30
        '
        'DtgvEstadoUsuario
        '
        Me.DtgvEstadoUsuario.AllowUserToAddRows = False
        Me.DtgvEstadoUsuario.AllowUserToDeleteRows = False
        Me.DtgvEstadoUsuario.AllowUserToResizeColumns = False
        Me.DtgvEstadoUsuario.AllowUserToResizeRows = False
        Me.DtgvEstadoUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DtgvEstadoUsuario.Location = New System.Drawing.Point(327, 174)
        Me.DtgvEstadoUsuario.Name = "DtgvEstadoUsuario"
        Me.DtgvEstadoUsuario.ReadOnly = True
        Me.DtgvEstadoUsuario.Size = New System.Drawing.Size(54, 16)
        Me.DtgvEstadoUsuario.TabIndex = 31
        Me.DtgvEstadoUsuario.Visible = False
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(18, 98)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 19)
        Me.Label4.TabIndex = 33
        Me.Label4.Text = "Inicio"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(235, 98)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 19)
        Me.Label3.TabIndex = 34
        Me.Label3.Text = "Final"
        '
        'FrmInactivaactivauser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(460, 251)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnCambiarEstadoForm)
        Me.Controls.Add(Me.cboEstado)
        Me.Controls.Add(Me.ChkActivaAutomaticamente)
        Me.Controls.Add(Me.DTPFECHAHASTA)
        Me.Controls.Add(Me.DTPfECHADESDE)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DtgvEstadoUsuario)
        Me.Name = "FrmInactivaactivauser"
        Me.Text = ".: CAMBIAR ESTADO USUARIO :."
        CType(Me.DtgvEstadoUsuario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents DTPfECHADESDE As DateTimePicker
    Friend WithEvents DTPFECHAHASTA As DateTimePicker
    Friend WithEvents ChkActivaAutomaticamente As CheckBox
    Friend WithEvents cboEstado As ComboBox
    Friend WithEvents btnCambiarEstadoForm As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents DtgvEstadoUsuario As DataGridView
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
End Class
