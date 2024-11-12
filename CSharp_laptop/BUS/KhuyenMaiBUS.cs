using CSharp_laptop.DAO;
using CSharp_laptop.DTO;
using System;
using System.Collections.Generic;
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
        public List<KhuyenMaiDTO> getKhuyenMaiArr()
        {
            return khuyenMaiDAO.GetKhuyenMaiArr();
        }
        public bool AddKhachHang(KhuyenMaiDTO khuyenMai)
        {
            return khuyenMaiDAO.AddKhuyenMai(khuyenMai);
        }
    }
}
