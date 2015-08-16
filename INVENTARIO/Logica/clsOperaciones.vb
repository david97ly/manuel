Imports MySql.Data.MySqlClient
Friend Class clsOperaciones
    Inherits clsConexionBD
    Public Function Consultar(ByVal Sql As String) As DataTable
        Dim da As New MySqlDataAdapter
        Dim dt As New DataTable
        MyBase.Conectar()
        Try
            da.SelectCommand = New MySqlCommand(Sql, MyBase.conexion)
            da.Fill(dt)
        Catch errorConsulta As MySqlException
            Throw New Exception("Error en la Operacion" & vbCrLf & "Razon : " & errorConsulta.Message)

        Finally
            MyBase.Desconectar()
            Consultar = dt
        End Try
    End Function
    Public Function Insertar(ByVal sql As String) As Integer
        Dim nr As Integer = 0
        MyBase.Conectar()
        Try
            nr = New MySqlCommand(sql, MyBase.conexion).ExecuteNonQuery()
        Catch eInsert As Exception
            Throw New Exception("Error en la Operacion" & vbCrLf & "Razon : " & eInsert.Message)
        Finally
            MyBase.Desconectar()
        End Try
        Return nr
    End Function
    Public Function Actualizar(ByVal sql As String) As Integer
        Dim nr As Integer = 0
        MyBase.Conectar()
        Try
            nr = New MySqlCommand(sql, MyBase.conexion).ExecuteNonQuery()
        Catch eActualiza As Exception
            Throw New Exception("Error en la Operacion" & vbCrLf & "Razon : " & eActualiza.Message)
        Finally
            MyBase.Desconectar()
        End Try
        Return nr
    End Function
    Public Function Eliminar(ByVal sql As String) As Integer
        Dim nr As Integer = 0
        MyBase.Conectar()
        Try
            nr = New MySqlCommand(sql, MyBase.conexion).ExecuteNonQuery()
        Catch eElimina As Exception
            Throw New Exception("Error en la Operacion" & vbCrLf & "Razon : " & eElimina.Message)
        Finally
            MyBase.Desconectar()
        End Try
        Return nr
    End Function
End Class