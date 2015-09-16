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
        Me.lcantidad = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.botatender = New System.Windows.Forms.Button()
        Me.timerhijo = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'lcantidad
        '
        Me.lcantidad.AutoSize = True
        Me.lcantidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lcantidad.Location = New System.Drawing.Point(1, 51)
        Me.lcantidad.Name = "lcantidad"
        Me.lcantidad.Size = New System.Drawing.Size(159, 25)
        Me.lcantidad.TabIndex = 0
        Me.lcantidad.Text = "Cantidad: $25"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(1, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(25, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "1"
        '
        'botatender
        '
        Me.botatender.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.botatender.Location = New System.Drawing.Point(104, 0)
        Me.botatender.Name = "botatender"
        Me.botatender.Size = New System.Drawing.Size(107, 35)
        Me.botatender.TabIndex = 2
        Me.botatender.Text = "Atender"
        Me.botatender.UseVisualStyleBackColor = True
        '
        'timerhijo
        '
        Me.timerhijo.Interval = 2000
        '
        'nventa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(211, 75)
        Me.Controls.Add(Me.botatender)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lcantidad)
        Me.Name = "nventa"
        Me.Text = "nventa"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lcantidad As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents botatender As System.Windows.Forms.Button
    Friend WithEvents timerhijo As System.Windows.Forms.Timer
End Class
