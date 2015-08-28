
Imports logica
Public Class DatosEmpresa
    Private nombreE As String
    Private codigo As String
    Private nit As String
    Private nrc As String
    Private giro As String
    Private direccionN As String
    Private direccionO As String
    Private TelefonoPorpietario As String
    Private tipo As String
    Private telefonoO As String
    Private telefonoN As String
    Private telefonoP As String
    Private email As String
    Private codempresa As String
    Private razon As String
    Private propietario As String
    Private frm As Empresas
    Private faxN As String
    Private faxO As String
    Private Proveedores As New clsMaestros(clsNomTab.eTbl.Proveedores)
    Private Clientes As New clsMaestros(clsNomTab.eTbl.Clientes)
    Private Creartabla As New clsProcesos
    Private cempresa As String
    Private donde As String

    'para la factura
    Private facturaventa As New clsMaestros(clsNomTab.eTbl.FacturaVenta)
    Private facturacompra As New clsMaestros(clsNomTab.eTbl.FacturaCompra)
    Private detallefacturav As New clsMaestros(clsNomTab.eTbl.DetalleFacturaV)
    Private detallefacturac As New clsMaestros(clsNomTab.eTbl.DetalleFacturaC)
    'hasta aqui la factura

    Public Sub New(ByRef f As Empresas, ByVal d As String, ByVal c As String)

        frm = f
        donde = d
        Me.codigo = c
        Me.nombreE = f.texnomempresa.Text.ToString.Trim
        Me.nit = f.texnit.Text.ToString.Trim
        Me.nrc = f.texnrc.Text.ToString.Trim
        Me.giro = f.texgiro.Text.ToString.Trim
        Me.direccionN = f.texdireccionN.Text.ToString.Trim + " " + f.combomuniN.Text.ToString.Trim + " " + f.combodeparN.Text.ToString.Trim
        Me.telefonoN = f.texnumeroN.Text.ToString.Trim
        Me.email = f.texemail.Text.ToString.Trim
        Me.faxN = f.texfaxN.Text.ToString.Trim

    End Sub

    Public Function comprobarvacio() As Boolean

    End Function

    Public Function Insertar() As Boolean
        Try
           

            If donde = "proveedores" Then
                Proveedores.Insertar("'" + nombreE + "','" + nit + "','" + nrc + "','" + giro + "','" + Me.direccionN + "','" + Me.telefonoN + "','" + Me.faxN + "','" + Me.email + "','Activo'")
                MsgBox("El proveedor se guardo con exito", MsgBoxStyle.Information, "Exito")
            ElseIf donde = "clientes" Then
                Clientes.Insertar("'" + nombreE + "','" + nit + "','" + nrc + "','" + giro + "','" + Me.direccionN + "','" + Me.telefonoN + "','" + Me.faxN + "','" + Me.email + "','Activo'")
                MsgBox("El cliente se guardo con exito", MsgBoxStyle.Information, "Exito")
            End If
        Catch ex As Exception
            MsgBox("Hubo un error en la insercion razon : " & ex.Message, MsgBoxStyle.Critical, "Aviso")
        End Try
    End Function

    Public Function Actualizar() As Boolean
        Try

            If donde = "proveedores" Then
                Proveedores.Actualizar("'" + Me.codigo + "'|'" + nombreE + "'|'" + nit + "'|'" + nrc + "'|'" + giro + "'|'" + Me.direccionN + "'|'" + Me.telefonoN + "'|'" + Me.faxN + "'|'" + Me.email + "'|'Activo'")
                MsgBox("El proveedor se actualizo con exito", MsgBoxStyle.Information, "Exito")
            ElseIf donde = "clientes" Then
                Clientes.Actualizar("'" + Me.codigo + "'|'" + nombreE + "'|'" + nit + "'|'" + nrc + "'|'" + giro + "'|'" + Me.direccionN + "'|'" + Me.telefonoN + "'|'" + Me.faxN + "'|'" + Me.email + "'|'Activo'")
                MsgBox("El cliente se actualizo con exito", MsgBoxStyle.Information, "Exito")
            End If
        Catch ex As Exception
            MsgBox("Hubo un error en la Actualizacion razon : " & ex.Message, MsgBoxStyle.Critical, "Aviso")
        End Try
    End Function


    Public Sub eliminar(ByVal id As String, ByVal donde As String)
        If donde = "here" Then

            MsgBox("La empresa se actualizo con exito", MsgBoxStyle.Information, "Exito")
        ElseIf donde = "proveedores" Then
            Proveedores.Eliminar(id)
            MsgBox("El proveedor se elimino con exito", MsgBoxStyle.Information, "Exito")
        ElseIf donde = "clientes" Then
            Clientes.Eliminar(id)
            MsgBox("El cliente se elimino con exito", MsgBoxStyle.Information, "Exito")
        End If
    End Sub




End Class
