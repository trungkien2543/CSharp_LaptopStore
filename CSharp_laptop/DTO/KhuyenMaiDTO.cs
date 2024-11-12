using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharp_laptop.DTO
{
    internal class KhuyenMaiDTO
    {
        public string IDKM { get; set; }
        public string TenKM { get; set; }
        public int MucGiamGia { get; set; }
        public string MoTa { get; set; }
        public DateTime ThoiGianBatDau { get; set; }
        public DateTime ThoiGianKetThuc { get; set; }
        public DateTime NgayTao { get; set; }
                
        public KhuyenMaiDTO()
        {
        }
        public KhuyenMaiDTO(string idKM, string tenKM, int mucGiamGia, string moTa, DateTime thoiGianBatDau, DateTime thoiGianKetThuc, DateTime ngayTao)
        {
            this.IDKM = idKM;
            this.TenKM = tenKM;
            this.MucGiamGia = mucGiamGia;
            this.MoTa = moTa;
            this.ThoiGianBatDau = thoiGianBatDau;
            this.ThoiGianKetThuc = thoiGianKetThuc;
            this.NgayTao = ngayTao;
        }
    }
}
