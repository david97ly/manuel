Imports logica

Public Class frmBusqueda
    Public tituloB As String
    Public Resultado As String
    Private dtm As DataTable
    Private mGrupos As New clsMaestros(clsNomTab.eTbl.Grp)
    Private Sub frmBusqueda_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = tituloB
        'Dando formato a la cuadricula
        Me.DataGridView1.ColumnCount = 2
        Me.DataGridView1.Columns(0).Width = 100
        Me.DataGridView1.Columns(1).Width = 200
        Me.DataGridView1.Columns(0).HeaderText = "Codigo"
        Me.DataGridView1.Columns(1).HeaderText = "Grupo"
        LlenaGrid()
    End Sub
    Private Sub LlenaGrid()
        Dim nf As Short
        Try
            dtm = mGrupos.Consultar()
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
            frmError.Show()
            frmError.TextBox1.Text = ex.Message
        End Try
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Resultado = ""
        Me.Hide()
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim fs As Short = Me.DataGridView1.CurrentCell.RowIndex
        Resultado = Me.dtm.Rows(fs).Item(0).ToString & " | " & Me.dtm.Rows(fs).Item(1).ToString
        Me.Hide()
    End Sub
End Class