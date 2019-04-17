
Public Class FrmCocinaVarios
    Private dt As New DataTable
    Public DTIEMPO As Integer
    Private Sub FrmCocinaVarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Dim imagen As Image = Image.FromFile("c:\imagenes\imagen.jpg")

        'DataGridView1.Rows.Add("nombre imagen", imagen)
        'DataGridView1.Rows.Add("", "", "10")
        DataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells
        mostrarOrdenes()
    End Sub

    Private Sub mostrarOrdenes()

        Mostrartiempos()

        Dim fun As New FCocina
        dt = fun.mostrarOrdenesDETALLE(DTIEMPO, Today.Date)
        dtgvdetalles.DataSource = dt

        For Each row As DataGridViewRow In dtgvdetalles.Rows
            Dim DEPARTAMENTO As String
            Dim AREA As String
            Dim CANTIDAD As Integer
            DEPARTAMENTO = row.Cells(0).Value
            AREA = row.Cells(1).Value
            CANTIDAD = row.Cells(2).Value
            DataGridView1.Rows.Add(DEPARTAMENTO, AREA, CANTIDAD)
        Next
        'DEPARTAMENTO = dt.Rows(0)("DepartamentoDescripcion")
        'AREA = dt.Rows(0)("DescripcionArea")
        'CANTIDAD = dt.Rows(0)("CANTIDAD DE PLATOS")
        'MsgBox(DEPARTAMENTO)
        'MsgBox(AREA)
        'MsgBox(CANTIDAD)
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        'DataGridView1.DefaultCellStyle.Font = New Font("Verdana", 16, FontStyle.Bold)

        'Dim NumeroDeFilaSeleccionada As Integer

        'If DataGridView1.CurrentCell.Selected = 3 Then
        '    MsgBox("hola")
        'End If
        'NumeroDeFilaSeleccionada = DataGridView1.CurrentRow.Index()
        'MsgBox(DataGridView1.CurrentCell.ColumnIndex)
        ''MessageBox.Show("Selecciona una fila")
        ''End If
        'If NumeroDeFilaSeleccionada = 3 Then
        '    MsgBox("hola")
        'End If
        Dim var As String


        var = DataGridView1.Rows(e.RowIndex).Cells(3).Value
        Dim area As String
        area = DataGridView1.CurrentRow.Cells(1).Value
        If var <> "" Then
            'MsgBox("no hacer nada")
        Else
            'mostrar frmdetalle
            Dim fun As New FCocina
            dt = fun.mostrarOrdenesdetalleasreas(Today.ToShortDateString, area)

            DtgvVerdetalle.DataSource = dt
        End If

        'DataGridView1.Rows.
    End Sub
    Private Sub Mostrartiempos()
        Dim fun As New FLoginComedor
        dt = fun.Mostrartiempos
        datagvListatiempos.DataSource = dt
        Dim VAL As Integer = 0
        For Each row As DataGridViewRow In datagvListatiempos.Rows
            If Now.TimeOfDay.ToString >= row.Cells(2).Value.ToString And Now.TimeOfDay.ToString <= row.Cells(3).Value.ToString And row.Cells(1).Value = "DESAYUNO" Then

                DTIEMPO = 1
                Exit For
            Else
                If Now.TimeOfDay.ToString >= row.Cells(2).Value.ToString And Now.TimeOfDay.ToString <= row.Cells(3).Value.ToString And row.Cells(1).Value = "ALMUERZO" Then
                    '   MsgBox("HORA DEL ALMUERZO")


                    DTIEMPO = 2
                    Exit For
                Else
                    If Now.TimeOfDay.ToString >= row.Cells(2).Value.ToString And Now.TimeOfDay.ToString <= row.Cells(3).Value.ToString And row.Cells(1).Value = "CENA" Then
                        '  MsgBox("HORA DE LA CENA")


                        DTIEMPO = 3
                        Exit For
                    End If
                End If
            End If
        Next

    End Sub
End Class

