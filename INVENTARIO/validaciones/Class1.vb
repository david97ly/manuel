Public Class validar
    Function vacio(ByVal a) As Boolean
        Dim vandera As Boolean


        If a = Nothing Then
            MsgBox("Tiene que digitar algo")
            vandera = False
        Else
            vandera = True
        End If

        Return vandera

    End Function

    'acepta solo numeros
    Public Function onlynumero(ByVal caracter As System.Windows.Forms.KeyPressEventArgs)

        If (Asc(caracter.KeyChar)) >= 48 And (Asc(caracter.KeyChar)) <= 57 Or _
          (Asc(caracter.KeyChar)) = System.Windows.Forms.Keys.Back Or (Asc(caracter.KeyChar)) = 46 Then
            Return False
        Else
            Return True
        End If
    End Function

    'Solo letras
    Function onlyletters(ByVal caracter As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsLetter(caracter.KeyChar) Or Char.IsSeparator(caracter.KeyChar) Or _
                Asc(caracter.KeyChar) = 8 Then
            Return False
        Else
            Return True
        End If
    End Function


End Class
