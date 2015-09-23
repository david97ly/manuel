Imports logica
Public Class Configuraciones
    Dim tiraje As New clsMaestros(clsNomTab.eTbl.tiraje)
    Dim dttiraje As DataTable
    Dim tirajeeliminar As New clsProcesos

    Private Sub Configuraciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenartirajes()
    End Sub

    Private Sub llenartirajes()
        Try
            dttiraje = tiraje.Consultar()
            If dttiraje.Rows.Count <> 0 Then
                

                Dim resultado1 As Integer = CInt(dttiraje.Rows(0).Item(4)) * 100
                resultado1 /= CInt(dttiraje.Rows(0).Item(3))

                Me.progresf.Value = resultado1

                Me.texdedef.Text = dttiraje.Rows(0).Item(1) + dttiraje.Rows(0).Item(2).ToString
                Me.texhastaf.Text = dttiraje.Rows(0).Item(1) + dttiraje.Rows(0).Item(3).ToString
                Me.texactualf.Text = dttiraje.Rows(0).Item(4).ToString


                ''aqui comienza el calculo para las de comprobantes



               
                Dim resultado2 As Integer = CInt(dttiraje.Rows(0).Item(8)) * 100
                resultado2 /= CInt(dttiraje.Rows(0).Item(7))

                Me.progresccf.Value = resultado2

                Me.texdesdeccf.Text = dttiraje.Rows(0).Item(5) + dttiraje.Rows(0).Item(6).ToString
                Me.texhastaccf.Text = dttiraje.Rows(0).Item(5) + dttiraje.Rows(0).Item(7).ToString
                Me.texactualccf.Text = dttiraje.Rows(0).Item(8).ToString
            End If

        Catch ex As Exception

        End Try


    End Sub

    Private Sub bothechof_Click(sender As Object, e As EventArgs) Handles bothechof.Click

        Dim tirajedesde As String = Me.texndesdef.Text.Trim.ToString
        Dim tirajehasta As String = Me.texnhastaf.Text.Trim.ToString

        Dim Ndesdef As String = ""
        Dim Nhastaf As String = ""
        Dim tirajefactura As String = ""
        Dim esnumerof As Boolean = True
        Dim esnumeroc As Boolean = True

        tirajedesde = StrReverse(tirajedesde)
        tirajehasta = StrReverse(tirajehasta)

        For i As Integer = 0 To tirajedesde.Length - 1

            If IsNumeric(tirajedesde(i)) And esnumerof Then
                Ndesdef += tirajedesde(i).ToString
            Else
                tirajefactura += tirajedesde(i).ToString
                esnumerof = False
            End If

        Next


        For i As Integer = 0 To tirajehasta.Length - 1

            If IsNumeric(tirajehasta(i)) And esnumeroc Then
                Nhastaf += tirajehasta(i).ToString
            Else
                esnumeroc = False
            End If

        Next

        Ndesdef = StrReverse(Ndesdef)
        Nhastaf = StrReverse(Nhastaf)
        tirajefactura = StrReverse(tirajefactura)



        Me.Width = 594
     

        tirajeeliminar.Consultar(" Update tirajes set tirajefs = '" & tirajefactura & "', tirajefd ='" & Ndesdef & "',tirajefh ='" & Nhastaf & "', tirajefa ='" & CInt(Ndesdef).ToString & "' where idtiraje =1")
    End Sub

    Private Sub bothechoccf_Click(sender As Object, e As EventArgs) Handles bothechoccf.Click
        Dim tirajedesde As String = Me.texndesdeccf.Text.Trim.ToString
        Dim tirajehasta As String = Me.texnhastaccf.Text.Trim.ToString

        Dim Ndesdef As String = ""
        Dim Nhastaf As String = ""
        Dim tirajefactura As String = ""
        Dim esnumerof As Boolean = True
        Dim esnumeroc As Boolean = True

        tirajedesde = StrReverse(tirajedesde)
        tirajehasta = StrReverse(tirajehasta)

        For i As Integer = 0 To tirajedesde.Length - 1

            If IsNumeric(tirajedesde(i)) And esnumerof Then
                Ndesdef += tirajedesde(i).ToString
            Else
                tirajefactura += tirajedesde(i).ToString
                esnumerof = False
            End If

        Next


        For i As Integer = 0 To tirajehasta.Length - 1

            If IsNumeric(tirajehasta(i)) And esnumeroc Then
                Nhastaf += tirajehasta(i).ToString
            Else
                esnumeroc = False
            End If

        Next

        Ndesdef = StrReverse(Ndesdef)
        Nhastaf = StrReverse(Nhastaf)
        tirajefactura = StrReverse(tirajefactura)



        Me.Width = 594



        tirajeeliminar.Consultar(" Update tirajes set tirajecs = ' " & tirajefactura & "',tirajecd ='" & Ndesdef & "',tirajech = '" & Nhastaf & "', tirajeca = '" & (CInt(Ndesdef)).ToString & "' where idtiraje = 1")
    End Sub

    Private Sub botnfacturas_Click(sender As Object, e As EventArgs) Handles botnfacturas.Click
        Me.Width = 1016
    End Sub

    Private Sub botnccf_Click(sender As Object, e As EventArgs) Handles botnccf.Click
        Me.Width = 1016
    End Sub
End Class