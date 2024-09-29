using System;

namespace LaptopStore.DTO
{
    public class ChiTietLaptopDTO
    {
        public string MaSP { get; set; }
        public long GiaNhap { get; set; }
        public DateTime NgayBan { get; set; }
        public string LoaiLaptop { get; set; }

        // Constructor
        public ChiTietLaptopDTO() { }

        public ChiTietLaptopDTO(string maSP, long giaNhap, DateTime ngayBan, string loaiLaptop)
        {
            MaSP = maSP;
            GiaNhap = giaNhap;
            NgayBan = ngayBan;
            LoaiLaptop = loaiLaptop;
        }
    }

}