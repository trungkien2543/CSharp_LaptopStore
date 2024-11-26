﻿using CSharp_laptop.BUS;
using LaptopStore.DTO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using JsonSerializer = System.Text.Json.JsonSerializer;

namespace CSharp_laptop.GUI
{
    public partial class ChatGPT : Form
    {
        LoaiLaptopBUS loaiLaptopBUS;
        List<LoaiLaptopDTO> laptops;
        MainForm mf;


        public ChatGPT(MainForm mf)
        {
            InitializeComponent();
            this.mf = mf;
            loaiLaptopBUS = new LoaiLaptopBUS();
            laptops = loaiLaptopBUS.GetLaptops();
            this.TopMost = true;
        }

        private void ChatGPT_Load(object sender, EventArgs e)
        {

        }
        private async Task ChatGPTAsync(string chatrequest)
        {

            string laptopsJson = JsonConvert.SerializeObject(laptops, Formatting.Indented);

            // Thay thế API Key của bạn ở đây
            string apiKey = "";
            string endpoint = "https://api.openai.com/v1/chat/completions";

            var httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Add("Authorization", $"Bearer {apiKey}");

            // Nội dung body
            var requestBody = new
            {
                model = "gpt-3.5-turbo", // Hoặc "gpt-4"
                messages = new[]
                {
                new { role = "system", content = "Nhớ kỹ Bạn là Nhân Viên hoạt động trong kho hàng cho công cụ quản lý cửa hàng bán laptop " +
                "(chỉ tương tác với quản lý và nhân viên của cửa hàng). " +
                "Phần mềm được các thành viên Danh, Duy, Nam, Kiên(Trưởng nhóm), Tiến, Đức phát triển." +
                "Phầm mềm gồm các chức năng: Quản lý Sản phẩm(1), QL nhà sản xuất(2), Bán Hàng(3), QL Nhân Viên(4)" +
                "QL Khách Hàng(5), QL Khuyến mãi(6), QL Nhập Hàng(10), Xem Thống Kê(7), QL Tài Khoản(8), QL bảo hành(9). " +
                "Bạn trả lời kèm /GoTo<number> để code tự đến chức năng đấy giúp nhân viên. "+
                "bạn sẽ hỗ trợ cho người dùng(là nhân viên hoặc admin) quản lý các thông tin trong cửa hàng. " +
                "Nếu được hỏi các thông tin về laptop thì dựa vào đây(ưu tiên thông tin số lượng): "  + laptopsJson +  ". "  },
                new { role = "user", content = chatrequest }
            },
                max_tokens = 2000,
                temperature = 0.3
            };

            var content = new StringContent(JsonSerializer.Serialize(requestBody), Encoding.UTF8, "application/json");

            try
            {
                var response = await httpClient.PostAsync(endpoint, content);
                var responseString = await response.Content.ReadAsStringAsync();
                var json = JObject.Parse(responseString);

                // Lấy content
                string contentt = (string)json["choices"][0]["message"]["content"];

                // Hiển thị kết quả
                if (GetNumberAfterGoTo(contentt) != null)
                {
                    mf.moChucNang((int)GetNumberAfterGoTo(contentt));
                    //contentt = RemoveSentencesWithGoTo(contentt);
                }
                richTextBox1.AppendText("\n>> Bot: " + contentt);
            }
            catch (Exception ex)
            {
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                richTextBox1.Text += "\n>> Bạn: " + textBox1.Text;


                if (GetNumberAfterGoTo(textBox1.Text) != null)
                {
                    mf.moChucNang((int)GetNumberAfterGoTo(textBox1.Text));
                } else 
                    ChatGPTAsync(textBox1.Text);
                textBox1.Text = "";
            }
        }
        public int? GetNumberAfterGoTo(string input)
        {
            if (string.IsNullOrEmpty(input))
                return null;

            Regex regex = new Regex(@"/GoTo(\d+)");
            Match match = regex.Match(input);

            if (match.Success)
            {
                if (int.TryParse(match.Groups[1].Value, out int number))
                {
                    return number;
                }
            }
            return null;
        }
        public string RemoveSentencesWithGoTo(string input)
        {
            if (string.IsNullOrEmpty(input))
                return input;

            // Tách chuỗi thành các câu dựa trên dấu chấm (.)
            string[] sentences = input.Split(new[] { '.' }, StringSplitOptions.RemoveEmptyEntries);

            // Lọc bỏ các câu chứa "/GoTo"
            var filteredSentences = sentences
                .Where(sentence => !sentence.Contains("/GoTo"))
                .Select(sentence => sentence.Trim()); // Xóa khoảng trắng thừa

            // Ghép lại thành chuỗi với dấu chấm (.)
            return string.Join(". ", filteredSentences) + ".";
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            richTextBox1.SelectionStart = richTextBox1.TextLength;
            richTextBox1.ScrollToCaret();
        }
    }
}
