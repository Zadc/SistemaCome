Imports System.Data.SqlClient
Public Class FrmLogin
    Dim fu As New fLogin
    Dim vu As New vUsuario
    Dim men As FrmMenu
    Dim ad As FrmAdmin
    Dim sec As FrmSecretaria

    Public _IdUsuario As Integer
    Public _CodigoUsuario As Integer
    Public _UsuarioNombre As String
    Public _UsuarioApellido As String
    Public _UsuarioNick As String
    Public _UsuarioPassword As String
    Public _TipoUsuario As String
    Public _UPermisoAgregar As Integer
    Public _UPermisoModificar As Integer
    Public _UPermisoEliminar As Integer
    Public _UPermisoAdmin As Integer
    Public _UPermisoCrealista As Integer
    Public _UPermisoCocina As Integer
    Public _UPermisoTransportista As Integer
    Public _IdArea As Integer
    Public _UsuarioEstado As Integer
    Public _IdTurno As Integer
    Public _UpermisoSuperintendente As Integer
    Public _IdDepartamneto As Integer
    Public _NUMEROtICKETMASIVO As String
    Public _Numerogrupo As Integer
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Try
            If txtUsuario.Text <> "" And txtLoginPass.Text <> "" Then
                Dim dt As New DataTable
                vu.gusuarionick = txtUsuario.Text
                vu.gpassword = txtUsuario.Text
                dt = fu.validarUsuario(vu)
                If dt.Rows.Count > 0 Then

                    Dim IdUsuario As Integer
                    Dim CodigoUsuario As Integer
                    Dim UsuarioNombre As String
                    Dim UsuarioApellido As String
                    Dim UsuarioNick As String
                    Dim UPermisoAgregar As Integer
                    Dim UPermisoModificar As Integer
                    Dim UPermisoEliminar As Integer
                    Dim UPermisoAdmin As Integer
                    Dim UPermisoCrealista As Integer
                    Dim UPermisoCocina As Integer
                    Dim UPermisoTransportista As Integer
                    Dim Idarea As Integer
                    Dim UsuarioEstado As Integer
                    Dim IdTurno As Integer
                    Dim UpermisoSuperintendente As Integer
                    Dim IdDepartamento As Integer
                    Dim NUmeroGrupo As Integer

                    UsuarioNombre = dt.Rows(0)("UsuarioNombre")
                    IdUsuario = dt.Rows(0)("IdUsuario")
                    CodigoUsuario = dt.Rows(0)("CodigoUsuario")
                    UsuarioNombre = dt.Rows(0)("UsuarioNombre")
                    UsuarioApellido = dt.Rows(0)("UsuarioApellido")
                    UsuarioNick = dt.Rows(0)("UsuarioNick")
                    UPermisoAgregar = dt.Rows(0)("UPermisoAgregar")
                    UPermisoModificar = dt.Rows(0)("UPermisoModificar")
                    UPermisoEliminar = dt.Rows(0)("UPermisoEliminar")
                    UPermisoAdmin = dt.Rows(0)("UPermisoAdmin")
                    UPermisoCrealista = dt.Rows(0)("UPermisoCrealista")
                    UPermisoCocina = dt.Rows(0)("UPermisoCocina")
                    UPermisoTransportista = dt.Rows(0)("UPermisoTransportista")
                    Idarea = dt.Rows(0)("IdArea")
                    UsuarioEstado = dt.Rows(0)("UsuarioEstado")
                    IdTurno = dt.Rows(0)("IdTurno")
                    UpermisoSuperintendente = dt.Rows(0)("UpermisoSuperintendente")
                    UPermisoAgregar = dt.Rows(0)("UPermisoAgregar")
                    IdDepartamento = dt.Rows(0)("IdDepartamento")
                    NUmeroGrupo = dt.Rows(0)("NUMERO.GRUPO")
                    If UPermisoAgregar = 1 Then

                    Else
                        UPermisoAgregar = 0

                    End If

                    UPermisoModificar = dt.Rows(0)("UPermisoModificar")
                    If UPermisoModificar = 1 Then

                    Else
                        UPermisoModificar = 0
                    End If


                    UPermisoEliminar = dt.Rows(0)("UPermisoEliminar")
                    If UPermisoEliminar = 1 Then
                    Else
                        UPermisoEliminar = 0
                    End If


                    UPermisoAdmin = dt.Rows(0)("UPermisoAdmin")
                    If UPermisoAdmin = 1 Then

                    Else
                        UPermisoAdmin = 0
                    End If


                    UPermisoCocina = dt.Rows(0)("UPermisoCocina")
                    If UPermisoCocina = 1 Then

                    Else
                        UPermisoCocina = 0
                    End If

                    UPermisoTransportista = dt.Rows(0)("UPermisoTransportista")
                    If UPermisoTransportista = 1 Then

                    Else
                        UPermisoTransportista = 0
                    End If
                    UpermisoSuperintendente = dt.Rows(0)("UpermisoSuperintendente")
                    If UpermisoSuperintendente = 1 Then

                    Else
                        UpermisoSuperintendente = 0
                    End If

                    UPermisoCrealista = dt.Rows(0)("UPermisoCrealista")
                    If UPermisoCrealista = 1 Then
                        _IdUsuario = IdUsuario
                        _UsuarioNombre = UsuarioNombre
                        _UsuarioApellido = UsuarioApellido
                        Dim dt3 As New DataTable
                        Dim VTICKETMASIVO As New VticketMasivo
                        Dim FUTICKETMASIVO As New FTicketmasivo
                        VTICKETMASIVO.gid_Usuario = IdUsuario
                        dt3 = FUTICKETMASIVO.ValidaNUMEROTICKETMASIVO(VTICKETMASIVO)
                        If dt3.Rows.Count > 0 Then
                            _NUMEROtICKETMASIVO = dt3.Rows(0)("NUMEROTICKETMASIVO")
                            'MsgBox(_NUMEROtICKETMASIVO)
                        Else

                            Hide()
                            Frm_Asigna_ticketmasivo.Show()
                            txtLoginPass.Clear()
                            txtUsuario.Clear()
                            Exit Sub


                        End If

                    Else
                        UPermisoCrealista = 0
                    End If
                    _IdUsuario = IdUsuario
                    _CodigoUsuario = CodigoUsuario
                    _UsuarioNombre = UsuarioNombre
                    _UsuarioApellido = UsuarioApellido
                    _UsuarioNick = UsuarioNick
                    _UPermisoAgregar = UPermisoAgregar
                    _UPermisoModificar = UPermisoModificar
                    _UPermisoEliminar = UPermisoEliminar
                    _UPermisoAdmin = UPermisoAdmin
                    _UPermisoCrealista = UPermisoCrealista
                    _UPermisoCocina = UPermisoCocina
                    _UPermisoTransportista = UPermisoTransportista
                    _IdArea = Idarea
                    _UsuarioEstado = UsuarioEstado
                    _IdTurno = IdTurno
                    _UpermisoSuperintendente = UpermisoSuperintendente
                    _IdDepartamneto = IdDepartamento
                    _Numerogrupo = NUmeroGrupo
                    If UsuarioEstado = 0 Then
                        MsgBox("Usuario no se encuentra Activo", MsgBoxStyle.Critical)
                    Else
                        '  MsgBox("BIENVENIDO AL SISTEMA : " & UsuarioNombre & "")
                        FrmMenu.Show()
                        txtUsuario.Text = ""
                        txtLoginPass.Clear()

                    End If
                Else
                    MsgBox("Usuario o Contraseña Incorrectos Intente nuevamente o contacte a I.T para obtener una nueva contraseña", MsgBoxStyle.Critical)
                End If


            Else
                MsgBox("Debe ingresar su NICK o su PASSWORD para acceder al Sistema")
            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub FrmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txtUsuario.Focus()


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        FrmSecretaria.Close()
        FrmMenu.Close()
        Me.Finalize()
    End Sub


End Class
