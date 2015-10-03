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
-- Current Database: `manuelbd`
--

CREATE DATABASE /*!32312 IF NOT EXISTS*/ `manuelbd` /*!40100 DEFAULT CHARACTER SET latin1 */;

USE `manuelbd`;

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
) ENGINE=MyISAM AUTO_INCREMENT=13 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `categoria`
--

LOCK TABLES `categoria` WRITE;
/*!40000 ALTER TABLE `categoria` DISABLE KEYS */;
INSERT INTO `categoria` VALUES (6,'Cables','para todo tipo de uso'),(7,'Alambre','de acero'),(8,'Pinturas','De aceite');
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
) ENGINE=MyISAM AUTO_INCREMENT=5 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `cliente`
--

LOCK TABLES `cliente` WRITE;
/*!40000 ALTER TABLE `cliente` DISABLE KEYS */;
INSERT INTO `cliente` VALUES (3,'asdfa','asdf','asdf','adf','asdf Cuisnahuat Sonsonate','asdfas','','','Activo'),(2,'Preuba','adsf','asdfasd','asdf','fasfdsaf Armenia Sonsonate','245234','3452345','2345234','Activo'),(4,'ACEPROS','23-6523','2365-562-5','venta de agua potable','Cara Sucia San Francisco Menéndez Ahuachapán','2437-25635','','','Activo');
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
) ENGINE=MyISAM AUTO_INCREMENT=5447 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `clientescf`
--

LOCK TABLES `clientescf` WRITE;
/*!40000 ALTER TABLE `clientescf` DISABLE KEYS */;
INSERT INTO `clientescf` VALUES (5403,'Consumidor Final'),(5406,'David Cortez Rivera'),(5407,'Chepepura'),(5408,'Laura Yasmin Roman'),(5409,'David Cortez'),(5410,'David Cortez'),(5411,'Tancho Varancho'),(5412,'Manuel de Jesus'),(5413,'Claudio Cortez'),(5414,'Luis Portillo'),(5415,'Wilfredo Roman'),(5416,'Paz Cortez'),(5417,'Cardelaria Perez'),(5418,'David Cortez'),(5419,'David Cortez'),(5420,'Laura Roman'),(5421,'Wilfredo Roman'),(5422,'Norma Maricela'),(5423,'Normaricela'),(5424,'yo compres'),(5425,'Maritza'),(5426,'Belen'),(5427,'Chepepura'),(5428,'Eduardo Granado'),(5429,'Elizabeth Yanez'),(5430,'David Cortez'),(5431,'Gerson Gaitan'),(5432,'Luaricolor'),(5433,'Fautino Perez'),(5434,'David Cortez'),(5435,'Denis Sifredo'),(5436,'David Cortez'),(5437,'Laura Yasmin'),(5438,'Victor Palacios'),(5439,'David Cortez'),(5440,'Maritza'),(5441,'Segundo'),(5442,'Tercero'),(5443,'David Cortez'),(5444,'Dinora Cortez'),(5445,'David Cortez'),(5446,'CF');
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
  `codproducto` varchar(50) DEFAULT NULL,
  `cantidadunit` double DEFAULT NULL,
  `descuento` double DEFAULT NULL,
  `precioreal` double DEFAULT NULL,
  `preciodescuento` double DEFAULT NULL,
  `total` double DEFAULT NULL,
  `total1` double DEFAULT NULL,
  `preciopublico` double DEFAULT NULL,
  PRIMARY KEY (`coddetallefacturac`),
  KEY `codfacturac` (`codfacturac`),
  KEY `codproducto` (`codproducto`)
) ENGINE=MyISAM AUTO_INCREMENT=100 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `detallecompra`
--

LOCK TABLES `detallecompra` WRITE;
/*!40000 ALTER TABLE `detallecompra` DISABLE KEYS */;
INSERT INTO `detallecompra` VALUES (90,55,'03',989,0,0,0,200,0,0.2),(91,56,'03',999,0,0,0,500,0,0.5),(92,57,'02',900,0,0,0,500,0,0.56),(93,58,'03',150,0,0,0,1000,0,6.67),(94,59,'02',200,0,0,0,20,0,0.1),(95,59,'03',900,0,0,0,5,0,0.01),(96,60,'01',5000,0,0,0,60000,0,12),(97,60,'02',5000,0,0,0,12000,0,2.4),(98,60,'03',5000,0,0,0,15000,0,3),(99,61,'01',1000,0,0,0,1522.5689,0,1.5226);
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
  `codproducto` varchar(50) DEFAULT NULL,
  `cantidadunit` double DEFAULT NULL,
  `descuento` double DEFAULT NULL,
  `precioreal` double DEFAULT NULL,
  `preciodescuento` decimal(6,3) DEFAULT NULL,
  `total` double DEFAULT NULL,
  `total1` double DEFAULT NULL,
  `preciopublico` double DEFAULT NULL,
  PRIMARY KEY (`coddetallefacturav`),
  KEY `codfacturav` (`codfacturav`),
  KEY `codproducto` (`codproducto`)
) ENGINE=MyISAM AUTO_INCREMENT=347 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `detalleventa`
--

