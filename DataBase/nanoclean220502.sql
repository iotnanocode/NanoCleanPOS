-- MySQL dump 10.19  Distrib 10.3.32-MariaDB, for debian-linux-gnu (x86_64)
--
-- Host: localhost    Database: nanoclean
-- ------------------------------------------------------
-- Server version	10.3.32-MariaDB-0ubuntu0.20.04.1

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `almacenes`
--

DROP TABLE IF EXISTS `almacenes`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `almacenes` (
  `ID` varchar(40) CHARACTER SET utf8 NOT NULL,
  `FK_Categoria` varchar(40) CHARACTER SET utf8 DEFAULT NULL,
  `Descripcion` varchar(250) CHARACTER SET utf8 DEFAULT NULL,
  `Ubicacion` varchar(500) CHARACTER SET utf8 DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `almacenes`
--

LOCK TABLES `almacenes` WRITE;
/*!40000 ALTER TABLE `almacenes` DISABLE KEYS */;
/*!40000 ALTER TABLE `almacenes` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `almacenes_clasificacion`
--

DROP TABLE IF EXISTS `almacenes_clasificacion`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `almacenes_clasificacion` (
  `ID` varchar(40) CHARACTER SET utf8 NOT NULL,
  `Descripcion` varchar(45) CHARACTER SET utf8 DEFAULT NULL,
  `Virtual` tinyint(4) DEFAULT 0 COMMENT 'las ubcaciones virtuales son para cuadrar el inventario',
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `almacenes_clasificacion`
--

LOCK TABLES `almacenes_clasificacion` WRITE;
/*!40000 ALTER TABLE `almacenes_clasificacion` DISABLE KEYS */;
/*!40000 ALTER TABLE `almacenes_clasificacion` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `almacenes_tiendas`
--

DROP TABLE IF EXISTS `almacenes_tiendas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `almacenes_tiendas` (
  `ID` varchar(40) CHARACTER SET utf8 NOT NULL,
  `FK_Almacen` varchar(40) CHARACTER SET utf8 DEFAULT NULL,
  `FK_Tienda` varchar(40) CHARACTER SET utf8 DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `almacenes_tiendas`
--

LOCK TABLES `almacenes_tiendas` WRITE;
/*!40000 ALTER TABLE `almacenes_tiendas` DISABLE KEYS */;
/*!40000 ALTER TABLE `almacenes_tiendas` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `categorias_productos`
--

DROP TABLE IF EXISTS `categorias_productos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `categorias_productos` (
  `ID` varchar(40) CHARACTER SET utf8 NOT NULL,
  `Descripcion` varchar(45) CHARACTER SET utf8 DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `categorias_productos`
--

LOCK TABLES `categorias_productos` WRITE;
/*!40000 ALTER TABLE `categorias_productos` DISABLE KEYS */;
/*!40000 ALTER TABLE `categorias_productos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `clientes`
--

DROP TABLE IF EXISTS `clientes`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `clientes` (
  `ID` varchar(40) CHARACTER SET utf8 NOT NULL,
  `RFC` varchar(15) CHARACTER SET utf8 DEFAULT NULL,
  `RSocial` varchar(250) CHARACTER SET utf8 DEFAULT NULL,
  `Calle` varchar(45) CHARACTER SET utf8 DEFAULT NULL,
  `CP` varchar(45) CHARACTER SET utf8 DEFAULT NULL,
  `Colonia` varchar(250) CHARACTER SET utf8 DEFAULT NULL,
  `Estado` varchar(250) DEFAULT NULL,
  `Municipio` varchar(45) DEFAULT NULL,
  `Pais` varchar(45) DEFAULT NULL,
  `Contacto` varchar(45) DEFAULT NULL,
  `Telefono` varchar(45) DEFAULT NULL,
  `Mail` varchar(45) DEFAULT NULL,
  `Activo` bit(1) DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `clientes`
--

LOCK TABLES `clientes` WRITE;
/*!40000 ALTER TABLE `clientes` DISABLE KEYS */;
INSERT INTO `clientes` VALUES ('b5621212-ca4c-11ec-9d64-0242ac120002','XAXX010101000','Publico en General','NA','45000','NA','NA','NA','MX','Na','Na','NA','');
/*!40000 ALTER TABLE `clientes` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `existencias`
--

DROP TABLE IF EXISTS `existencias`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `existencias` (
  `ID` varchar(40) CHARACTER SET utf8 NOT NULL,
  `FK_Producto` varchar(40) CHARACTER SET utf8 DEFAULT NULL,
  `FK_Almacen` varchar(40) CHARACTER SET utf8 DEFAULT NULL,
  `Cantidad` float DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `existencias`
--

LOCK TABLES `existencias` WRITE;
/*!40000 ALTER TABLE `existencias` DISABLE KEYS */;
/*!40000 ALTER TABLE `existencias` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `movimientos`
--

DROP TABLE IF EXISTS `movimientos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `movimientos` (
  `ID` varchar(40) CHARACTER SET utf8 NOT NULL,
  `FK_Producto` varchar(40) CHARACTER SET utf8 DEFAULT NULL,
  `FK_AlmacenOrigen` varchar(40) CHARACTER SET utf8 DEFAULT NULL,
  `FK_AlmacenDestino` varchar(40) CHARACTER SET utf8 DEFAULT NULL,
  `Fecha` datetime DEFAULT NULL,
  `Cantidad` float DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `movimientos`
--

LOCK TABLES `movimientos` WRITE;
/*!40000 ALTER TABLE `movimientos` DISABLE KEYS */;
/*!40000 ALTER TABLE `movimientos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `productos`
--

DROP TABLE IF EXISTS `productos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `productos` (
  `ID` varchar(40) CHARACTER SET utf8 NOT NULL,
  `FK_Categoria` varchar(40) CHARACTER SET utf8 DEFAULT NULL,
  `UPC` varchar(8) CHARACTER SET utf8 DEFAULT NULL,
  `Descripcion` varchar(45) DEFAULT NULL,
  `Presentacion` int(11) DEFAULT NULL COMMENT 'tamaño en litros',
  `Costo1` float DEFAULT NULL,
  `Costo2` float DEFAULT NULL,
  `Precio` float DEFAULT NULL,
  `FK_Envase` varchar(40) CHARACTER SET utf8 DEFAULT NULL COMMENT 'los envases son tambien productos',
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `productos`
--

LOCK TABLES `productos` WRITE;
/*!40000 ALTER TABLE `productos` DISABLE KEYS */;
/*!40000 ALTER TABLE `productos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tiendas`
--

DROP TABLE IF EXISTS `tiendas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tiendas` (
  `ID` varchar(40) CHARACTER SET utf8 NOT NULL,
  `Nombre` varchar(250) CHARACTER SET utf8 DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tiendas`
--

LOCK TABLES `tiendas` WRITE;
/*!40000 ALTER TABLE `tiendas` DISABLE KEYS */;
/*!40000 ALTER TABLE `tiendas` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `users`
--

DROP TABLE IF EXISTS `users`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `users` (
  `ID` varchar(40) CHARACTER SET utf8 NOT NULL,
  `Nombre` varchar(250) CHARACTER SET utf8 DEFAULT NULL,
  `Usuario` varchar(50) CHARACTER SET utf8 DEFAULT NULL,
  `Pwd` varbinary(255) DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `users`
--

LOCK TABLES `users` WRITE;
/*!40000 ALTER TABLE `users` DISABLE KEYS */;
/*!40000 ALTER TABLE `users` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `ventas`
--

DROP TABLE IF EXISTS `ventas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `ventas` (
  `ID` varchar(40) CHARACTER SET utf8 NOT NULL,
  `Fecha` datetime DEFAULT NULL,
  `FK_Cliente` varchar(40) CHARACTER SET utf8 DEFAULT 'b5621212-ca4c-11ec-9d64-0242ac120002' COMMENT 'por default van a publico en general',
  `Facturada` tinyint(4) DEFAULT NULL,
  `MontoTotal` float DEFAULT NULL,
  `FK_Usuario` varchar(40) CHARACTER SET utf8 DEFAULT NULL,
  `FK_Tienda` varchar(40) CHARACTER SET utf8 DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ventas`
--

LOCK TABLES `ventas` WRITE;
/*!40000 ALTER TABLE `ventas` DISABLE KEYS */;
/*!40000 ALTER TABLE `ventas` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `ventas_detalles`
--

DROP TABLE IF EXISTS `ventas_detalles`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `ventas_detalles` (
  `ID` varchar(40) CHARACTER SET utf8 NOT NULL,
  `FK_Venta` varchar(40) CHARACTER SET utf8 DEFAULT NULL,
  `FK_Producto` varchar(40) CHARACTER SET utf8 DEFAULT NULL,
  `Cantidad` float DEFAULT NULL,
  `Precio` float DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ventas_detalles`
--

LOCK TABLES `ventas_detalles` WRITE;
/*!40000 ALTER TABLE `ventas_detalles` DISABLE KEYS */;
/*!40000 ALTER TABLE `ventas_detalles` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Temporary table structure for view `vwVentas`
--

DROP TABLE IF EXISTS `vwVentas`;
/*!50001 DROP VIEW IF EXISTS `vwVentas`*/;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
/*!50001 CREATE TABLE `vwVentas` (
  `ID` tinyint NOT NULL,
  `Fecha` tinyint NOT NULL,
  `FK_Cliente` tinyint NOT NULL,
  `Facturada` tinyint NOT NULL,
  `MontoTotal` tinyint NOT NULL,
  `Cantidad` tinyint NOT NULL,
  `Precio` tinyint NOT NULL,
  `UPC` tinyint NOT NULL,
  `Descripcion` tinyint NOT NULL,
  `Vendedor` tinyint NOT NULL,
  `Tienda` tinyint NOT NULL
) ENGINE=MyISAM */;
SET character_set_client = @saved_cs_client;

--
-- Final view structure for view `vwVentas`
--

/*!50001 DROP TABLE IF EXISTS `vwVentas`*/;
/*!50001 DROP VIEW IF EXISTS `vwVentas`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_general_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`nanocode`@`%` SQL SECURITY DEFINER */
/*!50001 VIEW `vwVentas` AS select `V`.`ID` AS `ID`,`V`.`Fecha` AS `Fecha`,`V`.`FK_Cliente` AS `FK_Cliente`,`V`.`Facturada` AS `Facturada`,`V`.`MontoTotal` AS `MontoTotal`,`VD`.`Cantidad` AS `Cantidad`,`VD`.`Precio` AS `Precio`,`P`.`UPC` AS `UPC`,`P`.`Descripcion` AS `Descripcion`,`U`.`Nombre` AS `Vendedor`,`T`.`Nombre` AS `Tienda` from ((((`ventas` `V` join `ventas_detalles` `VD` on(`V`.`ID` = `VD`.`FK_Venta`)) join `productos` `P` on(`VD`.`FK_Producto` = `P`.`ID`)) join `users` `U` on(`V`.`FK_Usuario` = `U`.`ID`)) join `tiendas` `T` on(`V`.`FK_Tienda` = `T`.`ID`)) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2022-05-02 19:40:23
