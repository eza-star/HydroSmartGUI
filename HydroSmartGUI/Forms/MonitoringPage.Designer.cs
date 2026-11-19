using System.Drawing;
using System.Windows.Forms;

namespace HydroSmart.Forms
{
    partial class MonitoringPage
    {
        private void InitializeComponent()
        {
            _cmbTanaman = new ComboBox();
            _numPh = new NumericUpDown();
            _numTds = new NumericUpDown();
            _numSuhu = new NumericUpDown();
            _hasil = new Panel();
            _lblRingkas = new Label();
            ((System.ComponentModel.ISupportInitialize)_numPh).BeginInit();
            ((System.ComponentModel.ISupportInitialize)_numTds).BeginInit();
            ((System.ComponentModel.ISupportInitialize)_numSuhu).BeginInit();
            _hasil.SuspendLayout();
            SuspendLayout();
            // 
            // _cmbTanaman
            // 
            _cmbTanaman.Location = new Point(0, 0);
            _cmbTanaman.Name = "_cmbTanaman";
            _cmbTanaman.Size = new Size(121, 36);
            _cmbTanaman.TabIndex = 2;
            // 
            // _numPh
            // 
            _numPh.Location = new Point(0, 0);
            _numPh.Name = "_numPh";
            _numPh.Size = new Size(120, 34);
            _numPh.TabIndex = 7;
            // 
            // _numTds
            // 
            _numTds.Location = new Point(0, 0);
            _numTds.Name = "_numTds";
            _numTds.Size = new Size(120, 34);
            _numTds.TabIndex = 8;
            // 
            // _numSuhu
            // 
            _numSuhu.Location = new Point(0, 0);
            _numSuhu.Name = "_numSuhu";
            _numSuhu.Size = new Size(120, 34);
            _numSuhu.TabIndex = 9;
            // 
            // _hasil
            // 
            _hasil.Controls.Add(_lblRingkas);
            _hasil.Location = new Point(0, 0);
            _hasil.Name = "_hasil";
            _hasil.Size = new Size(200, 100);
            _hasil.TabIndex = 12;
            // 
            // _lblRingkas
            // 
            _lblRingkas.Location = new Point(0, 0);
            _lblRingkas.Name = "_lblRingkas";
            _lblRingkas.Size = new Size(100, 23);
            _lblRingkas.TabIndex = 1;
            // 
            // MonitoringPage
            // 
            BackColor = Color.FromArgb(244, 248, 244);
            Controls.Add(_cmbTanaman);
            Controls.Add(_numPh);
            Controls.Add(_numTds);
            Controls.Add(_numSuhu);
            Controls.Add(_hasil);
            Name = "MonitoringPage";
            Size = new Size(1233, 540);
            ((System.ComponentModel.ISupportInitialize)_numPh).EndInit();
            ((System.ComponentModel.ISupportInitialize)_numTds).EndInit();
            ((System.ComponentModel.ISupportInitialize)_numSuhu).EndInit();
            _hasil.ResumeLayout(false);
            _hasil.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
