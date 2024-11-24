using CSharp_laptop.DAO;
using CSharp_laptop.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_laptop.BUS
{
    internal class LaptopBUS
    {
        private LaptopDAO laptopDAO = new LaptopDAO();

        public List<LaptopDTO> GetLaptopsByLoai(string loaiLaptop)
        {
            return laptopDAO.GetAllLaptops(loaiLaptop);
        }

        public LaptopDTO GetLaptopByIMEI(string imei)
        {
            return laptopDAO.GetLaptopByIMEI(imei);
        }

        public long GetGiaBanByIMEI(string imei)
        {
            return laptopDAO.GetGiaBanByIMEI(imei) ;
        }

        public DataTable SearchLaptop(string searchTerm, string laptopID)
        {
            // Kiểm tra giá trị đầu vào nếu cần
            if (string.IsNullOrWhiteSpace(laptopID))
            {
                throw new ArgumentException("Laptop ID không được để trống.");
            }
            return laptopDAO.SearchLaptop(searchTerm, laptopID);
        }
    }
}
