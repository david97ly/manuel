<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Configuraciones
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
        Me.TabControlPanel1 = New DevComponents.DotNetBar.TabControlPanel()
        Me.GroupPanel2 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.grubfactura = New System.Windows.Forms.GroupBox()
        Me.ReflectionLabel2 = New DevComponents.DotNetBar.Controls.ReflectionLabel()
        Me.bothechof = New System.Windows.Forms.Button()
        Me.texndesdef = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.texnhastaf = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.grubcomprobante = New System.Windows.Forms.GroupBox()
        Me.ReflectionLabel3 = New DevComponents.DotNetBar.Controls.ReflectionLabel()
        Me.bothechoccf = New System.Windows.Forms.Button()
        Me.texndesdeccf = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.texnhastaccf = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.botnccf = New DevComponents.DotNetBar.ButtonX()
        Me.botnfacturas = New DevComponents.DotNetBar.ButtonX()
        Me.texactualccf = New System.Windows.Forms.TextBox()
        Me.texactualf = New System.Windows.Forms.TextBox()
        Me.progresccf = New System.Windows.Forms.ProgressBar()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.texhastaccf = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.texdesdeccf = New System.Windows.Forms.TextBox()
        Me.ReflectionLabel1 = New DevComponents.DotNetBar.Controls.ReflectionLabel()
        Me.progresf = New System.Windows.Forms.ProgressBar()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.texhastaf = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.texdedef = New System.Windows.Forms.TextBox()
        Me.ReflectionLabel9 = New DevComponents.DotNetBar.Controls.ReflectionLabel()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape3 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.TabItem1 = New DevComponents.DotNetBar.TabItem(Me.components)
        Me.TabControlPanel2 = New DevComponents.DotNetBar.TabControlPanel()
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.ReflectionLabel4 = New DevComponents.DotNetBar.Controls.ReflectionLabel()
        Me.TabItem2 = New DevComponents.DotNetBar.TabItem(Me.components)
        CType(Me.TabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabControlPanel1.SuspendLayout()
        Me.GroupPanel2.SuspendLayout()
        Me.grubfactura.SuspendLayout()
        Me.grubcomprobante.SuspendLayout()
        Me.TabControlPanel2.SuspendLayout()
        Me.GroupPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.CanReorderTabs = True
        Me.TabControl1.Controls.Add(Me.TabControlPanel1)
        Me.TabControl1.Controls.Add(Me.TabControlPanel2)
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(4)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedTabFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.TabControl1.SelectedTabIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(998, 433)
        Me.TabControl1.TabIndex = 0
        Me.TabControl1.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.FixedWithNavigationBox
        Me.TabControl1.Tabs.Add(Me.TabItem1)
        Me.TabControl1.Tabs.Add(Me.TabItem2)
        Me.TabControl1.Text = "TabControl1"
        '
        'TabControlPanel1
        '
        Me.TabControlPanel1.Controls.Add(Me.GroupPanel2)
        Me.TabControlPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlPanel1.Location = New System.Drawing.Point(0, 26)
        Me.TabControlPanel1.Margin = New System.Windows.Forms.Padding(4)
        Me.TabControlPanel1.Name = "TabControlPanel1"
        Me.TabControlPanel1.Padding = New System.Windows.Forms.Padding(1)
        Me.TabControlPanel1.Size = New System.Drawing.Size(998, 407)
        Me.TabControlPanel1.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.TabControlPanel1.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.TabControlPanel1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.TabControlPanel1.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.TabControlPanel1.Style.BorderSide = CType(((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
            Or DevComponents.DotNetBar.eBorderSide.Bottom), DevComponents.DotNetBar.eBorderSide)
        Me.TabControlPanel1.Style.GradientAngle = 90
        Me.TabControlPanel1.TabIndex = 1
        Me.TabControlPanel1.TabItem = Me.TabItem1
        Me.TabControlPanel1.Text = "Documentos"
        '
        'GroupPanel2
        '
        Me.GroupPanel2.BackColor = System.Drawing.Color.Transparent
        Me.GroupPanel2.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel2.Controls.Add(Me.grubfactura)
        Me.GroupPanel2.Controls.Add(Me.grubcomprobante)
        Me.GroupPanel2.Controls.Add(Me.botnccf)
        Me.GroupPanel2.Controls.Add(Me.botnfacturas)
        Me.GroupPanel2.Controls.Add(Me.texactualccf)
        Me.GroupPanel2.Controls.Add(Me.texactualf)
        Me.GroupPanel2.Controls.Add(Me.progresccf)
        Me.GroupPanel2.Controls.Add(Me.Label3)
        Me.GroupPanel2.Controls.Add(Me.texhastaccf)
        Me.GroupPanel2.Controls.Add(Me.Label4)
        Me.GroupPanel2.Controls.Add(Me.texdesdeccf)
        Me.GroupPanel2.Controls.Add(Me.ReflectionLabel1)
        Me.GroupPanel2.Controls.Add(Me.progresf)
        Me.GroupPanel2.Controls.Add(Me.Label2)
        Me.GroupPanel2.Controls.Add(Me.texhastaf)
        Me.GroupPanel2.Controls.Add(Me.Label1)
        Me.GroupPanel2.Controls.Add(Me.texdedef)
        Me.GroupPanel2.Controls.Add(Me.ReflectionLabel9)
        Me.GroupPanel2.Controls.Add(Me.ShapeContainer1)
        Me.GroupPanel2.Location = New System.Drawing.Point(5, 0)
        Me.GroupPanel2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupPanel2.Name = "GroupPanel2"
        Me.GroupPanel2.Size = New System.Drawing.Size(994, 398)
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
        Me.GroupPanel2.Text = "Control de Tiraje"
        '
        'grubfactura
        '
        Me.grubfactura.Controls.Add(Me.ReflectionLabel2)
        Me.grubfactura.Controls.Add(Me.bothechof)
        Me.grubfactura.Controls.Add(Me.texndesdef)
        Me.grubfactura.Controls.Add(Me.Label5)
        Me.grubfactura.Controls.Add(Me.texnhastaf)
        Me.grubfactura.Controls.Add(Me.Label6)
        Me.grubfactura.Location = New System.Drawing.Point(567, -10)
        Me.grubfactura.Name = "grubfactura"
        Me.grubfactura.Size = New System.Drawing.Size(424, 177)
        Me.grubfactura.TabIndex = 66
        Me.grubfactura.TabStop = False
        '
        'ReflectionLabel2
        '
        Me.ReflectionLabel2.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.ReflectionLabel2.BackgroundStyle.Class = ""
        Me.ReflectionLabel2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ReflectionLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReflectionLabel2.Location = New System.Drawing.Point(95, 12)
        Me.ReflectionLabel2.Margin = New System.Windows.Forms.Padding(4)
        Me.ReflectionLabel2.Name = "ReflectionLabel2"
        Me.ReflectionLabel2.Size = New System.Drawing.Size(245, 46)
        Me.ReflectionLabel2.TabIndex = 62
        Me.ReflectionLabel2.Text = "<b><font size=""+6""><i>Nuevo Tiraje de Facturas</i><font color=""#B02B2C""></font></" & _
    "font></b>"
        '
        'bothechof
        '
        Me.bothechof.Location = New System.Drawing.Point(165, 118)
        Me.bothechof.Name = "bothechof"
        Me.bothechof.Size = New System.Drawing.Size(111, 31)
        Me.bothechof.TabIndex = 64
        Me.bothechof.Text = "Hecho"
        Me.bothechof.UseVisualStyleBackColor = True
        '
        'texndesdef
        '
        Me.texndesdef.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.texndesdef.Location = New System.Drawing.Point(75, 66)
        Me.texndesdef.Margin = New System.Windows.Forms.Padding(4)
        Me.texndesdef.Name = "texndesdef"
        Me.texndesdef.Size = New System.Drawing.Size(132, 24)
        Me.texndesdef.TabIndex = 58
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(24, 69)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 18)
        Me.Label5.TabIndex = 59
        Me.Label5.Text = "Tiraje"
        '
        'texnhastaf
        '
        Me.texnhastaf.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.texnhastaf.Location = New System.Drawing.Point(270, 66)
        Me.texnhastaf.Margin = New System.Windows.Forms.Padding(4)
        Me.texnhastaf.Name = "texnhastaf"
        Me.texnhastaf.Size = New System.Drawing.Size(132, 24)
        Me.texnhastaf.TabIndex = 60
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(227, 69)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(27, 18)
        Me.Label6.TabIndex = 61
        Me.Label6.Text = "AL"
        '
        'grubcomprobante
        '
        Me.grubcomprobante.Controls.Add(Me.ReflectionLabel3)
        Me.grubcomprobante.Controls.Add(Me.bothechoccf)
        Me.grubcomprobante.Controls.Add(Me.texndesdeccf)
        Me.grubcomprobante.Controls.Add(Me.Label8)
        Me.grubcomprobante.Controls.Add(Me.texnhastaccf)
        Me.grubcomprobante.Controls.Add(Me.Label7)
        Me.grubcomprobante.Location = New System.Drawing.Point(567, 166)
        Me.grubcomprobante.Name = "grubcomprobante"
        Me.grubcomprobante.Size = New System.Drawing.Size(424, 210)
        Me.grubcomprobante.TabIndex = 65
        Me.grubcomprobante.TabStop = False
        '
        'ReflectionLabel3
        '
        Me.ReflectionLabel3.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.ReflectionLabel3.BackgroundStyle.Class = ""
        Me.ReflectionLabel3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ReflectionLabel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReflectionLabel3.Location = New System.Drawing.Point(95, 48)
        Me.ReflectionLabel3.Margin = New System.Windows.Forms.Padding(4)
        Me.ReflectionLabel3.Name = "ReflectionLabel3"
        Me.ReflectionLabel3.Size = New System.Drawing.Size(245, 46)
        Me.ReflectionLabel3.TabIndex = 62
        Me.ReflectionLabel3.Text = "<b><font size=""+6""><i>Nuevo Tiraje de C.C.F</i><font color=""#B02B2C""></font></fon" & _
    "t></b>"
        '
        'bothechoccf
        '
        Me.bothechoccf.Location = New System.Drawing.Point(165, 154)
        Me.bothechoccf.Name = "bothechoccf"
        Me.bothechoccf.Size = New System.Drawing.Size(111, 31)
        Me.bothechoccf.TabIndex = 64
        Me.bothechoccf.Text = "Hecho"
        Me.bothechoccf.UseVisualStyleBackColor = True
        '
        'texndesdeccf
        '
        Me.texndesdeccf.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.texndesdeccf.Location = New System.Drawing.Point(75, 102)
        Me.texndesdeccf.Margin = New System.Windows.Forms.Padding(4)
        Me.texndesdeccf.Name = "texndesdeccf"
        Me.texndesdeccf.Size = New System.Drawing.Size(132, 24)
        Me.texndesdeccf.TabIndex = 58
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(24, 105)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(50, 18)
        Me.Label8.TabIndex = 59
        Me.Label8.Text = "Tiraje"
        '
        'texnhastaccf
        '
        Me.texnhastaccf.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.texnhastaccf.Location = New System.Drawing.Point(270, 102)
        Me.texnhastaccf.Margin = New System.Windows.Forms.Padding(4)
        Me.texnhastaccf.Name = "texnhastaccf"
        Me.texnhastaccf.Size = New System.Drawing.Size(132, 24)
        Me.texnhastaccf.TabIndex = 60
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(227, 105)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(27, 18)
        Me.Label7.TabIndex = 61
        Me.Label7.Text = "AL"
        '
        'botnccf
        '
        Me.botnccf.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.botnccf.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.botnccf.Location = New System.Drawing.Point(471, 178)
        Me.botnccf.Name = "botnccf"
        Me.botnccf.Size = New System.Drawing.Size(80, 34)
        Me.botnccf.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.botnccf.TabIndex = 52
        Me.botnccf.Text = "Nuevo Tiraje"
        '
        'botnfacturas
        '
        Me.botnfacturas.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.botnfacturas.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.botnfacturas.Location = New System.Drawing.Point(471, 4)
        Me.botnfacturas.Name = "botnfacturas"
        Me.botnfacturas.Size = New System.Drawing.Size(80, 34)
        Me.botnfacturas.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.botnfacturas.TabIndex = 51
        Me.botnfacturas.Text = "Nuevo Tiraje"
        '
        'texactualccf
        '
        Me.texactualccf.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.texactualccf.Location = New System.Drawing.Point(159, 320)
        Me.texactualccf.Margin = New System.Windows.Forms.Padding(4)
        Me.texactualccf.Name = "texactualccf"
        Me.texactualccf.Size = New System.Drawing.Size(132, 24)
        Me.texactualccf.TabIndex = 50
        '
        'texactualf
        '
        Me.texactualf.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.texactualf.Location = New System.Drawing.Point(159, 110)
        Me.texactualf.Margin = New System.Windows.Forms.Padding(4)
        Me.texactualf.Name = "texactualf"
        Me.texactualf.Size = New System.Drawing.Size(132, 24)
        Me.texactualf.TabIndex = 49
        '
        'progresccf
        '
        Me.progresccf.Location = New System.Drawing.Point(70, 258)
        Me.progresccf.Name = "progresccf"
        Me.progresccf.Size = New System.Drawing.Size(327, 23)
        Me.progresccf.TabIndex = 47
        Me.progresccf.Value = 50
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(222, 291)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(27, 18)
        Me.Label3.TabIndex = 46
        Me.Label3.Text = "AL"
        '
        'texhastaccf
        '
        Me.texhastaccf.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.texhastaccf.Location = New System.Drawing.Point(265, 288)
        Me.texhastaccf.Margin = New System.Windows.Forms.Padding(4)
        Me.texhastaccf.Name = "texhastaccf"
        Me.texhastaccf.Size = New System.Drawing.Size(132, 24)
        Me.texhastaccf.TabIndex = 45
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(19, 291)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 18)
        Me.Label4.TabIndex = 44
        Me.Label4.Text = "Tiraje"
        '
        'texdesdeccf
        '
        Me.texdesdeccf.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.texdesdeccf.Location = New System.Drawing.Point(70, 288)
        Me.texdesdeccf.Margin = New System.Windows.Forms.Padding(4)
        Me.texdesdeccf.Name = "texdesdeccf"
        Me.texdesdeccf.Size = New System.Drawing.Size(132, 24)
        Me.texdesdeccf.TabIndex = 43
        '
        'ReflectionLabel1
        '
        Me.ReflectionLabel1.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.ReflectionLabel1.BackgroundStyle.Class = ""
        Me.ReflectionLabel1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ReflectionLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReflectionLabel1.Location = New System.Drawing.Point(108, 214)
        Me.ReflectionLabel1.Margin = New System.Windows.Forms.Padding(4)
        Me.ReflectionLabel1.Name = "ReflectionLabel1"
        Me.ReflectionLabel1.Size = New System.Drawing.Size(244, 46)
        Me.ReflectionLabel1.TabIndex = 42
        Me.ReflectionLabel1.Text = "<b><font size=""+6""><i>Tiraje Actual de C.C.F</i><font color=""#B02B2C""></font></fo" & _
    "nt></b>"
        '
        'progresf
        '
        Me.progresf.Location = New System.Drawing.Point(61, 48)
        Me.progresf.Name = "progresf"
        Me.progresf.Size = New System.Drawing.Size(327, 23)
        Me.progresf.TabIndex = 41
        Me.progresf.Value = 75
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(213, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(27, 18)
        Me.Label2.TabIndex = 40
        Me.Label2.Text = "AL"
        '
        'texhastaf
        '
        Me.texhastaf.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.texhastaf.Location = New System.Drawing.Point(256, 78)
        Me.texhastaf.Margin = New System.Windows.Forms.Padding(4)
        Me.texhastaf.Name = "texhastaf"
        Me.texhastaf.Size = New System.Drawing.Size(132, 24)
        Me.texhastaf.TabIndex = 39
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(10, 81)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 18)
        Me.Label1.TabIndex = 38
        Me.Label1.Text = "Tiraje"
        '
        'texdedef
        '
        Me.texdedef.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.texdedef.Location = New System.Drawing.Point(61, 78)
        Me.texdedef.Margin = New System.Windows.Forms.Padding(4)
        Me.texdedef.Name = "texdedef"
        Me.texdedef.Size = New System.Drawing.Size(132, 24)
        Me.texdedef.TabIndex = 37
        '
        'ReflectionLabel9
        '
        Me.ReflectionLabel9.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.ReflectionLabel9.BackgroundStyle.Class = ""
        Me.ReflectionLabel9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ReflectionLabel9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReflectionLabel9.Location = New System.Drawing.Point(105, 4)
        Me.ReflectionLabel9.Margin = New System.Windows.Forms.Padding(4)
        Me.ReflectionLabel9.Name = "ReflectionLabel9"
        Me.ReflectionLabel9.Size = New System.Drawing.Size(244, 46)
        Me.ReflectionLabel9.TabIndex = 36
        Me.ReflectionLabel9.Text = "<b><font size=""+6""><i>Tiraje Actual de Facturas</i><font color=""#B02B2C""></font><" & _
    "/font></b>"
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape3, Me.LineShape2, Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(988, 375)
        Me.ShapeContainer1.TabIndex = 48
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape3
        '
        Me.LineShape3.Name = "LineShape3"
        Me.LineShape3.X1 = 568
        Me.LineShape3.X2 = 567
        Me.LineShape3.Y1 = -35
        Me.LineShape3.Y2 = 392
        '
        'LineShape2
        '
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.X1 = 455
        Me.LineShape2.X2 = 454
        Me.LineShape2.Y1 = -50
        Me.LineShape2.Y2 = 377
        '
        'LineShape1
        '
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = -2
        Me.LineShape1.X2 = 989
        Me.LineShape1.Y1 = 166
        Me.LineShape1.Y2 = 166
        '
        'TabItem1
        '
        Me.TabItem1.AttachedControl = Me.TabControlPanel1
        Me.TabItem1.Name = "TabItem1"
        Me.TabItem1.Text = "Control de Documentos"
        '
        'TabControlPanel2
        '
        Me.TabControlPanel2.Controls.Add(Me.GroupPanel1)
        Me.TabControlPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlPanel2.Location = New System.Drawing.Point(0, 26)
        Me.TabControlPanel2.Margin = New System.Windows.Forms.Padding(4)
        Me.TabControlPanel2.Name = "TabControlPanel2"
        Me.TabControlPanel2.Padding = New System.Windows.Forms.Padding(1)
        Me.TabControlPanel2.Size = New System.Drawing.Size(998, 407)
        Me.TabControlPanel2.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.TabControlPanel2.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.TabControlPanel2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.TabControlPanel2.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.TabControlPanel2.Style.BorderSide = CType(((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
            Or DevComponents.DotNetBar.eBorderSide.Bottom), DevComponents.DotNetBar.eBorderSide)
        Me.TabControlPanel2.Style.GradientAngle = 90
        Me.TabControlPanel2.TabIndex = 2
        Me.TabControlPanel2.TabItem = Me.TabItem2
        '
        'GroupPanel1
        '
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.ReflectionLabel4)
        Me.GroupPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupPanel1.Location = New System.Drawing.Point(1, 1)
        Me.GroupPanel1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(996, 405)
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
        'ReflectionLabel4
        '
        Me.ReflectionLabel4.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.ReflectionLabel4.BackgroundStyle.Class = ""
        Me.ReflectionLabel4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ReflectionLabel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReflectionLabel4.Location = New System.Drawing.Point(308, 153)
        Me.ReflectionLabel4.Margin = New System.Windows.Forms.Padding(4)
        Me.ReflectionLabel4.Name = "ReflectionLabel4"
        Me.ReflectionLabel4.Size = New System.Drawing.Size(338, 67)
        Me.ReflectionLabel4.TabIndex = 63
        Me.ReflectionLabel4.Text = "<b><font size=""+6""><i> COMING SOON !!!!!</i><font color=""#B02B2C""></font></font><" & _
    "/b>"
        '
        'TabItem2
        '
        Me.TabItem2.AttachedControl = Me.TabControlPanel2
        Me.TabItem2.Name = "TabItem2"
        Me.TabItem2.Text = "Productos e Impuestos"
        '
        'Configuraciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(575, 424)
        Me.Controls.Add(Me.TabControl1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Configuraciones"
        Me.Text = "Configuraciones"
        CType(Me.TabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabControlPanel1.ResumeLayout(False)
        Me.GroupPanel2.ResumeLayout(False)
        Me.GroupPanel2.PerformLayout()
        Me.grubfactura.ResumeLayout(False)
        Me.grubfactura.PerformLayout()
        Me.grubcomprobante.ResumeLayout(False)
        Me.grubcomprobante.PerformLayout()
        Me.TabControlPanel2.ResumeLayout(False)
        Me.GroupPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents texhastaf As System.Windows.Forms.TextBox
    Friend WithEvents texdedef As System.Windows.Forms.TextBox
    Friend WithEvents progresf As System.Windows.Forms.ProgressBar
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents texactualccf As System.Windows.Forms.TextBox
    Friend WithEvents texactualf As System.Windows.Forms.TextBox
    Friend WithEvents progresccf As System.Windows.Forms.ProgressBar
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents texhastaccf As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents texdesdeccf As System.Windows.Forms.TextBox
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape2 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape3 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents grubfactura As System.Windows.Forms.GroupBox
    Friend WithEvents bothechof As System.Windows.Forms.Button
    Friend WithEvents texndesdef As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents texnhastaf As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents grubcomprobante As System.Windows.Forms.GroupBox
    Friend WithEvents bothechoccf As System.Windows.Forms.Button
    Friend WithEvents texndesdeccf As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents texnhastaccf As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Private WithEvents TabControl1 As DevComponents.DotNetBar.TabControl
    Private WithEvents TabControlPanel1 As DevComponents.DotNetBar.TabControlPanel
    Private WithEvents TabItem1 As DevComponents.DotNetBar.TabItem
    Private WithEvents TabControlPanel2 As DevComponents.DotNetBar.TabControlPanel
    Private WithEvents TabItem2 As DevComponents.DotNetBar.TabItem
    Private WithEvents GroupPanel2 As DevComponents.DotNetBar.Controls.GroupPanel
    Private WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Private WithEvents ReflectionLabel9 As DevComponents.DotNetBar.Controls.ReflectionLabel
    Private WithEvents botnccf As DevComponents.DotNetBar.ButtonX
    Private WithEvents botnfacturas As DevComponents.DotNetBar.ButtonX
    Private WithEvents ReflectionLabel1 As DevComponents.DotNetBar.Controls.ReflectionLabel
    Private WithEvents ReflectionLabel2 As DevComponents.DotNetBar.Controls.ReflectionLabel
    Private WithEvents ReflectionLabel3 As DevComponents.DotNetBar.Controls.ReflectionLabel
    Private WithEvents ReflectionLabel4 As DevComponents.DotNetBar.Controls.ReflectionLabel
End Class
