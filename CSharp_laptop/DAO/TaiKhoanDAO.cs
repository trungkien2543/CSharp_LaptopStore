﻿using CSharp_laptop.DTO;
using MySql.Data.MySqlClient;

namespace CSharp_laptop.DAO
{
    internal class TaiKhoanDAO
    {
        private MySqlConnectionHelper connectionHelper = new MySqlConnectionHelper();

        public List<TaiKhoanDTO> GetAllTaiKhoan()
        {
            List<TaiKhoanDTO> accs = new List<TaiKhoanDTO>();

            using (MySqlConnection conn = connectionHelper.GetConnection())
            {
                conn.Open();
                string query = "SELECT * FROM taikhoan";
                MySqlCommand cmd = new MySqlCommand(query, conn);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        TaiKhoanDTO taikhoan = new TaiKhoanDTO()
                        {
                            TenDN = reader["TenDN"].ToString(),
                            MatKhau = reader["MatKhau"].ToString(),
                            Quyen = reader["Quyen"].ToString()
                        };
                        accs.Add(taikhoan);
                    }
                }
            }
            return accs;
        }
        public TaiKhoanDTO CheckLogin(string tenDN, string matKhau)
        {
            using (MySqlConnection conn = connectionHelper.GetConnection())
            {
                conn.Open();
                string query = "SELECT * FROM taikhoan WHERE TenDN = @TenDN AND MatKhau = @MatKhau";
                MySqlCommand cmd = new MySqlCommand(query, conn);

                // Thêm các tham số để ngăn chặn SQL Injection
                cmd.Parameters.AddWithValue("@TenDN", tenDN);
                cmd.Parameters.AddWithValue("@MatKhau", matKhau);

                TaiKhoanDTO taikhoan = new TaiKhoanDTO();

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        taikhoan.TenDN = reader["TenDN"].ToString();
                        taikhoan.MatKhau = reader["MatKhau"].ToString();
                        taikhoan.Quyen = reader["Quyen"].ToString();
                    }
                }

                if (taikhoan.TenDN == tenDN)
                {
                    return taikhoan;
                }

                // Nếu count > 0, tài khoản và mật khẩu hợp lệ
                return null;
            }
        }

        public bool AddTaiKhoan(TaiKhoanDTO taiKhoan)
        {
            using (MySqlConnection conn = connectionHelper.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO taikhoan (TenDN, MatKhau, Quyen) VALUES (@TenDN, @MatKhau, @Quyen)";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@TenDN", taiKhoan.TenDN);
                    cmd.Parameters.AddWithValue("@MatKhau", taiKhoan.MatKhau);

                    // Kiểm tra giá trị của Quyen và gán tham số phù hợp
                    if (string.IsNullOrEmpty(taiKhoan.Quyen))
                    {
                        cmd.Parameters.AddWithValue("@Quyen", DBNull.Value); // Nếu Quyen null, gán DBNull.Value
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@Quyen", taiKhoan.Quyen); // Gán giá trị Quyen nếu không null
                    }

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
        public bool SuaTK(TaiKhoanDTO taiKhoan)
        {
            using (MySqlConnection conn = connectionHelper.GetConnection())
            {
                try
                {
                    conn.Open();
                    // Câu lệnh SQL để cập nhật mật khẩu và quyền của tài khoản dựa trên TenDN
                    string query = "UPDATE taikhoan SET MatKhau = @MatKhau, Quyen = @Quyen WHERE TenDN = @TenDN";
                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    // Thêm các tham số để ngăn chặn SQL Injection
                    cmd.Parameters.AddWithValue("@TenDN", taiKhoan.TenDN);
                    cmd.Parameters.AddWithValue("@MatKhau", taiKhoan.MatKhau);

                    // Kiểm tra và gán giá trị `Quyen` (nếu `Quyen` là null, gán `DBNull.Value`)
                    if (string.IsNullOrEmpty(taiKhoan.Quyen))
                    {
                        cmd.Parameters.AddWithValue("@Quyen", DBNull.Value);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@Quyen", taiKhoan.Quyen);
                    }

                    // Thực thi câu lệnh SQL
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

        public bool XoaTaiKhoan(string tenDN)
        {
            using (MySqlConnection conn = connectionHelper.GetConnection())
            {
                try
                {
                    conn.Open();
                    // Câu lệnh SQL để xóa tài khoản theo TenDN
                    string query = "DELETE FROM taikhoan WHERE TenDN = @TenDN";
                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    // Thêm tham số TenDN vào câu lệnh để ngăn chặn SQL Injection
                    cmd.Parameters.AddWithValue("@TenDN", tenDN);

                    // Thực thi câu lệnh SQL
                    int rowsAffected = cmd.ExecuteNonQuery();

                    // Nếu số dòng bị ảnh hưởng > 0, xóa thành công
                    return rowsAffected > 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }



        public Dictionary<string, string> GetAllQuyen()
        {
            Dictionary<string, string> quyen = new Dictionary<string, string>();

            using (MySqlConnection conn = connectionHelper.GetConnection())
            {
                conn.Open();
                string query = "SELECT ID_Quyen, ChiTietQuyen FROM quyen";
                MySqlCommand cmd = new MySqlCommand(query, conn);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        // Thêm vào Dictionary với ID_KhuyenMai là Key và TenKhuyenMai là Value
                        quyen.Add(reader["ID_Quyen"].ToString(), reader["ChiTietQuyen"].ToString());
                    }
                }
            }
            return quyen;
        }
        public TaiKhoanDTO GetTaiKhoanByID(string id)
        {
            TaiKhoanDTO taikhoan = null;

            using (MySqlConnection conn = connectionHelper.GetConnection())
            {
                conn.Open();
                string query = "SELECT * FROM taikhoan WHERE TenDN = @id";
                MySqlCommand cmd = new MySqlCommand(query, conn);

                // Thêm tham số ID để tránh SQL Injection
                cmd.Parameters.AddWithValue("@id", id);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read()) // Kiểm tra nếu có dữ liệu trả về
                    {
                        taikhoan = new TaiKhoanDTO()
                        {
                            TenDN = reader["TenDN"].ToString(),
                            MatKhau = reader["MatKhau"].ToString(),
                            Quyen = reader["Quyen"].ToString()
                        };
                    }
                }
            }

            return taikhoan; // Trả về đối tượng TaiKhoanDTO hoặc null nếu không tìm thấy
        }


    }
}
