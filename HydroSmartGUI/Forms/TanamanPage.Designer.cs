namespace HydroSmart.Forms
{
    partial class TanamanPage
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            pnlGrid = new System.Windows.Forms.Panel();
            dgvTanaman = new System.Windows.Forms.DataGridView();
            colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colNama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colJenis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colLokasi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colTanam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colUmur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colFase = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colPanen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colIdeal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            pnlForm = new System.Windows.Forms.Panel();
            lblJenis = new System.Windows.Forms.Label();
            cmbJenis = new System.Windows.Forms.ComboBox();
            lblNama = new System.Windows.Forms.Label();
            txtNama = new System.Windows.Forms.TextBox();
            lblLokasi = new System.Windows.Forms.Label();
            cmbLokasi = new System.Windows.Forms.ComboBox();
            lblTanggal = new System.Windows.Forms.Label();
            dtpTanggal = new System.Windows.Forms.DateTimePicker();
            btnTambah = new System.Windows.Forms.Button();
            btnUbah = new System.Windows.Forms.Button();
            btnHapus = new System.Windows.Forms.Button();
            btnKosongkan = new System.Windows.Forms.Button();
            lblJudul = new System.Windows.Forms.Label();
            pnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTanaman).BeginInit();
            pnlForm.SuspendLayout();
            SuspendLayout();
            // 
            // pnlGrid
            // 
            pnlGrid.BackColor = System.Drawing.Color.FromArgb(244, 248, 244);
            pnlGrid.Controls.Add(dgvTanaman);
            pnlGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            pnlGrid.Location = new System.Drawing.Point(0, 214);
            pnlGrid.Name = "pnlGrid";
            pnlGrid.Padding = new System.Windows.Forms.Padding(20, 10, 20, 20);
            pnlGrid.Size = new System.Drawing.Size(940, 506);
            pnlGrid.TabIndex = 0;
            // 
            // dgvTanaman
            // 
            dgvTanaman.AllowUserToAddRows = false;
            dgvTanaman.AllowUserToDeleteRows = false;
            dgvTanaman.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(247, 251, 247);
            dgvTanaman.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvTanaman.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvTanaman.BackgroundColor = System.Drawing.Color.White;
            dgvTanaman.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(46, 125, 50);
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(46, 125, 50);
            dgvTanaman.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvTanaman.ColumnHeadersHeight = 36;
            dgvTanaman.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvTanaman.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { colId, colNama, colJenis, colLokasi, colTanam, colUmur, colFase, colPanen, colIdeal });
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(165, 214, 167);
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            dgvTanaman.DefaultCellStyle = dataGridViewCellStyle3;
            dgvTanaman.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvTanaman.EnableHeadersVisualStyles = false;
            dgvTanaman.Location = new System.Drawing.Point(20, 10);
            dgvTanaman.MultiSelect = false;
            dgvTanaman.Name = "dgvTanaman";
            dgvTanaman.ReadOnly = true;
            dgvTanaman.RowHeadersVisible = false;
            dgvTanaman.RowHeadersWidth = 51;
            dgvTanaman.RowTemplate.Height = 30;
            dgvTanaman.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvTanaman.Size = new System.Drawing.Size(900, 476);
            dgvTanaman.TabIndex = 1;
            dgvTanaman.SelectionChanged += Grid_SelectionChanged;
            // 
            // colId
            // 
            colId.FillWeight = 30F;
            colId.HeaderText = "ID";
            colId.MinimumWidth = 6;
            colId.Name = "colId";
            colId.ReadOnly = true;
            // 
            // colNama
            // 
            colNama.HeaderText = "Nama";
            colNama.MinimumWidth = 6;
            colNama.Name = "colNama";
            colNama.ReadOnly = true;
            // 
            // colJenis
            // 
            colJenis.HeaderText = "Jenis";
            colJenis.MinimumWidth = 6;
            colJenis.Name = "colJenis";
            colJenis.ReadOnly = true;
            // 
            // colLokasi
            // 
            colLokasi.HeaderText = "Lokasi";
            colLokasi.MinimumWidth = 6;
            colLokasi.Name = "colLokasi";
            colLokasi.ReadOnly = true;
            // 
            // colTanam
            // 
            colTanam.HeaderText = "Tanggal Tanam";
            colTanam.MinimumWidth = 6;
            colTanam.Name = "colTanam";
            colTanam.ReadOnly = true;
            // 
            // colUmur
            // 
            colUmur.FillWeight = 50F;
            colUmur.HeaderText = "Umur (hari)";
            colUmur.MinimumWidth = 6;
            colUmur.Name = "colUmur";
            colUmur.ReadOnly = true;
            // 
            // colFase
            // 
            colFase.HeaderText = "Fase";
            colFase.MinimumWidth = 6;
            colFase.Name = "colFase";
            colFase.ReadOnly = true;
            // 
            // colPanen
            // 
            colPanen.HeaderText = "Estimasi Panen";
            colPanen.MinimumWidth = 6;
            colPanen.Name = "colPanen";
            colPanen.ReadOnly = true;
            // 
            // colIdeal
            // 
            colIdeal.FillWeight = 130F;
            colIdeal.HeaderText = "Ideal pH / TDS";
            colIdeal.MinimumWidth = 6;
            colIdeal.Name = "colIdeal";
            colIdeal.ReadOnly = true;
            // 
            // pnlForm
            // 
            pnlForm.BackColor = System.Drawing.Color.White;
            pnlForm.Controls.Add(lblJenis);
            pnlForm.Controls.Add(cmbJenis);
            pnlForm.Controls.Add(lblNama);
            pnlForm.Controls.Add(txtNama);
            pnlForm.Controls.Add(lblLokasi);
            pnlForm.Controls.Add(cmbLokasi);
            pnlForm.Controls.Add(lblTanggal);
            pnlForm.Controls.Add(dtpTanggal);
            pnlForm.Controls.Add(btnTambah);
            pnlForm.Controls.Add(btnUbah);
            pnlForm.Controls.Add(btnHapus);
            pnlForm.Controls.Add(btnKosongkan);
            pnlForm.Dock = System.Windows.Forms.DockStyle.Top;
            pnlForm.Location = new System.Drawing.Point(0, 64);
            pnlForm.Name = "pnlForm";
            pnlForm.Size = new System.Drawing.Size(940, 150);
            pnlForm.TabIndex = 2;
            // 
            // lblJenis
            // 
            lblJenis.AutoSize = true;
            lblJenis.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblJenis.ForeColor = System.Drawing.Color.FromArgb(84, 110, 122);
            lblJenis.Location = new System.Drawing.Point(20, 12);
            lblJenis.Name = "lblJenis";
            lblJenis.Size = new System.Drawing.Size(57, 28);
            lblJenis.TabIndex = 3;
            lblJenis.Text = "Jenis";
            // 
            // cmbJenis
            // 
            cmbJenis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbJenis.FormattingEnabled = true;
            cmbJenis.Items.AddRange(new object[] { "Selada", "Kangkung", "Pakcoy" });
            cmbJenis.Location = new System.Drawing.Point(20, 36);
            cmbJenis.Name = "cmbJenis";
            cmbJenis.Size = new System.Drawing.Size(130, 36);
            cmbJenis.TabIndex = 4;
            // 
            // lblNama
            // 
            lblNama.AutoSize = true;
            lblNama.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblNama.ForeColor = System.Drawing.Color.FromArgb(84, 110, 122);
            lblNama.Location = new System.Drawing.Point(170, 12);
            lblNama.Name = "lblNama";
            lblNama.Size = new System.Drawing.Size(65, 28);
            lblNama.TabIndex = 5;
            lblNama.Text = "Nama";
            lblNama.Click += lblNama_Click;
            // 
            // txtNama
            // 
            txtNama.Location = new System.Drawing.Point(170, 36);
            txtNama.Name = "txtNama";
            txtNama.Size = new System.Drawing.Size(220, 34);
            txtNama.TabIndex = 6;
            // 
            // lblLokasi
            // 
            lblLokasi.AutoSize = true;
            lblLokasi.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblLokasi.ForeColor = System.Drawing.Color.FromArgb(84, 110, 122);
            lblLokasi.Location = new System.Drawing.Point(410, 12);
            lblLokasi.Name = "lblLokasi";
            lblLokasi.Size = new System.Drawing.Size(69, 28);
            lblLokasi.TabIndex = 7;
            lblLokasi.Text = "Lokasi";
            // 
            // cmbLokasi
            // 
            cmbLokasi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbLokasi.FormattingEnabled = true;
            cmbLokasi.Items.AddRange(new object[] { "Rak 1", "Rak 2", "Rak 3", "GH 1", "GH 2" });
            cmbLokasi.Location = new System.Drawing.Point(410, 36);
            cmbLokasi.Name = "cmbLokasi";
            cmbLokasi.Size = new System.Drawing.Size(170, 36);
            cmbLokasi.TabIndex = 8;
            // 
            // lblTanggal
            // 
            lblTanggal.AutoSize = true;
            lblTanggal.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblTanggal.ForeColor = System.Drawing.Color.FromArgb(84, 110, 122);
            lblTanggal.Location = new System.Drawing.Point(600, 12);
            lblTanggal.Name = "lblTanggal";
            lblTanggal.Size = new System.Drawing.Size(145, 28);
            lblTanggal.TabIndex = 9;
            lblTanggal.Text = "Tanggal tanam";
            // 
            // dtpTanggal
            // 
            dtpTanggal.CustomFormat = "dd-MM-yyyy";
            dtpTanggal.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            dtpTanggal.Location = new System.Drawing.Point(600, 36);
            dtpTanggal.Name = "dtpTanggal";
            dtpTanggal.Size = new System.Drawing.Size(140, 34);
            dtpTanggal.TabIndex = 10;
            // 
            // btnTambah
            // 
            btnTambah.BackColor = System.Drawing.Color.FromArgb(46, 125, 50);
            btnTambah.Cursor = System.Windows.Forms.Cursors.Hand;
            btnTambah.FlatAppearance.BorderSize = 0;
            btnTambah.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnTambah.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnTambah.ForeColor = System.Drawing.Color.White;
            btnTambah.Location = new System.Drawing.Point(20, 90);
            btnTambah.Name = "btnTambah";
            btnTambah.Size = new System.Drawing.Size(130, 38);
            btnTambah.TabIndex = 11;
            btnTambah.Text = "Tambah";
            btnTambah.UseVisualStyleBackColor = false;
            btnTambah.Click += BtnTambah_Click;
            // 
            // btnUbah
            // 
            btnUbah.BackColor = System.Drawing.Color.FromArgb(21, 101, 192);
            btnUbah.Cursor = System.Windows.Forms.Cursors.Hand;
            btnUbah.FlatAppearance.BorderSize = 0;
            btnUbah.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnUbah.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnUbah.ForeColor = System.Drawing.Color.White;
            btnUbah.Location = new System.Drawing.Point(160, 90);
            btnUbah.Name = "btnUbah";
            btnUbah.Size = new System.Drawing.Size(130, 38);
            btnUbah.TabIndex = 12;
            btnUbah.Text = "Ubah";
            btnUbah.UseVisualStyleBackColor = false;
            btnUbah.Click += BtnUbah_Click;
            // 
            // btnHapus
            // 
            btnHapus.BackColor = System.Drawing.Color.FromArgb(198, 40, 40);
            btnHapus.Cursor = System.Windows.Forms.Cursors.Hand;
            btnHapus.FlatAppearance.BorderSize = 0;
            btnHapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnHapus.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnHapus.ForeColor = System.Drawing.Color.White;
            btnHapus.Location = new System.Drawing.Point(300, 90);
            btnHapus.Name = "btnHapus";
            btnHapus.Size = new System.Drawing.Size(130, 38);
            btnHapus.TabIndex = 13;
            btnHapus.Text = "Hapus";
            btnHapus.UseVisualStyleBackColor = false;
            btnHapus.Click += BtnHapus_Click;
            // 
            // btnKosongkan
            // 
            btnKosongkan.BackColor = System.Drawing.Color.FromArgb(84, 110, 122);
            btnKosongkan.Cursor = System.Windows.Forms.Cursors.Hand;
            btnKosongkan.FlatAppearance.BorderSize = 0;
            btnKosongkan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnKosongkan.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnKosongkan.ForeColor = System.Drawing.Color.White;
            btnKosongkan.Location = new System.Drawing.Point(440, 90);
            btnKosongkan.Name = "btnKosongkan";
            btnKosongkan.Size = new System.Drawing.Size(160, 38);
            btnKosongkan.TabIndex = 14;
            btnKosongkan.Text = "Kosongkan Form";
            btnKosongkan.UseVisualStyleBackColor = false;
            btnKosongkan.Click += BtnKosongkan_Click;
            // 
            // lblJudul
            // 
            lblJudul.BackColor = System.Drawing.Color.FromArgb(244, 248, 244);
            lblJudul.Dock = System.Windows.Forms.DockStyle.Top;
            lblJudul.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblJudul.ForeColor = System.Drawing.Color.FromArgb(27, 94, 32);
            lblJudul.Location = new System.Drawing.Point(0, 0);
            lblJudul.Name = "lblJudul";
            lblJudul.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            lblJudul.Size = new System.Drawing.Size(940, 64);
            lblJudul.TabIndex = 15;
            lblJudul.Text = "Kelola Tanaman";
            lblJudul.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TanamanPage
            // 
            Controls.Add(pnlGrid);
            Controls.Add(pnlForm);
            Controls.Add(lblJudul);
            Name = "TanamanPage";
            Size = new System.Drawing.Size(940, 720);
            pnlGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvTanaman).EndInit();
            pnlForm.ResumeLayout(false);
            pnlForm.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlGrid;
        private System.Windows.Forms.DataGridView dgvTanaman;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNama;
        private System.Windows.Forms.DataGridViewTextBoxColumn colJenis;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLokasi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTanam;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUmur;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFase;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPanen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdeal;
        private System.Windows.Forms.Panel pnlForm;
        private System.Windows.Forms.Label lblJenis;
        private System.Windows.Forms.ComboBox cmbJenis;
        private System.Windows.Forms.Label lblNama;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.Label lblLokasi;
        private System.Windows.Forms.ComboBox cmbLokasi;
        private System.Windows.Forms.Label lblTanggal;
        private System.Windows.Forms.DateTimePicker dtpTanggal;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.Button btnUbah;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Button btnKosongkan;
        private System.Windows.Forms.Label lblJudul;
    }
}
