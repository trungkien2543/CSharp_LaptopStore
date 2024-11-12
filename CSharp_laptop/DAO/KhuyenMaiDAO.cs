using CSharp_laptop.BUS;
using CSharp_laptop.DTO;
using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_laptop.DAO
{
    internal class KhuyenMaiDAO
    {
        private MySqlConnectionHelper connectionHelper = new MySqlConnectionHelper();

        public Dictionary<string, string> GetAllKhuyenMai()
        {
            Dictionary<string, string> khuyenMai = new Dictionary<string, string>();

            using (MySqlConnection conn = connectionHelper.GetConnection())
            {
                conn.Open();
                string query = "SELECT ID_KhuyenMai, TenKhuyenMai FROM khuyenmai";
                MySqlCommand cmd = new MySqlCommand(query, conn);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        // Thêm vào Dictionary với ID_KhuyenMai là Key và TenKhuyenMai là Value
                        khuyenMai.Add(reader["ID_KhuyenMai"].ToString(), reader["TenKhuyenMai"].ToString());
                    }
                }
            }

            return khuyenMai;
        }
        public List<KhuyenMaiDTO> GetKhuyenMaiArr()
        {
            List<KhuyenMaiDTO> khuyenMaiArr = new List<KhuyenMaiDTO>();

            using (MySqlConnection conn = connectionHelper.GetConnection())
            {
                conn.Open();
                string query = "SELECT ID_KhuyenMai, TenKhuyenMai, MucGiamGia, MoTaKM, ThoiGianBatDau, ThoiGianKetThuc,ThoiGianTaoKM FROM khuyenmai";
                MySqlCommand cmd = new MySqlCommand(query, conn);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        KhuyenMaiDTO khuyenMai = new KhuyenMaiDTO
                        {
                            IDKM = reader["ID_KhuyenMai"].ToString(),
                            TenKM = reader["TenKhuyenMai"].ToString(),
                            MucGiamGia = int.Parse(reader["MucGiamGia"].ToString()),
                            MoTa = reader["MoTaKM"].ToString(),
                            ThoiGianBatDau = reader.GetDateTime(4),
                            ThoiGianKetThuc = reader.GetDateTime(5),
                            NgayTao = reader.GetDateTime(6)
                        };
                        khuyenMaiArr.Add(khuyenMai);
                    }
                }

                //string query2 = "SELECT ThoiGianBatDau FROM khuyenmai WHERE ID = @ID";
                //DateTime a = DateTime.MinValue;
                //MySqlCommand cmd2 = new MySqlCommand(query, conn);
                //using (MySqlDataReader reader = cmd2.ExecuteReader())
                //{
                //    cmd2.Parameters.AddWithValue("@ID", "KM001");
                //    while (reader.Read())
                //    {
                //        a = reader.GetDateTime(4);
                //    }
                //}
                //MessageBox.Show("Ngày: " + a + " đi chơi thôi nào!!!");
            }
            return khuyenMaiArr;
        }

        public bool AddKhuyenMai(KhuyenMaiDTO khuyenMai)
        {
            bool isSuccess = false;
            using (MySqlConnection conn = connectionHelper.GetConnection())
            {
                conn.Open();
                string query = @"INSERT INTO `Khuyenmai` (`ID_KhuyenMai`, `TenKhuyenMai`, `MucGiamGia`, `MoTaKM`, `ThoiGianBatDau`, `ThoiGianKetThuc`, `ThoiGianTaoKM`)
                         VALUES (@idKM, @tenKM, @muGiamGia, @moTa, @ngayBatDau,  @ngayKetThuc, @ngayTao)";
                MySqlCommand cmd = new MySqlCommand(query, conn);

                // Thêm các tham số để tránh SQL Injection
                cmd.Parameters.AddWithValue("@ID_KhuyenMai", khuyenMai.IDKM);
                cmd.Parameters.AddWithValue("@TenKhuyenMai", khuyenMai.TenKM);
                cmd.Parameters.AddWithValue("@MucGiamGia", khuyenMai.MucGiamGia);
                cmd.Parameters.AddWithValue("@MoTaKM", khuyenMai.MoTa);
                cmd.Parameters.AddWithValue("@ThoiGianBatDau", khuyenMai.ThoiGianBatDau);
                cmd.Parameters.AddWithValue("@ThoiGianKetThuc", khuyenMai.ThoiGianKetThuc);
                cmd.Parameters.AddWithValue("@ThoiGianTaoKM", khuyenMai.NgayTao);

                try
                {
                    int rowsAffected = cmd.ExecuteNonQuery();
                    isSuccess = rowsAffected > 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            return isSuccess;
        }
    }
}
