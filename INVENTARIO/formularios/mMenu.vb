Imports logica

Imports MySql.Data
Public Class mMenu
    Dim codOpc As Short
    Private dtm As DataTable
    Private accion As String
    Private oMenu As New clsMaestros(clsNomTab.eTbl.Menu)
    Private Sub mMenu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = mdiMain
        ActualizaArbol()
        Me.TreeView1.SelectedNode = Me.TreeView1.TopNode
    End Sub
    Private Sub ActualizaArbol()
        Me.TreeView1.Nodes.Add(0, "Raiz")
        Try
            dtm = oMenu.Consultar()
            crearNodos(0, Nothing)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub crearNodos(ByVal ip As Integer, ByVal nodo As TreeNode)
        Dim dvArbol As DataView
        dvArbol = New DataView(dtm)
        dvArbol.RowFilter = dtm.Columns("nIdBar").ColumnName.ToString + " = " + ip.ToString()
        For Each drActual As DataRowView In dvArbol
            Dim nuevoNodo As New TreeNode
            nuevoNodo.Name = drActual("IdOpc").ToString.Trim
            nuevoNodo.Text = drActual("cNomOpc").ToString().Trim()
            If nodo Is Nothing Then
                Me.TreeView1.Nodes.Add(nuevoNodo)
            Else
                nodo.Nodes.Add(nuevoNodo)
            End If
            crearNodos(Int32.Parse(drActual("IdOpc").ToString()), nuevoNodo)
        Next drActual
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'Agrega Nodos
        Me.accion = "AD"
        Me.TextBox1.Text = ""
        Me.TextBox2.Text = ""
        Me.TextBox3.Text = ""
        Ed(False)
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        'Modifica
        Dim dvArbol As DataView
        codOpc = Me.TreeView1.SelectedNode.Name
        dvArbol = New DataView(dtm)
        dvArbol.RowFilter = dtm.Columns("IdOpc").ColumnName + " = " + codOpc.ToString
        Me.accion = "MO"
        If dvArbol.Count = 0 Then
            MessageBox.Show("No puede modificar el Raiz")
        Else
            codOpc = dvArbol.Item(0).Item(2).ToString
            Me.TextBox1.Text = dvArbol.Item(0).Item(1).ToString
            Me.TextBox2.Text = dvArbol.Item(0).Item(3).ToString
            Me.TextBox3.Text = dvArbol.Item(0).Item(4).ToString
            Ed(False)
        End If
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        'Elimina Nodos
        Dim mIdOpc As String
        mIdOpc = Me.TreeView1.SelectedNode.Name
        Try
            If oMenu.Eliminar("'" & mIdOpc & "'") > 0 Then
                Me.TreeView1.Nodes.Clear()
                ActualizaArbol()
            End If
            Ed(True)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Close()
    End Sub
    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        'Aceptar
        Dim mIdOpc As String
        Dim mOpcion As String
        Dim mIdBar As String
        Dim mAccion As String
        Dim mDescri As String
        mIdOpc = Me.TreeView1.SelectedNode.Name
        mOpcion = Me.TextBox1.Text.ToString.Trim.ToUpper
        mIdBar = codOpc
        mAccion = Me.TextBox2.Text.ToString.Trim
        mDescri = Me.TextBox3.Text.ToString.Trim.ToUpper()
        Try
            If Me.accion = "AD" Then
                oMenu.Insertar("'" & mOpcion & "','" & mIdOpc & "','" & mAccion & "','" & mDescri & "'")
            Else
                oMenu.Actualizar("'" & mIdOpc & "'|'" & mOpcion & "'|'" & mIdBar & "'|'" & mAccion & "'|'" & mDescri & "'")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Me.TreeView1.Nodes.Clear()
        ActualizaArbol()
        Ed(True)
    End Sub
    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        'Cancelar
        Ed(True)
    End Sub
    'Metodos definidos por el usuario
    Private Sub Ed(ByVal valor As Boolean)
        If valor Then
            Me.TreeView1.Visible = True
            Me.Button1.Enabled = True
            Me.Button2.Enabled = True
            Me.Button3.Enabled = True
        Else
            Me.TreeView1.Visible = False
            Me.Button1.Enabled = False
            Me.Button2.Enabled = False
            Me.Button3.Enabled = False
        End If
    End Sub
End Class