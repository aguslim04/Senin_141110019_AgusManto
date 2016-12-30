-- phpMyAdmin SQL Dump
-- version 4.5.1
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: Dec 30, 2016 at 03:41 PM
-- Server version: 10.1.19-MariaDB
-- PHP Version: 5.6.28

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `latihan_pos`
--

-- --------------------------------------------------------

--
-- Table structure for table `tblbarang`
--

CREATE TABLE `tblbarang` (
  `id` int(10) NOT NULL,
  `kodeBarang` varchar(20) NOT NULL,
  `nama` varchar(100) NOT NULL,
  `jumlahawal` int(10) NOT NULL,
  `hargahpp` decimal(16,2) NOT NULL,
  `hargajual` decimal(16,2) NOT NULL,
  `createdate` datetime NOT NULL,
  `updatedate` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tblbarang`
--

INSERT INTO `tblbarang` (`id`, `kodeBarang`, `nama`, `jumlahawal`, `hargahpp`, `hargajual`, `createdate`, `updatedate`) VALUES
(18, '1', 'Windows 10', 3, '550000.00', '650000.00', '2016-12-30 19:28:46', '2016-12-30 19:28:46'),
(19, '2', 'SSD', 2, '800000.00', '900000.00', '2016-12-30 19:38:38', '2016-12-30 19:38:38');

-- --------------------------------------------------------

--
-- Table structure for table `tblcustomer`
--

CREATE TABLE `tblcustomer` (
  `id` int(20) NOT NULL,
  `nama_customer` varchar(100) NOT NULL,
  `alamat_customer` varchar(100) NOT NULL,
  `noHPCustomer` varchar(12) NOT NULL,
  `createdate` datetime NOT NULL,
  `updatedate` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tblcustomer`
--

INSERT INTO `tblcustomer` (`id`, `nama_customer`, `alamat_customer`, `noHPCustomer`, `createdate`, `updatedate`) VALUES
(12, 'Bill Gates', 'Amerika', '088877776666', '2016-12-30 19:27:26', '2016-12-30 19:27:26');

-- --------------------------------------------------------

--
-- Table structure for table `tblpembelian`
--

CREATE TABLE `tblpembelian` (
  `id` int(11) NOT NULL,
  `namaBarang` varchar(100) NOT NULL,
  `namaSupplier` varchar(100) NOT NULL,
  `jumlahBeli` int(100) NOT NULL,
  `hargabeli` int(11) NOT NULL,
  `hargaakhir` decimal(16,2) NOT NULL,
  `waktubeli` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tblpembelian`
--

INSERT INTO `tblpembelian` (`id`, `namaBarang`, `namaSupplier`, `jumlahBeli`, `hargabeli`, `hargaakhir`, `waktubeli`) VALUES
(0, 'SSD', '1', 0, 900000, '0.00', '2016-12-30 20:13:39');

-- --------------------------------------------------------

--
-- Table structure for table `tblpenjualan`
--

CREATE TABLE `tblpenjualan` (
  `id` int(11) NOT NULL,
  `namaBarang` varchar(100) NOT NULL,
  `namaCustomer` varchar(100) NOT NULL,
  `jumlahBeli` int(100) NOT NULL,
  `hargajual` int(11) NOT NULL,
  `hargaakhir` decimal(16,2) NOT NULL,
  `waktujual` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tblpenjualan`
--

INSERT INTO `tblpenjualan` (`id`, `namaBarang`, `namaCustomer`, `jumlahBeli`, `hargajual`, `hargaakhir`, `waktujual`) VALUES
(13, 'Windows 10', 'Bill Gates', 2, 650000, '1300000.00', '2016-12-30 20:22:55');

-- --------------------------------------------------------

--
-- Table structure for table `tblsupplier`
--

CREATE TABLE `tblsupplier` (
  `id` int(100) NOT NULL,
  `kodeSupplier` varchar(100) NOT NULL,
  `nama` varchar(100) NOT NULL,
  `alamat` varchar(100) NOT NULL,
  `kota` varchar(100) NOT NULL,
  `noHPSupplier` varchar(12) NOT NULL,
  `createDate` datetime NOT NULL,
  `updateDate` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tblsupplier`
--

INSERT INTO `tblsupplier` (`id`, `kodeSupplier`, `nama`, `alamat`, `kota`, `noHPSupplier`, `createDate`, `updateDate`) VALUES
(8, '1', 'Microsoft', 'Amerika', 'New York', '088877776655', '2016-12-30 19:27:57', '2016-12-30 19:27:57');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tblbarang`
--
ALTER TABLE `tblbarang`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `tblcustomer`
--
ALTER TABLE `tblcustomer`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `tblpenjualan`
--
ALTER TABLE `tblpenjualan`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `tblsupplier`
--
ALTER TABLE `tblsupplier`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `tblbarang`
--
ALTER TABLE `tblbarang`
  MODIFY `id` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=20;
--
-- AUTO_INCREMENT for table `tblcustomer`
--
ALTER TABLE `tblcustomer`
  MODIFY `id` int(20) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;
--
-- AUTO_INCREMENT for table `tblpenjualan`
--
ALTER TABLE `tblpenjualan`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=14;
--
-- AUTO_INCREMENT for table `tblsupplier`
--
ALTER TABLE `tblsupplier`
  MODIFY `id` int(100) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
