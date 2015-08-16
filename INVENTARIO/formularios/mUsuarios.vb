Imports logica

Public Class mUsuarios
    Private dtu As DataTable
    Private accion As String
    Private musr As New clsMaestros(clsNomTab.eTbl.Usr)


    Private Sub mUsuarios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = mdiMain
        'Dando formato a la cuadricula
        Me.DataGridView1.ColumnCount = 2
        Me.DataGridView1.Columns(0).Width = "150"
        Me.DataGridView1.Columns(1).Width = "200"
        Me.DataGridView1.Columns(0).HeaderText = "Login"
        Me.DataGridView1.Columns(1).HeaderText = "Usuario"
        ActualizaGrid()
        'Llenando el combo para el estado
        Me.ComboBox1.Items.Add("Activo")
        Me.ComboBox1.Items.Add("Inactivo")
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'Aceptar
        Dim mLogin As String
        Dim mNombres As String
        Dim mApellidos As String
        Dim mClave As String
        Dim mEstado As String
        Me.TextBox1.Enabled = True
        mLogin = Me.TextBox1.Text.ToString.Trim
        mNombres = Me.TextBox2.Text.ToString.Trim.ToUpper()
        mApellidos = Me.TextBox3.Text.ToString.Trim.ToUpper()
        mClave = Me.TextBox4.Text.ToString.Trim
        If Me.ComboBox1.SelectedIndex = 0 Then
            mEstado = "A"
        Else
            mEstado = "I"
        End If
        If Me.TextBox5.Text.ToString.Trim = mClave Then
            Try
                If Me.accion = "AD" Then
                    musr.Insertar("'" & mLogin & "','" & mNombres & "','" & mApellidos & "','" & mClave & "','" & mEstado & "'")
                Else
                    musr.Actualizar("'" & mLogin & "'|'" & mNombres & "'|'" & mApellidos & "'|'" & mEstado & "'")
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
            Ed(True)
            ActualizaGrid()
        Else
            MessageBox.Show("Las contraseñas no coinciden")
            Me.TextBox4.Text = ""
            Me.TextBox5.Text = ""
            Me.TextBox4.Focus()
        End If
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        'Cancela
        Ed(True)
        Me.TextBox1.Enabled = True
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        'Agrega
        Me.TextBox4.Enabled = True
        Me.TextBox5.Enabled = True
        Me.accion = "AD"
        Me.TextBox1.Text = ""
        Me.TextBox2.Text = ""
        Me.TextBox3.Text = ""
        Me.TextBox4.Text = ""
        Me.TextBox5.Text = ""
        Me.TextBox1.Focus()
        Ed(False)
    End Sub
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        'Modifica
        Me.TextBox1.Enabled = False
        Dim fs As Short = Me.DataGridView1.CurrentCell.RowIndex
        'Asignando valores del datatable
        Me.TextBox1.Text = Me.dtu.Rows(fs).Item(0).ToString
        Me.TextBox2.Text = Me.dtu.Rows(fs).Item(1).ToString
        Me.TextBox3.Text = Me.dtu.Rows(fs).Item(2).ToString
        Me.TextBox4.Enabled = False
        Me.TextBox5.Enabled = False
        If dtu.Rows(fs).Item(4).ToString = "A" Then
            Me.ComboBox1.SelectedIndex = 0
        Else
            Me.ComboBox1.SelectedIndex = 1
        End If
        Me.TextBox1.Focus()
        Me.accion = "MO"
        Ed(False)
    End Sub
    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        'Elimina
        Dim Login As String
        Dim fs As Short = Me.DataGridView1.CurrentCell.RowIndex
        Login = Me.dtu.Rows(fs).Item(0)
        Try
            If musr.Eliminar("'" & Login & "'") <= 0 Then
                MessageBox.Show("El registro no se eliminó")
            Else
                Me.ActualizaGrid()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Me.Close()
    End Sub
    'Metodos definidos por el usuario
    Private Sub Ed(ByVal valor As Boolean)
        If valor Then
            Me.DataGridView1.Visible = True
            Me.Button3.Enabled = True
            Me.Button4.Enabled = True
            Me.Button5.Enabled = True
        Else
            Me.DataGridView1.Visible = False
            Me.Button3.Enabled = False
            Me.Button4.Enabled = False
            Me.Button5.Enabled = False
        End If
    End Sub
    Private Sub ActualizaGrid()
        Dim nf As Short
        Try
            dtu = musr.Consultar()
            nf = dtu.Rows.Count
            If nf = 0 Then
                Me.DataGridView1.RowCount = 1
            Else
                Me.DataGridView1.RowCount = nf
            End If
            For i As Integer = 0 To dtu.Rows.Count - 1
                Me.DataGridView1.Rows(i).Cells(0).Value = dtu.Rows(i).Item(0).ToString
                Me.DataGridView1.Rows(i).Cells(1).Value = dtu.Rows(i).Item(1).ToString & " " & dtu.Rows(i).Item(2).ToString
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class