Module Module1

    Public DPI(6) As Double
    Public Nombre(6) As String
    Public Valor(6) As Double
    Public Meses(6) As Integer
    Public Tasa(6) As Double
    Public Total(6) As Double

    Public t As Byte
    Public i As Integer = 0

    Function comprobar_repetido() As Boolean
        Dim encontrado As Boolean = True
        t = 0
        comprobar_repetido = True
        While (t <= 6) And (encontrado)

            If (DPI(t) <> Nothing) Then

                If (DPI(t) = (Form1.TextBox1.Text)) Then
                    comprobar_repetido = encontrado = False
                    Return comprobar_repetido
                Else
                    t = t + 1
                End If
            Else
                Exit While
            End If
        End While
        If (encontrado) Then
            Return comprobar_repetido
        End If

    End Function

    Public Sub mostrar_matriz()
        Dim x As Byte

        Form1.DataGridView1.Rows.Clear()

        x = 0

        While (x < 7)

            If (DPI(x) <> Nothing) Then

                Form1.DataGridView1.Rows.Add((DPI(x)), (Nombre(x)), (Valor(x)), (Meses(x)), (Tasa(x)), (Total(x)))
                x = x + 1
            Else
                Exit While
            End If
        End While
    End Sub

    Public Sub limpiar_entradas()

        Form1.TextBox1.Text = ""
        Form1.TextBox2.Text = ""
        Form1.TextBox3.Text = ""
        Form1.TextBox4.Text = ""

    End Sub
    Public Sub limpiar_vectores()

        Dim j As Byte

        Form1.DataGridView1.Rows.Clear()
        i = 0


        j = 0
        While (j <= 5)

            DPI(j) = Nothing
            Nombre(j) = Nothing
            Valor(j) = Nothing
            Meses(j) = Nothing
            Tasa(j) = Nothing
            Total(j) = Nothing

            j = j + 1

        End While

        MsgBox("Vectores se han limpiado exitosamente", vbInformation)

    End Sub


End Module
