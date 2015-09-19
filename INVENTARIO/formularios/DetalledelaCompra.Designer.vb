<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DetalledelaCompra
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.gridcompra = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cantida = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombr = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.preciu = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.preciod = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.exentas = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tota = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.boteliminar = New System.Windows.Forms.Button()
        Me.boteditar = New System.Windows.Forms.Button()
        Me.botguardar = New System.Windows.Forms.Button()
        Me.texivauno = New System.Windows.Forms.TextBox()
        Me.text1retencion = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lson = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.texexentas = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.texnosujeta = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.textotal = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.texiva = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.texsumas = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.texproveedor = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.texnumfact = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.texformapago = New System.Windows.Forms.TextBox()
        Me.textipo = New System.Windows.Forms.TextBox()
        Me.botiz = New System.Windows.Forms.Button()
        Me.botde = New System.Windows.Forms.Button()
        Me.texnit = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.texnrc = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.textfecha = New System.Windows.Forms.TextBox()
        Me.botpagar = New System.Windows.Forms.Button()
        CType(Me.gridcompra, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'gridcompra
        '
        Me.gridcompra.AllowUserToAddRows = False
        Me.gridcompra.AllowUserToDeleteRows = False
        Me.gridcompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridcompra.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.codigo, Me.cantida, Me.nombr, Me.preciu, Me.preciod, Me.exentas, Me.tota})
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.gridcompra.DefaultCellStyle = DataGridViewCellStyle1
        Me.gridcompra.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.gridcompra.Location = New System.Drawing.Point(81, 153)
        Me.gridcompra.Name = "gridcompra"
        Me.gridcompra.ReadOnly = True
        Me.gridcompra.RowHeadersVisible = False
        Me.gridcompra.Size = New System.Drawing.Size(879, 219)
        Me.gridcompra.TabIndex = 163
        '
        'codigo
        '
        Me.codigo.HeaderText = "Codigo"
        Me.codigo.Name = "codigo"
        Me.codigo.ReadOnly = True
        Me.codigo.Width = 75
        '
        'cantida
        '
        Me.cantida.HeaderText = "Cantidad"
        Me.cantida.Name = "cantida"
        Me.cantida.ReadOnly = True
        '
        'nombr
        '
        Me.nombr.HeaderText = "Nombre del Producto"
        Me.nombr.Name = "nombr"
        Me.nombr.ReadOnly = True
        Me.nombr.Width = 300
        '
        'preciu
        '
        Me.preciu.HeaderText = "Precio Unitario"
        Me.preciu.Name = "preciu"
        Me.preciu.ReadOnly = True
        '
        'preciod
        '
        Me.preciod.HeaderText = "Ventas       no sujetas"
        Me.preciod.Name = "preciod"
        Me.preciod.ReadOnly = True
        '
        'exentas
        '
        Me.exentas.HeaderText = "Ventas Exentas"
        Me.exentas.Name = "exentas"
        Me.exentas.ReadOnly = True
        '
        'tota
        '
        Me.tota.HeaderText = "Ventas Afectas"
        Me.tota.Name = "tota"
        Me.tota.ReadOnly = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.boteliminar)
        Me.GroupBox1.Controls.Add(Me.boteditar)
        Me.GroupBox1.Controls.Add(Me.botguardar)
        Me.GroupBox1.Location = New System.Drawing.Point(81, 481)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(598, 69)
        Me.GroupBox1.TabIndex = 162
        Me.GroupBox1.TabStop = False
        '
        'boteliminar
        '
        Me.boteliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.boteliminar.ForeColor = System.Drawing.Color.Red
        Me.boteliminar.Location = New System.Drawing.Point(265, 16)
        Me.boteliminar.Name = "boteliminar"
        Me.boteliminar.Size = New System.Drawing.Size(159, 40)
        Me.boteliminar.TabIndex = 2
        Me.boteliminar.Text = "Eliminar"
        Me.boteliminar.UseVisualStyleBackColor = True
        '
        'boteditar
        '
        Me.boteditar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.boteditar.Location = New System.Drawing.Point(6, 16)
        Me.boteditar.Name = "boteditar"
        Me.boteditar.Size = New System.Drawing.Size(159, 40)
        Me.boteditar.TabIndex = 1
        Me.boteditar.Text = "Editar"
        Me.boteditar.UseVisualStyleBackColor = True
        '
        'botguardar
        '
        Me.botguardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.botguardar.Location = New System.Drawing.Point(439, 16)
        Me.botguardar.Name = "botguardar"
        Me.botguardar.Size = New System.Drawing.Size(159, 40)
        Me.botguardar.TabIndex = 0
        Me.botguardar.Text = "Salir"
        Me.botguardar.UseVisualStyleBackColor = True
        '
        'texivauno
        '
        Me.texivauno.Enabled = False
        Me.texivauno.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.texivauno.Location = New System.Drawing.Point(863, 442)
        Me.texivauno.Margin = New System.Windows.Forms.Padding(4)
        Me.texivauno.Name = "texivauno"
        Me.texivauno.Size = New System.Drawing.Size(96, 24)
        Me.texivauno.TabIndex = 158
        Me.texivauno.Text = "0.0"
        '
        'text1retencion
        '
        Me.text1retencion.AutoSize = True
        Me.text1retencion.BackColor = System.Drawing.Color.Transparent
        Me.text1retencion.Location = New System.Drawing.Point(800, 445)
        Me.text1retencion.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.text1retencion.Name = "text1retencion"
        Me.text1retencion.Size = New System.Drawing.Size(27, 13)
        Me.text1retencion.TabIndex = 157
        Me.text1retencion.Text = "(1%)"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lson)
        Me.GroupBox3.Controls.Add(Me.Label22)
        Me.GroupBox3.Location = New System.Drawing.Point(81, 390)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox3.Size = New System.Drawing.Size(603, 86)
        Me.GroupBox3.TabIndex = 156
        Me.GroupBox3.TabStop = False
        '
        'lson
        '
        Me.lson.AutoSize = True
        Me.lson.Location = New System.Drawing.Point(52, 18)
        Me.lson.Name = "lson"
        Me.lson.Size = New System.Drawing.Size(29, 13)
        Me.lson.TabIndex = 1
        Me.lson.Text = "Son:"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(9, 18)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(29, 13)
        Me.Label22.TabIndex = 0
        Me.Label22.Text = "Son:"
        '
        'texexentas
        '
        Me.texexentas.Enabled = False
        Me.texexentas.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.texexentas.Location = New System.Drawing.Point(864, 497)
        Me.texexentas.Margin = New System.Windows.Forms.Padding(4)
        Me.texexentas.Name = "texexentas"
        Me.texexentas.Size = New System.Drawing.Size(96, 24)
        Me.texexentas.TabIndex = 153
        Me.texexentas.Text = "0.0"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.Location = New System.Drawing.Point(773, 503)
        Me.Label20.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(67, 13)
        Me.Label20.TabIndex = 152
        Me.Label20.Text = "V.EXENTAS"
        '
        'texnosujeta
        '
        Me.texnosujeta.Enabled = False
        Me.texnosujeta.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.texnosujeta.Location = New System.Drawing.Point(864, 470)
        Me.texnosujeta.Margin = New System.Windows.Forms.Padding(4)
        Me.texnosujeta.Name = "texnosujeta"
        Me.texnosujeta.Size = New System.Drawing.Size(96, 24)
        Me.texnosujeta.TabIndex = 151
        Me.texnosujeta.Text = "0.0"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Location = New System.Drawing.Point(765, 475)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(77, 13)
        Me.Label15.TabIndex = 150
        Me.Label15.Text = "V.NO SUJETA"
        '
        'textotal
        '
        Me.textotal.Enabled = False
        Me.textotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textotal.Location = New System.Drawing.Point(864, 524)
        Me.textotal.Margin = New System.Windows.Forms.Padding(4)
        Me.textotal.Name = "textotal"
        Me.textotal.Size = New System.Drawing.Size(96, 24)
        Me.textotal.TabIndex = 147
        Me.textotal.Text = "0.0"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(768, 529)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(88, 16)
        Me.Label14.TabIndex = 146
        Me.Label14.Text = "Venta Total"
        '
        'texiva
        '
        Me.texiva.Enabled = False
        Me.texiva.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.texiva.Location = New System.Drawing.Point(864, 414)
        Me.texiva.Margin = New System.Windows.Forms.Padding(4)
        Me.texiva.Name = "texiva"
        Me.texiva.Size = New System.Drawing.Size(96, 24)
        Me.texiva.TabIndex = 145
        Me.texiva.Text = "0.0"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Location = New System.Drawing.Point(799, 419)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(50, 13)
        Me.Label12.TabIndex = 144
        Me.Label12.Text = "IVA(13%)"
        '
        'texsumas
        '
        Me.texsumas.Enabled = False
        Me.texsumas.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.texsumas.Location = New System.Drawing.Point(865, 385)
        Me.texsumas.Margin = New System.Windows.Forms.Padding(4)
        Me.texsumas.Name = "texsumas"
        Me.texsumas.Size = New System.Drawing.Size(96, 24)
        Me.texsumas.TabIndex = 143
        Me.texsumas.Text = "0.0"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Location = New System.Drawing.Point(807, 390)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(39, 13)
        Me.Label10.TabIndex = 142
        Me.Label10.Text = "Sumas"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Location = New System.Drawing.Point(568, 89)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(79, 13)
        Me.Label9.TabIndex = 141
        Me.Label9.Text = "Forma de Pago"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(862, 89)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 13)
        Me.Label5.TabIndex = 134
        Me.Label5.Text = "Fecha:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(291, 89)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(28, 13)
        Me.Label4.TabIndex = 131
        Me.Label4.Text = "Tipo"
        '
        'texproveedor
        '
        Me.texproveedor.Location = New System.Drawing.Point(190, 48)
        Me.texproveedor.Margin = New System.Windows.Forms.Padding(4)
        Me.texproveedor.Name = "texproveedor"
        Me.texproveedor.Size = New System.Drawing.Size(224, 20)
        Me.texproveedor.TabIndex = 126
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(262, 31)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 13)
        Me.Label3.TabIndex = 129
        Me.Label3.Text = "Proveedor"
        '
        'texnumfact
        '
        Me.texnumfact.Location = New System.Drawing.Point(106, 106)
        Me.texnumfact.Margin = New System.Windows.Forms.Padding(4)
        Me.texnumfact.Name = "texnumfact"
        Me.texnumfact.Size = New System.Drawing.Size(56, 20)
        Me.texnumfact.TabIndex = 127
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(87, 89)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 13)
        Me.Label2.TabIndex = 125
        Me.Label2.Text = "Numero de factura:"
        '
        'texformapago
        '
        Me.texformapago.Location = New System.Drawing.Point(505, 106)
        Me.texformapago.Margin = New System.Windows.Forms.Padding(4)
        Me.texformapago.Name = "texformapago"
        Me.texformapago.Size = New System.Drawing.Size(224, 20)
        Me.texformapago.TabIndex = 165
        '
        'textipo
        '
        Me.textipo.Location = New System.Drawing.Point(219, 106)
        Me.textipo.Margin = New System.Windows.Forms.Padding(4)
        Me.textipo.Name = "textipo"
        Me.textipo.Size = New System.Drawing.Size(224, 20)
        Me.textipo.TabIndex = 166
        '
        'botiz
        '
        Me.botiz.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.botiz.ForeColor = System.Drawing.Color.OrangeRed
        Me.botiz.Location = New System.Drawing.Point(6, 185)
        Me.botiz.Name = "botiz"
        Me.botiz.Size = New System.Drawing.Size(75, 149)
        Me.botiz.TabIndex = 167
        Me.botiz.Text = "<"
        Me.botiz.UseVisualStyleBackColor = True
        '
        'botde
        '
        Me.botde.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.botde.ForeColor = System.Drawing.Color.OrangeRed
        Me.botde.Location = New System.Drawing.Point(960, 185)
        Me.botde.Name = "botde"
        Me.botde.Size = New System.Drawing.Size(75, 149)
        Me.botde.TabIndex = 168
        Me.botde.Text = ">"
        Me.botde.UseVisualStyleBackColor = True
        '
        'texnit
        '
        Me.texnit.Location = New System.Drawing.Point(429, 48)
        Me.texnit.Margin = New System.Windows.Forms.Padding(4)
        Me.texnit.Name = "texnit"
        Me.texnit.Size = New System.Drawing.Size(138, 20)
        Me.texnit.TabIndex = 169
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(480, 31)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(25, 13)
        Me.Label1.TabIndex = 170
        Me.Label1.Text = "NIT"
        '
        'texnrc
        '
        Me.texnrc.Location = New System.Drawing.Point(591, 48)
        Me.texnrc.Margin = New System.Windows.Forms.Padding(4)
        Me.texnrc.Name = "texnrc"
        Me.texnrc.Size = New System.Drawing.Size(138, 20)
        Me.texnrc.TabIndex = 171
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(640, 31)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(30, 13)
        Me.Label6.TabIndex = 172
        Me.Label6.Text = "NRC"
        '
        'textfecha
        '
        Me.textfecha.Location = New System.Drawing.Point(804, 106)
        Me.textfecha.Margin = New System.Windows.Forms.Padding(4)
        Me.textfecha.Name = "textfecha"
        Me.textfecha.Size = New System.Drawing.Size(151, 20)
        Me.textfecha.TabIndex = 173
        '
        'botpagar
        '
        Me.botpagar.BackColor = System.Drawing.Color.Orange
        Me.botpagar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.botpagar.Location = New System.Drawing.Point(915, 13)
        Me.botpagar.Name = "botpagar"
        Me.botpagar.Size = New System.Drawing.Size(99, 40)
        Me.botpagar.TabIndex = 174
        Me.botpagar.Text = "Pagar"
        Me.botpagar.UseVisualStyleBackColor = False
        '
        'DetalledelaCompra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1039, 561)
        Me.Controls.Add(Me.botpagar)
        Me.Controls.Add(Me.textfecha)
        Me.Controls.Add(Me.texnrc)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.texnit)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.botde)
        Me.Controls.Add(Me.botiz)
        Me.Controls.Add(Me.textipo)
        Me.Controls.Add(Me.texformapago)
        Me.Controls.Add(Me.gridcompra)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.texivauno)
        Me.Controls.Add(Me.text1retencion)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.texexentas)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.texnosujeta)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.textotal)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.texiva)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.texsumas)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.texproveedor)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.texnumfact)
        Me.Controls.Add(Me.Label2)
        Me.Name = "DetalledelaCompra"
        Me.Text = "DetalledelaCompra"
        CType(Me.gridcompra, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gridcompra As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents codigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cantida As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nombr As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents preciu As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents preciod As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents exentas As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tota As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents botguardar As System.Windows.Forms.Button
    Friend WithEvents texivauno As System.Windows.Forms.TextBox
    Friend WithEvents text1retencion As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents lson As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents texexentas As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents texnosujeta As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents textotal As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents texiva As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents texsumas As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents texproveedor As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents texnumfact As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents texformapago As System.Windows.Forms.TextBox
    Friend WithEvents textipo As System.Windows.Forms.TextBox
    Friend WithEvents botiz As System.Windows.Forms.Button
    Friend WithEvents botde As System.Windows.Forms.Button
    Friend WithEvents texnit As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents texnrc As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents textfecha As System.Windows.Forms.TextBox
    Friend WithEvents boteliminar As System.Windows.Forms.Button
    Friend WithEvents boteditar As System.Windows.Forms.Button
    Friend WithEvents botpagar As System.Windows.Forms.Button
End Class
