Imports logica

Public Class frmPermisos
    Private idgrp As String
    Private opcPadre As String
    Private opcSelec As String = ""
    Private opcSelEl As String = ""
    Private dtm As DataTable
    Private dtmAsig As DataTable
    Private obGen As New clsProcesos
    Private Sub frmPermisos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = mdiMain
        ActivaBotones(False)
    End Sub
    Private Sub cmdBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBuscar.Click
        'Busqueda de Grupos
        Dim rcmp As String
        frmBusqueda.tituloB = "Busqueda de Grupos"
        frmBusqueda.ShowDialog()
        rcmp = frmBusqueda.Resultado
        frmBusqueda.Close()
        If rcmp = "" Then
            MessageBox.Show("No selecciono ningun registro")
        Else
            Me.txtGrupo.Text = rcmp
            Me.idgrp = rcmp.Substring(0, rcmp.IndexOf("|") - 1)
            ActivaBotones(True)
            ActualizaArbol()
            ActualizaArbolAsig()
            Me.opcDisp.SelectedNode = Me.opcDisp.TopNode
            Me.opcAsig.SelectedNode = Me.opcAsig.TopNode
        End If
    End Sub
    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()
    End Sub
    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        Dim cadena As String
        If opcSelec = "0" Then
            MessageBox.Show("Ya existe la Raiz")
        Else
            cadena = "insert into permisos (IdGrp,IdOpc) values ('" & idgrp & "','" & opcSelec & "')"
            If Me.opcAsig.Nodes.Find(Me.opcPadre, True).Length = 0 Then
                MessageBox.Show("Primero Agregue la Menu al que pertenece")
            Else
                If Me.opcAsig.Nodes.Find(Me.opcSelec, True).Length = 0 Then
                    If obGen.Ejecutar(cadena) > 0 Then
                        Me.opcAsig.Nodes.Clear()
                        ActualizaArbolAsig()
                        Me.opcDisp.Nodes.Clear()
                        ActualizaArbol()
                    Else
                        MessageBox.Show("Opcion no Asignada")
                    End If
                Else
                    MessageBox.Show("La opcion ya esta agregada")
                End If
            End If
        End If
    End Sub
    Private Sub ActualizaArbol()
        Me.opcDisp.Nodes.Clear()
        Me.opcDisp.Nodes.Add(0, "Raiz")
        Try
            dtm = obGen.Consultar("SELECT IdOpc, cNomOpc, nIdBar, cAccion, cDescripcion FROM menu where idOpc not in (select idOpc from permisos WHERE idgrp='" & Me.idgrp & "') OR nIdBar='0'")
            crearNodos(0, Nothing)
            Me.opcDisp.ExpandAll()
        Catch ex As Exception
            frmError.Show()
            frmError.TextBox1.Text = ex.Message
        End Try
    End Sub
    Private Sub ActualizaArbolAsig()
        Me.opcAsig.Nodes.Clear()
        Me.opcAsig.Nodes.Add(0, "Raiz")
        Try
            dtmAsig = PermisosAsignados(Me.idgrp)
            crearNodosAsig(0, Nothing)
            Me.opcAsig.ExpandAll()
        Catch ex As Exception
            frmError.Show()
            frmError.TextBox1.Text = ex.Message
        End Try
    End Sub
    Private Sub crearNodos(ByVal ip As Integer, ByVal nodo As TreeNode)
        Dim dvArbol As DataView
        dvArbol = New DataView(dtm)
        dvArbol.RowFilter = dtm.Columns("nIdBar").ColumnName + " = " + ip.ToString()
        For Each drActual As DataRowView In dvArbol
            Dim nuevoNodo As New TreeNode
            nuevoNodo.Name = drActual("IdOpc").ToString.Trim
            nuevoNodo.Text = drActual("cNomOpc").ToString().Trim()
            If nodo Is Nothing Then
                Me.opcDisp.Nodes.Add(nuevoNodo)
            Else
                nodo.Nodes.Add(nuevoNodo)
            End If
            crearNodos(Int32.Parse(drActual("IdOpc").ToString()), nuevoNodo)
        Next drActual
    End Sub
    Private Sub crearNodosAsig(ByVal ip As Integer, ByVal nodo As TreeNode)
        Dim dvArbol As DataView
        dvArbol = New DataView(dtmAsig)
        dvArbol.RowFilter = dtmAsig.Columns("nIdBar").ColumnName + " = " + ip.ToString()
        For Each drActual As DataRowView In dvArbol
            Dim nuevoNodo As New TreeNode
            nuevoNodo.Name = drActual("IdOpc").ToString.Trim
            nuevoNodo.Text = drActual("cNomOpc").ToString().Trim()
            nuevoNodo.Tag = drActual("IdPermiso").ToString().Trim()
            If nodo Is Nothing Then
                Me.opcAsig.Nodes.Add(nuevoNodo)
            Else
                nodo.Nodes.Add(nuevoNodo)
            End If
            crearNodosAsig(Int32.Parse(drActual("IdOpc").ToString()), nuevoNodo)
        Next drActual
    End Sub
    Private Sub opcDisp_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles opcDisp.AfterSelect
        Me.opcSelec = Me.opcDisp.SelectedNode.Name
        Try
            Me.opcPadre = Me.opcDisp.SelectedNode.Parent.Name
        Catch ex As Exception
            Me.opcPadre = "0"
        End Try
    End Sub
    Private Sub cmdElimina_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdElimina.Click
        Me.opcSelEl = Me.opcAsig.SelectedNode.Tag
        If Me.opcAsig.SelectedNode.Nodes.Count = 0 Then
            If obGen.Ejecutar("DELETE FROM permisos WHERE IdPermiso = '" & Me.opcSelEl & "'") = 0 Then
                MessageBox.Show("Hubo un error en la eliminacion")
            Else
                Me.opcAsig.Nodes.Clear()
                ActualizaArbolAsig()
                Me.opcDisp.Nodes.Clear()
                ActualizaArbol()
            End If
        Else
            MessageBox.Show("No puede eliminar la opcion, porque contiene subopciones")
        End If
    End Sub
    Private Sub ActivaBotones(ByVal valor As Boolean)
        If valor Then
            Me.cmdAdd.Enabled = True
            Me.cmdElimina.Enabled = True
            Me.cmdAddTodos.Enabled = True
            Me.cmdElTodos.Enabled = True
        Else
            Me.cmdAdd.Enabled = False
            Me.cmdElimina.Enabled = False
            Me.cmdAddTodos.Enabled = False
            Me.cmdElTodos.Enabled = False
        End If
    End Sub
    Private Sub cmdAddTodos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAddTodos.Click
        'Dim dtper As New DataTable
        'Dim nr As Short = 0
        'dtper = mntPermisos.Consultar(" WHERE IdGrp ='" & Me.idgrp & "'")
        'For i As Short = 0 To dtper.Rows.Count - 1
        'nr = nr + mntPermisos.Eliminar("'" & dtper.Rows(i).Item(0) & "'")
        'Next
    End Sub
    Public Function PermisosAsignados(ByVal IdGrp As String) As DataTable
        Dim dt As DataTable
        Dim sql As String
        sql = "SELECT a.IdPermiso, a.IdGrp, a.IdOpc, b.cNomOpc, b.nIdBar FROM permisos a, menu b WHERE a.IdOpc = b.IdOpc AND a.IdGrp='" & IdGrp & "'"
        dt = obGen.Consultar(sql)
        Return dt
    End Function
End Class