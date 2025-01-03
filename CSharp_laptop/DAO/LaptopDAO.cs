﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using CSharp_laptop.DTO;
using System.Transactions;


namespace CSharp_laptop.DAO
{

    internal class LaptopDAO
    {
        private MySqlConnectionHelper connectionHelper = new MySqlConnectionHelper();

        public List<LaptopDTO> GetAllLaptops(string loaiLaptop)
        {
            List<LaptopDTO> laptops = new List<LaptopDTO>();

            using (MySqlConnection conn = connectionHelper.GetConnection())
            {
                conn.Open();
                string query = "SELECT * FROM laptop WHERE LoaiLaptop = @LoaiLaptop";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@LoaiLaptop", loaiLaptop);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        LaptopDTO laptop = new LaptopDTO
                        {
                            IMEI = reader["IMEI"].ToString(),
                            ThoiGianBaoHanh = long.Parse(reader["ThoiGianBaoHanh"].ToString()),
                            TrangThai = int.Parse(reader["TrangThai"].ToString()),
                            LoaiLaptop = reader["LoaiLaptop"].ToString()
                        };
                        laptops.Add(laptop);
                    }
                }
            }
            return laptops;
        }

        public LaptopDTO GetLaptopByIMEI(string imei)
        {
            LaptopDTO laptop = null;

            using (MySqlConnection conn = connectionHelper.GetConnection())
            {
                conn.Open();
                string query = "SELECT * FROM laptop WHERE IMEI = @IMEI";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@IMEI", imei);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        laptop = new LaptopDTO
                        {
                            IMEI = reader["IMEI"].ToString(),
                            ThoiGianBaoHanh = long.Parse(reader["ThoiGianBaoHanh"].ToString()),
                            TrangThai = int.Parse(reader["TrangThai"].ToString()),
                            LoaiLaptop = reader["LoaiLaptop"].ToString()
                        };
                    }
                }
            }

            return laptop;
        }


        public long GetGiaBanByIMEI(string IMEI)
        {
            long giaBan = 0;
            using (MySqlConnection conn = connectionHelper.GetConnection())
            {
                conn.Open();
                string query = "SELECT \r\n     CAST(loailaptop.GiaBan -  loailaptop.GiaBan * \r\n    CASE \r\n        WHEN khuyenmai.MucGiamGia IS NOT NULL THEN (khuyenmai.MucGiamGia / 100) \r\n        ELSE 0\r\n    END AS INT) AS GiaBan  \r\nFROM \r\n    laptop \r\nJOIN \r\n    loailaptop ON laptop.LoaiLaptop = loailaptop.IDLoaiLaptop \r\nLEFT JOIN \r\n    khuyenmai ON khuyenmai.ID_KhuyenMai = loailaptop.KhuyenMai \r\nWHERE \r\n    laptop.IMEI = @IMEI;";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@IMEI", IMEI);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        giaBan = long.Parse(reader["GiaBan"].ToString());
                    }
                }
            }

            return giaBan;
        }

        public static bool CapNhatTrangThai(int MaHD, int TrangThai, MySqlTransaction transaction)
        {

            string query = "UPDATE laptop\r\nJOIN chitiethoadon ON chitiethoadon.IMEI = laptop.IMEI\r\nJOIN hoadon ON chitiethoadon.ID_HoaDon = hoadon.ID_HoaDon\r\nSET laptop.TrangThai = 0\r\nWHERE hoadon.ID_HoaDon = @MaHD;";
            MySqlCommand command = new MySqlCommand(query, transaction.Connection, transaction);
            command.Parameters.AddWithValue("@MaHD", MaHD);

            return command.ExecuteNonQuery() > 0;
        }


        public DataTable SearchLaptop(string searchTerm, string laptopID)
        {
            DataTable dt = new DataTable();
            using (MySqlConnection conn = connectionHelper.GetConnection())
            {
                conn.Open();
                string query = @"SELECT * 
                             FROM laptop 
                             WHERE (IMEI LIKE @SearchTerm 
                                 OR ThoiGianBaoHanh LIKE @SearchTerm 
                                 OR TrangThai LIKE @SearchTerm 
                                 OR LoaiLaptop LIKE @SearchTerm)
                               AND LoaiLaptop = @LaptopID";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@SearchTerm", "%" + searchTerm + "%");
                    cmd.Parameters.AddWithValue("@LaptopID", laptopID); // Tham số LaptopID
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    da.Fill(dt);
                }
            }
            return dt;
        }


    }
}
