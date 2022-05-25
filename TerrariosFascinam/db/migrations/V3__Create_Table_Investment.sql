CREATE TABLE IF NOT EXISTS `investment` (
  `id` bigint NOT NULL AUTO_INCREMENT,
  `value` varchar(10) NOT NULL,
  `investment_date` varchar(10) NOT NULL,
  `product` varchar(50) DEFAULT NULL,
  `quantity` bigint DEFAULT NULL,
  PRIMARY KEY (`id`)
);