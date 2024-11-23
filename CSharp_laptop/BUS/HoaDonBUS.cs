 using CSharp_laptop.DAO;
using CSharp_laptop.DTO;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.ComponentModel;

namespace CSharp_laptop.BUS { 


    public class HoaDonBUS
    {
        private readonly HoaDonDAO dao = new HoaDonDAO();


        private static readonly MySqlConnectionHelper connectionHelper = new MySqlConnectionHelper();

 

        public List<HoaDonDTO> GetAllHoaDon()
        {
            return dao.GetAllHoaDon();
        }

        public static bool AddHoaDon(HoaDonDTO hoaDonDTO, List<ChiTietHoaDonDTO> chiTietHoaDonList, int TichDiem)
        {
            // Thêm hóa đơn


            // Thêm chi tiết hóa đơn



            // Cập nhật số lượng tồn kho

            // Cập nhật tích điểm cho khách hàng

            // Cập nhật trạng thái của laptop

            using (MySqlConnection connection = connectionHelper.GetConnection())
            {
                connection.Open();
                MySqlTransaction transaction = connection.BeginTransaction();

                try
                {
                    // Thêm hóa đơn
                    int maHoaDon = HoaDonDAO.AddHoaDon(hoaDonDTO, transaction);
                    if (maHoaDon <= 0)
                        throw new Exception("Failed to add receipt");


                    // Thêm chi tiết hóa đơn
                    foreach (var chiTiet in chiTietHoaDonList)
                    {
                        chiTiet.ID_HoaDon = maHoaDon;
                        if (!ChiTietHoaDonDAO.AddChiTietHoaDon(chiTiet, transaction))
                            throw new Exception("Failed to add receipt details");
                    }

                    // Tích điểm cho khách hàng
                    if (!KhachHangDAO.TichDiem(hoaDonDTO.MaKH, TichDiem, transaction))
                        throw new Exception("Lỗi khi tích điểm");

                    // Cập nhật trạng thái sản phẩm

                    if (!LaptopDAO.CapNhatTrangThai(maHoaDon, 1, transaction))
                        throw new Exception("Lỗi khi cập nhật trạng thái");

                    // Cập nhật số lượng tồn kho
                    if (!LoaiLaptopDAO.CapNhatTonKhoKhiBan(maHoaDon,transaction))
                        throw new Exception("Lỗi khi cập nhật số lượng tồn kho");


                    // Commit transaction nếu tất cả thành công
                    transaction.Commit();
                    return true;
                }
                catch (Exception ex)
                {
                    // Rollback transaction nếu có lỗi
                    transaction.Rollback();
                    MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }

        public bool UpdateHoaDon(HoaDonDTO hoadon)
        {
            return dao.UpdateHoaDon(hoadon);
        }

        public bool DeleteHoaDon(long id_HoaDon)
        {
            return dao.DeleteHoaDon(id_HoaDon);
        }
    }

}
