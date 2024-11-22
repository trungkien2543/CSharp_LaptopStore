using CSharp_laptop.DAO;
using CSharp_laptop.DTO;
using System.Collections.Generic;

namespace CSharp_laptop.BUS
{
    

    public class ChiTietHoaDonBUS
    {
        private readonly ChiTietHoaDonDAO dao = new ChiTietHoaDonDAO();

        public List<ChiTietHoaDonDTO> GetAllChiTietHoaDon()
        {
            return dao.GetAllChiTietHoaDon();
        }
    }

}
