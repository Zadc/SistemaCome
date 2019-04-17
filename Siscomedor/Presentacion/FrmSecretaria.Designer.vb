<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSecretaria
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmSecretaria))
        Me.DataListadoEmpleados = New System.Windows.Forms.DataGridView()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.BtnValidar = New System.Windows.Forms.Button()
        Me.lblfiltrar = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DatagvOrdenes = New System.Windows.Forms.DataGridView()
        Me.ComplementoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComedordbDataSet = New Siscomedor.comedordbDataSet()
        Me.ComplementoTableAdapter = New Siscomedor.comedordbDataSetTableAdapters.ComplementoTableAdapter()
        Me.BtnGenerarOrden = New System.Windows.Forms.Button()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.DtgvRango = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnTurnos = New System.Windows.Forms.Button()
        Me.btnAnularOrdenes = New System.Windows.Forms.Button()
        Me.picboxregresar = New System.Windows.Forms.PictureBox()
        Me.SECUENCIAL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EMPLEADO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TIEMPO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FECHA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataListadoEmpleados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatagvOrdenes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComplementoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComedordbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DtgvRango, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picboxregresar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataListadoEmpleados
        '
        Me.DataListadoEmpleados.AllowUserToAddRows = False
        Me.DataListadoEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataListadoEmpleados.Location = New System.Drawing.Point(65, 133)
        Me.DataListadoEmpleados.Name = "DataListadoEmpleados"
        Me.DataListadoEmpleados.Size = New System.Drawing.Size(625, 386)
        Me.DataListadoEmpleados.TabIndex = 2
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(253, 91)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(195, 20)
        Me.TextBox2.TabIndex = 3
        Me.TextBox2.Visible = False
        '
        'BtnValidar
        '
        Me.BtnValidar.Location = New System.Drawing.Point(696, 88)
        Me.BtnValidar.Name = "BtnValidar"
        Me.BtnValidar.Size = New System.Drawing.Size(75, 24)
        Me.BtnValidar.TabIndex = 4
        Me.BtnValidar.Text = "Validar "
        Me.BtnValidar.UseVisualStyleBackColor = True
        '
        'lblfiltrar
        '
        Me.lblfiltrar.AutoSize = True
        Me.lblfiltrar.Location = New System.Drawing.Point(199, 99)
        Me.lblfiltrar.Name = "lblfiltrar"
        Me.lblfiltrar.Size = New System.Drawing.Size(32, 13)
        Me.lblfiltrar.TabIndex = 5
        Me.lblfiltrar.Text = "Filtrar"
        Me.lblfiltrar.Visible = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(586, 89)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'DatagvOrdenes
        '
        Me.DatagvOrdenes.AllowUserToAddRows = False
        Me.DatagvOrdenes.AllowUserToDeleteRows = False
        Me.DatagvOrdenes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DatagvOrdenes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SECUENCIAL, Me.EMPLEADO, Me.TIEMPO, Me.FECHA})
        Me.DatagvOrdenes.Location = New System.Drawing.Point(99, 549)
        Me.DatagvOrdenes.Name = "DatagvOrdenes"
        Me.DatagvOrdenes.Size = New System.Drawing.Size(614, 150)
        Me.DatagvOrdenes.TabIndex = 7
        '
        'ComplementoBindingSource
        '
        Me.ComplementoBindingSource.DataMember = "Complemento"
        Me.ComplementoBindingSource.DataSource = Me.ComedordbDataSet
        '
        'ComedordbDataSet
        '
        Me.ComedordbDataSet.DataSetName = "comedordbDataSet"
        Me.ComedordbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ComplementoTableAdapter
        '
        Me.ComplementoTableAdapter.ClearBeforeFill = True
        '
        'BtnGenerarOrden
        '
        Me.BtnGenerarOrden.Location = New System.Drawing.Point(696, 315)
        Me.BtnGenerarOrden.Name = "BtnGenerarOrden"
        Me.BtnGenerarOrden.Size = New System.Drawing.Size(75, 56)
        Me.BtnGenerarOrden.TabIndex = 8
        Me.BtnGenerarOrden.Text = "PROCESAR ORDEN"
        Me.BtnGenerarOrden.UseVisualStyleBackColor = True
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "yyyy;MM;dd"
        Me.DateTimePicker1.Location = New System.Drawing.Point(85, 28)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(82, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(166, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Fecha desde la que se generaran"
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.CustomFormat = "yyyy;MM;dd"
        Me.DateTimePicker2.Enabled = False
        Me.DateTimePicker2.Location = New System.Drawing.Point(304, 27)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker2.TabIndex = 11
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(503, 177)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(60, 73)
        Me.DataGridView1.TabIndex = 13
        Me.DataGridView1.Visible = False
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(471, 89)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 14
        Me.Button3.Text = "Button3"
        Me.Button3.UseVisualStyleBackColor = True
        Me.Button3.Visible = False
        '
        'DtgvRango
        '
        Me.DtgvRango.AllowUserToAddRows = False
        Me.DtgvRango.AllowUserToDeleteRows = False
        Me.DtgvRango.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DtgvRango.Location = New System.Drawing.Point(154, 215)
        Me.DtgvRango.Name = "DtgvRango"
        Me.DtgvRango.ReadOnly = True
        Me.DtgvRango.Size = New System.Drawing.Size(77, 74)
        Me.DtgvRango.TabIndex = 15
        Me.DtgvRango.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(529, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 13)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "DIAS A GENERAR :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(651, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Label3"
        '
        'btnTurnos
        '
        Me.btnTurnos.Location = New System.Drawing.Point(777, 89)
        Me.btnTurnos.Name = "btnTurnos"
        Me.btnTurnos.Size = New System.Drawing.Size(75, 23)
        Me.btnTurnos.TabIndex = 18
        Me.btnTurnos.Text = "TURNOS"
        Me.btnTurnos.UseVisualStyleBackColor = True
        '
        'btnAnularOrdenes
        '
        Me.btnAnularOrdenes.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnAnularOrdenes.Location = New System.Drawing.Point(696, 456)
        Me.btnAnularOrdenes.Name = "btnAnularOrdenes"
        Me.btnAnularOrdenes.Size = New System.Drawing.Size(89, 63)
        Me.btnAnularOrdenes.TabIndex = 19
        Me.btnAnularOrdenes.Text = "Cambiar Ordenes"
        Me.btnAnularOrdenes.UseVisualStyleBackColor = True
        '
        'picboxregresar
        '
        Me.picboxregresar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.picboxregresar.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.picboxregresar.BackgroundImage = CType(resources.GetObject("picboxregresar.BackgroundImage"), System.Drawing.Image)
        Me.picboxregresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.picboxregresar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picboxregresar.Location = New System.Drawing.Point(710, 239)
        Me.picboxregresar.Name = "picboxregresar"
        Me.picboxregresar.Size = New System.Drawing.Size(100, 50)
        Me.picboxregresar.TabIndex = 20
        Me.picboxregresar.TabStop = False
        '
        'SECUENCIAL
        '
        Me.SECUENCIAL.HeaderText = "SECUENCIAL"
        Me.SECUENCIAL.Name = "SECUENCIAL"
        Me.SECUENCIAL.ReadOnly = True
        '
        'EMPLEADO
        '
        Me.EMPLEADO.HeaderText = "EMPLEADO"
        Me.EMPLEADO.Name = "EMPLEADO"
        Me.EMPLEADO.ReadOnly = True
        '
        'TIEMPO
        '
        Me.TIEMPO.HeaderText = "TIEMPO"
        Me.TIEMPO.Name = "TIEMPO"
        Me.TIEMPO.ReadOnly = True
        Me.TIEMPO.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.TIEMPO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'FECHA
        '
        Me.FECHA.HeaderText = "FECHA"
        Me.FECHA.Name = "FECHA"
        Me.FECHA.ReadOnly = True
        Me.FECHA.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.FECHA.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'FrmSecretaria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(874, 742)
        Me.Controls.Add(Me.picboxregresar)
        Me.Controls.Add(Me.btnAnularOrdenes)
        Me.Controls.Add(Me.btnTurnos)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.BtnGenerarOrden)
        Me.Controls.Add(Me.DatagvOrdenes)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblfiltrar)
        Me.Controls.Add(Me.BtnValidar)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.DataListadoEmpleados)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.DtgvRango)
        Me.Name = "FrmSecretaria"
        Me.Text = "FrmSecretaria"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DataListadoEmpleados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatagvOrdenes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComplementoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComedordbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DtgvRango, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picboxregresar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataListadoEmpleados As DataGridView
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents BtnValidar As Button
    Friend WithEvents lblfiltrar As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents DatagvOrdenes As DataGridView
    Friend WithEvents ComedordbDataSet As comedordbDataSet
    Friend WithEvents ComplementoBindingSource As BindingSource
    Friend WithEvents ComplementoTableAdapter As comedordbDataSetTableAdapters.ComplementoTableAdapter
    Friend WithEvents BtnGenerarOrden As Button
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button3 As Button
    Friend WithEvents DtgvRango As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnTurnos As Button
    Friend WithEvents btnAnularOrdenes As Button
    Friend WithEvents picboxregresar As PictureBox
    Friend WithEvents SECUENCIAL As DataGridViewTextBoxColumn
    Friend WithEvents EMPLEADO As DataGridViewTextBoxColumn
    Friend WithEvents TIEMPO As DataGridViewTextBoxColumn
    Friend WithEvents FECHA As DataGridViewTextBoxColumn
End Class
