<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Lista
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
        Me.components = New System.ComponentModel.Container()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.ComedordbDataSet = New Siscomedor.comedordbDataSet()
        Me.ComedordbDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComplementoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComplementoTableAdapter = New Siscomedor.comedordbDataSetTableAdapters.ComplementoTableAdapter()
        CType(Me.ComedordbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComedordbDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComplementoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListBox1
        '
        Me.ListBox1.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ComedordbDataSet, "Complemento.ComplementoEstado", True))
        Me.ListBox1.DataSource = Me.ComplementoBindingSource
        Me.ListBox1.DisplayMember = "IdComplemento"
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(297, 115)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(120, 95)
        Me.ListBox1.TabIndex = 0
        Me.ListBox1.ValueMember = "ComplementoDescripcion"
        '
        'ComedordbDataSet
        '
        Me.ComedordbDataSet.DataSetName = "comedordbDataSet"
        Me.ComedordbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ComedordbDataSetBindingSource
        '
        Me.ComedordbDataSetBindingSource.DataSource = Me.ComedordbDataSet
        Me.ComedordbDataSetBindingSource.Position = 0
        '
        'ComplementoBindingSource
        '
        Me.ComplementoBindingSource.DataMember = "Complemento"
        Me.ComplementoBindingSource.DataSource = Me.ComedordbDataSetBindingSource
        '
        'ComplementoTableAdapter
        '
        Me.ComplementoTableAdapter.ClearBeforeFill = True
        '
        'Lista
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ListBox1)
        Me.Name = "Lista"
        Me.Text = "Lista"
        CType(Me.ComedordbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComedordbDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComplementoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents ComedordbDataSetBindingSource As BindingSource
    Friend WithEvents ComedordbDataSet As comedordbDataSet
    Friend WithEvents ComplementoBindingSource As BindingSource
    Friend WithEvents ComplementoTableAdapter As comedordbDataSetTableAdapters.ComplementoTableAdapter
End Class
