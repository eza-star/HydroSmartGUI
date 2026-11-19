using System;
using System.Drawing;
using System.Windows.Forms;
using HydroSmart.Models;
using HydroSmart.Services;

namespace HydroSmart.Forms
{
    public partial class PengingatPage : HalamanBase
    {
        private ComboBox _cmbTanaman = new();
        private ComboBox _cmbKegiatan = new();
        private DateTimePicker _dtpJadwal = new();
        private DataGridView _grid = new();

        public PengingatPage() : base()
        {
            InitializeComponent();
        }

        public PengingatPage(Layanan layanan) : base(layanan)
        {
            Bangun();
        }

        private void Bangun()
        {
            Label judul = Tema.Judul("Pengingat Perawatan");
            judul.Location = new Point(24, 18);

            Label lblTanaman = Tema.Lbl("Tanaman", 24, 70);
            _cmbTanaman.Location = new Point(24, 92);
            _cmbTanaman.Size = new Size(250, 27);

            Label lblKegiatan = Tema.Lbl("Kegiatan", 292, 70);
            _cmbKegiatan.Location = new Point(292, 92);
            _cmbKegiatan.Size = new Size(250, 27);
            _cmbKegiatan.Items.AddRange(new object[] { "CekpH", "GantiNutrisi", "Pembersihan", "Penyiraman" });

            Label lblTanggal = Tema.Lbl("Tanggal jadwal", 560, 70);
            _dtpJadwal.Location = new Point(560, 92);
            _dtpJadwal.Size = new Size(220, 27);

            Button tambah = Tema.Tombol("Tambah Pengingat", Tema.Hijau, 24, 132, 170);
            tambah.Click += Tambah_Click;
            Button selesai = Tema.Tombol("Tandai Selesai", Tema.Biru, 202, 132, 150);
            selesai.Click += Selesai_Click;
            Button hapus = Tema.Tombol("Hapus", Tema.Merah, 360, 132, 120);
            hapus.Click += Hapus_Click;

            _grid.Location = new Point(24, 190);
            _grid.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            _grid.Size = new Size(900, 180);
            _grid.ReadOnly = true;
            _grid.AllowUserToAddRows = false;
            _grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            _grid.MultiSelect = false;
            _grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            _grid.EnableHeadersVisualStyles = false;
            _grid.ColumnHeadersDefaultCellStyle.BackColor = Tema.Hijau;
            _grid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            _grid.Columns.Add("Id", "ID");
            _grid.Columns.Add("Jadwal", "Jadwal");
            _grid.Columns.Add("Tanaman", "Tanaman");
            _grid.Columns.Add("Kegiatan", "Kegiatan");
            _grid.Columns.Add("Status", "Status");

            Controls.Add(judul);
            Controls.Add(lblTanaman); Controls.Add(_cmbTanaman);
            Controls.Add(lblKegiatan); Controls.Add(_cmbKegiatan);
            Controls.Add(lblTanggal); Controls.Add(_dtpJadwal);
            Controls.Add(tambah); Controls.Add(selesai); Controls.Add(hapus);
            Controls.Add(_grid);
        }

        public override void Muat()
        {
            IsiComboTanaman(_cmbTanaman);
            if (_cmbKegiatan.SelectedIndex < 0 && _cmbKegiatan.Items.Count > 0)
                _cmbKegiatan.SelectedIndex = 0;
            MuatGrid();
        }

        private void MuatGrid()
        {
            _grid.Rows.Clear();
            foreach (Pengingat p in L.Perawatan.Semua())
                _grid.Rows.Add(p.Id, p.Jadwal.ToString("dd-MM-yyyy"), p.NamaTanaman, p.Kegiatan, p.Status);
            _grid.ClearSelection();
        }

        private void Tambah_Click(object sender, EventArgs e)
        {
            Tanaman tanaman = _cmbTanaman.SelectedItem as Tanaman;
            if (tanaman == null)
            {
                Peringatan("Pilih tanaman dulu.");
                return;
            }
            L.Perawatan.Tambah(new Pengingat
            {
                NamaTanaman = tanaman.Nama,
                Jadwal = _dtpJadwal.Value.Date,
                Kegiatan = _cmbKegiatan.SelectedItem?.ToString() ?? "CekpH"
            });
            MuatGrid();
            Info("Pengingat berhasil ditambahkan.");
        }

        private void Selesai_Click(object sender, EventArgs e)
        {
            int id = IdTerpilih(_grid);
            if (id < 0) { Peringatan("Pilih pengingat di tabel."); return; }
            L.Perawatan.TandaiSelesai(id);
            MuatGrid();
        }

        private void Hapus_Click(object sender, EventArgs e)
        {
            int id = IdTerpilih(_grid);
            if (id < 0) { Peringatan("Pilih pengingat di tabel."); return; }
            if (!Tanya("Yakin hapus pengingat ini?")) return;
            L.Perawatan.Hapus(id);
            MuatGrid();
        }
    }
}
