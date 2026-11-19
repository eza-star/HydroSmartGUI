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
            this.pnlGrid = new System.Windows.Forms.Panel();
            this.dgvTanaman = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colJenis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLokasi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTanam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUmur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFase = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPanen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIdeal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlForm = new System.Windows.Forms.Panel();
            this.lblJenis = new System.Windows.Forms.Label();
            this.cmbJenis = new System.Windows.Forms.ComboBox();
            this.lblNama = new System.Windows.Forms.Label();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.lblLokasi = new System.Windows.Forms.Label();
            this.txtLokasi = new System.Windows.Forms.TextBox();
            this.lblTanggal = new System.Windows.Forms.Label();
            this.dtpTanggal = new System.Windows.Forms.DateTimePicker();
            this.btnTambah = new System.Windows.Forms.Button();
            this.btnUbah = new System.Windows.Forms.Button();
            this.btnHapus = new System.Windows.Forms.Button();
            this.btnKosongkan = new System.Windows.Forms.Button();
            this.lblJudul = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTanaman)).BeginInit();
            this.pnlGrid.SuspendLayout();
            this.pnlForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlGrid
            // 
            this.pnlGrid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(248)))), ((int)(((byte)(244)))));
            this.pnlGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGrid.Location = new System.Drawing.Point(0, 0);
            this.pnlGrid.Padding = new System.Windows.Forms.Padding(20, 10, 20, 20);
            this.pnlGrid.Size = new System.Drawing.Size(940, 720);
            this.pnlGrid.TabIndex = 0;
            this.pnlGrid.Controls.Add(this.dgvTanaman);
            // 
            // dgvTanaman
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(214)))), ((int)(((byte)(167)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(247)))));
            this.dgvTanaman.AllowUserToAddRows = false;
            this.dgvTanaman.AllowUserToDeleteRows = false;
            this.dgvTanaman.AllowUserToResizeRows = false;
            this.dgvTanaman.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvTanaman.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTanaman.BackgroundColor = System.Drawing.Color.White;
            this.dgvTanaman.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTanaman.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTanaman.ColumnHeadersHeight = 36;
            this.dgvTanaman.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvTanaman.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colNama,
            this.colJenis,
            this.colLokasi,
            this.colTanam,
            this.colUmur,
            this.colFase,
            this.colPanen,
            this.colIdeal});
            this.dgvTanaman.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTanaman.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTanaman.EnableHeadersVisualStyles = false;
            this.dgvTanaman.Location = new System.Drawing.Point(0, 0);
            this.dgvTanaman.MultiSelect = false;
            this.dgvTanaman.ReadOnly = true;
            this.dgvTanaman.RowHeadersVisible = false;
            this.dgvTanaman.RowHeadersWidth = 51;
            this.dgvTanaman.RowTemplate.Height = 30;
            this.dgvTanaman.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTanaman.Size = new System.Drawing.Size(900, 440);
            this.dgvTanaman.TabIndex = 1;
            this.dgvTanaman.SelectionChanged += new System.EventHandler(this.Grid_SelectionChanged);
            // 
            // colId
            // 
            this.colId.FillWeight = 30F;
            this.colId.HeaderText = "ID";
            this.colId.MinimumWidth = 6;
            this.colId.Name = "colId";
            // 
            // colNama
            // 
            this.colNama.HeaderText = "Nama";
            this.colNama.MinimumWidth = 6;
            this.colNama.Name = "colNama";
            // 
            // colJenis
            // 
            this.colJenis.HeaderText = "Jenis";
            this.colJenis.MinimumWidth = 6;
            this.colJenis.Name = "colJenis";
            // 
            // colLokasi
            // 
            this.colLokasi.HeaderText = "Lokasi";
            this.colLokasi.MinimumWidth = 6;
            this.colLokasi.Name = "colLokasi";
            // 
            // colTanam
            // 
            this.colTanam.HeaderText = "Tanggal Tanam";
            this.colTanam.MinimumWidth = 6;
            this.colTanam.Name = "colTanam";
            // 
            // colUmur
            // 
            this.colUmur.FillWeight = 50F;
            this.colUmur.HeaderText = "Umur (hari)";
            this.colUmur.MinimumWidth = 6;
            this.colUmur.Name = "colUmur";
            // 
            // colFase
            // 
            this.colFase.HeaderText = "Fase";
            this.colFase.MinimumWidth = 6;
            this.colFase.Name = "colFase";
            // 
            // colPanen
            // 
            this.colPanen.HeaderText = "Estimasi Panen";
            this.colPanen.MinimumWidth = 6;
            this.colPanen.Name = "colPanen";
            // 
            // colIdeal
            // 
            this.colIdeal.FillWeight = 130F;
            this.colIdeal.HeaderText = "Ideal pH / TDS";
            this.colIdeal.MinimumWidth = 6;
            this.colIdeal.Name = "colIdeal";
            // 
            // pnlForm
            // 
            this.pnlForm.BackColor = System.Drawing.Color.White;
            this.pnlForm.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlForm.Location = new System.Drawing.Point(0, 64);
            this.pnlForm.Size = new System.Drawing.Size(940, 150);
            this.pnlForm.TabIndex = 2;
            this.pnlForm.Controls.Add(this.lblJenis);
            this.pnlForm.Controls.Add(this.cmbJenis);
            this.pnlForm.Controls.Add(this.lblNama);
            this.pnlForm.Controls.Add(this.txtNama);
            this.pnlForm.Controls.Add(this.lblLokasi);
            this.pnlForm.Controls.Add(this.txtLokasi);
            this.pnlForm.Controls.Add(this.lblTanggal);
            this.pnlForm.Controls.Add(this.dtpTanggal);
            this.pnlForm.Controls.Add(this.btnTambah);
            this.pnlForm.Controls.Add(this.btnUbah);
            this.pnlForm.Controls.Add(this.btnHapus);
            this.pnlForm.Controls.Add(this.btnKosongkan);
            // 
            // lblJenis
            // 
            this.lblJenis.AutoSize = true;
            this.lblJenis.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJenis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(110)))), ((int)(((byte)(122)))));
            this.lblJenis.Location = new System.Drawing.Point(20, 12);
            this.lblJenis.Size = new System.Drawing.Size(45, 23);
            this.lblJenis.Text = "Jenis";
            this.lblJenis.TabIndex = 3;
            // 
            // cmbJenis
            // 
            this.cmbJenis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbJenis.FormattingEnabled = true;
            this.cmbJenis.Items.AddRange(new object[] {
            "Selada",
            "Kangkung",
            "Pakcoy"});
            this.cmbJenis.Location = new System.Drawing.Point(20, 36);
            this.cmbJenis.Size = new System.Drawing.Size(130, 28);
            this.cmbJenis.TabIndex = 4;
            // 
            // lblNama
            // 
            this.lblNama.AutoSize = true;
            this.lblNama.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNama.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(110)))), ((int)(((byte)(122)))));
            this.lblNama.Location = new System.Drawing.Point(170, 12);
            this.lblNama.Size = new System.Drawing.Size(160, 23);
            this.lblNama.Text = "Nama / label tanaman";
            this.lblNama.TabIndex = 5;
            // 
            // txtNama
            // 
            this.txtNama.Location = new System.Drawing.Point(170, 36);
            this.txtNama.Size = new System.Drawing.Size(220, 27);
            this.txtNama.TabIndex = 6;
            // 
            // lblLokasi
            // 
            this.lblLokasi.AutoSize = true;
            this.lblLokasi.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLokasi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(110)))), ((int)(((byte)(122)))));
            this.lblLokasi.Location = new System.Drawing.Point(410, 12);
            this.lblLokasi.Size = new System.Drawing.Size(55, 23);
            this.lblLokasi.Text = "Lokasi";
            this.lblLokasi.TabIndex = 7;
            // 
            // txtLokasi
            // 
            this.txtLokasi.Location = new System.Drawing.Point(410, 36);
            this.txtLokasi.Size = new System.Drawing.Size(170, 27);
            this.txtLokasi.TabIndex = 8;
            // 
            // lblTanggal
            // 
            this.lblTanggal.AutoSize = true;
            this.lblTanggal.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTanggal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(110)))), ((int)(((byte)(122)))));
            this.lblTanggal.Location = new System.Drawing.Point(600, 12);
            this.lblTanggal.Size = new System.Drawing.Size(105, 23);
            this.lblTanggal.Text = "Tanggal tanam";
            this.lblTanggal.TabIndex = 9;
            // 
            // dtpTanggal
            // 
            this.dtpTanggal.CustomFormat = "dd-MM-yyyy";
            this.dtpTanggal.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTanggal.Location = new System.Drawing.Point(600, 36);
            this.dtpTanggal.Size = new System.Drawing.Size(140, 27);
            this.dtpTanggal.TabIndex = 10;
            // 
            // btnTambah
            // 
            this.btnTambah.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            this.btnTambah.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTambah.FlatAppearance.BorderSize = 0;
            this.btnTambah.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTambah.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTambah.ForeColor = System.Drawing.Color.White;
            this.btnTambah.Location = new System.Drawing.Point(20, 90);
            this.btnTambah.Size = new System.Drawing.Size(130, 38);
            this.btnTambah.Text = "Tambah";
            this.btnTambah.UseVisualStyleBackColor = false;
            this.btnTambah.TabIndex = 11;
            this.btnTambah.Click += new System.EventHandler(this.BtnTambah_Click);
            // 
            // btnUbah
            // 
            this.btnUbah.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(101)))), ((int)(((byte)(192)))));
            this.btnUbah.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUbah.FlatAppearance.BorderSize = 0;
            this.btnUbah.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUbah.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUbah.ForeColor = System.Drawing.Color.White;
            this.btnUbah.Location = new System.Drawing.Point(160, 90);
            this.btnUbah.Size = new System.Drawing.Size(130, 38);
            this.btnUbah.Text = "Ubah";
            this.btnUbah.UseVisualStyleBackColor = false;
            this.btnUbah.TabIndex = 12;
            this.btnUbah.Click += new System.EventHandler(this.BtnUbah_Click);
            // 
            // btnHapus
            // 
            this.btnHapus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnHapus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHapus.FlatAppearance.BorderSize = 0;
            this.btnHapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHapus.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHapus.ForeColor = System.Drawing.Color.White;
            this.btnHapus.Location = new System.Drawing.Point(300, 90);
            this.btnHapus.Size = new System.Drawing.Size(130, 38);
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseVisualStyleBackColor = false;
            this.btnHapus.TabIndex = 13;
            this.btnHapus.Click += new System.EventHandler(this.BtnHapus_Click);
            // 
            // btnKosongkan
            // 
            this.btnKosongkan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(110)))), ((int)(((byte)(122)))));
            this.btnKosongkan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKosongkan.FlatAppearance.BorderSize = 0;
            this.btnKosongkan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKosongkan.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKosongkan.ForeColor = System.Drawing.Color.White;
            this.btnKosongkan.Location = new System.Drawing.Point(440, 90);
            this.btnKosongkan.Size = new System.Drawing.Size(160, 38);
            this.btnKosongkan.Text = "Kosongkan Form";
            this.btnKosongkan.UseVisualStyleBackColor = false;
            this.btnKosongkan.TabIndex = 14;
            this.btnKosongkan.Click += new System.EventHandler(this.BtnKosongkan_Click);
            // 
            // lblJudul
            // 
            this.lblJudul.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(248)))), ((int)(((byte)(244)))));
            this.lblJudul.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblJudul.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJudul.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(32)))));
            this.lblJudul.Location = new System.Drawing.Point(0, 0);
            this.lblJudul.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.lblJudul.Size = new System.Drawing.Size(940, 64);
            this.lblJudul.Text = "Kelola Tanaman";
            this.lblJudul.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblJudul.TabIndex = 15;
            // 
            // TanamanPage
            // 
            this.Size = new System.Drawing.Size(940, 720);
            this.Controls.Add(this.pnlGrid);
            this.Controls.Add(this.pnlForm);
            this.Controls.Add(this.lblJudul);
            this.Name = "TanamanPage";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTanaman)).EndInit();
            this.pnlForm.ResumeLayout(false);
            this.pnlForm.PerformLayout();
            this.pnlGrid.ResumeLayout(false);
            this.pnlGrid.PerformLayout();
            this.ResumeLayout(false);
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
        private System.Windows.Forms.TextBox txtLokasi;
        private System.Windows.Forms.Label lblTanggal;
        private System.Windows.Forms.DateTimePicker dtpTanggal;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.Button btnUbah;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Button btnKosongkan;
        private System.Windows.Forms.Label lblJudul;
    }
}
