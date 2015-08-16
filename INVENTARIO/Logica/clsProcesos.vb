Public Class clsProcesos
    Private ObOp As New clsOperaciones
    Public Overloads Function Consultar(ByVal sql As String) As DataTable
        Dim dt As DataTable
        dt = ObOp.Consultar(sql)
        Consultar = dt
    End Function
    Public Function Ejecutar(ByVal sql As String) As Integer
        Dim nr As Integer
        nr = ObOp.Actualizar(sql)
        Return nr
    End Function
End Class
