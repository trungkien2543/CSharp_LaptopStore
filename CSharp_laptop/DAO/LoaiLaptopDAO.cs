﻿using LaptopStore.DTO;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Shapes;

namespace CSharp_laptop.DAO
{
    internal class LoaiLaptopDAO
    {
        private MySqlConnectionHelper connectionHelper = new MySqlConnectionHelper();

        public List<LoaiLaptopDTO> GetAllLaptops()
        {
            List<LoaiLaptopDTO> laptops = new List<LoaiLaptopDTO>();

            using (MySqlConnection conn = connectionHelper.GetConnection())
            {
                conn.Open(); 
                string query = @"
                                SELECT ll.*, h.TenHang, km.TenKhuyenMai 
                                FROM loailaptop ll 
                                LEFT JOIN hangsanxuat h ON ll.Hang = h.ID_Hang 
                                LEFT JOIN khuyenmai km ON ll.KhuyenMai = km.ID_KhuyenMai";
                MySqlCommand cmd = new MySqlCommand(query, conn);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        LoaiLaptopDTO laptop = new LoaiLaptopDTO
                        {
                            IDLoaiLaptop = reader["IDLoaiLaptop"].ToString(),
                            TenSP = reader["TenSP"].ToString(),
                            GiaBan = long.Parse(reader["GiaBan"].ToString()),
                            Hang = reader["TenHang"].ToString(),
                            CPU = reader["CPU"].ToString(),
                            RAM = int.Parse(reader["RAM"].ToString()),
                            GPU = reader["GPU"].ToString(),
                            HinhAnh = reader["HinhAnh"].ToString(),
                            KichThuoc = reader["KichThuoc"].ToString(),
                            KhuyenMai = reader["TenKhuyenMai"].ToString(),
                            SLTonKho = reader["SLTonKho"].ToString()
                        };
                        laptops.Add(laptop);
                    }
                }
            }
            return laptops;
        }

        public LoaiLaptopDTO GetLaptopByID(string IDLoaiLaptop)
        {
            LoaiLaptopDTO laptop = null;  // Khởi tạo null để kiểm tra nếu không tìm thấy laptop

            using (MySqlConnection conn = connectionHelper.GetConnection())
            {
                conn.Open();
                string query = @"
                SELECT ll.*, ll.Hang AS ID_Hang, ll.KhuyenMai AS ID_KhuyenMai 
                FROM loailaptop ll
                WHERE ll.IDLoaiLaptop = @IDLoaiLaptop";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@IDLoaiLaptop", IDLoaiLaptop);  // Thêm tham số vào câu lệnh SQL

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())  // Chỉ lấy 1 bản ghi
                    {
                        laptop = new LoaiLaptopDTO
                        {
                            IDLoaiLaptop = reader["IDLoaiLaptop"].ToString(),
                            TenSP = reader["TenSP"].ToString(),
                            GiaBan = long.Parse(reader["GiaBan"].ToString()),
                            Hang = reader["ID_Hang"].ToString(),  // Lấy ID_Hang
                            CPU = reader["CPU"].ToString(),
                            RAM = int.Parse(reader["RAM"].ToString()),
                            GPU = reader["GPU"].ToString(),
                            HinhAnh = reader["HinhAnh"].ToString(),
                            KichThuoc = reader["KichThuoc"].ToString(),
                            KhuyenMai = reader["ID_KhuyenMai"]?.ToString(),  // Lấy ID_KhuyenMai, kiểm tra null
                            SLTonKho = reader["SLTonKho"].ToString()
                        };
                    }
                }
            }
            return laptop;  // Trả về đối tượng laptop hoặc null nếu không tìm thấy
        }



        public bool InsertLoaiLaptop(LoaiLaptopDTO laptop)
        {
            using (MySqlConnection conn = connectionHelper.GetConnection())
            {
                try
                {
                    conn.Open();
                    // Câu truy vấn SQL được điều chỉnh để kiểm tra giá trị của KhuyenMai
                    string query = "INSERT INTO loailaptop (IDLoaiLaptop, TenSP, GiaBan, Hang, CPU, RAM, GPU, HinhAnh, KichThuoc, KhuyenMai) " +
                                   "VALUES (@IDLoaiLaptop, @TenSP, @GiaBan, @Hang, @CPU, @RAM, @GPU, @HinhAnh, @KichThuoc, @KhuyenMai)";

                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@IDLoaiLaptop", laptop.IDLoaiLaptop);
                    cmd.Parameters.AddWithValue("@TenSP", laptop.TenSP);
                    cmd.Parameters.AddWithValue("@GiaBan", laptop.GiaBan);
                    cmd.Parameters.AddWithValue("@Hang", laptop.Hang);
                    cmd.Parameters.AddWithValue("@CPU", laptop.CPU);
                    cmd.Parameters.AddWithValue("@RAM", laptop.RAM);
                    cmd.Parameters.AddWithValue("@GPU", laptop.GPU);
                    cmd.Parameters.AddWithValue("@HinhAnh", laptop.HinhAnh);
                    cmd.Parameters.AddWithValue("@KichThuoc", laptop.KichThuoc);

                    // Kiểm tra giá trị của KhuyenMai và gán tham số phù hợp
                    if (string.IsNullOrEmpty(laptop.KhuyenMai))
                    {
                        cmd.Parameters.AddWithValue("@KhuyenMai", DBNull.Value); // Nếu KhuyenMai null, gán DBNull.Value
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@KhuyenMai", laptop.KhuyenMai); // Gán giá trị KhuyenMai nếu không null
                    }

                    cmd.ExecuteNonQuery();
                    return true;
                }
                catch (Exception ex)
                {
                    //MessageBox.Show("Error: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }


        public bool DeleteLaptop(string IDLoaiLaptop)
        {
            using (MySqlConnection conn = connectionHelper.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = "DELETE FROM loailaptop WHERE IDLoaiLaptop = @IDLoaiLaptop";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@IDLoaiLaptop", IDLoaiLaptop);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0; 
                }
                catch (Exception ex)
                {
                    //MessageBox.Show("Error: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }

        public bool UpdateLoaiLaptop(LoaiLaptopDTO laptop)
        {
            using (MySqlConnection conn = connectionHelper.GetConnection())
            {
                try
                {
                    conn.Open();
                    // Câu truy vấn SQL cho việc cập nhật thông tin laptop
                    string query = "UPDATE loailaptop SET TenSP = @TenSP, GiaBan = @GiaBan, Hang = @Hang, " +
                                   "CPU = @CPU, RAM = @RAM, GPU = @GPU, HinhAnh = @HinhAnh, KichThuoc = @KichThuoc, " +
                                   "KhuyenMai = @KhuyenMai WHERE IDLoaiLaptop = @IDLoaiLaptop";

                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    // Gán giá trị cho các tham số
                    cmd.Parameters.AddWithValue("@IDLoaiLaptop", laptop.IDLoaiLaptop);
                    cmd.Parameters.AddWithValue("@TenSP", laptop.TenSP);
                    cmd.Parameters.AddWithValue("@GiaBan", laptop.GiaBan);
                    cmd.Parameters.AddWithValue("@Hang", laptop.Hang);
                    cmd.Parameters.AddWithValue("@CPU", laptop.CPU);
                    cmd.Parameters.AddWithValue("@RAM", laptop.RAM);
                    cmd.Parameters.AddWithValue("@GPU", laptop.GPU);
                    cmd.Parameters.AddWithValue("@HinhAnh", laptop.HinhAnh);
                    cmd.Parameters.AddWithValue("@KichThuoc", laptop.KichThuoc);

                    // Kiểm tra giá trị của KhuyenMai và gán tham số phù hợp
                    if (string.IsNullOrEmpty(laptop.KhuyenMai))
                    {
                        cmd.Parameters.AddWithValue("@KhuyenMai", DBNull.Value); // Nếu KhuyenMai null, gán DBNull.Value
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@KhuyenMai", laptop.KhuyenMai); // Gán giá trị KhuyenMai nếu không null
                    }

                    cmd.ExecuteNonQuery();
                    return true;
                }
                catch (Exception ex)
                {
                    //MessageBox.Show("Error: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }

        public bool CheckIfIDExists(string idLoaiLaptop)
        {
            using (MySqlConnection conn = connectionHelper.GetConnection())
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM loailaptop WHERE IDLoaiLaptop = @IDLoaiLaptop";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@IDLoaiLaptop", idLoaiLaptop);

                int count = Convert.ToInt32(cmd.ExecuteScalar());
                return count > 0;
            }
        }

        public DataTable SearchLaptop(string searchTerm)
        {
            DataTable dt = new DataTable();
            using (MySqlConnection conn = connectionHelper.GetConnection())
            {
                conn.Open();
                string query = "SELECT * FROM loailaptop WHERE TenSP LIKE @TenSP";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@TenSP", "%" + searchTerm + "%");
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    da.Fill(dt);
                }
            }
            return dt;
        }


        public List<String> searchForComboBox(string searchTerm, string TenSP, string CPU, string RAM, string GPU, string TenHang, string KichThuoc, long GiaBan)
        {
            List<String> list = new List<String>();
            using (MySqlConnection conn = connectionHelper.GetConnection())
            {
                conn.Open();
                string query = @"
                        SELECT DISTINCT " + searchTerm + @"
                        FROM loailaptop ll
                        INNER JOIN hangsanxuat h ON ll.Hang = h.ID_Hang
                        WHERE ll.TenSP LIKE @TenSP 
                        AND ll.CPU LIKE @CPU 
                        AND ll.RAM LIKE @RAM
                        AND ll.GPU LIKE @GPU 
                        AND h.TenHang LIKE @TenHang
                        AND ll.KichThuoc LIKE @KichThuoc 
                        AND ll.GiaBan <= @GiaBan";

                MySqlCommand cmd = new MySqlCommand(query, conn);

                // Gán giá trị cho các tham số, thêm dấu `%` cho các tham số `LIKE`
                cmd.Parameters.AddWithValue("@TenSP", "%" + TenSP + "%");
                cmd.Parameters.AddWithValue("@CPU", "%" + CPU + "%");
                cmd.Parameters.AddWithValue("@RAM", "%" + RAM + "%");
                cmd.Parameters.AddWithValue("@GPU", "%" + GPU + "%");
                cmd.Parameters.AddWithValue("@TenHang", "%" + TenHang + "%");
                cmd.Parameters.AddWithValue("@KichThuoc", "%" + KichThuoc + "%");
                cmd.Parameters.AddWithValue("@GiaBan", GiaBan);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        // Thêm giá trị vào list từ cột tìm kiếm
                        list.Add(reader[searchTerm].ToString());
                    }
                }
            }

            return list;
        }


        public List<LoaiLaptopDTO> findWithCondition(string TenSP, string CPU, string RAM, string GPU, string TenHang, string KichThuoc, long GiaBan)
        {
            List<LoaiLaptopDTO> laptops = new List<LoaiLaptopDTO>();

            using (MySqlConnection conn = connectionHelper.GetConnection())
            {
                conn.Open();
                string query = @"
                        SELECT ll.*, h.TenHang, km.TenKhuyenMai
                        FROM loailaptop ll
                        LEFT JOIN hangsanxuat h ON ll.Hang = h.ID_Hang
                        LEFT JOIN khuyenmai km ON ll.KhuyenMai = km.ID_KhuyenMai
                        WHERE ll.TenSP LIKE @TenSP AND ll.CPU LIKE @CPU AND ll.RAM LIKE @RAM 
                              AND ll.GPU LIKE @GPU AND h.TenHang LIKE @TenHang 
                              AND ll.KichThuoc LIKE @KichThuoc AND ll.GiaBan <= @GiaBan";
                MySqlCommand cmd = new MySqlCommand(query, conn);

                // Gán giá trị cho các tham số, thêm dấu `%` cho các tham số `LIKE`
                cmd.Parameters.AddWithValue("@TenSP", "%" + TenSP + "%");
                cmd.Parameters.AddWithValue("@CPU", "%" + CPU + "%");
                cmd.Parameters.AddWithValue("@RAM", "%" + RAM + "%");
                cmd.Parameters.AddWithValue("@GPU", "%" + GPU + "%");
                cmd.Parameters.AddWithValue("@TenHang", "%" + TenHang + "%");
                cmd.Parameters.AddWithValue("@KichThuoc", "%" + KichThuoc + "%");
                cmd.Parameters.AddWithValue("@GiaBan",GiaBan);
               

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        LoaiLaptopDTO laptop = new LoaiLaptopDTO
                        {
                            IDLoaiLaptop = reader["IDLoaiLaptop"].ToString(),
                            TenSP = reader["TenSP"].ToString(),
                            GiaBan = long.Parse(reader["GiaBan"].ToString()),
                            Hang = reader["TenHang"].ToString(),
                            CPU = reader["CPU"].ToString(),
                            RAM = int.Parse(reader["RAM"].ToString()),
                            GPU = reader["GPU"].ToString(),
                            HinhAnh = reader["HinhAnh"].ToString(),
                            KichThuoc = reader["KichThuoc"].ToString(),
                            KhuyenMai = reader["TenKhuyenMai"].ToString(),
                            SLTonKho = reader["SLTonKho"].ToString()
                        };
                        laptops.Add(laptop);
                    }
                }
            }
            return laptops;
        }

        public List<LoaiLaptopDTO> GetLoaiLaptopByHang(string hang)
        {
            List<LoaiLaptopDTO> loaiLaptopList = new List<LoaiLaptopDTO>();

            using (MySqlConnection conn = connectionHelper.GetConnection())
            {
                conn.Open();
                string query = "SELECT IDLoaiLaptop, TenSP FROM loailaptop WHERE Hang = @hang";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@hang", hang);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        LoaiLaptopDTO loaiLaptop = new LoaiLaptopDTO
                        {
                            IDLoaiLaptop = reader["IDLoaiLaptop"].ToString(),
                            TenSP = reader["TenSP"].ToString(),
                        };
                        loaiLaptopList.Add(loaiLaptop);
                    }
                }
            }
            return loaiLaptopList;
        }


        public static bool CapNhatTonKhoKhiBan(int MaHD, MySqlTransaction transaction)
        {
            string query = @"
                            UPDATE LoaiLaptop
                            SET SLTonKho = (
                                SELECT COUNT(laptop.IMEI)
                                FROM laptop
                                WHERE laptop.LoaiLaptop = LoaiLaptop.IDLoaiLaptop AND laptop.TrangThai != 0
                            )
                            WHERE IDLoaiLaptop IN (
                                SELECT laptop.LoaiLaptop
                                FROM laptop
                                JOIN chitiethoadon ON chitiethoadon.IMEI = laptop.IMEI
                                JOIN hoadon ON chitiethoadon.ID_HoaDon = hoadon.ID_HoaDon
                                WHERE hoadon.ID_HoaDon = @MaHD
                            );";

            MySqlCommand command = new MySqlCommand(query, transaction.Connection, transaction);
            command.Parameters.AddWithValue("@MaHD", MaHD);

            return command.ExecuteNonQuery() > 0;
        }

    }
}
