<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Calcular = New System.Windows.Forms.Button()
        Me.limpiarentradas = New System.Windows.Forms.Button()
        Me.limpiarvectores = New System.Windows.Forms.Button()
        Me.limpiarlistas = New System.Windows.Forms.Button()
        Me.Salir = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtnit = New System.Windows.Forms.TextBox()
        Me.txtplaca = New System.Windows.Forms.TextBox()
        Me.txtdias = New System.Windows.Forms.TextBox()
        Me.listnit = New System.Windows.Forms.ListBox()
        Me.listplaca = New System.Windows.Forms.ListBox()
        Me.listmarca = New System.Windows.Forms.ListBox()
        Me.listdias = New System.Windows.Forms.ListBox()
        Me.listparcial = New System.Windows.Forms.ListBox()
        Me.listdescuento = New System.Windows.Forms.ListBox()
        Me.listtotal = New System.Windows.Forms.ListBox()
        Me.combomarca = New System.Windows.Forms.ComboBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.checkefectivo = New System.Windows.Forms.CheckBox()
        Me.checktarjeta = New System.Windows.Forms.CheckBox()
        Me.txtefectivo = New System.Windows.Forms.TextBox()
        Me.txttarjeta = New System.Windows.Forms.TextBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.combomarca)
        Me.GroupBox1.Controls.Add(Me.txtdias)
        Me.GroupBox1.Controls.Add(Me.txtplaca)
        Me.GroupBox1.Controls.Add(Me.txtnit)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.PictureBox2)
        Me.GroupBox1.Location = New System.Drawing.Point(21, 24)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(289, 176)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ingresar Datos:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(28, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "NIT:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Placa:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(23, 101)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Marca:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(23, 137)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Días a Alquilar:"
        '
        'Calcular
        '
        Me.Calcular.Location = New System.Drawing.Point(614, 39)
        Me.Calcular.Name = "Calcular"
        Me.Calcular.Size = New System.Drawing.Size(140, 23)
        Me.Calcular.TabIndex = 1
        Me.Calcular.Text = "&Calcular"
        Me.Calcular.UseVisualStyleBackColor = True
        '
        'limpiarentradas
        '
        Me.limpiarentradas.Location = New System.Drawing.Point(614, 68)
        Me.limpiarentradas.Name = "limpiarentradas"
        Me.limpiarentradas.Size = New System.Drawing.Size(140, 23)
        Me.limpiarentradas.TabIndex = 2
        Me.limpiarentradas.Text = "Limpiar &Entradas"
        Me.limpiarentradas.UseVisualStyleBackColor = True
        '
        'limpiarvectores
        '
        Me.limpiarvectores.Location = New System.Drawing.Point(614, 97)
        Me.limpiarvectores.Name = "limpiarvectores"
        Me.limpiarvectores.Size = New System.Drawing.Size(140, 23)
        Me.limpiarvectores.TabIndex = 3
        Me.limpiarvectores.Text = "Limpiar &Vectores"
        Me.limpiarvectores.UseVisualStyleBackColor = True
        '
        'limpiarlistas
        '
        Me.limpiarlistas.Location = New System.Drawing.Point(614, 126)
        Me.limpiarlistas.Name = "limpiarlistas"
        Me.limpiarlistas.Size = New System.Drawing.Size(140, 23)
        Me.limpiarlistas.TabIndex = 4
        Me.limpiarlistas.Text = "Limpiar &Listas"
        Me.limpiarlistas.UseVisualStyleBackColor = True
        '
        'Salir
        '
        Me.Salir.Location = New System.Drawing.Point(614, 155)
        Me.Salir.Name = "Salir"
        Me.Salir.Size = New System.Drawing.Size(140, 23)
        Me.Salir.TabIndex = 5
        Me.Salir.Text = "&Salir"
        Me.Salir.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.listtotal)
        Me.GroupBox2.Controls.Add(Me.listdescuento)
        Me.GroupBox2.Controls.Add(Me.listparcial)
        Me.GroupBox2.Controls.Add(Me.listdias)
        Me.GroupBox2.Controls.Add(Me.listmarca)
        Me.GroupBox2.Controls.Add(Me.listplaca)
        Me.GroupBox2.Controls.Add(Me.listnit)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.PictureBox4)
        Me.GroupBox2.Location = New System.Drawing.Point(16, 220)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(792, 276)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 35)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(25, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "NIT"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(115, 35)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(34, 13)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Placa"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(227, 35)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(37, 13)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Marca"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(339, 35)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(76, 13)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "Días a Alquilar"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(451, 35)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(67, 13)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "Pago Parcial"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(563, 35)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(112, 13)
        Me.Label10.TabIndex = 5
        Me.Label10.Text = "Descuento o Recargo"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(675, 35)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(31, 13)
        Me.Label11.TabIndex = 6
        Me.Label11.Text = "Total"
        '
        'txtnit
        '
        Me.txtnit.Location = New System.Drawing.Point(124, 28)
        Me.txtnit.Name = "txtnit"
        Me.txtnit.Size = New System.Drawing.Size(121, 20)
        Me.txtnit.TabIndex = 4
        '
        'txtplaca
        '
        Me.txtplaca.Location = New System.Drawing.Point(124, 64)
        Me.txtplaca.Name = "txtplaca"
        Me.txtplaca.Size = New System.Drawing.Size(121, 20)
        Me.txtplaca.TabIndex = 5
        '
        'txtdias
        '
        Me.txtdias.Location = New System.Drawing.Point(124, 134)
        Me.txtdias.Name = "txtdias"
        Me.txtdias.Size = New System.Drawing.Size(121, 20)
        Me.txtdias.TabIndex = 6
        '
        'listnit
        '
        Me.listnit.FormattingEnabled = True
        Me.listnit.Location = New System.Drawing.Point(6, 62)
        Me.listnit.Name = "listnit"
        Me.listnit.Size = New System.Drawing.Size(106, 186)
        Me.listnit.TabIndex = 7
        '
        'listplaca
        '
        Me.listplaca.FormattingEnabled = True
        Me.listplaca.Location = New System.Drawing.Point(118, 62)
        Me.listplaca.Name = "listplaca"
        Me.listplaca.Size = New System.Drawing.Size(106, 186)
        Me.listplaca.TabIndex = 8
        '
        'listmarca
        '
        Me.listmarca.FormattingEnabled = True
        Me.listmarca.Location = New System.Drawing.Point(230, 62)
        Me.listmarca.Name = "listmarca"
        Me.listmarca.Size = New System.Drawing.Size(106, 186)
        Me.listmarca.TabIndex = 9
        '
        'listdias
        '
        Me.listdias.FormattingEnabled = True
        Me.listdias.Location = New System.Drawing.Point(342, 62)
        Me.listdias.Name = "listdias"
        Me.listdias.Size = New System.Drawing.Size(106, 186)
        Me.listdias.TabIndex = 10
        '
        'listparcial
        '
        Me.listparcial.FormattingEnabled = True
        Me.listparcial.Location = New System.Drawing.Point(454, 62)
        Me.listparcial.Name = "listparcial"
        Me.listparcial.Size = New System.Drawing.Size(106, 186)
        Me.listparcial.TabIndex = 11
        '
        'listdescuento
        '
        Me.listdescuento.FormattingEnabled = True
        Me.listdescuento.Location = New System.Drawing.Point(566, 62)
        Me.listdescuento.Name = "listdescuento"
        Me.listdescuento.Size = New System.Drawing.Size(106, 186)
        Me.listdescuento.TabIndex = 12
        '
        'listtotal
        '
        Me.listtotal.FormattingEnabled = True
        Me.listtotal.Location = New System.Drawing.Point(678, 62)
        Me.listtotal.Name = "listtotal"
        Me.listtotal.Size = New System.Drawing.Size(106, 186)
        Me.listtotal.TabIndex = 13
        '
        'combomarca
        '
        Me.combomarca.FormattingEnabled = True
        Me.combomarca.Items.AddRange(New Object() {"Honda", "Mercedes Benz", "Toyota", "Mazda"})
        Me.combomarca.Location = New System.Drawing.Point(124, 102)
        Me.combomarca.Name = "combomarca"
        Me.combomarca.Size = New System.Drawing.Size(121, 21)
        Me.combomarca.TabIndex = 7
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txttarjeta)
        Me.GroupBox3.Controls.Add(Me.txtefectivo)
        Me.GroupBox3.Controls.Add(Me.checktarjeta)
        Me.GroupBox3.Controls.Add(Me.checkefectivo)
        Me.GroupBox3.Controls.Add(Me.PictureBox3)
        Me.GroupBox3.Location = New System.Drawing.Point(339, 52)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(233, 122)
        Me.GroupBox3.TabIndex = 7
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Método de Pago"
        '
        'checkefectivo
        '
        Me.checkefectivo.AutoSize = True
        Me.checkefectivo.Location = New System.Drawing.Point(25, 35)
        Me.checkefectivo.Name = "checkefectivo"
        Me.checkefectivo.Size = New System.Drawing.Size(65, 17)
        Me.checkefectivo.TabIndex = 0
        Me.checkefectivo.Text = "Efectivo"
        Me.checkefectivo.UseVisualStyleBackColor = True
        '
        'checktarjeta
        '
        Me.checktarjeta.AutoSize = True
        Me.checktarjeta.Location = New System.Drawing.Point(25, 72)
        Me.checktarjeta.Name = "checktarjeta"
        Me.checktarjeta.Size = New System.Drawing.Size(59, 17)
        Me.checktarjeta.TabIndex = 1
        Me.checktarjeta.Text = "Tarjeta"
        Me.checktarjeta.UseVisualStyleBackColor = True
        '
        'txtefectivo
        '
        Me.txtefectivo.Location = New System.Drawing.Point(112, 33)
        Me.txtefectivo.Name = "txtefectivo"
        Me.txtefectivo.Size = New System.Drawing.Size(100, 20)
        Me.txtefectivo.TabIndex = 2
        '
        'txttarjeta
        '
        Me.txttarjeta.Location = New System.Drawing.Point(112, 70)
        Me.txttarjeta.Name = "txttarjeta"
        Me.txttarjeta.Size = New System.Drawing.Size(100, 20)
        Me.txttarjeta.TabIndex = 3
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global._201902886_RENTAUTOS.My.Resources.Resources._1812
        Me.PictureBox2.Location = New System.Drawing.Point(-5, 19)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(307, 171)
        Me.PictureBox2.TabIndex = 8
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global._201902886_RENTAUTOS.My.Resources.Resources.patron_de_mosaico_de_color_rosa_pastel_papel_pintado_2560x1600_7
        Me.PictureBox1.Location = New System.Drawing.Point(-5, -8)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(835, 554)
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global._201902886_RENTAUTOS.My.Resources.Resources._1812
        Me.PictureBox3.Location = New System.Drawing.Point(-10, 19)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(247, 107)
        Me.PictureBox3.TabIndex = 9
        Me.PictureBox3.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global._201902886_RENTAUTOS.My.Resources.Resources._1812
        Me.PictureBox4.Location = New System.Drawing.Point(-21, 19)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(822, 274)
        Me.PictureBox4.TabIndex = 14
        Me.PictureBox4.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(820, 525)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Salir)
        Me.Controls.Add(Me.limpiarlistas)
        Me.Controls.Add(Me.limpiarvectores)
        Me.Controls.Add(Me.limpiarentradas)
        Me.Controls.Add(Me.Calcular)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Form1"
        Me.Text = "RENTA AUTOS"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Calcular As Button
    Friend WithEvents limpiarentradas As Button
    Friend WithEvents limpiarvectores As Button
    Friend WithEvents limpiarlistas As Button
    Friend WithEvents Salir As Button
    Friend WithEvents txtdias As TextBox
    Friend WithEvents txtplaca As TextBox
    Friend WithEvents txtnit As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents listtotal As ListBox
    Friend WithEvents listdescuento As ListBox
    Friend WithEvents listparcial As ListBox
    Friend WithEvents listdias As ListBox
    Friend WithEvents listmarca As ListBox
    Friend WithEvents listplaca As ListBox
    Friend WithEvents listnit As ListBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents combomarca As ComboBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents txttarjeta As TextBox
    Friend WithEvents txtefectivo As TextBox
    Friend WithEvents checktarjeta As CheckBox
    Friend WithEvents checkefectivo As CheckBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
End Class
