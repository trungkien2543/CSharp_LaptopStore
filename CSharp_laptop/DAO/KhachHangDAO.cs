using CSharp_laptop.DTO;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_laptop.DAO
{
    internal class KhachHangDAO
    {
        private MySqlConnectionHelper connectionHelper = new MySqlConnectionHelper();
        public List<KhachHangDTO> GetAllKhachHang()
        {
            List<KhachHangDTO> khachhangs = new List<KhachHangDTO>();

            using (MySqlConnection conn = connectionHelper.GetConnection())
            {
                conn.Open();
                string query = @"SELECT `ID_KhachHang`, `TenKH`, `DiaChiKH`, `SDT`, `TichDiem` FROM `khachhang` WHERE 1";
                MySqlCommand cmd = new MySqlCommand(query, conn);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        KhachHangDTO khach = new KhachHangDTO
                        {
                            ID_KhachHang = reader["ID_KhachHang"].ToString(),
                            TenKH = reader["TenKH"].ToString(),
                            DiaChiKH = reader["DiaChiKH"].ToString(),
                            SDT = reader["SDT"].ToString(),
                            TichDiem = int.Parse(reader["TichDiem"].ToString())
                        };
                        khachhangs.Add(khach);
                    }
                }
            }
            return khachhangs;
        }
    }
}
