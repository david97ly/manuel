Imports logica
Imports System.Windows.Forms
Public Class Inicio
    Dim dtempresa As DataTable
    Dim codigoe As String
    Private Sub Inicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargargrid()
    End Sub

    Private Sub cargargrid()


        Dim nf As Short

        nf = dtempresa.Rows.Count
     
            If nf = 0 Then
                Me.dataempresa.RowCount = 1
            Else
                Me.dataempresa.RowCount = nf
            End If

            For i As Integer = 0 To dtempresa.Rows.Count - 1
                'para el codigo
                Me.dataempresa.Rows(i).Cells(0).Value = dtempresa.Rows(i).Item(0).ToString
                Me.dataempresa.Rows(i).Cells(1).Value = dtempresa.Rows(i).Item(1).ToString
                Me.dataempresa.Rows(i).Cells(2).Value = dtempresa.Rows(i).Item(6).ToString
                Me.dataempresa.Rows(i).Cells(3).Value = dtempresa.Rows(i).Item(7).ToString
            Next


    End Sub




    Private Sub botseleccionar_Click_1(sender As Object, e As EventArgs) Handles botseleccionar.Click
        Try
            Dim id As String = Me.dataempresa.CurrentCell.RowIndex

            codigoe = dtempresa.Rows(id).Item(0)

            mdiMain.codigoempresa = codigoe
            mdiMain.Opacity = 100
            Me.Close()
            mdiMain.cargarmenu()
        Catch ex As Exception
            MsgBox("No se a podido acceder a la empresa razon: " + ex.Message, MsgBoxStyle.Critical, "Aviso")


        End Try
    End Sub

    Private Sub botsalir_Click_1(sender As Object, e As EventArgs) Handles botsalir.Click
        Me.Close()
        mdiMain.Close()
    End Sub
End Class