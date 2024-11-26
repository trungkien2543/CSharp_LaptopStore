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

        public bool InsertBaoHanh(BaoHanhDTO baohanh)
        {
            using (MySqlConnection conn = connectionHelper.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO baohanh (MaBaoHanh, IMEI, NgayBaoHanh, NgayTra, GhiChu) " +
                                   "VALUES (@MaBaoHanh, @IMEI, @NgayBaoHanh, @NgayTra, @GhiChu)";

                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@MaBaoHanh", baohanh.MaBaoHanh);
                    cmd.Parameters.AddWithValue("@IMEI", baohanh.IMEI);
                    cmd.Parameters.AddWithValue("@NgayBaoHanh", baohanh.NgayBaoHanh);
                    cmd.Parameters.AddWithValue("@NgayTra", baohanh.NgayTra);
                    cmd.Parameters.AddWithValue("@GhiChu", baohanh.GhiChu);

                    cmd.ExecuteNonQuery();
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Sản phẩm chưa được bán nên không thêm bảo hành mới!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }

        public bool UpdateBaoHanh(BaoHanhDTO baohanh)
        {
            using (MySqlConnection conn = connectionHelper.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = "UPDATE baohanh SET NgayBaoHanh = @NgayBaoHanh, NgayTra = @NgayTra, GhiChu = @GhiChu " +
                                   "WHERE MaBaoHanh = @MaBaoHanh";

                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@MaBaoHanh", baohanh.MaBaoHanh);
                    cmd.Parameters.AddWithValue("@NgayBaoHanh", baohanh.NgayBaoHanh);
                    cmd.Parameters.AddWithValue("@NgayTra", baohanh.NgayTra);
                    cmd.Parameters.AddWithValue("@GhiChu", baohanh.GhiChu);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }


    }
}
