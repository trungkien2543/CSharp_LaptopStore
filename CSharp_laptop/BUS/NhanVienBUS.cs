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
        private NhanVienDAO dao = new NhanVienDAO();

        public NhanVienBUS()
        {

        }

        public List<NhanVienDTO> getAllNhanVien()
        {
            return dao.GetAllNhanVien();
        }
    }
}
