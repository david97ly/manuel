Public Class clsNomTab
    Private ctbl As String
    Public Enum eTbl
        Grp = 1
        Usr = 2
        Menu = 3
        GrpUsr = 4
        Permisos = 5
    End Enum
    Protected Property tbl()
        Get
            Return ctbl
        End Get
        Set(ByVal value)
            ctbl = value
        End Set
    End Property
    Protected Function ObtieneSQL() As String
        Dim localSQL As String
        localSQL = "SELECT " & getCamposSelect(ctbl) & " FROM " & getTabla(ctbl)
        ObtieneSQL = localSQL
    End Function
    Protected Function ObtieneInsertSQL(ByVal valores As String) As String
        Dim localSQL As String
        localSQL = "INSERT INTO " & getTabla(ctbl) & " ( " & getCamposInsert(ctbl) & " ) VALUES (" & valores & ")"
        ObtieneInsertSQL = localSQL
    End Function
    Protected Function ObtieneUpdateSQL(ByVal valores As String) As String
        Dim localSQL As String
        Dim campos As ArrayList = getCamposUpdate(ctbl)
        Dim valUpdate As String = ""
        Dim llave As String = ""
        Dim i As Integer = 0
        For Each cmp As String In valores.Split("|")
            If i = 0 Then
                llave = cmp
            Else
                valUpdate = valUpdate & campos.Item(i).ToString & " = " & cmp & ", "
            End If
            i = i + 1
        Next
        valUpdate = valUpdate.Substring(0, valUpdate.Length - 2)
        localSQL = "UPDATE " & getTabla(ctbl) & " SET " & valUpdate & " WHERE " & campos.Item(0).ToString & "= " & llave
        ObtieneUpdateSQL = localSQL
    End Function
    Protected Function ObtieneDeleteSQL(ByVal llave As String) As String
        Dim localSQL As String
        localSQL = "DELETE FROM " & getTabla(ctbl) & " WHERE " & getCamposDelete(ctbl) & "=" & llave
        ObtieneDeleteSQL = localSQL
    End Function
    Private Function getTabla(ByVal Tabla As Short) As String
        Dim Resultado As String = ""
        Select Case Tabla
            Case 1
                Resultado = "grp"
        End Select
        Return Resultado
    End Function
    Private Function getCamposSelect(ByVal Tabla As Short) As String
        Dim Resultado As String = ""
        Select Case Tabla
            Case 1
                Resultado = "idGrp,cGrp"
        End Select
        Return Resultado
    End Function
    Private Function getCamposInsert(ByVal Tabla As Short) As String
        Dim Resultado As String = ""
        Select Case Tabla
            Case 1
                Resultado = "cGrp"
        End Select
        Return Resultado
    End Function
    Private Function getCamposUpdate(ByVal Tabla As Short) As ArrayList
        Dim Resultado As New ArrayList
        Select Case Tabla
            Case 1
                Resultado.Add("idGrp")
                Resultado.Add("cGrp")
        End Select
        Return Resultado
    End Function
    Private Function getCamposDelete(ByVal Tabla As Short) As String
        Dim Resultado As String = ""
        Select Case Tabla
            Case 1
                Resultado = "idGrp"
        End Select
        Return Resultado
    End Function
End Class