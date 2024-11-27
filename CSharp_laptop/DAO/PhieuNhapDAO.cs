using CSharp_laptop.DTO;
using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
                string query = "SELECT * FROM phieunhap ORDER BY NgayNhap DESC";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
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
                            phieuNhapList.Add(phieuNhap);
                        }
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
                string query = "SELECT MAX(ID_PhieuNhap) FROM phieunhap";
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
                string query = "INSERT INTO phieunhap (ID_PhieuNhap, MaNV, MaNcc, TongTien, NgayNhap) VALUES (@ID_PhieuNhap, @MaNV, @MaNcc, @TongTien, @NgayNhap)";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ID_PhieuNhap", phieuNhap.ID);
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
                string query1 = "INSERT INTO laptop (IMEI, ThoiGianBaoHanh, TrangThai, LoaiLaptop) VALUES (@IMEI, @ThoiGianBaoHanh, @TrangThai, @LoaiLaptop)";
                using (MySqlCommand cmd = new MySqlCommand(query1, conn))
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

                string query2 = "INSERT INTO chitietphieunhap (IMEI, GiaNhap, ID_PhieuNhap)  VALUES (@IMEI, @GiaNhap, @ID_PhieuNhap)";
                using (MySqlCommand cmd = new MySqlCommand(query2, conn))
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

        public bool UpdateSoLuongSP(LoaiLapPnDTO llt)
        {
            bool isSuccess = false;
            using (MySqlConnection conn = connectionHelper.GetConnection())
            {
                conn.Open();
                string query = "UPDATE loailaptop SET SLTonKho = @SLTonKho WHERE IDLoaiLaptop = @IDLoaiLaptop";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@IDLoaiLaptop", llt.IDLoaiLaptop);
                    cmd.Parameters.AddWithValue("@SLTonKho", llt.SoLuong);
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

        public bool CheckIMEI(string imei)
        {
            using (MySqlConnection conn = connectionHelper.GetConnection())
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM laptop WHERE IMEI = @imei";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@imei", imei);
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    if (count > 0)
                    {
                        return true;
                    }
                    return false;
                }
            }
        }

        public bool CheckSPPN(int id)
        {
            using (MySqlConnection conn = connectionHelper.GetConnection())
            {
                conn.Open();
                string query = "SELECT laptop.TrangThai FROM chitietphieunhap INNER JOIN laptop ON chitietphieunhap.IMEI = laptop.IMEI WHERE chitietphieunhap.ID_PhieuNhap = @ID_PhieuNhap";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ID_PhieuNhap", id);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int tt = int.Parse(reader.ToString());
                            if (tt == 0)
                            {
                                return false;
                            }
                        }
                        return true;
                    }
                }
            }
        }

        public PhieuNhapDTO Get1PhieuNhapByID(int id)
        {
            PhieuNhapDTO phieuNhap = new PhieuNhapDTO();

            using (MySqlConnection conn = connectionHelper.GetConnection())
            {
                conn.Open();
                string query = "SELECT * FROM phieunhap WHERE ID_PhieuNhap = @id";
                using(MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            phieuNhap = new PhieuNhapDTO()
                            {
                                ID = int.Parse(reader["ID_PhieuNhap"].ToString()),
                                IDNV = reader["MaNV"].ToString(),
                                IDNCC = reader["MaNCC"].ToString(),
                                TongTien = int.Parse(reader["TongTIen"].ToString()),
                                NgayTao = reader.GetDateTime("NgayNhap")
                            };
                        }    
                    }
                }      
            }
            return phieuNhap;
        }
        public BindingList<ChiTietPhieuNhapDTO> GetChiTietPhieuNhap1(int id)
        {
            BindingList<ChiTietPhieuNhapDTO> ctpnList = new BindingList<ChiTietPhieuNhapDTO>();

            using (MySqlConnection conn = connectionHelper.GetConnection())
            {
                conn.Open();
                string query = "SELECT chitietphieunhap.IMEI, chitietphieunhap.GiaNhap, laptop.ThoiGianBaoHanh, laptop.LoaiLaptop FROM chitietphieunhap INNER JOIN laptop ON chitietphieunhap.IMEI = laptop.IMEI WHERE chitietphieunhap.ID_PhieuNhap = @ID_PhieuNhap";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ID_PhieuNhap", id);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ChiTietPhieuNhapDTO ctpn = new ChiTietPhieuNhapDTO()
                            {
                                IMEI = reader["IMEI"].ToString(),
                                IDLoaiLaptop = reader["LoaiLaptop"].ToString(),
                                ThoiGianBaoHanh = int.Parse(reader["ThoiGianBaoHanh"].ToString()),
                                GiaNhap = int.Parse(reader["GiaNhap"].ToString())
                            };
                            ctpnList.Add(ctpn);
                        }
                    }
                }
            }
            return ctpnList;
        }

        public BindingList<LoaiLapPnDTO> GetChiTietPhieuNhap2(int id)
        {
            BindingList<LoaiLapPnDTO> ctpn2List = new BindingList<LoaiLapPnDTO>();

            using (MySqlConnection conn = connectionHelper.GetConnection())
            {
                conn.Open();
                string query = "SELECT loailaptop.IDLoaiLaptop, loailaptop.TenSP, laptop.ThoiGianBaoHanh, chitietphieunhap.GiaNhap FROM chitietphieunhap INNER JOIN laptop ON chitietphieunhap.IMEI = laptop.IMEI INNER JOIN loailaptop ON laptop.LoaiLaptop = loailaptop.IDLoaiLaptop WHERE chitietphieunhap.ID_PhieuNhap = @ID_PhieuNhap";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ID_PhieuNhap", id);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int dem = 0;
                            string idLoaiLaptop = reader["IDLoaiLaptop"].ToString();
                            if (ctpn2List.Count > 0)
                            {
                                for (int i = 0; i < ctpn2List.Count; i++)
                                {
                                    if (idLoaiLaptop == ctpn2List[i].IDLoaiLaptop)
                                    {
                                        ctpn2List[i].SoLuong++;
                                        ctpn2List[i].ThanhTien += ctpn2List[i].GiaNhap;
                                        //ctpn2List.ResetBindings();
                                    }
                                    else
                                    {
                                        dem++;
                                    }  
                                }
                                if(dem == ctpn2List.Count)
                                {
                                    LoaiLapPnDTO ctpn2 = new LoaiLapPnDTO()
                                    {
                                        IDLoaiLaptop = idLoaiLaptop,
                                        TenSanPham = reader["TenSP"].ToString(),
                                        ThoiGianBaoHanh = int.Parse(reader["ThoiGianBaoHanh"].ToString()),
                                        GiaNhap = int.Parse(reader["GiaNhap"].ToString()),
                                        SoLuong = 1,
                                        ThanhTien = int.Parse(reader["GiaNhap"].ToString())
                                    };
                                    ctpn2List.Add(ctpn2);
                                }
                            }
                            else
                            {
                                LoaiLapPnDTO ctpn2 = new LoaiLapPnDTO()
                                {
                                    IDLoaiLaptop = idLoaiLaptop,
                                    TenSanPham = reader["TenSP"].ToString(),
                                    ThoiGianBaoHanh = int.Parse(reader["ThoiGianBaoHanh"].ToString()),
                                    GiaNhap = int.Parse(reader["GiaNhap"].ToString()),
                                    SoLuong = 1,
                                    ThanhTien = int.Parse(reader["GiaNhap"].ToString())
                                };
                                ctpn2List.Add(ctpn2);
                            }
                            
                        }
                    }
                }
            }
            return ctpn2List;
        }
        public BindingList<PhieuNhapDTO> TimKiem(string searchTerm)
        {
            BindingList<PhieuNhapDTO> phieuNhapList = new BindingList<PhieuNhapDTO>();
            DataTable dt = new DataTable();
            using (MySqlConnection conn = connectionHelper.GetConnection())
            {
                conn.Open();
                string query = @"SELECT * 
                         FROM phieunhap 
                         WHERE ID_PhieuNhap LIKE @SearchTerm 
                            OR MaNV LIKE @SearchTerm 
                            OR MaNcc LIKE @SearchTerm 
                            OR TongTien LIKE @SearchTerm 
                            OR NgayNhap LIKE @SearchTerm ORDER BY NgayNhap DESC";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@SearchTerm", "%" + searchTerm + "%");
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
                            phieuNhapList.Add(phieuNhap);
                        }
                    }
                }
            }
            return phieuNhapList;
        }
    }
}
