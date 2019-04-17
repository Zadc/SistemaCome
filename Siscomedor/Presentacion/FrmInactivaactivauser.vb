Public Class FrmInactivaactivauser
    Private dt As New DataTable
    Public estadouser As Integer
    Public seActivaautomaticamente As Integer
    Public obtenerEstadoactual As String
    Public estadotexto As String

    Private Sub btnCambiarestado_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub FrmInactivaactivauser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DTPfECHADESDE.Value = Today.Date
        DTPFECHAHASTA.Value = Today.Date

        MOstrarestadoActualusuario()
        Label2.Text = (FrmAdmin.NOMBRECOMPLETO)
        Label1.Text = FrmAdmin.txtsecuencial.Text

        mostrarcausas()

    End Sub
    Private Sub mostrarcausas()
        Dim fun As New FCausas
        ComboBox1.DataSource = fun.MostrarCausas()
        ComboBox1.ValueMember = "SECUENCIAL"
        ComboBox1.DisplayMember = "DESCRIPCION"

    End Sub
    Private Sub ESTADO()
        If cboEstado.Text = "ACTIVO" Then
            estadouser = 1
        Else
            If cboEstado.Text = "INACTIVO" Then
                estadouser = 0
            Else


                If cboEstado.Text = "ESTADO" Or cboEstado.Text = "" Then
                    MsgBox("Debe seleccionar un estado", MsgBoxStyle.Critical)
                End If

            End If

        End If
    End Sub

    Private Sub ChkActivaAutomaticamente_CheckedChanged(sender As Object, e As EventArgs) Handles ChkActivaAutomaticamente.CheckedChanged
        If ChkActivaAutomaticamente.CheckState = CheckState.Checked Then
            seActivaautomaticamente = 1
        Else
            seActivaautomaticamente = 0
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCambiarEstadoForm.Click

        'MsgBox(DTPFECHAHASTA.Value)
        'MsgBox(DTPfECHADESDE.Value)
        ' ESTADO()
        If cboEstado.Text = "ACTIVO" Then
            estadouser = 1
            estadotexto = "ACTIVO"
        Else
            If cboEstado.Text = "INACTIVO" Then
                estadouser = 0
                estadotexto = "INACTIVO"
            Else
                If cboEstado.Text = "ESTADO" Or cboEstado.Text = "" Then
                    MsgBox("Debe seleccionar un estado", MsgBoxStyle.Critical)
                    Exit Sub
                End If
            End If
        End If
        MOstrarestadoActualusuario()
        If obtenerEstadoactual = cboEstado.Text Then
            MsgBox("No se puede cambiar a un estado que sea el actual: " + obtenerEstadoactual, MsgBoxStyle.Exclamation)
            Exit Sub
        End If
        If DTPFECHAHASTA.Value.Date <= DTPfECHADESDE.Value.Date Then
            MsgBox("LA FECHA INICIAL DEBE DE SER MENOR A LA MAYOR", MsgBoxStyle.Critical)
            'MsgBox(Label2.Text)
        Else
            If Label2.Text <> "" Then
                Dim fun As New fUsuario
                Dim dts As New vUsuario
                dts.gidusuario = Label1.Text
                dts.gestado = estadouser
                If fun.CambiarEstadoUsuario(dts) = True Then
                    MsgBox("Usuario ha cambiado a Estado: " + estadotexto, MsgBoxStyle.Information)
                    fun.InsertarHistorico(DTPfECHADESDE.Value.ToShortDateString, DTPFECHAHASTA.Value.ToShortDateString, Label1.Text, ComboBox1.SelectedValue, seActivaautomaticamente)
                    Me.Close()
                    FrmAdmin.Refresh()

                Else
                    Try
                        MsgBox("Se produjo un error intente nuevamente", MsgBoxStyle.Critical)
                    Catch ex As Exception
                        MessageBox.Show(ex.Message)

                    End Try
                    Me.Close()

                    FrmAdmin.Show()
                End If
            End If

        End If
        Dim Bringmeformadmin As New FrmAdmin



    End Sub
    Private Sub MOstrarestadoActualusuario()
        Dim fun As New fUsuario
        dt = fun.MuestraEstadoUsuario(FrmAdmin.txtsecuencial.Text)
        DtgvEstadoUsuario.DataSource = dt
        If DtgvEstadoUsuario.Rows.Count > 0 Then
            For Each row As DataGridViewRow In DtgvEstadoUsuario.Rows
                If (row.Cells(0).Value) = 0 Then
                    obtenerEstadoactual = "INACTIVO"
                Else
                    If (row.Cells(0).Value) = 1 Then
                        obtenerEstadoactual = "ACTIVO"
                    End If
                End If
            Next
        End If

    End Sub


End Class