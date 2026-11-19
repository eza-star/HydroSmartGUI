using System;
using System.Windows.Forms;
using HydroSmart.Models;
using HydroSmart.Services;

namespace HydroSmart.Forms
{
    /// <summary>Fitur 1: Kelola Tanaman (tambah, lihat, ubah, hapus).</summary>
    public partial class TanamanPage : HalamanBase
    {
        private bool _memuat = false;

        public TanamanPage(Layanan layanan) : base(layanan)
        {
            InitializeComponent();
            cmbJenis.SelectedIndex = 0;
        }

        public override void Muat()
        {
            _memuat = true;
            dgvTanaman.Rows.Clear();
            foreach (Tanaman t in L.Tanaman.Semua())
            {
                string ideal = "pH " + Tema.Fmt(t.PhMin) + "-" + Tema.Fmt(t.PhMax) + " | TDS " + t.TdsMin + "-" + t.TdsMax;
                dgvTanaman.Rows.Add(t.Id, t.Nama, t.Jenis, t.Lokasi, t.TanggalTanam.ToString("dd-MM-yyyy"),
                    t.UmurHari, t.FaseTumbuh(), t.EstimasiPanen.ToString("dd-MM-yyyy"), ideal);
            }
            dgvTanaman.ClearSelection();
            dgvTanaman.CurrentCell = null;
            _memuat = false;
        }

        private void BtnKosongkan_Click(object sender, EventArgs e)
        {
            KosongkanForm();
        }

        private void KosongkanForm()
        {
            cmbJenis.Enabled = true;
            cmbJenis.SelectedIndex = 0;
            txtNama.Clear();
            txtLokasi.Clear();
            dtpTanggal.Value = DateTime.Today;
            dgvTanaman.ClearSelection();
            dgvTanaman.CurrentCell = null;
        }

        private void Grid_SelectionChanged(object sender, EventArgs e)
        {
            if (_memuat) return;
            int id = IdTerpilih(dgvTanaman);
            if (id < 0) return;
            Tanaman t = L.Tanaman.Cari(id);
            if (t == null) return;

            cmbJenis.SelectedItem = t.Jenis;
            cmbJenis.Enabled = false;      // jenis tidak bisa diubah setelah dibuat
            txtNama.Text = t.Nama;
            txtLokasi.Text = t.Lokasi;
            dtpTanggal.Value = t.TanggalTanam;
        }

        private void BtnTambah_Click(object sender, EventArgs e)
        {
            if (txtNama.Text.Trim() == "" || txtLokasi.Text.Trim() == "")
            {
                Peringatan("Nama dan lokasi wajib diisi.");
                return;
            }
            Tanaman t = TanamanService.Buat(cmbJenis.SelectedIndex + 1, txtNama.Text, txtLokasi.Text.Trim(), dtpTanggal.Value.Date);
            L.Tanaman.Tambah(t);
            Muat();
            KosongkanForm();
            Info("Tanaman berhasil ditambahkan.\n\nTips: " + t.TipsPerawatan());
        }

        private void BtnUbah_Click(object sender, EventArgs e)
        {
            int id = IdTerpilih(dgvTanaman);
            if (id < 0)
            {
                Peringatan("Pilih dulu tanaman di tabel yang ingin diubah.");
                return;
            }
            Tanaman t = L.Tanaman.Cari(id);
            if (t == null) return;
            try
            {
                t.Nama = txtNama.Text;
                t.Lokasi = txtLokasi.Text.Trim();
                t.TanggalTanam = dtpTanggal.Value.Date;
            }
            catch (ArgumentException ex)
            {
                Peringatan(ex.Message);
                return;
            }
            Muat();
            KosongkanForm();
            Info("Data tanaman berhasil diubah.");
        }

        private void BtnHapus_Click(object sender, EventArgs e)
        {
            int id = IdTerpilih(dgvTanaman);
            if (id < 0)
            {
                Peringatan("Pilih dulu tanaman di tabel yang ingin dihapus.");
                return;
            }
            Tanaman t = L.Tanaman.Cari(id);
            if (t == null) return;
            if (!Tanya("Yakin hapus \"" + t.Nama + "\"?"))
                return;

            L.Tanaman.Hapus(id);
            Muat();
            KosongkanForm();
        }
    }
}
