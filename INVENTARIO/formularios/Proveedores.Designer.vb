<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Proveedores
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Proveedores))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.menuproveedores = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.mdetalle = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModificarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.grubbusquedaprov = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.radiocodigo = New System.Windows.Forms.RadioButton()
        Me.radionombre = New System.Windows.Forms.RadioButton()
        Me.texbusqueda = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.botseleccionar = New DevComponents.DotNetBar.ButtonX()
        Me.boteliminar = New DevComponents.DotNetBar.ButtonX()
        Me.botdetalle = New DevComponents.DotNetBar.ButtonX()
        Me.boteditar = New DevComponents.DotNetBar.ButtonX()
        Me.botnuevo = New DevComponents.DotNetBar.ButtonX()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.gridproveedores = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.co = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nomp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tip = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.direccion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.menuproveedores.SuspendLayout()
        Me.grubbusquedaprov.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridproveedores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'menuproveedores
        '
        Me.menuproveedores.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mdetalle, Me.EliminarToolStripMenuItem, Me.ModificarToolStripMenuItem})
        Me.menuproveedores.Name = "menuproveedores"
        Me.menuproveedores.Size = New System.Drawing.Size(126, 70)
        '
        'mdetalle
        '
        Me.mdetalle.Name = "mdetalle"
        Me.mdetalle.Size = New System.Drawing.Size(125, 22)
        Me.mdetalle.Text = "Detalle"
        '
        'EliminarToolStripMenuItem
        '
        Me.EliminarToolStripMenuItem.Name = "EliminarToolStripMenuItem"
        Me.EliminarToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.EliminarToolStripMenuItem.Text = "Eliminar"
        '
        'ModificarToolStripMenuItem
        '
        Me.ModificarToolStripMenuItem.Name = "ModificarToolStripMenuItem"
        Me.ModificarToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.ModificarToolStripMenuItem.Text = "Modificar"
        '
        'grubbusquedaprov
        '
        Me.grubbusquedaprov.BackColor = System.Drawing.Color.Transparent
        Me.grubbusquedaprov.Controls.Add(Me.GroupBox2)
        Me.grubbusquedaprov.Controls.Add(Me.texbusqueda)
        Me.grubbusquedaprov.Controls.Add(Me.Label2)
        Me.grubbusquedaprov.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grubbusquedaprov.Location = New System.Drawing.Point(4, 72)
        Me.grubbusquedaprov.Margin = New System.Windows.Forms.Padding(4)
        Me.grubbusquedaprov.Name = "grubbusquedaprov"
        Me.grubbusquedaprov.Padding = New System.Windows.Forms.Padding(4)
        Me.grubbusquedaprov.Size = New System.Drawing.Size(707, 76)
        Me.grubbusquedaprov.TabIndex = 2
        Me.grubbusquedaprov.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.radiocodigo)
        Me.GroupBox2.Controls.Add(Me.radionombre)
        Me.GroupBox2.Location = New System.Drawing.Point(233, 7)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(229, 35)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        '
        'radiocodigo
        '
        Me.radiocodigo.AutoSize = True
        Me.radiocodigo.Checked = True
        Me.radiocodigo.Location = New System.Drawing.Point(8, 12)
        Me.radiocodigo.Margin = New System.Windows.Forms.Padding(5)
        Me.radiocodigo.Name = "radiocodigo"
        Me.radiocodigo.Size = New System.Drawing.Size(77, 24)
        Me.radiocodigo.TabIndex = 7
        Me.radiocodigo.TabStop = True
        Me.radiocodigo.Text = "Codigo"
        Me.radiocodigo.UseVisualStyleBackColor = True
        '
        'radionombre
        '
        Me.radionombre.AutoSize = True
        Me.radionombre.Location = New System.Drawing.Point(146, 12)
        Me.radionombre.Margin = New System.Windows.Forms.Padding(5)
        Me.radionombre.Name = "radionombre"
        Me.radionombre.Size = New System.Drawing.Size(83, 24)
        Me.radionombre.TabIndex = 6
        Me.radionombre.Text = "Nombre"
        Me.radionombre.UseVisualStyleBackColor = True
        '
        'texbusqueda
        '
        Me.texbusqueda.Location = New System.Drawing.Point(94, 43)
        Me.texbusqueda.Margin = New System.Windows.Forms.Padding(4)
        Me.texbusqueda.Name = "texbusqueda"
        Me.texbusqueda.Size = New System.Drawing.Size(597, 26)
        Me.texbusqueda.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(4, 46)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 20)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Busqueda"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.botseleccionar)
        Me.GroupBox1.Controls.Add(Me.boteliminar)
        Me.GroupBox1.Controls.Add(Me.botdetalle)
        Me.GroupBox1.Controls.Add(Me.boteditar)
        Me.GroupBox1.Controls.Add(Me.botnuevo)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(5, 380)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(707, 75)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        '
        'botseleccionar
        '
        Me.botseleccionar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.botseleccionar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.botseleccionar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.botseleccionar.ForeColor = System.Drawing.Color.Blue
        Me.botseleccionar.Location = New System.Drawing.Point(298, 26)
        Me.botseleccionar.Name = "botseleccionar"
        Me.botseleccionar.Size = New System.Drawing.Size(115, 40)
        Me.botseleccionar.Style = DevComponents.DotNetBar.eDotNetBarStyle.VS2005
        Me.botseleccionar.TabIndex = 10
        Me.botseleccionar.Text = "Seleccionar"
        '
        'boteliminar
        '
        Me.boteliminar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.boteliminar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.boteliminar.Location = New System.Drawing.Point(616, 24)
        Me.boteliminar.Name = "boteliminar"
        Me.boteliminar.Size = New System.Drawing.Size(84, 35)
        Me.boteliminar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.boteliminar.TabIndex = 9
        Me.boteliminar.Text = "Eliminar"
        '
        'botdetalle
        '
        Me.botdetalle.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.botdetalle.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.botdetalle.Location = New System.Drawing.Point(208, 24)
        Me.botdetalle.Name = "botdetalle"
        Me.botdetalle.Size = New System.Drawing.Size(84, 35)
        Me.botdetalle.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.botdetalle.TabIndex = 8
        Me.botdetalle.Text = "Detalle"
        '
        'boteditar
        '
        Me.boteditar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.boteditar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.boteditar.Location = New System.Drawing.Point(118, 24)
        Me.boteditar.Name = "boteditar"
        Me.boteditar.Size = New System.Drawing.Size(84, 35)
        Me.boteditar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.boteditar.TabIndex = 7
        Me.boteditar.Text = "Modificar"
        '
        'botnuevo
        '
        Me.botnuevo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.botnuevo.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.botnuevo.Location = New System.Drawing.Point(28, 24)
        Me.botnuevo.Name = "botnuevo"
        Me.botnuevo.Size = New System.Drawing.Size(84, 35)
        Me.botnuevo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.botnuevo.TabIndex = 6
        Me.botnuevo.Text = "Nuevo"
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(668, 10)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(41, 42)
        Me.PictureBox3.TabIndex = 10
        Me.PictureBox3.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(658, 1)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(65, 64)
        Me.PictureBox4.TabIndex = 11
        Me.PictureBox4.TabStop = False
        Me.PictureBox4.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(146, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(351, 25)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "REGISTRO DE PROVEEDORES"
        '
        'gridproveedores
        '
        Me.gridproveedores.AllowUserToAddRows = False
        Me.gridproveedores.AllowUserToDeleteRows = False
        Me.gridproveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridproveedores.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.co, Me.nomp, Me.tip, Me.direccion})
        Me.gridproveedores.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.gridproveedores.DefaultCellStyle = DataGridViewCellStyle1
        Me.gridproveedores.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.gridproveedores.Location = New System.Drawing.Point(12, 155)
        Me.gridproveedores.Name = "gridproveedores"
        Me.gridproveedores.ReadOnly = True
        Me.gridproveedores.RowHeadersVisible = False
        Me.gridproveedores.Size = New System.Drawing.Size(693, 218)
        Me.gridproveedores.TabIndex = 22
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
        Me.nomp.HeaderText = "Nombre del Proveedor"
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
        'Proveedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(724, 468)
        Me.Controls.Add(Me.gridproveedores)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.grubbusquedaprov)
        Me.Controls.Add(Me.PictureBox4)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Proveedores"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Proveedores"
        Me.menuproveedores.ResumeLayout(False)
        Me.grubbusquedaprov.ResumeLayout(False)
        Me.grubbusquedaprov.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridproveedores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents menuproveedores As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents mdetalle As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EliminarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModificarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents grubbusquedaprov As System.Windows.Forms.GroupBox
    Friend WithEvents texbusqueda As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents radiocodigo As System.Windows.Forms.RadioButton
    Friend WithEvents radionombre As System.Windows.Forms.RadioButton
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents gridproveedores As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents co As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nomp As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tip As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents direccion As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents botseleccionar As DevComponents.DotNetBar.ButtonX
    Private WithEvents boteliminar As DevComponents.DotNetBar.ButtonX
    Private WithEvents botdetalle As DevComponents.DotNetBar.ButtonX
    Private WithEvents boteditar As DevComponents.DotNetBar.ButtonX
    Private WithEvents botnuevo As DevComponents.DotNetBar.ButtonX
End Class
