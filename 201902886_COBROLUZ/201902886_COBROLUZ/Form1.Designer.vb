<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ComboBoxtarifa = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ComboBoxservicio = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtconsumo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtsaldoanterior = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtnit = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtconsumidor = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.listdescuento = New System.Windows.Forms.ListBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.listtotal = New System.Windows.Forms.ListBox()
        Me.listpagoparcial = New System.Windows.Forms.ListBox()
        Me.listpagomora = New System.Windows.Forms.ListBox()
        Me.listmora = New System.Windows.Forms.ListBox()
        Me.listpagoinicial = New System.Windows.Forms.ListBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.listsaldoanterior = New System.Windows.Forms.ListBox()
        Me.listtarifa = New System.Windows.Forms.ListBox()
        Me.listservicio = New System.Windows.Forms.ListBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.listcliente = New System.Windows.Forms.ListBox()
        Me.salir = New System.Windows.Forms.Button()
        Me.limpv = New System.Windows.Forms.Button()
        Me.limpiarentradas = New System.Windows.Forms.Button()
        Me.calcular = New System.Windows.Forms.Button()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ComboBoxtarifa)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.ComboBoxservicio)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtconsumo)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtsaldoanterior)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtnit)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtconsumidor)
        Me.GroupBox1.Controls.Add(Me.PictureBox2)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(509, 152)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "INGRESO DE DATOS:"
        '
        'ComboBoxtarifa
        '
        Me.ComboBoxtarifa.FormattingEnabled = True
        Me.ComboBoxtarifa.Items.AddRange(New Object() {"Social", "No social"})
        Me.ComboBoxtarifa.Location = New System.Drawing.Point(352, 100)
        Me.ComboBoxtarifa.Name = "ComboBoxtarifa"
        Me.ComboBoxtarifa.Size = New System.Drawing.Size(121, 21)
        Me.ComboBoxtarifa.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(317, 84)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(76, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Tipo de Tarifa:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(317, 28)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(87, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Tipo de Servicio:"
        '
        'ComboBoxservicio
        '
        Me.ComboBoxservicio.FormattingEnabled = True
        Me.ComboBoxservicio.Items.AddRange(New Object() {"Residencial", "Industrial"})
        Me.ComboBoxservicio.Location = New System.Drawing.Point(352, 44)
        Me.ComboBoxservicio.Name = "ComboBoxservicio"
        Me.ComboBoxservicio.Size = New System.Drawing.Size(121, 21)
        Me.ComboBoxservicio.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre de Consumidor:"
        '
        'txtconsumo
        '
        Me.txtconsumo.Location = New System.Drawing.Point(142, 110)
        Me.txtconsumo.Name = "txtconsumo"
        Me.txtconsumo.Size = New System.Drawing.Size(100, 20)
        Me.txtconsumo.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(28, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "NIT:"
        '
        'txtsaldoanterior
        '
        Me.txtsaldoanterior.Location = New System.Drawing.Point(142, 81)
        Me.txtsaldoanterior.Name = "txtsaldoanterior"
        Me.txtsaldoanterior.Size = New System.Drawing.Size(100, 20)
        Me.txtsaldoanterior.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 84)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Saldo Anterior:"
        '
        'txtnit
        '
        Me.txtnit.Location = New System.Drawing.Point(142, 53)
        Me.txtnit.Name = "txtnit"
        Me.txtnit.Size = New System.Drawing.Size(100, 20)
        Me.txtnit.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 113)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Consumo (kW):"
        '
        'txtconsumidor
        '
        Me.txtconsumidor.Location = New System.Drawing.Point(142, 25)
        Me.txtconsumidor.Name = "txtconsumidor"
        Me.txtconsumidor.Size = New System.Drawing.Size(100, 20)
        Me.txtconsumidor.TabIndex = 4
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.listdescuento)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.listtotal)
        Me.GroupBox2.Controls.Add(Me.listpagoparcial)
        Me.GroupBox2.Controls.Add(Me.listpagomora)
        Me.GroupBox2.Controls.Add(Me.listmora)
        Me.GroupBox2.Controls.Add(Me.listpagoinicial)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.listsaldoanterior)
        Me.GroupBox2.Controls.Add(Me.listtarifa)
        Me.GroupBox2.Controls.Add(Me.listservicio)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.listcliente)
        Me.GroupBox2.Controls.Add(Me.PictureBox3)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 184)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1065, 240)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "DATOS:"
        '
        'listdescuento
        '
        Me.listdescuento.FormattingEnabled = True
        Me.listdescuento.Location = New System.Drawing.Point(838, 57)
        Me.listdescuento.Name = "listdescuento"
        Me.listdescuento.Size = New System.Drawing.Size(98, 160)
        Me.listdescuento.TabIndex = 25
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(731, 33)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(70, 13)
        Me.Label14.TabIndex = 25
        Me.Label14.Text = "Pago Parcial:"
        '
        'listtotal
        '
        Me.listtotal.FormattingEnabled = True
        Me.listtotal.Location = New System.Drawing.Point(946, 57)
        Me.listtotal.Name = "listtotal"
        Me.listtotal.Size = New System.Drawing.Size(98, 160)
        Me.listtotal.TabIndex = 26
        '
        'listpagoparcial
        '
        Me.listpagoparcial.FormattingEnabled = True
        Me.listpagoparcial.Location = New System.Drawing.Point(734, 57)
        Me.listpagoparcial.Name = "listpagoparcial"
        Me.listpagoparcial.Size = New System.Drawing.Size(98, 160)
        Me.listpagoparcial.TabIndex = 24
        '
        'listpagomora
        '
        Me.listpagomora.FormattingEnabled = True
        Me.listpagomora.Location = New System.Drawing.Point(630, 57)
        Me.listpagomora.Name = "listpagomora"
        Me.listpagomora.Size = New System.Drawing.Size(98, 160)
        Me.listpagomora.TabIndex = 23
        '
        'listmora
        '
        Me.listmora.FormattingEnabled = True
        Me.listmora.Location = New System.Drawing.Point(526, 57)
        Me.listmora.Name = "listmora"
        Me.listmora.Size = New System.Drawing.Size(98, 160)
        Me.listmora.TabIndex = 22
        '
        'listpagoinicial
        '
        Me.listpagoinicial.FormattingEnabled = True
        Me.listpagoinicial.Location = New System.Drawing.Point(422, 57)
        Me.listpagoinicial.Name = "listpagoinicial"
        Me.listpagoinicial.Size = New System.Drawing.Size(98, 160)
        Me.listpagoinicial.TabIndex = 21
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(627, 33)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(83, 13)
        Me.Label13.TabIndex = 20
        Me.Label13.Text = "Pago con Mora:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(523, 33)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(34, 13)
        Me.Label12.TabIndex = 19
        Me.Label12.Text = "Mora:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(419, 33)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(65, 13)
        Me.Label11.TabIndex = 18
        Me.Label11.Text = "Pago Inicial:"
        '
        'listsaldoanterior
        '
        Me.listsaldoanterior.FormattingEnabled = True
        Me.listsaldoanterior.Location = New System.Drawing.Point(318, 57)
        Me.listsaldoanterior.Name = "listsaldoanterior"
        Me.listsaldoanterior.Size = New System.Drawing.Size(98, 160)
        Me.listsaldoanterior.TabIndex = 17
        '
        'listtarifa
        '
        Me.listtarifa.FormattingEnabled = True
        Me.listtarifa.Location = New System.Drawing.Point(214, 57)
        Me.listtarifa.Name = "listtarifa"
        Me.listtarifa.Size = New System.Drawing.Size(98, 160)
        Me.listtarifa.TabIndex = 16
        '
        'listservicio
        '
        Me.listservicio.FormattingEnabled = True
        Me.listservicio.Location = New System.Drawing.Point(110, 57)
        Me.listservicio.Name = "listservicio"
        Me.listservicio.Size = New System.Drawing.Size(98, 160)
        Me.listservicio.TabIndex = 15
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(211, 33)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(76, 13)
        Me.Label10.TabIndex = 14
        Me.Label10.Text = "Tipo de Tarifa:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(315, 33)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(76, 13)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "Saldo Anterior:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(107, 33)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(87, 13)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Tipo de Servicio:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 33)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(42, 13)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Cliente:"
        '
        'listcliente
        '
        Me.listcliente.FormattingEnabled = True
        Me.listcliente.Location = New System.Drawing.Point(6, 57)
        Me.listcliente.Name = "listcliente"
        Me.listcliente.Size = New System.Drawing.Size(98, 160)
        Me.listcliente.TabIndex = 0
        '
        'salir
        '
        Me.salir.Location = New System.Drawing.Point(603, 117)
        Me.salir.Name = "salir"
        Me.salir.Size = New System.Drawing.Size(137, 23)
        Me.salir.TabIndex = 31
        Me.salir.Text = "Salir"
        Me.salir.UseVisualStyleBackColor = True
        '
        'limpv
        '
        Me.limpv.Location = New System.Drawing.Point(603, 88)
        Me.limpv.Name = "limpv"
        Me.limpv.Size = New System.Drawing.Size(137, 23)
        Me.limpv.TabIndex = 32
        Me.limpv.Text = "Limpiar Vectores"
        Me.limpv.UseVisualStyleBackColor = True
        '
        'limpiarentradas
        '
        Me.limpiarentradas.Location = New System.Drawing.Point(603, 59)
        Me.limpiarentradas.Name = "limpiarentradas"
        Me.limpiarentradas.Size = New System.Drawing.Size(137, 23)
        Me.limpiarentradas.TabIndex = 33
        Me.limpiarentradas.Text = "Limpiar Entradas"
        Me.limpiarentradas.UseVisualStyleBackColor = True
        '
        'calcular
        '
        Me.calcular.Location = New System.Drawing.Point(603, 30)
        Me.calcular.Name = "calcular"
        Me.calcular.Size = New System.Drawing.Size(137, 23)
        Me.calcular.TabIndex = 34
        Me.calcular.Text = "Calcular"
        Me.calcular.UseVisualStyleBackColor = True
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(835, 33)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(62, 13)
        Me.Label15.TabIndex = 27
        Me.Label15.Text = "Descuento:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(943, 33)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(34, 13)
        Me.Label16.TabIndex = 28
        Me.Label16.Text = "Total:"
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global._201902886_COBROLUZ.My.Resources.Resources.canva_azul_rosa_arcoíris_gradiente_fondo_virtual_zoom_kyL4zdu4OLM
        Me.PictureBox3.Location = New System.Drawing.Point(-3, 19)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(1114, 416)
        Me.PictureBox3.TabIndex = 37
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global._201902886_COBROLUZ.My.Resources.Resources.canva_azul_rosa_arcoíris_gradiente_fondo_virtual_zoom_kyL4zdu4OLM
        Me.PictureBox2.Location = New System.Drawing.Point(0, 15)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(531, 170)
        Me.PictureBox2.TabIndex = 36
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global._201902886_COBROLUZ.My.Resources.Resources.acuarelas
        Me.PictureBox1.Location = New System.Drawing.Point(-12, -3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1105, 483)
        Me.PictureBox1.TabIndex = 35
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1088, 452)
        Me.Controls.Add(Me.calcular)
        Me.Controls.Add(Me.limpiarentradas)
        Me.Controls.Add(Me.limpv)
        Me.Controls.Add(Me.salir)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ComboBoxtarifa As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents ComboBoxservicio As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtconsumo As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtsaldoanterior As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtnit As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtconsumidor As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label14 As Label
    Friend WithEvents listtotal As ListBox
    Friend WithEvents listpagoparcial As ListBox
    Friend WithEvents listpagomora As ListBox
    Friend WithEvents listmora As ListBox
    Friend WithEvents listpagoinicial As ListBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents listsaldoanterior As ListBox
    Friend WithEvents listtarifa As ListBox
    Friend WithEvents listservicio As ListBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents listcliente As ListBox
    Friend WithEvents salir As Button
    Friend WithEvents limpv As Button
    Friend WithEvents limpiarentradas As Button
    Friend WithEvents calcular As Button
    Friend WithEvents listdescuento As ListBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
End Class
