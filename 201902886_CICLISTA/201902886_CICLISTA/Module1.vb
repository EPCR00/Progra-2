Module Module1
    Public etapa(11) As String
    Public equipo(11) As String
    Public recorrido(11) As Integer
    Public tiempo(11) As Integer
    Public nacionalidad(11) As String
    Public penre(11) As Integer
    Public tiempototal(11) As Integer
    Public fila As Byte = 0
    Public I As Byte
    Sub salir()
        If MsgBox("¿Seguro Desea Salir?", vbQuestion + vbYesNo, "Salir") = vbYes Then
            Form1.Close()
        Else
            limpiar_entradas()
            limpiar_estadisticas()
        End If
    End Sub
    Sub limpiar_entradas()
        Form1.TextBox1.Clear()
        Form1.TextBox2.Clear()
        Form1.ComboBox1.Text = ""
        Form1.ComboBox2.Text = ""
        Form1.ComboBox3.Text = ""
        Form1.ComboBox1.Focus()
    End Sub
    Sub limpiar_estadisticas()
        Form1.TextBox3.Clear()
        Form1.TextBox4.Clear()
        Form1.TextBox5.Clear()
        Form1.TextBox6.Clear()
        Form1.TextBox7.Clear()
        Form1.TextBox8.Clear()
        Form1.TextBox9.Clear()
        Form1.TextBox10.Clear()
        Form1.TextBox11.Clear()
        Form1.TextBox3.Focus()
    End Sub
    Sub MOSTRAR()
        Form1.DataGridView1.Rows.Clear()
        For I = 0 To 11
            If (ETAPA(I) <> Nothing) Then
                Form1.DataGridView1.Rows.Add(etapa(I), equipo(I), recorrido(I), tiempo(I), nacionalidad(I), penre(I), tiempototal(I))
            Else
                Exit For
            End If
        Next I
    End Sub
    Sub limpiar_vectores()
        Form1.DataGridView1.Rows.Clear()
        FILA = 0
        For I = 0 To 4
            etapa(I) = Nothing
            equipo(I) = Nothing
            recorrido(I) = Nothing
            tiempo(I) = Nothing
            nacionalidad(I) = Nothing
            penre(I) = Nothing
            tiempototal(I) = Nothing
        Next I

    End Sub
End Module
