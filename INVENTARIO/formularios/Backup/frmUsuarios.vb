Imports pjtProAdus
Public Class frmUsuarios
    Private dtusr As DataTable
    Private dtUsrGrp As DataTable
    Private idgrp As String
    Private accion As String
    Private obUsr As New clsMaestros(clsNomTab.eTbl.Usr)
    Private obGen As New clsProcesos
    Private Sub frmUsuarios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = mdiMain
        'Dando formato a la cuadricula
        Me.DataGridView1.ColumnCount = 2
        Me.DataGridView1.Columns(0).Width = 100
        Me.DataGridView1.Columns(1).Width = 200
        Me.DataGridView1.Columns(0).HeaderText = "Login"
        Me.DataGridView1.Columns(1).HeaderText = "Nombres"
        'Llenando el combo de Estado del usuario
        Me.ComboBox2.Items.Add("Activo")
        Me.ComboBox2.Items.Add("Inactivo")
        Me.ComboBox2.SelectedIndex = 0
        Me.TextBox6.Enabled = False
    End Sub
    Private Sub ActualizaGrid()
        Dim i As Short = 0
        dtusr = obUsr.Consultar()
        dtUsrGrp = obGen.Consultar("SELECT a.IdUsr, a.cNom, a.cApe, b.IdGrp, b.IdGrpUSr FROM usr a, grpusr b WHERE a.IdUsr = b.IdUsr AND b.IdGrp='" & idgrp & "'")
        If dtUsrGrp.Rows.Count = 0 Then
            Me.DataGridView1.RowCount = 1
            Me.DataGridView1.Rows.Clear()
        Else
            Me.DataGridView1.RowCount = dtUsrGrp.Rows.Count
        End If
        For Each dr As DataRow In dtUsrGrp.Rows
            Me.DataGridView1.Rows(i).Cells(0).Value = dr.Item(0)
            Me.DataGridView1.Rows(i).Cells(1).Value = dr.Item(1) & " " & dr.Item(2)
            i = i + 1
        Next
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        'Boton Agregar Usuarios
        If Me.idgrp = "" Then
            MessageBox.Show("Debe de Seleccionar un grupo")
        Else
            Me.accion = "AD"
            Me.TextBox1.Text = ""
            Me.TextBox2.Text = ""
            Me.TextBox3.Text = ""
            Me.TextBox4.Text = ""
            Me.TextBox5.Text = ""
            Me.TextBox1.Enabled = True
            Me.TextBox4.Enabled = True
            Me.TextBox5.Enabled = True
            Edicion(True)
        End If
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        'Boton Modificar
        Me.accion = "MO"
        Dim mEst As String
        Dim fs As Short = 0
        Dim idFiltro As String
        Dim dtmFiltro As New DataView(dtusr)
        Try
            fs = Me.DataGridView1.CurrentCell.RowIndex
            idFiltro = Me.dtUsrGrp.Rows(fs).Item(0).ToString
            dtmFiltro.RowFilter = dtusr.Columns("IdUsr").ColumnName & " = '" & idFiltro & "'"
            Me.TextBox1.Text = dtmFiltro.Item(0).Item(0)
            Me.TextBox2.Text = dtmFiltro.Item(0).Item(1)
            Me.TextBox3.Text = dtmFiltro.Item(0).Item(2)
            Me.TextBox4.Text = ""
            Me.TextBox5.Text = ""
            mEst = dtmFiltro.Item(0).Item(3)
            If mEst = "A" Then
                Me.ComboBox2.SelectedIndex = 0
            Else
                Me.ComboBox2.SelectedIndex = 1
            End If
            Edicion(True)
            Me.TextBox1.Enabled = False
            Me.TextBox4.Enabled = False
            Me.TextBox5.Enabled = False
        Catch ex As Exception
            MessageBox.Show("No ha seleccionado ningun usuario ")
        End Try
    End Sub
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        'Boton Eliminar
        Dim fs As Short = 0
        Dim idFiltroGrp As String
        Dim idFiltroUsr As String
        Try
            fs = Me.DataGridView1.CurrentCell.RowIndex
            idFiltroUsr = Me.dtUsrGrp.Rows(fs).Item(0).ToString
            idFiltroGrp = dtUsrGrp.Rows(fs).Item(4)
            If obGen.Ejecutar("DELETE FROM grpusr WHERE IdGrpUSr='" & idFiltroGrp & "'") = 0 Then
                MessageBox.Show("Hubo un problema en la Eliminacion")
            Else
                If obGen.Ejecutar("DELETE FROM usr WHERE IdUsr='" & idFiltroUsr & "'") = 0 Then
                    MessageBox.Show("Hubo un error secundarion en la Eliminacion")
                End If
            End If
            Me.ActualizaGrid()
        Catch ex As Exception
            MessageBox.Show("No ha seleccionado ningun usuario ")
        End Try
    End Sub
    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        'Boton Salir
        Me.Close()
    End Sub
    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        'Boton Aceptar
        Dim mIdUsr As String = Me.TextBox1.Text
        Dim mNom As String = Me.TextBox2.Text.ToUpper
        Dim mApe As String = Me.TextBox3.Text.ToUpper
        Dim mClave1 As String = Me.TextBox4.Text
        Dim mClave2 As String = Me.TextBox5.Text
        Dim mEst As String = Me.ComboBox2.Items.Item(Me.ComboBox2.SelectedIndex)
        If Me.accion = "AD" Then
            'Insercion
            If mClave1 = mClave2 Then
                If mEst = "Activo" Then
                    mEst = "A"
                Else
                    mEst = "I"
                End If
                If obGen.Ejecutar("INSERT INTO usr (IdUsr,cNom,cApe,cClave,cEstado) VALUES ('" & mIdUsr & "','" & mNom & "','" & mApe & "',MD5('" & mClave1 & "'),'" & mEst & "')") = 0 Then
                    MessageBox.Show("Hubo un problema en la Insercion")
                Else
                    If obGen.Ejecutar("INSERT INTO grpusr (IdGrp,IdUsr) VALUES ('" & Me.idgrp & "','" & mIdUsr & "')") = 0 Then
                        MessageBox.Show("Hubo un Error Secundario en la insercion")
                    End If
                End If
                Me.ActualizaGrid()
            Else
                MessageBox.Show("Las claves no coinciden")
                Me.TextBox4.Text = ""
                Me.TextBox5.Text = ""
                Me.TextBox4.Focus()
            End If
        Else
            'Modificacion
            If mEst = "Activo" Then
                mEst = "A"
            Else
                mEst = "I"
            End If
            If obGen.Ejecutar("UPDATE usr SET cNom='" & mNom & "',cApe='" & mApe & "',cEstado='" & mEst & "' WHERE IdUsr='" & mIdUsr & "'") = 0 Then
                MessageBox.Show("Hubo un problema en la Actualizacion")
            Else
                Me.ActualizaGrid()
            End If
        End If
        Edicion(False)
    End Sub
    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        'Boton Cancelar
        Edicion(False)
    End Sub
    Private Sub Edicion(ByVal Activar As Boolean)
        If Activar Then
            Me.DataGridView1.Visible = False
            Me.Button1.Enabled = False
            Me.Button2.Enabled = False
            Me.Button3.Enabled = False
            Me.Button4.Enabled = False
        Else
            Me.DataGridView1.Visible = True
            Me.Button1.Enabled = True
            Me.Button2.Enabled = True
            Me.Button3.Enabled = True
            Me.Button4.Enabled = True
        End If
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'Busqueda de Grupos
        Dim rcmp As String
        frmBusqueda.tituloB = "Busqueda de Grupos"
        frmBusqueda.ShowDialog()
        rcmp = frmBusqueda.Resultado
        frmBusqueda.Close()
        If rcmp = "" Then
            MessageBox.Show("No selecciono ningun registro")
        Else
            Me.TextBox6.Text = rcmp
            Me.idgrp = rcmp.Substring(0, rcmp.IndexOf("|") - 1)
            ActualizaGrid()
        End If
    End Sub
End Class