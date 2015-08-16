<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Compras_realizadas
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.botnuevo = New System.Windows.Forms.Button()
        Me.botsalir = New System.Windows.Forms.Button()
        Me.botdetalle = New System.Windows.Forms.Button()
        Me.grubbusquedaprov = New System.Windows.Forms.GroupBox()
        Me.combotipo = New System.Windows.Forms.ComboBox()
        Me.checfecha = New System.Windows.Forms.CheckBox()
        Me.radiotipo = New System.Windows.Forms.RadioButton()
        Me.radiotodo = New System.Windows.Forms.RadioButton()
        Me.texbusqueda = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.botbuscar = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dt2 = New System.Windows.Forms.DateTimePicker()
        Me.dt1 = New System.Windows.Forms.DateTimePicker()
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.gridfacturacompras = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.numero = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombrproo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tipo1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fecha1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descuento1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.total1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.boteliminar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.grubbusquedaprov.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupPanel1.SuspendLayout()
        CType(Me.gridfacturacompras, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.boteliminar)
        Me.GroupBox1.Controls.Add(Me.botnuevo)
        Me.GroupBox1.Controls.Add(Me.botsalir)
        Me.GroupBox1.Controls.Add(Me.botdetalle)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 487)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(984, 78)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        '
        'botnuevo
        '
        Me.botnuevo.Location = New System.Drawing.Point(8, 25)
        Me.botnuevo.Margin = New System.Windows.Forms.Padding(4)
        Me.botnuevo.Name = "botnuevo"
        Me.botnuevo.Size = New System.Drawing.Size(124, 37)
        Me.botnuevo.TabIndex = 3
        Me.botnuevo.Text = "Nuevo"
        Me.botnuevo.UseVisualStyleBackColor = True
        '
        'botsalir
        '
        Me.botsalir.Location = New System.Drawing.Point(852, 25)
        Me.botsalir.Margin = New System.Windows.Forms.Padding(4)
        Me.botsalir.Name = "botsalir"
        Me.botsalir.Size = New System.Drawing.Size(124, 37)
        Me.botsalir.TabIndex = 2
        Me.botsalir.Text = "Salir"
        Me.botsalir.UseVisualStyleBackColor = True
        '
        'botdetalle
        '
        Me.botdetalle.Location = New System.Drawing.Point(140, 25)
        Me.botdetalle.Margin = New System.Windows.Forms.Padding(4)
        Me.botdetalle.Name = "botdetalle"
        Me.botdetalle.Size = New System.Drawing.Size(124, 37)
        Me.botdetalle.TabIndex = 0
        Me.botdetalle.Text = "Detalle"
        Me.botdetalle.UseVisualStyleBackColor = True
        '
        'grubbusquedaprov
        '
        Me.grubbusquedaprov.BackColor = System.Drawing.Color.Transparent
        Me.grubbusquedaprov.Controls.Add(Me.combotipo)
        Me.grubbusquedaprov.Controls.Add(Me.checfecha)
        Me.grubbusquedaprov.Controls.Add(Me.radiotipo)
        Me.grubbusquedaprov.Controls.Add(Me.radiotodo)
        Me.grubbusquedaprov.Controls.Add(Me.texbusqueda)
        Me.grubbusquedaprov.Controls.Add(Me.Label2)
        Me.grubbusquedaprov.Location = New System.Drawing.Point(14, 37)
        Me.grubbusquedaprov.Margin = New System.Windows.Forms.Padding(4)
        Me.grubbusquedaprov.Name = "grubbusquedaprov"
        Me.grubbusquedaprov.Padding = New System.Windows.Forms.Padding(4)
        Me.grubbusquedaprov.Size = New System.Drawing.Size(975, 50)
        Me.grubbusquedaprov.TabIndex = 10
        Me.grubbusquedaprov.TabStop = False
        '
        'combotipo
        '
        Me.combotipo.FormattingEnabled = True
        Me.combotipo.Items.AddRange(New Object() {"Factura", "Comprobante de Credito fiscal"})
        Me.combotipo.Location = New System.Drawing.Point(185, 15)
        Me.combotipo.Name = "combotipo"
        Me.combotipo.Size = New System.Drawing.Size(185, 24)
        Me.combotipo.TabIndex = 9
        Me.combotipo.Visible = False
        '
        'checfecha
        '
        Me.checfecha.AutoSize = True
        Me.checfecha.Location = New System.Drawing.Point(464, 18)
        Me.checfecha.Name = "checfecha"
        Me.checfecha.Size = New System.Drawing.Size(84, 20)
        Me.checfecha.TabIndex = 8
        Me.checfecha.Text = "Por fecha"
        Me.checfecha.UseVisualStyleBackColor = True
        '
        'radiotipo
        '
        Me.radiotipo.AutoSize = True
        Me.radiotipo.Location = New System.Drawing.Point(105, 17)
        Me.radiotipo.Margin = New System.Windows.Forms.Padding(4)
        Me.radiotipo.Name = "radiotipo"
        Me.radiotipo.Size = New System.Drawing.Size(72, 20)
        Me.radiotipo.TabIndex = 6
        Me.radiotipo.Text = "Por tipo"
        Me.radiotipo.UseVisualStyleBackColor = True
        '
        'radiotodo
        '
        Me.radiotodo.AutoSize = True
        Me.radiotodo.Checked = True
        Me.radiotodo.Location = New System.Drawing.Point(8, 17)
        Me.radiotodo.Margin = New System.Windows.Forms.Padding(4)
        Me.radiotodo.Name = "radiotodo"
        Me.radiotodo.Size = New System.Drawing.Size(66, 20)
        Me.radiotodo.TabIndex = 5
        Me.radiotodo.TabStop = True
        Me.radiotodo.Text = "Todos"
        Me.radiotodo.UseVisualStyleBackColor = True
        '
        'texbusqueda
        '
        Me.texbusqueda.Location = New System.Drawing.Point(850, 15)
        Me.texbusqueda.Margin = New System.Windows.Forms.Padding(4)
        Me.texbusqueda.Name = "texbusqueda"
        Me.texbusqueda.Size = New System.Drawing.Size(117, 22)
        Me.texbusqueda.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(772, 18)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 16)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Busqueda"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(386, 6)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(166, 20)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Listado de compras"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.botbuscar)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.dt2)
        Me.GroupBox2.Controls.Add(Me.dt1)
        Me.GroupBox2.Location = New System.Drawing.Point(14, 405)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(984, 75)
        Me.GroupBox2.TabIndex = 12
        Me.GroupBox2.TabStop = False
        '
        'botbuscar
        '
        Me.botbuscar.Location = New System.Drawing.Point(501, 31)
        Me.botbuscar.Margin = New System.Windows.Forms.Padding(4)
        Me.botbuscar.Name = "botbuscar"
        Me.botbuscar.Size = New System.Drawing.Size(124, 37)
        Me.botbuscar.TabIndex = 4
        Me.botbuscar.Text = "Buscar"
        Me.botbuscar.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(347, 18)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Hasta"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(91, 17)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Desde"
        '
        'dt2
        '
        Me.dt2.Location = New System.Drawing.Point(267, 36)
        Me.dt2.Name = "dt2"
        Me.dt2.Size = New System.Drawing.Size(200, 22)
        Me.dt2.TabIndex = 1
        '
        'dt1
        '
        Me.dt1.Location = New System.Drawing.Point(28, 36)
        Me.dt1.Name = "dt1"
        Me.dt1.Size = New System.Drawing.Size(200, 22)
        Me.dt1.TabIndex = 0
        '
        'GroupPanel1
        '
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.gridfacturacompras)
        Me.GroupPanel1.Controls.Add(Me.grubbusquedaprov)
        Me.GroupPanel1.Controls.Add(Me.GroupBox1)
        Me.GroupPanel1.Controls.Add(Me.GroupBox2)
        Me.GroupPanel1.Controls.Add(Me.Label1)
        Me.GroupPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupPanel1.Location = New System.Drawing.Point(0, 0)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(1013, 581)
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
        Me.GroupPanel1.TabIndex = 13
        '
        'gridfacturacompras
        '
        Me.gridfacturacompras.AllowUserToAddRows = False
        Me.gridfacturacompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridfacturacompras.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.numero, Me.Nombrproo, Me.tipo1, Me.fecha1, Me.descuento1, Me.total1})
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.gridfacturacompras.DefaultCellStyle = DataGridViewCellStyle1
        Me.gridfacturacompras.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.gridfacturacompras.Location = New System.Drawing.Point(22, 98)
        Me.gridfacturacompras.Name = "gridfacturacompras"
        Me.gridfacturacompras.RowHeadersVisible = False
        Me.gridfacturacompras.Size = New System.Drawing.Size(967, 301)
        Me.gridfacturacompras.TabIndex = 13
        '
        'numero
        '
        Me.numero.HeaderText = "Numero"
        Me.numero.Name = "numero"
        Me.numero.Width = 75
        '
        'Nombrproo
        '
        Me.Nombrproo.HeaderText = "Nombre Proveedor"
        Me.Nombrproo.Name = "Nombrproo"
        Me.Nombrproo.Width = 250
        '
        'tipo1
        '
        Me.tipo1.HeaderText = "Tipo"
        Me.tipo1.Name = "tipo1"
        Me.tipo1.Width = 250
        '
        'fecha1
        '
        Me.fecha1.HeaderText = "Fecha"
        Me.fecha1.Name = "fecha1"
        Me.fecha1.Width = 200
        '
        'descuento1
        '
        Me.descuento1.HeaderText = "Descuentos"
        Me.descuento1.Name = "descuento1"
        '
        'total1
        '
        Me.total1.HeaderText = "Total"
        Me.total1.Name = "total1"
        Me.total1.Width = 80
        '
        'boteliminar
        '
        Me.boteliminar.Location = New System.Drawing.Point(719, 25)
        Me.boteliminar.Margin = New System.Windows.Forms.Padding(4)
        Me.boteliminar.Name = "boteliminar"
        Me.boteliminar.Size = New System.Drawing.Size(124, 37)
        Me.boteliminar.TabIndex = 4
        Me.boteliminar.Text = "Eliminar"
        Me.boteliminar.UseVisualStyleBackColor = True
        '
        'Compras_realizadas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1013, 581)
        Me.Controls.Add(Me.GroupPanel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Compras_realizadas"
        Me.Opacity = 0.5R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Compras Realizadas"
        Me.GroupBox1.ResumeLayout(False)
        Me.grubbusquedaprov.ResumeLayout(False)
        Me.grubbusquedaprov.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupPanel1.ResumeLayout(False)
        Me.GroupPanel1.PerformLayout()
        CType(Me.gridfacturacompras, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents botnuevo As System.Windows.Forms.Button
    Friend WithEvents botsalir As System.Windows.Forms.Button
    Friend WithEvents botdetalle As System.Windows.Forms.Button
    Friend WithEvents grubbusquedaprov As System.Windows.Forms.GroupBox
    Friend WithEvents radiotipo As System.Windows.Forms.RadioButton
    Friend WithEvents radiotodo As System.Windows.Forms.RadioButton
    Friend WithEvents texbusqueda As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents botbuscar As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dt2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents dt1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents checfecha As System.Windows.Forms.CheckBox
    Friend WithEvents combotipo As System.Windows.Forms.ComboBox
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents gridfacturacompras As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents numero As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nombrproo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tipo1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fecha1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents descuento1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents total1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents boteliminar As System.Windows.Forms.Button
End Class
