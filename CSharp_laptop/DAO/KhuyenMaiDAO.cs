using CSharp_laptop.BUS;
using CSharp_laptop.DTO;
using LaptopStore.DTO;
using LiveChartsCore.Themes;
using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        public BindingList<KhuyenMaiDTO> GetKhuyenMaiArr()
        {
            BindingList<KhuyenMaiDTO> khuyenMaiArr = new BindingList<KhuyenMaiDTO>();

            using (MySqlConnection conn = connectionHelper.GetConnection())
            {
                conn.Open();
                string query = "SELECT * FROM khuyenmai ORDER BY ThoiGianTaoKM DESC";
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

        public KhuyenMaiDTO Get1KhuyenMai(string id) // Lấy 1 Khuyến mãi bằng id
        {
            KhuyenMaiDTO khuyenMai = null;
            using (MySqlConnection conn = connectionHelper.GetConnection())
            {
                conn.Open();
                string query = "SELECT ID_KhuyenMai, TenKhuyenMai, MucGiamGia, MoTaKM, ThoiGianBatDau, ThoiGianKetThuc, ThoiGianTaoKM FROM khuyenmai WHERE ID_KhuyenMai = @id";
                MySqlCommand cmd = new MySqlCommand(query, conn);

                // Gán giá trị cho tham số @id
                cmd.Parameters.AddWithValue("@id", id);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read()) // Kiểm tra xem có dữ liệu hay không
                    {
                        khuyenMai = new KhuyenMaiDTO
                        {
                            IDKM = reader["ID_KhuyenMai"].ToString(),
                            TenKM = reader["TenKhuyenMai"].ToString(),
                            MucGiamGia = int.Parse(reader["MucGiamGia"].ToString()),
                            MoTa = reader["MoTaKM"].ToString(),
                            ThoiGianBatDau = reader.GetDateTime("ThoiGianBatDau"), // Có thể dùng tên cột hoặc chỉ số
                            ThoiGianKetThuc = reader.GetDateTime("ThoiGianKetThuc"),
                            NgayTao = reader.GetDateTime("ThoiGianTaoKM")
                        };
                    }
                }
            }
            return khuyenMai;
        }


        public string GetMaxID()
        {
            string id = "KM001";
            using(MySqlConnection conn = connectionHelper.GetConnection())
            {
                conn.Open();
                string query = "SELECT MAX(ID_KhuyenMai) FROM khuyenmai";
                //string query = "SELECT ID_KhuyenMai FROM khuyenmai ORDER BY ID_KhuyenMai DESC LIMIT 1;";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                object result = cmd.ExecuteScalar();
                if (result != DBNull.Value)
                {
                    string maxID = result.ToString();
                    int numberPart = int.Parse(maxID.Substring(2));// Lấy phần số từ ID hiện tại (bỏ phần "KH")
                    numberPart++;
                    id = "KM" + numberPart.ToString("D3");// Tạo ID mới với định dạng "KM" + số tự động tăng với 3 chữ số
                }
            }
            return id;
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
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
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
            }
            return isSuccess;
        }

        public bool DeleteKhuyenMai(string id)
        {
            bool isSuccess = false;
            using (MySqlConnection conn = connectionHelper.GetConnection())
            {
                conn.Open();
                string query = "DELETE FROM khuyenmai WHERE ID_KhuyenMai = @ID_KhuyenMai";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ID_KhuyenMai", id);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        isSuccess = true;
                        Console.WriteLine("Xóa nhân viên thành công!");
                    }
                    else
                    {
                        Console.WriteLine("Không tìm thấy nhân viên với ID đã cho.");
                    }
                }

                string query2 = "UPDATE loailaptop SET KhuyenMai = NULL WHERE KhuyenMai = @ID_KhuyenMai";
                using (MySqlCommand cmd = new MySqlCommand(query2, conn))
                {
                    cmd.Parameters.AddWithValue("@ID_KhuyenMai", id);
                }
            }
            return isSuccess;
        }

        public void KiemTraKhuyenMaiHetHan(string ID_KhuyenMai)
        {
            using (MySqlConnection conn = connectionHelper.GetConnection())
            {
                conn.Open();
                string query = "UPDATE loailaptop SET KhuyenMai = NULL WHERE KhuyenMai = @ID_KhuyenMai";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ID_KhuyenMai", ID_KhuyenMai);
                }
            }
        }

        public BindingList<KhuyenMaiDTO> TimKiem(string searchTerm)
        {
            BindingList<KhuyenMaiDTO> khuyenMaiList = new BindingList<KhuyenMaiDTO>();
            DataTable dt = new DataTable();
            using (MySqlConnection conn = connectionHelper.GetConnection())
            {
                conn.Open();
                string query = @"SELECT * 
                         FROM phieunhap 
                         WHERE ID_KhuyenMai LIKE @SearchTerm 
                            OR TenKhuyenMai LIKE @SearchTerm 
                            OR MucGiamGia LIKE @SearchTerm 
                            OR ThoiGianTaoKM LIKE @SearchTerm ORDER BY NgayNhap DESC";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@SearchTerm", "%" + searchTerm + "%");
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
                            khuyenMaiList.Add(khuyenMai);
                        }
                    }
                }
            }
            return khuyenMaiList;
        }
    }
}
