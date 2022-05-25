CREATE TABLE IF NOT EXISTS `sale` (
  `id` bigint NOT NULL AUTO_INCREMENT,
  `value` varchar(10) NOT NULL,
  `sale_date` varchar(10) NOT NULL,
  `items` varchar(100) DEFAULT NULL,
  `client` bigint DEFAULT NULL,
  PRIMARY KEY (`id`),
  CONSTRAINT fk_client_sale FOREIGN KEY (`client`) REFERENCES `client` (`id`)
);