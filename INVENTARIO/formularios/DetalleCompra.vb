Imports logica
Public Class DetalleCompra
    Private tfacturac As New clsMaestros(clsNomTab.eTbl.FacturaCompra)
    Public dtfacturac As DataTable
    Private tdetallefacturac As New clsMaestros(clsNomTab.eTbl.DetalleFacturaC)
    Public dtdetallefacturac As DataTable
    Private tproveedores As New clsMaestros(clsNomTab.eTbl.Proveedores)
    Public dtproveedores As DataTable
    Private tproductos As New clsMaestros(clsNomTab.eTbl.Productos)
    Public dtproductos As DataTable
    Public frmcr As Compras_realizadas
    Public tipof As String
    Public contador As Integer = 0
    Public max As Integer
    Public modi As Boolean = False
    Private Sub DetalleCompra_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        hacerconsulta()
        cargarfacturac()

    End Sub

    Private Sub hacerconsulta()
        Try
            If tipof = "todos" Then
                dtfacturac = tfacturac.Consultar(" where codempresa = " + mdiMain.codigoempresa.ToString)
                Me.max = dtfacturac.Rows.Count - 1
            Else
                dtfacturac = tfacturac.Consultar(" where codempresa = " + mdiMain.codigoempresa.ToString + " and tipo = '" + tipof + "'")
                Me.max = dtfacturac.Rows.Count - 1
            End If
        Catch ex As Exception
            MsgBox("Ocurrio un error asegurese de haber llenado todos los campo correctamente", MsgBoxStyle.OkOnly, "Avise")
        End Try

    End Sub
    Public Sub cargarfacturac()

        Try
            If modi = True Then
                hacerconsulta()
            End If
            dtproveedores = tproveedores.Consultar(" where codproveedor = '" + dtfacturac.Rows(contador).Item(3).ToString + "' and codempresa = '" + mdiMain.codigoempresa.ToString + "'")
            Me.texnumero.Text = dtfacturac.Rows(contador).Item(1)
            Me.texnit.Text = dtproveedores.Rows(0).Item(2)
            Me.texnrc.Text = dtproveedores.Rows(0).Item(3)
            Me.lnomproveedor.Text = dtproveedores.Rows(0).Item(1)
            Me.lbdireccion.Text = dtproveedores.Rows(0).Item(5)
            Me.lformadepago.Text = dtfacturac.Rows(contador).Item(14)
            Me.ltipodefactura.Text = dtfacturac.Rows(contador).Item(2)
            Me.textotal.Text = dtfacturac.Rows(contador).Item(10)
            Me.lfecha.Text = dtfacturac.Rows(contador).Item(5)
            Me.lgiro.Text = dtproveedores.Rows(0).Item(4)

            Me.texsumas.Text = dtfacturac.Rows(contador).Item(6)
            Me.texdescuento.Text = dtfacturac.Rows(contador).Item(7)
            Me.texiva.Text = dtfacturac.Rows(contador).Item(8)
            Me.texnosujeta.Text = dtfacturac.Rows(contador).Item(9)
            Me.texfovial.Text = dtfacturac.Rows(contador).Item(10)
            Me.texcotrans.Text = dtfacturac.Rows(contador).Item(11)
            Me.textotal.Text = dtfacturac.Rows(contador).Item(13)
            Me.texiva1.Text = dtfacturac.Rows(contador).Item(15)


            Dim numletras1 As New NumeroLetras
            Dim nl As String
            numletras1.setnumero(textotal.Text.ToString)
            nl = numletras1.getnumero().ToString & " dolares "

            If numletras1.getdecimal() > 0 Then
                Dim nn As String
                If numletras1.getdecimal() < 11 Then
                    nn = numletras1.getdecimal() & "0"

                    nl = nl & "con " & nn & "/100 cent"
                Else
                    nl = nl & "con " & numletras1.getdecimal.ToString & "/100 cent"
                End If

            Else
                nl = nl
            End If

            Me.lson.Text = nl

            cargargrid()
        Catch ex As Exception
            MsgBox("Ocurrio un error al cargar los datos" + ex.Message, MsgBoxStyle.Critical, "Aviso")
        End Try
    End Sub
    Private Sub cargargrid()
        Try
            dtdetallefacturac = tdetallefacturac.Consultar(" where codfacturac = '" + dtfacturac.Rows(contador).Item(0).ToString + "'")
            Dim nf As Short
            nf = dtdetallefacturac.Rows.Count


            If nf = 0 Then
                Me.gridcompra.RowCount = 1
                Me.gridcompra.Rows(0).Cells(0).Value = ""
                Me.gridcompra.Rows(0).Cells(1).Value = ""
                Me.gridcompra.Rows(0).Cells(2).Value = ""
                Me.gridcompra.Rows(0).Cells(3).Value = ""
                Me.gridcompra.Rows(0).Cells(4).Value = ""
                Me.gridcompra.Rows(0).Cells(5).Value = ""
                Me.gridcompra.Rows(0).Cells(6).Value = ""
            Else
                Me.gridcompra.RowCount = nf
            End If

            For i As Integer = 0 To dtdetallefacturac.Rows.Count - 1
                dtproductos = tproductos.Consultar(" where codproducto = " + CInt(dtdetallefacturac.Rows(i).Item(2)).ToString)
                Me.gridcompra.Rows(i).Cells(0).Value = dtproductos.Rows(0).Item(0)
                Me.gridcompra.Rows(i).Cells(1).Value = dtproductos.Rows(0).Item(1)
                Me.gridcompra.Rows(i).Cells(2).Value = dtproductos.Rows(0).Item(2)
                Me.gridcompra.Rows(i).Cells(3).Value = dtdetallefacturac.Rows(i).Item(3)
                Me.gridcompra.Rows(i).Cells(4).Value = dtdetallefacturac.Rows(i).Item(5)
                Me.gridcompra.Rows(i).Cells(5).Value = dtdetallefacturac.Rows(i).Item(6)
                Me.gridcompra.Rows(i).Cells(6).Value = dtdetallefacturac.Rows(i).Item(8)
            Next
        Catch ex As Exception

        End Try

    End Sub
    Private Sub botderecha_Click(sender As Object, e As EventArgs) Handles botderecha.Click
        Try
            contador += 1
            If contador > max Then
                contador = 0
                cargarfacturac()
            Else
                cargarfacturac()
            End If
        Catch ex As Exception
            MsgBox("Ocurrio un error asegurese de haber llenado todos los campo correctamente", MsgBoxStyle.OkOnly, "Avise")
        End Try


    End Sub

    Private Sub botizquierda_Click(sender As Object, e As EventArgs) Handles botizquierda.Click
        Try
            contador -= 1
            If contador < 0 Then
                contador = max
                cargarfacturac()
            Else
                cargarfacturac()
            End If
        Catch ex As Exception
            MsgBox("Ocurrio un error asegurese de haber llenado todos los campo correctamente", MsgBoxStyle.OkOnly, "Avise")
        End Try


    End Sub

   

    Private Sub botsalir_Click(sender As Object, e As EventArgs) Handles botsalir.Click
        Me.Close()
    End Sub





    Private Sub boteliminar_Click(sender As Object, e As EventArgs)

    End Sub
End Class