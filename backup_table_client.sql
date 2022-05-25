-- --------------------------------------------------------
-- Servidor:                     127.0.0.1
-- Versão do servidor:           8.0.29 - MySQL Community Server - GPL
-- OS do Servidor:               Win64
-- HeidiSQL Versão:              11.3.0.6295
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;


-- Copiando estrutura do banco de dados para terrarios_fascinam
CREATE DATABASE IF NOT EXISTS `terrarios_fascinam` /*!40100 DEFAULT CHARACTER SET latin1 */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `terrarios_fascinam`;

-- Copiando estrutura para tabela terrarios_fascinam.changelog
CREATE TABLE IF NOT EXISTS `changelog` (
  `id` int NOT NULL AUTO_INCREMENT,
  `type` tinyint DEFAULT NULL,
  `version` varchar(50) DEFAULT NULL,
  `description` varchar(200) NOT NULL,
  `name` varchar(300) NOT NULL,
  `checksum` varchar(32) DEFAULT NULL,
  `installed_by` varchar(100) NOT NULL,
  `installed_on` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `success` tinyint(1) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- Copiando dados para a tabela terrarios_fascinam.changelog: ~0 rows (aproximadamente)
/*!40000 ALTER TABLE `changelog` DISABLE KEYS */;
/*!40000 ALTER TABLE `changelog` ENABLE KEYS */;

-- Copiando estrutura para tabela terrarios_fascinam.client
CREATE TABLE IF NOT EXISTS `client` (
  `id` bigint NOT NULL AUTO_INCREMENT,
  `name` varchar(100) NOT NULL,
  `born_date` varchar(10) DEFAULT NULL,
  `whatsapp` varchar(11) DEFAULT NULL,
  `cpf` varchar(11) DEFAULT NULL,
  `address` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `whatsapp` (`whatsapp`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=latin1;

-- Copiando dados para a tabela terrarios_fascinam.client: ~4 rows (aproximadamente)
/*!40000 ALTER TABLE `client` DISABLE KEYS */;
INSERT INTO `client` (`id`, `name`, `born_date`, `whatsapp`, `cpf`, `address`) VALUES
	(1, 'Hudson Alves Rocha', '16/07/1992', '34996580078', '00300400607', 'Rua José Silva Filho, 141'),
	(2, 'Giselle Silva de Oliveira Rocha', '19/07/1991', '34997976082', '00100200607', 'Rua José Silva Filho, 141'),
	(4, 'Enio José da Rocha', '02/11/1962', '34996969696', '00100200609', 'Alameda Genaína Novaes Barbosa, 100'),
	(7, 'Lúcia Marta Alves da Silva Rocha', '26/12/1969', '34992929292', '00100200611', 'Alameda Genaína Novaes Barbosa, 100');
/*!40000 ALTER TABLE `client` ENABLE KEYS */;

/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IFNULL(@OLD_FOREIGN_KEY_CHECKS, 1) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40111 SET SQL_NOTES=IFNULL(@OLD_SQL_NOTES, 1) */;
