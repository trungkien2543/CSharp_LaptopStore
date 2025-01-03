﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_laptop.DTO
{
    internal class BaoHanhDTO
    {
        public long MaBaoHanh { get; set; }
        public string IMEI { get; set; }
        public DateTime NgayBaoHanh { get; set; }
        public DateTime NgayTra { get; set; }
        public string GhiChu { get; set; }

        public BaoHanhDTO(string imei, DateTime ngayBaoHanh, DateTime ngayTra, string ghiChu)
        {
            IMEI = imei;
            NgayBaoHanh = ngayBaoHanh;
            NgayTra = ngayTra;
            GhiChu = ghiChu;
        }

        // Constructor mặc định
        public BaoHanhDTO()
        {
        }
    }
}
