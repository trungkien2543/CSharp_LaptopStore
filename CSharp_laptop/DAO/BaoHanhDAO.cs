using CSharp_laptop.DTO;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_laptop.DAO
{
    internal class BaoHanhDAO
    {
        private MySqlConnectionHelper connectionHelper = new MySqlConnectionHelper();

        public List<BaoHanhDTO> GetAllBaoHanhsByIMEI(string imei)
        {
            List<BaoHanhDTO> baoHanhs = new List<BaoHanhDTO>();

            using (MySqlConnection conn = connectionHelper.GetConnection())
            {
                conn.Open();
                string query = "SELECT * FROM baohanh WHERE IMEI = @IMEI";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@IMEI", imei);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        BaoHanhDTO baoHanh = new BaoHanhDTO
                        {
                            MaBaoHanh = long.Parse(reader["MaBaoHanh"].ToString()),
                            IMEI = reader["IMEI"].ToString(),
                            NgayBaoHanh = DateTime.Parse(reader["NgayBaoHanh"].ToString()),
                            NgayTra = DateTime.Parse(reader["NgayTra"].ToString()),
                            GhiChu = reader["GhiChu"].ToString()
                        };
                        baoHanhs.Add(baoHanh);
                    }
                }
            }

            return baoHanhs;
        }
    }
}
