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
                Dim desdef As String = dttiraje.Rows(0).Item(2).ToString

                Dim hastaf As String = dttiraje.Rows(0).Item(3).ToString

                Dim actualf As String = dttiraje.Rows(0).Item(4).ToString

                Dim numd As String = ""
                Dim numh As String = ""

                Dim rangof As Integer = 0

                For i As Integer = 0 To desdef.Length - 1

                    If i > 7 Then
                        numd += desdef(i)
                    End If

                Next


                For i As Integer = 0 To hastaf.Length - 1

                    If i > 7 Then
                        numh += hastaf(i)
                    End If

                Next

                rangof = CInt(numh) - CInt(numd)


                Dim resultado1 As Integer = CInt(actualf) * 100
                resultado1 /= rangof

                Me.progresf.Value = resultado1

                Me.texdedef.Text = dttiraje.Rows(0).Item(2).ToString
                Me.texhastaf.Text = dttiraje.Rows(0).Item(3).ToString
                Me.texactualf.Text = dttiraje.Rows(0).Item(4).ToString


                ''aqui comienza el calculo para las de comprobantes


                Dim desdec As String = dttiraje.Rows(0).Item(6).ToString

                Dim hastac As String = dttiraje.Rows(0).Item(7).ToString

                Dim actualc As String = dttiraje.Rows(0).Item(8).ToString

                Dim numdc As String = ""
                Dim numhc As String = ""

                Dim rangoc As Integer = 0

                For i As Integer = 0 To desdec.Length - 1

                    If i > 7 Then
                        numdc += desdec(i)
                    End If

                Next


                For i As Integer = 0 To hastac.Length - 1

                    If i > 7 Then
                        numhc += hastac(i)
                    End If

                Next

                rangoc = CInt(numhc) - CInt(numdc)


                Dim resultado2 As Integer = CInt(actualc) * 100
                resultado2 /= rangoc

                Me.progresccf.Value = resultado2

                Me.texdesdeccf.Text = dttiraje.Rows(0).Item(6).ToString
                Me.texhastaccf.Text = dttiraje.Rows(0).Item(7).ToString
                Me.texactualccf.Text = dttiraje.Rows(0).Item(8).ToString
            End If

        Catch ex As Exception

        End Try


    End Sub

    Private Sub bothechof_Click(sender As Object, e As EventArgs) Handles bothechof.Click
        Me.Width = 594
        Dim str As String = ""
        Dim str1 As String = CStr(Me.texndesdef.Text.Trim.ToString)
        Dim num As String = ""

        For i As Integer = 0 To str1.Length - 1

            If i > 7 Then
                num += str1(i)
            Else
                str += str1(i)
            End If

        Next

        Dim num1 As Integer = CInt(num)
        num1 -= 1


        tirajeeliminar.Consultar(" Update tirajes set tirajefs = '" & str & "', tirajefd ='" & Me.texndesdef.Text.Trim.ToString & "',tirajefh ='" & Me.texnhastaf.Text.Trim.ToString & "', tirajefa ='" & num1 & "' where idtiraje =1")
    End Sub

    Private Sub bothechoccf_Click(sender As Object, e As EventArgs) Handles bothechoccf.Click
        Me.Width = 594

        Dim str As String = ""
        Dim str1 As String = CStr ( Me.texndesdeccf .Text.Trim .ToString)
        Dim num As String = ""

        For i As Integer = 0 To str1.Length - 1

            If i > 7 Then
                num += str1(i)
            Else
                str += str1(i)
            End If

        Next

        Dim num1 As Integer = CInt(num)
        num1 -= 1


        tirajeeliminar.Consultar(" Update tirajes set tirajecs = ' " & str & "',tirajecd ='" & Me.texndesdeccf.Text.Trim.ToString & "',tirajech = '" & Me.texnhastaccf.Text.Trim.ToString & "', tirajeca = '" & num1 & "' where idtiraje = 1")
    End Sub

    Private Sub botnfacturas_Click(sender As Object, e As EventArgs) Handles botnfacturas.Click
        Me.Width = 1016
    End Sub

    Private Sub botnccf_Click(sender As Object, e As EventArgs) Handles botnccf.Click
        Me.Width = 1016
    End Sub
End Class