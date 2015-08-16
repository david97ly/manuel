<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPermisos
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.cmdSalir = New System.Windows.Forms.Button
        Me.txtGrupo = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmdBuscar = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.cmdElTodos = New System.Windows.Forms.Button
        Me.cmdElimina = New System.Windows.Forms.Button
        Me.cmdAddTodos = New System.Windows.Forms.Button
        Me.cmdAdd = New System.Windows.Forms.Button
        Me.opcAsig = New System.Windows.Forms.TreeView
        Me.opcDisp = New System.Windows.Forms.TreeView
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmdSalir)
        Me.GroupBox1.Controls.Add(Me.txtGrupo)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cmdBuscar)
        Me.GroupBox1.Location = New System.Drawing.Point(5, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(549, 64)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Grupos de Usuarios"
        '
        'cmdSalir
        '
        Me.cmdSalir.Location = New System.Drawing.Point(468, 19)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(75, 23)
        Me.cmdSalir.TabIndex = 2
        Me.cmdSalir.Text = "Salir"
        Me.cmdSalir.UseVisualStyleBackColor = True
        '
        'txtGrupo
        '
        Me.txtGrupo.Location = New System.Drawing.Point(49, 21)
        Me.txtGrupo.Name = "txtGrupo"
        Me.txtGrupo.Size = New System.Drawing.Size(369, 20)
        Me.txtGrupo.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Grupo"
        '
        'cmdBuscar
        '
        Me.cmdBuscar.Location = New System.Drawing.Point(424, 19)
        Me.cmdBuscar.Name = "cmdBuscar"
        Me.cmdBuscar.Size = New System.Drawing.Size(38, 23)
        Me.cmdBuscar.TabIndex = 0
        Me.cmdBuscar.Text = "..."
        Me.cmdBuscar.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cmdElTodos)
        Me.GroupBox2.Controls.Add(Me.cmdElimina)
        Me.GroupBox2.Controls.Add(Me.cmdAddTodos)
        Me.GroupBox2.Controls.Add(Me.cmdAdd)
        Me.GroupBox2.Controls.Add(Me.opcAsig)
        Me.GroupBox2.Controls.Add(Me.opcDisp)
        Me.GroupBox2.Location = New System.Drawing.Point(5, 79)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(549, 229)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Permisos"
        '
        'cmdElTodos
        '
        Me.cmdElTodos.Location = New System.Drawing.Point(246, 150)
        Me.cmdElTodos.Name = "cmdElTodos"
        Me.cmdElTodos.Size = New System.Drawing.Size(88, 23)
        Me.cmdElTodos.TabIndex = 5
        Me.cmdElTodos.Text = "Eliminar Todos"
        Me.cmdElTodos.UseVisualStyleBackColor = True
        '
        'cmdElimina
        '
        Me.cmdElimina.Location = New System.Drawing.Point(246, 121)
        Me.cmdElimina.Name = "cmdElimina"
        Me.cmdElimina.Size = New System.Drawing.Size(88, 23)
        Me.cmdElimina.TabIndex = 4
        Me.cmdElimina.Text = "Eliminar"
        Me.cmdElimina.UseVisualStyleBackColor = True
        '
        'cmdAddTodos
        '
        Me.cmdAddTodos.Location = New System.Drawing.Point(246, 63)
        Me.cmdAddTodos.Name = "cmdAddTodos"
        Me.cmdAddTodos.Size = New System.Drawing.Size(88, 23)
        Me.cmdAddTodos.TabIndex = 3
        Me.cmdAddTodos.Text = "Agrega Todos"
        Me.cmdAddTodos.UseVisualStyleBackColor = True
        '
        'cmdAdd
        '
        Me.cmdAdd.Location = New System.Drawing.Point(246, 92)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Size = New System.Drawing.Size(88, 23)
        Me.cmdAdd.TabIndex = 2
        Me.cmdAdd.Text = "Agrega"
        Me.cmdAdd.UseVisualStyleBackColor = True
        '
        'opcAsig
        '
        Me.opcAsig.Location = New System.Drawing.Point(340, 17)
        Me.opcAsig.Name = "opcAsig"
        Me.opcAsig.Size = New System.Drawing.Size(203, 200)
        Me.opcAsig.TabIndex = 1
        '
        'opcDisp
        '
        Me.opcDisp.Location = New System.Drawing.Point(8, 16)
        Me.opcDisp.Name = "opcDisp"
        Me.opcDisp.Size = New System.Drawing.Size(224, 201)
        Me.opcDisp.TabIndex = 0
        '
        'frmPermisos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(571, 321)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmPermisos"
        Me.Text = "Permisos usuarios"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdSalir As System.Windows.Forms.Button
    Friend WithEvents txtGrupo As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmdBuscar As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdElTodos As System.Windows.Forms.Button
    Friend WithEvents cmdElimina As System.Windows.Forms.Button
    Friend WithEvents cmdAddTodos As System.Windows.Forms.Button
    Friend WithEvents cmdAdd As System.Windows.Forms.Button
    Friend WithEvents opcAsig As System.Windows.Forms.TreeView
    Friend WithEvents opcDisp As System.Windows.Forms.TreeView
End Class
