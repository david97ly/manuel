Imports MySql.Data.MySqlClient
Imports System.Windows.Forms
Public Class clsUtilerias
    Private ObOp As New clsOperaciones
    Private mMenu As New System.Windows.Forms.MainMenu
    Private tabla As DataTable
    Public Function ValidaUsuario(ByVal Usuario As String, ByVal Clave As String) As Boolean
        Dim sql As String
        Dim dt As DataTable
        Dim lr As Boolean
        sql = " SELECT * FROM usr WHERE IdUsr ='" + Usuario + "' AND cClave=md5('" + Clave + "')"
        dt = ObOp.Consultar(sql)
        If dt.Rows.Count = 0 Then
            lr = False
        Else
            lr = True
        End If
        Return lr
    End Function
    Public Function GeneraMenu(ByVal flag As Boolean, ByVal usuario As String, ByVal ip As Integer, ByVal opc As MainMenu.MenuItemCollection) As System.Windows.Forms.MainMenu
        If flag = True Then
            tabla = ObOp.Consultar("select idopc,cnomopc, caccion, nidBar,cdescripcion from menu where idopc in (select permisos.idopc from permisos where idgrp in (select idgrp from grp where idgrp in( select idgrp from grpusr where idusr=" & "'" & usuario & "'" & ")))")
        End If
        Dim dvArbol As DataView
        dvArbol = New DataView(tabla)
        dvArbol.RowFilter = tabla.Columns(3).ColumnName.ToString + "=" + ip.ToString
        For Each drActual As DataRowView In dvArbol
            Dim t As New MenuItem
            t.Name = drActual.Item(0)
            t.Text = drActual.Item(1)
            t.Tag = drActual.Item(2)
            If opc Is Nothing Then
                mMenu.MenuItems.Add(t)
            Else
                opc.Add(t)
            End If
            GeneraMenu(False, usuario, t.Name, t.MenuItems)
        Next drActual
        Return mMenu
    End Function
End Class
