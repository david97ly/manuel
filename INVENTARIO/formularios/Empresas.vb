Imports System.Windows.Forms
Imports logica
Imports validaciones
Public Class Empresas
    Public controlgrub As Short = 0
    Dim clsDAtos As DatosEmpresa
    Public donde As String = "here"
    Dim Departamento As New clsMaestros(clsNomTab.eTbl.Departamentos)
    Dim Municipio As New clsMaestros(clsNomTab.eTbl.Municipios)
    Dim dtempresa As DataTable
    Dim dtDepartamento As DataTable
    Dim dtMunicipio As DataTable
    Dim coddepar As Short
    Dim codmuni As Short
    Public edit As Boolean = False
    Public dtempresas As DataRow
    Public cambio As String = "no"
    Public frmp As Proveedores
    Public frmc As Clientes
    Dim clsvalidar As New validar
    Private Sub Empresas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MdiParent = mdiMain
      
        Ocultargrubempresa()
    End Sub

    Public Sub Ocultargrubempresa()
        Try
            Me.combodeparN.Items.Clear()

            dtDepartamento = Departamento.Consultar()

            For i As Short = 0 To dtDepartamento.Rows.Count - 1
                Me.combodeparN.Items.Add(dtDepartamento.Rows(i).Item(1))

            Next
          



                If edit = True Then
                    cargardatosmod()
                End If

            controlgrub = 0
        Catch ex As Exception

        End Try

    End Sub




    Private Function camposvacios()
        Try
            Dim f As Boolean = False

          

            If Me.texnomempresa.Text = "" Then
                lcamposObligatorios.ForeColor = Color.Red
                lnempresa.ForeColor = Color.Red
                f = True
            Else
                lnempresa.ForeColor = Color.Black
            End If


         

            If Me.texgiro.Text = "" Then
                lcamposObligatorios.ForeColor = Color.Red
                lgiro.ForeColor = Color.Red
                f = True
            Else
                lgiro.ForeColor = Color.Black
            End If

            If Me.texnrc.Text = "" Then
                lcamposObligatorios.ForeColor = Color.Red
                lnrc.ForeColor = Color.Red
                f = True
            Else
                lnrc.ForeColor = Color.Black
            End If

            If Me.texnit.Text = "" Then
                lcamposObligatorios.ForeColor = Color.Red
                lnit.ForeColor = Color.Red
                f = True
            Else
                lnit.ForeColor = Color.Black
            End If


            If combodeparN.Text = "" Then
                lcamposObligatorios.ForeColor = Color.Red
                ldepan.ForeColor = Color.Red
                f = True
            Else
                ldepan.ForeColor = Color.Black
            End If

            If combomuniN.Text = "" Then
                lcamposObligatorios.ForeColor = Color.Red
                lmunim.ForeColor = Color.Red
                f = True
            Else
                lmunim.ForeColor = Color.Black
            End If

           

            If Me.texnumeroN.Text = "" Then
                lcamposObligatorios.ForeColor = Color.Red
                lnumn.ForeColor = Color.Red
                f = True
            Else
                lnumn.ForeColor = Color.Black
            End If

            If texdireccionN.Text = "" Then
                lcamposObligatorios.ForeColor = Color.Red
                ldirecn.ForeColor = Color.Red
                f = True
            Else
                ldirecn.ForeColor = Color.Black
            End If

        

            If f = True Then
                Return f
            Else
                Return f
            End If
        Catch ex As Exception
            Return False
        End Try
    End Function


    Private Sub limpiar(ByVal v As Short)
        Try
            If v = 1 Or v = 5 Then
                Me.texnomempresa.Text = ""
                Me.texgiro.Text = ""
                Me.texnit.Text = ""
                Me.texnrc.Text = ""
            End If
            If v = 2 Or v = 5 Then
                Me.combodeparN.Text = ""
                Me.combomuniN.Items.Clear()
                Me.combomuniN.Text = ""
                Me.texdireccionN.Text = ""
            End If
         
            If v = 4 Or v = 5 Then

                Me.texnumeroN.Text = ""
                Me.texfaxN.Text = ""
                Me.texemail.Text = ""
            End If
        Catch ex As Exception
            MsgBox("Ocurrio un error asegurese de haber llenado todos los campo correctamente", MsgBoxStyle.OkOnly, "Avise")
        End Try

    End Sub

    Private Sub botborrar1_Click(sender As Object, e As EventArgs)
        limpiar(1)
    End Sub


    Private Sub botsalirdatos_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub


    Private Sub cargardatosmod()
        Try
            Me.texnomempresa.Text = dtempresas.Item(1)
            Me.texgiro.Text = dtempresas.Item(4)
            Me.texnit.Text = dtempresas.Item(2)
            Me.texnrc.Text = dtempresas.Item(3)
            Me.texnumeroN.Text = dtempresas.Item(6)
            Me.texfaxN.Text = dtempresas.Item(7)
            Me.texemail.Text = dtempresas.Item(8)
            edit = True
        Catch ex As Exception
            MsgBox("Ocurrio un error razon: " & ex.Message, MsgBoxStyle.Critical, "Aviso")
        End Try


    End Sub


    Private Sub texnomempresa_KeyPress(sender As Object, e As KeyPressEventArgs)
        e.Handled = clsvalidar.onlyletters(e)
    End Sub



    Private Sub botnuevo_Click_1(sender As Object, e As EventArgs)
        controlgrub = 1
        Ocultargrubempresa()
    End Sub




    Private Sub botborrar1_Click_1(sender As Object, e As EventArgs) Handles botborrar1.Click
        limpiar(1)
    End Sub

    Private Sub botborrar4_Click_1(sender As Object, e As EventArgs) Handles botborrar4.Click
        limpiar(4)
    End Sub

    Private Sub botguardar_Click(sender As Object, e As EventArgs) Handles botguardar.Click
        Try
            If camposvacios() Then

                
                If donde = "clientes" Then
                    MsgBox("Todabia faltan campos que llenar", MsgBoxStyle.Critical, "Aviso")
                ElseIf donde = "proveedores" Then
                    MsgBox("Todabia faltan campos que llenar", MsgBoxStyle.Critical, "Aviso")
                End If


            Else
                If edit = True Then
                    If donde = "proveedores" Then
                        clsDAtos = New DatosEmpresa(Me, donde, dtempresas.Item(0))
                        clsDAtos.Actualizar()
                    ElseIf donde = "clientes" Then
                        clsDAtos = New DatosEmpresa(Me, donde, dtempresas.Item(0))
                        clsDAtos.Actualizar()
                    Else
                        clsDAtos = New DatosEmpresa(Me, donde, dtempresas.Item(0))
                        clsDAtos.Actualizar()
                    End If


                Else
                    clsDAtos = New DatosEmpresa(Me, Me.donde, "nada")
                    clsDAtos.Insertar()

                End If

                If donde = "proveedores" Or donde = "clientes" Then
                    limpiar(5)
                    controlgrub = 0
                    Ocultargrubempresa()
                    Me.Close()
                    If donde = "proveedores" Then
                        frmp.f = True
                        frmp.cargargrid()
                        Me.Close()
                    Else
                        Dim frmc1 As New Clientes
                        frmc1.f = True
                        frmc.Close()
                        frmc1.cargargrid()
                        frmc1.Show()
                        Me.Close()
                    End If
                End If
            End If

        Catch ex As Exception
            MsgBox("Ocurrio un error asegurese de haber llenado todos los campo correctamente", MsgBoxStyle.OkOnly, "Avise")
        End Try


    End Sub

    Private Sub botboarrartodo_Click_1(sender As Object, e As EventArgs) Handles botboarrartodo.Click
        limpiar(5)
    End Sub

    Private Sub botsalirdatos_Click_2(sender As Object, e As EventArgs) Handles botsalirdatos.Click
        Try
            Me.Close()
        Catch ex As Exception

        End Try
      
    End Sub

    Private Sub texcodigo_KeyPress1(sender As Object, e As KeyPressEventArgs)
        e.Handled = clsvalidar.onlynumero(e)
    End Sub




    Private Sub combodeparN_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles combodeparN.SelectedIndexChanged
        Try
            dtMunicipio = Departamento.Consultar(" where departamentos = '" & Me.combodeparN.Text.ToString.Trim & "'")
            codmuni = dtMunicipio.Rows(0).Item(0)
            dtMunicipio = Municipio.Consultar(" where cod_departamento = " & codmuni)
            Me.combomuniN.Text = ""
            Me.combomuniN.Items.Clear()
            For i As Short = 0 To dtMunicipio.Rows.Count - 1
                Me.combomuniN.Items.Add(dtMunicipio.Rows(i).Item(1))
            Next
        Catch ex As Exception
            MsgBox("Ocurrio un error asegurese de haber llenado todos los campo correctamente", MsgBoxStyle.OkOnly, "Avise")
        End Try

    End Sub

    

    Private Sub botboarrar3_Click_1(sender As Object, e As EventArgs)
        limpiar(3)
    End Sub

    Private Sub botborrar2_Click(sender As Object, e As EventArgs) Handles botborrar2.Click
        limpiar(2)
    End Sub




    Private Sub botsalir_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub grubempresas_Click(sender As Object, e As EventArgs)

    End Sub
End Class