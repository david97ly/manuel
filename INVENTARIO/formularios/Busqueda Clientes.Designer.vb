<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Busqueda_Clientes
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.botnuevo = New System.Windows.Forms.Button()
        Me.botsalir = New System.Windows.Forms.Button()
        Me.botmodificar = New System.Windows.Forms.Button()
        Me.botdetalle = New System.Windows.Forms.Button()
        Me.grubbusquedaprov = New System.Windows.Forms.GroupBox()
        Me.radiojuridico = New System.Windows.Forms.RadioButton()
        Me.radionatural = New System.Windows.Forms.RadioButton()
        Me.radiotodo = New System.Windows.Forms.RadioButton()
        Me.texbusqueda = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.gridclientes = New System.Windows.Forms.DataGridView()
        Me.cod = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Propietario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.telefono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.empresa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.grubbusquedaprov.SuspendLayout()
        CType(Me.gridclientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.botnuevo)
        Me.GroupBox1.Controls.Add(Me.botsalir)
        Me.GroupBox1.Controls.Add(Me.botmodificar)
        Me.GroupBox1.Controls.Add(Me.botdetalle)
        Me.GroupBox1.Location = New System.Drawing.Point(165, 367)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(719, 78)
        Me.GroupBox1.TabIndex = 7
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
        Me.botsalir.Location = New System.Drawing.Point(577, 25)
        Me.botsalir.Margin = New System.Windows.Forms.Padding(4)
        Me.botsalir.Name = "botsalir"
        Me.botsalir.Size = New System.Drawing.Size(124, 37)
        Me.botsalir.TabIndex = 2
        Me.botsalir.Text = "Salir"
        Me.botsalir.UseVisualStyleBackColor = True
        '
        'botmodificar
        '
        Me.botmodificar.Location = New System.Drawing.Point(139, 25)
        Me.botmodificar.Margin = New System.Windows.Forms.Padding(4)
        Me.botmodificar.Name = "botmodificar"
        Me.botmodificar.Size = New System.Drawing.Size(124, 37)
        Me.botmodificar.TabIndex = 1
        Me.botmodificar.Text = "Modificar"
        Me.botmodificar.UseVisualStyleBackColor = True
        '
        'botdetalle
        '
        Me.botdetalle.Location = New System.Drawing.Point(271, 25)
        Me.botdetalle.Margin = New System.Windows.Forms.Padding(4)
        Me.botdetalle.Name = "botdetalle"
        Me.botdetalle.Size = New System.Drawing.Size(124, 37)
        Me.botdetalle.TabIndex = 0
        Me.botdetalle.Text = "Detalle"
        Me.botdetalle.UseVisualStyleBackColor = True
        '
        'grubbusquedaprov
        '
        Me.grubbusquedaprov.Controls.Add(Me.radiojuridico)
        Me.grubbusquedaprov.Controls.Add(Me.radionatural)
        Me.grubbusquedaprov.Controls.Add(Me.radiotodo)
        Me.grubbusquedaprov.Controls.Add(Me.texbusqueda)
        Me.grubbusquedaprov.Controls.Add(Me.Label2)
        Me.grubbusquedaprov.Location = New System.Drawing.Point(16, 46)
        Me.grubbusquedaprov.Margin = New System.Windows.Forms.Padding(4)
        Me.grubbusquedaprov.Name = "grubbusquedaprov"
        Me.grubbusquedaprov.Padding = New System.Windows.Forms.Padding(4)
        Me.grubbusquedaprov.Size = New System.Drawing.Size(869, 50)
        Me.grubbusquedaprov.TabIndex = 6
        Me.grubbusquedaprov.TabStop = False
        '
        'radiojuridico
        '
        Me.radiojuridico.AutoSize = True
        Me.radiojuridico.Location = New System.Drawing.Point(223, 17)
        Me.radiojuridico.Margin = New System.Windows.Forms.Padding(4)
        Me.radiojuridico.Name = "radiojuridico"
        Me.radiojuridico.Size = New System.Drawing.Size(73, 20)
        Me.radiojuridico.TabIndex = 7
        Me.radiojuridico.Text = "Juridico"
        Me.radiojuridico.UseVisualStyleBackColor = True
        '
        'radionatural
        '
        Me.radionatural.AutoSize = True
        Me.radionatural.Location = New System.Drawing.Point(105, 17)
        Me.radionatural.Margin = New System.Windows.Forms.Padding(4)
        Me.radionatural.Name = "radionatural"
        Me.radionatural.Size = New System.Drawing.Size(69, 20)
        Me.radionatural.TabIndex = 6
        Me.radionatural.Text = "Natural"
        Me.radionatural.UseVisualStyleBackColor = True
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
        Me.texbusqueda.Location = New System.Drawing.Point(657, 20)
        Me.texbusqueda.Margin = New System.Windows.Forms.Padding(4)
        Me.texbusqueda.Name = "texbusqueda"
        Me.texbusqueda.Size = New System.Drawing.Size(172, 22)
        Me.texbusqueda.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(577, 22)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 16)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Busqueda"
        '
        'gridclientes
        '
        Me.gridclientes.AllowUserToDeleteRows = False
        Me.gridclientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridclientes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cod, Me.nombre, Me.Propietario, Me.telefono, Me.tipo, Me.empresa})
        Me.gridclientes.Location = New System.Drawing.Point(16, 103)
        Me.gridclientes.Margin = New System.Windows.Forms.Padding(4)
        Me.gridclientes.MultiSelect = False
        Me.gridclientes.Name = "gridclientes"
        Me.gridclientes.ReadOnly = True
        Me.gridclientes.RowHeadersVisible = False
        Me.gridclientes.Size = New System.Drawing.Size(872, 256)
        Me.gridclientes.TabIndex = 5
        '
        'cod
        '
        Me.cod.Frozen = True
        Me.cod.HeaderText = "Codigo"
        Me.cod.Name = "cod"
        Me.cod.ReadOnly = True
        Me.cod.Width = 75
        '
        'nombre
        '
        Me.nombre.Frozen = True
        Me.nombre.HeaderText = "Nombre Proveedor"
        Me.nombre.Name = "nombre"
        Me.nombre.ReadOnly = True
        Me.nombre.Width = 200
        '
        'Propietario
        '
        Me.Propietario.Frozen = True
        Me.Propietario.HeaderText = "Propietario"
        Me.Propietario.Name = "Propietario"
        Me.Propietario.ReadOnly = True
        Me.Propietario.Width = 150
        '
        'telefono
        '
        Me.telefono.Frozen = True
        Me.telefono.HeaderText = "Telefono"
        Me.telefono.Name = "telefono"
        Me.telefono.ReadOnly = True
        '
        'tipo
        '
        Me.tipo.Frozen = True
        Me.tipo.HeaderText = "Tipo"
        Me.tipo.Name = "tipo"
        Me.tipo.ReadOnly = True
        Me.tipo.Width = 125
        '
        'empresa
        '
        Me.empresa.Frozen = True
        Me.empresa.HeaderText = "Empresa"
        Me.empresa.Name = "empresa"
        Me.empresa.ReadOnly = True
        Me.empresa.Width = 250
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(345, 17)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(168, 20)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Lista de los clientes"
        '
        'Busqueda_Clientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(904, 459)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.grubbusquedaprov)
        Me.Controls.Add(Me.gridclientes)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Busqueda_Clientes"
        Me.Text = "Clientes"
        Me.GroupBox1.ResumeLayout(False)
        Me.grubbusquedaprov.ResumeLayout(False)
        Me.grubbusquedaprov.PerformLayout()
        CType(Me.gridclientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents botnuevo As System.Windows.Forms.Button
    Friend WithEvents botsalir As System.Windows.Forms.Button
    Friend WithEvents botmodificar As System.Windows.Forms.Button
    Friend WithEvents botdetalle As System.Windows.Forms.Button
    Friend WithEvents grubbusquedaprov As System.Windows.Forms.GroupBox
    Friend WithEvents texbusqueda As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents gridclientes As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents radiojuridico As System.Windows.Forms.RadioButton
    Friend WithEvents radionatural As System.Windows.Forms.RadioButton
    Friend WithEvents radiotodo As System.Windows.Forms.RadioButton
    Friend WithEvents cod As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Propietario As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents telefono As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tipo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents empresa As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
