using System.Drawing;
using System.Windows.Forms;

namespace HydroSmart.Forms
{
    partial class PengingatPage
    {
        private void InitializeComponent()
        {
            _cmbTanaman = new ComboBox();
            _cmbKegiatan = new ComboBox();
            _dtpJadwal = new DateTimePicker();
            SuspendLayout();
            // 
            // _cmbTanaman
            // 
            _cmbTanaman.Location = new Point(0, 0);
            _cmbTanaman.Name = "_cmbTanaman";
            _cmbTanaman.Size = new Size(121, 36);
            _cmbTanaman.TabIndex = 2;
            // 
            // _cmbKegiatan
            // 
            _cmbKegiatan.Items.AddRange(new object[] { "CekpH", "GantiNutrisi", "Pembersihan", "Penyiraman" });
            _cmbKegiatan.Location = new Point(0, 0);
            _cmbKegiatan.Name = "_cmbKegiatan";
            _cmbKegiatan.Size = new Size(121, 36);
            _cmbKegiatan.TabIndex = 4;
            // 
            // _dtpJadwal
            // 
            _dtpJadwal.Location = new Point(0, 0);
            _dtpJadwal.Name = "_dtpJadwal";
            _dtpJadwal.Size = new Size(200, 34);
            _dtpJadwal.TabIndex = 6;
            // 
            // PengingatPage
            // 
            BackColor = Color.FromArgb(244, 248, 244);
            Controls.Add(_cmbTanaman);
            Controls.Add(_cmbKegiatan);
            Controls.Add(_dtpJadwal);
            Name = "PengingatPage";
            Size = new Size(940, 470);
            Load += PengingatPage_Load;
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
