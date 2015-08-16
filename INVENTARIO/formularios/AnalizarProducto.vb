Imports logica
Public Class AnalizarProducto
    Private tproveedores As New clsMaestros(clsNomTab.eTbl.Proveedores)
    Private dtproveedores As DataTable

    Private tcategoria As New clsMaestros(clsNomTab.eTbl.Categorias)
    Private dtcategoria As DataTable

    Private tproductos As New clsMaestros(clsNomTab.eTbl.Productos)
    Private dtproductos As DataTable

    Private compraventa As String
    Private dtdesdeg, dthastag As String

    Private stcategoria As String
    Private strcodproducto As String
    Private totalcompra As Integer
    Private totalventa As Integer

    Private tfacturacompra As New clsMaestros(clsNomTab.eTbl.FacturaCompra)
    Private dtfacturacompra As DataTable
    Private tdetallecompra As New clsMaestros(clsNomTab.eTbl.DetalleFacturaC)
    Private dtdetallecompra As DataTable

    Private tfacturaventa As New clsMaestros(clsNomTab.eTbl.FacturaVenta)
    Private dtfacturaventa As DataTable
    Private tdetalleventa As New clsMaestros(clsNomTab.eTbl.DetalleFacturaV)
    Private dtdetalleventa As DataTable


    Private Sub botaceptar_Click(sender As Object, e As EventArgs) Handles botaceptar.Click
        Try
            If Me.swboton.Value = False Then
                Me.lbcv.Text = "Comprado"
                Me.lbcv1.Text = "Comprado"
                compraventa = "compra"
                ventas.HeaderText = "Compras"
                Me.lbmvendido.ForeColor = Color.Green
                Me.lbcantiddmasvendido.ForeColor = Color.Green
                Me.lbmenosvendido.ForeColor = Color.Green
                Me.lbcantidadmenosvendido.ForeColor = Color.Green
            Else
                Me.lbcv.Text = "Vendido"
                Me.lbcv1.Text = "Vendido"
                compraventa = "venta"
                ventas.HeaderText = "Ventas"
                Me.lbmvendido.ForeColor = Color.Blue
                Me.lbcantiddmasvendido.ForeColor = Color.Blue
                Me.lbmenosvendido.ForeColor = Color.Blue
                Me.lbcantidadmenosvendido.ForeColor = Color.Blue
            End If

            cargargrid()
        Catch ex As Exception

        End Try

    End Sub
    Private Sub cargargrid()
        strcodproducto = ""
        totalcompra = 0
        totalventa = 0
        obtenerfecha(dtdesde, dthasta)
        cargarstrigcategoria()

        If stcategoria <> "todo" Then
            dtproductos = tproductos.Consultar(" where " & stcategoria & " and codempresa = " & mdiMain.codigoempresa.ToString)
        Else
            dtproductos = tproductos.Consultar(" where codempresa = " & mdiMain.codigoempresa.ToString)
        End If


        Dim nf As Short = dtproductos.Rows.Count

        If nf = 0 Then
            Me.DataGridViewX1.RowCount = 1
        Else
            Me.DataGridViewX1.RowCount = nf
        End If

        For i As Integer = 0 To dtproductos.Rows.Count - 1
            If i <> dtproductos.Rows.Count - 1 Then
                strcodproducto += "codarticulo = '" & dtproductos.Rows(i).Item(0) & "' or "

            Else
                strcodproducto += "codarticulo = '" & dtproductos.Rows(i).Item(0) & "' "
            End If
            Me.DataGridViewX1.Rows(i).Cells(0).Value = dtproductos.Rows(i).Item(0)
            Me.DataGridViewX1.Rows(i).Cells(1).Value = dtproductos.Rows(i).Item(1)
            Me.DataGridViewX1.Rows(i).Cells(2).Value = dtproductos.Rows(i).Item(5)
            Me.DataGridViewX1.Rows(i).Cells(3).Value = dtproductos.Rows(i).Item(6)
            Me.DataGridViewX1.Rows(i).Cells(4).Value = 0

        Next

        If compraventa = "compra" Then
            dtfacturacompra = tfacturacompra.Consultar(" where fecha >='" & dtdesdeg & "' and fecha <='" & dthastag & "' and codempresa = " & mdiMain.codigoempresa.ToString)

            For i As Integer = 0 To dtfacturacompra.Rows.Count - 1

                If stcategoria <> "todo" Then
                    dtdetallecompra = tdetallecompra.Consultar(" where (" & strcodproducto & ") and  codfacturac = " & dtfacturacompra.Rows(i).Item(0) & " and codempresa = " & mdiMain.codigoempresa.ToString)
                Else
                    dtdetallecompra = tdetallecompra.Consultar(" where codfacturac = " & dtfacturacompra.Rows(i).Item(0) & " and codempresa = " & mdiMain.codigoempresa.ToString)
                End If

                For j As Integer = 0 To dtdetallecompra.Rows.Count - 1

                    For k As Integer = 0 To nf - 1

                        If Me.DataGridViewX1.Rows(k).Cells(0).Value.ToString = dtdetallecompra.Rows(j).Item(2).ToString Then
                            Dim cn As Integer = 0
                            cn = CInt(Me.DataGridViewX1.Rows(k).Cells(4).Value)
                            cn += CInt(dtdetallecompra.Rows(j).Item(8))
                            Me.DataGridViewX1.Rows(k).Cells(4).Value = cn
                        End If

                    Next

                Next
                totalcompra += CInt(dtfacturacompra.Rows(i).Item(7))
            Next
            'pr = (totalc * 100) / total
            Dim fl As Boolean = False
            For i As Integer = 0 To nf - 1
                Dim c As Integer = 0
                Dim d As Integer = 0
                c = CInt(Me.DataGridViewX1.Rows(i).Cells(4).Value)
                d = CInt(c + (c * 0.13))

                d = (d * 100) / totalcompra
                Me.DataGridViewX1.Rows(i).Cells(4).Value = d
                Me.DataGridViewX1.Rows(i).Cells(4).ToolTipText = d & "%"

                If fl = False Then
                    fl = True
                    Me.lbmvendido.Text = Me.DataGridViewX1.Rows(i).Cells(1).Value.ToString
                    Me.lbcantiddmasvendido.Text = c

                    Me.lbmenosvendido.Text = Me.DataGridViewX1.Rows(i).Cells(1).Value.ToString
                    Me.lbcantidadmenosvendido.Text = c
                Else
                    If c > CInt(Me.lbcantiddmasvendido.Text) Then
                        Me.lbmvendido.Text = Me.DataGridViewX1.Rows(i).Cells(1).Value.ToString
                        Me.lbcantiddmasvendido.Text = c
                    End If

                    If c < CInt(Me.lbcantidadmenosvendido.Text) Then
                        Me.lbmenosvendido.Text = Me.DataGridViewX1.Rows(i).Cells(1).Value.ToString
                        Me.lbcantidadmenosvendido.Text = c
                    End If
                End If

            Next
        Else
            dtfacturaventa = tfacturaventa.Consultar(" where fecha >='" & dtdesdeg & "' and fecha <='" & dthastag & "' and codempresa = " & mdiMain.codigoempresa.ToString)

            For i As Integer = 0 To dtfacturaventa.Rows.Count - 1

                If stcategoria <> "todo" Then
                    dtdetalleventa = tdetalleventa.Consultar(" where (" & strcodproducto & ") and  codfacturav = " & dtfacturaventa.Rows(i).Item(0) & " and codempresa = " & mdiMain.codigoempresa.ToString)
                Else
                    dtdetalleventa = tdetalleventa.Consultar(" where codfacturav = " & dtfacturaventa.Rows(i).Item(0) & " and codempresa = " & mdiMain.codigoempresa.ToString)
                End If

                For j As Integer = 0 To dtdetalleventa.Rows.Count - 1

                    For k As Integer = 0 To nf - 1

                        If Me.DataGridViewX1.Rows(k).Cells(0).Value.ToString = dtdetalleventa.Rows(j).Item(2).ToString Then
                            Dim cn As Integer = 0
                            cn = CInt(Me.DataGridViewX1.Rows(k).Cells(4).Value)
                            cn += CInt(dtdetalleventa.Rows(j).Item(8))
                            Me.DataGridViewX1.Rows(k).Cells(4).Value = cn
                        End If

                    Next

                Next
                totalventa += CInt(dtfacturaventa.Rows(i).Item(7))
            Next
            'pr = (totalc * 100) / total
            Dim fl As Boolean = False
            For i As Integer = 0 To nf - 1
                Dim c As Integer = 0
                Dim d As Integer = 0
                c = CInt(Me.DataGridViewX1.Rows(i).Cells(4).Value)
                d = CInt(c + (c * 0.13))

                d = (d * 100) / totalventa
                Me.DataGridViewX1.Rows(i).Cells(4).Value = d
                Me.DataGridViewX1.Rows(i).Cells(4).ToolTipText = d & "%"

                If fl = False Then
                    fl = True
                    Me.lbmvendido.Text = Me.DataGridViewX1.Rows(i).Cells(1).Value.ToString
                    Me.lbcantiddmasvendido.Text = c

                    Me.lbmenosvendido.Text = Me.DataGridViewX1.Rows(i).Cells(1).Value.ToString
                    Me.lbcantidadmenosvendido.Text = c
                Else
                    If c > CInt(Me.lbcantiddmasvendido.Text) Then
                        Me.lbmvendido.Text = Me.DataGridViewX1.Rows(i).Cells(1).Value.ToString
                        Me.lbcantiddmasvendido.Text = c
                    End If

                    If c < CInt(Me.lbcantidadmenosvendido.Text) Then
                        Me.lbmenosvendido.Text = Me.DataGridViewX1.Rows(i).Cells(1).Value.ToString
                        Me.lbcantidadmenosvendido.Text = c
                    End If
                End If

            Next
        End If

    End Sub

    Private Sub cargarstrigcategoria()
        stcategoria = ""
        Dim nf As Short = datacategoria.RowCount - 1
        Dim cn As Short = 0
        Dim cn1 As Short = 0
        If datacategoria.Rows(0).Cells(1).Value <> True Then
            For i As Integer = 0 To nf - 1
                If datacategoria.Rows(i + 1).Cells(1).Value = True Then
                    cn += 1
                End If
            Next

            For i As Integer = 0 To nf - 1
                If datacategoria.Rows(i + 1).Cells(1).Value = True Then
                    cn1 += 1
                    If cn = cn1 Then
                        stcategoria += "idcategoria = " & dtcategoria.Rows(i).Item(0).ToString
                    Else
                        stcategoria += "idcategoria = " & dtcategoria.Rows(i).Item(0).ToString & " or "
                    End If

                End If
            Next

            If cn = 0 Then
                datacategoria.Rows(0).Cells(1).Value = True
                stcategoria = "todo"
            End If
        Else
            stcategoria = "todo"
        End If

    End Sub
    Private Sub obtenerfecha(ByRef desde As DateTimePicker, ByRef hasta As DateTimePicker)
        dtdesdeg = desde.Value.Year.ToString + "-"
        dtdesdeg += desde.Value.Month.ToString + "-"
        dtdesdeg += desde.Value.Day.ToString

        dthastag = hasta.Value.Year.ToString + "-"
        dthastag += hasta.Value.Month.ToString + "-"
        dthastag += hasta.Value.Day.ToString
    End Sub
    Private Sub cargarcategoria()
        dtcategoria = tcategoria.Consultar(" where codempresa = " & mdiMain.codigoempresa.ToString)
        Me.datacategoria.RowCount = dtcategoria.Rows.Count + 1
        Me.datacategoria.Rows(0).Cells(0).Value = "Todos"
        Me.datacategoria.Rows(0).Cells(1).Value = True
        For i As Integer = 0 To dtcategoria.Rows.Count - 1
            Me.datacategoria.Rows(i + 1).Cells(0).Value = dtcategoria.Rows(i).Item(1)
        Next
    End Sub
    Private Sub AnalizarProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MdiParent = mdiMain
        cargarcategoria()
    End Sub

End Class