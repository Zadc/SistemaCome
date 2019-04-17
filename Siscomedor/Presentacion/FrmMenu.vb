Public Class FrmMenu
    Private Sub lblUsuarios_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub BtnCreaUsuarios_Click(sender As Object, e As EventArgs) Handles BtnCreaUsuarios.Click
        Dim Bringmeformadmin As New FrmAdmin
        Me.Hide()

        FrmAdmin.Show()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        Me.Close()

    End Sub



    Private Sub btnProveedores_Click(sender As Object, e As EventArgs) Handles btnProveedores.Click
        Dim Bringmeformprovider As New FrmProveedor
        Me.Hide()
        FrmProveedor.Show()

        btnProveedores.Enabled = FrmLogin._UpermisoSuperintendente



    End Sub

    Private Sub btnDepartamentos_Click(sender As Object, e As EventArgs) Handles btnDepartamentos.Click
        Dim dts As New vUsuario 'dejame usar aqui las expresiones que contienes

        Dim Bringmeformdep As New FrmCreaDeps
        Me.Hide()
        FrmCreaDeps.Show()


        'Try
        '    If dts.permiso_admin And dts.PermisoSuperintendente = 1 Then
        '        'btnDepartamentos.Enabled = True
        '        btnCrearPedido.Enabled = True
        '    Else
        '        'btnDepartamentos.Enabled = False
        '        btnCrearPedido.Enabled = False

        '    End If
        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'End Try

    End Sub

    Private Sub btnCrearPedido_Click(sender As Object, e As EventArgs) Handles btnCrearPedido.Click
        Dim bringmefrmsecretaria As New FrmSecretaria
        Me.Hide()
        FrmSecretaria.Show()

    End Sub

    Private Sub FrmMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'boton provee
        btnProveedores.Enabled = FrmLogin._UpermisoSuperintendente
        btnProveedores.Enabled = FrmLogin._UPermisoAdmin
        'boton crar pedidos
        BtnCreaUsuarios.Enabled = FrmLogin._UPermisoAdmin
        btnCrearPedido.Enabled = FrmLogin._UPermisoCrealista
        'Boton creadepartamentos
        btnDepartamentos.Enabled = FrmLogin._UPermisoAdmin
        'boton crea visitas
        btnUsauriosVisita.Enabled = FrmLogin._UpermisoSuperintendente
        btnUsauriosVisita.Enabled = FrmLogin._UPermisoAdmin

    End Sub

    Private Sub btnUsauriosVisita_Click(sender As Object, e As EventArgs) Handles btnUsauriosVisita.Click
        Me.Hide()
        FrmEditaVisitas.Show()

    End Sub
End Class