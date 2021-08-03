-- phpMyAdmin SQL Dump
-- version 5.0.2
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1:3306
-- Generation Time: Jul 28, 2021 at 09:52 AM
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
  `item_name` varchar(15) NOT NULL,
  `item_type` varchar(10) NOT NULL,
  `itm_quantity` int(5) NOT NULL,
  `color` varchar(7) NOT NULL,
  `size` varchar(7) NOT NULL,
  `brand` varchar(15) NOT NULL,
  `price` float NOT NULL,
  `season` varchar(7) NOT NULL,
  `stock_id` int(11) NOT NULL,
  PRIMARY KEY (`item_id`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `contain_items`
--

INSERT INTO `contain_items` (`item_id`, `item_name`, `item_type`, `itm_quantity`, `color`, `size`, `brand`, `price`, `season`, `stock_id`) VALUES
(1234, 'flaknit sky', 'kids', 3, 'blue', 'small', 'Tirex', 1200, 'Autumn ', 1),
(1235, 'taraki', 'women', 12, 'cream', 'medium', 'demok', 1400, 'Autumn', 2),
(1236, 'laster', 'women ', 8, 'black', 'medium', 'drebox', 1350, 'summer', 3),
(1237, 'tshirt', 'men', 10, 'white', 'large', 'edge', 1380, 'summer', 4),
(1238, 'jeans', 'men', 8, 'blue', 'medium', 'levi', 1900, 'summer', 5);

-- --------------------------------------------------------

--
-- Table structure for table `display`
--

DROP TABLE IF EXISTS `display`;
CREATE TABLE IF NOT EXISTS `display` (
  `pic_num` int(11) NOT NULL,
  `item_id` varchar(11) NOT NULL,
  `item_type` varchar(10) NOT NULL,
  `itm_quantity` int(5) NOT NULL,
  `color` varchar(7) NOT NULL,
  `size` varchar(7) NOT NULL,
  `pic_file_name` varchar(20) NOT NULL,
  `item_name` varchar(15) NOT NULL,
  `season` varchar(7) NOT NULL,
  `brand` varchar(15) NOT NULL,
  PRIMARY KEY (`pic_num`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `display`
--

INSERT INTO `display` (`pic_num`, `item_id`, `item_type`, `itm_quantity`, `color`, `size`, `pic_file_name`, `item_name`, `season`, `brand`) VALUES
(1, '1234', 'kids', 3, 'blue', 'small', 'boy11.png', 'flaknit sky', 'Autumn', 'Tirex'),
(2, '1235', 'women', 12, 'cream', 'medium', 'women11.png', 'taraki', 'Autumn', 'demok'),
(3, '1236', 'women', 8, 'black', 'medium', 'women21.png', 'laster', 'summer', 'drebox');

-- --------------------------------------------------------

--
-- Table structure for table `employees`
--

DROP TABLE IF EXISTS `employees`;
CREATE TABLE IF NOT EXISTS `employees` (
  `emp_no` int(11) NOT NULL,
  `emp_fname` varchar(25) NOT NULL,
  `emp_lname` varchar(25) NOT NULL,
  `emp_mobile` int(10) NOT NULL,
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
  `reg_id` int(11) NOT NULL,
  `username` varchar(15) NOT NULL,
  `password` char(32) NOT NULL,
  `email` varchar(255) NOT NULL,
  `gender` enum('male','female') NOT NULL,
  `phone_no` int(10) NOT NULL,
  `name` varchar(25) NOT NULL,
  `emp_no` int(11) NOT NULL,
  PRIMARY KEY (`reg_id`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `registration`
--

INSERT INTO `registration` (`reg_id`, `username`, `password`, `email`, `gender`, `phone_no`, `name`, `emp_no`) VALUES
(1, 'vamerasekera', 'Mypassword123', 'vamera@gmail.com', 'male', 778888222, 'Vijitha Amerasekera', 1),
(2, 'wperera', 'Testpassword', 'wperera@yahoo.com', 'male', 778878222, 'Wimalasena Perera', 2),
(3, 'rkumar ', 'password123', 'rkumar@gmail.com', 'male', 778488222, 'Ratna Kumar ', 3),
(4, 'ddharsha', '123password', 'ddharsha@gmail.com', 'female', 778448222, 'Damayanthi Dharsha', 4),
(5, 'sthilakaratne', '1password', 'sthilakaratne@gmail.com', 'male', 778447222, 'Sugath Thilakaratne', 5);

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
  `quantity` int(200) NOT NULL,
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
  `sup_mobile` int(10) NOT NULL,
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
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
