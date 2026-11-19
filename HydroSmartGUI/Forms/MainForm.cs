using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using HydroSmart.Services;

namespace HydroSmart.Forms
{
    /// <summary>Jendela utama: sidebar navigasi + area konten untuk dashboard dan 2 fitur.</summary>
    public class MainForm : Form
    {
        private readonly Layanan _l;
        private Panel _isi;
        private readonly List<Button> _tombolNav = new List<Button>();
        private Button _aktif;

        public MainForm(Layanan layanan)
        {
            _l = layanan;
            Bangun();
        }

        private void Bangun()
        {
            Text = "HydroSmart - Hidroponik Pintar";
            ClientSize = new Size(1180, 720);
            MinimumSize = new Size(1000, 640);
            StartPosition = FormStartPosition.CenterScreen;
            Font = Tema.FontNormal;
            BackColor = Tema.Latar;

            _isi = new Panel();
            _isi.Dock = DockStyle.Fill;
            _isi.BackColor = Tema.Latar;

            Panel sidebar = new Panel();
            sidebar.Dock = DockStyle.Left;
            sidebar.Width = 240;
            sidebar.BackColor = Tema.HijauTua;

            // Header sidebar
            Panel header = new Panel();
            header.Dock = DockStyle.Top;
            header.Height = 115;
            header.BackColor = Tema.HijauTua;

            Label brand = new Label();
            brand.Text = "HydroSmart";
            brand.Font = new Font("Segoe UI Semibold", 18F);
            brand.ForeColor = Color.White;
            brand.AutoSize = true;
            brand.Left = 20;
            brand.Top = 18;

            Label user = new Label();
            user.Text = _l.Auth.UserAktif.NamaLengkap + "\r\n(" + _l.Auth.UserAktif.Role + ")";
            user.Font = new Font("Segoe UI", 10F);
            user.ForeColor = Color.FromArgb(200, 230, 201);
            user.AutoSize = true;
            user.Left = 22;
            user.Top = 60;

            header.Controls.Add(brand);
            header.Controls.Add(user);

            // Navigasi
            FlowLayoutPanel nav = new FlowLayoutPanel();
            nav.Dock = DockStyle.Fill;
            nav.FlowDirection = FlowDirection.TopDown;
            nav.WrapContents = false;
            nav.BackColor = Tema.HijauTua;

            // Halaman-halaman
            HalamanBase dashboard = new DashboardPage(_l);
            TambahNav(nav, "Dashboard", dashboard);
            TambahNav(nav, "1. Kelola Tanaman", new TanamanPage(_l));
            TambahNav(nav, "2. Analisis Penyakit", new AnalisisPage(_l));

            sidebar.Controls.Add(nav);
            sidebar.Controls.Add(header);

            Controls.Add(_isi);
            Controls.Add(sidebar);

            Buka(dashboard, _tombolNav[0]);
        }

        private void TambahNav(FlowLayoutPanel nav, string teks, HalamanBase halaman)
        {
            Button b = new Button();
            b.Text = teks;
            b.Width = 240;
            b.Height = 50;
            b.Margin = new Padding(0);
            b.FlatStyle = FlatStyle.Flat;
            b.FlatAppearance.BorderSize = 0;
            b.BackColor = Tema.HijauTua;
            b.ForeColor = Color.White;
            b.Font = Tema.FontNormal;
            b.TextAlign = ContentAlignment.MiddleLeft;
            b.Padding = new Padding(20, 0, 0, 0);
            b.Cursor = Cursors.Hand;
            b.Click += delegate { Buka(halaman, b); };
            _tombolNav.Add(b);
            nav.Controls.Add(b);
        }

        private void Buka(HalamanBase halaman, Button tombol)
        {
            if (_aktif != null) _aktif.BackColor = Tema.HijauTua;
            _aktif = tombol;
            _aktif.BackColor = Tema.Hijau;

            _isi.Controls.Clear();
            halaman.Dock = DockStyle.Fill;
            _isi.Controls.Add(halaman);
            halaman.Muat();
        }
    }
}
