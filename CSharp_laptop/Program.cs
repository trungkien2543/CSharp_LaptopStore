using CSharp_laptop.GUI;

namespace CSharp_laptop
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            MainForm mainf = new MainForm("NV001");
            Application.Run(mainf);

            //// Hiển thị SplashForm
            //SplashForm splash = new SplashForm();
            //splash.Show();

            //// Load Form chính ở chế độ nền
            //Task.Run(() =>
            //{
            //    // Giả lập công việc load của form chính (ví dụ, load dữ liệu, tài nguyên, etc.)



            //    MainForm mainf = new MainForm("NV001");
            //    // Khởi tạo và hiển thị MainForm sau khi đã load xong
            //    splash.Invoke(new Action(() => splash.Close())); // Đóng SplashForm
            //    Application.Run(mainf); // Hiển thị MainForm

            //});

            //Application.Run();
        }
    }
}