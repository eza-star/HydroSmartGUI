using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using HydroSmart.Services;

namespace HydroSmart.Forms
{
    /// <summary>Warna, font, dan pembuat kontrol agar tampilan seragam.</summary>
    public static class Tema
    {
        public static readonly Color Hijau = ColorTranslator.FromHtml("#2E7D32");
        public static readonly Color HijauTua = ColorTranslator.FromHtml("#1B5E20");
        public static readonly Color HijauMuda = ColorTranslator.FromHtml("#E8F5E9");
        public static readonly Color Latar = ColorTranslator.FromHtml("#F4F8F4");
        public static readonly Color Abu = ColorTranslator.FromHtml("#546E7A");
        public static readonly Color Merah = ColorTranslator.FromHtml("#C62828");
        public static readonly Color Oranye = ColorTranslator.FromHtml("#EF6C00");
        public static readonly Color Biru = ColorTranslator.FromHtml("#1565C0");

        public static readonly Font FontNormal = new Font("Segoe UI", 10F);
        public static readonly Font FontSub = new Font("Segoe UI Semibold", 10F);
        public static readonly Font FontJudul = new Font("Segoe UI Semibold", 18F);
        public static readonly Font FontAngka = new Font("Segoe UI Semibold", 24F);

        public static string Fmt(double d)
        {
            return d.ToString("0.0#", CultureInfo.InvariantCulture);
        }

        public static Label Judul(string teks)
        {
            Label l = new Label();
            l.Text = teks;
            l.Dock = DockStyle.Top;
            l.Height = 64;
            l.Font = FontJudul;
            l.ForeColor = HijauTua;
            l.TextAlign = ContentAlignment.MiddleLeft;
            l.Padding = new Padding(20, 0, 0, 0);
            l.BackColor = Latar;
            return l;
        }

        public static Label Lbl(string teks, int x, int y)
        {
            Label l = new Label();
            l.Text = teks;
            l.Left = x;
            l.Top = y;
            l.AutoSize = true;
            l.Font = FontSub;
            l.ForeColor = Abu;
            return l;
        }

        public static Button Tombol(string teks, Color warna, int x, int y, int lebar)
        {
            Button b = new Button();
            b.Text = teks;
            b.Left = x;
            b.Top = y;
            b.Width = lebar;
            b.Height = 38;
            b.BackColor = warna;
            b.ForeColor = Color.White;
            b.FlatStyle = FlatStyle.Flat;
            b.FlatAppearance.BorderSize = 0;
            b.Font = FontSub;
            b.Cursor = Cursors.Hand;
            return b;
        }

        public static DataGridView Grid()
        {
            DataGridView g = new DataGridView();
            g.Dock = DockStyle.Fill;
            g.ReadOnly = true;
            g.AllowUserToAddRows = false;
            g.AllowUserToDeleteRows = false;
            g.AllowUserToResizeRows = false;
            g.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            g.MultiSelect = false;
            g.RowHeadersVisible = false;
            g.BackgroundColor = Color.White;
            g.BorderStyle = BorderStyle.None;
            g.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            g.EnableHeadersVisualStyles = false;
            g.ColumnHeadersDefaultCellStyle.BackColor = Hijau;
            g.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            g.ColumnHeadersDefaultCellStyle.SelectionBackColor = Hijau;
            g.ColumnHeadersDefaultCellStyle.Font = FontSub;
            g.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            g.ColumnHeadersHeight = 36;
            g.RowTemplate.Height = 30;
            g.DefaultCellStyle.SelectionBackColor = ColorTranslator.FromHtml("#A5D6A7");
            g.DefaultCellStyle.SelectionForeColor = Color.Black;
            g.AlternatingRowsDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#F7FBF7");
            return g;
        }
    }
}
