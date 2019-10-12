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
-- Table structure for table `student_detail`
--

DROP TABLE IF EXISTS `student_detail`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `student_detail` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `studentrollno_id` int(11) DEFAULT NULL,
  `year_id` int(11) DEFAULT NULL,
  `major_id` int(11) DEFAULT NULL,
  `class_id` int(11) DEFAULT NULL,
  `academic_id` int(11) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=235 DEFAULT CHARSET=utf8 COLLATE=utf8_bin;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `student_detail`
--

LOCK TABLES `student_detail` WRITE;
/*!40000 ALTER TABLE `student_detail` DISABLE KEYS */;
INSERT INTO `student_detail` VALUES (1,1,5,2,13,1),(2,2,5,3,15,1),(3,3,4,2,10,1),(4,4,4,3,12,1),(5,5,3,2,7,1),(6,6,3,3,9,1),(7,7,2,2,4,1),(8,8,2,3,6,1),(9,9,1,1,1,1),(10,10,1,1,1,1),(11,11,1,1,1,1),(12,12,1,1,1,1),(13,13,1,1,1,1),(14,14,1,1,1,1),(15,15,1,1,1,1),(16,16,1,1,1,1),(17,17,1,1,1,1),(18,18,1,1,1,1),(19,19,1,1,1,1),(20,20,1,1,1,1),(21,21,1,1,1,1),(22,22,1,1,1,1),(23,23,1,1,1,1),(24,24,1,1,1,1),(25,25,1,1,2,1),(26,26,1,1,2,1),(27,27,1,1,2,1),(28,28,1,1,2,1),(29,29,1,1,2,1),(30,30,1,1,2,1),(31,31,1,1,2,1),(32,32,1,1,2,1),(33,33,1,1,2,1),(34,34,1,1,2,1),(35,35,1,1,2,1),(36,36,1,1,2,1),(37,37,1,1,2,1),(38,38,1,1,2,1),(39,39,1,1,3,1),(40,40,1,1,3,1),(41,41,1,1,3,1),(42,42,1,1,3,1),(43,43,1,1,3,1),(44,44,1,1,3,1),(45,45,1,1,3,1),(46,46,1,1,3,1),(47,47,1,1,3,1),(48,48,1,1,3,1),(49,49,1,1,3,1),(50,50,1,1,3,1),(51,51,1,1,3,1),(52,52,1,1,3,1),(53,53,1,1,3,1),(54,54,1,1,3,1),(55,55,2,2,4,1),(56,56,2,2,4,1),(57,57,2,2,4,1),(58,58,2,2,4,1),(59,59,2,2,4,1),(60,60,2,2,4,1),(61,61,2,2,4,1),(62,62,2,2,4,1),(63,63,2,2,4,1),(64,64,2,2,4,1),(65,65,2,2,4,1),(66,66,2,2,4,1),(67,67,2,2,4,1),(68,68,2,2,4,1),(69,69,2,2,4,1),(70,70,2,2,5,1),(71,71,2,2,5,1),(72,72,2,2,5,1),(73,73,2,2,5,1),(74,74,2,2,5,1),(75,75,2,2,5,1),(76,76,2,2,5,1),(77,77,2,2,5,1),(78,78,2,2,5,1),(79,79,2,2,5,1),(80,80,2,2,5,1),(81,81,2,2,5,1),(82,82,2,2,5,1),(83,83,2,2,5,1),(84,84,2,2,5,1),(85,85,2,3,6,1),(86,86,2,3,6,1),(87,87,2,3,6,1),(88,88,2,3,6,1),(89,89,2,3,6,1),(90,90,2,3,6,1),(91,91,2,3,6,1),(92,92,2,3,6,1),(93,93,2,3,6,1),(94,94,2,3,6,1),(95,95,2,3,6,1),(96,96,2,3,6,1),(97,97,2,3,6,1),(98,98,2,3,6,1),(99,99,2,3,6,1),(100,100,3,2,7,1),(101,101,3,2,7,1),(102,102,3,2,7,1),(103,103,3,2,7,1),(104,104,3,2,7,1),(105,105,3,2,7,1),(106,106,3,2,7,1),(107,107,3,2,7,1),(108,108,3,2,7,1),(109,109,3,2,7,1),(110,110,3,2,7,1),(111,111,3,2,7,1),(112,112,3,2,7,1),(113,113,3,2,7,1),(114,114,3,2,7,1),(115,115,3,2,8,1),(116,116,3,2,8,1),(117,117,3,2,8,1),(118,118,3,2,8,1),(119,119,3,2,8,1),(120,120,3,2,8,1),(121,121,3,2,8,1),(122,122,3,2,8,1),(123,123,3,2,8,1),(124,124,3,2,8,1),(125,125,3,2,8,1),(126,126,3,2,8,1),(127,127,3,2,8,1),(128,128,3,2,8,1),(129,129,3,2,8,1),(130,130,3,3,9,1),(131,131,3,3,9,1),(132,132,3,3,9,1),(133,133,3,3,9,1),(134,134,3,3,9,1),(135,135,3,3,9,1),(136,136,3,3,9,1),(137,137,3,3,9,1),(138,138,3,3,9,1),(139,139,3,3,9,1),(140,140,3,3,9,1),(141,141,3,3,9,1),(142,142,3,3,9,1),(143,143,3,3,9,1),(144,144,3,3,9,1),(145,145,4,2,10,1),(146,146,4,2,10,1),(147,147,4,2,10,1),(148,148,4,2,10,1),(149,149,4,2,10,1),(150,150,4,2,10,1),(151,151,4,2,10,1),(152,152,4,2,10,1),(153,153,4,2,10,1),(154,154,4,2,10,1),(155,155,4,2,10,1),(156,156,4,2,10,1),(157,157,4,2,10,1),(158,158,4,2,10,1),(159,159,4,2,10,1),(160,160,4,2,11,1),(161,161,4,2,11,1),(162,162,4,2,11,1),(163,163,4,2,11,1),(164,164,4,2,11,1),(165,165,4,2,11,1),(166,166,4,2,11,1),(167,167,4,2,11,1),(168,168,4,2,11,1),(169,169,4,2,11,1),(170,170,4,2,11,1),(171,171,4,2,11,1),(172,172,4,2,11,1),(173,173,4,2,11,1),(174,174,4,2,11,1),(175,175,4,3,12,1),(176,176,4,3,12,1),(177,177,4,3,12,1),(178,178,4,3,12,1),(179,179,4,3,12,1),(180,180,4,3,12,1),(181,181,4,3,12,1),(182,182,4,3,12,1),(183,183,4,3,12,1),(184,184,4,3,12,1),(185,185,4,3,12,1),(186,186,4,3,12,1),(187,187,4,3,12,1),(188,188,4,3,12,1),(189,189,4,3,12,1),(190,190,5,2,13,1),(191,191,5,2,13,1),(192,192,5,2,13,1),(193,193,5,2,13,1),(194,194,5,2,13,1),(195,195,5,2,13,1),(196,196,5,2,13,1),(197,197,5,2,13,1),(198,198,5,2,13,1),(199,199,5,2,13,1),(200,200,5,2,13,1),(201,201,5,2,13,1),(202,202,5,2,13,1),(203,203,5,2,13,1),(204,204,5,2,13,1),(205,205,5,2,14,1),(206,206,5,2,14,1),(207,207,5,2,14,1),(208,208,5,2,14,1),(209,209,5,2,14,1),(210,210,5,2,14,1),(211,211,5,2,14,1),(212,212,5,2,14,1),(213,213,5,2,14,1),(214,214,5,2,14,1),(215,215,5,2,14,1),(216,216,5,2,14,1),(217,217,5,2,14,1),(218,218,5,2,14,1),(219,219,5,2,14,1),(220,220,5,3,15,1),(221,221,5,3,15,1),(222,222,5,3,15,1),(223,223,5,3,15,1),(224,224,5,3,15,1),(225,225,5,3,15,1),(226,226,5,3,15,1),(227,227,5,3,15,1),(228,228,5,3,15,1),(229,229,5,3,15,1),(230,230,5,3,15,1),(231,231,5,3,15,1),(232,232,5,3,15,1),(233,233,5,3,15,1),(234,234,5,3,15,1);
/*!40000 ALTER TABLE `student_detail` ENABLE KEYS */;
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