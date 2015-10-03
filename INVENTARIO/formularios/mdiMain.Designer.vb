<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mdiMain
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
                Application.Exit()
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mdiMain))
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.timllamar = New System.Windows.Forms.Timer(Me.components)
        Me.StyleManager1 = New DevComponents.DotNetBar.StyleManager(Me.components)
        Me.StyleManager2 = New DevComponents.DotNetBar.StyleManager(Me.components)
        Me.comboItem1 = New DevComponents.Editors.ComboItem()
        Me.comboItem2 = New DevComponents.Editors.ComboItem()
        Me.comboItem3 = New DevComponents.Editors.ComboItem()
        Me.comboItem4 = New DevComponents.Editors.ComboItem()
        Me.comboItem5 = New DevComponents.Editors.ComboItem()
        Me.comboItem6 = New DevComponents.Editors.ComboItem()
        Me.comboItem7 = New DevComponents.Editors.ComboItem()
        Me.comboItem8 = New DevComponents.Editors.ComboItem()
        Me.comboItem9 = New DevComponents.Editors.ComboItem()
        Me.checkBoxItem1 = New DevComponents.DotNetBar.CheckBoxItem()
        Me.checkBoxItem2 = New DevComponents.DotNetBar.CheckBoxItem()
        Me.checkBoxItem3 = New DevComponents.DotNetBar.CheckBoxItem()
        Me.checkBoxItem4 = New DevComponents.DotNetBar.CheckBoxItem()
        Me.checkBoxItem5 = New DevComponents.DotNetBar.CheckBoxItem()
        Me.checkBoxItem6 = New DevComponents.DotNetBar.CheckBoxItem()
        Me.buttonItem50 = New DevComponents.DotNetBar.ButtonItem()
        Me.buttonItem51 = New DevComponents.DotNetBar.ButtonItem()
        Me.buttonItem52 = New DevComponents.DotNetBar.ButtonItem()
        Me.ribbonTabItemGroup1 = New DevComponents.DotNetBar.RibbonTabItemGroup()
        Me.ComboItem10 = New DevComponents.Editors.ComboItem()
        Me.ComboItem11 = New DevComponents.Editors.ComboItem()
        Me.ComboItem12 = New DevComponents.Editors.ComboItem()
        Me.ComboItem13 = New DevComponents.Editors.ComboItem()
        Me.ComboItem14 = New DevComponents.Editors.ComboItem()
        Me.ComboItem15 = New DevComponents.Editors.ComboItem()
        Me.ComboItem16 = New DevComponents.Editors.ComboItem()
        Me.ComboItem17 = New DevComponents.Editors.ComboItem()
        Me.ComboItem18 = New DevComponents.Editors.ComboItem()
        Me.RibbonTabItemGroup2 = New DevComponents.DotNetBar.RibbonTabItemGroup()
        Me.GalleryContainer3 = New DevComponents.DotNetBar.GalleryContainer()
        Me.LabelItem1 = New DevComponents.DotNetBar.LabelItem()
        Me.buttonItem47 = New DevComponents.DotNetBar.ButtonItem()
        Me.buttonItem48 = New DevComponents.DotNetBar.ButtonItem()
        Me.buttonItem49 = New DevComponents.DotNetBar.ButtonItem()
        Me.buttonReplace = New DevComponents.DotNetBar.ButtonItem()
        Me.buttonGoto = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem14 = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem15 = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem16 = New DevComponents.DotNetBar.ButtonItem()
        Me.tmnulo = New System.Windows.Forms.Timer(Me.components)
        Me.timernuevaventa = New System.Windows.Forms.Timer(Me.components)
        Me.gridventas = New System.Windows.Forms.DataGridView()
        Me.Ored = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lnotis = New System.Windows.Forms.Label()
        CType(Me.gridventas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'timllamar
        '
        Me.timllamar.Interval = 10
        '
        'StyleManager1
        '
        Me.StyleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2010Blue
        '
        'StyleManager2
        '
        Me.StyleManager2.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2010Blue
        '
        'comboItem1
        '
        Me.comboItem1.Text = "6"
        '
        'comboItem2
        '
        Me.comboItem2.Text = "7"
        '
        'comboItem3
        '
        Me.comboItem3.Text = "8"
        '
        'comboItem4
        '
        Me.comboItem4.Text = "9"
        '
        'comboItem5
        '
        Me.comboItem5.Text = "10"
        '
        'comboItem6
        '
        Me.comboItem6.Text = "11"
        '
        'comboItem7
        '
        Me.comboItem7.Text = "12"
        '
        'comboItem8
        '
        Me.comboItem8.Text = "13"
        '
        'comboItem9
        '
        Me.comboItem9.Text = "14"
        '
        'checkBoxItem1
        '
        Me.checkBoxItem1.Checked = True
        Me.checkBoxItem1.CheckState = System.Windows.Forms.CheckState.Indeterminate
        Me.checkBoxItem1.Name = "checkBoxItem1"
        Me.checkBoxItem1.Text = "Header"
        Me.checkBoxItem1.ThreeState = True
        '
        'checkBoxItem2
        '
        Me.checkBoxItem2.Name = "checkBoxItem2"
        Me.checkBoxItem2.Text = "Footer"
        '
        'checkBoxItem3
        '
        Me.checkBoxItem3.Checked = True
        Me.checkBoxItem3.CheckState = System.Windows.Forms.CheckState.Checked
        Me.checkBoxItem3.Name = "checkBoxItem3"
        Me.checkBoxItem3.Text = "Margins"
        '
        'checkBoxItem4
        '
        Me.checkBoxItem4.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton
        Me.checkBoxItem4.Name = "checkBoxItem4"
        Me.checkBoxItem4.Text = "Horizontal Layout"
        '
        'checkBoxItem5
        '
        Me.checkBoxItem5.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton
        Me.checkBoxItem5.Name = "checkBoxItem5"
        Me.checkBoxItem5.Text = "Vertical Layout"
        '
        'checkBoxItem6
        '
        Me.checkBoxItem6.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton
        Me.checkBoxItem6.Checked = True
        Me.checkBoxItem6.CheckState = System.Windows.Forms.CheckState.Checked
        Me.checkBoxItem6.Name = "checkBoxItem6"
        Me.checkBoxItem6.Text = "Automatic Layout"
        '
        'buttonItem50
        '
        Me.buttonItem50.Checked = True
        Me.buttonItem50.Name = "buttonItem50"
        Me.buttonItem50.OptionGroup = "orientation"
        Me.buttonItem50.Text = "Auto"
        '
        'buttonItem51
        '
        Me.buttonItem51.Name = "buttonItem51"
        Me.buttonItem51.OptionGroup = "orientation"
        Me.buttonItem51.Text = "Horizontal"
        '
        'buttonItem52
        '
        Me.buttonItem52.Name = "buttonItem52"
        Me.buttonItem52.OptionGroup = "orientation"
        Me.buttonItem52.Text = "Vertical"
        '
        'ribbonTabItemGroup1
        '
        Me.ribbonTabItemGroup1.Color = DevComponents.DotNetBar.eRibbonTabGroupColor.Orange
        Me.ribbonTabItemGroup1.GroupTitle = "Tab Group"
        Me.ribbonTabItemGroup1.Name = "ribbonTabItemGroup1"
        '
        '
        '
        Me.ribbonTabItemGroup1.Style.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.ribbonTabItemGroup1.Style.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.ribbonTabItemGroup1.Style.BackColorGradientAngle = 90
        Me.ribbonTabItemGroup1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.ribbonTabItemGroup1.Style.BorderBottomWidth = 1
        Me.ribbonTabItemGroup1.Style.BorderColor = System.Drawing.Color.FromArgb(CType(CType(154, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.ribbonTabItemGroup1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.ribbonTabItemGroup1.Style.BorderLeftWidth = 1
        Me.ribbonTabItemGroup1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.ribbonTabItemGroup1.Style.BorderRightWidth = 1
        Me.ribbonTabItemGroup1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.ribbonTabItemGroup1.Style.BorderTopWidth = 1
        Me.ribbonTabItemGroup1.Style.Class = ""
        Me.ribbonTabItemGroup1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ribbonTabItemGroup1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.ribbonTabItemGroup1.Style.TextColor = System.Drawing.Color.Black
        Me.ribbonTabItemGroup1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        'ComboItem10
        '
        Me.ComboItem10.Text = "6"
        '
        'ComboItem11
        '
        Me.ComboItem11.Text = "7"
        '
        'ComboItem12
        '
        Me.ComboItem12.Text = "8"
        '
        'ComboItem13
        '
        Me.ComboItem13.Text = "9"
        '
        'ComboItem14
        '
        Me.ComboItem14.Text = "10"
        '
        'ComboItem15
        '
        Me.ComboItem15.Text = "11"
        '
        'ComboItem16
        '
        Me.ComboItem16.Text = "12"
        '
        'ComboItem17
        '
        Me.ComboItem17.Text = "13"
        '
        'ComboItem18
        '
        Me.ComboItem18.Text = "14"
        '
        'RibbonTabItemGroup2
        '
        Me.RibbonTabItemGroup2.Color = DevComponents.DotNetBar.eRibbonTabGroupColor.Orange
        Me.RibbonTabItemGroup2.GroupTitle = "Tab Group"
        Me.RibbonTabItemGroup2.Name = "RibbonTabItemGroup2"
        '
        '
        '
        Me.RibbonTabItemGroup2.Style.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.RibbonTabItemGroup2.Style.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.RibbonTabItemGroup2.Style.BackColorGradientAngle = 90
        Me.RibbonTabItemGroup2.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.RibbonTabItemGroup2.Style.BorderBottomWidth = 1
        Me.RibbonTabItemGroup2.Style.BorderColor = System.Drawing.Color.FromArgb(CType(CType(154, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.RibbonTabItemGroup2.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.RibbonTabItemGroup2.Style.BorderLeftWidth = 1
        Me.RibbonTabItemGroup2.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.RibbonTabItemGroup2.Style.BorderRightWidth = 1
        Me.RibbonTabItemGroup2.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.RibbonTabItemGroup2.Style.BorderTopWidth = 1
        Me.RibbonTabItemGroup2.Style.Class = ""
        Me.RibbonTabItemGroup2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.RibbonTabItemGroup2.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.RibbonTabItemGroup2.Style.TextColor = System.Drawing.Color.Black
        Me.RibbonTabItemGroup2.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        'GalleryContainer3
        '
        '
        '
        '
        Me.GalleryContainer3.BackgroundStyle.Class = "RibbonFileMenuColumnTwoContainer"
        Me.GalleryContainer3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GalleryContainer3.EnableGalleryPopup = False
        Me.GalleryContainer3.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical
        Me.GalleryContainer3.MinimumSize = New System.Drawing.Size(180, 240)
        Me.GalleryContainer3.MultiLine = False
        Me.GalleryContainer3.Name = "GalleryContainer3"
        Me.GalleryContainer3.PopupUsesStandardScrollbars = False
        '
        'LabelItem1
        '
        Me.LabelItem1.BorderSide = DevComponents.DotNetBar.eBorderSide.Bottom
        Me.LabelItem1.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.LabelItem1.CanCustomize = False
        Me.LabelItem1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LabelItem1.Name = "LabelItem1"
        '
        'buttonItem47
        '
        Me.buttonItem47.BeginGroup = True
        Me.buttonItem47.Image = CType(resources.GetObject("buttonItem47.Image"), System.Drawing.Image)
        Me.buttonItem47.Name = "buttonItem47"
        Me.buttonItem47.Text = "Search for Templates Online..."
        '
        'buttonItem48
        '
        Me.buttonItem48.Image = CType(resources.GetObject("buttonItem48.Image"), System.Drawing.Image)
        Me.buttonItem48.Name = "buttonItem48"
        Me.buttonItem48.Text = "Browse for Templates..."
        '
        'buttonItem49
        '
        Me.buttonItem49.Image = CType(resources.GetObject("buttonItem49.Image"), System.Drawing.Image)
        Me.buttonItem49.Name = "buttonItem49"
        Me.buttonItem49.Text = "Save Current Template..."
        '
        'buttonReplace
        '
        Me.buttonReplace.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.buttonReplace.Enabled = False
        Me.buttonReplace.Image = CType(resources.GetObject("buttonReplace.Image"), System.Drawing.Image)
        Me.buttonReplace.Name = "buttonReplace"
        Me.buttonReplace.Text = "&Replace"
        '
        'buttonGoto
        '
        Me.buttonGoto.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.buttonGoto.Enabled = False
        Me.buttonGoto.Image = CType(resources.GetObject("buttonGoto.Image"), System.Drawing.Image)
        Me.buttonGoto.Name = "buttonGoto"
        Me.buttonGoto.Text = "&Goto"
        '
        'ButtonItem14
        '
        Me.ButtonItem14.BeginGroup = True
        Me.ButtonItem14.Image = CType(resources.GetObject("ButtonItem14.Image"), System.Drawing.Image)
        Me.ButtonItem14.Name = "ButtonItem14"
        Me.ButtonItem14.Text = "Search for Templates Online..."
        '
        'ButtonItem15
        '
        Me.ButtonItem15.Image = CType(resources.GetObject("ButtonItem15.Image"), System.Drawing.Image)
        Me.ButtonItem15.Name = "ButtonItem15"
        Me.ButtonItem15.Text = "Browse for Templates..."
        '
        'ButtonItem16
        '
        Me.ButtonItem16.Image = CType(resources.GetObject("ButtonItem16.Image"), System.Drawing.Image)
        Me.ButtonItem16.Name = "ButtonItem16"
        Me.ButtonItem16.Text = "Save Current Template..."
        '
        'tmnulo
        '
        Me.tmnulo.Interval = 5
        '
        'timernuevaventa
        '
        Me.timernuevaventa.Enabled = True
        '
        'gridventas
        '
        Me.gridventas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridventas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Ored, Me.Tipo, Me.cliente, Me.cantidad})
        Me.gridventas.Location = New System.Drawing.Point(2, 136)
        Me.gridventas.Name = "gridventas"
        Me.gridventas.RowHeadersVisible = False
        Me.gridventas.Size = New System.Drawing.Size(331, 146)
        Me.gridventas.TabIndex = 1
        Me.gridventas.Visible = False
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
        'lnotis
        '
        Me.lnotis.AutoSize = True
        Me.lnotis.BackColor = System.Drawing.Color.Transparent
        Me.lnotis.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnotis.ForeColor = System.Drawing.Color.Blue
        Me.lnotis.Location = New System.Drawing.Point(5, 109)
        Me.lnotis.Name = "lnotis"
        Me.lnotis.Size = New System.Drawing.Size(319, 24)
        Me.lnotis.TabIndex = 3
        Me.lnotis.Text = "NUEVAS VENTAS PENDIENTES"
        Me.lnotis.Visible = False
        '
        'mdiMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1022, 491)
        Me.Controls.Add(Me.lnotis)
        Me.Controls.Add(Me.gridventas)
        Me.ForeColor = System.Drawing.Color.Black
        Me.IsMdiContainer = True
        Me.KeyPreview = True
        Me.Name = "mdiMain"
        Me.Text = "Menu"
        CType(Me.gridventas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents timllamar As System.Windows.Forms.Timer
    Friend WithEvents StyleManager1 As DevComponents.DotNetBar.StyleManager
    Friend WithEvents StyleManager2 As DevComponents.DotNetBar.StyleManager
    Private WithEvents buttonItem47 As DevComponents.DotNetBar.ButtonItem
    Private WithEvents buttonItem48 As DevComponents.DotNetBar.ButtonItem
    Private WithEvents buttonItem49 As DevComponents.DotNetBar.ButtonItem
    Private WithEvents comboItem1 As DevComponents.Editors.ComboItem
    Private WithEvents comboItem2 As DevComponents.Editors.ComboItem
    Private WithEvents comboItem3 As DevComponents.Editors.ComboItem
    Private WithEvents comboItem4 As DevComponents.Editors.ComboItem
    Private WithEvents comboItem5 As DevComponents.Editors.ComboItem
    Private WithEvents comboItem6 As DevComponents.Editors.ComboItem
    Private WithEvents comboItem7 As DevComponents.Editors.ComboItem
    Private WithEvents comboItem8 As DevComponents.Editors.ComboItem
    Private WithEvents comboItem9 As DevComponents.Editors.ComboItem
    Private WithEvents checkBoxItem1 As DevComponents.DotNetBar.CheckBoxItem
    Private WithEvents checkBoxItem2 As DevComponents.DotNetBar.CheckBoxItem
    Private WithEvents checkBoxItem3 As DevComponents.DotNetBar.CheckBoxItem
    Private WithEvents checkBoxItem4 As DevComponents.DotNetBar.CheckBoxItem
    Private WithEvents checkBoxItem5 As DevComponents.DotNetBar.CheckBoxItem
    Private WithEvents checkBoxItem6 As DevComponents.DotNetBar.CheckBoxItem
    Private WithEvents buttonReplace As DevComponents.DotNetBar.ButtonItem
    Private WithEvents buttonGoto As DevComponents.DotNetBar.ButtonItem
    Private WithEvents buttonItem50 As DevComponents.DotNetBar.ButtonItem
    Private WithEvents buttonItem51 As DevComponents.DotNetBar.ButtonItem
    Private WithEvents buttonItem52 As DevComponents.DotNetBar.ButtonItem
    Private WithEvents ribbonTabItemGroup1 As DevComponents.DotNetBar.RibbonTabItemGroup
    Private WithEvents ButtonItem14 As DevComponents.DotNetBar.ButtonItem
    Private WithEvents ButtonItem15 As DevComponents.DotNetBar.ButtonItem
    Private WithEvents ButtonItem16 As DevComponents.DotNetBar.ButtonItem
    Private WithEvents ComboItem10 As DevComponents.Editors.ComboItem
    Private WithEvents ComboItem11 As DevComponents.Editors.ComboItem
    Private WithEvents ComboItem12 As DevComponents.Editors.ComboItem
    Private WithEvents ComboItem13 As DevComponents.Editors.ComboItem
    Private WithEvents ComboItem14 As DevComponents.Editors.ComboItem
    Private WithEvents ComboItem15 As DevComponents.Editors.ComboItem
    Private WithEvents ComboItem16 As DevComponents.Editors.ComboItem
    Private WithEvents ComboItem17 As DevComponents.Editors.ComboItem
    Private WithEvents ComboItem18 As DevComponents.Editors.ComboItem
    Private WithEvents RibbonTabItemGroup2 As DevComponents.DotNetBar.RibbonTabItemGroup
    Friend WithEvents tmnulo As System.Windows.Forms.Timer
    Friend WithEvents timernuevaventa As System.Windows.Forms.Timer
    Private WithEvents GalleryContainer3 As DevComponents.DotNetBar.GalleryContainer
    Private WithEvents LabelItem1 As DevComponents.DotNetBar.LabelItem
    Friend WithEvents gridventas As System.Windows.Forms.DataGridView
    Friend WithEvents Ored As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Tipo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cliente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cantidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lnotis As System.Windows.Forms.Label

End Class
