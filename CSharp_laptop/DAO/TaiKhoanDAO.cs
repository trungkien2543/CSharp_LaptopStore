using CSharp_laptop.DTO;
using MySql.Data.MySqlClient;

namespace CSharp_laptop.DAO
{
    internal class TaiKhoanDAO
    {
        private MySqlConnectionHelper connectionHelper = new MySqlConnectionHelper();

        public List<TaiKhoanDTO> GetAllTaiKhoan()
        {
            List<TaiKhoanDTO> accs = new List<TaiKhoanDTO>();

            using (MySqlConnection conn = connectionHelper.GetConnection())
            {
                conn.Open();
                string query = "SELECT * FROM taikhoan";
                MySqlCommand cmd = new MySqlCommand(query, conn);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        TaiKhoanDTO taikhoan = new TaiKhoanDTO()
                        {
                            TenDN = reader["TenDN"].ToString(),
                            MatKhau = reader["MatKhau"].ToString(),
                            Quyen = reader["Quyen"].ToString()
                        };
                        accs.Add(taikhoan);
                    }
                }
            }
            return accs;
        }
    }
}
