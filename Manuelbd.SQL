-- MySQL dump 10.13  Distrib 5.1.56, for Win32 (ia32)
--
-- Host: localhost    Database: manuelbd
-- ------------------------------------------------------
-- Server version	5.1.56-community

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `categoria`
--

DROP TABLE IF EXISTS `categoria`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `categoria` (
  `id_categoria` int(11) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(50) DEFAULT NULL,
  `descripcion` varchar(200) DEFAULT NULL,
  PRIMARY KEY (`id_categoria`)
) ENGINE=MyISAM AUTO_INCREMENT=5 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `categoria`
--

LOCK TABLES `categoria` WRITE;
/*!40000 ALTER TABLE `categoria` DISABLE KEYS */;
INSERT INTO `categoria` VALUES (4,'nueva','nueva');
/*!40000 ALTER TABLE `categoria` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `cliente`
--

DROP TABLE IF EXISTS `cliente`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `cliente` (
  `codcliente` int(11) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(250) DEFAULT NULL,
  `nit` varchar(250) DEFAULT NULL,
  `nrc` varchar(250) DEFAULT NULL,
  `giro` varchar(250) DEFAULT NULL,
  `direccion` varchar(250) DEFAULT NULL,
  `telefono` varchar(250) DEFAULT NULL,
  `fax` varchar(250) DEFAULT NULL,
  `e_mail` varchar(250) DEFAULT NULL,
  `estado` varchar(250) DEFAULT NULL,
  PRIMARY KEY (`codcliente`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `cliente`
--

LOCK TABLES `cliente` WRITE;
/*!40000 ALTER TABLE `cliente` DISABLE KEYS */;
/*!40000 ALTER TABLE `cliente` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `clientescf`
--

DROP TABLE IF EXISTS `clientescf`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `clientescf` (
  `idclientescf` int(11) NOT NULL AUTO_INCREMENT,
  `cliente` varchar(250) DEFAULT NULL,
  PRIMARY KEY (`idclientescf`)
) ENGINE=MyISAM AUTO_INCREMENT=5403 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `clientescf`
--

LOCK TABLES `clientescf` WRITE;
/*!40000 ALTER TABLE `clientescf` DISABLE KEYS */;
/*!40000 ALTER TABLE `clientescf` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `configuraciones`
--

DROP TABLE IF EXISTS `configuraciones`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `configuraciones` (
  `id_config` int(11) NOT NULL,
  `tirage_fact` varchar(250) DEFAULT NULL,
  `tirage_compro` varchar(250) DEFAULT NULL,
  `tirage_fact_actual` varchar(250) DEFAULT NULL,
  `tirage_compro_actual` varchar(250) DEFAULT NULL,
  `numfact` varchar(250) DEFAULT NULL,
  `numcompro` varchar(250) DEFAULT NULL,
  `iva` decimal(8,0) DEFAULT NULL,
  `cotrans` decimal(8,0) DEFAULT NULL,
  `porce_iva_ret` decimal(8,0) DEFAULT NULL,
  PRIMARY KEY (`id_config`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `configuraciones`
--

LOCK TABLES `configuraciones` WRITE;
/*!40000 ALTER TABLE `configuraciones` DISABLE KEYS */;
/*!40000 ALTER TABLE `configuraciones` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `departamentos`
--

DROP TABLE IF EXISTS `departamentos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `departamentos` (
  `cod_departamento` int(11) NOT NULL,
  `departamentos` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`cod_departamento`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `departamentos`
--

LOCK TABLES `departamentos` WRITE;
/*!40000 ALTER TABLE `departamentos` DISABLE KEYS */;
INSERT INTO `departamentos` VALUES (1,'Ahuachapán'),(2,'Santa Ana'),(3,'Sonsonate'),(4,'Chalatenango'),(5,'Cuscatlán'),(6,'San Salvador'),(7,'La Libertad'),(8,'San Vicente'),(9,'La Paz'),(10,'Cabañas'),(11,'Usulután'),(12,'San Miguel'),(13,'Morazán'),(14,'La Unión');
/*!40000 ALTER TABLE `departamentos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `detallecompra`
--

DROP TABLE IF EXISTS `detallecompra`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `detallecompra` (
  `coddetallefacturac` int(11) NOT NULL AUTO_INCREMENT,
  `codfacturac` int(11) DEFAULT NULL,
  `codproducto` int(11) DEFAULT NULL,
  `cantidadunit` decimal(6,3) DEFAULT NULL,
  `descuento` decimal(6,3) DEFAULT NULL,
  `precioreal` decimal(6,3) DEFAULT NULL,
  `preciodescuento` decimal(6,3) DEFAULT NULL,
  `total` decimal(6,3) DEFAULT NULL,
  `total1` decimal(6,3) DEFAULT NULL,
  `preciopublico` decimal(6,3) DEFAULT NULL,
  PRIMARY KEY (`coddetallefacturac`),
  KEY `codfacturac` (`codfacturac`),
  KEY `codproducto` (`codproducto`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `detallecompra`
--

LOCK TABLES `detallecompra` WRITE;
/*!40000 ALTER TABLE `detallecompra` DISABLE KEYS */;
/*!40000 ALTER TABLE `detallecompra` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `detalleventa`
--

DROP TABLE IF EXISTS `detalleventa`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `detalleventa` (
  `coddetallefacturav` int(11) NOT NULL AUTO_INCREMENT,
  `codfacturav` int(11) DEFAULT NULL,
  `codproducto` int(11) DEFAULT NULL,
  `cantidadunit` decimal(6,3) DEFAULT NULL,
  `descuento` decimal(6,3) DEFAULT NULL,
  `precioreal` decimal(6,3) DEFAULT NULL,
  `preciodescuento` decimal(6,3) DEFAULT NULL,
  `total` decimal(6,3) DEFAULT NULL,
  `total1` decimal(6,3) DEFAULT NULL,
  `preciopublico` decimal(6,3) DEFAULT NULL,
  PRIMARY KEY (`coddetallefacturav`),
  KEY `codfacturav` (`codfacturav`),
  KEY `codproducto` (`codproducto`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `detalleventa`
--

LOCK TABLES `detalleventa` WRITE;
/*!40000 ALTER TABLE `detalleventa` DISABLE KEYS */;
/*!40000 ALTER TABLE `detalleventa` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `direccion`
--

DROP TABLE IF EXISTS `direccion`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `direccion` (
  `id_direcciones` int(11) NOT NULL AUTO_INCREMENT,
  `direccion` varchar(1000) DEFAULT NULL,
  `id_municipio` int(11) DEFAULT NULL,
  PRIMARY KEY (`id_direcciones`),
  KEY `id_municipio` (`id_municipio`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `direccion`
--

LOCK TABLES `direccion` WRITE;
/*!40000 ALTER TABLE `direccion` DISABLE KEYS */;
/*!40000 ALTER TABLE `direccion` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `facturacompra`
--

DROP TABLE IF EXISTS `facturacompra`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `facturacompra` (
  `codfacturac` int(11) NOT NULL AUTO_INCREMENT,
  `numfacturac` int(11) DEFAULT NULL,
  `tipo` varchar(100) DEFAULT NULL,
  `codproveedor` int(11) DEFAULT NULL,
  `fecha` date DEFAULT NULL,
  `sumas` decimal(6,3) DEFAULT NULL,
  `descuento` decimal(6,3) DEFAULT NULL,
  `iva` decimal(6,3) DEFAULT NULL,
  `nosujeta` decimal(6,3) DEFAULT NULL,
  `exentas` decimal(6,3) DEFAULT NULL,
  `total` decimal(6,3) DEFAULT NULL,
  `formadepago` varchar(50) DEFAULT NULL,
  `unoretencion` decimal(6,3) DEFAULT NULL,
  `estado` varchar(50) DEFAULT NULL,
  `tiraje` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`codfacturac`),
  KEY `codproveedor` (`codproveedor`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `facturacompra`
--

LOCK TABLES `facturacompra` WRITE;
/*!40000 ALTER TABLE `facturacompra` DISABLE KEYS */;
/*!40000 ALTER TABLE `facturacompra` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `facturaventa`
--

DROP TABLE IF EXISTS `facturaventa`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `facturaventa` (
  `codfacturav` int(11) NOT NULL AUTO_INCREMENT,
  `numfacturav` int(11) DEFAULT NULL,
  `tipo` varchar(100) DEFAULT NULL,
  `codcliente` int(11) DEFAULT NULL,
  `fecha` datetime DEFAULT NULL,
  `sumas` decimal(6,3) DEFAULT NULL,
  `descuento` decimal(6,3) DEFAULT NULL,
  `iva` decimal(6,3) DEFAULT NULL,
  `nosujeta` decimal(6,3) DEFAULT NULL,
  `exentas` decimal(6,3) DEFAULT NULL,
  `total` decimal(6,3) DEFAULT NULL,
  `formadepago` varchar(50) DEFAULT NULL,
  `unoretencion` decimal(6,3) DEFAULT NULL,
  `estado` varchar(50) DEFAULT NULL,
  `tiraje` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`codfacturav`),
  KEY `codcliente` (`codcliente`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `facturaventa`
--

LOCK TABLES `facturaventa` WRITE;
/*!40000 ALTER TABLE `facturaventa` DISABLE KEYS */;
/*!40000 ALTER TABLE `facturaventa` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `grp`
--

DROP TABLE IF EXISTS `grp`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `grp` (
  `IdGrp` int(11) NOT NULL AUTO_INCREMENT,
  `cGrp` varchar(20) DEFAULT NULL,
  PRIMARY KEY (`IdGrp`)
) ENGINE=MyISAM AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `grp`
--

LOCK TABLES `grp` WRITE;
/*!40000 ALTER TABLE `grp` DISABLE KEYS */;
INSERT INTO `grp` VALUES (1,'Administrador');
/*!40000 ALTER TABLE `grp` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `grpusr`
--

DROP TABLE IF EXISTS `grpusr`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `grpusr` (
  `IdGrpUsr` int(11) NOT NULL AUTO_INCREMENT,
  `IdGrp` int(11) NOT NULL,
  `IdUsr` varchar(15) NOT NULL,
  PRIMARY KEY (`IdGrpUsr`),
  KEY `IdGrp` (`IdGrp`),
  KEY `IdUsr` (`IdUsr`)
) ENGINE=MyISAM AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `grpusr`
--

LOCK TABLES `grpusr` WRITE;
/*!40000 ALTER TABLE `grpusr` DISABLE KEYS */;
INSERT INTO `grpusr` VALUES (1,1,'admin');
/*!40000 ALTER TABLE `grpusr` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `menu`
--

DROP TABLE IF EXISTS `menu`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `menu` (
  `IdOpc` int(11) NOT NULL AUTO_INCREMENT,
  `cNomOpc` varchar(20) DEFAULT NULL,
  `nIdBar` int(11) DEFAULT NULL,
  `cAccion` varchar(50) DEFAULT NULL,
  `cDescripcion` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`IdOpc`)
) ENGINE=MyISAM AUTO_INCREMENT=23 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `menu`
--

LOCK TABLES `menu` WRITE;
/*!40000 ALTER TABLE `menu` DISABLE KEYS */;
INSERT INTO `menu` VALUES (1,'Maestros',0,'Ninguna','Maestros'),(2,'Grupos',1,'mGrupo','Maestro Grupos'),(3,'Usuarios',1,'mUsuarios','Maestro de usuarios'),(4,'Menu',1,'mMenu','Maestro del menu'),(5,'Configuracion',0,'Ninguna','Configuracion'),(6,'Grupos de usuarios',5,'frmUsuarios','Grupos de usuarios'),(7,'Permisos',5,'frmPermisos','Permisos'),(8,'Mantenimiento',0,'Ninguna','Menu mantenimiento'),(9,'Productos',8,'Productos','Mustra los productos'),(10,'Proveedores',8,'Proveedores','Muestra los proveedores'),(21,'Configuraciones',8,'Configuraciones','muestra las configuraciones'),(12,'Movimientos',0,'Ninguna','Nada'),(13,'Compras',12,'compra','facturas compras'),(14,'Ventas',12,'Ventas','Facturas ventas'),(15,'Clientes',8,'Clientes','Clientes'),(16,'Documentos',0,'Ninguna','para ver docuentos'),(17,'Compras realizadas',16,'Compras_realizadas','muestra las compras realizadas'),(18,'Ventas Realizadas',16,'VentasRealizadas','muestra las ventas realizadas'),(19,'Kardex',16,'Kardex','muestra el kardez'),(20,'Reportes',16,'Reportes','Muestra las distintos reportez'),(22,'Respaldos',8,'Respaldos','Hace respaldo del al base de datos');
/*!40000 ALTER TABLE `menu` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `municipios`
--

DROP TABLE IF EXISTS `municipios`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `municipios` (
  `id_municipio` int(11) NOT NULL AUTO_INCREMENT,
  `municipio` varchar(50) DEFAULT NULL,
  `cod_departamento` int(11) DEFAULT NULL,
  PRIMARY KEY (`id_municipio`),
  KEY `cod_departamento` (`cod_departamento`)
) ENGINE=MyISAM AUTO_INCREMENT=264 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `municipios`
--

LOCK TABLES `municipios` WRITE;
/*!40000 ALTER TABLE `municipios` DISABLE KEYS */;
INSERT INTO `municipios` VALUES (1,'Ahuachapán',1),(2,'Jujutla',1),(3,'Atiquizaya',1),(4,'Concepción de Ataco',1),(5,'El Refugio',1),(6,'Guaymango',1),(7,'Apaneca',1),(8,'San Francisco Menéndez',1),(9,'San Lorenzo',1),(10,'San Pedro Puxtla',1),(11,'Tacuba',1),(12,'Turín',1),(13,'Candelaria de la Frontera',2),(14,'Chalchuapa',2),(15,'Coatepeque',2),(16,'El Congo',2),(17,'El Porvenir',2),(18,'Masahuat',2),(19,'Metapán',2),(20,'San Antonio Pajonal',2),(21,'San Sebastián Salitrillo',2),(22,'Santa Ana',2),(23,'Santa Rosa Guachipilín',2),(24,'Santiago de la Frontera',2),(25,'Texistepeque',2),(26,'Acajutla',3),(27,'Armenia',3),(28,'Caluco',3),(29,'Cuisnahuat',3),(30,'Izalco',3),(31,'Juayúa',3),(32,'Nahuizalco',3),(33,'Nahulingo',3),(34,'Salcoatitán',3),(35,'San antonio del Monte',3),(36,'San Julián',3),(37,'Santa Catarina Masahuat',3),(38,'Santa Isabel Ishuatán',3),(39,'Santo Domingo',3),(40,'Sonsonate',3),(41,'Sonzacate',3),(42,'Agua Caliente',4),(43,'Arcatao',4),(44,'Azacualpa',4),(45,'Chalatenango',4),(46,'Citalá',4),(47,'Comalapa',4),(48,'Concepción Quezaltepeque',4),(49,'Dulce Nombre de Maria',4),(50,'El Carrizal',4),(51,'El Paraíso',4),(52,'La Laguna',4),(53,'La Palma',4),(54,'La Reina',4),(55,'Las Vueltas',4),(56,'Nueva Concepción',4),(57,'Nueva Trinidad',4),(58,'Nombre de Jesús',4),(59,'Ojos de Agua',4),(60,'Potonico',4),(61,'San Antonio de la Cruz',4),(62,'San Antonio Los Ranchos',4),(63,'San Fernando',4),(64,'San Francisco Lempa',4),(65,'San Francisco Morazán',4),(66,'San Ignacio',4),(67,'San Isidro Labrador',4),(68,'San José Cancasque',4),(69,'San José Las Flores',4),(70,'San Luis del Carmen',4),(71,'San Miguel de Mercedes',4),(72,'San Rafael',4),(73,'Santa Rita',4),(74,'Tejutla',4),(75,'Candelaria',5),(76,'Cojutepeque',5),(77,'El Carmen',5),(78,'El Rosario',5),(79,'Monte San Juan',5),(80,'Oratorio de Concepción',5),(81,'San Bartolomé Perulapía',5),(82,'San Cristóbal',5),(83,'San José Guayabal',5),(84,'San Pedro Perulapán ',5),(85,'San Rafael Cedros',5),(86,'San Ramón',5),(87,'Santa Cruz Analquito',5),(88,'Santa Cruz Michapa',5),(89,'Suchitoto',5),(90,'Tenancingo',5),(91,'Aguilares',6),(92,'Apopa',6),(93,'Ayutuxtepeque',6),(94,'Cuscatancingo',6),(95,'Delgado',6),(96,'El Paisnal',6),(97,'Guazapa',6),(98,'Ilopango',6),(99,'Mejicanos',6),(100,'Nejapa',6),(101,'Panchimalco',6),(102,'Rosario de Mora',6),(103,'San Marcos',6),(104,'San Martín',6),(105,'San Salvador',6),(106,'Santiago Texacungos',6),(107,'Santo Tomás',6),(108,'Santo Tomás',6),(109,'Soyapango',6),(110,'Tonacatepeque',6),(111,'Antiguo Cuscatlán',7),(112,'Chitiupán',7),(113,'Ciudad Arce',7),(114,'Colón',7),(115,'Comasagua',7),(116,'Huizúcar',7),(117,'Jayaque',7),(118,'Jicalapa',7),(119,'La Libertad',7),(120,'Santa Tecla',7),(121,'Nuevo Cuscatlán',7),(122,'San Juan Opico',7),(123,'Quezaltepeque',7),(124,'Sacacoyo',7),(125,'San José Villanueva',7),(126,'San Matías',7),(127,'San Pablo Tacachico',7),(128,'Talnique',7),(129,'Tamanique',7),(130,'Teotepeque',7),(131,'Tepecoyo',7),(132,'Zaragoza',7),(133,'Apastepeque',8),(134,'Guadalupe',8),(135,'San Cayetano Istepeque',8),(136,'San Esteban Catarina',8),(137,'San Ildefonso',8),(138,'San Lorenzo',8),(139,'San Sebastián',8),(140,'San Vicente',8),(141,'Santa Clara',8),(142,'Santo Domingo',8),(143,'Tecoluca',8),(144,'Tepetitán',8),(145,'Verapaz',8),(146,'Cuyulán',9),(147,'El Rosario',9),(148,'Jerusalén',9),(149,'Mercedes La Ceiba',9),(150,'Olocuilta',9),(151,'Paraíso de Osorio',9),(152,'San Antonio Masahuat',9),(153,'San Emigdio',9),(154,'San Francisco Chinameca',9),(155,'San Juan Nonualco',9),(156,'San Juan Talpa',9),(157,'San Juan tepezontes',9),(158,'San Luis Talpa',9),(159,'San Luis La Herradura',9),(160,'San Miguel Teepezontes',9),(161,'San Pedro Masahuat',9),(162,'San Pedro Nonualco',9),(163,'San Rafael Obrajuelo',9),(164,'Santa María Ostuma',9),(165,'Santiago Nonualco',9),(166,'Tapalhuaca',9),(167,'Zacatecoluca',9),(168,'Cinquera',10),(169,'Dolores',10),(170,'Guacotecti',10),(171,'Ilobasco',10),(172,'Jutiapa',10),(173,'San Isidro',10),(174,'Sensutepeque',10),(175,'Tejutepeque',10),(176,'Victoria',10),(177,'Alegría',11),(178,'Berlín',11),(179,'California',11),(180,'Concepción Batres',11),(181,'El Triunfo',11),(182,'Ereguayquín',11),(183,'Estanzuelas',11),(184,'Jiquilisco',11),(185,'Jucuapa',11),(186,'Jucuarán',11),(187,'Mercedes Umaña',11),(188,'Nueva Granada',11),(189,'Ozatlán',11),(190,'Puerto El Triunfo',11),(191,'San Agustín',11),(192,'San Buenaventura',11),(193,'San Dionisio',11),(194,'San Francisco Javier',11),(195,'Santa Elena',11),(196,'Santa María',11),(197,'Santiago de María',11),(198,'Tacapán',11),(199,'Usulután',11),(200,'Carolina',12),(201,'Chapeltique',12),(202,'Chinameca',12),(203,'Chirilagua',12),(204,'Ciudad Barrios',12),(205,'Comacarán',12),(206,'El Tránsito',12),(207,'Lolotique',12),(208,'Moncagua',12),(209,'Nueva Guadalupe',12),(210,'Nuevo Edén de San Juan',12),(211,'Quelepa',12),(212,'San Antonio del Mosco',12),(213,'San Gerardo',12),(214,'San Jorge',12),(215,'San Luis de la Reina',12),(216,'San Miguel',12),(217,'San Rafael Oriente',12),(218,'Sesori',12),(219,'Uluazapa',12),(220,'Arambala',13),(221,'Cacaopera',13),(222,'Chilanga',13),(223,'Corinto',13),(224,'Delicias de Concepción',13),(225,'El Divisadero',13),(226,'El Rosario',13),(227,'Gualococti',13),(228,'Guatajiagua',13),(229,'Joateca',13),(230,'Jocoatiquea',13),(231,'Jocoro',13),(232,'Lolotiquillo',13),(233,'Meanguera',13),(234,'Osicala',13),(235,'Periquín',13),(236,'San Carlos',13),(237,'San Fernando',13),(238,'San Francisco Gotera',13),(239,'San Isidro',13),(240,'San Simón',13),(241,'Sensembra',13),(242,'Sociedad',13),(243,'Torola',13),(244,'Yamabal',13),(245,'Yoloaiquín',13),(246,'La Unión',14),(247,'San Alejo',14),(248,'Yucuaquín',14),(249,'Conchugua',14),(250,'Intipucá',14),(251,'San José',14),(252,'El Carmen',14),(253,'Yayantique',14),(254,'Bolívar',14),(255,'Meanguera del Golfo',14),(256,'Santa Rosa de Lima',14),(257,'Pasaquina',14),(258,'Anamorós',14),(259,'Nueva Esparta',14),(260,'El Sauce',14),(261,'Concepción de Oriente',14),(262,'Polorós',14),(263,'Lislique',14);
/*!40000 ALTER TABLE `municipios` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `numeros`
--

DROP TABLE IF EXISTS `numeros`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `numeros` (
  `idnumeros` int(11) NOT NULL AUTO_INCREMENT,
  `numero` int(11) DEFAULT NULL,
  `nombre` varchar(25) DEFAULT NULL,
  KEY `idnumeros` (`idnumeros`)
) ENGINE=MyISAM AUTO_INCREMENT=89 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `numeros`
--

LOCK TABLES `numeros` WRITE;
/*!40000 ALTER TABLE `numeros` DISABLE KEYS */;
INSERT INTO `numeros` VALUES (1,1,'un'),(2,2,'dos'),(3,3,'tres'),(4,4,'cuatro'),(5,5,'cinco'),(6,6,'seis'),(7,7,'siete'),(8,8,'ocho'),(9,9,'nueve'),(10,10,'diez'),(11,11,'once'),(12,12,'doce'),(13,13,'trece'),(14,14,'catorce'),(15,15,'quince'),(16,16,'diciseis'),(17,17,'diecisiete'),(18,18,'dieciocho'),(19,19,'diecinueve'),(20,20,'veinte'),(22,30,'treinta'),(23,31,'uno'),(24,40,'cuarenta'),(25,50,'cincuenta'),(26,60,'sesenta'),(27,70,'setenta'),(28,80,'ochenta'),(29,90,'noventa'),(30,100,'cien'),(31,101,'ciento'),(32,200,'doscientos'),(33,300,'trescientos'),(34,400,'cuatrocientos'),(35,500,'quinientos'),(36,600,'seiscientos'),(37,700,'setecientos'),(38,800,'ochocientos'),(39,900,'nuevecientos'),(40,1000,'mil'),(46,23,'veintitres'),(45,22,'veintidos'),(44,21,'veintiun'),(47,24,'veiticuatro'),(48,25,'vinticinco'),(49,26,'veintiseis'),(50,27,'veitisiete'),(51,28,'veintiocho'),(52,29,'veintinueve'),(53,1000,'mil'),(54,2000,'dos mil'),(55,3000,'tres mil'),(56,4000,'cuatro mil'),(57,5000,'cinco mil'),(58,6000,'seis mil'),(59,7000,'siete mil'),(60,8000,'ocho mil'),(61,9000,'nueve mil'),(62,10000,'dies mil'),(63,11000,'once mil'),(64,12000,'doce mil'),(65,13000,'trece mil'),(66,14000,'catorce mil'),(67,15000,'quince mil'),(68,16000,'dieciseis mil'),(69,17000,'diecisiete mil'),(70,18000,'dieciocho mil'),(71,19000,'dicinueve mil'),(72,20000,'veinte mil'),(73,21000,'veintiun mil'),(74,22000,'veintidos mil'),(75,23000,'veintitres mil'),(76,24000,'veinticuatro mil'),(77,25000,'veinticinco mil'),(78,26000,'vintiseis mil'),(79,27000,'veintisiete mil'),(80,28000,'veintiocho mil'),(81,29000,'veintinueve mil'),(82,30000,'treinta mil'),(83,40000,'cuarenta mil'),(84,50000,'cincuenta mil'),(85,60000,'sensenta mil'),(86,70000,'setenta mil'),(87,80000,'ochenta mil'),(88,90000,'noventa mil');
/*!40000 ALTER TABLE `numeros` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `permisos`
--

DROP TABLE IF EXISTS `permisos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `permisos` (
  `IdPermiso` int(11) NOT NULL AUTO_INCREMENT,
  `IdGrp` int(11) NOT NULL,
  `IdOpc` int(11) NOT NULL,
  PRIMARY KEY (`IdPermiso`),
  KEY `IdGrp` (`IdGrp`),
  KEY `IdOpc` (`IdOpc`)
) ENGINE=MyISAM AUTO_INCREMENT=22 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `permisos`
--

LOCK TABLES `permisos` WRITE;
/*!40000 ALTER TABLE `permisos` DISABLE KEYS */;
INSERT INTO `permisos` VALUES (1,1,1),(2,1,2),(3,1,3),(4,1,4),(5,1,5),(6,1,6),(7,1,7),(8,1,8),(9,1,9),(10,1,10),(11,1,21),(12,1,15),(13,1,22),(14,1,12),(15,1,13),(16,1,14),(17,1,16),(18,1,17),(19,1,18),(20,1,19),(21,1,20);
/*!40000 ALTER TABLE `permisos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `productos`
--

DROP TABLE IF EXISTS `productos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `productos` (
  `codproducto` int(11) NOT NULL,
  `nombre` varchar(500) DEFAULT NULL,
  `descripcion` varchar(500) DEFAULT NULL,
  `precio_unit` decimal(6,3) DEFAULT NULL,
  `precioindi` decimal(6,3) DEFAULT NULL,
  `preciopublico` decimal(6,3) DEFAULT NULL,
  `existencias` decimal(6,3) DEFAULT NULL,
  `id_categoria` int(11) DEFAULT NULL,
  `unid_med` varchar(50) DEFAULT NULL,
  `valida` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`codproducto`),
  KEY `id_categoria` (`id_categoria`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `productos`
--

LOCK TABLES `productos` WRITE;
/*!40000 ALTER TABLE `productos` DISABLE KEYS */;
INSERT INTO `productos` VALUES (1,'Producto1','Descripcion del producto 1','5.000','5.000','0.000','0.000',4,'Unidad','1');
/*!40000 ALTER TABLE `productos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `proveedor`
--

DROP TABLE IF EXISTS `proveedor`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `proveedor` (
  `codproveedor` int(11) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(250) DEFAULT NULL,
  `nit` varchar(250) DEFAULT NULL,
  `nrc` varchar(250) DEFAULT NULL,
  `giro` varchar(250) DEFAULT NULL,
  `direccion` varchar(250) DEFAULT NULL,
  `telefono` varchar(250) DEFAULT NULL,
  `fax` varchar(250) DEFAULT NULL,
  `e_mail` varchar(250) DEFAULT NULL,
  `estado` varchar(250) DEFAULT NULL,
  PRIMARY KEY (`codproveedor`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `proveedor`
--

LOCK TABLES `proveedor` WRITE;
/*!40000 ALTER TABLE `proveedor` DISABLE KEYS */;
/*!40000 ALTER TABLE `proveedor` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `respaldos`
--

DROP TABLE IF EXISTS `respaldos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `respaldos` (
  `idrespaldo` int(11) NOT NULL AUTO_INCREMENT,
  `fecha` varchar(200) DEFAULT NULL,
  `nombrearchivo` varchar(150) DEFAULT NULL,
  `automatico` varchar(150) DEFAULT NULL,
  PRIMARY KEY (`idrespaldo`)
) ENGINE=MyISAM AUTO_INCREMENT=779 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `respaldos`
--

LOCK TABLES `respaldos` WRITE;
/*!40000 ALTER TABLE `respaldos` DISABLE KEYS */;
/*!40000 ALTER TABLE `respaldos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tirajes`
--

DROP TABLE IF EXISTS `tirajes`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tirajes` (
  `idtiraje` int(11) NOT NULL,
  `tirajefs` varchar(50) DEFAULT NULL,
  `tirajefd` varchar(50) DEFAULT NULL,
  `tirajefh` varchar(50) DEFAULT NULL,
  `tirajefa` varchar(50) DEFAULT NULL,
  `tirajecs` varchar(50) DEFAULT NULL,
  `tirajecd` varchar(50) DEFAULT NULL,
  `tirajech` varchar(50) DEFAULT NULL,
  `tirajeca` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`idtiraje`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tirajes`
--

LOCK TABLES `tirajes` WRITE;
/*!40000 ALTER TABLE `tirajes` DISABLE KEYS */;
/*!40000 ALTER TABLE `tirajes` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `usr`
--

DROP TABLE IF EXISTS `usr`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `usr` (
  `IdUsr` char(15) NOT NULL,
  `cNom` varchar(20) DEFAULT NULL,
  `cApe` varchar(20) DEFAULT NULL,
  `cClave` varchar(80) DEFAULT NULL,
  `cEstado` varchar(2) DEFAULT NULL,
  PRIMARY KEY (`IdUsr`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `usr`
--

LOCK TABLES `usr` WRITE;
/*!40000 ALTER TABLE `usr` DISABLE KEYS */;
INSERT INTO `usr` VALUES ('admin','Usuario','Administrador','admin','A');
/*!40000 ALTER TABLE `usr` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2015-08-31 16:12:08
