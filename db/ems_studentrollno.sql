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
-- Table structure for table `studentrollno`
--

DROP TABLE IF EXISTS `studentrollno`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `studentrollno` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `student_id` int(11) DEFAULT NULL,
  `academic_id` int(11) DEFAULT NULL,
  `rollno` varchar(45) CHARACTER SET utf8 COLLATE utf8_bin DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=280 DEFAULT CHARSET=utf8 COLLATE=utf8_bin;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `studentrollno`
--

LOCK TABLES `studentrollno` WRITE;
/*!40000 ALTER TABLE `studentrollno` DISABLE KEYS */;
INSERT INTO `studentrollno` VALUES (1,1,1,'5CS-1'),(2,2,1,'5CT-1'),(3,3,1,'4CS-1'),(4,4,1,'4CT-1'),(5,5,1,'3CS-1'),(6,6,1,'3CT-1'),(7,7,1,'2CS-1'),(8,8,1,'2CT-1'),(9,9,1,'1CST-1'),(10,10,1,'1CST-2'),(11,11,1,'1CST-3'),(12,12,1,'1CST-4'),(13,13,1,'1CST-5'),(14,14,1,'1CST-6'),(15,15,1,'1CST-7'),(16,16,1,'1CST-8'),(17,17,1,'1CST-9'),(18,18,1,'1CST-10'),(19,19,1,'1CST-11'),(20,20,1,'1CST-12'),(21,21,1,'1CST-13'),(22,22,1,'1CST-14'),(23,23,1,'1CST-15'),(24,24,1,'1CST-16'),(25,25,1,'1CST-41'),(26,26,1,'1CST-42'),(27,27,1,'1CST-42'),(28,28,1,'1CST-43'),(29,29,1,'1CST-60'),(30,30,1,'1CST-43'),(31,31,1,'1CST-45'),(32,32,1,'1CST-62'),(33,33,1,'1CST-43'),(34,34,1,'1CST-44'),(35,35,1,'1CST-46'),(36,36,1,'1CST-47'),(37,37,1,'1CST-48'),(38,38,1,'1CST-56'),(39,39,1,'1CST-67'),(40,40,1,'1CST-68'),(41,41,1,'1CST-69'),(42,42,1,'1CST-70'),(43,43,1,'1CST-72'),(44,44,1,'1CST-73'),(45,45,1,'1CST-78'),(46,46,1,'1CST-80'),(47,47,1,'1CST-81'),(48,48,1,'1CST-82'),(49,49,1,'1CST-84'),(50,50,1,'1CST-85'),(51,51,1,'1CST-86'),(52,52,1,'1CST-87'),(53,53,1,'1CST-90'),(54,54,1,'1CST-92'),(55,55,1,'2CS-1'),(56,56,1,'2CS-2'),(57,57,1,'2CS-3'),(58,58,1,'2CS-4'),(59,59,1,'2CS-5'),(60,60,1,'2CS-6'),(61,61,1,'2CS-15'),(62,62,1,'2CS-18'),(63,63,1,'2CS-22'),(64,64,1,'2CS-26'),(65,65,1,'2CS-28'),(66,66,1,'2CS-30'),(67,67,1,'2CS-33'),(68,68,1,'2CS-37'),(69,69,1,'2CS-38'),(70,70,1,'2CS-40'),(71,71,1,'2CS-55'),(72,72,1,'2CS-56'),(73,73,1,'2CS-60'),(74,74,1,'2CS-62'),(75,75,1,'2CS-65'),(76,76,1,'2CS-67'),(77,77,1,'2CS-69'),(78,78,1,'2CS-70'),(79,79,1,'2CS-72'),(80,80,1,'2CS-74'),(81,81,1,'2CS-75'),(82,82,1,'2CS-77'),(83,83,1,'2CS-78'),(84,84,1,'2CS-80'),(85,85,1,'2CS-85'),(86,86,1,'2CT-1'),(87,87,1,'2CT-3'),(88,88,1,'2CT-5'),(89,89,1,'2CT-9'),(90,90,1,'2CT-12'),(91,91,1,'2CT-15'),(92,92,1,'2CT-19'),(93,93,1,'2CT-21'),(94,94,1,'2CT-24'),(95,95,1,'2CT-26'),(96,96,1,'2CT-27'),(97,97,1,'2CT-30'),(98,98,1,'2CT-35'),(99,99,1,'2CT-42'),(100,100,1,'3CS-1'),(101,101,1,'3CS-3'),(102,102,1,'3CS-4'),(103,103,1,'3CS-7'),(104,104,1,'3CS-10'),(105,105,1,'3CS-16'),(106,106,1,'3CS-18'),(107,107,1,'3CS-23'),(108,108,1,'3CS-27'),(109,109,1,'3CS-31'),(110,110,1,'3CS-34'),(111,111,1,'3CS-37'),(112,112,1,'3CS-40'),(113,113,1,'3CS-42'),(114,114,1,'3CS-50'),(115,115,1,'3CS-52'),(116,116,1,'3CS-54'),(117,117,1,'3CS-57'),(118,118,1,'3CS-62'),(119,119,1,'3CS-64'),(120,120,1,'3CS-67'),(121,121,1,'3CS-68'),(122,122,1,'3CS-70'),(123,123,1,'3CS-72'),(124,124,1,'3CS-74'),(125,125,1,'3CS-76'),(126,126,1,'3CS-78'),(127,127,1,'3CS-80'),(128,128,1,'3CS-82'),(129,129,1,'3CS-85'),(130,130,1,'3CT-1'),(131,131,1,'3CT-3'),(132,132,1,'3CT-5'),(133,133,1,'3CT-8'),(134,134,1,'3CT-13'),(135,135,1,'3CT-15'),(136,136,1,'3CT-19'),(137,137,1,'3CT-27'),(138,138,1,'3CT-29'),(139,139,1,'3CT-32'),(140,140,1,'3CT-35'),(141,141,1,'3CT-38'),(142,142,1,'3CT-42'),(143,143,1,'3CT-45'),(144,144,1,'3CT-50'),(145,145,1,'4CS-1'),(146,146,1,'4CS-3'),(147,147,1,'4CS-5'),(148,148,1,'4CS-7'),(149,149,1,'4CS-9'),(150,150,1,'4CS-12'),(151,151,1,'4CS-15'),(152,152,1,'4CS-19'),(153,153,1,'4CS-24'),(154,154,1,'4CS-27'),(155,155,1,'4CS-33'),(156,156,1,'4CS-37'),(157,157,1,'4CS-42'),(158,158,1,'4CS-48'),(159,159,1,'4CS-55'),(160,160,1,'4CS-56'),(161,161,1,'4CS-58'),(162,162,1,'4CS-60'),(163,163,1,'4CS-62'),(164,164,1,'4CS-65'),(165,165,1,'4CS-67'),(166,166,1,'4CS-69'),(167,167,1,'4CS-72'),(168,168,1,'4CS-75'),(169,169,1,'4CS-78'),(170,170,1,'4CS-80'),(171,171,1,'4CS-81'),(172,172,1,'4CS-82'),(173,173,1,'4CS-84'),(174,174,1,'4CS-85'),(175,175,1,'4CT-1'),(176,176,1,'4CT-3'),(177,177,1,'4CT-6'),(178,178,1,'4CT-7'),(179,179,1,'4CT-9'),(180,180,1,'4CT-12'),(181,181,1,'4CT-15'),(182,182,1,'4CT-16'),(183,183,1,'4CT-20'),(184,184,1,'4CT-25'),(185,185,1,'4CT-27'),(186,186,1,'4CT-30'),(187,187,1,'4CT-32'),(188,188,1,'4CT-34'),(189,189,1,'4CT-40'),(190,190,1,'5CS-1'),(191,191,1,'5CS-3'),(192,192,1,'5CS-7'),(193,193,1,'5CS-10'),(194,194,1,'5CS-13'),(195,195,1,'5CS-17'),(196,196,1,'5CS-22'),(197,197,1,'5CS-26'),(198,198,1,'5CS-29'),(199,199,1,'5CS-32'),(200,200,1,'5CS-36'),(201,201,1,'5CS-38'),(202,202,1,'5CS-42'),(203,203,1,'5CS-45'),(204,204,1,'5CS-48'),(205,205,1,'5CS-55'),(206,206,1,'5CS-57'),(207,207,1,'5CS-58'),(208,208,1,'5CS-60'),(209,209,1,'5CS-62'),(210,210,1,'5CS-64'),(211,211,1,'5CS-67'),(212,212,1,'5CS-69'),(213,213,1,'5CS-71'),(214,214,1,'5CS-73'),(215,215,1,'5CS-75'),(216,216,1,'5CS-78'),(217,217,1,'5CS-79'),(218,218,1,'5CS-80'),(219,219,1,'5CS-82'),(220,220,1,'5CS-85'),(221,221,1,'5CT-1'),(222,222,1,'5CT-3'),(223,223,1,'5CT-5'),(224,224,1,'5CT-10'),(225,225,1,'5CT-13'),(226,226,1,'5CT-19'),(227,227,1,'5CT-21'),(228,228,1,'5CT-25'),(229,229,1,'5CT-27'),(230,230,1,'5CT30'),(231,231,1,'5CT-34'),(232,232,1,'5CT-38'),(233,233,1,'5CT-43'),(234,234,1,'5CT-45');
/*!40000 ALTER TABLE `studentrollno` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2019-09-13 10:30:48
