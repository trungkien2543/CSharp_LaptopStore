using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_laptop.DAO
{
    using System;
    using System.Collections.Generic;
    using CSharp_laptop.DTO;
    using MySql.Data.MySqlClient;

    public class HoaDonDAO
    {
        private MySqlConnectionHelper connectionHelper = new MySqlConnectionHelper();

        public List<HoaDonDTO> GetAllHoaDon()
        {
            List<HoaDonDTO> result = new();
            using (MySqlConnection connection = connectionHelper.GetConnection())
            {
                string query = "SELECT * FROM hoadon";
                MySqlCommand command = new MySqlCommand(query, connection);

                connection.Open();
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        HoaDonDTO hoadon = new HoaDonDTO
                        {
                            ID_HoaDon = Convert.ToInt64(reader["ID_HoaDon"]),
                            MaNV = reader["MaNV"]?.ToString(),
                            MaKH = reader["MaKH"]?.ToString(),
                            NgayLap = reader["NgayLap"] as DateTime?,
                            TongTien = reader["TongTien"] as long?
                        };
                        result.Add(hoadon);
                    }
                }
            }
            return result;
        }
        public List<HoaDonDTO> FindWithCondition(string find, DateTime From, DateTime To)
        {
            List<HoaDonDTO> result = new();
            using (MySqlConnection connection = connectionHelper.GetConnection())
            {
                string query = @"
            SELECT * 
            FROM hoadon 
            WHERE 
                (hoadon.ID_HoaDon LIKE @FIND 
                OR hoadon.MaNV LIKE @FIND 
                OR hoadon.MaKH LIKE @FIND) 
                AND hoadon.NgayLap BETWEEN @From AND @To;";

                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@FIND", "%" + find + "%");
                command.Parameters.AddWithValue("@From", From);
                command.Parameters.AddWithValue("@To", To);

                connection.Open();
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        HoaDonDTO hoadon = new HoaDonDTO
                        {
                            ID_HoaDon = Convert.ToInt64(reader["ID_HoaDon"]),
                            MaNV = reader["MaNV"]?.ToString(),
                            MaKH = reader["MaKH"]?.ToString(),
                            NgayLap = reader["NgayLap"] == DBNull.Value ? null : Convert.ToDateTime(reader["NgayLap"]),
                            TongTien = reader["TongTien"] == DBNull.Value ? null : Convert.ToInt64(reader["TongTien"])
                        };
                        result.Add(hoadon);
                    }
                }
            }
            return result;
        }



        public static int AddHoaDon(HoaDonDTO hoaDonDTO, MySqlTransaction transaction)
        {
            string query = "INSERT INTO hoadon (MaNV, MaKH, NgayLap, TongTien) VALUES (@MaNV, @MaKH, @NgayLap, @TongTien); SELECT LAST_INSERT_ID();";
            MySqlCommand command = new MySqlCommand(query, transaction.Connection, transaction);
            command.Parameters.AddWithValue("@MaNV", hoaDonDTO.MaNV ?? (object)DBNull.Value);
            command.Parameters.AddWithValue("@MaKH", hoaDonDTO.MaKH ?? (object)DBNull.Value);
            command.Parameters.AddWithValue("@NgayLap", hoaDonDTO.NgayLap ?? (object)DBNull.Value);
            command.Parameters.AddWithValue("@TongTien", hoaDonDTO.TongTien ?? (object)DBNull.Value);

            object result = command.ExecuteScalar();
            return Convert.ToInt32(result);
        }

        public bool UpdateHoaDon(HoaDonDTO hoadon)
        {
            using (MySqlConnection connection = connectionHelper.GetConnection())
            {
                string query = "UPDATE hoadon SET MaNV = @MaNV, MaKH = @MaKH, NgayLap = @NgayLap, TongTien = @TongTien WHERE ID_HoaDon = @ID_HoaDon";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@ID_HoaDon", hoadon.ID_HoaDon);
                command.Parameters.AddWithValue("@MaNV", hoadon.MaNV ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@MaKH", hoadon.MaKH ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@NgayLap", hoadon.NgayLap ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@TongTien", hoadon.TongTien ?? (object)DBNull.Value);

                connection.Open();
                return command.ExecuteNonQuery() > 0;
            }
        }

        public bool DeleteHoaDon(long id_HoaDon)
        {
            using (MySqlConnection connection = connectionHelper.GetConnection())
            {
                string query = "DELETE FROM hoadon WHERE ID_HoaDon = @ID_HoaDon";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@ID_HoaDon", id_HoaDon);

                connection.Open();
                return command.ExecuteNonQuery() > 0;
            }
        }

        public HoaDonDTO GetHoaDonByIMEI(string imei)
        {
            HoaDonDTO hoadon = null;
            using (MySqlConnection connection = connectionHelper.GetConnection())
            {
                string query = @"
            SELECT h.* 
            FROM hoadon h
            JOIN chitiethoadon c ON h.ID_HoaDon = c.ID_HoaDon
            WHERE c.IMEI = @IMEI";

                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@IMEI", imei);

                connection.Open();
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        hoadon = new HoaDonDTO
                        {
                            ID_HoaDon = Convert.ToInt64(reader["ID_HoaDon"]),
                            MaNV = reader["MaNV"]?.ToString(),
                            MaKH = reader["MaKH"]?.ToString(),
                            NgayLap = reader["NgayLap"] as DateTime?,
                            TongTien = reader["TongTien"] as long?
                        };
                    }
                }
            }
            return hoadon;
        }

        public DateTime? GetWarrantyEndDateByIMEI(string imei)
        {
            using (MySqlConnection connection = connectionHelper.GetConnection())
            {
                string query = @"
            SELECT h.NgayLap, l.ThoiGianBaoHanh 
            FROM hoadon h
            JOIN chitiethoadon c ON h.ID_HoaDon = c.ID_HoaDon
            JOIN laptop l ON c.IMEI = l.IMEI
            WHERE c.IMEI = @IMEI";

                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@IMEI", imei);

                connection.Open();
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        DateTime? ngayLap = reader["NgayLap"] as DateTime?;
                        int thoiGianBaoHanh = Convert.ToInt32(reader["ThoiGianBaoHanh"]);

                        if (ngayLap.HasValue)
                        {
                            // Calculate the warranty end date
                            return ngayLap.Value.AddMonths(thoiGianBaoHanh);
                        }
                    }
                }
            }
            return null;
        }

    }

}
