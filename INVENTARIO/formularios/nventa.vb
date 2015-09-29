Imports logica
Public Class nventa

    Public NumeroOrden As Short
    Public py As Short
    Public px As Short


    Public idfactura As Short
    Dim dtnoti As DataTable
    Dim tnoti As New clsMaestros(clsNomTab.eTbl.notificaciones)


    Public dtfacturav As DataTable
    Public tfacturav As New clsMaestros(clsNomTab.eTbl.DetalleFacturaV)

    Public dtclientes As DataTable
    Public tclientes As New clsMaestros(clsNomTab.eTbl.Clientes)
    Public tclientesf As New clsMaestros(clsNomTab.eTbl.clientescf)

    Private Sub nventa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Me.MdiParent = mdiMain

        Me.Location = New Point(px, py)

    End Sub

    Private Sub botatender_Click(sender As Object, e As EventArgs)
        MsgBox("El codigo de la factura es: " & idfactura)
    End Sub

    Private Sub timerhijo_Tick(sender As Object, e As EventArgs) Handles timerhijo.Tick
        Me.WindowState() = FormWindowState.Minimized
        Me.MdiParent = mdiMain
        Me.timerhijo.Enabled = False
    End Sub

    

End Class