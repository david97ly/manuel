Public Class AnularDocumento

    Public forma As DetalleVenta

    Private Sub ButtonX1_Click(sender As Object, e As EventArgs) Handles ButtonX1.Click

        forma.duplicardocumento()
        Me.Close()
    End Sub

    Private Sub ButtonX2_Click(sender As Object, e As EventArgs) Handles ButtonX2.Click

        Me.Close()
    End Sub

    Private Sub ButtonX3_Click(sender As Object, e As EventArgs) Handles ButtonX3.Click

        Me.Close()
    End Sub

    Private Sub AnularDocumento_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class