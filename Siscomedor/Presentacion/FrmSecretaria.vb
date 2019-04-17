Public Class FrmSecretaria
    Public Rango As Integer
    Private dt As New DataTable
    Public iduser As Integer
    Public idcomida As Integer
    Public fechapublica As Integer

    Private Sub FrmSecretaria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BtnGenerarOrden.Visible = False
        obtenerrango()

        For counter As Integer = 1 To Rango
        Next
        'TODO: esta línea de código carga datos en la tabla 'ComedordbDataSet.Complemento' Puede moverla o quitarla según sea necesario.
        'Me.ComplementoTableAdapter.Fill(Me.ComedordbDataSet.Complemento)
        'TODO: esta línea de código carga datos en la tabla 'ComedorDataSet.Complemento' Puede moverla o quitarla según sea necesario.
        DateTimePicker2.Value = DateAdd(DateInterval.Day, Rango, Today.Date)
        Label3.Text = Rango + 1
        mostrarempleado()
    End Sub
    Private Sub mostrarempleado()
        Dim fun As New FSecretaria
        dt = fun.MostrarEmpleadosDepartamento(FrmLogin._Numerogrupo)
        DataListadoEmpleados.DataSource = dt
        'cambiarcolor()
        'crearcolumna()


        'SolicitarOrden.Items.AddRange("SI", "NO")
        'cambiarcolor()

        'cambiarcolor()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        mostrarempleado()
        'cambiarcolor()
    End Sub
    Private Sub crearcolumna()
        DataListadoEmpleados.Rows.Add(1, 1, 1, "SI")
        Dim cbx As New DataGridViewComboBoxColumn
        With cbx
            .HeaderText = "SOLICITAR ORDEN"
            .Name = "SolicitarOrden"


        End With
    End Sub
    Private Sub cambiarcolor()
        For Each fila As DataGridViewRow In DataListadoEmpleados.Rows
            If fila.Cells(4).Value = 1 Then
                fila.DefaultCellStyle.BackColor = Color.Green
            Else
                If fila.Cells(4).Value = 1 Then
                    fila.DefaultCellStyle.BackColor = Color.Red
                End If
            End If
        Next
    End Sub

    Private Sub DataListadoEmpleados_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataListadoEmpleados.CellContentClick
        'Select Case e.ColumnIndex
        '    Case 0 'o la columan que tenga el checkbox
        '        Dim Celda As DataGridViewCheckBoxCell = DataListadoEmpleados(e.ColumnIndex, e.RowIndex)
        '        Dim CE As CheckState = Celda.Value
        '        If CE = CheckState.Checked Then Celda.Value = CheckState.Unchecked Else Celda.Value = CheckState.Checked
        'End Select

        'Select Case e.ColumnIndex
        '    Case 1 'o la columan que tenga el checkbox
        '        Dim Celda As DataGridViewCheckBoxCell = DataListadoEmpleados(e.ColumnIndex, e.RowIndex)
        '        Dim CE As CheckState = Celda.Value
        '        If CE = CheckState.Checked Then Celda.Value = CheckState.Unchecked Else Celda.Value = CheckState.Checked
        'End Select
        Select Case e.ColumnIndex
            Case 4 'o la columan que tenga el checkbox
                Dim Celda As DataGridViewCheckBoxCell = DataListadoEmpleados(e.ColumnIndex, e.RowIndex)
                Dim CE As CheckState = Celda.Value
                If CE = CheckState.Checked Then Celda.Value = CheckState.Unchecked Else Celda.Value = CheckState.Checked
        End Select
        'cambiarcolor()
    End Sub
    Private Sub Validaantesdeprocesarordenes()
        DatagvOrdenes.Rows.Clear()
        For Each row As DataGridViewRow In DataListadoEmpleados.Rows

            If row.Cells(2).Value = False And row.Cells(3).Value = False And row.Cells(4).Value = False And row.Cells(5).Value = False Then
                row.DefaultCellStyle.BackColor = Color.Red
            Else

                If row.Cells(2).Value = False And row.Cells(3).Value = False And row.Cells(4).Value = False And row.Cells(5).Value = True Then
                    ' MsgBox("Al parecer selecciono una orden para el usuario " + row.Cells(0).Value + " Pero no selecciono Ningun tiempo", MsgBoxStyle.Critical)
                    row.DefaultCellStyle.BackColor = Color.Red
                Else
                    If row.Cells(2).Value = True And row.Cells(3).Value = True And row.Cells(4).Value = True And row.Cells(5).Value = True Then
                        row.DefaultCellStyle.BackColor = Color.Green
                        '  MsgBox("tres")
                        For i As Integer = 0 To Rango
                            DatagvOrdenes.Rows.Add((row.Cells(0).Value), (row.Cells(1).Value), "DESAYUNO", CDate(DateAdd(DateInterval.Day, i, DateTimePicker1.Value.Date)).ToShortDateString)
                            DatagvOrdenes.Rows.Add((row.Cells(0).Value), (row.Cells(1).Value), "ALMUERZO", CDate(DateAdd(DateInterval.Day, i, DateTimePicker1.Value.Date)).ToShortDateString)
                            DatagvOrdenes.Rows.Add((row.Cells(0).Value), (row.Cells(1).Value), "CENA", CDate(DateAdd(DateInterval.Day, i, DateTimePicker1.Value.Date)).ToShortDateString)
                        Next
                    Else
                        If row.Cells(2).Value = True And row.Cells(3).Value = True And row.Cells(4).Value = False And row.Cells(5).Value = True Then
                            '  MsgBox("Insertar desayuno y almuerzo")
                            row.DefaultCellStyle.BackColor = Color.Green
                            For i As Integer = 0 To Rango
                                DatagvOrdenes.Rows.Add((row.Cells(0).Value), (row.Cells(1).Value), "DESAYUNO", CDate(DateAdd(DateInterval.Day, i, DateTimePicker1.Value.Date)).ToShortDateString)
                                DatagvOrdenes.Rows.Add((row.Cells(0).Value), (row.Cells(1).Value), "ALMUERZO", CDate(DateAdd(DateInterval.Day, i, DateTimePicker1.Value.Date)).ToShortDateString)
                            Next

                        Else
                            If row.Cells(2).Value = True And row.Cells(3).Value = False And row.Cells(4).Value = False And row.Cells(5).Value = True Then
                                ' MsgBox("Insertar Solo desayuno")
                                row.DefaultCellStyle.BackColor = Color.Green
                                For i As Integer = 0 To Rango
                                    DatagvOrdenes.Rows.Add((row.Cells(0).Value), (row.Cells(1).Value), "DESAYUNO", CDate(DateAdd(DateInterval.Day, i, DateTimePicker1.Value.Date)).ToShortDateString)
                                Next
                            Else
                                If row.Cells(2).Value = False And row.Cells(3).Value = True And row.Cells(4).Value = True And row.Cells(5).Value = True Then
                                    ' MsgBox("Insertar solo almuerzo y cena")
                                    row.DefaultCellStyle.BackColor = Color.Green
                                    For i As Integer = 0 To Rango
                                        DatagvOrdenes.Rows.Add((row.Cells(0).Value), (row.Cells(1).Value), "ALMUERZO", CDate(DateAdd(DateInterval.Day, i, DateTimePicker1.Value.Date)).ToShortDateString)
                                        DatagvOrdenes.Rows.Add((row.Cells(0).Value), (row.Cells(1).Value), "CENA", CDate(DateAdd(DateInterval.Day, i, DateTimePicker1.Value.Date)).ToShortDateString)
                                    Next

                                Else

                                    If row.Cells(2).Value = False And row.Cells(3).Value = False And row.Cells(4).Value = True And row.Cells(5).Value = True Then
                                        ' MsgBox("Insertar solo cena")
                                        row.DefaultCellStyle.BackColor = Color.Green
                                        For i As Integer = 0 To Rango
                                            DatagvOrdenes.Rows.Add((row.Cells(0).Value), (row.Cells(1).Value), "CENA", CDate(DateAdd(DateInterval.Day, i, DateTimePicker1.Value.Date)).ToShortDateString)
                                        Next

                                    Else

                                        If row.Cells(2).Value = False And row.Cells(3).Value = True And row.Cells(4).Value = False And row.Cells(5).Value = True Then
                                            ' MsgBox("Solo almuerzo")
                                            row.DefaultCellStyle.BackColor = Color.Green
                                            For i As Integer = 0 To Rango
                                                DatagvOrdenes.Rows.Add((row.Cells(0).Value), (row.Cells(1).Value), "ALMUERZO", CDate(DateAdd(DateInterval.Day, i, DateTimePicker1.Value.Date)).ToShortDateString)
                                            Next

                                        Else

                                            If row.Cells(2).Value = True And row.Cells(3).Value = False And row.Cells(4).Value = True And row.Cells(5).Value = True Then
                                                'MsgBox("Pedir solo desayuno y cena")
                                                row.DefaultCellStyle.BackColor = Color.Green
                                                For i As Integer = 0 To Rango
                                                    DatagvOrdenes.Rows.Add((row.Cells(0).Value), (row.Cells(1).Value), "DESAYUNO", CDate(DateAdd(DateInterval.Day, i, DateTimePicker1.Value.Date)).ToShortDateString)
                                                    DatagvOrdenes.Rows.Add((row.Cells(0).Value), (row.Cells(1).Value), "CENA", CDate(DateAdd(DateInterval.Day, i, DateTimePicker1.Value.Date)).ToShortDateString)
                                                    MsgBox(CDate(DateAdd(DateInterval.Day, i, DateTimePicker1.Value.Date)))
                                                Next
                                            Else
                                                If row.Cells(5).Value = False Then
                                                    row.DefaultCellStyle.BackColor = Color.Red

                                                End If


                                            End If
                                        End If
                                    End If

                                End If
                            End If

                        End If
                    End If




                End If


            End If
            'If fila.Cells(4).Value = True Then
            '    fila.DefaultCellStyle.BackColor = Color.Green
            'Else
            '    If fila.Cells(4).Value = False Then
            '        fila.DefaultCellStyle.BackColor = Color.Red
            '    End If
            'End If

        Next

        MsgBox(Rango)
        validaordenesexistentes()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BtnValidar.Click
        validaordenesexistentes()
        MsgBox(Rango)
        DatagvOrdenes.Rows.Clear()
        For Each row As DataGridViewRow In DataListadoEmpleados.Rows

            If row.Cells(2).Value = False And row.Cells(3).Value = False And row.Cells(4).Value = False And row.Cells(5).Value = False Then
                row.DefaultCellStyle.BackColor = Color.Red
            Else

                If row.Cells(2).Value = False And row.Cells(3).Value = False And row.Cells(4).Value = False And row.Cells(5).Value = True Then
                    ' MsgBox("Al parecer selecciono una orden para el usuario " + row.Cells(0).Value + " Pero no selecciono Ningun tiempo", MsgBoxStyle.Critical)
                    row.DefaultCellStyle.BackColor = Color.Red
                Else
                    If row.Cells(2).Value = True And row.Cells(3).Value = True And row.Cells(4).Value = True And row.Cells(5).Value = True Then
                        row.DefaultCellStyle.BackColor = Color.Green
                        '  MsgBox("tres")
                        For i As Integer = 0 To Rango
                            DatagvOrdenes.Rows.Add((row.Cells(0).Value), (row.Cells(1).Value), "DESAYUNO", CDate(DateAdd(DateInterval.Day, i, DateTimePicker1.Value.Date)).ToShortDateString)
                            DatagvOrdenes.Rows.Add((row.Cells(0).Value), (row.Cells(1).Value), "ALMUERZO", CDate(DateAdd(DateInterval.Day, i, DateTimePicker1.Value.Date)).ToShortDateString)
                            DatagvOrdenes.Rows.Add((row.Cells(0).Value), (row.Cells(1).Value), "CENA", CDate(DateAdd(DateInterval.Day, i, DateTimePicker1.Value.Date)).ToShortDateString)
                        Next
                    Else
                        If row.Cells(2).Value = True And row.Cells(3).Value = True And row.Cells(4).Value = False And row.Cells(5).Value = True Then
                            '  MsgBox("Insertar desayuno y almuerzo")
                            row.DefaultCellStyle.BackColor = Color.Green
                            For i As Integer = 0 To Rango
                                DatagvOrdenes.Rows.Add((row.Cells(0).Value), (row.Cells(1).Value), "DESAYUNO", CDate(DateAdd(DateInterval.Day, i, DateTimePicker1.Value.Date)).ToShortDateString)
                                DatagvOrdenes.Rows.Add((row.Cells(0).Value), (row.Cells(1).Value), "ALMUERZO", CDate(DateAdd(DateInterval.Day, i, DateTimePicker1.Value.Date)).ToShortDateString)
                            Next

                        Else
                            If row.Cells(2).Value = True And row.Cells(3).Value = False And row.Cells(4).Value = False And row.Cells(5).Value = True Then
                                ' MsgBox("Insertar Solo desayuno")
                                row.DefaultCellStyle.BackColor = Color.Green
                                For i As Integer = 0 To Rango
                                    DatagvOrdenes.Rows.Add((row.Cells(0).Value), (row.Cells(1).Value), "DESAYUNO", CDate(DateAdd(DateInterval.Day, i, DateTimePicker1.Value.Date)).ToShortDateString)
                                Next
                            Else
                                If row.Cells(2).Value = False And row.Cells(3).Value = True And row.Cells(4).Value = True And row.Cells(5).Value = True Then
                                    ' MsgBox("Insertar solo almuerzo y cena")
                                    row.DefaultCellStyle.BackColor = Color.Green
                                    For i As Integer = 0 To Rango
                                        DatagvOrdenes.Rows.Add((row.Cells(0).Value), (row.Cells(1).Value), "ALMUERZO", CDate(DateAdd(DateInterval.Day, i, DateTimePicker1.Value.Date)).ToShortDateString)
                                        DatagvOrdenes.Rows.Add((row.Cells(0).Value), (row.Cells(1).Value), "CENA", CDate(DateAdd(DateInterval.Day, i, DateTimePicker1.Value.Date)).ToShortDateString)
                                    Next

                                Else

                                    If row.Cells(2).Value = False And row.Cells(3).Value = False And row.Cells(4).Value = True And row.Cells(5).Value = True Then
                                        ' MsgBox("Insertar solo cena")
                                        row.DefaultCellStyle.BackColor = Color.Green
                                        For i As Integer = 0 To Rango
                                            DatagvOrdenes.Rows.Add((row.Cells(0).Value), (row.Cells(1).Value), "CENA", CDate(DateAdd(DateInterval.Day, i, DateTimePicker1.Value.Date)).ToShortDateString)
                                        Next

                                    Else

                                        If row.Cells(2).Value = False And row.Cells(3).Value = True And row.Cells(4).Value = False And row.Cells(5).Value = True Then
                                            ' MsgBox("Solo almuerzo")
                                            row.DefaultCellStyle.BackColor = Color.Green
                                            For i As Integer = 0 To Rango
                                                DatagvOrdenes.Rows.Add((row.Cells(0).Value), (row.Cells(1).Value), "ALMUERZO", CDate(DateAdd(DateInterval.Day, i, DateTimePicker1.Value.Date)).ToShortDateString)
                                            Next

                                        Else

                                            If row.Cells(2).Value = True And row.Cells(3).Value = False And row.Cells(4).Value = True And row.Cells(5).Value = True Then
                                                'MsgBox("Pedir solo desayuno y cena")
                                                row.DefaultCellStyle.BackColor = Color.Green
                                                For i As Integer = 0 To Rango
                                                    DatagvOrdenes.Rows.Add((row.Cells(0).Value), (row.Cells(1).Value), "DESAYUNO", CDate(DateAdd(DateInterval.Day, i, DateTimePicker1.Value.Date)).ToShortDateString)
                                                    DatagvOrdenes.Rows.Add((row.Cells(0).Value), (row.Cells(1).Value), "CENA", CDate(DateAdd(DateInterval.Day, i, DateTimePicker1.Value.Date)).ToShortDateString)
                                                Next
                                            Else
                                                If row.Cells(5).Value = False Then
                                                    row.DefaultCellStyle.BackColor = Color.Red

                                                End If


                                            End If
                                        End If
                                    End If

                                End If
                            End If

                        End If
                    End If




                End If


            End If


        Next
        validaordenesexistentes()
        BtnGenerarOrden.Visible = True
        BtnValidar.Visible = False
    End Sub

    Private Sub ComplementoBindingSource_CurrentChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub BtnGenerarOrden_Click(sender As Object, e As EventArgs) Handles BtnGenerarOrden.Click
        Validaantesdeprocesarordenes()

        Dim result As DialogResult
        result = MessageBox.Show("Seguro que va a generar las ordenes para su departamento", "ADVERTENCIA", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        If result = DialogResult.OK Then

            Dim fun As New fOrden

            Try
                Dim CONTADORVERDE As Integer = 0
                Dim cantidadinserts As Integer = 0
                For Each ROW As DataGridViewRow In DatagvOrdenes.Rows

                    'ACA SE DETERMINA  EL TIEMPO QUE SE VA A INSERTAR EN LA BASE DE DATOS
                    Dim TIEMPO As Integer = 0
                    If ROW.Cells(2).Value = "DESAYUNO" Then
                        TIEMPO = 1
                    Else
                        If ROW.Cells(2).Value = "ALMUERZO" Then
                            TIEMPO = 2
                        Else
                            If ROW.Cells(2).Value = "CENA" Then
                                TIEMPO = 3
                            End If
                        End If
                    End If
                    Dim dts As New vOrden
                    Dim func As New FSecretaria

                    'aca faltan asignar los valores que se obtengan del login 
                    dts.gOidusuariocrea = FrmLogin._IdUsuario
                    dts.gOidusuarioasigna = ROW.Cells(0).Value
                    dts.gidcomida = TIEMPO
                    dts.gidComplemento = 1
                    dts.gFechaasignada = ROW.Cells(3).Value
                    dts.gidestadoticket = 1
                    dts.gNumeroticketMasivo = FrmLogin._NUMEROtICKETMASIVO



                    If ROW.DefaultCellStyle.BackColor = Color.Green Then
                        CONTADORVERDE = CONTADORVERDE + 1
                        If func.InsertarORDEN(dts) = True Then

                            cantidadinserts = cantidadinserts + 1
                        Else
                            MsgBox("NO SE PUDO PROCESAR LA ORDEN", MsgBoxStyle.Critical)

                        End If
                    End If

                Next
                If CONTADORVERDE = cantidadinserts Then
                    MsgBox("SE HAN GENERADO " & CONTADORVERDE & " DE ORDENES PARA SU DEPARTAMENTO EXITOSAMENTE ", MsgBoxStyle.Information)
                End If
            Catch ex As Exception

            End Try

        End If
        BtnValidar.Visible = True
        BtnGenerarOrden.Visible = False
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        DateTimePicker2.Value = DateAdd(DateInterval.Day, Rango, DateTimePicker1.Value)
        VALIDAFECHAPICKERS()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        'Dim i As Integer = 0
        obtenerrango()
        For counter As Integer = 1 To Rango
        Next
    End Sub
    Private Sub obtenerrango()
        Dim r As Integer
        Dim fun As New FSecretaria
        dt = fun.OBTENERRANGO(FrmLogin._IdUsuario)
        DtgvRango.DataSource = dt
        For Each fila As DataGridViewRow In DtgvRango.Rows

            r = fila.Cells(1).Value
        Next
        Rango = r - 1
    End Sub
    Private Sub validaordenesexistentes()
        For Each ROW1 As DataGridViewRow In DatagvOrdenes.Rows
            Dim TIEMPO2 As Integer = 0
            'Dim fun As New fOrden
            If ROW1.Cells(2).Value = "DESAYUNO" Then
                TIEMPO2 = 1
            Else
                If ROW1.Cells(2).Value = "ALMUERZO" Then
                    TIEMPO2 = 2
                Else
                    If ROW1.Cells(2).Value = "CENA" Then
                        TIEMPO2 = 3
                    End If
                End If

            End If
            Dim fu As New fOrden
            Dim ve As New vOrden
            Dim fuuser As New fUsuario
            Dim veuser As New vUsuario
            Dim dt As New DataTable
            Dim dt2 As New DataTable
            Dim validaturnoB As Integer
            'Dim recorrer As Integer
            'recorrer = DatagvOrdenes.Rows.Count
            'For i As Integer = 0 To recorrer


            ve.gOidusuarioasigna = ROW1.Cells(0).Value
            ve.gidcomida = TIEMPO2
            ve.gFechaasignada = ROW1.Cells(3).Value
            ve.gidestadoticket = 1
            'dt.Reset()
            veuser.gidusuario = ROW1.Cells(0).Value
            dt2 = fu.ValidarturnoUsuario(veuser)
            If dt2.Rows.Count > 0 Then
                validaturnoB = 1
                'MsgBox("turnob")
            End If
            dt = fu.Validarexistenciao2(ve)
            ' MsgBox("tiempo " & ROW1.Cells(2).Value & " USUARIO " & ROW1.Cells(1).Value & "")
            If dt.Rows.Count > 0 Then
                MsgBox("NO SE PUEDE GENERAR LA ORDEN PARA EL USUARIO " & ROW1.Cells(1).Value & " EN LA FECHA " & ROW1.Cells(3).Value & "", MsgBoxStyle.Critical)
                ROW1.DefaultCellStyle.BackColor = Color.Red

            Else

                ROW1.DefaultCellStyle.BackColor = Color.Green
                If validaturnoB = 1 And TIEMPO2 = 2 Then
                    ROW1.DefaultCellStyle.BackColor = Color.Red

                End If
                If validaturnoB = 1 And TIEMPO2 = 1 Then
                    ROW1.DefaultCellStyle.BackColor = Color.Red
                End If
            End If

        Next
    End Sub
    Private Sub VALIDAFECHAPICKERS()
        If DateTimePicker1.Value.Date < Today.Date Then
            MsgBox("La fecha inicial no puede ser menor a la fecha actual", MsgBoxStyle.Critical)
            DateTimePicker1.Value = Today.Date

        End If
    End Sub

    Private Sub btnTurnos_Click(sender As Object, e As EventArgs) Handles btnTurnos.Click
        FrmTurnos.Show()

    End Sub

    Private Sub btnAnularOrdenes_Click(sender As Object, e As EventArgs) Handles btnAnularOrdenes.Click
        FrmAnulaOrdenes.Show()

    End Sub

    Private Sub picboxregresar_Click(sender As Object, e As EventArgs) Handles picboxregresar.Click
        Me.Close()

        FrmMenu.Show()

    End Sub
End Class