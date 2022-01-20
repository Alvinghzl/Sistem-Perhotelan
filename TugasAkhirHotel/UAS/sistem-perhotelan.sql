-- --------------------------------------------------------
-- Host:                         localhost
-- Server version:               10.4.22-MariaDB - mariadb.org binary distribution
-- Server OS:                    Win64
-- HeidiSQL Version:             11.3.0.6295
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;


-- Dumping database structure for hotel
CREATE DATABASE IF NOT EXISTS `hotel` /*!40100 DEFAULT CHARACTER SET utf8mb4 */;
USE `hotel`;

-- Dumping structure for table hotel.buking
CREATE TABLE IF NOT EXISTS `buking` (
  `id_booking` int(11) unsigned NOT NULL AUTO_INCREMENT,
  `id_tamu` int(11) NOT NULL,
  `id_kamar` int(11) NOT NULL,
  `check_in` date NOT NULL,
  `check_out` date DEFAULT NULL,
  `total_bayar` int(50) DEFAULT NULL,
  `status` varchar(255) NOT NULL DEFAULT '',
  PRIMARY KEY (`id_booking`),
  KEY `id_kamar_fk` (`id_kamar`),
  KEY `id_tamu_fk` (`id_tamu`),
  CONSTRAINT `id_kamar_fk` FOREIGN KEY (`id_kamar`) REFERENCES `kamar` (`id_kamar`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `id_tamu_fk` FOREIGN KEY (`id_tamu`) REFERENCES `tamu` (`id_tamu`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8mb4;

-- Dumping data for table hotel.buking: ~0 rows (approximately)
/*!40000 ALTER TABLE `buking` DISABLE KEYS */;
/*!40000 ALTER TABLE `buking` ENABLE KEYS */;

-- Dumping structure for table hotel.jeniskamar
CREATE TABLE IF NOT EXISTS `jeniskamar` (
  `id_jenis_kamar` int(10) NOT NULL AUTO_INCREMENT,
  `jenis_kamar` varchar(255) NOT NULL,
  `harga_permalam` int(50) NOT NULL,
  PRIMARY KEY (`id_jenis_kamar`)
) ENGINE=InnoDB AUTO_INCREMENT=36 DEFAULT CHARSET=utf8mb4;

-- Dumping data for table hotel.jeniskamar: ~4 rows (approximately)
/*!40000 ALTER TABLE `jeniskamar` DISABLE KEYS */;
INSERT INTO `jeniskamar` (`id_jenis_kamar`, `jenis_kamar`, `harga_permalam`) VALUES
	(32, 'Grand', 900000),
	(33, 'Family', 100000),
	(34, 'Deluxe', 350000),
	(35, 'Luxury', 1500000);
/*!40000 ALTER TABLE `jeniskamar` ENABLE KEYS */;

-- Dumping structure for table hotel.kamar
CREATE TABLE IF NOT EXISTS `kamar` (
  `id_kamar` int(11) NOT NULL AUTO_INCREMENT,
  `id_jenis_kamar` int(10) NOT NULL,
  `nama_kamar` varchar(50) DEFAULT NULL,
  `status` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`id_kamar`),
  KEY `id_jenis_kamar` (`id_jenis_kamar`),
  CONSTRAINT `id_jenis_kamar` FOREIGN KEY (`id_jenis_kamar`) REFERENCES `jeniskamar` (`id_jenis_kamar`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=utf8mb4;

-- Dumping data for table hotel.kamar: ~4 rows (approximately)
/*!40000 ALTER TABLE `kamar` DISABLE KEYS */;
INSERT INTO `kamar` (`id_kamar`, `id_jenis_kamar`, `nama_kamar`, `status`) VALUES
	(7, 32, 'Tulip', 'Kosong'),
	(9, 33, 'Tulipwww', 'Kosong'),
	(10, 35, 'Maldives001', 'Kosong'),
	(11, 34, 'Pattaya001', 'Kosong');
/*!40000 ALTER TABLE `kamar` ENABLE KEYS */;

-- Dumping structure for table hotel.tamu
CREATE TABLE IF NOT EXISTS `tamu` (
  `id_tamu` int(11) NOT NULL AUTO_INCREMENT,
  `nik` int(11) NOT NULL,
  `nama_tamu` varchar(255) NOT NULL,
  `alamat` varchar(255) NOT NULL DEFAULT '',
  `jenis_kelamin` varchar(255) NOT NULL DEFAULT '',
  PRIMARY KEY (`id_tamu`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4;

-- Dumping data for table hotel.tamu: ~1 rows (approximately)
/*!40000 ALTER TABLE `tamu` DISABLE KEYS */;
INSERT INTO `tamu` (`id_tamu`, `nik`, `nama_tamu`, `alamat`, `jenis_kelamin`) VALUES
	(4, 200, 'alfian', 'depok', 'Laki Laki');
/*!40000 ALTER TABLE `tamu` ENABLE KEYS */;

-- Dumping structure for table hotel.users
CREATE TABLE IF NOT EXISTS `users` (
  `id_user` int(11) unsigned NOT NULL AUTO_INCREMENT,
  `username` varchar(50) NOT NULL,
  `password` varchar(50) NOT NULL,
  `email` varchar(50) NOT NULL DEFAULT '',
  PRIMARY KEY (`id_user`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4;

-- Dumping data for table hotel.users: ~2 rows (approximately)
/*!40000 ALTER TABLE `users` DISABLE KEYS */;
INSERT INTO `users` (`id_user`, `username`, `password`, `email`) VALUES
	(1, 'vin', 'c4ca4238a0b923820dcc509a6f75849b', '00:20:22'),
	(2, '22', 'b6d767d2f8ed5d21a44b0e5886680cb9', '2022/01/11'),
	(3, 'alvinghzl', '6512bd43d9caa6e02c990b0a82652dca', 'alvin@hh.com');
/*!40000 ALTER TABLE `users` ENABLE KEYS */;

/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IFNULL(@OLD_FOREIGN_KEY_CHECKS, 1) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40111 SET SQL_NOTES=IFNULL(@OLD_SQL_NOTES, 1) */;
