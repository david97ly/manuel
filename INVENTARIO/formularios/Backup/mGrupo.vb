Imports pjtProAdus
Public Class mGrupo
    Private mntGrupo As New clsMaestros(clsNomTab.eTbl.Grp)
    Private dtm As DataTable
    Private accion As String
    Private Sub mGrupo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = mdiMain
        'Dando formato a la cuadricula
        Me.DataGridView1.ColumnCount = 2
        Me.DataGridView1.Columns(0).Width = "150"
        Me.DataGridView1.Columns(1).Width = "200"
        Me.DataGridView1.Columns(0).HeaderText = "Codigo"
        Me.DataGridView1.Columns(1).HeaderText = "Grupo"
        ActualizaGrid()
        Me.TextBox1.Enabled = False
    End Sub
    Private Sub ActualizaGrid()
        Dim nf As Short
        Try
            dtm = mntGrupo.Consultar()
            nf = dtm.Rows.Count
            If nf = 0 Then
                Me.DataGridView1.RowCount = 1
            Else
                Me.DataGridView1.RowCount = nf
            End If
            For i As Integer = 0 To dtm.Rows.Count - 1
                Me.DataGridView1.Rows(i).Cells(0).Value = dtm.Rows(i).Item(0).ToString
                Me.DataGridView1.Rows(i).Cells(1).Value = dtm.Rows(i).Item(1).ToString
            Next
        Catch ex As Exception
            'frmError.Show()
            'frmError.TextBox1.Text = ex.Message
            MessageBox.Show(ex.Message)  
        End Try
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        'Agregar
        Me.accion = "AD"
        Me.TextBox1.Text = ""
        Me.TextBox2.Text = ""
        Me.TextBox2.Focus()
        Ed(False)
    End Sub
    Private Sub Ed(ByVal valor As Boolean)
        If valor Then
            Me.DataGridView1.Visible = True
            Me.Button3.Enabled = True
            Me.Button4.Enabled = True
            Me.Button5.Enabled = True
        Else
            Me.DataGridView1.Visible = False
            Me.Button3.Enabled = False
            Me.Button4.Enabled = False
            Me.Button5.Enabled = False
        End If
    End Sub
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        'Modifica
        Dim fs As Short = Me.DataGridView1.CurrentCell.RowIndex
        'Asignando valores del datagrid
        Me.TextBox1.Text = Me.dtm.Rows(fs).Item(0).ToString
        Me.TextBox2.Text = Me.dtm.Rows(fs).Item(1).ToString
        Me.TextBox2.Focus()
        Me.accion = "MO"
        Ed(False)
    End Sub
    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        'Elimina
        Dim codGrp As String
        Dim fs As Short = Me.DataGridView1.CurrentCell.RowIndex
        codGrp = Me.dtm.Rows(fs).Item(0)
        Try
            If mntGrupo.Eliminar("'" & codGrp & "'") <= 0 Then
                MessageBox.Show("El registro no se eliminó")
            Else
                Me.ActualizaGrid()
            End If
        Catch ex As Exception
            'frmError.Show()
            'frmError.TextBox1.Text = ex.Message
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        'Aceptar
        Dim mIdGrp As String
        Dim mGrp As String
        mIdGrp = Me.TextBox1.Text.ToString.Trim.ToUpper
        mGrp = Me.TextBox2.Text.ToString.Trim.ToUpper()
        Try
            If Me.accion = "AD" Then
                mntGrupo.Insertar("'" & mGrp & "'")
            Else
                mntGrupo.Actualizar("'" & mIdGrp & "'|'" & mGrp & "'")
            End If
        Catch ex As Exception
            'frmError.Show()
            'frmError.TextBox1.Text = ex.Message
            MessageBox.Show(ex.Message)
        End Try
        Ed(True)
        ActualizaGrid()
    End Sub
    Private Sub Button2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.Click
        'Cancela
        Ed(True)
    End Sub
    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Me.Close()
    End Sub
End Class