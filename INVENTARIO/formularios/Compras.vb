Imports logica

Public Class compra
    Public dtrproveedor As DataRow
    Public drproducto As DataRow
    Private facturacompras As New clsMaestros(clsNomTab.eTbl.FacturaCompra)
    Private dtfacturacompras As DataTable
    Private detallefacturacompra As New clsMaestros(clsNomTab.eTbl.DetalleFacturaC)
    Private dtproducto As DataTable
    Private tproductos As New clsMaestros(clsNomTab.eTbl.Productos)
    Private dtdetallefacturacompra As DataTable
    Private consultar As New clsProcesos
    Private nombretablafacturac As String
    Private nombretabladetallefacturac As String
    Public primeraf As Boolean = True
    Private primeradf As Boolean = True
    Private codfacturac As String
    Private dtcodfactura As DataTable
    Dim d, m, a, f As String
    Private pr = False, dr = False, tip = False, frmp = False, numf = False
    Dim vareliminada As Boolean = False

    Private tnumros As New clsMaestros(clsNomTab.eTbl.Numeros)
    Private dtnumerosa As DataTable


    'precios 
    Private subtotal1 = 0, subtotal2 = 0, subtotal3 = 0, iva = 0, descuentof = 0, totalf As Double
    Private sumas = 0, descuento = 0, iva1 = 0, cotrans = 0, fovial = 0, totalfactu, cantidadproducto, totalproducto, ivauno As Double
    Dim contador1 As Integer = 0
    Private sumas1 = 0, descuento1 = 0, iva2 = 0, cotrans2 = 0, fovial2 = 0, totalfactu2, cantidadproducto2, totalproducto2, ivauno2 As Double
    'hasque aqui precios

    'para el descuento
    Private fldescuento As Boolean = False
    Private dtdescuento As DataTable
    'hasta qui

    Dim contafactura As Short
    'para la modificaciond e la factura
    Public dtproveedores As DataTable
    Public dtproductos As DataTable
    Public dtfacturacompra As DataTable
    Public dtdetallefacturacompram As DataTable
    Public donde As String = "here"
    Public contador As Integer
    Public frmdc As DetalleCompra
    Public frmcr As Compras_realizadas
    'Aqui termina los atributos para la modificacion de la factura

    'id para el producto y para los proveedores
    Public idproducto As String
    Public idproveedor As String


    ' Para los proveedores y productos
    Private tproveedores1 As New clsMaestros(clsNomTab.eTbl.Proveedores)
    Private dtproveedores1 As DataTable

    Private tproductos1 As New clsMaestros(clsNomTab.eTbl.Productos)
    Private dtproductos1 As DataTable
    'aqui termina


   
    ' aqui termina

    'para el uno por ciento retencio
    Dim unopc As Double = 0
    Dim guardado As Boolean = False

    Private Sub compra_Disposed(sender As Object, e As EventArgs) Handles Me.Disposed
        mdiMain.teclas = False
    End Sub




    Private Sub compra_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        Try
            MdiParent = mdiMain
            If donde <> "here" Then
                cargardatos()

            Else
                MdiParent = mdiMain
            End If
        Catch ex As Exception
            MsgBox("Ocurrio un error asegurese de haber llenado todos los campo correctamente razon: " & ex.Message, MsgBoxStyle.OkOnly, "Avise")
        End Try


    End Sub

  
    Private Sub cargardatos()
        Try
            Me.texproveedor.Text = dtproveedores.Rows(0).Item(1)
            Me.combotipo.Text = dtfacturacompra.Rows(contador).Item(11)
            Me.coboformadepago.Text = dtfacturacompra.Rows(contador).Item(12)
            Me.texnumfact.Text = dtfacturacompra.Rows(contador).Item(1)
            Me.DateTimePicker1.Value = dtfacturacompra.Rows(contador).Item(4).ToString
            Me.codfacturac = dtfacturacompra.Rows(contador).Item(0)
            cargarfactura()
        Catch ex As Exception
            MsgBox("Ocurrio un error asegurese de haber llenado todos los campo correctamente", MsgBoxStyle.OkOnly, "Avise")
        End Try

    End Sub

    Private Sub texproveedor_Click(sender As Object, e As EventArgs) Handles texproveedor.Click
        Try
            Proveedores.donde = "compras"
            Proveedores.frmc = Me
            Proveedores.Show()
            pr = True

        Catch ex As Exception
            MsgBox("Ocurrio un error asegurese de haber llenado todos los campo correctamente", MsgBoxStyle.OkOnly, "Avise")
        End Try

    End Sub

   
    Private Sub texnombrep_Click(sender As Object, e As EventArgs) Handles texnombrep.Click
        Try
            pjtAdus.Productos.donde = "compras"
            pjtAdus.Productos.frmc = Me
            pjtAdus.Productos.Show()
            Me.textotalp.Select()
        Catch ex As Exception
            MsgBox("Ocurrio un error asegurese de haber llenado todos los campo correctamente", MsgBoxStyle.OkOnly, "Avise")
        End Try

    End Sub


    Private Function validar() As Boolean
        Return True
    End Function

   
    Private Sub insertar()
        Try
            If validar() Then

                If primeraf = True Then
                    primeraf = False
                    d = Me.DateTimePicker1.Value.Day
                    m = Me.DateTimePicker1.Value.Month
                    a = Me.DateTimePicker1.Value.Year
                    f = a + "-" + m + "-" + d
                    facturacompras.Insertar("'" & Me.texnumfact.Text.ToString.Trim & "','" & Me.combotipo.Text.ToString & "','" & idproveedor & "','" & mdiMain.codigoempresa.ToString & "','" & f & "'," & CDbl(0).ToString & "," & CDbl(0).ToString & "," & CDbl(0).ToString & "," & CDbl(0).ToString & "," & CDbl(0).ToString & "," & CDbl(0).ToString & "," & CDbl(0).ToString & "," & CDbl(0).ToString & ",'" & Me.coboformadepago.Text.ToString & "'," & CDbl(0).ToString & " ,'valida','" & Me.textiraje.Text.ToString & "',0,0,0,0")
                    dtcodfactura = consultar.Consultar("SELECT  Max(codfacturac) FROM facturacompra")
                    codfacturac = dtcodfactura.Rows(0).Item(0)
                    insertardetalle()
                Else
                    insertardetalle()
                End If
            End If
        Catch ex As Exception
            MsgBox("Ocurrio un error causa: " + ex.Message, MsgBoxStyle.OkOnly, "Avise")
        End Try


    End Sub


    Private Sub privar()
        Try
            Me.texprecio.Text = ""
            Me.texcantidad.Text = ""
            Me.textotalp.Text = ""
            Me.texnombrep.Text = ""
            Me.texproveedor.Enabled = False
            Me.texnumfact.Enabled = False
            Me.combotipo.Enabled = False
            Me.coboformadepago.Enabled = False
            Me.DateTimePicker1.Enabled = False
            Me.textiraje.Enabled = False
        Catch ex As Exception
            MsgBox("Ocurrio un error asegurese de haber llenado todos los campo correctamente", MsgBoxStyle.OkOnly, "Avise")
        End Try

    End Sub

  



    Private Sub insertardetalle()
        Try


            Dim prereal, totalfactura, canti As Double
            If dtdescuento.Rows(0).Item(2).ToString = "True" Then
                Dim prereal1, treal As Decimal
            
                prereal1 = Math.Round((CDec(Me.texprecio.Text) * 1.13), 6)
                '  prereal1 += Math.Round((CDec(Me.texprecio.Text) * 0.01), 6)
                prereal1 += 0.3
                prereal = prereal1

                treal = Math.Round(prereal1 * CDec(Me.texcantidad.Text), 6)
                totalfactura = treal 


                If Me.combotipo.Text = "Factura" Then
                    prereal = Me.texprecio.Text
                    prereal = Math.Round((prereal - 0.3), 4)
                    canti = texcantidad.Text
                    totalfactura = Math.Round((canti * prereal), 4)
                Else

                    'prereal = Me.texprecio.Text
                    prereal = Math.Round((prereal - 0.3), 6)
                    prereal = Math.Round(prereal / 1.13, 6)

                    canti = texcantidad.Text
                    'totalfactura = Math.Round((canti * prereal), 6)
                End If
            Else
                Dim treal As Decimal
                Dim opre As Decimal

                opre = CDec(Me.texprecio.Text.ToString)

                opre = Math.Round((opre + (opre * 0.13)), 6)

                prereal = Math.Round((CDec(opre) / 1.13), 6)
                '  prereal1 += Math.Round((CDec(Me.texprecio.Text) * 0.01), 6)


                treal = Math.Round(opre * CDec(Me.texcantidad.Text), 6)

                totalfactura = treal

                ' prereal = Math.Round((CDbl(Me.texprecio.Text) * 1.13), 4)
                '  totalfactura = Math.Round((CDec(Me.texcantidad.Text) * prereal), 4)


            End If



            If dtdescuento.Rows(0).Item(2).ToString <> "True" Then
                detallefacturacompra.Insertar(CInt(Me.codfacturac).ToString & "," & idproducto & "," & CDbl(Me.texcantidad.Text).ToString & ",0," & prereal & ",0,'" & mdiMain.codigoempresa.ToString & "'," & totalfactura & "," & totalfactura & "," & CDbl(prereal))

                'detallefacturacompra.Insertar(CInt(Me.codfacturac).ToString & "," & idproducto & "," & CDbl(Me.texcantidad.Text).ToString & ",0," & prereal & ",0,'" & mdiMain.codigoempresa.ToString & "'," & totalfactura & "," & CDbl(Me.textotalp.Text) & "," & CDbl(prereal))
            Else
                detallefacturacompra.Insertar(CInt(Me.codfacturac).ToString & "," & idproducto & "," & CDbl(Me.texcantidad.Text).ToString & ",0," & prereal & ",0,'" & mdiMain.codigoempresa.ToString & "'," & totalfactura & "," & totalfactura & "," & CDbl(Me.texprecio.Text))
            End If



            privar()
            cargarfactura()
        Catch ex As Exception
            MsgBox("Ocurrio un error a la hora de insertar el articulo razon: " + ex.Message, MsgBoxStyle.Critical, "Aviso")
        End Try
    End Sub
    Dim sumaf, sumac As Double
    Private Sub cargarfactura()
        Try
            dtdetallefacturacompra = detallefacturacompra.Consultar(" where codfacturac = '" + codfacturac.ToString + "'")
            Dim nf As Short
            nf = dtdetallefacturacompra.Rows.Count
            cantidadproducto = 0
            totalproducto = 0
            subtotal1 = 0
            fovial = 0
            cotrans = 0
            iva1 = 0
            sumas = 0
            sumac = 0
            sumaf = 0

            Me.texsumas.Text = "0"
            Me.texiva.Text = "0"
            Me.textotal.Text = "0"
            Me.texivauno.Text = "0"

            ivauno2 = 0
            If nf = 0 Then
                Me.gridcompra.RowCount = 1
                Me.gridcompra.Rows(0).Cells(0).Value = ""
                Me.gridcompra.Rows(0).Cells(1).Value = ""
                Me.gridcompra.Rows(0).Cells(2).Value = ""
                Me.gridcompra.Rows(0).Cells(3).Value = ""
                Me.gridcompra.Rows(0).Cells(4).Value = ""
                Me.gridcompra.Rows(0).Cells(5).Value = ""




            
            Else
                Me.gridcompra.RowCount = nf
            End If

            For i As Integer = 0 To dtdetallefacturacompra.Rows.Count - 1

                If Me.combotipo.Text <> "Factura" Then
                    dtproducto = tproductos.Consultar(" where codproducto = " + CInt(dtdetallefacturacompra.Rows(i).Item(2)).ToString)



                    cantidadproducto = Math.Round(CDbl(dtdetallefacturacompra.Rows(i).Item(3)), 2)
                    totalproducto = Math.Round(CDbl(dtdetallefacturacompra.Rows(i).Item(9)), 2)

                    If dtdescuento.Rows(0).Item(2).ToString = "False" Then
                        sumaf = Math.Round(CDbl(dtdetallefacturacompra.Rows(i).Item(3)) * 0.2, 2)
                        sumac = Math.Round(CDbl(dtdetallefacturacompra.Rows(i).Item(3)) * 0.1, 2)
                    End If

                    fovial = Math.Round(cantidadproducto * 0.2, 2)
                    cotrans = Math.Round(cantidadproducto * 0.1, 2)

                    fovial -= sumaf
                    cotrans -= sumac

                    sumas = Math.Round((totalproducto - fovial - cotrans), 2)

                    sumas = Math.Round((sumas / 1.13), 2)

                    '    sumas += Math.Round((sumas / 0.01), 2)


                    iva = Math.Round((sumas * 0.13), 2)

                    If dtdescuento.Rows(0).Item(2).ToString <> "False" Then
                        ivauno = Math.Round((sumas * 0.01), 2)
                    End If


                    consultar.Consultar("UPDATE detallecompra SET total = " & sumas & " where coddetallefacturac = " & dtdetallefacturacompra.Rows(i).Item(0))
                    dtdetallefacturacompra = detallefacturacompra.Consultar(" where codfacturac = '" + codfacturac.ToString + "'")
                    dtproducto = tproductos.Consultar(" where codproducto = " & CInt(dtdetallefacturacompra.Rows(i).Item(2)).ToString)
                    Me.gridcompra.Rows(i).Cells(0).Value = dtdetallefacturacompra.Rows(i).Item(3)
                    Me.gridcompra.Rows(i).Cells(1).Value = dtproducto.Rows(0).Item(1)
                    Me.gridcompra.Rows(i).Cells(2).Value = dtdetallefacturacompra.Rows(i).Item(5)
                    Me.gridcompra.Rows(i).Cells(3).Value = "0"
                    Me.gridcompra.Rows(i).Cells(4).Value = "0"
                    Me.gridcompra.Rows(i).Cells(5).Value = dtdetallefacturacompra.Rows(i).Item(8)


                    sumas1 += sumas
                    iva2 += iva
                    If dtdescuento.Rows(0).Item(2).ToString <> "False" Then
                        ivauno2 += ivauno
                    End If

                    cotrans2 += cotrans
                    fovial2 += fovial
                    totalproducto2 = sumas1 + iva2 + ivauno2 + cotrans2 + fovial2

                Else
                    dtproducto = tproductos.Consultar(" where codproducto = " + CInt(dtdetallefacturacompra.Rows(i).Item(2)).ToString)



                  
                    cantidadproducto = Math.Round(CDbl(dtdetallefacturacompra.Rows(i).Item(3)), 2)
                    totalproducto = Math.Round(CDbl(dtdetallefacturacompra.Rows(i).Item(9)), 2)

                    If dtdescuento.Rows(0).Item(2).ToString = "False" Then
                        sumaf = Math.Round(CDbl(dtdetallefacturacompra.Rows(i).Item(3)) * 0.2, 2)
                        sumac = Math.Round(CDbl(dtdetallefacturacompra.Rows(i).Item(3)) * 0.1, 2)
                    End If

                    fovial = Math.Round(cantidadproducto * 0.2, 2)
                    cotrans = Math.Round(cantidadproducto * 0.1, 2)

                    fovial -= sumaf
                    cotrans -= sumac

                    sumas = Math.Round((totalproducto - fovial - cotrans), 2)


                    consultar.Consultar("UPDATE detallecompra SET total = " & sumas & " where coddetallefacturac = " & dtdetallefacturacompra.Rows(i).Item(0))
                    dtdetallefacturacompra = detallefacturacompra.Consultar(" where codfacturac = '" + codfacturac.ToString + "'")
                    dtproducto = tproductos.Consultar(" where codproducto = " & CInt(dtdetallefacturacompra.Rows(i).Item(2)).ToString)
                     Me.gridcompra.Rows(i).Cells(0).Value = dtdetallefacturacompra.Rows(i).Item(3)
                    Me.gridcompra.Rows(i).Cells(1).Value = dtproducto.Rows(0).Item(1)
                    Me.gridcompra.Rows(i).Cells(2).Value = dtdetallefacturacompra.Rows(i).Item(5)
                    Me.gridcompra.Rows(i).Cells(3).Value = "0"
                    Me.gridcompra.Rows(i).Cells(4).Value = "0"
                    Me.gridcompra.Rows(i).Cells(5).Value = dtdetallefacturacompra.Rows(i).Item(8)

                    sumas1 += sumas
                    iva2 += iva
                    cotrans2 += cotrans
                    fovial2 += fovial
                    totalproducto2 += totalproducto
                End If
            


            Next



        Catch ex As Exception
            MsgBox("Ocurrio un error asegurese de haber llenado todos los campo correctamente", MsgBoxStyle.OkOnly, "Avise")
        End Try

    End Sub




    Private Sub texcantidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles texcantidad.KeyPress, texprecio.KeyPress, textotalp.KeyPress, texnumfact.KeyPress
        e.Handled = onlynumero(e)
        If (Asc(e.KeyChar)) = 13 Then
            botagregar_Click_1(sender, e)
        End If
    End Sub
    Public Function onlynumero(ByVal caracter As System.Windows.Forms.KeyPressEventArgs)

        If (Asc(caracter.KeyChar)) >= 48 And (Asc(caracter.KeyChar)) <= 57 Or _
          (Asc(caracter.KeyChar)) = System.Windows.Forms.Keys.Back Or (Asc(caracter.KeyChar)) = 46 Then
            Return False
        Else
            Return True
        End If
    End Function

  

    Private Function combotipo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles combotipo.KeyPress
      
        Return False

    End Function

  

    Private Sub combotipo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles combotipo.SelectedIndexChanged
        tip = True
    End Sub



    Private Sub texnumfact_TextChanged(sender As Object, e As EventArgs) Handles texnumfact.TextChanged
        numf = True
    End Sub


    Private Function correcto() As Boolean
        Dim fl As Boolean = True

        If texproveedor.Text = "" Then
            Me.texproveedor.BackColor = Color.Red
            fl = False
        Else
            Me.texproveedor.BackColor = Color.White
        End If

        If Me.texnumfact.Text = "" Then
            Me.texnumfact.BackColor = Color.Red
            fl = False
        Else
            Me.texnumfact.BackColor = Color.White
        End If

        If Me.combotipo.Text = "" Then
            Me.combotipo.BackColor = Color.Red
            fl = False
        Else
            Me.combotipo.BackColor = Color.White
        End If

        If Me.coboformadepago.Text = "" Then
            Me.coboformadepago.BackColor = Color.Red
            fl = False
        Else
            Me.coboformadepago.BackColor = Color.White
        End If

        If Me.textiraje.Text = "" Then
            Me.textiraje.BackColor = Color.Red
            fl = False
        Else
            Me.textiraje.BackColor = Color.White
        End If

        If Me.texnombrep.Text = "" Then
            Me.texnombrep.BackColor = Color.Red
            fl = False
        Else
            Me.texnombrep.BackColor = Color.White
        End If

        If Me.texcantidad.Text = "" Then
            Me.texcantidad.BackColor = Color.Red
            fl = False
        Else
            Me.texcantidad.BackColor = Color.White
        End If

        If Me.texprecio.Text = "" Then
            Me.texprecio.BackColor = Color.Red
            fl = False
        Else
            Me.texprecio.BackColor = Color.White
        End If

        If Me.textotalp.Text = "" Then
            Me.textotalp.BackColor = Color.Red
            fl = False
        Else
            Me.textotalp.BackColor = Color.White
        End If

        Return fl
    End Function

    Private Sub botagregar_Click_1(sender As Object, e As EventArgs) Handles botagregar.Click
        If correcto() <> False Then
            'limpirando las variables globales
            sumas1 = 0
            iva2 = 0
            cotrans2 = 0
            fovial2 = 0
            totalproducto2 = 0
            ivauno2 = 0
            Try
                If primeraf = False Then
                    Dim tl1 As Double
                    Dim can As Double
                    Dim tl As Double
                    Dim f As Boolean = False
                    For i As Integer = 0 To dtdetallefacturacompra.Rows.Count - 1
                        If idproducto.ToString = dtdetallefacturacompra.Rows(i).Item(2).ToString Then

                            can = Math.Round(CDbl(dtdetallefacturacompra.Rows(i).Item(3) + CDbl(Me.texcantidad.Text)), 2)
                            tl = Math.Round(CDbl(dtdetallefacturacompra.Rows(i).Item(9)) + CDbl(Me.textotalp.Text.Trim), 2)
                            tl1 = Math.Round((CDbl(dtdetallefacturacompra.Rows(i).Item(5)) * can), 2)
                            consultar.Consultar(" update detallecompra set total = " & tl1 & ", cantidadunit = " + can.ToString + ", total1 = " + tl.ToString + " where codfacturac = " + codfacturac.ToString + " and coddetallefacturac = " + dtdetallefacturacompra.Rows(i).Item(0).ToString)
                            f = True
                            privar()
                            cargarfactura()
                        End If
                    Next
                    If f = False Then
                        insertar()
                    End If
                Else
                    insertar()
                End If




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



            Catch ex As Exception
                MsgBox("Ocurrio un error asegurese de haber llenado todos los campo correctamente", MsgBoxStyle.OkOnly, "Avise")
            End Try
        Else
            MsgBox("Tiene que llenar los datos que estan en rojo", MsgBoxStyle.ApplicationModal, "Aviso")
        End If

    End Sub

    Private Sub btnaplicar_Click_1(sender As Object, e As EventArgs)
        subtotal1 = 0
        descuentof = 0
        subtotal2 = 0
        iva = 0
        ivauno2 = 0
        subtotal3 = 0
        totalf = 0
        Try

            Dim dttotal As Double = 0
            For i As Integer = 0 To dtdetallefacturacompra.Rows.Count - 1


                dttotal = CDbl(dtdetallefacturacompra.Rows(i).Item(8))

                consultar.Consultar(" update detallecompra set descuento = " + dtdescuento.ToString + ", preciodescuento = " + dttotal.ToString + " where codfacturac = " + codfacturac.ToString + " and coddetallefacturac = " + dtdetallefacturacompra.Rows(i).Item(0).ToString)
            Next
            MsgBox("El descuento se a efectuado exitozamente", MsgBoxStyle.OkOnly, "Exito")
            cargarfactura()
        Catch ex As Exception
            MsgBox("Ocurrio un error al aplicar el descuento" + ex.Message, MsgBoxStyle.Critical, "Aviso")
        End Try

    End Sub
  
    Private Sub botguardar_Click_1(sender As Object, e As EventArgs)
        Try
            Dim ella As String = ""
            If guardado = False Then
                guardado = True
                If combotipo.Text = "Factura" Then
                    ella = "La "
                Else
                    ella = "El "
                End If
                Dim c As Double = 0
                For i As Integer = 0 To dtdetallefacturacompra.Rows.Count - 1
                    dtproducto = tproductos.Consultar(" where codproducto = '" + dtdetallefacturacompra.Rows(i).Item(2).ToString + "'")
                    c = CDbl(dtdetallefacturacompra.Rows(i).Item(3) + CDbl(dtproducto.Rows(0).Item(6)))
                    consultar.Consultar(" update productos set existencias = " + c.ToString + " where codproducto = '" + dtdetallefacturacompra.Rows(i).Item(2).ToString + "'")
                Next
                Me.totalfactu = Me.textotal.Text
                consultar.Consultar(" update facturacompra set sumas = ")

                If MsgBox(ella & combotipo.Text.ToString & " Se ingreso exitozamente" & vbCrLf _
                          & " Desea agregar otra compra?", MsgBoxStyle.YesNo, "Compra") = MsgBoxResult.Yes Then
                    mdiMain.llama = "compra"
                    Me.Close()
                    mdiMain.timllamar.Enabled = True
                Else
                    Me.Close()
                End If

                If donde <> "here" Then
                    frmdc.modi = True
                    frmdc.cargarfacturac()
                    frmcr.hacerconsulta()
                    Me.Close()
                End If

            End If
        Catch ex As Exception
            MsgBox("Ocurrio un error al ingresar la factura razon: " + ex.Message, MsgBoxStyle.Critical, "Aviso")
        End Try


    End Sub

    Private Sub botmodificar_Click_1(sender As Object, e As EventArgs)
        Try
            Dim id As Short = Me.gridcompra.CurrentCell.RowIndex
            Dim dtrdetalle As DataRow = dtdetallefacturacompra.Rows(id)
            'Dim canti As Double = 0
            'dtdescuento = tdescuento.Consultar(" where codproducto = " & dtrdetalle.Item(2))

            'limpirando las variables globales
            sumas1 = 0
            iva2 = 0
            ivauno = 0
            cotrans2 = 0
            fovial2 = 0
            totalproducto2 = 0

            'If dtdescuento.Rows(0).Item(2).ToString <> "False" Then
            '    fovial -= Math.Round(dtdetallefacturacompra.Rows(id).Item(3) * 0.2, 2)
            '    cotrans -= Math.Round(dtdetallefacturacompra.Rows(id).Item(3) * 0.1, 2)
            '    canti = CDbl(dtdetallefacturacompra.Rows(id).Item(9)) - Math.Round(dtdetallefacturacompra.Rows(id).Item(3) * 0.2, 2) - Math.Round(dtdetallefacturacompra.Rows(id).Item(3) * 0.1, 2)
            '    canti = Math.Round((canti / 1.13), 2)
            'Else
            '    sumas1 -= CDbl(dtdetallefacturacompra.Rows(id).Item(8))
            '    iva2 -= Math.Round(CDbl(dtdetallefacturacompra.Rows(id).Item(8)) * 0.13, 2)
            'End If

            consultar.Consultar("delete from detallecompra where coddetallefacturac = " + dtrdetalle.Item(0).ToString)

            cargarfactura()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub botsalir_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub


    Dim cantidad, preciot, totalp As Double
    Private Sub textotalp_KeyUp(sender As Object, e As KeyEventArgs) Handles textotalp.KeyUp
        Try
            If checklibre.Checked <> True Then
                If Me.texprecio.Text = "" Or Me.textotalp.Text = "" Then
                    Me.textotalp.Text = ""
                Else

                    totalp = CDbl(Me.textotalp.Text)
                    preciot = CDbl(Me.texprecio.Text)
                    cantidad = totalp / preciot
                    Me.texcantidad.Text = Math.Round(cantidad, 2)
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub


    Private Sub texcantidad_KeyUp(sender As Object, e As KeyEventArgs) Handles texcantidad.KeyUp, texprecio.KeyUp
        Try
            If checklibre.Checked <> True Then
                If Me.texprecio.Text = "" Or Me.texcantidad.Text = "" Then
                    Me.texcantidad.Text = ""
                Else

                    Me.cantidad = CDbl(Me.texcantidad.Text)
                    Me.preciot = CDbl(Me.texprecio.Text)
                    Me.textotalp.Text = Math.Round((cantidad * preciot), 2)

                End If
            End If

        Catch ex As Exception
            MsgBox("Ocurrio un error asegurese de haber llenado todos los campo correctamente", MsgBoxStyle.OkOnly, "Avise")
        End Try

    End Sub


    Private Sub texnombrep_KeyPress(sender As Object, e As KeyPressEventArgs) Handles texnombrep.KeyPress
        e.Handled = onlynumero(e)
        If (Asc(e.KeyChar)) = 13 Then
            texnombrep_Click(sender, e)
        End If
    End Sub

 


 

    Private Sub Button7_Click(sender As Object, e As EventArgs)

        Me.texprecio.Text = Me.dtproductos1.Rows(3).Item(3)
        Me.texprecio.Select()
    End Sub


   

End Class