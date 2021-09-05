Public Class Form1

    Private Sub salir_Click(sender As Object, e As EventArgs) Handles salir.Click

        If MsgBox("¿Seguro que desea salir?", vbQuestion + vbYesNo, "Pregunta") = vbYes Then
            End
        End If

    End Sub


    Private Sub limpiarentradas_Click(sender As Object, e As EventArgs) Handles limpiarentradas.Click

        limpiar_entradas()

    End Sub


    Private Sub limpv_Click(sender As Object, e As EventArgs) Handles limpv.Click

        LimpiarV()

    End Sub


    Private Sub calcular_Click(sender As Object, e As EventArgs) Handles calcular.Click

        If (txtconsumidor.Text = "") Then

            MsgBox("Ingrese su nombre", vbExclamation)
            Limpiar_Entradas()
            Exit Sub

            txtconsumidor.Focus()

        End If

        If (txtnit.Text = "") Then

            MsgBox("Ingrese su NIT", vbExclamation)
            Limpiar_Entradas()
            Exit Sub

            txtconsumidor.Focus()

        End If

        If (txtconsumo.Text = "") Then

            MsgBox("Ingrese el consumo de kiloWatts", vbExclamation)
            Limpiar_Entradas()
            Exit Sub

            txtconsumidor.Focus()

        End If

        If (txtsaldoanterior.Text = "") Then

            MsgBox("Ingrese el saldo anterior, de no existir colocar 0", vbExclamation)
            Limpiar_Entradas()
            Exit Sub

            txtsaldoanterior.Focus()

        End If

        If (indice <= 11) Then

            Cliente(indice) = txtconsumidor.Text
            Servicio(indice) = ComboBoxservicio.Text
            Tarifa(indice) = ComboBoxtarifa.Text
            Module1.SaldoAnterior(indice) = txtsaldoanterior.Text


            If Str(ComboBoxservicio.Text = "Residencial") Then

                Select Case Val(txtconsumo.Text)

                    Case 1 To 100
                        totalpagoinicial = Val(txtconsumo.Text) * residencial1
                    Case 101 To 300
                        totalpagoinicial = Val(txtconsumo.Text) * residencial2
                    Case >= 301
                        totalpagoinicial = Val(txtconsumo.Text) * residencial3

                End Select

                PagoInicial(indice) = Math.Round(totalpagoinicial, 2)

            End If

            If Str(ComboBoxservicio.Text = "Industrial") Then

                Select Case Val(txtconsumo.Text)

                    Case 1 To 100
                        totalpagoinicial = Val(txtconsumo.Text) * industrial1
                    Case 101 To 300
                        totalpagoinicial = Val(txtconsumo.Text) * industrial2
                    Case >= 301
                        totalpagoinicial = Val(txtconsumo.Text) * industrial3

                End Select

                PagoInicial(indice) = Math.Round(totalpagoinicial, 2)

            End If

            If Val(txtsaldoanterior.Text) > 0 Then

                totalrecargo = (Val(txtsaldoanterior.Text) * moraaplicada)
                Mora(indice) = (moraaplicada * 100).ToString + "%"

            ElseIf Val(txtsaldoanterior.Text) <= 0 Then

                Mora(indice) = "No se aplica mora"

            End If

            totalconmora = Val(txtsaldoanterior.Text) + totalrecargo
            PMora(indice) = Math.Round(totalconmora, 2)



            Select Case ComboBoxtarifa.Text
                Case "Social"


                    totalpagoparcial = (Val(txtsaldoanterior.Text) + totalpagoparcial) + totalrecargo
                    PagoParcial(indice) = totalpagoparcial


                    totaltarifa = totalpagoparcial * descuentosocial
                    Descuento(indice) = (descuentosocial * 100).ToString + "%"

                    totalpagofinal = totalpagoparcial - totaltarifa
                    PagoTotal(indice) = Math.Round(totalpagofinal, 2)


                Case "No Social"


                    totaltarifa = totalpagoinicial - (totalpagoinicial * descuentonosocial)
                    Descuento(indice) = (descuentonosocial * 100).ToString + "%"

                    PagoInicial(indice) = Math.Round(totaltarifa, 2)

                    totalpagoparcial = totaltarifa + totalconmora
                    PagoParcial(indice) = Math.Round(totalpagoparcial, 2)

                    totalpagofinal = totalpagoparcial

                    PagoTotal(indice) = Math.Round(totalpagofinal, 2)

                    MsgBox("Recuerde que el descuento fue aplicado a su tarifa en el pago inicial de mes, por lo que el pago parcial y el total reflejarán el mismo valor", vbExclamation, "Recordatorio")

            End Select

            mostrar()

            indice = indice + 1

        End If

        If (indice > 11) Then

            MsgBox("Límite de 11 ingresos alcanzado")

        End If

        Limpiar_Entradas()

    End Sub


End Class
