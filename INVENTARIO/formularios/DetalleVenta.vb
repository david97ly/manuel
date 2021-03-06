﻿Imports logica

Imports System.Drawing.Printing
Public Class DetalleVenta
    Private tfacturav As New clsMaestros(clsNomTab.eTbl.FacturaVenta)
    Public dtfacturav As DataTable
    Private tdetallefacturav As New clsMaestros(clsNomTab.eTbl.DetalleFacturaV)
    Public dtdetallefacturav As DataTable
    Private tclientes As New clsMaestros(clsNomTab.eTbl.Clientes)
    Public dtclientes As DataTable
    Private tproductos As New clsMaestros(clsNomTab.eTbl.Productos)
    Public dtproductos As DataTable
    Public frmvr As VentasRealizadas
    Public tipof As String
    Public contador As Integer
    Public max As Integer
    Public modi As Boolean = False
    Private codfactura As String

    Private tfcf As New clsMaestros(clsNomTab.eTbl.clientescf)

    Private dttiraje As DataTable
    Private ttiraje As New clsMaestros(clsNomTab.eTbl.tiraje)
    Public donde As String = "aqui"

    'Variable para determinar si el documento actual es una factura o un comprobante
    Private factura As Boolean = True
    Private Sub DetalleCompra_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        If donde <> "noti" Then
            MdiParent = mdiMain
            hacerconsulta()
        End If
        cargarfacturac()

    End Sub

    Private Sub hacerconsulta()
        Try
            If tipof = "todos" Then
                dtfacturav = tfacturav.Consultar()
                Me.max = dtfacturav.Rows.Count - 1
            Else
                dtfacturav = tfacturav.Consultar(" where  tipo = '" + tipof + "'")
                Me.max = dtfacturav.Rows.Count - 1
            End If
        Catch ex As Exception
            MsgBox("Ocurrio un error asegurese de haber llenado todos los campo correctamente", MsgBoxStyle.OkOnly, "Avise")
        End Try

    End Sub
    Public Sub cargarfacturac()

        Try

            If donde = "noti" Then


                If modi = True Then
                    hacerconsulta()
                End If

                Me.botdere.Visible = False
                Me.botiz.Visible = False

                If dtfacturav.Rows(0).Item(2).ToString = "Factura" Then
                    dtclientes = tfcf.Consultar(" where idclientescf = " & dtfacturav.Rows(0).Item(3).ToString)
                    Me.gruregis.Visible = False
                Else
                    dtclientes = tclientes.Consultar(" where codcliente = " + dtfacturav.Rows(0).Item(3).ToString)
                    Me.gruregis.Visible = True
                End If

                dttiraje = ttiraje.Consultar()

                If dtfacturav.Rows(0).Item(2).ToString = "Factura" Then
                    Me.texcliente.Text = dtclientes.Rows(0).Item(1)
                    factura = True
                    If dttiraje.Rows(0).Item(4).ToString = (CInt(dtfacturav.Rows(0).Item(1).ToString) + 1).ToString Then
                        Me.boteliminar.Visible = True
                    Else
                        Me.boteliminar.Visible = False
                    End If
                Else
                    Me.texnit.Text = dtclientes.Rows(0).Item(2).ToString
                    Me.texnrc.Text = dtclientes.Rows(0).Item(3).ToString
                    Me.texcliente.Text = dtclientes.Rows(0).Item(1).ToString
                    factura = False

                    If dttiraje.Rows(0).Item(8).ToString = (CInt(dtfacturav.Rows(0).Item(1).ToString) + 1).ToString Then
                        Me.boteliminar.Visible = True
                    Else
                        Me.boteliminar.Visible = False
                    End If
                End If


                Me.texnumfactura.Text = dtfacturav.Rows(0).Item(1)

                Me.textiraje.Text = dtfacturav.Rows(0).Item(13)

                dttiraje = ttiraje.Consultar()

                Me.texformadepago.Text = dtfacturav.Rows(0).Item(11)

                Me.textipo.Text = dtfacturav.Rows(0).Item(2)

                Me.texfecha.Text = dtfacturav.Rows(0).Item(4)


                Me.texsumas.Text = dtfacturav.Rows(0).Item(5)
                Me.texiva.Text = dtfacturav.Rows(0).Item(7)

                Me.textotal.Text = dtfacturav.Rows(0).Item(10)

                If dtfacturav.Rows(0).Item(11).ToString = "Credito" Then

                    If dtfacturav.Rows(0).Item(6).ToString = "1" Then
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



                If dtfacturav.Rows(0).Item(12).ToString = "invalida" Then
                    Me.lbanulada.Visible = True
                    Me.grupboton.Visible = False
                Else
                    Me.lbanulada.Visible = False
                    Me.grupboton.Visible = True
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

                cargargrid()


            Else
                If modi = True Then
                    hacerconsulta()
                End If



                If dtfacturav.Rows(contador).Item(2).ToString = "Factura" Then
                    dtclientes = tfcf.Consultar(" where idclientescf = " & dtfacturav.Rows(contador).Item(3).ToString)
                    Me.gruregis.Visible = False
                Else
                    dtclientes = tclientes.Consultar(" where codcliente = " + dtfacturav.Rows(contador).Item(3).ToString)
                    Me.gruregis.Visible = True
                End If

                dttiraje = ttiraje.Consultar()

                If dtfacturav.Rows(contador).Item(2).ToString = "Factura" Then
                    Me.texcliente.Text = dtclientes.Rows(0).Item(1)
                    factura = True
                    If dttiraje.Rows(0).Item(4).ToString = (CInt(dtfacturav.Rows(contador).Item(1).ToString) + 1).ToString Then
                        Me.boteliminar.Visible = True
                    Else
                        Me.boteliminar.Visible = False
                    End If
                Else
                    Me.texnit.Text = dtclientes.Rows(0).Item(2).ToString
                    Me.texnrc.Text = dtclientes.Rows(0).Item(3).ToString
                    Me.texcliente.Text = dtclientes.Rows(0).Item(1).ToString
                    factura = False

                    If dttiraje.Rows(0).Item(8).ToString = (CInt(dtfacturav.Rows(contador).Item(1).ToString) + 1).ToString Then
                        Me.boteliminar.Visible = True
                    Else
                        Me.boteliminar.Visible = False
                    End If
                End If


                Me.texnumfactura.Text = dtfacturav.Rows(contador).Item(1)

                Me.textiraje.Text = dtfacturav.Rows(contador).Item(13)

                dttiraje = ttiraje.Consultar()

                Me.texformadepago.Text = dtfacturav.Rows(contador).Item(11)

                Me.textipo.Text = dtfacturav.Rows(contador).Item(2)

                Me.texfecha.Text = dtfacturav.Rows(contador).Item(4)


                Me.texsumas.Text = dtfacturav.Rows(contador).Item(5)
                Me.texiva.Text = dtfacturav.Rows(contador).Item(7)

                Me.textotal.Text = dtfacturav.Rows(contador).Item(10)

                If dtfacturav.Rows(contador).Item(11).ToString = "Credito" Then

                    If dtfacturav.Rows(contador).Item(6).ToString = "1" Then
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



                If dtfacturav.Rows(contador).Item(12).ToString = "invalida" Then
                    Me.lbanulada.Visible = True
                    Me.grupboton.Visible = False
                Else
                    Me.lbanulada.Visible = False
                    Me.grupboton.Visible = True
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

                cargargrid()
            End If

        Catch ex As Exception
            MsgBox("Ocurrio un error al cargar los datos" + ex.Message, MsgBoxStyle.Critical, "Aviso")
        End Try
    End Sub
    Private Sub cargargrid()
        Try
            dtdetallefacturav = tdetallefacturav.Consultar(" where codfacturav = '" + dtfacturav.Rows(contador).Item(0).ToString + "'")
            codfactura = dtfacturav.Rows(contador).Item(0).ToString
            Dim nf As Short
            nf = dtdetallefacturav.Rows.Count


            If nf = 0 Then
                Me.gridventa.RowCount = 1
                Me.gridventa.Rows(0).Cells(0).Value = ""
                Me.gridventa.Rows(0).Cells(1).Value = ""
                Me.gridventa.Rows(0).Cells(2).Value = ""
                Me.gridventa.Rows(0).Cells(3).Value = ""
                Me.gridventa.Rows(0).Cells(4).Value = ""
                Me.gridventa.Rows(0).Cells(5).Value = ""
                Me.gridventa.Rows(0).Cells(6).Value = ""
            Else
                Me.gridventa.RowCount = nf
            End If

            For i As Integer = 0 To dtdetallefacturav.Rows.Count - 1
                dtproductos = tproductos.Consultar(" where codproducto = '" + dtdetallefacturav.Rows(i).Item(2).ToString & "'")
                Me.gridventa.Rows(i).Cells(0).Value = dtproductos.Rows(0).Item(0) 'codigo del producto
                Me.gridventa.Rows(i).Cells(2).Value = dtproductos.Rows(0).Item(1) 'nombre del producto
                Me.gridventa.Rows(i).Cells(1).Value = dtdetallefacturav.Rows(i).Item(3) ' cantidad
                Me.gridventa.Rows(i).Cells(3).Value = dtdetallefacturav.Rows(i).Item(9) ' precio
                Me.gridventa.Rows(i).Cells(4).Value = "0"
                Me.gridventa.Rows(i).Cells(5).Value = "0"
                Me.gridventa.Rows(i).Cells(6).Value = dtdetallefacturav.Rows(i).Item(7)
            Next
            Me.gridventa.Rows(0).Cells(0).Selected = True
        Catch ex As Exception
            MsgBox("Ocurrio un error asegurese de haber llenado todos los campo correctamente", MsgBoxStyle.OkOnly, "Avise")
        End Try

    End Sub
    Private Sub botderecha_Click(sender As Object, e As EventArgs) Handles botdere.Click
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


    Private Sub botsalir_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub boteditar_Click(sender As Object, e As EventArgs)
        Try
            Dim ad As New AnularDocumento
            ad.forma = Me
            ad.Show()
        Catch ex As Exception

        End Try

    End Sub

    Dim c As New clsProcesos
 
    Public Sub duplicardocumento()
        Try
            'Insertando la venta nueva
            Dim nf As Integer = CInt(dtfacturav.Rows(contador).Item(1)) + 1
            Dim tcodf As New clsProcesos

            If dtfacturav.Rows(contador).Item(2).ToString = "Factura" Then
                tcodf.Consultar("update tirajes set tirajefa = '" & nf + 1 & "'")
            Else
                tcodf.Consultar("update tirajes set tirajeca = '" & nf + 1 & "'")
            End If

            Dim dt As Date = CDate(dtfacturav.Rows(contador).Item(4))
            Dim f As String = dt.Year.ToString + "-" + dt.Month.ToString + "-" + dt.Day.ToString


            tfacturav.Insertar("'" & nf.ToString & "','" & dtfacturav.Rows(contador).Item(2) & "','" & dtfacturav.Rows(contador).Item(3) & "','" & f & "'," & dtfacturav.Rows(contador).Item(5) & "," & dtfacturav.Rows(contador).Item(6) & "," & dtfacturav.Rows(contador).Item(7) & "," & dtfacturav.Rows(contador).Item(8) & "," & dtfacturav.Rows(contador).Item(9) & "," & dtfacturav.Rows(contador).Item(10) & ",'" & dtfacturav.Rows(contador).Item(11) & "','valida','" & dtfacturav.Rows(contador).Item(13) & "'")
            Dim dtcodfactura As DataTable
            Dim consultar As New clsProcesos

            dtcodfactura = consultar.Consultar("SELECT  Max(codfacturav) FROM facturaventa")
            codfactura = dtcodfactura.Rows(0).Item(0)


            For i As Integer = 0 To dtdetallefacturav.Rows.Count - 1
                
                tdetallefacturav.Insertar(codfactura.ToString & ",'" & dtdetallefacturav.Rows(i).Item(2).ToString & "'," & dtdetallefacturav.Rows(i).Item(3).ToString & "," & dtdetallefacturav.Rows(i).Item(4).ToString & "," & dtdetallefacturav.Rows(i).Item(5).ToString & "," & dtdetallefacturav.Rows(i).Item(6).ToString & ",'" & dtdetallefacturav.Rows(i).Item(7).ToString & "'," & dtdetallefacturav.Rows(i).Item(8).ToString & "," & dtdetallefacturav.Rows(i).Item(9).ToString)

            Next
            MsgBox("El docuemento se anulo exitozamente", MsgBoxStyle.Information, "Exito")

            Dim tf As New clsProcesos

            tf.Consultar("   UPDATE facturaventa SET  estado = 'invalida' where codfacturav = " & dtfacturav.Rows(contador).Item(0))

            Me.botimprimir.visible = True

            Me.Close()
        Catch ex As Exception

        End Try
      

    End Sub

    Private Sub imprimir1()
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
        Dim tcliente As New clsMaestros(clsNomTab.eTbl.clientescf)



        dtfacturaventa = tfacturaventa.Consultar(" where codfacturav = " & Me.codfactura)
        dtdetallefacturaventa = tdetallefacturaventa.Consultar(" where codfacturav = " & Me.codfactura)
        dtcliente = tcliente.Consultar(" where idclientescf = " & dtfacturaventa.Rows(0).Item(3))


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
        Dim fecha As Date = CDate(dtfacturaventa.Rows(0).Item(5))
        e.Graphics.DrawString(fecha.Day & "/" & fecha.Month & "/" & fecha.Year, prFont, Brushes.Black, xPos, yPos)

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

            If dtdetallefacturaventa.Rows(i).Item(2) = 4 Then
                'para cant lubricantes


                e.Graphics.DrawString(dtdetallefacturaventa.Rows(i).Item(3), prFont, Brushes.Black, xPos, yPos)

                'para el precio unitario
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


    Private Sub imprimir2()
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
        yPos += 121
        xPos += 15
        e.Graphics.DrawString(dtcliente.Rows(0).Item(1), prFont, Brushes.Black, xPos, yPos)

        'para la fecha
        Dim fecha As Date = CDate(dtfacturaventa.Rows(0).Item(5))
        xPos += 380
        e.Graphics.DrawString(fecha.Day & "/" & fecha.Month & "/" & fecha.Year, prFont, Brushes.Black, xPos, yPos)

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
        yPos += 30
        xPos += 75
        e.Graphics.DrawString(Me.texformadepago.Text.ToString, prFont, Brushes.Black, xPos, yPos)


        yPos += 42
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
                Dim tp As New clsProcesos
                Dim dtp As DataTable
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

        yPos += 110

        Dim prfont2 As New Font("Arial", 7, FontStyle.Italic)
        'para las sumas
        xPos += 563

        e.Graphics.DrawString(dtfacturaventa.Rows(0).Item(6).ToString, prfont2, Brushes.Black, xPos, yPos)

        yPos += 115
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
        yPos += 30
        e.Graphics.DrawString(dtfacturaventa.Rows(0).Item(13).ToString, prfont2, Brushes.Black, xPos, yPos)


        ' indicamos que ya no hay nada más que imprimir
        ' (el valor predeterminado de esta propiedad es False)
        e.HasMorePages = False

    End Sub





    Private Sub botimprimir_Click(sender As Object, e As EventArgs)
        If dtfacturav.Rows(contador).Item(2).ToString = "Factura" Then
            imprimir1()
        Else
            imprimir2()
        End If
    End Sub


    Private Sub botimprimir2_Click(sender As Object, e As EventArgs)
        If MsgBox("Esta seguro que desea imprimir", MsgBoxStyle.YesNo, "Aviso") = MsgBoxResult.Yes Then
            If dtfacturav.Rows(contador).Item(2).ToString = "Factura" Then
                imprimir1()
            Else
                imprimir2()
            End If
        End If

    End Sub

  
    Private Sub boteliminar_Click(sender As Object, e As EventArgs) Handles boteliminar.Click
        Try
            If MsgBox("Esta seguro de eliminar elsta venta? ", MsgBoxStyle.YesNo, "Aviso") = MsgBoxResult.Yes Then
                dtdetallefacturav = tdetallefacturav.Consultar(" where codfacturav = " & codfactura)
                Dim dtproducto As DataTable
                Dim consultar As New clsProcesos
                'Cuando todo ha salido bien hace los cargos a las existencias

                Dim c As Double = 0

                For i As Integer = 0 To dtdetallefacturav.Rows.Count - 1
                    dtproducto = tproductos.Consultar(" where codproducto = '" + dtdetallefacturav.Rows(i).Item(2).ToString + "'")
                    c = CDbl(CDbl(dtproducto.Rows(0).Item(6)) - dtdetallefacturav.Rows(i).Item(3))
                    consultar.Consultar(" update productos set existencias = " + c.ToString + " where codproducto = '" + dtdetallefacturav.Rows(i).Item(2).ToString + "'")
                Next

                consultar.Consultar(" delete from detalleventa where codfacturav = " & codfactura)

                consultar.Consultar(" delete from facturaventa where codfacturav = " & codfactura)

                If factura Then
                    consultar.Consultar(" update tirajes set tirajefa = " & CInt(CInt(Me.texnumfactura.Text)).ToString)
                Else
                    consultar.Consultar(" update tirajes set tirajeca = " & CInt(CInt(Me.texnumfactura.Text)).ToString)
                End If

                MsgBox("La venta fue eliminada exitosamente ", MsgBoxStyle.Information, "EXITO")
            End If
        Catch ex As Exception
            MsgBox("Ocurrio un error al eliminar la venta, razon:" & ex.Message, MsgBoxStyle.Critical, "ERROR")
        End Try


       
    End Sub


    Public Sub soloanular()
        Try

            dtdetallefacturav = tdetallefacturav.Consultar(" where codfacturav = " & codfactura)
            Dim dtproducto As DataTable
            Dim consultar As New clsProcesos
            'Cuando todo ha salido bien hace los cargos a las existencias

            Dim c As Double = 0

            For i As Integer = 0 To dtdetallefacturav.Rows.Count - 1
                dtproducto = tproductos.Consultar(" where codproducto = '" + dtdetallefacturav.Rows(i).Item(2).ToString + "'")
                c = CDbl(CDbl(dtproducto.Rows(0).Item(6)) + dtdetallefacturav.Rows(i).Item(3))
                consultar.Consultar(" update productos set existencias = " + c.ToString + " where codproducto = '" + dtdetallefacturav.Rows(i).Item(2).ToString + "'")
            Next

            consultar.Consultar("   UPDATE facturaventa SET  estado = 'invalida' where codfacturav = " & dtfacturav.Rows(contador).Item(0))


            MsgBox("La venta fue anulada exitosamente ", MsgBoxStyle.Information, "EXITO")

        Catch ex As Exception
            MsgBox("Ocurrio un error al anular la venta, razon:" & ex.Message, MsgBoxStyle.Critical, "ERROR")
        End Try
    End Sub
    Private Sub botanular_Click(sender As Object, e As EventArgs) Handles botanular.Click
        pjtAdus.AnularDocumento.forma = Me
        pjtAdus.AnularDocumento.Show()

    End Sub

    Private Sub botpagar_Click(sender As Object, e As EventArgs) Handles botpagar.Click
        If botpagar.Text <> "Cancelado" Then
            If MsgBox("Esta seguro de efectuar esta acción", MsgBoxStyle.YesNo, "Aviso") = MsgBoxResult.Yes Then
                Try
                    Dim codigofactura As String = dtfacturav.Rows(contador).Item(0).ToString
                    Dim consulta As New clsProcesos

                    consulta.Consultar(" update facturaventa set  descuento = 1 where codfacturav = " & codigofactura)
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