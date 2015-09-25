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
        actualizargrid()
    End Sub

    Private Sub botatender_Click(sender As Object, e As EventArgs)
        MsgBox("El codigo de la factura es: " & idfactura)
    End Sub

    Private Sub timerhijo_Tick(sender As Object, e As EventArgs) Handles timerhijo.Tick
        Me.WindowState() = FormWindowState.Minimized
        Me.MdiParent = mdiMain
        Me.timerhijo.Enabled = False
    End Sub

    Public Sub actualizargrid()
        dtnoti = tnoti.Consultar
        cargargrid()
    End Sub

    Public Sub cargargrid()

        Dim nf As Short
        nf = dtnoti.Rows.Count



        If nf = 0 Then
            Me.gridventas.RowCount = 1
            Me.gridventas.Rows(0).Cells(0).Value = ""
            Me.gridventas.Rows(0).Cells(1).Value = ""
            Me.gridventas.Rows(0).Cells(2).Value = ""
            Me.gridventas.Rows(0).Cells(3).Value = ""


        Else
            Me.gridventas.RowCount = nf
        End If

        For i As Integer = 0 To dtnoti.Rows.Count - 1
            Me.gridventas.Rows(i).Cells(0).Value = Me.dtnoti.Rows(i).Item(1)

            Me.gridventas.Rows(i).Cells(1).Value = Me.dtnoti.Rows(i).Item(2)
            Me.gridventas.Rows(i).Cells(2).Value = Me.dtnoti.Rows(i).Item(3)
            Me.gridventas.Rows(i).Cells(3).Value = Me.dtnoti.Rows(i).Item(4)
        Next
    End Sub

    Private Sub botseleccionar_Click(sender As Object, e As EventArgs) Handles botseleccionar.Click
        Dim id As Short = Me.gridventas.CurrentCell.RowIndex
        id = dtnoti.Rows(id).Item(5)
        MsgBox("El codigo de la factura es: " & id)
    End Sub
End Class