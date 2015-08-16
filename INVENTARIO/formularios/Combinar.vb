Imports logica
Imports validaciones
Public Class Combinar
    Public dtrproductos As DataRow
    Private proveedor As New clsMaestros(clsNomTab.eTbl.Proveedores)
    Private categoria As New clsMaestros(clsNomTab.eTbl.Categorias)
    Private productos As New clsMaestros(clsNomTab.eTbl.Productos)

    Private dtproveedor As DataTable
    Private dtcategoria As DataTable
    Private dtproductos As DataTable
    Public dtrproveedor As DataRow
    Public dtrcate As DataRow
    Public dtfacturasc As DataTable
    Public dtarticulosc As DataTable
    Private consulta As New clsProcesos
    Private id As Short
    Public idcategoria As String
    Public idproveedor As String
    'contador de filas 
    Private contador As Short = 0
    Private Sub texnombre_Click(sender As Object, e As EventArgs) Handles texnombre.Click
        pjtAdus.Productos.donde = "cambio"
        pjtAdus.Productos.frmcambio = Me
        pjtAdus.Productos.Show()
    End Sub


    Private Sub Combinar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MdiParent = mdiMain
    End Sub

    Public Sub generarprov()
        dtproveedor = proveedor.Consultar(" where codproveedor = " & Me.texproveedor.Text.Trim.ToString)
        Me.texproveedor.Text = dtproveedor.Rows(0).Item(1)
    End Sub
    Private Function mismo()
        Dim fl As Boolean = False
        Dim i As Short = 0
        While i < contador And fl <> True
            If Me.DataGridViewX1.Rows(i).Cells(0).Value = dtrproductos.Item(0) Then
                fl = True
            Else
                fl = False
            End If
            i += 1
        End While


        Return fl
    End Function
    Private Sub botagregar_Click(sender As Object, e As EventArgs) Handles botagregar.Click
        If Me.texnombre.Text <> "" And mismo() <> True Then

            contador += 1
            Me.DataGridViewX1.RowCount = contador

            Me.DataGridViewX1.Rows(contador - 1).Cells(0).Value = dtrproductos.Item(0)
            Me.DataGridViewX1.Rows(contador - 1).Cells(1).Value = dtrproductos.Item(1)
            Me.DataGridViewX1.Rows(contador - 1).Cells(2).Value = dtrproductos.Item(3)
            Me.DataGridViewX1.Rows(contador - 1).Cells(3).Value = dtrproductos.Item(6)
            Me.DataGridViewX1.Rows(contador - 1).Cells(4).Value = Me.texproveedor.Text.ToString
            Me.texnombre.Text = ""
            Me.texprecio.Text = ""
            Me.texexistencias.Text = ""
            Me.texproveedor.Text = ""
        End If
    End Sub

    Private Sub botremover_Click(sender As Object, e As EventArgs) Handles botremover.Click
        Dim id As Short = DataGridViewX1.CurrentCell.RowIndex

        For i As Integer = id To contador - 1
            If i < contador - 1 Then
                Me.DataGridViewX1.Rows(i).Cells(0).Value = Me.DataGridViewX1.Rows(i + 1).Cells(0).Value
                Me.DataGridViewX1.Rows(i).Cells(1).Value = Me.DataGridViewX1.Rows(i + 1).Cells(1).Value
                Me.DataGridViewX1.Rows(i).Cells(2).Value = Me.DataGridViewX1.Rows(i + 1).Cells(2).Value
                Me.DataGridViewX1.Rows(i).Cells(3).Value = Me.DataGridViewX1.Rows(i + 1).Cells(3).Value
                Me.DataGridViewX1.Rows(i).Cells(4).Value = Me.DataGridViewX1.Rows(i + 1).Cells(4).Value
            Else
                Me.DataGridViewX1.Rows(i).Cells(0).Value = ""
                Me.DataGridViewX1.Rows(i).Cells(1).Value = ""
                Me.DataGridViewX1.Rows(i).Cells(2).Value = ""
                Me.DataGridViewX1.Rows(i).Cells(3).Value = ""
                Me.DataGridViewX1.Rows(i).Cells(4).Value = ""
            End If

        Next

        Me.DataGridViewX1.RowCount = contador - 1
        contador -= 1
    End Sub

    Private Sub bocombinar_Click(sender As Object, e As EventArgs)
        generarnuevo()

    End Sub

    Private Sub generarnuevo()

    End Sub
    Private Sub todossobreuno()
        id = Me.DataGridViewX1.CurrentCell.RowIndex
        Dim existencias As Short = 0
        For i As Integer = 0 To contador - 1
            existencias += CShort(Me.DataGridViewX1.Rows(i).Cells(3).Value)
        Next

        dtproductos = productos.Consultar(" where codproducto = '" & Me.DataGridViewX1.Rows(id).Cells(0).Value.ToString & "'")

        Me.texncodigo.Text = dtproductos.Rows(0).Item(0)
        Me.texnnombre.Text = dtproductos.Rows(0).Item(1)
        Me.texndescripcion.Text = dtproductos.Rows(0).Item(2)

        Me.texnproveedor.Text = ""
        Me.texnprecio.Text = dtproductos.Rows(0).Item(3)
        Me.texnpreciopublico.Text = dtproductos.Rows(0).Item(5)
        Me.texnexistencias.Text = existencias.ToString
        'dtcategoria = categoria.Consultar(" where id_categoria = " & dtproductos.Rows(0).Item(8))
        'idcategoria = dtproductos.Rows(0).Item(8).ToString
        Me.texncategoria.Text = ""
        Me.texnunidad.Text = dtproductos.Rows(0).Item(10)
    End Sub
    Private Sub todouno_Click(sender As Object, e As EventArgs) Handles todouno.Click
        If contador > 1 Then
            todossobreuno()
        End If
    End Sub

    Private Sub texnproveedor_Click(sender As Object, e As EventArgs) Handles texnproveedor.Click
        pjtAdus.Proveedores.donde = "cambio"
        pjtAdus.Proveedores.frmcambio = Me
        pjtAdus.Proveedores.Show()
    End Sub

    Private Sub texncategoria_Click(sender As Object, e As EventArgs) Handles texncategoria.Click
        pjtAdus.Categoria.donde = "cambio"
        pjtAdus.Categoria.frmcambio = Me
        pjtAdus.Categoria.Show()
    End Sub

    Private Sub ButtonX1_Click(sender As Object, e As EventArgs) Handles ButtonX1.Click
        limpiar()
    End Sub

    Private Sub limpiar()
        Me.texncodigo.Text = ""
        Me.texnnombre.Text = ""
        Me.texndescripcion.Text = ""
        Me.texnprecio.Text = ""
        Me.texnpreciopublico.Text = ""
        Me.texnproveedor.Text = ""
        Me.texnexistencias.Text = ""
        Me.texncategoria.Text = ""
        Me.texnunidad.Text = ""

    End Sub

    Private Sub botaceptar_Click(sender As Object, e As EventArgs) Handles botaceptar.Click
        If vacio() Then
            MsgBox("No se puede realizar la operacion todos los campos tiene que estar llenos", MsgBoxStyle.Critical, "__..::Aviso::..__")
        Else
            If MsgBox("Esta seguro de combinar los productos, los cambios seran irreversibles", MsgBoxStyle.YesNo, "Aviso") = MsgBoxResult.Yes Then
                unir("facturacompra", "detallecompra", "codfacturac")
                unir("facturaventa", "detalleventa", "codfacturav")
                combinar()
                MsgBox("El producto fue cambiado exitozamente", MsgBoxStyle.Information, "EXITO")
            End If
        End If
    End Sub
    Private Sub combinar()
        Dim c As Short = contador - 1
        consulta.Consultar("update productos set codproducto = '" & texncodigo.Text.Trim & "', nombre = '" & texnnombre.Text.Trim & "',descripcion = '" & texndescripcion.Text.Trim & "',precio_unit = " & CDbl(texnprecio.Text.Trim).ToString & ",precioindi = 0,preciopublico = " & CDbl(texnpreciopublico.Text.Trim).ToString & ", existencias = " & CDbl(Me.texnexistencias.Text.Trim).ToString & ",unit_med = '" & Me.texnunidad.Text.Trim.ToString & "', idcategoria = " & idcategoria.ToString & ",codproveedor = '" & idproveedor.ToString & "' where codempresa = " & mdiMain.codigoempresa.ToString & " and codproducto = '" & Me.texncodigo.Text.Trim & "'")
        For i As Integer = 0 To c
            If Me.DataGridViewX1.Rows(i).Cells(0).Value <> Me.DataGridViewX1.Rows(id).Cells(0).Value Then
                consulta.Consultar("delete from productos where codempresa = '" & mdiMain.codigoempresa.ToString & "' and codproducto = " & Me.DataGridViewX1.Rows(i).Cells(0).Value.ToString)
            End If
        Next
    End Sub
    Private Sub unir(facturacompra As String, detallecompra As String, codfacturac As String)
        ' consulta.Consultar("update productos set nombre = '" & Me.texnnombre.Text.Trim.ToString & "', descripcion = '" & Me.texndescripcion.Text.Trim.ToString & "',precio_unit = " & CDbl(Me.texnprecio.Text.Trim) & ",precioindi=0,preciopublico = " & CDbl(Me.texnpreciopublico.Text.Trim) & ", existencias = " & CInt(Me.texnexistencias.Text.Trim) & ",codempresa = '" & mdiMain.codigoempresa.ToString & "',idcategoria = " & CInt(dtcategoria.Rows(0).Item(0)) & ",codproveedor = '" & dtproveedor.Rows(0).Item(0).ToString & "',unit_med = '" & Me.texnunidad.Text.Trim.ToString & "' where codproducto = '" & dtproductos.Rows(0).Item(0).ToString & "'")
        Dim cadena As String = ""
        Dim c As Short = contador - 1

        For i As Integer = 0 To c
            If i = c Then
                cadena += "codarticulo = '" & DataGridViewX1.Rows(i).Cells(0).Value.ToString & "' "
            Else
                cadena += "codarticulo = '" & DataGridViewX1.Rows(i).Cells(0).Value.ToString & "' or "
            End If
        Next
        'obtiene las facturas que contienen los articulos a combinar
        dtfacturasc = consulta.Consultar("select " & codfacturac & " from " & detallecompra & " where " & cadena & " order by " & codfacturac)
        'la proccima consulta

        Dim fl1 As Boolean = False
        Dim fl As Boolean = False
        For i As Integer = 0 To dtfacturasc.Rows.Count - 1
            If fl1 = False Then
                dtarticulosc = consulta.Consultar("select codarticulo,cantidadunit,descuento,precioreal,preciodescuento,total from " & detallecompra & " where (" & cadena & ") and " & codfacturac & " = " & dtfacturasc.Rows(i).Item(0).ToString)
                Dim cantidad, descuento, precioreal, preciodescuento, total As Double
                For j As Integer = 0 To dtarticulosc.Rows.Count - 1
                    cantidad += CDbl(dtarticulosc.Rows(j).Item(1))
                    descuento += CDbl(dtarticulosc.Rows(j).Item(2))
                    precioreal += CDbl(dtarticulosc.Rows(j).Item(3))
                    preciodescuento += CDbl(dtarticulosc.Rows(j).Item(4))
                    total += CDbl(dtarticulosc.Rows(j).Item(5))
                    If dtarticulosc.Rows(j).Item(0).ToString = Me.DataGridViewX1.Rows(CInt(Me.DataGridViewX1.CurrentCell.RowIndex)).Cells(0).Value.ToString Then
                        fl = True
                    End If
                Next
                If fl Then
                    fl = False
                    'UPDATE `detallecompra` SET cantidadunit = 25, descuento = 0, precioreal = 4.75, preciodescuento = 0, total= 118.75 where codarticulo = 8756 and codfacturac = 115
                    consulta.Consultar("UPDATE " & detallecompra & " SET cantidadunit =" & cantidad & ", descuento = " & descuento & ", precioreal = " & precioreal & ", preciodescuento = " & preciodescuento & ", total = " & total & " where codarticulo = " & Me.DataGridViewX1.Rows(id).Cells(0).Value.ToString & " and " & codfacturac & " = " & dtfacturasc.Rows(i).Item(0).ToString)
                    For j As Integer = 0 To dtarticulosc.Rows.Count - 1
                        If dtarticulosc.Rows(j).Item(0).ToString <> Me.DataGridViewX1.Rows(id).Cells(0).Value.ToString Then
                            consulta.Consultar("delete from " & detallecompra & " where codarticulo = " & dtarticulosc.Rows(j).Item(0).ToString & " and " & codfacturac & " = " & dtfacturasc.Rows(i).Item(0).ToString)
                        End If
                    Next
                End If
                fl1 = True
            Else
                'compara el codigo del articulo actual con el anterior para comprobar que no se el mismo

                If dtfacturasc.Rows(i).Item(0) <> dtfacturasc.Rows(i - 1).Item(0) Then
                    dtarticulosc = consulta.Consultar("select codarticulo,cantidadunit,descuento,precioreal,preciodescuento,total from " & detallecompra & " where (" & cadena & ") and " & codfacturac & " = " & dtfacturasc.Rows(i).Item(0).ToString)
                    Dim cantidad, descuento, precioreal, preciodescuento, total As Double
                    For j As Integer = 0 To dtarticulosc.Rows.Count - 1
                        cantidad += CDbl(dtarticulosc.Rows(j).Item(1))
                        descuento += CDbl(dtarticulosc.Rows(j).Item(2))
                        precioreal += CDbl(dtarticulosc.Rows(j).Item(3))
                        preciodescuento += CDbl(dtarticulosc.Rows(j).Item(4))
                        total += CDbl(dtarticulosc.Rows(j).Item(5))
                        If dtarticulosc.Rows(j).Item(0).ToString = Me.DataGridViewX1.Rows(CInt(Me.DataGridViewX1.CurrentCell.RowIndex)).Cells(0).Value.ToString Then
                            fl = True
                        End If
                    Next
                    If fl Then
                        fl = False
                        consulta.Consultar("UPDATE " & detallecompra & " SET cantidadunit =" & cantidad & ", descuento = " & descuento & ", precioreal = " & precioreal & ", preciodescuento = " & preciodescuento & ", total = " & total & " where codarticulo = " & Me.DataGridViewX1.Rows(id).Cells(0).Value.ToString & " and " & codfacturac & " = " & dtfacturasc.Rows(i).Item(0).ToString)
                        For j As Integer = 0 To dtarticulosc.Rows.Count - 1
                            If dtarticulosc.Rows(j).Item(0).ToString <> Me.DataGridViewX1.Rows(id).Cells(0).Value.ToString Then
                                consulta.Consultar("delete from " & detallecompra & " where codarticulo = " & dtarticulosc.Rows(j).Item(0).ToString & " and " & codfacturac & " = " & dtfacturasc.Rows(i).Item(0).ToString)
                            End If
                        Next
                    Else
                        For j As Integer = 0 To dtarticulosc.Rows.Count - 1
                            consulta.Consultar("delete from " & detallecompra & " where codarticulo = " & dtarticulosc.Rows(j).Item(0).ToString & " and " & codfacturac & " = " & dtfacturasc.Rows(i).Item(0).ToString)
                        Next
                        consulta.Consultar("INSERT INTO " & detallecompra & " (" & codfacturac & ",codarticulo,cantidadunit,descuento,precioreal,preciodescuento,codempresa,total) VALUES ('" & dtfacturasc.Rows(i).Item(0).ToString & "','" & Me.DataGridViewX1.Rows(id).Cells(0).Value.ToString & "'," & cantidad & "," & descuento & "," & precioreal & "," & preciodescuento & ",'" & mdiMain.codigoempresa.ToString & "'," & total & ")")
                    End If
                End If
            End If
        Next

    End Sub

    Private Function vacio()
        Dim fl As Boolean = False
        If Me.texncodigo.Text = "" Then
            fl = True
        End If
        If Me.texnnombre.Text = "" Then
            fl = True
        End If
        If Me.texndescripcion.Text = "" Then
            fl = True
        End If
        If Me.texnprecio.Text = "" Then
            fl = True
        End If

        If Me.texnpreciopublico.Text = "" Then
            fl = True
        End If
        If Me.texnproveedor.Text = "" Then
            fl = True
        End If
        If Me.texnexistencias.Text = "" Then
            fl = True
        End If
        If Me.texncategoria.Text = "" Then
            fl = True
        End If
        If Me.texnunidad.Text = "" Then
            fl = True
        End If
        Return fl
    End Function

    Private Sub texnproveedor_TextChanged(sender As Object, e As EventArgs) Handles texnproveedor.TextChanged

    End Sub
End Class