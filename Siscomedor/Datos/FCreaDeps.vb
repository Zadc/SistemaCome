Imports System.Data.SqlClient
Public Class FCreaDeps
    Inherits conexion


    Dim cmd As New SqlCommand
    'Muestra Departamentos en DataGrid
    Public Function mostrarDep() As DataTable
        Try
            Conectado()
            cmd = New SqlCommand("MOSTRA_DEP")

            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

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
        desconectado()
    End Function
    'Llenar COMBOBOX desde Base
    Public Function mostrarArea() As DataTable
        Try
            Conectado()
            cmd = New SqlCommand("SELECT IdArea AS 'ID', DescripcionArea AS 'NOMBRE AREA'
FROM Areas ")

            cmd.CommandType = CommandType.Text
            cmd.Connection = cnn

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

    Public Function InsertarDepartamento(ByVal dts As VCreaDeps) As Boolean

        Try
            Conectado()
            cmd = New SqlCommand("Insertar_Departamento")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            'cmd.Parameters.AddWithValue("@IdDepartamento", dts.gidepartamento)
            cmd.Parameters.AddWithValue("@DepartamentoCodigo", dts.gcodigodepartamento)
            cmd.Parameters.AddWithValue("@DepartamentoDescripcion", dts.gdescripcion)
            cmd.Parameters.AddWithValue("@IdArea", dts.gidarea)
            cmd.Parameters.AddWithValue("@CuentaContable", dts.gcuentacontable)

            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False

            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False

        End Try
        Return desconectado()
    End Function

    'INICIA FUNCION MODIFICAR DEPARTAMENTOS
    Public Function Modificar_Dep(ByVal dts As VCreaDeps) As Boolean
        Try
            Conectado()

            cmd = New SqlCommand("Modificar_Departamento")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("IdDepartamento", dts.gidepartamento)
            cmd.Parameters.AddWithValue("CodigoDepartamento", dts.codigoDepartamento)
            cmd.Parameters.AddWithValue("DepartamentoDescripcion", dts.descripcionDep)
            cmd.Parameters.AddWithValue("IdArea", dts.idarea)
            cmd.Parameters.AddWithValue("CuentaContable", dts.gcuentacontable)

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
    ' FINALIZA  FUNCION MODIFICAR DEPARTAMENTOS

    'INICIA FUNCIOMN ELIMINAR
    Public Function Eliminar_Dep(ByVal dts As VCreaDeps) As Boolean

        Try
            Conectado()
            cmd = New SqlCommand("Eliminar_Departamento")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@IdDepartamento", dts.gidepartamento)

            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return desconectado()
        End Try



    End Function



End Class

'  Public Function mostrarAreas() As DataTable
'      Try
'          Conectado()
'          cmd = New SqlCommand("SELECT [IdArea] as ID
'    ,DescripcionArea as Area

'FROM Areas")

'          cmd.CommandType = CommandType.Text
'          cmd.Connection = cnn

'          If cmd.ExecuteNonQuery Then
'              Dim dt As New DataTable
'              Dim da As New SqlClient.SqlDataAdapter(cmd)
'              da.Fill(dt)
'              Return dt
'          Else
'              Return Nothing

'          End If
'      Catch ex As Exception
'          MsgBox(ex.Message)
'          Return desconectado()
'      End Try
'  End Function






'Muestra departamentos en Lisview (espero)
'    Public Function mostrarDepenlistv() As DataTable
'        Try
'            Conectado()
'            cmd = New SqlCommand("SELECT Departamento.IdDepartamento AS'Secuencial', Departamento.DepartamentoCodigo AS 'CODIGO',
'Departamento.DepartamentoDescripcion AS'NOMBRE', Areas.DescripcionArea AS 'NOMBRE AREA', 
'Departamento.CuentaContable As 'CUENTA' 
' from Departamento INNER JOIN Areas 
' on Departamento .IdArea = Areas.IdArea")

'            cmd.CommandType = CommandType.Text

'            cmd.Connection = cnn

'            If cmd.ExecuteNonQuery Then
'                Dim dt As New DataTable
'                Dim da As New SqlClient.SqlDataAdapter(cmd)
'                da.Fill(dt)
'                Return dt

'            Else

'                Return Nothing

'            End If
'        Catch ex As Exception
'            MsgBox("ni idea, que paso?" + ex.Message)
'            Return Nothing
'        End Try
'        desconectado()
'    End Function
