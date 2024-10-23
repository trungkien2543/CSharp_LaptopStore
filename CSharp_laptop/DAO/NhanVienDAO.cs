using CSharp_laptop.DTO;
using LaptopStore.DTO;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_laptop.DAO
{
    internal class NhanVienDAO
    {
        private MySqlConnectionHelper connectionHelper = new MySqlConnectionHelper();
        public List<NhanVienDTO> GetAllNhanVien()
        {
            List<NhanVienDTO> nhanviens = new List<NhanVienDTO>();

            using (MySqlConnection conn = connectionHelper.GetConnection())
            {
                conn.Open();
                string query = @"SELECT `ID_NhanVien`, `TenNV`, `NgaySinh`, `SDT`, `DiaChi`, `GioiTinh`, `CCCD`, `Email` FROM `nhanvien` WHERE 1";
                MySqlCommand cmd = new MySqlCommand(query, conn);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        NhanVienDTO nhanvien = new NhanVienDTO
                        {
                            ID_NhanVien = reader["ID_NhanVien"].ToString(),
                            TenNV = reader["TenNV"].ToString(),
                            NgaySinh = reader["NgaySinh"].ToString(),
                            SDT = reader["SDT"].ToString(),
                            DiaChi = reader["DiaChi"].ToString(),
                            GioiTinh = reader["GioiTinh"].ToString() == "True",
                            CCCD = reader["CCCD"].ToString(),
                            Email = reader["Email"].ToString()
                        };
                        nhanviens.Add(nhanvien);
                    }
                }
            }
            return nhanviens;
        }
    }
}
