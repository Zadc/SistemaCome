Public Class frmlogincomedor
    Private dt As New DataTable
    Public Second As Integer
    Public tiempo As Integer = 0
    Public DEFINEUPDATEORDENES As Integer
    Public valortext As String
    Public idusuarioasigna As Integer
    Public _UsuarioNombre As String
    Public _usuarioApellido As String
    Public _Ticketmasivo As String
    Private Sub frmlogincomedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        FrmCocina.Show()
        Mostrartiempos()
    End Sub

    Private Sub btnentrar_Click(sender As Object, e As EventArgs) Handles btnentrar.Click
        _Ticketmasivo = txtLoginComedor.Text
        '   MsgBox(txtLoginComedor.Text)
        Dim fu As New fOrden
        Dim fu2 As New fUsuario
        Dim ve As New vOrden
        Dim ve2 As New vUsuario
        Dim dt2 As New DataTable
        Dim dt As New DataTable
        Dim DT3 As New DataTable
        Dim codigouser As Integer
        Dim iduser As Integer
        Dim UsuarioNombre As String
        Dim UsuarioApellido As String
        Dim validaerror As Integer = 1
        Mostrartiempos()
        ve2.gcodigousuario = txtLoginComedor.Text

        dt2 = fu2.ValidaLoginComedor(ve2)


        ve.gidcomida = tiempo
        ve.gFechaasignada = Today.Date
        ve.gNumeroticketMasivo = txtLoginComedor.Text
        ve.gidestadoticket = 1
        'dt.Reset()
        DT3 = fu.ValidarexistenciA_Masiva(ve)
        If DT3.Rows.Count > 0 Then
            DEFINEUPDATEORDENES = 1
            Frmorden.Show()
            Me.Hide()
            MsgBox("SELECCIONÓ UNA ORDEN MASIVA", MsgBoxStyle.Information)

            valortext = txtLoginComedor.Text
            _Ticketmasivo = txtLoginComedor.Text
            validaerror = 0
        Else
            If dt2.Rows.Count > 0 Then
                iduser = dt2.Rows(0)("IdUsuario")
                codigouser = dt2.Rows(0)("CodigoUsuario")
                UsuarioNombre = dt2.Rows(0)("UsuarioNombre")
                UsuarioApellido = dt2.Rows(0)("UsuarioApellido")
                ' MsgBox("iduser " & iduser & " codigo: " & codigouser & " TIEMPO: " & tiempo & "")
                ve.gOidusuarioasigna = iduser
                idusuarioasigna = iduser

                dt = fu.Validarexistenciao2(ve)
                If dt.Rows.Count > 0 Then
                    Frmorden.Show()
                    Me.Hide()
                    DEFINEUPDATEORDENES = 2
                    valortext = txtLoginComedor.Text
                    MsgBox("SELECCIONÓ UNA ORDEN INDIVIDUAL", MsgBoxStyle.Information)
                    validaerror = 1
                Else
                    'realiza el insert
                    'primero valida orden que no este en estado 2
                    Dim dttneew As New DataTable
                    codigouser = dt2.Rows(0)("CodigoUsuario")
                    ve.gidestadoticket = 2
                    dttneew = fu.Validarexistenciao2(ve)
                    If dttneew.Rows.Count > 0 Then
                        MsgBox("NO SE PUEDE PROCESAR LA SOLICITUD", MsgBoxStyle.Critical)

                    Else
                        Frmorden.Show()
                        DEFINEUPDATEORDENES = 3
                        validaerror = 1
                    End If


                End If

                'revisar

            End If
        End If
        If validaerror = 1 Then

            Dim funUServalidadefinitiva As New fUsuario
            Dim dtval As New DataTable
            dtval = funUServalidadefinitiva.validacodigousuario(txtLoginComedor.Text)
            If dtval.Rows.Count = 0 Then
                MsgBox("No se ha encontrado ningún registro intente nuevamentw", MsgBoxStyle.Critical)
            End If

        End If

    End Sub

    'Seteando Numeros en textbox con Botones  
    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        txtLoginComedor.Text = txtLoginComedor.Text + "1"
    End Sub
    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        txtLoginComedor.Text = txtLoginComedor.Text + "2"
    End Sub
    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        txtLoginComedor.Text = txtLoginComedor.Text + "3"
    End Sub
    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        txtLoginComedor.Text = txtLoginComedor.Text + "4"
    End Sub
    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        txtLoginComedor.Text = txtLoginComedor.Text + "5"
    End Sub
    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        txtLoginComedor.Text = txtLoginComedor.Text + "6"
    End Sub
    Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        txtLoginComedor.Text = txtLoginComedor.Text + "7"
    End Sub
    Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
        txtLoginComedor.Text = txtLoginComedor.Text + "8"
    End Sub
    Private Sub btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click
        txtLoginComedor.Text = txtLoginComedor.Text + "9"
    End Sub
    Private Sub btn0_Click(sender As Object, e As EventArgs) Handles btn0.Click
        txtLoginComedor.Text = txtLoginComedor.Text + "0"
    End Sub
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtLoginComedor.TextChanged
        If txtLoginComedor.Text.Length > 6 Then
            MsgBox("CODIGO SOBREPASA LIMITE PERMITIDO, INTENTE NUEVAMENTE", MsgBoxStyle.Critical)
            txtLoginComedor.Clear()
        End If
    End Sub
    Private Sub Mostrartiempos()
        Dim fun As New FLoginComedor
        dt = fun.Mostrartiempos
        datagvListatiempos.DataSource = dt
        Dim VAL As Integer = 0
        For Each row As DataGridViewRow In datagvListatiempos.Rows
            If Now.TimeOfDay.ToString >= row.Cells(2).Value.ToString And Now.TimeOfDay.ToString <= row.Cells(3).Value.ToString And row.Cells(1).Value = "DESAYUNO" Then
                ' MsgBox("HORA DEL DESAYUNO")
                DESBLOQUEAELEMENTOS()
                VAL = 1
                tiempo = 1
                Exit For
            Else
                If Now.TimeOfDay.ToString >= row.Cells(2).Value.ToString And Now.TimeOfDay.ToString <= row.Cells(3).Value.ToString And row.Cells(1).Value = "ALMUERZO" Then
                    '   MsgBox("HORA DEL ALMUERZO")
                    DESBLOQUEAELEMENTOS()
                    VAL = 1
                    tiempo = 2
                    Exit For
                Else
                    If Now.TimeOfDay.ToString >= row.Cells(2).Value.ToString And Now.TimeOfDay.ToString <= row.Cells(3).Value.ToString And row.Cells(1).Value = "CENA" Then
                        '  MsgBox("HORA DE LA CENA")
                        DESBLOQUEAELEMENTOS()
                        VAL = 1
                        tiempo = 3
                        Exit For
                    End If
                End If
            End If
        Next
        If VAL = 1 Then
            DESBLOQUEAELEMENTOS()
        ElseIf VAL = 0 Then
            BLOQUEAELEMENTOS()
        End If
    End Sub
    Private Sub BLOQUEAELEMENTOS()
        btn0.Enabled = False
        btn1.Enabled = False
        btn2.Enabled = False
        btn3.Enabled = False
        btn4.Enabled = False
        btn5.Enabled = False
        btn6.Enabled = False
        btn7.Enabled = False
        btn8.Enabled = False
        btn9.Enabled = False
        btnentrar.Enabled = False
        btnback.Enabled = False
    End Sub
    Private Sub DESBLOQUEAELEMENTOS()
        btn0.Enabled = True
        btn1.Enabled = True
        btn2.Enabled = True
        btn3.Enabled = True
        btn4.Enabled = True
        btn5.Enabled = True
        btn6.Enabled = True
        btn7.Enabled = True
        btn8.Enabled = True
        btn9.Enabled = True
        btnentrar.Enabled = True
        btnback.Enabled = True
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Second += 1
        Label2.Text = DateTime.Now.ToLongTimeString
        If Second > 30 Then
            Second = 0
            Mostrartiempos()
        End If
    End Sub
    Private Sub btnback_Click(sender As Object, e As EventArgs) Handles btnback.Click
        txtLoginComedor.Clear()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class