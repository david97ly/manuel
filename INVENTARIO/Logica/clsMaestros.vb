Imports MySql.Data.MySqlClient
Public Class clsMaestros
    Inherits clsNomTab
    Private ObOp As New clsOperaciones
    Public Sub New(ByVal tbl As clsNomTab.eTbl)
        MyBase.tbl = tbl
    End Sub
    Public Overloads Function Consultar() As DataTable
        Return Consultar("")
    End Function
    Public Overloads Function Consultar(ByVal condicion As String) As DataTable
        Dim sql As String
        Dim dt As DataTable
        sql = MyBase.ObtieneSQL() + condicion
        dt = ObOp.Consultar(sql)
        Consultar = dt
    End Function
    Public Overloads Function Consultar(ByVal Cursor As DataTable,ByVal condicion As String) As DataRow
        Dim dr As DataRow = Nothing
        Dim sw As Boolean = False
        Dim i As Integer = 0
        While i < Cursor.Rows.Count And sw = False
            dr = Cursor.Rows(i)
            If dr.Item(0).Equals(condicion) Then
                sw = True
            Else
                i = i + 1
            End If
        End While
        If sw = True Then
            Consultar = dr
        Else
            Consultar = Nothing
        End If
    End Function
    Public Function Insertar(ByVal valores As String) As Integer
        Dim sql As String
        Dim nr As Integer
        sql = MyBase.ObtieneInsertSQL(valores)
        nr = ObOp.Insertar(sql)
        Return nr
    End Function
    Public Function Actualizar(ByVal valores As String) As Integer
        Dim sql As String
        Dim nr As Integer
        sql = MyBase.ObtieneUpdateSQL(valores)
        nr = ObOp.Actualizar(sql)
        Return nr
    End Function
    Public Function Eliminar(ByVal valores As String) As Integer
        Dim sql As String
        Dim nr As Integer
        sql = MyBase.ObtieneDeleteSQL(valores)
        nr = ObOp.Actualizar(sql)
        Return nr
    End Function
End Class
