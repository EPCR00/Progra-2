Module Module1


    Public Hondia As Double = 250.0
    Public Merdia As Double = 450.0
    Public Toydia As Double = 325.0
    Public Mazdia As Double = 300.0

    Public indice As Byte = 0
    Public diasalquiler As Integer
    Public pagoparcial As Double

    Public Nit(6) As String
    Public Placa(6) As String
    Public Marca(6) As String
    Public Dias(6) As Integer
    Public Parcial(6) As Double
    Public Descuento(6) As Double
    Public Total(6) As Double

    Sub Limpiar_entradas()

        Form1.combomarca.SelectedIndex = "-1"
        Form1.txtnit.Clear()
        Form1.txtplaca.Clear()
        Form1.txtefectivo.Clear()
        Form1.txttarjeta.Clear()
        Form1.txtdias.Clear()
        Form1.checkefectivo.Checked = "False"
        Form1.CheckTarjeta.Checked = "False"
        Form1.txtefectivo.Enabled = "False"
        Form1.txttarjeta.Enabled = "False"

    End Sub

    Sub mostrar_resultado()

        Form1.listnit.Items.Add(Nit(indice))
        Form1.listplaca.Items.Add(Placa(indice))
        Form1.listmarca.Items.Add(Marca(indice))
        Form1.listdias.Items.Add(Dias(indice))
        Form1.listparcial.Items.Add(Parcial(indice))
        Form1.listdescuento.Items.Add(Descuento(indice))
        Form1.listtotal.Items.Add(Total(indice))

    End Sub

    Sub Limpiar_Listas()

        Form1.listnit.Items.Clear()
        Form1.listplaca.Items.Clear()
        Form1.listmarca.Items.Clear()
        Form1.listdias.Items.Clear()
        Form1.listparcial.Items.Clear()
        Form1.listdescuento.Items.Clear()
        Form1.listtotal.Items.Clear()

    End Sub

    Sub Limpiar_vectores()

        Form1.listnit.Items.Clear()
        Form1.listplaca.Items.Clear()
        Form1.listmarca.Items.Clear()
        Form1.listdias.Items.Clear()
        Form1.listparcial.Items.Clear()
        Form1.listdescuento.Items.Clear()
        Form1.listtotal.Items.Clear()

        indice = 0
        MsgBox("Puede realizar ingresos nuevamente", vbInformation)

    End Sub










End Module
