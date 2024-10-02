using LaptopStore.DTO;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_laptop.DAO
{
    internal class SanPhamDAO
    {
        private MySqlConnectionHelper connectionHelper = new MySqlConnectionHelper();

        public List<SanPhamDTO> GetAllLaptops()
        {
            List<SanPhamDTO> laptops = new List<SanPhamDTO>();

            using (MySqlConnection conn = connectionHelper.GetConnection())
            {
                conn.Open();
                string query = "SELECT * FROM loai_laptop";
                MySqlCommand cmd = new MySqlCommand(query, conn);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        SanPhamDTO laptop = new SanPhamDTO
                        {
                            IDLaptop = reader["IDLaptop"].ToString(),
                            TenSP = reader["TenSP"].ToString(),
                            GiaBan = long.Parse(reader["GiaBan"].ToString()),
                            Hang = reader["Hang"].ToString(),
                            CPU = reader["CPU"].ToString(),
                            RAM = int.Parse(reader["RAM"].ToString()),
                            GPU = reader["GPU"].ToString(),
                            HinhAnh = reader["HinhAnh"].ToString(),
                            KichThuoc = reader["KichThuoc"].ToString(),
                            KhuyenMai = reader["KhuyenMai"].ToString()
                        };
                        laptops.Add(laptop);
                    }
                }
            }
            return laptops;
        }

        public SanPhamDTO GetLaptopByID(string idLaptop)
        {
            SanPhamDTO laptop = null;  // Khởi tạo null để kiểm tra nếu không tìm thấy laptop

            using (MySqlConnection conn = connectionHelper.GetConnection())
            {
                conn.Open();
                string query = "SELECT * FROM loai_laptop WHERE IDLaptop = @IDLaptop";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@IDLaptop", idLaptop);  // Thêm tham số vào câu lệnh SQL

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())  // Chỉ lấy 1 bản ghi
                    {
                        laptop = new SanPhamDTO
                        {
                            IDLaptop = reader["IDLaptop"].ToString(),
                            TenSP = reader["TenSP"].ToString(),
                            GiaBan = long.Parse(reader["GiaBan"].ToString()),
                            Hang = reader["Hang"].ToString(),
                            CPU = reader["CPU"].ToString(),
                            RAM = int.Parse(reader["RAM"].ToString()),
                            GPU = reader["GPU"].ToString(),
                            HinhAnh = reader["HinhAnh"].ToString(),
                            KichThuoc = reader["KichThuoc"].ToString(),
                            KhuyenMai = reader["KhuyenMai"].ToString()
                        };
                    }
                }
            }
            return laptop;  // Trả về đối tượng laptop hoặc null nếu không tìm thấy
        }


        public bool InsertLoaiLaptop(SanPhamDTO laptop)
        {

            string message = $"ID Laptop: {laptop.IDLaptop}\n" +
                     $"Tên SP: {laptop.TenSP}\n" +
                     $"Giá bán: {laptop.GiaBan}\n" +
                     $"Hãng: {laptop.Hang}\n" +
                     $"CPU: {laptop.CPU}\n" +
                     $"RAM: {laptop.RAM}\n" +
                     $"GPU: {laptop.GPU}\n" +
                     $"Hình ảnh: {laptop.HinhAnh}\n" +
                     $"Kích thước: {laptop.KichThuoc}\n" +
                     $"Khuyến mãi: {laptop.KhuyenMai}";

            MessageBox.Show(message, "Thông tin Laptop", MessageBoxButtons.OK, MessageBoxIcon.Information);

            using (MySqlConnection conn = connectionHelper.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO loai_laptop (IDLaptop, TenSP, GiaBan, Hang, CPU, RAM, GPU, HinhAnh, KichThuoc, KhuyenMai) " +
                                   "VALUES (@IDLaptop, @TenSP, @GiaBan, @Hang, @CPU, @RAM, @GPU, @HinhAnh, @KichThuoc, @KhuyenMai)";
                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@IDLaptop", laptop.IDLaptop);
                    cmd.Parameters.AddWithValue("@TenSP", laptop.TenSP);
                    cmd.Parameters.AddWithValue("@GiaBan", laptop.GiaBan);
                    cmd.Parameters.AddWithValue("@Hang", laptop.Hang);
                    cmd.Parameters.AddWithValue("@CPU", laptop.CPU);
                    cmd.Parameters.AddWithValue("@RAM", laptop.RAM);
                    cmd.Parameters.AddWithValue("@GPU", laptop.GPU);
                    cmd.Parameters.AddWithValue("@HinhAnh", laptop.HinhAnh);
                    cmd.Parameters.AddWithValue("@KichThuoc", laptop.KichThuoc);
                    cmd.Parameters.AddWithValue("@KhuyenMai", laptop.KhuyenMai);

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

        public bool DeleteLaptop(string idLaptop)
        {
            using (MySqlConnection conn = connectionHelper.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = "DELETE FROM loai_laptop WHERE IDLaptop = @idLaptop";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@IDLaptop", idLaptop);

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
