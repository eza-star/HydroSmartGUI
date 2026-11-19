using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using HydroSmart.Models;
using HydroSmart.Services;

namespace HydroSmart.Forms
{
    /// <summary>Fitur 2: Analisis Penyakit Tanaman berdasarkan gejala yang dipilih.</summary>
    public partial class AnalisisPage : HalamanBase
    {
        private class GejalaItem
        {
            public int Kode;
            public string Nama;
            public override string ToString() { return Nama; }
        }

        private readonly IDiagnosa _diagnosa;   // dipakai lewat interface

        public AnalisisPage(Layanan layanan) : base(layanan)
        {
            _diagnosa = layanan.Analisis;
            InitializeComponent();

            foreach (KeyValuePair<int, string> g in AnalisisService.DaftarGejala)
            {
                GejalaItem item = new GejalaItem();
                item.Kode = g.Key;
                item.Nama = g.Value;
                clbGejala.Items.Add(item);
            }
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < clbGejala.Items.Count; i++) clbGejala.SetItemChecked(i, false);
        }

        public override void Muat()
        {
            IsiComboTanaman(cmbTanaman);
            MuatRiwayat();
        }

        private void MuatRiwayat()
        {
            dgvRiwayat.Rows.Clear();
            foreach (HasilAnalisis h in L.Analisis.Riwayat())
            {
                dgvRiwayat.Rows.Add(h.Id, h.Waktu.ToString("dd-MM-yyyy HH:mm"), h.NamaTanaman, h.Diagnosa, h.Kecocokan + "%");
            }
            dgvRiwayat.ClearSelection();
        }

        private void BtnAnalisis_Click(object sender, EventArgs e)
        {
            Tanaman t = cmbTanaman.SelectedItem as Tanaman;
            if (t == null)
            {
                Peringatan("Pilih tanaman dulu.");
                return;
            }

            List<int> kode = new List<int>();
            foreach (object o in clbGejala.CheckedItems)
                kode.Add(((GejalaItem)o).Kode);

            if (kode.Count == 0)
            {
                Peringatan("Centang minimal satu gejala.");
                return;
            }

            HasilAnalisis h = _diagnosa.Diagnosa(t, kode);
            lblDiagnosa.Text = h.Diagnosa;
            lblDiagnosa.ForeColor = h.Diagnosa == "Belum dapat dipastikan" ? Tema.Oranye : Tema.Merah;
            lblKecocokan.Text = "Kecocokan: " + h.Kecocokan + "%";
            lblPenyebab.Text = "Penyebab: " + h.Penyebab;
            lblPenanganan.Text = "Penanganan: " + h.Penanganan;
            MuatRiwayat();
        }
    }
}
