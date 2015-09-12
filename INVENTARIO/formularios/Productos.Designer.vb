<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Productos
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.texbusquedacodigonombre = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.botanalizar = New DevComponents.DotNetBar.ButtonX()
        Me.botSeguir = New DevComponents.DotNetBar.ButtonX()
        Me.botsalir = New DevComponents.DotNetBar.ButtonX()
        Me.botseleccionar = New DevComponents.DotNetBar.ButtonX()
        Me.boteditar = New DevComponents.DotNetBar.ButtonX()
        Me.botdetalle = New DevComponents.DotNetBar.ButtonX()
        Me.botnuevo = New DevComponents.DotNetBar.ButtonX()
        Me.gridproductos = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.cod = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nomb = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.des = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.unimed = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pr = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.exis = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.HolaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Hola1ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Hola2ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.respaldar = New System.Windows.Forms.SaveFileDialog()
        Me.botacutalizar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.gridproductos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.texbusquedacodigonombre)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(10, 34)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(741, 63)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Busqueda"
        '
        'texbusquedacodigonombre
        '
        Me.texbusquedacodigonombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.texbusquedacodigonombre.Location = New System.Drawing.Point(197, 24)
        Me.texbusquedacodigonombre.Name = "texbusquedacodigonombre"
        Me.texbusquedacodigonombre.Size = New System.Drawing.Size(538, 31)
        Me.texbusquedacodigonombre.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(17, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(179, 25)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Codigo o Nombre"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.botanalizar)
        Me.GroupBox2.Controls.Add(Me.botSeguir)
        Me.GroupBox2.Controls.Add(Me.botsalir)
        Me.GroupBox2.Controls.Add(Me.botseleccionar)
        Me.GroupBox2.Controls.Add(Me.boteditar)
        Me.GroupBox2.Controls.Add(Me.botdetalle)
        Me.GroupBox2.Controls.Add(Me.botnuevo)
        Me.GroupBox2.Location = New System.Drawing.Point(9, 366)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(898, 63)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        '
        'botanalizar
        '
        Me.botanalizar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.botanalizar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.botanalizar.Location = New System.Drawing.Point(391, 20)
        Me.botanalizar.Margin = New System.Windows.Forms.Padding(2)
        Me.botanalizar.Name = "botanalizar"
        Me.botanalizar.Size = New System.Drawing.Size(82, 30)
        Me.botanalizar.Style = DevComponents.DotNetBar.eDotNetBarStyle.VS2005
        Me.botanalizar.TabIndex = 13
        Me.botanalizar.Text = "Analizar"
        '
        'botSeguir
        '
        Me.botSeguir.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.botSeguir.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.botSeguir.Location = New System.Drawing.Point(296, 20)
        Me.botSeguir.Margin = New System.Windows.Forms.Padding(2)
        Me.botSeguir.Name = "botSeguir"
        Me.botSeguir.Size = New System.Drawing.Size(82, 30)
        Me.botSeguir.Style = DevComponents.DotNetBar.eDotNetBarStyle.VS2005
        Me.botSeguir.TabIndex = 12
        Me.botSeguir.Text = "Seguir"
        '
        'botsalir
        '
        Me.botsalir.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.botsalir.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.botsalir.Location = New System.Drawing.Point(811, 20)
        Me.botsalir.Margin = New System.Windows.Forms.Padding(2)
        Me.botsalir.Name = "botsalir"
        Me.botsalir.Size = New System.Drawing.Size(82, 30)
        Me.botsalir.Style = DevComponents.DotNetBar.eDotNetBarStyle.VS2005
        Me.botsalir.TabIndex = 11
        Me.botsalir.Text = "Salir"
        '
        'botseleccionar
        '
        Me.botseleccionar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.botseleccionar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.botseleccionar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.botseleccionar.Location = New System.Drawing.Point(334, 13)
        Me.botseleccionar.Margin = New System.Windows.Forms.Padding(2)
        Me.botseleccionar.Name = "botseleccionar"
        Me.botseleccionar.Size = New System.Drawing.Size(102, 40)
        Me.botseleccionar.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003
        Me.botseleccionar.TabIndex = 10
        Me.botseleccionar.Text = "Seleccionar"
        Me.botseleccionar.Visible = False
        '
        'boteditar
        '
        Me.boteditar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.boteditar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.boteditar.Location = New System.Drawing.Point(198, 20)
        Me.boteditar.Margin = New System.Windows.Forms.Padding(2)
        Me.boteditar.Name = "boteditar"
        Me.boteditar.Size = New System.Drawing.Size(82, 30)
        Me.boteditar.Style = DevComponents.DotNetBar.eDotNetBarStyle.VS2005
        Me.boteditar.TabIndex = 9
        Me.boteditar.Text = "Editar"
        '
        'botdetalle
        '
        Me.botdetalle.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.botdetalle.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.botdetalle.Location = New System.Drawing.Point(104, 20)
        Me.botdetalle.Margin = New System.Windows.Forms.Padding(2)
        Me.botdetalle.Name = "botdetalle"
        Me.botdetalle.Size = New System.Drawing.Size(82, 30)
        Me.botdetalle.Style = DevComponents.DotNetBar.eDotNetBarStyle.VS2005
        Me.botdetalle.TabIndex = 8
        Me.botdetalle.Text = "Detalle"
        '
        'botnuevo
        '
        Me.botnuevo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.botnuevo.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.botnuevo.Location = New System.Drawing.Point(7, 20)
        Me.botnuevo.Margin = New System.Windows.Forms.Padding(2)
        Me.botnuevo.Name = "botnuevo"
        Me.botnuevo.Size = New System.Drawing.Size(82, 30)
        Me.botnuevo.Style = DevComponents.DotNetBar.eDotNetBarStyle.VS2005
        Me.botnuevo.TabIndex = 7
        Me.botnuevo.Text = "Nuevo"
        '
        'gridproductos
        '
        Me.gridproductos.AllowUserToAddRows = False
        Me.gridproductos.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.gridproductos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.gridproductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridproductos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cod, Me.Nomb, Me.des, Me.cate, Me.unimed, Me.pr, Me.exis})
        Me.gridproductos.ContextMenuStrip = Me.ContextMenuStrip1
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.gridproductos.DefaultCellStyle = DataGridViewCellStyle2
        Me.gridproductos.GridColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.gridproductos.Location = New System.Drawing.Point(9, 101)
        Me.gridproductos.Margin = New System.Windows.Forms.Padding(2)
        Me.gridproductos.Name = "gridproductos"
        Me.gridproductos.ReadOnly = True
        Me.gridproductos.RowHeadersVisible = False
        Me.gridproductos.Size = New System.Drawing.Size(1049, 260)
        Me.gridproductos.TabIndex = 11
        '
        'cod
        '
        Me.cod.HeaderText = "Codigo"
        Me.cod.Name = "cod"
        Me.cod.ReadOnly = True
        '
        'Nomb
        '
        Me.Nomb.HeaderText = "Nombre"
        Me.Nomb.Name = "Nomb"
        Me.Nomb.ReadOnly = True
        Me.Nomb.Width = 275
        '
        'des
        '
        Me.des.HeaderText = "Descripcion"
        Me.des.Name = "des"
        Me.des.ReadOnly = True
        Me.des.Width = 275
        '
        'cate
        '
        Me.cate.HeaderText = "Categoria"
        Me.cate.Name = "cate"
        Me.cate.ReadOnly = True
        Me.cate.Width = 150
        '
        'unimed
        '
        Me.unimed.HeaderText = "Unidad de medida"
        Me.unimed.Name = "unimed"
        Me.unimed.ReadOnly = True
        '
        'pr
        '
        Me.pr.HeaderText = "Precio"
        Me.pr.Name = "pr"
        Me.pr.ReadOnly = True
        Me.pr.Width = 75
        '
        'exis
        '
        Me.exis.HeaderText = "Existencias"
        Me.exis.Name = "exis"
        Me.exis.ReadOnly = True
        Me.exis.Width = 70
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HolaToolStripMenuItem, Me.Hola1ToolStripMenuItem, Me.Hola2ToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(111, 70)
        '
        'HolaToolStripMenuItem
        '
        Me.HolaToolStripMenuItem.Name = "HolaToolStripMenuItem"
        Me.HolaToolStripMenuItem.Size = New System.Drawing.Size(110, 22)
        Me.HolaToolStripMenuItem.Text = "Detalle"
        '
        'Hola1ToolStripMenuItem
        '
        Me.Hola1ToolStripMenuItem.Name = "Hola1ToolStripMenuItem"
        Me.Hola1ToolStripMenuItem.Size = New System.Drawing.Size(110, 22)
        Me.Hola1ToolStripMenuItem.Text = "Editar"
        '
        'Hola2ToolStripMenuItem
        '
        Me.Hola2ToolStripMenuItem.Name = "Hola2ToolStripMenuItem"
        Me.Hola2ToolStripMenuItem.Size = New System.Drawing.Size(110, 22)
        Me.Hola2ToolStripMenuItem.Text = "Seguir"
        '
        'botacutalizar
        '
        Me.botacutalizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.botacutalizar.Location = New System.Drawing.Point(963, 51)
        Me.botacutalizar.Name = "botacutalizar"
        Me.botacutalizar.Size = New System.Drawing.Size(95, 38)
        Me.botacutalizar.TabIndex = 12
        Me.botacutalizar.Text = "Actualizar"
        Me.botacutalizar.UseVisualStyleBackColor = True
        '
        'Productos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Beige
        Me.ClientSize = New System.Drawing.Size(1073, 438)
        Me.Controls.Add(Me.botacutalizar)
        Me.Controls.Add(Me.gridproductos)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Productos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Productos"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.gridproductos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents texbusquedacodigonombre As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents gridproductos As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents HolaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Hola1ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Hola2ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents respaldar As System.Windows.Forms.SaveFileDialog
    Friend WithEvents cod As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nomb As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents des As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents unimed As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents pr As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents exis As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents botsalir As DevComponents.DotNetBar.ButtonX
    Private WithEvents botseleccionar As DevComponents.DotNetBar.ButtonX
    Private WithEvents boteditar As DevComponents.DotNetBar.ButtonX
    Private WithEvents botdetalle As DevComponents.DotNetBar.ButtonX
    Private WithEvents botnuevo As DevComponents.DotNetBar.ButtonX
    Private WithEvents botSeguir As DevComponents.DotNetBar.ButtonX
    Private WithEvents botanalizar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents botacutalizar As System.Windows.Forms.Button
End Class
