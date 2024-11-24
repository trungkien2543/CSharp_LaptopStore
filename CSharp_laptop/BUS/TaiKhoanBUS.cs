using CSharp_laptop.DAO;
using CSharp_laptop.DTO;
using LaptopStore.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_laptop.BUS
{
    internal class TaiKhoanBUS
    {
        private TaiKhoanDAO dao= new TaiKhoanDAO();

        public TaiKhoanBUS()
        {

        }
        public bool AddTaiKhoan(TaiKhoanDTO tk)
        {
            if (string.IsNullOrEmpty(tk.TenDN))
            {
                return false;
            }
            return dao.AddTaiKhoan(tk);
        }
        public bool SuaTK(TaiKhoanDTO tk)
        {
            if (string.IsNullOrEmpty(tk.TenDN))
            {
                return false;
            }
            return dao.SuaTK(tk);
        }
        public List<TaiKhoanDTO> GetAllTaiKhoan()
        {
            return dao.GetAllTaiKhoan();
        }
        public Dictionary<string, string> GetAllQuyen()
        {
            return dao.GetAllQuyen();
        }
        public bool XoaTaiKhoan(string tenDN)
        {
            try
            {
                return dao.XoaTaiKhoan(tenDN); // Gọi DAO để xóa tài khoản
            }
            catch (Exception ex)
            {
                // Nếu có lỗi trong quá trình xóa tài khoản
                Console.WriteLine("Error: " + ex.Message);
                return false;
            }
        }
    }
}
