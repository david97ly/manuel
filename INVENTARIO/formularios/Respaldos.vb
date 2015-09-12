Imports logica
Imports System.IO.StreamWriter
Imports System.IO

Public Class Respaldos
    Dim carpeta As New FolderBrowserDialog
    Dim consultar As New clsProcesos

    Dim dtrespados1 As DataTable
    Dim trespaldos1 As New clsMaestros(clsNomTab.eTbl.Respaldo)

    Private Sub botrespladar_Click(sender As Object, e As EventArgs) Handles botrespladar.Click
        respaldar.DefaultExt = "sql"
        Dim pathmysql As String
        Dim comando As String
        pathmysql = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Wow6432Node\MySQL AB\MYSQL Server 5.1", "Location", 0)
        If pathmysql = Nothing Then
            MsgBox("No se encontro en tu equipo Mysql, escoge la carpeta donde esta ubicado")
            carpeta.ShowDialog()
            pathmysql = carpeta.SelectedPath
        End If
        Dim nombrearchivo As String
        Dim dtrespaldo As DataTable
        Dim trespaldo As New clsMaestros(clsNomTab.eTbl.Respaldo)


        trespaldo.Insertar("'" & System.DateTime.Now & "','Respaldo',' '")
        dtrespaldo = consultar.Consultar("select max(idrespaldo) from respaldos")
        consultar.Consultar("update respaldos set nombrearchivo = 'Respaldo" & dtrespaldo.Rows(0).Item(0).ToString & "' where idrespaldo = " & dtrespaldo.Rows(0).Item(0).ToString)



        nombrearchivo = "Respaldo" & dtrespaldo.Rows(0).Item(0).ToString & ".sql"
        ' Dim ruta As String = "D:\SISTEMAS DE LA UNIVERSIDAD\AUDITORIA DE SISTEMAS\INVENTARIO DE GASOLINERA CON MONITOREO DE BOMBAS AL FINAL DEL DIA\INVENTARIO\Respaldos\"
        Dim ruta As String = "E:\SISTEMA DEL HERMANO MANUEL\SYSTEMANUEL\INVENTARIO\Respaldos\"
        MsgBox("Esta es a ruta: " & ruta, MsgBoxStyle.Information, "Aviso de respaldo")

        Try
            comando = pathmysql & "\bin\mysqldump --user=root --password=root --databases manuelbd -r """ & ruta & nombrearchivo & """"
            Shell(comando, AppWinStyle.MinimizedFocus, True)

            cargargrid()

            MsgBox("La Base de datos se respaldo exitosamente", MsgBoxStyle.Information, "EXITO")
        Catch ex As Exception
            MsgBox("Ocurrio un error al respaldar", MsgBoxStyle.Critical, "Informacion")
        End Try


    End Sub

    Private Sub botrestaurar_Click(sender As Object, e As EventArgs) Handles botrestaurar.Click

        Dim id As Short = Me.gridrespaldos.CurrentCell.RowIndex


        Try

            If MsgBox("Se restablecerán los datos a una fecha anterior desea continuar se perderán todos los datos no respaldados", MsgBoxStyle.YesNo, "Aviso") = MsgBoxResult.Yes Then


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

                Dim nombrearchivo As String = dtrespados1.Rows(id).Item(2).ToString & ".sql"
                ' Dim ruta As String = "D:\SISTEMAS DE LA UNIVERSIDAD\AUDITORIA DE SISTEMAS\INVENTARIO DE GASOLINERA CON MONITOREO DE BOMBAS AL FINAL DEL DIA\INVENTARIO\Respaldos\"
                Dim ruta As String = "E:\SISTEMA DEL HERMANO MANUEL\SYSTEMANUEL\INVENTARIO\Respaldos\"
                comando = pathmysql & "\bin\mysql.exe"
                comando.Replace("\\", "\")
                arg = "mysql --user=root --password=root --host=localhost --database manuelbd < " & Chr(34) & ruta & nombrearchivo & Chr(34)
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

                MsgBox("La Base de datos se ha restablecido exitosamente", MsgBoxStyle.Information, "EXITO")


            End If
        Catch ex As Exception
            MsgBox("aqui ocurrio el error porque: ", ex.Message)
        End Try

    End Sub

    Private Sub Respaldos_Disposed(sender As Object, e As EventArgs) Handles Me.Disposed
        If Me.cherresauto.Checked = True Then
            consultar.Consultar("update respaldos set automatico = 'true'")
        Else
            consultar.Consultar("update respaldos set automatico = 'false'")
        End If
    End Sub

    Private Sub Respaldos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            MdiParent = mdiMain
            cargargrid()
        Catch ex As Exception

        End Try

    End Sub


    Private Sub cargargrid()
        dtrespados1 = trespaldos1.Consultar()

        Dim cf As Short = dtrespados1.Rows.Count

        Me.gridrespaldos.RowCount = cf



        If cf = 0 Then
            Me.gridrespaldos.RowCount = 1
            Me.gridrespaldos.Rows(0).Cells(0).Value = ""
            Me.gridrespaldos.Rows(0).Cells(1).Value = ""
            Me.gridrespaldos.Rows(0).Cells(2).Value = ""

        Else
            Me.gridrespaldos.RowCount = cf
            If dtrespados1.Rows(0).Item(3).ToString.Trim = "true" Then
                Me.cherresauto.Checked = True
            Else
                Me.cherresauto.Checked = False
            End If
        End If

        For i As Integer = 0 To dtrespados1.Rows.Count - 1
            Me.gridrespaldos.Rows(i).Cells(0).Value = dtrespados1.Rows(i).Item(0)
            Me.gridrespaldos.Rows(i).Cells(1).Value = dtrespados1.Rows(i).Item(1)
            Me.gridrespaldos.Rows(i).Cells(2).Value = dtrespados1.Rows(i).Item(2)
        Next
    End Sub
End Class