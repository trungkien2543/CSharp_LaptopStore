using CSharp_laptop.DAO;
using CSharp_laptop.DTO;
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

        public List<TaiKhoanDTO> GetAllTaiKhoan()
        {
            return dao.GetAllTaiKhoan();
        }
    }
}
