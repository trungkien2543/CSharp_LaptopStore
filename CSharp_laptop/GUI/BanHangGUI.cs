using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_laptop.GUI
{
    public partial class BanHangGUI : Form
    {

        //private int row;
        //public BanHangGUI()
        //{
        //    InitializeComponent();

        //    SetHint(txtFindHD, "Nhập thông tin muốn tìm vào đây ....");

        //    // Thiết lập View của ListView thành Details
        //    tblHoaDon.View = View.Details;

        //    // Thêm cột vào ListView
        //    tblHoaDon.Columns.Add("Mã hóa đơn", 80); // Tên cột và chiều rộng (đơn vị pixel)
        //    tblHoaDon.Columns.Add("Mã nhân viên", 150);
        //    tblHoaDon.Columns.Add("Mã khách hàng", 200);
        //    tblHoaDon.Columns.Add("Ngày lập", 200);
        //    tblHoaDon.Columns.Add("Tổng tiền", 100);
        //    tblHoaDon.Columns.Add("Tiền giảm", 100);
        //    tblHoaDon.Columns.Add("Tiền thối", 100);
        //    tblHoaDon.Columns.Add("Tiền nhận", 100);


        //    // Tự động điều chỉnh kích thước cột

        //    //ResizeColumnsToFit();


        //    AddDataToListView();


        //}

        //private void AddDataToListView()
        //{
        //    // Thêm 10 hàng dữ liệu vào ListView
        //    for (int i = 1; i <= 10; i++)
        //    {
        //        ListViewItem item = new ListViewItem($"HD{i}"); // Mã hóa đơn
        //        item.SubItems.Add($"NV{i}"); // Mã nhân viên
        //        item.SubItems.Add($"KH{i}"); // Mã khách hàng
        //        item.SubItems.Add(DateTime.Now.AddDays(-i).ToString("dd/MM/yyyy")); // Ngày lập
        //        item.SubItems.Add((i * 100000).ToString("N0")); // Tổng tiền
        //        item.SubItems.Add((i * 10000).ToString("N0")); // Tiền giảm
        //        item.SubItems.Add(((i * 100000) - (i * 10000)).ToString("N0")); // Tiền thối
        //        item.SubItems.Add((i * 100000).ToString("N0")); // Tiền nhận

        //        // Thêm item vào ListView
        //        tblHoaDon.Items.Add(item);
        //    }
        //}

        //private void tabPage1_Click(object sender, EventArgs e)
        //{

        //}

        //private void BanHangGUI_Load(object sender, EventArgs e)
        //{

        //}

        //private void btnThemHD_Click(object sender, EventArgs e)
        //{
        //    // Chuyển sang tab thứ hai
        //    tabHoaDon.SelectedIndex = 1;
        //}

        //private void btnBack_Click(object sender, EventArgs e)
        //{
        //    tabHoaDon.SelectedIndex = 0;
        //}

        //// Thiết lập gợi ý
        //private void SetHint(TextBox textBox, string hintText)
        //{
        //    textBox.Text = hintText;
        //    textBox.ForeColor = Color.Gray;

        //    // Xử lý sự kiện khi người dùng nhấp vào TextBox
        //    textBox.Enter += (s, e) =>
        //    {
        //        if (textBox.Text == hintText)
        //        {
        //            textBox.Text = "";
        //            textBox.ForeColor = Color.Black; // Chuyển màu chữ lại thành bình thường
        //        }
        //    };

        //    // Xử lý sự kiện khi người dùng rời khỏi TextBox
        //    textBox.Leave += (s, e) =>
        //    {
        //        if (string.IsNullOrWhiteSpace(textBox.Text))
        //        {
        //            textBox.Text = hintText;
        //            textBox.ForeColor = Color.Gray; // Gợi ý hiện lại với màu xám
        //        }
        //    };
        //}


        //private void ResizeColumnsToFit()
        //{
        //    int totalWidth = tblHoaDon.ClientSize.Width; // Chiều rộng của ListView trừ đi 4 cột được set cứng rồi
        //    int columnCount = tblHoaDon.Columns.Count;

        //    if (columnCount > 0)
        //    {
        //        // Tính toán kích thước cho từng cột
        //        int columnWidth = totalWidth / columnCount;

        //        for (int i = 0; i < columnCount; i++)
        //        {
        //            tblHoaDon.Columns[i].Width = columnWidth; // Đặt chiều rộng cho từng cột
        //        }
        //    }
        //}

        //protected override void OnResize(EventArgs e)
        //{
        //    base.OnResize(e);
        //    ResizeColumnsToFit(); // Gọi lại khi form được phóng to
        //}

        //private void btnChuyenTrang_Click(object sender, EventArgs e)
        //{
        //    if (tabThemHoaDon.SelectedIndex == 1)
        //    {
        //        btnChuyenTrang.IconChar = FontAwesome.Sharp.IconChar.CircleInfo;
        //        btnChuyenTrang.Text = "Nhập thông tin chi tiết";
        //        tabThemHoaDon.SelectedIndex = 0;
        //    }
        //    else
        //    {
        //        btnChuyenTrang.IconChar = FontAwesome.Sharp.IconChar.CartShopping;
        //        btnChuyenTrang.Text = "Chọn sản phẩm";
        //        tabThemHoaDon.SelectedIndex = 1;
        //    }
        //}

        //private void progressBar1_Click(object sender, EventArgs e)
        //{

        //}

        //private void label1_Click(object sender, EventArgs e)
        //{

        //}

        //private void label3_Click(object sender, EventArgs e)
        //{

        //}

        //private void tblHoaDon_SelectedIndexChanged(object sender, EventArgs e)
        //{
          
        //}

        //private void txtMaHD_TextChanged(object sender, EventArgs e)
        //{

        //}

        //private void textBox2_TextChanged(object sender, EventArgs e)
        //{

        //}
    }
}
