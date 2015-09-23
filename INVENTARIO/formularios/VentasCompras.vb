﻿Imports logica
Public Class VentasCompras
    Private tfacturacompra As New clsMaestros(clsNomTab.eTbl.FacturaCompra)
    Private dtfacturacompra As DataTable

    Private tfacturaventa As New clsMaestros(clsNomTab.eTbl.FacturaVenta)
    Private dtfacturaventa As DataTable

    Private dtdesdeg, dthastag As String

    Private ganancia1, ganancia2 As Double



    Private Sub botmostrar_Click(sender As Object, e As EventArgs) Handles botmostrar.Click
        obtenerfecha(dtdesde, dthasta)
        obtenerresultados()
    End Sub

    Private Sub obtenerresultados()
        dtfacturacompra = tfacturacompra.Consultar(" where fecha >='" & dtdesdeg & "' and fecha <='" & dthastag & "'")
        dtfacturaventa = tfacturaventa.Consultar(" where fecha >='" & dtdesdeg & "' and fecha <='" & dthastag & "'")
        Dim compras1 As Double
        Dim ventas1 As Double

        Dim comprascontado As Double
        Dim comprascretito As Double
        Dim ventascontado As Double
        Dim ventascredito As Double

        For i As Integer = 0 To dtfacturacompra.Rows.Count - 1
            compras1 += Math.Round(CDbl(dtfacturacompra.Rows(i).Item(10)), 2)

            If dtfacturacompra.Rows(i).Item(11).ToString = "Contado" Then
                comprascontado += Math.Round(CDbl(dtfacturacompra.Rows(i).Item(10)), 2)
            End If

            If dtfacturacompra.Rows(i).Item(11).ToString = "Credito" Then
                comprascretito += Math.Round(CDbl(dtfacturacompra.Rows(i).Item(10)), 2)
            End If
        Next

        For i As Integer = 0 To dtfacturaventa.Rows.Count - 1
            ventas1 += Math.Round(CDbl(dtfacturaventa.Rows(i).Item(10)), 2)

            If dtfacturaventa.Rows(i).Item(11).ToString = "Contado" Then
                ventascontado += Math.Round(CDbl(dtfacturaventa.Rows(i).Item(10)), 2)
            End If

            If dtfacturaventa.Rows(i).Item(11).ToString = "Credito" Then
                ventascredito += Math.Round(CDbl(dtfacturaventa.Rows(i).Item(10)), 2)
            End If
        Next

        texcompras2.Text = "$ " & comprascontado
        texcompracreditofecha.Text = "$ " & comprascretito
        texsumacomprasfecha.Text = "$ " & compras1

        texventas2.Text = "$ " & ventascontado
        texventascreditofecha.Text = "$ " & ventascredito
        texsumaventasfecha.Text = "$ " & ventas1



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

        Dim compras As Double
        Dim ventas As Double
        Dim comprascontado As Double
        Dim comprascretito As Double
        Dim ventascontado As Double
        Dim ventascredito As Double


        dtfacturacompra = tfacturacompra.Consultar(" where fecha ='" & hoy & "'")
        dtfacturaventa = tfacturaventa.Consultar(" where fecha ='" & hoy & "'")

        For i As Integer = 0 To dtfacturacompra.Rows.Count - 1
            compras += Math.Round(CDbl(dtfacturacompra.Rows(i).Item(10)), 2)

            If dtfacturacompra.Rows(i).Item(11).ToString = "Contado" Then
                comprascontado += Math.Round(CDbl(dtfacturacompra.Rows(i).Item(10)), 2)
            End If

            If dtfacturacompra.Rows(i).Item(11).ToString = "Credito" Then
                comprascretito += Math.Round(CDbl(dtfacturacompra.Rows(i).Item(10)), 2)
            End If

        Next

        For i As Integer = 0 To dtfacturaventa.Rows.Count - 1
            ventas += Math.Round(CDbl(dtfacturaventa.Rows(i).Item(10)), 2)

            If dtfacturaventa.Rows(i).Item(11).ToString = "Contado" Then
                ventascontado += Math.Round(CDbl(dtfacturaventa.Rows(i).Item(10)), 2)
            End If

            If dtfacturaventa.Rows(i).Item(11).ToString = "Credito" Then
                ventascredito += Math.Round(CDbl(dtfacturaventa.Rows(i).Item(10)), 2)
            End If

        Next

        Me.texsumacompras.Text = "$ " & compras
        Me.texsumaventas.Text = "$ " & ventas
        Me.texcompras.Text = "$ " & comprascontado
        Me.texcompracredito.Text = "$ " & comprascretito
        Me.texventascredito.Text = "$ " & ventascredito
        Me.texventas.Text = "$ " & ventascontado

    End Sub

  
  
End Class