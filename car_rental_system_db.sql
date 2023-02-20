-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jul 04, 2022 at 11:58 AM
-- Server version: 10.4.24-MariaDB
-- PHP Version: 8.1.6

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `car_rental_system_db`
--

-- --------------------------------------------------------

--
-- Table structure for table `car`
--

CREATE TABLE `car` (
  `id` int(50) NOT NULL,
  `make` varchar(100) NOT NULL,
  `model` int(11) NOT NULL,
  `brand` varchar(50) NOT NULL,
  `reg_no` varchar(50) NOT NULL,
  `description` varchar(250) NOT NULL,
  `driver_id` int(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `car`
--

INSERT INTO `car` (`id`, `make`, `model`, `brand`, `reg_no`, `description`, `driver_id`) VALUES
(1, 'ALTO-2002', 0, 'ALTO', '1234-12334-12234', 'Car In One', 0);

-- --------------------------------------------------------

--
-- Table structure for table `customer`
--

CREATE TABLE `customer` (
  `id` int(50) NOT NULL,
  `first_name` varchar(100) NOT NULL,
  `last_name` varchar(100) NOT NULL,
  `gender` tinyint(1) NOT NULL,
  `cnic` varchar(50) NOT NULL,
  `contact_no` varchar(50) NOT NULL,
  `address` varchar(250) NOT NULL,
  `guarantor_cnic` int(50) NOT NULL,
  `guarantor_name` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `customer`
--

INSERT INTO `customer` (`id`, `first_name`, `last_name`, `gender`, `cnic`, `contact_no`, `address`, `guarantor_cnic`, `guarantor_name`) VALUES
(1, 'Naseeb', 'Jaan', 0, '520235445', '0313455455', 'abhvh', 552022545, 'umer');

-- --------------------------------------------------------

--
-- Table structure for table `driver`
--

CREATE TABLE `driver` (
  `id` int(50) NOT NULL,
  `first_name` varchar(100) NOT NULL,
  `last_name` varchar(100) NOT NULL,
  `cnic` varchar(50) NOT NULL,
  `license_no` varchar(50) NOT NULL,
  `contact_no` varchar(50) NOT NULL,
  `gender` tinyint(1) NOT NULL,
  `address` varchar(250) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `driver`
--

INSERT INTO `driver` (`id`, `first_name`, `last_name`, `cnic`, `license_no`, `contact_no`, `gender`, `address`) VALUES
(0, 'Shah', 'Dad', '5220368289149', '1234-1234-1234', '0313788741', 0, 'Turbat'),
(0, 'Shah', 'Dad', '5220368289149', '1234-1234-1234', '0313788741', 0, '44');

-- --------------------------------------------------------

--
-- Table structure for table `rental_record`
--

CREATE TABLE `rental_record` (
  `car_id` int(50) NOT NULL,
  `customer_id` int(50) NOT NULL,
  `booking_from` datetime NOT NULL,
  `booking_to` datetime NOT NULL,
  `total_rent` decimal(10,4) NOT NULL,
  `paid` decimal(10,4) NOT NULL,
  `balance` decimal(10,4) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `rental_record`
--

INSERT INTO `rental_record` (`car_id`, `customer_id`, `booking_from`, `booking_to`, `total_rent`, `paid`, `balance`) VALUES
(1, 1, '2020-07-04 00:00:00', '2009-08-14 00:00:00', '10.0000', '100.0000', '200.0000');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `car`
--
ALTER TABLE `car`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `customer`
--
ALTER TABLE `customer`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `car`
--
ALTER TABLE `car`
  MODIFY `id` int(50) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT for table `customer`
--
ALTER TABLE `customer`
  MODIFY `id` int(50) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
