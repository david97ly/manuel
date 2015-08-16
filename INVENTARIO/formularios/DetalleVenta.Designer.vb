<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DetalleVenta
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.texnrc = New System.Windows.Forms.TextBox()
        Me.texnit = New System.Windows.Forms.TextBox()
        Me.texnumero = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lgiro = New System.Windows.Forms.Label()
        Me.lbdireccion = New System.Windows.Forms.Label()
        Me.lnomproveedor = New System.Windows.Forms.Label()
        Me.lfecha = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lformadepago = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ltipodefactura = New System.Windows.Forms.Label()
        Me.botizquierda = New System.Windows.Forms.Button()
        Me.botderecha = New System.Windows.Forms.Button()
        Me.boteditar = New System.Windows.Forms.Button()
        Me.botsalir = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.botimprimir2 = New System.Windows.Forms.Button()
        Me.checimprimir = New System.Windows.Forms.CheckBox()
        Me.botimprimir = New System.Windows.Forms.Button()
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.gridcompra = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombr = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.decrip = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cantida = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.preciu = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.preciod = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tota = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lson = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.texiva1 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.texexentas = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.texnosujeta = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.texcotrans = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.texfovial = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.textotal = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.texiva = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.texdescuento = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.texsumas = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.linea1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.linea2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.RectangleShape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape2 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.GroupBox1.SuspendLayout()
        Me.GroupPanel1.SuspendLayout()
        CType(Me.gridcompra, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'texnrc
        '
        Me.texnrc.Enabled = False
        Me.texnrc.Location = New System.Drawing.Point(730, 45)
        Me.texnrc.Name = "texnrc"
        Me.texnrc.Size = New System.Drawing.Size(133, 20)
        Me.texnrc.TabIndex = 79
        '
        'texnit
        '
        Me.texnit.Enabled = False
        Me.texnit.Location = New System.Drawing.Point(730, 25)
        Me.texnit.Name = "texnit"
        Me.texnit.Size = New System.Drawing.Size(133, 20)
        Me.texnit.TabIndex = 78
        '
        'texnumero
        '
        Me.texnumero.Enabled = False
        Me.texnumero.Location = New System.Drawing.Point(729, 4)
        Me.texnumero.Name = "texnumero"
        Me.texnumero.Size = New System.Drawing.Size(133, 20)
        Me.texnumero.TabIndex = 77
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(688, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(30, 13)
        Me.Label3.TabIndex = 76
        Me.Label3.Text = "NRC"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(688, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(28, 13)
        Me.Label2.TabIndex = 75
        Me.Label2.Text = "NIT:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(693, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(22, 13)
        Me.Label1.TabIndex = 74
        Me.Label1.Text = "N°:"
        '
        'lgiro
        '
        Me.lgiro.AutoSize = True
        Me.lgiro.BackColor = System.Drawing.Color.Transparent
        Me.lgiro.Location = New System.Drawing.Point(9, 28)
        Me.lgiro.Name = "lgiro"
        Me.lgiro.Size = New System.Drawing.Size(26, 13)
        Me.lgiro.TabIndex = 82
        Me.lgiro.Text = "Giro"
        '
        'lbdireccion
        '
        Me.lbdireccion.AutoSize = True
        Me.lbdireccion.BackColor = System.Drawing.Color.Transparent
        Me.lbdireccion.Location = New System.Drawing.Point(9, 45)
        Me.lbdireccion.Name = "lbdireccion"
        Me.lbdireccion.Size = New System.Drawing.Size(52, 13)
        Me.lbdireccion.TabIndex = 81
        Me.lbdireccion.Text = "Direccion"
        '
        'lnomproveedor
        '
        Me.lnomproveedor.AutoSize = True
        Me.lnomproveedor.BackColor = System.Drawing.Color.Transparent
        Me.lnomproveedor.Location = New System.Drawing.Point(9, 9)
        Me.lnomproveedor.Name = "lnomproveedor"
        Me.lnomproveedor.Size = New System.Drawing.Size(110, 13)
        Me.lnomproveedor.TabIndex = 80
        Me.lnomproveedor.Text = "nombre del proveedor"
        '
        'lfecha
        '
        Me.lfecha.AutoSize = True
        Me.lfecha.BackColor = System.Drawing.Color.Transparent
        Me.lfecha.Location = New System.Drawing.Point(450, 89)
        Me.lfecha.Name = "lfecha"
        Me.lfecha.Size = New System.Drawing.Size(34, 13)
        Me.lfecha.TabIndex = 52
        Me.lfecha.Text = "fecha"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(9, 62)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 13)
        Me.Label4.TabIndex = 53
        Me.Label4.Text = "Forma de pago:"
        '
        'lformadepago
        '
        Me.lformadepago.AutoSize = True
        Me.lformadepago.BackColor = System.Drawing.Color.Transparent
        Me.lformadepago.Location = New System.Drawing.Point(92, 62)
        Me.lformadepago.Name = "lformadepago"
        Me.lformadepago.Size = New System.Drawing.Size(81, 13)
        Me.lformadepago.TabIndex = 54
        Me.lformadepago.Text = "Forma de pago:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(57, 89)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(31, 13)
        Me.Label6.TabIndex = 55
        Me.Label6.Text = "Tipo:"
        '
        'ltipodefactura
        '
        Me.ltipodefactura.AutoSize = True
        Me.ltipodefactura.BackColor = System.Drawing.Color.Transparent
        Me.ltipodefactura.Location = New System.Drawing.Point(92, 89)
        Me.ltipodefactura.Name = "ltipodefactura"
        Me.ltipodefactura.Size = New System.Drawing.Size(75, 13)
        Me.ltipodefactura.TabIndex = 56
        Me.ltipodefactura.Text = "tipo de factura"
        '
        'botizquierda
        '
        Me.botizquierda.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.botizquierda.ForeColor = System.Drawing.Color.Red
        Me.botizquierda.Location = New System.Drawing.Point(2, 198)
        Me.botizquierda.Name = "botizquierda"
        Me.botizquierda.Size = New System.Drawing.Size(27, 78)
        Me.botizquierda.TabIndex = 70
        Me.botizquierda.Text = "<"
        Me.botizquierda.UseVisualStyleBackColor = True
        '
        'botderecha
        '
        Me.botderecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.botderecha.ForeColor = System.Drawing.Color.Red
        Me.botderecha.Location = New System.Drawing.Point(829, 168)
        Me.botderecha.Name = "botderecha"
        Me.botderecha.Size = New System.Drawing.Size(27, 78)
        Me.botderecha.TabIndex = 71
        Me.botderecha.Text = ">"
        Me.botderecha.UseVisualStyleBackColor = True
        '
        'boteditar
        '
        Me.boteditar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.boteditar.Location = New System.Drawing.Point(2, 26)
        Me.boteditar.Name = "boteditar"
        Me.boteditar.Size = New System.Drawing.Size(81, 35)
        Me.boteditar.TabIndex = 1
        Me.boteditar.Text = "Anular"
        Me.boteditar.UseVisualStyleBackColor = True
        '
        'botsalir
        '
        Me.botsalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.botsalir.Location = New System.Drawing.Point(289, 26)
        Me.botsalir.Name = "botsalir"
        Me.botsalir.Size = New System.Drawing.Size(81, 35)
        Me.botsalir.TabIndex = 2
        Me.botsalir.Text = "Salir"
        Me.botsalir.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.botimprimir2)
        Me.GroupBox1.Controls.Add(Me.checimprimir)
        Me.GroupBox1.Controls.Add(Me.botimprimir)
        Me.GroupBox1.Controls.Add(Me.botsalir)
        Me.GroupBox1.Controls.Add(Me.boteditar)
        Me.GroupBox1.Location = New System.Drawing.Point(25, 461)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(375, 81)
        Me.GroupBox1.TabIndex = 72
        Me.GroupBox1.TabStop = False
        '
        'botimprimir2
        '
        Me.botimprimir2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.botimprimir2.Location = New System.Drawing.Point(141, 26)
        Me.botimprimir2.Name = "botimprimir2"
        Me.botimprimir2.Size = New System.Drawing.Size(81, 35)
        Me.botimprimir2.TabIndex = 5
        Me.botimprimir2.Text = "imprimir"
        Me.botimprimir2.UseVisualStyleBackColor = True
        Me.botimprimir2.Visible = False
        '
        'checimprimir
        '
        Me.checimprimir.AutoSize = True
        Me.checimprimir.Location = New System.Drawing.Point(141, 9)
        Me.checimprimir.Name = "checimprimir"
        Me.checimprimir.Size = New System.Drawing.Size(61, 17)
        Me.checimprimir.TabIndex = 4
        Me.checimprimir.Text = "Imprimir"
        Me.checimprimir.UseVisualStyleBackColor = True
        '
        'botimprimir
        '
        Me.botimprimir.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.botimprimir.Location = New System.Drawing.Point(54, 26)
        Me.botimprimir.Name = "botimprimir"
        Me.botimprimir.Size = New System.Drawing.Size(81, 35)
        Me.botimprimir.TabIndex = 3
        Me.botimprimir.Text = "imprimir"
        Me.botimprimir.UseVisualStyleBackColor = True
        Me.botimprimir.Visible = False
        '
        'GroupPanel1
        '
        Me.GroupPanel1.CanvasColor = System.Drawing.Color.Red
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.gridcompra)
        Me.GroupPanel1.Controls.Add(Me.botderecha)
        Me.GroupPanel1.Controls.Add(Me.texnrc)
        Me.GroupPanel1.Controls.Add(Me.texnit)
        Me.GroupPanel1.Controls.Add(Me.texnumero)
        Me.GroupPanel1.Controls.Add(Me.GroupBox2)
        Me.GroupPanel1.Controls.Add(Me.texiva1)
        Me.GroupPanel1.Controls.Add(Me.Label5)
        Me.GroupPanel1.Controls.Add(Me.texexentas)
        Me.GroupPanel1.Controls.Add(Me.Label20)
        Me.GroupPanel1.Controls.Add(Me.texnosujeta)
        Me.GroupPanel1.Controls.Add(Me.Label15)
        Me.GroupPanel1.Controls.Add(Me.texcotrans)
        Me.GroupPanel1.Controls.Add(Me.Label19)
        Me.GroupPanel1.Controls.Add(Me.texfovial)
        Me.GroupPanel1.Controls.Add(Me.Label13)
        Me.GroupPanel1.Controls.Add(Me.textotal)
        Me.GroupPanel1.Controls.Add(Me.Label14)
        Me.GroupPanel1.Controls.Add(Me.texiva)
        Me.GroupPanel1.Controls.Add(Me.Label12)
        Me.GroupPanel1.Controls.Add(Me.texdescuento)
        Me.GroupPanel1.Controls.Add(Me.Label11)
        Me.GroupPanel1.Controls.Add(Me.texsumas)
        Me.GroupPanel1.Controls.Add(Me.Label10)
        Me.GroupPanel1.Controls.Add(Me.GroupBox1)
        Me.GroupPanel1.Controls.Add(Me.lgiro)
        Me.GroupPanel1.Controls.Add(Me.lfecha)
        Me.GroupPanel1.Controls.Add(Me.lbdireccion)
        Me.GroupPanel1.Controls.Add(Me.Label4)
        Me.GroupPanel1.Controls.Add(Me.lnomproveedor)
        Me.GroupPanel1.Controls.Add(Me.lformadepago)
        Me.GroupPanel1.Controls.Add(Me.Label6)
        Me.GroupPanel1.Controls.Add(Me.ltipodefactura)
        Me.GroupPanel1.Controls.Add(Me.Label1)
        Me.GroupPanel1.Controls.Add(Me.Label3)
        Me.GroupPanel1.Controls.Add(Me.Label2)
        Me.GroupPanel1.Controls.Add(Me.ShapeContainer1)
        Me.GroupPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupPanel1.Location = New System.Drawing.Point(0, 0)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(878, 558)
        '
        '
        '
        Me.GroupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GroupPanel1.Style.BackColorGradientAngle = 90
        Me.GroupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GroupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderBottomWidth = 1
        Me.GroupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderLeftWidth = 1
        Me.GroupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderRightWidth = 1
        Me.GroupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderTopWidth = 1
        Me.GroupPanel1.Style.Class = ""
        Me.GroupPanel1.Style.CornerDiameter = 4
        Me.GroupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GroupPanel1.StyleMouseDown.Class = ""
        Me.GroupPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanel1.StyleMouseOver.Class = ""
        Me.GroupPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GroupPanel1.TabIndex = 83
        '
        'gridcompra
        '
        Me.gridcompra.AllowUserToAddRows = False
        Me.gridcompra.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.gridcompra.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.gridcompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridcompra.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.codigo, Me.nombr, Me.decrip, Me.cantida, Me.preciu, Me.preciod, Me.tota})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.gridcompra.DefaultCellStyle = DataGridViewCellStyle2
        Me.gridcompra.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.gridcompra.Location = New System.Drawing.Point(25, 113)
        Me.gridcompra.Name = "gridcompra"
        Me.gridcompra.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.gridcompra.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.gridcompra.RowHeadersVisible = False
        Me.gridcompra.Size = New System.Drawing.Size(805, 231)
        Me.gridcompra.TabIndex = 84
        '
        'codigo
        '
        Me.codigo.HeaderText = "Codigo"
        Me.codigo.Name = "codigo"
        Me.codigo.ReadOnly = True
        '
        'nombr
        '
        Me.nombr.HeaderText = "Nombre"
        Me.nombr.Name = "nombr"
        Me.nombr.ReadOnly = True
        Me.nombr.Width = 200
        '
        'decrip
        '
        Me.decrip.HeaderText = "Descripcion"
        Me.decrip.Name = "decrip"
        Me.decrip.ReadOnly = True
        '
        'cantida
        '
        Me.cantida.HeaderText = "Cantidad"
        Me.cantida.Name = "cantida"
        Me.cantida.ReadOnly = True
        '
        'preciu
        '
        Me.preciu.HeaderText = "Precio Unitario"
        Me.preciu.Name = "preciu"
        Me.preciu.ReadOnly = True
        '
        'preciod
        '
        Me.preciod.HeaderText = "Precio con descuento"
        Me.preciod.Name = "preciod"
        Me.preciod.ReadOnly = True
        '
        'tota
        '
        Me.tota.HeaderText = "Total"
        Me.tota.Name = "tota"
        Me.tota.ReadOnly = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.lson)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Location = New System.Drawing.Point(25, 360)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(450, 97)
        Me.GroupBox2.TabIndex = 127
        Me.GroupBox2.TabStop = False
        '
        'lson
        '
        Me.lson.AutoSize = True
        Me.lson.Location = New System.Drawing.Point(43, 17)
        Me.lson.Name = "lson"
        Me.lson.Size = New System.Drawing.Size(29, 13)
        Me.lson.TabIndex = 1
        Me.lson.Text = "Son:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(5, 17)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(29, 13)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Son:"
        '
        'texiva1
        '
        Me.texiva1.Enabled = False
        Me.texiva1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.texiva1.Location = New System.Drawing.Point(758, 415)
        Me.texiva1.Name = "texiva1"
        Me.texiva1.Size = New System.Drawing.Size(73, 24)
        Me.texiva1.TabIndex = 126
        Me.texiva1.Text = "0.0"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(709, 419)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 13)
        Me.Label5.TabIndex = 125
        Me.Label5.Text = "IVA(1%)"
        '
        'texexentas
        '
        Me.texexentas.Enabled = False
        Me.texexentas.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.texexentas.Location = New System.Drawing.Point(757, 502)
        Me.texexentas.Name = "texexentas"
        Me.texexentas.Size = New System.Drawing.Size(73, 24)
        Me.texexentas.TabIndex = 124
        Me.texexentas.Text = "0.0"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.Location = New System.Drawing.Point(689, 504)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(67, 13)
        Me.Label20.TabIndex = 123
        Me.Label20.Text = "V.EXENTAS"
        '
        'texnosujeta
        '
        Me.texnosujeta.Enabled = False
        Me.texnosujeta.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.texnosujeta.Location = New System.Drawing.Point(758, 438)
        Me.texnosujeta.Name = "texnosujeta"
        Me.texnosujeta.Size = New System.Drawing.Size(73, 24)
        Me.texnosujeta.TabIndex = 122
        Me.texnosujeta.Text = "0.0"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Location = New System.Drawing.Point(683, 440)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(77, 13)
        Me.Label15.TabIndex = 121
        Me.Label15.Text = "V.NO SUJETA"
        '
        'texcotrans
        '
        Me.texcotrans.Enabled = False
        Me.texcotrans.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.texcotrans.Location = New System.Drawing.Point(757, 480)
        Me.texcotrans.Name = "texcotrans"
        Me.texcotrans.Size = New System.Drawing.Size(73, 24)
        Me.texcotrans.TabIndex = 120
        Me.texcotrans.Text = "0.0"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Location = New System.Drawing.Point(699, 483)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(59, 13)
        Me.Label19.TabIndex = 119
        Me.Label19.Text = "COTRANS"
        '
        'texfovial
        '
        Me.texfovial.Enabled = False
        Me.texfovial.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.texfovial.Location = New System.Drawing.Point(757, 460)
        Me.texfovial.Name = "texfovial"
        Me.texfovial.Size = New System.Drawing.Size(73, 24)
        Me.texfovial.TabIndex = 118
        Me.texfovial.Text = "0.0"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Location = New System.Drawing.Point(713, 462)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(44, 13)
        Me.Label13.TabIndex = 117
        Me.Label13.Text = "FOVIAL"
        '
        'textotal
        '
        Me.textotal.Enabled = False
        Me.textotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textotal.Location = New System.Drawing.Point(758, 523)
        Me.textotal.Name = "textotal"
        Me.textotal.Size = New System.Drawing.Size(73, 24)
        Me.textotal.TabIndex = 116
        Me.textotal.Text = "0.0"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(686, 526)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(88, 16)
        Me.Label14.TabIndex = 115
        Me.Label14.Text = "Venta Total"
        '
        'texiva
        '
        Me.texiva.Enabled = False
        Me.texiva.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.texiva.Location = New System.Drawing.Point(758, 393)
        Me.texiva.Name = "texiva"
        Me.texiva.Size = New System.Drawing.Size(73, 24)
        Me.texiva.TabIndex = 114
        Me.texiva.Text = "0.0"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Location = New System.Drawing.Point(709, 397)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(50, 13)
        Me.Label12.TabIndex = 113
        Me.Label12.Text = "IVA(13%)"
        '
        'texdescuento
        '
        Me.texdescuento.Enabled = False
        Me.texdescuento.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.texdescuento.Location = New System.Drawing.Point(758, 371)
        Me.texdescuento.Name = "texdescuento"
        Me.texdescuento.Size = New System.Drawing.Size(73, 24)
        Me.texdescuento.TabIndex = 112
        Me.texdescuento.Text = "0.00"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Location = New System.Drawing.Point(701, 375)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(59, 13)
        Me.Label11.TabIndex = 111
        Me.Label11.Text = "Descuento"
        '
        'texsumas
        '
        Me.texsumas.Enabled = False
        Me.texsumas.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.texsumas.Location = New System.Drawing.Point(758, 350)
        Me.texsumas.Name = "texsumas"
        Me.texsumas.Size = New System.Drawing.Size(73, 24)
        Me.texsumas.TabIndex = 110
        Me.texsumas.Text = "0.0"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Location = New System.Drawing.Point(714, 354)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(39, 13)
        Me.Label10.TabIndex = 109
        Me.Label10.Text = "Sumas"
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.linea1, Me.linea2, Me.RectangleShape1, Me.RectangleShape2})
        Me.ShapeContainer1.Size = New System.Drawing.Size(872, 552)
        Me.ShapeContainer1.TabIndex = 0
        Me.ShapeContainer1.TabStop = False
        '
        'linea1
        '
        Me.linea1.BorderColor = System.Drawing.Color.Red
        Me.linea1.BorderWidth = 10
        Me.linea1.Name = "linea1"
        Me.linea1.Visible = False
        Me.linea1.X1 = -9
        Me.linea1.X2 = 873
        Me.linea1.Y1 = 556
        Me.linea1.Y2 = -5
        '
        'linea2
        '
        Me.linea2.BorderColor = System.Drawing.Color.Red
        Me.linea2.BorderWidth = 10
        Me.linea2.Name = "linea2"
        Me.linea2.Visible = False
        Me.linea2.X1 = -2
        Me.linea2.X2 = 874
        Me.linea2.Y1 = -2
        Me.linea2.Y2 = 551
        '
        'RectangleShape1
        '
        Me.RectangleShape1.Location = New System.Drawing.Point(649, 1)
        Me.RectangleShape1.Name = "RectangleShape1"
        Me.RectangleShape1.Size = New System.Drawing.Size(219, 79)
        '
        'RectangleShape2
        '
        Me.RectangleShape2.Location = New System.Drawing.Point(2, 2)
        Me.RectangleShape2.Name = "RectangleShape2"
        Me.RectangleShape2.Size = New System.Drawing.Size(618, 76)
        '
        'DetalleVenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightCoral
        Me.ClientSize = New System.Drawing.Size(878, 558)
        Me.Controls.Add(Me.botizquierda)
        Me.Controls.Add(Me.GroupPanel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "DetalleVenta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DetalleVenta"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupPanel1.ResumeLayout(False)
        Me.GroupPanel1.PerformLayout()
        CType(Me.gridcompra, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents texnrc As System.Windows.Forms.TextBox
    Friend WithEvents texnit As System.Windows.Forms.TextBox
    Friend WithEvents texnumero As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lgiro As System.Windows.Forms.Label
    Friend WithEvents lbdireccion As System.Windows.Forms.Label
    Friend WithEvents lnomproveedor As System.Windows.Forms.Label
    Friend WithEvents lfecha As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lformadepago As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ltipodefactura As System.Windows.Forms.Label
    Friend WithEvents botizquierda As System.Windows.Forms.Button
    Friend WithEvents botderecha As System.Windows.Forms.Button
    Friend WithEvents boteditar As System.Windows.Forms.Button
    Friend WithEvents botsalir As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents RectangleShape1 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents RectangleShape2 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents texexentas As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents texnosujeta As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents texcotrans As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents texfovial As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents textotal As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents texiva As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents texdescuento As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents texsumas As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents texiva1 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lson As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents botimprimir As System.Windows.Forms.Button
    Friend WithEvents linea1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents linea2 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents gridcompra As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents codigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nombr As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents decrip As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cantida As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents preciu As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents preciod As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tota As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents botimprimir2 As System.Windows.Forms.Button
    Friend WithEvents checimprimir As System.Windows.Forms.CheckBox
End Class
