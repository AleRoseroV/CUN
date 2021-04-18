
Imports System.Math
Public Class Form4

    Dim Nombre, apellido, Observacion As String
    Dim Altura, Peso, Resultado, R As Double
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Nombre = Rnombre.Text
        apellido = Rapellido.Text
        Altura = Val(Raltura.Text)
        Peso = Val(Rpeso.Text)


        Resultado = Peso / (Altura) ^ 2


        R = Round(Resultado, 2)


        If (R < 18.5) Then

            Observacion = "Peso inferior al normal"

        End If

        If (R > 18.5 And R <= 29.9) Then

            Observacion = "Peso normal"

        End If

        If (R >= 25 And R <= 29.9) Then

            Observacion = "Peso superior al normal"

        End If

        If (R >= 30) Then

            Observacion = "Obesidad"

        End If



        Resultados.Items.Add("Nombre: " & Nombre)
        Resultados.Items.Add("Apellido: " & apellido)
        Resultados.Items.Add("Altura: " & Altura)
        Resultados.Items.Add("Peso: " & Peso)
        Resultados.Items.Add("")
        Resultados.Items.Add("---------------- Calculo IMC ----------------")
        Resultados.Items.Add("IMC: " & R)
        Resultados.Items.Add("Composición corporal: " & Observacion)
        Resultados.Items.Add("--------------------------------------------------------")

    End Sub
End Class