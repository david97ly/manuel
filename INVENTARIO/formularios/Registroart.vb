Imports logica
Public Class Registroart
    Dim tproductos As New clsMaestros(clsNomTab.eTbl.Productos)
    Dim dtproductos As DataTable
    Public dtrproductos As DataRow

    Dim tcompras As New clsMaestros(clsNomTab.eTbl.DetalleFacturaC)
    Dim dtcompras As DataTable
    Dim tventas As New clsMaestros(clsNomTab.eTbl.DetalleFacturaV)
    Dim dtventas As DataTable

    Dim tablac As New clsProcesos
    Dim dtdtcompras As New clsProcesos
    Dim ttablac As DataTable

    Dim dtfcompras As DataTable
    Dim dthastag, dtdesdeg As String
    Dim donde As String
    Dim cantidadc, cantidadv, totalc, totalv As Double
    Private Sub Registroart_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarnombre()

    End Sub

    Private Sub cargarnombre()
        donde = "a"
        Me.lbarticulo.Text = dtrproductos.Item(1).ToString
        Me.lbarticulosv.Text = dtrproductos.Item(1).ToString
        Me.lbarticulocv.Text = dtrproductos.Item(1).ToString
        obtenerfecha(dtdesde, dthasta)
        cargarcantidadmonto()
        obtenerfecha(dtdesdecv, dthastav)
        cargarventa()
    End Sub

    Private Sub obtenerfecha(ByRef desde As DateTimePicker, ByRef hasta As DateTimePicker)
        dtdesdeg = desde.Value.Year.ToString + "-"
        dtdesdeg += desde.Value.Month.ToString + "-"
        dtdesdeg += desde.Value.Day.ToString

        dthastag = hasta.Value.Year.ToString + "-"
        dthastag += hasta.Value.Month.ToString + "-"
        dthastag += hasta.Value.Day.ToString
    End Sub
    Private Sub cargarcantidadmonto()
        cantidadc = 0
        totalc = 0
        Dim cantidad, total As Double

        Dim dtdtcomprast As DataTable
        dtcompras = tablac.Consultar("SELECT `codfacturac` FROM `facturacompra` where fecha >='" & dtdesdeg & "' and fecha <='" & dthastag & "'")

        For i As Integer = 0 To dtcompras.Rows.Count - 1
            ttablac = tablac.Consultar("SELECT SUM(cantidadunit),SUM(total) FROM `detallecompra` where   codfacturac = " & dtcompras.Rows(i).Item(0).ToString)
            If ttablac.Rows.Count < 1 Then
            Else
                cantidad += CDbl(ttablac.Rows(0).Item(0))
                total += CDbl(ttablac.Rows(0).Item(1))

                dtdtcomprast = dtdtcompras.Consultar("SELECT codarticulo,cantidadunit,total FROM `detallecompra` where codfacturac = " & dtcompras.Rows(i).Item(0).ToString)
                For j As Integer = 0 To dtdtcomprast.Rows.Count - 1
                    If dtdtcomprast.Rows(j).Item(0).ToString = dtrproductos.Item(0).ToString Then
                        cantidadc += CDbl(dtdtcomprast.Rows(j).Item(1))
                        totalc += CDbl(dtdtcomprast.Rows(j).Item(2))
                    End If
                Next
            End If

        Next

        Dim pr As Double = 0.0
        If donde <> "cv" Then
            pr = (totalc * 100) / total

            lbcantidad.Text = cantidadc
            lbmonto.Text = totalc
            lbporcentaje.Text = pr.ToString
        End If

    End Sub

    Private Sub ButtonX1_Click(sender As Object, e As EventArgs) Handles ButtonX1.Click
        donde = "c"
        obtenerfecha(dtdesde, dthasta)
        cargarnombre()
    End Sub


    Private Sub cargarventa()
        cantidadv = 0
        totalv = 0
        Dim cantidad, total As Double

        Dim dtdtcomprast As DataTable

        dtcompras = tablac.Consultar("SELECT `codfacturav` FROM `facturaventa` where fecha >='" & dtdesdeg & "' and fecha <='" & dthastag & "'")

        For i As Integer = 0 To dtcompras.Rows.Count - 1
            ttablac = tablac.Consultar("SELECT SUM(cantidadunit),SUM(total) FROM `detalleventa` where   codfacturav = " & dtcompras.Rows(i).Item(0).ToString)
            If ttablac.Rows.Count < 1 Then
            Else
                cantidad += CDbl(ttablac.Rows(0).Item(0))
                total += CDbl(ttablac.Rows(0).Item(1))

                dtdtcomprast = dtdtcompras.Consultar("SELECT codarticulo,cantidadunit,total FROM `detalleventa` where codfacturav = " & dtcompras.Rows(i).Item(0).ToString)
                For j As Integer = 0 To dtdtcomprast.Rows.Count - 1
                    If dtdtcomprast.Rows(j).Item(0).ToString = dtrproductos.Item(0).ToString Then
                        cantidadv += CDbl(dtdtcomprast.Rows(j).Item(1))
                        totalv += CDbl(dtdtcomprast.Rows(j).Item(2))
                    End If
                Next
            End If

        Next

        Dim pr As Double = 0.0
        If donde <> "cv" Then
            pr = (totalv * 100) / total

            lbcantidadv.Text = cantidadv
            lbmontov.Text = totalv
            lbporcentajev.Text = pr.ToString
        End If

    End Sub

    Private Sub botaceptarv_Click(sender As Object, e As EventArgs) Handles botaceptarv.Click
        donde = "v"
        obtenerfecha(dtdesdev, dthastav)
        cargarventa()
    End Sub

    Private Sub ButtonX2_Click(sender As Object, e As EventArgs) Handles ButtonX2.Click
        donde = "cv"
        obtenerfecha(dtdesdecv, dthastacv)
        cargarcantidadmonto()
        cargarventa()
        cargarlbcv()
    End Sub

    Private Sub cargarlbcv()
        lbarticulocv.Text = dtrproductos.Item(1).ToString
        lbcantidadcompra.Text = cantidadc
        lbcantidadventa.Text = cantidadv
        lbmontocompra.Text = totalc
        lbmontoventa.Text = totalv
        Dim r As Double

        r = (totalv * 100) / totalc
        If r >= 100 Then
            Me.lbrecuperacion.ForeColor = Color.Green
        End If
        Me.lbrecuperacion.Text = r.ToString + "%"
    End Sub

    
End Class