Imports logica
Public Class VentasCompras
    Private tfacturacompra As New clsMaestros(clsNomTab.eTbl.FacturaCompra)
    Private dtfacturacompra As DataTable

    Private tfacturaventa As New clsMaestros(clsNomTab.eTbl.FacturaVenta)
    Private dtfacturaventa As DataTable

    Private dtdesdeg, dthastag As String

    Private ganancia1, ganancia2 As Double


    Private Sub botcalcular_Click(sender As Object, e As EventArgs) Handles botcalcular.Click
        obtenerfecha(dtdesde, dthasta)
        obtenerresultados()
    End Sub

    Private Sub obtenerresultados()
        dtfacturacompra = tfacturacompra.Consultar(" where fecha >='" & dtdesdeg & "' and fecha <='" & dthastag & "' and codempresa = " & mdiMain.codigoempresa.ToString)
        dtfacturaventa = tfacturaventa.Consultar(" where fecha >='" & dtdesdeg & "' and fecha <='" & dthastag & "' and codempresa = " & mdiMain.codigoempresa.ToString)

        Dim cantidadc As Double = 0
        Dim cantidadv As Double = 0
        ganancia2 = 0
        For i As Integer = 0 To dtfacturacompra.Rows.Count - 1
            cantidadc += CDbl(dtfacturacompra.Rows(i).Item(10))
        Next

        For i As Integer = 0 To dtfacturaventa.Rows.Count - 1
            cantidadv += CDbl(dtfacturaventa.Rows(i).Item(10))
        Next

        datacompras1.Rows(0).Cells(0).Value = cantidadc
        dataventas1.Rows(0).Cells(0).Value = cantidadv


        Dim d, d1 As Double
        d = (cantidadv * 100) / cantidadc
        ganancia1 = cantidadv - cantidadc

        'cantidad double
        Me.dataresultados1.Rows(0).Cells(0).Value = cantidadc

        If cantidadv >= cantidadc Then
            Me.dataresultados1.Rows(0).Cells(1).ToolTipText = "100%"
        Else
            Me.dataresultados1.Rows(0).Cells(1).ToolTipText = CInt(d).ToString + "%"
        End If

        Me.dataresultados1.Rows(0).Cells(1).Value = CInt(d)

        'cantidad entera
        d1 = (ganancia2 * 100) / cantidadc
        Me.dataresultados1.Rows(0).Cells(2).Value = CInt(d1)
        Me.dataresultados1.Rows(0).Cells(2).ToolTipText = CInt(d1).ToString + "%"
        If ganancia1 < 0 Then
            ganancia1 = 0
        End If
        Me.dataresultados1.Rows(0).Cells(3).Value = CDbl(ganancia1)


    End Sub

    Private Sub obtenerfecha(ByRef desde As DateTimePicker, ByRef hasta As DateTimePicker)
        dtdesdeg = desde.Value.Year.ToString + "-"
        dtdesdeg += desde.Value.Month.ToString + "-"
        dtdesdeg += desde.Value.Day.ToString

        dthastag = hasta.Value.Year.ToString + "-"
        dthastag += hasta.Value.Month.ToString + "-"
        dthastag += hasta.Value.Day.ToString
    End Sub

    
    Private Sub VentasCompras_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        obtenerresultadoshoy()

    End Sub

    Private Sub obtenerresultadoshoy()
        Dim hoy As String = Date.Now.Year.ToString + "-" + Date.Now.Month.ToString + "-" + Date.Now.Day.ToString

        dtfacturacompra = tfacturacompra.Consultar(" where fecha ='" & hoy & "' and codempresa = " & mdiMain.codigoempresa.ToString)
        dtfacturaventa = tfacturaventa.Consultar(" where fecha ='" & hoy & "' and codempresa = " & mdiMain.codigoempresa.ToString)
        ganancia1 = 0
        Dim cantidadc As Double = 0
        Dim cantidadv As Double = 0

        For i As Integer = 0 To dtfacturacompra.Rows.Count - 1
            cantidadc += CDbl(dtfacturacompra.Rows(i).Item(10))
        Next

        For i As Integer = 0 To dtfacturaventa.Rows.Count - 1
            cantidadv += CDbl(dtfacturaventa.Rows(i).Item(10))
        Next

        datacompras2.Rows(0).Cells(0).Value = cantidadc
        dataventas2.Rows(0).Cells(0).Value = cantidadv

        Dim d, d2 As Double
        d = (cantidadv * 100) / cantidadc
        ganancia2 = cantidadv - cantidadc

        'cantidad double
        Me.dataresultados2.Rows(0).Cells(0).Value = cantidadc
        If cantidadv >= cantidadc Then
            Me.dataresultados2.Rows(0).Cells(1).ToolTipText = "100%"
        Else
            Me.dataresultados2.Rows(0).Cells(1).ToolTipText = CInt(d).ToString + "%"
        End If
        Me.dataresultados2.Rows(0).Cells(1).Value = CInt(d)

        'cantidad entera
        d2 = (ganancia2 * 100) / cantidadc
        Me.dataresultados2.Rows(0).Cells(2).Value = CInt(d2)
        Me.dataresultados2.Rows(0).Cells(2).ToolTipText = CInt(d2).ToString + "%"
        If ganancia2 < 0 Then
            ganancia2 = 0
        End If
        Me.dataresultados2.Rows(0).Cells(3).Value = CDbl(ganancia2)
    End Sub
End Class