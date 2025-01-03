﻿using CSharp_laptop.DAO;
using LaptopStore.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_laptop.BUS
{
    internal class HangBUS
    {
        private HangDAO hangDAO = new HangDAO();

        public List<HangDTO> GetHangs()
        {
            return hangDAO.GetAllHangs();
        }

        public Dictionary<string, string> GetHangSanXuat()
        {
            return hangDAO.GetAllHangSanXuat();
        }

        public bool AddHangSanXuat(HangDTO hang)
        {
            return hangDAO.InsertHangSanXuat(hang);
        }

        public bool UpdateHangSanXuat(HangDTO hang)
        {
            return hangDAO.UpdateHangSanXuat(hang);
        }

        public bool CheckIfIDExists(string idHang)
        {
            return hangDAO.CheckIfIDExists(idHang);
        }

        public HangDTO GetHangSanXuatById(string idHang)
        {
            return hangDAO.GetHangSanXuatById(idHang);
        }

        public bool DeleteHangSanXuat(string idHang)
        {
            return hangDAO.DeleteHangSanXuat(idHang);
        }

        public DataTable SearchHangSanXuat(string searchTerm)
        {
            return hangDAO.SearchHangSanXuat(searchTerm);
        }
    }
}
