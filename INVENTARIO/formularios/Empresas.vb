Imports System.Windows.Forms
Imports logica
Imports validaciones
Public Class Empresas
    Public controlgrub As Short = 0
    Dim clsDAtos As DatosEmpresa
    Public donde As String = "here"
    Dim Departamento As New clsMaestros(clsNomTab.eTbl.Departamentos)
    Dim Municipio As New clsMaestros(clsNomTab.eTbl.Municipios)
    Dim dtempresa As DataTable
    Dim dtDepartamento As DataTable
    Dim dtMunicipio As DataTable
    Dim coddepar As Short
    Dim codmuni As Short
    Public edit As Boolean = False
    Public dtempresas As DataRow
    Public cambio As String = "no"
    Public frmp As Proveedores
    Public frmc As Clientes
    Dim clsvalidar As New validar
    Private Sub Empresas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MdiParent = mdiMain
        If cambio = "si" Then
            Me.grubbotones.Visible = False
            Me.botcambio.Visible = True
        Else
            Me.grubbotones.Visible = True
            Me.botcambio.Visible = False
        End If
        Ocultargrubempresa()
    End Sub

    Public Sub Ocultargrubempresa()
        Try
            Me.combodeparN.Items.Clear()
            Me.combodeparO.Items.Clear()
            dtDepartamento = Departamento.Consultar()

            For i As Short = 0 To dtDepartamento.Rows.Count - 1
                Me.combodeparN.Items.Add(dtDepartamento.Rows(i).Item(1))
                Me.combodeparO.Items.Add(dtDepartamento.Rows(i).Item(1))
            Next
            If controlgrub = 0 Then
                Me.grubempresas.Visible = True
                actualizagrid()
            Else
                Me.grubempresas.Visible = False

                Me.lbempresa.Text = dtempresa.Rows(0).Item(1).ToString

                If edit = True Then
                    cargardatosmod()
                End If
            End If
            controlgrub = 0
        Catch ex As Exception

        End Try

    End Sub

    Public Sub actualizagrid()


        Dim nf As Short

        nf = dtempresa.Rows.Count

        If nf = 0 Then
            Me.gridempresas.RowCount = 1
        Else
            Me.gridempresas.RowCount = nf
        End If

        For i As Integer = 0 To dtempresa.Rows.Count - 1
            'para el codigo
            Me.gridempresas.Rows(i).Cells(0).Value = dtempresa.Rows(i).Item(0).ToString
            Me.gridempresas.Rows(i).Cells(1).Value = dtempresa.Rows(i).Item(1).ToString
            Me.gridempresas.Rows(i).Cells(2).Value = dtempresa.Rows(i).Item(6).ToString
            Me.gridempresas.Rows(i).Cells(3).Value = dtempresa.Rows(i).Item(4).ToString
            Me.gridempresas.Rows(i).Cells(4).Value = dtempresa.Rows(i).Item(7).ToString
        Next
    End Sub


    Private Function camposvacios()
        Try
            Dim f As Boolean = False

            If Me.texcodigo.Text = "" Then
                lcamposObligatorios.ForeColor = Color.Red
                lcodigo.ForeColor = Color.Red
                f = True
            Else
                lcodigo.ForeColor = Color.Black
            End If

            If Me.texnomempresa.Text = "" Then
                lcamposObligatorios.ForeColor = Color.Red
                lnempresa.ForeColor = Color.Red
                f = True
            Else
                lnempresa.ForeColor = Color.Black
            End If

            If Me.texpropietario.Text = "" Then
                lcamposObligatorios.ForeColor = Color.Red
                lpropie.ForeColor = Color.Red
                f = True
            Else
                lpropie.ForeColor = Color.Black
            End If

            If combotipo.Text = "" Then
                lcamposObligatorios.ForeColor = Color.Red
                ltipo.ForeColor = Color.Red
            Else
                ltipo.ForeColor = Color.Black
            End If

            If combotipo.Text <> "Final" Then
                If Me.texgiro.Text = "" Then
                    lcamposObligatorios.ForeColor = Color.Red
                    lgiro.ForeColor = Color.Red
                    f = True
                Else
                    lgiro.ForeColor = Color.Black
                End If

                If Me.texnrc.Text = "" Then
                    lcamposObligatorios.ForeColor = Color.Red
                    lnrc.ForeColor = Color.Red
                    f = True
                Else
                    lnrc.ForeColor = Color.Black
                End If

                If Me.texnit.Text = "" Then
                    lcamposObligatorios.ForeColor = Color.Red
                    lnit.ForeColor = Color.Red
                    f = True
                Else
                    lnit.ForeColor = Color.Black
                End If
            End If

            If combodeparN.Text = "" Then
                lcamposObligatorios.ForeColor = Color.Red
                ldepan.ForeColor = Color.Red
                f = True
            Else
                ldepan.ForeColor = Color.Black
            End If

            If combomuniN.Text = "" Then
                lcamposObligatorios.ForeColor = Color.Red
                lmunim.ForeColor = Color.Red
                f = True
            Else
                lmunim.ForeColor = Color.Black
            End If

            If combodeparO.Text = "" Then
                lcamposObligatorios.ForeColor = Color.Red
                ldeptoo.ForeColor = Color.Red
                f = True
            Else
                ldeptoo.ForeColor = Color.Black
            End If

            If combomuniO.Text = "" Then
                lcamposObligatorios.ForeColor = Color.Red
                lmunio.ForeColor = Color.Red
                f = True
            Else
                lmunio.ForeColor = Color.Black
            End If

            If Me.texnumeroN.Text = "" Then
                lcamposObligatorios.ForeColor = Color.Red
                lnumn.ForeColor = Color.Red
                f = True
            Else
                lnumn.ForeColor = Color.Black
            End If

            If texdireccionN.Text = "" Then
                lcamposObligatorios.ForeColor = Color.Red
                ldirecn.ForeColor = Color.Red
                f = True
            Else
                ldirecn.ForeColor = Color.Black
            End If

            If texdireccionO.Text = "" Then
                lcamposObligatorios.ForeColor = Color.Red
                ldirec0.ForeColor = Color.Red
                f = True
            Else
                ldirec0.ForeColor = Color.Black
            End If

            If f = True Then
                Return f
            Else
                Return f
            End If
        Catch ex As Exception
            Return False
        End Try
    End Function


    Private Sub limpiar(ByVal v As Short)
        Try
            If v = 1 Or v = 5 Then
                Me.texnomempresa.Text = ""
                Me.texpropietario.Text = ""
                Me.combotipo.Text = ""
                Me.texrazon.Text = ""
                Me.texgiro.Text = ""
                Me.texnit.Text = ""
                Me.texnrc.Text = ""
            End If
            If v = 2 Or v = 5 Then
                Me.combodeparN.Text = ""
                Me.combomuniN.Items.Clear()
                Me.combomuniN.Text = ""
                Me.texdireccionN.Text = ""
            End If
            If v = 3 Or v = 5 Then
                Me.combodeparO.Text = ""
                Me.combomuniO.Items.Clear()
                Me.combomuniO.Text = ""
                Me.texdireccionO.Text = ""
            End If
            If v = 4 Or v = 5 Then
                Me.texnumeroP.Text = ""
                Me.texnumeroN.Text = ""
                Me.texfaxN.Text = ""
                Me.texnumeroO.Text = ""
                Me.texfaxO.Text = ""
                Me.texemail.Text = ""
            End If
        Catch ex As Exception
            MsgBox("Ocurrio un error asegurese de haber llenado todos los campo correctamente", MsgBoxStyle.OkOnly, "Avise")
        End Try

    End Sub

    Private Sub botborrar1_Click(sender As Object, e As EventArgs)
        limpiar(1)
    End Sub


    Private Sub botsalirdatos_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub


    Private Sub cargardatosmod()
        Try
            Me.texnomempresa.Text = dtempresas.Item(1)
            Me.texpropietario.Text = dtempresas.Item(6)
            Me.texrazon.Text = dtempresas.Item(9)
            Me.texgiro.Text = dtempresas.Item(4)
            Me.texnit.Text = dtempresas.Item(2)
            Me.texnrc.Text = dtempresas.Item(3)
            Me.texnumeroP.Text = dtempresas.Item(15)
            Me.texnumeroN.Text = dtempresas.Item(7)
            Me.texfaxN.Text = dtempresas.Item(12)
            Me.texnumeroO.Text = dtempresas.Item(11)
            Me.texfaxO.Text = dtempresas.Item(13)
            Me.texemail.Text = dtempresas.Item(14)
            Me.texcodigo.Text = dtempresas.Item(0)
            Me.texcodigo.Enabled = False
            edit = True
        Catch ex As Exception
            MsgBox("Ocurrio un error razon: " & ex.Message, MsgBoxStyle.Critical, "Aviso")
        End Try


    End Sub


    Private Sub texnomempresa_KeyPress(sender As Object, e As KeyPressEventArgs)
        e.Handled = clsvalidar.onlyletters(e)
    End Sub



    Private Sub botnuevo_Click_1(sender As Object, e As EventArgs) Handles botnuevo.Click
        controlgrub = 1
        Ocultargrubempresa()
    End Sub

    Private Sub boteliminar_Click_1(sender As Object, e As EventArgs) Handles boteliminar.Click
        Try
            Dim id As String = Me.gridempresas.CurrentCell.RowIndex
            id = dtempresa.Rows(id).Item(0).ToString

            If MsgBox("Seguro que quiere eliminar la empresa", MsgBoxStyle.YesNo, "___....:::: AVISO :::...___") = MsgBoxResult.Yes Then

                actualizagrid()
                MsgBox("La empresa fue eliminada", MsgBoxStyle.Information, "___....:::: EXITO :::...___")
            End If
        Catch ex As Exception
            MsgBox("Ocurrio un error asegurese de haber llenado todos los campo correctamente", MsgBoxStyle.OkOnly, "Avise")
        End Try

    End Sub


    Private Sub botborrar1_Click_1(sender As Object, e As EventArgs) Handles botborrar1.Click
        limpiar(2)
    End Sub

    Private Sub botborrar4_Click_1(sender As Object, e As EventArgs) Handles botborrar4.Click
        limpiar(4)
    End Sub

    Private Sub botguardar_Click(sender As Object, e As EventArgs) Handles botguardar.Click
        Try
            If camposvacios() Then
                If Me.picno.Visible = True Then
                    If donde = "here" Then
                        MsgBox("El codigo de la empresa ya existe", MsgBoxStyle.Critical, "Aviso")
                    ElseIf donde = "clientes" Then
                        MsgBox("El codigo del cliente ya existe", MsgBoxStyle.Critical, "Aviso")
                    ElseIf donde = "proveedores" Then
                        MsgBox("El codigo del proveedor ya existe", MsgBoxStyle.Critical, "Aviso")
                    End If

                Else
                    MsgBox("Tiene que llenar los campos que son obligatorios", MsgBoxStyle.Critical, "Aviso")
                End If

            Else
                If edit = True Then
                    If donde = "proveedores" Then
                        clsDAtos = New DatosEmpresa(Me, donde, dtempresas.Item(0).ToString)
                        clsDAtos.Actualizar(dtempresas.Item(16).ToString)
                    ElseIf donde = "clientes" Then
                        clsDAtos = New DatosEmpresa(Me, donde, dtempresas.Item(0).ToString)
                        clsDAtos.Actualizar(dtempresas.Item(16).ToString)
                    Else
                        clsDAtos = New DatosEmpresa(Me, donde, dtempresas.Item(0).ToString)
                        clsDAtos.Actualizar("nada")
                    End If

                    If donde = "here" Then
                        limpiar(5)
                        controlgrub = 0
                        Ocultargrubempresa()
                        actualizagrid()
                    End If
                Else
                    clsDAtos = New DatosEmpresa(Me, Me.donde, dtempresa.Rows(0).Item(0))
                    clsDAtos.Insertar()
                    If donde = "here" Then
                        limpiar(5)
                        controlgrub = 0
                        Ocultargrubempresa()
                        actualizagrid()
                    End If
                End If

                If donde = "proveedores" Or donde = "clientes" Then
                    limpiar(5)
                    controlgrub = 0
                    Ocultargrubempresa()
                    Me.Close()
                    If donde = "proveedores" Then
                        frmp.f = True
                        frmp.cargargrid()
                        Me.Close()
                    Else
                        frmc.f = True
                        frmc.cargargrid()
                        Me.Close()
                    End If
                End If
            End If

        Catch ex As Exception
            MsgBox("Ocurrio un error asegurese de haber llenado todos los campo correctamente", MsgBoxStyle.OkOnly, "Avise")
        End Try


    End Sub

    Private Sub botboarrartodo_Click_1(sender As Object, e As EventArgs) Handles botboarrartodo.Click
        limpiar(5)
    End Sub

    Private Sub botsalirdatos_Click_2(sender As Object, e As EventArgs) Handles botsalirdatos.Click
        Me.Close()
    End Sub

    Private Sub texcodigo_KeyPress1(sender As Object, e As KeyPressEventArgs) Handles texcodigo.KeyPress
        e.Handled = clsvalidar.onlynumero(e)
    End Sub

    Private Sub texcodigo_KeyUp(sender As Object, e As KeyEventArgs) Handles texcodigo.KeyUp
        Try
            Dim dtcodemp As DataTable = Nothing
            Dim tcodemp As New clsProcesos

            If donde = "here" Then
                dtcodemp = tcodemp.Consultar("Select codempresa from empresa where codempresa = '" & Me.texcodigo.Text.Trim.ToString & "'")
            ElseIf donde = "clientes" Then
                dtcodemp = tcodemp.Consultar("Select codcliente from cliente where codcliente = '" & Me.texcodigo.Text.Trim.ToString & "'")
            ElseIf donde = "proveedores" Then
                dtcodemp = tcodemp.Consultar("Select codproveedor from proveedor where codproveedor = '" & Me.texcodigo.Text.Trim.ToString & "'")
            End If

            If dtcodemp.Rows.Count > 0 Then
                Me.picno.Visible = True
                Me.picsi.Visible = False
            Else
                Me.picno.Visible = False
                Me.picsi.Visible = True
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub combotipo_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles combotipo.SelectedIndexChanged
        If combotipo.Text = "Final" Then
            Me.grubrazon.Visible = False
        Else
            Me.grubrazon.Visible = True
        End If
    End Sub

    Private Sub combodeparN_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles combodeparN.SelectedIndexChanged
        Try
            dtMunicipio = Departamento.Consultar(" where departamentos = '" & Me.combodeparN.Text.ToString.Trim & "'")
            codmuni = dtMunicipio.Rows(0).Item(0)
            dtMunicipio = Municipio.Consultar(" where cod_departamento = " & codmuni)
            Me.combomuniN.Text = ""
            Me.combomuniN.Items.Clear()
            For i As Short = 0 To dtMunicipio.Rows.Count - 1
                Me.combomuniN.Items.Add(dtMunicipio.Rows(i).Item(1))
            Next
        Catch ex As Exception
            MsgBox("Ocurrio un error asegurese de haber llenado todos los campo correctamente", MsgBoxStyle.OkOnly, "Avise")
        End Try

    End Sub

    Private Sub combodeparO_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles combodeparO.SelectedIndexChanged
        Try
            dtMunicipio = Departamento.Consultar(" where departamentos = '" & Me.combodeparO.Text.ToString.Trim & "'")
            codmuni = dtMunicipio.Rows(0).Item(0)
            dtMunicipio = Municipio.Consultar(" where cod_departamento = " & codmuni)
            Me.combomuniO.Text = ""
            Me.combomuniO.Items.Clear()
            For i As Short = 0 To dtMunicipio.Rows.Count - 1
                Me.combomuniO.Items.Add(dtMunicipio.Rows(i).Item(1))
            Next
        Catch ex As Exception
            MsgBox("Ocurrio un error asegurese de haber llenado todos los campo correctamente", MsgBoxStyle.OkOnly, "Avise")
        End Try

    End Sub

    Private Sub botboarrar3_Click_1(sender As Object, e As EventArgs) Handles botboarrar3.Click
        limpiar(3)
    End Sub

    Private Sub botborrar2_Click(sender As Object, e As EventArgs) Handles botborrar2.Click
        limpiar(2)
    End Sub

    Private Sub botcambio_Click_1(sender As Object, e As EventArgs) Handles botcambio.Click
        Try
            Dim id As Short = Me.gridempresas.CurrentCell.RowIndex
            mdiMain.Text = dtempresa.Rows(id).Item(1)
            Dim codigoe As String
            'desde aqui
            codigoe = dtempresa.Rows(id).Item(0)
            mdiMain.codigoempresa = codigoe
            'hasta aqui
            MsgBox("Se ha cambiado de empresa exitozamente", MsgBoxStyle.Information, "___...:::EXITO:::...___")
            Me.Close()
        Catch ex As Exception
            MsgBox("Ocurrio un error asegurese de haber llenado todos los campo correctamente", MsgBoxStyle.OkOnly, "Avise")
        End Try

    End Sub

    Private Sub boteditar_Click(sender As Object, e As EventArgs) Handles boteditar.Click
        Try
            Dim id As Short = Me.gridempresas.CurrentCell.RowIndex
            Me.controlgrub = 1
            Me.dtempresas = dtempresa.Rows(id)
            Me.edit = True
            Me.donde = "here"
            Ocultargrubempresa()
        Catch ex As Exception
            MsgBox("Ocurrio un error asegurese de haber llenado todos los campo correctamente", MsgBoxStyle.OkOnly, "Avise")
        End Try

    End Sub

    Private Sub botdetalle_Click_1(sender As Object, e As EventArgs) Handles botdetalle.Click
        Try
            Dim id As Short = Me.gridempresas.CurrentCell.RowIndex
            DetalleEmpresa.dtempresa = dtempresa.Rows(id)
            DetalleEmpresa.donde = "here"
            DetalleEmpresa.Show()
            Me.Close()
        Catch ex As Exception
            MsgBox("Ocurrio un error asegurese de haber llenado todos los campo correctamente", MsgBoxStyle.OkOnly, "Avise")
        End Try

    End Sub

    Private Sub botsalir_Click(sender As Object, e As EventArgs) Handles botsalir.Click
        Me.Close()
    End Sub

    Private Sub grubempresas_Click(sender As Object, e As EventArgs) Handles grubempresas.Click

    End Sub
End Class