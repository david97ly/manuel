<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AnalizarProducto
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.lbcantidadmenosvendido = New DevComponents.DotNetBar.Controls.ReflectionLabel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lbcantiddmasvendido = New DevComponents.DotNetBar.Controls.ReflectionLabel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbmenosvendido = New DevComponents.DotNetBar.Controls.ReflectionLabel()
        Me.lbcv1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbmvendido = New DevComponents.DotNetBar.Controls.ReflectionLabel()
        Me.lbcv = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridViewX1 = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.existencas = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ventas = New DevComponents.DotNetBar.Controls.DataGridViewProgressBarXColumn()
        Me.GroupPanel2 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.datacategoria = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.categoria = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sino = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.botaceptar = New DevComponents.DotNetBar.ButtonX()
        Me.GroupPanel3 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.swboton = New DevComponents.DotNetBar.Controls.SwitchButton()
        Me.dthasta = New System.Windows.Forms.DateTimePicker()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.dtdesde = New System.Windows.Forms.DateTimePicker()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.GroupPanel1.SuspendLayout()
        CType(Me.DataGridViewX1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupPanel2.SuspendLayout()
        CType(Me.datacategoria, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupPanel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupPanel1
        '
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.lbcantidadmenosvendido)
        Me.GroupPanel1.Controls.Add(Me.Label4)
        Me.GroupPanel1.Controls.Add(Me.lbcantiddmasvendido)
        Me.GroupPanel1.Controls.Add(Me.Label2)
        Me.GroupPanel1.Controls.Add(Me.lbmenosvendido)
        Me.GroupPanel1.Controls.Add(Me.lbcv1)
        Me.GroupPanel1.Controls.Add(Me.Label3)
        Me.GroupPanel1.Controls.Add(Me.lbmvendido)
        Me.GroupPanel1.Controls.Add(Me.lbcv)
        Me.GroupPanel1.Controls.Add(Me.Label1)
        Me.GroupPanel1.Controls.Add(Me.DataGridViewX1)
        Me.GroupPanel1.Controls.Add(Me.GroupPanel2)
        Me.GroupPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupPanel1.Location = New System.Drawing.Point(0, 0)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(750, 489)
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
        Me.GroupPanel1.TabIndex = 0
        '
        'lbcantidadmenosvendido
        '
        Me.lbcantidadmenosvendido.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lbcantidadmenosvendido.BackgroundStyle.Class = ""
        Me.lbcantidadmenosvendido.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbcantidadmenosvendido.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbcantidadmenosvendido.ForeColor = System.Drawing.Color.Green
        Me.lbcantidadmenosvendido.Location = New System.Drawing.Point(595, 348)
        Me.lbcantidadmenosvendido.Name = "lbcantidadmenosvendido"
        Me.lbcantidadmenosvendido.Size = New System.Drawing.Size(95, 42)
        Me.lbcantidadmenosvendido.TabIndex = 11
        Me.lbcantidadmenosvendido.Text = "00"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(541, 351)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 20)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Con $"
        '
        'lbcantiddmasvendido
        '
        Me.lbcantiddmasvendido.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lbcantiddmasvendido.BackgroundStyle.Class = ""
        Me.lbcantiddmasvendido.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbcantiddmasvendido.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbcantiddmasvendido.ForeColor = System.Drawing.Color.Green
        Me.lbcantiddmasvendido.Location = New System.Drawing.Point(594, 210)
        Me.lbcantiddmasvendido.Name = "lbcantiddmasvendido"
        Me.lbcantiddmasvendido.Size = New System.Drawing.Size(95, 42)
        Me.lbcantiddmasvendido.TabIndex = 9
        Me.lbcantiddmasvendido.Text = "00"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(539, 217)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 20)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Con $"
        '
        'lbmenosvendido
        '
        Me.lbmenosvendido.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lbmenosvendido.BackgroundStyle.Class = ""
        Me.lbmenosvendido.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbmenosvendido.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbmenosvendido.ForeColor = System.Drawing.Color.Green
        Me.lbmenosvendido.Location = New System.Drawing.Point(545, 306)
        Me.lbmenosvendido.Name = "lbmenosvendido"
        Me.lbmenosvendido.Size = New System.Drawing.Size(156, 42)
        Me.lbmenosvendido.TabIndex = 7
        Me.lbmenosvendido.Text = "Producto"
        '
        'lbcv1
        '
        Me.lbcv1.AutoSize = True
        Me.lbcv1.BackColor = System.Drawing.Color.Transparent
        Me.lbcv1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbcv1.Location = New System.Drawing.Point(600, 278)
        Me.lbcv1.Name = "lbcv1"
        Me.lbcv1.Size = New System.Drawing.Size(71, 20)
        Me.lbcv1.TabIndex = 6
        Me.lbcv1.Text = "vendido"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(540, 278)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 20)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Menos"
        '
        'lbmvendido
        '
        Me.lbmvendido.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lbmvendido.BackgroundStyle.Class = ""
        Me.lbmvendido.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbmvendido.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbmvendido.ForeColor = System.Drawing.Color.Green
        Me.lbmvendido.Location = New System.Drawing.Point(544, 171)
        Me.lbmvendido.Name = "lbmvendido"
        Me.lbmvendido.Size = New System.Drawing.Size(156, 42)
        Me.lbmvendido.TabIndex = 4
        Me.lbmvendido.Text = "Producto"
        '
        'lbcv
        '
        Me.lbcv.AutoSize = True
        Me.lbcv.BackColor = System.Drawing.Color.Transparent
        Me.lbcv.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbcv.Location = New System.Drawing.Point(579, 152)
        Me.lbcv.Name = "lbcv"
        Me.lbcv.Size = New System.Drawing.Size(71, 20)
        Me.lbcv.TabIndex = 3
        Me.lbcv.Text = "vendido"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(541, 152)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Mas"
        '
        'DataGridViewX1
        '
        Me.DataGridViewX1.AllowUserToAddRows = False
        Me.DataGridViewX1.AllowUserToDeleteRows = False
        Me.DataGridViewX1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewX1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.codigo, Me.Nombre, Me.Precio, Me.existencas, Me.ventas})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewX1.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewX1.GridColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.DataGridViewX1.Location = New System.Drawing.Point(3, 152)
        Me.DataGridViewX1.Name = "DataGridViewX1"
        Me.DataGridViewX1.ReadOnly = True
        Me.DataGridViewX1.RowHeadersVisible = False
        Me.DataGridViewX1.Size = New System.Drawing.Size(503, 328)
        Me.DataGridViewX1.TabIndex = 1
        '
        'codigo
        '
        Me.codigo.HeaderText = "Codigo"
        Me.codigo.Name = "codigo"
        Me.codigo.ReadOnly = True
        Me.codigo.Width = 75
        '
        'Nombre
        '
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.Name = "Nombre"
        Me.Nombre.ReadOnly = True
        Me.Nombre.Width = 125
        '
        'Precio
        '
        Me.Precio.HeaderText = "Precio"
        Me.Precio.Name = "Precio"
        Me.Precio.ReadOnly = True
        Me.Precio.Width = 75
        '
        'existencas
        '
        Me.existencas.HeaderText = "Existencas"
        Me.existencas.Name = "existencas"
        Me.existencas.ReadOnly = True
        Me.existencas.Width = 75
        '
        'ventas
        '
        Me.ventas.HeaderText = "ventas"
        Me.ventas.Name = "ventas"
        Me.ventas.ReadOnly = True
        Me.ventas.Style = DevComponents.DotNetBar.eDotNetBarStyle.Windows7
        Me.ventas.Text = Nothing
        Me.ventas.Width = 150
        '
        'GroupPanel2
        '
        Me.GroupPanel2.BackColor = System.Drawing.Color.Transparent
        Me.GroupPanel2.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2010
        Me.GroupPanel2.Controls.Add(Me.datacategoria)
        Me.GroupPanel2.Controls.Add(Me.botaceptar)
        Me.GroupPanel2.Controls.Add(Me.GroupPanel3)
        Me.GroupPanel2.Location = New System.Drawing.Point(3, 5)
        Me.GroupPanel2.Name = "GroupPanel2"
        Me.GroupPanel2.Size = New System.Drawing.Size(738, 121)
        '
        '
        '
        Me.GroupPanel2.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GroupPanel2.Style.BackColorGradientAngle = 90
        Me.GroupPanel2.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GroupPanel2.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel2.Style.BorderBottomWidth = 1
        Me.GroupPanel2.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupPanel2.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel2.Style.BorderLeftWidth = 1
        Me.GroupPanel2.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel2.Style.BorderRightWidth = 1
        Me.GroupPanel2.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel2.Style.BorderTopWidth = 1
        Me.GroupPanel2.Style.Class = ""
        Me.GroupPanel2.Style.CornerDiameter = 4
        Me.GroupPanel2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanel2.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanel2.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanel2.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GroupPanel2.StyleMouseDown.Class = ""
        Me.GroupPanel2.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanel2.StyleMouseOver.Class = ""
        Me.GroupPanel2.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GroupPanel2.TabIndex = 0
        Me.GroupPanel2.Text = "Filtro"
        '
        'datacategoria
        '
        Me.datacategoria.AllowUserToAddRows = False
        Me.datacategoria.AllowUserToDeleteRows = False
        Me.datacategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datacategoria.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.categoria, Me.sino})
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.datacategoria.DefaultCellStyle = DataGridViewCellStyle4
        Me.datacategoria.GridColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.datacategoria.Location = New System.Drawing.Point(519, 4)
        Me.datacategoria.Name = "datacategoria"
        Me.datacategoria.RowHeadersVisible = False
        Me.datacategoria.Size = New System.Drawing.Size(210, 93)
        Me.datacategoria.TabIndex = 3
        '
        'categoria
        '
        Me.categoria.HeaderText = "Categoria"
        Me.categoria.Name = "categoria"
        Me.categoria.ReadOnly = True
        Me.categoria.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.categoria.Width = 140
        '
        'sino
        '
        Me.sino.HeaderText = "Select"
        Me.sino.Name = "sino"
        Me.sino.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.sino.Width = 50
        '
        'botaceptar
        '
        Me.botaceptar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.botaceptar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.botaceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.botaceptar.Location = New System.Drawing.Point(445, 52)
        Me.botaceptar.Name = "botaceptar"
        Me.botaceptar.Size = New System.Drawing.Size(68, 45)
        Me.botaceptar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.botaceptar.TabIndex = 2
        Me.botaceptar.Text = "Aceptar"
        '
        'GroupPanel3
        '
        Me.GroupPanel3.BackColor = System.Drawing.Color.Transparent
        Me.GroupPanel3.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2010
        Me.GroupPanel3.Controls.Add(Me.swboton)
        Me.GroupPanel3.Controls.Add(Me.dthasta)
        Me.GroupPanel3.Controls.Add(Me.LabelX2)
        Me.GroupPanel3.Controls.Add(Me.dtdesde)
        Me.GroupPanel3.Controls.Add(Me.LabelX1)
        Me.GroupPanel3.Location = New System.Drawing.Point(3, 0)
        Me.GroupPanel3.Name = "GroupPanel3"
        Me.GroupPanel3.Size = New System.Drawing.Size(436, 97)
        '
        '
        '
        Me.GroupPanel3.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GroupPanel3.Style.BackColorGradientAngle = 90
        Me.GroupPanel3.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GroupPanel3.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel3.Style.BorderBottomWidth = 1
        Me.GroupPanel3.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupPanel3.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel3.Style.BorderLeftWidth = 1
        Me.GroupPanel3.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel3.Style.BorderRightWidth = 1
        Me.GroupPanel3.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel3.Style.BorderTopWidth = 1
        Me.GroupPanel3.Style.Class = ""
        Me.GroupPanel3.Style.CornerDiameter = 4
        Me.GroupPanel3.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanel3.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanel3.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanel3.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GroupPanel3.StyleMouseDown.Class = ""
        Me.GroupPanel3.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanel3.StyleMouseOver.Class = ""
        Me.GroupPanel3.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GroupPanel3.TabIndex = 1
        Me.GroupPanel3.Text = "Rango de fechas"
        '
        'swboton
        '
        '
        '
        '
        Me.swboton.BackgroundStyle.Class = ""
        Me.swboton.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.swboton.Location = New System.Drawing.Point(170, 13)
        Me.swboton.Name = "swboton"
        Me.swboton.OffBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.swboton.OffText = "Comprados"
        Me.swboton.OffTextColor = System.Drawing.Color.Black
        Me.swboton.OnBackColor = System.Drawing.Color.Blue
        Me.swboton.OnText = "Vendidos"
        Me.swboton.OnTextColor = System.Drawing.Color.Black
        Me.swboton.Size = New System.Drawing.Size(103, 22)
        Me.swboton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.swboton.TabIndex = 2
        '
        'dthasta
        '
        Me.dthasta.Location = New System.Drawing.Point(224, 53)
        Me.dthasta.Name = "dthasta"
        Me.dthasta.Size = New System.Drawing.Size(200, 20)
        Me.dthasta.TabIndex = 6
        '
        'LabelX2
        '
        Me.LabelX2.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX2.BackgroundStyle.Class = ""
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX2.Location = New System.Drawing.Point(300, 35)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(75, 23)
        Me.LabelX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.Windows7
        Me.LabelX2.TabIndex = 7
        Me.LabelX2.Text = "Hasta"
        '
        'dtdesde
        '
        Me.dtdesde.Location = New System.Drawing.Point(5, 53)
        Me.dtdesde.Name = "dtdesde"
        Me.dtdesde.Size = New System.Drawing.Size(200, 20)
        Me.dtdesde.TabIndex = 4
        '
        'LabelX1
        '
        Me.LabelX1.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX1.BackgroundStyle.Class = ""
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX1.Location = New System.Drawing.Point(89, 34)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(75, 23)
        Me.LabelX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Windows7
        Me.LabelX1.TabIndex = 5
        Me.LabelX1.Text = "Desde"
        '
        'AnalizarProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(750, 489)
        Me.Controls.Add(Me.GroupPanel1)
        Me.Name = "AnalizarProducto"
        Me.Text = "AnalizarProducto"
        Me.GroupPanel1.ResumeLayout(False)
        Me.GroupPanel1.PerformLayout()
        CType(Me.DataGridViewX1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupPanel2.ResumeLayout(False)
        CType(Me.datacategoria, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupPanel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents GroupPanel2 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents GroupPanel3 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents swboton As DevComponents.DotNetBar.Controls.SwitchButton
    Friend WithEvents dthasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents dtdesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents lbcv As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DataGridViewX1 As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents botaceptar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents lbmvendido As DevComponents.DotNetBar.Controls.ReflectionLabel
    Friend WithEvents lbmenosvendido As DevComponents.DotNetBar.Controls.ReflectionLabel
    Friend WithEvents lbcv1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lbcantidadmenosvendido As DevComponents.DotNetBar.Controls.ReflectionLabel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lbcantiddmasvendido As DevComponents.DotNetBar.Controls.ReflectionLabel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents datacategoria As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents categoria As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents sino As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents codigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Precio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents existencas As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ventas As DevComponents.DotNetBar.Controls.DataGridViewProgressBarXColumn
End Class
