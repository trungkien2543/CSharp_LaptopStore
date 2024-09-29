using System;

namespace LaptopStore.DTO
{
    public class HangDTO
    {
        public string ID_Hang { get; set; }
        public string TenHang { get; set; }
        public string DiaChi { get; set; }
        public string SDT { get; set; }

        // Constructor
        public HangDTO() { }

        public HangDTO(string idHang, string tenHang, string diaChi, string sdt)
        {
            ID_Hang = idHang;
            TenHang = tenHang;
            DiaChi = diaChi;
            SDT = sdt;
        }
    }



}