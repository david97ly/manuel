<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Inicio
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dataempresa = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.codigo1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombreempresa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pripie = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.numtele = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.botseleccionar = New DevComponents.DotNetBar.ButtonX()
        Me.botsalir = New DevComponents.DotNetBar.ButtonX()
        CType(Me.dataempresa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(73, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(564, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Por favor Seleccione la empresa que desea ingresar"
        '
        'dataempresa
        '
        Me.dataempresa.AllowUserToAddRows = False
        Me.dataempresa.AllowUserToDeleteRows = False
        Me.dataempresa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataempresa.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.codigo1, Me.nombreempresa, Me.pripie, Me.numtele})
        Me.dataempresa.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dataempresa.DefaultCellStyle = DataGridViewCellStyle1
        Me.dataempresa.GridColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.dataempresa.Location = New System.Drawing.Point(44, 89)
        Me.dataempresa.Name = "dataempresa"
        Me.dataempresa.ReadOnly = True
        Me.dataempresa.RowHeadersVisible = False
        Me.dataempresa.Size = New System.Drawing.Size(654, 187)
        Me.dataempresa.TabIndex = 4
        '
        'codigo1
        '
        Me.codigo1.HeaderText = "Codigo"
        Me.codigo1.Name = "codigo1"
        Me.codigo1.ReadOnly = True
        Me.codigo1.Width = 75
        '
        'nombreempresa
        '
        Me.nombreempresa.HeaderText = "Nombre de la empresa"
        Me.nombreempresa.Name = "nombreempresa"
        Me.nombreempresa.ReadOnly = True
        Me.nombreempresa.Width = 250
        '
        'pripie
        '
        Me.pripie.HeaderText = "Propietario"
        Me.pripie.Name = "pripie"
        Me.pripie.ReadOnly = True
        Me.pripie.Width = 200
        '
        'numtele
        '
        Me.numtele.HeaderText = "Número de télefono"
        Me.numtele.Name = "numtele"
        Me.numtele.ReadOnly = True
        Me.numtele.Width = 125
        '
        'botseleccionar
        '
        Me.botseleccionar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.botseleccionar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.botseleccionar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.botseleccionar.Location = New System.Drawing.Point(44, 299)
        Me.botseleccionar.Name = "botseleccionar"
        Me.botseleccionar.Size = New System.Drawing.Size(145, 44)
        Me.botseleccionar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.botseleccionar.TabIndex = 5
        Me.botseleccionar.Text = "Seleccionar"
        '
        'botsalir
        '
        Me.botsalir.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.botsalir.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.botsalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.botsalir.Location = New System.Drawing.Point(555, 299)
        Me.botsalir.Name = "botsalir"
        Me.botsalir.Size = New System.Drawing.Size(145, 44)
        Me.botsalir.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.botsalir.TabIndex = 6
        Me.botsalir.Text = "Salir"
        '
        'Inicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(712, 355)
        Me.Controls.Add(Me.botsalir)
        Me.Controls.Add(Me.botseleccionar)
        Me.Controls.Add(Me.dataempresa)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Inicio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "l"
        Me.TopMost = True
        CType(Me.dataempresa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dataempresa As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents codigo1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nombreempresa As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents pripie As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents numtele As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents botseleccionar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents botsalir As DevComponents.DotNetBar.ButtonX
End Class
