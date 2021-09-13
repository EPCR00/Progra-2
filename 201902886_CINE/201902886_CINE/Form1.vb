Public Class Form1
    Private Sub salir_Click(sender As Object, e As EventArgs) Handles salir.Click

        If MsgBox("¿Desea salir?", vbQuestion + vbYesNo, "Pregunta") = vbYes Then
            End
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If (txtentradas.Text = "") Then

            MsgBox("Ingrese el número de las entradas ", vbQuestion)
            Exit Sub
            txtentradas.Focus()

        End If

        If (combofuncion.Text = "") Then

            MsgBox("Seleccione la función", vbQuestion)
            Exit Sub
            txtentradas.Focus()

        End If

        If (combocine.Text = "") Then

            MsgBox("Seleccione el cine ", vbQuestion)
            Exit Sub
            txtentradas.Focus()

        End If



        If (indice < 9) Then

            vfuncion(indice) = combofuncion.Text
            vcine(indice) = combocine.Text
            vnumeroentradas(indice) = txtentradas.Text



            If combocine.Text = "A" And combofuncion.Text = "1" Then
                a = 30
                subtotal = Val(txtentradas.Text) * a

            ElseIf ComboCine.Text = "A" And combofuncion.Text = "2" Then
                a = 35
                subtotal = Val(txtentradas.Text) * a

            ElseIf ComboCine.Text = "A" And combofuncion.Text = "3" Then
                a = 40
                subtotal = Val(txtentradas.Text) * a
            ElseIf ComboCine.Text = "A" And Combofuncion.Text = "4" Then
                a = 40
                subtotal = Val(txtentradas.Text) * a
            End If

            If combocine.Text = "B" And combofuncion.Text = "1" Then

                b = 24
                subtotal = Val(txtentradas.Text) * b
            ElseIf ComboCine.Text = "B" And ComboFuncion.Text = "2" Then

                b = 34
                subtotal = Val(txtentradas.Text) * b
            ElseIf ComboCine.Text = "B" And ComboFuncion.Text = "3" Then

                b = 44
                subtotal = Val(txtentradas.Text) * b
            ElseIf ComboCine.Text = "B" And ComboFuncion.Text = "4" Then

                b = 44
                subtotal = Val(txtentradas.Text) * b
            End If

            If combocine.Text = "C" And combofuncion.Text = "1" Then

                c = 35
                subtotal = Val(txtentradas.Text) * c
            ElseIf ComboCine.Text = "C" And ComboFuncion.Text = "2" Then

                c = 40
                subtotal = Val(txtentradas.Text) * c
            ElseIf ComboCine.Text = "C" And ComboFuncion.Text = "3" Then

                c = 50
                subtotal = Val(txtentradas.Text) * c
            ElseIf ComboCine.Text = "C" And ComboFuncion.Text = "4" Then

                c = 50
                subtotal = Val(txtentradas.Text) * c
            End If

            subtotal(indice) = subtotal

            vdescuento1(indice) = calculardesc1(vfuncion(indice), vcine(indice))
            vdescuento2(indice) = calculardesc2(subtotal2)

            totalapagar = subtotal - calculardesc1(vfuncion(indice), vcine(indice)) - calculardesc2(subtotal2)

            totalapagar(indice) = totalapagar

            mostrar_resultado()

            indice = indice + 1


        End If


    End Sub
    Function calculardesc1(Funcion_ As Double, Cine_ As String) As Double

        If (combofuncion.Text = "3" Or combofuncion.Text = "4") And (combocine.Text = "C" Or combocine.Text = "B") Then

            calculardesc1 = subtotal * 0.055

        ElseIf (combofuncion.Text = "1") And (combocine.Text = "C" Or combocine.Text = "B") Then

            calculardesc1 = subtotal * 0.03

        ElseIf (combofuncion.Text = "2") And (combocine.Text = "A") Then

            calculardesc1 = subtotal * 0.015

        End If

        Return calculardesc1

    End Function

    Function calculardesc2(subtotal_2 As Double) As Double

        If (subtotal >= 100 And subtotal <= 300) Then

            calculardesc2 = subtotal * 0.02

        ElseIf (subtotal >= 301 And subtotal <= 500) Then

            calculardesc2 = subtotal * 0.04

        ElseIf (subtotal >= 501 And subtotal <= 1000) Then

            calculardesc2 = subtotal * 0.06

        End If

        Return calculardesc2

    End Function




    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Limpiarlistas()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        limpiarentradas()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Limpiar_vectores()
    End Sub
End Class
