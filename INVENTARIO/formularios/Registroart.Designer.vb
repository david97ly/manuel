<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Registroart
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
        Me.components = New System.ComponentModel.Container()
        Me.TabControl1 = New DevComponents.DotNetBar.TabControl()
        Me.TabControlPanel4 = New DevComponents.DotNetBar.TabControlPanel()
        Me.TabItem4 = New DevComponents.DotNetBar.TabItem(Me.components)
        Me.TabControlPanel3 = New DevComponents.DotNetBar.TabControlPanel()
        Me.lbrecuperacion = New DevComponents.DotNetBar.Controls.ReflectionLabel()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.lbmontoventa = New DevComponents.DotNetBar.Controls.ReflectionLabel()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.lbmontocompra = New DevComponents.DotNetBar.Controls.ReflectionLabel()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.lbcantidadventa = New DevComponents.DotNetBar.Controls.ReflectionLabel()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lbcantidadcompra = New DevComponents.DotNetBar.Controls.ReflectionLabel()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lbarticulocv = New DevComponents.DotNetBar.Controls.ReflectionLabel()
        Me.GroupPanel3 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.ButtonX2 = New DevComponents.DotNetBar.ButtonX()
        Me.dthastacv = New System.Windows.Forms.DateTimePicker()
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX()
        Me.dtdesdecv = New System.Windows.Forms.DateTimePicker()
        Me.LabelX6 = New DevComponents.DotNetBar.LabelX()
        Me.TabItem3 = New DevComponents.DotNetBar.TabItem(Me.components)
        Me.panelventas = New DevComponents.DotNetBar.TabControlPanel()
        Me.lbporcentajev = New DevComponents.DotNetBar.Controls.ReflectionLabel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lbmontov = New DevComponents.DotNetBar.Controls.ReflectionLabel()
        Me.lbcantidadv = New DevComponents.DotNetBar.Controls.ReflectionLabel()
        Me.lbarticulosv = New DevComponents.DotNetBar.Controls.ReflectionLabel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupPanel2 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.botaceptarv = New DevComponents.DotNetBar.ButtonX()
        Me.dthastav = New System.Windows.Forms.DateTimePicker()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.dtdesdev = New System.Windows.Forms.DateTimePicker()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.TabItem1 = New DevComponents.DotNetBar.TabItem(Me.components)
        Me.panelcompras = New DevComponents.DotNetBar.TabControlPanel()
        Me.lbporcentaje = New DevComponents.DotNetBar.Controls.ReflectionLabel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lbmonto = New DevComponents.DotNetBar.Controls.ReflectionLabel()
        Me.lbcantidad = New DevComponents.DotNetBar.Controls.ReflectionLabel()
        Me.lbarticulo = New DevComponents.DotNetBar.Controls.ReflectionLabel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX()
        Me.dthasta = New System.Windows.Forms.DateTimePicker()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.dtdesde = New System.Windows.Forms.DateTimePicker()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.TabItem2 = New DevComponents.DotNetBar.TabItem(Me.components)
        CType(Me.TabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabControlPanel3.SuspendLayout()
        Me.GroupPanel3.SuspendLayout()
        Me.panelventas.SuspendLayout()
        Me.GroupPanel2.SuspendLayout()
        Me.panelcompras.SuspendLayout()
        Me.GroupPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.CanReorderTabs = True
        Me.TabControl1.Controls.Add(Me.panelcompras)
        Me.TabControl1.Controls.Add(Me.TabControlPanel3)
        Me.TabControl1.Controls.Add(Me.TabControlPanel4)
        Me.TabControl1.Controls.Add(Me.panelventas)
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(0, 1)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedTabFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.TabControl1.SelectedTabIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(497, 368)
        Me.TabControl1.TabIndex = 0
        Me.TabControl1.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.FixedWithNavigationBox
        Me.TabControl1.Tabs.Add(Me.TabItem2)
        Me.TabControl1.Tabs.Add(Me.TabItem1)
        Me.TabControl1.Tabs.Add(Me.TabItem3)
        Me.TabControl1.Tabs.Add(Me.TabItem4)
        Me.TabControl1.Text = "TabControl1"
        '
        'TabControlPanel4
        '
        Me.TabControlPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlPanel4.Location = New System.Drawing.Point(0, 26)
        Me.TabControlPanel4.Name = "TabControlPanel4"
        Me.TabControlPanel4.Padding = New System.Windows.Forms.Padding(1)
        Me.TabControlPanel4.Size = New System.Drawing.Size(497, 342)
        Me.TabControlPanel4.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.TabControlPanel4.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.TabControlPanel4.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.TabControlPanel4.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.TabControlPanel4.Style.BorderSide = CType(((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
            Or DevComponents.DotNetBar.eBorderSide.Bottom), DevComponents.DotNetBar.eBorderSide)
        Me.TabControlPanel4.Style.GradientAngle = 90
        Me.TabControlPanel4.TabIndex = 4
        Me.TabControlPanel4.TabItem = Me.TabItem4
        '
        'TabItem4
        '
        Me.TabItem4.AttachedControl = Me.TabControlPanel4
        Me.TabItem4.Name = "TabItem4"
        Me.TabItem4.Text = "Filtros"
        '
        'TabControlPanel3
        '
        Me.TabControlPanel3.Controls.Add(Me.lbrecuperacion)
        Me.TabControlPanel3.Controls.Add(Me.Label16)
        Me.TabControlPanel3.Controls.Add(Me.lbmontoventa)
        Me.TabControlPanel3.Controls.Add(Me.Label15)
        Me.TabControlPanel3.Controls.Add(Me.lbmontocompra)
        Me.TabControlPanel3.Controls.Add(Me.Label14)
        Me.TabControlPanel3.Controls.Add(Me.lbcantidadventa)
        Me.TabControlPanel3.Controls.Add(Me.Label13)
        Me.TabControlPanel3.Controls.Add(Me.lbcantidadcompra)
        Me.TabControlPanel3.Controls.Add(Me.Label12)
        Me.TabControlPanel3.Controls.Add(Me.Label11)
        Me.TabControlPanel3.Controls.Add(Me.lbarticulocv)
        Me.TabControlPanel3.Controls.Add(Me.GroupPanel3)
        Me.TabControlPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlPanel3.Location = New System.Drawing.Point(0, 26)
        Me.TabControlPanel3.Name = "TabControlPanel3"
        Me.TabControlPanel3.Padding = New System.Windows.Forms.Padding(1)
        Me.TabControlPanel3.Size = New System.Drawing.Size(497, 342)
        Me.TabControlPanel3.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.TabControlPanel3.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.TabControlPanel3.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.TabControlPanel3.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.TabControlPanel3.Style.BorderSide = CType(((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
            Or DevComponents.DotNetBar.eBorderSide.Bottom), DevComponents.DotNetBar.eBorderSide)
        Me.TabControlPanel3.Style.GradientAngle = 90
        Me.TabControlPanel3.TabIndex = 3
        Me.TabControlPanel3.TabItem = Me.TabItem3
        '
        'lbrecuperacion
        '
        Me.lbrecuperacion.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lbrecuperacion.BackgroundStyle.Class = ""
        Me.lbrecuperacion.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbrecuperacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbrecuperacion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbrecuperacion.Location = New System.Drawing.Point(192, 310)
        Me.lbrecuperacion.Name = "lbrecuperacion"
        Me.lbrecuperacion.Size = New System.Drawing.Size(90, 32)
        Me.lbrecuperacion.TabIndex = 28
        Me.lbrecuperacion.Text = "Monto"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(39, 310)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(147, 24)
        Me.Label16.TabIndex = 27
        Me.Label16.Text = "Recuperacion:"
        '
        'lbmontoventa
        '
        Me.lbmontoventa.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lbmontoventa.BackgroundStyle.Class = ""
        Me.lbmontoventa.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbmontoventa.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbmontoventa.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbmontoventa.Location = New System.Drawing.Point(288, 253)
        Me.lbmontoventa.Name = "lbmontoventa"
        Me.lbmontoventa.Size = New System.Drawing.Size(66, 43)
        Me.lbmontoventa.TabIndex = 26
        Me.lbmontoventa.Text = "Monto"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(263, 226)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(116, 24)
        Me.Label15.TabIndex = 25
        Me.Label15.Text = "Moto Venta"
        '
        'lbmontocompra
        '
        Me.lbmontocompra.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lbmontocompra.BackgroundStyle.Class = ""
        Me.lbmontocompra.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbmontocompra.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbmontocompra.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbmontocompra.Location = New System.Drawing.Point(80, 253)
        Me.lbmontocompra.Name = "lbmontocompra"
        Me.lbmontocompra.Size = New System.Drawing.Size(66, 43)
        Me.lbmontocompra.TabIndex = 24
        Me.lbmontocompra.Text = "Monto"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(51, 226)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(135, 24)
        Me.Label14.TabIndex = 23
        Me.Label14.Text = "Moto Compra"
        '
        'lbcantidadventa
        '
        Me.lbcantidadventa.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lbcantidadventa.BackgroundStyle.Class = ""
        Me.lbcantidadventa.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbcantidadventa.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbcantidadventa.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbcantidadventa.Location = New System.Drawing.Point(276, 180)
        Me.lbcantidadventa.Name = "lbcantidadventa"
        Me.lbcantidadventa.Size = New System.Drawing.Size(87, 43)
        Me.lbcantidadventa.TabIndex = 22
        Me.lbcantidadventa.Text = "Cantidad"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(249, 153)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(152, 24)
        Me.Label13.TabIndex = 21
        Me.Label13.Text = "Cantidad Venta"
        '
        'lbcantidadcompra
        '
        Me.lbcantidadcompra.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lbcantidadcompra.BackgroundStyle.Class = ""
        Me.lbcantidadcompra.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbcantidadcompra.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbcantidadcompra.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbcantidadcompra.Location = New System.Drawing.Point(70, 180)
        Me.lbcantidadcompra.Name = "lbcantidadcompra"
        Me.lbcantidadcompra.Size = New System.Drawing.Size(87, 43)
        Me.lbcantidadcompra.TabIndex = 20
        Me.lbcantidadcompra.Text = "Cantidad"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(36, 153)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(171, 24)
        Me.Label12.TabIndex = 19
        Me.Label12.Text = "Cantidad Compra"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(23, 116)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(87, 24)
        Me.Label11.TabIndex = 18
        Me.Label11.Text = "Articulo:"
        '
        'lbarticulocv
        '
        Me.lbarticulocv.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lbarticulocv.BackgroundStyle.Class = ""
        Me.lbarticulocv.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbarticulocv.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbarticulocv.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbarticulocv.Location = New System.Drawing.Point(114, 112)
        Me.lbarticulocv.Name = "lbarticulocv"
        Me.lbarticulocv.Size = New System.Drawing.Size(345, 43)
        Me.lbarticulocv.TabIndex = 17
        Me.lbarticulocv.Text = "Articulos"
        '
        'GroupPanel3
        '
        Me.GroupPanel3.BackColor = System.Drawing.Color.Transparent
        Me.GroupPanel3.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel3.Controls.Add(Me.ButtonX2)
        Me.GroupPanel3.Controls.Add(Me.dthastacv)
        Me.GroupPanel3.Controls.Add(Me.LabelX5)
        Me.GroupPanel3.Controls.Add(Me.dtdesdecv)
        Me.GroupPanel3.Controls.Add(Me.LabelX6)
        Me.GroupPanel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupPanel3.Location = New System.Drawing.Point(21, 4)
        Me.GroupPanel3.Name = "GroupPanel3"
        Me.GroupPanel3.Size = New System.Drawing.Size(452, 105)
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
        Me.GroupPanel3.TabIndex = 13
        Me.GroupPanel3.Text = "Seleccione el rango de las fechas"
        '
        'ButtonX2
        '
        Me.ButtonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonX2.Location = New System.Drawing.Point(175, 41)
        Me.ButtonX2.Name = "ButtonX2"
        Me.ButtonX2.Size = New System.Drawing.Size(83, 35)
        Me.ButtonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.VS2005
        Me.ButtonX2.TabIndex = 4
        Me.ButtonX2.Text = "Aceptar"
        '
        'dthastacv
        '
        Me.dthastacv.Location = New System.Drawing.Point(222, 15)
        Me.dthastacv.Name = "dthastacv"
        Me.dthastacv.Size = New System.Drawing.Size(200, 22)
        Me.dthastacv.TabIndex = 2
        '
        'LabelX5
        '
        Me.LabelX5.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX5.BackgroundStyle.Class = ""
        Me.LabelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX5.Location = New System.Drawing.Point(298, -3)
        Me.LabelX5.Name = "LabelX5"
        Me.LabelX5.Size = New System.Drawing.Size(75, 23)
        Me.LabelX5.Style = DevComponents.DotNetBar.eDotNetBarStyle.Windows7
        Me.LabelX5.TabIndex = 3
        Me.LabelX5.Text = "Hasta"
        '
        'dtdesdecv
        '
        Me.dtdesdecv.Location = New System.Drawing.Point(3, 15)
        Me.dtdesdecv.Name = "dtdesdecv"
        Me.dtdesdecv.Size = New System.Drawing.Size(200, 22)
        Me.dtdesdecv.TabIndex = 0
        '
        'LabelX6
        '
        Me.LabelX6.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX6.BackgroundStyle.Class = ""
        Me.LabelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX6.Location = New System.Drawing.Point(87, -4)
        Me.LabelX6.Name = "LabelX6"
        Me.LabelX6.Size = New System.Drawing.Size(75, 23)
        Me.LabelX6.Style = DevComponents.DotNetBar.eDotNetBarStyle.Windows7
        Me.LabelX6.TabIndex = 1
        Me.LabelX6.Text = "Desde"
        '
        'TabItem3
        '
        Me.TabItem3.AttachedControl = Me.TabControlPanel3
        Me.TabItem3.Name = "TabItem3"
        Me.TabItem3.Text = "Compras/Ventas"
        '
        'panelventas
        '
        Me.panelventas.Controls.Add(Me.lbporcentajev)
        Me.panelventas.Controls.Add(Me.Label4)
        Me.panelventas.Controls.Add(Me.Label5)
        Me.panelventas.Controls.Add(Me.lbmontov)
        Me.panelventas.Controls.Add(Me.lbcantidadv)
        Me.panelventas.Controls.Add(Me.lbarticulosv)
        Me.panelventas.Controls.Add(Me.Label6)
        Me.panelventas.Controls.Add(Me.Label9)
        Me.panelventas.Controls.Add(Me.Label10)
        Me.panelventas.Controls.Add(Me.GroupPanel2)
        Me.panelventas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelventas.Location = New System.Drawing.Point(0, 26)
        Me.panelventas.Name = "panelventas"
        Me.panelventas.Padding = New System.Windows.Forms.Padding(1)
        Me.panelventas.Size = New System.Drawing.Size(497, 342)
        Me.panelventas.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.panelventas.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.panelventas.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.panelventas.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.panelventas.Style.BorderSide = CType(((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
            Or DevComponents.DotNetBar.eBorderSide.Bottom), DevComponents.DotNetBar.eBorderSide)
        Me.panelventas.Style.GradientAngle = 90
        Me.panelventas.TabIndex = 1
        Me.panelventas.TabItem = Me.TabItem1
        Me.panelventas.Text = "Ventas"
        '
        'lbporcentajev
        '
        Me.lbporcentajev.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lbporcentajev.BackgroundStyle.Class = ""
        Me.lbporcentajev.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbporcentajev.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbporcentajev.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbporcentajev.Location = New System.Drawing.Point(146, 293)
        Me.lbporcentajev.Name = "lbporcentajev"
        Me.lbporcentajev.Size = New System.Drawing.Size(53, 43)
        Me.lbporcentajev.TabIndex = 20
        Me.lbporcentajev.Text = "000"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(198, 297)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(166, 24)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = " % De las Ventas"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(8, 297)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(140, 24)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Representa el"
        '
        'lbmontov
        '
        Me.lbmontov.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lbmontov.BackgroundStyle.Class = ""
        Me.lbmontov.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbmontov.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbmontov.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbmontov.Location = New System.Drawing.Point(115, 238)
        Me.lbmontov.Name = "lbmontov"
        Me.lbmontov.Size = New System.Drawing.Size(296, 43)
        Me.lbmontov.TabIndex = 18
        Me.lbmontov.Text = "Monto"
        '
        'lbcantidadv
        '
        Me.lbcantidadv.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lbcantidadv.BackgroundStyle.Class = ""
        Me.lbcantidadv.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbcantidadv.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbcantidadv.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbcantidadv.Location = New System.Drawing.Point(120, 181)
        Me.lbcantidadv.Name = "lbcantidadv"
        Me.lbcantidadv.Size = New System.Drawing.Size(224, 43)
        Me.lbcantidadv.TabIndex = 17
        Me.lbcantidadv.Text = "Cantidad"
        '
        'lbarticulosv
        '
        Me.lbarticulosv.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lbarticulosv.BackgroundStyle.Class = ""
        Me.lbarticulosv.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbarticulosv.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbarticulosv.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbarticulosv.Location = New System.Drawing.Point(120, 132)
        Me.lbarticulosv.Name = "lbarticulosv"
        Me.lbarticulosv.Size = New System.Drawing.Size(345, 43)
        Me.lbarticulosv.TabIndex = 16
        Me.lbarticulosv.Text = "Articulos"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(40, 241)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 24)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Monto:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(16, 187)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(98, 24)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Cantidad:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(27, 135)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(87, 24)
        Me.Label10.TabIndex = 13
        Me.Label10.Text = "Articulo:"
        '
        'GroupPanel2
        '
        Me.GroupPanel2.BackColor = System.Drawing.Color.Transparent
        Me.GroupPanel2.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel2.Controls.Add(Me.botaceptarv)
        Me.GroupPanel2.Controls.Add(Me.dthastav)
        Me.GroupPanel2.Controls.Add(Me.LabelX3)
        Me.GroupPanel2.Controls.Add(Me.dtdesdev)
        Me.GroupPanel2.Controls.Add(Me.LabelX4)
        Me.GroupPanel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupPanel2.Location = New System.Drawing.Point(21, 4)
        Me.GroupPanel2.Name = "GroupPanel2"
        Me.GroupPanel2.Size = New System.Drawing.Size(452, 122)
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
        Me.GroupPanel2.TabIndex = 12
        Me.GroupPanel2.Text = "Seleccione el rango de las fechas"
        '
        'botaceptarv
        '
        Me.botaceptarv.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.botaceptarv.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.botaceptarv.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.botaceptarv.Location = New System.Drawing.Point(175, 56)
        Me.botaceptarv.Name = "botaceptarv"
        Me.botaceptarv.Size = New System.Drawing.Size(83, 35)
        Me.botaceptarv.Style = DevComponents.DotNetBar.eDotNetBarStyle.VS2005
        Me.botaceptarv.TabIndex = 4
        Me.botaceptarv.Text = "Aceptar"
        '
        'dthastav
        '
        Me.dthastav.Location = New System.Drawing.Point(222, 22)
        Me.dthastav.Name = "dthastav"
        Me.dthastav.Size = New System.Drawing.Size(200, 22)
        Me.dthastav.TabIndex = 2
        '
        'LabelX3
        '
        Me.LabelX3.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX3.BackgroundStyle.Class = ""
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.Location = New System.Drawing.Point(298, 4)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(75, 23)
        Me.LabelX3.Style = DevComponents.DotNetBar.eDotNetBarStyle.Windows7
        Me.LabelX3.TabIndex = 3
        Me.LabelX3.Text = "Hasta"
        '
        'dtdesdev
        '
        Me.dtdesdev.Location = New System.Drawing.Point(3, 22)
        Me.dtdesdev.Name = "dtdesdev"
        Me.dtdesdev.Size = New System.Drawing.Size(200, 22)
        Me.dtdesdev.TabIndex = 0
        '
        'LabelX4
        '
        Me.LabelX4.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX4.BackgroundStyle.Class = ""
        Me.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX4.Location = New System.Drawing.Point(87, 3)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(75, 23)
        Me.LabelX4.Style = DevComponents.DotNetBar.eDotNetBarStyle.Windows7
        Me.LabelX4.TabIndex = 1
        Me.LabelX4.Text = "Desde"
        '
        'TabItem1
        '
        Me.TabItem1.AttachedControl = Me.panelventas
        Me.TabItem1.Name = "TabItem1"
        Me.TabItem1.Text = "Ventas"
        '
        'panelcompras
        '
        Me.panelcompras.Controls.Add(Me.lbporcentaje)
        Me.panelcompras.Controls.Add(Me.Label8)
        Me.panelcompras.Controls.Add(Me.Label7)
        Me.panelcompras.Controls.Add(Me.lbmonto)
        Me.panelcompras.Controls.Add(Me.lbcantidad)
        Me.panelcompras.Controls.Add(Me.lbarticulo)
        Me.panelcompras.Controls.Add(Me.Label3)
        Me.panelcompras.Controls.Add(Me.Label2)
        Me.panelcompras.Controls.Add(Me.Label1)
        Me.panelcompras.Controls.Add(Me.GroupPanel1)
        Me.panelcompras.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelcompras.Location = New System.Drawing.Point(0, 26)
        Me.panelcompras.Name = "panelcompras"
        Me.panelcompras.Padding = New System.Windows.Forms.Padding(1)
        Me.panelcompras.Size = New System.Drawing.Size(497, 342)
        Me.panelcompras.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.panelcompras.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.panelcompras.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.panelcompras.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.panelcompras.Style.BorderSide = CType(((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
            Or DevComponents.DotNetBar.eBorderSide.Bottom), DevComponents.DotNetBar.eBorderSide)
        Me.panelcompras.Style.GradientAngle = 90
        Me.panelcompras.TabIndex = 2
        Me.panelcompras.TabItem = Me.TabItem2
        '
        'lbporcentaje
        '
        Me.lbporcentaje.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lbporcentaje.BackgroundStyle.Class = ""
        Me.lbporcentaje.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbporcentaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbporcentaje.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbporcentaje.Location = New System.Drawing.Point(146, 293)
        Me.lbporcentaje.Name = "lbporcentaje"
        Me.lbporcentaje.Size = New System.Drawing.Size(54, 43)
        Me.lbporcentaje.TabIndex = 10
        Me.lbporcentaje.Text = "000"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(198, 297)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(179, 24)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "% De las Compras"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(8, 297)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(140, 24)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Representa el"
        '
        'lbmonto
        '
        Me.lbmonto.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lbmonto.BackgroundStyle.Class = ""
        Me.lbmonto.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbmonto.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbmonto.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbmonto.Location = New System.Drawing.Point(115, 238)
        Me.lbmonto.Name = "lbmonto"
        Me.lbmonto.Size = New System.Drawing.Size(296, 43)
        Me.lbmonto.TabIndex = 8
        Me.lbmonto.Text = "Monto"
        '
        'lbcantidad
        '
        Me.lbcantidad.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lbcantidad.BackgroundStyle.Class = ""
        Me.lbcantidad.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbcantidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbcantidad.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbcantidad.Location = New System.Drawing.Point(120, 181)
        Me.lbcantidad.Name = "lbcantidad"
        Me.lbcantidad.Size = New System.Drawing.Size(224, 43)
        Me.lbcantidad.TabIndex = 7
        Me.lbcantidad.Text = "Cantidad"
        '
        'lbarticulo
        '
        Me.lbarticulo.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lbarticulo.BackgroundStyle.Class = ""
        Me.lbarticulo.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbarticulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbarticulo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbarticulo.Location = New System.Drawing.Point(120, 132)
        Me.lbarticulo.Name = "lbarticulo"
        Me.lbarticulo.Size = New System.Drawing.Size(345, 43)
        Me.lbarticulo.TabIndex = 6
        Me.lbarticulo.Text = "Articulos"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(40, 241)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 24)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Monto:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 187)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 24)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Cantidad:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(27, 135)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 24)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Articulo:"
        '
        'GroupPanel1
        '
        Me.GroupPanel1.BackColor = System.Drawing.Color.Transparent
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.ButtonX1)
        Me.GroupPanel1.Controls.Add(Me.dthasta)
        Me.GroupPanel1.Controls.Add(Me.LabelX2)
        Me.GroupPanel1.Controls.Add(Me.dtdesde)
        Me.GroupPanel1.Controls.Add(Me.LabelX1)
        Me.GroupPanel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupPanel1.Location = New System.Drawing.Point(21, 4)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(452, 122)
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
        Me.GroupPanel1.TabIndex = 2
        Me.GroupPanel1.Text = "Seleccione el rango de las fechas"
        '
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonX1.Location = New System.Drawing.Point(175, 56)
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.Size = New System.Drawing.Size(83, 35)
        Me.ButtonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.VS2005
        Me.ButtonX1.TabIndex = 4
        Me.ButtonX1.Text = "Aceptar"
        '
        'dthasta
        '
        Me.dthasta.Location = New System.Drawing.Point(222, 22)
        Me.dthasta.Name = "dthasta"
        Me.dthasta.Size = New System.Drawing.Size(200, 22)
        Me.dthasta.TabIndex = 2
        '
        'LabelX2
        '
        Me.LabelX2.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX2.BackgroundStyle.Class = ""
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Location = New System.Drawing.Point(298, 4)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(75, 23)
        Me.LabelX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.Windows7
        Me.LabelX2.TabIndex = 3
        Me.LabelX2.Text = "Hasta"
        '
        'dtdesde
        '
        Me.dtdesde.Location = New System.Drawing.Point(3, 22)
        Me.dtdesde.Name = "dtdesde"
        Me.dtdesde.Size = New System.Drawing.Size(200, 22)
        Me.dtdesde.TabIndex = 0
        '
        'LabelX1
        '
        Me.LabelX1.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX1.BackgroundStyle.Class = ""
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Location = New System.Drawing.Point(87, 3)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(75, 23)
        Me.LabelX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Windows7
        Me.LabelX1.TabIndex = 1
        Me.LabelX1.Text = "Desde"
        '
        'TabItem2
        '
        Me.TabItem2.AttachedControl = Me.panelcompras
        Me.TabItem2.Name = "TabItem2"
        Me.TabItem2.Text = "Compras"
        '
        'Registroart
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(495, 370)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Registroart"
        Me.Text = "Registroart"
        CType(Me.TabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabControlPanel3.ResumeLayout(False)
        Me.TabControlPanel3.PerformLayout()
        Me.GroupPanel3.ResumeLayout(False)
        Me.panelventas.ResumeLayout(False)
        Me.panelventas.PerformLayout()
        Me.GroupPanel2.ResumeLayout(False)
        Me.panelcompras.ResumeLayout(False)
        Me.panelcompras.PerformLayout()
        Me.GroupPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As DevComponents.DotNetBar.TabControl
    Friend WithEvents panelventas As DevComponents.DotNetBar.TabControlPanel
    Friend WithEvents TabItem1 As DevComponents.DotNetBar.TabItem
    Friend WithEvents panelcompras As DevComponents.DotNetBar.TabControlPanel
    Friend WithEvents TabItem2 As DevComponents.DotNetBar.TabItem
    Friend WithEvents TabControlPanel3 As DevComponents.DotNetBar.TabControlPanel
    Friend WithEvents TabItem3 As DevComponents.DotNetBar.TabItem
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents dthasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents dtdesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents lbmonto As DevComponents.DotNetBar.Controls.ReflectionLabel
    Friend WithEvents lbcantidad As DevComponents.DotNetBar.Controls.ReflectionLabel
    Friend WithEvents lbarticulo As DevComponents.DotNetBar.Controls.ReflectionLabel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TabControlPanel4 As DevComponents.DotNetBar.TabControlPanel
    Friend WithEvents TabItem4 As DevComponents.DotNetBar.TabItem
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lbporcentaje As DevComponents.DotNetBar.Controls.ReflectionLabel
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents lbporcentajev As DevComponents.DotNetBar.Controls.ReflectionLabel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lbmontov As DevComponents.DotNetBar.Controls.ReflectionLabel
    Friend WithEvents lbcantidadv As DevComponents.DotNetBar.Controls.ReflectionLabel
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents GroupPanel2 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents botaceptarv As DevComponents.DotNetBar.ButtonX
    Friend WithEvents dthastav As System.Windows.Forms.DateTimePicker
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents dtdesdev As System.Windows.Forms.DateTimePicker
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents lbarticulocv As DevComponents.DotNetBar.Controls.ReflectionLabel
    Friend WithEvents GroupPanel3 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents ButtonX2 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents dthastacv As System.Windows.Forms.DateTimePicker
    Friend WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
    Friend WithEvents dtdesdecv As System.Windows.Forms.DateTimePicker
    Friend WithEvents LabelX6 As DevComponents.DotNetBar.LabelX
    Friend WithEvents lbarticulosv As DevComponents.DotNetBar.Controls.ReflectionLabel
    Friend WithEvents lbmontoventa As DevComponents.DotNetBar.Controls.ReflectionLabel
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents lbmontocompra As DevComponents.DotNetBar.Controls.ReflectionLabel
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents lbcantidadventa As DevComponents.DotNetBar.Controls.ReflectionLabel
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents lbcantidadcompra As DevComponents.DotNetBar.Controls.ReflectionLabel
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents lbrecuperacion As DevComponents.DotNetBar.Controls.ReflectionLabel
    Friend WithEvents Label16 As System.Windows.Forms.Label
End Class
