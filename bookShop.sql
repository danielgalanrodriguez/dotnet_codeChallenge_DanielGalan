-- phpMyAdmin SQL Dump
-- version 4.8.5
-- https://www.phpmyadmin.net/
--
-- Host: localhost:3306
-- Generation Time: Apr 26, 2019 at 08:35 AM
-- Server version: 5.7.25-0ubuntu0.18.04.2
-- PHP Version: 7.2.17-0ubuntu0.18.04.1

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `bookShop`
--
CREATE DATABASE IF NOT EXISTS `bookShop` DEFAULT CHARACTER SET latin1 COLLATE latin1_swedish_ci;
USE `bookShop`;

-- --------------------------------------------------------

--
-- Table structure for table `Books`
--

CREATE TABLE `Books` (
  `id` int(11) NOT NULL,
  `title` varchar(256) NOT NULL,
  `author` varchar(256) NOT NULL,
  `price` decimal(10,0) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `Books`
--

INSERT INTO `Books` (`id`, `title`, `author`, `price`) VALUES
(1, 'Clean Code', 'Martin, Robert C.', '400'),
(2, 'Design Patterns', 'Eric Freeman', '445'),
(3, 'The Pragmatic Programmer: From Journeyman To Master', 'Andrew Hunt,David Thomas', '202'),
(4, 'Harry Potter And The Sorcerer\'s Stone', 'J.k. Rowling', '450'),
(5, 'Harry Potter and the Chamber of Secrets', 'J.k. Rowling', '399');

-- --------------------------------------------------------

--
-- Table structure for table `Purchases`
--

CREATE TABLE `Purchases` (
  `id` int(11) NOT NULL,
  `book_id` int(11) NOT NULL,
  `user_id` int(11) NOT NULL,
  `date` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `Purchases`
--

INSERT INTO `Purchases` (`id`, `book_id`, `user_id`, `date`) VALUES
(1, 4, 2, '2019-04-26 07:32:38'),
(2, 1, 2, '2019-04-26 07:32:42'),
(3, 4, 4, '2019-04-26 07:32:54'),
(4, 1, 4, '2019-04-26 07:32:59'),
(5, 2, 4, '2019-04-26 07:33:03'),
(6, 3, 3, '2019-04-26 07:33:11'),
(7, 3, 3, '2019-04-26 07:33:13'),
(8, 5, 1, '2019-04-26 07:43:27'),
(9, 3, 1, '2019-04-26 08:14:15');

-- --------------------------------------------------------

--
-- Table structure for table `Users`
--

CREATE TABLE `Users` (
  `id` int(11) NOT NULL,
  `email` varchar(256) NOT NULL,
  `password` varchar(256) NOT NULL,
  `name` varchar(256) NOT NULL,
  `surname` varchar(256) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `Users`
--

INSERT INTO `Users` (`id`, `email`, `password`, `name`, `surname`) VALUES
(1, 'putTest@test.test', 'putPassword', 'putName', 'putSurname'),
(2, 'joe.garbet@hotmail.com', 'passjoe', 'Joe', 'Garbet'),
(3, 'deadpool@deadpool.com', 'nopass', 'dead', 'pool'),
(4, 'alfredHitchcock@alfred.com', 'alfred1234pass', 'alfred ', 'hitchcock'),
(5, 'danielgalan@gmail.com', 'password', 'Daniel', 'Galan');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `Books`
--
ALTER TABLE `Books`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `title` (`title`);

--
-- Indexes for table `Purchases`
--
ALTER TABLE `Purchases`
  ADD PRIMARY KEY (`id`) USING BTREE,
  ADD KEY `book_id` (`book_id`),
  ADD KEY `Purchases_ibfk_2` (`user_id`);

--
-- Indexes for table `Users`
--
ALTER TABLE `Users`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `email` (`email`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `Books`
--
ALTER TABLE `Books`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `Purchases`
--
ALTER TABLE `Purchases`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- AUTO_INCREMENT for table `Users`
--
ALTER TABLE `Users`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `Purchases`
--
ALTER TABLE `Purchases`
  ADD CONSTRAINT `Purchases_ibfk_1` FOREIGN KEY (`book_id`) REFERENCES `Books` (`id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `Purchases_ibfk_2` FOREIGN KEY (`user_id`) REFERENCES `Users` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
