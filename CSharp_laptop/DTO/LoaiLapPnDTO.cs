using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_laptop.DTO
{
    internal class LoaiLapPnDTO
    {
        public string IDLoaiLaptop {  get; set; }
        public string TenSanPham { get; set; }
        public int ThoiGianBaoHanh { get; set; }
        public int GiaNhap { get; set; }
        public int SoLuong { get; set; }
        public int ThanhTien { get; set; }

        public LoaiLapPnDTO()
        {
        }

        public LoaiLapPnDTO(string iDLoaiLaptop, string tenSanPham, int thoiGianBaoHanh, int giaNhap, int soLuong, int thanhTien)
        {
            IDLoaiLaptop = iDLoaiLaptop;
            TenSanPham = tenSanPham;
            ThoiGianBaoHanh = thoiGianBaoHanh;
            GiaNhap = giaNhap;
            SoLuong = soLuong;
            ThanhTien = thanhTien;
        }
    }
}
