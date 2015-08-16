Imports pjtProAdUs
Public Class frmLogin
    Private mUsr As New clsUtilerias
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim usr As String = Me.TextBox1.Text.Trim
        Dim clv As String = Me.TextBox2.Text.Trim

        Try
            If mUsr.ValidaUsuario(usr, clv) Then
                Me.Hide()
                mdiMain.usuario = usr
                mdiMain.Show()
            Else
                MessageBox.Show("Error. Usuario o contraseña incorrecto")
                Me.TextBox1.Text = ""
                Me.TextBox2.Text = ""
                Me.TextBox1.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Me.Dispose()
        End Try
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class
