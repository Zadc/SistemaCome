Public Class FrmCocina
    Public second As Integer
    Private dt As New DataTable
    Private Sub FrmCocina_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        'cambiodemonitor()
        'CAMBIAR 
        Mostrarordenesprocesadas()
        maximizar()


    End Sub


    'Dim monitor As Integer
    'Public Sub cambiarmonitor(ByVal monitor As Integer)
    '    Dim pantalla As Screen
    '    Dim area As Rectangle
    '    pantalla = Screen.AllScreens(monitor = 0)   'le paso 0 para el monitor principal y 1 para el secundario
    '    area = pantalla.Bounds
    '    Me.WindowState = FormWindowState.Normal
    '    Me.Hide()
    '    Me.StartPosition = FormStartPosition.Manual
    '    Dim p As New Point(pantalla.Bounds.Location.X = 800, pantalla.Bounds.Location.Y)
    '    Me.Location = p
    '    Me.Width = area.Width
    '    Me.Height = area.Height
    '    Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
    '    Me.WindowState = FormWindowState.Maximized
    '    Me.Show()
    'End Sub
    Public Sub cambiodemonitor()
        Dim screen As Screen

        'Show the form on second screen
        screen = Screen.AllScreens(1)
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None 'Propiedad para quitar barra superior de formularios
        Me.StartPosition = FormStartPosition.Manual
        Me.Location = screen.Bounds.Location + New Point(100, 100)
        Me.Show()


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
        MsgBox(TimeOfDay.ToShortTimeString)
        dt = fun.mostrarOrdenes(DateTime.Now.ToLongTimeString, DateTime.Now.ToLongTimeString)
        datagvMostrarConsultaordenesProcesadas.DataSource = dt


    End Sub
End Class