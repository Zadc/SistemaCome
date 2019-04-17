<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCocina
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
        Dim ListViewGroup1 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("areas", System.Windows.Forms.HorizontalAlignment.Left)
        Me.dvgMuestraOrdenes = New System.Windows.Forms.DataGridView()
        Me.TIEMPO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EMPLEADO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.COMPLEMENTO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AREA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DETALLE = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.datagvMostrarConsultaordenesProcesadas = New System.Windows.Forms.DataGridView()
        Me.ListView1 = New System.Windows.Forms.ListView()
        CType(Me.dvgMuestraOrdenes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.datagvMostrarConsultaordenesProcesadas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dvgMuestraOrdenes
        '
        Me.dvgMuestraOrdenes.AllowUserToAddRows = False
        Me.dvgMuestraOrdenes.AllowUserToDeleteRows = False
        Me.dvgMuestraOrdenes.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.dvgMuestraOrdenes.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dvgMuestraOrdenes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dvgMuestraOrdenes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TIEMPO, Me.EMPLEADO, Me.COMPLEMENTO, Me.AREA, Me.DETALLE})
        Me.dvgMuestraOrdenes.Location = New System.Drawing.Point(30, 74)
        Me.dvgMuestraOrdenes.Name = "dvgMuestraOrdenes"
        Me.dvgMuestraOrdenes.ReadOnly = True
        Me.dvgMuestraOrdenes.Size = New System.Drawing.Size(811, 126)
        Me.dvgMuestraOrdenes.TabIndex = 0
        '
        'TIEMPO
        '
        Me.TIEMPO.HeaderText = "TIEMPO"
        Me.TIEMPO.Name = "TIEMPO"
        Me.TIEMPO.ReadOnly = True
        '
        'EMPLEADO
        '
        Me.EMPLEADO.HeaderText = "EMPLEADO"
        Me.EMPLEADO.Name = "EMPLEADO"
        Me.EMPLEADO.ReadOnly = True
        '
        'COMPLEMENTO
        '
        Me.COMPLEMENTO.HeaderText = "COMPLEMENTO"
        Me.COMPLEMENTO.Name = "COMPLEMENTO"
        Me.COMPLEMENTO.ReadOnly = True
        '
        'AREA
        '
        Me.AREA.HeaderText = "AREA"
        Me.AREA.Name = "AREA"
        Me.AREA.ReadOnly = True
        '
        'DETALLE
        '
        Me.DETALLE.HeaderText = "VER DETALLE"
        Me.DETALLE.Name = "DETALLE"
        Me.DETALLE.ReadOnly = True
        '
        'Timer1
        '
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(299, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Label1"
        '
        'datagvMostrarConsultaordenesProcesadas
        '
        Me.datagvMostrarConsultaordenesProcesadas.AllowUserToAddRows = False
        Me.datagvMostrarConsultaordenesProcesadas.AllowUserToDeleteRows = False
        Me.datagvMostrarConsultaordenesProcesadas.AllowUserToResizeColumns = False
        Me.datagvMostrarConsultaordenesProcesadas.AllowUserToResizeRows = False
        Me.datagvMostrarConsultaordenesProcesadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datagvMostrarConsultaordenesProcesadas.Location = New System.Drawing.Point(146, 50)
        Me.datagvMostrarConsultaordenesProcesadas.Name = "datagvMostrarConsultaordenesProcesadas"
        Me.datagvMostrarConsultaordenesProcesadas.ReadOnly = True
        Me.datagvMostrarConsultaordenesProcesadas.Size = New System.Drawing.Size(418, 150)
        Me.datagvMostrarConsultaordenesProcesadas.TabIndex = 2
        '
        'ListView1
        '
        Me.ListView1.GridLines = True
        ListViewGroup1.Header = "areas"
        ListViewGroup1.Name = "ListVieWareas"
        Me.ListView1.Groups.AddRange(New System.Windows.Forms.ListViewGroup() {ListViewGroup1})
        Me.ListView1.Location = New System.Drawing.Point(89, 270)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(324, 97)
        Me.ListView1.TabIndex = 3
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'FrmCocina
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(904, 571)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.datagvMostrarConsultaordenesProcesadas)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dvgMuestraOrdenes)
        Me.Location = New System.Drawing.Point(3000, 0)
        Me.Name = "FrmCocina"
        Me.Text = "FrmCocina"
        CType(Me.dvgMuestraOrdenes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.datagvMostrarConsultaordenesProcesadas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dvgMuestraOrdenes As DataGridView
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label1 As Label
    Friend WithEvents datagvMostrarConsultaordenesProcesadas As DataGridView
    Friend WithEvents TIEMPO As DataGridViewTextBoxColumn
    Friend WithEvents EMPLEADO As DataGridViewTextBoxColumn
    Friend WithEvents COMPLEMENTO As DataGridViewTextBoxColumn
    Friend WithEvents AREA As DataGridViewTextBoxColumn
    Friend WithEvents DETALLE As DataGridViewImageColumn
    Friend WithEvents ListView1 As ListView
End Class
