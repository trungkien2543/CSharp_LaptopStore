using System;
using System.Collections.Generic;
using CSharp_laptop.DTO;
using MySql.Data.MySqlClient;

namespace CSharp_laptop.DAO
{
    

    public class ChiTietHoaDonDAO
    {
        private MySqlConnectionHelper connectionHelper = new MySqlConnectionHelper();

        public List<ChiTietHoaDonDTO> GetAllChiTietHoaDon()
        {
            List<ChiTietHoaDonDTO> result = new();
            using (MySqlConnection connection = connectionHelper.GetConnection())
            {
                string query = "SELECT * FROM chitiethoadon";
                MySqlCommand command = new MySqlCommand(query, connection);

                connection.Open();
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ChiTietHoaDonDTO chiTiet = new ChiTietHoaDonDTO
                        {
                            IMEI = reader["IMEI"].ToString(),
                            ID_HoaDon = Convert.ToInt64(reader["ID_HoaDon"]),
                            GiaBan = Convert.ToInt64(reader["GiaBan"])
                        };
                        result.Add(chiTiet);
                    }
                }
            }
            return result;
        }

       
        public static bool AddChiTietHoaDon(ChiTietHoaDonDTO chiTietHoaDonDTO, MySqlTransaction transaction)
        {
            string query = "INSERT INTO chitiethoadon (IMEI, ID_HoaDon, GiaBan) VALUES (@IMEI, @ID_HoaDon, @GiaBan)";
            MySqlCommand command = new MySqlCommand(query, transaction.Connection, transaction);
            command.Parameters.AddWithValue("@IMEI", chiTietHoaDonDTO.IMEI);
            command.Parameters.AddWithValue("@ID_HoaDon", chiTietHoaDonDTO.ID_HoaDon);
            command.Parameters.AddWithValue("@GiaBan", chiTietHoaDonDTO.GiaBan);

            return command.ExecuteNonQuery() > 0;
        }
        


        //public bool UpdateChiTietHoaDon(ChiTietHoaDonDTO chiTiet)
        //{
        //    using (MySqlConnection connection = connectionHelper.GetConnection())
        //    {
        //        string query = "UPDATE chitiethoadon SET GiaBan = @GiaBan WHERE IMEI = @IMEI AND ID_HoaDon = @ID_HoaDon";
        //        MySqlCommand command = new MySqlCommand(query, connection);
        //        command.Parameters.AddWithValue("@IMEI", chiTiet.IMEI);
        //        command.Parameters.AddWithValue("@ID_HoaDon", chiTiet.ID_HoaDon);
        //        command.Parameters.AddWithValue("@GiaBan", chiTiet.GiaBan);

        //        connection.Open();
        //        return command.ExecuteNonQuery() > 0;
        //    }
        //}

        //public bool DeleteChiTietHoaDon(string imei, long id_HoaDon)
        //{
        //    using (MySqlConnection connection = connectionHelper.GetConnection())
        //    {
        //        string query = "DELETE FROM chitiethoadon WHERE IMEI = @IMEI AND ID_HoaDon = @ID_HoaDon";
        //        MySqlCommand command = new MySqlCommand(query, connection);
        //        command.Parameters.AddWithValue("@IMEI", imei);
        //        command.Parameters.AddWithValue("@ID_HoaDon", id_HoaDon);

        //        connection.Open();
        //        return command.ExecuteNonQuery() > 0;
        //    }
        //}
    }

}
