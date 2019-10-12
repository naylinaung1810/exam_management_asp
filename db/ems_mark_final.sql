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
-- Table structure for table `mark_final`
--

DROP TABLE IF EXISTS `mark_final`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `mark_final` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `studentrollno_id` int(11) DEFAULT NULL,
  `mark` int(11) DEFAULT NULL,
  `subject_id` int(11) DEFAULT NULL,
  `academic_id` int(11) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=1547 DEFAULT CHARSET=utf8 COLLATE=utf8_bin;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `mark_final`
--

LOCK TABLES `mark_final` WRITE;
/*!40000 ALTER TABLE `mark_final` DISABLE KEYS */;
INSERT INTO `mark_final` VALUES (1,1,40,27,1),(2,1,84,28,1),(3,1,60,29,1),(4,1,55,30,1),(5,1,90,31,1),(6,1,67,32,1),(7,1,34,33,1),(8,2,79,27,1),(9,2,50,28,1),(10,2,40,29,1),(11,2,84,30,1),(12,2,60,31,1),(13,2,55,32,1),(14,2,90,33,1),(15,3,67,20,1),(16,3,34,21,1),(17,3,79,22,1),(18,3,50,23,1),(19,3,40,24,1),(20,3,84,25,1),(21,3,60,26,1),(22,4,55,20,1),(23,4,90,21,1),(24,4,67,22,1),(25,4,34,23,1),(26,4,79,24,1),(27,4,50,25,1),(28,4,40,26,1),(29,5,84,13,1),(30,5,60,14,1),(31,5,55,15,1),(32,5,90,16,1),(33,5,67,17,1),(34,5,34,18,1),(35,5,79,19,1),(36,6,50,13,1),(37,6,40,14,1),(38,6,84,15,1),(39,6,60,16,1),(40,6,55,17,1),(41,6,90,18,1),(42,6,67,19,1),(43,7,34,6,1),(44,7,79,7,1),(45,7,50,8,1),(46,7,40,9,1),(47,7,84,10,1),(48,7,60,11,1),(49,7,55,12,1),(50,8,90,6,1),(51,8,67,7,1),(52,8,34,8,1),(53,8,79,9,1),(54,8,50,10,1),(55,8,40,11,1),(56,8,84,12,1),(57,9,30,1,1),(58,9,55,2,1),(59,9,90,3,1),(60,9,67,4,1),(61,9,34,5,1),(62,10,79,1,1),(63,10,50,2,1),(64,10,40,3,1),(65,10,84,4,1),(66,10,60,5,1),(67,11,55,1,1),(68,11,90,2,1),(69,11,67,3,1),(70,11,34,4,1),(71,11,79,5,1),(72,12,50,1,1),(73,12,40,2,1),(74,12,84,3,1),(75,12,60,4,1),(76,12,55,5,1),(77,13,90,1,1),(78,13,67,2,1),(79,13,34,3,1),(80,13,79,4,1),(81,13,50,5,1),(82,14,40,1,1),(83,14,84,2,1),(84,14,60,3,1),(85,14,55,4,1),(86,14,90,5,1),(87,15,67,1,1),(88,15,34,2,1),(89,15,79,3,1),(90,15,50,4,1),(91,15,40,5,1),(92,16,84,1,1),(93,16,60,2,1),(94,16,55,3,1),(95,16,90,4,1),(96,16,67,5,1),(97,17,34,1,1),(98,17,79,2,1),(99,17,50,3,1),(100,17,40,4,1),(101,17,84,5,1),(102,18,60,1,1),(103,18,55,2,1),(104,18,90,3,1),(105,18,67,4,1),(106,18,34,5,1),(107,19,79,1,1),(108,19,50,2,1),(109,19,40,3,1),(110,19,84,4,1),(111,19,60,5,1),(112,20,55,1,1),(113,20,90,2,1),(114,20,67,3,1),(115,20,34,4,1),(116,20,79,5,1),(117,21,50,1,1),(118,21,40,2,1),(119,21,84,3,1),(120,21,60,4,1),(121,21,55,5,1),(122,22,90,1,1),(123,22,67,2,1),(124,22,34,3,1),(125,22,79,4,1),(126,22,50,5,1),(127,23,40,1,1),(128,23,84,2,1),(129,23,60,3,1),(130,23,55,4,1),(131,23,90,5,1),(132,24,67,1,1),(133,24,34,2,1),(134,24,79,3,1),(135,24,50,4,1),(136,24,40,5,1),(137,25,84,1,1),(138,25,60,2,1),(139,25,55,3,1),(140,25,90,4,1),(141,25,67,5,1),(142,26,34,1,1),(143,26,79,2,1),(144,26,50,3,1),(145,26,40,4,1),(146,26,84,5,1),(147,27,60,1,1),(148,27,55,2,1),(149,27,90,3,1),(150,27,67,4,1),(151,27,34,5,1),(152,28,79,1,1),(153,28,50,2,1),(154,28,40,3,1),(155,28,84,4,1),(156,28,60,5,1),(157,29,55,1,1),(158,29,90,2,1),(159,29,67,3,1),(160,29,34,4,1),(161,29,79,5,1),(162,30,50,1,1),(163,30,40,2,1),(164,30,84,3,1),(165,30,60,4,1),(166,30,55,5,1),(167,31,90,1,1),(168,31,67,2,1),(169,31,34,3,1),(170,31,79,4,1),(171,31,50,5,1),(172,32,40,1,1),(173,32,84,2,1),(174,32,60,3,1),(175,32,55,4,1),(176,32,90,5,1),(177,33,67,1,1),(178,33,34,2,1),(179,33,79,3,1),(180,33,50,4,1),(181,33,40,5,1),(182,34,84,1,1),(183,34,60,2,1),(184,34,55,3,1),(185,34,90,4,1),(186,34,67,5,1),(187,35,34,1,1),(188,35,79,2,1),(189,35,50,3,1),(190,35,40,4,1),(191,35,84,5,1),(192,36,60,1,1),(193,36,55,2,1),(194,36,90,3,1),(195,36,67,4,1),(196,36,34,5,1),(197,37,79,1,1),(198,37,50,2,1),(199,37,40,3,1),(200,37,84,4,1),(201,37,60,5,1),(202,38,55,1,1),(203,38,90,2,1),(204,38,67,3,1),(205,38,34,4,1),(206,38,79,5,1),(207,39,50,1,1),(208,39,40,2,1),(209,39,84,3,1),(210,39,60,4,1),(211,39,55,5,1),(212,40,90,1,1),(213,40,67,2,1),(214,40,34,3,1),(215,40,79,4,1),(216,40,50,5,1),(217,41,40,1,1),(218,41,84,2,1),(219,41,60,3,1),(220,41,55,4,1),(221,41,90,5,1),(222,42,67,1,1),(223,42,34,2,1),(224,42,79,3,1),(225,42,50,4,1),(226,42,40,5,1),(227,43,84,1,1),(228,43,60,2,1),(229,43,55,3,1),(230,43,90,4,1),(231,43,67,5,1),(232,44,34,1,1),(233,44,79,2,1),(234,44,50,3,1),(235,44,40,4,1),(236,44,84,5,1),(237,45,60,1,1),(238,45,55,2,1),(239,45,90,3,1),(240,45,67,4,1),(241,45,34,5,1),(242,46,79,1,1),(243,46,50,2,1),(244,46,40,3,1),(245,46,84,4,1),(246,46,60,5,1),(247,47,55,1,1),(248,47,90,2,1),(249,47,67,3,1),(250,47,34,4,1),(251,47,79,5,1),(252,48,50,1,1),(253,48,40,2,1),(254,48,84,3,1),(255,48,60,4,1),(256,48,55,5,1),(257,49,90,1,1),(258,49,67,2,1),(259,49,34,3,1),(260,49,79,4,1),(261,49,50,5,1),(262,50,40,1,1),(263,50,84,2,1),(264,50,60,3,1),(265,50,55,4,1),(266,50,90,5,1),(267,51,67,1,1),(268,51,34,2,1),(269,51,79,3,1),(270,51,50,4,1),(271,51,40,5,1),(272,52,84,1,1),(273,52,60,2,1),(274,52,55,3,1),(275,52,90,4,1),(276,52,67,5,1),(277,53,34,1,1),(278,53,79,2,1),(279,53,50,3,1),(280,53,40,4,1),(281,53,84,5,1),(282,54,60,1,1),(283,54,55,2,1),(284,54,90,3,1),(285,54,67,4,1),(286,54,34,5,1),(287,55,79,6,1),(288,55,50,7,1),(289,55,40,8,1),(290,55,84,9,1),(291,55,60,10,1),(292,55,55,11,1),(293,55,90,12,1),(294,56,67,6,1),(295,56,34,7,1),(296,56,79,8,1),(297,56,50,9,1),(298,56,40,10,1),(299,56,84,11,1),(300,56,60,12,1),(301,57,55,6,1),(302,57,90,7,1),(303,57,67,8,1),(304,57,34,9,1),(305,57,79,10,1),(306,57,50,11,1),(307,57,40,12,1),(308,58,84,6,1),(309,58,60,7,1),(310,58,55,8,1),(311,58,90,9,1),(312,58,67,10,1),(313,58,34,11,1),(314,58,79,12,1),(315,59,50,6,1),(316,59,40,7,1),(317,59,84,8,1),(318,59,60,9,1),(319,59,55,10,1),(320,59,90,11,1),(321,59,67,12,1),(322,60,34,6,1),(323,60,79,7,1),(324,60,50,8,1),(325,60,40,9,1),(326,60,84,10,1),(327,60,60,11,1),(328,60,55,12,1),(329,61,90,6,1),(330,61,67,7,1),(331,61,34,8,1),(332,61,79,9,1),(333,61,50,10,1),(334,61,40,11,1),(335,61,84,12,1),(336,62,60,6,1),(337,62,55,7,1),(338,62,90,8,1),(339,62,67,9,1),(340,62,34,10,1),(341,62,79,11,1),(342,62,50,12,1),(343,63,40,6,1),(344,63,84,7,1),(345,63,60,8,1),(346,63,55,9,1),(347,63,90,10,1),(348,63,67,11,1),(349,63,34,12,1),(350,64,79,6,1),(351,64,50,7,1),(352,64,40,8,1),(353,64,84,9,1),(354,64,60,10,1),(355,64,55,11,1),(356,64,90,12,1),(357,65,67,6,1),(358,65,34,7,1),(359,65,79,8,1),(360,65,50,9,1),(361,65,40,10,1),(362,65,84,11,1),(363,65,60,12,1),(364,66,55,6,1),(365,66,90,7,1),(366,66,67,8,1),(367,66,34,9,1),(368,66,79,10,1),(369,66,50,11,1),(370,66,40,12,1),(371,67,84,6,1),(372,67,60,7,1),(373,67,55,8,1),(374,67,90,9,1),(375,67,67,10,1),(376,67,34,11,1),(377,67,79,12,1),(378,68,50,6,1),(379,68,40,7,1),(380,68,84,8,1),(381,68,60,9,1),(382,68,55,10,1),(383,68,90,11,1),(384,68,67,12,1),(385,69,34,6,1),(386,69,79,7,1),(387,69,50,8,1),(388,69,40,9,1),(389,69,84,10,1),(390,69,60,11,1),(391,69,55,12,1),(392,70,90,6,1),(393,70,67,7,1),(394,70,34,8,1),(395,70,79,9,1),(396,70,50,10,1),(397,70,40,11,1),(398,70,84,12,1),(399,71,60,6,1),(400,71,55,7,1),(401,71,90,8,1),(402,71,67,9,1),(403,71,34,10,1),(404,71,79,11,1),(405,71,50,12,1),(406,72,40,6,1),(407,72,84,7,1),(408,72,60,8,1),(409,72,55,9,1),(410,72,90,10,1),(411,72,67,11,1),(412,72,34,12,1),(413,73,79,6,1),(414,73,50,7,1),(415,73,40,8,1),(416,73,84,9,1),(417,73,60,10,1),(418,73,55,11,1),(419,73,90,12,1),(420,74,67,6,1),(421,74,34,7,1),(422,74,79,8,1),(423,74,50,9,1),(424,74,40,10,1),(425,74,84,11,1),(426,74,60,12,1),(427,75,55,6,1),(428,75,90,7,1),(429,75,67,8,1),(430,75,34,9,1),(431,75,79,10,1),(432,75,50,11,1),(433,75,40,12,1),(434,76,84,6,1),(435,76,60,7,1),(436,76,55,8,1),(437,76,90,9,1),(438,76,67,10,1),(439,76,34,11,1),(440,76,79,12,1),(441,77,50,6,1),(442,77,40,7,1),(443,77,84,8,1),(444,77,60,9,1),(445,77,55,10,1),(446,77,90,11,1),(447,77,67,12,1),(448,78,34,6,1),(449,78,79,7,1),(450,78,50,8,1),(451,78,40,9,1),(452,78,84,10,1),(453,78,60,11,1),(454,78,55,12,1),(455,79,90,6,1),(456,79,67,7,1),(457,79,34,8,1),(458,79,79,9,1),(459,79,50,10,1),(460,79,40,11,1),(461,79,84,12,1),(462,80,60,6,1),(463,80,55,7,1),(464,80,90,8,1),(465,80,67,9,1),(466,80,34,10,1),(467,80,79,11,1),(468,80,50,12,1),(469,81,40,6,1),(470,81,84,7,1),(471,81,60,8,1),(472,81,55,9,1),(473,81,90,10,1),(474,81,67,11,1),(475,81,34,12,1),(476,82,79,6,1),(477,82,50,7,1),(478,82,40,8,1),(479,82,84,9,1),(480,82,60,10,1),(481,82,55,11,1),(482,82,90,12,1),(483,83,67,6,1),(484,83,34,7,1),(485,83,79,8,1),(486,83,50,9,1),(487,83,40,10,1),(488,83,84,11,1),(489,83,60,12,1),(490,84,55,6,1),(491,84,90,7,1),(492,84,67,8,1),(493,84,34,9,1),(494,84,79,10,1),(495,84,50,11,1),(496,84,40,12,1),(497,85,84,6,1),(498,85,60,7,1),(499,85,55,8,1),(500,85,90,9,1),(501,85,67,10,1),(502,85,34,11,1),(503,85,79,12,1),(504,86,50,6,1),(505,86,40,7,1),(506,86,84,8,1),(507,86,60,9,1),(508,86,55,10,1),(509,86,90,11,1),(510,86,67,12,1),(511,87,34,6,1),(512,87,79,7,1),(513,87,50,8,1),(514,87,40,9,1),(515,87,84,10,1),(516,87,60,11,1),(517,87,55,12,1),(518,88,90,6,1),(519,88,67,7,1),(520,88,34,8,1),(521,88,79,9,1),(522,88,50,10,1),(523,88,40,11,1),(524,88,84,12,1),(525,89,60,6,1),(526,89,55,7,1),(527,89,90,8,1),(528,89,67,9,1),(529,89,34,10,1),(530,89,79,11,1),(531,89,50,12,1),(532,90,40,6,1),(533,90,84,7,1),(534,90,60,8,1),(535,90,55,9,1),(536,90,90,10,1),(537,90,67,11,1),(538,90,34,12,1),(539,91,79,6,1),(540,91,50,7,1),(541,91,40,8,1),(542,91,84,9,1),(543,91,60,10,1),(544,91,55,11,1),(545,91,90,12,1),(546,92,67,6,1),(547,92,34,7,1),(548,92,79,8,1),(549,92,50,9,1),(550,92,40,10,1),(551,92,84,11,1),(552,92,60,12,1),(553,93,55,6,1),(554,93,90,7,1),(555,93,67,8,1),(556,93,34,9,1),(557,93,79,10,1),(558,93,50,11,1),(559,93,40,12,1),(560,94,84,6,1),(561,94,60,7,1),(562,94,55,8,1),(563,94,90,9,1),(564,94,67,10,1),(565,94,34,11,1),(566,94,79,12,1),(567,95,50,6,1),(568,95,40,7,1),(569,95,84,8,1),(570,95,60,9,1),(571,95,55,10,1),(572,95,90,11,1),(573,95,67,12,1),(574,96,34,6,1),(575,96,79,7,1),(576,96,50,8,1),(577,96,40,9,1),(578,96,84,10,1),(579,96,60,11,1),(580,96,55,12,1),(581,97,90,6,1),(582,97,67,7,1),(583,97,34,8,1),(584,97,79,9,1),(585,97,50,10,1),(586,97,40,11,1),(587,97,84,12,1),(588,98,60,6,1),(589,98,55,7,1),(590,98,90,8,1),(591,98,67,9,1),(592,98,34,10,1),(593,98,79,11,1),(594,98,50,12,1),(595,99,40,6,1),(596,99,84,7,1),(597,99,60,8,1),(598,99,55,9,1),(599,99,90,10,1),(600,99,67,11,1),(601,99,34,12,1),(602,100,79,13,1),(603,100,50,14,1),(604,100,40,15,1),(605,100,84,16,1),(606,100,60,17,1),(607,100,55,18,1),(608,100,90,19,1),(609,101,67,13,1),(610,101,34,14,1),(611,101,79,15,1),(612,101,50,16,1),(613,101,40,17,1),(614,101,84,18,1),(615,101,60,19,1),(616,102,55,13,1),(617,102,90,14,1),(618,102,67,15,1),(619,102,34,16,1),(620,102,79,17,1),(621,102,50,18,1),(622,102,40,19,1),(623,103,84,13,1),(624,103,60,14,1),(625,103,55,15,1),(626,103,90,16,1),(627,103,67,17,1),(628,103,34,18,1),(629,103,79,19,1),(630,104,50,13,1),(631,104,40,14,1),(632,104,84,15,1),(633,104,60,16,1),(634,104,55,17,1),(635,104,90,18,1),(636,104,67,19,1),(637,105,34,13,1),(638,105,79,14,1),(639,105,50,15,1),(640,105,40,16,1),(641,105,84,17,1),(642,105,60,18,1),(643,105,55,19,1),(644,106,90,13,1),(645,106,67,14,1),(646,106,34,15,1),(647,106,79,16,1),(648,106,50,17,1),(649,106,40,18,1),(650,106,84,19,1),(651,107,60,13,1),(652,107,55,14,1),(653,107,90,15,1),(654,107,67,16,1),(655,107,34,17,1),(656,107,79,18,1),(657,107,50,19,1),(658,108,40,13,1),(659,108,84,14,1),(660,108,60,15,1),(661,108,55,16,1),(662,108,90,17,1),(663,108,67,18,1),(664,108,34,19,1),(665,109,79,13,1),(666,109,50,14,1),(667,109,40,15,1),(668,109,84,16,1),(669,109,60,17,1),(670,109,55,18,1),(671,109,90,19,1),(672,110,67,13,1),(673,110,34,14,1),(674,110,79,15,1),(675,110,50,16,1),(676,110,40,17,1),(677,110,84,18,1),(678,110,60,19,1),(679,111,55,13,1),(680,111,90,14,1),(681,111,67,15,1),(682,111,34,16,1),(683,111,79,17,1),(684,111,50,18,1),(685,111,40,19,1),(686,112,84,13,1),(687,112,60,14,1),(688,112,55,15,1),(689,112,90,16,1),(690,112,67,17,1),(691,112,34,18,1),(692,112,79,19,1),(693,113,50,13,1),(694,113,40,14,1),(695,113,84,15,1),(696,113,60,16,1),(697,113,55,17,1),(698,113,90,18,1),(699,113,67,19,1),(700,114,34,13,1),(701,114,79,14,1),(702,114,50,15,1),(703,114,40,16,1),(704,114,84,17,1),(705,114,60,18,1),(706,114,55,19,1),(707,115,90,13,1),(708,115,67,14,1),(709,115,34,15,1),(710,115,79,16,1),(711,115,50,17,1),(712,115,40,18,1),(713,115,84,19,1),(714,116,60,13,1),(715,116,55,14,1),(716,116,90,15,1),(717,116,67,16,1),(718,116,34,17,1),(719,116,79,18,1),(720,116,50,19,1),(721,117,40,13,1),(722,117,84,14,1),(723,117,60,15,1),(724,117,55,16,1),(725,117,90,17,1),(726,117,67,18,1),(727,117,34,19,1),(728,118,79,13,1),(729,118,50,14,1),(730,118,40,15,1),(731,118,84,16,1),(732,118,60,17,1),(733,118,55,18,1),(734,118,90,19,1),(735,119,67,13,1),(736,119,34,14,1),(737,119,79,15,1),(738,119,50,16,1),(739,119,40,17,1),(740,119,84,18,1),(741,119,60,19,1),(742,120,55,13,1),(743,120,90,14,1),(744,120,67,15,1),(745,120,34,16,1),(746,120,79,17,1),(747,120,50,18,1),(748,120,40,19,1),(749,121,84,13,1),(750,121,60,14,1),(751,121,55,15,1),(752,121,90,16,1),(753,121,67,17,1),(754,121,34,18,1),(755,121,79,19,1),(756,122,50,13,1),(757,122,40,14,1),(758,122,84,15,1),(759,122,60,16,1),(760,122,55,17,1),(761,122,90,18,1),(762,122,67,19,1),(763,123,34,13,1),(764,123,79,14,1),(765,123,50,15,1),(766,123,40,16,1),(767,123,84,17,1),(768,123,60,18,1),(769,123,55,19,1),(770,124,90,13,1),(771,124,67,14,1),(772,124,34,15,1),(773,124,79,16,1),(774,124,50,17,1),(775,124,40,18,1),(776,124,84,19,1),(777,125,60,13,1),(778,125,55,14,1),(779,125,90,15,1),(780,125,67,16,1),(781,125,34,17,1),(782,125,79,18,1),(783,125,50,19,1),(784,126,40,13,1),(785,126,84,14,1),(786,126,60,15,1),(787,126,55,16,1),(788,126,90,17,1),(789,126,67,18,1),(790,126,34,19,1),(791,127,79,13,1),(792,127,50,14,1),(793,127,40,15,1),(794,127,84,16,1),(795,127,60,17,1),(796,127,55,18,1),(797,127,90,19,1),(798,128,67,13,1),(799,128,34,14,1),(800,128,79,15,1),(801,128,50,16,1),(802,128,40,17,1),(803,128,84,18,1),(804,128,60,19,1),(805,129,55,13,1),(806,129,90,14,1),(807,129,67,15,1),(808,129,34,16,1),(809,129,79,17,1),(810,129,50,18,1),(811,129,40,19,1),(812,130,84,13,1),(813,130,60,14,1),(814,130,55,15,1),(815,130,90,16,1),(816,130,67,17,1),(817,130,34,18,1),(818,130,79,19,1),(819,131,50,13,1),(820,131,40,14,1),(821,131,84,15,1),(822,131,60,16,1),(823,131,55,17,1),(824,131,90,18,1),(825,131,67,19,1),(826,132,34,13,1),(827,132,79,14,1),(828,132,50,15,1),(829,132,40,16,1),(830,132,84,17,1),(831,132,60,18,1),(832,132,55,19,1),(833,133,90,13,1),(834,133,67,14,1),(835,133,34,15,1),(836,133,79,16,1),(837,133,50,17,1),(838,133,40,18,1),(839,133,84,19,1),(840,134,60,13,1),(841,134,55,14,1),(842,134,90,15,1),(843,134,67,16,1),(844,134,34,17,1),(845,134,79,18,1),(846,134,50,19,1),(847,135,40,13,1),(848,135,84,14,1),(849,135,60,15,1),(850,135,55,16,1),(851,135,90,17,1),(852,135,67,18,1),(853,135,34,19,1),(854,136,79,13,1),(855,136,50,14,1),(856,136,40,15,1),(857,136,84,16,1),(858,136,60,17,1),(859,136,55,18,1),(860,136,90,19,1),(861,137,67,13,1),(862,137,34,14,1),(863,137,79,15,1),(864,137,50,16,1),(865,137,40,17,1),(866,137,84,18,1),(867,137,60,19,1),(868,138,55,13,1),(869,138,90,14,1),(870,138,67,15,1),(871,138,34,16,1),(872,138,79,17,1),(873,138,50,18,1),(874,138,40,19,1),(875,139,84,13,1),(876,139,60,14,1),(877,139,55,15,1),(878,139,90,16,1),(879,139,67,17,1),(880,139,34,18,1),(881,139,79,19,1),(882,140,50,13,1),(883,140,40,14,1),(884,140,84,15,1),(885,140,60,16,1),(886,140,55,17,1),(887,140,90,18,1),(888,140,67,19,1),(889,141,34,13,1),(890,141,79,14,1),(891,141,50,15,1),(892,141,40,16,1),(893,141,84,17,1),(894,141,60,18,1),(895,141,55,19,1),(896,142,90,13,1),(897,142,67,14,1),(898,142,34,15,1),(899,142,79,16,1),(900,142,50,17,1),(901,142,40,18,1),(902,142,84,19,1),(903,143,60,13,1),(904,143,55,14,1),(905,143,90,15,1),(906,143,67,16,1),(907,143,34,17,1),(908,143,79,18,1),(909,143,50,19,1),(910,144,40,13,1),(911,144,84,14,1),(912,144,60,15,1),(913,144,55,16,1),(914,144,90,17,1),(915,144,67,18,1),(916,144,34,19,1),(917,145,79,20,1),(918,145,50,21,1),(919,145,40,22,1),(920,145,84,23,1),(921,145,60,24,1),(922,145,55,25,1),(923,145,90,26,1),(924,146,67,20,1),(925,146,34,21,1),(926,146,79,22,1),(927,146,50,23,1),(928,146,40,24,1),(929,146,84,25,1),(930,146,60,26,1),(931,147,55,20,1),(932,147,90,21,1),(933,147,67,22,1),(934,147,34,23,1),(935,147,79,24,1),(936,147,50,25,1),(937,147,40,26,1),(938,148,84,20,1),(939,148,60,21,1),(940,148,55,22,1),(941,148,90,23,1),(942,148,67,24,1),(943,148,34,25,1),(944,148,79,26,1),(945,149,50,20,1),(946,149,40,21,1),(947,149,84,22,1),(948,149,60,23,1),(949,149,55,24,1),(950,149,90,25,1),(951,149,67,26,1),(952,150,34,20,1),(953,150,79,21,1),(954,150,50,22,1),(955,150,40,23,1),(956,150,84,24,1),(957,150,60,25,1),(958,150,55,26,1),(959,151,90,20,1),(960,151,67,21,1),(961,151,34,22,1),(962,151,79,23,1),(963,151,50,24,1),(964,151,40,25,1),(965,151,84,26,1),(966,152,60,20,1),(967,152,55,21,1),(968,152,90,22,1),(969,152,67,23,1),(970,152,34,24,1),(971,152,79,25,1),(972,152,50,26,1),(973,153,40,20,1),(974,153,84,21,1),(975,153,60,22,1),(976,153,55,23,1),(977,153,90,24,1),(978,153,67,25,1),(979,153,34,26,1),(980,154,79,20,1),(981,154,50,21,1),(982,154,40,22,1),(983,154,84,23,1),(984,154,60,24,1),(985,154,55,25,1),(986,154,90,26,1),(987,155,67,20,1),(988,155,34,21,1),(989,155,79,22,1),(990,155,50,23,1),(991,155,40,24,1),(992,155,84,25,1),(993,155,60,26,1),(994,156,55,20,1),(995,156,90,21,1),(996,156,67,22,1),(997,156,34,23,1),(998,156,79,24,1),(999,156,50,25,1),(1000,156,40,26,1),(1001,157,84,20,1),(1002,157,60,21,1),(1003,157,55,22,1),(1004,157,90,23,1),(1005,157,67,24,1),(1006,157,34,25,1),(1007,157,79,26,1),(1008,158,50,20,1),(1009,158,40,21,1),(1010,158,84,22,1),(1011,158,60,23,1),(1012,158,55,24,1),(1013,158,90,25,1),(1014,158,67,26,1),(1015,159,34,20,1),(1016,159,79,21,1),(1017,159,50,22,1),(1018,159,40,23,1),(1019,159,84,24,1),(1020,159,60,25,1),(1021,159,55,26,1),(1022,160,90,20,1),(1023,160,67,21,1),(1024,160,34,22,1),(1025,160,79,23,1),(1026,160,50,24,1),(1027,160,40,25,1),(1028,160,84,26,1),(1029,161,60,20,1),(1030,161,55,21,1),(1031,161,90,22,1),(1032,161,67,23,1),(1033,161,34,24,1),(1034,161,79,25,1),(1035,161,50,26,1),(1036,162,40,20,1),(1037,162,84,21,1),(1038,162,60,22,1),(1039,162,55,23,1),(1040,162,90,24,1),(1041,162,67,25,1),(1042,162,34,26,1),(1043,163,79,20,1),(1044,163,50,21,1),(1045,163,40,22,1),(1046,163,84,23,1),(1047,163,60,24,1),(1048,163,55,25,1),(1049,163,90,26,1),(1050,164,67,20,1),(1051,164,34,21,1),(1052,164,79,22,1),(1053,164,50,23,1),(1054,164,40,24,1),(1055,164,84,25,1),(1056,164,60,26,1),(1057,165,55,20,1),(1058,165,90,21,1),(1059,165,67,22,1),(1060,165,34,23,1),(1061,165,79,24,1),(1062,165,50,25,1),(1063,165,40,26,1),(1064,166,84,20,1),(1065,166,60,21,1),(1066,166,55,22,1),(1067,166,90,23,1),(1068,166,67,24,1),(1069,166,34,25,1),(1070,166,79,26,1),(1071,167,50,20,1),(1072,167,40,21,1),(1073,167,84,22,1),(1074,167,60,23,1),(1075,167,55,24,1),(1076,167,90,25,1),(1077,167,67,26,1),(1078,168,34,20,1),(1079,168,79,21,1),(1080,168,50,22,1),(1081,168,40,23,1),(1082,168,84,24,1),(1083,168,60,25,1),(1084,168,55,26,1),(1085,169,90,20,1),(1086,169,67,21,1),(1087,169,34,22,1),(1088,169,79,23,1),(1089,169,50,24,1),(1090,169,40,25,1),(1091,169,84,26,1),(1092,170,60,20,1),(1093,170,55,21,1),(1094,170,90,22,1),(1095,170,67,23,1),(1096,170,34,24,1),(1097,170,79,25,1),(1098,170,50,26,1),(1099,171,40,20,1),(1100,171,84,21,1),(1101,171,60,22,1),(1102,171,55,23,1),(1103,171,90,24,1),(1104,171,67,25,1),(1105,171,34,26,1),(1106,172,79,20,1),(1107,172,50,21,1),(1108,172,40,22,1),(1109,172,84,23,1),(1110,172,60,24,1),(1111,172,55,25,1),(1112,172,90,26,1),(1113,173,67,20,1),(1114,173,34,21,1),(1115,173,79,22,1),(1116,173,50,23,1),(1117,173,40,24,1),(1118,173,84,25,1),(1119,173,60,26,1),(1120,174,55,20,1),(1121,174,90,21,1),(1122,174,67,22,1),(1123,174,34,23,1),(1124,174,79,24,1),(1125,174,50,25,1),(1126,174,40,26,1),(1127,175,84,20,1),(1128,175,60,21,1),(1129,175,55,22,1),(1130,175,90,23,1),(1131,175,67,24,1),(1132,175,34,25,1),(1133,175,79,26,1),(1134,176,50,20,1),(1135,176,40,21,1),(1136,176,84,22,1),(1137,176,60,23,1),(1138,176,55,24,1),(1139,176,90,25,1),(1140,176,67,26,1),(1141,177,34,20,1),(1142,177,79,21,1),(1143,177,50,22,1),(1144,177,40,23,1),(1145,177,84,24,1),(1146,177,60,25,1),(1147,177,55,26,1),(1148,178,90,20,1),(1149,178,67,21,1),(1150,178,34,22,1),(1151,178,79,23,1),(1152,178,50,24,1),(1153,178,40,25,1),(1154,178,84,26,1),(1155,179,60,20,1),(1156,179,55,21,1),(1157,179,90,22,1),(1158,179,67,23,1),(1159,179,34,24,1),(1160,179,79,25,1),(1161,179,50,26,1),(1162,180,40,20,1),(1163,180,84,21,1),(1164,180,60,22,1),(1165,180,55,23,1),(1166,180,90,24,1),(1167,180,67,25,1),(1168,180,34,26,1),(1169,181,79,20,1),(1170,181,50,21,1),(1171,181,40,22,1),(1172,181,84,23,1),(1173,181,60,24,1),(1174,181,55,25,1),(1175,181,90,26,1),(1176,182,67,20,1),(1177,182,34,21,1),(1178,182,79,22,1),(1179,182,50,23,1),(1180,182,40,24,1),(1181,182,84,25,1),(1182,182,60,26,1),(1183,183,55,20,1),(1184,183,90,21,1),(1185,183,67,22,1),(1186,183,34,23,1),(1187,183,79,24,1),(1188,183,50,25,1),(1189,183,40,26,1),(1190,184,84,20,1),(1191,184,60,21,1),(1192,184,55,22,1),(1193,184,90,23,1),(1194,184,67,24,1),(1195,184,34,25,1),(1196,184,79,26,1),(1197,185,50,20,1),(1198,185,40,21,1),(1199,185,84,22,1),(1200,185,60,23,1),(1201,185,55,24,1),(1202,185,90,25,1),(1203,185,67,26,1),(1204,186,34,20,1),(1205,186,79,21,1),(1206,186,50,22,1),(1207,186,40,23,1),(1208,186,84,24,1),(1209,186,60,25,1),(1210,186,55,26,1),(1211,187,90,20,1),(1212,187,67,21,1),(1213,187,34,22,1),(1214,187,79,23,1),(1215,187,50,24,1),(1216,187,40,25,1),(1217,187,84,26,1),(1218,188,60,20,1),(1219,188,55,21,1),(1220,188,90,22,1),(1221,188,67,23,1),(1222,188,34,24,1),(1223,188,79,25,1),(1224,188,50,26,1),(1225,189,40,20,1),(1226,189,84,21,1),(1227,189,60,22,1),(1228,189,55,23,1),(1229,189,90,24,1),(1230,189,67,25,1),(1231,189,34,26,1),(1232,190,79,27,1),(1233,190,50,28,1),(1234,190,40,29,1),(1235,190,84,30,1),(1236,190,60,31,1),(1237,190,55,32,1),(1238,190,90,33,1),(1239,191,67,27,1),(1240,191,34,28,1),(1241,191,79,29,1),(1242,191,50,30,1),(1243,191,40,31,1),(1244,191,84,32,1),(1245,191,60,33,1),(1246,192,55,27,1),(1247,192,90,28,1),(1248,192,67,29,1),(1249,192,34,30,1),(1250,192,79,31,1),(1251,192,50,32,1),(1252,192,40,33,1),(1253,193,84,27,1),(1254,193,60,28,1),(1255,193,55,29,1),(1256,193,90,30,1),(1257,193,67,31,1),(1258,193,34,32,1),(1259,193,79,33,1),(1260,194,50,27,1),(1261,194,40,28,1),(1262,194,84,29,1),(1263,194,60,30,1),(1264,194,55,31,1),(1265,194,90,32,1),(1266,194,67,33,1),(1267,195,34,27,1),(1268,195,79,28,1),(1269,195,50,29,1),(1270,195,40,30,1),(1271,195,84,31,1),(1272,195,60,32,1),(1273,195,55,33,1),(1274,196,90,27,1),(1275,196,67,28,1),(1276,196,34,29,1),(1277,196,79,30,1),(1278,196,50,31,1),(1279,196,40,32,1),(1280,196,84,33,1),(1281,197,60,27,1),(1282,197,55,28,1),(1283,197,90,29,1),(1284,197,67,30,1),(1285,197,34,31,1),(1286,197,79,32,1),(1287,197,50,33,1),(1288,198,40,27,1),(1289,198,84,28,1),(1290,198,60,29,1),(1291,198,55,30,1),(1292,198,90,31,1),(1293,198,67,32,1),(1294,198,34,33,1),(1295,199,79,27,1),(1296,199,50,28,1),(1297,199,40,29,1),(1298,199,84,30,1),(1299,199,60,31,1),(1300,199,55,32,1),(1301,199,90,33,1),(1302,200,67,27,1),(1303,200,34,28,1),(1304,200,79,29,1),(1305,200,50,30,1),(1306,200,40,31,1),(1307,200,84,32,1),(1308,200,60,33,1),(1309,201,55,27,1),(1310,201,90,28,1),(1311,201,67,29,1),(1312,201,34,30,1),(1313,201,79,31,1),(1314,201,50,32,1),(1315,201,40,33,1),(1316,202,84,27,1),(1317,202,60,28,1),(1318,202,55,29,1),(1319,202,90,30,1),(1320,202,67,31,1),(1321,202,34,32,1),(1322,202,79,33,1),(1323,203,50,27,1),(1324,203,40,28,1),(1325,203,84,29,1),(1326,203,60,30,1),(1327,203,55,31,1),(1328,203,90,32,1),(1329,203,67,33,1),(1330,204,34,27,1),(1331,204,79,28,1),(1332,204,50,29,1),(1333,204,40,30,1),(1334,204,84,31,1),(1335,204,60,32,1),(1336,204,55,33,1),(1337,205,90,27,1),(1338,205,67,28,1),(1339,205,34,29,1),(1340,205,79,30,1),(1341,205,50,31,1),(1342,205,40,32,1),(1343,205,84,33,1),(1344,206,60,27,1),(1345,206,55,28,1),(1346,206,90,29,1),(1347,206,67,30,1),(1348,206,34,31,1),(1349,206,79,32,1),(1350,206,50,33,1),(1351,207,40,27,1),(1352,207,84,28,1),(1353,207,60,29,1),(1354,207,55,30,1),(1355,207,90,31,1),(1356,207,67,32,1),(1357,207,34,33,1),(1358,208,79,27,1),(1359,208,50,28,1),(1360,208,40,29,1),(1361,208,84,30,1),(1362,208,60,31,1),(1363,208,55,32,1),(1364,208,90,33,1),(1365,209,67,27,1),(1366,209,34,28,1),(1367,209,79,29,1),(1368,209,50,30,1),(1369,209,40,31,1),(1370,209,84,32,1),(1371,209,60,33,1),(1372,210,55,27,1),(1373,210,90,28,1),(1374,210,67,29,1),(1375,210,34,30,1),(1376,210,79,31,1),(1377,210,50,32,1),(1378,210,40,33,1),(1379,211,84,27,1),(1380,211,60,28,1),(1381,211,55,29,1),(1382,211,90,30,1),(1383,211,67,31,1),(1384,211,34,32,1),(1385,211,79,33,1),(1386,212,50,27,1),(1387,212,40,28,1),(1388,212,84,29,1),(1389,212,60,30,1),(1390,212,55,31,1),(1391,212,90,32,1),(1392,212,67,33,1),(1393,213,34,27,1),(1394,213,79,28,1),(1395,213,50,29,1),(1396,213,40,30,1),(1397,213,84,31,1),(1398,213,60,32,1),(1399,213,55,33,1),(1400,214,90,27,1),(1401,214,67,28,1),(1402,214,34,29,1),(1403,214,79,30,1),(1404,214,50,31,1),(1405,214,40,32,1),(1406,214,84,33,1),(1407,215,60,27,1),(1408,215,55,28,1),(1409,215,90,29,1),(1410,215,67,30,1),(1411,215,34,31,1),(1412,215,79,32,1),(1413,215,50,33,1),(1414,216,40,27,1),(1415,216,84,28,1),(1416,216,60,29,1),(1417,216,55,30,1),(1418,216,90,31,1),(1419,216,67,32,1),(1420,216,34,33,1),(1421,217,79,27,1),(1422,217,50,28,1),(1423,217,40,29,1),(1424,217,84,30,1),(1425,217,60,31,1),(1426,217,55,32,1),(1427,217,90,33,1),(1428,218,67,27,1),(1429,218,34,28,1),(1430,218,79,29,1),(1431,218,50,30,1),(1432,218,40,31,1),(1433,218,84,32,1),(1434,218,60,33,1),(1435,219,55,27,1),(1436,219,90,28,1),(1437,219,67,29,1),(1438,219,34,30,1),(1439,219,79,31,1),(1440,219,50,32,1),(1441,219,40,33,1),(1442,220,84,27,1),(1443,220,60,28,1),(1444,220,55,29,1),(1445,220,90,30,1),(1446,220,67,31,1),(1447,220,34,32,1),(1448,220,79,33,1),(1449,221,50,27,1),(1450,221,40,28,1),(1451,221,84,29,1),(1452,221,60,30,1),(1453,221,55,31,1),(1454,221,90,32,1),(1455,221,67,33,1),(1456,222,34,27,1),(1457,222,79,28,1),(1458,222,50,29,1),(1459,222,40,30,1),(1460,222,84,31,1),(1461,222,60,32,1),(1462,222,55,33,1),(1463,223,90,27,1),(1464,223,67,28,1),(1465,223,34,29,1),(1466,223,79,30,1),(1467,223,50,31,1),(1468,223,40,32,1),(1469,223,84,33,1),(1470,224,60,27,1),(1471,224,55,28,1),(1472,224,90,29,1),(1473,224,67,30,1),(1474,224,34,31,1),(1475,224,79,32,1),(1476,224,50,33,1),(1477,225,40,27,1),(1478,225,84,28,1),(1479,225,60,29,1),(1480,225,55,30,1),(1481,225,90,31,1),(1482,225,67,32,1),(1483,225,34,33,1),(1484,226,79,27,1),(1485,226,50,28,1),(1486,226,40,29,1),(1487,226,84,30,1),(1488,226,60,31,1),(1489,226,55,32,1),(1490,226,90,33,1),(1491,227,67,27,1),(1492,227,34,28,1),(1493,227,79,29,1),(1494,227,50,30,1),(1495,227,40,31,1),(1496,227,84,32,1),(1497,227,60,33,1),(1498,228,55,27,1),(1499,228,90,28,1),(1500,228,67,29,1),(1501,228,34,30,1),(1502,228,79,31,1),(1503,228,50,32,1),(1504,228,40,33,1),(1505,229,84,27,1),(1506,229,60,28,1),(1507,229,55,29,1),(1508,229,90,30,1),(1509,229,67,31,1),(1510,229,34,32,1),(1511,229,79,33,1),(1512,230,50,27,1),(1513,230,40,28,1),(1514,230,84,29,1),(1515,230,60,30,1),(1516,230,55,31,1),(1517,230,90,32,1),(1518,230,67,33,1),(1519,231,34,27,1),(1520,231,79,28,1),(1521,231,50,29,1),(1522,231,40,30,1),(1523,231,84,31,1),(1524,231,60,32,1),(1525,231,55,33,1),(1526,232,90,27,1),(1527,232,67,28,1),(1528,232,34,29,1),(1529,232,79,30,1),(1530,232,50,31,1),(1531,232,40,32,1),(1532,232,84,33,1),(1533,233,60,27,1),(1534,233,55,28,1),(1535,233,90,29,1),(1536,233,67,30,1),(1537,233,34,31,1),(1538,233,79,32,1),(1539,233,50,33,1),(1540,234,40,27,1),(1541,234,84,28,1),(1542,234,60,29,1),(1543,234,55,30,1),(1544,234,90,31,1),(1545,234,67,32,1),(1546,234,34,33,1);
/*!40000 ALTER TABLE `mark_final` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2019-09-13 10:30:53
