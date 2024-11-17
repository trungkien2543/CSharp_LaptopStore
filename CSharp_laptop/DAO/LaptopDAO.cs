using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using CSharp_laptop.DTO;


namespace CSharp_laptop.DAO
{

    internal class LaptopDAO
    {
        private MySqlConnectionHelper connectionHelper = new MySqlConnectionHelper();

        public List<LaptopDTO> GetAllLaptops(string loaiLaptop)
        {
            List<LaptopDTO> laptops = new List<LaptopDTO>();

            using (MySqlConnection conn = connectionHelper.GetConnection())
            {
                conn.Open();
                string query = "SELECT * FROM laptop WHERE LoaiLaptop = @LoaiLaptop";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@LoaiLaptop", loaiLaptop);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        LaptopDTO laptop = new LaptopDTO
                        {
                            IMEI = reader["IMEI"].ToString(),
                            ThoiGianBaoHanh = long.Parse(reader["ThoiGianBaoHanh"].ToString()),
                            TrangThai = reader["TrangThai"].ToString(),
                            LoaiLaptop = reader["LoaiLaptop"].ToString()
                        };
                        laptops.Add(laptop);
                    }
                }
            }
            return laptops;
        }

        public LaptopDTO GetLaptopByIMEI(string imei)
        {
            LaptopDTO laptop = null;

            using (MySqlConnection conn = connectionHelper.GetConnection())
            {
                conn.Open();
                string query = "SELECT * FROM laptop WHERE IMEI = @IMEI";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@IMEI", imei);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        laptop = new LaptopDTO
                        {
                            IMEI = reader["IMEI"].ToString(),
                            ThoiGianBaoHanh = long.Parse(reader["ThoiGianBaoHanh"].ToString()),
                            TrangThai = reader["TrangThai"].ToString(),
                            LoaiLaptop = reader["LoaiLaptop"].ToString()
                        };
                    }
                }
            }

            return laptop;
        }

    }
}
