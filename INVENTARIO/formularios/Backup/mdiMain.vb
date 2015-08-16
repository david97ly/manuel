Imports System.Windows.Forms
Imports pjtProAdus
Public Class mdiMain
    Public usuario As String
    Private mMenu As New System.Windows.Forms.MainMenu()
    Private Sub mdiMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Form1.Close()
        Dim operacion As New clsUtilerias
        Me.WindowState() = FormWindowState.Maximized
        Me.Menu = mMenu
        mMenu = operacion.GeneraMenu(True, usuario, 0, mMenu.MenuItems)
        Me.Menu.MenuItems.Add("Salir")
        AgregarManejador(Me.Menu.MenuItems, 0)

    End Sub
    Private Sub AgregarManejador(ByVal menuItems As MenuItem.MenuItemCollection, ByVal nivel As Integer)
        For Each menuItem As MenuItem In menuItems
            AddHandler menuItem.Click, AddressOf Opciones_Click
            AgregarManejador(menuItem.MenuItems, nivel + 1)
        Next
    End Sub
    Private Sub Opciones_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim t As MenuItem
        t = sender
        Dim formulario As New Form
        Dim tipo As System.Type
        If t.Text = "Salir" Then
            'Cerrando el formulario inicial (Login) Puede confirmar
            frmLogin.Close()
        Else
            Try
                tipo = Type.GetType("pjtAdus." & t.Tag)
                formulario = Activator.CreateInstance(tipo)
                formulario.Show()
            Catch ex As Exception
                MessageBox.Show("El programa no existe")
            End Try
        End If
    End Sub
    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub
End Class
