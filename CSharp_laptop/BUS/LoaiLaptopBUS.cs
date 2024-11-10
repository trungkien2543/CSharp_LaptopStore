using CSharp_laptop.DAO;
using Guna.UI2.WinForms;
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

        public List<String> getValueForComboBox(string searchItem, Guna2TextBox txtTenSP, Guna2ComboBox cbxCPU, Guna2ComboBox cbxRAM, Guna2ComboBox cbxGPU, Guna2ComboBox cbxTenHang, Guna2ComboBox cbxKichThuoc, Guna2TextBox txtGia)
        {

            // Đảm bảo `GiaBan` là số hợp lệ hoặc chuyển về số không nếu để trống
            if (!long.TryParse(txtGia.Text, out long giaBanValue))
            {
                giaBanValue = 100000000;
            }

            // Kiểm tra từng ComboBox, nếu trống thì gán chuỗi rỗng ""
            string cpu = string.IsNullOrEmpty(cbxCPU.Text) ? "" : cbxCPU.Text;
            string ram = string.IsNullOrEmpty(cbxRAM.Text) ? "" : cbxRAM.Text;
            string gpu = string.IsNullOrEmpty(cbxGPU.Text) ? "" : cbxGPU.Text;
            string tenHang = string.IsNullOrEmpty(cbxTenHang.Text) ? "" : cbxTenHang.Text;
            string kichThuoc = string.IsNullOrEmpty(cbxKichThuoc.Text) ? "" : cbxKichThuoc.Text;

            // Gọi phương thức searchForComboBox với các giá trị đã kiểm tra
            return loailaptopDAO.searchForComboBox(searchItem, txtTenSP.Text, cpu, ram, gpu, tenHang, kichThuoc, giaBanValue);



        }

        

        internal List<LoaiLaptopDTO> findLaptop(Guna2TextBox txtTenSP, Guna2ComboBox cbxCPU, Guna2ComboBox cbxRAM, Guna2ComboBox cbxGPU, Guna2ComboBox cbxTenHang, Guna2ComboBox cbxKichThuoc, Guna2TextBox txtGia)
        {
            List<LoaiLaptopDTO> list = new List<LoaiLaptopDTO>();

            // Đảm bảo `GiaBan` là số hợp lệ hoặc chuyển về số không nếu để trống
            if (!long.TryParse(txtGia.Text, out long giaBanValue))
            {
                giaBanValue = 100000000;
            }
                
    

            list = loailaptopDAO.findWithCondition(txtTenSP.Text, cbxCPU.Text, cbxRAM.Text, cbxGPU.Text, cbxTenHang.Text, cbxKichThuoc.Text,giaBanValue);

            return list;


        }
    }
}
