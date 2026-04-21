-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Waktu pembuatan: 21 Apr 2026 pada 09.58
-- Versi server: 10.4.32-MariaDB
-- Versi PHP: 8.0.30

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
-- Struktur dari tabel `tbhijab`
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
-- Dumping data untuk tabel `tbhijab`
--

INSERT INTO `tbhijab` (`kodeHijab`, `namaHijab`, `kategori`, `warna`, `harga`, `stok`) VALUES
('HJ001', 'Instan Basic', 'Instan', 'Hitam', 35000, 13),
('HJ002', 'Bergo Daily', 'Bergo', 'Dark Red', 40000, 13),
('HJ003', 'Khimar Syari', 'Khimar', 'Navy', 75000, 5),
('HJ004', 'Pashmina Viscoes', 'Pashmina', 'Ivory', 55000, 39),
('HJ005', 'Segi Empat Voal', 'Segi Empat', 'Dark Brown', 35000, 30);

-- --------------------------------------------------------

--
-- Struktur dari tabel `tbtransaksi`
--

CREATE TABLE `tbtransaksi` (
  `idTransaksi` int(11) NOT NULL,
  `kodeHijab` varchar(10) DEFAULT NULL,
  `tanggal` date DEFAULT NULL,
  `jumlah` int(11) DEFAULT NULL,
  `total` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data untuk tabel `tbtransaksi`
--

INSERT INTO `tbtransaksi` (`idTransaksi`, `kodeHijab`, `tanggal`, `jumlah`, `total`) VALUES
(1, 'HJ001', '2026-04-21', 1, 35000),
(2, 'HJ001', '2026-04-21', 2, 70000),
(12, 'HJ004', '2026-04-13', 1, 55000),
(13, 'HJ003', '2026-04-06', 2, 150000),
(14, 'HJ003', '2026-04-21', 2, 150000);

--
-- Indexes for dumped tables
--

--
-- Indeks untuk tabel `tbhijab`
--
ALTER TABLE `tbhijab`
  ADD PRIMARY KEY (`kodeHijab`);

--
-- Indeks untuk tabel `tbtransaksi`
--
ALTER TABLE `tbtransaksi`
  ADD PRIMARY KEY (`idTransaksi`),
  ADD KEY `kodeHijab` (`kodeHijab`);

--
-- AUTO_INCREMENT untuk tabel yang dibuang
--

--
-- AUTO_INCREMENT untuk tabel `tbtransaksi`
--
ALTER TABLE `tbtransaksi`
  MODIFY `idTransaksi` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=15;

--
-- Ketidakleluasaan untuk tabel pelimpahan (Dumped Tables)
--

--
-- Ketidakleluasaan untuk tabel `tbtransaksi`
--
ALTER TABLE `tbtransaksi`
  ADD CONSTRAINT `tbtransaksi_ibfk_1` FOREIGN KEY (`kodeHijab`) REFERENCES `tbhijab` (`kodeHijab`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
