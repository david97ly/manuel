Imports System.Windows.Forms
Imports logica


Public Class mdiMain
    Public usuario As String
    Public mMenu As New System.Windows.Forms.MainMenu
    Public codigoempresa As String
    Private dtempresas As DataTable


    'parte de los productos
    Public productos As New clsProcesos
    Public dtproductos As DataTable
    Public dttablas As DataTable


    'termina parte de los productos


    'ihabiliara las teclas de acceso rapido
    Public teclas As Boolean = True
    Public llama As String

    Public anular As Boolean = False
    Public Sub llamar()

        Me.timllamar.Enabled = False
        If llama = "compra" Then
            compra.Show()
        Else
            Ventas.Show()
        End If

    End Sub

  

    Private Sub mdiMain_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        If teclas = True Then
            If (e.KeyChar) = "v" Or (e.KeyChar) = "V" Then
                llama = "Ventas"
                teclas = False
                llamar()
            End If

         

            If (e.KeyChar) = "c" Or (e.KeyChar) = "C" Then
                llama = "compra"
                teclas = False
                llamar()
            End If

            If (e.KeyChar) = "d" Then
                VentasDiarias.Show()
            End If

            If (e.KeyChar) = "r" Or (e.KeyChar) = "R" Then
                Form1.Show()

            End If

        End If

    End Sub

    Private Sub mdiMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Form1.Close()
        Me.WindowState() = FormWindowState.Maximized

        cargarmenu()
       


    End Sub

    Public Sub cargarmenu()

        Me.Text = "FerroElectrina Manuel"
        Dim operacion As New clsUtilerias
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

        If t.Text = "Cambiar Empresa" Then
            teclas = True
            Empresas.cambio = "si"
            Empresas.Show()
        Else
            If t.Text = "Salir" Then
                'Cerrando el formulario inicial (Login) Puede confirmar
                frmLogin.Close()
            Else
                Try
                    tipo = Type.GetType("pjtAdus." & t.Tag)
                    formulario = Activator.CreateInstance(tipo)
                    teclas = False
                    formulario.Show()
                Catch ex As Exception
                    MessageBox.Show("El programa no existe")
                End Try
            End If
        End If

    End Sub
    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub

    Private Sub timllamar_Tick(sender As Object, e As EventArgs) Handles timllamar.Tick
        llamar()
    End Sub

    Private Sub ButtonItem7_Click(sender As Object, e As EventArgs)
        Me.Close()

    End Sub

   

    Private Sub tmnulo_Tick(sender As Object, e As EventArgs) Handles tmnulo.Tick
        DetalleCompra.Show()
    End Sub
End Class
