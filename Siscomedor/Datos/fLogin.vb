Imports System.Data.SqlClient
Imports System.Data.Sql

Public Class fLogin

    Inherits conexion
    Public Function validarUsuario(ByRef dts As vUsuario) As DataTable
        Dim cmd As New SqlCommand
        Conectado()
        'cmd = New SqlCommand("Select * from Usuarios  where UsuarioNick = '" & FrmLogin.TxtUsuarioNi.Text & "' and Contraseña = '" & FrmLogin.TxtContraseña.Text & "'   ")
        cmd = New SqlCommand("
SELECT [IdUsuario]
,[CodigoUsuario]
,[UsuarioNombre]
,[UsuarioApellido]
,[UsuarioNick]
,[UsuarioPassword]
,[TipoUsuario]
,[UPermisoAgregar]
,[UPermisoModificar]
,[UPermisoEliminar]
,[UPermisoAdmin]
,[UPermisoCrealista]
,[UPermisoCocina]
,[UPermisoDigitador]
,[UPermisoTransportista]
,A.IdArea
,[UsuarioEstado]
,[UFechaCreacion]
,[UFechaModificacion]
,[UfechaContratacion]
,[IdTurno]
,[UpermisoSuperintendente]
,U.IdDepartamento
,[ValidaPeticion]
 ,[NUMERO.GRUPO]
FROM [comedordb].[dbo].[TUsuarios] U
INNER JOIN dbo.Departamento d ON d.IdDepartamento = u.IdDepartamento
INNER JOIN dbo.Areas A ON A.IdArea = d.IdArea

  where UsuarioNick = '" & FrmLogin.txtUsuario.Text & "'
  and UsuarioPassword = '" & FrmLogin.txtLoginPass.Text & "'
")

        cmd.CommandType = CommandType.Text
        cmd.Connection = cnn


        If cmd.ExecuteNonQuery Then
            Using dt As New DataTable
                Using da As New SqlDataAdapter(cmd)
                    da.Fill(dt)
                    Return dt
                End Using
            End Using
        Else
            Return Nothing


        End If



    End Function
    'Inherits conexion

    'Dim cmd As New SqlCommand
    ''Dim cmd As SqlCommand
    ''Public Function iniciaSesion(ByVal usuario As String, ByVal password As String) As Integer

    ''Using cnn As New SqlConnection()
    ''    Try
    ''        cnn.Open()
    ''        Dim cmd As New SqlCommand("iniciaSesion", cnn)
    ''        cmd.CommandType = CommandType.StoredProcedure

    ''        cmd.Parameters.AddWithValue("@usuario", usuario)
    ''        cmd.Parameters.AddWithValue("@password", password)
    ''        cmd.Parameters.AddWithValue(@"RETURN_VALUE", SqlDbType.Int).Direction = ParameterDirection.ReturnValue

    ''    Catch ex As Exception
    ''        MsgBox(ex.Message)
    ''    End Try
    ''End Using
    'Public Function Login(ByVal dts As vLogin) As Boolean
    '    Try
    '        Conectado()

    '        cmd = New SqlCommand("inicio_sesion")
    '        cmd.CommandType = CommandType.StoredProcedure
    '        cmd.Connection = cnn

    '        cmd.Parameters.AddWithValue("@UsuarioNombre", dts.gusuariologin)
    '        cmd.Parameters.AddWithValue("@UsuarioPassword", dts.gpassword)
    '        Dim dr As SqlDataReader
    '        dr = cmd.ExecuteReader

    '        If dr.HasRows = True Then
    '            Return True
    '        Else
    '            Return False
    '        End If
    '        '    If cmd.ExecuteNonQuery Then
    '        '        Using dt As New DataTable
    '        '            Using da As New SqlDataAdapter(cmd)
    '        '                da.Fill(dt)
    '        '                Return True
    '        '            End Using

    '        '        End Using
    '        '        MsgBox("Inicio exitoso")

    '        '    Else

    '        '    End If
    '    Catch ex As Exception

    '        MsgBox(ex.Message)
    '        Return False
    '        'Finally
    '        '    desconectado()
    '    End Try

    '    End If

    'If cmd.ExecuteNonQuery Then
    '    Using dt As New DataTable
    '        Using da As New SqlDataAdapter(cmd)
    '            da.Fill(dt)
    '        End Using
    '    End Using



    'Else
    'Try


    'Catch ex As Exception
    '    MessageBox.Show(ex.Message)
    'End Try
    'Return Nothing




    'End If

    'End Function
    'Private Sub New()

    'End Sub

End Class
