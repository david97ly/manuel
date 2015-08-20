Imports logica
Public Class Nuevo_Producto
    Public donde As String
    Private dtproducto As DataTable
    Public dtrcate As DataRow
    Public dtrprove As DataRow
    Private dtrtabla As DataRow
    Private productos As New clsProcesos
    Private tproductos As New clsMaestros(clsNomTab.eTbl.Productos)
    Private consultar As New clsProcesos
    Public frmp As Productos
    Public editar As Boolean = False
    'desde aqui son de detalle
    Public dtrprodedit As DataRow
    Public dtcateedit As DataTable
    Public dtprovedit As DataTable
    Public frmdt As DetalleProducto
    Public frmps As Productos
    'hasta aqui son de detalle
    Dim flagc As Boolean = False
    Dim flagp As Boolean = False
    Public flp As Boolean = False
    Private llenos As Boolean = True
    'nueva actualizacion
    Private provedores, categorian As String
    Private dtproveedores, dtcategoria As DataTable
    Dim idcategoria As String
    Dim codpreovee As String

    Private dtdescuentos As DataTable

    Private Sub Nuevo_Producto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            MdiParent = mdiMain
            If donde = "productos" Then
                Me.texcantidad.Enabled = False
            End If

            If donde = "detalleproductos" Or flp = True Then
                Me.texcantidad.Enabled = False
                cargardatos()
                Me.texcodigo.Enabled = False
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub cargardatos()
        Try
            Me.texcodigo.Text = dtrprodedit.Item(0)
            Me.texnombre.Text = dtrprodedit.Item(1)
            Me.texdescripcion.Text = dtrprodedit.Item(2)
            Me.texpreciounitario.Text = dtrprodedit.Item(3)
            Me.texpreciopublico.Text = dtrprodedit.Item(5)
            Me.texcantidad.Text = dtrprodedit.Item(6)
            If flp = True Then
                dtcategoria = consultar.Consultar(" Select id_categoria,nombre from categoria where id_categoria = " & dtrprodedit.Item(8).ToString)
                Me.texcategoria.Text = dtcategoria.Rows(0).Item(1).ToString
                idcategoria = dtcategoria.Rows(0).Item(0)
                dtproveedores = consultar.Consultar(" Select codproveedor,nombre from proveedor where codproveedor = " & dtrprodedit.Item(9))
                Me.texproveedor.Text = dtproveedores.Rows(0).Item(1)
                dtrprove = dtproveedores.Rows(0)
                codpreovee = dtproveedores.Rows(0).Item(0)
            Else
                Me.texcategoria.Text = dtcateedit.Rows(0).Item(1)
                Me.texproveedor.Text = dtprovedit.Rows(0).Item(1)
            End If
            If dtdescuentos.Rows(0).Item(2).ToString = "True" Then
                Me.checcotrans.Checked = True
            Else
                Me.checcotrans.Checked = False
            End If

            If dtdescuentos.Rows(0).Item(3).ToString = "True" Then
                Me.checfovial.Checked = True
            Else
                Me.checfovial.Checked = False
            End If

            Me.texunidaddemedida.Text = dtrprodedit.Item(10)
            Me.editar = True
        Catch ex As Exception

        End Try

    End Sub
    Private Sub botguardar_Click(sender As Object, e As EventArgs) Handles botguardar.Click
        Try
            If Me.picno.Visible <> True Or editar = True Then

                If donde = "productos" And flp = False Then
                    insertarproducto()
                    If llenos Then
                        frmp.cargargrid()
                        frmp.f = True
                        Me.Close()
                    End If

                End If
                If flp = True Then
                    insertarproducto()
                    If llenos Then
                        frmps.cargargrid()
                        Me.Close()
                    End If

                End If
                If donde = "detalleproductos" Then
                    insertarproducto()
                End If
                llenos = True
            Else
                MsgBox("El codigo no se puede repetir para los productos", MsgBoxStyle.AbortRetryIgnore, "Aviso")
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub insertarproducto()
        If vacio() Then
            If Me.picno.Visible = True Then
                MsgBox("El codigo del producto ya existe ", MsgBoxStyle.OkOnly, "Aviso")
            Else
                MsgBox("Tiene que llenar todos los campos obligatorios", MsgBoxStyle.OkOnly, "Aviso")
            End If

        Else
            Try
                Dim idprod As String = Me.texcodigo.Text.ToString.Trim
                Dim nombre As String = Me.texnombre.Text.ToString.Trim
                Dim descripcion As String = Me.texdescripcion.Text.ToString.Trim
                Dim preciounit As String
                Dim preciopublic As String
                Dim existencias As String

                If Me.texpreciounitario.Text.Trim = "" Then
                    preciounit = 0
                Else
                    preciounit = Me.texpreciounitario.Text.ToString.Trim
                End If

                If Me.texpreciopublico.Text.Trim = "" Then
                    preciopublic = 0
                Else
                    preciopublic = Me.texpreciopublico.Text.ToString.Trim
                End If


                If Me.texcantidad.Text.ToString.Trim = "" Then
                    existencias = "0"
                Else
                    existencias = Me.texcantidad.Text.ToString.Trim
                End If

              
                Dim codempresa As String = mdiMain.codigoempresa.ToString

                If flagc = True Then
                    idcategoria = dtrcate.Item(0).ToString
                Else
                    If donde <> "productos" Then
                        idcategoria = dtcateedit.Rows(0).Item(0).ToString
                    End If

                End If

                If flagp = True Then
                    codpreovee = dtrprove.Item(0).ToString
                Else
                    If donde <> "productos" Then
                        codpreovee = dtprovedit.Rows(0).Item(0).ToString
                    End If
                End If

                Dim unidmede As String = texunidaddemedida.Text.ToString.Trim

                If editar = False Then

                    tproductos.Insertar("'" & idprod + "','" & nombre & "','" & descripcion & "'," & preciounit & ",0" & "," & preciopublic & "," & existencias & ",'" & codempresa & "'," & idcategoria & ",'" & codpreovee & "','" & unidmede & "'")
                    MsgBox("El producto se ingreso exitozamente", MsgBoxStyle.Information, "Exito")
                Else
                    tproductos.Actualizar(dtrprodedit.Item(0) & "|'" & nombre.ToString & "'|'" & descripcion.ToString & "'|" & preciounit.ToString & "|" & "0 |" & preciopublic.ToString & "|" & existencias.ToString & "|'" & mdiMain.codigoempresa.ToString & "'|" & idcategoria.ToString & "|'" & codpreovee & "'|'" & unidmede.ToString & "'")

                    consultar.Consultar(" update descuentos set iva = '" & Me.checiva.Checked.ToString & "',cotrans ='" & Me.checcotrans.Checked.ToString & "',fovial = '" & Me.checfovial.Checked.ToString & "' where codproducto =" & dtrprodedit.Item(0))
                    MsgBox("El producto se actualizo exitozamente", MsgBoxStyle.Information, "Exito")
                    If flp = False Then
                        dtproducto = tproductos.Consultar(" where codproducto = '" & dtrprodedit.Item(0) & "'")
                        frmdt.dtrproducto = dtproducto.Rows(0)
                        frmdt.modi = True
                        frmdt.cargardatos()
                        Me.Close()
                    End If

                End If

            Catch ex As Exception
                MsgBox("Ocurrio un error al momento de insertar el producto razon: " + ex.Message, MsgBoxStyle.Critical, "Aviso")
            End Try

        End If

    End Sub

    Private Function vacio() As Boolean

        If Me.texcodigo.Text.Trim = "" Then
            Me.lbcamposobligatorios.ForeColor = Color.Red
            Me.lcodigo.ForeColor = Color.Red
            llenos = False
        Else
            Me.lcodigo.ForeColor = Color.Black
        End If

        If Me.texcategoria.Text.Trim = "" Then
            Me.lbcamposobligatorios.ForeColor = Color.Red
            Me.lcat.ForeColor = Color.Red
            llenos = False
        Else
            Me.lcat.ForeColor = Color.Black
        End If

        If Me.texproveedor.Text.Trim = "" Then
            Me.lbcamposobligatorios.ForeColor = Color.Red
            Me.lproveedor.ForeColor = Color.Red
            llenos = False
        Else
            Me.lproveedor.ForeColor = Color.Black
        End If

        If Me.texdescripcion.Text.Trim = "" Then
            Me.lbcamposobligatorios.ForeColor = Color.Red
            Me.ldescripcion.ForeColor = Color.Red
            llenos = False
        Else
            Me.ldescripcion.ForeColor = Color.Black
        End If

        If Me.texunidaddemedida.Text.Trim = "" Then
            Me.lbcamposobligatorios.ForeColor = Color.Red
            Me.lunitmed.ForeColor = Color.Red
            llenos = False
        Else
            Me.lunitmed.ForeColor = Color.Black
        End If

        If Me.texnombre.Text.Trim = "" Then
            Me.lbcamposobligatorios.ForeColor = Color.Red
            Me.lnombre.ForeColor = Color.Red
            llenos = False
        Else
            Me.lnombre.ForeColor = Color.Black
        End If

        If llenos Then
            Me.lbcamposobligatorios.ForeColor = Color.Black
            Return False
        Else
            Return True
        End If
    End Function
    Private Sub botborrar_Click(sender As Object, e As EventArgs) Handles botborrar.Click
        borrar()
    End Sub

    Private Sub borrar()
        Me.texcategoria.Text = ""
        Me.texnombre.Text = ""
        Me.texdescripcion.Text = ""
        Me.texcantidad.Text = ""
        Me.texcodigo.Text = ""
        Me.texproveedor.Text = ""
        Me.texpreciopublico.Text = ""
        Me.texpreciounitario.Text = ""
        Me.texunidaddemedida.Text = ""
    End Sub
    Private Sub texcategoria_Click(sender As Object, e As EventArgs) Handles texcategoria.Click
        Me.flagc = True

        Categoria.donde = "producto"
        Categoria.frmprod = Me
        Categoria.Show()
    End Sub

    Private Sub texproveedor_Click(sender As Object, e As EventArgs) Handles texproveedor.Click
        Me.flagp = True
        Proveedores.donde = "producto"
        Proveedores.frm = Me
        Proveedores.Show()
    End Sub


    Private Sub botsalir_Click(sender As Object, e As EventArgs) Handles botsalir.Click
        Me.Close()
    End Sub

    Private Sub texcodigo_KeyUp(sender As Object, e As KeyEventArgs) Handles texcodigo.KeyUp
        Dim dtp As DataTable = Nothing
        Dim ttp As New clsMaestros(clsNomTab.eTbl.Productos)
        dtp = ttp.Consultar(" where codproducto = '" & Me.texcodigo.Text.Trim.ToString & "'")
        If dtp.Rows.Count > 0 Then
            Me.picno.Visible = True
            Me.picsi.Visible = False
        Else
            Me.picno.Visible = False
            Me.picsi.Visible = True
        End If
    End Sub

   
    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class