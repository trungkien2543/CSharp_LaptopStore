-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Nov 08, 2024 at 10:29 AM
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
-- Table structure for table `baohanh`
--

CREATE TABLE `baohanh` (
  `MaBaoHanh` bigint(20) NOT NULL,
  `IMEI` bigint(20) NOT NULL,
  `NgayBaoHanh` date NOT NULL,
  `NgayTra` date NOT NULL,
  `GhiChu` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `baohanh`
--

INSERT INTO `baohanh` (`MaBaoHanh`, `IMEI`, `NgayBaoHanh`, `NgayTra`, `GhiChu`) VALUES
(1, 123456789012345, '2024-10-01', '2024-10-05', 'Bảo hành bàn phím'),
(2, 123456789012346, '2024-10-02', '2024-10-06', 'Bảo hành màn hình'),
(3, 123456789012347, '2024-10-03', '2024-10-07', 'Bảo hành pin'),
(4, 123456789012348, '2024-10-04', '2024-10-08', 'Bảo hành ổ cứng'),
(5, 123456789012349, '2024-10-05', '2024-10-09', 'Bảo hành cổng USB'),
(6, 123456789012350, '2024-10-06', '2024-10-10', 'Bảo hành card đồ họa'),
(7, 123456789012351, '2024-10-07', '2024-10-11', 'Bảo hành RAM'),
(8, 123456789012352, '2024-10-08', '2024-10-12', 'Bảo hành Wi-Fi'),
(9, 123456789012353, '2024-10-09', '2024-10-13', 'Bảo hành âm thanh'),
(10, 123456789012354, '2024-10-10', '2024-10-14', 'Bảo hành quạt tản nhiệt');

-- --------------------------------------------------------

--
-- Table structure for table `chitiethoadon`
--

CREATE TABLE `chitiethoadon` (
  `IMEI` bigint(20) NOT NULL,
  `ID_HoaDon` bigint(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `chitiethoadon`
--

INSERT INTO `chitiethoadon` (`IMEI`, `ID_HoaDon`) VALUES
(123456789012345, 1001),
(123456789012346, 1002),
(123456789012347, 1003),
(123456789012348, 1004),
(123456789012349, 1005),
(123456789012350, 1006),
(123456789012351, 1007),
(123456789012352, 1008),
(123456789012353, 1009),
(123456789012354, 1010);

-- --------------------------------------------------------

--
-- Table structure for table `chitietphieunhap`
--

CREATE TABLE `chitietphieunhap` (
  `IMEI` bigint(20) NOT NULL,
  `ID_PhieuNhap` bigint(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `chitietphieunhap`
--

INSERT INTO `chitietphieunhap` (`IMEI`, `ID_PhieuNhap`) VALUES
(123456789012345, 1),
(123456789012346, 1),
(123456789012347, 2),
(123456789012348, 2),
(123456789012349, 3),
(123456789012350, 4),
(123456789012351, 5),
(123456789012352, 6),
(123456789012353, 7),
(123456789012354, 8);

-- --------------------------------------------------------

--
-- Table structure for table `hangsanxuat`
--

CREATE TABLE `hangsanxuat` (
  `ID_Hang` varchar(255) NOT NULL,
  `TenHang` varchar(255) NOT NULL,
  `DiaChi` varchar(255) NOT NULL,
  `SDT` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `hangsanxuat`
--

INSERT INTO `hangsanxuat` (`ID_Hang`, `TenHang`, `DiaChi`, `SDT`) VALUES
('H001', 'Dell', 'USA1234', '123456789'),
('H002', '2', '2', '2'),
('H003', 'Asus', 'Taiwan', '543216789'),
('H004', 'Acer', 'Taiwan', '987654123'),
('H005', 'Apple', 'USA123', '123987654'),
('H006', 'Lenovo', 'China', '654789321'),
('H007', 'MSI', 'Taiwan', '321654987'),
('H008', 'Samsung', 'Korea', '987321654'),
('H009', 'Toshiba', 'Japan', '321987654'),
('H010', 'Sony', 'Japan', '654123987');

-- --------------------------------------------------------

--
-- Table structure for table `hoadon`
--

CREATE TABLE `hoadon` (
  `ID_HoaDon` bigint(20) NOT NULL,
  `MaNV` varchar(255) DEFAULT NULL,
  `MaKH` varchar(255) DEFAULT NULL,
  `NgayLap` datetime DEFAULT NULL,
  `TongTien` bigint(20) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `hoadon`
--

INSERT INTO `hoadon` (`ID_HoaDon`, `MaNV`, `MaKH`, `NgayLap`, `TongTien`) VALUES
(1001, 'NV001', 'KH001', '2024-10-01 00:00:00', 30000000),
(1002, 'NV002', 'KH002', '2024-10-02 00:00:00', 28000000),
(1003, 'NV003', 'KH003', '2024-10-03 00:00:00', 26000000),
(1004, 'NV004', 'KH004', '2024-10-04 00:00:00', 22000000),
(1005, 'NV005', 'KH005', '2024-10-05 00:00:00', 33000000),
(1006, 'NV006', 'KH006', '2024-10-06 00:00:00', 31000000),
(1007, 'NV007', 'KH007', '2024-10-07 00:00:00', 35000000),
(1008, 'NV008', 'KH008', '2024-10-08 00:00:00', 29000000),
(1009, 'NV009', 'KH009', '2024-10-09 00:00:00', 24000000),
(1010, 'NV010', 'KH010', '2024-10-10 00:00:00', 38000000);

-- --------------------------------------------------------

--
-- Table structure for table `khachhang`
--

CREATE TABLE `khachhang` (
  `ID_KhachHang` varchar(255) NOT NULL,
  `TenKH` varchar(255) NOT NULL,
  `DiaChiKH` varchar(255) NOT NULL,
  `SDT` varchar(255) NOT NULL,
  `TichDiem` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `khachhang`
--

INSERT INTO `khachhang` (`ID_KhachHang`, `TenKH`, `DiaChiKH`, `SDT`, `TichDiem`) VALUES
('KH001', 'Nguyen Van A', 'Ha Noi', '0987654321', 100),
('KH002', 'Tran Thi B', 'Ho Chi Minh', '0912345678', 200),
('KH003', 'Le Van C', 'Da Nang', '0909876543', 150),
('KH004', 'Pham Thi D', 'Hai Phong', '0961234567', 180),
('KH005', 'Hoang Van E', 'Can Tho', '0976543210', 220),
('KH006', 'Bui Thi F', 'Hue', '0934567890', 250),
('KH007', 'Do Van G', 'Quang Ninh', '0945678901', 90),
('KH008', 'Nguyen Thi H', 'Binh Dinh', '0981234567', 300),
('KH009', 'Vu Van I', 'Ninh Binh', '0923456789', 120),
('KH010', 'Truong Thi J', 'Bac Ninh', '0919876543', 400);

-- --------------------------------------------------------

--
-- Table structure for table `khuyenmai`
--

CREATE TABLE `khuyenmai` (
  `ID_KhuyenMai` varchar(255) NOT NULL,
  `TenKhuyenMai` varchar(255) NOT NULL,
  `MucGiamGia` int(11) NOT NULL,
  `MoTaKM` varchar(255) NOT NULL,
  `ThoiGianBatDau` datetime NOT NULL,
  `ThoiGianKetThuc` datetime NOT NULL,
  `ThoiGianTaoKM` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `khuyenmai`
--

INSERT INTO `khuyenmai` (`ID_KhuyenMai`, `TenKhuyenMai`, `MucGiamGia`, `MoTaKM`, `ThoiGianBatDau`, `ThoiGianKetThuc`, `ThoiGianTaoKM`) VALUES
('KM001', 'Black Friday', 10, 'Giảm giá cuối năm', '2024-11-01 00:00:00', '2024-11-30 00:00:00', '2024-10-18 00:00:00'),
('KM002', 'Cyber Monday', 15, 'Giảm giá mua sắm online', '2024-12-01 00:00:00', '2024-12-05 00:00:00', '2024-10-18 00:00:00'),
('KM003', 'Summer Sale', 5, 'Giảm giá mùa hè', '2024-06-01 00:00:00', '2024-06-15 00:00:00', '2024-05-01 00:00:00'),
('KM004', 'New Year Sale', 20, 'Giảm giá Tết', '2024-12-25 00:00:00', '2025-01-05 00:00:00', '2024-12-01 00:00:00'),
('KM005', 'Back to School', 7, 'Giảm giá cho sinh viên', '2024-08-01 00:00:00', '2024-09-01 00:00:00', '2024-07-15 00:00:00'),
('KM006', 'End of Season Sale', 12, 'Giảm giá cuối mùa', '2024-09-01 00:00:00', '2024-09-15 00:00:00', '2024-08-01 00:00:00'),
('KM007', 'Loyalty Discount', 5, 'Giảm giá cho khách hàng thân thiết', '2024-01-01 00:00:00', '2024-12-31 00:00:00', '2024-01-01 00:00:00'),
('KM008', 'Valentine Sale', 8, 'Giảm giá Valentine', '2024-02-10 00:00:00', '2024-02-15 00:00:00', '2024-02-01 00:00:00'),
('KM009', 'Mid-Year Sale', 10, 'Giảm giá giữa năm', '2024-06-15 00:00:00', '2024-06-30 00:00:00', '2024-05-25 00:00:00'),
('KM010', 'Christmas Sale', 20, 'Giảm giá Giáng sinh', '2024-12-10 00:00:00', '2024-12-24 00:00:00', '2024-11-25 00:00:00');

-- --------------------------------------------------------

--
-- Table structure for table `laptop`
--

CREATE TABLE `laptop` (
  `IMEI` bigint(20) NOT NULL,
  `ThoiGianBaoHanh` bigint(20) NOT NULL,
  `TrangThai` bigint(20) NOT NULL,
  `LoaiLaptop` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `laptop`
--

INSERT INTO `laptop` (`IMEI`, `ThoiGianBaoHanh`, `TrangThai`, `LoaiLaptop`) VALUES
(123456789012345, 24, 1, 'L001'),
(123456789012346, 24, 1, 'L002'),
(123456789012347, 24, 1, 'L003'),
(123456789012348, 24, 1, 'L004'),
(123456789012349, 24, 1, 'L005'),
(123456789012350, 24, 1, 'L006'),
(123456789012351, 24, 1, 'L007'),
(123456789012352, 24, 1, 'L008'),
(123456789012353, 24, 1, 'L009'),
(123456789012354, 24, 1, 'L010');

-- --------------------------------------------------------

--
-- Table structure for table `loailaptop`
--

CREATE TABLE `loailaptop` (
  `IDLoaiLaptop` varchar(255) NOT NULL,
  `TenSP` varchar(255) NOT NULL,
  `GiaBan` bigint(20) NOT NULL,
  `Hang` varchar(255) NOT NULL,
  `CPU` varchar(255) NOT NULL,
  `RAM` int(11) NOT NULL,
  `GPU` varchar(255) NOT NULL,
  `HinhAnh` varchar(255) NOT NULL,
  `KichThuoc` varchar(255) NOT NULL,
  `KhuyenMai` varchar(255) NOT NULL,
  `SLTonKho` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `loailaptop`
--

INSERT INTO `loailaptop` (`IDLoaiLaptop`, `TenSP`, `GiaBan`, `Hang`, `CPU`, `RAM`, `GPU`, `HinhAnh`, `KichThuoc`, `KhuyenMai`, `SLTonKho`) VALUES
('L001', 'Dell XPS 1312', 30000000, 'H005', 'Intel i7', 16, '', 'xps13.jpg', '13 inch', 'KM001', 0),
('L002', 'HP Spectre x36012', 28000000, 'H004', 'Intel i5', 8, 'Intel Iris', 'spectrex360.jpg', '13.3 inch', 'KM001', 0),
('L003', 'Asus ZenBook', 26000000, 'H003', 'Intel i7', 16, 'NVIDIA MX250', 'zenbook.jpg', '14 inch', 'KM003', 0),
('L004', 'Acer Swift 3', 22000000, 'H004', 'Intel i5', 8, 'Intel UHD', 'swift3.jpg', '14 inch', 'KM004', 0),
('L005', 'Apple MacBook Air', 33000000, 'H001', 'Apple M1', 16, '', 'macbookair.jpg', '13.3 inch', 'KM001', 0),
('L006', 'Lenovo ThinkPad X1', 31000000, 'H006', 'Intel i7', 16, 'Intel Iris', 'thinkpadx1.jpg', '14 inch', 'KM006', 0),
('L007', 'MSI Prestige 14', 35000000, 'H007', 'Intel i7', 32, 'NVIDIA GTX 1650', 'prestige14.jpg', '14 inch', 'KM007', 0),
('L008', 'Samsung Galaxy Book', 29000000, 'H008', 'Intel i5', 16, 'Intel Iris', 'galaxybook.jpg', '15.6 inch', 'KM008', 0),
('L009', 'Toshiba Portege', 24000000, 'H001', 'Intel i5', 8, 'Intel UHD123', 'portege.jpg', '13.3 inch', 'KM001', 0),
('L010', 'Sony Vaio SX14', 38000000, 'H010', 'Intel i7', 16, 'Intel Iris', 'vaio.jpg', '14 inch', 'KM010', 0),
('L012', '123', 12, 'H004', '12', 123, '12', '', '13', 'KM008', 0),
('L12', 'test ảnh 123', 123, 'H001', '123', 123, '123123', 'C:\\Users\\PC\\OneDrive\\Hình ảnh\\WallPaper\\1.jpg', '123', 'KM001', 0);

-- --------------------------------------------------------

--
-- Table structure for table `nhanvien`
--

CREATE TABLE `nhanvien` (
  `ID_NhanVien` varchar(255) NOT NULL,
  `TenNV` varchar(255) NOT NULL,
  `NgaySinh` varchar(255) NOT NULL,
  `SDT` varchar(255) NOT NULL,
  `DiaChi` varchar(255) NOT NULL,
  `GioiTinh` tinyint(1) NOT NULL,
  `CCCD` varchar(255) NOT NULL,
  `Email` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `nhanvien`
--

INSERT INTO `nhanvien` (`ID_NhanVien`, `TenNV`, `NgaySinh`, `SDT`, `DiaChi`, `GioiTinh`, `CCCD`, `Email`) VALUES
('NV001', 'Nguyen Van A', '1990-01-01', '0987654321', 'Hanoi', 1, '123456789', 'vana@example.com'),
('NV002', 'Tran Thi B', '1992-05-05', '0987654322', 'HCM', 0, '123456788', 'tranb@example.com'),
('NV003', 'Le Van C', '1993-03-03', '0987654323', 'Danang', 1, '123456787', 'levanc@example.com'),
('NV004', 'Pham Thi D', '1994-04-04', '0987654324', 'Hue', 0, '123456786', 'phamd@example.com'),
('NV005', 'Hoang Van E', '1995-06-06', '0987654325', 'Can Tho', 1, '123456785', 'hoange@example.com'),
('NV006', 'Do Thi F', '1996-07-07', '0987654326', 'Nha Trang', 0, '123456784', 'dotf@example.com'),
('NV007', 'Ngo Van G', '1997-08-08', '0987654327', 'Hai Phong', 1, '123456783', 'ngog@example.com'),
('NV008', 'Duong Thi H', '1998-09-09', '0987654328', 'Ha Long', 0, '123456782', 'duongh@example.com'),
('NV009', 'Phan Van I', '1999-10-10', '0987654329', 'Quang Ngai', 1, '123456781', 'phanvi@example.com'),
('NV010', 'Vu Thi J', '2000-11-11', '0987654330', 'Vung Tau', 0, '123456780', 'vuthj@example.com');

-- --------------------------------------------------------

--
-- Table structure for table `phieunhap`
--

CREATE TABLE `phieunhap` (
  `ID_PhieuNhap` bigint(20) NOT NULL,
  `MaNV` varchar(255) NOT NULL,
  `MaNcc` varchar(255) NOT NULL,
  `NgayNhap` datetime NOT NULL,
  `TongTien` bigint(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `phieunhap`
--

INSERT INTO `phieunhap` (`ID_PhieuNhap`, `MaNV`, `MaNcc`, `NgayNhap`, `TongTien`) VALUES
(1, 'NV001', 'H001', '2024-01-01 08:00:00', 100000),
(2, 'NV002', 'H002', '2024-01-02 09:30:00', 200000),
(3, 'NV003', 'H003', '2024-01-03 10:15:00', 300000),
(4, 'NV004', 'H004', '2024-01-04 11:45:00', 150000),
(5, 'NV005', 'H005', '2024-01-05 13:00:00', 250000),
(6, 'NV006', 'H006', '2024-01-06 14:30:00', 400000),
(7, 'NV007', 'H007', '2024-01-07 15:15:00', 500000),
(8, 'NV008', 'H008', '2024-01-08 16:00:00', 350000),
(9, 'NV009', 'H009', '2024-01-09 17:30:00', 450000),
(10, 'NV010', 'H010', '2024-01-10 18:45:00', 600000);

-- --------------------------------------------------------

--
-- Table structure for table `quyen`
--

CREATE TABLE `quyen` (
  `ID_Quyen` varchar(255) NOT NULL,
  `ChiTietQuyen` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `quyen`
--

INSERT INTO `quyen` (`ID_Quyen`, `ChiTietQuyen`) VALUES
('Q1', 'Manager'),
('Q2', 'Staff');

-- --------------------------------------------------------

--
-- Table structure for table `taikhoan`
--

CREATE TABLE `taikhoan` (
  `TenDN` varchar(255) NOT NULL,
  `MatKhau` varchar(255) NOT NULL,
  `Quyen` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `taikhoan`
--

INSERT INTO `taikhoan` (`TenDN`, `MatKhau`, `Quyen`) VALUES
('NV001', 'password001', 'Q1'),
('NV002', 'password002', 'Q2'),
('Nv003', 'password003', 'Q2'),
('NV004', 'password001', 'Q1'),
('NV005', 'password002', 'Q2'),
('NV006', 'password003', 'Q1'),
('NV007', 'password004', 'Q2'),
('NV008', 'password005', 'Q2'),
('NV009', 'password006', 'Q1'),
('NV010', 'password007', 'Q2');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `baohanh`
--
ALTER TABLE `baohanh`
  ADD PRIMARY KEY (`MaBaoHanh`),
  ADD KEY `IMEI` (`IMEI`);

--
-- Indexes for table `chitiethoadon`
--
ALTER TABLE `chitiethoadon`
  ADD PRIMARY KEY (`IMEI`,`ID_HoaDon`),
  ADD KEY `ID_HoaDon` (`ID_HoaDon`);

--
-- Indexes for table `chitietphieunhap`
--
ALTER TABLE `chitietphieunhap`
  ADD PRIMARY KEY (`IMEI`,`ID_PhieuNhap`),
  ADD KEY `ID_PhieuNhap` (`ID_PhieuNhap`);

--
-- Indexes for table `hangsanxuat`
--
ALTER TABLE `hangsanxuat`
  ADD PRIMARY KEY (`ID_Hang`);

--
-- Indexes for table `hoadon`
--
ALTER TABLE `hoadon`
  ADD PRIMARY KEY (`ID_HoaDon`),
  ADD KEY `MaKH` (`MaKH`),
  ADD KEY `MaNV` (`MaNV`);

--
-- Indexes for table `khachhang`
--
ALTER TABLE `khachhang`
  ADD PRIMARY KEY (`ID_KhachHang`);

--
-- Indexes for table `khuyenmai`
--
ALTER TABLE `khuyenmai`
  ADD PRIMARY KEY (`ID_KhuyenMai`);

--
-- Indexes for table `laptop`
--
ALTER TABLE `laptop`
  ADD PRIMARY KEY (`IMEI`),
  ADD KEY `LoaiLaptop` (`LoaiLaptop`);

--
-- Indexes for table `loailaptop`
--
ALTER TABLE `loailaptop`
  ADD PRIMARY KEY (`IDLoaiLaptop`),
  ADD KEY `loailaptop_hang_foreign` (`Hang`),
  ADD KEY `KhuyenMai` (`KhuyenMai`);

--
-- Indexes for table `nhanvien`
--
ALTER TABLE `nhanvien`
  ADD PRIMARY KEY (`ID_NhanVien`);

--
-- Indexes for table `phieunhap`
--
ALTER TABLE `phieunhap`
  ADD PRIMARY KEY (`ID_PhieuNhap`),
  ADD KEY `ID_NhanVien` (`MaNV`),
  ADD KEY `ID_NCC` (`MaNcc`);

--
-- Indexes for table `quyen`
--
ALTER TABLE `quyen`
  ADD PRIMARY KEY (`ID_Quyen`);

--
-- Indexes for table `taikhoan`
--
ALTER TABLE `taikhoan`
  ADD PRIMARY KEY (`TenDN`),
  ADD KEY `Quyen` (`Quyen`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `baohanh`
--
ALTER TABLE `baohanh`
  MODIFY `MaBaoHanh` bigint(20) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT for table `hoadon`
--
ALTER TABLE `hoadon`
  MODIFY `ID_HoaDon` bigint(20) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=1011;

--
-- AUTO_INCREMENT for table `phieunhap`
--
ALTER TABLE `phieunhap`
  MODIFY `ID_PhieuNhap` bigint(20) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `baohanh`
--
ALTER TABLE `baohanh`
  ADD CONSTRAINT `baohanh_ibfk_1` FOREIGN KEY (`IMEI`) REFERENCES `chitiethoadon` (`IMEI`);

--
-- Constraints for table `chitiethoadon`
--
ALTER TABLE `chitiethoadon`
  ADD CONSTRAINT `chitiethoadon_ibfk_1` FOREIGN KEY (`IMEI`) REFERENCES `laptop` (`IMEI`),
  ADD CONSTRAINT `chitiethoadon_ibfk_2` FOREIGN KEY (`ID_HoaDon`) REFERENCES `hoadon` (`ID_HoaDon`);

--
-- Constraints for table `chitietphieunhap`
--
ALTER TABLE `chitietphieunhap`
  ADD CONSTRAINT `chitietphieunhap_ibfk_1` FOREIGN KEY (`IMEI`) REFERENCES `laptop` (`IMEI`),
  ADD CONSTRAINT `chitietphieunhap_ibfk_2` FOREIGN KEY (`ID_PhieuNhap`) REFERENCES `phieunhap` (`ID_PhieuNhap`);

--
-- Constraints for table `hoadon`
--
ALTER TABLE `hoadon`
  ADD CONSTRAINT `hoadon_ibfk_1` FOREIGN KEY (`MaKH`) REFERENCES `khachhang` (`ID_KhachHang`),
  ADD CONSTRAINT `hoadon_ibfk_2` FOREIGN KEY (`MaNV`) REFERENCES `nhanvien` (`ID_NhanVien`);

--
-- Constraints for table `laptop`
--
ALTER TABLE `laptop`
  ADD CONSTRAINT `laptop_ibfk_1` FOREIGN KEY (`LoaiLaptop`) REFERENCES `loailaptop` (`IDLoaiLaptop`);

--
-- Constraints for table `loailaptop`
--
ALTER TABLE `loailaptop`
  ADD CONSTRAINT `loailaptop_hang_foreign` FOREIGN KEY (`Hang`) REFERENCES `hangsanxuat` (`ID_Hang`),
  ADD CONSTRAINT `loailaptop_ibfk_1` FOREIGN KEY (`KhuyenMai`) REFERENCES `khuyenmai` (`ID_KhuyenMai`);

--
-- Constraints for table `phieunhap`
--
ALTER TABLE `phieunhap`
  ADD CONSTRAINT `phieunhap_ibfk_1` FOREIGN KEY (`MaNV`) REFERENCES `nhanvien` (`ID_NhanVien`),
  ADD CONSTRAINT `phieunhap_ibfk_2` FOREIGN KEY (`MaNcc`) REFERENCES `hangsanxuat` (`ID_Hang`);

--
-- Constraints for table `taikhoan`
--
ALTER TABLE `taikhoan`
  ADD CONSTRAINT `taikhoan_ibfk_1` FOREIGN KEY (`TenDN`) REFERENCES `nhanvien` (`ID_NhanVien`),
  ADD CONSTRAINT `taikhoan_ibfk_2` FOREIGN KEY (`Quyen`) REFERENCES `quyen` (`ID_Quyen`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
