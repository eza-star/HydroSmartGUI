using System.Windows.Forms;
using HydroSmart.Models;
using HydroSmart.Services;

namespace HydroSmart.Forms
{
    /// <summary>Dashboard: ringkasan tanaman. Tampilan diedit lewat DashboardPage.Designer.cs (Designer).</summary>
    public partial class DashboardPage : HalamanBase
    {
        public DashboardPage(Layanan layanan) : base(layanan)
        {
            InitializeComponent();
        }

        public override void Muat()
        {
            dgvTanaman.Rows.Clear();
            int siapPanen = 0;
            foreach (Tanaman t in L.Tanaman.Semua())
            {
                string fase = t.FaseTumbuh();
                if (fase.StartsWith("Siap") || fase.StartsWith("Menjelang")) siapPanen++;
                dgvTanaman.Rows.Add(t.Nama, t.Jenis, t.Lokasi, t.UmurHari, fase, t.EstimasiPanen.ToString("dd-MM-yyyy"));
            }
            dgvTanaman.ClearSelection();

            lblTotal.Text = L.Tanaman.Semua().Count.ToString();
            lblPanen.Text = siapPanen.ToString();
            lblAnalisis.Text = L.Analisis.Riwayat().Count.ToString();
        }
    }
}
