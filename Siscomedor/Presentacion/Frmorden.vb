Imports System.Data.SqlClient
'Private dt As New DataTable
Public Class Frmorden

    Private Sub btnRefresco_Click(sender As Object, e As EventArgs) Handles btnRefresco.Click
        blockbtnrefresco()
    End Sub

    Private Sub btncomida_Click(sender As Object, e As EventArgs) Handles btncomida.Click
        blockbtncomida()
    End Sub

    Private dt As New DataTable


    Private Sub mostrarcomidafrm()
        Dim fun As New fOrden
        dt = fun.MostrarComida
        DatagVistacomida.DataSource = dt
    End Sub

    Private Sub Frmorden_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        MsgBox(frmlogincomedor.DEFINEUPDATEORDENES)
        'MsgBox(frmlogincomedor.tiempo, frmlogincomedor._Ticketmasivo)
        mostrarcomidafrm()
        visibilidadelementos()
        LLenarlistbox()

    End Sub

    Private Sub verificarhora()
        'For Each row As DataGridViewRow In DatagVistacomida.Rows
        'MsgBox(row.Cells(3).Value.ToString)
        If Now.TimeOfDay.ToString >= "06:29:00" And Now.TimeOfDay.ToString <= "09:00:00" Then
            MsgBox("Desayuno")
        Else
            If Now.TimeOfDay.ToString >= "12:00:00" And Now.TimeOfDay.ToString <= "14:00:00" Then
                MsgBox("almuerzo")
            Else
                If Now.TimeOfDay.ToString >= "18:00:00" And Now.TimeOfDay.ToString <= "20:00:00" Then
                    MsgBox("Cena")
                End If

            End If

        End If

        'If Now.TimeOfDay.ToString >= row.Cells(2).Value.ToString And Now.TimeOfDay.ToString <= row.Cells(3).Value.ToString Then
        '    MsgBox("hola")
        'End If
        'Next
    End Sub


    'Funcion para que cuado se ejecute el programa se ejecute mas de un form

    Private Sub blockbtncomida()
        btncomida.Enabled = True



    End Sub
    Private Sub blockbtnrefresco()
        btnRefresco.Enabled = True
    End Sub

    Private Sub btnConfirmar_Click(sender As Object, e As EventArgs) Handles btnConfirmar.Click
        verificarhora()

        Dim fun As New fOrden
        Dim ve As New vOrden
        ve.gFechaasignada = Today.Date
        ve.gidcomida = frmlogincomedor.tiempo
        ve.gNumeroticketMasivo = frmlogincomedor.valortext
        ve.gOidusuarioasigna = frmlogincomedor.idusuarioasigna
        ve.gidestadoticket = 1
        If fun.actualizaordenes(ve, frmlogincomedor.DEFINEUPDATEORDENES) = True Then
            MsgBox("correcto")
        Else
            MsgBox("incorrecto")

        End If
        Me.Close()
        'frmlogincomedor.Show()
    End Sub
    Private Sub LLenarlistbox()
        Dim fun As New fOrden

        dt = fun.MostrarOrdenesFinales(frmlogincomedor.tiempo, Numeromasivo:=frmlogincomedor._Ticketmasivo)
            If dt.Rows.Count > 0 Then
                For i As Integer = 1 To dt.Rows.Count
                    Dim usuario, comida As String
                    usuario = dt.Rows(i - 1)("EMPLEADO")
                    comida = dt.Rows(i - 1)("TIEMPO")
                    ListBox1.Items.Add(usuario)
                    DomainUpDown2.Items.Add(i)

            Next
            End If



    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim dialog As DialogResult
        Me.Close()
        frmlogincomedor.Show()


    End Sub
    Private Sub visibilidadelementos()
        If frmlogincomedor.DEFINEUPDATEORDENES = 1 Then
            Label2.Visible = 0
            ListBox1.Visible = 1
        Else
            If frmlogincomedor.DEFINEUPDATEORDENES = 2 Then
                ListBox1.Visible = 0
                Label2.Visible = 1
                Label2.Text = frmlogincomedor._UsuarioNombre & " " & frmlogincomedor._usuarioApellido

            Else
                If frmlogincomedor.DEFINEUPDATEORDENES = 3 Then
                    ListBox1.Visible = 0
                    Label2.Visible = 1
                    Label2.Text = frmlogincomedor._UsuarioNombre & " " & frmlogincomedor._usuarioApellido
                End If
            End If
        End If
    End Sub

End Class