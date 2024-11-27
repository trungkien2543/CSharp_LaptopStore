using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_laptop.DTO
{
    internal class ChiTietPhieuNhap
    {
        public string IMEI { get; set; }
        public string IDLoaiLaptop { get; set; }
        public int GiaNhap { get; set; }
        public int ThoiGianBaoHanh { get; set; }

        public ChiTietPhieuNhap()
        {
        }

        public ChiTietPhieuNhap(string iMEI, string iDLoaiLaptop, int giaNhap, int thoiGianBaoHanh)
        {
            IMEI = iMEI;
            IDLoaiLaptop = iDLoaiLaptop;
            GiaNhap = giaNhap;
            ThoiGianBaoHanh = thoiGianBaoHanh;
        }
    }
}
