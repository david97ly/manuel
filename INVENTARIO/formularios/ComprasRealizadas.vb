Imports logica
Public Class Compras_realizadas
    Private tfacturacompra As New clsMaestros(clsNomTab.eTbl.FacturaCompra)
    Private dtfacturacompra As DataTable
    Private tdetallefacutracompra As New clsMaestros(clsNomTab.eTbl.DetalleFacturaC)
    Private dtdetallefacturacompra As DataTable
    Private tproveedor As New clsMaestros(clsNomTab.eTbl.Proveedores)
    Private dtproveedor As DataTable

    Private loadf As Boolean = False
    Private tipof As String
    Private contaf As Short = 0
    Private ccf = False, fa = False, nc = False, nd = False, tic = False, otr = False

    Private Sub Compras_realizadas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try

            loadf = True
            Me.gridfacturacompras.Height = 384
            dtfacturacompra = tfacturacompra.Consultar()
            tipof = "todos"
            cargarcompras()
        Catch ex As Exception
            MsgBox("Ocurrio un error asegurese de haber llenado todos los campo correctamente", MsgBoxStyle.OkOnly, "Avise")
        End Try

    End Sub
    Public Sub hacerconsulta()
      
        If tipof = "todos" Then
            radiotodos()
        ElseIf tipof = "Factura" Then
            radiofacturas()
        Else
            radiocomprobantes()
        End If
    End Sub

    Public Sub cargarcompras()

        Try

            Dim nf As Short
            nf = dtfacturacompra.Rows.Count

            If nf = 0 Then
                Me.gridfacturacompras.RowCount = 1
                Me.gridfacturacompras.Rows(0).Cells(0).Value = ""
                Me.gridfacturacompras.Rows(0).Cells(1).Value = ""
                Me.gridfacturacompras.Rows(0).Cells(2).Value = ""
                Me.gridfacturacompras.Rows(0).Cells(3).Value = ""
                Me.gridfacturacompras.Rows(0).Cells(4).Value = ""
                Me.gridfacturacompras.Rows(0).Cells(5).Value = ""
                Me.gridfacturacompras.Rows(0).Cells(6).Value = ""
                Me.gridfacturacompras.Rows(0).Cells(7).Value = ""
            Else
                Me.gridfacturacompras.RowCount = nf
            End If

            For i As Integer = 0 To dtfacturacompra.Rows.Count - 1
                If dtfacturacompra.Rows(i).Item(11).ToString = "Credito" Then
                    If dtfacturacompra.Rows(i).Item(6).ToString = "1" Then
                        Me.gridfacturacompras.Rows(i).Cells(4).Style.BackColor = Color.Green
                    Else
                        Me.gridfacturacompras.Rows(i).Cells(4).Style.BackColor = Color.Orange
                    End If


                End If
                Me.gridfacturacompras.Rows(i).Cells(0).Value = dtfacturacompra.Rows(i).Item(1).ToString
                dtproveedor = tproveedor.Consultar(" where codproveedor = '" + dtfacturacompra.Rows(i).Item(3).ToString + "'")
                If dtproveedor.Rows(0).Item(9) = "inactivo" Then
                    Me.gridfacturacompras.Rows(i).Cells(1).Style.BackColor = Color.Red
                Else
                    Me.gridfacturacompras.Rows(i).Cells(1).Style.BackColor = Color.White
                End If
                Me.gridfacturacompras.Rows(i).Cells(1).Value = dtproveedor.Rows(0).Item(1)
                Me.gridfacturacompras.Rows(i).Cells(2).Value = dtfacturacompra.Rows(i).Item(2).ToString
                Dim s As Date = dtfacturacompra.Rows(i).Item(4)
                Me.gridfacturacompras.Rows(i).Cells(3).Value = s.Day.ToString + "/" + s.Month.ToString + "/" + s.Year.ToString

                Me.gridfacturacompras.Rows(i).Cells(4).Value = FormatNumber(CDbl(dtfacturacompra.Rows(i).Item(10)), 2)
               
            Next
        Catch ex As Exception
        End Try

    End Sub

    Private Sub botnuevo_Click(sender As Object, e As EventArgs) Handles botnuevo.Click
        compra.Show()
        Me.Close()
    End Sub

    Private Sub botdetalle_Click(sender As Object, e As EventArgs) Handles botdetalle.Click
        Try
            Dim id As Short = Me.gridfacturacompras.CurrentCell.RowIndex
            DetalledelaCompra.contador = id
            DetalledelaCompra.dtfacturac = Me.dtfacturacompra
            DetalledelaCompra.dtdetallefacturac = Me.dtdetallefacturacompra
            DetalledelaCompra.dtproveedores = Me.dtproveedor
            DetalledelaCompra.tipof = Me.tipof
            DetalledelaCompra.frmcr = Me
            DetalledelaCompra.Show()
            Me.Close()
        Catch ex As Exception
            MsgBox("Ocurrio un error asegurese de haber llenado todos los campo correctamente", MsgBoxStyle.OkOnly, "Avise")
        End Try

    End Sub


    Private Sub radiocomprobante_CheckedChanged(sender As Object, e As EventArgs)
        radiocomprobantes()
    End Sub

    Private Sub radiocomprobantes()
        Try
            dtfacturacompra = tfacturacompra.Consultar(" where tipo = 'Comprobante de Credito fiscal' ")
            tipof = "Comprovante de Credito fiscal"
            cargarcompras()
        Catch ex As Exception
            MsgBox("Ocurrio un error asegurese de haber llenado todos los campo correctamente", MsgBoxStyle.OkOnly, "Avise")
        End Try

    End Sub
    Private Sub radiofacturas()
        Try
            dtfacturacompra = tfacturacompra.Consultar(" where tipo = 'Factura' ")
            tipof = "Factura"
            cargarcompras()
        Catch ex As Exception
            MsgBox("Ocurrio un error asegurese de haber llenado todos los campo correctamente", MsgBoxStyle.OkOnly, "Avise")
        End Try

    End Sub
 
    Dim fl As Boolean = True
    Private Sub radiotodos()
        Try
            If fl <> False Then
                If loadf = True Then
                    dtfacturacompra = tfacturacompra.Consultar()
                    tipof = "todos"
                    cargarcompras()
                End If
            End If
        Catch ex As Exception
            MsgBox("Ocurrio un error asegurese de haber llenado todos los campo correctamente", MsgBoxStyle.OkOnly, "Avise")
        End Try

    End Sub
    Dim varbus As String
    Dim contvarbus As Short
    Private Sub texbusqueda_KeyPress(sender As Object, e As KeyPressEventArgs) Handles texbusqueda.KeyPress
        Try
            fl = False
            Me.radiotodo.Checked = True
            If (Asc(e.KeyChar) = 13) Or (Asc(e.KeyChar) = 46) Then
                Dim vc As String = Me.texbusqueda.Text.Trim.ToString
                vc = vc.Substring(0, contvarbus)
                Me.texbusqueda.Text = vc
            Else
                If (Asc(e.KeyChar)) = System.Windows.Forms.Keys.Back Then

                    If varbus.Length = 0 Then
                    Else

                        contvarbus = varbus.Length
                        If varbus.Length = 1 Then
                            varbus = varbus.Remove(contvarbus - 1, 1)
                        Else
                            varbus = varbus.Remove(contvarbus - 1, 1)
                            dtproveedor = tproveedor.Consultar(" where nombre like '%" + varbus + "%' ")
                            If dtproveedor.Rows.Count = 0 Then
                                dtfacturacompra = tfacturacompra.Consultar(" where (tipo like '%" & varbus & "%' or formadepago like '%" & varbus & "%'  or numfacturac like '%" & varbus & "%')")
                            Else
                                dtfacturacompra = tfacturacompra.Consultar(" where (tipo like '%" & varbus & "%' or formadepago like '%" & varbus & "%'  or numfacturac like '%" & varbus & "%' or codproveedor like '%" + dtproveedor.Rows(0).Item(0).ToString + "%')")
                            End If

                            If dtfacturacompra.Rows.Count <> 0 Then
                                cargarcompras()
                            End If
                        End If

                    End If

                Else
                    varbus += e.KeyChar
                    dtproveedor = tproveedor.Consultar(" where nombre like '%" + varbus + "%' ")
                    If dtproveedor.Rows.Count = 0 Then
                        dtfacturacompra = tfacturacompra.Consultar(" where  (tipo like '%" & varbus & "%' or formadepago like '%" & varbus & "%'  or numfacturac like '%" & varbus & "%')")
                    Else
                        dtfacturacompra = tfacturacompra.Consultar(" where (tipo like '%" & varbus & "%' or formadepago like '%" & varbus & "%'  or numfacturac like '%" & varbus & "%' or codproveedor like '%" + dtproveedor.Rows(0).Item(0).ToString + "%')")
                    End If

                    If dtfacturacompra.Rows.Count <> 0 Then
                        cargarcompras()
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox("Ocurrio un herror al buscar los datos razon: " + ex.Message, MsgBoxStyle.OkOnly, "Avise")
        End Try



    End Sub



    Private Sub botbuscar_Click(sender As Object, e As EventArgs) Handles botbuscar.Click
        Try
            Dim d1, m1, a1, d2, a2, m2, f1, f2 As String
            d1 = dt1.Value.Day
            m1 = dt1.Value.Month
            a1 = dt1.Value.Year
            f1 = a1 + "-" + m1 + "-" + d1
            d2 = dt2.Value.Day
            m2 = dt2.Value.Month
            a2 = dt2.Value.Year
            f2 = a2 + "-" + m2 + "-" + d2
            If Me.combotipo.Text = "Factura" Then
                dtfacturacompra = tfacturacompra.Consultar(" where tipo = 'Factura' and  fecha >= '" + f1 + "' and fecha <= '" + f2 + "'")
                tipof = "Factura"
                cargarcompras()
            ElseIf Me.combotipo.Text = "Comprovante de Credito fiscal" Then
                dtfacturacompra = tfacturacompra.Consultar(" where tipo = 'Comprovante de Credito fiscal' and  fecha >='" + f1 + "' and fecha <= '" + f2 + "'")
                tipof = "Comprovante de Credito fiscal"
                cargarcompras()
            ElseIf Me.radiotodo.Checked = True Then
                dtfacturacompra = tfacturacompra.Consultar(" where  fecha >='" + f1 + "' and fecha <= '" + f2 + "'")
                tipof = "todos"
                cargarcompras()
            End If
        Catch ex As Exception
            MsgBox("Ocurrio un error asegurese de haber llenado todos los campo correctamente", MsgBoxStyle.OkOnly, "Avise")
        End Try

    End Sub

    Private Sub checfecha_CheckedChanged(sender As Object, e As EventArgs) Handles checfecha.CheckedChanged
        If checfecha.Checked = True Then
            Me.gridfacturacompras.Height = 300
        Else
            Me.gridfacturacompras.Height = 384
        End If
    End Sub

    Private Sub botsalir_Click(sender As Object, e As EventArgs) Handles botsalir.Click
        Me.Close()
    End Sub


    Private Sub combotipo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles combotipo.SelectedIndexChanged
        Try
            Select Case Me.combotipo.Text.ToString.Trim
                Case "Factura"
                    fa = True
                    radiofacturas()
                Case "Comprobante de Credito fiscal"
                    ccf = True
                    radiocomprobantes()
                Case "Nota de credito"
                Case "Nota de debito2"
                Case "Tiquet"
                Case "Otros"
            End Select
        Catch ex As Exception

        End Try

    End Sub

    Private Sub radiotodo_Click(sender As Object, e As EventArgs) Handles radiotodo.Click
        radiotodos()
    End Sub

    Private Sub radiotipo_CheckedChanged(sender As Object, e As EventArgs) Handles radiotipo.CheckedChanged

        If Me.radiotipo.Checked = True Then
            Me.combotipo.Visible = True
        Else
            Me.combotipo.Visible = False
        End If
    End Sub


    Private Sub boteliminar_Click(sender As Object, e As EventArgs)
        Try
            Dim id As Short = Me.gridfacturacompras.CurrentCell.RowIndex
            Dim dl As New clsProcesos

            If dtfacturacompra.Rows(id).Item(13).ToString = "0" Then
                dl.Consultar(" delete from facturacompra where codfacturac = " & dtfacturacompra.Rows(id).Item(0))
                dl.Consultar(" delete from detallecompra where codfacturac = " & dtfacturacompra.Rows(id).Item(0))
                hacerconsulta()
            Else
                If MsgBox("Esta seguro que desea eliminar esta compra la operacion no podra revertirse", MsgBoxStyle.YesNo, "Aviso") = MsgBoxResult.Yes Then
                    Dim codfactura As Short = dtfacturacompra.Rows(id).Item(0)
                    Dim dtdetallecompra As DataTable
                    Dim tdetallecompra As New clsMaestros(clsNomTab.eTbl.DetalleFacturaC)

                    dtdetallecompra = tdetallecompra.Consultar(" where codfacturac = " & codfactura)

                    Dim dtprod As DataTable
                    Dim tprod As New clsMaestros(clsNomTab.eTbl.Productos)
                    Dim cp As Decimal
                    Dim c As New clsProcesos


                    For i As Integer = 0 To dtdetallecompra.Rows.Count - 1
                        cp = CDec(dtdetallecompra.Rows(i).Item(3))

                        dtprod = tprod.Consultar(" where codproducto = " & dtdetallecompra.Rows(i).Item(2))

                        cp = Math.Round((CDec(dtprod.Rows(0).Item(6)) - cp), 2)

                        c.Consultar(" Update productos set existencias = " & cp & " where codproducto = " & dtdetallecompra.Rows(i).Item(2))

                        If dtdetallecompra.Rows(i).Item(2).ToString = "1" Then
                        ElseIf dtdetallecompra.Rows(i).Item(2).ToString = "2" Then
                        ElseIf dtdetallecompra.Rows(i).Item(2).ToString = "3" Then


                        End If
                    Next

                    Dim cd1 As Decimal = CDec(dtfacturacompra.Rows(id).Item(18))
                    Dim cd2 As Decimal = CDec(dtfacturacompra.Rows(id).Item(19))
                    Dim cr As Decimal = CDec(dtfacturacompra.Rows(id).Item(20))
                    Dim cs As Decimal = CDec(dtfacturacompra.Rows(id).Item(21))




                    'para eliminanar la compra por completo
                    dl.Consultar(" delete from facturacompra where codfacturac = " & dtfacturacompra.Rows(id).Item(0))
                    dl.Consultar(" delete from detallecompra where codfacturac = " & dtfacturacompra.Rows(id).Item(0))
                    hacerconsulta()
                    MsgBox("La Compra se elimino exitozamente ", MsgBoxStyle.Information)
                End If

            End If


        Catch ex As Exception

        End Try

    End Sub

 
    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub
End Class