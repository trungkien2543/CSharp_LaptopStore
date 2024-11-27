using CSharp_laptop.DAO;
using CSharp_laptop.DTO;
using LaptopStore.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        public bool AddPhieuNhap(PhieuNhapDTO phieuNhap, BindingList<ChiTietPhieuNhapDTO> ctpnArr, BindingList<LoaiLapPnDTO> llt)
        {
            bool isSuccess = false;
            if (phieuNhapDAO.AddPhieuNhap(phieuNhap)) isSuccess = true;
            else isSuccess = false;

            for (int i = 0; i < ctpnArr.Count; i++)
            {
                if (phieuNhapDAO.AddCTPhieuNhapi(phieuNhap.ID, ctpnArr[i])) isSuccess = true;
                else isSuccess = false;
            }

            for (int i = 0; i < llt.Count; i++)
            {
                phieuNhapDAO.UpdateSoLuongSP(llt[i]);
            }

            return isSuccess;
        }

        public bool CheckIMEI(string imei)
        {
            return phieuNhapDAO.CheckIMEI(imei);
        }

        //public bool CheckSPPN(int id)
        //{
        //    return phieuNhapDAO.CheckSPPN(id);
        //}

        public PhieuNhapDTO GetPhieuNhapByID(int id)
        {
            return phieuNhapDAO.Get1PhieuNhapByID(id);
        }

        public BindingList<ChiTietPhieuNhapDTO> GetChiTietPhieuNhap1(int id)
        {
            return phieuNhapDAO.GetChiTietPhieuNhap1(id);
        }

        public BindingList<LoaiLapPnDTO> GetChiTietPhieuNhap2(int id)
        {
            return phieuNhapDAO.GetChiTietPhieuNhap2(id);
        }

        public BindingList<PhieuNhapDTO> TimKiem(string searchTerm)
        {
            return phieuNhapDAO.TimKiem(searchTerm);
        }
    }
}
