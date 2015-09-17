Imports logica
Public Class Clientes
    Dim tclientes As New clsMaestros(clsNomTab.eTbl.Clientes)
    Dim dtclientes As DataTable
    Dim dtrclientes As DataRow
    Dim cloperaciones As New clsProcesos

    Dim tclientesf As New clsMaestros(clsNomTab.eTbl.clientescf)



    Public donde As String
    Public frmv As Ventas
    Public f As Boolean = True

    'contador de activos e inactivos
    Private conativos As Short
    'Definir variables globales; estas van despues de la linea de inherits

    Dim ex, ey As Integer

    Dim Arrastre As Boolean

    'Estas tres subrutinas permiten desplazar el formulario. 

    Private Sub Clientes_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseDown
        ex = e.X

        ey = e.Y

        Arrastre = True

    End Sub

    Private Sub Clientes_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseUp

        Arrastre = False

    End Sub

    Private Sub Clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

            If donde = "ventas" Then
                ocultar()
            Else
                MdiParent = mdiMain
            End If
            cargargrid()
        Catch ex As Exception
            MsgBox("Ocurrio un error asegurese de haber llenado todos los campo correctamente", MsgBoxStyle.OkOnly, "Avise")
        End Try

    End Sub
    Private Sub ocultar()
        Try
            Me.botdetalle.Visible = False
            Me.boteliminar.Visible = False
            Me.botseleccionar.Visible = True
            Me.boteditar.Visible = False
        Catch ex As Exception
            MsgBox("Ocurrio un error asegurese de haber llenado todos los campo correctamente", MsgBoxStyle.OkOnly, "Avise")
        End Try

    End Sub


    Public Sub cargargrid()
        Try
            If f Then

                If radiojuridico.Checked = True Then
                    dtclientes = tclientes.Consultar()
                ElseIf radionatural.Checked = True Then
                    dtclientes = tclientesf.Consultar()
                End If
                f = False
            End If

            If Me.radionatural.Checked <> True Then
                For z As Integer = 0 To dtclientes.Rows.Count - 1
                    If dtclientes.Rows(z).Item(9) = "inactivo" Then
                        conativos += 1
                    End If
                Next
            End If


            Dim nf As Short
            If Me.radionatural.Checked = True Then
                nf = dtclientes.Rows.Count
            Else
                nf = dtclientes.Rows.Count - conativos
            End If

            If nf = 0 Then
                Me.gridclientes.RowCount = 1
                Me.gridclientes.Rows(0).Cells(0).Value = ""
                Me.gridclientes.Rows(0).Cells(1).Value = ""
                Me.gridclientes.Rows(0).Cells(2).Value = ""
                Me.gridclientes.Rows(0).Cells(3).Value = ""
            Else
                Me.gridclientes.RowCount = nf
            End If
            Dim i As Integer = 0
            For e As Integer = 0 To nf - 1
                If Me.radionatural.Checked <> True Then
                    If dtclientes.Rows(i).Item(9) <> "inactivo" Then
                        Me.gridclientes.Rows(e).Cells(0).Value = dtclientes.Rows(i).Item(0).ToString
                        Me.gridclientes.Rows(e).Cells(1).Value = dtclientes.Rows(i).Item(1).ToString
                        Me.gridclientes.Rows(e).Cells(2).Value = dtclientes.Rows(i).Item(6).ToString
                        Me.gridclientes.Rows(e).Cells(3).Value = dtclientes.Rows(i).Item(5).ToString
                    Else
                        i += 1
                        Me.gridclientes.Rows(e).Cells(0).Value = dtclientes.Rows(i).Item(0).ToString
                        Me.gridclientes.Rows(e).Cells(1).Value = dtclientes.Rows(i).Item(1).ToString
                        Me.gridclientes.Rows(e).Cells(2).Value = dtclientes.Rows(i).Item(6).ToString
                        Me.gridclientes.Rows(e).Cells(3).Value = dtclientes.Rows(i).Item(5).ToString
                    End If
                    i += 1
                Else
                    Me.gridclientes.Rows(e).Cells(0).Value = dtclientes.Rows(i).Item(0).ToString
                    Me.gridclientes.Rows(e).Cells(1).Value = dtclientes.Rows(i).Item(1).ToString
                    Me.gridclientes.Rows(e).Cells(2).Value = ""
                    Me.gridclientes.Rows(e).Cells(3).Value = ""
                    i += 1
                End If

            Next
        Catch ex As Exception
            MsgBox("Ocurrio un error asegurese de haber llenado todos los campo correctamente", MsgBoxStyle.OkOnly, "Avise")
        End Try

    End Sub



    Private Sub radiotodo_Click(sender As Object, e As EventArgs)
        Try
            f = True
            cargargrid()
        Catch ex As Exception
            MsgBox("Ocurrio un error asegurese de haber llenado todos los campo correctamente", MsgBoxStyle.OkOnly, "Avise")
        End Try

    End Sub

    Private Sub radionatural_Click(sender As Object, e As EventArgs) Handles radionatural.Click
        Try
            f = True
            cargargrid()
        Catch ex As Exception
            MsgBox("Ocurrio un error asegurese de haber llenado todos los campo correctamente", MsgBoxStyle.OkOnly, "Avise")
        End Try

    End Sub

    Private Sub radiojuridico_Click(sender As Object, e As EventArgs) Handles radiojuridico.Click
        Try
            f = True
            cargargrid()
        Catch ex As Exception
            MsgBox("Ocurrio un error asegurese de haber llenado todos los campo correctamente", MsgBoxStyle.OkOnly, "Avise")
        End Try

    End Sub
    Dim varbus As String

 

    Private Sub texbusqueda_KeyPress(sender As Object, e As KeyPressEventArgs) Handles texbusqueda.KeyPress
        Try
            f = False
            If radiojuridico.Checked Then
                If (Asc(e.KeyChar) = 13) Then
                Else
                    If (Asc(e.KeyChar)) = System.Windows.Forms.Keys.Back Then
                        Dim contvarbus As Short
                        If varbus = "" Then
                        Else
                            contvarbus = varbus.Length
                            varbus = varbus.Remove(contvarbus - 1, 1)
                        End If
                        dtclientes = tclientes.Consultar(" where codcliente like '%" + varbus + "%' or nombre like '%" + varbus + "%'")


                        If dtclientes.Rows.Count <> 0 Then

                            cargargrid()
                        End If
                    Else
                        varbus += e.KeyChar
                        dtclientes = tclientes.Consultar(" where codcliente like '%" + varbus + "%' or nombre like '%" + varbus + "%'")

                        If dtclientes.Rows.Count <> 0 Then

                            cargargrid()
                        End If
                    End If
                End If
            Else
                If (Asc(e.KeyChar) = 13) Then
                Else
                    If (Asc(e.KeyChar)) = System.Windows.Forms.Keys.Back Then
                        Dim contvarbus As Short
                        If varbus = "" Then
                        Else
                            contvarbus = varbus.Length
                            varbus = varbus.Remove(contvarbus - 1, 1)
                        End If
                        dtclientes = tclientesf.Consultar(" where idclientescf like '%" + varbus + "%' or cliente like '%" + varbus + "%'")


                        If dtclientes.Rows.Count <> 0 Then

                            cargargrid()
                        End If
                    Else
                        varbus += e.KeyChar
                        dtclientes = tclientesf.Consultar(" where idclientescf like '%" + varbus + "%' or cliente like '%" + varbus + "%'")

                        If dtclientes.Rows.Count <> 0 Then

                            cargargrid()
                        End If
                    End If
                End If
            End If
           
        Catch ex As Exception
            MsgBox("Ocurrio un error asegurese de haber llenado todos los campo correctamente", MsgBoxStyle.OkOnly, "Avise")
        End Try


    End Sub
  
    Private Sub botnuevo_Click(sender As Object, e As EventArgs) Handles botnuevo.Click

        Try
            Empresas.donde = "clientes"
            Empresas.frmc = Me
            Empresas.controlgrub = 1
            Empresas.Text = "Nuevo Cliente"
            Empresas.Show()
            Me.Visible = False
        Catch ex As Exception
            MsgBox("Ocurrio un error asegurese de haber llenado todos los campo correctamente", MsgBoxStyle.OkOnly, "Avise")
        End Try
    End Sub

    Private Sub boteditar_Click_1(sender As Object, e As EventArgs) Handles boteditar.Click
        Try
            Dim id As Short = Me.gridclientes.CurrentCell.RowIndex
            dtrclientes = dtclientes.Rows(id)
            Empresas.dtempresas = dtrclientes
            Empresas.controlgrub = 1
            Empresas.donde = "clientes"
            Empresas.frmc = Me
            Empresas.edit = True
            Empresas.Show()
            Me.Visible = False
        Catch ex As Exception
            MsgBox("Ocurrio un error asegurese de haber llenado todos los campo correctamente", MsgBoxStyle.OkOnly, "Avise")
        End Try
    End Sub

    Private Sub botdetalle_Click_1(sender As Object, e As EventArgs) Handles botdetalle.Click

        Try
            Dim id As Short = Me.gridclientes.CurrentCell.RowIndex
            dtrclientes = dtclientes.Rows(id)
            DetalleEmpresa.dtempresa = dtrclientes
            DetalleEmpresa.donde = "clientes"
            DetalleEmpresa.frmc = Me
            DetalleEmpresa.Show()
        Catch ex As Exception
            MsgBox("Ocurrio un error asegurese de haber llenado todos los campo correctamente", MsgBoxStyle.OkOnly, "Avise")
        End Try
    End Sub

    Private Sub boteliminar_Click_1(sender As Object, e As EventArgs) Handles boteliminar.Click
        Try
            Dim id As String = Me.gridclientes.CurrentCell.RowIndex
            id = dtclientes.Rows(id).Item(0).ToString
            If MsgBox("Seguro que quiere eliminar el Cliente ", MsgBoxStyle.YesNo, "___....:::: AVISO :::...___") = MsgBoxResult.Yes Then
                cloperaciones.Consultar("UPDATE cliente SET estado='inactivo' where codcliente=" & id)
                f = True
                cargargrid()
                MsgBox("El Cliente se elimino exitozamente: ", MsgBoxStyle.Information, "Exito")
            End If
        Catch ex As Exception
            MsgBox("Ocurrio un error asegurese de haber llenado todos los campo correctamente", MsgBoxStyle.OkOnly, "Avise")
        End Try
    End Sub

    Private Sub botseleccionar_Click_1(sender As Object, e As EventArgs) Handles botseleccionar.Click, botseleccionar.Enter
        Try
            Dim id As Short = Me.gridclientes.CurrentCell.RowIndex
            dtrclientes = dtclientes.Rows(id)
            frmv.dtrclientes = dtrclientes
            frmv.texcliente.Text = dtrclientes.Item(1).ToString
            frmv.idcliente = dtrclientes.Item(0).ToString
            Me.Close()
        Catch ex As Exception
            MsgBox("Ocurrio un error asegurese de haber llenado todos los campo correctamente", MsgBoxStyle.OkOnly, "Avise")
        End Try
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub


    'Private Sub PictureBox3_MouseMove(sender As Object, e As MouseEventArgs)
    '    Me.PictureBox3.Visible = False
    '    Me.PictureBox4.Visible = True
    'End Sub

    'Private Sub Clientes_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
    '    If Arrastre Then Me.Location = Me.PointToScreen(New Point(Control.MousePosition.X - Me.Location.X - ex, Control.MousePosition.Y - Me.Location.Y - ey))


    '    Me.PictureBox4.Visible = False
    '    Me.PictureBox3.Visible = True
    'End Sub

   
    
    Private Sub texbusqueda_TextChanged(sender As Object, e As EventArgs) Handles texbusqueda.TextChanged

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class