LOCK TABLES `detalleventa` WRITE;
/*!40000 ALTER TABLE `detalleventa` DISABLE KEYS */;
INSERT INTO `detalleventa` VALUES (229,152,'01',980,0,0,'0.000',5488,0,5.6),(230,153,'02',830,0,0,'0.000',1689.38,0,2.3),(231,154,'03',50,0,0,'0.000',265,0,5.3),(232,155,'02',100,0,0,'0.000',230,0,2.3),(233,156,'01',50,0,0,'0.000',280,0,5.6),(234,156,'02',50,0,0,'0.000',115,0,2.3),(235,156,'03',50,0,0,'0.000',265,0,5.3),(236,157,'03',950,0,0,'0.000',4455.75,0,5.3),(237,158,'02',950,0,0,'0.000',1933.63,0,2.3),(238,159,'01',50,0,0,'0.000',280,0,5.6),(239,160,'01',100,0,0,'0.000',560,0,5.6),(240,161,'02',50,0,0,'0.000',115,0,2.3),(241,162,'02',50,0,0,'0.000',101.77,0,2.3),(242,163,'02',50,0,0,'0.000',115,0,2.3),(243,164,'02',50,0,0,'0.000',115,0,2.3),(244,165,'02',50,0,0,'0.000',101.77,0,2.3),(245,166,'02',50,0,0,'0.000',115,0,2.3),(246,167,'02',2.17,0,0,'0.000',5,0,2.3),(247,168,'01',10,0,0,'0.000',49.56,0,5.6),(248,169,'03',0.93,0,0,'0.000',5,0,5.35),(249,170,'01',500,0,0,'0.000',2477.88,0,5.6),(250,171,'02',97.83,0,0,'0.000',225.009,0,2.3),(251,172,'03',5,0,0,'0.000',23.45,0,5.3),(252,173,'03',94.07,0,0,'0.000',498.571,0,5.3),(253,174,'01',90,0,0,'0.000',446.02,0,5.6),(254,175,'02',600,0,0,'0.000',1221.24,0,2.3),(255,176,'02',20,0,0,'0.000',46,0,2.3),(256,177,'03',200,0,0,'0.000',1060,0,5.3),(257,178,'01',200,0,0,'0.000',991.15,0,5.6),(258,179,'02',80,0,0,'0.000',184,0,2.3),(259,180,'03',50,0,0,'0.000',265,0,5.3),(260,181,'02',50,0,0,'0.000',115,0,2.3),(261,182,'01',50,0,0,'0.000',280,0,5.6),(262,183,'01',50,0,0,'0.000',280,0,5.6),(263,184,'01',50,0,0,'0.000',280,0,5.6),(264,185,'01',50,0,0,'0.000',280,0,5.6),(265,186,'02',50,0,0,'0.000',115,0,2.3),(266,187,'01',50,0,0,'0.000',280,0,5.6),(267,188,'02',50,0,0,'0.000',115,0,2.3),(268,189,'01',50,0,0,'0.000',280,0,5.6),(269,190,'03',100,0,0,'0.000',530,0,5.3),(270,190,'01',50,0,0,'0.000',280,0,5.6),(271,190,'02',50,0,0,'0.000',115,0,2.3),(272,191,'02',100,0,0,'0.000',203.54,0,2.3),(273,191,'01',10,0,0,'0.000',49.56,0,5.6),(274,192,'01',40,0,0,'0.000',224,0,5.6),(275,193,'01',500,0,0,'0.000',2800,0,5.6),(276,193,'02',500,0,0,'0.000',1150,0,2.3),(277,193,'03',500,0,0,'0.000',2650,0,5.3),(278,194,'01',50,0,0,'0.000',280,0,5.6),(279,194,'02',50,0,0,'0.000',115,0,2.3),(280,195,'01',50,0,0,'0.000',247.79,0,5.6),(281,195,'02',50,0,0,'0.000',101.77,0,2.3),(282,196,'03',50,0,0,'0.000',234.51,0,5.3),(283,197,'01',50,0,0,'0.000',280,0,5.6),(284,198,'01',50,0,0,'0.000',280,0,5.6),(285,199,'01',100,0,0,'0.000',495.58,0,5.6),(286,199,'02',50,0,0,'0.000',101.77,0,2.3),(287,200,'01',50,0,0,'0.000',280,0,5.6),(288,201,'02',50,0,0,'0.000',101.77,0,2.3),(289,202,'02',50,0,0,'0.000',115,0,2.3),(290,202,'01',50,0,0,'0.000',280,0,5.6),(291,203,'01',50,0,0,'0.000',280,0,5.6),(292,204,'02',50,0,0,'0.000',115,0,2.3),(293,205,'02',50,0,0,'0.000',115,0,2.3),(294,206,'03',50,0,0,'0.000',265,0,5.3),(295,207,'01',50,0,0,'0.000',280,0,5.6),(296,208,'03',50,0,0,'0.000',265,0,5.3),(297,209,'02',50,0,0,'0.000',115,0,2.3),(298,210,'02',50,0,0,'0.000',115,0,2.3),(299,211,'03',50,0,0,'0.000',265,0,5.3),(300,212,'01',50,0,0,'0.000',280,0,5.6),(301,213,'03',50,0,0,'0.000',265,0,5.3),(302,214,'03',50,0,0,'0.000',265,0,5.3),(303,215,'02',50,0,0,'0.000',115,0,2.3),(304,216,'01',50,0,0,'0.000',280,0,5.6),(305,217,'01',50,0,0,'0.000',280,0,5.6),(306,218,'02',50,0,0,'0.000',115,0,2.3),(307,219,'02',50,0,0,'0.000',115,0,2.3),(308,220,'03',50,0,0,'0.000',265,0,5.3),(309,221,'02',50,0,0,'0.000',115,0,2.3),(310,222,'02',50,0,0,'0.000',115,0,2.3),(311,223,'02',50,0,0,'0.000',115,0,2.3),(312,224,'02',50,0,0,'0.000',115,0,2.3),(313,225,'02',50,0,0,'0.000',115,0,2.3),(314,226,'03',50,0,0,'0.000',265,0,5.3),(315,227,'01',50,0,0,'0.000',280,0,5.6),(316,228,'01',50,0,0,'0.000',280,0,5.6),(317,229,'02',50,0,0,'0.000',115,0,2.3),(318,230,'03',50,0,0,'0.000',265,0,5.3),(319,231,'01',10,0,0,'0.000',56,0,5.6),(320,231,'02',10,0,0,'0.000',23,0,2.3),(321,232,'01',50,0,0,'0.000',280,0,5.6),(322,232,'02',5,0,0,'0.000',11.5,0,2.3),(323,233,'01',10,0,0,'0.000',56,0,5.6),(324,233,'02',10,0,0,'0.000',23,0,2.3),(325,233,'03',10,0,0,'0.000',53,0,5.3),(326,234,'01',10,0,0,'0.000',56,0,5.6),(327,234,'02',10,0,0,'0.000',23,0,2.3),(328,234,'03',10,0,0,'0.000',53,0,5.3),(329,235,'01',10,0,0,'0.000',49.56,0,5.6),(330,235,'02',10,0,0,'0.000',20.35,0,2.3),(331,235,'03',10,0,0,'0.000',46.9,0,5.3),(332,236,'01',10,0,0,'0.000',49.56,0,5.6),(333,236,'02',10,0,0,'0.000',20.35,0,2.3),(334,236,'03',10,0,0,'0.000',46.9,0,5.3),(335,237,'01',20,0,0,'0.000',99.12,0,5.6),(336,237,'02',20,0,0,'0.000',40.71,0,2.3),(337,237,'03',20,0,0,'0.000',93.81,0,5.3),(338,238,'01',20,0,0,'0.000',99.12,0,5.6),(339,238,'02',20,0,0,'0.000',40.71,0,2.3),(340,238,'03',20,0,0,'0.000',93.81,0,5.3),(341,239,'01',20,0,0,'0.000',99.12,0,5.6),(344,239,'02',20,0,0,'0.000',40.71,0,2.3),(343,239,'03',20,0,0,'0.000',93.81,0,5.3),(345,240,'01',50,0,0,'0.000',280,0,5.6),(346,241,'02',50,0,0,'0.000',115,0,2.3);
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
  `sumas` double DEFAULT NULL,
  `descuento` double DEFAULT NULL,
  `iva` double DEFAULT NULL,
  `nosujeta` double DEFAULT NULL,
  `exentas` double DEFAULT NULL,
  `total` double DEFAULT NULL,
  `formadepago` varchar(50) DEFAULT NULL,
  `unoretencion` double DEFAULT NULL,
  `estado` varchar(50) DEFAULT NULL,
  `tiraje` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`codfacturac`),
  KEY `codproveedor` (`codproveedor`)
) ENGINE=MyISAM AUTO_INCREMENT=62 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `facturacompra`
--

