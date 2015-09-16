Imports logica
Public Class nventa

    Public NumeroOrden As Short
    Public py As Short
    Public px As Short



    Private Sub nventa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Me.MdiParent = mdiMain
        Me.Label1.Text = NumeroOrden
        Me.Location = New Point(px, py)

    End Sub

    Private Sub botatender_Click(sender As Object, e As EventArgs) Handles botatender.Click
        pjtAdus.Ventas.Show()
        pjtAdus.mdiMain.setearventanas()
        Me.Close()
    End Sub

    Private Sub timerhijo_Tick(sender As Object, e As EventArgs) Handles timerhijo.Tick
        Me.WindowState() = FormWindowState.Minimized
        Me.MdiParent = mdiMain
        Me.timerhijo.Enabled = False
    End Sub
End Class