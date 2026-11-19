using System.Drawing;
using System.Windows.Forms;

namespace HydroSmart.Forms
{
    partial class MonitoringPage
    {
        private ComboBox _cmbTanaman;
        private NumericUpDown _numPh;
        private NumericUpDown _numTds;
        private NumericUpDown _numSuhu;
        private Panel _hasil;
        private Label _lblRingkas;
        private DataGridView _grid;
        private Label _lblJudul;
        private Label _lblTanaman;
        private Label _lblIdeal;
        private Label _lblPh;
        private Label _lblTds;
        private Label _lblSuhu;
        private Label _lblHasil;
        private Button _btnSimpan;
        private Button _btnHapus;

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            _lblJudul = new Label();
            _lblTanaman = new Label();
            _lblIdeal = new Label();
            _lblPh = new Label();
            _lblTds = new Label();
            _lblSuhu = new Label();
            _lblHasil = new Label();
            _cmbTanaman = new ComboBox();
            _numPh = new NumericUpDown();
            _numTds = new NumericUpDown();
            _numSuhu = new NumericUpDown();
            _btnSimpan = new Button();
            _btnHapus = new Button();
            _hasil = new Panel();
            _lblRingkas = new Label();
            _grid = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn8 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)_numPh).BeginInit();
            ((System.ComponentModel.ISupportInitialize)_numTds).BeginInit();
            ((System.ComponentModel.ISupportInitialize)_numSuhu).BeginInit();
            _hasil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)_grid).BeginInit();
            SuspendLayout();
            // 
            // _lblJudul
            // 
            _lblJudul.Font = new Font("Segoe UI Semibold", 18F);
            _lblJudul.ForeColor = Color.FromArgb(27, 94, 32);
            _lblJudul.Location = new Point(24, 3);
            _lblJudul.Name = "_lblJudul";
            _lblJudul.Size = new Size(500, 58);
            _lblJudul.TabIndex = 14;
            _lblJudul.Text = "Monitoring Nutrisi";
            _lblJudul.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // _lblTanaman
            // 
            _lblTanaman.AutoSize = true;
            _lblTanaman.Font = new Font("Segoe UI Semibold", 10F);
            _lblTanaman.ForeColor = Color.FromArgb(84, 110, 122);
            _lblTanaman.Location = new Point(24, 61);
            _lblTanaman.Name = "_lblTanaman";
            _lblTanaman.Size = new Size(93, 28);
            _lblTanaman.TabIndex = 13;
            _lblTanaman.Text = "Tanaman";
            // 
            // _lblIdeal
            // 
            _lblIdeal.AutoSize = true;
            _lblIdeal.Font = new Font("Segoe UI Semibold", 10F);
            _lblIdeal.ForeColor = Color.FromArgb(84, 110, 122);
            _lblIdeal.Location = new Point(24, 131);
            _lblIdeal.Name = "_lblIdeal";
            _lblIdeal.Size = new Size(161, 28);
            _lblIdeal.TabIndex = 12;
            _lblIdeal.Text = "Kebutuhan ideal";
            _lblIdeal.Click += _lblIdeal_Click;
            // 
            // _lblPh
            // 
            _lblPh.AutoSize = true;
            _lblPh.Font = new Font("Segoe UI Semibold", 10F);
            _lblPh.ForeColor = Color.FromArgb(84, 110, 122);
            _lblPh.Location = new Point(24, 201);
            _lblPh.Name = "_lblPh";
            _lblPh.Size = new Size(108, 28);
            _lblPh.TabIndex = 11;
            _lblPh.Text = "pH larutan";
            _lblPh.Click += _lblPh_Click;
            // 
            // _lblTds
            // 
            _lblTds.AutoSize = true;
            _lblTds.Font = new Font("Segoe UI Semibold", 10F);
            _lblTds.ForeColor = Color.FromArgb(84, 110, 122);
            _lblTds.Location = new Point(142, 201);
            _lblTds.Name = "_lblTds";
            _lblTds.Size = new Size(110, 28);
            _lblTds.TabIndex = 10;
            _lblTds.Text = "TDS (ppm)";
            _lblTds.Click += _lblTds_Click;
            // 
            // _lblSuhu
            // 
            _lblSuhu.AutoSize = true;
            _lblSuhu.Font = new Font("Segoe UI Semibold", 10F);
            _lblSuhu.ForeColor = Color.FromArgb(84, 110, 122);
            _lblSuhu.Location = new Point(267, 201);
            _lblSuhu.Name = "_lblSuhu";
            _lblSuhu.Size = new Size(119, 28);
            _lblSuhu.TabIndex = 9;
            _lblSuhu.Text = "Suhu air (C)";
            _lblSuhu.Click += _lblSuhu_Click;
            // 
            // _lblHasil
            // 
            _lblHasil.AutoSize = true;
            _lblHasil.Font = new Font("Segoe UI Semibold", 11F);
            _lblHasil.ForeColor = Color.FromArgb(84, 110, 122);
            _lblHasil.Location = new Point(444, 52);
            _lblHasil.Name = "_lblHasil";
            _lblHasil.Size = new Size(145, 30);
            _lblHasil.TabIndex = 0;
            _lblHasil.Text = "Hasil Evaluasi";
            // 
            // _cmbTanaman
            // 
            _cmbTanaman.DropDownStyle = ComboBoxStyle.DropDownList;
            _cmbTanaman.FormattingEnabled = true;
            _cmbTanaman.Location = new Point(24, 92);
            _cmbTanaman.Name = "_cmbTanaman";
            _cmbTanaman.Size = new Size(343, 36);
            _cmbTanaman.TabIndex = 1;
            // 
            // _numPh
            // 
            _numPh.DecimalPlaces = 1;
            _numPh.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            _numPh.Location = new Point(24, 164);
            _numPh.Maximum = new decimal(new int[] { 14, 0, 0, 0 });
            _numPh.Name = "_numPh";
            _numPh.Size = new Size(100, 34);
            _numPh.TabIndex = 2;
            _numPh.Value = new decimal(new int[] { 60, 0, 0, 65536 });
            _numPh.ValueChanged += _numPh_ValueChanged;
            // 
            // _numTds
            // 
            _numTds.Location = new Point(142, 164);
            _numTds.Maximum = new decimal(new int[] { 5000, 0, 0, 0 });
            _numTds.Name = "_numTds";
            _numTds.Size = new Size(100, 34);
            _numTds.TabIndex = 3;
            _numTds.Value = new decimal(new int[] { 700, 0, 0, 0 });
            // 
            // _numSuhu
            // 
            _numSuhu.DecimalPlaces = 1;
            _numSuhu.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            _numSuhu.Location = new Point(267, 164);
            _numSuhu.Maximum = new decimal(new int[] { 60, 0, 0, 0 });
            _numSuhu.Name = "_numSuhu";
            _numSuhu.Size = new Size(100, 34);
            _numSuhu.TabIndex = 4;
            _numSuhu.Value = new decimal(new int[] { 240, 0, 0, 65536 });
            _numSuhu.ValueChanged += _numSuhu_ValueChanged;
            // 
            // _btnSimpan
            // 
            _btnSimpan.BackColor = Color.FromArgb(46, 125, 50);
            _btnSimpan.Cursor = Cursors.Hand;
            _btnSimpan.FlatAppearance.BorderSize = 0;
            _btnSimpan.FlatStyle = FlatStyle.Flat;
            _btnSimpan.Font = new Font("Segoe UI Semibold", 10F);
            _btnSimpan.ForeColor = Color.White;
            _btnSimpan.Location = new Point(24, 251);
            _btnSimpan.Name = "_btnSimpan";
            _btnSimpan.Size = new Size(218, 38);
            _btnSimpan.TabIndex = 5;
            _btnSimpan.Text = "Simpan dan Evaluasi";
            _btnSimpan.UseVisualStyleBackColor = false;
            _btnSimpan.Click += Simpan_Click;
            // 
            // _btnHapus
            // 
            _btnHapus.BackColor = Color.FromArgb(198, 40, 40);
            _btnHapus.Cursor = Cursors.Hand;
            _btnHapus.FlatAppearance.BorderSize = 0;
            _btnHapus.FlatStyle = FlatStyle.Flat;
            _btnHapus.Font = new Font("Segoe UI Semibold", 10F);
            _btnHapus.ForeColor = Color.White;
            _btnHapus.Location = new Point(267, 251);
            _btnHapus.Name = "_btnHapus";
            _btnHapus.Size = new Size(150, 38);
            _btnHapus.TabIndex = 6;
            _btnHapus.Text = "Hapus Catatan";
            _btnHapus.UseVisualStyleBackColor = false;
            _btnHapus.Click += Hapus_Click;
            // 
            // _hasil
            // 
            _hasil.BackColor = Color.FromArgb(247, 251, 247);
            _hasil.Controls.Add(_lblRingkas);
            _hasil.Location = new Point(444, 85);
            _hasil.Name = "_hasil";
            _hasil.Size = new Size(430, 130);
            _hasil.TabIndex = 7;
            _hasil.Paint += _hasil_Paint;
            // 
            // _lblRingkas
            // 
            _lblRingkas.Location = new Point(20, 40);
            _lblRingkas.Name = "_lblRingkas";
            _lblRingkas.Size = new Size(390, 55);
            _lblRingkas.TabIndex = 1;
            _lblRingkas.Text = "Isi pengukuran lalu klik tombol Simpan dan Evaluasi.";
            // 
            // _grid
            // 
            _grid.AllowUserToAddRows = false;
            _grid.AllowUserToDeleteRows = false;
            _grid.AllowUserToResizeRows = false;
            _grid.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            _grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            _grid.BackgroundColor = Color.White;
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = Color.FromArgb(46, 125, 50);
            dataGridViewCellStyle10.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle10.ForeColor = Color.White;
            dataGridViewCellStyle10.SelectionBackColor = Color.FromArgb(46, 125, 50);
            dataGridViewCellStyle10.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.True;
            _grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            _grid.ColumnHeadersHeight = 30;
            _grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            _grid.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6, dataGridViewTextBoxColumn7, dataGridViewTextBoxColumn8 });
            _grid.EnableHeadersVisualStyles = false;
            _grid.Location = new Point(24, 310);
            _grid.MultiSelect = false;
            _grid.Name = "_grid";
            _grid.ReadOnly = true;
            _grid.RowHeadersVisible = false;
            _grid.RowHeadersWidth = 51;
            _grid.RowTemplate.Height = 30;
            _grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            _grid.Size = new Size(850, 180);
            _grid.TabIndex = 8;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "ID";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Waktu";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "pH";
            dataGridViewTextBoxColumn3.MinimumWidth = 6;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "TDS (ppm)";
            dataGridViewTextBoxColumn4.MinimumWidth = 6;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.HeaderText = "Suhu (C)";
            dataGridViewTextBoxColumn5.MinimumWidth = 6;
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.HeaderText = "Status pH";
            dataGridViewTextBoxColumn6.MinimumWidth = 6;
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            dataGridViewTextBoxColumn7.HeaderText = "Status TDS";
            dataGridViewTextBoxColumn7.MinimumWidth = 6;
            dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            dataGridViewTextBoxColumn8.HeaderText = "Status Suhu";
            dataGridViewTextBoxColumn8.MinimumWidth = 6;
            dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // MonitoringPage
            // 
            BackColor = Color.FromArgb(244, 248, 244);
            Controls.Add(_lblHasil);
            Controls.Add(_grid);
            Controls.Add(_hasil);
            Controls.Add(_btnHapus);
            Controls.Add(_btnSimpan);
            Controls.Add(_numSuhu);
            Controls.Add(_numTds);
            Controls.Add(_numPh);
            Controls.Add(_cmbTanaman);
            Controls.Add(_lblSuhu);
            Controls.Add(_lblTds);
            Controls.Add(_lblPh);
            Controls.Add(_lblIdeal);
            Controls.Add(_lblTanaman);
            Controls.Add(_lblJudul);
            Name = "MonitoringPage";
            Size = new Size(940, 520);
            ((System.ComponentModel.ISupportInitialize)_numPh).EndInit();
            ((System.ComponentModel.ISupportInitialize)_numTds).EndInit();
            ((System.ComponentModel.ISupportInitialize)_numSuhu).EndInit();
            _hasil.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)_grid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
    }
}