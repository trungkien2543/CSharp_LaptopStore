using CSharp_laptop.DAO;
using CSharp_laptop.DTO;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_laptop.BUS
{
    internal class KhachHangBUS
    {
        private KhachHangDAO dao;
        public KhachHangBUS()
        {
            dao = new KhachHangDAO();
        } 

        public List<KhachHangDTO> getAllKhachHang()
        {
            return dao.GetAllKhachHang();
        }
        public bool AddKhachHang(KhachHangDTO kh)
        {
            return dao.AddKhachHang(kh);
        }

        public KhachHangDTO findKhachHang(String SDT)
        {
            return dao.GetKhachHangBySDT(SDT);
        }

        public bool DeleteKhachHang(string idKhachHang)
        {
            return dao.DeleteKhachHang(idKhachHang);
        }
    }
}
