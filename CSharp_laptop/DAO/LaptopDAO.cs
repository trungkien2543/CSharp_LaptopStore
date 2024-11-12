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
                            IMEI = long.Parse(reader["IMEI"].ToString()),
                            ThoiGianBaoHanh = long.Parse(reader["ThoiGianBaoHanh"].ToString()),
                            TrangThai = long.Parse(reader["TrangThai"].ToString()),
                            LoaiLaptop = reader["LoaiLaptop"].ToString()
                        };
                        laptops.Add(laptop);
                    }
                }
            }
            return laptops;
        }
    }
}
