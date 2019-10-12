-- MySQL dump 10.13  Distrib 8.0.16, for Win64 (x86_64)
--
-- Host: localhost    Database: ems
-- ------------------------------------------------------
-- Server version	8.0.16

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
 SET NAMES utf8 ;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `attendance`
--

DROP TABLE IF EXISTS `attendance`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `attendance` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `studentrollno_id` int(11) DEFAULT NULL,
  `month` varchar(45) CHARACTER SET utf8 COLLATE utf8_bin DEFAULT NULL,
  `total` int(11) DEFAULT NULL,
  `current` int(11) DEFAULT NULL,
  `academic_id` int(11) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=237 DEFAULT CHARSET=utf8 COLLATE=utf8_bin;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `attendance`
--

LOCK TABLES `attendance` WRITE;
/*!40000 ALTER TABLE `attendance` DISABLE KEYS */;
INSERT INTO `attendance` VALUES (1,1,'December',120,110,1),(2,2,'December',120,40,1),(3,3,'December',120,49,1),(4,4,'December',120,110,1),(5,5,'December',120,110,1),(6,6,'December',120,110,1),(7,7,'December',120,110,1),(8,8,'December',120,110,1),(9,9,'December',120,110,1),(10,10,'December',120,110,1),(11,11,'December',120,110,1),(12,12,'December',120,110,1),(13,13,'December',120,110,1),(14,14,'December',120,40,1),(15,15,'December',120,110,1),(16,16,'December',120,110,1),(17,17,'December',120,110,1),(18,18,'December',120,110,1),(19,19,'December',120,110,1),(20,20,'December',120,110,1),(21,21,'December',120,110,1),(22,22,'December',120,110,1),(23,23,'December',120,110,1),(24,24,'December',120,110,1),(25,25,'December',120,110,1),(26,26,'December',120,110,1),(27,27,'December',120,110,1),(28,28,'December',120,110,1),(29,29,'December',120,110,1),(30,30,'December',120,110,1),(31,31,'December',120,110,1),(32,32,'December',120,110,1),(33,33,'December',120,110,1),(34,34,'December',120,110,1),(35,35,'December',120,110,1),(36,36,'December',120,110,1),(37,37,'December',120,40,1),(38,38,'December',120,110,1),(39,39,'December',120,110,1),(40,40,'December',120,110,1),(41,41,'December',120,110,1),(42,42,'December',120,110,1),(43,43,'December',120,110,1),(44,44,'December',120,110,1),(45,45,'December',120,110,1),(46,46,'December',120,110,1),(47,47,'December',120,110,1),(48,48,'December',120,110,1),(49,49,'December',120,110,1),(50,50,'December',120,110,1),(51,51,'December',120,110,1),(52,52,'December',120,110,1),(53,53,'December',120,110,1),(54,54,'December',120,110,1),(55,55,'December',120,110,1),(56,56,'December',120,110,1),(57,57,'December',120,110,1),(58,58,'December',120,110,1),(59,59,'December',120,110,1),(60,60,'December',120,110,1),(61,61,'December',120,40,1),(62,62,'December',120,110,1),(63,63,'December',120,110,1),(64,64,'December',120,110,1),(65,65,'December',120,110,1),(66,66,'December',120,110,1),(67,67,'December',120,110,1),(68,68,'December',120,110,1),(69,69,'December',120,110,1),(70,70,'December',120,110,1),(71,71,'December',120,110,1),(72,72,'December',120,110,1),(73,73,'December',120,110,1),(74,74,'December',120,110,1),(75,75,'December',120,110,1),(76,76,'December',120,110,1),(77,77,'December',120,110,1),(78,78,'December',120,110,1),(79,79,'December',120,110,1),(80,80,'December',120,110,1),(81,81,'December',120,110,1),(82,82,'December',120,110,1),(83,83,'December',120,110,1),(84,84,'December',120,110,1),(85,85,'December',120,40,1),(86,86,'December',120,110,1),(87,87,'December',120,110,1),(88,88,'December',120,110,1),(89,89,'December',120,110,1),(90,90,'December',120,110,1),(91,91,'December',120,110,1),(92,92,'December',120,110,1),(93,93,'December',120,110,1),(94,94,'December',120,110,1),(95,95,'December',120,110,1),(96,96,'December',120,110,1),(97,97,'December',120,110,1),(98,98,'December',120,110,1),(99,99,'December',120,110,1),(100,100,'December',120,110,1),(101,101,'December',120,110,1),(102,102,'December',120,110,1),(103,103,'December',120,110,1),(104,104,'December',120,110,1),(105,105,'December',120,110,1),(106,106,'December',120,110,1),(107,107,'December',120,110,1),(108,108,'December',120,110,1),(109,109,'December',120,110,1),(110,110,'December',120,110,1),(111,111,'December',120,110,1),(112,112,'December',120,110,1),(113,113,'December',120,110,1),(114,114,'December',120,110,1),(115,115,'December',120,110,1),(116,116,'December',120,110,1),(117,117,'December',120,110,1),(118,118,'December',120,110,1),(119,119,'December',120,110,1),(120,120,'December',120,110,1),(121,121,'December',120,110,1),(122,122,'December',120,110,1),(123,123,'December',120,110,1),(124,124,'December',120,110,1),(125,125,'December',120,110,1),(126,126,'December',120,110,1),(127,127,'December',120,110,1),(128,128,'December',120,110,1),(129,129,'December',120,110,1),(130,130,'December',120,110,1),(131,131,'December',120,110,1),(132,132,'December',120,110,1),(133,133,'December',120,110,1),(134,134,'December',120,110,1),(135,135,'December',120,110,1),(136,136,'December',120,110,1),(137,137,'December',120,110,1),(138,138,'December',120,110,1),(139,139,'December',120,110,1),(140,140,'December',120,110,1),(141,141,'December',120,110,1),(142,142,'December',120,110,1),(143,143,'December',120,110,1),(144,144,'December',120,110,1),(145,145,'December',120,110,1),(146,146,'December',120,110,1),(147,147,'December',120,110,1),(148,148,'December',120,110,1),(149,149,'December',120,110,1),(150,150,'December',120,110,1),(151,151,'December',120,110,1),(152,152,'December',120,110,1),(153,153,'December',120,110,1),(154,154,'December',120,110,1),(155,155,'December',120,110,1),(156,156,'December',120,110,1),(157,157,'December',120,110,1),(158,158,'December',120,110,1),(159,159,'December',120,110,1),(160,160,'December',120,110,1),(161,161,'December',120,110,1),(162,162,'December',120,110,1),(163,163,'December',120,110,1),(164,164,'December',120,110,1),(165,165,'December',120,110,1),(166,166,'December',120,110,1),(167,167,'December',120,110,1),(168,168,'December',120,110,1),(169,169,'December',120,110,1),(170,170,'December',120,110,1),(171,171,'December',120,110,1),(172,172,'December',120,110,1),(173,173,'December',120,110,1),(174,174,'December',120,110,1),(175,175,'December',120,110,1),(176,176,'December',120,110,1),(177,177,'December',120,110,1),(178,178,'December',120,110,1),(179,179,'December',120,110,1),(180,180,'December',120,110,1),(181,181,'December',120,110,1),(182,182,'December',120,110,1),(183,183,'December',120,110,1),(184,184,'December',120,110,1),(185,185,'December',120,110,1),(186,186,'December',120,110,1),(187,187,'December',120,110,1),(188,188,'December',120,110,1),(189,189,'December',120,110,1),(190,190,'December',120,110,1),(191,191,'December',120,110,1),(192,192,'December',120,110,1),(193,193,'December',120,110,1),(194,194,'December',120,110,1),(195,195,'December',120,110,1),(196,196,'December',120,110,1),(197,197,'December',120,110,1),(198,198,'December',120,110,1),(199,199,'December',120,110,1),(200,200,'December',120,110,1),(201,201,'December',120,110,1),(202,202,'December',120,110,1),(203,203,'December',120,110,1),(204,204,'December',120,110,1),(205,205,'December',120,110,1),(206,206,'December',120,110,1),(207,207,'December',120,110,1),(208,208,'December',120,110,1),(209,209,'December',120,110,1),(210,210,'December',120,110,1),(211,211,'December',120,110,1),(212,212,'December',120,110,1),(213,213,'December',120,110,1),(214,214,'December',120,110,1),(215,215,'December',120,110,1),(216,216,'December',120,110,1),(217,217,'December',120,110,1),(218,218,'December',120,110,1),(219,219,'December',120,110,1),(220,220,'December',120,110,1),(221,221,'December',120,110,1),(222,222,'December',120,110,1),(223,223,'December',120,110,1),(224,224,'December',120,110,1),(225,225,'December',120,110,1),(226,226,'December',120,110,1),(227,227,'December',120,110,1),(228,228,'December',120,110,1),(229,229,'December',120,110,1),(230,230,'December',120,110,1),(231,231,'December',120,110,1),(232,232,'December',120,110,1),(233,233,'December',120,110,1),(234,234,'December',120,110,1),(235,12,'January',200,190,1),(236,9,'January',120,110,1);
/*!40000 ALTER TABLE `attendance` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2019-09-13 10:30:52
