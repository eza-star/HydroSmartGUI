using System.Drawing;
using System.Windows.Forms;

namespace HydroSmart.Forms
{
    partial class PengingatPage
    {
        private ComboBox _cmbTanaman;
        private ComboBox _cmbKegiatan;
        private DateTimePicker _dtpJadwal;
        private DataGridView _grid;
        private Label _lblJudul;
        private Label _lblTanaman;
        private Label _lblKegiatan;
        private Label _lblTanggal;
        private Button _btnTambah;
        private Button _btnSelesai;
        private Button _btnHapus;

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            _lblJudul = new Label();
            _lblTanaman = new Label();
            _lblKegiatan = new Label();
            _lblTanggal = new Label();
            _cmbTanaman = new ComboBox();
            _cmbKegiatan = new ComboBox();
            _dtpJadwal = new DateTimePicker();
            _btnTambah = new Button();
            _btnSelesai = new Button();
            _btnHapus = new Button();
            _grid = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)_grid).BeginInit();
            SuspendLayout();
            // 
            // _lblJudul
            // 
            _lblJudul.Font = new Font("Segoe UI Semibold", 18F);
            _lblJudul.ForeColor = Color.FromArgb(27, 94, 32);
            _lblJudul.Location = new Point(24, 0);
            _lblJudul.Name = "_lblJudul";
            _lblJudul.Size = new Size(500, 58);
            _lblJudul.TabIndex = 14;
            _lblJudul.Text = "Pengingat Perawatan";
            _lblJudul.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // _lblTanaman
            // 
            _lblTanaman.AutoSize = true;
            _lblTanaman.Font = new Font("Segoe UI Semibold", 10F);
            _lblTanaman.ForeColor = Color.FromArgb(84, 110, 122);
            _lblTanaman.Location = new Point(24, 59);
            _lblTanaman.Name = "_lblTanaman";
            _lblTanaman.Size = new Size(79, 23);
            _lblTanaman.TabIndex = 13;
            _lblTanaman.Text = "Tanaman";
            // 
            // _lblKegiatan
            // 
            _lblKegiatan.AutoSize = true;
            _lblKegiatan.Font = new Font("Segoe UI Semibold", 10F);
            _lblKegiatan.ForeColor = Color.FromArgb(84, 110, 122);
            _lblKegiatan.Location = new Point(292, 59);
            _lblKegiatan.Name = "_lblKegiatan";
            _lblKegiatan.Size = new Size(77, 23);
            _lblKegiatan.TabIndex = 12;
            _lblKegiatan.Text = "Kegiatan";
            // 
            // _lblTanggal
            // 
            _lblTanggal.AutoSize = true;
            _lblTanggal.Font = new Font("Segoe UI Semibold", 10F);
            _lblTanggal.ForeColor = Color.FromArgb(84, 110, 122);
            _lblTanggal.Location = new Point(560, 59);
            _lblTanggal.Name = "_lblTanggal";
            _lblTanggal.Size = new Size(123, 23);
            _lblTanggal.TabIndex = 11;
            _lblTanggal.Text = "Tanggal jadwal";
            // 
            // _cmbTanaman
            // 
            _cmbTanaman.DropDownStyle = ComboBoxStyle.DropDownList;
            _cmbTanaman.FormattingEnabled = true;
            _cmbTanaman.Location = new Point(24, 83);
            _cmbTanaman.Name = "_cmbTanaman";
            _cmbTanaman.Size = new Size(250, 31);
            _cmbTanaman.TabIndex = 2;
            // 
            // _cmbKegiatan
            // 
            _cmbKegiatan.DropDownStyle = ComboBoxStyle.DropDownList;
            _cmbKegiatan.FormattingEnabled = true;
            _cmbKegiatan.Items.AddRange(new object[] { "CekpH", "GantiNutrisi", "Pembersihan", "Penyiraman" });
            _cmbKegiatan.Location = new Point(292, 83);
            _cmbKegiatan.Name = "_cmbKegiatan";
            _cmbKegiatan.Size = new Size(250, 31);
            _cmbKegiatan.TabIndex = 4;
            // 
            // _dtpJadwal
            // 
            _dtpJadwal.Location = new Point(560, 83);
            _dtpJadwal.Name = "_dtpJadwal";
            _dtpJadwal.Size = new Size(220, 30);
            _dtpJadwal.TabIndex = 6;
            // 
            // _btnTambah
            // 
            _btnTambah.BackColor = Color.FromArgb(46, 125, 50);
            _btnTambah.Cursor = Cursors.Hand;
            _btnTambah.FlatAppearance.BorderSize = 0;
            _btnTambah.FlatStyle = FlatStyle.Flat;
            _btnTambah.Font = new Font("Segoe UI Semibold", 10F);
            _btnTambah.ForeColor = Color.White;
            _btnTambah.Location = new Point(24, 123);
            _btnTambah.Name = "_btnTambah";
            _btnTambah.Size = new Size(170, 38);
            _btnTambah.TabIndex = 7;
            _btnTambah.Text = "Tambah Pengingat";
            _btnTambah.UseVisualStyleBackColor = false;
            _btnTambah.Click += Tambah_Click;
            // 
            // _btnSelesai
            // 
            _btnSelesai.BackColor = Color.FromArgb(21, 101, 192);
            _btnSelesai.Cursor = Cursors.Hand;
            _btnSelesai.FlatAppearance.BorderSize = 0;
            _btnSelesai.FlatStyle = FlatStyle.Flat;
            _btnSelesai.Font = new Font("Segoe UI Semibold", 10F);
            _btnSelesai.ForeColor = Color.White;
            _btnSelesai.Location = new Point(233, 123);
            _btnSelesai.Name = "_btnSelesai";
            _btnSelesai.Size = new Size(150, 38);
            _btnSelesai.TabIndex = 8;
            _btnSelesai.Text = "Tandai Selesai";
            _btnSelesai.UseVisualStyleBackColor = false;
            _btnSelesai.Click += Selesai_Click;
            // 
            // _btnHapus
            // 
            _btnHapus.BackColor = Color.FromArgb(198, 40, 40);
            _btnHapus.Cursor = Cursors.Hand;
            _btnHapus.FlatAppearance.BorderSize = 0;
            _btnHapus.FlatStyle = FlatStyle.Flat;
            _btnHapus.Font = new Font("Segoe UI Semibold", 10F);
            _btnHapus.ForeColor = Color.White;
            _btnHapus.Location = new Point(421, 123);
            _btnHapus.Name = "_btnHapus";
            _btnHapus.Size = new Size(120, 38);
            _btnHapus.TabIndex = 9;
            _btnHapus.Text = "Hapus";
            _btnHapus.UseVisualStyleBackColor = false;
            _btnHapus.Click += Hapus_Click;
            // 
            // _grid
            // 
            _grid.AllowUserToAddRows = false;
            _grid.AllowUserToDeleteRows = false;
            _grid.AllowUserToResizeRows = false;
            _grid.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            _grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            _grid.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(46, 125, 50);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(46, 125, 50);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            _grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            _grid.ColumnHeadersHeight = 30;
            _grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            _grid.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5 });
            _grid.EnableHeadersVisualStyles = false;
            _grid.Location = new Point(24, 182);
            _grid.MultiSelect = false;
            _grid.Name = "_grid";
            _grid.ReadOnly = true;
            _grid.RowHeadersVisible = false;
            _grid.RowHeadersWidth = 51;
            _grid.RowTemplate.Height = 30;
            _grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            _grid.Size = new Size(900, 180);
            _grid.TabIndex = 10;
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
            dataGridViewTextBoxColumn2.HeaderText = "Jadwal";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Tanaman";
            dataGridViewTextBoxColumn3.MinimumWidth = 6;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "Kegiatan";
            dataGridViewTextBoxColumn4.MinimumWidth = 6;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.HeaderText = "Status";
            dataGridViewTextBoxColumn5.MinimumWidth = 6;
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // PengingatPage
            // 
            BackColor = Color.FromArgb(244, 248, 244);
            Controls.Add(_grid);
            Controls.Add(_btnHapus);
            Controls.Add(_btnSelesai);
            Controls.Add(_btnTambah);
            Controls.Add(_dtpJadwal);
            Controls.Add(_cmbKegiatan);
            Controls.Add(_cmbTanaman);
            Controls.Add(_lblTanggal);
            Controls.Add(_lblKegiatan);
            Controls.Add(_lblTanaman);
            Controls.Add(_lblJudul);
            Name = "PengingatPage";
            Size = new Size(940, 470);
            Load += PengingatPage_Load;
            ((System.ComponentModel.ISupportInitialize)_grid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}
