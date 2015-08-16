Imports logica
Imports pjtAdus
Imports validaciones
Imports System.Drawing.Printing

Public Class Ventas
    Public dtrclientes As DataRow
    Public dtrproductos As DataRow
    Private tventas As New clsMaestros(clsNomTab.eTbl.FacturaVenta)
    Private dtventas As DataTable
    Private tdetalleventa As New clsMaestros(clsNomTab.eTbl.DetalleFacturaV)
    Private dtproducto As DataTable
    Private tproductos As New clsMaestros(clsNomTab.eTbl.Productos)

    Private dtdetalleventa As DataTable

    Public primeraf As Boolean = True
    Public primera As Boolean = True

    Private dtcodfactura As DataTable
    Private codfactura As Integer
    Private consultar As New clsProcesos
    Private clsvalidar As validar

    Public tdescuento As New clsMaestros(clsNomTab.eTbl.Descuentos)
    Public dtdecuento As DataTable

    Private subtotal1 = 0, subtotal2 = 0, subtotal3 = 0, iva = 0, descuentof = 0, totalf As Double
    Private sumas = 0, descuento = 0, iva1 = 0, cotrans = 0, fovial = 0, totalfactu, cantidadproducto, totalproducto As Double
    Private sumas1 = 0, descuento1 = 0, iva2 = 0, cotrans2 = 0, fovial2 = 0, totalfactu2, cantidadproducto2, totalproducto2 As Double

    'para la modificacionde la factura
    Public dtclientes As DataTable
    Public dtproductos As DataTable
    Public dtfacturaventas As DataTable
    Public dtdetallefacturaventas As DataTable
    Public donde As String = "here"
    Public contador As Integer
    Public frmdv As DetalleVenta
    Public frmvr As VentasRealizadas
    'Aqui termina los atributos para la modificacion de la factura
    Private llenara As Boolean = False

    'id para el producto y para los proveedores
    Public idproducto As String
    Public idcliente As String

    'para la variable de agregar
    Dim agregarv As Boolean = False


    ' Para los proveedores y productos
    Private tclientes1 As New clsMaestros(clsNomTab.eTbl.Clientes)
    Private dtclientes11 As DataTable

    Private tproductos1 As New clsMaestros(clsNomTab.eTbl.Productos)
    Private dtproductos1 As DataTable
    'aqui termina


    ' Para los tanques
    Dim ttanques As New clsMaestros(clsNomTab.eTbl.Tanques)
    Dim dttanques As DataTable
    Dim tbombas As New clsMaestros(clsNomTab.eTbl.Bombas)
    Dim dtbombas As DataTable

    Dim guardado As Boolean = False

    Dim contafactura As Short

    Dim tclientesfinales As New clsMaestros(clsNomTab.eTbl.clientescf)

    Private Sub Ventas_Deactivate(sender As Object, e As EventArgs) Handles Me.Deactivate
        salirnada()
    End Sub

    Private Sub salirnada()
        Dim sender As Object
        Dim e As EventArgs
        If agregarv = True And guardado = False Then
            If MsgBox("No a guardado los cambios desea guardar y salir", MsgBoxStyle.YesNo, "Aviso") = MsgBoxResult.Yes Then
                Me.botguardar_Click(sender, e)
                mdiMain.teclas = False
            Else
                Me.Close()
                mdiMain.teclas = False
            End If

        Else
            Me.Close()
        End If
    End Sub

    Private Sub Ventas_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        If guardado = False Then
            If (e.KeyChar) = "c" Or (e.KeyChar) = "C" Then
                Button1.Select()
            ElseIf (e.KeyChar) = "A" Or (e.KeyChar) = "a" Then
                Button4.Select()
            ElseIf (e.KeyChar) = "B" Or (e.KeyChar) = "b" Then
                Me.controlbombas.Select()
            ElseIf (e.KeyChar) = "g" Or (e.KeyChar) = "G" Then
                botguardar_Click(sender, e)
            End If
        Else
            If (e.KeyChar) = "1" Then
                checdiesel1.Checked = True
            ElseIf (e.KeyChar) = "2" Then
                chekregular1.Checked = True
            ElseIf (e.KeyChar) = "3" Then
                chekdiesel2.Checked = True
            ElseIf (e.KeyChar) = "4" Then
                chekregular2.Checked = True
            ElseIf (e.KeyChar) = "5" Then
                chekdiesel3.Checked = True
            ElseIf (e.KeyChar) = "6" Then
                cheksuper.Checked = True
            ElseIf (e.KeyChar) = "g" Or (e.KeyChar) = "G" Then
                botguardar_Click(sender, e)
            End If
        End If

    End Sub
    Private Sub Ventas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        Me.texcliente.Select()
        Try
            MdiParent = mdiMain
            If donde <> "here" Then
                cargardatos()
            Else
                MdiParent = mdiMain
                cargarcp()
            End If
        Catch ex As Exception
            MsgBox("Ocurrio un error asegurese de haber llenado todos los campo correctamente razon: " & ex.Message, MsgBoxStyle.OkOnly, "Avise")
        End Try

    End Sub

    Private Sub cargarcp()
        dtclientes11 = tclientes1.Consultar(" where codempresa = '" & mdiMain.codigoempresa.ToString & "'")
        dtproductos1 = tproductos1.Consultar(" where codempresa = '" & mdiMain.codigoempresa.ToString & "'")

        Dim nfp1 As Short = dtclientes11.Rows.Count
        Dim nfp2 As Short = dtproductos1.Rows.Count



        If nfp1 >= 1 Then
            Me.texco1.Text = dtclientes11.Rows(0).Item(0)
            Me.texprovee1.Text = dtclientes11.Rows(0).Item(1)
            If nfp1 >= 2 Then
                Me.texco2.Text = dtclientes11.Rows(1).Item(0)
                Me.texprovee2.Text = dtclientes11.Rows(1).Item(1)
                If nfp1 >= 3 Then
                    Me.texco3.Text = dtclientes11.Rows(2).Item(0)
                    Me.texprovee3.Text = dtclientes11.Rows(2).Item(1)
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
            Me.texcliente.Text = dtclientes.Rows(0).Item(1)
            Me.combotipo.Text = dtfacturaventas.Rows(contador).Item(11)
            Me.comboformapago.Text = dtfacturaventas.Rows(contador).Item(12)
            Me.texnumfact.Text = dtfacturaventas.Rows(contador).Item(1)
            Me.DateTimePicker1.Value = dtfacturaventas.Rows(contador).Item(4).ToString
            Me.codfactura = dtfacturaventas.Rows(contador).Item(0)
            cargarfactura()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub texproveedor_Click(sender As Object, e As EventArgs) Handles texcliente.Click
      

    End Sub

    Private Sub texnombrep_Click(sender As Object, e As EventArgs)
        Try
            pjtAdus.Productos.donde = "ventas"
            pjtAdus.Productos.frmv = Me
            pjtAdus.Productos.Show()
            Me.textotalp.Select()
        Catch ex As Exception

        End Try

    End Sub

   
    Private Function validar() As Boolean
        Return True
    End Function


    Private Sub insertar()
        If validar() Then

            If primeraf = True Then
                primeraf = False
                Dim d, m, a, f As String
                d = Me.DateTimePicker1.Value.Day
                m = Me.DateTimePicker1.Value.Month
                a = Me.DateTimePicker1.Value.Year
                f = a + "-" + m + "-" + d

                If Me.combotipo.Text = "Factura" Then
                    If llenara = False Then
                        Dim cf As New clsMaestros(clsNomTab.eTbl.clientescf)
                        Dim dtcf As DataTable
                        Dim ncf As Integer

                        cf.Insertar("'" & Me.texcliente.Text.Trim.ToString & "'")

                        dtcf = consultar.Consultar("SELECT  max(idclientescf) FROM clientescf")

                        ncf = CInt(dtcf.Rows(0).Item(0))
                        idcliente = ncf
                    End If
                Else
                    If Me.llenara = False Then
                        Dim ncc As Integer
                        Dim dtncc As DataTable
                        Dim consultar As New clsProcesos
                        dtncc = consultar.Consultar(" select max(codcliente) from cliente")
                        ncc = CInt(dtncc.Rows(0).Item(0))
                        ncc += 1
                        consultar.Consultar("Insert into cliente (codcliente,nombre,nrc,codempresa,estado,tipo) values(" & ncc & ",'" & Me.texcliente.Text.Trim.ToString & "','" & Me.texnrc.Text.Trim.ToString & "','" & mdiMain.codigoempresa.ToString & "','Activo','Contribuyente')")
                        idcliente = ncc
                    End If
                End If

                tventas.Insertar("'" & Me.texnumfact.Text.ToString.Trim & "','" & Me.combotipo.Text.ToString & "','" & idcliente & "','" & mdiMain.codigoempresa.ToString & "','" & f & "'," & CDbl(0).ToString & "," & CDbl(0) & "," & CDbl(0).ToString & "," & CDbl(0).ToString & "," & CDbl(0).ToString & "," & CDbl(0).ToString & "," & CDbl(0).ToString & "," & CDbl(0) & ",'" & Me.comboformapago.Text.ToString & "','valida','" & Me.textiraje.Text.ToString & "'")
                dtcodfactura = consultar.Consultar("SELECT  Max(codfacturav) FROM facturaventa")
                codfactura = dtcodfactura.Rows(0).Item(0)
                insertardetalle()
            Else
                insertardetalle()
            End If
        End If

    End Sub


    Private Sub privar()
        Try
            Me.texprecio.Text = ""
            Me.texcantidad.Text = ""
            Me.textotalp.Text = ""
            Me.texnombrep.Text = ""
            Me.texcliente.Enabled = False
            Me.texnumfact.Enabled = False
            Me.combotipo.Enabled = False
            Me.comboformapago.Enabled = False
            Me.DateTimePicker1.Enabled = False
        Catch ex As Exception

        End Try

    End Sub

    Private Sub activarcheques(ByVal t As Short)
        If t = 1 Or t = 3 Or t = 5 Then
            Me.checdiesel1.Visible = True
            Me.checdiesel1.Checked = True
            Me.chekdiesel3.Visible = True
            Me.chekdiesel2.Visible = True
        ElseIf t = 2 Or t = 4 Then
            Me.chekregular1.Visible = True
            Me.chekregular2.Visible = True
            Me.chekregular1.Checked = True
        Else
            Me.cheksuper.Visible = True
        End If
    End Sub

    Private Sub llenartanque(ByVal id As Short)
        If id = 1 Then
            activarcheques(6)
            Me.cheksuper.Checked = True
        ElseIf id = 2 Then
            activarcheques(2)
        ElseIf id = 3 Then
            activarcheques(1)
        End If
    End Sub

    Private Sub insertardetalle()
        Try
            dtdecuento = tdescuento.Consultar(" where codproducto = " & idproducto)

            Dim prereal, totalfactura, canti As Double
            If dtdecuento.Rows(0).Item(2).ToString = "True" Then

                If Me.combotipo.Text = "Factura" Then

                    prereal = Me.texprecio.Text
                    prereal = Math.Round((prereal - 0.3), 2)
                    canti = texcantidad.Text
                    totalfactura = Math.Round((canti * prereal), 2)

                Else
                    prereal = Me.texprecio.Text
                    prereal = Math.Round((prereal - 0.3), 2)
                    prereal = Math.Round(prereal / 1.13, 2)
                    canti = texcantidad.Text
                    totalfactura = Math.Round((canti * prereal), 2)
                End If
            Else
                prereal = Math.Round((CDbl(Me.texprecio.Text) / 1.13), 2)
                totalfactura = Math.Round((CDbl(Me.texcantidad.Text) * prereal), 2)
                
            End If

            llenartanque(idproducto)
            prereal = Math.Round(prereal, 2)
            totalfactura = Math.Round(totalfactura, 2)
            canti = Math.Round(canti, 2)


            ' tdetalleventa.Insertar(CInt(Me.codfactura).ToString + ",'" + dtrproductos.Item(0).ToString + "'," + CInt(Me.texcantidad.Text).ToString + ",0," + CDbl(Me.texprecio.Text).ToString + ",0,'" + mdiMain.codigoempresa.ToString + "'," + CDbl(Me.textotalp.Text).ToString)
            tdetalleventa.Insertar(CInt(Me.codfactura).ToString & "," & idproducto & "," & CDbl(Me.texcantidad.Text).ToString & ",0," & prereal & ",0,'" & mdiMain.codigoempresa.ToString & "'," & totalfactura & "," & CDbl(Me.textotalp.Text) & "," & CDbl(Me.texprecio.Text))
            privar()
            cargarfactura()

        Catch ex As Exception
            MsgBox("Ocurrio un error a la hora de insertar el articulo razon: " + ex.Message, MsgBoxStyle.Critical, "Aviso")
        End Try
    End Sub
    Dim sumaf, sumac As Double

    Private Sub cargarfactura()
        Try
            subtotal1 = 0
            subtotal2 = 0
            subtotal3 = 0
            iva = 0
            descuentof = 0
            totalf = 0

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
            Me.textotal.Text = ""



            dtdetalleventa = tdetalleventa.Consultar(" where codfacturav = '" + codfactura.ToString + "'")
            Dim nf As Short
            nf = dtdetalleventa.Rows.Count

            subtotal1 = 0

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
            For i As Integer = 0 To dtdetalleventa.Rows.Count - 1

                If Me.combotipo.Text <> "Factura" Then
                    dtproducto = tproductos.Consultar(" where codproducto = " + CInt(dtdetalleventa.Rows(i).Item(2)).ToString)



                    dtdecuento = tdescuento.Consultar(" where codproducto = " & dtproducto.Rows(0).Item(0))

                    cantidadproducto = Math.Round(CDbl(dtdetalleventa.Rows(i).Item(3)), 2)
                    totalproducto = Math.Round(CDbl(dtdetalleventa.Rows(i).Item(9)), 2)

                    If dtdecuento.Rows(0).Item(2).ToString = "False" Then
                        sumaf = Math.Round(CDbl(dtdetalleventa.Rows(i).Item(3)) * 0.2, 2)
                        sumac = Math.Round(CDbl(dtdetalleventa.Rows(i).Item(3)) * 0.1, 2)
                    End If

                    fovial = Math.Round(cantidadproducto * 0.2, 2)
                    cotrans = Math.Round(cantidadproducto * 0.1, 2)

                    fovial -= sumaf
                    cotrans -= sumac

                    sumas = Math.Round((totalproducto - fovial - cotrans), 2)

                    sumas = Math.Round((sumas / 1.13), 2)

                    iva = Math.Round((sumas * 0.13), 2)

                    consultar.Consultar("UPDATE detalleventa SET total = " & sumas & " where coddetallefacturav = " & dtdetalleventa.Rows(i).Item(0))
                    dtdetalleventa = tdetalleventa.Consultar(" where codfacturav = '" + codfactura.ToString + "'")
                    dtproducto = tproductos.Consultar(" where codproducto = " & CInt(dtdetalleventa.Rows(i).Item(2)).ToString)
                    Me.gridcompra.Rows(i).Cells(0).Value = dtdetalleventa.Rows(i).Item(3)
                    Me.gridcompra.Rows(i).Cells(1).Value = dtproducto.Rows(0).Item(1)
                    Me.gridcompra.Rows(i).Cells(2).Value = dtdetalleventa.Rows(i).Item(5)
                    Me.gridcompra.Rows(i).Cells(3).Value = "0"
                    Me.gridcompra.Rows(i).Cells(4).Value = "0"
                    Me.gridcompra.Rows(i).Cells(5).Value = dtdetalleventa.Rows(i).Item(8)

                    sumas1 += sumas
                    iva2 += iva
                    cotrans2 += cotrans
                    fovial2 += fovial
                    totalproducto2 += totalproducto
                Else
                    dtproducto = tproductos.Consultar(" where codproducto = " + CInt(dtdetalleventa.Rows(i).Item(2)).ToString)



                    dtdecuento = tdescuento.Consultar(" where codproducto = " & dtproducto.Rows(0).Item(0))

                    cantidadproducto = Math.Round(CDbl(dtdetalleventa.Rows(i).Item(3)), 3)
                    totalproducto = Math.Round(CDbl(dtdetalleventa.Rows(i).Item(9)), 3)

                    If dtdecuento.Rows(0).Item(2).ToString = "False" Then
                        sumaf = Math.Round(CDbl(dtdetalleventa.Rows(i).Item(3)) * 0.2, 3)
                        sumac = Math.Round(CDbl(dtdetalleventa.Rows(i).Item(3)) * 0.1, 3)
                    End If

                    fovial = Math.Round(cantidadproducto * 0.2, 3)
                    cotrans = Math.Round(cantidadproducto * 0.1, 3)

                    fovial -= sumaf
                    cotrans -= sumac

                    sumas = Math.Round((totalproducto - fovial - cotrans), 3)


                    consultar.Consultar("UPDATE detalleventa SET total = " & sumas & " where coddetallefacturav = " & dtdetalleventa.Rows(i).Item(0))
                    dtdetalleventa = tdetalleventa.Consultar(" where codfacturav = '" + codfactura.ToString + "'")
                    dtproducto = tproductos.Consultar(" where codproducto = " & CInt(dtdetalleventa.Rows(i).Item(2)).ToString)
                      Me.gridcompra.Rows(i).Cells(0).Value = dtdetalleventa.Rows(i).Item(3)
                    Me.gridcompra.Rows(i).Cells(1).Value = dtproducto.Rows(0).Item(1)
                    Me.gridcompra.Rows(i).Cells(2).Value = dtdetalleventa.Rows(i).Item(5)
                    Me.gridcompra.Rows(i).Cells(3).Value = "0"
                    Me.gridcompra.Rows(i).Cells(4).Value = "0"
                    Me.gridcompra.Rows(i).Cells(5).Value = Math.Round(CDbl(dtdetalleventa.Rows(i).Item(8)), 2)

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


            Me.texsumas.Text = Math.Round(sumas1, 2)
            Me.texfovial.Text = Math.Round(fovial2, 2)
            Me.texiva.Text = Math.Round(iva2, 2)
            Me.texcotrans.Text = Math.Round(cotrans2, 2)
            Me.textotal.Text = Math.Round(totalproducto2, 2)

        Catch ex As Exception
            MsgBox("Ocurrio un error al momento de llenar registrar el articulo en la factura razon: " + ex.Message, MsgBoxStyle.Critical, "Aviso")
        End Try
      
    End Sub



    Private Sub texnombrep_Click1(sender As Object, e As EventArgs) Handles texnombrep.Click
        pjtAdus.Productos.donde = "ventas"
        pjtAdus.Productos.frmv = Me
        pjtAdus.Productos.Show()
    End Sub

   
    Dim cantidad, preciot As Double

    Private Sub texcantidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles texcantidad.KeyPress, texprecio.KeyPress, textotalp.KeyPress, texnumfact.KeyPress
        Try
            e.Handled = onlynumero(e)
            e.Handled = onlynumero(e)
            If (Asc(e.KeyChar)) = 13 Then
                botagregar_Click(sender, e)
            End If
        Catch ex As Exception

        End Try

    End Sub

    Public Function onlynumero(ByVal caracter As System.Windows.Forms.KeyPressEventArgs)

        If (Asc(caracter.KeyChar)) >= 48 And (Asc(caracter.KeyChar)) <= 57 Or _
          (Asc(caracter.KeyChar)) = System.Windows.Forms.Keys.Back Or (Asc(caracter.KeyChar)) = 46 Then
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub texcantidad_KeyUp(sender As Object, e As KeyEventArgs) Handles texcantidad.KeyUp, texprecio.KeyUp
        Try
            If checklibre.Checked <> True Then
                If Me.texprecio.Text = "" Or Me.texcantidad.Text = "" Then
                Else
                    Me.cantidad = CDbl(Me.texcantidad.Text)
                    Me.preciot = CDbl(Me.texprecio.Text)
                    Me.textotalp.Text = cantidad * preciot
                End If
            End If
        Catch ex As Exception
            MsgBox("Ingrese datos en los campos para realizar los calculos", MsgBoxStyle.Critical, "Aviso")
        End Try

    End Sub

    Private Sub botappdescuento_Click(sender As Object, e As EventArgs) Handles botappdescuento.Click
        If primeraf = True Then
            MsgBox("Teene que igresar almenos un articulo para aplicar descuentos", MsgBoxStyle.OkOnly, "Aviso")
        Else
            Me.grubdescuento.Visible = True
        End If
    End Sub

    Private Sub botsalir_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

   
    Private Sub combotipo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles combotipo.SelectedIndexChanged
        Try
            Dim dtcodf As DataTable
            Dim tcodf As New clsProcesos
            Dim tt As New clsProcesos
            Dim dttt As DataTable
            Dim n As String = ""
            Dim n1 As Integer = 0

            If Me.combotipo.Text.Trim.ToString <> "Factura" Then
                Me.texnrc.Visible = True
                Me.lnrc.Visible = True
            Else
                Me.texnrc.Visible = False
                Me.lnrc.Visible = False
            End If

            If Me.combotipo.Text.Trim.ToString = "Factura" Then
                dtcodf = tcodf.Consultar("select max(tirajefa) from tirajes")
                dttt = tt.Consultar("select tirajefs from tirajes")
                Me.textiraje.Text = dttt.Rows(0).Item(0).ToString
            Else
                dtcodf = tcodf.Consultar("select max(tirajeca) from tirajes")
                dttt = tt.Consultar("select tirajecs from tirajes")
                Me.textiraje.Text = dttt.Rows(0).Item(0).ToString
            End If


            If dtcodf.Rows(0).Item(0).ToString = "" Then
                Me.texnumfact.Text = "1"
            Else
                Me.texnumfact.Text = CInt(dtcodf.Rows(0).Item(0) + 1).ToString
            End If

        Catch ex As Exception

        End Try

    End Sub

   

    Private Sub btnaplicar_Click(sender As Object, e As EventArgs) Handles btnaplicar.Click

        Try
            Dim dtdescuento As Double = 0
            Dim dttotal As Double = 0
            For i As Integer = 0 To dtdetalleventa.Rows.Count - 1
                dtdescuento = CDbl(dtdetalleventa.Rows(i).Item(8)) * CDbl(CDbl(Me.texpdescuento.Text.Trim) / 100)

                dttotal = CDbl(dtdetalleventa.Rows(i).Item(8)) - dtdescuento

                consultar.Consultar(" update detalleventa set descuento = " & dtdescuento.ToString & ", preciodescuento = " & dttotal.ToString & " where codfacturav = " & codfactura.ToString & " and coddetallefacturav = " & dtdetalleventa.Rows(i).Item(0).ToString)
            Next
            MsgBox("El descuento se a efectuado exitozamente", MsgBoxStyle.OkOnly, "Exito")
            cargarfactura()
        Catch ex As Exception
            MsgBox("Ocurrio un error al aplicar el descuento" + ex.Message, MsgBoxStyle.Critical, "Aviso")
        End Try

    End Sub


    Private Sub guardartanques()
        Dim t1, t2, t3, t4, t5, t6 As Double
        dtdetallefacturaventas = tdetalleventa.Consultar(" where codfacturav = " & codfactura)
        For i As Integer = 0 To dtdetallefacturaventas.Rows.Count - 1

            If dtdetallefacturaventas.Rows(i).Item(2).ToString = "1" Then
                t6 = CDbl(dtdetallefacturaventas.Rows(i).Item(3))
                tanquesybombas(6, t6, i)
            ElseIf dtdetallefacturaventas.Rows(i).Item(2).ToString = "2" Then
                If chekregular1.Checked = True Then
                    t2 = CDbl(dtdetallefacturaventas.Rows(i).Item(3))
                    tanquesybombas(2, t2, i)
                Else
                    t4 = CDbl(dtdetallefacturaventas.Rows(i).Item(3))
                    tanquesybombas(4, t4, i)
                End If
            ElseIf dtdetallefacturaventas.Rows(i).Item(2).ToString = "3" Then
                If checdiesel1.Checked = True Then
                    t1 = CDbl(dtdetallefacturaventas.Rows(i).Item(3))
                    tanquesybombas(1, t1, i)
                ElseIf chekdiesel2.Checked = True Then
                    t3 = CDbl(dtdetallefacturaventas.Rows(i).Item(3))
                    tanquesybombas(3, t3, i)
                Else
                    t5 = CDbl(dtdetallefacturaventas.Rows(i).Item(3))
                    tanquesybombas(5, t5, i)
                End If
            End If
        Next
    End Sub

    Private Sub tanquesybombas(ByVal bom As Short, ByVal t As Double, ByVal indice As Integer)

        Dim vs As Double = 0
        Dim v As Double = 0
        dtbombas = tbombas.Consultar(" where idbombas = " & bom)

        vs = CDbl(dtbombas.Rows(0).Item(3)) + t
        v = CDbl(dtbombas.Rows(0).Item(2)) + CDbl(dtdetallefacturaventas.Rows(indice).Item(9))

        consultar.Consultar("update bombas set ventasdiarias = " & v & ", ventasdiariasgalon = " & vs & " where idbombas = " & bom)

     
    End Sub


    Private Sub imprimir()
        imprimirfactura()

        Me.progresimprimir.Visible = True
        Me.Timerimprimir.Enabled = True
    End Sub



    Private Sub imprimirfactura()
        ' ejemplo simple para imprimir en .NET
        ' Usamos una clase del tipo PrintDocument
        Dim printDoc As New PrintDocument
        'Dim TamañoPersonal As New Printing.PaperSize("Prueba", 650, 425)
        Dim TamañoPersonal As New Printing.PaperSize("Prueba", 700, 550)


        printDoc.DefaultPageSettings.PaperSize = TamañoPersonal
        ' asignamos el método de evento para cada página a imprimir
        AddHandler printDoc.PrintPage, AddressOf print_PrintPage
        ' indicamos que queremos imprimir

        printDoc.Print()
    End Sub

    Private Sub print_PrintPage(ByVal sender As Object, ByVal e As PrintPageEventArgs)

        Dim dtfacturaventa As DataTable
        Dim tfacturaventa As New clsMaestros(clsNomTab.eTbl.FacturaVenta)

        Dim dtdetallefacturaventa As DataTable
        Dim tdetallefacturaventa As New clsMaestros(clsNomTab.eTbl.DetalleFacturaV)

        Dim dtcliente As DataTable
        Dim tcliente As New clsMaestros(clsNomTab.eTbl.Clientes)



        dtfacturaventa = tfacturaventa.Consultar(" where codfacturav = " & Me.codfactura)
        dtdetallefacturaventa = tdetallefacturaventa.Consultar(" where codfacturav = " & Me.codfactura)

        Dim dtp As DataTable
        Dim tp As New clsMaestros(clsNomTab.eTbl.Productos)



        dtcliente = tclientesfinales.Consultar(" where idclientescf = " & dtfacturaventa.Rows(0).Item(3))
       


        ' Este evento se producirá cada vez que se imprima una nueva página
        ' imprimir HOLA MUNDO en Arial tamaño 24 y negrita

        ' imprimimos la cadena en el margen izquierdo
        Dim xPos As Single = e.MarginBounds.Left
        ' La fuente a usar
        Dim prFont As New Font("Arial", 8, FontStyle.Italic)
        ' la posición superior
        Dim yPos As Single = prFont.GetHeight(e.Graphics)




        'para el cliente
        yPos += 110
        xPos += 0
        e.Graphics.DrawString(dtcliente.Rows(0).Item(1), prFont, Brushes.Black, xPos, yPos)

        'para la fecha
        xPos += 380
        'e.Graphics.DrawString(System.DateTime.Today.Day.ToString & "/" & System.DateTime.Today.Month.ToString & "/" & System.DateTime.Today.Year.ToString, prFont, Brushes.Black, xPos, yPos)


        e.Graphics.DrawString(Me.DateTimePicker1.Value.Day.ToString & "/" & Me.DateTimePicker1.Value.Month.ToString & "/" & Me.DateTimePicker1.Value.Year.ToString, prFont, Brushes.Black, xPos, yPos)

        'para la direccion
        yPos += 27
        xPos -= 380
        e.Graphics.DrawString(" ", prFont, Brushes.Black, xPos, yPos)

        'para el nit o dui
        xPos += 380
        e.Graphics.DrawString(" ", prFont, Brushes.Black, xPos, yPos)

        'para cant super
        xPos -= 415
        yPos += 60

        For i As Integer = 0 To dtdetallefacturaventa.Rows.Count - 1
            If dtdetallefacturaventa.Rows(i).Item(2) = 1 Then

                e.Graphics.DrawString(dtdetallefacturaventa.Rows(i).Item(3), prFont, Brushes.Black, xPos, yPos)

                'para el precio unitario
                xPos += 458
                e.Graphics.DrawString(dtdetallefacturaventa.Rows(i).Item(5), prFont, Brushes.Black, xPos, yPos)

                'para las ventas gravadas
                xPos += 110
                e.Graphics.DrawString(dtdetallefacturaventa.Rows(i).Item(8), prFont, Brushes.Black, xPos, yPos)
                yPos += 20
                xPos -= 568
            Else
                yPos += 20
            End If

            If dtdetallefacturaventa.Rows(i).Item(2) = 2 Then
                'para cant Regular

                e.Graphics.DrawString(dtdetallefacturaventa.Rows(i).Item(3), prFont, Brushes.Black, xPos, yPos)

                'para el precio unitario
                xPos += 458
                e.Graphics.DrawString(dtdetallefacturaventa.Rows(i).Item(5), prFont, Brushes.Black, xPos, yPos)

                'para las ventas gravadas
                xPos += 110
                e.Graphics.DrawString(dtdetallefacturaventa.Rows(i).Item(8), prFont, Brushes.Black, xPos, yPos)
                yPos += 25
                xPos -= 568
            Else
                yPos += 25
            End If

            If dtdetallefacturaventa.Rows(i).Item(2) = 3 Then
                'para cant Diesel


                e.Graphics.DrawString(dtdetallefacturaventa.Rows(i).Item(3), prFont, Brushes.Black, xPos, yPos)

                'para el precio unitario
                xPos += 458
                e.Graphics.DrawString(dtdetallefacturaventa.Rows(i).Item(5), prFont, Brushes.Black, xPos, yPos)

                'para las ventas gravadas
                xPos += 110
                e.Graphics.DrawString(dtdetallefacturaventa.Rows(i).Item(8), prFont, Brushes.Black, xPos, yPos)
                yPos += 20
                xPos -= 568
            Else
                yPos += 20
            End If

            If dtdetallefacturaventa.Rows(i).Item(2) > 3 Then
                'para cant lubricantes

                e.Graphics.DrawString(dtdetallefacturaventa.Rows(i).Item(3), prFont, Brushes.Black, xPos, yPos)

                'para el nombre
                dtp = tp.Consultar(" where codproducto = " & dtdetallefacturaventa.Rows(i).Item(2).ToString)
                xPos += 200
                e.Graphics.DrawString(dtp.Rows(0).Item(1).ToString, prFont, Brushes.Black, xPos, yPos)


                'para el precio unitario
                xPos -= 200
                xPos += 458
                e.Graphics.DrawString(dtdetallefacturaventa.Rows(i).Item(5), prFont, Brushes.Black, xPos, yPos)

                'para las ventas gravadas
                xPos += 110
                e.Graphics.DrawString(dtdetallefacturaventa.Rows(i).Item(8), prFont, Brushes.Black, xPos, yPos)
                yPos += 50
                xPos -= 568
            Else
                yPos += 50
            End If
            yPos -= 115
        Next

        yPos += 115



        ' para las numeros letras son
        xPos += 50
        'xPos -= 528
        Dim numletras1 As New NumeroLetras
        Dim nl As String
        numletras1.setnumero(dtfacturaventa.Rows(0).Item(13).ToString)
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
            nl = nl & " con 00/100 cent"
        End If

        e.Graphics.DrawString(nl, prFont, Brushes.Black, xPos, yPos)

        'para las sumas
        xPos += 518
        e.Graphics.DrawString(dtfacturaventa.Rows(0).Item(6).ToString, prFont, Brushes.Black, xPos, yPos)

        'para fovial
        yPos += 60
        e.Graphics.DrawString(dtfacturaventa.Rows(0).Item(10).ToString, prFont, Brushes.Black, xPos, yPos)

        'para cotrans
        yPos += 25
        e.Graphics.DrawString(dtfacturaventa.Rows(0).Item(11).ToString, prFont, Brushes.Black, xPos, yPos)

        'para los totales
        yPos += 40
        e.Graphics.DrawString(dtfacturaventa.Rows(0).Item(13).ToString, prFont, Brushes.Black, xPos, yPos)


        ' indicamos que ya no hay nada más que imprimir
        ' (el valor predeterminado de esta propiedad es False)
        e.HasMorePages = False

    End Sub


    Public Sub imprimecomprobante()
        Me.progresimprimir.Visible = True
        Me.Timerimprimir.Enabled = True
        ' ejemplo simple para imprimir en .NET
        ' Usamos una clase del tipo PrintDocument
        Dim printDoc As New PrintDocument
        'Dim TamañoPersonal As New Printing.PaperSize("Prueba", 650, 425)
        Dim TamañoPersonal As New Printing.PaperSize("Prueba", 750, 575)


        printDoc.DefaultPageSettings.PaperSize = TamañoPersonal
        ' asignamos el método de evento para cada página a imprimir
        AddHandler printDoc.PrintPage, AddressOf print_PrintPage1
        ' indicamos que queremos imprimir

        printDoc.Print()
    End Sub

    Private Sub print_PrintPage1(ByVal sender As Object, ByVal e As PrintPageEventArgs)

        Dim dtfacturaventa As DataTable
        Dim tfacturaventa As New clsMaestros(clsNomTab.eTbl.FacturaVenta)

        Dim dtdetallefacturaventa As DataTable
        Dim tdetallefacturaventa As New clsMaestros(clsNomTab.eTbl.DetalleFacturaV)

        Dim dtcliente As DataTable
        Dim tcliente As New clsMaestros(clsNomTab.eTbl.Clientes)



        dtfacturaventa = tfacturaventa.Consultar(" where codfacturav = " & Me.codfactura)
        dtdetallefacturaventa = tdetallefacturaventa.Consultar(" where codfacturav = " & Me.codfactura)

        Dim dtp As DataTable
        Dim tp As New clsMaestros(clsNomTab.eTbl.Productos)

        dtcliente = tcliente.Consultar(" where codcliente = " & dtfacturaventa.Rows(0).Item(3))


        ' Este evento se producirá cada vez que se imprima una nueva página
        ' imprimir HOLA MUNDO en Arial tamaño 24 y negrita

        ' imprimimos la cadena en el margen izquierdo
        Dim xPos As Single = e.MarginBounds.Left
        ' La fuente a usar
        Dim prFont As New Font("Arial", 6, FontStyle.Italic)
        Dim prfont1 As New Font("Arial", 8, FontStyle.Italic)
        ' la posición superior
        Dim yPos As Single = prFont.GetHeight(e.Graphics)




        'para el cliente
        yPos += 111
        xPos += 15
        e.Graphics.DrawString(dtcliente.Rows(0).Item(1).ToString, prFont, Brushes.Black, xPos, yPos)

        'para la fecha
        xPos += 380
        e.Graphics.DrawString(Me.DateTimePicker1.Value.Day.ToString & "/" & Me.DateTimePicker1.Value.Month.ToString & "/" & Me.DateTimePicker1.Value.Year.ToString, prFont, Brushes.Black, xPos, yPos)

        'para la direccion
        yPos += 15
        xPos -= 380
        e.Graphics.DrawString(dtcliente.Rows(0).Item(5).ToString, prFont, Brushes.Black, xPos, yPos)

        'para el numero de registro
        xPos += 390
        e.Graphics.DrawString(dtcliente.Rows(0).Item(3).ToString, prFont, Brushes.Black, xPos, yPos)

        'para el giro
        xPos -= 30
        yPos += 10
        e.Graphics.DrawString(dtcliente.Rows(0).Item(4).ToString, prFont, Brushes.Black, xPos, yPos)

        'para forma de pago
        yPos += 35
        xPos += 75
        e.Graphics.DrawString(Me.comboformapago.Text.ToString, prFont, Brushes.Black, xPos, yPos)

        yPos += 37
        'para cant super

        xPos -= 480
        For i As Integer = 0 To dtdetallefacturaventa.Rows.Count - 1
            If dtdetallefacturaventa.Rows(i).Item(2) = 1 Then



                e.Graphics.DrawString(dtdetallefacturaventa.Rows(i).Item(3), prfont1, Brushes.Black, xPos, yPos)

                'para el precio unitario
                xPos += 444
                e.Graphics.DrawString(dtdetallefacturaventa.Rows(i).Item(5), prfont1, Brushes.Black, xPos, yPos)

                'para las ventas gravadas
                xPos += 117
                e.Graphics.DrawString(dtdetallefacturaventa.Rows(i).Item(8), prfont1, Brushes.Black, xPos, yPos)
                yPos += 20
                xPos -= 561
            Else
                yPos += 20
            End If

            If dtdetallefacturaventa.Rows(i).Item(2) = 2 Then
                'para cant Regular

                e.Graphics.DrawString(dtdetallefacturaventa.Rows(i).Item(3), prfont1, Brushes.Black, xPos, yPos)

                'para el precio unitario
                xPos += 444
                e.Graphics.DrawString(dtdetallefacturaventa.Rows(i).Item(5), prfont1, Brushes.Black, xPos, yPos)

                'para las ventas gravadas
                xPos += 117
                e.Graphics.DrawString(dtdetallefacturaventa.Rows(i).Item(8), prfont1, Brushes.Black, xPos, yPos)
                yPos += 25
                xPos -= 561
            Else
                yPos += 25
            End If

            If dtdetallefacturaventa.Rows(i).Item(2) = 3 Then
                'para cant Diesel


                e.Graphics.DrawString(dtdetallefacturaventa.Rows(i).Item(3), prfont1, Brushes.Black, xPos, yPos)

                'para el precio unitario
                xPos += 444
                e.Graphics.DrawString(dtdetallefacturaventa.Rows(i).Item(5), prfont1, Brushes.Black, xPos, yPos)

                'para las ventas gravadas
                xPos += 117
                e.Graphics.DrawString(dtdetallefacturaventa.Rows(i).Item(8), prfont1, Brushes.Black, xPos, yPos)
                yPos += 20
                xPos -= 561
            Else
                yPos += 20
            End If

            If dtdetallefacturaventa.Rows(i).Item(2) > 3 Then
                'para cant lubricantes


                e.Graphics.DrawString(dtdetallefacturaventa.Rows(i).Item(3), prfont1, Brushes.Black, xPos, yPos)


                'para el nombre
               
                dtp = tp.Consultar(" where codproducto = " & dtdetallefacturaventa.Rows(i).Item(2).ToString)
                xPos += 200
                If dtp.Rows.Count = 0 Then
                    e.Graphics.DrawString("", prFont, Brushes.Black, xPos, yPos)

                Else
                    e.Graphics.DrawString(dtp.Rows(0).Item(1).ToString, prFont, Brushes.Black, xPos, yPos)

                End If



                'para el precio unitario
                xPos -= 200
                xPos += 444

                e.Graphics.DrawString(dtdetallefacturaventa.Rows(i).Item(5), prfont1, Brushes.Black, xPos, yPos)

                'para las ventas gravadas
                xPos += 117
                e.Graphics.DrawString(dtdetallefacturaventa.Rows(i).Item(8), prfont1, Brushes.Black, xPos, yPos)
                yPos += 50
                xPos -= 561
            Else
                yPos += 50
            End If
            yPos -= 115
        Next

        yPos += 117

        Dim prfont2 As New Font("Arial", 7, FontStyle.Italic)
        'para las sumas
        xPos += 561
        e.Graphics.DrawString(dtfacturaventa.Rows(0).Item(6).ToString, prfont2, Brushes.Black, xPos, yPos)

        yPos += 15
        ' para las numeros letras son
        xPos -= 563
        xPos += 50
   
        Dim numletras1 As New NumeroLetras
        Dim nl As String
        numletras1.setnumero(dtfacturaventa.Rows(0).Item(13).ToString)
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
            nl = nl & " con 00/100 cent"
        End If

        e.Graphics.DrawString(nl, prfont1, Brushes.Black, xPos, yPos)


    
        'para el iva
        xPos += 518
        e.Graphics.DrawString(dtfacturaventa.Rows(0).Item(8).ToString, prfont2, Brushes.Black, xPos, yPos)


        'para fovial
        yPos += 65
        e.Graphics.DrawString(dtfacturaventa.Rows(0).Item(10).ToString, prfont2, Brushes.Black, xPos, yPos)

        'para cotrans
        yPos += 18
        e.Graphics.DrawString(dtfacturaventa.Rows(0).Item(11).ToString, prfont2, Brushes.Black, xPos, yPos)

        'para los totales
        yPos += 33
        e.Graphics.DrawString(dtfacturaventa.Rows(0).Item(13).ToString, prfont2, Brushes.Black, xPos, yPos)


        ' indicamos que ya no hay nada más que imprimir
        ' (el valor predeterminado de esta propiedad es False)
        e.HasMorePages = False

    End Sub



    Private Sub botguardar_Click(sender As Object, e As EventArgs) Handles botguardar.Click
        Try
            Dim ella As String = ""
            If guardado = False Then
                guardado = True
                If combotipo.Text = "Factura" Then
                    ella = "La "
                Else
                    ella = "El "
                End If
                Dim imprimir1 As String = ""

                Dim imprimir2 As String = ella & combotipo.Text.ToString & " esta por imprimirse: Desea continuar?" & vbCrLf _
                          & " La decisión no podrá revertirse"

             

                MsgBox(imprimir2, MsgBoxStyle.Information)

                Dim c As Double
                For i As Integer = 0 To dtdetalleventa.Rows.Count - 1
                    dtproducto = tproductos.Consultar(" where codproducto = '" & dtdetalleventa.Rows(i).Item(2).ToString & "'")
                    c = CDbl(dtproducto.Rows(0).Item(6)) - CDbl(dtdetalleventa.Rows(i).Item(3))
                    consultar.Consultar(" update productos set existencias = " & c.ToString & " where codproducto = '" & dtdetalleventa.Rows(i).Item(2).ToString & "'")
                Next
                'consultar.Consultar(" update facturaventa set subtotal1 = " + subtotal1.ToString + ", subtotal2 = " + subtotal2.ToString + ", subtotal3 = " + subtotal3.ToString + ", iva = " + iva.ToString + ", descuento = " + descuentof.ToString + ", total = " + totalf.ToString + " where codfacturav = " + codfactura.ToString)
                totalfactu = Me.textotal.Text
                consultar.Consultar(" update facturaventa set sumas = " & Me.texsumas.Text.ToString & ", iva = " & Me.texiva.Text.ToString & ", fovial = " & Me.texfovial.Text.ToString & ", cotrans = " & Me.texcotrans.Text.ToString & ", descuento = " & descuentof.ToString & ", total = " & Me.textotal.Text.ToString & " where codfacturav = " & codfactura)

                Me.botguardar.Text = "Guardar"

                If checkimprimir.Checked = True Then
                    'llamando al metodo imprimir
                    If Me.combotipo.Text = "Factura" Then
                        imprimir()
                    Else
                        imprimecomprobante()
                    End If
                End If



                'termina la tarea de imprimir

                If donde <> "here" Then
                    frmdv.modi = True
                    frmdv.cargarfacturac()
                    frmvr.hacerconsulta()
                    Me.Close()
                End If
                guardartanques()
            Else

                If MsgBox(ella & combotipo.Text & " se guardo exitozamente!!" & vbCrLf _
                          & "Desea ingresar otra venta", MsgBoxStyle.YesNo, "Compra") = MsgBoxResult.Yes Then
                    mdiMain.llama = "venta"
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

    Private Sub btneliminar_Click(sender As Object, e As EventArgs) Handles btneliminar.Click
        Try
            Dim id As Short = Me.gridcompra.CurrentCell.RowIndex
            Dim dtrdetalle As DataRow = dtdetalleventa.Rows(id)
            'Dim canti As Double = 0
            'dtdecuento = tdescuento.Consultar(" where codproducto " & dtrdetalle.Item(2))

            'limpirando las variables globales
            sumas1 = 0
            iva2 = 0
            cotrans2 = 0
            fovial2 = 0
            totalproducto2 = 0

            'If dtdecuento.Rows(0).Item(2).ToString <> "False" Then
            '    fovial -= Math.Round(dtdetallefacturaventas.Rows(id).Item(3) * 0.2, 2)
            '    cotrans -= Math.Round(dtdetallefacturaventas.Rows(id).Item(3) * 0.1, 2)
            '    canti = CDbl(dtdetallefacturaventas.Rows(id).Item(9)) - Math.Round(dtdetallefacturaventas.Rows(id).Item(3) * 0.2, 2) - Math.Round(dtdetallefacturaventas.Rows(id).Item(3) * 0.1, 2)
            '    canti = Math.Round((canti / 1.13), 2)
            'Else
            '    sumas1 -= CDbl(dtdetallefacturaventas.Rows(id).Item(8))
            '    iva2 -= Math.Round(CDbl(dtdetallefacturaventas.Rows(id).Item(8)) * 0.13, 2)
            'End If

            consultar.Consultar("delete from detalleventa where coddetallefacturav = " & dtrdetalle.Item(0))
            cargarfactura()
        Catch ex As Exception

        End Try

    End Sub



    Private Function correcto() As Boolean
        Dim fl As Boolean = True

        If texcliente.Text = "" Then
            Me.texcliente.BackColor = Color.Red
            fl = False
        Else
            Me.texcliente.BackColor = Color.White
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

        If Me.comboformapago.Text = "" Then
            Me.comboformapago.BackColor = Color.Red
            fl = False
        Else
            Me.comboformapago.BackColor = Color.White
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

        If Me.combotipo.Text.Trim.ToString <> "Factura" Then

            If Me.texnrc.Text = "" Then
                Me.texnrc.BackColor = Color.Red
                fl = False
            Else
                Me.texnrc.BackColor = Color.White
            End If

        End If
        Return fl
    End Function

    'Private Function cfactura() As Boolean
    '    Dim fl As Boolean = True
    '    If entert = False Then

    '        Dim dt As DataTable
    '        Dim dtc As New clsMaestros(clsNomTab.eTbl.Clientes)
    '        Dim dtcf As New clsMaestros(clsNomTab.eTbl.clientescf)

    '        If Me.combotipo.Text <> "Factura" Then
    '            dt = dtc.Consultar(" where codcliente = " & idcliente)
    '            If dt.Rows.Count = 0 Then
    '                fl = False
    '            Else
    '                fl = True
    '            End If
    '        End If
    '        Return fl
    '    End If

    'End Function
    Private Sub botagregar_Click(sender As Object, e As EventArgs) Handles botagregar.Click




        If correcto() <> False Then
            agregarv = True
            'limpirando las variables globales
            sumas1 = 0
            iva2 = 0
            cotrans2 = 0
            fovial2 = 0
            totalproducto2 = 0
            Button4.Select()


            Dim tcodf As New clsProcesos

            If Me.combotipo.Text.Trim.ToString = "Factura" Then
                tcodf.Consultar("update tirajes set tirajefa = '" & Me.texnumfact.Text.Trim.ToString & "'")
            Else
                tcodf.Consultar("update tirajes set tirajeca = '" & Me.texnumfact.Text.Trim.ToString & "'")
            End If



            Try
                If primeraf = False Then

                    Dim can As Double
                    Dim tl As Double
                    Dim tl1 As Double
                    Dim f As Boolean = False
                    For i As Integer = 0 To dtdetalleventa.Rows.Count - 1
                        If idproducto = dtdetalleventa.Rows(i).Item(2).ToString Then

                            can = Math.Round(CDbl(dtdetalleventa.Rows(i).Item(3) + CDbl(Me.texcantidad.Text)), 2)
                            tl = Math.Round(CDbl(dtdetalleventa.Rows(i).Item(9)) + CDbl(Me.textotalp.Text.Trim), 2)
                            tl1 = Math.Round((CDbl(dtdetalleventa.Rows(i).Item(5)) * can), 2)

                            'consultar.Consultar(" update detalleventa set cantidadunit = " + can.ToString + ", precioreal = " + p.ToString + ", total = " + tl.ToString + " where codfacturav = " + codfactura.ToString + " and coddetallefacturav = " + dtdetalleventa.Rows(i).Item(0).ToString)
                            consultar.Consultar("update detalleventa set total = " & tl1 & ", cantidadunit = " & can.ToString & ", total1 = " & tl.ToString & " where codfacturav = " & codfactura.ToString & " and coddetallefacturav = " & dtdetalleventa.Rows(i).Item(0).ToString)
                            f = True
                            privar()
                            cargarfactura()
                        End If
                    Next
                    If f = False Then
                        If CInt(dtrproductos.Item(6)) < CInt(Me.texcantidad.Text.Trim) Then
                            MsgBox("No cuenta con susficientes existencias de este produto para realizar la transaccion", MsgBoxStyle.Critical, "Aviso")
                        Else
                            insertar()
                        End If
                    End If
                Else
                    If CInt(dtrproductos.Item(6)) < CInt(Me.texcantidad.Text.Trim) Then
                        MsgBox("No cuenta con susficientes existencias de este produto para realizar la transaccion", MsgBoxStyle.Critical, "Aviso")
                    Else
                        insertar()
                    End If
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
                MsgBox("ocurrio un error razon: " + ex.Message, MsgBoxStyle.Critical, "Aviso")
            End Try
        Else
            MsgBox("Tiene que llenar todos los campos que esten en rojo", MsgBoxStyle.ApplicationModal, "Aviso")
        End If
 

    End Sub

    Private Sub botsalir_Click_1(sender As Object, e As EventArgs) Handles botsalir.Click
        salirnada()
    End Sub

    Private Sub textotalp_KeyUp(sender As Object, e As KeyEventArgs) Handles textotalp.KeyUp
        Try
            If checklibre.Checked <> True Then
                If Me.textotalp.Text = "" Or Me.texprecio.Text = "" Then
                Else
                    Me.cantidad = CDbl(Me.textotalp.Text)
                    Me.preciot = CDbl(Me.texprecio.Text)
                    Me.texcantidad.Text = Math.Round(cantidad / preciot, 2)
                End If
            End If
        Catch ex As Exception
            MsgBox("Ingrese datos en los campos para realizar los calculos", MsgBoxStyle.Critical, "Aviso")
        End Try

    End Sub


    Private Sub invalidarprov()
        Me.Button1.Enabled = False
        Me.Button2.Enabled = False
        Me.Button3.Enabled = False
    End Sub

    Dim dtprov As DataTable
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.idcliente = Me.texco1.Text
        Me.texcliente.Text = Me.texprovee1.Text
        If Me.combotipo.Text.Trim <> "Factura" Then
            dtprov = consultar.Consultar("SELECT nrc FROM cliente where codcliente = " & Me.idcliente)
            Me.texnrc.Text = dtprov.Rows(0).Item(0)
        End If
        Me.Button4.Select()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.idcliente = Me.texco2.Text
        Me.texcliente.Text = Me.texprovee2.Text
        If Me.combotipo.Text.Trim <> "Factura" Then
            dtprov = consultar.Consultar("SELECT nrc FROM cliente where codcliente = " & Me.idcliente)
            Me.texnrc.Text = dtprov.Rows(0).Item(0)
        End If
        Me.Button4.Select()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.idcliente = Me.texco3.Text
        Me.texcliente.Text = Me.texprovee3.Text
        If Me.combotipo.Text.Trim <> "Factura" Then
            dtprov = consultar.Consultar("SELECT nrc FROM cliente where codcliente = " & Me.idcliente)
            Me.texnrc.Text = dtprov.Rows(0).Item(0)
        End If
        Me.Button4.Select()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.idproducto = Me.texco4.Text
        Me.texnombrep.Text = Me.texprod4.Text
        Me.texprecio.Text = Me.dtproductos1.Rows(0).Item(5)
        Me.dtrproductos = Me.dtproductos1.Rows(0)

        Me.textotalp.Select()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.idproducto = Me.texco5.Text
        Me.texnombrep.Text = Me.texprod5.Text
        Me.texprecio.Text = Me.dtproductos1.Rows(1).Item(5)
        Me.dtrproductos = Me.dtproductos1.Rows(1)
        Me.textotalp.Select()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.idproducto = Me.texco6.Text
        Me.texnombrep.Text = Me.texprod6.Text
        Me.texprecio.Text = Me.dtproductos1.Rows(2).Item(5)
        Me.dtrproductos = Me.dtproductos1.Rows(2)
        Me.textotalp.Select()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs)

        Me.texprecio.Text = Me.dtproductos1.Rows(3).Item(5)
        Me.dtrproductos = Me.dtproductos1.Rows(3)
        Me.texcantidad.Select()
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



    Dim contasegundos As Short = 0
    Private Sub Timerimprimir_Tick(sender As Object, e As EventArgs) Handles Timerimprimir.Tick
        contasegundos += 1
        Me.progresimprimir.Value = contasegundos
        If contasegundos = 100 Then
            Me.Timerimprimir.Enabled = False
            Me.contasegundos = 0
        End If
    End Sub

    Private Sub texcliente_DoubleClick(sender As Object, e As EventArgs) Handles texcliente.DoubleClick
        Try
            Clientes.donde = "ventas"
            Clientes.frmv = Me
            Clientes.Show()
        Catch ex As Exception

        End Try
    End Sub


    Dim dtcli As DataTable
    Dim dtclcf As DataTable
    Dim cf = False, cc As Boolean = False


    'Private Sub texcliente_Enter(sender As Object, e As EventArgs) Handles texcliente.Enter
    '  
    'End Sub

    Private Sub texcliente_KeyUp(sender As Object, e As KeyEventArgs) Handles texcliente.KeyUp
        Try
            Me.texco1.Text = ""
            Me.texco2.Text = ""
            Me.texco3.Text = ""
            Me.texprovee1.Text = ""
            Me.texprovee2.Text = ""
            Me.texprovee3.Text = ""

            Dim nomc As String = Me.texcliente.Text.Trim.ToString

            If Me.texcliente.Text.Trim.ToString = "" Then
                Me.texnrc.Text = ""
            End If
            If Me.combotipo.Text = "Factura" Then
                dtclcf = consultar.Consultar("Select idclientescf, cliente from clientescf where cliente like '%" & nomc & "%'")
                If dtclcf.Rows.Count <> 0 Then

                    Me.idcliente = dtclcf.Rows(0).Item(0)


                    If dtclcf.Rows.Count > 0 Then
                        Me.texco1.Text = dtclcf.Rows(0).Item(0).ToString
                        Me.texprovee1.Text = dtclcf.Rows(0).Item(1).ToString

                        If dtclcf.Rows.Count > 1 Then
                            Me.texco2.Text = dtclcf.Rows(1).Item(0).ToString
                            Me.texprovee2.Text = dtclcf.Rows(1).Item(1).ToString

                            If dtclcf.Rows.Count > 2 Then
                                Me.texco3.Text = dtclcf.Rows(2).Item(0).ToString
                                Me.texprovee3.Text = dtclcf.Rows(2).Item(1).ToString
                            End If
                        End If
                    Else
                        llenara = False
                        Me.texco1.Text = ""
                        Me.texco2.Text = ""
                        Me.texco3.Text = ""
                        Me.texprovee1.Text = ""
                        Me.texprovee2.Text = ""
                        Me.texprovee3.Text = ""
                    End If







                End If
            Else
                dtcli = consultar.Consultar("Select codcliente, nombre,nrc from cliente where nombre like '%" & nomc & "%'")
                If dtcli.Rows.Count <> 0 Then

                    Me.idcliente = dtcli.Rows(0).Item(0)

                    If dtcli.Rows.Count > 0 Then
                        Me.texco1.Text = dtcli.Rows(0).Item(0).ToString
                        Me.texprovee1.Text = dtcli.Rows(0).Item(1).ToString

                        If dtcli.Rows.Count > 1 Then
                            Me.texco2.Text = dtcli.Rows(1).Item(0).ToString
                            Me.texprovee2.Text = dtcli.Rows(1).Item(1).ToString

                            If dtcli.Rows.Count > 2 Then
                                Me.texco3.Text = dtcli.Rows(2).Item(0).ToString
                                Me.texprovee3.Text = dtcli.Rows(2).Item(1).ToString
                            End If
                        End If
                    Else
                        llenara = False
                        Me.texco1.Text = ""
                        Me.texco2.Text = ""
                        Me.texco3.Text = ""
                        Me.texprovee1.Text = ""
                        Me.texprovee2.Text = ""
                        Me.texprovee3.Text = ""
                    End If

                End If
            End If

        Catch ex As Exception

        End Try


    End Sub


    Private Sub texcliente_KeyPress(sender As Object, e As KeyPressEventArgs) Handles texcliente.KeyPress
        If (Asc(e.KeyChar)) = 13 Then
            llenar()
        End If
    End Sub


    Dim entert As Boolean = False

    Private Sub llenar()
        Try
            llenara = True
            If Me.combotipo.Text = "Factura" Then
                Me.texcliente.Text = dtclcf.Rows(0).Item(1).ToString
                Me.idcliente = dtclcf.Rows(0).Item(0).ToString
            Else
                Me.texcliente.Text = dtcli.Rows(0).Item(1).ToString
                Me.texnrc.Text = dtcli.Rows(0).Item(2).ToString
                Me.idcliente = dtcli.Rows(0).Item(0)
            End If
            entert = True
            Button4.Select()

        Catch ex As Exception

        End Try

    End Sub


    Private Sub checkimprimir_CheckedChanged(sender As Object, e As EventArgs) Handles checkimprimir.CheckedChanged
        If Me.checkimprimir.Checked = True Then
            Me.botguardar.Text = "Imprimir"
        Else
            Me.botguardar.Text = "Guardar"
        End If
    End Sub

    Private Sub texcliente_TextChanged(sender As Object, e As EventArgs) Handles texcliente.TextChanged

    End Sub
End Class