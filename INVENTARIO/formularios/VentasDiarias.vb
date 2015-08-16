Imports System.Drawing.Printing

Public Class VentasDiarias

    Private Sub imprimir()
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
        e.Graphics.DrawString("CF", prFont, Brushes.Black, xPos, yPos)

        'para la fecha
        xPos += 380
        e.Graphics.DrawString(System.DateTime.Today.Day, prFont, Brushes.Black, xPos, yPos)

        'para la direccion
        yPos += 27
        xPos -= 380
        e.Graphics.DrawString("CF", prFont, Brushes.Black, xPos, yPos)

        'para el nit o dui
        xPos += 380
        e.Graphics.DrawString(System.DateTime.Today.Day, prFont, Brushes.Black, xPos, yPos)

        'para cant super
        xPos -= 435
        yPos += 60
        e.Graphics.DrawString("3.85", prFont, Brushes.Black, xPos, yPos)

        'para el precio unitario
        xPos += 458
        e.Graphics.DrawString("4.1", prFont, Brushes.Black, xPos, yPos)

        'para las ventas gravadas
        xPos += 110
        e.Graphics.DrawString("14.69", prFont, Brushes.Black, xPos, yPos)


        'para cant Regular
        xPos -= 568
        yPos += 20
        e.Graphics.DrawString("3.85", prFont, Brushes.Black, xPos, yPos)

        'para el precio unitario
        xPos += 458
        e.Graphics.DrawString("4.1", prFont, Brushes.Black, xPos, yPos)

        'para las ventas gravadas
        xPos += 110
        e.Graphics.DrawString("14.69", prFont, Brushes.Black, xPos, yPos)


        'para cant Diesel
        xPos -= 568
        yPos += 25
        e.Graphics.DrawString("3.85", prFont, Brushes.Black, xPos, yPos)

        'para el precio unitario
        xPos += 458
        e.Graphics.DrawString("4.1", prFont, Brushes.Black, xPos, yPos)

        'para las ventas gravadas
        xPos += 110
        e.Graphics.DrawString("14.69", prFont, Brushes.Black, xPos, yPos)


        'para cant lubricantes
        xPos -= 568
        yPos += 20
        e.Graphics.DrawString("3.85", prFont, Brushes.Black, xPos, yPos)

        'para el precio unitario
        xPos += 458
        e.Graphics.DrawString("4.1", prFont, Brushes.Black, xPos, yPos)

        'para las ventas gravadas
        xPos += 110
        e.Graphics.DrawString("14.69", prFont, Brushes.Black, xPos, yPos)

        ' para las numeros letras son
        yPos += 50
        xPos -= 528
        e.Graphics.DrawString("novecientos setenta y cinco 00/100 Dolares", prFont, Brushes.Black, xPos, yPos)

        'para las sumas
        xPos += 528
        e.Graphics.DrawString("14.69", prFont, Brushes.Black, xPos, yPos)

        'para fovial
        yPos += 60
        e.Graphics.DrawString("14.69", prFont, Brushes.Black, xPos, yPos)

        'para cotrans
        yPos += 25
        e.Graphics.DrawString("14.69", prFont, Brushes.Black, xPos, yPos)

        'para los totales
        yPos += 40
        e.Graphics.DrawString("14.69", prFont, Brushes.Black, xPos, yPos)
    

        ' indicamos que ya no hay nada más que imprimir
        ' (el valor predeterminado de esta propiedad es False)
        e.HasMorePages = False

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        imprimir()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Configuraciones.Show()
    End Sub
End Class