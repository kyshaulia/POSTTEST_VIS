-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Apr 13, 2026 at 12:54 PM
-- Server version: 10.4.32-MariaDB
-- PHP Version: 8.0.30

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `db_hijab`
--

-- --------------------------------------------------------

--
-- Table structure for table `tbhijab`
--

CREATE TABLE `tbhijab` (
  `kodeHijab` varchar(5) NOT NULL,
  `namaHijab` varchar(50) NOT NULL,
  `kategori` varchar(20) NOT NULL,
  `warna` varchar(20) NOT NULL,
  `harga` int(11) NOT NULL,
  `stok` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tbhijab`
--

INSERT INTO `tbhijab` (`kodeHijab`, `namaHijab`, `kategori`, `warna`, `harga`, `stok`) VALUES
('HJ001', 'Instan Basic', 'Instan', 'Hitam', 35000, 20),
('HJ002', 'Bergo Daily', 'Bergo', 'Dark Red', 40000, 15),
('HJ003', 'Khimar Syari', 'Khimar', 'Navy', 75000, 10),
('HJ004', 'Pashmina Viscoes', 'Pashmina', 'Ivory', 55000, 40),
('HJ005', 'Segi Empat Voal', 'Segi Empat', 'Dark Brown', 35000, 30);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tbhijab`
--
ALTER TABLE `tbhijab`
  ADD PRIMARY KEY (`kodeHijab`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
