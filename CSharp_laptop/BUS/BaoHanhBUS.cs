﻿using CSharp_laptop.DAO;
using CSharp_laptop.DTO;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_laptop.BUS
{
    internal class BaoHanhBUS
    {
        private BaoHanhDAO baoHanhDAO = new BaoHanhDAO();

        public List<BaoHanhDTO> GetAllBaoHanhsByIMEI(string imei)
        {
            // You can add any business logic here, such as validation
            if (string.IsNullOrWhiteSpace(imei))
            {
                throw new ArgumentException("IMEI must not be empty.");
            }

            return baoHanhDAO.GetAllBaoHanhsByIMEI(imei);
        }
    }
}