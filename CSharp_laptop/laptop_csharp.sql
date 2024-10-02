-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Oct 01, 2024 at 03:52 PM
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
-- Database: `laptop_csharp`
--

-- --------------------------------------------------------

--
-- Table structure for table `chitiethoadon`
--

CREATE TABLE `chitiethoadon` (
  `ID_SP` varchar(255) NOT NULL,
  `ID_HoaDon` bigint(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `chitiethoadon`
--

INSERT INTO `chitiethoadon` (`ID_SP`, `ID_HoaDon`) VALUES
('1', 1),
('2', 2),
('3', 3),
('4', 4),
('5', 5);

-- --------------------------------------------------------

--
-- Table structure for table `chitietphieunhap`
--

CREATE TABLE `chitietphieunhap` (
  `ID_SP` varchar(255) NOT NULL,
  `ID_PhieuNhap` bigint(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `chitietphieunhap`
--

INSERT INTO `chitietphieunhap` (`ID_SP`, `ID_PhieuNhap`) VALUES
('1', 1),
('2', 2),
('3', 3),
('4', 4),
('5', 5);

-- --------------------------------------------------------

--
-- Table structure for table `hang`
--

CREATE TABLE `hang` (
  `ID_Hang` varchar(255) NOT NULL,
  `TenHang` varchar(255) DEFAULT NULL,
  `DiaChi` varchar(255) DEFAULT NULL,
  `SDT` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `hang`
--

INSERT INTO `hang` (`ID_Hang`, `TenHang`, `DiaChi`, `SDT`) VALUES
('1', 'Apple', '1 Infinite Loop, Cupertino, CA', '408-996-1010'),
('2', 'Samsung', '129 Samsung-ro, Yeongtong-gu, Suwon-si', '031-200-1111'),
('3', 'Dell', '1 Dell Way, Round Rock, TX', '512-338-4400'),
('4', 'Lenovo', '1009 Think Place, Morrisville, NC', '919-294-4500'),
('5', 'Asus', '1501 S. Mopac Expy, Austin, TX', '512-345-0980');

-- --------------------------------------------------------

--
-- Table structure for table `hoadon`
--

CREATE TABLE `hoadon` (
  `ID_HoaDon` bigint(20) NOT NULL,
  `MaNV` varchar(255) DEFAULT NULL,
  `MaKH` varchar(255) DEFAULT NULL,
  `NgayLap` datetime DEFAULT NULL,
  `TongTien` bigint(20) DEFAULT NULL,
  `TienGiam` bigint(20) DEFAULT NULL,
  `TienNhan` bigint(20) DEFAULT NULL,
  `TienThoi` bigint(20) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `hoadon`
--

INSERT INTO `hoadon` (`ID_HoaDon`, `MaNV`, `MaKH`, `NgayLap`, `TongTien`, `TienGiam`, `TienNhan`, `TienThoi`) VALUES
(1, 'NV001', 'KH001', '2024-08-08 00:00:00', 500000, 50000, 600000, 50000),
(2, 'NV002', 'KH002', '2024-07-03 00:00:00', 750000, 100000, 800000, 50000),
(3, 'NV001', 'KH003', '2024-09-28 00:00:00', 300000, 0, 300000, 0),
(4, 'NV003', 'KH004', '2024-06-21 00:00:00', 1000000, 150000, 1200000, 50000),
(5, 'NV002', 'KH005', '2024-01-11 00:00:00', 200000, 20000, 220000, 20000);

-- --------------------------------------------------------

--
-- Table structure for table `khachhang`
--

CREATE TABLE `khachhang` (
  `ID_KhachHang` varchar(255) NOT NULL,
  `TenKH` varchar(255) DEFAULT NULL,
  `DiaChiKH` varchar(255) DEFAULT NULL,
  `SDT` varchar(255) DEFAULT NULL,
  `TichDiem` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `khachhang`
--

INSERT INTO `khachhang` (`ID_KhachHang`, `TenKH`, `DiaChiKH`, `SDT`, `TichDiem`) VALUES
('KH001', 'Lê Hoài Nam', '123 Đường ABC, Quận 1, TP.HCM', '0901234567', 100),
('KH002', 'Lê Trung Kiên', '456 Đường XYZ, Quận 2, TP.HCM', '0912345678', 200),
('KH003', 'Trần Xuân Danh', '789 Đường DEF, Quận 3, TP.HCM', '0923456789', 150),
('KH004', 'Trần Khánh Duy', '321 Đường GHI, Quận 4, TP.HCM', '0934567890', 300),
('KH005', 'Lê Thị Lan Hương', '654 Đường JKL, Quận 5, TP.HCM', '0945678901', 50);

-- --------------------------------------------------------

--
-- Table structure for table `khuyenmai`
--

CREATE TABLE `khuyenmai` (
  `ID_KhuyenMai` varchar(255) NOT NULL,
  `TenKhuyenMai` varchar(255) DEFAULT NULL,
  `MucGiamGia` int(11) DEFAULT NULL,
  `MoTaKM` varchar(255) DEFAULT NULL,
  `ThoiGianBatDau` datetime DEFAULT NULL,
  `ThoiGianKetThuc` datetime DEFAULT NULL,
  `ThoiGianTaoKM` datetime DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `khuyenmai`
--

INSERT INTO `khuyenmai` (`ID_KhuyenMai`, `TenKhuyenMai`, `MucGiamGia`, `MoTaKM`, `ThoiGianBatDau`, `ThoiGianKetThuc`, `ThoiGianTaoKM`) VALUES
('KM001', 'Giảm giá mùa hè', 10, 'Giảm 10% cho tất cả sản phẩm', '2024-06-01 00:00:00', '2024-06-30 00:00:00', '2024-10-01 17:52:11'),
('KM002', 'Khuyến mãi 20%', 20, 'Giảm 20% cho đơn hàng từ 1 triệu', '2024-07-01 00:00:00', '2024-07-15 00:00:00', '2024-10-01 17:52:11'),
('KM003', 'Khuyến mãi mua 1 tặng 1', 50, 'Mua 1 sản phẩm bất kỳ tặng 1 sản phẩm cùng loại', '2024-07-16 00:00:00', '2024-08-15 00:00:00', '2024-10-01 17:52:11'),
('KM004', 'Giảm giá học sinh, sinh viên', 15, 'Giảm 15% cho học sinh, sinh viên xuất trình thẻ', '2024-08-01 00:00:00', '2024-08-31 00:00:00', '2024-10-01 17:52:11'),
('KM005', 'Khuyến mãi cuối năm', 25, 'Giảm giá 25% cho các sản phẩm vào dịp Tết', '2024-12-01 00:00:00', '2025-01-01 00:00:00', '2024-10-01 17:52:11');

-- --------------------------------------------------------

--
-- Table structure for table `loai_laptop`
--

CREATE TABLE `loai_laptop` (
  `IDLaptop` varchar(255) NOT NULL,
  `TenSP` varchar(255) DEFAULT NULL,
  `GiaBan` bigint(20) DEFAULT NULL,
  `Hang` varchar(255) DEFAULT NULL,
  `CPU` varchar(255) DEFAULT NULL,
  `RAM` int(11) DEFAULT NULL,
  `GPU` varchar(255) DEFAULT NULL,
  `HinhAnh` varchar(255) DEFAULT NULL,
  `KichThuoc` varchar(255) DEFAULT NULL,
  `KhuyenMai` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `loai_laptop`
--

INSERT INTO `loai_laptop` (`IDLaptop`, `TenSP`, `GiaBan`, `Hang`, `CPU`, `RAM`, `GPU`, `HinhAnh`, `KichThuoc`, `KhuyenMai`) VALUES
('1', 'Dell XPS 13', 25000000, '1', 'Intel Core i7', 16, 'NVIDIA GeForce MX150', 'dell_xps_13.jpg', '13.3 inches', 'KM001'),
('2', 'MacBook Air', 30000000, '2', 'Apple M1', 8, 'Apple Integrated', 'macbook_air.jpg', '13.3 inches', 'KM002'),
('3', 'Asus ROG Zephyrus', 45000000, '3', 'AMD Ryzen 7', 16, 'NVIDIA GeForce GTX 1660 Ti', 'rog_zephyrus.jpg', '15.6 inches', 'KM003'),
('4', 'HP Spectre x360', 35000000, '4', 'Intel Core i5', 16, 'Intel Integrated', 'hp_spectre_x360.jpg', '13.3 inches', 'KM004'),
('5', 'Lenovo ThinkPad X1', 40000000, '5', 'Intel Core i7', 16, 'NVIDIA GeForce MX250', 'lenovo_thinkpad_x1.jpg', '14 inches', 'KM005');

-- --------------------------------------------------------

--
-- Table structure for table `nhanvien`
--

CREATE TABLE `nhanvien` (
  `ID_NhanVien` varchar(255) NOT NULL,
  `TenNV` varchar(255) DEFAULT NULL,
  `NgaySinh` varchar(255) DEFAULT NULL,
  `SDT` varchar(255) DEFAULT NULL,
  `DiaChi` varchar(255) DEFAULT NULL,
  `GioiTinh` tinyint(1) DEFAULT NULL,
  `CCCD` varchar(255) DEFAULT NULL,
  `Email` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `nhanvien`
--

INSERT INTO `nhanvien` (`ID_NhanVien`, `TenNV`, `NgaySinh`, `SDT`, `DiaChi`, `GioiTinh`, `CCCD`, `Email`) VALUES
('NV001', 'Nguyễn Văn A', '1990-01-15', '0901234567', '123 Đường A, Quận 1, TP.HCM', 0, '123456789012', 'nvA@example.com'),
('NV002', 'Trần Thị B', '1995-05-20', '0912345678', '456 Đường B, Quận 2, TP.HCM', 0, '234567890123', 'nvB@example.com'),
('NV003', 'Lê Văn C', '1988-12-30', '0923456789', '789 Đường C, Quận 3, TP.HCM', 0, '345678901234', 'nvC@example.com'),
('NV004', 'Phạm Thị D', '1992-03-25', '0934567890', '321 Đường D, Quận 4, TP.HCM', 0, '456789012345', 'nvD@example.com'),
('NV005', 'Nguyễn Văn E', '1985-07-10', '0945678901', '654 Đường E, Quận 5, TP.HCM', 0, '567890123456', 'nvE@example.com');

-- --------------------------------------------------------

--
-- Table structure for table `phieunhap`
--

CREATE TABLE `phieunhap` (
  `ID_PhieuNhap` bigint(20) NOT NULL,
  `ID_NhanVien` varchar(255) DEFAULT NULL,
  `ID_NCC` varchar(255) DEFAULT NULL,
  `NgayNhap` datetime DEFAULT NULL,
  `TongTien` bigint(20) DEFAULT NULL,
  `TienTra` bigint(20) DEFAULT NULL,
  `TienThoi` bigint(20) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `phieunhap`
--

INSERT INTO `phieunhap` (`ID_PhieuNhap`, `ID_NhanVien`, `ID_NCC`, `NgayNhap`, `TongTien`, `TienTra`, `TienThoi`) VALUES
(1, 'NV001', '1', '2024-09-25 00:00:00', 10000000, 8000000, 2000000),
(2, 'NV002', '2', '2024-09-26 00:00:00', 15000000, 12000000, 3000000),
(3, 'NV003', '3', '2024-09-27 00:00:00', 20000000, 15000000, 5000000),
(4, 'NV004', '4', '2024-09-28 00:00:00', 25000000, 20000000, 5000000),
(5, 'NV005', '5', '2024-09-29 00:00:00', 30000000, 25000000, 5000000);

-- --------------------------------------------------------

--
-- Table structure for table `quyen`
--

CREATE TABLE `quyen` (
  `ID_Quyen` varchar(255) NOT NULL,
  `ChiTietQuyen` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `quyen`
--

INSERT INTO `quyen` (`ID_Quyen`, `ChiTietQuyen`) VALUES
('001', 'user'),
('002', 'admin');

-- --------------------------------------------------------

--
-- Table structure for table `taikhoan`
--

CREATE TABLE `taikhoan` (
  `TenDN` varchar(255) NOT NULL,
  `MatKhau` varchar(255) DEFAULT NULL,
  `Quyen` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `taikhoan`
--

INSERT INTO `taikhoan` (`TenDN`, `MatKhau`, `Quyen`) VALUES
('NV001', '123456', '001'),
('NV002', '123', '002');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `chitiethoadon`
--
ALTER TABLE `chitiethoadon`
  ADD PRIMARY KEY (`ID_SP`,`ID_HoaDon`),
  ADD UNIQUE KEY `ID_HoaDon` (`ID_HoaDon`);

--
-- Indexes for table `chitietphieunhap`
--
ALTER TABLE `chitietphieunhap`
  ADD PRIMARY KEY (`ID_SP`,`ID_PhieuNhap`),
  ADD UNIQUE KEY `ID_PhieuNhap` (`ID_PhieuNhap`);

--
-- Indexes for table `hang`
--
ALTER TABLE `hang`
  ADD PRIMARY KEY (`ID_Hang`),
  ADD UNIQUE KEY `ID_Hang` (`ID_Hang`);

--
-- Indexes for table `hoadon`
--
ALTER TABLE `hoadon`
  ADD PRIMARY KEY (`ID_HoaDon`),
  ADD UNIQUE KEY `ID_HoaDon` (`ID_HoaDon`),
  ADD KEY `MaNV` (`MaNV`),
  ADD KEY `MaKH` (`MaKH`);

--
-- Indexes for table `khachhang`
--
ALTER TABLE `khachhang`
  ADD PRIMARY KEY (`ID_KhachHang`),
  ADD UNIQUE KEY `ID_KhachHang` (`ID_KhachHang`);

--
-- Indexes for table `khuyenmai`
--
ALTER TABLE `khuyenmai`
  ADD PRIMARY KEY (`ID_KhuyenMai`),
  ADD UNIQUE KEY `ID_KhuyenMai` (`ID_KhuyenMai`);

--
-- Indexes for table `loai_laptop`
--
ALTER TABLE `loai_laptop`
  ADD PRIMARY KEY (`IDLaptop`),
  ADD UNIQUE KEY `ID_Loai` (`IDLaptop`),
  ADD KEY `Hang` (`Hang`),
  ADD KEY `KhuyenMai` (`KhuyenMai`);

--
-- Indexes for table `nhanvien`
--
ALTER TABLE `nhanvien`
  ADD PRIMARY KEY (`ID_NhanVien`),
  ADD UNIQUE KEY `ID_NhanVien` (`ID_NhanVien`);

--
-- Indexes for table `phieunhap`
--
ALTER TABLE `phieunhap`
  ADD PRIMARY KEY (`ID_PhieuNhap`),
  ADD UNIQUE KEY `ID_PhieuNhap` (`ID_PhieuNhap`),
  ADD KEY `ID_NhanVien` (`ID_NhanVien`),
  ADD KEY `ID_NCC` (`ID_NCC`);

--
-- Indexes for table `quyen`
--
ALTER TABLE `quyen`
  ADD PRIMARY KEY (`ID_Quyen`),
  ADD UNIQUE KEY `ID_Quyen` (`ID_Quyen`);

--
-- Indexes for table `taikhoan`
--
ALTER TABLE `taikhoan`
  ADD PRIMARY KEY (`TenDN`),
  ADD UNIQUE KEY `TenDN` (`TenDN`),
  ADD KEY `Quyen` (`Quyen`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `chitiethoadon`
--
ALTER TABLE `chitiethoadon`
  MODIFY `ID_HoaDon` bigint(20) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `hoadon`
--
ALTER TABLE `hoadon`
  MODIFY `ID_HoaDon` bigint(20) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `phieunhap`
--
ALTER TABLE `phieunhap`
  MODIFY `ID_PhieuNhap` bigint(20) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `chitiethoadon`
--
ALTER TABLE `chitiethoadon`
  ADD CONSTRAINT `chitiethoadon_ibfk_1` FOREIGN KEY (`ID_HoaDon`) REFERENCES `hoadon` (`ID_HoaDon`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `chitiethoadon_ibfk_2` FOREIGN KEY (`ID_SP`) REFERENCES `loai_laptop` (`IDLaptop`);

--
-- Constraints for table `chitietphieunhap`
--
ALTER TABLE `chitietphieunhap`
  ADD CONSTRAINT `chitietphieunhap_ibfk_2` FOREIGN KEY (`ID_PhieuNhap`) REFERENCES `phieunhap` (`ID_PhieuNhap`),
  ADD CONSTRAINT `chitietphieunhap_ibfk_3` FOREIGN KEY (`ID_SP`) REFERENCES `loai_laptop` (`IDLaptop`);

--
-- Constraints for table `hoadon`
--
ALTER TABLE `hoadon`
  ADD CONSTRAINT `hoadon_ibfk_1` FOREIGN KEY (`MaNV`) REFERENCES `nhanvien` (`ID_NhanVien`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `hoadon_ibfk_2` FOREIGN KEY (`MaKH`) REFERENCES `khachhang` (`ID_KhachHang`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Constraints for table `loai_laptop`
--
ALTER TABLE `loai_laptop`
  ADD CONSTRAINT `loai_laptop_ibfk_1` FOREIGN KEY (`Hang`) REFERENCES `hang` (`ID_Hang`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `loai_laptop_ibfk_2` FOREIGN KEY (`KhuyenMai`) REFERENCES `khuyenmai` (`ID_KhuyenMai`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Constraints for table `phieunhap`
--
ALTER TABLE `phieunhap`
  ADD CONSTRAINT `phieunhap_ibfk_1` FOREIGN KEY (`ID_NhanVien`) REFERENCES `nhanvien` (`ID_NhanVien`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `phieunhap_ibfk_2` FOREIGN KEY (`ID_NCC`) REFERENCES `hang` (`ID_Hang`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Constraints for table `taikhoan`
--
ALTER TABLE `taikhoan`
  ADD CONSTRAINT `taikhoan_ibfk_1` FOREIGN KEY (`TenDN`) REFERENCES `nhanvien` (`ID_NhanVien`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `taikhoan_ibfk_2` FOREIGN KEY (`Quyen`) REFERENCES `quyen` (`ID_Quyen`) ON DELETE NO ACTION ON UPDATE NO ACTION;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
