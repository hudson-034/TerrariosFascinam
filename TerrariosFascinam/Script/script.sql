CREATE TABLE IF NOT EXISTS `client` (
  `id` BIGINT(20) NOT NULL AUTO_INCREMENT,
  `name` VARCHAR(100) NOT NULL,
  `born_date` DATE NOT NULL,
  `whatsapp` BIGINT(11) NOT NULL,
  `cpf` BIGINT(11),
  `address` VARCHAR(100),
  PRIMARY KEY (`id`)
)