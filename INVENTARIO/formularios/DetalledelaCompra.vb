Imports logica
Public Class DetalledelaCompra

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
    Public donde As String = "here"

    Private Sub DetalledelaCompra_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        hacerconsulta()
        cargarfacturac()
    End Sub


    Private Sub hacerconsulta()
        Try
            If tipof = "todos" Then
                dtfacturac = tfacturac.Consultar()
                Me.max = dtfacturac.Rows.Count - 1
            Else
                dtfacturac = tfacturac.Consultar(" where tipo = '" + tipof + "'")
                Me.max = dtfacturac.Rows.Count - 1
            End If
        Catch ex As Exception
            MsgBox("Ocurrio un error en la consulta", MsgBoxStyle.OkOnly, "Avise")
        End Try

    End Sub

    Public Sub cargarfacturac()

        Try
            If modi = True Then
                hacerconsulta()
            End If
            dtproveedores = tproveedores.Consultar(" where codproveedor = '" + dtfacturac.Rows(contador).Item(3).ToString & "'")
            Me.texnumfact.Text = dtfacturac.Rows(contador).Item(1)
            Me.texnit.Text = dtproveedores.Rows(0).Item(2)
            Me.texnrc.Text = dtproveedores.Rows(0).Item(3)
            Me.texproveedor.Text = dtproveedores.Rows(0).Item(1)

            Me.texformapago.Text = dtfacturac.Rows(contador).Item(11)
            Me.textipo.Text = dtfacturac.Rows(contador).Item(2)

            Me.textfecha.Text = dtfacturac.Rows(contador).Item(4)


            Me.texsumas.Text = dtfacturac.Rows(contador).Item(5)
            Me.texiva.Text = dtfacturac.Rows(contador).Item(7)
            Me.texivauno.Text = dtfacturac.Rows(contador).Item(12)
            Me.textotal.Text = dtfacturac.Rows(contador).Item(10)

            If dtfacturac.Rows(contador).Item(11).ToString = "Credito" Then

                If dtfacturac.Rows(contador).Item(6).ToString = "1" Then
                    Me.botpagar.Text = "Cancelado"
                    Me.botpagar.BackColor = Color.Green
                    Me.botpagar.Visible = True
                Else
                    Me.botpagar.Text = "Pagar"
                    Me.botpagar.BackColor = Color.Orange
                    Me.botpagar.Visible = True
                End If
            Else
                Me.botpagar.Visible = False
                
            End If
          

            cargargrid()

            If CDbl(Me.textotal.Text.ToString) <> 0 Then
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
            End If


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
                dtproductos = tproductos.Consultar(" where codproducto = '" + dtdetallefacturac.Rows(i).Item(2).ToString & "'")
                Me.gridcompra.Rows(i).Cells(0).Value = dtproductos.Rows(0).Item(0)
                Me.gridcompra.Rows(i).Cells(1).Value = dtdetallefacturac.Rows(i).Item(3)
                Me.gridcompra.Rows(i).Cells(2).Value = dtproductos.Rows(0).Item(1)
                Me.gridcompra.Rows(i).Cells(3).Value = dtdetallefacturac.Rows(i).Item(9)
                Me.gridcompra.Rows(i).Cells(4).Value = "0"
                Me.gridcompra.Rows(i).Cells(5).Value = "0"
                Me.gridcompra.Rows(i).Cells(6).Value = dtdetallefacturac.Rows(i).Item(7)
            Next
        Catch ex As Exception

        End Try

    End Sub


    Private Sub botderecha_Click(sender As Object, e As EventArgs) Handles botde.Click
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

    Private Sub botizquierda_Click(sender As Object, e As EventArgs) Handles botiz.Click
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


    Private Sub botguardar_Click(sender As Object, e As EventArgs) Handles botguardar.Click

        salirdetalle()
    End Sub

    Private Sub salirdetalle()
        Compras_realizadas.Show()

        Me.Close()
    End Sub

    Private Sub boteditar_Click(sender As Object, e As EventArgs) Handles boteditar.Click
        compra.codfacturac = dtfacturac.Rows(contador).Item(0)
        compra.donde = "detallecompra"
        Me.donde = "compras"
        compra.estado = "editando"
        compra.Show()
        Me.Close()

    End Sub

    Private Sub boteditar_Disposed(sender As Object, e As EventArgs) Handles boteditar.Disposed
        If donde = "here" Then
            Compras_realizadas.Show()
        End If

    End Sub

    Private Sub boteliminar_Click(sender As Object, e As EventArgs) Handles boteliminar.Click
        Try

            If MsgBox("Esta seguro de eliminar este Documento? la accion no podra ser revertida", MsgBoxStyle.YesNo, "Aviso") = MsgBoxResult.Yes Then
                Dim facturacompras As New clsMaestros(clsNomTab.eTbl.FacturaCompra)
                Dim dtdetallefacturacompra As DataTable
                Dim detallefacturacompra As New clsMaestros(clsNomTab.eTbl.DetalleFacturaC)
                Dim dtproducto As DataTable
                Dim consultar As New clsProcesos

                'MsgBox(dtfacturac.Rows(contador).Item(0).ToString)
                dtdetallefacturacompra = detallefacturacompra.Consultar(" where codfacturac = '" + dtfacturac.Rows(contador).Item(0).ToString + "'")

                Dim c As Double = 0
                For i As Integer = 0 To dtdetallefacturacompra.Rows.Count - 1
                    dtproducto = tproductos.Consultar(" where codproducto = '" + dtdetallefacturacompra.Rows(i).Item(2).ToString + "'")
                    c = CDbl(CDbl(dtproducto.Rows(0).Item(6)) - dtdetallefacturacompra.Rows(i).Item(3))
                    consultar.Consultar(" update productos set existencias = " + c.ToString + " where codproducto = '" + dtdetallefacturacompra.Rows(i).Item(2).ToString + "'")
                Next

                consultar.Consultar(" delete from facturacompra where codfacturac = " & dtfacturac.Rows(contador).Item(0))
                salirdetalle()

                MsgBox("La factura se elimino exitozamente", MsgBoxStyle.Information, "Exito")
            End If
           

        Catch ex As Exception
            MsgBox("Ocurrio un error al eliminar la factura razon: " & ex.Message, MsgBoxStyle.Critical, "ERROR")
        End Try



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles botpagar.Click
        If botpagar.Text <> "Cancelado" Then
            If MsgBox("Esta seguro de efectuar esta acción", MsgBoxStyle.YesNo, "Aviso") = MsgBoxResult.Yes Then
                Try
                    Dim codigofactura As String = dtfacturac.Rows(contador).Item(0).ToString
                    Dim consulta As New clsProcesos

                    consulta.Consultar(" update facturacompra set descuento = 1 where codfacturac = " & codigofactura)
                    Me.botpagar.Visible = False
                    hacerconsulta()
                    cargarfacturac()
                    MsgBox("La deuda se cancelo efectivamente", MsgBoxStyle.Information, "Exito")

                Catch ex As Exception
                    MsgBox("Ocurrio un error razon: " & ex.Message, MsgBoxStyle.Critical, "EROR")
                End Try

            End If
        End If
       

    End Sub
End Class