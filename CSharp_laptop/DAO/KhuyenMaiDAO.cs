using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_laptop.DAO
{
    internal class KhuyenMaiDAO
    {
        private MySqlConnectionHelper connectionHelper = new MySqlConnectionHelper();

        public Dictionary<string, string> GetAllKhuyenMai()
        {
            Dictionary<string, string> khuyenMai = new Dictionary<string, string>();

            using (MySqlConnection conn = connectionHelper.GetConnection())
            {
                conn.Open();
                string query = "SELECT ID_KhuyenMai, TenKhuyenMai FROM khuyenmai";
                MySqlCommand cmd = new MySqlCommand(query, conn);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        // Thêm vào Dictionary với ID_KhuyenMai là Key và TenKhuyenMai là Value
                        khuyenMai.Add(reader["ID_KhuyenMai"].ToString(), reader["TenKhuyenMai"].ToString());
                    }
                }
            }

            return khuyenMai;
        }
    }
}
