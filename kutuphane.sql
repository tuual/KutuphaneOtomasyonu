-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Anamakine: 127.0.0.1:3306
-- Üretim Zamanı: 20 Ara 2023, 12:58:38
-- Sunucu sürümü: 8.0.31
-- PHP Sürümü: 8.0.26

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Veritabanı: `kutuphane`
--

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `kitaplar`
--

DROP TABLE IF EXISTS `kitaplar`;
CREATE TABLE IF NOT EXISTS `kitaplar` (
  `ID` int NOT NULL AUTO_INCREMENT,
  `kitapadi` varchar(200) COLLATE utf8mb4_turkish_ci NOT NULL,
  `kitapyazari` varchar(200) COLLATE utf8mb4_turkish_ci NOT NULL,
  `kitaptemasi` varchar(200) COLLATE utf8mb4_turkish_ci NOT NULL,
  `kitapsayfa` varchar(200) COLLATE utf8mb4_turkish_ci NOT NULL,
  `kitapdurum` varchar(200) COLLATE utf8mb4_turkish_ci NOT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=MyISAM AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_turkish_ci;

--
-- Tablo döküm verisi `kitaplar`
--

INSERT INTO `kitaplar` (`ID`, `kitapadi`, `kitapyazari`, `kitaptemasi`, `kitapsayfa`, `kitapdurum`) VALUES
(2, 'AD', 'SAD', 'ASD', 'ASD', 'Yıpranmış');

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `uyeler`
--

DROP TABLE IF EXISTS `uyeler`;
CREATE TABLE IF NOT EXISTS `uyeler` (
  `ID` int NOT NULL AUTO_INCREMENT,
  `uyeadi` varchar(100) COLLATE utf8mb4_turkish_ci NOT NULL,
  `uyetelno` varchar(233) COLLATE utf8mb4_turkish_ci NOT NULL,
  `uyetcno` varchar(223) COLLATE utf8mb4_turkish_ci NOT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=MyISAM AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_turkish_ci;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
