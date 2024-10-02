using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_laptop.DTO
{
    internal class TaiKhoanDTO
    {
        public string TenDN { get; set; }
        public string MatKhau { get; set; }
        public string Quyen { get; set; }

        public TaiKhoanDTO(string tenDN, string matKhau, string quyen)
        {
            TenDN = tenDN;
            MatKhau = matKhau;
            Quyen = quyen;
        }

        public TaiKhoanDTO()
        {
        }
    }
}
