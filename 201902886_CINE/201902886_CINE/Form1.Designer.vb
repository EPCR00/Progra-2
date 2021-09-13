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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.combofuncion = New System.Windows.Forms.ComboBox()
        Me.combocine = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.salir = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Listcine = New System.Windows.Forms.ListBox()
        Me.Listfuncion = New System.Windows.Forms.ListBox()
        Me.Listsubtotal = New System.Windows.Forms.ListBox()
        Me.Listdescuento1 = New System.Windows.Forms.ListBox()
        Me.Listdescuento2 = New System.Windows.Forms.ListBox()
        Me.Listtotal = New System.Windows.Forms.ListBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtentradas = New System.Windows.Forms.TextBox()
        Me.Listentradas = New System.Windows.Forms.ListBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtentradas)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.combofuncion)
        Me.GroupBox1.Controls.Add(Me.combocine)
        Me.GroupBox1.Location = New System.Drawing.Point(25, 21)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(404, 135)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Cine y Función:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Función:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Cine:"
        '
        'combofuncion
        '
        Me.combofuncion.FormattingEnabled = True
        Me.combofuncion.Items.AddRange(New Object() {"1", "2", "3", "4"})
        Me.combofuncion.Location = New System.Drawing.Point(79, 93)
        Me.combofuncion.Name = "combofuncion"
        Me.combofuncion.Size = New System.Drawing.Size(110, 21)
        Me.combofuncion.TabIndex = 1
        '
        'combocine
        '
        Me.combocine.FormattingEnabled = True
        Me.combocine.Items.AddRange(New Object() {"A", "B", "C"})
        Me.combocine.Location = New System.Drawing.Point(79, 36)
        Me.combocine.Name = "combocine"
        Me.combocine.Size = New System.Drawing.Size(110, 21)
        Me.combocine.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(488, 21)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(118, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Aceptar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(488, 50)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(118, 23)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Limpiar Listas"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(488, 79)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(118, 23)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "Limpiar Entradas"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'salir
        '
        Me.salir.Location = New System.Drawing.Point(488, 137)
        Me.salir.Name = "salir"
        Me.salir.Size = New System.Drawing.Size(118, 23)
        Me.salir.TabIndex = 5
        Me.salir.Text = "Salir"
        Me.salir.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Listentradas)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Listtotal)
        Me.GroupBox2.Controls.Add(Me.Listdescuento2)
        Me.GroupBox2.Controls.Add(Me.Listdescuento1)
        Me.GroupBox2.Controls.Add(Me.Listsubtotal)
        Me.GroupBox2.Controls.Add(Me.Listfuncion)
        Me.GroupBox2.Controls.Add(Me.Listcine)
        Me.GroupBox2.Location = New System.Drawing.Point(25, 183)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(775, 244)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos:"
        '
        'Listcine
        '
        Me.Listcine.FormattingEnabled = True
        Me.Listcine.Location = New System.Drawing.Point(15, 47)
        Me.Listcine.Name = "Listcine"
        Me.Listcine.Size = New System.Drawing.Size(101, 173)
        Me.Listcine.TabIndex = 0
        '
        'Listfuncion
        '
        Me.Listfuncion.FormattingEnabled = True
        Me.Listfuncion.Location = New System.Drawing.Point(122, 47)
        Me.Listfuncion.Name = "Listfuncion"
        Me.Listfuncion.Size = New System.Drawing.Size(101, 173)
        Me.Listfuncion.TabIndex = 1
        '
        'Listsubtotal
        '
        Me.Listsubtotal.FormattingEnabled = True
        Me.Listsubtotal.Location = New System.Drawing.Point(336, 47)
        Me.Listsubtotal.Name = "Listsubtotal"
        Me.Listsubtotal.Size = New System.Drawing.Size(101, 173)
        Me.Listsubtotal.TabIndex = 2
        '
        'Listdescuento1
        '
        Me.Listdescuento1.FormattingEnabled = True
        Me.Listdescuento1.Location = New System.Drawing.Point(443, 47)
        Me.Listdescuento1.Name = "Listdescuento1"
        Me.Listdescuento1.Size = New System.Drawing.Size(101, 173)
        Me.Listdescuento1.TabIndex = 3
        '
        'Listdescuento2
        '
        Me.Listdescuento2.FormattingEnabled = True
        Me.Listdescuento2.Location = New System.Drawing.Point(550, 47)
        Me.Listdescuento2.Name = "Listdescuento2"
        Me.Listdescuento2.Size = New System.Drawing.Size(101, 173)
        Me.Listdescuento2.TabIndex = 4
        '
        'Listtotal
        '
        Me.Listtotal.FormattingEnabled = True
        Me.Listtotal.Location = New System.Drawing.Point(657, 47)
        Me.Listtotal.Name = "Listtotal"
        Me.Listtotal.Size = New System.Drawing.Size(101, 173)
        Me.Listtotal.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 31)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Cine:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(119, 31)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Función:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(333, 31)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Sub Total:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(440, 31)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Descuento 1:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(547, 31)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(71, 13)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Descuento 2:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(654, 31)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(34, 13)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Total:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(251, 44)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(52, 13)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "Cantidad:"
        '
        'txtentradas
        '
        Me.txtentradas.Location = New System.Drawing.Point(254, 70)
        Me.txtentradas.Name = "txtentradas"
        Me.txtentradas.Size = New System.Drawing.Size(100, 20)
        Me.txtentradas.TabIndex = 5
        Me.txtentradas.Text = "0"
        '
        'Listentradas
        '
        Me.Listentradas.FormattingEnabled = True
        Me.Listentradas.Location = New System.Drawing.Point(229, 47)
        Me.Listentradas.Name = "Listentradas"
        Me.Listentradas.Size = New System.Drawing.Size(101, 173)
        Me.Listentradas.TabIndex = 12
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(226, 31)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(52, 13)
        Me.Label10.TabIndex = 13
        Me.Label10.Text = "Entradas:"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(488, 108)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(118, 23)
        Me.Button4.TabIndex = 7
        Me.Button4.Text = "Limpiar Vectores"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global._201902886_CINE.My.Resources.Resources.acuarelas_azul_2
        Me.PictureBox1.Location = New System.Drawing.Point(-5, -6)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(587, 372)
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global._201902886_CINE.My.Resources.Resources.acuarelas_azul_2
        Me.PictureBox2.Location = New System.Drawing.Point(-5, 137)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(587, 372)
        Me.PictureBox2.TabIndex = 9
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global._201902886_CINE.My.Resources.Resources.acuarelas_azul_2
        Me.PictureBox3.Location = New System.Drawing.Point(435, 114)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(587, 372)
        Me.PictureBox3.TabIndex = 10
        Me.PictureBox3.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global._201902886_CINE.My.Resources.Resources.acuarelas_azul_2
        Me.PictureBox4.Location = New System.Drawing.Point(323, -72)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(587, 372)
        Me.PictureBox4.TabIndex = 11
        Me.PictureBox4.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(803, 450)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.salir)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox4)
        Me.Name = "Form1"
        Me.Text = "CINE"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents combofuncion As ComboBox
    Friend WithEvents combocine As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents salir As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Listtotal As ListBox
    Friend WithEvents Listdescuento2 As ListBox
    Friend WithEvents Listdescuento1 As ListBox
    Friend WithEvents Listsubtotal As ListBox
    Friend WithEvents Listfuncion As ListBox
    Friend WithEvents Listcine As ListBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtentradas As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Listentradas As ListBox
    Friend WithEvents Button4 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
End Class
