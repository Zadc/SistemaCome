Public Class Frm_Asigna_ticketmasivo
    Private Dt As New DataTable
    Public rango As Integer
    Private Sub Frm_Asigna_ticketmasivo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Rangoget()
        Label1.Text = FrmLogin._UsuarioNombre & " " & FrmLogin._UsuarioApellido
        ComboBox1.Items.Add(1)
        ComboBox1.Items.Add(2)
        ComboBox1.Items.Add(3)
        ComboBox1.Items.Add(4)
        ComboBox1.Items.Add(5)
        ComboBox1.Items.Add(6)
        ComboBox1.Items.Add(7)
        ComboBox1.Items.Add(8)
        ComboBox1.Items.Add(9)
        ComboBox1.Items.Add(10)
        ComboBox1.Items.Add(11)
        ComboBox1.Items.Add(12)


    End Sub

    Private Sub Validanumeroticketmasivo()
        Rangoget()
        If Val(ComboBox1.Text) > rango Then
            MsgBox("No es un valor permitido Intente con un valor menor o igual que " & rango & "")
        Else
            Try
                Dim dt3 As New DataTable
                Dim VTICKETMASIVO As New VticketMasivo
                Dim FUTICKETMASIVO As New FTicketmasivo
                VTICKETMASIVO.gid_Usuario = FrmLogin._IdUsuario
                VTICKETMASIVO.getNumeroticketMasivo = TextBox1.Text
                VTICKETMASIVO.getdiasagenerar = Val(ComboBox1.Text)
                dt3 = FUTICKETMASIVO.ValidapARANOREPETIRCODIGOMASIVO(VTICKETMASIVO)
                If dt3.Rows.Count > 0 Then
                    MsgBox("NO PUEDE USAR ESE NUMERO DE TICKET INTENTE CON OTRO", MsgBoxStyle.Critical)
                    ErrorP.SetError(TextBox1, "DEBE INGRESAR OTRO NUMERO")
                Else
                    If FUTICKETMASIVO.InserTAR_ACTUALIZAR_USUARIOTICKETMASIVO(VTICKETMASIVO) = True Then
                        MsgBox("NUMERO DE TICKET PARA COBROS MASIVOS REGISTRADO EXITOSAMENTE", MsgBoxStyle.Information)
                    Else
                        MsgBox("NO SE HA PODIDO ALMACENAR EL REGISTRO, INTENTE NUEVAMENTE", MsgBoxStyle.Critical)
                    End If
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

        End If

    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        Validanumeroticketmasivo()

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        ErrorP.Clear()

    End Sub

    Private Sub Rangoget()
        Dim fun As New FSecretaria
        Dt = fun.OBTENERRANGO(FrmLogin._IdUsuario)
        If Dt.Rows.Count > 0 Then
            rango = Dt.Rows(0)("DiasaGenerar")
        End If
        rango = rango
        For I As Integer = 1 To rango
            I = I + 1
            rango = I
        Next

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Rangoget()
        If Val(ComboBox1.Text) > rango Then
            MsgBox("No es un valor permitido Intente con un valor menor o igual que " & rango & "")
            ComboBox1.SelectedIndex = rango - 1
        End If
    End Sub
End Class