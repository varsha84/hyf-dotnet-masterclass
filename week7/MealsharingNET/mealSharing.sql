CREATE DATABASE  IF NOT EXISTS `meal-sharing`;
USE `meal-sharing`;
--
-- Table structure for table `meals`
--

DROP TABLE IF EXISTS `meals`;
CREATE TABLE `meals` (
  `id` int NOT NULL AUTO_INCREMENT,
  `title` varchar(45) DEFAULT NULL,
  `description` varchar(45) DEFAULT NULL,
  `price` DOUBLE DEFAULT NULL,
  `imageUrl` varchar(45) DEFAULT NULL,
  `location` varchar(45) DEFAULT NULL,
  `maxReservation` int DEFAULT NULL,
  `created_date` DATETIME NOT NULL,
  `when` DATETIME NOT NULL,

  PRIMARY KEY (`id`)
) ENGINE=InnoDB;

--
-- Dumping data for table `meals`
--

INSERT INTO `meals` VALUES (1,'chicken curry','spicy', 120.6, '', 'valby', 10, '2015-05-16T05:50:06', '2015-05-16T05:43:05' );
INSERT INTO `meals` VALUES (2,'Pasta','white sauce', 123.5, '', 'virum', 12, '2016-05-16T05:50:06', '2016-05-16T05:51:07');

INSERT INTO `meals` VALUES (3,'Paneer Tikka','Grill', 150.8, '', 'smørum', 9, '2017-04-16T05:50:06', '2017-05-16T05:52:04');

INSERT INTO `meals` VALUES (4,'Veg Biryani','Delicious', 160.9, '', 'Lyngby', 13, '2019-05-16T05:50:06', '2019-06-16T05:50:06');

SELECT * from  meals;


/*reservation table*/

DROP TABLE IF EXISTS `reservations`;

CREATE TABLE `reservations` ( 
    `id` int NOT NULL AUTO_INCREMENT, 
    `name` VARCHAR(45) DEFAULT NULL, 
    `mobile_no` INT DEFAULT NULL, 
    `email` varchar(45) DEFAULT NULL, 
    `reservation_date` DATETIME NOT NULL, 
    `num_of_persons` INT NOT NULL,
    `meal_id` INT NOT NULL,
    PRIMARY KEY (`id`),
    FOREIGN KEY (meal_id) REFERENCES meals(id)
    ) ENGINE=InnoDB;

--
-- Dumping data for table `reservations`
--


INSERT INTO `reservations` VALUES (1,'varsha', 456789,'varsha@abc.com','2021-05-16T05:50:06', 12, 1 );
INSERT INTO `reservations` VALUES (2,'vikas', 456789,'vikas@abc.com','2022-05-16T05:50:06', 10, 1 );

INSERT INTO `reservations` VALUES (3,'sonu', 487799,'sonu@abc.com','2022-02-16T05:50:06',5, 1 );



SELECT * FROM reservations;


/*Review Table*/
DROP TABLE IF EXISTS `reviews`;

CREATE TABLE `reviews` ( 
    `id` int NOT NULL AUTO_INCREMENT, 
    `title` VARCHAR(45) DEFAULT NULL,  
    `description` varchar(45) DEFAULT NULL, 
    `meal_id` INT NOT NULL,
    `stars` INT NOT NULL,
    `created_date` DATETIME NOT NULL, 
    PRIMARY KEY (`id`),
    FOREIGN KEY (meal_id) REFERENCES meals(id)
    ) ENGINE=InnoDB;



INSERT INTO `reviews` VALUES (1,'crispy','very good', 3, 5 ,'2021-05-16T05:50:06');
INSERT INTO `reviews` VALUES (2,'spicy','super tasty', 4, 4,'2021-05-16T05:50:06');