LOCK TABLES `facturacompra` WRITE;
/*!40000 ALTER TABLE `facturacompra` DISABLE KEYS */;
INSERT INTO `facturacompra` VALUES (55,56,'Comprobante de Credito fiscal',7,'2015-09-25',200,0,26,0,0,228,'Contado',2,'valida',' 15HC001D1'),(56,6,'Comprobante de Credito fiscal',6,'2015-09-25',500,1,65,0,0,570,'Credito',5,'valida',' 15HC001D16'),(57,25,'Comprobante de Credito fiscal',6,'2015-09-26',500,1,65,0,0,570,'Credito',5,'valida','32423c5'),(58,65,'Comprobante de Credito fiscal',7,'2015-09-26',1000,0,130,0,0,1140,'Contado',10,'valida','dfda'),(59,42,'Comprobante de Credito fiscal',8,'2015-09-26',25,1,3.25,0,0,28.5,'Credito',0.25,'valida','sdfacfad3'),(60,2423,'Comprobante de Credito fiscal',6,'2015-10-02',87000,0,11310,0,0,99180,'Credito',870,'valida','CDF000FC'),(61,34,'Comprobante de Credito fiscal',7,'2015-10-02',1522.57,0,197.93,0,0,1735.73,'Contado',15.23,'valida','CDF0000F');
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
  `sumas` double DEFAULT NULL,
  `descuento` double DEFAULT NULL,
  `iva` double DEFAULT NULL,
  `nosujeta` double DEFAULT NULL,
  `exentas` double DEFAULT NULL,
  `total` double DEFAULT NULL,
  `formadepago` varchar(50) DEFAULT NULL,
  `estado` varchar(50) DEFAULT NULL,
  `tiraje` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`codfacturav`),
  KEY `codcliente` (`codcliente`)
) ENGINE=MyISAM AUTO_INCREMENT=242 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `facturaventa`
--

