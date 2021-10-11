Imports System.Math
Public Class Form1
    Dim TOTALPARCIAL As Integer = 0
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ComboBox1.Text = "" Or ComboBox2.Text = "" Or ComboBox3.Text = "" Then
            MsgBox("Debe ingresar todos los datos", vbExclamation, "Sistema")
            TextBox1.Focus()
        ElseIf TextBox1.Text = "" Or TextBox2.Text = "" Then
            MsgBox("Debe ingresar todos los datos", vbExclamation, "Sistema")
            TextBox1.Focus()
        ElseIf (INDICE <= 6) Then
            edad(indice) = Val(TextBox1.Text)
            genero(INDICE) = ComboBox1.Text
            codigoreg(indice) = ComboBox2.Text
            daños(INDICE) = Val(TextBox2.Text)
            taller(indice) = ComboBox3.Text
            indice = INDICE + 1
            INICIAR()
        End If
        If (INDICE >= 7) Then
            MsgBox("Registro Completo", vbInformation, "Sistema")
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim MOSTRAR_ As Byte
        DataGridView1.Rows.Clear()
        For MOSTRAR_ = 0 To 6
            If edad(MOSTRAR_) <> Nothing Then
                DataGridView1.Rows.Add(edad(MOSTRAR_), genero(MOSTRAR_), codigoreg(MOSTRAR_), daños(MOSTRAR_), taller(MOSTRAR_))
            Else
                Exit For
            End If
        Next MOSTRAR_
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        Dim TOTALP As Integer
        For TOTALP = 0 To DataGridView1.Rows.Count - 2
            TOTALPARCIAL = TOTALPARCIAL + Val(DataGridView1.Rows(TOTALP).Cells(3).Value)

        Next TOTALP
        TextBox3.Text = Str(TOTALPARCIAL) * 0.06
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim LIMPIAR As Byte
        For LIMPIAR = 0 To 6
            edad(LIMPIAR) = Nothing
            genero(LIMPIAR) = Nothing
            codigoreg(LIMPIAR) = Nothing
            daños(LIMPIAR) = Nothing
            taller(LIMPIAR) = Nothing
        Next LIMPIAR
        MsgBox("Vectores Borrados Correctamente", vbInformation, "Sistema")
        DataGridView1.Rows.Clear()
        TextBox3.Clear()
        INDICE = 0
        INICIAR()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim R As Byte
        Dim MD_ As Byte = 0
        Dim GF As Byte = 0
        Dim GM As Byte = 0
        Dim RE As Byte = 0
        Dim CI As Byte = 0
        Dim TOT As Byte = 0
        For R = 0 To 6
            If (edad(R) <= 24 And edad(R) > 0) Then
                MD_ = (MD_ + 1)
            End If
            If (genero(R) = "Femenino") Then
                GF = (GF + 1)
            End If
            If (genero(R) = "Masculino") And (edad(R) >= 18 And edad(R) <= 25) Then
                GM = (GM + 1)
            End If
            If (codigoreg(R) = "0 (Extranjero)") Then
                RE = (RE + 1)
            End If
        Next R
        TextBox4.Text = Str(MD_) / indice
        TextBox5.Text = Str(GF) / indice
        TextBox6.Text = Str(GM) / indice
        TextBox7.Text = Str(RE) / indice
        TextBox8.Text = indice
        TextBox9.Text = TOTALPARCIAL

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        LIMPIARESTADISTICAS()
        MsgBox("Campos Borrados Correctamente", vbInformation, "Sistema")
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        SALIR()
    End Sub
End Class

