using CSharp_laptop.DAO;
using CSharp_laptop.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_laptop.BUS
{
    internal class ChatgptLineBUS
    {
        ChatgptLineDAO dao;
        public ChatgptLineBUS() 
        { 
            dao = new ChatgptLineDAO();
        }
        public List<ChatgptLineDTO> GetAllLine()
        {
           return dao.GetAllLine();
        }

        public string ConcatAllLines()
        {
            return dao.ConcatAllLines();
        }
    }
}
