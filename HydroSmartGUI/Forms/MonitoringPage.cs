using System;
using System.Drawing;
using System.Windows.Forms;
using HydroSmart.Models;
using HydroSmart.Services;

namespace HydroSmart.Forms
{
    public partial class MonitoringPage : HalamanBase
    {
        private ComboBox _cmbTanaman = new();
        private NumericUpDown _numPh = new();
        private NumericUpDown _numTds = new();
        private NumericUpDown _numSuhu = new();
        private Panel _hasil = new();
        private Label _lblRingkas = new();
        private DataGridView _grid = new();

        public MonitoringPage() : base()
        {
            InitializeComponent();
        }

        public MonitoringPage(Layanan layanan) : base(layanan)
        {
            Bangun();
        }

        private void Bangun()
        {
            Label judul = Tema.Judul("Monitoring Nutrisi");
            judul.Location = new Point(24, 18);

            Label lblTanaman = Tema.Lbl("Tanaman", 24, 70);
            _cmbTanaman.Location = new Point(24, 92);
            _cmbTanaman.Size = new Size(330, 27);

            Label lblIdeal = Tema.Lbl("Kebutuhan ideal", 24, 125);
            lblIdeal.Width = 500;

            _numPh.Location = new Point(24, 155);
            _numPh.Size = new Size(100, 27);
            _numTds.Location = new Point(132, 155);
            _numTds.Size = new Size(100, 27);
            _numSuhu.Location = new Point(240, 155);
            _numSuhu.Size = new Size(100, 27);
            _numPh.DecimalPlaces = 1;
            _numPh.Increment = 0.1M;
            _numPh.Minimum = 0;
            _numPh.Maximum = 14;
            _numTds.Minimum = 0;
            _numTds.Maximum = 5000;
            _numSuhu.DecimalPlaces = 1;
            _numSuhu.Increment = 0.1M;
            _numSuhu.Minimum = 0;
            _numSuhu.Maximum = 60;

            Label lblPh = Tema.Lbl("pH larutan", 24, 180);
            Label lblTds = Tema.Lbl("TDS (ppm)", 132, 180);
            Label lblSuhu = Tema.Lbl("Suhu air (C)", 240, 180);

            Button simpan = Tema.Tombol("Simpan dan Evaluasi", Tema.Hijau, 24, 220, 180);
            simpan.Click += Simpan_Click;
            Button hapus = Tema.Tombol("Hapus Catatan", Tema.Merah, 212, 220, 150);
            hapus.Click += Hapus_Click;

            _hasil.Location = new Point(420, 85);
            _hasil.Size = new Size(430, 130);
            _hasil.BackColor = Color.FromArgb(247, 251, 247);
            Label lblHasil = Tema.Lbl("Hasil Evaluasi", 20, 18);
            lblHasil.Font = new Font("Segoe UI Semibold", 11F);
            _lblRingkas.Location = new Point(20, 55);
            _lblRingkas.Size = new Size(390, 55);
            _lblRingkas.Text = "Isi pengukuran lalu klik tombol Simpan dan Evaluasi.";
            _hasil.Controls.Add(lblHasil);
            _hasil.Controls.Add(_lblRingkas);

            _grid.Location = new Point(24, 290);
            _grid.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            _grid.Size = new Size(850, 180);
            _grid.ReadOnly = true;
            _grid.AllowUserToAddRows = false;
            _grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            _grid.MultiSelect = false;
            _grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            _grid.EnableHeadersVisualStyles = false;
            _grid.ColumnHeadersDefaultCellStyle.BackColor = Tema.Hijau;
            _grid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            _grid.Columns.Add("Id", "ID");
            _grid.Columns.Add("Waktu", "Waktu");
            _grid.Columns.Add("Ph", "pH");
            _grid.Columns.Add("Tds", "TDS (ppm)");
            _grid.Columns.Add("Suhu", "Suhu (C)");
            _grid.Columns.Add("StatusPh", "Status pH");
            _grid.Columns.Add("StatusTds", "Status TDS");
            _grid.Columns.Add("StatusSuhu", "Status Suhu");

            Controls.Add(judul);
            Controls.Add(lblTanaman); Controls.Add(_cmbTanaman);
            Controls.Add(lblIdeal);
            Controls.Add(_numPh); Controls.Add(_numTds); Controls.Add(_numSuhu);
            Controls.Add(lblPh); Controls.Add(lblTds); Controls.Add(lblSuhu);
            Controls.Add(simpan); Controls.Add(hapus);
            Controls.Add(_hasil); Controls.Add(_grid);
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
    }
}
