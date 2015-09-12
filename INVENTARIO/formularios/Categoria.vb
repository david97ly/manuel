Imports logica
Public Class Categoria
    Public donde As String = ""
    Private categoria As New clsMaestros(clsNomTab.eTbl.Categorias)
    Private dtcategoria As DataTable
    Private idmod As String
    Private modificar As Boolean = False
    Public frmprod As Nuevo_Producto
    Public frmcambio As Combinar
    Private Sub Categoria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargargrid()
    End Sub

    Private Sub cargargrid()
        Try
            dtcategoria = categoria.Consultar()
            Dim nf As Short
            nf = dtcategoria.Rows.Count

            If nf = 0 Then
                Me.DataGridView1.RowCount = 1
            Else
                Me.DataGridView1.RowCount = nf
            End If
            For i As Integer = 0 To dtcategoria.Rows.Count - 1

                Me.DataGridView1.Rows(i).Cells(0).Value = dtcategoria.Rows(i).Item(0).ToString

                Me.DataGridView1.Rows(i).Cells(1).Value = dtcategoria.Rows(i).Item(1).ToString

                Me.DataGridView1.Rows(i).Cells(2).Value = dtcategoria.Rows(i).Item(2).ToString
            Next
            Me.boteliminar.Visible = True
            Me.botmodificar.Visible = True
            Me.botnuevo.Visible = True
            Me.botseleccionar.Visible = True
            Me.DataGridView1.Visible = True
        Catch ex As Exception
            MsgBox("Ocurrio un error asegurese de haber llenado todos los campo correctamente", MsgBoxStyle.OkOnly, "Avise")
        End Try
    End Sub

    Private Sub botnuevo_Click(sender As Object, e As EventArgs) Handles botnuevo.Click
        ocultar()
    End Sub

    Private Sub ocultar()
        Try
            Me.boteliminar.Visible = False
            Me.botmodificar.Visible = False
            Me.botnuevo.Visible = False
            Me.botseleccionar.Visible = False
            Me.DataGridView1.Visible = False
        Catch ex As Exception
            MsgBox("Ocurrio un error asegurese de haber llenado todos los campo correctamente", MsgBoxStyle.OkOnly, "Avise")
        End Try
    End Sub
    Private Sub botGuardar_Click(sender As Object, e As EventArgs) Handles botGuardar.Click
        Try
            If vacio() = True Then
                If modificar = True Then
                    actualizardatos()
                Else
                    insertardatos()
                End If
                cargargrid()
            End If
        Catch ex As Exception
            MsgBox("Ocurrio un error asegurese de haber llenado todos los campo correctamente", MsgBoxStyle.OkOnly, "Avise")
        End Try
    End Sub

    Private Function vacio() As Boolean
        Try
            Dim n As Boolean = True
            Dim d As Boolean = True

            If Me.texnombre.Text.ToString = "" Then
                Me.lcamposobligatorios.ForeColor = Color.Red
                Me.ln.ForeColor = Color.Red
                n = False
            Else
                Me.ln.ForeColor = Color.Black
                n = True
            End If


            If Me.texdescripcion.Text.ToString = "" Then
                Me.lcamposobligatorios.ForeColor = Color.Red
                Me.ld.ForeColor = Color.Red
                d = False
            Else
                Me.ld.ForeColor = Color.Black
                d = True
            End If

            If n = True And d = True Then
                Me.lcamposobligatorios.ForeColor = Color.Black
                Return True
            End If
        Catch ex As Exception
            MsgBox("Ocurrio un error asegurese de haber llenado todos los campo correctamente", MsgBoxStyle.OkOnly, "Avise")
        End Try


    End Function
    Private Sub insertardatos()
        Try
            categoria.Insertar("'" + Me.texnombre.Text.ToString.Trim + "','" + Me.texdescripcion.Text.ToString.Trim + "'")
            MsgBox("La categoria se inserto Exitozamente", MsgBoxStyle.Information, "Exito")
        Catch ex As Exception
            MsgBox("Ocurrio un error al insertar la categoria razon: " + ex.Message, MsgBoxStyle.Critical, "Aviso")
        End Try

    End Sub
    Private Sub actualizardatos()
        Try
            categoria.Actualizar(idmod + "|'" + Me.texnombre.Text.ToString.Trim + "'|'" + Me.texdescripcion.Text.ToString.Trim + "'")
            MsgBox("La categoria se modifico Exitozamente", MsgBoxStyle.Information, "Exito")
        Catch ex As Exception
            MsgBox("Ocurrio un error al modificar la categoria razon: " + ex.Message, MsgBoxStyle.Critical, "Aviso")
        End Try
    End Sub

    Private Sub botmodificar_Click(sender As Object, e As EventArgs) Handles botmodificar.Click
        Try
            Dim id As Short = Me.DataGridView1.CurrentCell.RowIndex
            Me.texnombre.Text = dtcategoria.Rows(id).Item(1).ToString
            Me.texdescripcion.Text = dtcategoria.Rows(id).Item(2).ToString
            Me.idmod = dtcategoria.Rows(id).Item(0)
            modificar = True
            ocultar()
        Catch ex As Exception
            MsgBox("Ocurrio un error asegurese de haber llenado todos los campo correctamente", MsgBoxStyle.OkOnly, "Avise")
        End Try

    End Sub

    Private Sub boteliminar_Click(sender As Object, e As EventArgs) Handles boteliminar.Click
        Try
            Dim id As Short = Me.DataGridView1.CurrentCell.RowIndex
            If MsgBox("Seguro que quiere eliminar la categoria ", MsgBoxStyle.YesNo, "___....:::: AVISO :::...___") = MsgBoxResult.Yes Then
                categoria.Eliminar(dtcategoria.Rows(id).Item(0))
                cargargrid()
                MsgBox("La Categoria se elimino exitozamente: ", MsgBoxStyle.Information, "Exito")
            End If
        Catch ex As Exception
            MsgBox("Ocurrio un error a la hora de eliminar la caterogira", MsgBoxStyle.OkOnly, "Avise")
        End Try

    End Sub

    Private Sub botseleccionar_Click(sender As Object, e As EventArgs) Handles botseleccionar.Click
        Try
            Dim id As Short = Me.DataGridView1.CurrentCell.RowIndex
            Dim dtrcate1 As DataRow = dtcategoria.Rows(id)
            If donde = "producto" Then

                frmprod.dtrcate = dtrcate1
                frmprod.texcategoria.Text = dtrcate1.Item(1)
                Me.Close()
            ElseIf donde = "cambio" Then
                frmcambio.dtrcate = dtrcate1
                frmcambio.texncategoria.Text = dtrcate1.Item(1)
                frmcambio.idcategoria = dtcategoria.Rows(id).Item(0)
                Me.Close()
            End If
        Catch ex As Exception
            MsgBox("Ocurrio un error asegurese de haber llenado todos los campo correctamente", MsgBoxStyle.OkOnly, "Avise")
        End Try

    End Sub

    Private Sub botsalir_Click(sender As Object, e As EventArgs) Handles botsalir.Click
        Me.Close()
    End Sub

    
End Class