using System.Windows.Forms;
using HydroSmart.Models;
using HydroSmart.Services;

namespace HydroSmart.Forms
{
    /// <summary>
    /// Kelas dasar semua halaman konten (Inheritance + Polymorphism pada sisi tampilan).
    /// Sengaja TIDAK abstract dan punya constructor tanpa parameter supaya Designer Visual Studio bisa membukanya.
    /// </summary>
    public class HalamanBase : UserControl
    {
        protected readonly Layanan L;

        public HalamanBase()
        {
            BackColor = Tema.Latar;
            Font = Tema.FontNormal;
        }

        protected HalamanBase(Layanan layanan) : this()
        {
            L = layanan;
        }

        /// <summary>Dipanggil setiap halaman ditampilkan untuk menyegarkan data (di-override oleh tiap halaman).</summary>
        public virtual void Muat()
        {
        }

        protected void Info(string pesan)
        {
            MessageBox.Show(pesan, "HydroSmart", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        protected void Peringatan(string pesan)
        {
            MessageBox.Show(pesan, "HydroSmart", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        protected bool Tanya(string pesan)
        {
            return MessageBox.Show(pesan, "HydroSmart", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
        }

        /// <summary>Mengisi ComboBox dengan daftar tanaman dan mempertahankan pilihan sebelumnya.</summary>
        protected void IsiComboTanaman(ComboBox cmb)
        {
            int idLama = -1;
            Tanaman lama = cmb.SelectedItem as Tanaman;
            if (lama != null) idLama = lama.Id;

            cmb.Items.Clear();
            cmb.DisplayMember = "Nama";
            foreach (Tanaman t in L.Tanaman.Semua())
            {
                int i = cmb.Items.Add(t);
                if (t.Id == idLama) cmb.SelectedIndex = i;
            }
            if (cmb.SelectedIndex < 0 && cmb.Items.Count > 0)
                cmb.SelectedIndex = 0;
        }

        protected static int IdTerpilih(DataGridView grid)
        {
            if (grid.SelectedRows.Count == 0) return -1;
            return (int)grid.SelectedRows[0].Cells[0].Value;
        }
    }
}
