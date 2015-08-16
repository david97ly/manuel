Imports logica
Imports System.IO.StreamWriter
Imports System.IO
Public Class Productos
   
    Dim dtrtabla As DataRow
    Dim dtproveedor As DataTable
    Dim dtproveedor1 As DataTable
    Dim tproveedor As New clsMaestros(clsNomTab.eTbl.Proveedores)
    Dim tproductos As New clsMaestros(clsNomTab.eTbl.Productos)
    Dim dtproductos As DataTable
    Public donde As String
    'datos de ventas
    Public frmv As Ventas
    Public frmc As compra
    Public frmk As Kardex

    Public frmcambio As Combinar
    Private codproveedor As String
    Public f As Boolean = True
    'termina datos ventas

    Dim consulta1 As New clsProcesos

    'para los tanques
    Dim ttanques As New clsMaestros(clsNomTab.eTbl.Tanques)
    Dim dttanques As DataTable

    'para las bombas
    Dim ttanques1 As New clsMaestros(clsNomTab.eTbl.Bombas)


    'para los respaldos
    Dim carpeta As New FolderBrowserDialog
    Dim consultar As New clsProcesos



    Private Sub Productos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.gridproductos.Select()
        Me.botanalizar.Visible = False
        Me.botSeguir.Visible = False

        Try

            Me.comboprovee.Visible = False
            If donde = "ventas" Or donde = "compras" Or donde = "cambio" Or donde = "kardex" Then
                ocultar()
            End If
            cargargrid()
        Catch ex As Exception

        End Try

    End Sub
    Private Sub ocultar()
        Me.botseleccionar.Visible = True
        Me.botdetalle.Visible = False
        Me.boteditar.Visible = False
        Me.botSeguir.Visible = False
        Me.botanalizar.Visible = False
    End Sub
    Public Sub cargargrid()
        Try
            If f Then
                If radioproveedor.Checked = True Then
                    dtproductos = tproductos.Consultar(" where codempresa = " + mdiMain.codigoempresa.ToString + " and codproveedor = '" + codproveedor + "'")
                ElseIf radiotodos.Checked = True Then
                    dtproductos = tproductos.Consultar(" where codempresa = " + mdiMain.codigoempresa.ToString)
                End If
                f = False
            End If
        Catch ex As Exception

        End Try


        Try

            Dim nf As Short
            nf = dtproductos.Rows.Count

            If nf = 0 Then
                Me.gridproductos.RowCount = 1
                Me.gridproductos.Rows(0).Cells(0).Value = ""
                Me.gridproductos.Rows(0).Cells(1).Value = ""
                Me.gridproductos.Rows(0).Cells(2).Value = ""
                Me.gridproductos.Rows(0).Cells(3).Value = ""
                Me.gridproductos.Rows(0).Cells(4).Value = ""
                Me.gridproductos.Rows(0).Cells(5).Value = ""
                Me.gridproductos.Rows(0).Cells(6).Value = ""
            Else
                Me.gridproductos.RowCount = nf
            End If

            For i As Integer = 0 To dtproductos.Rows.Count - 1

                Me.gridproductos.Rows(i).Cells(0).Value = dtproductos.Rows(i).Item(0).ToString
                Me.gridproductos.Rows(i).Cells(1).Value = dtproductos.Rows(i).Item(1).ToString
                Me.gridproductos.Rows(i).Cells(2).Value = dtproductos.Rows(i).Item(2).ToString
                dtproveedor = tproveedor.Consultar(" where codproveedor = " + dtproductos.Rows(i).Item(9).ToString)
                If dtproveedor.Rows(0).Item(17) = "inactivo" Then
                    Me.gridproductos.Rows(i).Cells(3).Style.BackColor = Color.Red
                Else
                    Me.gridproductos.Rows(i).Cells(3).Style.BackColor = Color.White
                End If
                Me.gridproductos.Rows(i).Cells(3).Value = dtproveedor.Rows(0).Item(1)
                Me.gridproductos.Rows(i).Cells(4).Value = dtproductos.Rows(i).Item(10).ToString
                Me.gridproductos.Rows(i).Cells(5).Value = dtproductos.Rows(i).Item(5).ToString
                Me.gridproductos.Rows(i).Cells(6).Value = dtproductos.Rows(i).Item(6).ToString
            Next
        Catch ex As Exception
            MsgBox("Ocurrio el siguiente error a la hora de llenar el grid: " + ex.Message, MsgBoxStyle.Critical, "Aviso")
        End Try

    End Sub

    Private Sub ocultarbot()
        Me.botdetalle.Visible = False
        Me.boteditar.Visible = False
        Me.botseleccionar.Visible = True
    End Sub

    Private Sub radioproveedor_CheckedChanged(sender As Object, e As EventArgs) Handles radioproveedor.CheckedChanged
        If radioproveedor.Checked = True Then
            Me.comboprovee.Visible = True
            cargarprov()
        Else
            Me.comboprovee.Visible = False
        End If
    End Sub

    Private Sub cargarprov()
        Try
            dtproveedor1 = tproveedor.Consultar(" where codempresa = '" + mdiMain.codigoempresa.ToString + "'")
            Me.comboprovee.Items.Clear()
            For i As Integer = 0 To dtproveedor1.Rows.Count - 1
                Me.comboprovee.Items.Add(dtproveedor1.Rows(i).Item(1))
            Next
        Catch ex As Exception

        End Try

    End Sub
  


    Private Sub radiotodos_Click(sender As Object, e As EventArgs) Handles radiotodos.Click
        f = True
        cargargrid()
    End Sub

    Private Sub checporprecio_CheckedChanged(sender As Object, e As EventArgs) Handles checporprecio.CheckedChanged
        If Me.checporprecio.Checked = True Then
            Me.grubprecios.Visible = True
        Else
            Me.grubprecios.Visible = False
        End If
    End Sub

    Private Sub botbuscar_Click(sender As Object, e As EventArgs) Handles botbuscar.Click
        Try
            f = False
            If radioproveedor.Checked = True Then
                dtproductos = tproductos.Consultar(" where codempresa = " + mdiMain.codigoempresa.ToString + " and precio_unit >= " + CDbl(Me.tesdesde.Text).ToString + " and precio_unit <= " + CDbl(Me.texhasta.Text).ToString + " and codproveedor = " + codproveedor)
            Else
                dtproductos = tproductos.Consultar(" where codempresa = " + mdiMain.codigoempresa.ToString + " and precio_unit >= " + CDbl(Me.tesdesde.Text).ToString + " and precio_unit <= " + CDbl(Me.texhasta.Text).ToString)
            End If

            cargargrid()
        Catch ex As Exception

        End Try

    End Sub
    Dim varbus As String
    Private Sub texbusquedacodigonombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles texbusquedacodigonombre.KeyPress
        Try
            f = False
            Me.radiotodos.Checked = True
            If (Asc(e.KeyChar) = 13) Then
            Else
                If (Asc(e.KeyChar)) = System.Windows.Forms.Keys.Back Then
                    Dim contvarbus As Short
                    If varbus = "" Then
                        dtproductos = tproductos.Consultar(" where codempresa = " + mdiMain.codigoempresa.ToString)
                        cargargrid()
                    Else
                        contvarbus = varbus.Length
                        varbus = varbus.Remove(contvarbus - 1, 1)
                    End If
                    If varbus <> "" Then
                        dtproductos = tproductos.Consultar(" where (codproducto like '%" + varbus + "%' or nombre like '%" + varbus + "%') and  codempresa = " + mdiMain.codigoempresa.ToString)
                    End If

                    If dtproductos.Rows.Count <> 0 Then
                        cargargrid()
                    End If

                Else
                    varbus += e.KeyChar

                    dtproductos = tproductos.Consultar(" where (codproducto like '%" + varbus + "%' or nombre like '%" + varbus + "%') and  codempresa = " + mdiMain.codigoempresa.ToString)

                    If dtproductos.Rows.Count <> 0 Then
                        cargargrid()
                    End If
                End If
            End If
        Catch ex As Exception

        End Try

    End Sub

   


    Private Sub comboprovee_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles comboprovee.SelectedIndexChanged
        Me.codproveedor = dtproveedor1.Rows(comboprovee.SelectedIndex).Item(0).ToString
        f = True
        cargargrid()
    End Sub


    Private Sub botnuevo_Click(sender As Object, e As EventArgs) Handles botnuevo.Click
        Nuevo_Producto.donde = "productos"
        Nuevo_Producto.frmp = Me
        Nuevo_Producto.Show()
    End Sub

    Private Sub botdetalle_Click(sender As Object, e As EventArgs) Handles botdetalle.Click
        Try
            Dim id As Short = Me.gridproductos.CurrentCell.RowIndex
            Dim dtrproducto1 As DataRow = dtproductos.Rows(id)
            DetalleProducto.donde = "productos"
            DetalleProducto.dtrproducto = dtrproducto1
            DetalleProducto.dtproveedor = Me.dtproveedor
            DetalleProducto.frmp = Me
            DetalleProducto.Show()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub boteditar_Click(sender As Object, e As EventArgs) Handles boteditar.Click
        Try
            Dim id As Short = Me.gridproductos.CurrentCell.RowIndex
            Dim dtrproducto1 As DataRow = dtproductos.Rows(id)
            Nuevo_Producto.dtrprodedit = dtrproducto1
            Nuevo_Producto.dtprovedit = dtproveedor
            Nuevo_Producto.frmps = Me
            Nuevo_Producto.flp = True
            Nuevo_Producto.editar = True
            Nuevo_Producto.donde = "productos"
            Nuevo_Producto.Show()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub botseleccionar_Click_1(sender As Object, e As EventArgs) Handles botseleccionar.Click
        Try
            Dim id As Short = Me.gridproductos.CurrentCell.RowIndex
            Dim dtrproducto1 As DataRow = dtproductos.Rows(id)
            If donde = "compras" Then
                frmc.drproducto = dtrproducto1
                frmc.idproducto = dtrproducto1.Item(0)
                frmc.texnombrep.Text = dtrproducto1.Item(1)
                frmc.texprecio.Text = dtrproducto1.Item(3)
                frmc.textotalp.SelectAll()
                Me.Close()
            ElseIf donde = "ventas" Then
                frmv.dtrproductos = dtrproducto1
                frmv.texnombrep.Text = dtrproducto1.Item(1)
                frmv.texprecio.Text = dtrproducto1.Item(5)
                frmv.textotalp.SelectAll()
                frmv.idproducto = dtrproducto1.Item(0)
                Me.Close()
            ElseIf donde = "kardex" Then
                frmk.dtrproductos = dtrproducto1
                frmk.texnombrep.Text = dtrproducto1.Item(1)
                Me.Close()

            Else
                frmcambio.dtrproductos = dtrproducto1
                frmcambio.texnombre.Text = dtrproducto1.Item(1)
                frmcambio.texprecio.Text = dtrproducto1.Item(3)
                frmcambio.texexistencias.Text = dtrproducto1.Item(6)
                frmcambio.texproveedor.Text = dtrproducto1.Item(9)
                frmcambio.generarprov()
                Me.Close()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub botsalir_Click(sender As Object, e As EventArgs) Handles botsalir.Click
        Me.Close()
    End Sub

    Private Sub HolaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HolaToolStripMenuItem.Click
        botdetalle_Click(sender, e)
    End Sub

    Private Sub Hola1ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Hola1ToolStripMenuItem.Click
        boteditar_Click(sender, e)
    End Sub

    Private Sub Hola2ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Hola2ToolStripMenuItem.Click, botSeguir.Click
        Dim id As Short = Me.gridproductos.CurrentCell.RowIndex
        Dim dtrproducto1 As DataRow = dtproductos.Rows(id)
        Registroart.dtrproductos = dtrproducto1
        Registroart.Show()
    End Sub

  
    Private Sub botanalizar_Click(sender As Object, e As EventArgs) Handles botanalizar.Click
        AnalizarProducto.Show()
        Me.Close()
    End Sub
    Dim ctanque As Short = 0
    Private Sub bottanques_Click(sender As Object, e As EventArgs) Handles bottanques.Click



        If ctanque = 0 Then
            cargartanques()
            cargarbombas()
            Me.MaximumSize = New Size(1185, 477)
            Me.Width = 1185
            ctanque = 1
        Else
            Me.Width = 818
            ctanque = 0
            Me.MaximumSize = New Size(818, 477)
        End If

    End Sub

    Private Sub cargarbombas()
        dttanques = ttanques1.Consultar()

        Me.texd1.Text = dttanques.Rows(0).Item(3).ToString
        Me.diesel = CDec(Me.texd1.Text.ToString)

        Me.texr.Text = dttanques.Rows(1).Item(3).ToString

        Me.texs.Text = dttanques.Rows(5).Item(3).ToString
    End Sub

    Private Sub cargartanques()
        dttanques = ttanques.Consultar()
        'para el tanque 1
        Me.lcond1.Text = dttanques.Rows(0).Item(3).ToString & "gl"
        Me.lpord1.Text = Math.Round((CDbl(dttanques.Rows(0).Item(3)) * 100) / 5000, 2).ToString
        Me.progresd1.Value = CInt(Me.lpord1.Text)
        Me.progresd11.Value = CInt(Me.lpord1.Text)

        'para el tanque 2
        Me.lcond2.Text = dttanques.Rows(1).Item(3).ToString & "gl"
        Me.lpord2.Text = Math.Round((CDbl(dttanques.Rows(1).Item(3)) * 100) / 5000, 2).ToString
        Me.progresd2.Value = CInt(Me.lpord2.Text)
        Me.progresd22.Value = CInt(Me.lpord2.Text)


        'para el tanque 3
        Me.lconr.Text = dttanques.Rows(2).Item(3).ToString & "gl"
        Me.lporr.Text = Math.Round((CDbl(dttanques.Rows(2).Item(3)) * 100) / 4000, 2).ToString
        Me.progresr.Value = CInt(Me.lporr.Text)
        Me.progresr2.Value = CInt(Me.lporr.Text)

        'para el tanque 4
        Me.lcons.Text = dttanques.Rows(3).Item(3).ToString & "gl"
        Me.lpors.Text = Math.Round((CDbl(dttanques.Rows(3).Item(3)) * 100) / 5000, 2).ToString
        Me.progress.Value = CInt(Me.lpors.Text)
        Me.progress2.Value = CInt(Me.lpors.Text)

    End Sub



    'Private Sub ButtonX1_Click(sender As Object, e As EventArgs) Handles ButtonX1.Click
    '    Dim b As New clsProcesos

    '    b.Consultar("UPDATE bombas SET ventasdiarias = 0, ventasdiariasgalon= 0")
    '    Me.texv1.Text = ""
    '    Me.texg1.Text = ""

    '    Me.texv2.Text = ""
    '    Me.texg2.Text = ""

    '    Me.texv3.Text = ""
    '    Me.texg3.Text = ""

    '    Me.texv4.Text = ""
    '    Me.texg4.Text = ""

    '    Me.texv5.Text = ""
    '    Me.texg5.Text = ""

    '    Me.texv6.Text = ""
    '    Me.texg6.Text = ""

    '    Me.texv6.Text = ""
    '    Me.texg6.Text = ""
    'End Sub

  
    Dim diesel As Decimal
    Dim d1 = False, d2 As Boolean = False

    Private Sub ButtonX1_Click(sender As Object, e As EventArgs) Handles ButtonX1.Click
        Try
            If MsgBox("Esta seguro de vaciar el tanque ", MsgBoxStyle.YesNo, "Aviso") = MsgBoxResult.Yes Then


                d1 = True
                Dim ct As Decimal
                Dim ttanques1 As New clsMaestros(clsNomTab.eTbl.Tanques)
                Dim dttanques1 As DataTable
                Dim t As Decimal
                t = CDec(Me.texd1.Text.Trim.ToString)

                dttanques1 = ttanques1.Consultar(" where codtanque = 1")
                ct = CDbl(dttanques1.Rows(0).Item(3))
                ct -= t

                consulta1.Consultar("UPDATE tanques SET cantidad = " & ct & " where codtanque = 1 ")
                cargartanques()



                Dim b As New clsProcesos
                If d2 = True Then
                    b.Consultar("UPDATE bombas SET ventasdiarias = 0, ventasdiariasgalon= 0 where idbombas = 1")
                Else
                    diesel = diesel - CDec(Me.texd1.Text.Trim.ToString)
                    b.Consultar("UPDATE bombas SET ventasdiarias = 0, ventasdiariasgalon = " & diesel.ToString & " where idbombas = 1")
                End If
                Me.texd1.Text = ""
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ButtonX2_Click(sender As Object, e As EventArgs) Handles ButtonX2.Click
        Try
            If MsgBox("Esta seguro de vaciar el tanque ", MsgBoxStyle.YesNo, "Aviso") = MsgBoxResult.Yes Then


                d2 = True
                Dim ct As Decimal
                Dim ttanques1 As New clsMaestros(clsNomTab.eTbl.Tanques)
                Dim dttanques1 As DataTable
                Dim t As Decimal
                t = CDec(Me.texd2.Text.Trim.ToString)

                dttanques1 = ttanques1.Consultar(" where codtanque = 2")
                ct = CDbl(dttanques1.Rows(0).Item(3))
                ct -= t

                consulta1.Consultar("UPDATE tanques SET cantidad = " & ct & " where codtanque = 2 ")
                cargartanques()


                Dim b As New clsProcesos

                If d1 = True Then
                    b.Consultar("UPDATE bombas SET ventasdiarias = 0, ventasdiariasgalon= 0 where idbombas = 1")
                Else
                    diesel = diesel - CDec(Me.texd2.Text.Trim.ToString)
                    b.Consultar("UPDATE bombas SET ventasdiarias = 0, ventasdiariasgalon = " & diesel.ToString & " where idbombas = 1")
                End If

                Me.texd2.Text = ""
            End If
        Catch ex As Exception

        End Try
    End Sub


    Private Sub ButtonX3_Click(sender As Object, e As EventArgs) Handles ButtonX3.Click
        Try

            If MsgBox("Esta seguro de vaciar el tanque ", MsgBoxStyle.YesNo, "Aviso") = MsgBoxResult.Yes Then

                Dim ct As Decimal
                Dim ttanques1 As New clsMaestros(clsNomTab.eTbl.Tanques)
                Dim dttanques1 As DataTable
                Dim t As Decimal
                t = CDec(Me.texr.Text.Trim.ToString)

                dttanques1 = ttanques1.Consultar(" where codtanque = 3")
                ct = CDbl(dttanques1.Rows(0).Item(3))
                ct -= t

                consulta1.Consultar("UPDATE tanques SET cantidad = " & ct & " where codtanque = 3 ")
                cargartanques()


                Me.texr.Text = ""

                Dim b As New clsProcesos
                b.Consultar("UPDATE bombas SET ventasdiarias = 0, ventasdiariasgalon= 0 where idbombas = 2")
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ButtonX4_Click(sender As Object, e As EventArgs) Handles ButtonX4.Click
        Try
            If MsgBox("Esta seguro de vaciar el tanque ", MsgBoxStyle.YesNo, "Aviso") = MsgBoxResult.Yes Then


                Dim ct As Decimal
                Dim ttanques1 As New clsMaestros(clsNomTab.eTbl.Tanques)
                Dim dttanques1 As DataTable
                Dim t As Decimal
                t = CDec(Me.texs.Text.Trim.ToString)

                dttanques1 = ttanques1.Consultar(" where codtanque = 4")
                ct = CDbl(dttanques1.Rows(0).Item(3))
                ct -= t

                consulta1.Consultar("UPDATE tanques SET cantidad = " & ct & " where codtanque = 4 ")
                cargartanques()

                Me.texs.Text = ""

                Dim b As New clsProcesos
                b.Consultar("UPDATE bombas SET ventasdiarias = 0, ventasdiariasgalon= 0 where idbombas = 6")

                Dim dtres As DataTable
                Dim tres As New clsMaestros(clsNomTab.eTbl.Respaldo)
                dtres = tres.Consultar()
                If dtres.Rows(0).Item(3).ToString.Trim = "true" Then
                    hacerrespaldos()
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub


    Private Sub hacerrespaldos()
        respaldar.DefaultExt = "sql"
        Dim pathmysql As String
        Dim comando As String
        pathmysql = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Wow6432Node\MySQL AB\MYSQL Server 5.1", "Location", 0)
        If pathmysql = Nothing Then
            MsgBox("No se encontro en tu equipo Mysql, escoge la carpeta donde esta ubicado")
            carpeta.ShowDialog()
            pathmysql = carpeta.SelectedPath
        End If
        Dim nombrearchivo As String
        Dim dtrespaldo As DataTable
        Dim trespaldo As New clsMaestros(clsNomTab.eTbl.Respaldo)


        trespaldo.Insertar("'" & System.DateTime.Now & "','Respaldo',' '")
        dtrespaldo = consultar.Consultar("select max(idrespaldo) from respaldos")
        consultar.Consultar("update respaldos set nombrearchivo = 'Respaldo" & dtrespaldo.Rows(0).Item(0).ToString & "' where idrespaldo = " & dtrespaldo.Rows(0).Item(0).ToString)



        nombrearchivo = "Respaldo" & dtrespaldo.Rows(0).Item(0).ToString & ".sql"
        Dim ruta As String = "D:\SISTEMAS DE LA UNIVERSIDAD\AUDITORIA DE SISTEMAS\INVENTARIO DE GASOLINERA CON MONITOREO DE BOMBAS AL FINAL DEL DIA\INVENTARIO\Respaldos\"
        Try
            comando = pathmysql & "\bin\mysqldump --user=root --password=root --databases inventariome -r """ & ruta & nombrearchivo & """"
            Shell(comando, AppWinStyle.MinimizedFocus, True)
        Catch ex As Exception
            MsgBox("Ocurrio un error al respaldar", MsgBoxStyle.Critical, "Informacion")
        End Try

    End Sub

    Dim mita As Decimal
    Private Sub texd1_KeyUp(sender As Object, e As KeyEventArgs) Handles texd1.KeyUp
        Try
            If Me.checklibre.Checked <> True Then
                If texd1.Text.Trim.ToString = "" Then
                    Me.texd2.Text = diesel
                Else
                    Dim tex As String = Me.texd1.Text.ToString
                    If CDbl(Me.texd1.Text) > diesel Then
                        Me.texd1.Text = tex.Substring(0, tex.Length - 1)
                    Else
                        If checklibre.Checked <> True Then
                            If Me.texd1.Text = "" Then
                                Me.texd1.Text = "0"
                            Else

                                mita = Math.Round(diesel - CDbl(Me.texd1.Text), 3)

                                Me.texd2.Text = mita

                            End If
                        End If
                    End If
                End If
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub texd2_KeyUp(sender As Object, e As KeyEventArgs) Handles texd2.KeyUp
        Try
            If Me.checklibre.Checked <> True Then
                If Me.texd2.Text.Trim.ToString = "" Then
                    Me.texd1.Text = diesel
                Else
                    Dim tex As String = Me.texd2.Text.ToString
                    If CDbl(Me.texd2.Text) > diesel Then
                        Me.texd2.Text = tex.Substring(0, tex.Length - 1)
                    Else
                        If checklibre.Checked <> True Then
                            If Me.texd2.Text = "" Then
                                Me.texd2.Text = "0"
                            Else
                                mita = Math.Round(diesel - CDbl(Me.texd2.Text), 3)

                                Me.texd1.Text = mita

                            End If
                        End If
                    End If
                End If
            End If


        Catch ex As Exception

        End Try
    End Sub



End Class