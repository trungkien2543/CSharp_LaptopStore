using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_laptop.DTO
{
    public class ChatgptLineDTO
    {
        public int ID { get; set; }
        public string Line { get; set; }
        public ChatgptLineDTO()
        {
        }

        public ChatgptLineDTO(int iD, string line)
        {
            ID = iD;
            Line = line;
        }

    }
}
