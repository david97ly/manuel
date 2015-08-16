<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Combinar
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
        Me.texnombre = New System.Windows.Forms.TextBox()
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.todouno = New DevComponents.DotNetBar.ButtonX()
        Me.botremover = New DevComponents.DotNetBar.ButtonX()
        Me.botagregar = New DevComponents.DotNetBar.ButtonX()
        Me.DataGridViewX1 = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.existencias = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.provee = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.texproveedor = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.texexistencias = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.texprecio = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupPanel2 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX()
        Me.botaceptar = New DevComponents.DotNetBar.ButtonX()
        Me.texnunidad = New System.Windows.Forms.TextBox()
        Me.texncategoria = New System.Windows.Forms.TextBox()
        Me.texnexistencias = New System.Windows.Forms.TextBox()
        Me.texnpreciopublico = New System.Windows.Forms.TextBox()
        Me.texnprecio = New System.Windows.Forms.TextBox()
        Me.texnproveedor = New System.Windows.Forms.TextBox()
        Me.texndescripcion = New System.Windows.Forms.TextBox()
        Me.texnnombre = New System.Windows.Forms.TextBox()
        Me.texncodigo = New System.Windows.Forms.TextBox()
        Me.LabelX9 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX8 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX7 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX6 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.GroupPanel1.SuspendLayout()
        CType(Me.DataGridViewX1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'texnombre
        '
        Me.texnombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.texnombre.Location = New System.Drawing.Point(3, 26)
        Me.texnombre.Name = "texnombre"
        Me.texnombre.ReadOnly = True
        Me.texnombre.Size = New System.Drawing.Size(179, 26)
        Me.texnombre.TabIndex = 1
        '
        'GroupPanel1
        '
        Me.GroupPanel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.todouno)
        Me.GroupPanel1.Controls.Add(Me.botremover)
        Me.GroupPanel1.Controls.Add(Me.botagregar)
        Me.GroupPanel1.Controls.Add(Me.DataGridViewX1)
        Me.GroupPanel1.Controls.Add(Me.texproveedor)
        Me.GroupPanel1.Controls.Add(Me.Label4)
        Me.GroupPanel1.Controls.Add(Me.texexistencias)
        Me.GroupPanel1.Controls.Add(Me.Label3)
        Me.GroupPanel1.Controls.Add(Me.texprecio)
        Me.GroupPanel1.Controls.Add(Me.Label2)
        Me.GroupPanel1.Controls.Add(Me.Label1)
        Me.GroupPanel1.Controls.Add(Me.texnombre)
        Me.GroupPanel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupPanel1.Location = New System.Drawing.Point(12, 12)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(606, 435)
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
        Me.GroupPanel1.Text = "Productos a combinar"
        '
        'todouno
        '
        Me.todouno.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.todouno.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.todouno.Location = New System.Drawing.Point(461, 359)
        Me.todouno.Name = "todouno"
        Me.todouno.Size = New System.Drawing.Size(136, 43)
        Me.todouno.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.todouno.TabIndex = 13
        Me.todouno.Text = "Combinar"
        '
        'botremover
        '
        Me.botremover.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.botremover.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.botremover.Location = New System.Drawing.Point(3, 359)
        Me.botremover.Name = "botremover"
        Me.botremover.Size = New System.Drawing.Size(105, 43)
        Me.botremover.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.botremover.TabIndex = 11
        Me.botremover.Text = "Remover"
        '
        'botagregar
        '
        Me.botagregar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.botagregar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.botagregar.Location = New System.Drawing.Point(491, 20)
        Me.botagregar.Name = "botagregar"
        Me.botagregar.Size = New System.Drawing.Size(100, 32)
        Me.botagregar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.botagregar.TabIndex = 10
        Me.botagregar.Text = "Agregar"
        '
        'DataGridViewX1
        '
        Me.DataGridViewX1.AllowUserToAddRows = False
        Me.DataGridViewX1.AllowUserToDeleteRows = False
        Me.DataGridViewX1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DataGridViewX1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewX1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.codigo, Me.nombre, Me.precio, Me.existencias, Me.provee})
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewX1.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewX1.GridColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.DataGridViewX1.Location = New System.Drawing.Point(3, 58)
        Me.DataGridViewX1.Name = "DataGridViewX1"
        Me.DataGridViewX1.ReadOnly = True
        Me.DataGridViewX1.RowHeadersVisible = False
        Me.DataGridViewX1.Size = New System.Drawing.Size(588, 260)
        Me.DataGridViewX1.TabIndex = 9
        '
        'codigo
        '
        Me.codigo.HeaderText = "Codigo"
        Me.codigo.Name = "codigo"
        Me.codigo.ReadOnly = True
        Me.codigo.Width = 75
        '
        'nombre
        '
        Me.nombre.HeaderText = "Nombre"
        Me.nombre.Name = "nombre"
        Me.nombre.ReadOnly = True
        Me.nombre.Width = 150
        '
        'precio
        '
        Me.precio.HeaderText = "Precio"
        Me.precio.Name = "precio"
        Me.precio.ReadOnly = True
        '
        'existencias
        '
        Me.existencias.HeaderText = "Existencias"
        Me.existencias.Name = "existencias"
        Me.existencias.ReadOnly = True
        Me.existencias.Width = 110
        '
        'provee
        '
        Me.provee.HeaderText = "Proveedor"
        Me.provee.Name = "provee"
        Me.provee.ReadOnly = True
        Me.provee.Width = 150
        '
        'texproveedor
        '
        Me.texproveedor.Enabled = False
        Me.texproveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.texproveedor.Location = New System.Drawing.Point(371, 26)
        Me.texproveedor.Name = "texproveedor"
        Me.texproveedor.Size = New System.Drawing.Size(100, 26)
        Me.texproveedor.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(371, 5)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 20)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Proveedor"
        '
        'texexistencias
        '
        Me.texexistencias.Enabled = False
        Me.texexistencias.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.texexistencias.Location = New System.Drawing.Point(269, 26)
        Me.texexistencias.Name = "texexistencias"
        Me.texexistencias.Size = New System.Drawing.Size(71, 26)
        Me.texexistencias.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(265, 6)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 20)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Existencias"
        '
        'texprecio
        '
        Me.texprecio.Enabled = False
        Me.texprecio.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.texprecio.Location = New System.Drawing.Point(188, 26)
        Me.texprecio.Name = "texprecio"
        Me.texprecio.Size = New System.Drawing.Size(71, 26)
        Me.texprecio.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(188, 6)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Precio"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Nombre"
        '
        'GroupPanel2
        '
        Me.GroupPanel2.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel2.Controls.Add(Me.ButtonX1)
        Me.GroupPanel2.Controls.Add(Me.botaceptar)
        Me.GroupPanel2.Controls.Add(Me.texnunidad)
        Me.GroupPanel2.Controls.Add(Me.texncategoria)
        Me.GroupPanel2.Controls.Add(Me.texnexistencias)
        Me.GroupPanel2.Controls.Add(Me.texnpreciopublico)
        Me.GroupPanel2.Controls.Add(Me.texnprecio)
        Me.GroupPanel2.Controls.Add(Me.texnproveedor)
        Me.GroupPanel2.Controls.Add(Me.texndescripcion)
        Me.GroupPanel2.Controls.Add(Me.texnnombre)
        Me.GroupPanel2.Controls.Add(Me.texncodigo)
        Me.GroupPanel2.Controls.Add(Me.LabelX9)
        Me.GroupPanel2.Controls.Add(Me.LabelX8)
        Me.GroupPanel2.Controls.Add(Me.LabelX7)
        Me.GroupPanel2.Controls.Add(Me.LabelX6)
        Me.GroupPanel2.Controls.Add(Me.LabelX5)
        Me.GroupPanel2.Controls.Add(Me.LabelX4)
        Me.GroupPanel2.Controls.Add(Me.LabelX3)
        Me.GroupPanel2.Controls.Add(Me.LabelX2)
        Me.GroupPanel2.Controls.Add(Me.LabelX1)
        Me.GroupPanel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupPanel2.Location = New System.Drawing.Point(624, 12)
        Me.GroupPanel2.Name = "GroupPanel2"
        Me.GroupPanel2.Size = New System.Drawing.Size(320, 435)
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
        Me.GroupPanel2.TabIndex = 3
        Me.GroupPanel2.Text = "Producto combinado"
        '
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX1.Location = New System.Drawing.Point(3, 362)
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.Size = New System.Drawing.Size(82, 43)
        Me.ButtonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.VS2005
        Me.ButtonX1.TabIndex = 19
        Me.ButtonX1.Text = "Cancelar"
        '
        'botaceptar
        '
        Me.botaceptar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.botaceptar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.botaceptar.Location = New System.Drawing.Point(226, 362)
        Me.botaceptar.Name = "botaceptar"
        Me.botaceptar.Size = New System.Drawing.Size(85, 43)
        Me.botaceptar.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003
        Me.botaceptar.TabIndex = 18
        Me.botaceptar.Text = "Aceptar"
        '
        'texnunidad
        '
        Me.texnunidad.Location = New System.Drawing.Point(141, 275)
        Me.texnunidad.Name = "texnunidad"
        Me.texnunidad.Size = New System.Drawing.Size(121, 26)
        Me.texnunidad.TabIndex = 17
        '
        'texncategoria
        '
        Me.texncategoria.Location = New System.Drawing.Point(141, 243)
        Me.texncategoria.Name = "texncategoria"
        Me.texncategoria.Size = New System.Drawing.Size(158, 26)
        Me.texncategoria.TabIndex = 16
        '
        'texnexistencias
        '
        Me.texnexistencias.Location = New System.Drawing.Point(141, 211)
        Me.texnexistencias.Name = "texnexistencias"
        Me.texnexistencias.Size = New System.Drawing.Size(82, 26)
        Me.texnexistencias.TabIndex = 15
        '
        'texnpreciopublico
        '
        Me.texnpreciopublico.Location = New System.Drawing.Point(141, 179)
        Me.texnpreciopublico.Name = "texnpreciopublico"
        Me.texnpreciopublico.Size = New System.Drawing.Size(82, 26)
        Me.texnpreciopublico.TabIndex = 14
        '
        'texnprecio
        '
        Me.texnprecio.Location = New System.Drawing.Point(141, 147)
        Me.texnprecio.Name = "texnprecio"
        Me.texnprecio.Size = New System.Drawing.Size(82, 26)
        Me.texnprecio.TabIndex = 13
        '
        'texnproveedor
        '
        Me.texnproveedor.Location = New System.Drawing.Point(141, 115)
        Me.texnproveedor.Name = "texnproveedor"
        Me.texnproveedor.Size = New System.Drawing.Size(158, 26)
        Me.texnproveedor.TabIndex = 12
        '
        'texndescripcion
        '
        Me.texndescripcion.Location = New System.Drawing.Point(141, 83)
        Me.texndescripcion.Name = "texndescripcion"
        Me.texndescripcion.Size = New System.Drawing.Size(158, 26)
        Me.texndescripcion.TabIndex = 11
        '
        'texnnombre
        '
        Me.texnnombre.Location = New System.Drawing.Point(141, 51)
        Me.texnnombre.Name = "texnnombre"
        Me.texnnombre.Size = New System.Drawing.Size(158, 26)
        Me.texnnombre.TabIndex = 10
        '
        'texncodigo
        '
        Me.texncodigo.Location = New System.Drawing.Point(141, 20)
        Me.texncodigo.Name = "texncodigo"
        Me.texncodigo.Size = New System.Drawing.Size(82, 26)
        Me.texncodigo.TabIndex = 9
        '
        'LabelX9
        '
        Me.LabelX9.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX9.BackgroundStyle.Class = ""
        Me.LabelX9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX9.Location = New System.Drawing.Point(19, 180)
        Me.LabelX9.Name = "LabelX9"
        Me.LabelX9.Size = New System.Drawing.Size(116, 23)
        Me.LabelX9.TabIndex = 8
        Me.LabelX9.Text = "Precio Publico:"
        '
        'LabelX8
        '
        Me.LabelX8.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX8.BackgroundStyle.Class = ""
        Me.LabelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX8.Location = New System.Drawing.Point(3, 276)
        Me.LabelX8.Name = "LabelX8"
        Me.LabelX8.Size = New System.Drawing.Size(142, 23)
        Me.LabelX8.TabIndex = 7
        Me.LabelX8.Text = "Unidad de medida:"
        '
        'LabelX7
        '
        Me.LabelX7.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX7.BackgroundStyle.Class = ""
        Me.LabelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX7.Location = New System.Drawing.Point(52, 247)
        Me.LabelX7.Name = "LabelX7"
        Me.LabelX7.Size = New System.Drawing.Size(83, 23)
        Me.LabelX7.TabIndex = 6
        Me.LabelX7.Text = "Categoria:"
        '
        'LabelX6
        '
        Me.LabelX6.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX6.BackgroundStyle.Class = ""
        Me.LabelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX6.Location = New System.Drawing.Point(42, 212)
        Me.LabelX6.Name = "LabelX6"
        Me.LabelX6.Size = New System.Drawing.Size(93, 23)
        Me.LabelX6.TabIndex = 5
        Me.LabelX6.Text = "Existencias:"
        '
        'LabelX5
        '
        Me.LabelX5.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX5.BackgroundStyle.Class = ""
        Me.LabelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX5.Location = New System.Drawing.Point(83, 147)
        Me.LabelX5.Name = "LabelX5"
        Me.LabelX5.Size = New System.Drawing.Size(62, 23)
        Me.LabelX5.TabIndex = 4
        Me.LabelX5.Text = "Precio:"
        '
        'LabelX4
        '
        Me.LabelX4.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX4.BackgroundStyle.Class = ""
        Me.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX4.Location = New System.Drawing.Point(52, 115)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(93, 23)
        Me.LabelX4.TabIndex = 3
        Me.LabelX4.Text = "Proveedor:"
        '
        'LabelX3
        '
        Me.LabelX3.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX3.BackgroundStyle.Class = ""
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.Location = New System.Drawing.Point(42, 83)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(93, 23)
        Me.LabelX3.TabIndex = 2
        Me.LabelX3.Text = "Descripcion:"
        '
        'LabelX2
        '
        Me.LabelX2.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX2.BackgroundStyle.Class = ""
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Location = New System.Drawing.Point(73, 51)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(62, 23)
        Me.LabelX2.TabIndex = 1
        Me.LabelX2.Text = "Nombre:"
        '
        'LabelX1
        '
        Me.LabelX1.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX1.BackgroundStyle.Class = ""
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Location = New System.Drawing.Point(73, 23)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(62, 23)
        Me.LabelX1.TabIndex = 0
        Me.LabelX1.Text = "Codigo:"
        '
        'Combinar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(956, 459)
        Me.Controls.Add(Me.GroupPanel2)
        Me.Controls.Add(Me.GroupPanel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Combinar"
        Me.Text = "Combinar productos "
        Me.GroupPanel1.ResumeLayout(False)
        Me.GroupPanel1.PerformLayout()
        CType(Me.DataGridViewX1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupPanel2.ResumeLayout(False)
        Me.GroupPanel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents texnombre As System.Windows.Forms.TextBox
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents texproveedor As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents texexistencias As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents texprecio As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DataGridViewX1 As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents codigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents precio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents existencias As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents provee As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents botremover As DevComponents.DotNetBar.ButtonX
    Friend WithEvents botagregar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents GroupPanel2 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents texnunidad As System.Windows.Forms.TextBox
    Friend WithEvents texncategoria As System.Windows.Forms.TextBox
    Friend WithEvents texnexistencias As System.Windows.Forms.TextBox
    Friend WithEvents texnpreciopublico As System.Windows.Forms.TextBox
    Friend WithEvents texnprecio As System.Windows.Forms.TextBox
    Friend WithEvents texnproveedor As System.Windows.Forms.TextBox
    Friend WithEvents texndescripcion As System.Windows.Forms.TextBox
    Friend WithEvents texnnombre As System.Windows.Forms.TextBox
    Friend WithEvents texncodigo As System.Windows.Forms.TextBox
    Friend WithEvents LabelX9 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX8 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX7 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX6 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents todouno As DevComponents.DotNetBar.ButtonX
    Friend WithEvents botaceptar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonX
End Class
