Imports System.Data.SqlClient
Public Class fTurnos
    Inherits conexion
    Dim cmd As New SqlCommand
    Public Function MostrarTurnos(ByVal numerogrupo As Integer) As DataTable
        Try
            Conectado()
            cmd = New SqlCommand("SELECT U.IdUsuario, CONCAT(U.UsuarioNombre, ' ', U.UsuarioApellido) AS 'NOMBRE COMPLETO',T.[Turno.Descripcion],A.DescripcionArea
,U.[NUMERO.GRUPO] as [Numero de Grupo], CASE
WHEN U.ValidaPeticion =1
THEN 'SI'
ELSE 'NO'
END AS [PEDIDO LLEVAR]
 FROM dbo.TUsuarios U
INNER JOIN dbo.Departamento D ON D.IdDepartamento = U.IdDepartamento
INNER JOIN dbo.Areas A ON A.IdArea = D.IdArea
INNER JOIN dbo.Turnos T ON T.[Turno.Id] = U.IdTurno
WHERE u.[NUMERO.GRUPO] = @NUMERO")

            cmd.CommandType = CommandType.Text
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@NUMERO", numerogrupo)

            If cmd.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New SqlClient.SqlDataAdapter(cmd)
                da.Fill(dt)
                Return dt
            Else
                Return Nothing

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function
    '    Public Function MostraBusqueda(ByVal Nombre As String) As DataTable
    '        Try
    '            Conectado()
    '            cmd = New SqlCommand("SELECT U.IdUsuario, CONCAT(U.UsuarioNombre, ' ', U.UsuarioApellido) AS 'NOMBRE COMPLETO',T.[Turno.Descripcion],A.DescripcionArea
    ',U.[NUMERO.GRUPO] as [Numero de Grupo], CASE
    'WHEN U.ValidaPeticion =1
    'THEN 'SI'
    'ELSE 'NO'
    'END AS [PEDIDO LLEVAR]
    ' FROM dbo.TUsuarios U
    'INNER JOIN dbo.Departamento D ON D.IdDepartamento = U.IdDepartamento
    'INNER JOIN dbo.Areas A ON A.IdArea = D.IdArea
    'INNER JOIN dbo.Turnos T ON T.[Turno.Id] = U.IdTurno
    'WHERE u.UsuarioNombre like '% @NOmbre %'")

    '            cmd.CommandType = CommandType.Text
    '            cmd.Connection = cnn
    '            cmd.Parameters.AddWithValue("@nombre", Nombre)
    '            Dim da As SqlClient.SqlDataAdapter = New SqlClient.SqlDataAdapter(cmd, cnn)
    '            Dim dt As DataTable = New DataTable("Nombre")
    '        Catch ex As Exception

    '        End Try
    '        Return Nothing

    '    End Function


    '    Public Function insertvalidapeticion(ByVal llevarcomer As Integer) As DataTable
    '        Try
    '            Conectado()
    '            cmd = New SqlCommand("")

    '            cmd.CommandType = CommandType.Text
    '            cmd.Connection = cnn
    '            cmd.Parameters.AddWithValue("@ValidarPeticion", llevarcomer)

    '            If cmd.ExecuteNonQuery Then
    '                Dim dt As New DataTable
    '                Dim da As New SqlClient.SqlDataAdapter(cmd)
    '                da.Fill(dt)
    '                Return dt
    '            Else
    '                Return Nothing

    '            End If
    '        Catch ex As Exception
    '            MsgBox(ex.Message)
    '            Return Nothing
    '        End Try
    '    End Function


    Public Function ModificaUserSecretaria(ByVal dts As vUsuario) As Boolean
        Try
            Conectado()
            cmd = New SqlCommand("UPDATE [dbo].[TUsuarios]
SET 
[UFechaModificacion] = CONVERT(DATE,GETDATE())
,[IdTurno] = @idturno
,[validapeticion] = @validapeticion
WHERE IdUsuario = @IdUsuario")
            cmd.CommandType = CommandType.Text
            cmd.Connection = cnn


            cmd.Parameters.AddWithValue("@validapeticion", dts.gValidaPeticion)
            cmd.Parameters.AddWithValue("@Idturno", dts.gidturno)
            cmd.Parameters.AddWithValue("@IdUsuario", dts.gidusuario)

            If cmd.ExecuteNonQuery Then
                Return True

            Else
                Return False
            End If
        Catch ex As Exception

            MsgBox(ex.Message)
        End Try
        Return desconectado()
    End Function


    '    Public Function MostraBusquedas()
    '        Dim sql As String = ("SELECT U.IdUsuario, CONCAT(U.UsuarioNombre, ' ', U.UsuarioApellido) AS 'NOMBRE COMPLETO',T.[Turno.Descripcion],A.DescripcionArea
    ',U.[NUMERO.GRUPO] as [Numero de Grupo], CASE
    'WHEN U.ValidaPeticion =1
    'THEN 'SI'
    'ELSE 'NO'
    'END AS [PEDIDO LLEVAR]
    ' FROM dbo.TUsuarios U
    'INNER JOIN dbo.Departamento D ON D.IdDepartamento = U.IdDepartamento
    'INNER JOIN dbo.Areas A ON A.IdArea = D.IdArea
    'INNER JOIN dbo.Turnos T ON T.[Turno.Id] = U.IdTurno
    'WHERE u.UsuarioNombre like '% @NOmbre %'")
    '        Dim da As SqlClient.SqlDataAdapter = New SqlClient.SqlDataAdapter(cnn, cmd)
    '        Dim dt As DataTable = New DataTable("Nombre")
    '    End Function


End Class
