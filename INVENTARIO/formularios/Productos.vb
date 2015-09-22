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



    'para los respaldos
    Dim carpeta As New FolderBrowserDialog
    Dim consultar As New clsProcesos



    Private Sub Productos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.botanalizar.Visible = False
        Me.botSeguir.Visible = False

        Me.texbusquedacodigonombre.Select()

        Try


            If donde = "ventas" Or donde = "compras" Or donde = "cambio" Or donde = "kardex" Then
                ocultar()
                MdiParent = mdiMain
            Else
                MdiParent = mdiMain
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
        dtproductos = tproductos.Consultar()


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
                Me.gridproductos.Rows(0).Cells(5).Value = ""
            Else
                Me.gridproductos.RowCount = nf
            End If


            'variable para la categoria
            Dim cate As New clsMaestros(clsNomTab.eTbl.Categorias)
            Dim datecate As DataTable

            For i As Integer = 0 To dtproductos.Rows.Count - 1
                If Not CBool(dtproductos.Rows(i).Item(9)) Then
                    Me.gridproductos.Rows(i).Visible = False
                Else
                    Me.gridproductos.Rows(i).Cells(0).Value = dtproductos.Rows(i).Item(0).ToString 'para el codigo
                    Me.gridproductos.Rows(i).Cells(1).Value = dtproductos.Rows(i).Item(1).ToString 'para el nombre
                    Me.gridproductos.Rows(i).Cells(2).Value = dtproductos.Rows(i).Item(2).ToString 'para la descripcion

                    datecate = cate.Consultar(" where id_categoria = " & dtproductos.Rows(i).Item(7))
                    Me.gridproductos.Rows(i).Cells(3).Value = datecate.Rows(0).Item(1) 'para la categoria

                    Me.gridproductos.Rows(i).Cells(4).Value = dtproductos.Rows(i).Item(8).ToString 'para la unidad de medida
                    Me.gridproductos.Rows(i).Cells(5).Value = "$ " & dtproductos.Rows(i).Item(3).ToString 'para el precio
                    Me.gridproductos.Rows(i).Cells(6).Value = dtproductos.Rows(i).Item(6).ToString 'para las existencias
                End If

            Next
        Catch ex As Exception
            MsgBox("Ocurrio el siguiente error a la hora de llenar el grid: " + ex.Message, MsgBoxStyle.Critical, "Aviso")
        End Try

    End Sub


    Public Sub cargargrid1()


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
                Me.gridproductos.Rows(0).Cells(5).Value = ""
            Else
                Me.gridproductos.RowCount = nf
            End If


            'variable para la categoria
            Dim cate As New clsMaestros(clsNomTab.eTbl.Categorias)
            Dim datecate As DataTable

            For i As Integer = 0 To dtproductos.Rows.Count - 1
                If Not CBool(dtproductos.Rows(i).Item(9)) Then
                    Me.gridproductos.Rows(i).Visible = False
                Else
                    Me.gridproductos.Rows(i).Cells(0).Value = dtproductos.Rows(i).Item(0).ToString 'para el codigo
                    Me.gridproductos.Rows(i).Cells(1).Value = dtproductos.Rows(i).Item(1).ToString 'para el nombre
                    Me.gridproductos.Rows(i).Cells(2).Value = dtproductos.Rows(i).Item(2).ToString 'para la descripcion

                    datecate = cate.Consultar(" where id_categoria = " & dtproductos.Rows(i).Item(7))
                    Me.gridproductos.Rows(i).Cells(3).Value = datecate.Rows(0).Item(1) 'para la categoria

                    Me.gridproductos.Rows(i).Cells(4).Value = dtproductos.Rows(i).Item(8).ToString 'para la unidad de medida
                    Me.gridproductos.Rows(i).Cells(5).Value = "$ " & dtproductos.Rows(i).Item(3).ToString 'para el precio
                    Me.gridproductos.Rows(i).Cells(6).Value = dtproductos.Rows(i).Item(6).ToString 'para las existencias
                End If

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

 
  


    Private Sub radiotodos_Click(sender As Object, e As EventArgs)
        f = True
        cargargrid()
    End Sub

   

    Dim varbus As String
    Private Sub texbusquedacodigonombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles texbusquedacodigonombre.KeyPress
        Try
            f = False
            If (Asc(e.KeyChar) = 13) Then
            Else
                If (Asc(e.KeyChar)) = System.Windows.Forms.Keys.Back Then
                    Dim contvarbus As Short
                    If varbus = "" Then
                        dtproductos = tproductos.Consultar()
                        cargargrid()
                    Else
                        contvarbus = varbus.Length
                        varbus = varbus.Remove(contvarbus - 1, 1)
                    End If
                    If varbus <> "" Then
                        dtproductos = tproductos.Consultar(" where (codproducto like '%" + varbus + "%' or nombre like '%" + varbus + "%') ")
                    End If

                    If dtproductos.Rows.Count <> 0 Then
                        cargargrid1()
                    End If

                Else
                    varbus += e.KeyChar

                    dtproductos = tproductos.Consultar(" where (codproducto like '%" + varbus + "%' or nombre like '%" + varbus + "%') ")

                    If dtproductos.Rows.Count <> 0 Then
                        cargargrid1()
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox("ocurrio algo")
        End Try

    End Sub

   



    Private Sub botnuevo_Click(sender As Object, e As EventArgs) Handles botnuevo.Click
        pjtAdus.Nuevo_Producto.donde = "productos"
        pjtAdus.Nuevo_Producto.frmp = Me
        pjtAdus.Nuevo_Producto.Show()
    End Sub

    Private Sub botdetalle_Click(sender As Object, e As EventArgs) Handles botdetalle.Click
        Try
            Dim id As Short = Me.gridproductos.CurrentCell.RowIndex
            Dim dtrproducto1 As DataRow = dtproductos.Rows(id)
            DetalleProducto.donde = "productos"
            DetalleProducto.dtrproducto = dtrproducto1

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
                frmv.texprecio.Text = dtrproducto1.Item(3)
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


    Private Sub botacutalizar_Click(sender As Object, e As EventArgs) Handles botacutalizar.Click
        cargargrid()
    End Sub
End Class