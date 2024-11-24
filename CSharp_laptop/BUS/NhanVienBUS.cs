using CSharp_laptop.DAO;
using CSharp_laptop.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_laptop.BUS
{
    internal class NhanVienBUS
    {
        private NhanVienDAO dao;

        public NhanVienBUS()
        {
            dao = new NhanVienDAO();
        }

        public List<NhanVienDTO> getAllNhanVien()
        {
            return dao.GetAllNhanVien();
        }
        public bool AddNhanVien(NhanVienDTO nhanvien)
        {
            return dao.AddNhanVien(nhanvien);
        }
        public bool DeleteNhanVien(string idNhanVien)
        {
            return dao.DeleteNhanVien(idNhanVien);
        }
        public NhanVienDTO FindNhanVienById(string idNhanVien)
        {
            return dao.FindNhanVienById(idNhanVien);
        }

        public bool UpdateNhanVien(NhanVienDTO nhanvien)
        {
            return dao.UpdateNhanVien(nhanvien);
        }

        public List<NhanVienDTO> SearchNhanVien(string searchTerm)
        {
            return dao.SearchNhanVien(searchTerm);
        }
        public List<string> GetNhanVienChuaCoTaiKhoan()
        {
            return dao.GetNhanVienChuaCoTaiKhoan();
        }

    }
}
