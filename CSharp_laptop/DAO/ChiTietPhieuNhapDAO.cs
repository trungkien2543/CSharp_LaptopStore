using CSharp_laptop.DTO;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_laptop.DAO
{
    internal class ChiTietPhieuNhapDAO
    {
        private MySqlConnectionHelper connectionHelper = new MySqlConnectionHelper();

        public List<ChiTietPhieuNhapDTO> GetChiTietPhieuNhapWithHoaDon(string find)
        {
            List<ChiTietPhieuNhapDTO> result = new();
            using (MySqlConnection connection = connectionHelper.GetConnection())
            {
                string query = @"SELECT * FROM chitietphieunnhap WHERE chitietphieunhap.ID_PhieuNhap IN (" + @"
                                                                                               SELECT * 
                                                                                                FROM phieunhap 
                                                                                                WHERE ID_PhieuNhap LIKE @SearchTerm 
                                                                                                OR MaNV LIKE @SearchTerm 
                                                                                                OR MaNcc LIKE @SearchTerm 
                                                                                                OR TongTien LIKE @SearchTerm 
                                                                                                OR NgayNhap LIKE @SearchTerm ORDER BY NgayNhap DESC;";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@Search", "%" + find + "%");


                connection.Open();
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ChiTietPhieuNhapDTO chiTiet = new ChiTietPhieuNhapDTO
                        {
                            IMEI = reader["IMEI"].ToString(),
                            ID_PhieuNhap = Convert.ToInt64(reader["ID_PhieuNhap"]),
                            GiaNhap = Convert.ToInt64(reader["GiaNhap"])
                        };
                        result.Add(chiTiet);
                    }
                }
            }
            return result;
        }




    }
}
