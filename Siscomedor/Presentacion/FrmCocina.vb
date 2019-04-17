Public Class FrmCocina
    Public second As Integer
    Private dt As New DataTable
    Private Sub FrmCocina_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        'Mostrarenlistbox()
        'CAMBIAR 
        cambiodemonitor()

        maximizar()
        Mostrarordenesprocesadas()

        ListViewComidatest.Columns.Add("Nombre", 0)
        ListViewComidatest.Columns.Add("Apellido", 1)
        ListViewComidatest.Columns.Add("Departamneto", 2)
        ListViewComidatest.Columns.Add("Comida", 3)
        ListViewComidatest.Columns.Add("Complemento", 4)
        ListViewComidatest.View = View.Details



    End Sub

    Public Sub cambiodemonitor()
        Dim screen As Screen

        'Show the form on a second screen
        'screen = Screen.AllScreens(1)
        'Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None 'Propiedad para quitar barra superior de formularios
        'Me.StartPosition = FormStartPosition.Manual
        'Me.Location = screen.Bounds.Location + New Point(100, 100)
        'Me.Show()


    End Sub
    Dim pantalla As Screen
    Public Sub maximizar()
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub dvgMuestraOrdenes_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dvgMuestraOrdenes.CellContentClick

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Second += 1
        Label1.Text = DateTime.Now.ToLongTimeString
        If second > 30 Then

            second = 0
            ' Mostrartiempos()

            'MsgBox("update")
        End If
    End Sub

    Private Sub Mostrarordenesprocesadas()
        Dim fun As New FCocina
        ' MsgBox(TimeOfDay.ToShortTimeString)
        '    dt = fun.mostrarOrdenes(DateTime.Now.ToLongTimeString, DateTime.Now.ToLongTimeString)
        '  datagvMostrarConsultaordenesProcesadas.DataSource = dt


    End Sub

End Class