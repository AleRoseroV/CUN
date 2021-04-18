Public Class Form1
    Private Sub PartidoDeFutbolToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PartidoDeFutbolToolStripMenuItem.Click
        Dim F2 As New Form2()
        F2.Show()
    End Sub

    Private Sub EleccionesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EleccionesToolStripMenuItem.Click
        Dim F3 As New Form3()
        F3.Show()
    End Sub

    Private Sub CalculoDeIMCToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CalculoDeIMCToolStripMenuItem.Click
        Dim F4 As New Form4()
        F4.Show()
    End Sub
End Class
