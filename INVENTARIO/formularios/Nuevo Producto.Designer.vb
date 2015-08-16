<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Nuevo_Producto
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Nuevo_Producto))
        Me.lbcamposobligatorios = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.texcodigo = New System.Windows.Forms.TextBox()
        Me.texnombre = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.texdescripcion = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.texpreciounitario = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.texpreciopublico = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.texcantidad = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.texproveedor = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.texunidaddemedida = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.botguardar = New System.Windows.Forms.Button()
        Me.botsalir = New System.Windows.Forms.Button()
        Me.botborrar = New System.Windows.Forms.Button()
        Me.texcategoria = New System.Windows.Forms.TextBox()
        Me.lcat = New System.Windows.Forms.Label()
        Me.lcodigo = New System.Windows.Forms.Label()
        Me.lnombre = New System.Windows.Forms.Label()
        Me.ldescripcion = New System.Windows.Forms.Label()
        Me.lunitmed = New System.Windows.Forms.Label()
        Me.lproveedor = New System.Windows.Forms.Label()
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.ExpandablePanel1 = New DevComponents.DotNetBar.ExpandablePanel()
        Me.checfovial = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.checcotrans = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.checiva = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.picno = New System.Windows.Forms.PictureBox()
        Me.picsi = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupPanel1.SuspendLayout()
        Me.ExpandablePanel1.SuspendLayout()
        CType(Me.picno, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picsi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbcamposobligatorios
        '
        Me.lbcamposobligatorios.AutoSize = True
        Me.lbcamposobligatorios.BackColor = System.Drawing.Color.Transparent
        Me.lbcamposobligatorios.Location = New System.Drawing.Point(3, 6)
        Me.lbcamposobligatorios.Name = "lbcamposobligatorios"
        Me.lbcamposobligatorios.Size = New System.Drawing.Size(349, 16)
        Me.lbcamposobligatorios.TabIndex = 0
        Me.lbcamposobligatorios.Text = "Por favor llenar todos los campos que son obligatorios (*)"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(81, 80)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Codigo"
        '
        'texcodigo
        '
        Me.texcodigo.Location = New System.Drawing.Point(137, 80)
        Me.texcodigo.Name = "texcodigo"
        Me.texcodigo.Size = New System.Drawing.Size(82, 22)
        Me.texcodigo.TabIndex = 2
        '
        'texnombre
        '
        Me.texnombre.Location = New System.Drawing.Point(137, 108)
        Me.texnombre.Name = "texnombre"
        Me.texnombre.Size = New System.Drawing.Size(279, 22)
        Me.texnombre.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(76, 108)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Nombre"
        '
        'texdescripcion
        '
        Me.texdescripcion.Location = New System.Drawing.Point(137, 136)
        Me.texdescripcion.Name = "texdescripcion"
        Me.texdescripcion.Size = New System.Drawing.Size(279, 22)
        Me.texdescripcion.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(53, 136)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 16)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Descripcion"
        '
        'texpreciounitario
        '
        Me.texpreciounitario.Location = New System.Drawing.Point(137, 164)
        Me.texpreciounitario.Name = "texpreciounitario"
        Me.texpreciounitario.Size = New System.Drawing.Size(82, 22)
        Me.texpreciounitario.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(37, 164)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 16)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Precio Unitario"
        '
        'texpreciopublico
        '
        Me.texpreciopublico.Location = New System.Drawing.Point(137, 192)
        Me.texpreciopublico.Name = "texpreciopublico"
        Me.texpreciopublico.Size = New System.Drawing.Size(82, 22)
        Me.texpreciopublico.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(37, 192)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(95, 16)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Precio Publico"
        '
        'texcantidad
        '
        Me.texcantidad.Location = New System.Drawing.Point(137, 220)
        Me.texcantidad.Name = "texcantidad"
        Me.texcantidad.Size = New System.Drawing.Size(82, 22)
        Me.texcantidad.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(70, 220)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 16)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Cantidad"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(66, 51)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(67, 16)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Categoria"
        '
        'texproveedor
        '
        Me.texproveedor.Location = New System.Drawing.Point(469, 48)
        Me.texproveedor.Name = "texproveedor"
        Me.texproveedor.Size = New System.Drawing.Size(279, 22)
        Me.texproveedor.TabIndex = 16
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Location = New System.Drawing.Point(388, 48)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(72, 16)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Proveedor"
        '
        'texunidaddemedida
        '
        Me.texunidaddemedida.Location = New System.Drawing.Point(137, 248)
        Me.texunidaddemedida.Name = "texunidaddemedida"
        Me.texunidaddemedida.Size = New System.Drawing.Size(82, 22)
        Me.texunidaddemedida.TabIndex = 18
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Location = New System.Drawing.Point(13, 248)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(120, 16)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Unidad de Medida"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.botguardar)
        Me.GroupBox1.Controls.Add(Me.botsalir)
        Me.GroupBox1.Controls.Add(Me.botborrar)
        Me.GroupBox1.Location = New System.Drawing.Point(460, 189)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(329, 90)
        Me.GroupBox1.TabIndex = 19
        Me.GroupBox1.TabStop = False
        '
        'botguardar
        '
        Me.botguardar.Location = New System.Drawing.Point(6, 37)
        Me.botguardar.Name = "botguardar"
        Me.botguardar.Size = New System.Drawing.Size(87, 35)
        Me.botguardar.TabIndex = 2
        Me.botguardar.Text = "Guardar"
        Me.botguardar.UseVisualStyleBackColor = True
        '
        'botsalir
        '
        Me.botsalir.Location = New System.Drawing.Point(236, 38)
        Me.botsalir.Name = "botsalir"
        Me.botsalir.Size = New System.Drawing.Size(87, 35)
        Me.botsalir.TabIndex = 1
        Me.botsalir.Text = "Salir"
        Me.botsalir.UseVisualStyleBackColor = True
        '
        'botborrar
        '
        Me.botborrar.Location = New System.Drawing.Point(143, 37)
        Me.botborrar.Name = "botborrar"
        Me.botborrar.Size = New System.Drawing.Size(87, 35)
        Me.botborrar.TabIndex = 0
        Me.botborrar.Text = "Borrar"
        Me.botborrar.UseVisualStyleBackColor = True
        '
        'texcategoria
        '
        Me.texcategoria.Location = New System.Drawing.Point(137, 51)
        Me.texcategoria.Name = "texcategoria"
        Me.texcategoria.Size = New System.Drawing.Size(165, 22)
        Me.texcategoria.TabIndex = 20
        '
        'lcat
        '
        Me.lcat.AutoSize = True
        Me.lcat.BackColor = System.Drawing.Color.Transparent
        Me.lcat.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lcat.Location = New System.Drawing.Point(305, 47)
        Me.lcat.Name = "lcat"
        Me.lcat.Size = New System.Drawing.Size(16, 20)
        Me.lcat.TabIndex = 21
        Me.lcat.Text = "*"
        '
        'lcodigo
        '
        Me.lcodigo.AutoSize = True
        Me.lcodigo.BackColor = System.Drawing.Color.Transparent
        Me.lcodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lcodigo.Location = New System.Drawing.Point(225, 80)
        Me.lcodigo.Name = "lcodigo"
        Me.lcodigo.Size = New System.Drawing.Size(16, 20)
        Me.lcodigo.TabIndex = 22
        Me.lcodigo.Text = "*"
        '
        'lnombre
        '
        Me.lnombre.AutoSize = True
        Me.lnombre.BackColor = System.Drawing.Color.Transparent
        Me.lnombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnombre.Location = New System.Drawing.Point(419, 108)
        Me.lnombre.Name = "lnombre"
        Me.lnombre.Size = New System.Drawing.Size(16, 20)
        Me.lnombre.TabIndex = 23
        Me.lnombre.Text = "*"
        '
        'ldescripcion
        '
        Me.ldescripcion.AutoSize = True
        Me.ldescripcion.BackColor = System.Drawing.Color.Transparent
        Me.ldescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ldescripcion.Location = New System.Drawing.Point(419, 136)
        Me.ldescripcion.Name = "ldescripcion"
        Me.ldescripcion.Size = New System.Drawing.Size(16, 20)
        Me.ldescripcion.TabIndex = 24
        Me.ldescripcion.Text = "*"
        '
        'lunitmed
        '
        Me.lunitmed.AutoSize = True
        Me.lunitmed.BackColor = System.Drawing.Color.Transparent
        Me.lunitmed.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lunitmed.Location = New System.Drawing.Point(222, 245)
        Me.lunitmed.Name = "lunitmed"
        Me.lunitmed.Size = New System.Drawing.Size(16, 20)
        Me.lunitmed.TabIndex = 25
        Me.lunitmed.Text = "*"
        '
        'lproveedor
        '
        Me.lproveedor.AutoSize = True
        Me.lproveedor.BackColor = System.Drawing.Color.Transparent
        Me.lproveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lproveedor.Location = New System.Drawing.Point(751, 45)
        Me.lproveedor.Name = "lproveedor"
        Me.lproveedor.Size = New System.Drawing.Size(16, 20)
        Me.lproveedor.TabIndex = 26
        Me.lproveedor.Text = "*"
        '
        'GroupPanel1
        '
        Me.GroupPanel1.BackColor = System.Drawing.Color.Transparent
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.ExpandablePanel1)
        Me.GroupPanel1.Controls.Add(Me.GroupBox1)
        Me.GroupPanel1.Controls.Add(Me.lbcamposobligatorios)
        Me.GroupPanel1.Controls.Add(Me.lproveedor)
        Me.GroupPanel1.Controls.Add(Me.ldescripcion)
        Me.GroupPanel1.Controls.Add(Me.lunitmed)
        Me.GroupPanel1.Controls.Add(Me.lcat)
        Me.GroupPanel1.Controls.Add(Me.Label8)
        Me.GroupPanel1.Controls.Add(Me.lnombre)
        Me.GroupPanel1.Controls.Add(Me.Label7)
        Me.GroupPanel1.Controls.Add(Me.Label1)
        Me.GroupPanel1.Controls.Add(Me.Label2)
        Me.GroupPanel1.Controls.Add(Me.Label3)
        Me.GroupPanel1.Controls.Add(Me.Label9)
        Me.GroupPanel1.Controls.Add(Me.Label4)
        Me.GroupPanel1.Controls.Add(Me.Label5)
        Me.GroupPanel1.Controls.Add(Me.Label6)
        Me.GroupPanel1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.GroupPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupPanel1.Location = New System.Drawing.Point(0, 0)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(804, 297)
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
        Me.GroupPanel1.TabIndex = 39
        '
        'ExpandablePanel1
        '
        Me.ExpandablePanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.ExpandablePanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ExpandablePanel1.Controls.Add(Me.checfovial)
        Me.ExpandablePanel1.Controls.Add(Me.checcotrans)
        Me.ExpandablePanel1.Controls.Add(Me.checiva)
        Me.ExpandablePanel1.Expanded = False
        Me.ExpandablePanel1.ExpandedBounds = New System.Drawing.Rectangle(466, 83, 279, 100)
        Me.ExpandablePanel1.Location = New System.Drawing.Point(466, 83)
        Me.ExpandablePanel1.Name = "ExpandablePanel1"
        Me.ExpandablePanel1.Size = New System.Drawing.Size(279, 26)
        Me.ExpandablePanel1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.ExpandablePanel1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.ExpandablePanel1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.ExpandablePanel1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.ExpandablePanel1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.ExpandablePanel1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
        Me.ExpandablePanel1.Style.GradientAngle = 90
        Me.ExpandablePanel1.TabIndex = 27
        Me.ExpandablePanel1.TitleStyle.Alignment = System.Drawing.StringAlignment.Center
        Me.ExpandablePanel1.TitleStyle.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.ExpandablePanel1.TitleStyle.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.ExpandablePanel1.TitleStyle.Border = DevComponents.DotNetBar.eBorderType.RaisedInner
        Me.ExpandablePanel1.TitleStyle.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.ExpandablePanel1.TitleStyle.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.ExpandablePanel1.TitleStyle.GradientAngle = 90
        Me.ExpandablePanel1.TitleText = "Descuentos"
        '
        'checfovial
        '
        '
        '
        '
        Me.checfovial.BackgroundStyle.Class = ""
        Me.checfovial.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.checfovial.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.checfovial.Location = New System.Drawing.Point(174, 47)
        Me.checfovial.Name = "checfovial"
        Me.checfovial.Size = New System.Drawing.Size(89, 23)
        Me.checfovial.TabIndex = 3
        Me.checfovial.Text = "FOVIAL"
        '
        'checcotrans
        '
        '
        '
        '
        Me.checcotrans.BackgroundStyle.Class = ""
        Me.checcotrans.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.checcotrans.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.checcotrans.Location = New System.Drawing.Point(67, 47)
        Me.checcotrans.Name = "checcotrans"
        Me.checcotrans.Size = New System.Drawing.Size(89, 23)
        Me.checcotrans.TabIndex = 2
        Me.checcotrans.Text = "COTRANS"
        '
        'checiva
        '
        '
        '
        '
        Me.checiva.BackgroundStyle.Class = ""
        Me.checiva.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.checiva.Checked = True
        Me.checiva.CheckState = System.Windows.Forms.CheckState.Checked
        Me.checiva.CheckValue = "Y"
        Me.checiva.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.checiva.Location = New System.Drawing.Point(4, 47)
        Me.checiva.Name = "checiva"
        Me.checiva.Size = New System.Drawing.Size(57, 23)
        Me.checiva.TabIndex = 1
        Me.checiva.Text = "IVA"
        '
        'picno
        '
        Me.picno.Image = CType(resources.GetObject("picno.Image"), System.Drawing.Image)
        Me.picno.Location = New System.Drawing.Point(238, 79)
        Me.picno.Name = "picno"
        Me.picno.Size = New System.Drawing.Size(25, 25)
        Me.picno.TabIndex = 37
        Me.picno.TabStop = False
        '
        'picsi
        '
        Me.picsi.Image = CType(resources.GetObject("picsi.Image"), System.Drawing.Image)
        Me.picsi.Location = New System.Drawing.Point(238, 79)
        Me.picsi.Name = "picsi"
        Me.picsi.Size = New System.Drawing.Size(25, 25)
        Me.picsi.TabIndex = 38
        Me.picsi.TabStop = False
        '
        'Nuevo_Producto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(804, 297)
        Me.Controls.Add(Me.picno)
        Me.Controls.Add(Me.picsi)
        Me.Controls.Add(Me.lcodigo)
        Me.Controls.Add(Me.texcategoria)
        Me.Controls.Add(Me.texunidaddemedida)
        Me.Controls.Add(Me.texproveedor)
        Me.Controls.Add(Me.texcantidad)
        Me.Controls.Add(Me.texpreciopublico)
        Me.Controls.Add(Me.texpreciounitario)
        Me.Controls.Add(Me.texdescripcion)
        Me.Controls.Add(Me.texnombre)
        Me.Controls.Add(Me.texcodigo)
        Me.Controls.Add(Me.GroupPanel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Nuevo_Producto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registro de Productos"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupPanel1.ResumeLayout(False)
        Me.GroupPanel1.PerformLayout()
        Me.ExpandablePanel1.ResumeLayout(False)
        CType(Me.picno, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picsi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbcamposobligatorios As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents texcodigo As System.Windows.Forms.TextBox
    Friend WithEvents texnombre As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents texdescripcion As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents texpreciounitario As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents texpreciopublico As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents texcantidad As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents texproveedor As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents texunidaddemedida As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents botguardar As System.Windows.Forms.Button
    Friend WithEvents botsalir As System.Windows.Forms.Button
    Friend WithEvents botborrar As System.Windows.Forms.Button
    Friend WithEvents texcategoria As System.Windows.Forms.TextBox
    Friend WithEvents lcat As System.Windows.Forms.Label
    Friend WithEvents lcodigo As System.Windows.Forms.Label
    Friend WithEvents lnombre As System.Windows.Forms.Label
    Friend WithEvents ldescripcion As System.Windows.Forms.Label
    Friend WithEvents lunitmed As System.Windows.Forms.Label
    Friend WithEvents lproveedor As System.Windows.Forms.Label
    Friend WithEvents picno As System.Windows.Forms.PictureBox
    Friend WithEvents picsi As System.Windows.Forms.PictureBox
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents ExpandablePanel1 As DevComponents.DotNetBar.ExpandablePanel
    Friend WithEvents checfovial As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents checcotrans As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents checiva As DevComponents.DotNetBar.Controls.CheckBoxX
End Class
