using CSharp_laptop.DTO;
using LaptopStore.DTO;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_laptop.DAO
{
    internal class NhanVienDAO
    {
        private MySqlConnectionHelper connectionHelper = new MySqlConnectionHelper();
        public List<NhanVienDTO> GetAllNhanVien()
        {
            List<NhanVienDTO> nhanviens = new List<NhanVienDTO>();

            using (MySqlConnection conn = connectionHelper.GetConnection())
            {
                conn.Open();
                string query = @"SELECT `ID_NhanVien`, `TenNV`, `NgaySinh`, `SDT`, `DiaChi`, `GioiTinh`, `CCCD`, `Email` FROM `nhanvien` WHERE 1";
                MySqlCommand cmd = new MySqlCommand(query, conn);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        NhanVienDTO nhanvien = new NhanVienDTO
                        {
                            ID_NhanVien = reader["ID_NhanVien"].ToString(),
                            TenNV = reader["TenNV"].ToString(),
                            NgaySinh = reader["NgaySinh"].ToString(),
                            SDT = reader["SDT"].ToString(),
                            DiaChi = reader["DiaChi"].ToString(),
                            GioiTinh = reader["GioiTinh"].ToString() == "True",
                            CCCD = reader["CCCD"].ToString(),
                            Email = reader["Email"].ToString()
                        };
                        nhanviens.Add(nhanvien);
                    }
                }
            }
            return nhanviens;
        }
        public bool AddNhanVien(NhanVienDTO nhanvien)
        {
            bool isSuccess = false;

            using (MySqlConnection conn = connectionHelper.GetConnection())
            {
                conn.Open();
                string query = @"
            INSERT INTO `nhanvien` (`ID_NhanVien`, `TenNV`, `NgaySinh`, `SDT`, `DiaChi`, `GioiTinh`, `CCCD`, `Email`)
            VALUES (@ID_NhanVien, @TenNV, @NgaySinh, @SDT, @DiaChi, @GioiTinh, @CCCD, @Email)";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ID_NhanVien", nhanvien.ID_NhanVien);
                cmd.Parameters.AddWithValue("@TenNV", nhanvien.TenNV);
                cmd.Parameters.AddWithValue("@NgaySinh", nhanvien.NgaySinh);
                cmd.Parameters.AddWithValue("@SDT", nhanvien.SDT);
                cmd.Parameters.AddWithValue("@DiaChi", nhanvien.DiaChi);
                cmd.Parameters.AddWithValue("@GioiTinh", nhanvien.GioiTinh);
                cmd.Parameters.AddWithValue("@CCCD", nhanvien.CCCD);
                cmd.Parameters.AddWithValue("@Email", nhanvien.Email);

                try
                {
                    int rowsAffected = cmd.ExecuteNonQuery();
                    isSuccess = rowsAffected > 0; // Kiểm tra nếu có ít nhất một dòng bị ảnh hưởng.
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message); // Có thể thay thế bằng ghi log.
                }
            }

            return isSuccess;
        }
        public bool DeleteNhanVien(string idNhanVien)
        {
            bool isSuccess = false;

            using (MySqlConnection conn = connectionHelper.GetConnection())
            {
                conn.Open();
                string query = "DELETE FROM `nhanvien` WHERE `ID_NhanVien` = @ID_NhanVien";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ID_NhanVien", idNhanVien);

                try
                {
                    int rowsAffected = cmd.ExecuteNonQuery();
                    isSuccess = rowsAffected > 0; // Kiểm tra nếu có ít nhất một dòng bị xóa.
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message); // Có thể thay thế bằng ghi log.
                }
            }

            return isSuccess;
        }
        public bool UpdateNhanVien(NhanVienDTO nhanvien)
        {
            bool isSuccess = false;

            using (MySqlConnection conn = connectionHelper.GetConnection())
            {
                conn.Open();
                string query = @"
            UPDATE `nhanvien` 
            SET 
                `TenNV` = @TenNV,
                `NgaySinh` = @NgaySinh,
                `SDT` = @SDT,
                `DiaChi` = @DiaChi,
                `GioiTinh` = @GioiTinh,
                `CCCD` = @CCCD,
                `Email` = @Email
            WHERE `ID_NhanVien` = @ID_NhanVien";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ID_NhanVien", nhanvien.ID_NhanVien);
                cmd.Parameters.AddWithValue("@TenNV", nhanvien.TenNV);
                cmd.Parameters.AddWithValue("@NgaySinh", nhanvien.NgaySinh);
                cmd.Parameters.AddWithValue("@SDT", nhanvien.SDT);
                cmd.Parameters.AddWithValue("@DiaChi", nhanvien.DiaChi);
                cmd.Parameters.AddWithValue("@GioiTinh", nhanvien.GioiTinh);
                cmd.Parameters.AddWithValue("@CCCD", nhanvien.CCCD);
                cmd.Parameters.AddWithValue("@Email", nhanvien.Email);

                try
                {
                    int rowsAffected = cmd.ExecuteNonQuery();
                    isSuccess = rowsAffected > 0; // Kiểm tra nếu có ít nhất một dòng bị cập nhật.
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message); // Có thể thay thế bằng ghi log.
                }
            }

            return isSuccess;
        }

        public NhanVienDTO FindNhanVienById(string idNhanVien)
        {
            NhanVienDTO nhanvien = null;

            using (MySqlConnection conn = connectionHelper.GetConnection())
            {
                conn.Open();
                string query = @"
                SELECT `ID_NhanVien`, `TenNV`, `NgaySinh`, `SDT`, `DiaChi`, `GioiTinh`, `CCCD`, `Email` 
                FROM `nhanvien` 
                WHERE `ID_NhanVien` = @ID_NhanVien";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ID_NhanVien", idNhanVien);

                try
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            nhanvien = new NhanVienDTO
                            {
                                ID_NhanVien = reader["ID_NhanVien"].ToString(),
                                TenNV = reader["TenNV"].ToString(),
                                NgaySinh = reader["NgaySinh"].ToString(),
                                SDT = reader["SDT"].ToString(),
                                DiaChi = reader["DiaChi"].ToString(),
                                GioiTinh = reader["GioiTinh"].ToString() == "True",
                                CCCD = reader["CCCD"].ToString(),
                                Email = reader["Email"].ToString()
                            };
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message); // Có thể thay thế bằng ghi log.
                }
            }

            return nhanvien;
        }
    }
}
