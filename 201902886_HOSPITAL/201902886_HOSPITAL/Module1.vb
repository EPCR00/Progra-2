Module Module1
    Public Hospital(6, 9) As String
    Public Fila As Byte = 0
    Public I As Byte
    Function Repetido() As Boolean
        Dim Encontrado As Boolean = True
        I = 0
        Repetido = True
        While (I <= 5) And (Encontrado)
            If (Hospital(I, 0) <> Nothing) Then
                If (Hospital(I, 1) = Val(Form1.TextBox2.Text)) Then
                    Repetido = Encontrado = False
                    Return Repetido
                Else
                    I = I + 1
                End If
            Else
                Exit While
            End If
        End While
        If (Encontrado) Then
            Return Repetido
        End If
    End Function
    Sub MOSTRAR()
        Form1.DataGridView1.Rows.Clear()
        I = 0
        While (I <= 5)
            If (HOSPITAL(I, 0) <> Nothing) Then
                Form1.DataGridView1.Rows.Add(Hospital(I, 0), Hospital(I, 1), Hospital(I, 2), Hospital(I, 3), Hospital(I, 4), Hospital(I, 5), Hospital(I, 6), Hospital(I, 7), Hospital(I, 8))
            Else
                Exit While
            End If
            I = I + 1
        End While
    End Sub
    Sub LIMPIARMATRIZ()
        Form1.DataGridView1.Rows.Clear()
        FILA = 0
        I = 0
        While (I <= 5)
            Hospital(I, 0) = Nothing
            Hospital(I, 1) = Nothing
            Hospital(I, 2) = Nothing
            Hospital(I, 3) = Nothing
            Hospital(I, 4) = Nothing
            Hospital(I, 5) = Nothing
            Hospital(I, 6) = Nothing
            Hospital(I, 7) = Nothing
            Hospital(I, 8) = Nothing
            I = I + 1
        End While
    End Sub

    Sub LIMPIARESTADISTICAS()

        Form1.TextBox6.Clear()
        Form1.TextBox7.Clear()
        Form1.TextBox8.Clear()

    End Sub

    Sub LIMPIARENTRADAS()

        Form1.TextBox1.Clear()
        Form1.TextBox2.Clear()
        Form1.TextBox3.Clear()
        Form1.TextBox4.Clear()
        Form1.ComboBox1.Text = ""
        Form1.ComboBox2.Text = ""

    End Sub

End Module
