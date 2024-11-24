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
        public int SoLuong { get; set; }

        public LoaiLapPnDTO()
        {
        }

        public LoaiLapPnDTO(string iDLoaiLaptop, string tenSanPham, int soLuong)
        {
            IDLoaiLaptop = iDLoaiLaptop;
            TenSanPham = tenSanPham;
            SoLuong = soLuong;
        }
    }
}
