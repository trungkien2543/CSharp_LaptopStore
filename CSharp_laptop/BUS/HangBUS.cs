using CSharp_laptop.DAO;
using LaptopStore.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_laptop.BUS
{
    internal class HangBUS
    {
        private HangDAO hangDAO = new HangDAO();

        public List<HangDTO> GetHangs()
        {
            return hangDAO.GetAllHangs();
        }
    }
}
