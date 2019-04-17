Imports System.Data.SqlClient
Public Class conexion


    Public cnn As New SqlConnection


    Public Function Conectado()
        Try
            'CONEXION PC CARLOS
            cnn = New SqlConnection("Data Source=VK-PC;Initial Catalog=comedordb; Integrated Security=True")
            'conexion PC LEO
            'cnn = New SqlConnection("Data Source=DESKTOP-CCM42VI;Initial Catalog=comedordb; Integrated Security=True")
            cnn.Open()
            'MessageBox.Show("conected")
            Return True
        Catch ex As Exception
            'MessageBox.Show("fail conetion")
            MsgBox(ex.Message)
            Return False
        Finally
            'If cnn.State = ConnectionState.Closed Then
            'cnn.Open()
            ' End If
        End Try
    End Function
    Public Function desconectado()
        Try
            If cnn.State = ConnectionState.Open Then
                cnn.Close()
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try

    End Function

End Class


