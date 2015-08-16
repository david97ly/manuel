use inventariome;

create table if not exists  Cliente(
  codcliente int not null,
nombre varchar (50),
nit varchar (50),
nrc varchar(50),
giro varchar(500),
direccionN varchar(1000),
propietario varchar(100),
telefonoN varchar(20),
tipo varchar(50),
razon_social varchar(50),
direccionO varchar(500),
telefonoO varchar(20),
faxN varchar(20),
faxO varchar(20),
e_mail varchar(50),
primary key(codcliente) 
)Engine MyIsam;

create table if not exists  proveedor(
  codproveedor int not null,
nombre varchar (50),
nit varchar (50),
nrc varchar(50),
giro varchar(500),
direccionN varchar(1000),
propietario varchar(100),
telefonoN varchar(20),
tipo varchar(50),
razon_social varchar(50),
direccionO varchar(500),
telefonoO varchar(20),
faxN varchar(20),
faxO varchar(20),
e_mail varchar(50),
primary key(codproveedor) 
)Engine MyIsam;

create table if not exists  Empresa(
  codempresa int not null,
nombre varchar (50),
nit varchar (50),
nrc varchar(50),
giro varchar(500),
direccionN varchar(1000),
propietario varchar(100),
telefonoN varchar(20),
tipo varchar(50),
razon_social varchar(50),
direccionO varchar(500),
telefonoO varchar(20),
faxN varchar(20),
faxO varchar(20),
e_mail varchar(50),
primary key(codempresa) 
)Engine MyIsam;

create table if not exists categoria(
  id_categoria int not null auto_increment,
  nombre varchar(50),
  descripcion varchar(200) ,
  primary key(id_categoria)  
)Engine MyIsam;

create table if not exists Articulo(
id_articulo int not null,
nombre varchar(50),
descripcion varchar(200),
precio_unit double,
precio_indi double,
precio_public double,
precio_publicindi double,
unidad_medida varchar(50),
existencias int,
existencias_indi  int,
codempresa int,
id_categoria int,
codproveedor int,
totalArticulos int,
primary key(id_articulo),
foreign key(codempresa)references empresa(codempresa),
foreign key(codproveedor)references proveedor(codproveedor),
foreign key(id_categoria)references categoria(id_categoria)
)Engine MyIsam;
	
create table if not exists despachador(
  coddespachador int not null auto_increment,
  nombres varchar(50),
  apellidos varchar(50),  
   codempresa int,  
  primary key(coddespachador),
   key(codempresa)  
)Engine MyIsam;

create table if not exists factura_compra(
 codfacturac int not null auto_increment,
codproveedor int,
codempresa int,
fecha varchar(50),
coddespachador int,
subtotal1 double,
subtotal2 double,
subtotal3 double,
descuento double,
iva double,
total double,
primary key(codfacturac),
foreign key(codproveedor)references proveedor(codproveedor),
foreign key(codempresa)references empresa(codempresa),
foreign key(coddespachador)references despachador(coddespachador)
 )Engine MyIsam;

create table if not exists detalle_facturac(
	coddetallefacturac int not null auto_increment,
	codfacturac int,
	id_articulo int,
	cantidadunit double,
	cantidadindi double,
	precioreal double,
	preciodescuento double,
	primary key(coddetallefacturac),
	foreign key(codfacturac)references  factura_compra(codfacturac),
	foreign key(id_articulo)references  articulo(id_articulo)
	)Engine MyIsam;
	
	CREATE TABLE if not exists `factura_venta` (
  `codfacturav` int(11) NOT NULL AUTO_INCREMENT,
  `codproveedor` int(11) DEFAULT NULL,
  `codempresa` int(11) DEFAULT NULL,
  `fecha` varchar(50) DEFAULT NULL,
  `coddespachador` int(11) DEFAULT NULL,
  `subtotal1` double DEFAULT NULL,
  `subtotal2` double DEFAULT NULL,
  `subtotal3` double DEFAULT NULL,
  `descuento` double DEFAULT NULL,
  `iva` double DEFAULT NULL,
  `total` double DEFAULT NULL,
  PRIMARY KEY (`codfacturav`),
  KEY `codproveedor` (`codproveedor`),
  KEY `codempresa` (`codempresa`),
  KEY `coddespachador` (`coddespachador`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;


CREATE TABLE if not exists `detalle_facturav` (
  `coddetallefacturav` int(11) NOT NULL AUTO_INCREMENT,
  `codfacturav` int(11) DEFAULT NULL,
  `id_articulo` int(11) DEFAULT NULL,
  `cantidadunit` double DEFAULT NULL,
  `cantidadindi` double DEFAULT NULL,
  `precioreal` double DEFAULT NULL,
  `preciodescuento` double DEFAULT NULL,
  PRIMARY KEY (`coddetallefacturav`),
  KEY `codfacturac` (`codfacturav`),
  KEY `id_articulo` (`id_articulo`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

	
create table if not exists Tablas_inventario(
id_tablas_inventario int not null auto_increment,
codempresa int,
id_inventario varchar(50),
cod_empresa varchar(50),
cantidad_articulos varchar(50),
costo_articulos varchar(50),
iva_articulos varchar(50),
total_con_iva varchar(50),
tatal_sin_iva varchar(50),
primary key(id_tablas_inventario),
foreign key(codempresa)references empresa(codempresa)
)ENGINE=MyISAM;
	
	
create table if not exists Tablas_detalle_inventario(
id_Tablas_detalle_inventario int not null auto_increment,
id_tablas_inventario int,
id_inventario varchar(50),
id_articulo varchar(50),
nombre varchar(100),
descripcion varchar(250),
preciounit varchar(50),
precionpublic varchar(50),
existencias varchar(50),
idempresa varchar(50),
idcategoria varchar(50),
idproveedor varchar(50),
idunidmed varchar(50),
primary key(id_Tablas_detalle_inventario),
foreign key(id_tablas_inventario)references Tablas_inventario(id_tablas_inventario)
)Engine = MyIsam;
