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
        Empresa = 8
        Despachador = 9
        FacturaCompra = 10
        FacturaVenta = 11
        DetalleFacturaC = 12
        DetalleFacturaV = 13
        RegistroUltimo = 14
        TablasInventario = 15
        DetalleTablasInventario = 16
        Departamentos = 17
        Municipios = 18
        Tablas = 19
        Categorias = 20
        Productos = 21
        Descuentos = 22
        Numeros = 23
        Tanques = 24
        Bombas = 25
        clientescf = 26
        tiraje = 27
        Respaldo = 28
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
                Resultado = "empresa"
            Case 9
                Resultado = "despachador"
            Case 10
                Resultado = "facturacompra"
            Case 11
                Resultado = "facturaventa"
            Case 12
                Resultado = "detallecompra"
            Case 13
                Resultado = "detalleventa"
            Case 14
                Resultado = "registro_ultimo"
            Case 15
                Resultado = "tablas_inventario"
            Case 16
                Resultado = "tablas_detalle_inventario"
            Case 17
                Resultado = "departamentos"
            Case 18
                Resultado = "municipios"
            Case 19
                Resultado = "tablas"
            Case 20
                Resultado = "categoria"
            Case 21
                Resultado = "productos"
            Case 22
                Resultado = "descuentos"
            Case 23
                Resultado = "numeros"
            Case 24
                Resultado = "tanques"
            Case 25
                Resultado = "bombas"
            Case 26
                Resultado = "clientescf"
            Case 27
                Resultado = "tirajes"
            Case 28
                Resultado = "respaldos"
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
                Resultado = "codproveedor,nombre,nit,nrc,giro,direccionN,propietario,telefonoN,tipo,razon_social,direccionO,telefonoO,faxN,faxO,e_mail,numpropietario,codempresa,estado"
            Case 7
                Resultado = "codcliente,nombre,nit,nrc,giro,direccionN,propietario,telefonoN,tipo,razon_social,direccionO,telefonoO,faxN,faxO,e_mail,numpropietario,codempresa,estado"
            Case 8
                Resultado = "codempresa,nombre,nit,nrc,giro,direccionN,propietario,telefonoN,tipo,razon_social,direccionO,telefonoO,faxN,faxO,e_mail"
            Case 9
                Resultado = "coddespachador,nombres,apellidos,codempresa"
            Case 10
                Resultado = "codfacturac,numfacturac,tipo,codproveedor,codempresa,fecha,sumas,descuento,iva,nosujeta,fovial,cotrans,exentas,total,formadepago,unoretencion,estado,tiraje,td1,td2,tr,ts"
            Case 11
                Resultado = "codfacturav,numfacturav,tipo,codcliente,codempresa,fecha,sumas,descuento,iva,nosujeta,fovial,cotrans,exentas,total,formadepago,estado,tiraje"
            Case 12
                Resultado = "coddetallefacturac,codfacturac,codproducto,cantidadunit,descuento,precioreal,preciodescuento,codempresa,total,total1,preciopublico"
            Case 13
                Resultado = "coddetallefacturav,codfacturav,codproducto,cantidadunit,descuento,precioreal,preciodescuento,codempresa,total,total1,preciopublico"
            Case 14
                Resultado = "id_registroultimo,fecha,hora,IdUsr,duracionSecion,codempresa,codfactura"
            Case 15
                Resultado = "id_tablas_inventario,codempresa,id_inventario,cod_empresa,cantidad_articulos,iva_articulos,total_con_iva,total_sin_iva"
            Case 16
                Resultado = "id_Tablas_detalle_inventario,id_tablas_inventario,id_inventario,id_articulo,nombre,descripcion,preciounit,preciopublic,existencias,idempresa,idcategoria,idproveedor,idunidmed"
            Case 17
                Resultado = "cod_departamento,departamentos"
            Case 18
                Resultado = "id_municipio,municipio,cod_departamento"
            Case 19
                Resultado = "idtablas,nombretabla,codtabla,nombre,descripcion,preciounit,precio_public,existencias,codempresa,id_categoria,codproveedor,unid_med"
            Case 20
                Resultado = "id_categoria,nombre,descripcion,codempresa"
            Case 21
                Resultado = "codproducto,nombre,descripcion,precio_unit,precioindi,preciopublico,existencias,codempresa,id_categoria,codproveedor,unid_med"
            Case 22
                Resultado = "iddescuento,iva,cotrans,fovial,codproducto"
            Case 23
                Resultado = "idnumeros,numero,nombre"
            Case 24
                Resultado = "codtanque,nombre,contiene,cantidad,capacidad,porcentaje"
            Case 25
                Resultado = "idbombas,nombre,ventasdiarias,ventasdiariasgalon,codtanque"
            Case 26
                Resultado = "idclientescf,cliente"
            Case 27
                Resultado = "idtiraje,tirajefs,tirajefd,tirajefh,tirajefa,tirajecs,tirajecd,tirajech,tirajeca"
            Case 28
                Resultado = "idrespaldo,fecha,nombrearchivo,automatico"
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
                Resultado = "codproveedor,nombre,nit,nrc,giro,direccionN,propietario,telefonoN,tipo,razon_social,direccionO,telefonoO,faxN,faxO,e_mail,numpropietario,codempresa,estado"
            Case 7
                Resultado = "codcliente,nombre,nit,nrc,giro,direccionN,propietario,telefonoN,tipo,razon_social,direccionO,telefonoO,faxN,faxO,e_mail,numpropietario,codempresa,estado"
            Case 8
                Resultado = "codempresa,nombre,nit,nrc,giro,direccionN,propietario,telefonoN,tipo,razon_social,direccionO,telefonoO,faxN,faxO,e_mail,numpropietario,estado"
            Case 9
                Resultado = "nombres,apellidos,codempresa"
            Case 10
                Resultado = "numfacturac,tipo,codproveedor,codempresa,fecha,sumas,descuento,iva,nosujeta,fovial,cotrans,exentas,total,formadepago,unoretencion,estado,tiraje,td1,td2,tr,ts"
            Case 11
                Resultado = "numfacturav,tipo,codcliente,codempresa,fecha,sumas,descuento,iva,nosujeta,fovial,cotrans,exentas,total,formadepago,estado,tiraje"
            Case 12
                Resultado = "codfacturac,codproducto,cantidadunit,descuento,precioreal,preciodescuento,codempresa,total,total1,preciopublico"
            Case 13
                Resultado = "codfacturav,codproducto,cantidadunit,descuento,precioreal,preciodescuento,codempresa,total,total1,preciopublico"
            Case 14
                Resultado = "fecha,hora,IdUsr,duracionSecion,codempresa,codfactura"
            Case 15
                Resultado = "codempresa,id_inventario,cod_empresa,cantidad_articulos,iva_articulos,total_con_iva,total_sin_iva"
            Case 16
                Resultado = "id_tablas_inventario,id_inventario,id_articulo,nombre,descripcion,preciounit,preciopublic,existencias,idempresa,idcategoria,idproveedor,idunidmed"
            Case 17
                Resultado = "id_departamento,departamento"
            Case 18
                Resultado = "id_municipio,municipio,id_departamento"
            Case 19
                Resultado = "nombretabla,codtabla,nombre,descripcion,preciounit,precio_public,existencias,codempresa,idcategoria,codproveedor,unit_med,codempresa1"
            Case 20
                Resultado = "nombre,descripcion,codempresa"
            Case 21
                Resultado = "codproducto,nombre,descripcion,precio_unit,precioindi,preciopublico,existencias,codempresa,id_categoria,codproveedor,unid_med"
            Case 22
                Resultado = "iva,cotrans,fovial,codproducto"
            Case 23
                Resultado = "numero,nombre"
            Case 24
                Resultado = "codtanque,nombre,contiene,cantidad,capacidad,porcentaje"
            Case 25
                Resultado = "idbombas,nombre,ventasdiarias,ventasdiariasgalon,codtanque"
            Case 26
                Resultado = "cliente"
            Case 27
                Resultado = "tirajefs,tirajefd,tirajefh,tirajefa,tirajecs,tirajecd,tirajech,tirajeca"
            Case 28
                Resultado = "fecha,nombrearchivo,automatico"
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
                Resultado.Add("direccionN")
                Resultado.Add("propietario")
                Resultado.Add("telefonoN")
                Resultado.Add("tipo")
                Resultado.Add("razon_social")
                Resultado.Add("direccionO")
                Resultado.Add("telefonoO")
                Resultado.Add("faxN")
                Resultado.Add("faxO")
                Resultado.Add("e_mail")
                Resultado.Add("numpropietario")
                Resultado.Add("codempresa")
                Resultado.Add("estado")
            Case 7
                Resultado.Add("codcliente")
                Resultado.Add("nombre")
                Resultado.Add("nit")
                Resultado.Add("nrc")
                Resultado.Add("giro")
                Resultado.Add("direccionN")
                Resultado.Add("propietario")
                Resultado.Add("telefonoN")
                Resultado.Add("tipo")
                Resultado.Add("razon_social")
                Resultado.Add("direccionO")
                Resultado.Add("telefonoO")
                Resultado.Add("faxN")
                Resultado.Add("faxO")
                Resultado.Add("e_mail")
                Resultado.Add("numpropietario")
                Resultado.Add("codempresa")
                Resultado.Add("estado")
            Case 8
                Resultado.Add("codempresa")
                Resultado.Add("nombre")
                Resultado.Add("nit")
                Resultado.Add("nrc")
                Resultado.Add("giro")
                Resultado.Add("direccionN")
                Resultado.Add("propietario")
                Resultado.Add("telefonoN")
                Resultado.Add("tipo")
                Resultado.Add("razon_social")
                Resultado.Add("direccionO")
                Resultado.Add("telefonoO")
                Resultado.Add("faxN")
                Resultado.Add("faxO")
                Resultado.Add("e_mail")
                Resultado.Add("numpropietario")
                Resultado.Add("estado")
            Case 9
                Resultado.Add("nombres")
                Resultado.Add("apellidos")
                Resultado.Add("codempresa")
            Case 10
                Resultado.Add("codfacturac")
                Resultado.Add("numfacturac")
                Resultado.Add("tipo")
                Resultado.Add("codproveedor")
                Resultado.Add("codempresa")
                Resultado.Add("fecha")
                Resultado.Add("sumas")
                Resultado.Add("descuento")
                Resultado.Add("iva")
                Resultado.Add("nosujeta")
                Resultado.Add("fovial")
                Resultado.Add("cotrans")
                Resultado.Add("exentas")
                Resultado.Add("total")
                Resultado.Add("formadepago")
                Resultado.Add("unoretencion")
                Resultado.Add("estado")
                Resultado.Add("tiraje")
                Resultado.Add("td1")
                Resultado.Add("td2")
                Resultado.Add("tr")
                Resultado.Add("ts")
            Case 11
                Resultado.Add("codfacturav")
                Resultado.Add("numfacturav")
                Resultado.Add("tipo")
                Resultado.Add("codcliente")
                Resultado.Add("codempresa")
                Resultado.Add("fecha")
                Resultado.Add("sumas")
                Resultado.Add("descuento")
                Resultado.Add("iva")
                Resultado.Add("nosujeta")
                Resultado.Add("fovial")
                Resultado.Add("cotrans")
                Resultado.Add("exentas")
                Resultado.Add("total")
                Resultado.Add("formadepago")
                Resultado.Add("estado")
                Resultado.Add("tiraje")
            Case 12
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
            Case 13
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
            Case 14
                Resultado.Add("fecha")
                Resultado.Add("hora")
                Resultado.Add("IdUsr")
                Resultado.Add("duracionSecion")
                Resultado.Add("codempresa")
                Resultado.Add("codfactura")
            Case 15
                Resultado.Add("codempresa")
                Resultado.Add("id_inventario")
                Resultado.Add("cod_empresa")
                Resultado.Add("cantidad_articulos")
                Resultado.Add("iva_articulos")
                Resultado.Add("total_con_iva")
                Resultado.Add("total_sin_iva")
            Case 16
                Resultado.Add("id_tablas_inventario")
                Resultado.Add("id_inventario")
                Resultado.Add("id_articulo")
                Resultado.Add("nombre")
                Resultado.Add("descripcion")
                Resultado.Add("preciounit")
                Resultado.Add("preciopublic")
                Resultado.Add("existencias")
                Resultado.Add("idempresa")
                Resultado.Add("idcategoria")
                Resultado.Add("idproveedor")
                Resultado.Add("idunidmed")
            Case 17
                Resultado.Add("cod_departamento")
                Resultado.Add("departamentos")
            Case 18
                Resultado.Add("id_municipio")
                Resultado.Add("municipio")
                Resultado.Add("cod_departamento")

            Case 19
                Resultado.Add("idtablas")
                Resultado.Add("nombretabla")
                Resultado.Add("codtabla")
                Resultado.Add("nombre")
                Resultado.Add("descripcion")
                Resultado.Add("preciounit")
                Resultado.Add("precio_public")
                Resultado.Add("existencias")
                Resultado.Add("codempresa")
                Resultado.Add("idcategoria")
                Resultado.Add("codproveedor")
                Resultado.Add("unit_med")
                Resultado.Add("codempresa1")
            Case 20
                Resultado.Add("id_categoria")
                Resultado.Add("nombre")
                Resultado.Add("descripcion")
                Resultado.Add("codempresa")
            Case 21
                Resultado.Add("codproducto")
                Resultado.Add("nombre")
                Resultado.Add("descripcion")
                Resultado.Add("precio_unit")
                Resultado.Add("precioindi")
                Resultado.Add("preciopublico")
                Resultado.Add("existencias")
                Resultado.Add("codempresa")
                Resultado.Add("id_categoria")
                Resultado.Add("codproveedor")
                Resultado.Add("unid_med")
            Case 22

                Resultado.Add("iddescuento")
                Resultado.Add("iva")
                Resultado.Add("cotras")
                Resultado.Add("fovil")
                Resultado.Add("codproducto")
            Case 23
                Resultado.Add("idnumeros")
                Resultado.Add("numero")
                Resultado.Add("nombre")

            Case 24
                Resultado.Add("codtanque")
                Resultado.Add("nombre")
                Resultado.Add("contiene")
                Resultado.Add("cantidad")
                Resultado.Add("capacidad")
                Resultado.Add("porcentaje")
            Case 25
                Resultado.Add("idbombas")
                Resultado.Add("nombre")
                Resultado.Add("ventasdiarias")
                Resultado.Add("ventasdiariasgalon")
                Resultado.Add("codtanque")
            Case 26
                Resultado.Add("idclientescf")
                Resultado.Add("cliente")
            Case 27
                Resultado.Add("idtiraje")
                Resultado.Add("tirajefs")
                Resultado.Add("tirajefd")
                Resultado.Add("tirajefh")
                Resultado.Add("tirajefa")
                Resultado.Add("tirajecs")
                Resultado.Add("tirajecd")
                Resultado.Add("tirajech")
                Resultado.Add("tirajeca")
            Case 28
                Resultado.Add("idrespaldo")
                Resultado.Add("fecha")
                Resultado.Add("nombrearchivo")
                Resultado.Add("automatico")
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
                Resultado = "codempresa"
            Case 9
                Resultado = "coddespachador"
            Case 10
                Resultado = "idtablafacturac"
            Case 11
                Resultado = "idtablafarcurav"
            Case 12
                Resultado = "coddetallefacturac"
            Case 13
                Resultado = "coddetallefacturav"
            Case 14
                Resultado = "id_registroultimo"
            Case 15
                Resultado = "id_tablas_inventario"
            Case 16
                Resultado = "id_Tablas_detalle_inventario"
            Case 17
                Resultado = "cod_departamento"
            Case 18
                Resultado = "id_municipio"
            Case 19
                Resultado = "idtablas"
            Case 20
                Resultado = "id_categoria"
            Case 21
                Resultado = "codproducto"
            Case 22
                Resultado = "iddescuento"
            Case 23
                Resultado = "idnumeros"
            Case 24
                Resultado = "codtanque"
            Case 25
                Resultado = "idbombas"
            Case 26
                Resultado = "idclientescf"
            Case 27
                Resultado = "idtiraje"
            Case 28
                Resultado = "idrespaldo"
        End Select
        Return Resultado
    End Function
End Class