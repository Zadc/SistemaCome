Imports System.Data.SqlClient
Public Class FCocinaVarios
    Inherits conexion


    Public Function mostrarOrdenes() As DataTable
        Dim cmd As New SqlCommand
        Dim gb As New DataGridViewButtonColumn

        gb.DataPropertyName = "Ver Detalle"
        gb.HeaderText = "Ver Detalle"
        Try
            Conectado()
            cmd = New SqlCommand("select cc.ComidaDescripcion as 'TIEMPO', CONCAT(U.UsuarioNombre, ' ', U.UsuarioApellido) AS 'EMPLEADO', C.ComplementoDescripcion from Pedidodepartamento PD
inner join TUsuarios u on u.IdUsuario = pd.IdUsuarioAsignaticket
inner join Complemento c on c.IdComplemento = pd.IdComplemento
inner join Comida CC on cc.IdComida = pd.IdComida
WHERE CC.HoraInicio >= @HORAINICIA AND CC.HoraFinalizacion <= @HORAFINALIZA")
            cmd.CommandType = CommandType.Text

            cmd.Connection = cnn


            If cmd.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)
                Return dt
            Else
                Return Nothing

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally

            desconectado()
        End Try
    End Function


    '    Public Function mostrarOrdenesDetalle() As DataTable
    '        Dim cmd As New SqlCommand
    '        Dim gb As New DataGridViewButtonColumn

    '        gb.DataPropertyName = "Ver Detalle"
    '        gb.HeaderText = "Ver Detalle"
    '        Try
    '            Conectado()
    '            cmd = New SqlCommand("select cc.ComidaDescripcion as 'TIEMPO', CONCAT(U.UsuarioNombre, ' ', U.UsuarioApellido) AS 'EMPLEADO', C.ComplementoDescripcion from Pedidodepartamento PD
    'inner join TUsuarios u on u.IdUsuario = pd.IdUsuarioAsignaticket
    'inner join Complemento c on c.IdComplemento = pd.IdComplemento
    'inner join Comida CC on cc.IdComida = pd.IdComida
    'WHERE CC.HoraInicio >= @HORAINICIA AND CC.HoraFinalizacion <= @HORAFINALIZA")
    '            cmd.CommandType = CommandType.Text

    '            cmd.Connection = cnn


    '            If cmd.ExecuteNonQuery Then
    '                Dim dt As New DataTable
    '                Dim da As New SqlDataAdapter(cmd)
    '                da.Fill(dt)
    '                Return dt
    '            Else
    '                Return Nothing

    '            End If
    '        Catch ex As Exception
    '            MsgBox(ex.Message)
    '            Return Nothing
    '        Finally

    '            desconectado()
    '        End Try
    '    End Function



End Class
