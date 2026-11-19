using System;
using System.Windows.Forms;
using HydroSmart.Models;
using HydroSmart.Services;

namespace HydroSmart.Forms
{
    public partial class MonitoringPage : HalamanBase
    {
        public MonitoringPage() : base()
        {
            InitializeComponent();
        }

        public MonitoringPage(Layanan layanan) : base(layanan)
        {
            InitializeComponent();
        }

        public override void Muat()
        {
            IsiComboTanaman(_cmbTanaman);
            if (_cmbTanaman.SelectedItem is Tanaman tanaman)
            {
                _numPh.Value = (decimal)((tanaman.PhMin + tanaman.PhMax) / 2);
                _numTds.Value = (tanaman.TdsMin + tanaman.TdsMax) / 2;
                _numSuhu.Value = 24;
            }
            MuatGrid();
        }

        private void MuatGrid()
        {
            _grid.Rows.Clear();
            foreach (CatatanNutrisi c in L.Nutrisi.Semua())
            {
                _grid.Rows.Add(c.Id, c.Waktu.ToString("dd-MM-yyyy HH:mm"), c.PH.ToString("0.0"),
                    c.Tds, c.Suhu.ToString("0.0"), c.StatusPH, c.StatusTds, c.StatusSuhu);
            }
            _grid.ClearSelection();
        }

        private void Simpan_Click(object sender, EventArgs e)
        {
            Tanaman tanaman = _cmbTanaman.SelectedItem as Tanaman;
            if (tanaman == null)
            {
                Peringatan("Pilih tanaman dulu.");
                return;
            }

            CatatanNutrisi c = L.Nutrisi.Tambah(tanaman.Nama,
                (double)_numPh.Value, (int)_numTds.Value, (double)_numSuhu.Value,
                tanaman.PhMin, tanaman.PhMax, tanaman.TdsMin, tanaman.TdsMax);

            _lblRingkas.Text = string.Format("pH: {0}\r\nTDS: {1}\r\nSuhu: {2} C",
                c.StatusPH, c.StatusTds, c.StatusSuhu);
            MuatGrid();
        }

        private void Hapus_Click(object sender, EventArgs e)
        {
            if (!Tanya("Hapus seluruh catatan nutrisi?")) return;
            L.Nutrisi.HapusSemua();
            _lblRingkas.Text = "Isi pengukuran lalu klik tombol Simpan dan Evaluasi.";
            MuatGrid();
        }

        private void _hasil_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
