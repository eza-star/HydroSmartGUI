using System;
using System.Windows.Forms;
using HydroSmart.Forms;
using HydroSmart.Services;

namespace HydroSmart
{
    internal static class Program
    {
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.SetHighDpiMode(HighDpiMode.SystemAware);

            Layanan layanan = new Layanan();
            DataAwal.Isi(layanan);

            // Alur: login -> form utama (tutup jendela = keluar aplikasi)
            DialogResult hasil;
            using (LoginForm login = new LoginForm(layanan.Auth))
            {
                hasil = login.ShowDialog();
            }
            if (hasil != DialogResult.OK) return;

            Application.Run(new MainForm(layanan));
        }
    }
}
