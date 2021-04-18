Public Class Form2

    Dim suma, num As Integer

    Private Sub Agregar_Click(sender As Object, e As EventArgs) Handles Agregar.Click
        If (Edad.Text = "") Then
            MsgBox("Debe ingresar un nombre para poder agregar un elemento",
           vbQuestion + vbOKOnly, "Datos incompletos")
        End If
        ListBox1.Items.Add(Edad.Text)
    End Sub
End Class