<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class nventa
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
        Me.timerhijo = New System.Windows.Forms.Timer(Me.components)
        Me.gridventas = New System.Windows.Forms.DataGridView()
        Me.Ored = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.botseleccionar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.gridventas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'timerhijo
        '
        Me.timerhijo.Interval = 2000
        '
        'gridventas
        '
        Me.gridventas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridventas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Ored, Me.Tipo, Me.cliente, Me.cantidad})
        Me.gridventas.Location = New System.Drawing.Point(1, 54)
        Me.gridventas.Name = "gridventas"
        Me.gridventas.RowHeadersVisible = False
        Me.gridventas.Size = New System.Drawing.Size(327, 146)
        Me.gridventas.TabIndex = 0
        '
        'Ored
        '
        Me.Ored.Frozen = True
        Me.Ored.HeaderText = "ORDEN"
        Me.Ored.Name = "Ored"
        Me.Ored.ReadOnly = True
        Me.Ored.Width = 50
        '
        'Tipo
        '
        Me.Tipo.Frozen = True
        Me.Tipo.HeaderText = "Tipo"
        Me.Tipo.Name = "Tipo"
        Me.Tipo.ReadOnly = True
        Me.Tipo.Width = 75
        '
        'cliente
        '
        Me.cliente.Frozen = True
        Me.cliente.HeaderText = "Cliente"
        Me.cliente.Name = "cliente"
        Me.cliente.ReadOnly = True
        Me.cliente.Width = 150
        '
        'cantidad
        '
        Me.cantidad.Frozen = True
        Me.cantidad.HeaderText = "Cantidad"
        Me.cantidad.Name = "cantidad"
        Me.cantidad.ReadOnly = True
        Me.cantidad.Width = 50
        '
        'botseleccionar
        '
        Me.botseleccionar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.botseleccionar.Location = New System.Drawing.Point(91, 217)
        Me.botseleccionar.Name = "botseleccionar"
        Me.botseleccionar.Size = New System.Drawing.Size(122, 32)
        Me.botseleccionar.TabIndex = 1
        Me.botseleccionar.Text = "ATENDER"
        Me.botseleccionar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(319, 24)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "NUEVAS VENTAS PENDIENTES"
        '
        'nventa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(328, 261)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.botseleccionar)
        Me.Controls.Add(Me.gridventas)
        Me.Name = "nventa"
        Me.Text = "nventa"
        Me.TopMost = True
        CType(Me.gridventas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents timerhijo As System.Windows.Forms.Timer
    Friend WithEvents gridventas As System.Windows.Forms.DataGridView
    Friend WithEvents botseleccionar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Ored As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Tipo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cliente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cantidad As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
