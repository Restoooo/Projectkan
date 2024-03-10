-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Mar 10, 2024 at 05:49 AM
-- Server version: 10.4.32-MariaDB
-- PHP Version: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `restoooo`
--

-- --------------------------------------------------------

--
-- Table structure for table `detail_pesanan`
--

CREATE TABLE `detail_pesanan` (
  `id_pesanan` int(3) NOT NULL,
  `id_menu` int(3) NOT NULL,
  `jumlah_pesanan` int(2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `karyawan`
--

CREATE TABLE `karyawan` (
  `id_karyawan` int(11) NOT NULL,
  `Nama` varchar(20) NOT NULL,
  `Jabatan` varchar(10) NOT NULL,
  `Username` varchar(10) NOT NULL,
  `Password` varchar(8) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `karyawan`
--

INSERT INTO `karyawan` (`id_karyawan`, `Nama`, `Jabatan`, `Username`, `Password`) VALUES
(1, 'John Doe', 'Kasir', 'jd123', 'jd321');

-- --------------------------------------------------------

--
-- Table structure for table `menu`
--

CREATE TABLE `menu` (
  `id_menu` int(3) NOT NULL,
  `Nama` varchar(50) NOT NULL,
  `Stok` int(10) NOT NULL,
  `jenis` varchar(15) NOT NULL,
  `harga` int(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `menu`
--

INSERT INTO `menu` (`id_menu`, `Nama`, `Stok`, `jenis`, `harga`) VALUES
(1, 'Nasi Goreng Kemangi', 20, 'Makanan', 27000),
(2, 'Nasi Uduk Spesial', 20, 'Makanan', 23000),
(3, 'Mie Ongklok', 20, 'Makanan', 28000),
(4, 'Donat', 20, 'Makanan', 18000),
(5, 'Pecel', 20, 'Makanan', 15000),
(6, 'Es Doger', 30, 'Minuman', 12000),
(7, 'Risoles', 35, 'Makanan', 15000),
(8, 'Es Buah', 50, 'Minuman', 15000),
(9, 'Kopi Susu', 35, 'Minuman', 18000),
(10, 'Rujak', 10, 'Makanan', 25000),
(11, 'Gado-gado', 15, 'Makanan', 25000),
(12, 'Bakmi Jawa', 20, 'Makanan', 25000),
(13, 'Juice', 20, 'Minuman', 10000),
(14, 'Ayam Ungkep', 25, 'Makanan', 35000),
(15, 'Rendang Sapi', 20, 'Makanan', 30000),
(16, 'Lunpia Semarang', 20, 'Makanan', 15000),
(17, 'Milkshake', 25, 'Minuman', 12000),
(18, 'Es Teh', 50, 'Minuman', 5000),
(19, 'Sup Asparagus Kepiting', 25, 'Makanan', 37000),
(20, 'Sup Buntut', 10, 'Makanan', 75000),
(21, 'Sup Iga', 10, 'Makanan', 45000),
(22, 'Iga Bakar', 10, 'Makanan', 50000),
(23, 'Air Mineral', 80, 'Minuman', 6000),
(24, 'Kroket', 15, 'Makanan', 12000),
(25, 'Es Jeruk', 30, 'Minuman', 8000);

-- --------------------------------------------------------

--
-- Table structure for table `pesanan`
--

CREATE TABLE `pesanan` (
  `id_pesanan` int(3) NOT NULL,
  `id_karyawan` int(3) NOT NULL,
  `tanggal_pesanan` date NOT NULL,
  `nomor_meja` int(3) NOT NULL,
  `harga` int(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `tempat_duduk`
--

CREATE TABLE `tempat_duduk` (
  `nomor_meja` int(3) NOT NULL,
  `jumlah_kursi` int(2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tempat_duduk`
--

INSERT INTO `tempat_duduk` (`nomor_meja`, `jumlah_kursi`) VALUES
(0, 0),
(1, 2),
(2, 2),
(3, 2),
(4, 2),
(5, 4),
(6, 4),
(7, 4),
(8, 4),
(9, 8),
(10, 8),
(11, 2),
(12, 2),
(13, 2);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `detail_pesanan`
--
ALTER TABLE `detail_pesanan`
  ADD PRIMARY KEY (`id_pesanan`,`id_menu`),
  ADD KEY `FK_Menu` (`id_menu`),
  ADD KEY `FK_pesanan` (`id_pesanan`);

--
-- Indexes for table `karyawan`
--
ALTER TABLE `karyawan`
  ADD PRIMARY KEY (`id_karyawan`);

--
-- Indexes for table `menu`
--
ALTER TABLE `menu`
  ADD PRIMARY KEY (`id_menu`);

--
-- Indexes for table `pesanan`
--
ALTER TABLE `pesanan`
  ADD PRIMARY KEY (`id_pesanan`),
  ADD KEY `FK_Karyawan` (`id_karyawan`),
  ADD KEY `FK_Meja` (`nomor_meja`);

--
-- Indexes for table `tempat_duduk`
--
ALTER TABLE `tempat_duduk`
  ADD PRIMARY KEY (`nomor_meja`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `karyawan`
--
ALTER TABLE `karyawan`
  MODIFY `id_karyawan` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT for table `menu`
--
ALTER TABLE `menu`
  MODIFY `id_menu` int(3) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=26;

--
-- AUTO_INCREMENT for table `pesanan`
--
ALTER TABLE `pesanan`
  MODIFY `id_pesanan` int(3) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `detail_pesanan`
--
ALTER TABLE `detail_pesanan`
  ADD CONSTRAINT `FK_Menu` FOREIGN KEY (`id_menu`) REFERENCES `menu` (`id_menu`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `Fk_pesanan` FOREIGN KEY (`id_pesanan`) REFERENCES `pesanan` (`id_pesanan`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `pesanan`
--
ALTER TABLE `pesanan`
  ADD CONSTRAINT `FK_Karyawan` FOREIGN KEY (`id_karyawan`) REFERENCES `karyawan` (`id_karyawan`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `FK_Meja` FOREIGN KEY (`nomor_meja`) REFERENCES `tempat_duduk` (`nomor_meja`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
