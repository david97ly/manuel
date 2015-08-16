Imports logica

Public Class DetalleProducto
    Public donde As String
    Public dtrproducto As DataRow
    Public nombretabla As String
    Public dtcategoria As DataTable
    Public dtproveedor As DataTable
    Private tcategoria As New clsMaestros(clsNomTab.eTbl.Categorias)
    Private tproveedor As New clsMaestros(clsNomTab.eTbl.Proveedores)
    Public frmp As Productos
    Public modi As Boolean = False
    Private Sub DetalleProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mdiMain = mdiMain
        cargardatos()
    End Sub

    Public Sub cargardatos()
        Try
            If modi = True Then
                frmp.cargargrid()
            End If

            Me.texcodigo.Text = Me.dtrproducto.Item(0).ToString
            Me.texnombre.Text = Me.dtrproducto.Item(1).ToString
            Me.texdescripcion.Text = Me.dtrproducto.Item(2).ToString
            Me.texpreciounit.Text = Me.dtrproducto.Item(3).ToString
            Me.texpreciopublic.Text = Me.dtrproducto.Item(5).ToString
            Me.texexistencias.Text = Me.dtrproducto.Item(6).ToString
            dtcategoria = tcategoria.Consultar(" where codempresa =" + mdiMain.codigoempresa.ToString + " and id_categoria = " & dtrproducto.Item(8).ToString)
            Me.texcategoria.Text = dtcategoria.Rows(0).Item(1)
            dtproveedor = tproveedor.Consultar(" where codproveedor ='" + dtrproducto.Item(9).ToString + "' and codempresa = " & mdiMain.codigoempresa.ToString)
            Me.texproveedor.Text = Me.dtproveedor.Rows(0).Item(1)
            Me.texunidmed.Text = Me.dtrproducto.Item(10).ToString
        Catch ex As Exception
            MsgBox("Ocurrio un error al cargar los datos rezon: " + ex.Message, MsgBoxStyle.Critical, "Aviso")
        End Try

    End Sub

    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Nuevo_Producto.dtrprodedit = dtrproducto
        Nuevo_Producto.dtprovedit = dtproveedor
        Nuevo_Producto.dtcateedit = dtcategoria
        Nuevo_Producto.frmdt = Me
        Nuevo_Producto.donde = "detalleproductos"
        Nuevo_Producto.Show()
    End Sub
End Class