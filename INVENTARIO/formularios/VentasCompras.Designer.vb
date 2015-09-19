<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VentasCompras
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
        Me.Label15 = New System.Windows.Forms.Label()
        Me.texsumacomprasfecha = New System.Windows.Forms.TextBox()
        Me.texsumaventasfecha = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.texventascreditofecha = New System.Windows.Forms.TextBox()
        Me.texcompracreditofecha = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.texventas2 = New System.Windows.Forms.TextBox()
        Me.texcompras2 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.botmostrar = New System.Windows.Forms.Button()
        Me.dthasta = New System.Windows.Forms.DateTimePicker()
        Me.dtdesde = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.texsumaventas = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.texventascredito = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.texsumacompras = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.texcompracredito = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.texventas = New System.Windows.Forms.TextBox()
        Me.texcompras = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.texsumacomprasfecha)
        Me.GroupBox1.Controls.Add(Me.texsumaventasfecha)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.texventascreditofecha)
        Me.GroupBox1.Controls.Add(Me.texcompracreditofecha)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.texventas2)
        Me.GroupBox1.Controls.Add(Me.texcompras2)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.botmostrar)
        Me.GroupBox1.Controls.Add(Me.dthasta)
        Me.GroupBox1.Controls.Add(Me.dtdesde)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 248)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1053, 300)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Seleccione el rango de fechas"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(640, 147)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(185, 25)
        Me.Label15.TabIndex = 17
        Me.Label15.Text = "Ventas al contado"
        '
        'texsumacomprasfecha
        '
        Me.texsumacomprasfecha.Location = New System.Drawing.Point(195, 262)
        Me.texsumacomprasfecha.Name = "texsumacomprasfecha"
        Me.texsumacomprasfecha.Size = New System.Drawing.Size(122, 29)
        Me.texsumacomprasfecha.TabIndex = 20
        '
        'texsumaventasfecha
        '
        Me.texsumaventasfecha.Location = New System.Drawing.Point(786, 262)
        Me.texsumaventasfecha.Name = "texsumaventasfecha"
        Me.texsumaventasfecha.Size = New System.Drawing.Size(122, 29)
        Me.texsumaventasfecha.TabIndex = 18
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(161, 234)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(185, 25)
        Me.Label13.TabIndex = 19
        Me.Label13.Text = "Suma de compras"
        '
        'texventascreditofecha
        '
        Me.texventascreditofecha.Location = New System.Drawing.Point(906, 175)
        Me.texventascreditofecha.Name = "texventascreditofecha"
        Me.texventascreditofecha.Size = New System.Drawing.Size(122, 29)
        Me.texventascreditofecha.TabIndex = 14
        '
        'texcompracreditofecha
        '
        Me.texcompracreditofecha.Location = New System.Drawing.Point(324, 175)
        Me.texcompracreditofecha.Name = "texcompracreditofecha"
        Me.texcompracreditofecha.Size = New System.Drawing.Size(122, 29)
        Me.texcompracreditofecha.TabIndex = 18
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(764, 234)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(167, 25)
        Me.Label12.TabIndex = 17
        Me.Label12.Text = "Suma de ventas"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(281, 147)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(192, 25)
        Me.Label14.TabIndex = 17
        Me.Label14.Text = "Compras al credito"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(874, 147)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(173, 25)
        Me.Label11.TabIndex = 13
        Me.Label11.Text = "Ventas al credito"
        '
        'texventas2
        '
        Me.texventas2.Location = New System.Drawing.Point(671, 175)
        Me.texventas2.Name = "texventas2"
        Me.texventas2.Size = New System.Drawing.Size(122, 29)
        Me.texventas2.TabIndex = 12
        '
        'texcompras2
        '
        Me.texcompras2.Location = New System.Drawing.Point(71, 175)
        Me.texcompras2.Name = "texcompras2"
        Me.texcompras2.Size = New System.Drawing.Size(122, 29)
        Me.texcompras2.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(29, 147)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(204, 25)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Compras al contado"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(336, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 25)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Hasta"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(66, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 25)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Desde"
        '
        'botmostrar
        '
        Me.botmostrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.botmostrar.Location = New System.Drawing.Point(672, 73)
        Me.botmostrar.Name = "botmostrar"
        Me.botmostrar.Size = New System.Drawing.Size(88, 33)
        Me.botmostrar.TabIndex = 2
        Me.botmostrar.Text = "Mostrar"
        Me.botmostrar.UseVisualStyleBackColor = True
        '
        'dthasta
        '
        Me.dthasta.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dthasta.Location = New System.Drawing.Point(303, 80)
        Me.dthasta.Name = "dthasta"
        Me.dthasta.Size = New System.Drawing.Size(286, 26)
        Me.dthasta.TabIndex = 1
        '
        'dtdesde
        '
        Me.dtdesde.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtdesde.Location = New System.Drawing.Point(6, 80)
        Me.dtdesde.Name = "dtdesde"
        Me.dtdesde.Size = New System.Drawing.Size(288, 26)
        Me.dtdesde.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.texsumaventas)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.texventascredito)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.texsumacompras)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.texcompracredito)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.texventas)
        Me.GroupBox2.Controls.Add(Me.texcompras)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 25)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1053, 186)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Movimientos de hoy"
        '
        'texsumaventas
        '
        Me.texsumaventas.Location = New System.Drawing.Point(786, 140)
        Me.texsumaventas.Name = "texsumaventas"
        Me.texsumaventas.Size = New System.Drawing.Size(122, 29)
        Me.texsumaventas.TabIndex = 16
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(764, 112)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(167, 25)
        Me.Label10.TabIndex = 15
        Me.Label10.Text = "Suma de ventas"
        '
        'texventascredito
        '
        Me.texventascredito.Location = New System.Drawing.Point(890, 53)
        Me.texventascredito.Name = "texventascredito"
        Me.texventascredito.Size = New System.Drawing.Size(122, 29)
        Me.texventascredito.TabIndex = 14
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(868, 25)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(173, 25)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "Ventas al credito"
        '
        'texsumacompras
        '
        Me.texsumacompras.Location = New System.Drawing.Point(195, 140)
        Me.texsumacompras.Name = "texsumacompras"
        Me.texsumacompras.Size = New System.Drawing.Size(122, 29)
        Me.texsumacompras.TabIndex = 12
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(161, 112)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(185, 25)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Suma de compras"
        '
        'texcompracredito
        '
        Me.texcompracredito.Location = New System.Drawing.Point(324, 53)
        Me.texcompracredito.Name = "texcompracredito"
        Me.texcompracredito.Size = New System.Drawing.Size(122, 29)
        Me.texcompracredito.TabIndex = 10
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(281, 25)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(192, 25)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Compras al credito"
        '
        'texventas
        '
        Me.texventas.Location = New System.Drawing.Point(671, 53)
        Me.texventas.Name = "texventas"
        Me.texventas.Size = New System.Drawing.Size(122, 29)
        Me.texventas.TabIndex = 8
        '
        'texcompras
        '
        Me.texcompras.Location = New System.Drawing.Point(52, 53)
        Me.texcompras.Name = "texcompras"
        Me.texcompras.Size = New System.Drawing.Size(122, 29)
        Me.texcompras.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(640, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(185, 25)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Ventas al contado"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 25)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(204, 25)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Compras al contado"
        '
        'VentasCompras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1093, 564)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "VentasCompras"
        Me.Text = "Compras sobre Ventas"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents botmostrar As System.Windows.Forms.Button
    Friend WithEvents dthasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtdesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents texventas As System.Windows.Forms.TextBox
    Friend WithEvents texcompras As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents texventas2 As System.Windows.Forms.TextBox
    Friend WithEvents texcompras2 As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents texsumacomprasfecha As System.Windows.Forms.TextBox
    Friend WithEvents texsumaventasfecha As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents texventascreditofecha As System.Windows.Forms.TextBox
    Friend WithEvents texcompracreditofecha As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents texsumaventas As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents texventascredito As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents texsumacompras As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents texcompracredito As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
End Class
