Public Class clsNomTab
    Private ctbl As String
    Public Enum eTbl
        Grp = 1
        Usr = 2
        Menu = 3
        GrpUsr = 4
        Permisos = 5
        Proveedores = 6
        Clientes = 7
        FacturaCompra = 8
        FacturaVenta = 9
        DetalleFacturaC = 10
        DetalleFacturaV = 11
        Departamentos = 12
        Municipios = 13
        Categorias = 14
        Productos = 15
        Numeros = 16
        clientescf = 17
        tiraje = 18
        Respaldo = 19
        Configuraciones = 20
        Direccion = 21
        notificaciones = 22
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
            Case 2
                Resultado = "usr"
            Case 3
                Resultado = "menu"
            Case 4
                Resultado = "grpusr"
            Case 5
                Resultado = "permisos"
            Case 6
                Resultado = "proveedor"
            Case 7
                Resultado = "cliente"
            Case 8
                Resultado = "facturacompra"
            Case 9
                Resultado = "facturaventa"
            Case 10
                Resultado = "detallecompra"
            Case 11
                Resultado = "detalleventa"
            Case 12
                Resultado = "departamentos"
            Case 13
                Resultado = "municipios"
            Case 14
                Resultado = "categoria"
            Case 15
                Resultado = "productos"
            Case 16
                Resultado = "numeros"
            Case 17
                Resultado = "clientescf"
            Case 18
                Resultado = "tirajes"
            Case 19
                Resultado = "respaldos"
            Case 20
                Resultado = "configuraciones"
            Case 21
                Resultado = "direccion"
            Case 22
                Resultado = "notificaciones"
        End Select
        Return Resultado
    End Function
    Private Function getCamposSelect(ByVal Tabla As Short) As String
        Dim Resultado As String = ""
        Select Case Tabla
            Case 1
                Resultado = "IdGrp,cGrp"
            Case 2
                Resultado = "IdUsr, cNom, cApe,cClave, cEstado"
            Case 3
                Resultado = "IdOpc,cNomOpc,nIdBar,cAccion,cDescripcion"
            Case 4
                Resultado = "IdGrpUsr,IdGrp,IdUsr"
            Case 5
                Resultado = "IdPermiso,IdGrp,IdOpc"
            Case 6
                Resultado = "codproveedor,nombre,nit,nrc,giro,direccion,telefono,fax,e_mail,estado"
            Case 7
                Resultado = "codcliente,nombre,nit,nrc,giro,direccion,telefono,fax,e_mail,estado"
            Case 8
                Resultado = "codfacturac,numfacturac,tipo,codproveedor,fecha,sumas,descuento,iva,nosujeta,exentas,total,formadepago,unoretencion,estado,tiraje"
            Case 9
                Resultado = "codfacturav,numfacturav,tipo,codcliente,fecha,sumas,descuento,iva,nosujeta,exentas,total,formadepago,estado,tiraje"
            Case 10
                Resultado = "coddetallefacturac,codfacturac,codproducto,cantidadunit,descuento,precioreal,preciodescuento,total,total1,preciopublico"
            Case 11
                Resultado = "coddetallefacturav,codfacturav,codproducto,cantidadunit,descuento,precioreal,preciodescuento,total,total1,preciopublico"
            Case 12
                Resultado = "cod_departamento,departamentos"
            Case 13
                Resultado = "id_municipio,municipio,cod_departamento"
            Case 14
                Resultado = "id_categoria,nombre,descripcion"
            Case 15
                Resultado = "codproducto,nombre,descripcion,precio_unit,precioindi,preciopublico,existencias,id_categoria,unid_med,valida"
            Case 16
                Resultado = "idnumeros,numero,nombre"
            Case 17
                Resultado = "idclientescf,cliente"
            Case 18
                Resultado = "idtiraje,tirajefs,tirajefd,tirajefh,tirajefa,tirajecs,tirajecd,tirajech,tirajeca"
            Case 19
                Resultado = "idrespaldo,fecha,nombrearchivo,automatico"
            Case 20
                Resultado = "id_config,tirage_fact,tirage_compro,tirage_fact_actual,tirage_compro_actual,numfact,numcompro,iva,cotrans,porce_iva_ret"
            Case 21
                Resultado = "id_direcciones,direccion,id_municipio"
            Case 22
                Resultado = "idnoti,orden,tipo,cliente,cantidad,idfacturav"
        End Select
        Return Resultado
    End Function
    Private Function getCamposInsert(ByVal Tabla As Short) As String
        Dim Resultado As String = ""
        Select Case Tabla
            Case 1
                Resultado = "cGrp"
            Case 2
                Resultado = "IdUsr,cNom,cApe,cClave,cEstado"
            Case 3
                Resultado = "cNomOpc,nIdBar,cAccion,cDescripcion"
            Case 4
                Resultado = "IdGrp,IdUsr"
            Case 5
                Resultado = "IdGrp,IdOpc"
            Case 6
                Resultado = "nombre,nit,nrc,giro,direccion,telefono,fax,e_mail,estado"
            Case 7
                Resultado = "nombre,nit,nrc,giro,direccion,telefono,fax,e_mail,estado"
            Case 8
                Resultado = "numfacturac,tipo,codproveedor,fecha,sumas,descuento,iva,nosujeta,exentas,total,formadepago,unoretencion,estado,tiraje"
            Case 9
                Resultado = "numfacturav,tipo,codcliente,fecha,sumas,descuento,iva,nosujeta,exentas,total,formadepago,estado,tiraje"
            Case 10
                Resultado = "codfacturac,codproducto,cantidadunit,descuento,precioreal,preciodescuento,total,total1,preciopublico"
            Case 11
                Resultado = "codfacturav,codproducto,cantidadunit,descuento,precioreal,preciodescuento,total,total1,preciopublico"
            Case 12
                Resultado = "cod_departamento,departamentos"
            Case 13
                Resultado = "id_municipio,municipio,cod_departamento"
            Case 14
                Resultado = "nombre,descripcion"
            Case 15
                Resultado = "codproducto,nombre,descripcion,precio_unit,precioindi,preciopublico,existencias,id_categoria,unid_med,valida"
            Case 16
                Resultado = "idnumeros,numero,nombre"
            Case 17
                Resultado = "cliente"
            Case 18
                Resultado = "tirajefs,tirajefd,tirajefh,tirajefa,tirajecs,tirajecd,tirajech,tirajeca"
            Case 19
                Resultado = "fecha,nombrearchivo,automatico"
            Case 20
                Resultado = "id_config,tirage_fact,tirage_compro,tirage_fact_actual,tirage_compro_actual,numfact,numcompro,iva,cotrans,porce_iva_ret"
            Case 21
                Resultado = "direccion,id_municipio"
            Case 22
                Resultado = "orden,tipo,cliente,cantidad,idfacturav"
        End Select
        Return Resultado
    End Function
    Private Function getCamposUpdate(ByVal Tabla As Short) As ArrayList
        Dim Resultado As New ArrayList
        Select Case Tabla
            Case 1
                Resultado.Add("IdGrp")
                Resultado.Add("cGrp")
            Case 2
                Resultado.Add("IdUsr")
                Resultado.Add("cNom")
                Resultado.Add("cApe")
                Resultado.Add("cEstado")
            Case 3
                Resultado.Add("IdOpc")
                Resultado.Add("cNomOpc")
                Resultado.Add("nIdBar")
                Resultado.Add("cAccion")
                Resultado.Add("cDescripcion")
            Case 4
                Resultado.Add("IdGrpUsr")
                Resultado.Add("IdGrp")
                Resultado.Add("IdUsr")
            Case 5
                Resultado.Add("IdPermiso")
                Resultado.Add("IdGrp")
                Resultado.Add("IdOpc")
            Case 6
                Resultado.Add("codproveedor")
                Resultado.Add("nombre")
                Resultado.Add("nit")
                Resultado.Add("nrc")
                Resultado.Add("giro")
                Resultado.Add("direccion")
                Resultado.Add("telefono")
                Resultado.Add("fax")
                Resultado.Add("e_mail")
                Resultado.Add("estado")
            Case 7
                Resultado.Add("codcliente")
                Resultado.Add("nombre")
                Resultado.Add("nit")
                Resultado.Add("nrc")
                Resultado.Add("giro")
                Resultado.Add("direccion")
                Resultado.Add("telefono")
                Resultado.Add("fax")
                Resultado.Add("e_mail")
                Resultado.Add("estado")
          
            Case 8
                Resultado.Add("codfacturac")
                Resultado.Add("numfacturac")
                Resultado.Add("tipo")
                Resultado.Add("codproveedor")
                Resultado.Add("fecha")
                Resultado.Add("sumas")
                Resultado.Add("descuento")
                Resultado.Add("iva")
                Resultado.Add("nosujeta")
                Resultado.Add("exentas")
                Resultado.Add("total")
                Resultado.Add("formadepago")
                Resultado.Add("unoretencion")
                Resultado.Add("estado")
                Resultado.Add("tiraje")
            Case 9
                Resultado.Add("codfacturav")
                Resultado.Add("numfacturav")
                Resultado.Add("tipo")
                Resultado.Add("codcliente")
                Resultado.Add("fecha")
                Resultado.Add("sumas")
                Resultado.Add("descuento")
                Resultado.Add("iva")
                Resultado.Add("nosujeta")
                Resultado.Add("exentas")
                Resultado.Add("total")
                Resultado.Add("formadepago")
                Resultado.Add("estado")
                Resultado.Add("tiraje")
            Case 10
                Resultado.Add("coddetallefacturac")
                Resultado.Add("codfacturac")
                Resultado.Add("codarticulo")
                Resultado.Add("cantidadunit")
                Resultado.Add("descuento")
                Resultado.Add("precioreal")
                Resultado.Add("preciodescuento")
                Resultado.Add("codempresa")
                Resultado.Add("total")
                Resultado.Add("total1")
                Resultado.Add("preciopublico")
            Case 11
                Resultado.Add("coddetallefacturav")
                Resultado.Add("codfacturav")
                Resultado.Add("codarticulo")
                Resultado.Add("cantidadunit")
                Resultado.Add("descuento")
                Resultado.Add("precioreal")
                Resultado.Add("preciodescuento")
                Resultado.Add("codempresa")
                Resultado.Add("total")
                Resultado.Add("total1")
                Resultado.Add("preciopublico")

            Case 12
                Resultado.Add("cod_departamento")
                Resultado.Add("departamentos")
            Case 13
                Resultado.Add("id_municipio")
                Resultado.Add("municipio")
                Resultado.Add("cod_departamento")
            
      
            Case 14
                Resultado.Add("id_categoria")
                Resultado.Add("nombre")
                Resultado.Add("descripcion")
            Case 15
                Resultado.Add("codproducto")
                Resultado.Add("nombre")
                Resultado.Add("descripcion")
                Resultado.Add("precio_unit")
                Resultado.Add("precioindi")
                Resultado.Add("preciopublico")
                Resultado.Add("existencias")
                Resultado.Add("id_categoria")
                Resultado.Add("unid_med")
                Resultado.Add("valida")
            Case 16
                Resultado.Add("idnumeros")
                Resultado.Add("numero")
                Resultado.Add("nombre")
            Case 17
                Resultado.Add("idclientescf")
                Resultado.Add("cliente")

         
            Case 18
                Resultado.Add("idtiraje")
                Resultado.Add("tirajefs")
                Resultado.Add("tirajefd")
                Resultado.Add("tirajefh")
                Resultado.Add("tirajefa")
                Resultado.Add("tirajecs")
                Resultado.Add("tirajecd")
                Resultado.Add("tirajech")
                Resultado.Add("tirajeca")
            Case 19
                Resultado.Add("idrespaldo")
                Resultado.Add("fecha")
                Resultado.Add("nombrearchivo")
                Resultado.Add("automatico")

            Case 20
                Resultado.Add("id_config")
                Resultado.Add("tirage_fact")
                Resultado.Add("tirage_compro")
                Resultado.Add("tirage_fact_actual")
                Resultado.Add("tirage_compro_actual")
                Resultado.Add("numfact")
                Resultado.Add("numcompro")
                Resultado.Add("iva")
                Resultado.Add("cotrans")
                Resultado.Add("porce_iva_ret")
            Case 21
                Resultado.Add("id_direccion")
                Resultado.Add("direccion")
                Resultado.Add("idmunicipio")
            Case 22
                Resultado.Add("idnoti")
                Resultado.Add("orden")
                Resultado.Add("tipo")
                Resultado.Add("cliente")
                Resultado.Add("cantidad")
                Resultado.Add("idfacturav")

        End Select
        Return Resultado
    End Function
    Private Function getCamposDelete(ByVal Tabla As Short) As String
        Dim Resultado As String = ""
        Select Case Tabla
              Case 1
                Resultado = "IdGrp"
            Case 2
                Resultado = "IdUsr"
            Case 3
                Resultado = "IdOpc"
            Case 4
                Resultado = "IdGrpUsr"
            Case 5
                Resultado = "IdPermiso"
            Case 6
                Resultado = "codproveedor"
            Case 7
                Resultado = "codcliente"
            Case 8
                Resultado = "codfacturac"
            Case 9
                Resultado = "codfacturav"
            Case 10
                Resultado = "coddetallefacturac"
            Case 11
                Resultado = "coddetallefacturav"
            Case 12
                Resultado = "cod_departamento"
            Case 13
                Resultado = "id_municipio"
            Case 14
                Resultado = "id_categoria"
            Case 15
                Resultado = "codproducto"
            Case 16
                Resultado = "idnumeros"
            Case 17
                Resultado = "idclientescf"
            Case 18
                Resultado = "idtiraje"
            Case 19
                Resultado = "idrespaldo"
            Case 20
                Resultado = "id_config"
            Case 21
                Resultado = "id_direcciones"
            Case 21
                Resultado = "idnoti"
        End Select
        Return Resultado
    End Function
End Class