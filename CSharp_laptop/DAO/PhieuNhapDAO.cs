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
                //string query = "SELECT ID_PhieuNhap, MaNV, MaNcc, TongTien, NgayNhap FROM phieunhap ";
                string query = "SELECT * FROM phieunhap ORDER BY NgayNhap DESC";
                MySqlCommand cmd = new MySqlCommand(query, conn);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        PhieuNhapDTO phieuNhap = new PhieuNhapDTO()
                        {
                            ID = int.Parse(reader["ID_PhieuNhap"].ToString()),
                            IDNV = reader["MaNV"].ToString(),
                            IDNCC = reader["MaNCC"].ToString(),
                            TongTien = int.Parse(reader["TongTIen"].ToString()),
                            NgayTao = reader.GetDateTime(3)
                        }; 
                        Console.WriteLine("data:" + phieuNhap.ID + phieuNhap.IDNV + phieuNhap.IDNCC + phieuNhap.TongTien + phieuNhap.NgayTao);
                        phieuNhapList.Add(phieuNhap);
                    }
                }
            }
            return phieuNhapList;
        }

        public int GetMaxID()
        {
            int id = 1;
            using (MySqlConnection conn = connectionHelper.GetConnection())
            {
                conn.Open();
                string query = "SELECT MAX(ID_PhieuNhap) From phieunhap";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                object result = cmd.ExecuteScalar();
                if (result != DBNull.Value)
                {
                    id = int.Parse(result.ToString())+1;
                }
            }
            return id;
        }

        public bool AddPhieuNhap(PhieuNhapDTO phieuNhap)
        {
            bool isSuccess = false;
            using (MySqlConnection conn = connectionHelper.GetConnection())
            {
                conn.Open();
                string query = "INSERT INTO phieunhap (MaNV, MaNcc, TongTien,NgayNhap) VALUES (@MaNV, @MaNcc, @TongTien, @NgayNhap)";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@MaNV", phieuNhap.IDNV);
                    cmd.Parameters.AddWithValue("@MaNcc", phieuNhap.IDNCC);
                    cmd.Parameters.AddWithValue("@TongTien", phieuNhap.TongTien);
                    cmd.Parameters.AddWithValue("@NgayNhap", phieuNhap.NgayTao);

                    try
                    {
                        int rowsAffected = cmd.ExecuteNonQuery();
                        isSuccess = rowsAffected > 0;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
            return isSuccess;
        }

        public bool AddCTPhieuNhapi(int idPN, ChiTietPhieuNhapDTO ctpn)
        {
            bool isSuccess = false;
            using (MySqlConnection conn = connectionHelper.GetConnection())
            {
                conn.Open();
                string query2 = "INSERT INTO laptop (IMEI, ThoiGianBaoHanh, TrangThai, LoaiLaptop) VALUES (@IMEI, @ThoiGianBaoHanh, @TrangThai, @LoaiLaptop)";
                using (MySqlCommand cmd = new MySqlCommand(query2, conn))
                {
                    cmd.Parameters.AddWithValue("@IMEI", ctpn.IMEI);
                    cmd.Parameters.AddWithValue("@ThoiGianBaoHanh", ctpn.ThoiGianBaoHanh);
                    cmd.Parameters.AddWithValue("@TrangThai", 1);
                    cmd.Parameters.AddWithValue("@LoaiLaptop", ctpn.IDLoaiLaptop);
                    try
                    {
                        int rowsAffected = cmd.ExecuteNonQuery();
                        isSuccess = rowsAffected > 0;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }

                string query = "INSERT INTO chitietphieunhap (IMEI, GiaNhap, ID_PhieuNhap)  VALUES (@IMEI, @GiaNhap, @ID_PhieuNhap)";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@IMEI", ctpn.IMEI);
                    cmd.Parameters.AddWithValue("@GiaNhap", ctpn.GiaNhap);
                    cmd.Parameters.AddWithValue("@ID_PhieuNhap", idPN);
                    try
                    {
                        int rowsAffected = cmd.ExecuteNonQuery();
                        isSuccess = rowsAffected > 0;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }

                
            }
            return isSuccess;
        }
    }
}
