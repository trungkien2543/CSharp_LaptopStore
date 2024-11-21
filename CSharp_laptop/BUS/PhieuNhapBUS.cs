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

        public int GetMaxID()
        {
            return phieuNhapDAO.GetMaxID();
        }
        public BindingList<PhieuNhapDTO> GetAllPhieuNhap()
        {
            return phieuNhapDAO.GetAllPhieuNhap();
        }

        public bool AddPhieuNhap(int idPN, PhieuNhapDTO phieuNhap, BindingList<ChiTietPhieuNhapDTO> ctpnArr)
        {
            bool isSuccess = false;
            if (phieuNhapDAO.AddPhieuNhap(phieuNhap)) isSuccess = true;
            else isSuccess = false;

            for (int i = 0; i < ctpnArr.Count; i++)
            {
                ChiTietPhieuNhapDTO ctpn = new ChiTietPhieuNhapDTO()
                {
                    IMEI = ctpnArr[i].IMEI,
                    IDLoaiLaptop = ctpnArr[i].IDLoaiLaptop,
                    GiaNhap = ctpnArr[i].GiaNhap
                };
                if (phieuNhapDAO.AddCTPhieuNhapi(idPN, ctpn)) isSuccess = true;
                else isSuccess = false;
            }
            return isSuccess;
        }

    }
}
