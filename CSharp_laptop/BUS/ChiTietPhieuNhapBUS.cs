using CSharp_laptop.DAO;
using CSharp_laptop.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_laptop.BUS
{
    internal class ChiTietPhieuNhapBUS
    {
        public ChiTietPhieuNhapDAO dao = new ChiTietPhieuNhapDAO();

        public ChiTietPhieuNhapBUS()
        {

        }


        public BindingList<ChiTietPhieuNhapDTO> GetChiTietPhieuNhapWithPhieuNhap(string find)
        {
            return dao.GetChiTietPhieuNhapWithPhieuNhap(find);

        }
    }


}
