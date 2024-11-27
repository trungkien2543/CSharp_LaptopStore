using CSharp_laptop.DAO;
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
            if (string.IsNullOrWhiteSpace(imei))
            {
                MessageBox.Show("Nhập sai IMEI hoặc IMEI không tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return baoHanhDAO.GetAllBaoHanhsByIMEI(imei);
        }

        public bool AddBaoHanh(BaoHanhDTO baoHanh)
        {
            return baoHanhDAO.InsertBaoHanh(baoHanh);
        }

        public bool UpdateBaoHanh(BaoHanhDTO baoHanh)
        {
            return baoHanhDAO.UpdateBaoHanh(baoHanh);
        }
    }
}
