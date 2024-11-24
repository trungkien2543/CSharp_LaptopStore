using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_laptop.DTO
{
    public class ChiTietHoaDonDTO
    {
        public string IMEI { get; set; }
        public long ID_HoaDon { get; set; }
        public long GiaBan { get; set; }

        public ChiTietHoaDonDTO() { }

        public ChiTietHoaDonDTO(string imei, long id_HoaDon, long giaBan)
        {
            IMEI = imei;
            ID_HoaDon = id_HoaDon;
            GiaBan = giaBan;
        }
    }

}
