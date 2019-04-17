<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAnulaOrdenes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAnulaOrdenes))
        Me.dgvMostrarOrdenes = New System.Windows.Forms.DataGridView()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.picCambiarAnular = New System.Windows.Forms.PictureBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.txtmuestrausuario = New System.Windows.Forms.TextBox()
        Me.picboxback = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.dgvMostrarOrdenes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCambiarAnular, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picboxback, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvMostrarOrdenes
        '
        Me.dgvMostrarOrdenes.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.dgvMostrarOrdenes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMostrarOrdenes.Location = New System.Drawing.Point(49, 83)
        Me.dgvMostrarOrdenes.Name = "dgvMostrarOrdenes"
        Me.dgvMostrarOrdenes.ReadOnly = True
        Me.dgvMostrarOrdenes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvMostrarOrdenes.Size = New System.Drawing.Size(774, 472)
        Me.dgvMostrarOrdenes.TabIndex = 0
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(206, 16)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 1
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(273, 367)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'picCambiarAnular
        '
        Me.picCambiarAnular.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.picCambiarAnular.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.picCambiarAnular.BackgroundImage = CType(resources.GetObject("picCambiarAnular.BackgroundImage"), System.Drawing.Image)
        Me.picCambiarAnular.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.picCambiarAnular.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picCambiarAnular.Location = New System.Drawing.Point(75, 561)
        Me.picCambiarAnular.Name = "picCambiarAnular"
        Me.picCambiarAnular.Size = New System.Drawing.Size(100, 50)
        Me.picCambiarAnular.TabIndex = 4
        Me.picCambiarAnular.TabStop = False
        '
        'ComboBox1
        '
        Me.ComboBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ComboBox1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"SOLICITADO", "ANULADO"})
        Me.ComboBox1.Location = New System.Drawing.Point(204, 12)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(144, 27)
        Me.ComboBox1.TabIndex = 5
        '
        'txtmuestrausuario
        '
        Me.txtmuestrausuario.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtmuestrausuario.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmuestrausuario.Location = New System.Drawing.Point(48, 13)
        Me.txtmuestrausuario.Name = "txtmuestrausuario"
        Me.txtmuestrausuario.Size = New System.Drawing.Size(150, 26)
        Me.txtmuestrausuario.TabIndex = 6
        '
        'picboxback
        '
        Me.picboxback.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.picboxback.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.picboxback.BackgroundImage = CType(resources.GetObject("picboxback.BackgroundImage"), System.Drawing.Image)
        Me.picboxback.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.picboxback.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picboxback.Location = New System.Drawing.Point(229, 561)
        Me.picboxback.Name = "picboxback"
        Me.picboxback.Size = New System.Drawing.Size(100, 50)
        Me.picboxback.TabIndex = 7
        Me.picboxback.TabStop = False
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(73, 614)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 19)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Cancelar Orden"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(258, 614)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 19)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Volver"
        '
        'FrmAnulaOrdenes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(886, 649)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.picboxback)
        Me.Controls.Add(Me.txtmuestrausuario)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.picCambiarAnular)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.dgvMostrarOrdenes)
        Me.Controls.Add(Me.Button2)
        Me.Name = "FrmAnulaOrdenes"
        Me.Text = "FrmAnulaOrdenes"
        CType(Me.dgvMostrarOrdenes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCambiarAnular, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picboxback, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvMostrarOrdenes As DataGridView
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents picCambiarAnular As PictureBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents txtmuestrausuario As TextBox
    Friend WithEvents picboxback As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
End Class
