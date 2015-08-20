Imports iTextSharp
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports iTextSharp.text.Font
Imports System.IO
Imports logica
Public Class Kardex
    Dim dtempresa As DataTable
    Dim nombre As String
    Public dtrproductos As DataRow

    Dim dtproductos As DataTable
    Dim tproductos As New clsMaestros(clsNomTab.eTbl.Productos)


    ' para la instancia de las entradas y salidas

    Dim dtfcompras As DataTable
    Dim tfcompras As New clsMaestros(clsNomTab.eTbl.FacturaCompra)
    Dim dtdetallcompra As DataTable
    Dim tdetallecompra As New clsMaestros(clsNomTab.eTbl.DetalleFacturaC)

    Dim dtfventas As DataTable
    Dim tfventas As New clsMaestros(clsNomTab.eTbl.FacturaVenta)
    Dim dtdetalleventa As DataTable
    Dim tdetalleventa As New clsMaestros(clsNomTab.eTbl.DetalleFacturaV)




    Private Sub texnombrep_Click(sender As Object, e As EventArgs) Handles texnombrep.Click
        Try
            pjtAdus.Productos.donde = "kardex"
            pjtAdus.Productos.frmk = Me
            pjtAdus.Productos.Show()
        Catch ex As Exception
            MsgBox("Ocurrio un error asegurese de haber llenado todos los campo correctamente", MsgBoxStyle.OkOnly, "Avise")
        End Try
    End Sub

    Private Sub Kardex_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MdiParent = mdiMain
    End Sub

    Private Sub botkardex_Click(sender As Object, e As EventArgs) Handles botkardex.Click
        Try
            Dim Documento As New Document 'Declaracion del documento
            Dim parrafo As New Paragraph ' Declaracion de un parrafo
            Dim parrafo1 As New Paragraph
            Dim parrafo0 As New Paragraph


            'Definicion de fechas
            Dim f, f2, d, m, a, d1, m1, a1 As String
            d = dtdesde.Value.Day
            m = dtdesde.Value.Month
            a = dtdesde.Value.Year
            f = a + "-" + m + "-" + d

            d1 = dthasta.Value.Day
            m1 = dthasta.Value.Month
            a1 = dthasta.Value.Year
            f2 = a1 + "-" + m1 + "-" + d1


            'Dim imagendemo As ItextSharp.text.Image 'Declaracion de una imagen
            Dim tabla1 As New PdfPTable(4) 'declara la tabla con 4 Columnas

            nombre = "Kardex" & dtrproductos.Item(1).ToString & ".pdf"

          

            If dtdesde.Value > dthasta.Value Then
                MessageBox.Show("La fecha inicial no tiene que ser mayor a la fecha final", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                pdf.PdfWriter.GetInstance(Documento, New FileStream(nombre, FileMode.Create)) 'Crea el archivo "DEMO.PDF"

                Documento.Open() 'Abre documento para su escritura
                parrafo.Alignment = Element.ALIGN_CENTER 'Alinea el parrafo para que sea centrado o justificado
                parrafo.Font = FontFactory.GetFont("Arial", 10, BOLDITALIC) 'Asigan fuente
                'parrafo.Add(" KADEX " & vbCrLf & "Listado General de inventario con saldo al " & Date.Now.ToString & vbCrLf) 'Texto que se insertara
                parrafo.Add("TARGETA KARDEX " & vbCrLf)

                'parrafo.Add.FontFactory.("Sucursal: X    " & "  Area: Y        " & "Saldo al: FECHA    ")
                parrafo0.Alignment = Element.ALIGN_LEFT
                parrafo0.Font = FontFactory.GetFont("Arial", 10, BOLDITALIC)
                parrafo0.Add(("Empresa: " + dtempresa.Rows(0).Item(1).ToString))
                parrafo1.Alignment = Element.ALIGN_LEFT
                parrafo1.Add("Codigo: " & dtrproductos.Item(0).ToString & vbCrLf & "Nombre: " & dtrproductos.Item(1).ToString & vbCrLf & "Presentación:" & dtrproductos.Item(10))
                Documento.Add(parrafo)
                Documento.Add(parrafo0) 'Agrega el parrafo al documento
                Documento.Add(parrafo1)
                parrafo.Clear() 'Limpia el parrafo para que despues pueda ser utilizado nuevamente
                Documento.Add(New Paragraph(" "))

                ''Documento.Add(New Paragraph(" ")) 'Salto de linea

                ' imagendemo = ItextSharp.text.Image.GetInstance("imagendemo.jpg") 'Dirreccion a la imagen que se hace referencia
                ' imagendemo.SetAbsolutePosition(50, 550) 'Posicion en el eje cartesiano
                ' imagendemo.ScaleAbsoluteWidth(200) 'Ancho de la imagen
                ' imagendemo.ScaleAbsoluteHeight(165) 'Altura de la imagen
                'Documento.Add(imagendemo) ' Agrega la imagen al documento

                Documento.Add(New Paragraph(" ")) 'Salto de linea
                Dim celda As New pdf.PdfPCell
                dtproductos = tproductos.Consultar(" where codempresa = " + mdiMain.codigoempresa.ToString)
                tabla1.SetWidthPercentage({114, 114, 114, 114}, PageSize.A5) 'Ajusta el tamaño de cada columna
                tabla1.AddCell(New Paragraph(""))
                tabla1.AddCell(New Paragraph("ENTRADAS ", FontFactory.GetFont("Arial", 10, BOLD))) 'Agrega COLUMNA1 con fuente ARIAL tamaño 8
                tabla1.AddCell(New Paragraph("SALIDAS", FontFactory.GetFont("Arial", 10, BOLD)))
                tabla1.AddCell(New Paragraph("EXISTENCIAS", FontFactory.GetFont("Arial", 10, BOLD)))
               
                Documento.Add(tabla1) 'Agrega la tabla al documento
            
                    Dim tabla2 As New PdfPTable(12) 'declara la tabla con 4 Columnas
                tabla2.SetWidthPercentage({20, 47, 47, 38, 38, 38, 38, 38, 38, 38, 38, 38}, PageSize.A5) 'Ajusta el tamaño de cada columna
                tabla2.AddCell(New Paragraph("No", FontFactory.GetFont("Arial", 8))) 'Agrega COLUMNA1 con fuente ARIAL tamaño 5
                tabla2.AddCell(New Paragraph("CONCEPTO", FontFactory.GetFont("Arial", 8))) 'Agrega COLUMNA1 con fuente ARIAL tamaño 8
                tabla2.AddCell(New Paragraph("FECHA", FontFactory.GetFont("Arial", 8)))
                tabla2.AddCell(New Paragraph("CANTIDAD", FontFactory.GetFont("Arial", 8))) 'Agrega COLUMNA1 con fuente ARIAL tamaño 10
                tabla2.AddCell(New Paragraph("PU", FontFactory.GetFont("Arial", 8))) 'Agrega COLUMNA1 con fuente ARIAL tamaño 12
                tabla2.AddCell(New Paragraph("TOTAL", FontFactory.GetFont("Arial", 8))) 'Agrega COLUMNA1 con fuente ARIAL tamaño 12
                tabla2.AddCell(New Paragraph("CANTIDAD", FontFactory.GetFont("Arial", 8))) 'Agrega COLUMNA1 con fuente ARIAL tamaño 10
                tabla2.AddCell(New Paragraph("PU", FontFactory.GetFont("Arial", 8))) 'Agrega COLUMNA1 con fuente ARIAL tamaño 12
                tabla2.AddCell(New Paragraph("TOTAL", FontFactory.GetFont("Arial", 8))) 'Agrega COLUMNA1 con fuente ARIAL tamaño 12
                tabla2.AddCell(New Paragraph("CANTIDAD", FontFactory.GetFont("Arial", 8))) 'Agrega COLUMNA1 con fuente ARIAL tamaño 10
                tabla2.AddCell(New Paragraph("PU", FontFactory.GetFont("Arial", 8))) 'Agrega COLUMNA1 con fuente ARIAL tamaño 12
                tabla2.AddCell(New Paragraph("TOTAL", FontFactory.GetFont("Arial", 8))) 'Agrega COLUMNA1 con fuente ARIAL tamaño 12
                Documento.Add(tabla2) 'Agrega la tabla al documento


               
                Dim costo As Double
                Dim cantidad As Double
                Dim total As Double

                Dim tcosto As Double = 0
                Dim tcantidad As Double = 0
                Dim ttotal As Double = 0

                Dim numerot As Integer = 1
                Dim fl As Boolean = False
                Dim fecha As String = f
                Dim flc As Boolean = False
                Dim flv As Boolean = False

                Dim di As Integer
                Dim sfecha As String
                Dim sdia As String

                sfecha = fecha.ToString

                sdia = d
                di = sdia


                If di <= 9 Then
                    sdia = "0" & di.ToString
                Else
                    sdia = di.ToString
                End If

                fecha = f
                While fl <> True
                    flc = False
                    flv = False
                    If di > dthasta.Value.Day Then
                        fl = True
                    Else
                        dtfcompras = tfcompras.Consultar(" Where fecha = '" & fecha.ToString & "'") 'selecciono todas las compras de ese dia
                        If dtfcompras.Rows.Count <> 0 Then
                            For i As Integer = 0 To dtfcompras.Rows.Count - 1
                                dtdetallcompra = tdetallecompra.Consultar(" where codfacturac = " & dtfcompras.Rows(i).Item(0).ToString & " and codproducto = " & dtrproductos.Item(0)) ' selecciono el pro producto de esa factura resultado
                                If dtdetallcompra.Rows.Count <> 0 Then
                                    costo = FormatNumber(CDbl(dtdetallcompra.Rows(0).Item(10) + costo) / 2, 2) 'formula para calcular el promedio del costo
                                    cantidad += dtdetallcompra.Rows(0).Item(3)
                                    flc = True ' para saber si hubo compra ese dias
                                End If

                            Next
                        End If



                        If flc = True Then
                            Dim tabla3 As New PdfPTable(12) 'declara la tabla con 4 Columnas
                            tabla3.SetWidthPercentage({20, 47, 47, 38, 38, 38, 38, 38, 38, 38, 38, 38}, PageSize.A5) 'Ajusta el tamaño de cada columna

                            tabla3.AddCell(New Paragraph(numerot.ToString, FontFactory.GetFont("Arial", 8))) ' escribimos el numero de la operacion
                            tabla3.AddCell(New Paragraph("Compra", FontFactory.GetFont("Arial", 8))) 'Escribe el concepto de compra
                            tabla3.AddCell(New Paragraph(fecha.ToString, FontFactory.GetFont("Arial", 8))) 'Escribe la fecha de la transaccion

                            tabla3.AddCell(New Paragraph(cantidad.ToString, FontFactory.GetFont("Arial", 8))) 'Escribe la cantidad
                            tabla3.AddCell(New Paragraph(costo.ToString, FontFactory.GetFont("Arial", 8))) 'Escribe el costo
                            total = costo * cantidad
                            tabla3.AddCell(New Paragraph(total.ToString, FontFactory.GetFont("Arial", 8))) 'Escribe la multiplicacion de el costo por la cantidad

                            tabla3.AddCell(New Paragraph(" ", FontFactory.GetFont("Arial", 8))) 'Espacios en blanco
                            tabla3.AddCell(New Paragraph(" ", FontFactory.GetFont("Arial", 8))) 'Espacios en blanco
                            tabla3.AddCell(New Paragraph(" ", FontFactory.GetFont("Arial", 8))) 'Espacios en blanco
                            tcantidad += cantidad

                            If tcosto = 0 Then
                                tcosto = costo
                            Else
                                tcosto = (tcosto + costo) / 2
                            End If

                            ttotal = tcantidad * tcosto
                            tabla3.AddCell(New Paragraph(tcantidad, FontFactory.GetFont("Arial", 8))) 'inserto la cantidad
                            tabla3.AddCell(New Paragraph(tcosto, FontFactory.GetFont("Arial", 8))) 'inserto el prercio unitario
                            tabla3.AddCell(New Paragraph(ttotal, FontFactory.GetFont("Arial", 8))) 'inserto el total
                            Documento.Add(tabla3) 'Agrega la tabla al documento
                            numerot += 1
                            flc = False
                        End If
                        costo = 0
                        cantidad = 0
                        total = 0

                        dtfventas = tfventas.Consultar(" Where fecha = '" & fecha.ToString & "'")
                        If dtfventas.Rows.Count <> 0 Then
                            For i As Integer = 0 To dtfventas.Rows.Count - 1
                                dtdetalleventa = tdetalleventa.Consultar(" where codfacturav = " & dtfventas.Rows(i).Item(0).ToString & " and codproducto = " & dtrproductos.Item(0)) ' selecciono el pro producto de esa factura resultado
                                If dtdetalleventa.Rows.Count <> 0 Then
                                    costo = CDbl(dtdetalleventa.Rows(0).Item(10) + costo) / 2
                                    cantidad += dtdetalleventa.Rows(0).Item(3)
                                    flv = True ' para saber si hubo compra ese dias
                                End If


                            Next
                        End If

                        If flv = True Then
                            Dim tabla3 As New PdfPTable(12) 'declara la tabla con 4 Columnas
                            tabla3.SetWidthPercentage({20, 47, 47, 38, 38, 38, 38, 38, 38, 38, 38, 38}, PageSize.A5) 'Ajusta el tamaño de cada columna

                            tabla3.AddCell(New Paragraph(numerot.ToString, FontFactory.GetFont("Arial", 8))) ' escribimos el numero de la operacion
                            tabla3.AddCell(New Paragraph("Venta", FontFactory.GetFont("Arial", 8))) 'Escribe el concepto de compra
                            tabla3.AddCell(New Paragraph(fecha.ToString, FontFactory.GetFont("Arial", 8))) 'Escribe la fecha de la transaccion

                            tabla3.AddCell(New Paragraph(" ", FontFactory.GetFont("Arial", 8))) 'Espacios en blanco
                            tabla3.AddCell(New Paragraph(" ", FontFactory.GetFont("Arial", 8))) 'Espacios en blanco
                            tabla3.AddCell(New Paragraph(" ", FontFactory.GetFont("Arial", 8))) 'Espacios en blanco

                            tabla3.AddCell(New Paragraph(FormatNumber(cantidad, 2), FontFactory.GetFont("Arial", 8))) 'Escribe la cantidad
                            tabla3.AddCell(New Paragraph(FormatNumber(tcosto, 2), FontFactory.GetFont("Arial", 8))) 'Escribe el costo
                            total = tcosto * cantidad
                            tabla3.AddCell(New Paragraph(FormatNumber(total, 2), FontFactory.GetFont("Arial", 8))) 'Escribe la multiplicacion de el costo por la cantidad


                            tcantidad -= cantidad
                            ttotal = tcantidad * tcosto

                            tabla3.AddCell(New Paragraph(FormatNumber ( tcantidad,2), FontFactory.GetFont("Arial", 8))) 'inserto la cantidad
                            tabla3.AddCell(New Paragraph(FormatNumber(tcosto, 2), FontFactory.GetFont("Arial", 8))) 'inserto el costo
                            tabla3.AddCell(New Paragraph(FormatNumber(ttotal, 2), FontFactory.GetFont("Arial", 8))) 'inserto el total
                            Documento.Add(tabla3) 'Agrega la tabla al documento
                            numerot += 1
                            flv = False
                        End If

                        costo = 0
                        cantidad = 0
                        total = 0
                    End If

                    d += 1
                    di = d
                  
                    If di <= 9 Then
                        sdia = "0" & di.ToString
                    Else
                        sdia = di.ToString
                    End If


                    m = dtdesde.Value.Month
                    a = dtdesde.Value.Year
                    f = a & "-" + m & "-" & di
                    fecha = f
                End While

                Documento.Close() 'Cierra el documento
                System.Diagnostics.Process.Start(nombre) 'Abre el archivo DEMO.PDF
            End If
           

        Catch ex As Exception
            MsgBox("NO se puede construir el pdf asegurece de aver cerrado todo los pdf con el mismo nombre: razon " & ex.Message, MsgBoxStyle.OkOnly, "Aviso")
        End Try

    End Sub

  
End Class