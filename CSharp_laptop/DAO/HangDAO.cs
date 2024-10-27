using LaptopStore.DTO;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
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
    }
}
