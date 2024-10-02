using LaptopStore.DTO;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_laptop.DAO
{
    internal class SanPhamDAO
    {
        private MySqlConnectionHelper connectionHelper = new MySqlConnectionHelper();

        public List<SanPhamDTO> GetAllLaptops()
        {
            List<SanPhamDTO> laptops = new List<SanPhamDTO>();

            using (MySqlConnection conn = connectionHelper.GetConnection())
            {
                conn.Open();
                string query = "SELECT * FROM loai_laptop";
                MySqlCommand cmd = new MySqlCommand(query, conn);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        SanPhamDTO laptop = new SanPhamDTO
                        {
                            ID_Loai = reader["IDLaptop"].ToString(),
                            TenSP = reader["TenSP"].ToString(),
                            GiaBan = long.Parse(reader["GiaBan"].ToString()),
                            Hang = reader["Hang"].ToString(),
                            CPU = reader["CPU"].ToString(),
                            RAM = int.Parse(reader["RAM"].ToString()),
                            GPU = reader["GPU"].ToString(),
                            HinhAnh = reader["HinhAnh"].ToString(),
                            KichThuoc = reader["KichThuoc"].ToString(),
                            KhuyenMai = reader["KhuyenMai"].ToString()
                        };
                        laptops.Add(laptop);
                    }
                }
            }
            return laptops;
        }
    }
}
