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
    Public codfacturac As String
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

    'para el uno por ciento retencion
    Dim unopc As Double = 0
    Dim guardado As Boolean = False

    'para ver si esta siendo editado o no
    Public estado As String = "nuevo"
    Private guardar As Boolean = False

    Private Sub compra_Disposed(sender As Object, e As EventArgs) Handles Me.Disposed

        If guardar = False Then
            If MsgBox("Desea guardar el documento", MsgBoxStyle.YesNo, "aviso") = MsgBoxResult.Yes Then
                botguardar_Click_1(sender, e)
            End If
        End If
        


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
            dtfacturacompra = facturacompras.Consultar(" where codfacturac = " & codfacturac)
            dtproveedores = tproveedores1.Consultar(" where codproveedor = " & dtfacturacompra.Rows(0).Item(3))
            Me.idproveedor = dtproveedores.Rows(0).Item(0)
            Me.texproveedor.Text = dtproveedores.Rows(0).Item(1)
            Me.combotipo.Text = dtfacturacompra.Rows(0).Item(2)
            Me.coboformadepago.Text = dtfacturacompra.Rows(0).Item(11)
            Me.texnumfact.Text = dtfacturacompra.Rows(0).Item(1)
            Me.textiraje.Text = dtfacturacompra.Rows(0).Item(14)
            Me.DateTimePicker1.Value = dtfacturacompra.Rows(0).Item(4).ToString
            If Me.dtfacturacompra.Rows(0).Item(11).ToString <> "0" Then
                Me.check1.Checked = True
            End If
            Me.primeraf = False

            Dim num As Double = CDbl(dtfacturacompra.Rows(0).Item(10))
            convertirnumeroletras(num)
            cargarfactura()

            'Cuando todo ha salido bien hace los cargos a las existencias
            Dim c As Double = 0
            For i As Integer = 0 To dtdetallefacturacompra.Rows.Count - 1
                dtproducto = tproductos.Consultar(" where codproducto = '" + dtdetallefacturacompra.Rows(i).Item(2).ToString + "'")
                c = CDbl(CDbl(dtproducto.Rows(0).Item(6)) - dtdetallefacturacompra.Rows(i).Item(3))
                consultar.Consultar(" update productos set existencias = " + c.ToString + " where codproducto = '" + dtdetallefacturacompra.Rows(i).Item(2).ToString + "'")
            Next

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

                    facturacompras.Insertar("'" & CDbl(0) & "','" & 0 & "','" & 0 & "','" & f & "'," & CDbl(0).ToString & "," & CDbl(0) & "," & CDbl(0).ToString & "," & CDbl(0).ToString & "," & CDbl(0).ToString & "," & CDbl(0).ToString & ",'" & 0 & "',0,'valida','" & 0 & "'")

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


          Dim prereal As Double
            Dim ventatotal As Double = CDbl(Me.textotalp.Text.ToString)
            Dim totalfactura As Double = 0.0


            detallefacturacompra.Insertar(CInt(Me.codfacturac).ToString & "," & idproducto & "," & CDbl(Me.texcantidad.Text).ToString & ",0," & prereal & ",0," & ventatotal & ", 0 ," & CDbl(Me.texprecio.Text))

            privar()

            cargarfactura()


        Catch ex As Exception
            MsgBox("Ocurrio un error a la hora de insertar el articulo razon: " + ex.Message, MsgBoxStyle.Critical, "Aviso")
        End Try
    End Sub
    Dim sumaf, sumac As Double
    Private Sub cargarfactura()
        Try
           
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

          

            dtdetallefacturacompra = detallefacturacompra.Consultar(" where codfacturac = '" + codfacturac.ToString + "'")
            Dim nf As Short
            nf = dtdetallefacturacompra.Rows.Count

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

            For i As Integer = 0 To dtdetallefacturacompra.Rows.Count - 1

                 If Me.combotipo.Text <> "Factura" Then
                    dtproducto = tproductos.Consultar(" where codproducto = " + CInt(dtdetallefacturacompra.Rows(i).Item(2)).ToString)

                    sumas += Math.Round(CDbl(dtdetallefacturacompra.Rows(i).Item(7)), 2)

                    Me.gridcompra.Rows(i).Cells(0).Value = dtdetallefacturacompra.Rows(i).Item(2)
                    Me.gridcompra.Rows(i).Cells(1).Value = dtdetallefacturacompra.Rows(i).Item(3)
                    Me.gridcompra.Rows(i).Cells(2).Value = dtproducto.Rows(0).Item(1)
                    Me.gridcompra.Rows(i).Cells(3).Value = dtdetallefacturacompra.Rows(i).Item(9)
                    Me.gridcompra.Rows(i).Cells(4).Value = "0"
                    Me.gridcompra.Rows(i).Cells(5).Value = "0"
                    Me.gridcompra.Rows(i).Cells(6).Value = dtdetallefacturacompra.Rows(i).Item(7)


                Else
                    dtproducto = tproductos.Consultar(" where codproducto = " + CInt(dtdetallefacturacompra.Rows(i).Item(2)).ToString)

                    sumas += Math.Round(CDbl(dtdetallefacturacompra.Rows(i).Item(7)), 2)

                    Me.gridcompra.Rows(i).Cells(0).Value = dtdetallefacturacompra.Rows(i).Item(2)
                    Me.gridcompra.Rows(i).Cells(1).Value = dtdetallefacturacompra.Rows(i).Item(3)
                    Me.gridcompra.Rows(i).Cells(2).Value = dtproducto.Rows(0).Item(1)
                    Me.gridcompra.Rows(i).Cells(3).Value = dtdetallefacturacompra.Rows(i).Item(9)
                    Me.gridcompra.Rows(i).Cells(4).Value = "0"
                    Me.gridcompra.Rows(i).Cells(5).Value = "0"
                    Me.gridcompra.Rows(i).Cells(6).Value = dtdetallefacturacompra.Rows(i).Item(7)


                End If
            


            Next


            Me.texsumas.Text = CDbl(sumas)
            Dim uno As Double = 0
            If Me.combotipo.Text.ToString <> "Factura" Then
                iva = Math.Round((sumas * 0.13), 2)

                Me.texiva.Text = iva

                If check1.Checked Then
                    uno = Math.Round((sumas * 0.01), 2)
                    Me.textotal.Text = CDbl(sumas + iva + uno)
                    Me.texivauno.Text = uno
                Else
                    Me.textotal.Text = CDbl(sumas + iva)
                End If


            Else
                Me.textotal.Text = CDbl(sumas)

            End If

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
         
            Try
                If primeraf = False Then
                    Dim can As Double
                    Dim tl As Double
                    Dim f As Boolean = False

                    For i As Integer = 0 To dtdetallefacturacompra.Rows.Count - 1
                        If idproducto.ToString = dtdetallefacturacompra.Rows(i).Item(2).ToString Then
                       
                                can = Math.Round(CDbl(dtdetallefacturacompra.Rows(i).Item(3) + CDbl(Me.texcantidad.Text)), 2)
                                tl = Math.Round(CDbl(dtdetallefacturacompra.Rows(i).Item(7)) + CDbl(Me.textotalp.Text.Trim), 2)


                                consultar.Consultar("update detallecompra set total = " & tl & ", cantidadunit = " & can.ToString & " where codfacturac = " & codfacturac.ToString & " and coddetallefacturac = " & dtdetallefacturacompra.Rows(i).Item(0).ToString)

                                f = True
                                cargarfactura()
                            End If
                    Next
                    If f = False Then
                        insertar()
                    End If
                Else
                    insertar()
                End If

                Dim num As Double = CDbl(Me.textotal.Text)
                convertirnumeroletras(num)

                


            Catch ex As Exception
                MsgBox("Ocurrio un error asegurese de haber llenado todos los campo correctamente", MsgBoxStyle.OkOnly, "Avise")
            End Try
        Else
            MsgBox("Tiene que llenar los datos que estan en rojo", MsgBoxStyle.ApplicationModal, "Aviso")
        End If

    End Sub

    Private Sub convertirnumeroletras(ByVal numero As Double)
        Dim numletras1 As New NumeroLetras
        Dim nl As String
        numletras1.setnumero(numero)
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

    End Sub

    Private Sub botguardar_Click_1(sender As Object, e As EventArgs) Handles botguardar.Click
        Try
            guardar = True
            Dim ella As String = ""
            If guardado = False Then
                guardado = True
                If combotipo.Text = "Factura" Then
                    ella = "La "
                Else
                    ella = "El "
                End If

                Me.totalfactu = Me.textotal.Text


                d = Me.DateTimePicker1.Value.Day
                m = Me.DateTimePicker1.Value.Month
                a = Me.DateTimePicker1.Value.Year
                f = a + "-" + m + "-" + d

                'facturacompras.Insertar("'" & Me.texnumfact.Text.ToString.Trim & "','" & Me.combotipo.Text.ToString & "','" & idproveedor & "','" & f & "'," & CDbl(0).ToString & "," & CDbl(0) & "," & CDbl(0).ToString & "," & CDbl(0).ToString & "," & CDbl(0).ToString & "," & CDbl(0).ToString & ",'" & Me.coboformadepago.Text.ToString & "',0,'valida','" & Me.textiraje.Text.ToString & "'")


                If Me.check1.Checked Then
                    consultar.Consultar(" update facturacompra set numfacturac = '" & Me.texnumfact.Text.ToString.Trim & "', tipo = '" & Me.combotipo.Text.ToString & "', codproveedor = '" & idproveedor & "', fecha = '" & f & "', formadepago = '" & Me.coboformadepago.Text.ToString & "', tiraje = '" & Me.textiraje.Text.ToString & "', " & "sumas = " & Me.texsumas.Text.Trim.ToString & ", iva = " & Me.texiva.Text.Trim.ToString & ", total = " & Me.textotal.Text.Trim.ToString & ", unoretencion = " & Me.texivauno.Text.Trim.ToString & " where codfacturac = " & codfacturac)
                Else
                    consultar.Consultar(" update facturacompra set numfacturac = '" & Me.texnumfact.Text.ToString.Trim & "', tipo = '" & Me.combotipo.Text.ToString & "', codproveedor = '" & idproveedor & "', fecha = '" & f & "', formadepago = '" & Me.coboformadepago.Text.ToString & "', tiraje = '" & Me.textiraje.Text.ToString & "', " & " sumas = " & Me.texsumas.Text.Trim.ToString & ", iva = " & Me.texiva.Text.Trim.ToString & ", total = " & Me.textotal.Text.Trim.ToString & ",  unoretencion = 0 where codfacturac = " & codfacturac)
                End If

                'Cuando todo ha salido bien hace los cargos a las existencias
                Dim c As Double = 0
                For i As Integer = 0 To dtdetallefacturacompra.Rows.Count - 1
                    dtproducto = tproductos.Consultar(" where codproducto = '" + dtdetallefacturacompra.Rows(i).Item(2).ToString + "'")
                    c = CDbl(dtdetallefacturacompra.Rows(i).Item(3) + CDbl(dtproducto.Rows(0).Item(6)))
                    consultar.Consultar(" update productos set existencias = " + c.ToString + " where codproducto = '" + dtdetallefacturacompra.Rows(i).Item(2).ToString + "'")
                Next



                If MsgBox(ella & combotipo.Text.ToString & " Se ingreso exitozamente" & vbCrLf _
                          & " Desea agregar otra compra?", MsgBoxStyle.YesNo, "Compra") = MsgBoxResult.Yes Then
                    mdiMain.llama = "compra"
                    Me.Close()
                    mdiMain.timllamar.Enabled = True
                Else
                    Me.Close()
                End If



            End If
        Catch ex As Exception
            MsgBox("Ocurrio un error al ingresar la factura razon: " + ex.Message, MsgBoxStyle.Critical, "Aviso")
        End Try


    End Sub


    Private Sub botsalir_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub


    Dim cantidad, preciot, totalp As Double


    Private Sub textotalp_KeyUp(sender As Object, e As KeyEventArgs) Handles textotalp.KeyUp
        Try
            If checklibre.Checked <> True Then
                If Me.textotalp.Text = "" Or Me.texcantidad.Text = "" Then
                    Me.texprecio.Text = ""
                Else

                    Me.cantidad = CDbl(Me.texcantidad.Text)
                    Me.totalp = CDbl(Me.textotalp.Text)


                    Me.texprecio.Text = Math.Round(Me.totalp / Me.cantidad, 2)

                End If
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub texcantidad_KeyUp(sender As Object, e As KeyEventArgs) Handles texcantidad.KeyUp, texprecio.KeyUp
        Try
            If checklibre.Checked <> True Then
                If Me.textotalp.Text = "" Or Me.texcantidad.Text = "" Then
                    Me.texprecio.Text = ""
                Else

                    Me.cantidad = CDbl(Me.texcantidad.Text)
                    Me.totalp = CDbl(Me.textotalp.Text)


                    Me.texprecio.Text = Math.Round((totalp) / Me.cantidad, 2)

                End If
            End If

        Catch ex As Exception

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

    Private Sub boteliminar_Click(sender As Object, e As EventArgs) Handles boteliminar.Click
        Try
            Dim id As Short = Me.gridcompra.CurrentCell.RowIndex
            Dim dtrdetalle As DataRow = dtdetallefacturacompra.Rows(id)

            If MsgBox("Esta seguro de quitar el producto de la factura? ", MsgBoxStyle.YesNo, "Aviso") = MsgBoxResult.Yes Then
                consultar.Consultar("delete from detallecompra where coddetallefacturac = " & dtrdetalle.Item(0))
                cargarfactura()
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub texprecio_TextChanged(sender As Object, e As EventArgs) Handles texprecio.TextChanged

    End Sub
End Class