LOCK TABLES `facturaventa` WRITE;
/*!40000 ALTER TABLE `facturaventa` DISABLE KEYS */;
INSERT INTO `facturaventa` VALUES (152,1,'Factura',5403,'2015-09-25 00:00:00',5488,0,0,0,0,5488,'Contado','valida','15HC001F'),(153,1,'Comprobante de Credito fiscal',4,'2015-09-25 00:00:00',1689.38,1,219.62,0,0,1909,'Credito','valida',' 15HC001D'),(154,2,'Factura',5403,'2015-09-25 00:00:00',265,0,0,0,0,265,'Contado','valida','15HC001F'),(155,3,'Factura',5403,'2015-09-25 00:00:00',230,1,0,0,0,230,'Credito','valida','15HC001F'),(156,4,'Factura',5403,'2015-09-26 00:00:00',660,1,0,0,0,660,'Credito','valida','15HC001F'),(157,2,'Comprobante de Credito fiscal',4,'2015-09-26 00:00:00',4455.75,0,579.25,0,0,5035,'Contado','valida',' 15HC001D'),(158,3,'Comprobante de Credito fiscal',2,'2015-09-26 00:00:00',1933.63,1,251.37,0,0,2185,'Credito','valida',' 15HC001D'),(159,5,'Factura',5403,'2015-09-26 00:00:00',280,0,0,0,0,280,'Contado','valida','15HC001F'),(160,6,'Factura',5403,'2015-09-26 00:00:00',560,0,0,0,0,560,'Contado','valida','15HC001F'),(161,7,'Factura',5416,'2015-09-26 00:00:00',115,0,0,0,0,115,'Contado','valida','15HC001F'),(162,4,'Comprobante de Credito fiscal',4,'2015-09-26 00:00:00',101.77,0,13.23,0,0,115,'Credito','valida',' 15HC001D'),(163,8,'Factura',5403,'2015-09-26 00:00:00',115,0,0,0,0,115,'Contado','valida','15HC001F'),(164,9,'Factura',5417,'2015-09-26 00:00:00',115,0,0,0,0,115,'Credito','valida','15HC001F'),(165,5,'Comprobante de Credito fiscal',4,'2015-09-26 00:00:00',101.77,0,13.23,0,0,115,'Credito','valida',' 15HC001D'),(166,10,'Factura',5403,'2015-09-29 00:00:00',115,0,0,0,0,115,'Contado','valida','15HC001F'),(167,11,'Factura',5403,'2015-09-29 00:00:00',5,0,0,0,0,5,'Contado','valida','15HC001F'),(168,6,'Comprobante de Credito fiscal',4,'2015-09-29 00:00:00',49.56,0,6.44,0,0,56,'Contado','valida',' 15HC001D'),(169,12,'Factura',5403,'2015-09-29 00:00:00',5,0,0,0,0,5,'Contado','valida','15HC001F'),(170,7,'Comprobante de Credito fiscal',2,'2015-09-29 00:00:00',2477.88,0,322.12,0,0,2800,'Contado','valida',' 15HC001D'),(171,13,'Factura',5403,'2015-09-29 00:00:00',225.01,0,0,0,0,225.01,'Contado','valida','15HC001F'),(172,8,'Comprobante de Credito fiscal',4,'2015-09-29 00:00:00',23.45,0,3.05,0,0,26.5,'Contado','valida',' 15HC001D'),(173,14,'Factura',5403,'2015-09-29 00:00:00',498.57,0,0,0,0,498.57,'Contado','valida','15HC001F'),(174,9,'Comprobante de Credito fiscal',4,'2015-09-29 00:00:00',446.02,0,57.98,0,0,504,'Credito','valida',' 15HC001D'),(175,10,'Comprobante de Credito fiscal',4,'2015-09-29 00:00:00',1221.24,0,158.76,0,0,1380,'Credito','valida',' 15HC001D'),(176,15,'Factura',5418,'2015-09-29 00:00:00',46,0,0,0,0,46,'Contado','valida','15HC001F'),(177,16,'Factura',5419,'2015-10-02 00:00:00',1060,0,0,0,0,1060,'Contado','valida','15HC001F'),(178,11,'Comprobante de Credito fiscal',4,'2015-10-02 00:00:00',991.15,0,128.85,0,0,1120,'Contado','valida',' 15HC001D'),(179,17,'Factura',5403,'2015-10-02 00:00:00',184,0,0,0,0,184,'Contado','valida','15HC001F'),(180,18,'Factura',5403,'2015-10-02 00:00:00',265,0,0,0,0,265,'Contado','valida','15HC001F'),(181,19,'Factura',5420,'2015-10-02 00:00:00',115,0,0,0,0,115,'Contado','valida','15HC001F'),(182,20,'Factura',5421,'2015-10-02 00:00:00',280,0,0,0,0,280,'Contado','valida','15HC001F'),(183,21,'Factura',5422,'2015-10-02 00:00:00',280,0,0,0,0,280,'Contado','valida','15HC001F'),(184,22,'Factura',5423,'2015-10-02 00:00:00',280,0,0,0,0,280,'Contado','valida','15HC001F'),(185,23,'Factura',5403,'2015-10-02 00:00:00',280,0,0,0,0,280,'Contado','valida','15HC001F'),(186,24,'Factura',5424,'2015-10-02 00:00:00',115,0,0,0,0,115,'Contado','valida','15HC001F'),(187,25,'Factura',5403,'2015-10-02 00:00:00',280,0,0,0,0,280,'Contado','valida','15HC001F'),(188,26,'Factura',5425,'2015-10-02 00:00:00',115,0,0,0,0,115,'Contado','valida','15HC001F'),(189,27,'Factura',5426,'2015-10-02 00:00:00',280,0,0,0,0,280,'Contado','valida','15HC001F'),(190,28,'Factura',5427,'2015-10-02 00:00:00',925,0,0,0,0,925,'Credito','valida','15HC001F'),(191,12,'Comprobante de Credito fiscal',4,'2015-10-02 00:00:00',253.1,0,32.9,0,0,286,'Contado','valida',' 15HC001D'),(192,29,'Factura',5428,'2015-10-02 00:00:00',224,0,0,0,0,224,'Contado','valida','15HC001F'),(193,30,'Factura',5403,'2015-10-02 00:00:00',6600,0,0,0,0,6600,'Contado','valida','15HC001F'),(194,31,'Factura',5429,'2015-10-02 00:00:00',395,0,0,0,0,395,'Contado','valida','15HC001F'),(195,13,'Comprobante de Credito fiscal',2,'2015-10-02 00:00:00',349.56,0,45.44,0,0,395,'Credito','valida',' 15HC001D'),(196,14,'Comprobante de Credito fiscal',3,'2015-10-02 00:00:00',234.51,0,30.49,0,0,265,'Contado','valida',' 15HC001D'),(197,32,'Factura',5403,'2015-10-03 00:00:00',280,0,0,0,0,280,'Contado','valida','15HC001F'),(198,33,'Factura',5430,'2015-10-03 00:00:00',280,0,0,0,0,280,'Contado','valida','15HC001F'),(199,15,'Comprobante de Credito fiscal',4,'2015-10-03 00:00:00',597.35,0,77.66,0,0,675.01,'Credito','valida',' 15HC001D'),(200,34,'Factura',5403,'2015-10-03 00:00:00',280,0,0,0,0,280,'Contado','valida','15HC001F'),(201,16,'Comprobante de Credito fiscal',2,'2015-10-03 00:00:00',101.77,0,13.23,0,0,115,'Contado','valida',' 15HC001D'),(202,35,'Factura',5403,'2015-10-03 00:00:00',395,0,0,0,0,395,'Contado','valida','15HC001F'),(203,36,'Factura',5403,'2015-10-03 00:00:00',280,0,0,0,0,280,'Contado','valida','15HC001F'),(204,37,'Factura',5431,'2015-10-03 00:00:00',115,0,0,0,0,115,'Credito','valida','15HC001F'),(205,38,'Factura',5403,'2015-10-03 00:00:00',115,0,0,0,0,115,'Contado','valida','15HC001F'),(206,39,'Factura',5403,'2015-10-03 00:00:00',265,0,0,0,0,265,'Contado','valida','15HC001F'),(207,40,'Factura',5432,'2015-10-03 00:00:00',280,0,0,0,0,280,'Contado','valida','15HC001F'),(208,41,'Factura',5433,'2015-10-03 00:00:00',265,0,0,0,0,265,'Credito','valida','15HC001F'),(209,42,'Factura',5403,'2015-10-03 00:00:00',115,0,0,0,0,115,'Contado','valida','15HC001F'),(210,43,'Factura',5403,'2015-10-03 00:00:00',115,0,0,0,0,115,'Contado','valida','15HC001F'),(211,44,'Factura',5403,'2015-10-03 00:00:00',265,0,0,0,0,265,'Contado','valida','15HC001F'),(212,45,'Factura',5403,'2015-10-03 00:00:00',280,0,0,0,0,280,'Contado','valida','15HC001F'),(213,46,'Factura',5434,'2015-10-03 00:00:00',265,0,0,0,0,265,'Contado','valida','15HC001F'),(214,47,'Factura',5403,'2015-10-03 00:00:00',265,0,0,0,0,265,'Contado','valida','15HC001F'),(215,48,'Factura',5435,'2015-10-03 00:00:00',115,0,0,0,0,115,'Contado','valida','15HC001F'),(216,49,'Factura',5403,'2015-10-03 00:00:00',280,0,0,0,0,280,'Contado','valida','15HC001F'),(217,50,'Factura',5403,'2015-10-03 00:00:00',280,0,0,0,0,280,'Contado','valida','15HC001F'),(235,17,'Comprobante de Credito fiscal',2,'2015-10-03 00:00:00',116.81,0,15.19,0,0,132,'Contado','valida',' 15HC001D'),(219,51,'Factura',5436,'2015-10-03 00:00:00',115,0,0,0,0,115,'Contado','valida','15HC001F'),(220,52,'Factura',5437,'2015-10-03 00:00:00',265,0,0,0,0,265,'Credito','valida','15HC001F'),(221,53,'Factura',5403,'2015-10-03 00:00:00',115,0,0,0,0,115,'Contado','valida','15HC001F'),(222,54,'Factura',5403,'2015-10-03 00:00:00',115,0,0,0,0,115,'Contado','valida','15HC001F'),(223,55,'Factura',5438,'2015-10-03 00:00:00',115,0,0,0,0,115,'Contado','valida','15HC001F'),(224,56,'Factura',5403,'2015-10-03 00:00:00',115,0,0,0,0,115,'Contado','valida','15HC001F'),(225,57,'Factura',5403,'2015-10-03 00:00:00',115,0,0,0,0,115,'Contado','valida','15HC001F'),(226,58,'Factura',5439,'2015-10-03 00:00:00',265,0,0,0,0,265,'Contado','valida','15HC001F'),(227,59,'Factura',5440,'2015-10-03 00:00:00',280,0,0,0,0,280,'Contado','valida','15HC001F'),(228,60,'Factura',5403,'2015-10-03 00:00:00',280,0,0,0,0,280,'Contado','valida','15HC001F'),(229,61,'Factura',5441,'2015-10-03 00:00:00',115,0,0,0,0,115,'Contado','valida','15HC001F'),(230,62,'Factura',5442,'2015-10-03 00:00:00',265,0,0,0,0,265,'Contado','valida','15HC001F'),(231,63,'Factura',5403,'2015-10-03 00:00:00',79,0,0,0,0,79,'Contado','valida','15HC001F'),(232,64,'Factura',5443,'2015-10-03 00:00:00',291.5,0,0,0,0,291.5,'Contado','valida','15HC001F'),(233,65,'Factura',5444,'2015-10-03 00:00:00',132,0,0,0,0,132,'Contado','valida','15HC001F'),(234,66,'Factura',5445,'2015-10-03 00:00:00',132,0,0,0,0,132,'Contado','valida','15HC001F'),(236,18,'Comprobante de Credito fiscal',4,'2015-10-03 00:00:00',116.81,0,15.19,0,0,132,'Contado','valida',' 15HC001D'),(237,19,'Comprobante de Credito fiscal',3,'2015-10-03 00:00:00',233.64,0,30.37,0,0,264.01,'Contado','valida',' 15HC001D'),(238,20,'Comprobante de Credito fiscal',2,'2015-10-03 00:00:00',233.64,0,30.37,0,0,264.01,'Contado','valida',' 15HC001D'),(239,21,'Comprobante de Credito fiscal',4,'2015-10-03 00:00:00',233.64,0,30.37,0,0,264.01,'Contado','valida',' 15HC001D'),(240,67,'Factura',5403,'2015-10-03 00:00:00',280,0,0,0,0,280,'Contado','valida','15HC001F'),(241,68,'Factura',5446,'2015-10-03 00:00:00',115,0,0,0,0,115,'Contado','valida','15HC001F');
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
) ENGINE=MyISAM AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `grp`
--

