Imports pjtProADUS
Public Class frmLogin
    Private mUsr As New clsUtilerias
    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        Dim usr As String = Me.txtLogin.Text.Trim
        Dim clv As String = Me.txtClave.Text.Trim
        Try
            If mUsr.ValidaUsuario(usr, clv) Then
                Me.Hide()
                mdiMain.usuario = usr
                mdiMain.Show()
            Else
                MessageBox.Show("Error. Usuario o contraseña incorrecto")
                Me.txtLogin.Text = ""
                Me.txtClave.Text = ""
                Me.txtLogin.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Me.Dispose()
        End Try
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
    Private Sub frmLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub
End Class
