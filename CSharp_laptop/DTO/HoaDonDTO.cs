using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_laptop.DTO
{
    public class HoaDonDTO
    {
        public long ID_HoaDon { get; set; }
        public string MaNV { get; set; }
        public string MaKH { get; set; }
        public DateTime? NgayLap { get; set; }
        public long? TongTien { get; set; }

        public HoaDonDTO() { }

        public HoaDonDTO(long id_HoaDon, string? maNV, string? maKH, DateTime? ngayLap, long? tongTien)
        {
            ID_HoaDon = id_HoaDon;
            MaNV = maNV;
            MaKH = maKH;
            NgayLap = ngayLap;
            TongTien = tongTien;
        }
    }

}
