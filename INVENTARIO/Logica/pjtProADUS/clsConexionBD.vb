Imports MySql.Data
Imports MySql.Data.MySqlClient
Friend MustInherit Class clsConexionBD
    Protected conexion As New MySqlConnection
    Sub New()
        Dim cadena As String
        cadena = "database=adus;data source=localhost;user id=root;password=admin"
        Me.conexion.ConnectionString = cadena
    End Sub
    Protected Sub Conectar()
        Try
            Me.conexion.Open()
        Catch errorConexion As MySqlException
            Throw (New Exception("Error de Conexion" & vbCrLf & "Razon : " & errorConexion.Message))
        End Try
    End Sub
    Protected Sub Desconectar()
        Me.conexion.Close()
    End Sub
End Class