LOCK TABLES `grp` WRITE;
/*!40000 ALTER TABLE `grp` DISABLE KEYS */;
INSERT INTO `grp` VALUES (1,'Administrador'),(2,'SUPER USUARIO');
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
) ENGINE=MyISAM AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `grpusr`
--

LOCK TABLES `grpusr` WRITE;
/*!40000 ALTER TABLE `grpusr` DISABLE KEYS */;
INSERT INTO `grpusr` VALUES (1,1,'admin'),(2,2,'Prueba'),(3,2,'p');
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
) ENGINE=MyISAM AUTO_INCREMENT=24 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `menu`
--

LOCK TABLES `menu` WRITE;
/*!40000 ALTER TABLE `menu` DISABLE KEYS */;
INSERT INTO `menu` VALUES (1,'Maestros',0,'Ninguna','Maestros'),(2,'Grupos',1,'mGrupo','Maestro Grupos'),(3,'Usuarios',1,'mUsuarios','Maestro de usuarios'),(4,'Menu',1,'mMenu','Maestro del menu'),(5,'Configuracion',0,'Ninguna','Configuracion'),(6,'Grupos de usuarios',5,'frmUsuarios','Grupos de usuarios'),(7,'Permisos',5,'frmPermisos','Permisos'),(8,'Mantenimiento',0,'Ninguna','Menu mantenimiento'),(9,'Productos',8,'Productos','Mustra los productos'),(10,'Proveedores',8,'Proveedores','Muestra los proveedores'),(21,'Configuraciones',8,'Configuraciones','muestra las configuraciones'),(12,'Movimientos',0,'Ninguna','Nada'),(13,'Compras',12,'compra','facturas compras'),(14,'Ventas',12,'Ventas','Facturas ventas'),(15,'Clientes',8,'Clientes','Clientes'),(16,'Documentos',0,'Ninguna','para ver docuentos'),(17,'Compras realizadas',16,'Compras_realizadas','muestra las compras realizadas'),(18,'Ventas Realizadas',16,'VentasRealizadas','muestra las ventas realizadas'),(19,'Kardex',16,'Kardex','muestra el kardez'),(20,'Reportes',16,'Reportes','Muestra las distintos reportez'),(22,'Respaldos',8,'Respaldos','Hace respaldo del al base de datos'),(23,'Compras y Ventas',12,'VentasCompras','El que muestra las compras y la ventas');
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
-- Table structure for table `notificaciones`
--

