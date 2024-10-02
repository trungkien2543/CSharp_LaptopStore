using CSharp_laptop.DAO;
using LaptopStore.DTO;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_laptop.BUS
{
    internal class SanPhamBUS
    {
        private SanPhamDAO laptopDAO = new SanPhamDAO();

        public List<SanPhamDTO> GetLaptops()
        {
            return laptopDAO.GetAllLaptops();
        }

        public SanPhamDTO GetLaptopByID(string idLaptop)
        {
            return laptopDAO.GetLaptopByID(idLaptop);  // Gọi phương thức từ DAO
        }


        public bool AddLaptop(SanPhamDTO laptop)
        {

            

            if (string.IsNullOrEmpty(laptop.TenSP) || laptop.GiaBan <= 0)
            {
                return false; 
            }
            return laptopDAO.InsertLoaiLaptop(laptop); 
        }

        public bool DeleteLaptop(string idLaptop)
        {
            return laptopDAO.DeleteLaptop(idLaptop);
        }
    }
}
