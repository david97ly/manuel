Imports logica
Public Class frmLogin
    Private mUsr As New clsUtilerias
    'Definir variables globales; estas van despues de la linea de inherits

    Dim ex, ey As Integer

    Dim Arrastre As Boolean

    'Estas tres subrutinas permiten desplazar el formulario. 

    Private Sub Form1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseDown

        ex = e.X

        ey = e.Y

        Arrastre = True

    End Sub

    Private Sub Form1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseUp

        Arrastre = False

    End Sub

    Private Sub Form1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseMove

        'Si el formulario no tiene borde (FormBorderStyle = none) la siguiente linea funciona bien

        If Arrastre Then Me.Location = Me.PointToScreen(New Point(Control.MousePosition.X - Me.Location.X - ex, Control.MousePosition.Y - Me.Location.Y - ey))

        'pero si quieres dejar los bordes y la barra de titulo entonces es necesario descomentar la siguiente linea y comentar la anterior, osea ponerle el apostrofe

        'If Arrastre Then Me.Location = Me.PointToScreen(New Point(Me.MousePosition.X - Me.Location.X - ex - 8, Me.MousePosition.Y - Me.Location.Y - ey - 60))

    End Sub
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        'Me.texidusuario.Text = "admin"
        'Me.texcontraseña.Text = "admin"
    End Sub
  
    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Me.Close()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Dim usr As String = Me.texidusuario.Text.Trim
        Dim clv As String = Me.texcontraseña.Text.Trim

        Try
            If mUsr.ValidaUsuario(usr, clv) Then
                Me.Hide()
                mdiMain.usuario = usr
                mdiMain.Show()
            Else
                MessageBox.Show("Error. Usuario o contraseña incorrecto")
                Me.texidusuario.Text = ""
                Me.texcontraseña.Text = ""
                Me.texidusuario.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Me.Dispose()
        End Try
    End Sub


    Private Sub PictureBox1_MouseHover(sender As Object, e As EventArgs) Handles PictureBox1.MouseHover
        Me.PictureBox1.Visible = False
        Me.PictureBox2.Visible = True
    End Sub

   

    Private Sub PictureBox3_MouseHover(sender As Object, e As EventArgs) Handles PictureBox3.MouseHover
        Me.PictureBox3.Visible = False
        Me.PictureBox4.Visible = True
    End Sub

    Private Sub frmLogin_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        Me.PictureBox4.Visible = False
        Me.PictureBox3.Visible = True
        Me.PictureBox2.Visible = False
        Me.PictureBox1.Visible = True
    End Sub

    Private Sub texidusuario_KeyPress(sender As Object, e As KeyPressEventArgs) Handles texidusuario.KeyPress, texcontraseña.KeyPress
        If (Asc(e.KeyChar)) = 13 Then
            PictureBox2_Click(sender, e)
        End If
    End Sub

 
End Class
