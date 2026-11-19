using System.Drawing;
using System.Windows.Forms;

namespace HydroSmart.Forms
{
    partial class MonitoringPage
    {
        private void InitializeComponent()
        {
            SuspendLayout();

            BackColor = Tema.Latar;
            Font = Tema.FontNormal;

            Label judul = Tema.Judul("Monitoring Nutrisi");
            judul.Location = new Point(24, 18);

            _cmbTanaman = new ComboBox { Location = new Point(24, 92), Size = new Size(330, 27) };

            _numPh = new NumericUpDown { Location = new Point(24, 155), Size = new Size(100, 27), DecimalPlaces = 1, Minimum = 0, Maximum = 14, Increment = 0.1M };
            _numTds = new NumericUpDown { Location = new Point(132, 155), Size = new Size(100, 27), Minimum = 0, Maximum = 5000 };
            _numSuhu = new NumericUpDown { Location = new Point(240, 155), Size = new Size(100, 27), DecimalPlaces = 1, Minimum = 0, Maximum = 60, Increment = 0.1M, Value = 24 };

            Controls.Add(judul);
            Controls.Add(Tema.Lbl("Tanaman", 24, 70));
            Controls.Add(_cmbTanaman);
            Controls.Add(Tema.Lbl("Kebutuhan ideal", 24, 125));
            Controls.Add(Tema.Lbl("pH larutan", 24, 180));
            Controls.Add(Tema.Lbl("TDS (ppm)", 132, 180));
            Controls.Add(Tema.Lbl("Suhu air (C)", 240, 180));
            Controls.Add(_numPh);
            Controls.Add(_numTds);
            Controls.Add(_numSuhu);

            Button simpan = Tema.Tombol("Simpan dan Evaluasi", Tema.Hijau, 24, 220, 180);
            Button hapus = Tema.Tombol("Hapus Catatan", Tema.Merah, 212, 220, 150);
            Controls.Add(simpan);
            Controls.Add(hapus);

            _hasil = new Panel
            {
                Location = new Point(420, 85),
                Size = new Size(430, 130),
                BackColor = Color.FromArgb(247, 251, 247)
            };
            Label lblHasil = Tema.Lbl("Hasil Evaluasi", 20, 18);
            lblHasil.Font = new Font("Segoe UI Semibold", 11F);
            _lblRingkas = new Label
            {
                Location = new Point(20, 55),
                Size = new Size(390, 55),
                Text = "Isi pengukuran lalu klik tombol Simpan dan Evaluasi."
            };
            _hasil.Controls.Add(lblHasil);
            _hasil.Controls.Add(_lblRingkas);
            Controls.Add(_hasil);

            _grid = Tema.Grid();
            _grid.Location = new Point(24, 290);
            _grid.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            _grid.Size = new Size(850, 180);
            _grid.Columns.Add("Id", "ID");
            _grid.Columns.Add("Waktu", "Waktu");
            _grid.Columns.Add("Ph", "pH");
            _grid.Columns.Add("Tds", "TDS (ppm)");
            _grid.Columns.Add("Suhu", "Suhu (C)");
            _grid.Columns.Add("StatusPh", "Status pH");
            _grid.Columns.Add("StatusTds", "Status TDS");
            _grid.Columns.Add("StatusSuhu", "Status Suhu");
            Controls.Add(_grid);

            Name = "MonitoringPage";
            Size = new Size(940, 470);
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
