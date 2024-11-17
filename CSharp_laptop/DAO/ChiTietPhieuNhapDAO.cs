using CSharp_laptop.DTO;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_laptop.DAO
{
    internal class ChiTietPhieuNhapDAO
    {
        private MySqlConnectionHelper connectionHelper = new MySqlConnectionHelper();

        public BindingList<KhuyenMaiDTO> GetKhuyenMaiArr()
        {
            BindingList<KhuyenMaiDTO> khuyenMaiArr = new BindingList<KhuyenMaiDTO>();

            using (MySqlConnection conn = connectionHelper.GetConnection())
            {
                conn.Open();
                string query = "SELECT * FROM khuyenmai";
                MySqlCommand cmd = new MySqlCommand(query, conn);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        KhuyenMaiDTO khuyenMai = new KhuyenMaiDTO
                        {
                            IDKM = reader["ID_KhuyenMai"].ToString(),
                            TenKM = reader["TenKhuyenMai"].ToString(),
                            MucGiamGia = int.Parse(reader["MucGiamGia"].ToString()),
                            MoTa = reader["MoTaKM"].ToString(),
                            ThoiGianBatDau = reader.GetDateTime(4),
                            ThoiGianKetThuc = reader.GetDateTime(5),
                            NgayTao = reader.GetDateTime(6)
                        };
                        khuyenMaiArr.Add(khuyenMai);
                    }
                }
            }
            return khuyenMaiArr;
        }

    }
}
