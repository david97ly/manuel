Imports iTextSharp
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports iTextSharp.text.Font
Imports System.IO
Imports logica
Public Class Reportes

    Private dtproductos As DataTable
    Private tproductos As New clsMaestros(clsNomTab.eTbl.Productos)
    Private dtempresa As DataTable
    Private nombre As String
    Private dtfactaracompra As DataTable
    Private tfacturacompra As New clsMaestros(clsNomTab.eTbl.FacturaCompra)
    Private dtfacturaventa As DataTable
    Private tfacturaventa As New clsMaestros(clsNomTab.eTbl.FacturaVenta)
    Private dtproveedor As DataTable
    Private tproveedor As New clsMaestros(clsNomTab.eTbl.Proveedores)

  
    Private Sub botinventario_Click(sender As Object, e As EventArgs) Handles botinventario.Click
        Try
            Dim Documento As New Document 'Declaracion del documento
            Dim parrafo As New Paragraph ' Declaracion de un parrafo


            'Dim imagendemo As ItextSharp.text.Image 'Declaracion de una imagen
            Dim tablademo As New PdfPTable(6) 'declara la tabla con 4 Columnas

            nombre = "InventarioGeneral.pdf"



            pdf.PdfWriter.GetInstance(Documento, New FileStream(nombre, FileMode.Create)) 'Crea el archivo "DEMO.PDF"

            Documento.Open() 'Abre documento para su escritura
            parrafo.Alignment = Element.ALIGN_CENTER 'Alinea el parrafo para que sea centrado o justificado
            parrafo.Font = FontFactory.GetFont("Arial", 10, BOLDITALIC) 'Asigan fuente


            parrafo.Add("Listado General de inventario con saldo al " & Date.Now.ToString & vbCrLf) 'Texto que se insertara
            'parrafo.Add.FontFactory.("Sucursal: X    " & "  Area: Y        " & "Saldo al: FECHA    ")

            Documento.Add(parrafo) 'Agrega el parrafo al documento
            parrafo.Clear() 'Limpia el parrafo para que despues pueda ser utilizado nuevamente
            Documento.Add(New Paragraph(" "))
            Documento.Add(New Paragraph(("      Empresa : Ferroelectrica San Jose " + "                                  " & "                                                                   " & "                      Saldo al: " + Date.Now + "                   "), FontFactory.GetFont("Arial", 8, BOLD))) 'Salto de linea
            ''Documento.Add(New Paragraph(" ")) 'Salto de linea

            ' imagendemo = ItextSharp.text.Image.GetInstance("imagendemo.jpg") 'Dirreccion a la imagen que se hace referencia
            ' imagendemo.SetAbsolutePosition(50, 550) 'Posicion en el eje cartesiano
            ' imagendemo.ScaleAbsoluteWidth(200) 'Ancho de la imagen
            ' imagendemo.ScaleAbsoluteHeight(165) 'Altura de la imagen
            'Documento.Add(imagendemo) ' Agrega la imagen al documento

            Documento.Add(New Paragraph(" ")) 'Salto de linea
            Dim celda As New pdf.PdfPCell
            dtproductos = tproductos.Consultar()
            tablademo.SetWidthPercentage({50, 150, 50, 50, 50, 50}, PageSize.A5) 'Ajusta el tamaño de cada columna
            tablademo.AddCell(New Paragraph("Codigo", FontFactory.GetFont("Arial", 10, BOLD))) 'Agrega COLUMNA1 con fuente ARIAL tamaño 5
            tablademo.AddCell(New Paragraph("                               Descripcion", FontFactory.GetFont("Arial", 10, BOLD))) 'Agrega COLUMNA1 con fuente ARIAL tamaño 8
            tablademo.AddCell(New Paragraph("UnidMed", FontFactory.GetFont("Arial", 10, BOLD)))
            tablademo.AddCell(New Paragraph("Saldo Act", FontFactory.GetFont("Arial", 10, BOLD))) 'Agrega COLUMNA1 con fuente ARIAL tamaño 10
            tablademo.AddCell(New Paragraph("Costo Unitario", FontFactory.GetFont("Arial", 10, BOLD))) 'Agrega COLUMNA1 con fuente ARIAL tamaño 12
            tablademo.AddCell(New Paragraph("Total", FontFactory.GetFont("Arial", 12))) 'Agrega COLUMNA1 con fuente ARIAL tamaño 12
            Documento.Add(tablademo) 'Agrega la tabla al documento
            Dim pu As Double = 0
            Dim sa As Double = 0
            Dim total As Double = 0
            For i As Integer = 0 To dtproductos.Rows.Count - 1
                Dim tablademo2 As New PdfPTable(6) 'declara la tabla con 4 Columnas
                tablademo2.SetWidthPercentage({50, 150, 50, 50, 50, 50}, PageSize.A5) 'Ajusta el tamaño de cada columna
                tablademo2.AddCell(New Paragraph(dtproductos.Rows(i).Item(0), FontFactory.GetFont("Arial", 10))) 'Agrega COLUMNA1 con fuente ARIAL tamaño 5
                tablademo2.AddCell(New Paragraph("                               " + dtproductos.Rows(i).Item(1).ToString, FontFactory.GetFont("Arial", 10))) 'Agrega COLUMNA1 con fuente ARIAL tamaño 8
                tablademo2.AddCell(New Paragraph(dtproductos.Rows(i).Item(3).ToString, FontFactory.GetFont("Arial", 10)))
                tablademo2.AddCell(New Paragraph(dtproductos.Rows(i).Item(6).ToString, FontFactory.GetFont("Arial", 10))) 'Agrega COLUMNA1 con fuente ARIAL tamaño 10
                tablademo2.AddCell(New Paragraph(dtproductos.Rows(i).Item(3).ToString, FontFactory.GetFont("Arial", 10))) 'Agrega COLUMNA1 con fuente ARIAL tamaño 12
                tablademo2.AddCell(New Paragraph(CDbl(CDbl(dtproductos.Rows(i).Item(6)) * CDbl(dtproductos.Rows(i).Item(3))).ToString, FontFactory.GetFont("Arial", 12))) 'Agrega COLUMNA1 con fuente ARIAL tamaño 12
                Documento.Add(tablademo2) 'Agrega la tabla al documento
                pu += CDbl(dtproductos.Rows(i).Item(3))
                sa += CDbl(dtproductos.Rows(i).Item(6))
                total = pu * sa
            Next
          

            Documento.Add(New Paragraph(" "))
            Dim tablademo4 As New PdfPTable(3)
            tablademo4.SetWidthPercentage({100, 100, 100}, PageSize.A5)
            tablademo4.AddCell(New Paragraph(" TOTAL COSTO UNITARIO", FontFactory.GetFont("Arial", 8, BOLD)))
            tablademo4.AddCell(New Paragraph(" TOTAL SALDO ACTIVO", FontFactory.GetFont("Arial", 8, BOLD))) 'Agrega COLUMNA1 con fuente ARIAL tamaño 5
            tablademo4.AddCell(New Paragraph("TOTAL", FontFactory.GetFont("Arial", 8, BOLD)))
            'tablademo4.AddCell(totalneta.ToString)
            Documento.Add(tablademo4)
            Dim tablademo5 As New PdfPTable(3)
            tablademo5.SetWidthPercentage({100, 100, 100}, PageSize.A5)
            tablademo5.AddCell(New Paragraph(pu.ToString, FontFactory.GetFont("Arial", 10, BOLD)))
            tablademo5.AddCell(New Paragraph(sa.ToString, FontFactory.GetFont("Arial", 10, BOLD))) 'Agrega COLUMNA1 con fuente ARIAL tamaño 5
            tablademo5.AddCell(New Paragraph(total.ToString, FontFactory.GetFont("Arial", 10, BOLD)))
            Documento.Add(tablademo5)
            Documento.Close() 'Cierra el documento
            System.Diagnostics.Process.Start(nombre) 'Abre el archivo DEMO.PDF

        Catch ex As Exception
            MsgBox("NO se puede construir el pdf asegurece de aver cerrado todo los pdf con el mismo nombre", MsgBoxStyle.OkOnly, "Aviso")
        End Try

    End Sub

    Private Sub Reportes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MdiParent = mdiMain
    End Sub


    Private Sub botcomprascontribuyentes_Click(sender As Object, e As EventArgs)
        Try

            nombre = "LibroComprasContribuyente" + dtempresa.Rows(0).Item(1).ToString + ".pdf"

            Dim Documento As New Document 'Declaracion del documento
            Dim parrafo As New Paragraph ' Declaracion de un parrafo



            Dim f, f2, d, m, a, d1, m1, a1 As String
            d = dtdesde.Value.Day
            m = dtdesde.Value.Month
            a = dtdesde.Value.Year
            f = a + "-" + m + "-" + d

            d1 = dthasta.Value.Day
            m1 = dthasta.Value.Month
            a1 = dthasta.Value.Year
            f2 = a1 + "-" + m1 + "-" + d1


            pdf.PdfWriter.GetInstance(Documento, New FileStream(nombre, FileMode.Create)) 'Crea el archivo "DEMO.PDF"

            Documento.Open() 'Abre documento para su escritura
            parrafo.Alignment = Element.ALIGN_CENTER 'Alinea el parrafo para que sea centrado o justificado
            parrafo.Font = FontFactory.GetFont("Arial", 10, BOLDITALIC) 'Asigan fuente

            Documento.Add(parrafo) 'Agrega el parrafo al documento
            parrafo.Clear() 'Limpia el parrafo para que despues pueda ser utilizado nuevamente
            Documento.Add(New Paragraph((dtempresa.Rows(0).Item(6).ToString).ToUpper & " - " & (dtempresa.Rows(0).Item(1).ToString).ToUpper, FontFactory.GetFont("Arial", 12, BOLD)))
            Documento.Add(New Paragraph(("LIBRO DE COMPRAS AL CONTRIBUYENTE               " & "                                REGISTRO N°: " & dtempresa.Rows(0).Item(3).ToString), FontFactory.GetFont("Arial", 10, BOLD)))
            Documento.Add(New Paragraph(("DESDE:" + Me.datedesdevf.Value.ToString + "     HASTA:" + Me.datehastavf.Value.ToString + "                 " & "NIT NUMERO: " & dtempresa.Rows(0).Item(2).ToString), FontFactory.GetFont("Arial", 10, BOLD)))


            Documento.Add(New Paragraph(" ")) 'Salto de linea
            Dim tablademo As New PdfPTable(14) 'declara la tabla con 4 Columnas

            tablademo.SetWidthPercentage({25, 27, 25, 25, 30, 70, 50, 50, 25, 30, 25, 25, 25, 25}, PageSize.A5) 'Ajusta el tamaño de cada columna
            tablademo.AddCell(New Paragraph("No Corre", FontFactory.GetFont("Arial", 6, BOLD))) 'Agrega COLUMNA1 con fuente ARIAL tamaño 5
            tablademo.AddCell(New Paragraph("Fecha Emisión", FontFactory.GetFont("Arial", 6, BOLD))) 'Agrega COLUMNA1 con fuente ARIAL tamaño 8
            tablademo.AddCell(New Paragraph(("No Comprob"), FontFactory.GetFont("Arial", 6, BOLD)))
            tablademo.AddCell(New Paragraph("No Registro", FontFactory.GetFont("Arial", 6, BOLD))) 'Agrega COLUMNA1 con fuente ARIAL tamaño 10
            tablademo.AddCell(New Paragraph("NIT O DUI SUJETO EXCLUSIVO", FontFactory.GetFont("Arial", 5, BOLD))) 'Agrega COLUMNA1 con fuente ARIAL tamaño 12
            tablademo.AddCell(New Paragraph("Proveedor", FontFactory.GetFont("Arial", 6, BOLD))) 'Agrega COLUMNA1 con fuente ARIAL tamaño 12
            tablademo.AddCell(New Paragraph("COMPRAS EXENTAS/                EXCLUIDAS ___________________   Internas   importacion", FontFactory.GetFont("Arial", 5, BOLD))) 'Agrega COLUMNA1 con fuente ARIAL tamaño 12
            tablademo.AddCell(New Paragraph("COMPRAS GRABADAS                                       ___________________       Internas      Impor e Inter", FontFactory.GetFont("Arial", 5, BOLD))) 'Agrega COLUMNA1 con fuente ARIAL tamaño 12
            tablademo.AddCell(New Paragraph("CREDITO FISCAL", FontFactory.GetFont("Arial", 6, BOLD)))
            tablademo.AddCell(New Paragraph("RETENIDO ", FontFactory.GetFont("Arial", 6, BOLD))) 'Agrega COLUMNA1 con fuente ARIAL tamaño 10
            tablademo.AddCell(New Paragraph("PRECEPCION", FontFactory.GetFont("Arial", 6, BOLD))) 'Agrega COLUMNA1 con fuente ARIAL tamaño 12
            tablademo.AddCell(New Paragraph("FOVIAL COTRANS", FontFactory.GetFont("Arial", 5, BOLD))) 'Agrega COLUMNA1 con fuente ARIAL tamaño 12
            tablademo.AddCell(New Paragraph("Total Compras", FontFactory.GetFont("Arial", 6, BOLD))) 'Agrega COLUMNA1 con fuente ARIAL tamaño 12
            tablademo.AddCell(New Paragraph("Sujetos Exc", FontFactory.GetFont("Arial", 6, BOLD)))
            Documento.Add(tablademo) 'Agrega la tabla al documento
            dtfactaracompra = tfacturacompra.Consultar(" where codempresa = " + mdiMain.codigoempresa + " and tipo = 'Comprobante de Credito fiscal' and fecha >= '" + f + "' and fecha <= '" + f2 + "'")

            Dim internas1 As Double = 0
            Dim ivafical1 As Double = 0
            Dim total As Double = 0
            For i As Integer = 0 To dtfactaracompra.Rows.Count - 1
                Dim internas As Double = 0
                Dim ivafical As Double = 0
                Dim total1 As Double = 0
                Dim tablademo1 As New PdfPTable(16) 'declara la tabla con 4 Columnas

                tablademo1.SetWidthPercentage({25, 27, 25, 25, 30, 70, 25, 25, 25, 25, 25, 30, 25, 25, 25, 25}, PageSize.A5) 'Ajusta el tamaño de cada columna
                tablademo1.AddCell(New Paragraph(i + 1, FontFactory.GetFont("Arial", 6, BOLD))) 'Agrega COLUMNA1 con fuente ARIAL tamaño 5

                Dim date2 As New DateTime
                Dim date3 As String
                date2 = dtfactaracompra.Rows(i).Item(4)
                date3 = date2.Day.ToString & "-" & date2.Month.ToString & "-" & date2.Year.ToString
                tablademo1.AddCell(New Paragraph(date3.ToString, FontFactory.GetFont("Arial", 6, BOLD))) 'Agrega COLUMNA1 con fuente ARIAL tamaño 8
                tablademo1.AddCell(New Paragraph(dtfactaracompra.Rows(i).Item(1).ToString, FontFactory.GetFont("Arial", 6, BOLD)))
                dtproveedor = tproveedor.Consultar(" where codproveedor =" + dtfactaracompra.Rows(i).Item(2).ToString)
                tablademo1.AddCell(New Paragraph(dtproveedor.Rows(0).Item(3).ToString, FontFactory.GetFont("Arial", 6, BOLD))) 'Agrega COLUMNA1 con fuente ARIAL tamaño 10
                tablademo1.AddCell(New Paragraph(" ", FontFactory.GetFont("Arial", 5, BOLD))) 'Agrega COLUMNA1 con fuente ARIAL tamaño 12
                tablademo1.AddCell(New Paragraph(dtproveedor.Rows(0).Item(1).ToString, FontFactory.GetFont("Arial", 6, BOLD))) 'Agrega COLUMNA1 con fuente ARIAL tamaño 12
                tablademo1.AddCell(New Paragraph("0.00", FontFactory.GetFont("Arial", 5, BOLD))) 'Agrega COLUMNA1 con fuente ARIAL tamaño 12
                tablademo1.AddCell(New Paragraph("0.00", FontFactory.GetFont("Arial", 5, BOLD))) 'Agrega COLUMNA1 con fuente ARIAL tamaño 12
                ivafical = FormatNumber(CDbl(dtfactaracompra.Rows(i).Item(9)), 2)
                total1 = FormatNumber(CDbl(dtfactaracompra.Rows(i).Item(10)), 2)
                internas = FormatNumber((total1 - ivafical), 2)
                tablademo1.AddCell(New Paragraph(internas.ToString, FontFactory.GetFont("Arial", 5, BOLD))) 'Agrega COLUMNA1 con fuente ARIAL tamaño 12
                tablademo1.AddCell(New Paragraph("0.00", FontFactory.GetFont("Arial", 5, BOLD))) 'Agrega COLUMNA1 con fuente ARIAL tamaño 12
                tablademo1.AddCell(New Paragraph(ivafical.ToString, FontFactory.GetFont("Arial", 6, BOLD)))
                tablademo1.AddCell(New Paragraph("0.00 ", FontFactory.GetFont("Arial", 6, BOLD))) 'Agrega COLUMNA1 con fuente ARIAL tamaño 10
                tablademo1.AddCell(New Paragraph("0.00 ", FontFactory.GetFont("Arial", 6, BOLD))) 'Agrega COLUMNA1 con fuente ARIAL tamaño 12
                tablademo1.AddCell(New Paragraph("0.00 ", FontFactory.GetFont("Arial", 5, BOLD))) 'Agrega COLUMNA1 con fuente ARIAL tamaño 12
                tablademo1.AddCell(New Paragraph(total1, FontFactory.GetFont("Arial", 6, BOLD))) 'Agrega COLUMNA1 con fuente ARIAL tamaño 12
                tablademo1.AddCell(New Paragraph("0.00", FontFactory.GetFont("Arial", 6, BOLD)))
                total += total1
                ivafical1 += ivafical
                internas1 += internas
                Documento.Add(tablademo1)
            Next

            Dim tablademo3 As New PdfPTable(7) 'declara la tabla con 4 Columnas

            tablademo3.SetWidthPercentage({252, 25, 25, 25, 80, 25, 25}, PageSize.A5) 'Ajusta el tamaño de cada columna
            tablademo3.AddCell(New Paragraph("Totales.....................", FontFactory.GetFont("Arial", 10, BOLDITALIC)))
            tablademo3.AddCell(New Paragraph(internas1.ToString, FontFactory.GetFont("Arial", 7, BOLDITALIC))) 'Agrega COLUMNA1 con fuente ARIAL tamaño 5
            tablademo3.AddCell(New Paragraph(" ", FontFactory.GetFont("Arial", 5, BOLDITALIC)))
            tablademo3.AddCell(New Paragraph(ivafical1.ToString, FontFactory.GetFont("Arial", 7, BOLDITALIC)))
            tablademo3.AddCell(New Paragraph("", FontFactory.GetFont("Arial", 5, BOLDITALIC)))
            tablademo3.AddCell(New Paragraph(total.ToString, FontFactory.GetFont("Arial", 7, BOLDITALIC)))
            tablademo3.AddCell(New Paragraph(" ", FontFactory.GetFont("Arial", 5, BOLDITALIC))) 'Agrega COLUMNA1 con fuente ARIAL tamaño 10
            Documento.Add(tablademo3)

            Dim pies As New Paragraph
            Dim neta As New Paragraph
            pies.Alignment = Element.ALIGN_CENTER
            pies.Font = FontFactory.GetFont("Arial", 8, BOLD)
            pies.Add("                               ")
            neta.Alignment = Element.ALIGN_CENTER
            neta.Font = FontFactory.GetFont("Arial", 10)

            'Dim totalneta As Double
            'totalneta = total - totalgrava

            'Documento.Add(New Paragraph(" ")) 'Salto de linea


            'Dim tablademo4 As New PdfPTable(3)
            'tablademo4.SetWidthPercentage({100, 100, 100}, PageSize.A5)
            'tablademo4.AddCell(New Paragraph(" VENTAS NETAS GRAVADAS", FontFactory.GetFont("Arial", 8, BOLD)))
            'tablademo4.AddCell(New Paragraph(" IMPUSTOS(DEBITO FISCAL)", FontFactory.GetFont("Arial", 8, BOLD))) 'Agrega COLUMNA1 con fuente ARIAL tamaño 5
            'tablademo4.AddCell(New Paragraph("TOTAL VENTAS GRAVADAS", FontFactory.GetFont("Arial", 8, BOLD)))
            ''tablademo4.AddCell(totalneta.ToString)

            'Dim tablademo5 As New PdfPTable(3)
            'tablademo5.SetWidthPercentage({100, 100, 100}, PageSize.A5)
            'tablademo5.AddCell(New Paragraph(totalneta.ToString, FontFactory.GetFont("Arial", 10, BOLD)))
            'tablademo5.AddCell(New Paragraph(totalgrava.ToString, FontFactory.GetFont("Arial", 10, BOLD))) 'Agrega COLUMNA1 con fuente ARIAL tamaño 5
            'tablademo5.AddCell(New Paragraph(total.ToString, FontFactory.GetFont("Arial", 10, BOLD)))
            ''tablademo4.AddCell(totalneta.ToString)

            pies.Add("___________________                      ________________________")
            neta.Add("                    Elavorado por                                  Contador")
            'Documento.Add(tablademo4)
            'Documento.Add(tablademo5)

            Documento.Add(New Paragraph(" ")) 'Salto de linea
            Documento.Add(New Paragraph(" ")) 'Salto de linea
            Documento.Add(New Paragraph(" ")) 'Salto de linea
            Documento.Add(New Paragraph(" ")) 'Salto de linea

            Documento.Add(pies)
            Documento.Add(neta)
            Documento.Close() 'Cierra el documento
            System.Diagnostics.Process.Start(nombre) 'Abre el archivo DEMO.PDF

        Catch ex As Exception
            MsgBox("NO se puede construir el pdf asegurece de aver cerrado todo los pdf con el mismo nombre", MsgBoxStyle.OkOnly, "Aviso")
        End Try

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim Documento As New Document 'Declaracion del documento
            Dim parrafo As New Paragraph ' Declaracion de un parrafo


            'Dim imagendemo As ItextSharp.text.Image 'Declaracion de una imagen
            Dim tablademo As New PdfPTable(6) 'declara la tabla con 4 Columnas

            nombre = "InventarioExistencias" + dtempresa.Rows(0).Item(1).ToString + ".pdf"



            pdf.PdfWriter.GetInstance(Documento, New FileStream(nombre, FileMode.Create)) 'Crea el archivo "DEMO.PDF"

            Documento.Open() 'Abre documento para su escritura
            parrafo.Alignment = Element.ALIGN_CENTER 'Alinea el parrafo para que sea centrado o justificado
            parrafo.Font = FontFactory.GetFont("Arial", 10, BOLDITALIC) 'Asigan fuente


            parrafo.Add(dtempresa.Rows(0).Item(1) & vbCrLf & "Listado General de inventario con saldo al " & Date.Now.ToString & vbCrLf) 'Texto que se insertara
            'parrafo.Add.FontFactory.("Sucursal: X    " & "  Area: Y        " & "Saldo al: FECHA    ")

            Documento.Add(parrafo) 'Agrega el parrafo al documento
            parrafo.Clear() 'Limpia el parrafo para que despues pueda ser utilizado nuevamente
            Documento.Add(New Paragraph(" "))
            Documento.Add(New Paragraph(("      Sucursal: " + dtempresa.Rows(0).Item(1).ToString + "                                  " & "                                                                   " & "                      Saldo al: " + Date.Now + "                   "), FontFactory.GetFont("Arial", 8, BOLD))) 'Salto de linea
            ''Documento.Add(New Paragraph(" ")) 'Salto de linea

            ' imagendemo = ItextSharp.text.Image.GetInstance("imagendemo.jpg") 'Dirreccion a la imagen que se hace referencia
            ' imagendemo.SetAbsolutePosition(50, 550) 'Posicion en el eje cartesiano
            ' imagendemo.ScaleAbsoluteWidth(200) 'Ancho de la imagen
            ' imagendemo.ScaleAbsoluteHeight(165) 'Altura de la imagen
            'Documento.Add(imagendemo) ' Agrega la imagen al documento

            Documento.Add(New Paragraph(" ")) 'Salto de linea
            Dim celda As New pdf.PdfPCell
            dtproductos = tproductos.Consultar(" where codempresa = " + mdiMain.codigoempresa.ToString)
            tablademo.SetWidthPercentage({50, 150, 50, 50, 50, 50}, PageSize.A5) 'Ajusta el tamaño de cada columna
            tablademo.AddCell(New Paragraph("Codigo", FontFactory.GetFont("Arial", 10, BOLD))) 'Agrega COLUMNA1 con fuente ARIAL tamaño 5
            tablademo.AddCell(New Paragraph("                               Descripcion", FontFactory.GetFont("Arial", 10, BOLD))) 'Agrega COLUMNA1 con fuente ARIAL tamaño 8
            tablademo.AddCell(New Paragraph("UnidMed", FontFactory.GetFont("Arial", 10, BOLD)))
            tablademo.AddCell(New Paragraph("Costo Unitario", FontFactory.GetFont("Arial", 10, BOLD))) 'Agrega COLUMNA1 con fuente ARIAL tamaño 10
            tablademo.AddCell(New Paragraph("Saldo Act", FontFactory.GetFont("Arial", 10, BOLD))) 'Agrega COLUMNA1 con fuente ARIAL tamaño 12
            tablademo.AddCell(New Paragraph("Total", FontFactory.GetFont("Arial", 12))) 'Agrega COLUMNA1 con fuente ARIAL tamaño 12
            Documento.Add(tablademo) 'Agrega la tabla al documento
            Dim pu As Double = 0
            Dim sa As Double = 0
            Dim total As Double = 0
            For i As Integer = 0 To dtproductos.Rows.Count - 1
                Dim tablademo2 As New PdfPTable(6) 'declara la tabla con 4 Columnas
                tablademo2.SetWidthPercentage({50, 150, 50, 50, 50, 50}, PageSize.A5) 'Ajusta el tamaño de cada columna
                tablademo2.AddCell(New Paragraph(dtproductos.Rows(i).Item(0), FontFactory.GetFont("Arial", 10))) 'Agrega COLUMNA1 con fuente ARIAL tamaño 5
                tablademo2.AddCell(New Paragraph("                               " + dtproductos.Rows(i).Item(1).ToString, FontFactory.GetFont("Arial", 10))) 'Agrega COLUMNA1 con fuente ARIAL tamaño 8
                tablademo2.AddCell(New Paragraph(dtproductos.Rows(i).Item(10).ToString, FontFactory.GetFont("Arial", 10)))
                tablademo2.AddCell(New Paragraph(dtproductos.Rows(i).Item(3).ToString, FontFactory.GetFont("Arial", 10))) 'Agrega COLUMNA1 con fuente ARIAL tamaño 10
                tablademo2.AddCell(New Paragraph(" ", FontFactory.GetFont("Arial", 10))) 'Agrega COLUMNA1 con fuente ARIAL tamaño 12
                tablademo2.AddCell(New Paragraph(" ", FontFactory.GetFont("Arial", 12))) 'Agrega COLUMNA1 con fuente ARIAL tamaño 12
                Documento.Add(tablademo2) 'Agrega la tabla al documento
                pu += CDbl(dtproductos.Rows(i).Item(3))
                sa += CDbl(dtproductos.Rows(i).Item(6))
                total = pu * sa
            Next

            Documento.Add(New Paragraph(" "))
            Dim tablademo4 As New PdfPTable(3)
            tablademo4.SetWidthPercentage({100, 100, 100}, PageSize.A5)
            tablademo4.AddCell(New Paragraph(" TOTAL COSTO UNITARIO", FontFactory.GetFont("Arial", 8, BOLD)))
            tablademo4.AddCell(New Paragraph(" TOTAL SALDO ACTIVO", FontFactory.GetFont("Arial", 8, BOLD))) 'Agrega COLUMNA1 con fuente ARIAL tamaño 5
            tablademo4.AddCell(New Paragraph("TOTAL", FontFactory.GetFont("Arial", 8, BOLD)))
            'tablademo4.AddCell(totalneta.ToString)
            Documento.Add(tablademo4)
            Dim tablademo5 As New PdfPTable(3)
            tablademo5.SetWidthPercentage({100, 100, 100}, PageSize.A5)
            tablademo5.AddCell(New Paragraph(" ", FontFactory.GetFont("Arial", 10, BOLD)))
            tablademo5.AddCell(New Paragraph(" ", FontFactory.GetFont("Arial", 10, BOLD))) 'Agrega COLUMNA1 con fuente ARIAL tamaño 5
            tablademo5.AddCell(New Paragraph(" ", FontFactory.GetFont("Arial", 10, BOLD)))
            Documento.Add(tablademo5)

            Documento.Close() 'Cierra el documento
            System.Diagnostics.Process.Start(nombre) 'Abre el archivo DEMO.PDF

        Catch ex As Exception
            MsgBox("NO se puede construir el pdf asegurece de haber cerrado todo los pdf con el mismo nombre", MsgBoxStyle.OkOnly, "Aviso")
        End Try

    End Sub




    Private Sub botcomprascontribuyentes_Click_1(sender As Object, e As EventArgs) Handles botcomprascontribuyentes.Click
        Try

            nombre = "ComprasContribuyente" + dtempresa.Rows(0).Item(1).ToString + ".pdf"

            Dim Documento As New Document 'Declaracion del documento
            Dim parrafo As New Paragraph ' Declaracion de un parrafo
            Dim tablademo As New PdfPTable(9) 'declara la tabla con 4 Columnas



            Dim f, f2, d, m, a, d1, m1, a1 As String
            d = dtdesde.Value.Day
            m = dtdesde.Value.Month
            a = dtdesde.Value.Year
            f = a + "-" + m + "-" + d

            d1 = dthasta.Value.Day
            m1 = dthasta.Value.Month
            a1 = dthasta.Value.Year
            f2 = a1 + "-" + m1 + "-" + d1

            If dtdesde.Value > dthasta.Value Then
                MsgBox("La fecha inicial no debe ser mayor a la fecha final", MsgBoxStyle.Critical, "Aviso")
            Else
                pdf.PdfWriter.GetInstance(Documento, New FileStream(nombre, FileMode.Create)) 'Crea el archivo "DEMO.PDF"

                Documento.Open() 'Abre documento para su escritura
                parrafo.Alignment = Element.ALIGN_CENTER 'Alinea el parrafo para que sea centrado o justificado
                parrafo.Font = FontFactory.GetFont("Arial", 10, BOLDITALIC) 'Asigan fuente

                Documento.Add(parrafo) 'Agrega el parrafo al documento
                parrafo.Clear() 'Limpia el parrafo para que despues pueda ser utilizado nuevamente
                Documento.Add(New Paragraph((dtempresa.Rows(0).Item(6).ToString).ToUpper & " - " & (dtempresa.Rows(0).Item(1).ToString).ToUpper, FontFactory.GetFont("Arial", 12, BOLD)))
                Documento.Add(New Paragraph(("LIBRO DE COMPRAS AL CONTRIBULLENTE                         " & "REGISTRO N°: " & dtempresa.Rows(0).Item(3).ToString), FontFactory.GetFont("Arial", 10, BOLD)))
                Documento.Add(New Paragraph(("DESDE:" + f + "     HASTA:" + f2 + "                 " & "NIT NUMERO: " & dtempresa.Rows(0).Item(2).ToString), FontFactory.GetFont("Arial", 10, BOLD)))


                Documento.Add(New Paragraph(" ")) 'Salto de linea
                Dim celda As New pdf.PdfPCell
                tablademo.SetWidthPercentage({30, 50, 55, 55, 50, 50, 50, 50, 50}, PageSize.A5) 'Ajusta el tamaño de cada columna

                tablademo.AddCell(New Paragraph("No. Corre", FontFactory.GetFont("Arial", 10, BOLD))) 'Agrega COLUMNA1 con fuente ARIAL tamaño 5
                tablademo.AddCell(New Paragraph("Fecha emision", FontFactory.GetFont("Arial", 10, BOLD))) 'Agrega COLUMNA1 con fuente ARIAL tamaño 5
                tablademo.AddCell(New Paragraph("No. comprobante", FontFactory.GetFont("Arial", 10, BOLD))) 'Agrega COLUMNA1 con fuente ARIAL tamaño 8
                tablademo.AddCell(New Paragraph("No. registro", FontFactory.GetFont("Arial", 10, BOLD)))
                tablademo.AddCell(New Paragraph("NIT DUI SUJETO EXCLUSIVO ", FontFactory.GetFont("Arial", 10, BOLD))) 'Agrega COLUMNA1 con fuente ARIAL tamaño 10
                tablademo.AddCell(New Paragraph("Nombre del proveedor", FontFactory.GetFont("Arial", 10, BOLD))) 'Agrega COLUMNA1 con fuente ARIAL tamaño 12
                tablademo.AddCell(New Paragraph("COMPRAS EXENTAS/ EXCLUIDAS   INTERNTAS EXPORTACION", FontFactory.GetFont("Arial", 10, BOLD))) 'Agrega COLUMNA1 con fuente ARIAL tamaño 12
                tablademo.AddCell(New Paragraph("Exportación", FontFactory.GetFont("Arial", 10, BOLD))) 'Agrega COLUMNA1 con fuente ARIAL tamaño 12
                tablademo.AddCell(New Paragraph("Locales", FontFactory.GetFont("Arial", 10, BOLD))) 'Agrega COLUMNA1 con fuente ARIAL tamaño 12
                Documento.Add(tablademo) 'Agrega la tabla al documento

                Dim total As Double = 0
                Dim totalgrava As Double
                For i As Integer = d - 1 To d1 - 1
                    Dim tablademo2 As New PdfPTable(9) 'declara la tabla con 4 Columnas

                    Dim del As Integer
                    Dim al As Integer
                    Dim grava As Double
                    Dim totalv As Double


                    tablademo2.SetWidthPercentage({30, 50, 55, 55, 50, 50, 50, 50, 50}, PageSize.A5) 'Ajusta el tamaño de cada columna
                    f = a + "-" + m + "-" + CInt(i + 1).ToString
                    dtfactaracompra = tfacturacompra.Consultar(" where codempresa = '" + mdiMain.codigoempresa.ToString + "' and tipo ='Comprobante de Credito fiscal' and fecha = '" + f + "'")

                    For j As Integer = 0 To dtfactaracompra.Rows.Count - 1
                        If j = 0 Then
                            del = dtfactaracompra.Rows(j).Item(1)
                        End If

                        grava += FormatNumber(CDbl(dtfactaracompra.Rows(j).Item(6)), 2)
                        totalv += FormatNumber(CDbl(dtfactaracompra.Rows(j).Item(10)), 2)

                        al = dtfactaracompra.Rows(j).Item(1)
                    Next
                    If dtfactaracompra.Rows.Count <> 0 Then
                        tablademo2.AddCell(New Paragraph(i + 1, FontFactory.GetFont("Arial", 10))) 'Agrega COLUMNA1 con fuente ARIAL tamaño 5
                        tablademo2.AddCell(New Paragraph(f, FontFactory.GetFont("Arial", 10))) 'Agrega COLUMNA1 con fuente ARIAL tamaño 5
                        tablademo2.AddCell(New Paragraph(del.ToString, FontFactory.GetFont("Arial", 10))) 'Agrega COLUMNA1 con fuente ARIAL tamaño 8
                        tablademo2.AddCell(New Paragraph(al.ToString, FontFactory.GetFont("Arial", 10)))
                        tablademo2.AddCell(New Paragraph(" ", FontFactory.GetFont("Arial", 10))) 'Agrega COLUMNA1 con fuente ARIAL tamaño 10
                        tablademo2.AddCell(New Paragraph("0.00 ", FontFactory.GetFont("Arial", 10))) 'Agrega COLUMNA1 con fuente ARIAL tamaño 12
                        tablademo2.AddCell(New Paragraph(totalv.ToString, FontFactory.GetFont("Arial", 12))) 'Agrega COLUMNA1 con fuente ARIAL tamaño 12
                        tablademo2.AddCell(New Paragraph("0.00 ", FontFactory.GetFont("Arial", 10))) 'Agrega COLUMNA1 con fuente ARIAL tamaño 12
                        tablademo2.AddCell(New Paragraph(totalv.ToString, FontFactory.GetFont("Arial", 12))) 'Agrega COLUMNA1 con fuente ARIAL tamaño 12
                        total += totalv
                        totalgrava += grava
                        grava = 0
                        totalv = 0
                        Documento.Add(tablademo2) 'Agrega la tabla al documento
                    End If

                Next

                Dim tablademo3 As New PdfPTable(5) 'declara la tabla con 4 Columnas

                tablademo3.SetWidthPercentage({240, 50, 50, 50, 50}, PageSize.A5) 'Ajusta el tamaño de cada columna
                tablademo3.AddCell(New Paragraph("Totales.....................", FontFactory.GetFont("Arial", 11, BOLDITALIC)))
                tablademo3.AddCell(New Paragraph("$0.00", FontFactory.GetFont("Arial", 10, BOLDITALIC))) 'Agrega COLUMNA1 con fuente ARIAL tamaño 5
                tablademo3.AddCell(New Paragraph("$" + total.ToString, FontFactory.GetFont("Arial", 10, BOLDITALIC))) 'Agrega COLUMNA1 con fuente ARIAL tamaño 8
                tablademo3.AddCell(New Paragraph("$0.00", FontFactory.GetFont("Arial", 10, BOLDITALIC)))
                tablademo3.AddCell(New Paragraph("$" + total.ToString, FontFactory.GetFont("Arial", 10, BOLDITALIC))) 'Agrega COLUMNA1 con fuente ARIAL tamaño 10
                Documento.Add(tablademo3)

                Dim pies As New Paragraph
                Dim neta As New Paragraph
                pies.Alignment = Element.ALIGN_CENTER
                pies.Font = FontFactory.GetFont("Arial", 8, BOLD)
                pies.Add("                               ")
                neta.Alignment = Element.ALIGN_CENTER
                neta.Font = FontFactory.GetFont("Arial", 10)

                Dim totalneta As Double
                totalneta = total - totalgrava

                Documento.Add(New Paragraph(" ")) 'Salto de linea


                Dim tablademo4 As New PdfPTable(3)
                tablademo4.SetWidthPercentage({100, 100, 100}, PageSize.A5)
                tablademo4.AddCell(New Paragraph(" VENTAS NETAS GRAVADAS", FontFactory.GetFont("Arial", 8, BOLD)))
                tablademo4.AddCell(New Paragraph(" IMPUSTOS(DEBITO FISCAL)", FontFactory.GetFont("Arial", 8, BOLD))) 'Agrega COLUMNA1 con fuente ARIAL tamaño 5
                tablademo4.AddCell(New Paragraph("TOTAL VENTAS GRAVADAS", FontFactory.GetFont("Arial", 8, BOLD)))
                'tablademo4.AddCell(totalneta.ToString)

                Dim tablademo5 As New PdfPTable(3)
                tablademo5.SetWidthPercentage({100, 100, 100}, PageSize.A5)
                tablademo5.AddCell(New Paragraph(totalneta.ToString, FontFactory.GetFont("Arial", 10, BOLD)))
                tablademo5.AddCell(New Paragraph(totalgrava.ToString, FontFactory.GetFont("Arial", 10, BOLD))) 'Agrega COLUMNA1 con fuente ARIAL tamaño 5
                tablademo5.AddCell(New Paragraph(total.ToString, FontFactory.GetFont("Arial", 10, BOLD)))
                'tablademo4.AddCell(totalneta.ToString)

                pies.Add("___________________                      ________________________")
                neta.Add("                    Elavorado por                                  Contador")
                Documento.Add(tablademo4)
                Documento.Add(tablademo5)

                Documento.Add(New Paragraph(" ")) 'Salto de linea
                Documento.Add(New Paragraph(" ")) 'Salto de linea
                Documento.Add(New Paragraph(" ")) 'Salto de linea
                Documento.Add(New Paragraph(" ")) 'Salto de linea

                Documento.Add(pies)
                Documento.Add(neta)
                Documento.Close() 'Cierra el documento
                System.Diagnostics.Process.Start(nombre) 'Abre el archivo DEMO.PDF
            End If


        Catch ex As Exception
            MsgBox("NO se puede construir el pdf asegurece de aver cerrado todo los pdf con el mismo nombre: " & ex.Message, MsgBoxStyle.OkOnly, "Aviso")
        End Try
    End Sub

    Private Sub botcomprasfinal_Click(sender As Object, e As EventArgs) Handles botcomprasfinal.Click
        Try

            nombre = "VentasConsumidor" + dtempresa.Rows(0).Item(1).ToString + ".pdf"

            Dim Documento As New Document 'Declaracion del documento
            Dim parrafo As New Paragraph ' Declaracion de un parrafo
            Dim tablademo As New PdfPTable(9) 'declara la tabla con 4 Columnas



            Dim f, f2, d, m, a, d1, m1, a1 As String
            d = Me.dat1.Value.Day
            m = Me.dat1.Value.Month
            a = Me.dat1.Value.Year
            f = a + "-" + m + "-" + d

            d1 = Me.dat2.Value.Day
            m1 = Me.dat2.Value.Month
            a1 = Me.dat2.Value.Year
            f2 = a1 + "-" + m1 + "-" + d1

            If Me.dat2.Value < Me.dat1.Value Then
                MsgBox("La fecha final no debe ser menor a la fecha de inicio", MsgBoxStyle.Critical, "Aviso")
            Else
                pdf.PdfWriter.GetInstance(Documento, New FileStream(nombre, FileMode.Create)) 'Crea el archivo "DEMO.PDF"

                Documento.Open() 'Abre documento para su escritura
                parrafo.Alignment = Element.ALIGN_CENTER 'Alinea el parrafo para que sea centrado o justificado
                parrafo.Font = FontFactory.GetFont("Arial", 10, BOLDITALIC) 'Asigan fuente

                Documento.Add(parrafo) 'Agrega el parrafo al documento
                parrafo.Clear() 'Limpia el parrafo para que despues pueda ser utilizado nuevamente
                Documento.Add(New Paragraph((dtempresa.Rows(0).Item(6).ToString).ToUpper & " - " & (dtempresa.Rows(0).Item(1).ToString).ToUpper, FontFactory.GetFont("Arial", 12, BOLD)))
                Documento.Add(New Paragraph(("LIBRO DE VENTAS AL CONTRIBULLENTE                         " & "REGISTRO N°: " & dtempresa.Rows(0).Item(3).ToString), FontFactory.GetFont("Arial", 10, BOLD)))
                Documento.Add(New Paragraph(("DESDE:" + Me.datedesdevf.Value.ToString + "     HASTA:" + Me.datehastavf.Value.ToString + "                 " & "NIT NUMERO: " & dtempresa.Rows(0).Item(2).ToString), FontFactory.GetFont("Arial", 10, BOLD)))


                Documento.Add(New Paragraph(" ")) 'Salto de linea
                Dim celda As New pdf.PdfPCell
                tablademo.SetWidthPercentage({30, 50, 55, 55, 50, 50, 50, 50, 50}, PageSize.A5) 'Ajusta el tamaño de cada columna

                tablademo.AddCell(New Paragraph("No. Corre", FontFactory.GetFont("Arial", 10, BOLD))) 'Agrega COLUMNA1 con fuente ARIAL tamaño 5
                tablademo.AddCell(New Paragraph("Fecha emision", FontFactory.GetFont("Arial", 10, BOLD))) 'Agrega COLUMNA1 con fuente ARIAL tamaño 5
                tablademo.AddCell(New Paragraph("No. comprobante", FontFactory.GetFont("Arial", 10, BOLD))) 'Agrega COLUMNA1 con fuente ARIAL tamaño 8
                tablademo.AddCell(New Paragraph("No. registro", FontFactory.GetFont("Arial", 10, BOLD)))
                tablademo.AddCell(New Paragraph("NIT DUI SUJETO EXCLUSIVO ", FontFactory.GetFont("Arial", 10, BOLD))) 'Agrega COLUMNA1 con fuente ARIAL tamaño 10
                tablademo.AddCell(New Paragraph("Nombre del proveedor", FontFactory.GetFont("Arial", 10, BOLD))) 'Agrega COLUMNA1 con fuente ARIAL tamaño 12
                tablademo.AddCell(New Paragraph("COMPRAS EXENTAS/ EXCLUIDAS   INTERNTAS EXPORTACION", FontFactory.GetFont("Arial", 10, BOLD))) 'Agrega COLUMNA1 con fuente ARIAL tamaño 12
                tablademo.AddCell(New Paragraph("Exportación", FontFactory.GetFont("Arial", 10, BOLD))) 'Agrega COLUMNA1 con fuente ARIAL tamaño 12
                tablademo.AddCell(New Paragraph("Locales", FontFactory.GetFont("Arial", 10, BOLD))) 'Agrega COLUMNA1 con fuente ARIAL tamaño 12
                Documento.Add(tablademo) 'Agrega la tabla al documento

                Dim total As Double = 0
                Dim totalgrava As Double
                For i As Integer = d - 1 To d1 - 1
                    Dim tablademo2 As New PdfPTable(9) 'declara la tabla con 4 Columnas

                    Dim del As Integer
                    Dim al As Integer
                    Dim grava As Double
                    Dim totalv As Double


                    tablademo2.SetWidthPercentage({30, 50, 55, 55, 50, 50, 50, 50, 50}, PageSize.A5) 'Ajusta el tamaño de cada columna
                    f = a + "-" + m + "-" + CInt(i + 1).ToString
                    dtfacturaventa = tfacturaventa.Consultar(" where codempresa = '" + mdiMain.codigoempresa.ToString + "' and tipo <>'Comprovante de Credito fiscal' and fecha = '" + f + "'")

                    For j As Integer = 0 To dtfacturaventa.Rows.Count - 1
                        If j = 0 Then
                            del = dtfacturaventa.Rows(j).Item(1)
                        End If
                        grava += FormatNumber(CDbl(dtfacturaventa.Rows(j).Item(9)), 2)
                        totalv += FormatNumber(CDbl(dtfacturaventa.Rows(j).Item(10)), 2)

                        al = dtfacturaventa.Rows(j).Item(1)
                    Next
                    If dtfacturaventa.Rows.Count <> 0 Then
                        tablademo2.AddCell(New Paragraph(i + 1, FontFactory.GetFont("Arial", 10))) 'Agrega COLUMNA1 con fuente ARIAL tamaño 5
                        tablademo2.AddCell(New Paragraph(f, FontFactory.GetFont("Arial", 10))) 'Agrega COLUMNA1 con fuente ARIAL tamaño 5
                        tablademo2.AddCell(New Paragraph(del.ToString, FontFactory.GetFont("Arial", 10))) 'Agrega COLUMNA1 con fuente ARIAL tamaño 8
                        tablademo2.AddCell(New Paragraph(al.ToString, FontFactory.GetFont("Arial", 10)))
                        tablademo2.AddCell(New Paragraph(" ", FontFactory.GetFont("Arial", 10))) 'Agrega COLUMNA1 con fuente ARIAL tamaño 10
                        tablademo2.AddCell(New Paragraph("0.00 ", FontFactory.GetFont("Arial", 10))) 'Agrega COLUMNA1 con fuente ARIAL tamaño 12
                        tablademo2.AddCell(New Paragraph(totalv.ToString, FontFactory.GetFont("Arial", 12))) 'Agrega COLUMNA1 con fuente ARIAL tamaño 12
                        tablademo2.AddCell(New Paragraph("0.00 ", FontFactory.GetFont("Arial", 10))) 'Agrega COLUMNA1 con fuente ARIAL tamaño 12
                        tablademo2.AddCell(New Paragraph(totalv.ToString, FontFactory.GetFont("Arial", 12))) 'Agrega COLUMNA1 con fuente ARIAL tamaño 12
                        total += totalv
                        totalgrava += grava
                        grava = 0
                        totalv = 0
                        Documento.Add(tablademo2) 'Agrega la tabla al documento
                    End If

                Next

                Dim tablademo3 As New PdfPTable(5) 'declara la tabla con 4 Columnas

                tablademo3.SetWidthPercentage({240, 50, 50, 50, 50}, PageSize.A5) 'Ajusta el tamaño de cada columna
                tablademo3.AddCell(New Paragraph("Totales.....................", FontFactory.GetFont("Arial", 11, BOLDITALIC)))
                tablademo3.AddCell(New Paragraph("$0.00", FontFactory.GetFont("Arial", 10, BOLDITALIC))) 'Agrega COLUMNA1 con fuente ARIAL tamaño 5
                tablademo3.AddCell(New Paragraph("$" + total.ToString, FontFactory.GetFont("Arial", 10, BOLDITALIC))) 'Agrega COLUMNA1 con fuente ARIAL tamaño 8
                tablademo3.AddCell(New Paragraph("$0.00", FontFactory.GetFont("Arial", 10, BOLDITALIC)))
                tablademo3.AddCell(New Paragraph("$" + total.ToString, FontFactory.GetFont("Arial", 10, BOLDITALIC))) 'Agrega COLUMNA1 con fuente ARIAL tamaño 10
                Documento.Add(tablademo3)

                Dim pies As New Paragraph
                Dim neta As New Paragraph
                pies.Alignment = Element.ALIGN_CENTER
                pies.Font = FontFactory.GetFont("Arial", 8, BOLD)
                pies.Add("                               ")
                neta.Alignment = Element.ALIGN_CENTER
                neta.Font = FontFactory.GetFont("Arial", 10)

                Dim totalneta As Double
                totalneta = total - totalgrava

                Documento.Add(New Paragraph(" ")) 'Salto de linea


                Dim tablademo4 As New PdfPTable(3)
                tablademo4.SetWidthPercentage({100, 100, 100}, PageSize.A5)
                tablademo4.AddCell(New Paragraph(" VENTAS NETAS GRAVADAS", FontFactory.GetFont("Arial", 8, BOLD)))
                tablademo4.AddCell(New Paragraph(" IMPUSTOS(DEBITO FISCAL)", FontFactory.GetFont("Arial", 8, BOLD))) 'Agrega COLUMNA1 con fuente ARIAL tamaño 5
                tablademo4.AddCell(New Paragraph("TOTAL VENTAS GRAVADAS", FontFactory.GetFont("Arial", 8, BOLD)))
                'tablademo4.AddCell(totalneta.ToString)

                Dim tablademo5 As New PdfPTable(3)
                tablademo5.SetWidthPercentage({100, 100, 100}, PageSize.A5)
                tablademo5.AddCell(New Paragraph(totalneta.ToString, FontFactory.GetFont("Arial", 10, BOLD)))
                tablademo5.AddCell(New Paragraph(totalgrava.ToString, FontFactory.GetFont("Arial", 10, BOLD))) 'Agrega COLUMNA1 con fuente ARIAL tamaño 5
                tablademo5.AddCell(New Paragraph(total.ToString, FontFactory.GetFont("Arial", 10, BOLD)))
                'tablademo4.AddCell(totalneta.ToString)

                pies.Add("___________________                      ________________________")
                neta.Add("                    Elavorado por                                  Contador")
                Documento.Add(tablademo4)
                Documento.Add(tablademo5)

                Documento.Add(New Paragraph(" ")) 'Salto de linea
                Documento.Add(New Paragraph(" ")) 'Salto de linea
                Documento.Add(New Paragraph(" ")) 'Salto de linea
                Documento.Add(New Paragraph(" ")) 'Salto de linea

                Documento.Add(pies)
                Documento.Add(neta)
                Documento.Close() 'Cierra el documento
                System.Diagnostics.Process.Start(nombre) 'Abre el archivo DEMO.PDF
            End If


        Catch ex As Exception
            MsgBox("NO se puede construir el pdf asegurece de aver cerrado todo los pdf con el mismo nombre", MsgBoxStyle.OkOnly, "Aviso")
        End Try
    End Sub

    Private Sub botventascontribuyente_Click(sender As Object, e As EventArgs) Handles botventascontribuyente.Click
        Try

            nombre = "LibroVentasContribuyente" + dtempresa.Rows(0).Item(1).ToString + ".pdf"

            Dim Documento As New Document 'Declaracion del documento
            Dim parrafo As New Paragraph ' Declaracion de un parrafo
            Dim iva As Double


            Dim f, f2, d, m, a, d1, m1, a1 As String
            d = dtdesdevc.Value.Day
            m = dtdesdevc.Value.Month
            a = dtdesdevc.Value.Year
            f = a + "-" + m + "-" + d

            d1 = dthastavc.Value.Day
            m1 = dthastavc.Value.Month
            a1 = dthastavc.Value.Year
            f2 = a1 + "-" + m1 + "-" + d1





            pdf.PdfWriter.GetInstance(Documento, New FileStream(nombre, FileMode.Create)) 'Crea el archivo "DEMO.PDF"

            Documento.Open() 'Abre documento para su escritura
            parrafo.Alignment = Element.ALIGN_CENTER 'Alinea el parrafo para que sea centrado o justificado
            parrafo.Font = FontFactory.GetFont("Arial", 10, BOLDITALIC) 'Asigan fuente

            Documento.Add(parrafo) 'Agrega el parrafo al documento
            parrafo.Clear() 'Limpia el parrafo para que despues pueda ser utilizado nuevamente
            Documento.Add(New Paragraph((dtempresa.Rows(0).Item(6).ToString).ToUpper & " - " & (dtempresa.Rows(0).Item(1).ToString).ToUpper, FontFactory.GetFont("Arial", 12, BOLD)))
            Documento.Add(New Paragraph(("LIBRO DE VENTAS AL CONTRIBUYENTE               " & "                                REGISTRO N°: " & dtempresa.Rows(0).Item(3).ToString), FontFactory.GetFont("Arial", 10, BOLD)))
            Documento.Add(New Paragraph(("DESDE:" + f + "     HASTA:" + f2 + "                 " & "NIT NUMERO: " & dtempresa.Rows(0).Item(2).ToString), FontFactory.GetFont("Arial", 10, BOLD)))


            Documento.Add(New Paragraph(" ")) 'Salto de linea
            Dim tablademo As New PdfPTable(12) 'declara la tabla con 4 Columnas

            tablademo.SetWidthPercentage({35, 27, 25, 25, 30, 40, 40, 40, 40, 40, 25, 25}, PageSize.A5) 'Ajusta el tamaño de cada columna
            tablademo.AddCell(New Paragraph("No Corre", FontFactory.GetFont("Arial", 6, BOLD))) 'Agrega COLUMNA1 con fuente ARIAL tamaño 5
            tablademo.AddCell(New Paragraph("Fecha Emisión", FontFactory.GetFont("Arial", 6, BOLD))) 'Agrega COLUMNA1 con fuente ARIAL tamaño 8
            tablademo.AddCell(New Paragraph(("No Comprob"), FontFactory.GetFont("Arial", 6, BOLD)))
            tablademo.AddCell(New Paragraph("No Registro", FontFactory.GetFont("Arial", 6, BOLD))) 'Agrega COLUMNA1 con fuente ARIAL tamaño 10
            tablademo.AddCell(New Paragraph("NOMBRE DEL CLIENTE MANDANTE O MANDATARIO", FontFactory.GetFont("Arial", 5, BOLD))) 'Agrega COLUMNA1 con fuente ARIAL tamaño 12
            tablademo.AddCell(New Paragraph("Propias Exentas", FontFactory.GetFont("Arial", 5, BOLD))) 'Agrega COLUMNA1 con fuente ARIAL tamaño 12
            tablademo.AddCell(New Paragraph("Propias Internas Gravadas", FontFactory.GetFont("Arial", 5, BOLD))) 'Agrega COLUMNA1 con fuente ARIAL tamaño 12
            tablademo.AddCell(New Paragraph("Propias Iva Deb Fiscal", FontFactory.GetFont("Arial", 6, BOLD)))
            tablademo.AddCell(New Paragraph("A Cta de Terc Exentos", FontFactory.GetFont("Arial", 6, BOLD))) 'Agrega COLUMNA1 con fuente ARIAL tamaño 10
            tablademo.AddCell(New Paragraph("A Cta de Terc Internas Gravadas", FontFactory.GetFont("Arial", 6, BOLD))) 'Agrega COLUMNA1 con fuente ARIAL tamaño 12
            tablademo.AddCell(New Paragraph("A Cta de Terc Iva Deb Fiscal", FontFactory.GetFont("Arial", 5, BOLD))) 'Agrega COLUMNA1 con fuente ARIAL tamaño 12
            tablademo.AddCell(New Paragraph("Retenido", FontFactory.GetFont("Arial", 6, BOLD))) 'Agrega COLUMNA1 con fuente ARIAL tamaño 12

            Documento.Add(tablademo) 'Agrega la tabla al documento
            dtfactaracompra = tfacturacompra.Consultar(" where codempresa = " + mdiMain.codigoempresa + " and tipo = 'Comprobante de Credito fiscal' and fecha >= '" + f + "' and fecha <= '" + f2 + "'")

            Dim internas1 As Double = 0
            Dim ivafical1 As Double = 0
            Dim total As Double = 0

            Dim internas As Double = 0
            Dim ivafical As Double = 0
            Dim total1 As Double = 0
            Dim tablademo1 As New PdfPTable(12) 'declara la tabla con 4 Columnas
            Dim grava As Double

            For i As Integer = d - 1 To d1 - 1




                f = a + "-" + m + "-" + CInt(i + 1).ToString
                dtfacturaventa = tfacturaventa.Consultar(" where codempresa = '" + mdiMain.codigoempresa.ToString + "' and tipo ='Comprobante de Credito fiscal' and fecha = '" + f + "'")

                For j As Integer = 0 To dtfacturaventa.Rows.Count - 1


                    grava += FormatNumber(CDbl(dtfacturaventa.Rows(j).Item(6)), 2)
                    iva += FormatNumber(CDbl(dtfacturaventa.Rows(j).Item(8)), 2)

                    tablademo1.AddCell(New Paragraph((j + 1).ToString, FontFactory.GetFont("Arial", 6, BOLD))) 'Agrega COLUMNA1 con fuente ARIAL tamaño 8
                    tablademo1.AddCell(New Paragraph(f, FontFactory.GetFont("Arial", 6, BOLD)))
                    tablademo1.AddCell(New Paragraph(dtfacturaventa.Rows(j).Item(1).ToString, FontFactory.GetFont("Arial", 6, BOLD))) 'Agrega COLUMNA1 con fuente ARIAL tamaño 10
                    tablademo1.AddCell(New Paragraph("000000 ", FontFactory.GetFont("Arial", 5, BOLD))) 'Agrega COLUMNA1 con fuente ARIAL tamaño 12
                    tablademo1.AddCell(New Paragraph("Cliente", FontFactory.GetFont("Arial", 6, BOLD))) 'Agrega COLUMNA1 con fuente ARIAL tamaño 12
                    tablademo1.AddCell(New Paragraph("0", FontFactory.GetFont("Arial", 5, BOLD))) 'Agrega COLUMNA1 con fuente ARIAL tamaño 12
                    tablademo1.AddCell(New Paragraph(dtfacturaventa.Rows(j).Item(6).ToString, FontFactory.GetFont("Arial", 5, BOLD))) 'Agrega COLUMNA1 con fuente ARIAL tamaño 12


                    tablademo1.AddCell(New Paragraph(dtfacturaventa.Rows(j).Item(8).ToString, FontFactory.GetFont("Arial", 5, BOLD))) 'Agrega COLUMNA1 con fuente ARIAL tamaño 12
                    tablademo1.AddCell(New Paragraph("0.00", FontFactory.GetFont("Arial", 5, BOLD))) 'Agrega COLUMNA1 con fuente ARIAL tamaño 12
                    tablademo1.AddCell(New Paragraph(" ", FontFactory.GetFont("Arial", 6, BOLD)))
                    tablademo1.AddCell(New Paragraph("0 ", FontFactory.GetFont("Arial", 6, BOLD))) 'Agrega COLUMNA1 con fuente ARIAL tamaño 10
                    tablademo1.AddCell(New Paragraph(dtfacturaventa.Rows(j).Item(8).ToString, FontFactory.GetFont("Arial", 6, BOLD))) 'Agrega COLUMNA1 con fuente ARIAL tamaño 12
                Next
            Next

            tablademo1.SetWidthPercentage({35, 27, 25, 25, 30, 40, 40, 40, 40, 40, 25, 25}, PageSize.A5) 'Ajusta el tamaño de cada columna
            tablademo1.AddCell(New Paragraph(0 + 1, FontFactory.GetFont("Arial", 6, BOLD))) 'Agrega COLUMNA1 con fuente ARIAL tamaño 5


            'date2 = dtfacturaventa.Rows(0).Item(4)
            'date3 = date2.Day.ToString & "-" & date2.Month.ToString & "-" & date2.Year.ToString



            Documento.Add(tablademo1)


            Dim tablademo3 As New PdfPTable(12) 'declara la tabla con 4 Columnas

            tablademo3.SetWidthPercentage({35, 27, 25, 25, 30, 40, 40, 40, 40, 40, 25, 25}, PageSize.A5) 'Ajusta el tamaño de cada columna
            tablademo3.AddCell(New Paragraph("Totales", FontFactory.GetFont("Arial", 10, BOLDITALIC)))
            tablademo3.AddCell(New Paragraph(" ", FontFactory.GetFont("Arial", 7, BOLDITALIC))) 'Agrega COLUMNA1 con fuente ARIAL tamaño 5
            tablademo3.AddCell(New Paragraph(" ", FontFactory.GetFont("Arial", 5, BOLDITALIC)))
            tablademo3.AddCell(New Paragraph(" ", FontFactory.GetFont("Arial", 7, BOLDITALIC)))
            tablademo3.AddCell(New Paragraph("  ", FontFactory.GetFont("Arial", 5, BOLDITALIC)))
            tablademo3.AddCell(New Paragraph(" ", FontFactory.GetFont("Arial", 7, BOLDITALIC)))
            tablademo3.AddCell(New Paragraph(grava, FontFactory.GetFont("Arial", 5, BOLDITALIC))) 'Agrega COLUMNA1 con fuente ARIAL tamaño 10
            tablademo3.AddCell(New Paragraph(iva, FontFactory.GetFont("Arial", 7, BOLDITALIC)))
            tablademo3.AddCell(New Paragraph("0", FontFactory.GetFont("Arial", 5, BOLDITALIC))) 'Agrega COLUMNA1 con fuente ARIAL tamaño 10
            tablademo3.AddCell(New Paragraph("0", FontFactory.GetFont("Arial", 7, BOLDITALIC)))
            tablademo3.AddCell(New Paragraph("0", FontFactory.GetFont("Arial", 5, BOLDITALIC))) 'Agrega COLUMNA1 con fuente ARIAL tamaño 10
            tablademo3.AddCell(New Paragraph(iva, FontFactory.GetFont("Arial", 7, BOLDITALIC)))

            Documento.Add(tablademo3)

            Dim pies As New Paragraph
            Dim neta As New Paragraph
            pies.Alignment = Element.ALIGN_CENTER
            pies.Font = FontFactory.GetFont("Arial", 8, BOLD)
            pies.Add("                               ")
            neta.Alignment = Element.ALIGN_CENTER
            neta.Font = FontFactory.GetFont("Arial", 10)

            'Dim totalneta As Double
            'totalneta = total - totalgrava

            'Documento.Add(New Paragraph(" ")) 'Salto de linea


            'Dim tablademo4 As New PdfPTable(3)
            'tablademo4.SetWidthPercentage({100, 100, 100}, PageSize.A5)
            'tablademo4.AddCell(New Paragraph(" VENTAS NETAS GRAVADAS", FontFactory.GetFont("Arial", 8, BOLD)))
            'tablademo4.AddCell(New Paragraph(" IMPUSTOS(DEBITO FISCAL)", FontFactory.GetFont("Arial", 8, BOLD))) 'Agrega COLUMNA1 con fuente ARIAL tamaño 5
            'tablademo4.AddCell(New Paragraph("TOTAL VENTAS GRAVADAS", FontFactory.GetFont("Arial", 8, BOLD)))
            ''tablademo4.AddCell(totalneta.ToString)

            'Dim tablademo5 As New PdfPTable(3)
            'tablademo5.SetWidthPercentage({100, 100, 100}, PageSize.A5)
            'tablademo5.AddCell(New Paragraph(totalneta.ToString, FontFactory.GetFont("Arial", 10, BOLD)))
            'tablademo5.AddCell(New Paragraph(totalgrava.ToString, FontFactory.GetFont("Arial", 10, BOLD))) 'Agrega COLUMNA1 con fuente ARIAL tamaño 5
            'tablademo5.AddCell(New Paragraph(total.ToString, FontFactory.GetFont("Arial", 10, BOLD)))
            ''tablademo4.AddCell(totalneta.ToString)

            pies.Add("___________________                      ________________________")
            neta.Add("                    Elaborado por                                  Contador")
            'Documento.Add(tablademo4)
            'Documento.Add(tablademo5)

            Documento.Add(New Paragraph(" ")) 'Salto de linea
            Documento.Add(New Paragraph(" ")) 'Salto de linea
            Documento.Add(New Paragraph(" ")) 'Salto de linea
            Documento.Add(New Paragraph(" ")) 'Salto de linea

            Documento.Add(pies)
            Documento.Add(neta)
            Documento.Close() 'Cierra el documento
            System.Diagnostics.Process.Start(nombre) 'Abre el archivo DEMO.PDF

        Catch ex As Exception
            MsgBox("NO se puede construir el pdf asegurece de aver cerrado todo los pdf con el mismo nombre " + ex.Message, MsgBoxStyle.OkOnly, "Aviso")
        End Try
    End Sub

    Private Sub botventasfinal_Click_1(sender As Object, e As EventArgs) Handles botventasfinal.Click
        Try

            nombre = "LibroVentasfinal" + dtempresa.Rows(0).Item(1).ToString + ".pdf"

            Dim Documento As New Document 'Declaracion del documento
            Dim parrafo As New Paragraph ' Declaracion de un parrafo
            Dim tablademo As New PdfPTable(8) 'declara la tabla con 4 Columnas



            Dim f, f2, d, m, a, d1, m1, a1 As String
            d = datedesdevf.Value.Day
            m = datedesdevf.Value.Month
            a = datedesdevf.Value.Year
            f = a + "-" + m + "-" + d

            d1 = datehastavf.Value.Day
            m1 = datehastavf.Value.Month
            a1 = datehastavf.Value.Year
            f2 = a1 + "-" + m1 + "-" + d1

            If datehastavf.Value < datedesdevf.Value Then
                MsgBox("La fecha final no debe ser mayor a la fecha de inicio", MsgBoxStyle.Critical, "Aviso")
            Else
                pdf.PdfWriter.GetInstance(Documento, New FileStream(nombre, FileMode.Create)) 'Crea el archivo "DEMO.PDF"

                Documento.Open() 'Abre documento para su escritura
                parrafo.Alignment = Element.ALIGN_CENTER 'Alinea el parrafo para que sea centrado o justificado
                parrafo.Font = FontFactory.GetFont("Arial", 10, BOLDITALIC) 'Asigan fuente

                Documento.Add(parrafo) 'Agrega el parrafo al documento
                parrafo.Clear() 'Limpia el parrafo para que despues pueda ser utilizado nuevamente
                Documento.Add(New Paragraph((dtempresa.Rows(0).Item(6).ToString).ToUpper & " - " & (dtempresa.Rows(0).Item(1).ToString).ToUpper, FontFactory.GetFont("Arial", 12, BOLD)))
                Documento.Add(New Paragraph(("LIBRO DE VENTAS AL CONSUMIDOR                         " & "REGISTRO N°: " & dtempresa.Rows(0).Item(3).ToString), FontFactory.GetFont("Arial", 10, BOLD)))
                Documento.Add(New Paragraph(("DESDE:" + f & "     HASTA:" & f2 + "                 " & "NIT NUMERO: " & dtempresa.Rows(0).Item(2).ToString), FontFactory.GetFont("Arial", 10, BOLD)))


                Documento.Add(New Paragraph(" ")) 'Salto de linea
                Dim celda As New pdf.PdfPCell
                tablademo.SetWidthPercentage({50, 55, 55, 50, 50, 50, 50, 50}, PageSize.A5) 'Ajusta el tamaño de cada columna
                tablademo.AddCell(New Paragraph("Fecha", FontFactory.GetFont("Arial", 10, BOLD))) 'Agrega COLUMNA1 con fuente ARIAL tamaño 5
                tablademo.AddCell(New Paragraph("Del comprobante", FontFactory.GetFont("Arial", 10, BOLD))) 'Agrega COLUMNA1 con fuente ARIAL tamaño 8
                tablademo.AddCell(New Paragraph("Al comprobante", FontFactory.GetFont("Arial", 10, BOLD)))
                tablademo.AddCell(New Paragraph("Descripcion ", FontFactory.GetFont("Arial", 10, BOLD))) 'Agrega COLUMNA1 con fuente ARIAL tamaño 10
                tablademo.AddCell(New Paragraph("Exentas", FontFactory.GetFont("Arial", 10, BOLD))) 'Agrega COLUMNA1 con fuente ARIAL tamaño 12
                tablademo.AddCell(New Paragraph("Gravadas", FontFactory.GetFont("Arial", 10, BOLD))) 'Agrega COLUMNA1 con fuente ARIAL tamaño 12
                tablademo.AddCell(New Paragraph("Exportación", FontFactory.GetFont("Arial", 10, BOLD))) 'Agrega COLUMNA1 con fuente ARIAL tamaño 12
                tablademo.AddCell(New Paragraph("Locales", FontFactory.GetFont("Arial", 10, BOLD))) 'Agrega COLUMNA1 con fuente ARIAL tamaño 12
                Documento.Add(tablademo) 'Agrega la tabla al documento

                Dim total As Double = 0
                Dim totalgrava As Double
                For i As Integer = d - 1 To d1 - 1
                    Dim tablademo2 As New PdfPTable(8) 'declara la tabla con 4 Columnas

                    Dim del As Integer
                    Dim al As Integer
                    Dim grava As Double
                    Dim iva As Double


                    tablademo2.SetWidthPercentage({50, 55, 55, 50, 50, 50, 50, 50}, PageSize.A5) 'Ajusta el tamaño de cada columna
                    f = a + "-" + m + "-" + CInt(i + 1).ToString
                    dtfacturaventa = tfacturaventa.Consultar(" where codempresa = '" + mdiMain.codigoempresa.ToString + "' and tipo ='Factura' and fecha = '" + f + "'")

                    For j As Integer = 0 To dtfacturaventa.Rows.Count - 1
                        If j = 0 Then
                            del = dtfacturaventa.Rows(j).Item(1)
                        End If
                        grava += FormatNumber(CDbl(dtfacturaventa.Rows(j).Item(6)) + CDbl(dtfacturaventa.Rows(j).Item(8)), 2)


                        al = dtfacturaventa.Rows(j).Item(1)
                    Next
                    If dtfacturaventa.Rows.Count <> 0 Then
                        tablademo2.AddCell(New Paragraph(f, FontFactory.GetFont("Arial", 10))) 'Agrega COLUMNA1 con fuente ARIAL tamaño 5
                        tablademo2.AddCell(New Paragraph(del.ToString, FontFactory.GetFont("Arial", 10))) 'Agrega COLUMNA1 con fuente ARIAL tamaño 8
                        tablademo2.AddCell(New Paragraph(al.ToString, FontFactory.GetFont("Arial", 10)))
                        tablademo2.AddCell(New Paragraph(" ", FontFactory.GetFont("Arial", 10))) 'Agrega COLUMNA1 con fuente ARIAL tamaño 10
                        tablademo2.AddCell(New Paragraph("0.00 ", FontFactory.GetFont("Arial", 10))) 'Agrega COLUMNA1 con fuente ARIAL tamaño 12
                        tablademo2.AddCell(New Paragraph(grava, FontFactory.GetFont("Arial", 12))) 'Agrega COLUMNA1 con fuente ARIAL tamaño 12
                        tablademo2.AddCell(New Paragraph("0.00 ", FontFactory.GetFont("Arial", 10))) 'Agrega COLUMNA1 con fuente ARIAL tamaño 12
                        tablademo2.AddCell(New Paragraph(grava.ToString, FontFactory.GetFont("Arial", 12))) 'Agrega COLUMNA1 con fuente ARIAL tamaño 12
                        total += iva
                        totalgrava += grava
                        grava = 0
                        iva = 0
                        Documento.Add(tablademo2) 'Agrega la tabla al documento
                    End If

                Next

                

                Dim pies As New Paragraph
                Dim neta As New Paragraph
                pies.Alignment = Element.ALIGN_CENTER
                pies.Font = FontFactory.GetFont("Arial", 8, BOLD)
                pies.Add("                               ")
                neta.Alignment = Element.ALIGN_CENTER
                neta.Font = FontFactory.GetFont("Arial", 10)

                Dim totalneta As Double
                totalneta = total - totalgrava

                Documento.Add(New Paragraph(" ")) 'Salto de linea


                Dim tablademo4 As New PdfPTable(3)
                tablademo4.SetWidthPercentage({100, 100, 100}, PageSize.A5)
                tablademo4.AddCell(New Paragraph(" VENTAS NETAS GRAVADAS", FontFactory.GetFont("Arial", 8, BOLD)))
                tablademo4.AddCell(New Paragraph(" IMPUSTOS(DEBITO FISCAL)", FontFactory.GetFont("Arial", 8, BOLD))) 'Agrega COLUMNA1 con fuente ARIAL tamaño 5
                tablademo4.AddCell(New Paragraph("TOTAL VENTAS GRAVADAS", FontFactory.GetFont("Arial", 8, BOLD)))
                'tablademo4.AddCell(totalneta.ToString)

                Dim tablademo5 As New PdfPTable(3)
                tablademo5.SetWidthPercentage({100, 100, 100}, PageSize.A5)
                tablademo5.AddCell(New Paragraph(FormatNumber(totalgrava / 1.13, 2), FontFactory.GetFont("Arial", 10, BOLD)))

                tablademo5.AddCell(New Paragraph(FormatNumber((totalgrava / 1.13) * 0.13, 2), FontFactory.GetFont("Arial", 10, BOLD))) 'Agrega COLUMNA1 con fuente ARIAL tamaño 5
                tablademo5.AddCell(New Paragraph(FormatNumber(totalgrava), FontFactory.GetFont("Arial", 10, BOLD)))
                'tablademo4.AddCell(totalneta.ToString)

                pies.Add("___________________                      ________________________")
                neta.Add("                    Elaborado por                                  Contador")
                Documento.Add(tablademo4)
                Documento.Add(tablademo5)

                Documento.Add(New Paragraph(" ")) 'Salto de linea
                Documento.Add(New Paragraph(" ")) 'Salto de linea
                Documento.Add(New Paragraph(" ")) 'Salto de linea
                Documento.Add(New Paragraph(" ")) 'Salto de linea

                Documento.Add(pies)
                Documento.Add(neta)
                Documento.Close() 'Cierra el documento
                System.Diagnostics.Process.Start(nombre) 'Abre el archivo DEMO.PDF
            End If


        Catch ex As Exception
            MsgBox("NO se puede construir el pdf asegurece de aver cerrado todo los pdf con el mismo nombre", MsgBoxStyle.OkOnly, "Aviso")
        End Try


    End Sub


    Private Sub sumasdia(ByVal fecha As String, ByRef sregular As Decimal, ByRef sdiesel As Decimal, ByRef ssuper As Decimal, ByRef siva As Decimal, ByRef scotrans As Decimal, ByRef sfovial As Decimal)
        'Dim tfacturav As New clsMaestros(clsNomTab.eTbl.FacturaVenta)
        'Dim dtfacturav As DataTable
        'Dim tdetalleventa As New clsMaestros(clsNomTab.eTbl.DetalleFacturaV)
        'Dim dtdetallev As DataTable

        'Dim t As New clsProcesos
        'Dim dtt As DataTable




        'dtt = t.Consultar("select * from facturaventa,detalleventa where fecha = '" & fecha & "' and  detalleventa.codfacturav = facturaventa.codfacturav  and detalleventa.codproducto<4")

        ''SELECT * FROM detalleventa,facturaventa where detalleventa.codfacturav = facturaventa.codfacturav and  facturaventa.fecha = '2014-08-02' and detalleventa.codproducto <4

    End Sub


    Private Sub Botimprimir1_Click(sender As Object, e As EventArgs) Handles texmostrar1.Click
        Try

            If Me.textitulo1.Text.Trim.ToString <> "" Then
                Dim f1, f2, f3, d1, m1, a1, d2, m2, a2, d3, m3, a3 As String

                d1 = datep1.Value.Day
                m1 = datep1.Value.Month
                a1 = datep1.Value.Year
                f1 = a1 + "-" + m1 + "-" + d1

                d2 = datep2.Value.Day
                m2 = datep2.Value.Month
                a2 = datep2.Value.Year
                f2 = a2 + "-" + m2 + "-" + d2

                d3 = datep3.Value.Day
                m3 = datep3.Value.Month
                a3 = datep3.Value.Year
                f3 = a3 + "-" + m3 + "-" + d3


                Dim sregular, sdiesel, ssuper As Decimal
                Dim siva, scotrans, sfovial, stotal, tps As Decimal
                Dim riva, rcotrans, rfovial, rtotal, tpr As Decimal
                Dim diva, dcotrans, dfovial, dtotal, tpd As Decimal


                Dim parrafo As New Paragraph ' Declaracion de un parrafo
                Dim parrafo1 As New Paragraph
                Dim parrafo0 As New Paragraph
                Dim parrafo2 As New Paragraph



                Dim Documento As New Document 'Declaracion del documento


                'Dim imagendemo As ItextSharp.text.Image 'Declaracion de una imagen
                Dim tablademo As New PdfPTable(19) 'declara la tabla con 4 Columnas
                nombre = Me.textitulo1.Text.Trim.ToString + ".pdf"

                pdf.PdfWriter.GetInstance(Documento, New FileStream(nombre, FileMode.Create)) 'Crea el archivo 

                Documento.Open() 'Abre documento para su escritura
                parrafo.Alignment = Element.ALIGN_CENTER 'Alinea el parrafo para que sea centrado o justificado
                parrafo.Font = FontFactory.GetFont("Arial", 14, BOLDITALIC) 'Asigan fuente

                parrafo.Add(Me.textitulo1.Text.ToString) 'Texto que se insertara

                Documento.Add(parrafo) 'Agrega el parrafo al documento
                parrafo.Clear() 'Limpia el parrafo para que despues pueda ser utilizado nuevamente
                Documento.Add(New Paragraph(" ")) ' salto de linea

                Dim celda As New pdf.PdfPCell
                tablademo.SetWidthPercentage({24.31, 24.31, 22, 24.31, 24.31, 24.31, 24.31, 31.24, 22, 24.31, 24.31, 24.31, 24.31, 24.31, 22, 24.31, 24.31, 24.31, 24.31}, PageSize.A5) 'Ajusta el tamaño de cada columna
                tablademo.AddCell(New Paragraph("Fecha", FontFactory.GetFont("Arial", 7, BOLD))) 'Agrega COLUMNA1 con fuente ARIAL tamaño 5
                tablademo.AddCell(New Paragraph("DIESEL", FontFactory.GetFont("Arial", 7, BOLD))) 'Agrega COLUMNA1 con fuente ARIAL tamaño 8
                tablademo.AddCell(New Paragraph("P.U", FontFactory.GetFont("Arial", 5, BOLD)))
                tablademo.AddCell(New Paragraph("IVA", FontFactory.GetFont("Arial", 5, BOLD))) 'Agrega COLUMNA1 con fuente ARIAL tamaño 10
                tablademo.AddCell(New Paragraph("FOVIAL", FontFactory.GetFont("Arial", 5, BOLD))) 'Agrega COLUMNA1 con fuente ARIAL tamaño 12
                tablademo.AddCell(New Paragraph("COTRANS", FontFactory.GetFont("Arial", 5, BOLD))) 'Agrega COLUMNA1 con fuente ARIAL tamaño 12
                tablademo.AddCell(New Paragraph("TOTAL", FontFactory.GetFont("Arial", 6, BOLD))) 'Agrega COLUMNA1 con fuente ARIAL tamaño 12
                tablademo.AddCell(New Paragraph("REGULAR", FontFactory.GetFont("Arial", 7, BOLD))) 'Agrega COLUMNA1 con fuente ARIAL tamaño 8
                tablademo.AddCell(New Paragraph("P.U", FontFactory.GetFont("Arial", 5, BOLD)))
                tablademo.AddCell(New Paragraph("IVA", FontFactory.GetFont("Arial", 5, BOLD))) 'Agrega COLUMNA1 con fuente ARIAL tamaño 10
                tablademo.AddCell(New Paragraph("FOVIAL", FontFactory.GetFont("Arial", 5, BOLD))) 'Agrega COLUMNA1 con fuente ARIAL tamaño 12
                tablademo.AddCell(New Paragraph("COTRANS", FontFactory.GetFont("Arial", 5, BOLD))) 'Agrega COLUMNA1 con fuente ARIAL tamaño 12
                tablademo.AddCell(New Paragraph("TOTAL", FontFactory.GetFont("Arial", 6, BOLD))) 'Agrega COLUMNA1 con fuente ARIAL tamaño 12
                tablademo.AddCell(New Paragraph("SUPER", FontFactory.GetFont("Arial", 7, BOLD))) 'Agrega COLUMNA1 con fuente ARIAL tamaño 8
                tablademo.AddCell(New Paragraph("P.U", FontFactory.GetFont("Arial", 5, BOLD)))
                tablademo.AddCell(New Paragraph("IVA", FontFactory.GetFont("Arial", 5, BOLD))) 'Agrega COLUMNA1 con fuente ARIAL tamaño 10
                tablademo.AddCell(New Paragraph("FOVIAL", FontFactory.GetFont("Arial", 5, BOLD))) 'Agrega COLUMNA1 con fuente ARIAL tamaño 12
                tablademo.AddCell(New Paragraph("COTRANS", FontFactory.GetFont("Arial", 5, BOLD))) 'Agrega COLUMNA1 con fuente ARIAL tamaño 12
                tablademo.AddCell(New Paragraph("TOTAL", FontFactory.GetFont("Arial", 6, BOLD))) 'Agrega COLUMNA1 con fuente ARIAL tamaño 12


                If Me.radiodia.Checked = True Then
                    Dim t As New clsProcesos
                    Dim dtt As DataTable

                    parrafo0.Alignment = Element.ALIGN_LEFT
                    parrafo0.Font = FontFactory.GetFont("Arial", 10, BOLD)
                    parrafo1.Font = FontFactory.GetFont("Arial", 10, BOLD)
                    parrafo0.Add(("EMPRESA: " + dtempresa.Rows(0).Item(1).ToString))
                    parrafo1.Alignment = Element.ALIGN_LEFT
                    parrafo1.Add("NIC: " & dtempresa.Rows(0).Item(2).ToString & vbCrLf & "NRC: " & dtempresa.Rows(0).Item(3).ToString & vbCrLf & "GIRO:" & dtempresa.Rows(0).Item(4).ToString)
                    Documento.Add(parrafo)
                    Documento.Add(parrafo0) 'Agrega el parrafo al documento
                    Documento.Add(parrafo1)
                    parrafo.Clear() 'Limpia el 
                    Documento.Add(New Paragraph(" ")) ' salto de linea
                    Documento.Add(tablademo) 'Agrega la tabla al documento
                    dtt = t.Consultar("select * from facturaventa,detalleventa where fecha = '" & f1 & "' and  detalleventa.codfacturav = facturaventa.codfacturav  and detalleventa.codproducto < 4 and estado = 'valida'")

                    For i As Integer = 0 To dtt.Rows.Count - 1

                        If dtt.Rows(i).Item(19).ToString = "1" Then
                            ssuper += CDec(dtt.Rows(i).Item(20))
                            tps += CDec(dtt.Rows(i).Item(26))
                        ElseIf dtt.Rows(i).Item(19).ToString = "2" Then
                            sregular += CDec(dtt.Rows(i).Item(20))
                            tpr += CDec(dtt.Rows(i).Item(26))
                        ElseIf dtt.Rows(i).Item(19).ToString = "3" Then
                            sdiesel += CDec(dtt.Rows(i).Item(20))
                            tpd += CDec(dtt.Rows(i).Item(26))
                        End If
                    Next

                    'Para la super
                    scotrans = ssuper * 0.1
                    sfovial = scotrans * 2

                    siva = tps - scotrans - sfovial
                    siva = siva / 1.13
                    siva = siva * 0.13

                    'Para la regular
                    rcotrans = sregular * 0.1
                    rfovial = rcotrans * 2

                    riva = tpr - rcotrans - rfovial
                    riva = riva / 1.13
                    riva = riva * 0.13

                    'Para el Diesel
                    dcotrans = sdiesel * 0.1
                    dfovial = dcotrans * 2

                    diva = tpd - dcotrans - dfovial
                    diva = diva / 1.13
                    diva = diva * 0.13


                    Dim tablademo1 As New PdfPTable(19) 'declara la tabla con 4 Columnas

                    tablademo1.SetWidthPercentage({24.31, 24.31, 22, 24.31, 24.31, 24.31, 24.31, 31.24, 22, 24.31, 24.31, 24.31, 24.31, 24.31, 22, 24.31, 24.31, 24.31, 24.31}, PageSize.A5) 'Ajusta el tamaño de cada columna
                    tablademo1.AddCell(New Paragraph(CDate((dtt.Rows(0).Item(5).ToString).ToString), FontFactory.GetFont("Arial", 5))) 'Agrega COLUMNA1 con fuente ARIAL tamaño 12
                    tablademo1.AddCell(New Paragraph(Math.Round(sdiesel, 2), FontFactory.GetFont("Arial", 6))) 'Agrega COLUMNA1 con fuente ARIAL tamaño 12

                    'Para saber el precio unitario que tenia ese producto ese dia
                    Dim dttt As DataTable
                    Dim ttt As New clsProcesos

                    dttt = ttt.Consultar("select detalleventa.preciopublico from facturaventa,detalleventa where fecha ='" & f1 & "' and  detalleventa.codfacturav = facturaventa.codfacturav  and detalleventa.codproducto = 3")
                    tablademo1.AddCell(New Paragraph(dttt.Rows(0).Item(0), FontFactory.GetFont("Arial", 6))) 'Agrega COLUMNA1 con fuente ARIAL tamaño 12
                    tablademo1.AddCell(New Paragraph(Math.Round(diva, 2), FontFactory.GetFont("Arial", 6))) 'Agrega COLUMNA1 con fuente ARIAL tamaño 12
                    tablademo1.AddCell(New Paragraph(Math.Round(dfovial, 2), FontFactory.GetFont("Arial", 6))) 'Agrega COLUMNA1 con fuente ARIAL tamaño 12
                    tablademo1.AddCell(New Paragraph(Math.Round(dcotrans, 2), FontFactory.GetFont("Arial", 6))) 'Agrega COLUMNA1 con fuente ARIAL tamaño 12
                    tablademo1.AddCell(New Paragraph(Math.Round(tpd, 2), FontFactory.GetFont("Arial", 6))) 'Agrega COLUMNA1 con fuente ARIAL tamaño 12
                    tablademo1.AddCell(New Paragraph(Math.Round(sregular, 2), FontFactory.GetFont("Arial", 6))) 'Agrega COLUMNA1 con fuente ARIAL tamaño 12

                    dttt = ttt.Consultar("select detalleventa.preciopublico from facturaventa,detalleventa where fecha ='" & f1 & "' and  detalleventa.codfacturav = facturaventa.codfacturav  and detalleventa.codproducto = 2")
                    tablademo1.AddCell(New Paragraph(dttt.Rows(0).Item(0), FontFactory.GetFont("Arial", 6))) 'Agrega COLUMNA1 con fuente ARIAL tamaño 12
                    tablademo1.AddCell(New Paragraph(Math.Round(riva, 2), FontFactory.GetFont("Arial", 6))) 'Agrega COLUMNA1 con fuente ARIAL tamaño 12
                    tablademo1.AddCell(New Paragraph(Math.Round(rfovial, 2), FontFactory.GetFont("Arial", 6))) 'Agrega COLUMNA1 con fuente ARIAL tamaño 12
                    tablademo1.AddCell(New Paragraph(Math.Round(rcotrans, 2), FontFactory.GetFont("Arial", 6))) 'Agrega COLUMNA1 con fuente ARIAL tamaño 12
                    tablademo1.AddCell(New Paragraph(Math.Round(tpr, 2), FontFactory.GetFont("Arial", 6))) 'Agrega COLUMNA1 con fuente ARIAL tamaño 12
                    tablademo1.AddCell(New Paragraph(Math.Round(ssuper, 2), FontFactory.GetFont("Arial", 6))) 'Agrega COLUMNA1 con fuente ARIAL tamaño 12

                    dttt = ttt.Consultar("select detalleventa.preciopublico from facturaventa,detalleventa where fecha ='" & f1 & "' and  detalleventa.codfacturav = facturaventa.codfacturav  and detalleventa.codproducto = 1")
                    tablademo1.AddCell(New Paragraph(dttt.Rows(0).Item(0), FontFactory.GetFont("Arial", 6))) 'Agrega COLUMNA1 con fuente ARIAL tamaño 12
                    tablademo1.AddCell(New Paragraph(Math.Round(siva, 2), FontFactory.GetFont("Arial", 6))) 'Agrega COLUMNA1 con fuente ARIAL tamaño 12
                    tablademo1.AddCell(New Paragraph(Math.Round(sfovial, 2), FontFactory.GetFont("Arial", 6))) 'Agrega COLUMNA1 con fuente ARIAL tamaño 12
                    tablademo1.AddCell(New Paragraph(Math.Round(scotrans, 2), FontFactory.GetFont("Arial", 6))) 'Agrega COLUMNA1 con fuente ARIAL tamaño 12
                    tablademo1.AddCell(New Paragraph(Math.Round(tps, 2), FontFactory.GetFont("Arial", 6))) 'Agrega COLUMNA1 con fuente ARIAL tamaño 12

                    Documento.Add(tablademo1) 'Agrega la tabla al documento
                    Documento.Add(New Paragraph(" ")) ' salto de linea
                    Documento.Add(New Paragraph(" ")) 'Salto de linea
                    Dim tablademo3 As New PdfPTable(4) 'declara la tabla con 4 Columnas

                    tablademo3.SetWidthPercentage({115.47, 115.47, 115.47, 115.47}, PageSize.A5) 'Ajusta el tamaño de cada columna
                    tablademo3.AddCell(New Paragraph("DIESEL", FontFactory.GetFont("Arial", 11, BOLDITALIC)))
                    tablademo3.AddCell(New Paragraph("REGULAR", FontFactory.GetFont("Arial", 10, BOLDITALIC))) 'Agrega COLUMNA1 con fuente ARIAL tamaño 5
                    tablademo3.AddCell(New Paragraph("SUPER", FontFactory.GetFont("Arial", 10, BOLDITALIC))) 'Agrega COLUMNA1 con fuente ARIAL tamaño 8
                    tablademo3.AddCell(New Paragraph("TOTAL", FontFactory.GetFont("Arial", 10, BOLDITALIC)))

                    Documento.Add(tablademo3)

                    Dim tablademo4 As New PdfPTable(8) 'declara la tabla con 4 Columnas

                    tablademo4.SetWidthPercentage({57.735, 57.735, 57.735, 57.735, 57.735, 57.735, 57.735, 57.735}, PageSize.A5) 'Ajusta el tamaño de cada columna
                    tablademo4.AddCell(New Paragraph("T.Galones", FontFactory.GetFont("Arial", 11, BOLDITALIC)))
                    tablademo4.AddCell(New Paragraph("T.Dolares", FontFactory.GetFont("Arial", 10, BOLDITALIC)))
                    tablademo4.AddCell(New Paragraph("T.Galones", FontFactory.GetFont("Arial", 11, BOLDITALIC)))
                    tablademo4.AddCell(New Paragraph("T.Dolares", FontFactory.GetFont("Arial", 10, BOLDITALIC)))
                    tablademo4.AddCell(New Paragraph("T.Galones", FontFactory.GetFont("Arial", 11, BOLDITALIC)))
                    tablademo4.AddCell(New Paragraph("T.Dolares", FontFactory.GetFont("Arial", 10, BOLDITALIC)))
                    tablademo4.AddCell(New Paragraph("T.Galones", FontFactory.GetFont("Arial", 11, BOLDITALIC)))
                    tablademo4.AddCell(New Paragraph("T.Dolares", FontFactory.GetFont("Arial", 10, BOLDITALIC)))
                    Documento.Add(tablademo4)


                    Dim tablademo5 As New PdfPTable(8) 'declara la tabla con 4 Columnas

                    tablademo5.SetWidthPercentage({57.735, 57.735, 57.735, 57.735, 57.735, 57.735, 57.735, 57.735}, PageSize.A5) 'Ajusta el tamaño de cada columna
                    tablademo5.AddCell(New Paragraph(Math.Round(sdiesel, 2), FontFactory.GetFont("Arial", 11, BOLDITALIC)))
                    tablademo5.AddCell(New Paragraph(Math.Round(tpd, 2), FontFactory.GetFont("Arial", 11, BOLDITALIC)))
                    tablademo5.AddCell(New Paragraph(Math.Round(sregular, 2), FontFactory.GetFont("Arial", 11, BOLDITALIC)))
                    tablademo5.AddCell(New Paragraph(Math.Round(tpr, 2), FontFactory.GetFont("Arial", 11, BOLDITALIC)))
                    tablademo5.AddCell(New Paragraph(Math.Round(ssuper, 2), FontFactory.GetFont("Arial", 11, BOLDITALIC)))
                    tablademo5.AddCell(New Paragraph(Math.Round(tps, 2), FontFactory.GetFont("Arial", 11, BOLDITALIC)))
                    tablademo5.AddCell(New Paragraph(Math.Round((sdiesel + sregular + ssuper), 3), FontFactory.GetFont("Arial", 11, BOLDITALIC)))
                    tablademo5.AddCell(New Paragraph(Math.Round((tpd + tpr + tps), 3), FontFactory.GetFont("Arial", 11, BOLDITALIC)))

                    Documento.Add(tablademo5)


                Else

                    parrafo0.Alignment = Element.ALIGN_LEFT
                    parrafo0.Font = FontFactory.GetFont("Arial", 10, BOLD)
                    parrafo1.Font = FontFactory.GetFont("Arial", 10, BOLD)
                    parrafo0.Add(("EMPRESA: " + dtempresa.Rows(0).Item(1).ToString))
                    parrafo1.Alignment = Element.ALIGN_LEFT
                    parrafo1.Add("NIC: " & dtempresa.Rows(0).Item(2).ToString & vbCrLf & "NRC: " & dtempresa.Rows(0).Item(3).ToString & vbCrLf & "GIRO:" & dtempresa.Rows(0).Item(4).ToString)
                    Documento.Add(parrafo)
                    Documento.Add(parrafo0) 'Agrega el parrafo al documento
                    Documento.Add(parrafo1)
                    parrafo.Clear() 'Limpia el 
                    Documento.Add(New Paragraph(" ")) ' salto de linea
                    Documento.Add(tablademo) 'Agrega la tabla al documento
                    Dim tgd, tgr, tgs As Decimal
                    Dim tdd, tdr, tds As Decimal
                    Dim tg, td As Decimal

                    Dim h As Integer = 1
                    Dim igual As String


                    Dim t As New clsProcesos
                    Dim dtt As DataTable

                    If m1 < 10 Then
                        dtt = t.Consultar("select * from facturaventa,detalleventa where fecha like '%" & a1 + "-0" + m1 & "%' and  detalleventa.codfacturav = facturaventa.codfacturav  and detalleventa.codproducto < 4 and estado = 'valida'")
                    Else
                        dtt = t.Consultar("select * from facturaventa,detalleventa where fecha like '%" & a1 + "-" + m1 & "%' and  detalleventa.codfacturav = facturaventa.codfacturav  and detalleventa.codproducto < 4 and estado = 'valida'")
                    End If




                    igual = (CDate(dtt.Rows(0).Item(5)).Date.Day).ToString
                    For i As Integer = 0 To dtt.Rows.Count - 1
                        If (CDate(dtt.Rows(i).Item(5)).Date.Day).ToString <> igual Then
                            h += 1
                            igual = (CDate(dtt.Rows(i).Item(5)).Date.Day).ToString
                        End If
                    Next

                    Dim f As String 'para la fecha
                    Dim tablademo1 As New PdfPTable(19) 'declara la tabla con 19 Columnas
                    For j As Integer = 1 To h

                        If m1 < 10 Then
                            If j < 10 Then
                                f = a1 & "-0" & m1 & "-0" & j
                            Else
                                f = a1 & "-0" & m1 & "-" & j
                            End If

                        Else
                            If j < 10 Then
                                f = a1 & "-" & m1 & "-0" & j
                            Else
                                f = a1 & "-" & m1 & "-" & j
                            End If

                        End If

                        dtt = t.Consultar("select * from facturaventa,detalleventa where fecha = '" & f & "' and  detalleventa.codfacturav = facturaventa.codfacturav  and detalleventa.codproducto < 4 and estado = 'valida'")

                        For i As Integer = 0 To dtt.Rows.Count - 1

                            If dtt.Rows(i).Item(19).ToString = "1" Then
                                ssuper += CDec(dtt.Rows(i).Item(20))
                                tps += CDec(dtt.Rows(i).Item(26))
                            ElseIf dtt.Rows(i).Item(19).ToString = "2" Then
                                sregular += CDec(dtt.Rows(i).Item(20))
                                tpr += CDec(dtt.Rows(i).Item(26))
                            ElseIf dtt.Rows(i).Item(19).ToString = "3" Then
                                sdiesel += CDec(dtt.Rows(i).Item(20))
                                tpd += CDec(dtt.Rows(i).Item(26))
                            End If
                        Next


                        'Para la super
                        scotrans = ssuper * 0.1
                        sfovial = scotrans * 2

                        siva = tps - scotrans - sfovial
                        siva = siva / 1.13
                        siva = siva * 0.13

                        'Para la regular
                        rcotrans = sregular * 0.1
                        rfovial = rcotrans * 2

                        riva = tpr - rcotrans - rfovial
                        riva = riva / 1.13
                        riva = riva * 0.13

                        'Para el Diesel
                        dcotrans = sdiesel * 0.1
                        dfovial = dcotrans * 2

                        diva = tpd - dcotrans - dfovial
                        diva = diva / 1.13
                        diva = diva * 0.13

                        'Para saber el precio unitario que tenia ese producto ese dia
                        Dim dttt As DataTable
                        Dim ttt As New clsProcesos



                        tablademo1.SetWidthPercentage({24.31, 24.31, 22, 24.31, 24.31, 24.31, 24.31, 31.24, 22, 24.31, 24.31, 24.31, 24.31, 24.31, 22, 24.31, 24.31, 24.31, 24.31}, PageSize.A5) 'Ajusta el tamaño de cada columna

                        tablademo1.AddCell(New Paragraph(f, FontFactory.GetFont("Arial", 5))) 'Agrega COLUMNA1 con fuente ARIAL tamaño 12

                        dttt = ttt.Consultar("select detalleventa.preciopublico from facturaventa,detalleventa where fecha ='" & f & "' and  detalleventa.codfacturav = facturaventa.codfacturav  and detalleventa.codproducto = 3")

                        If dttt.Rows.Count <> 0 Then
                            tablademo1.AddCell(New Paragraph(Math.Round(sdiesel, 2), FontFactory.GetFont("Arial", 6))) 'Agrega COLUMNA1 con fuente ARIAL tamaño 12
                            tablademo1.AddCell(New Paragraph(dttt.Rows(0).Item(0), FontFactory.GetFont("Arial", 6))) 'Agrega COLUMNA1 con fuente ARIAL tamaño 12
                            tablademo1.AddCell(New Paragraph(Math.Round(diva, 2), FontFactory.GetFont("Arial", 6))) 'Agrega COLUMNA1 con fuente ARIAL tamaño 12
                            tablademo1.AddCell(New Paragraph(Math.Round(dfovial, 2), FontFactory.GetFont("Arial", 6))) 'Agrega COLUMNA1 con fuente ARIAL tamaño 12
                            tablademo1.AddCell(New Paragraph(Math.Round(dcotrans, 2), FontFactory.GetFont("Arial", 6))) 'Agrega COLUMNA1 con fuente ARIAL tamaño 12
                            tablademo1.AddCell(New Paragraph(Math.Round(tpd, 2), FontFactory.GetFont("Arial", 6, BOLDITALIC))) 'Agrega COLUMNA1 con fuente ARIAL tamaño 12

                        Else
                            tablademo1.AddCell(New Paragraph("0", FontFactory.GetFont("Arial", 6))) 'Agrega COLUMNA1 con fuente ARIAL tamaño 12
                            tablademo1.AddCell(New Paragraph("0", FontFactory.GetFont("Arial", 6))) 'Agrega COLUMNA1 con fuente ARIAL tamaño 12
                            tablademo1.AddCell(New Paragraph("0", FontFactory.GetFont("Arial", 6))) 'Agrega COLUMNA1 con fuente ARIAL tamaño 12
                            tablademo1.AddCell(New Paragraph("0", FontFactory.GetFont("Arial", 6))) 'Agrega COLUMNA1 con fuente ARIAL tamaño 12
                            tablademo1.AddCell(New Paragraph("0", FontFactory.GetFont("Arial", 6))) 'Agrega COLUMNA1 con fuente ARIAL tamaño 12
                            tablademo1.AddCell(New Paragraph("0", FontFactory.GetFont("Arial", 6, BOLDITALIC))) 'Agrega COLUMNA1 con fuente ARIAL tamaño 12
                        End If



                        dttt = ttt.Consultar("select detalleventa.preciopublico from facturaventa,detalleventa where fecha ='" & f & "' and  detalleventa.codfacturav = facturaventa.codfacturav  and detalleventa.codproducto = 2")
                        If dttt.Rows.Count <> 0 Then
                            tablademo1.AddCell(New Paragraph(Math.Round(sregular, 2), FontFactory.GetFont("Arial", 6))) 'Agrega COLUMNA1 con fuente ARIAL tamaño 12
                            tablademo1.AddCell(New Paragraph(dttt.Rows(0).Item(0), FontFactory.GetFont("Arial", 6))) 'Agrega COLUMNA1 con fuente ARIAL tamaño 12
                            tablademo1.AddCell(New Paragraph(Math.Round(riva, 2), FontFactory.GetFont("Arial", 6))) 'Agrega COLUMNA1 con fuente ARIAL tamaño 12
                            tablademo1.AddCell(New Paragraph(Math.Round(rfovial, 2), FontFactory.GetFont("Arial", 6))) 'Agrega COLUMNA1 con fuente ARIAL tamaño 12
                            tablademo1.AddCell(New Paragraph(Math.Round(rcotrans, 2), FontFactory.GetFont("Arial", 6))) 'Agrega COLUMNA1 con fuente ARIAL tamaño 12
                            tablademo1.AddCell(New Paragraph(Math.Round(tpr, 2), FontFactory.GetFont("Arial", 6, BOLDITALIC))) 'Agrega COLUMNA1 con fuente ARIAL tamaño 12

                        Else
                            tablademo1.AddCell(New Paragraph("0", FontFactory.GetFont("Arial", 6))) 'Agrega COLUMNA1 con fuente ARIAL tamaño 12
                            tablademo1.AddCell(New Paragraph("0", FontFactory.GetFont("Arial", 6))) 'Agrega COLUMNA1 con fuente ARIAL tamaño 12
                            tablademo1.AddCell(New Paragraph("0", FontFactory.GetFont("Arial", 6))) 'Agrega COLUMNA1 con fuente ARIAL tamaño 12
                            tablademo1.AddCell(New Paragraph("0", FontFactory.GetFont("Arial", 6))) 'Agrega COLUMNA1 con fuente ARIAL tamaño 12
                            tablademo1.AddCell(New Paragraph("0", FontFactory.GetFont("Arial", 6))) 'Agrega COLUMNA1 con fuente ARIAL tamaño 12
                            tablademo1.AddCell(New Paragraph("0", FontFactory.GetFont("Arial", 6, BOLDITALIC))) 'Agrega COLUMNA1 con fuente ARIAL tamaño 12

                        End If





                        dttt = ttt.Consultar("select detalleventa.preciopublico from facturaventa,detalleventa where fecha ='" & f & "' and  detalleventa.codfacturav = facturaventa.codfacturav  and detalleventa.codproducto = 1")
                        If dttt.Rows.Count <> 0 Then
                            tablademo1.AddCell(New Paragraph(Math.Round(ssuper, 2), FontFactory.GetFont("Arial", 6))) 'Agrega COLUMNA1 con fuente ARIAL tamaño 12
                            tablademo1.AddCell(New Paragraph(dttt.Rows(0).Item(0), FontFactory.GetFont("Arial", 6))) 'Agrega COLUMNA1 con fuente ARIAL tamaño 12
                            tablademo1.AddCell(New Paragraph(Math.Round(siva, 2), FontFactory.GetFont("Arial", 6))) 'Agrega COLUMNA1 con fuente ARIAL tamaño 12
                            tablademo1.AddCell(New Paragraph(Math.Round(sfovial, 2), FontFactory.GetFont("Arial", 6))) 'Agrega COLUMNA1 con fuente ARIAL tamaño 12
                            tablademo1.AddCell(New Paragraph(Math.Round(scotrans, 2), FontFactory.GetFont("Arial", 6))) 'Agrega COLUMNA1 con fuente ARIAL tamaño 12
                            tablademo1.AddCell(New Paragraph(Math.Round(tps, 2), FontFactory.GetFont("Arial", 6, BOLDITALIC))) 'Agrega COLUMNA1 con fuente ARIAL tamaño 12

                        Else
                            tablademo1.AddCell(New Paragraph("0", FontFactory.GetFont("Arial", 6))) 'Agrega COLUMNA1 con fuente ARIAL tamaño 12
                            tablademo1.AddCell(New Paragraph("0", FontFactory.GetFont("Arial", 6))) 'Agrega COLUMNA1 con fuente ARIAL tamaño 12
                            tablademo1.AddCell(New Paragraph("0", FontFactory.GetFont("Arial", 6))) 'Agrega COLUMNA1 con fuente ARIAL tamaño 12
                            tablademo1.AddCell(New Paragraph("0", FontFactory.GetFont("Arial", 6))) 'Agrega COLUMNA1 con fuente ARIAL tamaño 12
                            tablademo1.AddCell(New Paragraph("0", FontFactory.GetFont("Arial", 6))) 'Agrega COLUMNA1 con fuente ARIAL tamaño 1
                            tablademo1.AddCell(New Paragraph("0", FontFactory.GetFont("Arial", 6, BOLDITALIC))) 'Agrega COLUMNA1 con fuente ARIAL tamaño 1
                        End If





                        tgs += Math.Round(ssuper, 2)
                        tgr += Math.Round(sregular, 2)
                        tgd += Math.Round(sdiesel, 2)

                        tds += Math.Round(tps, 2)
                        tdr += Math.Round(tpr, 2)
                        tdd += Math.Round(tpd, 2)

                        tg += Math.Round((tgs + tgr + tgd), 2)
                        td += Math.Round((tds + tdr + tdd), 2)

                        sregular = 0
                        sdiesel = 0
                        ssuper = 0

                        siva = 0
                        scotrans = 0
                        sfovial = 0
                        stotal = 0
                        tps = 0
                        riva = 0
                        rcotrans = 0
                        rfovial = 0
                        rtotal = 0
                        tpr = 0
                        diva = 0
                        dcotrans = 0
                        dfovial = 0
                        dtotal = 0
                        tpd = 0

                    Next

                    Documento.Add(tablademo1) 'Agrega la tabla al documento


                    Documento.Add(New Paragraph(" ")) ' salto de linea
                    Documento.Add(New Paragraph(" ")) 'Salto de linea
                    Dim tablademo3 As New PdfPTable(4) 'declara la tabla con 4 Columnas

                    tablademo3.SetWidthPercentage({115.47, 115.47, 115.47, 115.47}, PageSize.A5) 'Ajusta el tamaño de cada columna
                    tablademo3.AddCell(New Paragraph("DIESEL", FontFactory.GetFont("Arial", 11, BOLDITALIC)))
                    tablademo3.AddCell(New Paragraph("REGULAR", FontFactory.GetFont("Arial", 10, BOLDITALIC))) 'Agrega COLUMNA1 con fuente ARIAL tamaño 5
                    tablademo3.AddCell(New Paragraph("SUPER", FontFactory.GetFont("Arial", 10, BOLDITALIC))) 'Agrega COLUMNA1 con fuente ARIAL tamaño 8
                    tablademo3.AddCell(New Paragraph("TOTAL", FontFactory.GetFont("Arial", 10, BOLDITALIC)))

                    Documento.Add(tablademo3)

                    Dim tablademo4 As New PdfPTable(8) 'declara la tabla con 4 Columnas

                    tablademo4.SetWidthPercentage({57.735, 57.735, 57.735, 57.735, 57.735, 57.735, 57.735, 57.735}, PageSize.A5) 'Ajusta el tamaño de cada columna
                    tablademo4.AddCell(New Paragraph("T.Galones", FontFactory.GetFont("Arial", 11, BOLDITALIC)))
                    tablademo4.AddCell(New Paragraph("T.Dolares", FontFactory.GetFont("Arial", 10, BOLDITALIC)))
                    tablademo4.AddCell(New Paragraph("T.Galones", FontFactory.GetFont("Arial", 11, BOLDITALIC)))
                    tablademo4.AddCell(New Paragraph("T.Dolares", FontFactory.GetFont("Arial", 10, BOLDITALIC)))
                    tablademo4.AddCell(New Paragraph("T.Galones", FontFactory.GetFont("Arial", 11, BOLDITALIC)))
                    tablademo4.AddCell(New Paragraph("T.Dolares", FontFactory.GetFont("Arial", 10, BOLDITALIC)))
                    tablademo4.AddCell(New Paragraph("T.Galones", FontFactory.GetFont("Arial", 11, BOLDITALIC)))
                    tablademo4.AddCell(New Paragraph("T.Dolares", FontFactory.GetFont("Arial", 10, BOLDITALIC)))
                    Documento.Add(tablademo4)


                    Dim tablademo5 As New PdfPTable(8) 'declara la tabla con 4 Columnas

                    tablademo5.SetWidthPercentage({57.735, 57.735, 57.735, 57.735, 57.735, 57.735, 57.735, 57.735}, PageSize.A5) 'Ajusta el tamaño de cada columna
                    tablademo5.AddCell(New Paragraph(tgd, FontFactory.GetFont("Arial", 11, BOLDITALIC)))
                    tablademo5.AddCell(New Paragraph(tdd, FontFactory.GetFont("Arial", 11, BOLDITALIC)))
                    tablademo5.AddCell(New Paragraph(tgr, FontFactory.GetFont("Arial", 11, BOLDITALIC)))
                    tablademo5.AddCell(New Paragraph(tdr, FontFactory.GetFont("Arial", 11, BOLDITALIC)))
                    tablademo5.AddCell(New Paragraph(tgs, FontFactory.GetFont("Arial", 11, BOLDITALIC)))
                    tablademo5.AddCell(New Paragraph(tds, FontFactory.GetFont("Arial", 11, BOLDITALIC)))
                    tablademo5.AddCell(New Paragraph(tg, FontFactory.GetFont("Arial", 11, BOLDITALIC)))
                    tablademo5.AddCell(New Paragraph(td, FontFactory.GetFont("Arial", 11, BOLDITALIC)))

                    Documento.Add(tablademo5)



                End If



                Documento.Add(New Paragraph(" "))



                Documento.Close() 'Cierra el documento
                System.Diagnostics.Process.Start(nombre) 'Abre el archivo DEMO.PDF
            Else
                MsgBox("Tiene que escribir un titulo al documento", MsgBoxStyle.Critical, "Aviso")
            End If
        Catch ex As Exception
            MsgBox("NO se puede construir el pdf asegurece de aver cerrado todo los pdf o : " & ex.Message, MsgBoxStyle.OkOnly, "Aviso")
        End Try
    End Sub

End Class