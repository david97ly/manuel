<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Categoria
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.idcategoria = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descrip = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.texnombre = New System.Windows.Forms.TextBox()
        Me.texdescripcion = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.botGuardar = New System.Windows.Forms.Button()
        Me.lcamposobligatorios = New System.Windows.Forms.Label()
        Me.ln = New System.Windows.Forms.Label()
        Me.ld = New System.Windows.Forms.Label()
        Me.botseleccionar = New System.Windows.Forms.Button()
        Me.botsalir = New System.Windows.Forms.Button()
        Me.boteliminar = New System.Windows.Forms.Button()
        Me.botmodificar = New System.Windows.Forms.Button()
        Me.botnuevo = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idcategoria, Me.nombre, Me.descrip})
        Me.DataGridView1.Location = New System.Drawing.Point(5, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(594, 444)
        Me.DataGridView1.TabIndex = 8
        '
        'idcategoria
        '
        Me.idcategoria.HeaderText = "Id Categoria"
        Me.idcategoria.Name = "idcategoria"
        Me.idcategoria.ReadOnly = True
        '
        'nombre
        '
        Me.nombre.HeaderText = "Nombre"
        Me.nombre.Name = "nombre"
        Me.nombre.ReadOnly = True
        Me.nombre.Width = 200
        '
        'descrip
        '
        Me.descrip.HeaderText = "Descripcion"
        Me.descrip.Name = "descrip"
        Me.descrip.ReadOnly = True
        Me.descrip.Width = 250
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(36, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(176, 20)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Nombre de la Categoria"
        '
        'texnombre
        '
        Me.texnombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.texnombre.Location = New System.Drawing.Point(218, 57)
        Me.texnombre.Name = "texnombre"
        Me.texnombre.Size = New System.Drawing.Size(154, 26)
        Me.texnombre.TabIndex = 15
        '
        'texdescripcion
        '
        Me.texdescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.texdescripcion.Location = New System.Drawing.Point(218, 107)
        Me.texdescripcion.Name = "texdescripcion"
        Me.texdescripcion.Size = New System.Drawing.Size(154, 26)
        Me.texdescripcion.TabIndex = 17
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(13, 110)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(203, 20)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Descripcion de la Categoria"
        '
        'botGuardar
        '
        Me.botGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.botGuardar.Location = New System.Drawing.Point(506, 81)
        Me.botGuardar.Name = "botGuardar"
        Me.botGuardar.Size = New System.Drawing.Size(93, 33)
        Me.botGuardar.TabIndex = 18
        Me.botGuardar.Text = "Guardar"
        Me.botGuardar.UseVisualStyleBackColor = True
        '
        'lcamposobligatorios
        '
        Me.lcamposobligatorios.AutoSize = True
        Me.lcamposobligatorios.Location = New System.Drawing.Point(12, 13)
        Me.lcamposobligatorios.Name = "lcamposobligatorios"
        Me.lcamposobligatorios.Size = New System.Drawing.Size(342, 16)
        Me.lcamposobligatorios.TabIndex = 19
        Me.lcamposobligatorios.Text = "Porfavor llene todos los campos que son obligatorios (*)"
        '
        'ln
        '
        Me.ln.AutoSize = True
        Me.ln.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ln.Location = New System.Drawing.Point(378, 53)
        Me.ln.Name = "ln"
        Me.ln.Size = New System.Drawing.Size(18, 24)
        Me.ln.TabIndex = 20
        Me.ln.Text = "*"
        '
        'ld
        '
        Me.ld.AutoSize = True
        Me.ld.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ld.Location = New System.Drawing.Point(378, 106)
        Me.ld.Name = "ld"
        Me.ld.Size = New System.Drawing.Size(18, 24)
        Me.ld.TabIndex = 21
        Me.ld.Text = "*"
        '
        'botseleccionar
        '
        Me.botseleccionar.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.botseleccionar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.botseleccionar.Location = New System.Drawing.Point(3, 469)
        Me.botseleccionar.Name = "botseleccionar"
        Me.botseleccionar.Size = New System.Drawing.Size(119, 33)
        Me.botseleccionar.TabIndex = 26
        Me.botseleccionar.Text = "Seleccionar"
        Me.botseleccionar.UseVisualStyleBackColor = True
        '
        'botsalir
        '
        Me.botsalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.botsalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.botsalir.Location = New System.Drawing.Point(497, 469)
        Me.botsalir.Name = "botsalir"
        Me.botsalir.Size = New System.Drawing.Size(93, 33)
        Me.botsalir.TabIndex = 25
        Me.botsalir.Text = "Salir"
        Me.botsalir.UseVisualStyleBackColor = True
        '
        'boteliminar
        '
        Me.boteliminar.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.boteliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.boteliminar.Location = New System.Drawing.Point(398, 469)
        Me.boteliminar.Name = "boteliminar"
        Me.boteliminar.Size = New System.Drawing.Size(93, 33)
        Me.boteliminar.TabIndex = 24
        Me.boteliminar.Text = "Eliminar"
        Me.boteliminar.UseVisualStyleBackColor = True
        '
        'botmodificar
        '
        Me.botmodificar.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.botmodificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.botmodificar.Location = New System.Drawing.Point(237, 469)
        Me.botmodificar.Name = "botmodificar"
        Me.botmodificar.Size = New System.Drawing.Size(93, 33)
        Me.botmodificar.TabIndex = 23
        Me.botmodificar.Text = "Modificar"
        Me.botmodificar.UseVisualStyleBackColor = True
        '
        'botnuevo
        '
        Me.botnuevo.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.botnuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.botnuevo.Location = New System.Drawing.Point(128, 469)
        Me.botnuevo.Name = "botnuevo"
        Me.botnuevo.Size = New System.Drawing.Size(93, 33)
        Me.botnuevo.TabIndex = 22
        Me.botnuevo.Text = "Nueva"
        Me.botnuevo.UseVisualStyleBackColor = True
        '
        'Categoria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(604, 514)
        Me.Controls.Add(Me.botseleccionar)
        Me.Controls.Add(Me.botsalir)
        Me.Controls.Add(Me.boteliminar)
        Me.Controls.Add(Me.botmodificar)
        Me.Controls.Add(Me.botnuevo)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.ld)
        Me.Controls.Add(Me.ln)
        Me.Controls.Add(Me.lcamposobligatorios)
        Me.Controls.Add(Me.botGuardar)
        Me.Controls.Add(Me.texdescripcion)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.texnombre)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Categoria"
        Me.Text = "Categoria"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents idcategoria As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents descrip As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents texnombre As System.Windows.Forms.TextBox
    Friend WithEvents texdescripcion As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents botGuardar As System.Windows.Forms.Button
    Friend WithEvents lcamposobligatorios As System.Windows.Forms.Label
    Friend WithEvents ln As System.Windows.Forms.Label
    Friend WithEvents ld As System.Windows.Forms.Label
    Friend WithEvents botseleccionar As System.Windows.Forms.Button
    Friend WithEvents botsalir As System.Windows.Forms.Button
    Friend WithEvents boteliminar As System.Windows.Forms.Button
    Friend WithEvents botmodificar As System.Windows.Forms.Button
    Friend WithEvents botnuevo As System.Windows.Forms.Button
End Class
