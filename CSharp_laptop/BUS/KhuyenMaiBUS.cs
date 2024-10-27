using CSharp_laptop.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
