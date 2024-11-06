﻿using CSharp_laptop.DAO;
using LiveChartsCore.SkiaSharpView.Painting;
using LiveChartsCore.SkiaSharpView;
using LiveChartsCore;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomTabControl
{
    public partial class DoanhThu : UserControl
    {
        public DoanhThu()
        {
            InitializeComponent();
            LoadStatisticTypes(); // Tải các loại thống kê vào ComboBox ccbType


            // Đăng ký sự kiện cho ccbType
            ccbType.SelectedIndexChanged += ccbType_SelectedIndexChanged;
        }

        // Hàm để tải các loại thống kê vào ComboBox ccbType
        private void LoadStatisticTypes()
        {
            ccbType.Items.Clear();
            ccbType.Items.Add("Theo năm");
            ccbType.Items.Add("Theo tháng");
            ccbType.SelectedIndex = 0; // Mặc định là "Theo năm"
            ccbMonth.Visible = false;
            lblMonth.Visible = false;
            LoadYears();
        }

        // Xử lý khi thay đổi loại thống kê
        private void ccbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Nếu chọn "Theo năm", ẩn ComboBox tháng
            if (ccbType.SelectedItem.ToString() == "Theo năm")
            {
                ccbMonth.Visible = false;
                LoadChartDataByYear(ccbYear.SelectedItem.ToString());
            }
            else
            {
                // Nếu chọn "Theo tháng", hiện ComboBox tháng
                ccbMonth.Visible = true;
                lblMonth.Visible = true;
                LoadMonthsForYear(ccbYear.SelectedItem.ToString());

                LoadChartDataByMonth(ccbYear.SelectedItem?.ToString(), ccbMonth.SelectedItem?.ToString());
            }
        }

        // Hàm để điền các năm vào ComboBox
        private void LoadYears()
        {
            // Xóa các mục cũ nếu có
            ccbYear.Items.Clear();

            // Sử dụng MySqlConnectionHelper để kết nối CSDL
            MySqlConnectionHelper connectionHelper = new MySqlConnectionHelper();

            using (var connection = connectionHelper.GetConnection())
            {
                connection.Open();

                // Truy vấn để lấy danh sách các năm có trong bảng hoadon
                var command = new MySqlCommand("SELECT DISTINCT YEAR(NgayLap) AS Nam FROM hoadon ORDER BY Nam;", connection);

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        // Lấy giá trị năm từ kết quả truy vấn và thêm vào ComboBox
                        int year = reader.GetInt32("Nam");
                        ccbYear.Items.Add(year.ToString());
                    }
                }
            }

            // Kiểm tra xem ComboBox có mục nào không
            if (ccbYear.Items.Count > 0)
            {
                ccbYear.SelectedIndex = ccbYear.Items.Count - 1; // Chọn mặc định là năm cuối cùng trong danh sách
            }
            else
            {
                MessageBox.Show("Không có dữ liệu năm nào trong cơ sở dữ liệu!");
            }
        }

        // Hàm để điền các tháng theo năm vào ComboBox
        private void LoadMonthsForYear(string year)
        {
            // Xóa các mục cũ nếu có
            ccbMonth.Items.Clear();

            MySqlConnectionHelper connectionHelper = new MySqlConnectionHelper();

            using (var connection = connectionHelper.GetConnection())
            {
                connection.Open();

                // Truy vấn để lấy danh sách các tháng có trong bảng hoadon cho năm đã chọn
                var command = new MySqlCommand("SELECT DISTINCT MONTH(NgayLap) AS Thang FROM hoadon WHERE YEAR(NgayLap) = @year ORDER BY Thang;", connection);
                command.Parameters.AddWithValue("@year", year); // Sử dụng parameter để tránh SQL Injection

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        // Lấy giá trị tháng từ kết quả truy vấn và thêm vào ComboBox
                        int month = reader.GetInt32("Thang");
                        ccbMonth.Items.Add(month);
                    }
                }
            }

            // Kiểm tra xem ComboBox có mục nào không
            if (ccbMonth.Items.Count > 0)
            {
                ccbMonth.SelectedIndex = 0; // Chọn mặc định là tháng đầu tiên trong danh sách
            }
            else
            {
                MessageBox.Show("Không có dữ liệu tháng nào trong cơ sở dữ liệu cho năm đã chọn!");
            }
        }


        // Hàm để tải dữ liệu vào biểu đồ theo năm
        private void LoadChartDataByYear(string year)
        {
            if (string.IsNullOrEmpty(year)) return;

            var months = new List<string>();
            var revenue = new List<double>();

            MySqlConnectionHelper connectionHelper = new MySqlConnectionHelper();

            using (var connection = connectionHelper.GetConnection())
            {
                connection.Open();
                var command = new MySqlCommand($"SELECT MONTH(NgayLap) AS Thang, SUM(TongTien) AS DoanhThu FROM hoadon WHERE YEAR(NgayLap) = @year GROUP BY MONTH(NgayLap) ORDER BY Thang;", connection);
                command.Parameters.AddWithValue("@year", year);

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int month = reader.GetInt32("Thang");
                        months.Add("Tháng " + month.ToString());
                        revenue.Add(reader.GetDouble("DoanhThu"));
                    }
                }
            }

            UpdateChart(months, revenue);
        }

        // Hàm để tải dữ liệu vào biểu đồ theo tháng
        private void LoadChartDataByMonth(string year, string month)
        {
            if (string.IsNullOrEmpty(year) || string.IsNullOrEmpty(month)) return;

            var days = new List<string>();
            var revenue = new List<double>();

            MySqlConnectionHelper connectionHelper = new MySqlConnectionHelper();

            using (var connection = connectionHelper.GetConnection())
            {
                connection.Open();
                var command = new MySqlCommand($"SELECT DAY(NgayLap) AS Ngay, SUM(TongTien) AS DoanhThu FROM hoadon WHERE YEAR(NgayLap) = @year AND MONTH(NgayLap) = @month GROUP BY DAY(NgayLap) ORDER BY Ngay;", connection);
                command.Parameters.AddWithValue("@year", year);
                command.Parameters.AddWithValue("@month", month);

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int day = reader.GetInt32("Ngay");
                        days.Add("Ngày " + day.ToString());
                        revenue.Add(reader.GetDouble("DoanhThu"));
                    }
                }
            }

            UpdateChart(days, revenue);
        }

        // Hàm để cập nhật biểu đồ
        private void UpdateChart(List<string> labels, List<double> values)
        {
            var series = new LineSeries<double>
            {
                Values = values,
                Name = "Doanh Thu:",
                Stroke = new SolidColorPaint(new SkiaSharp.SKColor(0, 176, 240)),
                Fill = null
            };

            cartesianChart1.Series = new ISeries[] { series };

            cartesianChart1.XAxes = new Axis[]
            {
        new Axis { Labels = labels.ToArray() }
            };

            cartesianChart1.YAxes = new Axis[]
            {
        new Axis
        {
            Name = "Doanh Thu (VNĐ)"
        }
            };

            cartesianChart1.Update();
        }

        private void panelTitle_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ccbYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Lấy năm được chọn
            string selectedYear = ccbYear.SelectedItem?.ToString();

            if (ccbType.SelectedItem.ToString() == "Theo năm")
            {
                LoadChartDataByYear(selectedYear);
            }
            else if (ccbType.SelectedItem.ToString() == "Theo tháng")
            {
                LoadMonthsForYear(selectedYear);
                LoadChartDataByMonth(selectedYear, ccbMonth.SelectedItem?.ToString());
            }
        }

        private void ccbMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadChartDataByMonth(ccbYear.SelectedItem?.ToString(), ccbMonth.SelectedItem?.ToString());
        }

        private void panelTong_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}