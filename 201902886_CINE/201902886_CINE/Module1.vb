Module Module1

    Public a As Integer
    Public b As Integer
    Public c As Integer

    Public numeroentradas As Integer
    Public desc1 As Double
    Public desc2 As Double
    Public subtotal1 As Double
    Public subtotal2 As Double
    Public subtotal = 0
    Public total As Double

    Public vfuncion(9)
    Public vcine(9)
    Public vnumeroentradas(9)
    Public subtotalapagar(9)
    Public vdescuento1(9)
    Public vdescuento2(9)
    Public totalapagar(9)

    Public indice = 0

    Public calculosubtotal As Double = 0
    Public calculodesc1 As Double = 0
    Public calculodesc2 As Double = 0
    Public total2 As Double = 0



    Sub Limpiarlistas()

        Form1.Listcine.Items.Clear()
        Form1.Listfuncion.Items.Clear()
        Form1.Listsubtotal.Items.Clear()
        Form1.Listdescuento1.Items.Clear()
        Form1.Listdescuento2.Items.Clear()
        Form1.Listtotal.Items.Clear()

        indice = 0

    End Sub


    Sub Limpiar_vectores()

        Form1.Listcine.Items.Clear()
        Form1.Listfuncion.Items.Clear()
        Form1.Listsubtotal.Items.Clear()
        Form1.Listdescuento1.Items.Clear()
        Form1.Listdescuento2.Items.Clear()
        Form1.Listtotal.Items.Clear()

        indice = 0

    End Sub


    Sub limpiarentradas()
        Form1.txtentradas.Clear()
        Form1.combofuncion.SelectedIndex = "-1"
        Form1.combocine.SelectedIndex = "-1"
    End Sub

    Sub mostrar_resultado()

        Form1.Listfuncion.Items.Add(vfuncion(indice))
        Form1.Listcine.Items.Add(vcine(indice))
        Form1.Listentradas.Items.Add(vnumeroentradas(indice))
        Form1.Listsubtotal.Items.Add(subtotal(indice))
        Form1.Listdescuento1.Items.Add(vdescuento1(indice))
        Form1.Listdescuento2.Items.Add(vdescuento2(indice))
        Form1.Listtotal.Items.Add(totalapagar(indice))

    End Sub





End Module
