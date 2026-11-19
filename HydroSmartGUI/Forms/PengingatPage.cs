using System;
using System.Windows.Forms;
using HydroSmart.Models;
using HydroSmart.Services;

namespace HydroSmart.Forms
{
    public partial class PengingatPage : HalamanBase
    {
        public PengingatPage() : base()
        {
            InitializeComponent();
        }

        public PengingatPage(Layanan layanan) : base(layanan)
        {
            InitializeComponent();
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

        private void PengingatPage_Load(object sender, EventArgs e)
        {

        }
    }
}
