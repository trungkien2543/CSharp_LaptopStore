using CSharp_laptop.DAO;
using CSharp_laptop.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
