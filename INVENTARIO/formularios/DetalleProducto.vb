Imports logica

Public Class DetalleProducto
    Public donde As String
    Public dtrproducto As DataRow
    Public nombretabla As String
    Public dtcategoria As DataTable
    Private tcategoria As New clsMaestros(clsNomTab.eTbl.Categorias)
    Private consulta As New clsProcesos
    Public frmp As Productos
    Public modi As Boolean = False
    Private Sub DetalleProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MdiParent = mdiMain
        cargardatos()
    End Sub

    Public Sub cargardatos()
        Try
            If modi = True Then
                frmp.cargargrid()
            End If

            Me.texcodigo.Text = Me.dtrproducto.Item(0).ToString 'para el codigo

            Me.texnombre.Text = Me.dtrproducto.Item(1).ToString 'para el nombre

            Me.texdescripcion.Text = Me.dtrproducto.Item(2).ToString    'para la descripcion

            Me.texpreciounit.Text = Me.dtrproducto.Item(3).ToString 'para precio unitario

            Me.texprecioindi.Text = Me.dtrproducto.Item(4).ToString 'para el precio individual

            Me.texexistencias.Text = Me.dtrproducto.Item(6).ToString    'para las existencias

            dtcategoria = tcategoria.Consultar(" where id_categoria = " & dtrproducto.Item(7).ToString)

            Me.texcategoria.Text = dtcategoria.Rows(0).Item(1)
           
            Me.texunidmed.Text = Me.dtrproducto.Item(8).ToString
        Catch ex As Exception
            MsgBox("Ocurrio un error al cargar los datos rezon: " + ex.Message, MsgBoxStyle.Critical, "Aviso")
        End Try

    End Sub

    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles botsalir.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles boteditar.Click
        Nuevo_Producto.dtrprodedit = dtrproducto
        Nuevo_Producto.dtcateedit = dtcategoria
        Nuevo_Producto.frmdt = Me
        Nuevo_Producto.donde = "detalleproductos"
        Nuevo_Producto.Show()
    End Sub

    Private Sub boteliminar_Click(sender As Object, e As EventArgs) Handles boteliminar.Click
        If MsgBox("Seguro que quiere eliminar " & dtrproducto.Item(1).ToString, MsgBoxStyle.YesNo, "___....:::: AVISO :::...___") = MsgBoxResult.Yes Then
            consulta.Consultar("update productos set valida = 0 where codproducto = '" & dtrproducto.Item(0).ToString & "'")
            MsgBox("El Producto " & dtrproducto.Item(1).ToString & " se elimino exitozamente: ", MsgBoxStyle.Information, "Exito")
            Me.Close()
        End If
    End Sub
End Class