using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_laptop.DTO
{
    internal class PhieuNhapDTO
    {
        public int ID { get; set; }
        public string IDNV { get; set; }
        public string IDNCC { get; set; }
        public int TongTien { get; set; }
        public DateTime NgayTao { get; set; }

        public PhieuNhapDTO()
        {
        }

        public PhieuNhapDTO(int iD, string iDNV, string iDNCC, int tongTien, DateTime ngayTao)
        {
            ID = iD;
            IDNV = iDNV;
            IDNCC = iDNCC;
            TongTien = tongTien;
            NgayTao = ngayTao;
        }
    }
}
