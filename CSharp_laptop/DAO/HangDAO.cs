using LaptopStore.DTO;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_laptop.DAO
{
    internal class HangDAO
    {
        private MySqlConnectionHelper connectionHelper = new MySqlConnectionHelper();

        public List<HangDTO> GetAllHangs()
        {
            List<HangDTO> hangs = new List<HangDTO>();

            using (MySqlConnection conn = connectionHelper.GetConnection())
            {
                conn.Open();
                string query = "SELECT * FROM hangsanxuat";
                MySqlCommand cmd = new MySqlCommand(query, conn);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        HangDTO hang = new HangDTO()
                        {
                            ID_Hang = reader["ID_Hang"].ToString(),
                            TenHang = reader["TenHang"].ToString(),
                            DiaChi = reader["DiaChi"].ToString(),
                            SDT = reader["SDT"].ToString()
                        };
                        hangs.Add(hang);
                    }
                }
            }
            return hangs;
        }


        public Dictionary<string, string> GetAllHangSanXuat()
        {
            Dictionary<string, string> hangSanXuat = new Dictionary<string, string>();

            using (MySqlConnection conn = connectionHelper.GetConnection())
            {
                conn.Open();
                string query = "SELECT ID_Hang, TenHang FROM hangsanxuat";
                MySqlCommand cmd = new MySqlCommand(query, conn);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        // Thêm vào Dictionary với ID_Hang là Key và TenHang là Value
                        hangSanXuat.Add(reader["ID_Hang"].ToString(), reader["TenHang"].ToString());
                    }
                }
            }

            return hangSanXuat;
        }

        public bool InsertHangSanXuat(HangDTO hang)
        {
            using (MySqlConnection conn = connectionHelper.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO hangsanxuat (ID_Hang, TenHang, DiaChi, SDT) " +
                                   "VALUES (@ID_Hang, @TenHang, @DiaChi, @SDT)";

                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@ID_Hang", hang.ID_Hang);
                    cmd.Parameters.AddWithValue("@TenHang", hang.TenHang);
                    cmd.Parameters.AddWithValue("@DiaChi", hang.DiaChi);
                    cmd.Parameters.AddWithValue("@SDT", hang.SDT);

                    cmd.ExecuteNonQuery();
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }

        public bool CheckIfIDExists(string idHang)
        {
            using (MySqlConnection conn = connectionHelper.GetConnection())
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM hangsanxuat WHERE ID_Hang = @ID_Hang";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ID_Hang", idHang);

                int count = Convert.ToInt32(cmd.ExecuteScalar());
                return count > 0;
            }
        }


        public bool UpdateHangSanXuat(HangDTO hang)
        {
            using (MySqlConnection conn = connectionHelper.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = "UPDATE hangsanxuat SET TenHang = @TenHang, DiaChi = @DiaChi, SDT = @SDT WHERE ID_Hang = @ID_Hang";

                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@ID_Hang", hang.ID_Hang);
                    cmd.Parameters.AddWithValue("@TenHang", hang.TenHang);
                    cmd.Parameters.AddWithValue("@DiaChi", hang.DiaChi);
                    cmd.Parameters.AddWithValue("@SDT", hang.SDT);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }

        public HangDTO GetHangSanXuatById(string idHang)
        {
            using (MySqlConnection conn = connectionHelper.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = "SELECT ID_Hang, TenHang, DiaChi, SDT FROM hangsanxuat WHERE ID_Hang = @ID_Hang";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@ID_Hang", idHang);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            HangDTO hang = new HangDTO
                            {
                                ID_Hang = reader["ID_Hang"].ToString(),
                                TenHang = reader["TenHang"].ToString(),
                                DiaChi = reader["DiaChi"].ToString(),
                                SDT = reader["SDT"].ToString()
                            };
                            return hang;
                        }
                    }
                    return null; // Không tìm thấy hãng
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
            }
        }

        public bool DeleteHangSanXuat(string idHang)
        {
            using (MySqlConnection conn = connectionHelper.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = "DELETE FROM hangsanxuat WHERE ID_Hang = @ID_Hang";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@ID_Hang", idHang);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }

        public DataTable SearchHangSanXuat(string searchTerm)
        {
            DataTable dt = new DataTable();
            using (MySqlConnection conn = connectionHelper.GetConnection())
            {
                conn.Open();
                string query = @"SELECT * 
                         FROM hangsanxuat 
                         WHERE ID_Hang LIKE @SearchTerm 
                            OR TenHang LIKE @SearchTerm 
                            OR DiaChi LIKE @SearchTerm 
                            OR SDT LIKE @SearchTerm";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    // Gắn tham số @SearchTerm
                    cmd.Parameters.AddWithValue("@SearchTerm", "%" + searchTerm + "%");

                    // Sử dụng DataAdapter để điền dữ liệu vào DataTable
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    da.Fill(dt);
                }
            }
            return dt;
        }

    }
}
