using CSharp_laptop.DAO;
using CSharp_laptop.DTO;
using CSharp_laptop.GUI;
using Guna.UI2.WinForms;
using System.Collections.Generic;

namespace CSharp_laptop.BUS
{
    

    public class ChiTietHoaDonBUS
    {
        private readonly ChiTietHoaDonDAO dao = new ChiTietHoaDonDAO();

        public List<ChiTietHoaDonDTO> GetChiTietHoaDonWithHoaDon(RJTextBox rJTextBox, Guna2DateTimePicker DateTimeFrom, Guna2DateTimePicker DateTimeTo)
        {

            string findText = rJTextBox.Texts;

            // Lấy giá trị ngày từ DateTimePicker và đặt thời gian đầu ngày
            DateTime dateTimeFrom = DateTimeFrom.Value.Date; // Đặt thời gian là 00:00:00

            // Lấy giá trị ngày từ DateTimePicker và đặt thời gian cuối ngày
            DateTime dateTimeTo = DateTimeTo.Value.Date.AddDays(1).AddTicks(-1); // Đặt thời gian là 23:59:59.9999999


            return dao.GetChiTietHoaDonWithHoaDon(findText, dateTimeFrom, dateTimeTo);
        }
    }

}
