using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_laptop.DTO
{
    internal class NhanVienDTO
    {
        public string ID_NhanVien { get; set; }
        public string TenNV { get; set; }
        public string NgaySinh { get; set; }
        public string SDT { get; set; }
        public string DiaChi { get; set; }
        public bool GioiTinh { get; set; }
        public string CCCD { get; set; }
        public string Email { get; set; }

        public NhanVienDTO() { }

        public NhanVienDTO(string idNhanVien, string tenNV, string ngaySinh, string sdt, string diaChi, bool gioiTinh, string cccd, string email)
        {
            ID_NhanVien = idNhanVien;
            TenNV = tenNV;
            NgaySinh = ngaySinh;
            SDT = sdt;
            DiaChi = diaChi;
            GioiTinh = gioiTinh;
            CCCD = cccd;
            Email = email;
        }
    }
}
