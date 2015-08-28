<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DetalleEmpresa
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
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.botsalir = New System.Windows.Forms.Button()
        Me.texgiro = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.boteliminar = New System.Windows.Forms.Button()
        Me.boteditar = New System.Windows.Forms.Button()
        Me.botnuevo = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.texfaxO = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.textelfonoO = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.texdireccionO = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.texemail = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.texnrc = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.texnit = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.texnomempresa = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.texcodigo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupPanel1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupPanel1
        '
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.botsalir)
        Me.GroupPanel1.Controls.Add(Me.texgiro)
        Me.GroupPanel1.Controls.Add(Me.Label17)
        Me.GroupPanel1.Controls.Add(Me.boteliminar)
        Me.GroupPanel1.Controls.Add(Me.boteditar)
        Me.GroupPanel1.Controls.Add(Me.botnuevo)
        Me.GroupPanel1.Controls.Add(Me.TabControl1)
        Me.GroupPanel1.Controls.Add(Me.texnomempresa)
        Me.GroupPanel1.Controls.Add(Me.Label5)
        Me.GroupPanel1.Controls.Add(Me.texcodigo)
        Me.GroupPanel1.Controls.Add(Me.Label2)
        Me.GroupPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupPanel1.Location = New System.Drawing.Point(0, 0)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(799, 446)
        '
        '
        '
        Me.GroupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GroupPanel1.Style.BackColorGradientAngle = 90
        Me.GroupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GroupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderBottomWidth = 1
        Me.GroupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderLeftWidth = 1
        Me.GroupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderRightWidth = 1
        Me.GroupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderTopWidth = 1
        Me.GroupPanel1.Style.Class = ""
        Me.GroupPanel1.Style.CornerDiameter = 4
        Me.GroupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GroupPanel1.StyleMouseDown.Class = ""
        Me.GroupPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanel1.StyleMouseOver.Class = ""
        Me.GroupPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GroupPanel1.TabIndex = 0
        '
        'botsalir
        '
        Me.botsalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.botsalir.Location = New System.Drawing.Point(545, 380)
        Me.botsalir.Name = "botsalir"
        Me.botsalir.Size = New System.Drawing.Size(76, 38)
        Me.botsalir.TabIndex = 54
        Me.botsalir.Text = "Salir"
        Me.botsalir.UseVisualStyleBackColor = True
        '
        'texgiro
        '
        Me.texgiro.Enabled = False
        Me.texgiro.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.texgiro.Location = New System.Drawing.Point(247, 135)
        Me.texgiro.Name = "texgiro"
        Me.texgiro.Size = New System.Drawing.Size(457, 31)
        Me.texgiro.TabIndex = 50
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(183, 138)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(52, 25)
        Me.Label17.TabIndex = 49
        Me.Label17.Text = "Giro"
        '
        'boteliminar
        '
        Me.boteliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.boteliminar.Location = New System.Drawing.Point(177, 380)
        Me.boteliminar.Name = "boteliminar"
        Me.boteliminar.Size = New System.Drawing.Size(76, 38)
        Me.boteliminar.TabIndex = 48
        Me.boteliminar.Text = "Eliminar"
        Me.boteliminar.UseVisualStyleBackColor = True
        '
        'boteditar
        '
        Me.boteditar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.boteditar.Location = New System.Drawing.Point(95, 380)
        Me.boteditar.Name = "boteditar"
        Me.boteditar.Size = New System.Drawing.Size(76, 38)
        Me.boteditar.TabIndex = 47
        Me.boteditar.Text = "Editar"
        Me.boteditar.UseVisualStyleBackColor = True
        '
        'botnuevo
        '
        Me.botnuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.botnuevo.Location = New System.Drawing.Point(13, 380)
        Me.botnuevo.Name = "botnuevo"
        Me.botnuevo.Size = New System.Drawing.Size(76, 38)
        Me.botnuevo.TabIndex = 46
        Me.botnuevo.Text = "Nuevo"
        Me.botnuevo.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(13, 214)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(771, 150)
        Me.TabControl1.TabIndex = 45
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.texfaxO)
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Controls.Add(Me.textelfonoO)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.texdireccionO)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(763, 121)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Direccion"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'texfaxO
        '
        Me.texfaxO.Enabled = False
        Me.texfaxO.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.texfaxO.Location = New System.Drawing.Point(346, 59)
        Me.texfaxO.Name = "texfaxO"
        Me.texfaxO.Size = New System.Drawing.Size(129, 29)
        Me.texfaxO.TabIndex = 24
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(298, 62)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(42, 24)
        Me.Label9.TabIndex = 23
        Me.Label9.Text = "Fax"
        '
        'textelfonoO
        '
        Me.textelfonoO.Enabled = False
        Me.textelfonoO.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textelfonoO.Location = New System.Drawing.Point(120, 59)
        Me.textelfonoO.Name = "textelfonoO"
        Me.textelfonoO.Size = New System.Drawing.Size(129, 29)
        Me.textelfonoO.TabIndex = 22
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(29, 64)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(85, 24)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "Telefono"
        '
        'texdireccionO
        '
        Me.texdireccionO.Enabled = False
        Me.texdireccionO.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.texdireccionO.Location = New System.Drawing.Point(120, 19)
        Me.texdireccionO.Name = "texdireccionO"
        Me.texdireccionO.Size = New System.Drawing.Size(472, 29)
        Me.texdireccionO.TabIndex = 19
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(24, 22)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(90, 24)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Direccion"
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.texemail)
        Me.TabPage3.Controls.Add(Me.Label15)
        Me.TabPage3.Controls.Add(Me.texnrc)
        Me.TabPage3.Controls.Add(Me.Label14)
        Me.TabPage3.Controls.Add(Me.texnit)
        Me.TabPage3.Controls.Add(Me.Label13)
        Me.TabPage3.Location = New System.Drawing.Point(4, 25)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(763, 121)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Documentos"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'texemail
        '
        Me.texemail.Enabled = False
        Me.texemail.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.texemail.Location = New System.Drawing.Point(418, 48)
        Me.texemail.Name = "texemail"
        Me.texemail.Size = New System.Drawing.Size(190, 29)
        Me.texemail.TabIndex = 25
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(349, 51)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(63, 24)
        Me.Label15.TabIndex = 24
        Me.Label15.Text = "E-mail"
        '
        'texnrc
        '
        Me.texnrc.Enabled = False
        Me.texnrc.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.texnrc.Location = New System.Drawing.Point(75, 76)
        Me.texnrc.Name = "texnrc"
        Me.texnrc.Size = New System.Drawing.Size(190, 29)
        Me.texnrc.TabIndex = 23
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(22, 76)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(50, 24)
        Me.Label14.TabIndex = 22
        Me.Label14.Text = "NRC"
        '
        'texnit
        '
        Me.texnit.Enabled = False
        Me.texnit.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.texnit.Location = New System.Drawing.Point(75, 23)
        Me.texnit.Name = "texnit"
        Me.texnit.Size = New System.Drawing.Size(190, 29)
        Me.texnit.TabIndex = 21
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(29, 26)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(40, 24)
        Me.Label13.TabIndex = 20
        Me.Label13.Text = "NIT"
        '
        'texnomempresa
        '
        Me.texnomempresa.Enabled = False
        Me.texnomempresa.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.texnomempresa.Location = New System.Drawing.Point(247, 79)
        Me.texnomempresa.Name = "texnomempresa"
        Me.texnomempresa.Size = New System.Drawing.Size(229, 31)
        Me.texnomempresa.TabIndex = 43
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(10, 82)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(231, 25)
        Me.Label5.TabIndex = 42
        Me.Label5.Text = "Nombre de la Empresa"
        '
        'texcodigo
        '
        Me.texcodigo.Enabled = False
        Me.texcodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.texcodigo.Location = New System.Drawing.Point(247, 25)
        Me.texcodigo.Name = "texcodigo"
        Me.texcodigo.Size = New System.Drawing.Size(100, 31)
        Me.texcodigo.TabIndex = 39
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(161, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 25)
        Me.Label2.TabIndex = 38
        Me.Label2.Text = "Codigo"
        '
        'DetalleEmpresa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(799, 446)
        Me.Controls.Add(Me.GroupPanel1)
        Me.Name = "DetalleEmpresa"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Detalle del Proveedor"
        Me.GroupPanel1.ResumeLayout(False)
        Me.GroupPanel1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents botsalir As System.Windows.Forms.Button
    Friend WithEvents texgiro As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents boteliminar As System.Windows.Forms.Button
    Friend WithEvents boteditar As System.Windows.Forms.Button
    Friend WithEvents botnuevo As System.Windows.Forms.Button
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents texfaxO As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents textelfonoO As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents texdireccionO As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents texemail As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents texnrc As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents texnit As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents texnomempresa As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents texcodigo As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
