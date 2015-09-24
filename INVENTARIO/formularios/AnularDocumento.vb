Public Class AnularDocumento

    Public forma As DetalleVenta

    Private Sub botcancelar_Click(sender As Object, e As EventArgs) Handles botcancelar.Click
        Me.Close()

    End Sub

    Private Sub ButtonX1_Click(sender As Object, e As EventArgs) Handles ButtonX1.Click
        forma.duplicardocumento()
        Me.Close()
    End Sub

    Private Sub botmanual_Click(sender As Object, e As EventArgs) Handles botmanual.Click
        forma.soloanular()
        Me.Close()
    End Sub
End Class