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
    Private contador As Short = 0
    Public anular As Boolean = False

    'para la poscion en que aparecen'
    Public py As Short = 0
    Public px As Short = 0
    Public ventanas As Short = 0


    Public grp As New clsMaestros(clsNomTab.eTbl.Grp)
    Public grpusr As New clsMaestros(clsNomTab.eTbl.GrpUsr)

    Public dtgrp As DataTable
    Public dtgrpusr As DataTable


    'para las notificaciones
    Public cantidadf As Double
    Public idfactura As Short
    Public orden As Short

    Public super As Boolean = True 'para determinar si es super usuario o no'

    Public dtnoti As DataTable
    Public tnoti As New clsMaestros(clsNomTab.eTbl.notificaciones)

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
        'Me.timernuevaventa.Enabled = True
        cargarmenu()
       
        dtgrpusr = grpusr.Consultar(" where idUsr = '" & usuario & "'")

        dtgrp = grp.Consultar(" where IdGrp = " & dtgrpusr.Rows(0).Item(1).ToString)

        If dtgrp.Rows(0).Item(1).ToString = "SUPER USUARIO" Then
            timernuevaventa.Enabled = True
            super = True
        Else
            timernuevaventa.Enabled = False
            super = False
        End If


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
    End Sub

    Private Sub timernuevaventa_Tick(sender As Object, e As EventArgs) Handles timernuevaventa.Tick
   

        dtnoti = tnoti.Consultar()

        If dtnoti.Rows.Count > 0 Then
            'para las llamadas a los pedidos
            Dim vn As New nventa

            vn.Show()


            Me.timernuevaventa.Enabled = False
        End If




           


    End Sub

    Public Sub setearventanas()
        ventanas = ventanas - 1
        If ventanas = 0 Then
            Me.py = 0
            Me.px = 0
            Me.timernuevaventa.Enabled = True
        End If
    End Sub

End Class
