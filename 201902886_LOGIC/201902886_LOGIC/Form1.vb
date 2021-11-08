Public Class Form1
    Private Sub OperarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OperarToolStripMenuItem.Click

        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Then

            MsgBox("Verifique los datos ingresados", vbExclamation)
            Exit Sub

        End If

        If (i < 7) Then
            If (Not (comprobar_repetido())) Then
                MsgBox("DPI repetido, no se puede ingresar el dato nuevamente", vbExclamation)
                TextBox1.Focus()

            Else
                DPI(i) = TextBox1.Text
                Nombre(i) = TextBox2.Text
                Valor(i) = TextBox3.Text
                Meses(i) = TextBox4.Text

                If Val(TextBox4.Text) <= 12 Then
                    Tasa(i) = 0.03
                ElseIf Val(TextBox4.Text) > 12 And Val(TextBox4.Text) <= 24 Then
                    Tasa(i) = 0.045
                ElseIf Val(TextBox4.Text) > 24 And Val(TextBox4.Text) <= 36 Then
                    Tasa(i) = 0.055
                ElseIf Val(TextBox4.Text) >= 36 Then
                    Tasa(i) = 0.062
                ElseIf Val(TextBox4.Text) = 12 And Val(TextBox3.Text) > 8000 Then
                    Tasa(i) = 0.02
                End If
                Total(i) = Math.Round(Val(TextBox3.Text) + Tasa(i) * Val(TextBox3.Text), 2)

                i = i + 1
                MsgBox("Registro realizado con éxito", vbInformation)

            End If

        Else
            MsgBox("Vectores llenos", vbExclamation)
        End If

    End Sub

    Private Sub MostrarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MostrarToolStripMenuItem.Click
        mostrar_matriz()
    End Sub

    Private Sub OrdenarAscendenteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OrdenarAscendenteToolStripMenuItem.Click
        Dim i As Byte
        Dim j As Byte
        Dim temp1 As Double
        Dim temp2 As String
        Dim temp3 As Double
        Dim temp4 As Integer
        Dim temp5 As Double
        Dim temp6 As Double

        For i = 0 To 5
            For j = i + 1 To 6

                If (DPI(j) <> Nothing) Then
                    If (DPI(i) > DPI(j)) Then

                        temp1 = DPI(i)
                        DPI(i) = DPI(j)
                        DPI(j) = temp1

                        temp2 = Nombre(i)
                        Nombre(i) = Nombre(j)
                        Nombre(j) = temp2

                        temp3 = Valor(i)
                        Valor(i) = Valor(j)
                        Valor(j) = temp3

                        temp4 = Meses(i)
                        Meses(i) = Meses(j)
                        Meses(j) = temp4

                        temp5 = Tasa(i)
                        Tasa(i) = Tasa(j)
                        Tasa(j) = temp5

                        temp6 = Total(i)
                        Total(i) = Total(j)
                        Total(j) = temp6

                    End If
                Else
                    Exit For
                End If
            Next j

        Next i
    End Sub

    Private Sub OrdenarDescendenteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OrdenarDescendenteToolStripMenuItem.Click
        Dim i As Byte
        Dim j As Byte
        Dim temp1 As Double
        Dim temp2 As String
        Dim temp3 As Double
        Dim temp4 As Integer
        Dim temp5 As Double
        Dim temp6 As Double

        For i = 0 To 5
            For j = i + 1 To 6

                If (DPI(j) <> Nothing) Then
                    If (DPI(i) < DPI(j)) Then

                        temp1 = DPI(i)
                        DPI(i) = DPI(j)
                        DPI(j) = temp1

                        temp2 = Nombre(i)
                        Nombre(i) = Nombre(j)
                        Nombre(j) = temp2

                        temp3 = Valor(i)
                        Valor(i) = Valor(j)
                        Valor(j) = temp3

                        temp4 = Meses(i)
                        Meses(i) = Meses(j)
                        Meses(j) = temp4

                        temp5 = Tasa(i)
                        Tasa(i) = Tasa(j)
                        Tasa(j) = temp5

                        temp6 = Total(i)
                        Total(i) = Total(j)
                        Total(j) = temp6

                    End If
                Else
                    Exit For
                End If
            Next j

        Next i
    End Sub

    Private Sub LimpiarEntradasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarEntradasToolStripMenuItem.Click
        limpiar_entradas()
    End Sub

    Private Sub LimpiarVectoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarVectoresToolStripMenuItem.Click
        limpiar_vectores()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        If MsgBox("Seguro desea salir?", vbQuestion + vbYesNo, "Pregunta") = vbYes Then
            End
        End If
    End Sub
End Class
