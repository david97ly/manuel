Imports logica
Imports System.Windows.Forms
Imports pjtAdus.Empresas
Public Class DetalleEmpresa
    Public dtempresa As DataRow
    Private empresa As New Empresas
    Private tproveedores As New clsMaestros(clsNomTab.eTbl.Proveedores)
    Private tclientes As New clsMaestros(clsNomTab.eTbl.Clientes)
    Public frmp As Proveedores
    Public frmc As Clientes
    Public donde As String
    Private Sub DetalleEmpresa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MdiParent = mdiMain
        cargardatos()
    End Sub

    Private Sub cargardatos()
        Try
            If donde = "proveedores" Then
                Me.Text = "Detalle del proveedor: " + dtempresa.Item(1).ToString
            ElseIf donde = "clientes" Then
                Me.Text = "Detalle del cliente: " + dtempresa.Item(1).ToString
            ElseIf donde = "here" Then
                Me.Text = "Detalle de la empresa: " + dtempresa.Item(1).ToString
            End If
            Me.texcodigo.Text = dtempresa.Item(0)
            Me.texnomempresa.Text = dtempresa.Item(1)
            Me.texgiro.Text = dtempresa.Item(4)
            Me.texdireccionO.Text = dtempresa.Item(5)
            Me.textelfonoO.Text = dtempresa.Item(6)
            Me.texfaxO.Text = dtempresa.Item(7)
            Me.texnit.Text = dtempresa.Item(2)
            Me.texnrc.Text = dtempresa.Item(3)
            Me.texemail.Text = dtempresa.Item(8)
        Catch ex As Exception
            MsgBox("Ocurrio un error asegurese de haber llenado todos los campo correctamente", MsgBoxStyle.OkOnly, "Avise")
        End Try


    End Sub



    Private Sub botsalir_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub botnuevo_Click_1(sender As Object, e As EventArgs) Handles botnuevo.Click
        Try
            If donde = "here" Then
                Empresas.donde = "here"
                Empresas.controlgrub = 1
                Empresas.Text = "Nueva Empresa"
                Empresas.Show()
                Me.Close()
            ElseIf donde = "proveedores" Then
                Empresas.donde = "proveedores"
                Empresas.controlgrub = 1
                Empresas.Text = "Nuevo Proveedor"
                Empresas.Show()
                Me.Close()
            ElseIf donde = "clientes" Then
                Empresas.donde = "clientes"
                Empresas.controlgrub = 1
                Empresas.Text = "Nuevo Cliente"
                Empresas.Show()
                Me.Close()
            End If
        Catch ex As Exception
            MsgBox("Ocurrio un error asegurese de haber llenado todos los campo correctamente", MsgBoxStyle.OkOnly, "Avise")
        End Try
    End Sub

    Private Sub boteditar_Click_1(sender As Object, e As EventArgs) Handles boteditar.Click
        Try
            empresa.controlgrub = 1
            empresa.dtempresas = Me.dtempresa
            empresa.edit = True
            empresa.donde = Me.donde
            empresa.Show()
            If donde = "clientes" Then
                empresa.frmc = Me.frmc
            Else
                empresa.frmp = Me.frmp
            End If
            empresa.frmp = Me.frmp
            Me.Close()
        Catch ex As Exception
            MsgBox("Ocurrio un error asegurese de haber llenado todos los campo correctamente", MsgBoxStyle.OkOnly, "Avise")
        End Try
    End Sub

    Private Sub boteliminar_Click_1(sender As Object, e As EventArgs) Handles boteliminar.Click
        Try
            If MsgBox("Seguro que quiere eliminar el " & donde, MsgBoxStyle.YesNo, "___....:::: AVISO :::...___") = MsgBoxResult.Yes Then
                Try
                    If donde = "here" Then
                    ElseIf donde = "proveedores" Then
                        tproveedores.Eliminar(dtempresa.Item(0).ToString)
                        MsgBox("El Proveedor se elimino exitozamente: ", MsgBoxStyle.Information, "Exito")
                        Proveedores.cargargrid()
                        Proveedores.Show()
                        Me.Close()
                    ElseIf donde = "clientes" Then
                        tclientes.Eliminar(dtempresa.Item(0).ToString)
                        MsgBox("El Cliente se elimino exitozamente: ", MsgBoxStyle.Information, "Exito")
                        Clientes.cargargrid()
                        Clientes.Show()
                        Me.Close()
                    End If
                Catch ex As Exception
                    MsgBox("Ocurrio un herror al eliminar los datos razon: " & ex.Message, MsgBoxStyle.Critical, "Aviso")
                End Try

            End If
        Catch ex As Exception
            MsgBox("Ocurrio un error asegurese de haber llenado todos los campo correctamente", MsgBoxStyle.OkOnly, "Avise")
        End Try
    End Sub

    Private Sub botsalir_Click_1(sender As Object, e As EventArgs) Handles botsalir.Click
        Me.Close()
    End Sub
End Class