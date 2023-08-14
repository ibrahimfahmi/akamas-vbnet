-- phpMyAdmin SQL Dump
-- version 5.1.3
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jun 23, 2022 at 09:11 AM
-- Server version: 10.4.14-MariaDB
-- PHP Version: 7.2.34

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `akamas`
--

-- --------------------------------------------------------

--
-- Table structure for table `identitas`
--

CREATE TABLE `identitas` (
  `identitas_id` varchar(10) NOT NULL,
  `nama_masjid` varchar(40) NOT NULL,
  `alamat_singkat` varchar(50) NOT NULL,
  `alamat_sekretariat` varchar(120) NOT NULL,
  `telp` varchar(15) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `identitas`
--

INSERT INTO `identitas` (`identitas_id`, `nama_masjid`, `alamat_singkat`, `alamat_sekretariat`, `telp`) VALUES
('IDM-1', 'MASJID BAITURRAHMAN', 'Dukuh Kebak Rw XIII Desa Wirun', 'Dk. Kebak Rt 001 Rw 013 Ds. Wirun Kec. Mojolaban Kab. Sukoharjo Kode Pos 57554', '085-789-453-253');

-- --------------------------------------------------------

--
-- Table structure for table `kas`
--

CREATE TABLE `kas` (
  `kas_id` varchar(10) NOT NULL,
  `kegiatan_id` varchar(10) DEFAULT NULL,
  `jenis` varchar(7) NOT NULL,
  `masuk` int(11) NOT NULL,
  `keluar` int(11) NOT NULL,
  `tgl` date NOT NULL,
  `ket` varchar(200) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `kas`
--

INSERT INTO `kas` (`kas_id`, `kegiatan_id`, `jenis`, `masuk`, `keluar`, `tgl`, `ket`) VALUES
('KAS-1', 'KGT-1', 'Masuk', 200000, 0, '2022-06-09', 'infaq sholat jumat 2'),
('KAS-2', 'KGT-2', 'Keluar', 0, 180000, '2022-06-22', 'test'),
('KAS-3', 'KGT-1', 'Masuk', 300000, 0, '2022-05-26', 'infaq sholat jumat 1');

-- --------------------------------------------------------

--
-- Table structure for table `kegiatan`
--

CREATE TABLE `kegiatan` (
  `kegiatan_id` varchar(10) NOT NULL,
  `kegiatan` varchar(40) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `kegiatan`
--

INSERT INTO `kegiatan` (`kegiatan_id`, `kegiatan`) VALUES
('KGT-1', 'Infaq Sholat Jumat'),
('KGT-2', 'TPQ');

-- --------------------------------------------------------

--
-- Table structure for table `posisi`
--

CREATE TABLE `posisi` (
  `posisi_id` varchar(10) NOT NULL,
  `posisi` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `posisi`
--

INSERT INTO `posisi` (`posisi_id`, `posisi`) VALUES
('POS-1', 'KETUA TAKMIR'),
('POS-2', 'SEKRETARIS'),
('POS-3', 'BENDAHARA');

-- --------------------------------------------------------

--
-- Table structure for table `posisi_detail`
--

CREATE TABLE `posisi_detail` (
  `pj_id` varchar(10) NOT NULL,
  `posisi_id` varchar(10) NOT NULL,
  `pj` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `posisi_detail`
--

INSERT INTO `posisi_detail` (`pj_id`, `posisi_id`, `pj`) VALUES
('PJD-1', 'POS-1', 'Bp. Maryono'),
('PJD-2', 'POS-3', 'Bp. Sukarmin'),
('PJD-3', 'POS-2', 'Bp. Mulyono Imung');

-- --------------------------------------------------------

--
-- Table structure for table `user`
--

CREATE TABLE `user` (
  `user_id` varchar(10) NOT NULL,
  `username` varchar(15) NOT NULL,
  `fullname` varchar(20) NOT NULL,
  `password` varchar(8) NOT NULL,
  `role` varchar(5) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `user`
--

INSERT INTO `user` (`user_id`, `username`, `fullname`, `password`, `role`) VALUES
('USR-1', 'admin', 'cup', 'admin', 'admin'),
('USR-2', 'kas', 'kas', 'kas', 'user'),
('USR-3', 'boim', 'boim wong', 'boim', 'admin');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `kas`
--
ALTER TABLE `kas`
  ADD PRIMARY KEY (`kas_id`);

--
-- Indexes for table `kegiatan`
--
ALTER TABLE `kegiatan`
  ADD PRIMARY KEY (`kegiatan_id`);

--
-- Indexes for table `posisi`
--
ALTER TABLE `posisi`
  ADD PRIMARY KEY (`posisi_id`);

--
-- Indexes for table `posisi_detail`
--
ALTER TABLE `posisi_detail`
  ADD PRIMARY KEY (`pj_id`);

--
-- Indexes for table `user`
--
ALTER TABLE `user`
  ADD PRIMARY KEY (`user_id`),
  ADD UNIQUE KEY `username` (`username`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
