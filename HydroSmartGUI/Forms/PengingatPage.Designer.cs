using System.Drawing;
using System.Windows.Forms;

namespace HydroSmart.Forms
{
    partial class PengingatPage
    {
        private void InitializeComponent()
        {
            SuspendLayout();

            BackColor = Tema.Latar;
            Font = Tema.FontNormal;

            Label judul = Tema.Judul("Pengingat Perawatan");
            judul.Location = new Point(24, 18);

            _cmbTanaman = new ComboBox { Location = new Point(24, 92), Size = new Size(250, 27) };
            _cmbKegiatan = new ComboBox { Location = new Point(292, 92), Size = new Size(250, 27) };
            _cmbKegiatan.Items.AddRange(new object[] { "CekpH", "GantiNutrisi", "Pembersihan", "Penyiraman" });
            _dtpJadwal = new DateTimePicker { Location = new Point(560, 92), Size = new Size(220, 27) };

            Controls.Add(judul);
            Controls.Add(Tema.Lbl("Tanaman", 24, 70));
            Controls.Add(_cmbTanaman);
            Controls.Add(Tema.Lbl("Kegiatan", 292, 70));
            Controls.Add(_cmbKegiatan);
            Controls.Add(Tema.Lbl("Tanggal jadwal", 560, 70));
            Controls.Add(_dtpJadwal);

            Button tambah = Tema.Tombol("Tambah Pengingat", Tema.Hijau, 24, 132, 170);
            Button selesai = Tema.Tombol("Tandai Selesai", Tema.Biru, 202, 132, 150);
            Button hapus = Tema.Tombol("Hapus", Tema.Merah, 360, 132, 120);
            Controls.Add(tambah);
            Controls.Add(selesai);
            Controls.Add(hapus);

            _grid = Tema.Grid();
            _grid.Location = new Point(24, 190);
            _grid.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            _grid.Size = new Size(900, 180);
            _grid.Columns.Add("Id", "ID");
            _grid.Columns.Add("Jadwal", "Jadwal");
            _grid.Columns.Add("Tanaman", "Tanaman");
            _grid.Columns.Add("Kegiatan", "Kegiatan");
            _grid.Columns.Add("Status", "Status");
            Controls.Add(_grid);

            Name = "PengingatPage";
            Size = new Size(940, 470);
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
