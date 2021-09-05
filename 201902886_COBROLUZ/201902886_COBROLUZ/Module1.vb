Module Module1

    'Valor de Condiciones
    Public Const residencial1 As Double = 0.99
    Public Const residencial2 As Double = 1.2
    Public Const residencial3 As Double = 3.0

    Public Const industrial1 As Double = 1.99
    Public Const industrial2 As Double = 2.2
    Public Const industrial3 As Double = 4.0

    Public indice As Byte = 0

    'Datos solicitados
    Public totalpagoinicial As Double
    Public totalpagoparcial As Double
    Public totalpagoparcial1 As Double
    Public totalpagofinal As Double
    Public totalpagofinal1 As Double
    Public totalconmora As Double
    Public totalrecargo As Double
    Public totaltarifa As Double
    Public moraaplicada As Double = 0.02

    Public descuentosocial = 0.2
    Public descuentonosocial = 0.1

    'Cantidad
    Public Cliente(11) As String
    Public Servicio(11) As String
    Public Tarifa(11) As String
    Public SaldoAnterior(11) As Double
    Public PagoInicial(11) As Double
    Public Mora(11) As String
    Public PMora(11) As String
    Public PagoParcial(11) As Double
    Public Descuento(11) As String
    Public PagoTotal(11) As Double




    Sub limpiar_entradas()

        Form1.txtconsumidor.Clear()
        Form1.txtnit.Clear()
        Form1.txtsaldoanterior.Clear()
        Form1.txtconsumo.Clear()
        Form1.txtconsumidor.Focus()

    End Sub

    Sub mostrar()

        Form1.listcliente.Items.Add(Cliente(indice))
        Form1.listservicio.Items.Add(Servicio(indice))
        Form1.listtarifa.Items.Add(Tarifa(indice))
        Form1.listsaldoanterior.Items.Add(SaldoAnterior(indice))
        Form1.listpagoinicial.Items.Add(PagoInicial(indice))
        Form1.listmora.Items.Add(Mora(indice))
        Form1.listpagomora.Items.Add(PMora(indice))
        Form1.listpagoparcial.Items.Add(PagoParcial(indice))
        Form1.listdescuento.Items.Add(Descuento(indice))
        Form1.listtotal.Items.Add(PagoTotal(indice))

    End Sub


    Sub LimpiarV()

        Form1.listcliente.Items.Clear()
        Form1.listservicio.Items.Clear()
        Form1.listtarifa.Items.Clear()
        Form1.listsaldoanterior.Items.Clear()
        Form1.listpagoinicial.Items.Clear()
        Form1.listmora.Items.Clear()
        Form1.listpagomora.Items.Clear()
        Form1.listpagoparcial.Items.Clear()
        Form1.listdescuento.Items.Clear()
        Form1.listtotal.Items.Clear()

        indice = 0

    End Sub
End Module