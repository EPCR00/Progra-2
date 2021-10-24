Public Class Form1
    Dim Thabitacion As Double
    Dim Tpago As Double, TPAGO1 As Double
    Private Sub CALCULOToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CALCULOToolStripMenuItem.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Then
            MsgBox("Debe ingresar todos los datos", vbExclamation, "Sistema")
        ElseIf ComboBox1.Text = "" Or ComboBox2.Text = "" Then
            MsgBox("Debe ingresar todos los datos", vbExclamation, "Sistema")
        ElseIf ((REPETIDO())) Then
            If (FILA <= 5) Then
                Select Case ComboBox1.Text
                    Case "Habitación Privada"
                        Thabitacion = 350
                    Case "Habitación Semi-Privada"
                        Thabitacion = 250
                    Case "Habitación No Privada"
                        Thabitacion = 150
                End Select
                Select Case ComboBox2.Text
                    Case "Efectivo"
                        Tpago = (Thabitacion * 0.1)
                    Case "Deposito"
                        Tpago = (Thabitacion * 0.1)
                    Case "ACH"
                        Tpago = (Thabitacion * 0.08)
                    Case "Tarjeta de Crédito"
                        Tpago = (Thabitacion * 0.015)
                    Case Else
                        TPAGO = 0
                End Select
                Select Case ComboBox2.Text
                    Case "Efectivo"
                        TPAGO1 = Thabitacion - (Thabitacion * 0.1)
                    Case "Deposito"
                        TPAGO1 = Thabitacion - (Thabitacion * 0.1)
                    Case "ACH"
                        TPAGO1 = Thabitacion - (Thabitacion * 0.08)
                    Case "Tarjeta de Crédito"
                        TPAGO1 = Thabitacion + (Thabitacion * 0.015)
                    Case Else
                        TPAGO1 = THABITACION
                End Select
                Hospital(Fila, 0) = TextBox1.Text
                Hospital(Fila, 1) = TextBox2.Text
                Hospital(Fila, 2) = TextBox3.Text
                Hospital(Fila, 3) = TextBox4.Text
                Hospital(Fila, 4) = ComboBox1.Text
                Hospital(Fila, 5) = ComboBox2.Text
                Hospital(Fila, 6) = Thabitacion
                Hospital(Fila, 7) = Tpago
                Hospital(Fila, 8) = TPAGO1
                Fila = Fila + 1
                MsgBox("Datos ingresados Correctamente", vbInformation, "Sistema")
                LIMPIARENTRADAS()
            End If
        Else
            MsgBox("NIT ya registrado, verifique el dato ingresado", vbExclamation, "Sistema")
            TextBox2.Focus()
        End If
        If (FILA = 6) Then
            MsgBox("Límite de Datos Llena", vbExclamation, "Sistema")
        End If
    End Sub

    Private Sub MOSTRARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MOSTRARToolStripMenuItem.Click
        MOSTRAR()
    End Sub

    Private Sub MATRIZToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MATRIZToolStripMenuItem.Click
        LIMPIARMATRIZ()
        MsgBox("Matriz Limpia Correctamente", vbInformation, "Sistema")
    End Sub

    Private Sub CONSULTARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CONSULTARToolStripMenuItem.Click
        Dim CONSULTA As Boolean = True
        I = 0
        While (I <= 5) And CONSULTA
            If (HOSPITAL(I, 0) <> Nothing) Then
                If (Val(HOSPITAL(I, 1)) = Val(TextBox5.Text)) Then
                    CONSULTA = False
                Else
                    I = I + 1
                End If
            Else
                Exit While
            End If
        End While
        If CONSULTA Then
            MsgBox("NIT no encontrado", vbExclamation, "Sistema")
            TextBox5.Focus()
        Else
            MsgBox("Se realizo el registro exitosamente", vbInformation, "Sistema")
            TextBox1.Text = Hospital(I, 0)
            TextBox2.Text = Hospital(I, 1)
            TextBox3.Text = Hospital(I, 2)
            TextBox4.Text = Hospital(I, 3)
            ComboBox1.Text = Hospital(I, 4)
            ComboBox2.Text = Hospital(I, 5)
        End If
        DataGridView1.Rows.Clear()
        DataGridView1.Rows.Add(Hospital(I, 0), Hospital(I, 1), Hospital(I, 2), Hospital(I, 3), Hospital(I, 4), Hospital(I, 5), Hospital(I, 6), Hospital(I, 7), Hospital(I, 8))
        LIMPIARESTADISTICAS()
        FILA = I
    End Sub

    Private Sub ESTADISTICASToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ESTADISTICASToolStripMenuItem.Click
        Dim estadistica As Byte
        Dim sa As Double
        Dim NPRIV As Double

        I = 0
        While (I <= 5)
            If (Hospital(I, 0) <> Nothing) Then
                If (Hospital(I, 4) = "Habitación Privada") Then
                    estadistica = estadistica + 1
                End If

                If (Hospital(I, 5) = "ACH") Then
                    sa = sa + Val(DataGridView1.Rows(I).Cells(6).Value)
                End If

                If (Hospital(I, 4) = "Habitación No Privada") Then
                    NPRIV = NPRIV + Val(DataGridView1.Rows(I).Cells(2).Value)

                End If

                I = I + 1
            Else
                Exit While
            End If
        End While
        TextBox6.Text = Str(estadistica)
        TextBox7.Text = Str(sa)
        TextBox8.Text = Str(NPRIV)

    End Sub

    Private Sub ESTADISTICASToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ESTADISTICASToolStripMenuItem1.Click
        LIMPIARESTADISTICAS()
        MsgBox("Limpieza de Estadisticas Correcta", vbInformation, "Sistema")
    End Sub

    Private Sub CERRARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CERRARToolStripMenuItem.Click
        If MsgBox("¿Seguro que Desea Salir?", vbQuestion + vbYesNo, "Mensaje Salida") = vbYes Then
            Close()
        Else
            LIMPIARENTRADAS()
            LIMPIARESTADISTICAS()
        End If
    End Sub
End Class