CREATE TABLE IF NOT EXISTS `client` (
  `id` bigint NOT NULL AUTO_INCREMENT,
  `name` varchar(100) NOT NULL,
  `born_date` varchar(10) DEFAULT NULL,
  `whatsapp` varchar(11) NOT NULL,
  `cpf` varchar(11) DEFAULT NULL,
  `address` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`id`)
);