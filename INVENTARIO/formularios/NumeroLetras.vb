Imports logica
Public Class NumeroLetras
    Dim tnumros As New clsMaestros(clsNomTab.eTbl.Numeros)
    Dim dtnumerosa As DataTable

    Dim nuevonumero As String = ""
    Dim nuevodecimal As String = ""
    Dim strnumero As String = ""
    Dim punto As Boolean = False
    Dim conn As Short = 0
    Dim primera As Boolean = True
    Dim dpunto As String 

    Public Sub setnumero(ByVal numero2 As Double)

        Dim numero As String = CStr(numero2)

        If primera = False Then
            nuevonumero = numero
        End If

        While conn < numero.Length
            If punto <> True Then
                If numero(conn) = "." Then
                    punto = True
                    conn += 1
                Else
                    nuevonumero += numero(conn)
                    conn += 1
                End If
            Else
                dpunto += numero(conn)
                conn += 1
            End If

            primera = False
        End While



        If nuevonumero.Length = 1 Then
            get1_9(CInt(nuevonumero))
        ElseIf nuevonumero.Length = 2 Then
            get10_99(CInt(nuevonumero))
        ElseIf nuevonumero.Length = 3 Then
            get100_999(CInt(nuevonumero))
        ElseIf nuevonumero.Length = 4 Then
            get1000_9999(CInt(nuevonumero))
        ElseIf nuevonumero.Length = 5 Then
            get10000_99999(CInt(nuevonumero))
        End If

    End Sub

    Public Function getnumero() As String
        Return strnumero
    End Function

    Public Function getdecimal() As String
        Return dpunto
    End Function

    Private Sub get1_9(ByVal num As Integer)

        dtnumerosa = tnumros.Consultar(" where numero < 10  and idnumeros = " & num.ToString)

        strnumero += dtnumerosa.Rows(0).Item(2).ToString

    End Sub

    Private Sub get10_99(ByVal num1 As Integer)
        Dim num As String = CStr(num1)

        If num(1).ToString = "0" Then
            dtnumerosa = tnumros.Consultar(" where numero < 100  and numero > 9 and numero = " & num.ToString)
            strnumero += dtnumerosa.Rows(0).Item(2).ToString
        Else
            If num(0).ToString = "1" Or num(0).ToString = "2" Then
                dtnumerosa = tnumros.Consultar(" where numero = " & num.ToString)
                strnumero += dtnumerosa.Rows(0).Item(2).ToString
            Else
                dtnumerosa = tnumros.Consultar(" where numero < 100  and numero > 9 and numero = " & num(0).ToString & "0")
                strnumero += dtnumerosa.Rows(0).Item(2).ToString

                strnumero += " y "
                setnumero(CInt(num(1).ToString))
            End If

        End If



    End Sub

    Private Sub get100_999(ByVal num1 As Integer)

        Dim num As String = CStr(num1)

        If (num(1).ToString & num(2).ToString).ToString = "00" Then
            dtnumerosa = tnumros.Consultar(" where numero < 1000  and numero > 90 and numero = " & num.ToString)
            strnumero += dtnumerosa.Rows(0).Item(2).ToString
        ElseIf num(2).ToString = "0" Then
            dtnumerosa = tnumros.Consultar(" where numero < 1000  and numero > 90 and numero = " & num(0).ToString & "00")
            If num(0).ToString = "1" Then
                strnumero += dtnumerosa.Rows(0).Item(2).ToString & "to "
            Else
                strnumero += dtnumerosa.Rows(0).Item(2).ToString & " "
            End If
            setnumero(CInt((num(1) & "0").ToString))

        ElseIf num(1).ToString = "0" Then
            dtnumerosa = tnumros.Consultar(" where numero < 1000  and numero > 90 and numero = " & num(0).ToString & "00")
            If num(0).ToString = "1" Then
                strnumero += dtnumerosa.Rows(0).Item(2).ToString & "to "
            Else
                strnumero += dtnumerosa.Rows(0).Item(2).ToString & " "
            End If
            setnumero(CInt(num(2).ToString))
        Else
            If num(1).ToString = "1" Then
                dtnumerosa = tnumros.Consultar(" where numero < 1000  and numero > 90 and numero = " & num(0).ToString & "00")
                If num(0).ToString = "1" Then
                    strnumero += dtnumerosa.Rows(0).Item(2).ToString & "to "
                Else
                    strnumero += dtnumerosa.Rows(0).Item(2).ToString & " "
                End If

                dtnumerosa = tnumros.Consultar(" where numero = " & num(1).ToString & num(2).ToString)
                strnumero += dtnumerosa.Rows(0).Item(2).ToString
            Else
                dtnumerosa = tnumros.Consultar(" where numero < 1000  and numero > 90 and numero = " & num(0).ToString & "00")
                If num(0).ToString = "1" Then
                    strnumero += dtnumerosa.Rows(0).Item(2).ToString & "to "
                Else
                    strnumero += dtnumerosa.Rows(0).Item(2).ToString & " "
                End If
                setnumero(CInt(num(1) & num(2).ToString))

            End If
        End If

    End Sub

    Private Sub get1000_9999(ByVal num1 As Integer)
        Dim num As String = CStr(num1)
        If (num(1) & num(2) & num(3)).ToString = "000" Then
            dtnumerosa = tnumros.Consultar(" where numero = " & num)
            strnumero += dtnumerosa.Rows(0).Item(2)
        ElseIf (num(2) & num(3)).ToString = "00" Then
            dtnumerosa = tnumros.Consultar(" where numero = " & num(0) & "000")
            strnumero += dtnumerosa.Rows(0).Item(2) & " "
            setnumero(CInt((num(1) & num(2) & num(3)).ToString))
        Else
            dtnumerosa = tnumros.Consultar(" where numero = " & num(0) & "000")
            strnumero += dtnumerosa.Rows(0).Item(2) & " "
            setnumero(CInt((num(1) & num(2) & num(3)).ToString))

        End If
    End Sub

    Private Sub get10000_99999(ByVal num1 As Integer)
        Dim num As String = CStr(num1)
        If (num(1) & num(2) & num(3) & num(4)).ToString = "0000" Then
            dtnumerosa = tnumros.Consultar(" where numero = " & num)
            strnumero += dtnumerosa.Rows(0).Item(2)
        ElseIf (num(2) & num(3) & num(4)).ToString = "000" Then
            setnumero(CInt((num(0) & num(1)).ToString))
            strnumero += " mil"
        Else
            setnumero(CInt((num(0) & num(1)).ToString))
            strnumero += " mil "

            setnumero(CInt((num(2) & num(3) & num(4)).ToString))
        End If
    End Sub

End Class
