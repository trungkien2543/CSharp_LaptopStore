using CSharp_laptop.DAO;
using LaptopStore.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_laptop.BUS
{
    internal class LoaiLaptopBUS
    {
        private LoaiLaptopDAO laptopDAO = new LoaiLaptopDAO();

        public List<LoaiLaptopDTO> GetLaptops()
        {
            return laptopDAO.GetAllLaptops();
        }

        public LoaiLaptopDTO GetLaptopByID(string idLaptop)
        {
            return laptopDAO.GetLaptopByID(idLaptop);  // Gọi phương thức từ DAO
        }


        public bool AddLaptop(LoaiLaptopDTO laptop)
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

        public long GetNextID()
        {
            return laptopDAO.GetNextID();
        }

        public bool UpdateLaptop(LoaiLaptopDTO laptop)
        {
            if (string.IsNullOrEmpty(laptop.TenSP) || laptop.GiaBan <= 0)
            {
                return false;
            }
            return laptopDAO.UpdateLoaiLaptop(laptop);
        }

        public DataTable SearchLaptop(string searchTerm)
        {
            return laptopDAO.SearchLaptop(searchTerm);
        }
    }
}
