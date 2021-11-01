Public Class Form1
    Dim R As Double
    Private Sub Form1_Load(sender As Object, e As EventArgs)
        ComboBox1.Items.Add("Etapa1")
        ComboBox1.Items.Add("Etapa2")
        ComboBox1.Items.Add("Etapa3")
        ComboBox1.Items.Add("Etapa4")
        ComboBox1.Items.Add("Etapa5")
        ComboBox1.Items.Add("Etapa6")
        ComboBox1.Items.Add("Etapa7")
        ComboBox1.Items.Add("Etapa8")
        ComboBox1.Items.Add("Etapa9")
        ComboBox1.Items.Add("Etapa10")
        ComboBox1.Items.Add("Etapa11")
        ComboBox1.Items.Add("Etapa12")
        ComboBox2.Items.Add("SKY")
        ComboBox2.Items.Add("Movistar")
        ComboBox2.Items.Add("Pro Cycling")
        ComboBox2.Items.Add("Pro Team")
        ComboBox3.Items.Add("Guatemalteco")
        ComboBox3.Items.Add("EXTRANJERA")
        ComboBox4.Items.Add("Etapa1")
        ComboBox4.Items.Add("Etapa2")
        ComboBox4.Items.Add("Etapa3")
        ComboBox4.Items.Add("Etapa4")
        ComboBox4.Items.Add("Etapa5")
        ComboBox4.Items.Add("Etapa6")
        ComboBox4.Items.Add("Etapa7")
        ComboBox4.Items.Add("Etapa8")
        ComboBox4.Items.Add("Etapa9")
        ComboBox4.Items.Add("Etapa10")
        ComboBox4.Items.Add("Etapa11")
        ComboBox4.Items.Add("Etapa12")
    End Sub
    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click

        If (fila <= 11) Then
            etapa(fila) = ComboBox1.Text
            equipo(fila) = ComboBox2.Text
            recorrido(fila) = TextBox1.Text
            tiempo(fila) = TextBox2.Text
            nacionalidad(fila) = ComboBox3.Text
            If (tiempo(fila) > 120) And (tiempo(fila) <= 140) Then
                R = 30

            ElseIf (tiempo(fila) > 140) And (tiempo(fila) <= 160) Then
                R = 40

            ElseIf (tiempo(fila) > 160) Then
                R = 50
            ElseIf (tiempo(fila) < 85) And (equipo(fila) = "Movistar") Then
                R = -15

            ElseIf (tiempo(fila) < 85) And (equipo(fila) = "Pro team") Then
                R = -10
            Else
                R = 0
            End If
            penre(fila) = R
            tiempototal(fila) = tiempo(fila) + penre(fila)
            fila = fila + 1
            limpiar_entradas()
        End If
        If (fila = 12) Then
            MsgBox("Límite alcanzado en Vectores", vbExclamation)
        End If

    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        MOSTRAR()
    End Sub

    Private Sub EntradasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EntradasToolStripMenuItem.Click
        limpiar_entradas()

    End Sub

    Private Sub VectoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VectoresToolStripMenuItem.Click
        limpiar_vectores()

    End Sub

    Private Sub EstadisticasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EstadisticasToolStripMenuItem.Click
        limpiar_estadisticas()
    End Sub

    Private Sub ToolStripMenuItem8_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem8.Click
        salir()

    End Sub

    Private Sub ToolStripMenuItem9_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem9.Click

        Dim R1 As Integer = 0
        Dim R2 As Integer = 0
        Dim R3 As Integer = 0
        Dim R4 As Integer = 0
        Dim R5 As Integer = 0
        Dim R6 As Integer = 0
        Dim R7 As Integer = 0
        Dim R8 As Integer = 0
        Dim R9 As Integer = 0
        For I = 0 To 11
            If (etapa(I) <> Nothing) Then
                Select Case nacionalidad(I)
                    Case "Guatemalteco"
                        Select Case recorrido(I)
                            Case Is > 45
                                R1 = R1 + 1
                        End Select
                End Select
                Select Case equipo(I)
                    Case "SKY"
                        R2 = R2 + Val(DataGridView1.Rows(I).Cells(2).Value)
                    Case "Movistar"
                        R3 = R3 + Val(DataGridView1.Rows(I).Cells(2).Value)
                    Case "Pro Cycling"
                        R4 = R4 + Val(DataGridView1.Rows(I).Cells(2).Value)
                    Case "Pro Team"
                        R5 = R5 + Val(DataGridView1.Rows(I).Cells(2).Value)
                End Select
                Select Case equipo(I)
                    Case "SKY"
                        R6 = R6 + Val(DataGridView1.Rows(I).Cells(6).Value)
                    Case "Movistar"
                        R7 = R7 + Val(DataGridView1.Rows(I).Cells(6).Value)
                    Case "Pro Cycling"
                        R8 = R8 + Val(DataGridView1.Rows(I).Cells(6).Value)
                    Case "Pro Team"
                        R9 = R9 + Val(DataGridView1.Rows(I).Cells(6).Value)
                End Select
            Else
                Exit For
            End If
        Next I
        TextBox3.Text = Str(R1)
        TextBox4.Text = Str(R2)
        TextBox5.Text = Str(R4)
        TextBox6.Text = Str(R3)
        TextBox7.Text = Str(R5)
        TextBox8.Text = Str(R6) / 60
        TextBox9.Text = Str(R7) / 60
        TextBox10.Text = Str(R9) / 60
        TextBox11.Text = Str(R8) / 60

    End Sub

    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem3.Click

        Dim existe As Boolean = True

        I = 0
        While (I <= 11) And (existe)
            If (etapa(I) = ComboBox4.Text) Then
                existe = False
            Else
                I = I + 1
            End If
        End While
        If (existe) Then
            MsgBox("Etapa no encontrada", vbExclamation)
            ComboBox4.Focus()
        Else
            MsgBox("Registro encontrado exitosamente", vbInformation)
            TextBox1.Text = recorrido(I)
            TextBox2.Text = tiempo(I)
            ComboBox1.Text = etapa(I)
            ComboBox2.Text = equipo(I)
            ComboBox3.Text = nacionalidad(I)
            DataGridView1.Rows.Clear()
            DataGridView1.Rows.Add(etapa(I), equipo(I), recorrido(I), tiempo(I), nacionalidad(I), penre(I), tiempototal(I))
            fila = I
        End If

    End Sub

    Private Sub ToolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem4.Click

        etapa(fila) = ComboBox1.Text
        equipo(fila) = ComboBox2.Text
        recorrido(fila) = TextBox1.Text
        tiempo(fila) = TextBox2.Text
        nacionalidad(fila) = ComboBox3.Text
        If (tiempo(fila) > 120) And (tiempo(fila) <= 140) Then
            R = 30

        ElseIf (tiempo(fila) > 140) And (tiempo(fila) <= 160) Then
            R = 40

        ElseIf (tiempo(fila) > 160) Then
            R = 50
        ElseIf (tiempo(fila) < 85) And (equipo(fila) = "Movistar") Then
            R = -15

        ElseIf (tiempo(fila) < 85) And (equipo(fila) = "Pro Team") Then
            R = -10
        Else
            R = 0
        End If
        penre(fila) = R
        tiempototal(fila) = tiempo(fila) + penre(fila)
        DataGridView1.Rows.Clear()
        DataGridView1.Rows.Add(etapa(I), equipo(I), recorrido(I), tiempo(I), nacionalidad(I), penre(I), tiempototal(I))
        fila = 12
        MsgBox("Registro actualizado correctamente", vbInformation)

    End Sub

    Private Sub ToolStripMenuItem5_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem5.Click
        etapa(fila) = Nothing
        equipo(fila) = Nothing
        recorrido(fila) = Nothing
        tiempo(fila) = Nothing
        nacionalidad(fila) = Nothing
        penre(fila) = Nothing
        tiempototal(fila) = Nothing

        For I = fila To 10
            etapa(I) = etapa(I + 1)
            equipo(I) = equipo(I + 1)
            recorrido(I) = recorrido(I + 1)
            tiempo(I) = tiempo(I + 1)
            nacionalidad(I) = nacionalidad(I + 1)
            penre(I) = penre(I + 1)
            tiempototal(I) = tiempototal(I + 1)
        Next I
        MsgBox("Registro Eliminado Correctamente", vbInformation)
        etapa(I) = Nothing
        equipo(I) = Nothing
        recorrido(I) = Nothing
        tiempo(I) = Nothing
        nacionalidad(I) = Nothing
        penre(I) = Nothing
        tiempototal(I) = Nothing
        fila = I
        limpiar_entradas()
        DataGridView1.Rows.Clear()
    End Sub

    Private Sub ToolStripMenuItem7_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem7.Click

        Me.DataGridView1.Sort(Column1, System.ComponentModel.ListSortDirection.Ascending)
    End Sub
End Class
