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
-- Table structure for table `assignment`
--

DROP TABLE IF EXISTS `assignment`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `assignment` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `studentrollno_id` int(11) DEFAULT NULL,
  `subject_id` int(11) DEFAULT NULL,
  `mark` int(11) DEFAULT NULL,
  `academic_id` int(11) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=1547 DEFAULT CHARSET=utf8 COLLATE=utf8_bin;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `assignment`
--

LOCK TABLES `assignment` WRITE;
/*!40000 ALTER TABLE `assignment` DISABLE KEYS */;
INSERT INTO `assignment` VALUES (1,1,27,17,1),(2,1,28,17,1),(3,1,29,17,1),(4,1,30,17,1),(5,1,31,17,1),(6,1,32,17,1),(7,1,33,17,1),(8,2,27,17,1),(9,2,28,17,1),(10,2,29,17,1),(11,2,30,17,1),(12,2,31,17,1),(13,2,32,17,1),(14,2,33,17,1),(15,3,20,17,1),(16,3,21,17,1),(17,3,22,17,1),(18,3,23,17,1),(19,3,24,17,1),(20,3,25,17,1),(21,3,26,17,1),(22,4,20,17,1),(23,4,21,17,1),(24,4,22,17,1),(25,4,23,17,1),(26,4,24,17,1),(27,4,25,17,1),(28,4,26,17,1),(29,5,13,17,1),(30,5,14,17,1),(31,5,15,17,1),(32,5,16,17,1),(33,5,17,17,1),(34,5,18,17,1),(35,5,19,17,1),(36,6,13,17,1),(37,6,14,17,1),(38,6,15,17,1),(39,6,16,17,1),(40,6,17,17,1),(41,6,18,17,1),(42,6,19,17,1),(43,7,6,17,1),(44,7,7,17,1),(45,7,8,17,1),(46,7,9,17,1),(47,7,10,17,1),(48,7,11,17,1),(49,7,12,17,1),(50,8,6,17,1),(51,8,7,17,1),(52,8,8,17,1),(53,8,9,17,1),(54,8,10,17,1),(55,8,11,17,1),(56,8,12,17,1),(57,9,1,16,1),(58,9,2,17,1),(59,9,3,17,1),(60,9,4,17,1),(61,9,5,17,1),(62,10,1,12,1),(63,10,2,17,1),(64,10,3,17,1),(65,10,4,17,1),(66,10,5,17,1),(67,11,1,17,1),(68,11,2,17,1),(69,11,3,17,1),(70,11,4,17,1),(71,11,5,17,1),(72,12,1,17,1),(73,12,2,17,1),(74,12,3,17,1),(75,12,4,17,1),(76,12,5,17,1),(77,13,1,17,1),(78,13,2,17,1),(79,13,3,17,1),(80,13,4,17,1),(81,13,5,17,1),(82,14,1,17,1),(83,14,2,17,1),(84,14,3,17,1),(85,14,4,17,1),(86,14,5,17,1),(87,15,1,17,1),(88,15,2,17,1),(89,15,3,17,1),(90,15,4,17,1),(91,15,5,17,1),(92,16,1,17,1),(93,16,2,17,1),(94,16,3,17,1),(95,16,4,17,1),(96,16,5,17,1),(97,17,1,17,1),(98,17,2,17,1),(99,17,3,17,1),(100,17,4,17,1),(101,17,5,17,1),(102,18,1,17,1),(103,18,2,17,1),(104,18,3,17,1),(105,18,4,17,1),(106,18,5,17,1),(107,19,1,17,1),(108,19,2,17,1),(109,19,3,17,1),(110,19,4,17,1),(111,19,5,17,1),(112,20,1,17,1),(113,20,2,17,1),(114,20,3,17,1),(115,20,4,17,1),(116,20,5,17,1),(117,21,1,17,1),(118,21,2,17,1),(119,21,3,17,1),(120,21,4,17,1),(121,21,5,17,1),(122,22,1,17,1),(123,22,2,17,1),(124,22,3,17,1),(125,22,4,17,1),(126,22,5,17,1),(127,23,1,17,1),(128,23,2,17,1),(129,23,3,17,1),(130,23,4,17,1),(131,23,5,17,1),(132,24,1,17,1),(133,24,2,17,1),(134,24,3,17,1),(135,24,4,17,1),(136,24,5,17,1),(137,25,1,17,1),(138,25,2,17,1),(139,25,3,17,1),(140,25,4,17,1),(141,25,5,17,1),(142,26,1,17,1),(143,26,2,17,1),(144,26,3,17,1),(145,26,4,17,1),(146,26,5,17,1),(147,27,1,17,1),(148,27,2,17,1),(149,27,3,17,1),(150,27,4,17,1),(151,27,5,17,1),(152,28,1,17,1),(153,28,2,17,1),(154,28,3,17,1),(155,28,4,17,1),(156,28,5,17,1),(157,29,1,17,1),(158,29,2,17,1),(159,29,3,17,1),(160,29,4,17,1),(161,29,5,17,1),(162,30,1,17,1),(163,30,2,17,1),(164,30,3,17,1),(165,30,4,17,1),(166,30,5,17,1),(167,31,1,17,1),(168,31,2,17,1),(169,31,3,17,1),(170,31,4,17,1),(171,31,5,17,1),(172,32,1,17,1),(173,32,2,17,1),(174,32,3,17,1),(175,32,4,17,1),(176,32,5,17,1),(177,33,1,17,1),(178,33,2,17,1),(179,33,3,17,1),(180,33,4,17,1),(181,33,5,17,1),(182,34,1,17,1),(183,34,2,17,1),(184,34,3,17,1),(185,34,4,17,1),(186,34,5,17,1),(187,35,1,17,1),(188,35,2,17,1),(189,35,3,17,1),(190,35,4,17,1),(191,35,5,17,1),(192,36,1,17,1),(193,36,2,17,1),(194,36,3,17,1),(195,36,4,17,1),(196,36,5,17,1),(197,37,1,17,1),(198,37,2,17,1),(199,37,3,17,1),(200,37,4,17,1),(201,37,5,17,1),(202,38,1,17,1),(203,38,2,17,1),(204,38,3,17,1),(205,38,4,17,1),(206,38,5,17,1),(207,39,1,17,1),(208,39,2,17,1),(209,39,3,17,1),(210,39,4,17,1),(211,39,5,17,1),(212,40,1,17,1),(213,40,2,17,1),(214,40,3,17,1),(215,40,4,17,1),(216,40,5,17,1),(217,41,1,17,1),(218,41,2,17,1),(219,41,3,17,1),(220,41,4,17,1),(221,41,5,17,1),(222,42,1,17,1),(223,42,2,17,1),(224,42,3,17,1),(225,42,4,17,1),(226,42,5,17,1),(227,43,1,17,1),(228,43,2,17,1),(229,43,3,17,1),(230,43,4,17,1),(231,43,5,17,1),(232,44,1,17,1),(233,44,2,17,1),(234,44,3,17,1),(235,44,4,17,1),(236,44,5,17,1),(237,45,1,17,1),(238,45,2,17,1),(239,45,3,17,1),(240,45,4,17,1),(241,45,5,17,1),(242,46,1,17,1),(243,46,2,17,1),(244,46,3,17,1),(245,46,4,17,1),(246,46,5,17,1),(247,47,1,17,1),(248,47,2,17,1),(249,47,3,17,1),(250,47,4,17,1),(251,47,5,17,1),(252,48,1,17,1),(253,48,2,17,1),(254,48,3,17,1),(255,48,4,17,1),(256,48,5,17,1),(257,49,1,17,1),(258,49,2,17,1),(259,49,3,17,1),(260,49,4,17,1),(261,49,5,17,1),(262,50,1,17,1),(263,50,2,17,1),(264,50,3,17,1),(265,50,4,17,1),(266,50,5,17,1),(267,51,1,17,1),(268,51,2,17,1),(269,51,3,17,1),(270,51,4,17,1),(271,51,5,17,1),(272,52,1,17,1),(273,52,2,17,1),(274,52,3,17,1),(275,52,4,17,1),(276,52,5,17,1),(277,53,1,17,1),(278,53,2,17,1),(279,53,3,17,1),(280,53,4,17,1),(281,53,5,17,1),(282,54,1,17,1),(283,54,2,17,1),(284,54,3,17,1),(285,54,4,17,1),(286,54,5,17,1),(287,55,6,10,1),(288,55,7,17,1),(289,55,8,17,1),(290,55,9,17,1),(291,55,10,17,1),(292,55,11,17,1),(293,55,12,17,1),(294,56,6,13,1),(295,56,7,17,1),(296,56,8,17,1),(297,56,9,17,1),(298,56,10,17,1),(299,56,11,17,1),(300,56,12,17,1),(301,57,6,11,1),(302,57,7,17,1),(303,57,8,17,1),(304,57,9,17,1),(305,57,10,17,1),(306,57,11,17,1),(307,57,12,17,1),(308,58,6,11,1),(309,58,7,17,1),(310,58,8,17,1),(311,58,9,17,1),(312,58,10,17,1),(313,58,11,17,1),(314,58,12,17,1),(315,59,6,17,1),(316,59,7,17,1),(317,59,8,17,1),(318,59,9,17,1),(319,59,10,17,1),(320,59,11,17,1),(321,59,12,17,1),(322,60,6,17,1),(323,60,7,17,1),(324,60,8,17,1),(325,60,9,17,1),(326,60,10,17,1),(327,60,11,17,1),(328,60,12,17,1),(329,61,6,17,1),(330,61,7,17,1),(331,61,8,17,1),(332,61,9,17,1),(333,61,10,17,1),(334,61,11,17,1),(335,61,12,17,1),(336,62,6,17,1),(337,62,7,17,1),(338,62,8,17,1),(339,62,9,17,1),(340,62,10,17,1),(341,62,11,17,1),(342,62,12,17,1),(343,63,6,17,1),(344,63,7,17,1),(345,63,8,17,1),(346,63,9,17,1),(347,63,10,17,1),(348,63,11,17,1),(349,63,12,17,1),(350,64,6,17,1),(351,64,7,17,1),(352,64,8,17,1),(353,64,9,17,1),(354,64,10,17,1),(355,64,11,17,1),(356,64,12,17,1),(357,65,6,17,1),(358,65,7,17,1),(359,65,8,17,1),(360,65,9,17,1),(361,65,10,17,1),(362,65,11,17,1),(363,65,12,17,1),(364,66,6,17,1),(365,66,7,17,1),(366,66,8,17,1),(367,66,9,17,1),(368,66,10,17,1),(369,66,11,17,1),(370,66,12,17,1),(371,67,6,17,1),(372,67,7,17,1),(373,67,8,17,1),(374,67,9,17,1),(375,67,10,17,1),(376,67,11,17,1),(377,67,12,17,1),(378,68,6,17,1),(379,68,7,17,1),(380,68,8,17,1),(381,68,9,17,1),(382,68,10,17,1),(383,68,11,17,1),(384,68,12,17,1),(385,69,6,17,1),(386,69,7,17,1),(387,69,8,17,1),(388,69,9,17,1),(389,69,10,17,1),(390,69,11,17,1),(391,69,12,17,1),(392,70,6,17,1),(393,70,7,17,1),(394,70,8,17,1),(395,70,9,17,1),(396,70,10,17,1),(397,70,11,17,1),(398,70,12,17,1),(399,71,6,17,1),(400,71,7,17,1),(401,71,8,17,1),(402,71,9,17,1),(403,71,10,17,1),(404,71,11,17,1),(405,71,12,17,1),(406,72,6,17,1),(407,72,7,17,1),(408,72,8,17,1),(409,72,9,17,1),(410,72,10,17,1),(411,72,11,17,1),(412,72,12,17,1),(413,73,6,17,1),(414,73,7,17,1),(415,73,8,17,1),(416,73,9,17,1),(417,73,10,17,1),(418,73,11,17,1),(419,73,12,17,1),(420,74,6,17,1),(421,74,7,17,1),(422,74,8,17,1),(423,74,9,17,1),(424,74,10,17,1),(425,74,11,17,1),(426,74,12,17,1),(427,75,6,17,1),(428,75,7,17,1),(429,75,8,17,1),(430,75,9,17,1),(431,75,10,17,1),(432,75,11,17,1),(433,75,12,17,1),(434,76,6,17,1),(435,76,7,17,1),(436,76,8,17,1),(437,76,9,17,1),(438,76,10,17,1),(439,76,11,17,1),(440,76,12,17,1),(441,77,6,17,1),(442,77,7,17,1),(443,77,8,17,1),(444,77,9,17,1),(445,77,10,17,1),(446,77,11,17,1),(447,77,12,17,1),(448,78,6,17,1),(449,78,7,17,1),(450,78,8,17,1),(451,78,9,17,1),(452,78,10,17,1),(453,78,11,17,1),(454,78,12,17,1),(455,79,6,17,1),(456,79,7,17,1),(457,79,8,17,1),(458,79,9,17,1),(459,79,10,17,1),(460,79,11,17,1),(461,79,12,17,1),(462,80,6,17,1),(463,80,7,17,1),(464,80,8,17,1),(465,80,9,17,1),(466,80,10,17,1),(467,80,11,17,1),(468,80,12,17,1),(469,81,6,17,1),(470,81,7,17,1),(471,81,8,17,1),(472,81,9,17,1),(473,81,10,17,1),(474,81,11,17,1),(475,81,12,17,1),(476,82,6,17,1),(477,82,7,17,1),(478,82,8,17,1),(479,82,9,17,1),(480,82,10,17,1),(481,82,11,17,1),(482,82,12,17,1),(483,83,6,17,1),(484,83,7,17,1),(485,83,8,17,1),(486,83,9,17,1),(487,83,10,17,1),(488,83,11,17,1),(489,83,12,17,1),(490,84,6,17,1),(491,84,7,17,1),(492,84,8,17,1),(493,84,9,17,1),(494,84,10,17,1),(495,84,11,17,1),(496,84,12,17,1),(497,85,6,17,1),(498,85,7,17,1),(499,85,8,17,1),(500,85,9,17,1),(501,85,10,17,1),(502,85,11,17,1),(503,85,12,17,1),(504,86,6,17,1),(505,86,7,17,1),(506,86,8,17,1),(507,86,9,17,1),(508,86,10,17,1),(509,86,11,17,1),(510,86,12,17,1),(511,87,6,17,1),(512,87,7,17,1),(513,87,8,17,1),(514,87,9,17,1),(515,87,10,17,1),(516,87,11,17,1),(517,87,12,17,1),(518,88,6,17,1),(519,88,7,17,1),(520,88,8,17,1),(521,88,9,17,1),(522,88,10,17,1),(523,88,11,17,1),(524,88,12,17,1),(525,89,6,17,1),(526,89,7,17,1),(527,89,8,17,1),(528,89,9,17,1),(529,89,10,17,1),(530,89,11,17,1),(531,89,12,17,1),(532,90,6,17,1),(533,90,7,17,1),(534,90,8,17,1),(535,90,9,17,1),(536,90,10,17,1),(537,90,11,17,1),(538,90,12,17,1),(539,91,6,17,1),(540,91,7,17,1),(541,91,8,17,1),(542,91,9,17,1),(543,91,10,17,1),(544,91,11,17,1),(545,91,12,17,1),(546,92,6,17,1),(547,92,7,17,1),(548,92,8,17,1),(549,92,9,17,1),(550,92,10,17,1),(551,92,11,17,1),(552,92,12,17,1),(553,93,6,17,1),(554,93,7,17,1),(555,93,8,17,1),(556,93,9,17,1),(557,93,10,17,1),(558,93,11,17,1),(559,93,12,17,1),(560,94,6,17,1),(561,94,7,17,1),(562,94,8,17,1),(563,94,9,17,1),(564,94,10,17,1),(565,94,11,17,1),(566,94,12,17,1),(567,95,6,17,1),(568,95,7,17,1),(569,95,8,17,1),(570,95,9,17,1),(571,95,10,17,1),(572,95,11,17,1),(573,95,12,17,1),(574,96,6,17,1),(575,96,7,17,1),(576,96,8,17,1),(577,96,9,17,1),(578,96,10,17,1),(579,96,11,17,1),(580,96,12,17,1),(581,97,6,17,1),(582,97,7,17,1),(583,97,8,17,1),(584,97,9,17,1),(585,97,10,17,1),(586,97,11,17,1),(587,97,12,17,1),(588,98,6,17,1),(589,98,7,17,1),(590,98,8,17,1),(591,98,9,17,1),(592,98,10,17,1),(593,98,11,17,1),(594,98,12,17,1),(595,99,6,17,1),(596,99,7,17,1),(597,99,8,17,1),(598,99,9,17,1),(599,99,10,17,1),(600,99,11,17,1),(601,99,12,17,1),(602,100,13,17,1),(603,100,14,17,1),(604,100,15,17,1),(605,100,16,17,1),(606,100,17,17,1),(607,100,18,17,1),(608,100,19,17,1),(609,101,13,17,1),(610,101,14,17,1),(611,101,15,17,1),(612,101,16,17,1),(613,101,17,17,1),(614,101,18,17,1),(615,101,19,17,1),(616,102,13,17,1),(617,102,14,17,1),(618,102,15,17,1),(619,102,16,17,1),(620,102,17,17,1),(621,102,18,17,1),(622,102,19,17,1),(623,103,13,17,1),(624,103,14,17,1),(625,103,15,17,1),(626,103,16,17,1),(627,103,17,17,1),(628,103,18,17,1),(629,103,19,17,1),(630,104,13,17,1),(631,104,14,17,1),(632,104,15,17,1),(633,104,16,17,1),(634,104,17,17,1),(635,104,18,17,1),(636,104,19,17,1),(637,105,13,17,1),(638,105,14,17,1),(639,105,15,17,1),(640,105,16,17,1),(641,105,17,17,1),(642,105,18,17,1),(643,105,19,17,1),(644,106,13,17,1),(645,106,14,17,1),(646,106,15,17,1),(647,106,16,17,1),(648,106,17,17,1),(649,106,18,17,1),(650,106,19,17,1),(651,107,13,17,1),(652,107,14,17,1),(653,107,15,17,1),(654,107,16,17,1),(655,107,17,17,1),(656,107,18,17,1),(657,107,19,17,1),(658,108,13,17,1),(659,108,14,17,1),(660,108,15,17,1),(661,108,16,17,1),(662,108,17,17,1),(663,108,18,17,1),(664,108,19,17,1),(665,109,13,17,1),(666,109,14,17,1),(667,109,15,17,1),(668,109,16,17,1),(669,109,17,17,1),(670,109,18,17,1),(671,109,19,17,1),(672,110,13,17,1),(673,110,14,17,1),(674,110,15,17,1),(675,110,16,17,1),(676,110,17,17,1),(677,110,18,17,1),(678,110,19,17,1),(679,111,13,17,1),(680,111,14,17,1),(681,111,15,17,1),(682,111,16,17,1),(683,111,17,17,1),(684,111,18,17,1),(685,111,19,17,1),(686,112,13,17,1),(687,112,14,17,1),(688,112,15,17,1),(689,112,16,17,1),(690,112,17,17,1),(691,112,18,17,1),(692,112,19,17,1),(693,113,13,17,1),(694,113,14,17,1),(695,113,15,17,1),(696,113,16,17,1),(697,113,17,17,1),(698,113,18,17,1),(699,113,19,17,1),(700,114,13,17,1),(701,114,14,17,1),(702,114,15,17,1),(703,114,16,17,1),(704,114,17,17,1),(705,114,18,17,1),(706,114,19,17,1),(707,115,13,17,1),(708,115,14,17,1),(709,115,15,17,1),(710,115,16,17,1),(711,115,17,17,1),(712,115,18,17,1),(713,115,19,17,1),(714,116,13,17,1),(715,116,14,17,1),(716,116,15,17,1),(717,116,16,17,1),(718,116,17,17,1),(719,116,18,17,1),(720,116,19,17,1),(721,117,13,17,1),(722,117,14,17,1),(723,117,15,17,1),(724,117,16,17,1),(725,117,17,17,1),(726,117,18,17,1),(727,117,19,17,1),(728,118,13,17,1),(729,118,14,17,1),(730,118,15,17,1),(731,118,16,17,1),(732,118,17,17,1),(733,118,18,17,1),(734,118,19,17,1),(735,119,13,17,1),(736,119,14,17,1),(737,119,15,17,1),(738,119,16,17,1),(739,119,17,17,1),(740,119,18,17,1),(741,119,19,17,1),(742,120,13,17,1),(743,120,14,17,1),(744,120,15,17,1),(745,120,16,17,1),(746,120,17,17,1),(747,120,18,17,1),(748,120,19,17,1),(749,121,13,17,1),(750,121,14,17,1),(751,121,15,17,1),(752,121,16,17,1),(753,121,17,17,1),(754,121,18,17,1),(755,121,19,17,1),(756,122,13,17,1),(757,122,14,17,1),(758,122,15,17,1),(759,122,16,17,1),(760,122,17,17,1),(761,122,18,17,1),(762,122,19,17,1),(763,123,13,17,1),(764,123,14,17,1),(765,123,15,17,1),(766,123,16,17,1),(767,123,17,17,1),(768,123,18,17,1),(769,123,19,17,1),(770,124,13,17,1),(771,124,14,17,1),(772,124,15,17,1),(773,124,16,17,1),(774,124,17,17,1),(775,124,18,17,1),(776,124,19,17,1),(777,125,13,17,1),(778,125,14,17,1),(779,125,15,17,1),(780,125,16,17,1),(781,125,17,17,1),(782,125,18,17,1),(783,125,19,17,1),(784,126,13,17,1),(785,126,14,17,1),(786,126,15,17,1),(787,126,16,17,1),(788,126,17,17,1),(789,126,18,17,1),(790,126,19,17,1),(791,127,13,17,1),(792,127,14,17,1),(793,127,15,17,1),(794,127,16,17,1),(795,127,17,17,1),(796,127,18,17,1),(797,127,19,17,1),(798,128,13,17,1),(799,128,14,17,1),(800,128,15,17,1),(801,128,16,17,1),(802,128,17,17,1),(803,128,18,17,1),(804,128,19,17,1),(805,129,13,17,1),(806,129,14,17,1),(807,129,15,17,1),(808,129,16,17,1),(809,129,17,17,1),(810,129,18,17,1),(811,129,19,17,1),(812,130,13,17,1),(813,130,14,17,1),(814,130,15,17,1),(815,130,16,17,1),(816,130,17,17,1),(817,130,18,17,1),(818,130,19,17,1),(819,131,13,17,1),(820,131,14,17,1),(821,131,15,17,1),(822,131,16,17,1),(823,131,17,17,1),(824,131,18,17,1),(825,131,19,17,1),(826,132,13,17,1),(827,132,14,17,1),(828,132,15,17,1),(829,132,16,17,1),(830,132,17,17,1),(831,132,18,17,1),(832,132,19,17,1),(833,133,13,17,1),(834,133,14,17,1),(835,133,15,17,1),(836,133,16,17,1),(837,133,17,17,1),(838,133,18,17,1),(839,133,19,17,1),(840,134,13,17,1),(841,134,14,17,1),(842,134,15,17,1),(843,134,16,17,1),(844,134,17,17,1),(845,134,18,17,1),(846,134,19,17,1),(847,135,13,17,1),(848,135,14,17,1),(849,135,15,17,1),(850,135,16,17,1),(851,135,17,17,1),(852,135,18,17,1),(853,135,19,17,1),(854,136,13,17,1),(855,136,14,17,1),(856,136,15,17,1),(857,136,16,17,1),(858,136,17,17,1),(859,136,18,17,1),(860,136,19,17,1),(861,137,13,17,1),(862,137,14,17,1),(863,137,15,17,1),(864,137,16,17,1),(865,137,17,17,1),(866,137,18,17,1),(867,137,19,17,1),(868,138,13,17,1),(869,138,14,17,1),(870,138,15,17,1),(871,138,16,17,1),(872,138,17,17,1),(873,138,18,17,1),(874,138,19,17,1),(875,139,13,17,1),(876,139,14,17,1),(877,139,15,17,1),(878,139,16,17,1),(879,139,17,17,1),(880,139,18,17,1),(881,139,19,17,1),(882,140,13,17,1),(883,140,14,17,1),(884,140,15,17,1),(885,140,16,17,1),(886,140,17,17,1),(887,140,18,17,1),(888,140,19,17,1),(889,141,13,17,1),(890,141,14,17,1),(891,141,15,17,1),(892,141,16,17,1),(893,141,17,17,1),(894,141,18,17,1),(895,141,19,17,1),(896,142,13,17,1),(897,142,14,17,1),(898,142,15,17,1),(899,142,16,17,1),(900,142,17,17,1),(901,142,18,17,1),(902,142,19,17,1),(903,143,13,17,1),(904,143,14,17,1),(905,143,15,17,1),(906,143,16,17,1),(907,143,17,17,1),(908,143,18,17,1),(909,143,19,17,1),(910,144,13,17,1),(911,144,14,17,1),(912,144,15,17,1),(913,144,16,17,1),(914,144,17,17,1),(915,144,18,17,1),(916,144,19,17,1),(917,145,20,17,1),(918,145,21,17,1),(919,145,22,17,1),(920,145,23,17,1),(921,145,24,17,1),(922,145,25,17,1),(923,145,26,17,1),(924,146,20,17,1),(925,146,21,17,1),(926,146,22,17,1),(927,146,23,17,1),(928,146,24,17,1),(929,146,25,17,1),(930,146,26,17,1),(931,147,20,17,1),(932,147,21,17,1),(933,147,22,17,1),(934,147,23,17,1),(935,147,24,17,1),(936,147,25,17,1),(937,147,26,17,1),(938,148,20,17,1),(939,148,21,17,1),(940,148,22,17,1),(941,148,23,17,1),(942,148,24,17,1),(943,148,25,17,1),(944,148,26,17,1),(945,149,20,17,1),(946,149,21,17,1),(947,149,22,17,1),(948,149,23,17,1),(949,149,24,17,1),(950,149,25,17,1),(951,149,26,17,1),(952,150,20,17,1),(953,150,21,17,1),(954,150,22,17,1),(955,150,23,17,1),(956,150,24,17,1),(957,150,25,17,1),(958,150,26,17,1),(959,151,20,17,1),(960,151,21,17,1),(961,151,22,17,1),(962,151,23,17,1),(963,151,24,17,1),(964,151,25,17,1),(965,151,26,17,1),(966,152,20,17,1),(967,152,21,17,1),(968,152,22,17,1),(969,152,23,17,1),(970,152,24,17,1),(971,152,25,17,1),(972,152,26,17,1),(973,153,20,17,1),(974,153,21,17,1),(975,153,22,17,1),(976,153,23,17,1),(977,153,24,17,1),(978,153,25,17,1),(979,153,26,17,1),(980,154,20,17,1),(981,154,21,17,1),(982,154,22,17,1),(983,154,23,17,1),(984,154,24,17,1),(985,154,25,17,1),(986,154,26,17,1),(987,155,20,17,1),(988,155,21,17,1),(989,155,22,17,1),(990,155,23,17,1),(991,155,24,17,1),(992,155,25,17,1),(993,155,26,17,1),(994,156,20,17,1),(995,156,21,17,1),(996,156,22,17,1),(997,156,23,17,1),(998,156,24,17,1),(999,156,25,17,1),(1000,156,26,17,1),(1001,157,20,17,1),(1002,157,21,17,1),(1003,157,22,17,1),(1004,157,23,17,1),(1005,157,24,17,1),(1006,157,25,17,1),(1007,157,26,17,1),(1008,158,20,17,1),(1009,158,21,17,1),(1010,158,22,17,1),(1011,158,23,17,1),(1012,158,24,17,1),(1013,158,25,17,1),(1014,158,26,17,1),(1015,159,20,17,1),(1016,159,21,17,1),(1017,159,22,17,1),(1018,159,23,17,1),(1019,159,24,17,1),(1020,159,25,17,1),(1021,159,26,17,1),(1022,160,20,17,1),(1023,160,21,17,1),(1024,160,22,17,1),(1025,160,23,17,1),(1026,160,24,17,1),(1027,160,25,17,1),(1028,160,26,17,1),(1029,161,20,17,1),(1030,161,21,17,1),(1031,161,22,17,1),(1032,161,23,17,1),(1033,161,24,17,1),(1034,161,25,17,1),(1035,161,26,17,1),(1036,162,20,17,1),(1037,162,21,17,1),(1038,162,22,17,1),(1039,162,23,17,1),(1040,162,24,17,1),(1041,162,25,17,1),(1042,162,26,17,1),(1043,163,20,17,1),(1044,163,21,17,1),(1045,163,22,17,1),(1046,163,23,17,1),(1047,163,24,17,1),(1048,163,25,17,1),(1049,163,26,17,1),(1050,164,20,17,1),(1051,164,21,17,1),(1052,164,22,17,1),(1053,164,23,17,1),(1054,164,24,17,1),(1055,164,25,17,1),(1056,164,26,17,1),(1057,165,20,17,1),(1058,165,21,17,1),(1059,165,22,17,1),(1060,165,23,17,1),(1061,165,24,17,1),(1062,165,25,17,1),(1063,165,26,17,1),(1064,166,20,17,1),(1065,166,21,17,1),(1066,166,22,17,1),(1067,166,23,17,1),(1068,166,24,17,1),(1069,166,25,17,1),(1070,166,26,17,1),(1071,167,20,17,1),(1072,167,21,17,1),(1073,167,22,17,1),(1074,167,23,17,1),(1075,167,24,17,1),(1076,167,25,17,1),(1077,167,26,17,1),(1078,168,20,17,1),(1079,168,21,17,1),(1080,168,22,17,1),(1081,168,23,17,1),(1082,168,24,17,1),(1083,168,25,17,1),(1084,168,26,17,1),(1085,169,20,17,1),(1086,169,21,17,1),(1087,169,22,17,1),(1088,169,23,17,1),(1089,169,24,17,1),(1090,169,25,17,1),(1091,169,26,17,1),(1092,170,20,17,1),(1093,170,21,17,1),(1094,170,22,17,1),(1095,170,23,17,1),(1096,170,24,17,1),(1097,170,25,17,1),(1098,170,26,17,1),(1099,171,20,17,1),(1100,171,21,17,1),(1101,171,22,17,1),(1102,171,23,17,1),(1103,171,24,17,1),(1104,171,25,17,1),(1105,171,26,17,1),(1106,172,20,17,1),(1107,172,21,17,1),(1108,172,22,17,1),(1109,172,23,17,1),(1110,172,24,17,1),(1111,172,25,17,1),(1112,172,26,17,1),(1113,173,20,17,1),(1114,173,21,17,1),(1115,173,22,17,1),(1116,173,23,17,1),(1117,173,24,17,1),(1118,173,25,17,1),(1119,173,26,17,1),(1120,174,20,17,1),(1121,174,21,17,1),(1122,174,22,17,1),(1123,174,23,17,1),(1124,174,24,17,1),(1125,174,25,17,1),(1126,174,26,17,1),(1127,175,20,17,1),(1128,175,21,17,1),(1129,175,22,17,1),(1130,175,23,17,1),(1131,175,24,17,1),(1132,175,25,17,1),(1133,175,26,17,1),(1134,176,20,17,1),(1135,176,21,17,1),(1136,176,22,17,1),(1137,176,23,17,1),(1138,176,24,17,1),(1139,176,25,17,1),(1140,176,26,17,1),(1141,177,20,17,1),(1142,177,21,17,1),(1143,177,22,17,1),(1144,177,23,17,1),(1145,177,24,17,1),(1146,177,25,17,1),(1147,177,26,17,1),(1148,178,20,17,1),(1149,178,21,17,1),(1150,178,22,17,1),(1151,178,23,17,1),(1152,178,24,17,1),(1153,178,25,17,1),(1154,178,26,17,1),(1155,179,20,17,1),(1156,179,21,17,1),(1157,179,22,17,1),(1158,179,23,17,1),(1159,179,24,17,1),(1160,179,25,17,1),(1161,179,26,17,1),(1162,180,20,17,1),(1163,180,21,17,1),(1164,180,22,17,1),(1165,180,23,17,1),(1166,180,24,17,1),(1167,180,25,17,1),(1168,180,26,17,1),(1169,181,20,17,1),(1170,181,21,17,1),(1171,181,22,17,1),(1172,181,23,17,1),(1173,181,24,17,1),(1174,181,25,17,1),(1175,181,26,17,1),(1176,182,20,17,1),(1177,182,21,17,1),(1178,182,22,17,1),(1179,182,23,17,1),(1180,182,24,17,1),(1181,182,25,17,1),(1182,182,26,17,1),(1183,183,20,17,1),(1184,183,21,17,1),(1185,183,22,17,1),(1186,183,23,17,1),(1187,183,24,17,1),(1188,183,25,17,1),(1189,183,26,17,1),(1190,184,20,17,1),(1191,184,21,17,1),(1192,184,22,17,1),(1193,184,23,17,1),(1194,184,24,17,1),(1195,184,25,17,1),(1196,184,26,17,1),(1197,185,20,17,1),(1198,185,21,17,1),(1199,185,22,17,1),(1200,185,23,17,1),(1201,185,24,17,1),(1202,185,25,17,1),(1203,185,26,17,1),(1204,186,20,17,1),(1205,186,21,17,1),(1206,186,22,17,1),(1207,186,23,17,1),(1208,186,24,17,1),(1209,186,25,17,1),(1210,186,26,17,1),(1211,187,20,17,1),(1212,187,21,17,1),(1213,187,22,17,1),(1214,187,23,17,1),(1215,187,24,17,1),(1216,187,25,17,1),(1217,187,26,17,1),(1218,188,20,17,1),(1219,188,21,17,1),(1220,188,22,17,1),(1221,188,23,17,1),(1222,188,24,17,1),(1223,188,25,17,1),(1224,188,26,17,1),(1225,189,20,17,1),(1226,189,21,17,1),(1227,189,22,17,1),(1228,189,23,17,1),(1229,189,24,17,1),(1230,189,25,17,1),(1231,189,26,17,1),(1232,190,27,17,1),(1233,190,28,17,1),(1234,190,29,17,1),(1235,190,30,17,1),(1236,190,31,17,1),(1237,190,32,17,1),(1238,190,33,17,1),(1239,191,27,17,1),(1240,191,28,17,1),(1241,191,29,17,1),(1242,191,30,17,1),(1243,191,31,17,1),(1244,191,32,17,1),(1245,191,33,17,1),(1246,192,27,17,1),(1247,192,28,17,1),(1248,192,29,17,1),(1249,192,30,17,1),(1250,192,31,17,1),(1251,192,32,17,1),(1252,192,33,17,1),(1253,193,27,17,1),(1254,193,28,17,1),(1255,193,29,17,1),(1256,193,30,17,1),(1257,193,31,17,1),(1258,193,32,17,1),(1259,193,33,17,1),(1260,194,27,17,1),(1261,194,28,17,1),(1262,194,29,17,1),(1263,194,30,17,1),(1264,194,31,17,1),(1265,194,32,17,1),(1266,194,33,17,1),(1267,195,27,17,1),(1268,195,28,17,1),(1269,195,29,17,1),(1270,195,30,17,1),(1271,195,31,17,1),(1272,195,32,17,1),(1273,195,33,17,1),(1274,196,27,17,1),(1275,196,28,17,1),(1276,196,29,17,1),(1277,196,30,17,1),(1278,196,31,17,1),(1279,196,32,17,1),(1280,196,33,17,1),(1281,197,27,17,1),(1282,197,28,17,1),(1283,197,29,17,1),(1284,197,30,17,1),(1285,197,31,17,1),(1286,197,32,17,1),(1287,197,33,17,1),(1288,198,27,17,1),(1289,198,28,17,1),(1290,198,29,17,1),(1291,198,30,17,1),(1292,198,31,17,1),(1293,198,32,17,1),(1294,198,33,17,1),(1295,199,27,17,1),(1296,199,28,17,1),(1297,199,29,17,1),(1298,199,30,17,1),(1299,199,31,17,1),(1300,199,32,17,1),(1301,199,33,17,1),(1302,200,27,17,1),(1303,200,28,17,1),(1304,200,29,17,1),(1305,200,30,17,1),(1306,200,31,17,1),(1307,200,32,17,1),(1308,200,33,17,1),(1309,201,27,17,1),(1310,201,28,17,1),(1311,201,29,17,1),(1312,201,30,17,1),(1313,201,31,17,1),(1314,201,32,17,1),(1315,201,33,17,1),(1316,202,27,17,1),(1317,202,28,17,1),(1318,202,29,17,1),(1319,202,30,17,1),(1320,202,31,17,1),(1321,202,32,17,1),(1322,202,33,17,1),(1323,203,27,17,1),(1324,203,28,17,1),(1325,203,29,17,1),(1326,203,30,17,1),(1327,203,31,17,1),(1328,203,32,17,1),(1329,203,33,17,1),(1330,204,27,17,1),(1331,204,28,17,1),(1332,204,29,17,1),(1333,204,30,17,1),(1334,204,31,17,1),(1335,204,32,17,1),(1336,204,33,17,1),(1337,205,27,17,1),(1338,205,28,17,1),(1339,205,29,17,1),(1340,205,30,17,1),(1341,205,31,17,1),(1342,205,32,17,1),(1343,205,33,17,1),(1344,206,27,17,1),(1345,206,28,17,1),(1346,206,29,17,1),(1347,206,30,17,1),(1348,206,31,17,1),(1349,206,32,17,1),(1350,206,33,17,1),(1351,207,27,17,1),(1352,207,28,17,1),(1353,207,29,17,1),(1354,207,30,17,1),(1355,207,31,17,1),(1356,207,32,17,1),(1357,207,33,17,1),(1358,208,27,17,1),(1359,208,28,17,1),(1360,208,29,17,1),(1361,208,30,17,1),(1362,208,31,17,1),(1363,208,32,17,1),(1364,208,33,17,1),(1365,209,27,17,1),(1366,209,28,17,1),(1367,209,29,17,1),(1368,209,30,17,1),(1369,209,31,17,1),(1370,209,32,17,1),(1371,209,33,17,1),(1372,210,27,17,1),(1373,210,28,17,1),(1374,210,29,17,1),(1375,210,30,17,1),(1376,210,31,17,1),(1377,210,32,17,1),(1378,210,33,17,1),(1379,211,27,17,1),(1380,211,28,17,1),(1381,211,29,17,1),(1382,211,30,17,1),(1383,211,31,17,1),(1384,211,32,17,1),(1385,211,33,17,1),(1386,212,27,17,1),(1387,212,28,17,1),(1388,212,29,17,1),(1389,212,30,17,1),(1390,212,31,17,1),(1391,212,32,17,1),(1392,212,33,17,1),(1393,213,27,17,1),(1394,213,28,17,1),(1395,213,29,17,1),(1396,213,30,17,1),(1397,213,31,17,1),(1398,213,32,17,1),(1399,213,33,17,1),(1400,214,27,17,1),(1401,214,28,17,1),(1402,214,29,17,1),(1403,214,30,17,1),(1404,214,31,17,1),(1405,214,32,17,1),(1406,214,33,17,1),(1407,215,27,17,1),(1408,215,28,17,1),(1409,215,29,17,1),(1410,215,30,17,1),(1411,215,31,17,1),(1412,215,32,17,1),(1413,215,33,17,1),(1414,216,27,17,1),(1415,216,28,17,1),(1416,216,29,17,1),(1417,216,30,17,1),(1418,216,31,17,1),(1419,216,32,17,1),(1420,216,33,17,1),(1421,217,27,17,1),(1422,217,28,17,1),(1423,217,29,17,1),(1424,217,30,17,1),(1425,217,31,17,1),(1426,217,32,17,1),(1427,217,33,17,1),(1428,218,27,17,1),(1429,218,28,17,1),(1430,218,29,17,1),(1431,218,30,17,1),(1432,218,31,17,1),(1433,218,32,17,1),(1434,218,33,17,1),(1435,219,27,17,1),(1436,219,28,17,1),(1437,219,29,17,1),(1438,219,30,17,1),(1439,219,31,17,1),(1440,219,32,17,1),(1441,219,33,17,1),(1442,220,27,17,1),(1443,220,28,17,1),(1444,220,29,17,1),(1445,220,30,17,1),(1446,220,31,17,1),(1447,220,32,17,1),(1448,220,33,17,1),(1449,221,27,17,1),(1450,221,28,17,1),(1451,221,29,17,1),(1452,221,30,17,1),(1453,221,31,17,1),(1454,221,32,17,1),(1455,221,33,17,1),(1456,222,27,17,1),(1457,222,28,17,1),(1458,222,29,17,1),(1459,222,30,17,1),(1460,222,31,17,1),(1461,222,32,17,1),(1462,222,33,17,1),(1463,223,27,17,1),(1464,223,28,17,1),(1465,223,29,17,1),(1466,223,30,17,1),(1467,223,31,17,1),(1468,223,32,17,1),(1469,223,33,17,1),(1470,224,27,17,1),(1471,224,28,17,1),(1472,224,29,17,1),(1473,224,30,17,1),(1474,224,31,17,1),(1475,224,32,17,1),(1476,224,33,17,1),(1477,225,27,17,1),(1478,225,28,17,1),(1479,225,29,17,1),(1480,225,30,17,1),(1481,225,31,17,1),(1482,225,32,17,1),(1483,225,33,17,1),(1484,226,27,17,1),(1485,226,28,17,1),(1486,226,29,17,1),(1487,226,30,17,1),(1488,226,31,17,1),(1489,226,32,17,1),(1490,226,33,17,1),(1491,227,27,17,1),(1492,227,28,17,1),(1493,227,29,17,1),(1494,227,30,17,1),(1495,227,31,17,1),(1496,227,32,17,1),(1497,227,33,17,1),(1498,228,27,17,1),(1499,228,28,17,1),(1500,228,29,17,1),(1501,228,30,17,1),(1502,228,31,17,1),(1503,228,32,17,1),(1504,228,33,17,1),(1505,229,27,17,1),(1506,229,28,17,1),(1507,229,29,17,1),(1508,229,30,17,1),(1509,229,31,17,1),(1510,229,32,17,1),(1511,229,33,17,1),(1512,230,27,17,1),(1513,230,28,17,1),(1514,230,29,17,1),(1515,230,30,17,1),(1516,230,31,17,1),(1517,230,32,17,1),(1518,230,33,17,1),(1519,231,27,17,1),(1520,231,28,17,1),(1521,231,29,17,1),(1522,231,30,17,1),(1523,231,31,17,1),(1524,231,32,17,1),(1525,231,33,17,1),(1526,232,27,17,1),(1527,232,28,17,1),(1528,232,29,17,1),(1529,232,30,17,1),(1530,232,31,17,1),(1531,232,32,17,1),(1532,232,33,17,1),(1533,233,27,17,1),(1534,233,28,17,1),(1535,233,29,17,1),(1536,233,30,17,1),(1537,233,31,17,1),(1538,233,32,17,1),(1539,233,33,17,1),(1540,234,27,17,1),(1541,234,28,17,1),(1542,234,29,17,1),(1543,234,30,17,1),(1544,234,31,17,1),(1545,234,32,17,1),(1546,234,33,17,1);
/*!40000 ALTER TABLE `assignment` ENABLE KEYS */;
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