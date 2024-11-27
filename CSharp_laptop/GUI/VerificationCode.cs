using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using CSharp_laptop.BUS;
using CSharp_laptop.DTO;

namespace CSharp_laptop.GUI
{
    internal class VerificationCode
    {
        string smtpServer = "smtp.gmail.com"; // Máy chủ SMTP
        int smtpPort = 587; // Cổng SMTP
        string emailFrom = "healthhub.service.infor@gmail.com"; // Email gửi
        string password = "nojzhmfmabofiknp"; // Mật khẩu ứng dụng email (hoặc mật khẩu email, tuỳ cách bảo mật)
        NhanVienBUS bus;

        public VerificationCode()
        {
            bus = new NhanVienBUS();
        }
        public string sendVerification(string maNV)
        {
            string verificationCode = GenerateVerificationCode(); // Tạo mã xác nhận
            NhanVienDTO nhav = bus.FindNhanVienById(maNV);
            if (nhav == null)
            {
                MessageBox.Show("Mã Nhân Viên không tồn tại!");
                return "Errror";
            }
            string emailTo = nhav.Email;

            try
            {
                // Thiết lập SMTP client
                SmtpClient smtpClient = new SmtpClient(smtpServer, smtpPort)
                {
                    Credentials = new NetworkCredential(emailFrom, password),
                    EnableSsl = true
                };

                // Tạo nội dung email
                MailMessage mailMessage = new MailMessage
                {
                    From = new MailAddress(emailFrom),
                    Subject = "Mã xác nhận của bạn",
                    Body = $"Xin chào,\n\nMã xác nhận của bạn là: {verificationCode}\n\nTrân trọng,\nTeam của bạn",
                    IsBodyHtml = false
                };

                // Thêm người nhận
                mailMessage.To.Add(emailTo);

                // Gửi email
                smtpClient.Send(mailMessage);
                MessageBox.Show("Gửi email thành công! hãy nhập vào ô xác nhận vừa hiện!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString);
            }
            return verificationCode;
        }

        static string GenerateVerificationCode()
        {
            // Tạo mã xác nhận ngẫu nhiên (6 chữ số)
            Random random = new Random();
            return random.Next(100000, 999999).ToString();
        }
    }
}
