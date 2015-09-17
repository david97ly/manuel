<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Clientes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Clientes))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.botdetalle = New DevComponents.DotNetBar.ButtonX()
        Me.boteliminar = New DevComponents.DotNetBar.ButtonX()
        Me.boteditar = New DevComponents.DotNetBar.ButtonX()
        Me.botseleccionar = New DevComponents.DotNetBar.ButtonX()
        Me.botnuevo = New DevComponents.DotNetBar.ButtonX()
        Me.grubbusquedaprov = New System.Windows.Forms.GroupBox()
        Me.radiojuridico = New System.Windows.Forms.RadioButton()
        Me.radionatural = New System.Windows.Forms.RadioButton()
        Me.texbusqueda = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.gridclientes = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.co = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nomp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tip = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.direccion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.grubbusquedaprov.SuspendLayout()
        CType(Me.gridclientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.botdetalle)
        Me.GroupBox1.Controls.Add(Me.boteliminar)
        Me.GroupBox1.Controls.Add(Me.boteditar)
        Me.GroupBox1.Controls.Add(Me.botseleccionar)
        Me.GroupBox1.Controls.Add(Me.botnuevo)
        Me.GroupBox1.Location = New System.Drawing.Point(0, 428)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(5)
        Me.GroupBox1.Size = New System.Drawing.Size(747, 84)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        '
        'botdetalle
        '
        Me.botdetalle.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.botdetalle.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.botdetalle.Location = New System.Drawing.Point(196, 23)
        Me.botdetalle.Name = "botdetalle"
        Me.botdetalle.Size = New System.Drawing.Size(86, 34)
        Me.botdetalle.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.botdetalle.TabIndex = 10
        Me.botdetalle.Text = "Detalle"
        '
        'boteliminar
        '
        Me.boteliminar.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton
        Me.boteliminar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.boteliminar.Location = New System.Drawing.Point(631, 25)
        Me.boteliminar.Name = "boteliminar"
        Me.boteliminar.Size = New System.Drawing.Size(86, 34)
        Me.boteliminar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.boteliminar.TabIndex = 11
        Me.boteliminar.Text = "Eliminar"
        '
        'boteditar
        '
        Me.boteditar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.boteditar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.boteditar.Location = New System.Drawing.Point(104, 23)
        Me.boteditar.Name = "boteditar"
        Me.boteditar.Size = New System.Drawing.Size(86, 34)
        Me.boteditar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.boteditar.TabIndex = 9
        Me.boteditar.Text = "Editar"
        '
        'botseleccionar
        '
        Me.botseleccionar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.botseleccionar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.botseleccionar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.botseleccionar.Location = New System.Drawing.Point(316, 23)
        Me.botseleccionar.Name = "botseleccionar"
        Me.botseleccionar.Size = New System.Drawing.Size(128, 49)
        Me.botseleccionar.Style = DevComponents.DotNetBar.eDotNetBarStyle.VS2005
        Me.botseleccionar.TabIndex = 12
        Me.botseleccionar.Text = "Seleccionar"
        Me.botseleccionar.Visible = False
        '
        'botnuevo
        '
        Me.botnuevo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.botnuevo.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.botnuevo.Location = New System.Drawing.Point(12, 23)
        Me.botnuevo.Name = "botnuevo"
        Me.botnuevo.Size = New System.Drawing.Size(86, 34)
        Me.botnuevo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.botnuevo.TabIndex = 6
        Me.botnuevo.Text = "Nuevo"
        '
        'grubbusquedaprov
        '
        Me.grubbusquedaprov.BackColor = System.Drawing.Color.Transparent
        Me.grubbusquedaprov.Controls.Add(Me.radiojuridico)
        Me.grubbusquedaprov.Controls.Add(Me.radionatural)
        Me.grubbusquedaprov.Controls.Add(Me.texbusqueda)
        Me.grubbusquedaprov.Controls.Add(Me.Label2)
        Me.grubbusquedaprov.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grubbusquedaprov.Location = New System.Drawing.Point(12, 54)
        Me.grubbusquedaprov.Margin = New System.Windows.Forms.Padding(5)
        Me.grubbusquedaprov.Name = "grubbusquedaprov"
        Me.grubbusquedaprov.Padding = New System.Windows.Forms.Padding(5)
        Me.grubbusquedaprov.Size = New System.Drawing.Size(710, 87)
        Me.grubbusquedaprov.TabIndex = 6
        Me.grubbusquedaprov.TabStop = False
        '
        'radiojuridico
        '
        Me.radiojuridico.AutoSize = True
        Me.radiojuridico.Checked = True
        Me.radiojuridico.Location = New System.Drawing.Point(5, 29)
        Me.radiojuridico.Margin = New System.Windows.Forms.Padding(5)
        Me.radiojuridico.Name = "radiojuridico"
        Me.radiojuridico.Size = New System.Drawing.Size(81, 24)
        Me.radiojuridico.TabIndex = 4
        Me.radiojuridico.TabStop = True
        Me.radiojuridico.Text = "Juridico"
        Me.radiojuridico.UseVisualStyleBackColor = True
        '
        'radionatural
        '
        Me.radionatural.AutoSize = True
        Me.radionatural.Location = New System.Drawing.Point(100, 29)
        Me.radionatural.Margin = New System.Windows.Forms.Padding(5)
        Me.radionatural.Name = "radionatural"
        Me.radionatural.Size = New System.Drawing.Size(78, 24)
        Me.radionatural.TabIndex = 3
        Me.radionatural.Text = "Natural"
        Me.radionatural.UseVisualStyleBackColor = True
        '
        'texbusqueda
        '
        Me.texbusqueda.Location = New System.Drawing.Point(463, 55)
        Me.texbusqueda.Margin = New System.Windows.Forms.Padding(5)
        Me.texbusqueda.Name = "texbusqueda"
        Me.texbusqueda.Size = New System.Drawing.Size(237, 26)
        Me.texbusqueda.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(381, 59)
        Me.Label2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 20)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Busqueda"
        '
        'gridclientes
        '
        Me.gridclientes.AllowUserToAddRows = False
        Me.gridclientes.AllowUserToDeleteRows = False
        Me.gridclientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridclientes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.co, Me.nomp, Me.tip, Me.direccion})
        Me.gridclientes.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.gridclientes.DefaultCellStyle = DataGridViewCellStyle1
        Me.gridclientes.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.gridclientes.Location = New System.Drawing.Point(12, 158)
        Me.gridclientes.Name = "gridclientes"
        Me.gridclientes.ReadOnly = True
        Me.gridclientes.RowHeadersVisible = False
        Me.gridclientes.Size = New System.Drawing.Size(705, 262)
        Me.gridclientes.TabIndex = 8
        '
        'co
        '
        Me.co.Frozen = True
        Me.co.HeaderText = "Codigo"
        Me.co.Name = "co"
        Me.co.ReadOnly = True
        Me.co.Width = 75
        '
        'nomp
        '
        Me.nomp.Frozen = True
        Me.nomp.HeaderText = "Nombre del Cliente"
        Me.nomp.Name = "nomp"
        Me.nomp.ReadOnly = True
        Me.nomp.Width = 225
        '
        'tip
        '
        Me.tip.Frozen = True
        Me.tip.HeaderText = "Telefono"
        Me.tip.Name = "tip"
        Me.tip.ReadOnly = True
        Me.tip.Width = 150
        '
        'direccion
        '
        Me.direccion.Frozen = True
        Me.direccion.HeaderText = "Direccion"
        Me.direccion.Name = "direccion"
        Me.direccion.ReadOnly = True
        Me.direccion.Width = 250
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(191, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(292, 25)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "REGISTRO DE CLIENTES"
        '
        'Clientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(744, 512)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.gridclientes)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.grubbusquedaprov)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Clientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Clientes"
        Me.GroupBox1.ResumeLayout(False)
        Me.grubbusquedaprov.ResumeLayout(False)
        Me.grubbusquedaprov.PerformLayout()
        CType(Me.gridclientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents grubbusquedaprov As System.Windows.Forms.GroupBox
    Friend WithEvents radiojuridico As System.Windows.Forms.RadioButton
    Friend WithEvents radionatural As System.Windows.Forms.RadioButton
    Friend WithEvents texbusqueda As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents gridclientes As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents co As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nomp As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tip As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents direccion As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents botdetalle As DevComponents.DotNetBar.ButtonX
    Private WithEvents boteliminar As DevComponents.DotNetBar.ButtonX
    Private WithEvents boteditar As DevComponents.DotNetBar.ButtonX
    Private WithEvents botseleccionar As DevComponents.DotNetBar.ButtonX
    Private WithEvents botnuevo As DevComponents.DotNetBar.ButtonX
End Class
