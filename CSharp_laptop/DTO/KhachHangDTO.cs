using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_laptop.DTO
{
    internal class KhachHangDTO
    {
        public string ID_KhachHang { get; set; }
        public string TenKH { get; set; }
        public string DiaChiKH { get; set; }
        public string SDT { get; set; }
        public int TichDiem { get; set; }

        public KhachHangDTO() { }

        public KhachHangDTO(string idKhachHang, string tenKH, string diaChiKH, string sdt, int tichDiem)
        {
            ID_KhachHang = idKhachHang;
            TenKH = tenKH;
            DiaChiKH = diaChiKH;
            SDT = sdt;
            TichDiem = tichDiem;
        }
    }
}