DROP TABLE IF EXISTS `notificaciones`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `notificaciones` (
  `idnoti` int(11) NOT NULL AUTO_INCREMENT,
  `orden` int(11) DEFAULT NULL,
  `tipo` varchar(50) DEFAULT NULL,
  `cliente` varchar(50) DEFAULT NULL,
  `cantidad` double DEFAULT NULL,
  `idfacturav` int(11) DEFAULT NULL,
  PRIMARY KEY (`idnoti`),
  KEY `idfacturav` (`idfacturav`)
) ENGINE=MyISAM AUTO_INCREMENT=62 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `notificaciones`
--

LOCK TABLES `notificaciones` WRITE;
/*!40000 ALTER TABLE `notificaciones` DISABLE KEYS */;
/*!40000 ALTER TABLE `notificaciones` ENABLE KEYS */;
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
) ENGINE=MyISAM AUTO_INCREMENT=38 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `permisos`
--

LOCK TABLES `permisos` WRITE;
/*!40000 ALTER TABLE `permisos` DISABLE KEYS */;
INSERT INTO `permisos` VALUES (1,1,1),(2,1,2),(3,1,3),(4,1,4),(5,1,5),(6,1,6),(7,1,7),(8,1,8),(9,1,9),(10,1,10),(22,2,8),(12,1,15),(13,1,22),(14,1,12),(23,2,9),(16,1,14),(24,2,12),(30,1,13),(26,2,10),(27,2,15),(28,2,22),(29,2,14),(31,1,16),(32,1,17),(33,1,23),(34,1,18),(35,1,21),(36,1,20),(37,1,19);
/*!40000 ALTER TABLE `permisos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `productos`
--

DROP TABLE IF EXISTS `productos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `productos` (
  `codproducto` varchar(500) NOT NULL,
  `nombre` varchar(500) DEFAULT NULL,
  `descripcion` varchar(500) DEFAULT NULL,
  `precio_unit` double DEFAULT NULL,
  `precioindi` double DEFAULT NULL,
  `preciopublico` double DEFAULT NULL,
  `existencias` double DEFAULT NULL,
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
INSERT INTO `productos` VALUES ('asdf5','hola','holah',0.1,0.1,0,23215,4,'hola','0'),('01','Cable Coaxial 1/2 milimetro','Para cable e Internet',5.6,5.6,0,5090,6,'Yarda','1'),('02','Alambre de amarre','Para la construccion de edificios y casas',2.3,2.3,0,4035,7,'Libra','1'),('03','Pintura arcor Negra','Pintura de agua',5.3,5.3,0,4500,8,'Galon','1');
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
) ENGINE=MyISAM AUTO_INCREMENT=11 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `proveedor`
--

LOCK TABLES `proveedor` WRITE;
/*!40000 ALTER TABLE `proveedor` DISABLE KEYS */;
INSERT INTO `proveedor` VALUES (2,'asldjf','adf','ads','aaasd','sdfads Caluco Sonsonate','asdf','asdf','asdfasdf','Activo'),(3,'asdf','asdf','asdf','adf','asdfasdf Nahuizalco Sonsonate','52648652','df','asdf','Activo'),(5,'fdhjk','kjhlk','hkljh','lkhñhj','jkhklhjh Ahuachapán Ahuachapán','klhklh','kjlhk','lhkljh','Activo'),(6,'Galvaniza','45565-6556','55-4545','Manufacturadora de Aluminio','Por ahi nomas San Francisco Morazán Chalatenango','2564821','','','Activo'),(7,'Ferreteria la entrada','123-656','12-558','compra y venta de herramientas','Cara Sucia San Francisco Menéndez Ahuachapán','2437-25-71','','','Activo'),(8,'hola','hola','hola','hola','hola San José Las Flores Chalatenango','hola','','','Activo'),(9,'pr','pr','pr','pr','pr Coatepeque Santa Ana','pr','pr','pr','Activo'),(10,'aja','aja','aja','aja','aja Coatepeque Santa Ana','aja','aja','aja','Activo');
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
) ENGINE=MyISAM AUTO_INCREMENT=788 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `respaldos`
--

LOCK TABLES `respaldos` WRITE;
/*!40000 ALTER TABLE `respaldos` DISABLE KEYS */;
INSERT INTO `respaldos` VALUES (785,'31/08/2015 16:21:05','Respaldo785','false'),(786,'12/9/2015 1:20:02 a. m.','Respaldo786','false'),(787,'3/10/2015 3:21:58 p. m.','Respaldo787',' ');
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
INSERT INTO `tirajes` VALUES (1,'15HC001F','1','750','69',' 15HC001D','1','500','22');
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
INSERT INTO `usr` VALUES ('admin','Usuario','Administrador','admin','A'),('p','P','P','p','A'),('Prueba','NOMBRE','APELLIDO','prueba','A');
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

-- Dump completed on 2015-10-03 15:22:01
