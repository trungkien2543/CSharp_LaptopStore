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
    internal class PhieuNhapBUS
    {
        private PhieuNhapDAO phieuNhapDAO;
        public PhieuNhapBUS()
        {
            phieuNhapDAO = new PhieuNhapDAO();
        }

        public string GetMaxID()
        {
            return phieuNhapDAO.GetMaxID();
        }
        public BindingList<PhieuNhapDTO> GetAllPhieuNhap()
        {
            return phieuNhapDAO.GetAllPhieuNhap();
        }
    }
}
