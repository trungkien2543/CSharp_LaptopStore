using CSharp_laptop.DTO;
using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_laptop.DAO
{
    internal class PhieuNhapDAO
    {
        private MySqlConnectionHelper connectionHelper = new MySqlConnectionHelper();
         
        public BindingList<PhieuNhapDTO> GetAllPhieuNhap()
        {
            BindingList<PhieuNhapDTO> phieuNhapList = new BindingList<PhieuNhapDTO>();

            using(MySqlConnection conn = connectionHelper.GetConnection())
            {
                conn.Open();
                string query = "SELECT ID_PhieuNhap, MaNV, MaNcc, TongTien, NgayNhap FROM phieunhap";
                //string query = "SELECT * FROM phieunhap ORDER BY NgayNhap DESC";
                MySqlCommand cmd = new MySqlCommand(query, conn);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        PhieuNhapDTO phieuNhap = new PhieuNhapDTO()
                        {
                            ID = reader["ID_PhieuNhap"].ToString(),
                            IDNV = reader["MaNV"].ToString(),
                            IDNCC = reader["MaNCC"].ToString(),
                            TongTien = int.Parse(reader["TongTIen"].ToString()),
                            NgayTao = reader.GetDateTime(4)
                        };
                        Console.WriteLine("data:" + phieuNhap.ID + phieuNhap.IDNV + phieuNhap.IDNCC + phieuNhap.TongTien + phieuNhap.NgayTao);
                        phieuNhapList.Add(phieuNhap);
                    }
                }
            }
            return phieuNhapList;
        }
    }
}
