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
        public int GiaNhap { get; set; }
        public string IDPN { get; set; }

        public ChiTietPhieuNhapDTO()
        {
        }

        public ChiTietPhieuNhapDTO(string iMEI, int giaNhap, string iDPN)
        {
            IMEI = iMEI;
            GiaNhap = giaNhap;
            IDPN = iDPN;
        }
    }
}
