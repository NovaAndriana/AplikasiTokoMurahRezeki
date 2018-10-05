-- phpMyAdmin SQL Dump
-- version 4.7.9
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1:3306
-- Generation Time: Sep 28, 2018 at 03:33 PM
-- Server version: 5.7.21
-- PHP Version: 7.0.29

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `db_penjualan`
--

-- --------------------------------------------------------

--
-- Table structure for table `t_barang`
--

DROP TABLE IF EXISTS `t_barang`;
CREATE TABLE IF NOT EXISTS `t_barang` (
  `Kd_Barang` varchar(15) NOT NULL,
  `Nama_Barang` varchar(20) NOT NULL,
  `Stok` varchar(30) NOT NULL,
  `Harga` int(11) NOT NULL,
  PRIMARY KEY (`Kd_Barang`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `t_barang`
--

INSERT INTO `t_barang` (`Kd_Barang`, `Nama_Barang`, `Stok`, `Harga`) VALUES
('BR18092700001', 'xxxx', 'aqa', 222);

-- --------------------------------------------------------

--
-- Table structure for table `t_beli`
--

DROP TABLE IF EXISTS `t_beli`;
CREATE TABLE IF NOT EXISTS `t_beli` (
  `No_Beli` varchar(10) NOT NULL,
  `Kd_Supplier` varchar(15) NOT NULL,
  `Kd_Pegawai` varchar(10) NOT NULL,
  `Tanggal` date NOT NULL,
  `Total` int(11) NOT NULL,
  PRIMARY KEY (`No_Beli`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `t_detailbeli`
--

DROP TABLE IF EXISTS `t_detailbeli`;
CREATE TABLE IF NOT EXISTS `t_detailbeli` (
  `No_Beli` varchar(50) NOT NULL,
  `Kd_Barang` varchar(10) NOT NULL,
  `Jumlah` int(11) NOT NULL,
  `Harga` int(11) NOT NULL,
  PRIMARY KEY (`No_Beli`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `t_detailjual`
--

DROP TABLE IF EXISTS `t_detailjual`;
CREATE TABLE IF NOT EXISTS `t_detailjual` (
  `No_Jual` varchar(50) NOT NULL,
  `Kd_Pegawai` varchar(10) NOT NULL,
  `Kd_Member` varchar(10) NOT NULL,
  `Tanggal` date NOT NULL,
  `Sub_Total` int(11) NOT NULL,
  `Diskon` int(11) NOT NULL,
  `Total` int(11) NOT NULL,
  `Bayar` int(11) NOT NULL,
  `Kembalian` int(11) NOT NULL,
  PRIMARY KEY (`No_Jual`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `t_member`
--

DROP TABLE IF EXISTS `t_member`;
CREATE TABLE IF NOT EXISTS `t_member` (
  `Kd_Member` varchar(15) NOT NULL,
  `Nama_Member` varchar(20) NOT NULL,
  `Jenis_Kelamin` varchar(15) NOT NULL,
  `Alamat` varchar(20) NOT NULL,
  `No_Telp` int(15) NOT NULL,
  PRIMARY KEY (`Kd_Member`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `t_member`
--

INSERT INTO `t_member` (`Kd_Member`, `Nama_Member`, `Jenis_Kelamin`, `Alamat`, `No_Telp`) VALUES
('MBR/18092800001', 'sdfsd', 'Laki-Laki', 'sdfsd', 23);

-- --------------------------------------------------------

--
-- Table structure for table `t_pegawai`
--

DROP TABLE IF EXISTS `t_pegawai`;
CREATE TABLE IF NOT EXISTS `t_pegawai` (
  `Kd_Pegawai` varchar(15) NOT NULL,
  `Nama_Pegawai` varchar(20) NOT NULL,
  `Jenis_Kelamin` varchar(15) NOT NULL,
  `Status` varchar(10) NOT NULL,
  `Password` varchar(15) NOT NULL,
  `Alamat` varchar(30) NOT NULL,
  `No_Telp` varchar(15) NOT NULL,
  PRIMARY KEY (`Kd_Pegawai`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `t_pegawai`
--

INSERT INTO `t_pegawai` (`Kd_Pegawai`, `Nama_Pegawai`, `Jenis_Kelamin`, `Status`, `Password`, `Alamat`, `No_Telp`) VALUES
('P0001', 'Irsan', 'Laki-Laki', 'Admin', '123456', '-', '-');

-- --------------------------------------------------------

--
-- Table structure for table `t_supplier`
--

DROP TABLE IF EXISTS `t_supplier`;
CREATE TABLE IF NOT EXISTS `t_supplier` (
  `Kd_Supplier` varchar(15) NOT NULL,
  `Nama_Supplier` varchar(20) NOT NULL,
  `Alamat` varchar(20) NOT NULL,
  `No_Telp` int(13) NOT NULL,
  PRIMARY KEY (`Kd_Supplier`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `t_supplier`
--

INSERT INTO `t_supplier` (`Kd_Supplier`, `Nama_Supplier`, `Alamat`, `No_Telp`) VALUES
('SP18092800001', 'xxx', 'asda', 23);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
