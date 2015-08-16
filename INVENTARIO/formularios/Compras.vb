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
    Private tdescuento As New clsMaestros(clsNomTab.eTbl.Descuentos)
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


    ' Para los tanques
    Dim ttanques As New clsMaestros(clsNomTab.eTbl.Tanques)
    Dim dttanques As DataTable
    Dim tbombas As New clsMaestros(clsNomTab.eTbl.Bombas)
    Dim dtbombas As DataTable
    ' aqui termina

    'para el uno por ciento retencio
    Dim unopc As Double = 0
    Dim guardado As Boolean = False

    Private Sub compra_Disposed(sender As Object, e As EventArgs) Handles Me.Disposed
        mdiMain.teclas = False
    End Sub

    Private Sub compra_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        If guardado = False Then
            If (e.KeyChar) = "P" Or (e.KeyChar) = "p" Then
                Button3.Select()
            ElseIf (e.KeyChar) = "A" Or (e.KeyChar) = "a" Then
                Button4.Select()
            ElseIf (e.KeyChar) = "B" Or (e.KeyChar) = "b" Then
                Me.controlbombas.Select()
            ElseIf (e.KeyChar) = "g" Or (e.KeyChar) = "G" Then
                botguardar_Click_1(sender, e)
            End If
        End If



    End Sub


    Private Sub compra_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        Me.Button1.Select()
        Try
            MdiParent = mdiMain
            If donde <> "here" Then
                cargardatos()

            Else
                MdiParent = mdiMain
                cargarpp()
            End If
        Catch ex As Exception
            MsgBox("Ocurrio un error asegurese de haber llenado todos los campo correctamente razon: " & ex.Message, MsgBoxStyle.OkOnly, "Avise")
        End Try


    End Sub

    Private Sub cargarpp()
        dtproveedores1 = tproveedores1.Consultar(" where codempresa = '" & mdiMain.codigoempresa.ToString & "'")
        dtproductos1 = tproductos1.Consultar(" where codempresa = '" & mdiMain.codigoempresa.ToString & "'")

        Dim nfp1 As Short = dtproveedores1.Rows.Count
        Dim nfp2 As Short = dtproductos1.Rows.Count


        If nfp1 >= 1 Then
            Me.texco1.Text = dtproveedores1.Rows(0).Item(0)
            Me.texprovee1.Text = dtproveedores1.Rows(0).Item(1)
            If nfp1 >= 2 Then
                Me.texco2.Text = dtproveedores1.Rows(1).Item(0)
                Me.texprovee2.Text = dtproveedores1.Rows(1).Item(1)
                If nfp1 >= 3 Then
                    Me.texco3.Text = dtproveedores1.Rows(2).Item(0)
                    Me.texprovee3.Text = dtproveedores1.Rows(2).Item(1)
                End If
            End If
        End If

        If nfp2 >= 1 Then
            Me.texco4.Text = dtproductos1.Rows(0).Item(0)
            Me.texprod4.Text = dtproductos1.Rows(0).Item(1)
            If nfp2 >= 2 Then
                Me.texco5.Text = dtproductos1.Rows(1).Item(0)
                Me.texprod5.Text = dtproductos1.Rows(1).Item(1)
                If nfp2 >= 3 Then
                    Me.texco6.Text = dtproductos1.Rows(2).Item(0)
                    Me.texprod6.Text = dtproductos1.Rows(2).Item(1)
                  
                End If
            End If
        End If

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

  

    Private Sub llenartanque(ByVal id As Short)
        Dim detalle As DataTable
        Dim cat As Double
        If id = 1 Then
            Me.checksuper.Checked = True
            detalle = detallefacturacompra.Consultar(" where codfacturac = " & codfacturac & " and codproducto = " & 1)
            cat = CDbl(detalle.Rows(0).Item(3))

            Me.texs.Text = cat
            Me.texs.Visible = True

        ElseIf id = 2 Then
            Me.checkregular.Checked = True
            detalle = detallefacturacompra.Consultar(" where codfacturac = " & codfacturac & " and codproducto = " & 2)
            cat = CDbl(detalle.Rows(0).Item(3))

            Me.texr.Text = cat

            Me.texr.Visible = True
        ElseIf id = 3 Then
            Me.checdiesel1.Checked = True
            Me.checkdiesel2.Checked = True

            detalle = detallefacturacompra.Consultar(" where codfacturac = " & codfacturac & " and codproducto = " & 3)
            cat = CDbl(detalle.Rows(0).Item(3))

            Me.texd1.Text = cat
            Me.todo = cat
            Me.texd2.Text = 0
            Me.texd1.Visible = True
            Me.texd2.Visible = True
        End If
    End Sub


    Private Sub insertardetalle()
        Try

            dtdescuento = tdescuento.Consultar(" where codproducto = " & idproducto)
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
            llenartanque(idproducto)
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
            Me.texfovial.Text = "0"
            Me.texiva.Text = "0"
            Me.texcotrans.Text = "0"
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

                    dtdescuento = tdescuento.Consultar(" where codproducto = " & dtproducto.Rows(0).Item(0))

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



                    dtdescuento = tdescuento.Consultar(" where codproducto = " & dtproducto.Rows(0).Item(0))

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

            Me.texsumas.Text = ""
            Me.texfovial.Text = ""
            Me.texiva.Text = ""
            Me.texcotrans.Text = ""
            Me.textotal.Text = ""
            Me.texivauno.Text = ""


            Me.texsumas.Text = sumas1
            Me.texfovial.Text = fovial2
            Me.texiva.Text = iva2
            Me.texivauno.Text = ivauno2
            Me.texcotrans.Text = cotrans2
            Me.textotal.Text = Math.Round(totalproducto2, 2)

            'limpirando las variables globales
            'sumas1 = 0
            'iva2 = 0
            'cotrans2 = 0
            'fovial2 = 0
            'totalproducto2 = 0


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

    Private Sub aplicardescuento()
        Try
            If radiotodo.Checked = True Then
                If primeraf = True Then
                    MsgBox("Tiene que haber insertado por lo menos un articulo para aplicar el descuento", MsgBoxStyle.OkOnly, "Aviso")
                Else
                    grubdescuento.Visible = True
                    Me.texpdescuento.Focus()
                End If
            End If
        Catch ex As Exception
            MsgBox("Ocurrio un error asegurese de haber llenado todos los campo correctamente", MsgBoxStyle.OkOnly, "Avise")
        End Try

    End Sub

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
            Button4.Select()
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

    Private Sub btnaplicar_Click_1(sender As Object, e As EventArgs) Handles btnaplicar.Click
        subtotal1 = 0
        descuentof = 0
        subtotal2 = 0
        iva = 0
        ivauno2 = 0
        subtotal3 = 0
        totalf = 0
        Try
            Dim dtdescuento As Double = 0
            Dim dttotal As Double = 0
            For i As Integer = 0 To dtdetallefacturacompra.Rows.Count - 1
                dtdescuento = CDbl(dtdetallefacturacompra.Rows(i).Item(8)) * CDbl(CDbl(Me.texpdescuento.Text.Trim) / 100)

                dttotal = CDbl(dtdetallefacturacompra.Rows(i).Item(8)) - dtdescuento

                consultar.Consultar(" update detallecompra set descuento = " + dtdescuento.ToString + ", preciodescuento = " + dttotal.ToString + " where codfacturac = " + codfacturac.ToString + " and coddetallefacturac = " + dtdetallefacturacompra.Rows(i).Item(0).ToString)
            Next
            MsgBox("El descuento se a efectuado exitozamente", MsgBoxStyle.OkOnly, "Exito")
            cargarfactura()
        Catch ex As Exception
            MsgBox("Ocurrio un error al aplicar el descuento" + ex.Message, MsgBoxStyle.Critical, "Aviso")
        End Try

    End Sub
    Private Sub cargartanques()
        Dim t1 = 0, t2 = 0, t3 = 0, t4 As Double = 0
        'para el tanque de super
        dttanques = ttanques.Consultar(" Where codtanque = 4")
        t4 = CDbl(dttanques.Rows(0).Item(3))
        t4 += CDbl(Me.texs.Text)
        consultar.Consultar(" update tanques set cantidad = " & t4 & " where codtanque = 4")

        'para el tanque de regular
        dttanques = ttanques.Consultar(" Where codtanque = 3")
        t3 = CDbl(dttanques.Rows(0).Item(3))
        t3 += CDbl(Me.texr.Text)
        consultar.Consultar(" update tanques set cantidad = " & t3 & " where codtanque = 3")

        'para los tanques de Diesel
        dttanques = ttanques.Consultar(" Where codtanque = 1")
        t1 = CDbl(dttanques.Rows(0).Item(3))
        t1 += CDbl(Me.texd1.Text)
        consultar.Consultar(" update tanques set cantidad = " & t1 & " where codtanque = 1")

        dttanques = ttanques.Consultar(" Where codtanque = 2")
        t2 = CDbl(dttanques.Rows(0).Item(3))
        t2 += CDbl(Me.texd2.Text)
        consultar.Consultar(" update tanques set cantidad = " & t2 & " where codtanque = 2")
    End Sub
    Private Sub botguardar_Click_1(sender As Object, e As EventArgs) Handles botguardar.Click
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
                consultar.Consultar(" update facturacompra set sumas = " & Me.texsumas.Text.ToString & ", iva = " & Me.texiva.Text.ToString & ", fovial = " & Me.texfovial.Text.ToString & ", cotrans = " & Me.texcotrans.Text.ToString & ", descuento = " & descuentof.ToString & ", total = " & Me.textotal.Text.ToString & ", unoretencion = " & Me.texivauno.Text.ToString & ", td1 = " & Me.texd1.Text.Trim.ToString & ", td2 = " & Me.texd2.Text.Trim.ToString & ", tr = " & Me.texr.Text.Trim.ToString & ", ts = " & Me.texs.Text.Trim.ToString & " where codfacturac = " & codfacturac)
                cargartanques()
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

    Private Sub botmodificar_Click_1(sender As Object, e As EventArgs) Handles botmodificar.Click
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

    Private Sub botsalir_Click(sender As Object, e As EventArgs) Handles botsalir.Click
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

    Private Sub invalidarprov()
        Me.Button1.Enabled = False
        Me.Button2.Enabled = False
        Me.Button3.Enabled = False
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.idproveedor = Me.texco1.Text
        Me.texproveedor.Text = Me.texprovee1.Text
        Me.Button4.Select()
        invalidarprov()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.idproveedor = Me.texco2.Text
        Me.texproveedor.Text = Me.texprovee2.Text
        Me.Button4.Select()
        invalidarprov()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.idproveedor = Me.texco3.Text
        Me.texproveedor.Text = Me.texprovee3.Text
        Me.Button4.Select()
        invalidarprov()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.idproducto = Me.texco4.Text
        Me.texnombrep.Text = Me.texprod4.Text
        Me.texprecio.Text = Me.dtproductos1.Rows(0).Item(3)
        Me.texprecio.Select()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.idproducto = Me.texco5.Text
        Me.texnombrep.Text = Me.texprod5.Text
        Me.texprecio.Text = Me.dtproductos1.Rows(1).Item(3)
        Me.texprecio.Select()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.idproducto = Me.texco6.Text
        Me.texnombrep.Text = Me.texprod6.Text
        Me.texprecio.Text = Me.dtproductos1.Rows(2).Item(3)
        Me.texprecio.Select()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs)

        Me.texprecio.Text = Me.dtproductos1.Rows(3).Item(3)
        Me.texprecio.Select()
    End Sub

    Private Sub texnombrep_TextChanged(sender As Object, e As EventArgs) Handles texnombrep.TextChanged

    End Sub

    Private Sub texproveedor_TextChanged(sender As Object, e As EventArgs) Handles texproveedor.TextChanged

    End Sub

    Private Sub Button1_GotFocus(sender As Object, e As EventArgs) Handles Button1.GotFocus
        Me.Button1.Height = 40
        Me.Button1.Width = 175
    End Sub

 
    Private Sub Button1_LostFocus(sender As Object, e As EventArgs) Handles Button1.LostFocus
        Me.Button1.Height = 37
        Me.Button1.Width = 147
    End Sub

    Private Sub Button2_GotFocus(sender As Object, e As EventArgs) Handles Button2.GotFocus
        Me.Button2.Height = 40
        Me.Button2.Width = 175
    End Sub

    Private Sub Button2_LostFocus(sender As Object, e As EventArgs) Handles Button2.LostFocus
        Me.Button2.Height = 37
        Me.Button2.Width = 147
    End Sub

    Private Sub Button3_GotFocus(sender As Object, e As EventArgs) Handles Button3.GotFocus
        Me.Button3.Height = 40
        Me.Button3.Width = 175
    End Sub

    Private Sub Button3_LostFocus(sender As Object, e As EventArgs) Handles Button3.LostFocus
        Me.Button3.Height = 37
        Me.Button3.Width = 147
    End Sub

    Private Sub Button4_GotFocus(sender As Object, e As EventArgs) Handles Button4.GotFocus
        Me.Button4.Height = 40
        Me.Button4.Width = 175
    End Sub

    Private Sub Button4_LostFocus(sender As Object, e As EventArgs) Handles Button4.LostFocus
        Me.Button4.Height = 37
        Me.Button4.Width = 147
    End Sub

    Private Sub Button5_GotFocus(sender As Object, e As EventArgs) Handles Button5.GotFocus
        Me.Button5.Height = 40
        Me.Button5.Width = 175
    End Sub


    Private Sub Button5_LostFocus(sender As Object, e As EventArgs) Handles Button5.LostFocus
        Me.Button5.Height = 37
        Me.Button5.Width = 147
    End Sub

    Private Sub Button6_GotFocus(sender As Object, e As EventArgs) Handles Button6.GotFocus
        Me.Button6.Height = 40
        Me.Button6.Width = 175
    End Sub

    Private Sub Button6_LostFocus(sender As Object, e As EventArgs) Handles Button6.LostFocus
        Me.Button6.Height = 37
        Me.Button6.Width = 147
    End Sub

    Private Sub Button7_GotFocus(sender As Object, e As EventArgs)
        
    End Sub

    Private Sub Button7_LostFocus(sender As Object, e As EventArgs)
     
    End Sub

    Dim mita, todo As Double
    Private Sub texd1_KeyUp(sender As Object, e As KeyEventArgs) Handles texd1.KeyUp
        Try
            If Me.texd1.Text.Trim.ToString = "" Then
                Me.texd2.Text = todo
            Else
                Dim tex As String = Me.texd1.Text.ToString
                If CDbl(Me.texd1.Text) > todo Then
                    Me.texd1.Text = tex.Substring(0, tex.Length - 1)
                Else
                    If cheklibred.Checked <> True Then
                        If Me.texd1.Text = "" Then
                            Me.texd1.Text = "0"
                        Else

                            mita = Math.Round(todo - CDbl(Me.texd1.Text), 3)

                            Me.texd2.Text = mita

                        End If
                    End If
                End If

            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub texd2_KeyUp(sender As Object, e As KeyEventArgs) Handles texd2.KeyUp
        Try
            If Me.texd2.Text.Trim.ToString = "" Then
                texd1.Text = todo
            Else
                Dim tex As String = Me.texd2.Text.ToString
                If CDbl(Me.texd2.Text) > todo Then
                    Me.texd2.Text = tex.Substring(0, tex.Length - 1)
                Else
                    If cheklibred.Checked <> True Then
                        If Me.texd2.Text = "" Then
                            Me.texd2.Text = "0"
                        Else
                            mita = Math.Round(todo - CDbl(Me.texd2.Text), 3)

                            Me.texd1.Text = mita

                        End If
                    End If
                End If
            End If

        Catch ex As Exception

        End Try
    End Sub

  
    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Me.texd1.Text = Math.Round((todo / 2), 3)
        Me.texd2.Text = Math.Round((todo / 2), 3)
    End Sub

 
End Class