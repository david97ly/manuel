<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Respaldos
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
        Me.gridrespaldos = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.nr = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.noar = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.botrespladar = New DevComponents.DotNetBar.ButtonX()
        Me.botrestaurar = New DevComponents.DotNetBar.ButtonX()
        Me.cherresauto = New System.Windows.Forms.CheckBox()
        Me.respaldar = New System.Windows.Forms.SaveFileDialog()
        Me.abrir = New System.Windows.Forms.OpenFileDialog()
        CType(Me.gridrespaldos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gridrespaldos
        '
        Me.gridrespaldos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridrespaldos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.nr, Me.Fecha, Me.noar})
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.gridrespaldos.DefaultCellStyle = DataGridViewCellStyle1
        Me.gridrespaldos.GridColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.gridrespaldos.Location = New System.Drawing.Point(1, 12)
        Me.gridrespaldos.Name = "gridrespaldos"
        Me.gridrespaldos.RowHeadersVisible = False
        Me.gridrespaldos.Size = New System.Drawing.Size(504, 245)
        Me.gridrespaldos.TabIndex = 0
        '
        'nr
        '
        Me.nr.Frozen = True
        Me.nr.HeaderText = "Num Respaldo"
        Me.nr.Name = "nr"
        Me.nr.ReadOnly = True
        '
        'Fecha
        '
        Me.Fecha.Frozen = True
        Me.Fecha.HeaderText = "Fecha del respaldo"
        Me.Fecha.Name = "Fecha"
        Me.Fecha.ReadOnly = True
        Me.Fecha.Width = 200
        '
        'noar
        '
        Me.noar.Frozen = True
        Me.noar.HeaderText = "Nombre del Archivo"
        Me.noar.Name = "noar"
        Me.noar.ReadOnly = True
        Me.noar.Width = 200
        '
        'botrespladar
        '
        Me.botrespladar.AccessibleRole = System.Windows.Forms.AccessibleRole.ComboBox
        Me.botrespladar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.botrespladar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.botrespladar.Location = New System.Drawing.Point(511, 25)
        Me.botrespladar.Name = "botrespladar"
        Me.botrespladar.Size = New System.Drawing.Size(136, 42)
        Me.botrespladar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.botrespladar.TabIndex = 1
        Me.botrespladar.Text = "Respaldar Datos"
        '
        'botrestaurar
        '
        Me.botrestaurar.AccessibleRole = System.Windows.Forms.AccessibleRole.ComboBox
        Me.botrestaurar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.botrestaurar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.botrestaurar.Location = New System.Drawing.Point(511, 90)
        Me.botrestaurar.Name = "botrestaurar"
        Me.botrestaurar.Size = New System.Drawing.Size(136, 42)
        Me.botrestaurar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.botrestaurar.TabIndex = 2
        Me.botrestaurar.Text = "Restaurar Datos"
        '
        'cherresauto
        '
        Me.cherresauto.AutoSize = True
        Me.cherresauto.Location = New System.Drawing.Point(511, 190)
        Me.cherresauto.Name = "cherresauto"
        Me.cherresauto.Size = New System.Drawing.Size(154, 17)
        Me.cherresauto.TabIndex = 3
        Me.cherresauto.Text = "Respaldo automatico diario"
        Me.cherresauto.UseVisualStyleBackColor = True
        '
        'abrir
        '
        Me.abrir.FileName = "OpenFileDialog1"
        '
        'Respaldos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(659, 269)
        Me.Controls.Add(Me.cherresauto)
        Me.Controls.Add(Me.botrestaurar)
        Me.Controls.Add(Me.botrespladar)
        Me.Controls.Add(Me.gridrespaldos)
        Me.Name = "Respaldos"
        Me.Text = "Respaldos"
        CType(Me.gridrespaldos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gridrespaldos As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents nr As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Fecha As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents noar As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents botrespladar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents botrestaurar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents cherresauto As System.Windows.Forms.CheckBox
    Friend WithEvents respaldar As System.Windows.Forms.SaveFileDialog
    Friend WithEvents abrir As System.Windows.Forms.OpenFileDialog
End Class
