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
        private LoaiLaptopDAO loailaptopDAO = new LoaiLaptopDAO();

        public List<LoaiLaptopDTO> GetLaptops()
        {
            return loailaptopDAO.GetAllLaptops();
        }

        public LoaiLaptopDTO GetLaptopByID(string idLaptop)
        {
            return loailaptopDAO.GetLaptopByID(idLaptop);  // Gọi phương thức từ DAO
        }


        public bool AddLaptop(LoaiLaptopDTO laptop)
        {
            if (string.IsNullOrEmpty(laptop.TenSP) || laptop.GiaBan <= 0)
            {
                return false; 
            }
            return loailaptopDAO.InsertLoaiLaptop(laptop); 
        }

        public bool DeleteLaptop(string idLaptop)
        {
            return loailaptopDAO.DeleteLaptop(idLaptop);
        }

        public long GetNextID()
        {
            return loailaptopDAO.GetNextID();
        }

        public bool UpdateLaptop(LoaiLaptopDTO laptop)
        {
            if (string.IsNullOrEmpty(laptop.TenSP) || laptop.GiaBan <= 0)
            {
                return false;
            }
            return loailaptopDAO.UpdateLoaiLaptop(laptop);
        }

        public bool CheckIfIDExists(string idLoaiLaptop)
        {
            return loailaptopDAO.CheckIfIDExists(idLoaiLaptop);
        }


        public DataTable SearchLaptop(string searchTerm)
        {
            return loailaptopDAO.SearchLaptop(searchTerm);
        }

        public List<String> getValueForComboBox(string searchItem){ 
            return loailaptopDAO.searchForComboBox(searchItem);
        }
    }
}
