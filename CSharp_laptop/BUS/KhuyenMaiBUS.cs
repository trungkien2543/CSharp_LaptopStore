﻿using CSharp_laptop.DAO;
using CSharp_laptop.DTO;
using LaptopStore.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_laptop.BUS
{
    internal class KhuyenMaiBUS
    {
        private KhuyenMaiDAO khuyenMaiDAO;

        public KhuyenMaiBUS()
        {
            khuyenMaiDAO = new KhuyenMaiDAO();
        }

        public Dictionary<string, string> GetKhuyenMai()
        {
            return khuyenMaiDAO.GetAllKhuyenMai();
        }
        public BindingList<KhuyenMaiDTO> getKhuyenMaiArr()
        {
            return khuyenMaiDAO.GetKhuyenMaiArr();
        }
        
        public KhuyenMaiDTO Get1KhuyenMai(string id)
        {
            return khuyenMaiDAO.Get1KhuyenMai(id);
        }

        public string GetMaxID()
        {
            return khuyenMaiDAO.GetMaxID();
        }

        public bool AddorEditKhuyenMai(KhuyenMaiDTO khuyenMai, string funcion)
        {
            return khuyenMaiDAO.AddorEditKhuyenMai(khuyenMai, funcion);
        }

        public bool DeleteKhuyenMai(string id)
        {
            return khuyenMaiDAO.DeleteKhuyenMai(id);
        }

        public void KiemTraKhuyenMaiHetHan()
        {
            BindingList<KhuyenMaiDTO> l = khuyenMaiDAO.GetKhuyenMaiArr();
            for (int i = 0; i < l.Count; i++) 
            {
                DateTime today = DateTime.Now;
                DateTime thoiGianKetThucKM = l[i].ThoiGianKetThuc;
                if (today <= thoiGianKetThucKM)
                {
                    khuyenMaiDAO.KiemTraKhuyenMaiHetHan(l[i].IDKM);

                }
            }
        }

        public BindingList<KhuyenMaiDTO> TimKiem(string searchTerm)
        {
            return khuyenMaiDAO.TimKiem(searchTerm);
        }
    }
}
