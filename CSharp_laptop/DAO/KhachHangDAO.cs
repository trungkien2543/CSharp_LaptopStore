using CSharp_laptop.DTO;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace CSharp_laptop.DAO
{
    internal class KhachHangDAO
    {
        private MySqlConnectionHelper connectionHelper = new MySqlConnectionHelper();
        public List<KhachHangDTO> GetAllKhachHang()
        {
            List<KhachHangDTO> khachhangs = new List<KhachHangDTO>();

            using (MySqlConnection conn = connectionHelper.GetConnection())
            {
                conn.Open();
                string query = @"SELECT `ID_KhachHang`, `TenKH`, `DiaChiKH`, `SDT`, `TichDiem` FROM `khachhang` WHERE 1";
                MySqlCommand cmd = new MySqlCommand(query, conn);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        KhachHangDTO khach = new KhachHangDTO
                        {
                            ID_KhachHang = reader["ID_KhachHang"].ToString(),
                            TenKH = reader["TenKH"].ToString(),
                            DiaChiKH = reader["DiaChiKH"].ToString(),
                            SDT = reader["SDT"].ToString(),
                            TichDiem = int.Parse(reader["TichDiem"].ToString())
                        };
                        khachhangs.Add(khach);
                    }
                }
            }
            return khachhangs;
        }
        public bool AddKhachHang(KhachHangDTO khachHang)
        {
            bool isSuccess = false;
            using (MySqlConnection conn = connectionHelper.GetConnection())
            {
                conn.Open();
                string query = @"INSERT INTO `khachhang` (`ID_KhachHang`, `TenKH`, `DiaChiKH`, `SDT`, `TichDiem`)
                         VALUES (@ID_KhachHang, @TenKH, @DiaChiKH, @SDT, @TichDiem)";

                MySqlCommand cmd = new MySqlCommand(query, conn);

                // Thêm các tham số để tránh SQL Injection
                cmd.Parameters.AddWithValue("@ID_KhachHang", khachHang.ID_KhachHang);
                cmd.Parameters.AddWithValue("@TenKH", khachHang.TenKH);
                cmd.Parameters.AddWithValue("@DiaChiKH", khachHang.DiaChiKH);
                cmd.Parameters.AddWithValue("@SDT", khachHang.SDT);
                cmd.Parameters.AddWithValue("@TichDiem", khachHang.TichDiem);

                try
                {
                    int rowsAffected = cmd.ExecuteNonQuery();
                    isSuccess = rowsAffected > 0;
                }
                catch (Exception ex)
                {
                    //MessageBox.Show("Error: " + ex.Message);
                }
            }
            return isSuccess;
        }
        public bool UpdateKhachHang(KhachHangDTO khachHang)
        {
            bool isSuccess = false;

            using (MySqlConnection conn = connectionHelper.GetConnection())
            {
                conn.Open();
                string query = @"
            UPDATE `khachhang` 
            SET 
                `TenKH` = @TenKH,
                `DiaChiKH` = @DiaChiKH,
                `SDT` = @SDT,
                `TichDiem` = @TichDiem
            WHERE `ID_KhachHang` = @ID_KhachHang";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ID_KhachHang", khachHang.ID_KhachHang);
                cmd.Parameters.AddWithValue("@TenKH", khachHang.TenKH);
                cmd.Parameters.AddWithValue("@DiaChiKH", khachHang.DiaChiKH);
                cmd.Parameters.AddWithValue("@SDT", khachHang.SDT);
                cmd.Parameters.AddWithValue("@TichDiem", khachHang.TichDiem);

                try
                {
                    int rowsAffected = cmd.ExecuteNonQuery();
                    isSuccess = rowsAffected > 0; // Kiểm tra nếu có ít nhất một dòng bị cập nhật.
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message); 
                }
            }

            return isSuccess;
        }


        public KhachHangDTO GetKhachHangBySDT(String SDT)
        {
            KhachHangDTO khach = null;


            using (MySqlConnection conn = connectionHelper.GetConnection())
            {
                conn.Open();
                string query = "SELECT * FROM khachhang WHERE SDT = @SDT";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@SDT", SDT);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        khach = new KhachHangDTO
                        {
                            ID_KhachHang = reader["ID_KhachHang"].ToString(),
                            TenKH = reader["TenKH"].ToString(),
                            DiaChiKH = reader["DiaChiKH"].ToString(),
                            SDT = reader["SDT"].ToString(),
                            TichDiem = int.Parse(reader["TichDiem"].ToString())
                        };
                        
                    }
                }
            }
            return khach;
        }
        public bool DeleteKhachHang(string idKhachHang)
        {
            bool isSuccess = false;

            using (MySqlConnection conn = connectionHelper.GetConnection())
            {
                conn.Open();
                string query = "DELETE FROM `khachhang` WHERE `ID_KhachHang` = @ID_KhachHang";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ID_KhachHang", idKhachHang);

                try
                {
                    int rowsAffected = cmd.ExecuteNonQuery();
                    isSuccess = rowsAffected > 0; // Kiểm tra nếu có ít nhất một dòng bị xóa.
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message); // Ghi lại lỗi nếu xảy ra vấn đề.
                }
            }

            return isSuccess;
        }


        public static bool TichDiem(string idKhachHang, int TichDiem, MySqlTransaction transaction)
        {

            string query = "UPDATE khachhang SET TichDiem = @TichDiem WHERE ID_KhachHang = @ID_KhachHang;";
            MySqlCommand command = new MySqlCommand(query, transaction.Connection, transaction);
            command.Parameters.AddWithValue("@TichDiem", TichDiem);
            command.Parameters.AddWithValue("@ID_KhachHang", idKhachHang?? (object)DBNull.Value);

            return command.ExecuteNonQuery() > 0;
        }
        public KhachHangDTO GetKhachHangById(string idKhachHang)
        {
            KhachHangDTO khachHang = null;

            using (MySqlConnection conn = connectionHelper.GetConnection())
            {
                conn.Open();
                string query = @"
            SELECT `ID_KhachHang`, `TenKH`, `DiaChiKH`, `SDT`, `TichDiem` 
            FROM `khachhang`
            WHERE `ID_KhachHang` = @ID_KhachHang";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ID_KhachHang", idKhachHang);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        khachHang = new KhachHangDTO
                        {
                            ID_KhachHang = reader["ID_KhachHang"].ToString(),
                            TenKH = reader["TenKH"].ToString(),
                            DiaChiKH = reader["DiaChiKH"].ToString(),
                            SDT = reader["SDT"].ToString(),
                            TichDiem = int.Parse(reader["TichDiem"].ToString())
                        };
                    }
                }
            }

            return khachHang;
        }


    }
}
