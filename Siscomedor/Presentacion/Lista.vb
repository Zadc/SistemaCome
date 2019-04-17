Public Class Lista
    Dim dt As New DataTable
    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub

    Private Sub Lista_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ComedordbDataSet.Complemento' table. You can move, or remove it, as needed.
        Me.ComplementoTableAdapter.Fill(Me.ComedordbDataSet.Complemento)

    End Sub

    'Private Sub llenarlista()
    '    Dim fun As fLista
    '    dt = fun.ListBox
    '    ListBox1.DataSource = dt

    'End Sub
End Class