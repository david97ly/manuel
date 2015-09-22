Imports logica

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

    Private Sub DetalleCompra_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MdiParent = mdiMain
        hacerconsulta()
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



            If dtfacturav.Rows(contador).Item(2).ToString = "Factura" Then
                Me.texcliente.Text = dtclientes.Rows(0).Item(1)
            Else
                Me.texnit.Text = dtclientes.Rows(0).Item(2).ToString
                Me.texnrc.Text = dtclientes.Rows(0).Item(3).ToString
                Me.texcliente.Text = dtclientes.Rows(0).Item(1).ToString

            End If


            Me.texnumfactura.Text = dtfacturav.Rows(contador).Item(1)

            'Me.textiraje.Text = dtfacturav.Rows(contador).Item(14)

            Me.texformadepago.Text = dtfacturav.Rows(contador).Item(11)

            Me.textipo.Text = dtfacturav.Rows(contador).Item(2)

            Me.texfecha.Text = dtfacturav.Rows(contador).Item(4)


            Me.texsumas.Text = dtfacturav.Rows(contador).Item(5)
            Me.texiva.Text = dtfacturav.Rows(contador).Item(7)

            Me.textotal.Text = dtfacturav.Rows(contador).Item(10)

            If dtfacturav.Rows(contador).Item(11).ToString = "Credito" Then
                Me.botpagar.Visible = True
            Else
                Me.botpagar.Visible = False
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
    Public Sub anularmanual()
        Try

            c.Consultar(" UPDATE facturaventa SET estado ='invalida' where codfacturav = " & codfactura)
            Dim cp As Decimal

            Dim dtp As DataTable
            Dim tdep As New clsMaestros(clsNomTab.eTbl.DetalleFacturaV)

            Dim dtprod As DataTable
            Dim tprod As New clsMaestros(clsNomTab.eTbl.Productos)
            Dim dtcant As DataTable



            dtp = tdep.Consultar(" where codfacturav = " & codfactura)

            For i As Integer = 0 To dtp.Rows.Count - 1
                cp = CDec(dtp.Rows(i).Item(3))

                dtprod = tprod.Consultar(" where codproducto = " & dtp.Rows(i).Item(2))

                cp = Math.Round((CDec(dtprod.Rows(0).Item(6)) + cp), 2)

                c.Consultar(" Update productos set existencias = " & cp & " where codproducto = " & dtp.Rows(i).Item(2))


                'el vaciado de los tanques  para el control diario
                If dtp.Rows(i).Item(2).ToString.Trim = "1" Then
                    dtcant = c.Consultar("Select * from bombas where idbombas = 6")
                    Dim cantg As Decimal = dtcant.Rows(0).Item(3)
                    Dim cantv As Decimal = CDec(dtcant.Rows(0).Item(2))
                    cantv -= CDec(dtp.Rows(i).Item(9))
                    cantg -= CDec(dtp.Rows(i).Item(3))
                    c.Consultar("UPDATE  bombas SET  ventasdiariasgalon = " & cantg & ", ventasdiarias = " & cantv & " where idbombas = 6")
                ElseIf dtp.Rows(i).Item(2).ToString.Trim = "2" Then
                    dtcant = c.Consultar("Select * from bombas where idbombas = 2")
                    Dim cantg As Decimal = dtcant.Rows(0).Item(3)
                    Dim cantv As Decimal = CDec(dtcant.Rows(0).Item(2))
                    cantv -= CDec(dtp.Rows(i).Item(9))
                    cantg -= CDec(dtp.Rows(i).Item(3))
                    c.Consultar("UPDATE  bombas SET  ventasdiariasgalon = " & cantg & ", ventasdiarias = " & cantv & " where idbombas = 2")
                ElseIf dtp.Rows(i).Item(2).ToString.Trim = "3" Then
                    dtcant = c.Consultar("Select * from bombas where idbombas = 1")
                    Dim cantg As Decimal = dtcant.Rows(0).Item(3)
                    Dim cantv As Decimal = CDec(dtcant.Rows(0).Item(2))
                    cantv -= CDec(dtp.Rows(i).Item(9))
                    cantg -= CDec(dtp.Rows(i).Item(3))
                    c.Consultar("UPDATE  bombas SET  ventasdiariasgalon = " & cantg & ", ventasdiarias = " & cantv & " where idbombas = 1")
                End If
            Next



            MsgBox("La factura se anulo exitozamente", MsgBoxStyle.Information)
        Catch ex As Exception
            MsgBox("El documento se anulo exitozamente")
        End Try

    End Sub

    Public Sub duplicardocumento()
        Try
            'Insertando la venta nueva
            Dim nf As Integer = CInt(dtfacturav.Rows(contador).Item(1)) + 1
            Dim tcodf As New clsProcesos

            If dtfacturav.Rows(contador).Item(2).ToString = "Factura" Then
                tcodf.Consultar("update tirajes set tirajefa = '" & nf & "'")
            Else
                tcodf.Consultar("update tirajes set tirajeca = '" & nf & "'")
            End If

            Dim f As String = Date.Today.Year.ToString + "-" + Date.Today.Month.ToString + "-" + Date.Today.Day.ToString

            tfacturav.Insertar("'" & nf.ToString & "','" & dtfacturav.Rows(contador).Item(2).ToString & "','" & dtfacturav.Rows(contador).Item(3).ToString & "','" & dtfacturav.Rows(contador).Item(4).ToString & "','" & f.ToString & "'," & dtfacturav.Rows(contador).Item(6).ToString & "," & dtfacturav.Rows(contador).Item(7).ToString & "," & dtfacturav.Rows(contador).Item(8).ToString & "," & dtfacturav.Rows(contador).Item(9).ToString & "," & dtfacturav.Rows(contador).Item(10).ToString & "," & dtfacturav.Rows(contador).Item(11).ToString & "," & dtfacturav.Rows(contador).Item(12).ToString & "," & dtfacturav.Rows(contador).Item(13).ToString & ",'" & dtfacturav.Rows(contador).Item(14).ToString & "','valida','" & dtfacturav.Rows(contador).Item(16).ToString & "'")

            Dim codf As Integer = CInt(dtfacturav.Rows(contador).Item(0)) + 1

            For i As Integer = 0 To dtdetallefacturav.Rows.Count - 1
                tdetallefacturav.Insertar(codf.ToString & "," & dtdetallefacturav.Rows(i).Item(2).ToString & "," & dtdetallefacturav.Rows(i).Item(3).ToString & ",0," & dtdetallefacturav.Rows(i).Item(5).ToString & ",0,'" & dtdetallefacturav.Rows(i).Item(7).ToString & "'," & dtdetallefacturav.Rows(i).Item(8).ToString & "," & dtdetallefacturav.Rows(i).Item(9).ToString & "," & dtdetallefacturav.Rows(i).Item(10).ToString)
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

  
End Class