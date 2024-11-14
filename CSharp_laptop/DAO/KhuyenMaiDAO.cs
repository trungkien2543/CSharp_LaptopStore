using CSharp_laptop.BUS;
using CSharp_laptop.DTO;
using LiveChartsCore.Themes;
using MySql.Data.MySqlClient;
using Mysqlx.Crud;
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
            }
            return khuyenMaiArr;
        }

        public KhuyenMaiDTO Get1KhuyenMai(string id)// Lấy 1 Khuyễn mãi bằng id
        {
            KhuyenMaiDTO khuyenMai = null;
            MySqlConnection conn = connectionHelper.GetConnection();
            string query = "SELECT ID_KhuyenMai, TenKhuyenMai, MucGiamGia, MoTaKM, ThoiGianBatDau, ThoiGianKetThuc,ThoiGianTaoKM FROM khuyenmai WHERE ID_KhuyenMai = @id";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                khuyenMai = new KhuyenMaiDTO
                {
                    IDKM = reader["ID_KhuyenMai"].ToString(),
                    TenKM = reader["TenKhuyenMai"].ToString(),
                    MucGiamGia = int.Parse(reader["MucGiamGia"].ToString()),
                    MoTa = reader["MoTaKM"].ToString(),
                    ThoiGianBatDau = reader.GetDateTime(4),
                    ThoiGianKetThuc = reader.GetDateTime(5),
                    NgayTao = reader.GetDateTime(6)
                };
            }
            return khuyenMai;
        }

        public bool AddorEditKhuyenMai(KhuyenMaiDTO khuyenMai, string funcion)
        {
            bool isSuccess = false;
            using (MySqlConnection conn = connectionHelper.GetConnection())
            {
                conn.Open();
                string query = "";
                if (funcion == "add")
                {
                    query = "INSERT INTO Khuyenmai (ID_KhuyenMai, TenKhuyenMai, MucGiamGia, MoTaKM, ThoiGianBatDau, ThoiGianKetThuc, ThoiGianTaoKM) VALUES (@ID_KhuyenMai, @TenKhuyenMai, @MucGiamGia, @MoTaKM, @ThoiGianBatDau,  @ThoiGianKetThuc, @NgayTao)";
                }
                else if (funcion == "edit")
                {
                    query = "UPDATE Khuyenmai SET TenKhuyenMai = @TenKhuyenMai, MucGiamGia = @MucGiamGia, MoTaKM = @MoTaKM, ThoiGianBatDau = @ThoiGianBatDau, ThoiGianKetThuc = @ThoiGianKetThuc, ThoiGianTaoKM = @NgayTao WHERE ID_KhuyenMai = @ID_KhuyenMai";
                }
                MySqlCommand cmd = new MySqlCommand(query, conn);

                // Thêm các tham số để tránh SQL Injection
                cmd.Parameters.AddWithValue("@ID_KhuyenMai", khuyenMai.IDKM);
                cmd.Parameters.AddWithValue("@TenKhuyenMai", khuyenMai.TenKM);
                cmd.Parameters.AddWithValue("@MucGiamGia", khuyenMai.MucGiamGia);
                cmd.Parameters.AddWithValue("@MoTaKM", khuyenMai.MoTa);
                cmd.Parameters.AddWithValue("@ThoiGianBatDau", khuyenMai.ThoiGianBatDau);
                cmd.Parameters.AddWithValue("@ThoiGianKetThuc", khuyenMai.ThoiGianKetThuc);
                cmd.Parameters.AddWithValue("@NgayTao", khuyenMai.NgayTao);

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
