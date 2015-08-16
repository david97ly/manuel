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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.dataventas1 = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dataresultados1 = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.GroupPanel2 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.dataresultados2 = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.ReflectionLabel3 = New DevComponents.DotNetBar.Controls.ReflectionLabel()
        Me.ReflectionLabel4 = New DevComponents.DotNetBar.Controls.ReflectionLabel()
        Me.dataventas2 = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.datacompras2 = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReflectionLabel2 = New DevComponents.DotNetBar.Controls.ReflectionLabel()
        Me.ReflectionLabel1 = New DevComponents.DotNetBar.Controls.ReflectionLabel()
        Me.datacompras1 = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.Total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupPanel3 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.botcalcular = New DevComponents.DotNetBar.ButtonX()
        Me.dthasta = New System.Windows.Forms.DateTimePicker()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.dtdesde = New System.Windows.Forms.DateTimePicker()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.recuperacion = New DevComponents.DotNetBar.Controls.DataGridViewProgressBarXColumn()
        Me.ganancias = New DevComponents.DotNetBar.Controls.DataGridViewProgressBarXColumn()
        Me.cna = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewProgressBarXColumn3 = New DevComponents.DotNetBar.Controls.DataGridViewProgressBarXColumn()
        Me.DataGridViewProgressBarXColumn2 = New DevComponents.DotNetBar.Controls.DataGridViewProgressBarXColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupPanel1.SuspendLayout()
        CType(Me.dataventas1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dataresultados1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupPanel2.SuspendLayout()
        CType(Me.dataresultados2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dataventas2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.datacompras2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.datacompras1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupPanel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupPanel1
        '
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.dataventas1)
        Me.GroupPanel1.Controls.Add(Me.dataresultados1)
        Me.GroupPanel1.Controls.Add(Me.GroupPanel2)
        Me.GroupPanel1.Controls.Add(Me.ReflectionLabel2)
        Me.GroupPanel1.Controls.Add(Me.ReflectionLabel1)
        Me.GroupPanel1.Controls.Add(Me.datacompras1)
        Me.GroupPanel1.Controls.Add(Me.GroupPanel3)
        Me.GroupPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupPanel1.Location = New System.Drawing.Point(0, 0)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(659, 469)
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
        'dataventas1
        '
        Me.dataventas1.AllowUserToDeleteRows = False
        Me.dataventas1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataventas1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1})
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dataventas1.DefaultCellStyle = DataGridViewCellStyle1
        Me.dataventas1.GridColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.dataventas1.Location = New System.Drawing.Point(426, 144)
        Me.dataventas1.Name = "dataventas1"
        Me.dataventas1.ReadOnly = True
        Me.dataventas1.RowHeadersVisible = False
        Me.dataventas1.Size = New System.Drawing.Size(103, 43)
        Me.dataventas1.TabIndex = 11
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Total"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'dataresultados1
        '
        Me.dataresultados1.AllowUserToDeleteRows = False
        Me.dataresultados1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataresultados1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Cantidad, Me.recuperacion, Me.ganancias, Me.cna})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dataresultados1.DefaultCellStyle = DataGridViewCellStyle2
        Me.dataresultados1.GridColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.dataresultados1.Location = New System.Drawing.Point(97, 211)
        Me.dataresultados1.Name = "dataresultados1"
        Me.dataresultados1.ReadOnly = True
        Me.dataresultados1.RowHeadersVisible = False
        Me.dataresultados1.Size = New System.Drawing.Size(445, 44)
        Me.dataresultados1.TabIndex = 10
        '
        'GroupPanel2
        '
        Me.GroupPanel2.BackColor = System.Drawing.Color.Transparent
        Me.GroupPanel2.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2010
        Me.GroupPanel2.Controls.Add(Me.dataresultados2)
        Me.GroupPanel2.Controls.Add(Me.ReflectionLabel3)
        Me.GroupPanel2.Controls.Add(Me.ReflectionLabel4)
        Me.GroupPanel2.Controls.Add(Me.dataventas2)
        Me.GroupPanel2.Controls.Add(Me.datacompras2)
        Me.GroupPanel2.Location = New System.Drawing.Point(9, 292)
        Me.GroupPanel2.Name = "GroupPanel2"
        Me.GroupPanel2.Size = New System.Drawing.Size(635, 162)
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
        Me.GroupPanel2.TabIndex = 9
        Me.GroupPanel2.Text = "Compras y Ventas  de este dia"
        '
        'dataresultados2
        '
        Me.dataresultados2.AllowUserToDeleteRows = False
        Me.dataresultados2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataresultados2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewProgressBarXColumn3, Me.DataGridViewProgressBarXColumn2, Me.DataGridViewTextBoxColumn3})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dataresultados2.DefaultCellStyle = DataGridViewCellStyle3
        Me.dataresultados2.GridColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.dataresultados2.Location = New System.Drawing.Point(85, 94)
        Me.dataresultados2.Name = "dataresultados2"
        Me.dataresultados2.ReadOnly = True
        Me.dataresultados2.RowHeadersVisible = False
        Me.dataresultados2.Size = New System.Drawing.Size(445, 44)
        Me.dataresultados2.TabIndex = 15
        '
        'ReflectionLabel3
        '
        Me.ReflectionLabel3.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.ReflectionLabel3.BackgroundStyle.Class = ""
        Me.ReflectionLabel3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ReflectionLabel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReflectionLabel3.Location = New System.Drawing.Point(427, -4)
        Me.ReflectionLabel3.Name = "ReflectionLabel3"
        Me.ReflectionLabel3.Size = New System.Drawing.Size(120, 38)
        Me.ReflectionLabel3.TabIndex = 14
        Me.ReflectionLabel3.Text = "VENTAS"
        '
        'ReflectionLabel4
        '
        Me.ReflectionLabel4.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.ReflectionLabel4.BackgroundStyle.Class = ""
        Me.ReflectionLabel4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ReflectionLabel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReflectionLabel4.Location = New System.Drawing.Point(92, -4)
        Me.ReflectionLabel4.Name = "ReflectionLabel4"
        Me.ReflectionLabel4.Size = New System.Drawing.Size(120, 38)
        Me.ReflectionLabel4.TabIndex = 13
        Me.ReflectionLabel4.Text = "COMPRAS"
        '
        'dataventas2
        '
        Me.dataventas2.AllowUserToDeleteRows = False
        Me.dataventas2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataventas2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn4})
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dataventas2.DefaultCellStyle = DataGridViewCellStyle4
        Me.dataventas2.GridColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.dataventas2.Location = New System.Drawing.Point(414, 34)
        Me.dataventas2.Name = "dataventas2"
        Me.dataventas2.ReadOnly = True
        Me.dataventas2.RowHeadersVisible = False
        Me.dataventas2.Size = New System.Drawing.Size(103, 43)
        Me.dataventas2.TabIndex = 12
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "Total"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'datacompras2
        '
        Me.datacompras2.AllowUserToDeleteRows = False
        Me.datacompras2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datacompras2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn5})
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.datacompras2.DefaultCellStyle = DataGridViewCellStyle5
        Me.datacompras2.GridColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.datacompras2.Location = New System.Drawing.Point(85, 34)
        Me.datacompras2.Name = "datacompras2"
        Me.datacompras2.ReadOnly = True
        Me.datacompras2.RowHeadersVisible = False
        Me.datacompras2.Size = New System.Drawing.Size(103, 43)
        Me.datacompras2.TabIndex = 11
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.HeaderText = "Total"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'ReflectionLabel2
        '
        Me.ReflectionLabel2.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.ReflectionLabel2.BackgroundStyle.Class = ""
        Me.ReflectionLabel2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ReflectionLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReflectionLabel2.Location = New System.Drawing.Point(438, 106)
        Me.ReflectionLabel2.Name = "ReflectionLabel2"
        Me.ReflectionLabel2.Size = New System.Drawing.Size(120, 38)
        Me.ReflectionLabel2.TabIndex = 6
        Me.ReflectionLabel2.Text = "VENTAS"
        '
        'ReflectionLabel1
        '
        Me.ReflectionLabel1.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.ReflectionLabel1.BackgroundStyle.Class = ""
        Me.ReflectionLabel1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ReflectionLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReflectionLabel1.Location = New System.Drawing.Point(104, 106)
        Me.ReflectionLabel1.Name = "ReflectionLabel1"
        Me.ReflectionLabel1.Size = New System.Drawing.Size(120, 38)
        Me.ReflectionLabel1.TabIndex = 5
        Me.ReflectionLabel1.Text = "COMPRAS"
        '
        'datacompras1
        '
        Me.datacompras1.AllowUserToDeleteRows = False
        Me.datacompras1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datacompras1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Total})
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.datacompras1.DefaultCellStyle = DataGridViewCellStyle6
        Me.datacompras1.GridColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.datacompras1.Location = New System.Drawing.Point(104, 144)
        Me.datacompras1.Name = "datacompras1"
        Me.datacompras1.ReadOnly = True
        Me.datacompras1.RowHeadersVisible = False
        Me.datacompras1.Size = New System.Drawing.Size(103, 43)
        Me.datacompras1.TabIndex = 3
        '
        'Total
        '
        Me.Total.HeaderText = "Total"
        Me.Total.Name = "Total"
        Me.Total.ReadOnly = True
        '
        'GroupPanel3
        '
        Me.GroupPanel3.BackColor = System.Drawing.Color.Transparent
        Me.GroupPanel3.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2010
        Me.GroupPanel3.Controls.Add(Me.botcalcular)
        Me.GroupPanel3.Controls.Add(Me.dthasta)
        Me.GroupPanel3.Controls.Add(Me.LabelX2)
        Me.GroupPanel3.Controls.Add(Me.dtdesde)
        Me.GroupPanel3.Controls.Add(Me.LabelX1)
        Me.GroupPanel3.Location = New System.Drawing.Point(9, 9)
        Me.GroupPanel3.Name = "GroupPanel3"
        Me.GroupPanel3.Size = New System.Drawing.Size(635, 74)
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
        Me.GroupPanel3.TabIndex = 2
        Me.GroupPanel3.Text = "Rango de fechas"
        '
        'botcalcular
        '
        Me.botcalcular.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.botcalcular.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.botcalcular.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.botcalcular.Location = New System.Drawing.Point(491, 7)
        Me.botcalcular.Name = "botcalcular"
        Me.botcalcular.Size = New System.Drawing.Size(114, 38)
        Me.botcalcular.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.botcalcular.TabIndex = 8
        Me.botcalcular.Text = "Aceptar"
        '
        'dthasta
        '
        Me.dthasta.Location = New System.Drawing.Point(225, 25)
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
        Me.LabelX2.Location = New System.Drawing.Point(303, 7)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(75, 23)
        Me.LabelX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.Windows7
        Me.LabelX2.TabIndex = 7
        Me.LabelX2.Text = "Hasta"
        '
        'dtdesde
        '
        Me.dtdesde.Location = New System.Drawing.Point(6, 25)
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
        Me.LabelX1.Location = New System.Drawing.Point(92, 6)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(75, 23)
        Me.LabelX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Windows7
        Me.LabelX1.TabIndex = 5
        Me.LabelX1.Text = "Desde"
        '
        'Cantidad
        '
        Me.Cantidad.HeaderText = "Cantidad"
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.ReadOnly = True
        Me.Cantidad.Width = 70
        '
        'recuperacion
        '
        Me.recuperacion.HeaderText = "Recuperacion"
        Me.recuperacion.Name = "recuperacion"
        Me.recuperacion.ReadOnly = True
        Me.recuperacion.Text = Nothing
        Me.recuperacion.Width = 150
        '
        'ganancias
        '
        Me.ganancias.HeaderText = "Ganancia"
        Me.ganancias.Name = "ganancias"
        Me.ganancias.ReadOnly = True
        Me.ganancias.Text = Nothing
        Me.ganancias.Width = 150
        '
        'cna
        '
        Me.cna.HeaderText = "Cantidad"
        Me.cna.Name = "cna"
        Me.cna.ReadOnly = True
        Me.cna.Width = 70
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Cantidad"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 70
        '
        'DataGridViewProgressBarXColumn3
        '
        Me.DataGridViewProgressBarXColumn3.HeaderText = "Recuperacion"
        Me.DataGridViewProgressBarXColumn3.Name = "DataGridViewProgressBarXColumn3"
        Me.DataGridViewProgressBarXColumn3.ReadOnly = True
        Me.DataGridViewProgressBarXColumn3.Text = Nothing
        Me.DataGridViewProgressBarXColumn3.Width = 150
        '
        'DataGridViewProgressBarXColumn2
        '
        Me.DataGridViewProgressBarXColumn2.HeaderText = "Ganancia"
        Me.DataGridViewProgressBarXColumn2.Name = "DataGridViewProgressBarXColumn2"
        Me.DataGridViewProgressBarXColumn2.ReadOnly = True
        Me.DataGridViewProgressBarXColumn2.Text = Nothing
        Me.DataGridViewProgressBarXColumn2.Width = 150
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "Cantidad"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 70
        '
        'VentasCompras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(659, 469)
        Me.Controls.Add(Me.GroupPanel1)
        Me.Name = "VentasCompras"
        Me.Text = "Compras sobre Ventas"
        Me.GroupPanel1.ResumeLayout(False)
        CType(Me.dataventas1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dataresultados1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupPanel2.ResumeLayout(False)
        CType(Me.dataresultados2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dataventas2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.datacompras2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.datacompras1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupPanel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents GroupPanel3 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents dthasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents dtdesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents ReflectionLabel2 As DevComponents.DotNetBar.Controls.ReflectionLabel
    Friend WithEvents ReflectionLabel1 As DevComponents.DotNetBar.Controls.ReflectionLabel
    Friend WithEvents datacompras1 As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents dataresultados1 As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents GroupPanel2 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents botcalcular As DevComponents.DotNetBar.ButtonX
    Friend WithEvents dataresultados2 As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents ReflectionLabel3 As DevComponents.DotNetBar.Controls.ReflectionLabel
    Friend WithEvents ReflectionLabel4 As DevComponents.DotNetBar.Controls.ReflectionLabel
    Friend WithEvents dataventas2 As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents datacompras2 As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents dataventas1 As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Total As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cantidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents recuperacion As DevComponents.DotNetBar.Controls.DataGridViewProgressBarXColumn
    Friend WithEvents ganancias As DevComponents.DotNetBar.Controls.DataGridViewProgressBarXColumn
    Friend WithEvents cna As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewProgressBarXColumn3 As DevComponents.DotNetBar.Controls.DataGridViewProgressBarXColumn
    Friend WithEvents DataGridViewProgressBarXColumn2 As DevComponents.DotNetBar.Controls.DataGridViewProgressBarXColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
