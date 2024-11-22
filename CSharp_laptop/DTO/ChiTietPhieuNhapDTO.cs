using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_laptop.DTO
{
    internal class ChiTietPhieuNhapDTO
    {
        public string IMEI { get; set; }
        public string IDLoaiLaptop { get; set; }
        public int GiaNhap { get; set; }
        public int ThoiGianBaoHanh { get; set; }

        public ChiTietPhieuNhapDTO()
        {
        }

        public ChiTietPhieuNhapDTO(string iMEI, string iDLoaiLaptop, int giaNhap, int thoiGianBaoHanh)
        {
            IMEI = iMEI;
            IDLoaiLaptop = iDLoaiLaptop;
            GiaNhap = giaNhap;
            ThoiGianBaoHanh = thoiGianBaoHanh;
        }
    }
}
