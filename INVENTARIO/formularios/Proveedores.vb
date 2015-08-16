Imports pjtAdus.Empresas
Imports logica
Public Class Proveedores

    Dim proveedores As New clsMaestros(clsNomTab.eTbl.Proveedores)
    Dim dtproveedores As DataTable
    Public donde As String
    Public frm As Nuevo_Producto
    Public frmc As compra
    Public frmcambio As Combinar
    Public f As Boolean = True
    Dim cloperaciones As New clsProcesos

    'Definir variables globales; estas van despues de la linea de inherits

    Dim ex, ey As Integer

    Dim Arrastre As Boolean

    'Estas tres subrutinas permiten desplazar el formulario. 

    Private Sub Proveedores_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseDown

        ex = e.X

        ey = e.Y

        Arrastre = True

    End Sub

    Private Sub Proveedores_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseUp

        Arrastre = False

    End Sub

    Private Sub Proveedores_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseMove

        'Si el formulario no tiene borde (FormBorderStyle = none) la siguiente linea funciona bien

        If Arrastre Then Me.Location = Me.PointToScreen(New Point(Control.MousePosition.X - Me.Location.X - ex, Control.MousePosition.Y - Me.Location.Y - ey))

        'pero si quieres dejar los bordes y la barra de titulo entonces es necesario descomentar la siguiente linea y comentar la anterior, osea ponerle el apostrofe

        'If Arrastre Then Me.Location = Me.PointToScreen(New Point(Me.MousePosition.X - Me.Location.X - ex - 8, Me.MousePosition.Y - Me.Location.Y - ey - 60))
        Me.PictureBox3.Visible = True
        Me.PictureBox4.Visible = False
    End Sub


    Public Sub cargargrid()
        Try
            If f Then
                If radiotodo.Checked = True Then
                    dtproveedores = proveedores.Consultar(" where codempresa = " & mdiMain.codigoempresa)
                ElseIf radiojuridico.Checked = True Then
                    dtproveedores = proveedores.Consultar(" where codempresa = " & mdiMain.codigoempresa + " and tipo = 'Contribuyente'")
                ElseIf radionatural.Checked = True Then
                    dtproveedores = proveedores.Consultar(" where codempresa = " & mdiMain.codigoempresa + " and tipo = 'Final'")
                End If
                f = False
            End If
            Dim conativos As Short
            For i As Integer = 0 To dtproveedores.Rows.Count - 1
                If dtproveedores.Rows(i).Item(17) = "inactivo" Then
                    conativos += 1
                End If
            Next

            Dim nf As Short

            nf = dtproveedores.Rows.Count - conativos

            If nf = 0 Then
                Me.gridproveedores.RowCount = 1
                Me.gridproveedores.Rows(0).Cells(0).Value = ""
                Me.gridproveedores.Rows(0).Cells(1).Value = ""
                Me.gridproveedores.Rows(0).Cells(2).Value = ""
                Me.gridproveedores.Rows(0).Cells(3).Value = ""
                Me.gridproveedores.Rows(0).Cells(4).Value = ""
            Else
                Me.gridproveedores.RowCount = nf + 1

            End If

            For i As Integer = 0 To dtproveedores.Rows.Count - 1
                'para el codigo
                If dtproveedores.Rows(i).Item(17) <> "inactivo" Then
                    Me.gridproveedores.Rows(i).Cells(0).Value = dtproveedores.Rows(i).Item(0).ToString
                    Me.gridproveedores.Rows(i).Cells(1).Value = dtproveedores.Rows(i).Item(1).ToString
                    Me.gridproveedores.Rows(i).Cells(2).Value = dtproveedores.Rows(i).Item(6).ToString
                    Me.gridproveedores.Rows(i).Cells(3).Value = dtproveedores.Rows(i).Item(7).ToString
                    Me.gridproveedores.Rows(i).Cells(4).Value = dtproveedores.Rows(i).Item(8).ToString
                End If
            Next

        Catch ex As Exception

        End Try

    End Sub

    Private Sub Proveedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        MdiParent = mdiMain
        Me.gridproveedores.Select()
        cargargrid()
        If donde = "producto" Or donde = "ventas" Or donde = "compras" Or donde = "cambio" Then
            Me.botdetalle.Visible = False
            Me.boteditar.Visible = False
            Me.boteliminar.Visible = False
            Me.botseleccionar.Visible = True
        Else
            Me.botseleccionar.Visible = False
        End If
    End Sub





    Private Sub radionatural_Click(sender As Object, e As EventArgs) Handles radionatural.Click
        f = True
        cargargrid()
    End Sub

    Private Sub radiojuridico_Click(sender As Object, e As EventArgs) Handles radiojuridico.Click
        f = True
        cargargrid()
    End Sub

    Private Sub radiotodo_Click(sender As Object, e As EventArgs) Handles radiotodo.Click
        f = True
        cargargrid()
    End Sub
    Dim varbus As String



    Private Sub texbusqueda_KeyPress(sender As Object, e As KeyPressEventArgs) Handles texbusqueda.KeyPress
        Try
            f = False
            Me.radiotodo.Checked = True
            If (Asc(e.KeyChar) = 13) Then
            Else
                If (Asc(e.KeyChar)) = System.Windows.Forms.Keys.Back Then
                    Dim contvarbus As Short
                    If varbus = "" Then
                    Else
                        contvarbus = varbus.Length
                        varbus = varbus.Remove(contvarbus - 1, 1)
                    End If
                    If radiocodigo.Checked = True Then
                        dtproveedores = proveedores.Consultar(" where codempresa = '" + mdiMain.codigoempresa.ToString + "' and codproveedor like '%" + varbus + "%'")
                    Else
                        dtproveedores = proveedores.Consultar(" where codempresa = '" + mdiMain.codigoempresa.ToString + "' and nombre like '%" + varbus + "%'")
                    End If

                    If dtproveedores.Rows.Count <> 0 Then

                        cargargrid()
                    End If
                Else
                    varbus += e.KeyChar
                    If radiocodigo.Checked = True Then
                        dtproveedores = proveedores.Consultar(" where codempresa = '" + mdiMain.codigoempresa.ToString + "' and codproveedor like '%" + varbus + "%'")
                    Else
                        dtproveedores = proveedores.Consultar(" where codempresa = '" + mdiMain.codigoempresa.ToString + "' and nombre like '%" + varbus + "%'")
                    End If
                    If dtproveedores.Rows.Count <> 0 Then
                        cargargrid()
                    End If
                End If
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub PictureBox3_MouseMove(sender As Object, e As MouseEventArgs) Handles PictureBox3.MouseMove
        Me.PictureBox3.Visible = False
        Me.PictureBox4.Visible = True
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Me.Close()
    End Sub


    Private Sub boteditar_Click_1(sender As Object, e As EventArgs) Handles boteditar.Click
        Dim id As Short = Me.gridproveedores.CurrentCell.RowIndex
        Dim dtprovee As DataRow
        dtprovee = dtproveedores.Rows(id)
        Empresas.dtempresas = dtprovee
        Empresas.controlgrub = 1
        Empresas.donde = "proveedores"
        Empresas.edit = True
        Empresas.frmp = Me
        Empresas.Show()
    End Sub

    Private Sub botdetalle_Click_1(sender As Object, e As EventArgs) Handles botdetalle.Click
        Dim id As Short = Me.gridproveedores.CurrentCell.RowIndex
        Dim dtprovee As DataRow
        dtprovee = dtproveedores.Rows(id)
        DetalleEmpresa.dtempresa = dtprovee
        DetalleEmpresa.donde = "proveedores"
        DetalleEmpresa.Show()
        DetalleEmpresa.frmp = Me
    End Sub

    Private Sub botnuevo_Click_1(sender As Object, e As EventArgs) Handles botnuevo.Click
        Dim frmempresas As New Empresas
        frmempresas.donde = "proveedores"
        frmempresas.frmp = Me
        frmempresas.controlgrub = 1
        frmempresas.Text = "Nuevo Proveedor"
        frmempresas.Show()
    End Sub

    Private Sub botseleccionar_Click_1(sender As Object, e As EventArgs) Handles botseleccionar.Click
        Try
            Dim id As Short = Me.gridproveedores.CurrentCell.RowIndex
            Dim dtrpro As DataRow = dtproveedores.Rows(id)
            If donde = "producto" Then
                frm.dtrprove = dtrpro
                frm.texproveedor.Text = dtrpro.Item(1)
                Me.Close()
            End If

            If donde = "compras" Then
                frmc.dtrproveedor = dtrpro
                frmc.texproveedor.Text = dtrpro.Item(1)
                frmc.idproveedor = dtrpro.Item(0)
                Me.Close()
            End If

            If donde = "cambio" Then
                frmcambio.dtrproveedor = dtrpro
                frmcambio.texnproveedor.Text = dtrpro.Item(1)
                frmcambio.idproveedor = dtproveedores.Rows(id).Item(0)
                Me.Close()
            End If
        Catch ex As Exception
            MsgBox("Ocurrio un error asegurece de haber llenado todos los campos correctamente", MsgBoxStyle.OkOnly, "Aviso")
        End Try
    End Sub

    Private Sub boteliminar_Click(sender As Object, e As EventArgs) Handles boteliminar.Click
        Try
            Dim id As String = Me.gridproveedores.CurrentCell.RowIndex
            id = dtproveedores.Rows(id).Item(0).ToString
            If MsgBox("Seguro que quiere eliminar el Proveedor ", MsgBoxStyle.YesNo, "___....:::: AVISO :::...___") = MsgBoxResult.Yes Then
                cloperaciones.Consultar("UPDATE proveedor SET estado='inactivo' where codproveedor=" & id)
                cargargrid()
                MsgBox("El Proveedor se elimino exitozamente: ", MsgBoxStyle.Information, "Exito")
            End If
        Catch ex As Exception

        End Try
    End Sub

  

    'Private Sub gridproveedores_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles gridproveedores.CellEnter
    '    botseleccionar_Click_1(sender, e)
    'End Sub


    Private Sub gridproveedores_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles gridproveedores.CellDoubleClick
        botseleccionar_Click_1(sender, e)
    End Sub


    Dim idglobal As Short
    Private Sub gridproveedores_KeyPress(sender As Object, e As KeyPressEventArgs) Handles gridproveedores.KeyPress
        If (Asc(e.KeyChar)) = 13 Then
            If donde = "compras" Then

                Dim id As Short = Me.gridproveedores.CurrentCell.RowIndex - 1
              

                Dim dtrpro As DataRow = dtproveedores.Rows(id)
                frmc.dtrproveedor = dtrpro
                frmc.texproveedor.Text = dtrpro.Item(1)
                Me.Close()
            End If
        End If

    End Sub

 
End Class