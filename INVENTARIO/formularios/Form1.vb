Imports System.IO.StreamWriter
Imports System.IO
Imports logica
Public Class Form1

    Dim carpeta As New FolderBrowserDialog



    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Try
            abrir.DefaultExt = "sql"
            Dim pathmysql As String
            Dim comando As String
            Dim arg As String
            abrir.Filter = "File MYSQL (*.sql)|*.sql"
            pathmysql = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Wow6432Node\MySQL AB\MYSQL Server 5.1", "Location", 0)
            If pathmysql = Nothing Then
                MsgBox("No se encontro en tu equipo Mysql, escoge la carpeta donde esta ubicado")
                carpeta.ShowDialog()
                pathmysql = carpeta.SelectedPath
            End If

            If abrir.ShowDialog() = Windows.Forms.DialogResult.OK Then

                comando = pathmysql & "\bin\mysql.exe"
                comando.Replace("\\", "\")
                arg = "mysql --user=root --password=root --host=localhost --database inventariome < " & Chr(34) & abrir.FileName & Chr(34)
                Dim proceso As New Process
                proceso.StartInfo.FileName = "cmd.exe"
                proceso.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
                proceso.StartInfo.UseShellExecute = False
                proceso.StartInfo.RedirectStandardOutput = True
                proceso.StartInfo.RedirectStandardInput = True
                proceso.StartInfo.CreateNoWindow = True
                proceso.Start()
                Dim escribeconsola As StreamWriter = proceso.StandardInput
                Dim leyendoconsola As StreamReader = proceso.StandardOutput
                escribeconsola.WriteLine(arg)
                escribeconsola.Close()
                proceso.WaitForExit()
                proceso.Close()




            End If
        Catch ex As Exception
            MsgBox("aqui ocurrio el error porque: ", ex.Message)
        End Try

    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        respaldar.DefaultExt = "sql"
        Dim pathmysql As String
        Dim comando As String
        pathmysql = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Wow6432Node\MySQL AB\MYSQL Server 5.1", "Location", 0)
        If pathmysql = Nothing Then
            MsgBox("No se encontro en tu equipo Mysql, escoge la carpeta donde esta ubicado")
            carpeta.ShowDialog()
            pathmysql = carpeta.SelectedPath
        End If
        respaldar.Filter = "File MYSQL (*.sql)|*.sql"
        If respaldar.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Try
                comando = pathmysql & "\bin\mysqldump --user=root --password=root --databases inventariome -r """ & respaldar.FileName & """"
                Shell(comando, AppWinStyle.MinimizedFocus, True)
            Catch ex As Exception
                MsgBox("Ocurrio un error al respaldar", MsgBoxStyle.Critical, "Informacion")
            End Try

        End If
    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim dtfactura As DataTable
        Dim factura As New clsMaestros(clsNomTab.eTbl.FacturaVenta)

        dtfactura = factura.Consultar(" where numfacturav = 2541")
        Dim fecha As Date = CDate(dtfactura.Rows(0).Item(5))
        MsgBox(fecha.Day & "/" & fecha.Month & "/" & fecha.Year)
    End Sub
End Class