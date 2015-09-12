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
            Me.texprecioindi.Text = dtrprodedit.Item(4)
            Me.texcantidad.Text = dtrprodedit.Item(6)
            If flp = True Then
                dtcategoria = consultar.Consultar(" Select id_categoria,nombre from categoria where id_categoria = " & dtrprodedit.Item(7).ToString)
                Me.texcategoria.Text = dtcategoria.Rows(0).Item(1).ToString
                idcategoria = dtcategoria.Rows(0).Item(0)

            Else
                Me.texcategoria.Text = dtcateedit.Rows(0).Item(1)

            End If


            Me.texunidaddemedida.Text = dtrprodedit.Item(8)
            Me.editar = True
        Catch ex As Exception

        End Try

    End Sub
    Private Sub botguardar_Click(sender As Object, e As EventArgs) Handles botguardar.Click, texunidaddemedida.Enter
        Try
            If Me.picno.Visible <> True Or editar = True Then

                If donde = "productos" And flp = False Then
                    insertarproducto()
                    If llenos Then
                        frmp.cargargrid()
                        frmp.f = True

                        frmp.Show()
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

                If Me.texprecioindi.Text.Trim = "" Then
                    preciopublic = 0
                Else
                    preciopublic = Me.texprecioindi.Text.ToString.Trim
                End If


                If Me.texcantidad.Text.ToString.Trim = "" Then
                    existencias = "0"
                Else
                    existencias = Me.texcantidad.Text.ToString.Trim
                End If



                If flagc = True Then
                    idcategoria = dtrcate.Item(0).ToString
                Else
                    If donde <> "productos" Then
                        idcategoria = dtcateedit.Rows(0).Item(0).ToString
                    End If

                End If



                Dim unidmede As String = texunidaddemedida.Text.ToString.Trim

                If editar = False Then

                    tproductos.Insertar("'" & idprod + "','" & nombre & "','" & descripcion & "'," & preciounit & "," & preciopublic & ",0," & existencias & "," & idcategoria & ",'" & unidmede & "',1")
                    MsgBox("El producto se ingreso exitozamente", MsgBoxStyle.Information, "Exito")
                Else
                    tproductos.Actualizar(dtrprodedit.Item(0) & "|'" & nombre.ToString & "'|'" & descripcion.ToString & "'|" & CShort(preciounit.ToString) & "|" & CShort(preciopublic.ToString) & "|0|" & CShort(existencias.ToString) & "|" & idcategoria.ToString & "|'" & unidmede.ToString & "'|1")


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

        Me.texprecioindi.Text = ""
        Me.texpreciounitario.Text = ""
        Me.texunidaddemedida.Text = ""
    End Sub
    Private Sub texcategoria_Click(sender As Object, e As EventArgs) Handles texcategoria.Click
        Me.flagc = True

        Categoria.donde = "producto"
        Categoria.frmprod = Me
        Categoria.Show()
    End Sub

    Private Sub texproveedor_Click(sender As Object, e As EventArgs)
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

End Class