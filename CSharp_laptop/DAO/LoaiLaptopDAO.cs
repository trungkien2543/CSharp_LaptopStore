using LaptopStore.DTO;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                            KhuyenMai = reader["TenKhuyenMai"].ToString()
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
                        SELECT ll.*, h.TenHang, km.TenKhuyenMai 
                        FROM loailaptop ll 
                        LEFT JOIN hangsanxuat h ON ll.Hang = h.ID_Hang 
                        LEFT JOIN khuyenmai km ON ll.KhuyenMai = km.ID_KhuyenMai 
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
                            Hang = reader["TenHang"].ToString(),
                            CPU = reader["CPU"].ToString(),
                            RAM = int.Parse(reader["RAM"].ToString()),
                            GPU = reader["GPU"].ToString(),
                            HinhAnh = reader["HinhAnh"].ToString(),
                            KichThuoc = reader["KichThuoc"].ToString(),
                            KhuyenMai = reader["TenKhuyenMai"].ToString()
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
                    MessageBox.Show("Error: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    MessageBox.Show("Error: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }

        public long GetNextID()
        {
            long nextId = 1; // Giả định ID bắt đầu từ 1
            using (MySqlConnection conn = connectionHelper.GetConnection())
            {
                conn.Open();
                string query = "SELECT MAX(IDLoaiLaptop) FROM loailaptop";
                MySqlCommand cmd = new MySqlCommand(query, conn);

                object result = cmd.ExecuteScalar();
                if (result != DBNull.Value)
                {
                    nextId = Convert.ToInt64(result) + 1; // Lấy ID lớn nhất và cộng thêm 1
                }
            }
            return nextId;
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
                    MessageBox.Show("Error: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
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
    }
}
