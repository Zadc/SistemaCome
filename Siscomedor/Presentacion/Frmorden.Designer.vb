<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frmorden
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frmorden))
        Me.btnConfirmar = New System.Windows.Forms.Button()
        Me.btncomida = New System.Windows.Forms.Button()
        Me.DatagVistacomida = New System.Windows.Forms.DataGridView()
        Me.btnRefresco = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DomainUpDown2 = New System.Windows.Forms.DomainUpDown()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        CType(Me.DatagVistacomida, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnConfirmar
        '
        Me.btnConfirmar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnConfirmar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfirmar.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfirmar.Image = CType(resources.GetObject("btnConfirmar.Image"), System.Drawing.Image)
        Me.btnConfirmar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnConfirmar.Location = New System.Drawing.Point(357, 491)
        Me.btnConfirmar.Name = "btnConfirmar"
        Me.btnConfirmar.Size = New System.Drawing.Size(145, 61)
        Me.btnConfirmar.TabIndex = 5
        Me.btnConfirmar.Text = "Comfirmar"
        Me.btnConfirmar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnConfirmar.UseVisualStyleBackColor = True
        '
        'btncomida
        '
        Me.btncomida.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btncomida.BackColor = System.Drawing.SystemColors.Desktop
        Me.btncomida.BackgroundImage = CType(resources.GetObject("btncomida.BackgroundImage"), System.Drawing.Image)
        Me.btncomida.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btncomida.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncomida.Location = New System.Drawing.Point(9, 13)
        Me.btncomida.Name = "btncomida"
        Me.btncomida.Size = New System.Drawing.Size(254, 154)
        Me.btncomida.TabIndex = 3
        Me.btncomida.UseVisualStyleBackColor = False
        '
        'DatagVistacomida
        '
        Me.DatagVistacomida.AllowUserToAddRows = False
        Me.DatagVistacomida.AllowUserToDeleteRows = False
        Me.DatagVistacomida.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DatagVistacomida.Location = New System.Drawing.Point(23, 17)
        Me.DatagVistacomida.Name = "DatagVistacomida"
        Me.DatagVistacomida.ReadOnly = True
        Me.DatagVistacomida.Size = New System.Drawing.Size(240, 150)
        Me.DatagVistacomida.TabIndex = 6
        Me.DatagVistacomida.Visible = False
        '
        'btnRefresco
        '
        Me.btnRefresco.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnRefresco.BackColor = System.Drawing.SystemColors.Desktop
        Me.btnRefresco.BackgroundImage = CType(resources.GetObject("btnRefresco.BackgroundImage"), System.Drawing.Image)
        Me.btnRefresco.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnRefresco.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRefresco.Location = New System.Drawing.Point(10, 13)
        Me.btnRefresco.Name = "btnRefresco"
        Me.btnRefresco.Size = New System.Drawing.Size(254, 154)
        Me.btnRefresco.TabIndex = 8
        Me.btnRefresco.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel1.Controls.Add(Me.btncomida)
        Me.Panel1.Controls.Add(Me.DatagVistacomida)
        Me.Panel1.Location = New System.Drawing.Point(137, 127)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(274, 177)
        Me.Panel1.TabIndex = 9
        '
        'Panel2
        '
        Me.Panel2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel2.Controls.Add(Me.btnRefresco)
        Me.Panel2.Location = New System.Drawing.Point(437, 127)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(274, 177)
        Me.Panel2.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(319, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(165, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Nombre de quien esta ordenando"
        '
        'ListBox1
        '
        Me.ListBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ListBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(257, 343)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(379, 93)
        Me.ListBox1.TabIndex = 12
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(611, 491)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(73, 61)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 13
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoEllipsis = True
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Book Antiqua", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(382, 371)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 26)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Label2"
        '
        'DomainUpDown2
        '
        Me.DomainUpDown2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.DomainUpDown2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DomainUpDown2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DomainUpDown2.InterceptArrowKeys = False
        Me.DomainUpDown2.Location = New System.Drawing.Point(642, 371)
        Me.DomainUpDown2.Name = "DomainUpDown2"
        Me.DomainUpDown2.ReadOnly = True
        Me.DomainUpDown2.Size = New System.Drawing.Size(80, 29)
        Me.DomainUpDown2.Sorted = True
        Me.DomainUpDown2.TabIndex = 16
        Me.DomainUpDown2.Text = "0"
        Me.DomainUpDown2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(80, 379)
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(120, 20)
        Me.NumericUpDown1.TabIndex = 17
        '
        'Frmorden
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(840, 607)
        Me.Controls.Add(Me.NumericUpDown1)
        Me.Controls.Add(Me.DomainUpDown2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnConfirmar)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Frmorden"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Realizar Pedido"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DatagVistacomida, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnConfirmar As Button
    Friend WithEvents btncomida As Button
    Friend WithEvents DatagVistacomida As DataGridView
    Friend WithEvents btnRefresco As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents DomainUpDown2 As DomainUpDown
    Friend WithEvents NumericUpDown1 As NumericUpDown
End Class
