-- phpMyAdmin SQL Dump
-- version 5.0.2
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1:3306
-- Generation Time: Aug 06, 2021 at 06:38 PM
-- Server version: 5.7.31
-- PHP Version: 7.3.21

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `enchanterfashion`
--

-- --------------------------------------------------------

--
-- Table structure for table `contain_items`
--

DROP TABLE IF EXISTS `contain_items`;
CREATE TABLE IF NOT EXISTS `contain_items` (
  `item_id` int(11) NOT NULL,
  `item_name` varchar(25) NOT NULL,
  `item_type` varchar(10) NOT NULL,
  `brand` varchar(25) NOT NULL,
  `price` float NOT NULL,
  `Collection` varchar(17) NOT NULL,
  `Black` int(11) NOT NULL,
  `Blue` int(11) NOT NULL,
  `White` int(11) NOT NULL,
  `Red` int(11) NOT NULL,
  `SMALL` int(11) NOT NULL,
  `MEDIUM` int(11) NOT NULL,
  `LARGE` int(11) NOT NULL,
  `stock_id` int(11) NOT NULL,
  PRIMARY KEY (`item_id`),
  KEY `item_name` (`item_name`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `contain_items`
--

INSERT INTO `contain_items` (`item_id`, `item_name`, `item_type`, `brand`, `price`, `Collection`, `Black`, `Blue`, `White`, `Red`, `SMALL`, `MEDIUM`, `LARGE`, `stock_id`) VALUES
(1113, 'Stripped frock', 'kids', 'Miss Modano', 1250, 'Teen ', 15, 5, 20, 10, 10, 30, 10, 1),
(1233, 'asymmetrical la', 'women', 'Jezza', 2500, 'Festive', 10, 20, 50, 10, 20, 50, 20, 2),
(1236, 'Stretch denim', 'women ', 'LICC', 3350, 'Slim FI', 30, 30, 10, 2, 30, 50, 10, 3),
(1237, 'Mens Formal sh', 'men', 'King street', 1900, 'Slim FI', 50, 40, 60, 40, 30, 70, 50, 4),
(1238, 'Mens sport Tsh', 'men', 'MUN', 1400, 'Sports', 50, 50, 60, 40, 30, 65, 40, 5),
(1240, 'Casual T-shirt', 'men', 'Edge ', 1500, 'Slim Fi', 21, 21, 14, 15, 32, 24, 12, 7),
(1241, 'Casual frock', 'kids', 'Miss Modano', 1250, 'Teen', 14, 22, 11, 13, 23, 21, 14, 8),
(1242, 'Linen frock', 'kids', 'Butterfly Avenue', 1450, 'Teen', 22, 24, 32, 21, 20, 10, 23, 9),
(1243, 'Smocked floral top', 'women', 'Abiti', 1200, 'Floral', 22, 12, 10, 16, 18, 20, 22, 10),
(1244, 'Ladies Maxi dress', 'women', 'Chenara Dodge', 3200, 'Elegant', 22, 24, 14, 15, 32, 24, 23, 11),
(1245, 'De Asymmetrical ', 'women', 'Miss Modano', 1250, 'Teen', 13, 22, 11, 12, 23, 20, 13, 11),
(1247, 'Boys Trouser', 'kids', 'Vintage', 1400, 'Casual', 22, 12, 11, 12, 18, 23, 13, 10);

-- --------------------------------------------------------

--
-- Table structure for table `display`
--

DROP TABLE IF EXISTS `display`;
CREATE TABLE IF NOT EXISTS `display` (
  `pic_num` int(11) NOT NULL AUTO_INCREMENT,
  `pic_file_name` varchar(20) NOT NULL,
  `item_name` varchar(25) NOT NULL,
  `description` varchar(8000) NOT NULL,
  PRIMARY KEY (`pic_num`),
  KEY `pic_file_name` (`pic_file_name`),
  KEY `item_name` (`item_name`)
) ENGINE=InnoDB AUTO_INCREMENT=42 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `display`
--

INSERT INTO `display` (`pic_num`, `pic_file_name`, `item_name`, `description`) VALUES
(26, 'women11.png', 'Smocked floral top', 'This Summer plain-designed dress will soon become a seasonal favorite. You’ll be dazzling in this stunning outfit that shows off your sense of style, sophistication, and flair for fun. This dress is designed for looks and ease, made to be breathable and built for comfort. With this dress you will get your new stylish looks on and shine well. Get an angelic look in this white and red floral embroidered top for women. This classy and elegant outfit is sure to make lasting impressions on the crowd. The A-line top features a boat neck and a gathered waistline to hide that excess bulk. You can wear it with a cool blue denim trouser to look like a million bucks!'),
(29, 'girl4.png', 'Casual frock', 'All smiles for warmer weather and prints. Introducing the new teen collection by Miss Modano. This adorable dress is so comfortable and stylish so a girl can frolic in. It is perfect for travel, school, and play. Cotton blend is soft on kids’ skin and leaves garment wrinkle free. Dress your princess with the new kids range for a look that is light and airy yet occasion-ready, look no further than this picture-perfect. This is perfect for your toddler girl. Slip on design makes dressing easy. Easy to care for, machine washable.   '),
(30, 'women21.png', 'Stretch denim', 'Add some edge with our new premium stretch denim. A feminine cut combining engineered design and the perfect fit to hug hips and thighs with softness and comfortable stretch. The fit on the waist varies according to style but ultimately this is the perfect fit to feel great in with a figure flattering cut and endless comfort. Dress your princess with the new kids range for a look that is light and airy yet occasion-ready, look no further than this picture-perfect. This is perfect for your toddler girl. Slip on design makes dressing easy. Easy to care for, machine washable. '),
(32, 'men 1.jpg', 'Mens Formal sh', 'Bengal stripes lie at the bolder end of the spectrum in stripes. These formal shirts for men have stripes which are about one-fourth of an inch thick. Opt for a young and sharp look in your new job dressed in a white and charcoal grey Bengal-stripe shirt with a semi-cutaway collar. Pair it up with dark grey trousers, a brown belt and brown brogues. You can select and style a t-shirt for men according to the season and occasion, which means that the same garment could be used to create completely different looks entirely depending on the scenario and weather. However, to be able to do this successfully, you must first have an understanding of styling t-shirts and your personal preference; this includes how you would like to project yourself.'),
(33, 'men4.png', 'Mens sport Tsh', 'Fashion and function should both go hand-in-hand, the elements of style on a T-shirt can give you the boost of confidence you need. Once an integral part of the sports outfit for men, the humble cotton T-shirt does not make the cut for hours of strenuous training. Browse through our extensive collection and get game ready in style, dress in your favorite colors and feel a rush of confidence when you step on the field.'),
(35, 'girl3.png', 'Linen frock', 'Get an angelic look in this white and red floral embroidered top for women. This classy and elegant outfit is sure to make lasting impressions on the crowd. The A-line top features a boat neck and a gathered waistline to hide that excess bulk. You can wear it with a cool blue denim trouser to look like a million bucks. All smiles for warmer weather and prints. Introducing the new teen collection by Miss Modano. This adorable dress is so comfortable and stylish so a girl can frolic in. It is perfect for travel, school, and play. Cotton blend is soft on kids’ skin and leaves garment wrinkle free. '),
(37, 'boy1.png', 'Boys Trouser', 'Neat and classy pants for boys around age 12 to 15. Browse through our grand collection and get  in style, dress in your favorite colors like White, Brown & Grey. Take a break from your regular denims and flaunt a cotton trouser, this season. Cotton trousers earn some extra brownie points when it comes to bottom wear, for their relative comfort. Fashion and function should both go hand-in-hand, the elements of style on a T-shirt can give you the boost of confidence you need. Once an integral part of the sports outfit for men, the humble cotton T-shirt does not make the cut for hours of strenuous training. Browse through our extensive collection and get game ready in style, dress in your favorite colors and feel a rush of confidence when you step on the field.'),
(40, 'women2.png', 'De Asymmetrical ', 'Get an angelic look in this white and red floral embroidered top for women. This classy and elegant outfit is sure to make lasting impressions on the crowd. The A-line top features a boat neck and a gathered waistline to hide that excess bulk. You can wear it with a cool blue denim trouser to look like a million bucks.  This Summer plain-designed dress will soon become a seasonal favorite. You’ll be dazzling in this stunning outfit that shows off your sense of style, sophistication, and flair for fun. This dress is designed for looks and ease, made to be breathable and built for comfort. With this dress you will get your new stylish looks on and shine well.'),
(41, 'men2.png', 'Casual T-shirt', 'You can select and style a t-shirt for men according to the season and occasion, which means that the same garment could be used to create completely different looks entirely depending on the scenario and weather. However, to be able to do this successfully, you must first have an understanding of styling t-shirts and your personal preference; this includes how you would like to project yourself. Fashion and function should both go hand-in-hand, the elements of style on a T-shirt can give you the boost of confidence you need. Once an integral part of the sports outfit for men, the humble cotton T-shirt does not make the cut for hours of strenuous training. Browse through our extensive collection and get game ready in style, dress in your favorite colors and feel a rush of confidence when you step on the field.');

-- --------------------------------------------------------

--
-- Table structure for table `employees`
--

DROP TABLE IF EXISTS `employees`;
CREATE TABLE IF NOT EXISTS `employees` (
  `emp_no` int(11) NOT NULL,
  `emp_fname` varchar(25) NOT NULL,
  `emp_lname` varchar(25) NOT NULL,
  `emp_mobile` int(11) NOT NULL,
  `emp_hm_nub` varchar(5) NOT NULL,
  `emp_street` varchar(20) NOT NULL,
  `emp_city` varchar(15) NOT NULL,
  PRIMARY KEY (`emp_no`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `employees`
--

INSERT INTO `employees` (`emp_no`, `emp_fname`, `emp_lname`, `emp_mobile`, `emp_hm_nub`, `emp_street`, `emp_city`) VALUES
(1, 'Vijitha ', 'Amerasekera', 778888222, 'H01', 'Koswattha', 'Colombo'),
(2, 'Wimalasena ', 'Perera', 778878222, 'H02', 'Pallethalawinna', 'Kandy'),
(3, 'Ratna ', 'Kumar', 778488222, 'H03', 'Madawala', 'Kandy'),
(4, 'Damayanthi ', 'Dharsha', 778448222, 'H04', 'Nugawela', 'Galle'),
(5, 'Sugath ', 'Thilakaratne', 778447222, 'H05', 'Gurudeniya', 'Gampaha');

-- --------------------------------------------------------

--
-- Table structure for table `registration`
--

DROP TABLE IF EXISTS `registration`;
CREATE TABLE IF NOT EXISTS `registration` (
  `reg_id` int(11) NOT NULL AUTO_INCREMENT,
  `username` varchar(55) NOT NULL,
  `password` char(32) NOT NULL,
  `email` varchar(55) NOT NULL,
  `gender` enum('male','female') NOT NULL,
  `phone_no` int(11) NOT NULL,
  `name` varchar(25) NOT NULL,
  `question_1` varchar(25) NOT NULL,
  `question_2` varchar(25) NOT NULL,
  `emp_no` int(11) NOT NULL,
  PRIMARY KEY (`reg_id`)
) ENGINE=InnoDB AUTO_INCREMENT=13 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `registration`
--

INSERT INTO `registration` (`reg_id`, `username`, `password`, `email`, `gender`, `phone_no`, `name`, `question_1`, `question_2`, `emp_no`) VALUES
(1, 'vamerasekera', 'Mypassword123', 'vamera@gmail.com', 'male', 778888222, 'Vijitha Amerasekera', '', '', 1),
(2, 'wperera', 'Testpassword', 'wperera@yahoo.com', 'male', 778878222, 'Wimalasena Perera', '', '', 2),
(3, 'rkumar ', 'password123', 'rkumar@gmail.com', 'male', 778488222, 'Ratna Kumar ', '', '', 3),
(4, 'ddharsha', '123password', 'ddharsha@gmail.com', 'female', 778448222, 'Damayanthi Dharsha', '', '', 4),
(5, 'sthilakaratne', '1password', 'sthilakaratne@gmail.com', 'male', 778447222, 'Sugath Thilakaratne', '', '', 5),
(11, 'Supun ', 'Su1%', 'Supun1234@gmail.com', 'male', 772688805, 'SUpun Nisala', 'pcc', 'abha yaluwo', 6),
(12, 'Theruni', 'Su1%', 'Theruni12@gmail.com', 'female', 772688808, 'Theruni hansani', 'madolduwa', 'ccp', 7);

-- --------------------------------------------------------

--
-- Table structure for table `reg_stock`
--

DROP TABLE IF EXISTS `reg_stock`;
CREATE TABLE IF NOT EXISTS `reg_stock` (
  `mgt_id` int(11) NOT NULL,
  `date` date NOT NULL,
  `time` time NOT NULL,
  `reg_id` int(11) NOT NULL,
  `stock_id` int(11) NOT NULL,
  PRIMARY KEY (`mgt_id`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `reg_stock`
--

INSERT INTO `reg_stock` (`mgt_id`, `date`, `time`, `reg_id`, `stock_id`) VALUES
(1, '2021-07-14', '18:12:29', 1, 1),
(2, '2020-12-09', '19:12:21', 2, 2),
(3, '2020-02-10', '20:17:27', 3, 3),
(4, '2021-06-15', '17:05:27', 4, 4),
(5, '2021-01-12', '18:16:23', 5, 5);

-- --------------------------------------------------------

--
-- Table structure for table `stocks`
--

DROP TABLE IF EXISTS `stocks`;
CREATE TABLE IF NOT EXISTS `stocks` (
  `stock_id` int(11) NOT NULL,
  `quantity` int(11) NOT NULL,
  `price` float NOT NULL,
  `weight` float NOT NULL,
  `received_date` date NOT NULL,
  `received_time` time NOT NULL,
  `sup_id` int(11) NOT NULL,
  PRIMARY KEY (`stock_id`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `stocks`
--

INSERT INTO `stocks` (`stock_id`, `quantity`, `price`, `weight`, `received_date`, `received_time`, `sup_id`) VALUES
(1, 10, 15000, 4.5, '2021-07-14', '14:36:31', 1),
(2, 8, 6000, 3.7, '2020-12-09', '17:16:23', 2),
(3, 20, 28000, 9, '2020-02-10', '19:21:31', 3),
(4, 15, 17000, 6.7, '2021-06-15', '16:21:23', 4),
(5, 5, 6000, 2.5, '2021-01-12', '17:16:23', 5);

-- --------------------------------------------------------

--
-- Table structure for table `suppliers`
--

DROP TABLE IF EXISTS `suppliers`;
CREATE TABLE IF NOT EXISTS `suppliers` (
  `sup_id` int(11) NOT NULL,
  `sup_name` varchar(25) NOT NULL,
  `sup_mobile` int(11) NOT NULL,
  `sup_hm_nub` varchar(5) NOT NULL,
  `sup_street` varchar(20) NOT NULL,
  `sup_city` varchar(15) NOT NULL,
  `sup_email` varchar(255) NOT NULL,
  PRIMARY KEY (`sup_id`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `suppliers`
--

INSERT INTO `suppliers` (`sup_id`, `sup_name`, `sup_mobile`, `sup_hm_nub`, `sup_street`, `sup_city`, `sup_email`) VALUES
(1, 'Wickremasinghe Wimaladasa', 776666222, 'SH01', 'Kadaladeniya', 'Galle', 'wimaladasa123@gmail.com'),
(2, 'Chintaka de Zoysa', 776656222, 'SH02', 'Doragamuwa', 'Colombo', 'czoysa@yahoo.com'),
(3, 'Tilaka Jinadasa', 776556222, 'SH03', 'Dodangama', 'Kandy', 'tjinadasa@gmail.com'),
(4, 'Samararatne Dharmasena', 778448234, 'SH04', 'Yahalathenna', 'Colombo', 'sdharmasena@gmail.com'),
(5, 'Sumeda Ranasinghe', 778448234, 'SH05', 'Ratagahawattha', 'Gampaha', 'sranasinghe@gmail.com');

--
-- Constraints for dumped tables
--

--
-- Constraints for table `display`
--
ALTER TABLE `display`
  ADD CONSTRAINT `display_ibfk_1` FOREIGN KEY (`item_name`) REFERENCES `contain_items` (`item_name`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
