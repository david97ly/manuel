Imports logica
Public Class VentasRealizadas

    Private tfacturaventa As New clsMaestros(clsNomTab.eTbl.FacturaVenta)
    Private dtfacturaventa As DataTable
    Private tdetallefacutaventa As New clsMaestros(clsNomTab.eTbl.DetalleFacturaV)
    Private dtdetallefacturaventa As DataTable
    Private tclientes As New clsMaestros(clsNomTab.eTbl.Clientes)
    Private dtclientes As DataTable

    Private tclientescf As New clsMaestros(clsNomTab.eTbl.clientescf)

    Private loadf As Boolean = False
    Private tipof As String


    Private ccf = False, fa = False, nc = False, nd = False, tic = False, otr = False
    Private Sub VentasRealizadas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MdiParent = mdiMain
        loadf = True
        dtfacturaventa = tfacturaventa.Consultar(" where codempresa = " + mdiMain.codigoempresa.ToString)
        tipof = "todos"
        cargarventas()
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


    Public Sub cargarventas()

        Try

            Dim nf As Short
            nf = dtfacturaventa.Rows.Count

            If nf = 0 Then
                Me.gridfacturaventas.RowCount = 1
                Me.gridfacturaventas.Rows(0).Cells(0).Value = ""
                Me.gridfacturaventas.Rows(0).Cells(1).Value = ""
                Me.gridfacturaventas.Rows(0).Cells(2).Value = ""
                Me.gridfacturaventas.Rows(0).Cells(3).Value = ""
                Me.gridfacturaventas.Rows(0).Cells(4).Value = ""
                Me.gridfacturaventas.Rows(0).Cells(5).Value = ""
                Me.gridfacturaventas.Rows(0).Cells(6).Value = ""
                Me.gridfacturaventas.Rows(0).Cells(7).Value = ""
                Me.gridfacturaventas.Rows(0).Cells(8).Value = ""
            Else
                Me.gridfacturaventas.RowCount = nf
            End If

            For i As Integer = 0 To dtfacturaventa.Rows.Count - 1

                Me.gridfacturaventas.Rows(i).Cells(0).Value = dtfacturaventa.Rows(i).Item(1).ToString

                If dtfacturaventa.Rows(i).Item(2).ToString = "Factura" Then
                    dtclientes = tclientescf.Consultar(" where idclientescf = " + dtfacturaventa.Rows(i).Item(3).ToString)
                    If dtclientes.Rows.Count = 0 Then
                        dtclientes = tclientes.Consultar(" where codcliente = '" + dtfacturaventa.Rows(i).Item(3).ToString + "'")
                    End If
                Else
                    dtclientes = tclientes.Consultar(" where codcliente = '" + dtfacturaventa.Rows(i).Item(3).ToString + "'")
                    If dtclientes.Rows.Count = 0 Then
                        dtclientes = tclientescf.Consultar(" where idclientescf = " + dtfacturaventa.Rows(i).Item(3).ToString)
                    Else
                        If dtclientes.Rows(0).Item(17) = "inactivo" Then
                            Me.gridfacturaventas.Rows(i).Cells(1).Style.BackColor = Color.Red
                        Else
                            Me.gridfacturaventas.Rows(i).Cells(1).Style.BackColor = Color.White
                        End If
                    End If

                End If

               

                Me.gridfacturaventas.Rows(i).Cells(1).Value = dtclientes.Rows(0).Item(1)
                Me.gridfacturaventas.Rows(i).Cells(2).Value = dtfacturaventa.Rows(i).Item(2).ToString
                Dim s As Date = dtfacturaventa.Rows(i).Item(5)
                Me.gridfacturaventas.Rows(i).Cells(3).Value = s.Day.ToString + "/" + s.Month.ToString + "/" + s.Year.ToString
                Me.gridfacturaventas.Rows(i).Cells(4).Value = FormatNumber(CDbl(dtfacturaventa.Rows(i).Item(8)) + CDbl(dtfacturaventa.Rows(i).Item(10)) + CDbl(dtfacturaventa.Rows(i).Item(11)), 2)
                Me.gridfacturaventas.Rows(i).Cells(5).Value = FormatNumber(CDbl(dtfacturaventa.Rows(i).Item(6)), 2)

            Next
        Catch ex As Exception

        End Try
    End Sub


    Private Sub radiofactura_CheckedChanged(sender As Object, e As EventArgs)
        radiofacturas()
    End Sub

    Private Sub radiocomprobante_CheckedChanged(sender As Object, e As EventArgs)
        radiocomprobantes()
    End Sub

    Private Sub radiotodo_CheckedChanged(sender As Object, e As EventArgs) Handles radiotodo.CheckedChanged
        radiotodos()
    End Sub

    Private Sub radiocomprobantes()
        dtfacturaventa = tfacturaventa.Consultar(" where tipo = 'Comprobante de Credito fiscal' and codempresa = " + mdiMain.codigoempresa.ToString)
        tipof = "Comprobante de Credito fiscal"
        cargarventas()
    End Sub

    Private Sub radiofacturas()
        dtfacturaventa = tfacturaventa.Consultar(" where tipo = 'Factura' and codempresa = " + mdiMain.codigoempresa.ToString)
        tipof = "Factura"
        cargarventas()
    End Sub

    Private Sub radiotodos()
        If loadf = True Then
            dtfacturaventa = tfacturaventa.Consultar(" where codempresa = " + mdiMain.codigoempresa.ToString)
            tipof = "todos"
            cargarventas()
        End If
    End Sub

    Dim varbus As String
    Dim fl As Boolean = True
    Private Sub texbusqueda_KeyPress(sender As Object, e As KeyPressEventArgs) Handles texbusqueda.KeyPress
        Try
            fl = False
            Me.radiotodo.Checked = True
            If (Asc(e.KeyChar) = 13) Then
            Else
                If (Asc(e.KeyChar)) = System.Windows.Forms.Keys.Back Then
                    Dim contvarbus As Short

                    If varbus.Length = 0 Then
                    Else
                        contvarbus = varbus.Length
                        If varbus.Length = 1 Then
                            varbus = varbus.Remove(contvarbus - 1, 1)
                        Else
                            varbus = varbus.Remove(contvarbus - 1, 1)

                            dtclientes = tclientes.Consultar(" where nombre like '%" + varbus + "%' and codempresa = " + mdiMain.codigoempresa.ToString)
                            If dtclientes.Rows.Count = 0 Then
                                dtfacturaventa = tfacturaventa.Consultar(" where codempresa = " + mdiMain.codigoempresa.ToString + " and " + "(tipo like '%" & varbus & "%' or formadepago like '%" & varbus & "%'  or numfacturav like '%" & varbus & "%')")
                            Else
                                dtfacturaventa = tfacturaventa.Consultar(" where codempresa = " + mdiMain.codigoempresa.ToString + " and " + "(tipo like '%" & varbus & "%' or formadepago like '%" & varbus & "%'  or numfacturav like '%" & varbus & "%' or codcliente like '%" + dtclientes.Rows(0).Item(0).ToString + "%')")
                            End If

                            If dtfacturaventa.Rows.Count <> 0 Then
                                cargarventas()
                            End If
                        End If

                    End If
                Else

                    varbus += e.KeyChar
                    dtclientes = tclientes.Consultar(" where nombre like '%" + varbus + "%' and codempresa = " + mdiMain.codigoempresa.ToString)
                    If dtclientes.Rows.Count = 0 Then
                        dtfacturaventa = tfacturaventa.Consultar(" where codempresa = " + mdiMain.codigoempresa.ToString + " and " + "(tipo like '%" & varbus & "%' or formadepago like '%" & varbus & "%'  or numfacturav like '%" & varbus & "%')")
                    Else
                        dtfacturaventa = tfacturaventa.Consultar(" where codempresa = " + mdiMain.codigoempresa.ToString + " and " + "(tipo like '%" & varbus & "%' or formadepago like '%" & varbus & "%'  or numfacturav like '%" & varbus & "%' or codcliente like '%" + dtclientes.Rows(0).Item(0).ToString + "%')")
                    End If

                    If dtfacturaventa.Rows.Count <> 0 Then
                        cargarventas()
                    End If
                End If
            End If
        Catch ex As Exception

        End Try
      
    End Sub

    Private Sub botsalir_Click(sender As Object, e As EventArgs) Handles botsalir.Click
        Me.Close()
    End Sub

    Private Sub radiotipo_CheckedChanged(sender As Object, e As EventArgs) Handles radiotipo.CheckedChanged
        If Me.radiotipo.Checked = True Then
            Me.combotipo.Visible = True
        Else
            Me.combotipo.Visible = False
        End If
    End Sub


    Private Sub checfecha_CheckedChanged(sender As Object, e As EventArgs) Handles checfecha.CheckedChanged
        If checfecha.Checked = True Then
            Me.gridfacturaventas.Height = 300
        Else
            Me.gridfacturaventas.Height = 384
        End If
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

    Private Sub botbuscar_Click_1(sender As Object, e As EventArgs) Handles botbuscar.Click
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
                dtfacturaventa = tfacturaventa.Consultar(" where tipo = 'Factura' and codempresa = " + mdiMain.codigoempresa.ToString + " and fecha >= '" + f1 + "' and fecha <= '" + f2 + "'")
                tipof = "Factura"
                cargarventas()
            ElseIf Me.combotipo.Text = "Comprovante de Credito fiscal" Then
                dtfacturaventa = tfacturaventa.Consultar(" where tipo = 'Comprovante de Credito fiscal' and codempresa = " + mdiMain.codigoempresa.ToString + " and fecha >='" + f1 + "' and fecha <= '" + f2 + "'")
                tipof = "Comprovante de Credito fiscal"
                cargarventas()
            ElseIf Me.radiotodo.Checked = True Then
                dtfacturaventa = tfacturaventa.Consultar(" where codempresa = " + mdiMain.codigoempresa.ToString + " and fecha >='" + f1 + "' and fecha <= '" + f2 + "'")
                tipof = "todos"
                cargarventas()
            End If
        Catch ex As Exception

        End Try

    End Sub

  
    Private Sub botnuevo_Click_1(sender As Object, e As EventArgs) Handles botnuevo.Click
        Ventas.Show()
        Me.Close()
    End Sub


    Private Sub botdetalle_Click_1(sender As Object, e As EventArgs) Handles botdetalle.Click
        Dim id As Short = Me.gridfacturaventas.CurrentCell.RowIndex
        DetalleVenta.contador = id
        DetalleVenta.dtfacturav = Me.dtfacturaventa
        DetalleVenta.dtdetallefacturav = Me.dtdetallefacturaventa
        DetalleVenta.dtclientes = Me.dtclientes
        DetalleVenta.tipof = Me.tipof
        DetalleVenta.frmvr = Me
        DetalleVenta.Show()
    End Sub

  
    Private Sub boteliminar_Click(sender As Object, e As EventArgs) Handles boteliminar.Click
        Dim id As Short = Me.gridfacturaventas.CurrentCell.RowIndex
        Dim dl As New clsProcesos

        If dtfacturaventa.Rows(id).Item(13).ToString = "0" Then
            dl.Consultar(" delete from facturaventa where codfacturav = " & dtfacturaventa.Rows(id).Item(0))
            dl.Consultar(" delete from detalleventa where codfacturav = " & dtfacturaventa.Rows(id).Item(0))

            Dim dtcodf As DataTable
            Dim tcodf As New clsProcesos
            Dim n As String = ""
            Dim n1 As Integer = 0

            If dtfacturaventa.Rows(id).Item(2).ToString() = "Factura" Then

                dtcodf = tcodf.Consultar("select max(tirajefa) from tirajes")

                n = dtcodf.Rows(0).Item(0).ToString
                n1 = CInt(n) - 1

                tcodf.Consultar("update tirajes set tirajefa = '" & n1 & "'")

            Else
                dtcodf = tcodf.Consultar("select max(tirajeca) from tirajes")

                n = dtcodf.Rows(0).Item(0).ToString
                n1 = CInt(n) - 1

                tcodf.Consultar("update tirajes set tirajeca = '" & n1 & "'")

            End If


            hacerconsulta()
            cargarventas()
        Else
            MsgBox("Este documento no se puede eliminar solo se puede anular", MsgBoxStyle.Information, "Aviso")
        End If
    End Sub
End Class