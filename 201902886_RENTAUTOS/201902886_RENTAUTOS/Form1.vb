Public Class Form1
    Private Sub Salir_Click(sender As Object, e As EventArgs) Handles Salir.Click
        If MsgBox("¿Desea salir?", vbQuestion + vbYesNo, "Pregunta") = vbYes Then
            End
        End If
    End Sub

    Private Sub limpiarentradas_Click(sender As Object, e As EventArgs) Handles limpiarentradas.Click
        Limpiar_entradas()
    End Sub

    Private Sub limpiarlistas_Click(sender As Object, e As EventArgs) Handles limpiarlistas.Click
        Limpiar_Listas()
    End Sub

    Private Sub limpiarvectores_Click(sender As Object, e As EventArgs) Handles limpiarvectores.Click
        Limpiar_vectores()
    End Sub

    Private Sub Calcular_Click(sender As Object, e As EventArgs) Handles Calcular.Click

        If (txtnit.Text = "") Then

            MsgBox("Ingrese su NIT", vbExclamation)
            Exit Sub
            txtnit.Focus()

        End If

        If (combomarca.Text = "") Then

            MsgBox("Seleccione la marca de vehículo", vbExclamation)
            Exit Sub
            txtnit.Focus()

        End If

        If (txtplaca.Text = "") Then

            MsgBox("Ingrese su número de placa", vbExclamation)
            Exit Sub
            txtplaca.Focus()

        End If


        If (txtdias.Text = "") Then

            MsgBox("Ingrese la cantidad de días que alquilara el vehículo", vbExclamation)
            Exit Sub
            txtdias.Focus()

        End If


        If (indice < 6) Then

            Nit(indice) = txtnit.Text
            Placa(indice) = txtplaca.Text
            Marca(indice) = combomarca.SelectedItem
            Dias(indice) = txtdias.Text

            Parcial(indice) = calcularparcial(Parcial(indice))


            If checkefectivo.Checked = True And checktarjeta.Checked = False Then

                If Val(txtefectivo.Text) <> 100 Then

                    MsgBox("Error el pago no se puede procesar si no ingresa el 100% de su pago a realizar", vbInformation)
                    Exit Sub

                ElseIf Val(txtefectivo.Text) = 100 Then

                    MsgBox("Descuento aplicado por pagar en efectivo", vbInformation)

                    Descuento(indice) = calcularparcial(pagoparcial) * 0.05
                    Total(indice) = Math.Round((pagoparcial - Descuento(indice)), 2)

                End If

            End If

            If checkefectivo.Checked = False And checktarjeta.Checked = True Then

                If Val(txttarjeta.Text) <> 100 Then

                    MsgBox("Error el pago no se puede procesar si no ingresa el 100% de su pago a realizar", vbInformation)

                    Exit Sub

                ElseIf Val(txttarjeta.Text) = 100 Then

                    MsgBox("Recargo aplicado por pagar con tarjeta", vbInformation)
                    Descuento(indice) = calcularparcial(pagoparcial) * 0.025
                    Total(indice) = Math.Round((pagoparcial + Descuento(indice)), 2)

                End If


            End If

            If checkefectivo.Checked = True And checktarjeta.Checked = True Then

                If (Val(txttarjeta.Text) + Val(txtefectivo.Text)) <> 100 Then

                    MsgBox("Error el pago no se puede procesar si no ingresa el 100% de su pago a realizar", vbInformation)
                    Exit Sub
                End If

                If (Val(txttarjeta.Text) + Val(txtefectivo.Text)) = 100 Then
                    Descuento(indice) = 0
                    Total(indice) = Math.Round(calcularparcial(pagoparcial), 2)

                End If

            End If

            mostrar_resultado()
            indice = indice + 1

        End If

        If (indice >= 6) Then
            MsgBox("Límite de ingresos alcanzado", vbInformation, Title:="Sistema:")
        End If

    End Sub


    Public Function calcularparcial(ByRef PagoParcial As Double) As Double

        If combomarca.Text = "Honda" Then
            PagoParcial = Hondia * Val(txtdias.Text)

        ElseIf combomarca.Text = "Mercedes Benz" Then
            PagoParcial = Merdia * Val(txtdias.Text)

        ElseIf combomarca.Text = "Toyota" Then
            PagoParcial = Toydia * Val(txtdias.Text)

        ElseIf combomarca.Text = "Mazda" Then
            PagoParcial = Mazdia * Val(txtdias.Text)

        End If

        Return PagoParcial


    End Function



End Class
