namespace HydroSmart.Forms
{
    partial class AnalisisPage
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
            dgvRiwayat = new System.Windows.Forms.DataGridView();
            colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colWaktu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colTanaman = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colDiagnosa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colCocok = new System.Windows.Forms.DataGridViewTextBoxColumn();
            pnlForm = new System.Windows.Forms.Panel();
            lblTanaman = new System.Windows.Forms.Label();
            cmbTanaman = new System.Windows.Forms.ComboBox();
            lblGejala = new System.Windows.Forms.Label();
            clbGejala = new System.Windows.Forms.CheckedListBox();
            btnAnalisis = new System.Windows.Forms.Button();
            btnReset = new System.Windows.Forms.Button();
            pnlHasil = new System.Windows.Forms.Panel();
            lblHasilJudul = new System.Windows.Forms.Label();
            lblDiagnosa = new System.Windows.Forms.Label();
            lblKecocokan = new System.Windows.Forms.Label();
            lblPenyebab = new System.Windows.Forms.Label();
            lblPenanganan = new System.Windows.Forms.Label();
            lblJudul = new System.Windows.Forms.Label();
            pnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRiwayat).BeginInit();
            pnlForm.SuspendLayout();
            pnlHasil.SuspendLayout();
            SuspendLayout();
            // 
            // pnlGrid
            // 
            pnlGrid.BackColor = System.Drawing.Color.FromArgb(244, 248, 244);
            pnlGrid.Controls.Add(dgvRiwayat);
            pnlGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            pnlGrid.Location = new System.Drawing.Point(0, 374);
            pnlGrid.Name = "pnlGrid";
            pnlGrid.Padding = new System.Windows.Forms.Padding(20, 10, 20, 20);
            pnlGrid.Size = new System.Drawing.Size(940, 346);
            pnlGrid.TabIndex = 0;
            // 
            // dgvRiwayat
            // 
            dgvRiwayat.AllowUserToAddRows = false;
            dgvRiwayat.AllowUserToDeleteRows = false;
            dgvRiwayat.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(247, 251, 247);
            dgvRiwayat.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvRiwayat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvRiwayat.BackgroundColor = System.Drawing.Color.White;
            dgvRiwayat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(46, 125, 50);
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(46, 125, 50);
            dgvRiwayat.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvRiwayat.ColumnHeadersHeight = 36;
            dgvRiwayat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvRiwayat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { colId, colWaktu, colTanaman, colDiagnosa, colCocok });
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(165, 214, 167);
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            dgvRiwayat.DefaultCellStyle = dataGridViewCellStyle3;
            dgvRiwayat.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvRiwayat.EnableHeadersVisualStyles = false;
            dgvRiwayat.Location = new System.Drawing.Point(20, 10);
            dgvRiwayat.MultiSelect = false;
            dgvRiwayat.Name = "dgvRiwayat";
            dgvRiwayat.ReadOnly = true;
            dgvRiwayat.RowHeadersVisible = false;
            dgvRiwayat.RowHeadersWidth = 51;
            dgvRiwayat.RowTemplate.Height = 30;
            dgvRiwayat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvRiwayat.Size = new System.Drawing.Size(900, 316);
            dgvRiwayat.TabIndex = 1;
            // 
            // colId
            // 
            colId.FillWeight = 30F;
            colId.HeaderText = "ID";
            colId.MinimumWidth = 6;
            colId.Name = "colId";
            colId.ReadOnly = true;
            // 
            // colWaktu
            // 
            colWaktu.HeaderText = "Waktu";
            colWaktu.MinimumWidth = 6;
            colWaktu.Name = "colWaktu";
            colWaktu.ReadOnly = true;
            // 
            // colTanaman
            // 
            colTanaman.HeaderText = "Tanaman";
            colTanaman.MinimumWidth = 6;
            colTanaman.Name = "colTanaman";
            colTanaman.ReadOnly = true;
            // 
            // colDiagnosa
            // 
            colDiagnosa.FillWeight = 140F;
            colDiagnosa.HeaderText = "Diagnosa";
            colDiagnosa.MinimumWidth = 6;
            colDiagnosa.Name = "colDiagnosa";
            colDiagnosa.ReadOnly = true;
            // 
            // colCocok
            // 
            colCocok.HeaderText = "Kecocokan";
            colCocok.MinimumWidth = 6;
            colCocok.Name = "colCocok";
            colCocok.ReadOnly = true;
            // 
            // pnlForm
            // 
            pnlForm.BackColor = System.Drawing.Color.White;
            pnlForm.Controls.Add(lblTanaman);
            pnlForm.Controls.Add(cmbTanaman);
            pnlForm.Controls.Add(lblGejala);
            pnlForm.Controls.Add(clbGejala);
            pnlForm.Controls.Add(btnAnalisis);
            pnlForm.Controls.Add(btnReset);
            pnlForm.Controls.Add(pnlHasil);
            pnlForm.Dock = System.Windows.Forms.DockStyle.Top;
            pnlForm.Location = new System.Drawing.Point(0, 64);
            pnlForm.Name = "pnlForm";
            pnlForm.Size = new System.Drawing.Size(940, 310);
            pnlForm.TabIndex = 2;
            // 
            // lblTanaman
            // 
            lblTanaman.AutoSize = true;
            lblTanaman.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblTanaman.ForeColor = System.Drawing.Color.FromArgb(84, 110, 122);
            lblTanaman.Location = new System.Drawing.Point(20, 12);
            lblTanaman.Name = "lblTanaman";
            lblTanaman.Size = new System.Drawing.Size(79, 23);
            lblTanaman.TabIndex = 3;
            lblTanaman.Text = "Tanaman";
            // 
            // cmbTanaman
            // 
            cmbTanaman.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbTanaman.FormattingEnabled = true;
            cmbTanaman.Location = new System.Drawing.Point(20, 36);
            cmbTanaman.Name = "cmbTanaman";
            cmbTanaman.Size = new System.Drawing.Size(420, 31);
            cmbTanaman.TabIndex = 4;
            // 
            // lblGejala
            // 
            lblGejala.AutoSize = true;
            lblGejala.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblGejala.ForeColor = System.Drawing.Color.FromArgb(84, 110, 122);
            lblGejala.Location = new System.Drawing.Point(20, 72);
            lblGejala.Name = "lblGejala";
            lblGejala.Size = new System.Drawing.Size(227, 23);
            lblGejala.TabIndex = 5;
            lblGejala.Text = "Centang gejala yang terlihat";
            // 
            // clbGejala
            // 
            clbGejala.CheckOnClick = true;
            clbGejala.FormattingEnabled = true;
            clbGejala.Location = new System.Drawing.Point(20, 96);
            clbGejala.Name = "clbGejala";
            clbGejala.Size = new System.Drawing.Size(420, 154);
            clbGejala.TabIndex = 6;
            // 
            // btnAnalisis
            // 
            btnAnalisis.BackColor = System.Drawing.Color.FromArgb(46, 125, 50);
            btnAnalisis.Cursor = System.Windows.Forms.Cursors.Hand;
            btnAnalisis.FlatAppearance.BorderSize = 0;
            btnAnalisis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnAnalisis.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnAnalisis.ForeColor = System.Drawing.Color.White;
            btnAnalisis.Location = new System.Drawing.Point(20, 264);
            btnAnalisis.Name = "btnAnalisis";
            btnAnalisis.Size = new System.Drawing.Size(200, 38);
            btnAnalisis.TabIndex = 7;
            btnAnalisis.Text = "Analisis Sekarang";
            btnAnalisis.UseVisualStyleBackColor = false;
            btnAnalisis.Click += BtnAnalisis_Click;
            // 
            // btnReset
            // 
            btnReset.BackColor = System.Drawing.Color.FromArgb(84, 110, 122);
            btnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            btnReset.FlatAppearance.BorderSize = 0;
            btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnReset.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnReset.ForeColor = System.Drawing.Color.White;
            btnReset.Location = new System.Drawing.Point(230, 264);
            btnReset.Name = "btnReset";
            btnReset.Size = new System.Drawing.Size(140, 38);
            btnReset.TabIndex = 8;
            btnReset.Text = "Reset Gejala";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += BtnReset_Click;
            // 
            // pnlHasil
            // 
            pnlHasil.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            pnlHasil.BackColor = System.Drawing.Color.FromArgb(232, 245, 233);
            pnlHasil.Controls.Add(lblHasilJudul);
            pnlHasil.Controls.Add(lblDiagnosa);
            pnlHasil.Controls.Add(lblKecocokan);
            pnlHasil.Controls.Add(lblPenyebab);
            pnlHasil.Controls.Add(lblPenanganan);
            pnlHasil.Location = new System.Drawing.Point(470, 12);
            pnlHasil.Name = "pnlHasil";
            pnlHasil.Size = new System.Drawing.Size(430, 286);
            pnlHasil.TabIndex = 9;
            // 
            // lblHasilJudul
            // 
            lblHasilJudul.AutoSize = true;
            lblHasilJudul.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblHasilJudul.ForeColor = System.Drawing.Color.FromArgb(27, 94, 32);
            lblHasilJudul.Location = new System.Drawing.Point(12, 8);
            lblHasilJudul.Name = "lblHasilJudul";
            lblHasilJudul.Size = new System.Drawing.Size(123, 23);
            lblHasilJudul.TabIndex = 10;
            lblHasilJudul.Text = "Hasil Diagnosa";
            // 
            // lblDiagnosa
            // 
            lblDiagnosa.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblDiagnosa.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblDiagnosa.ForeColor = System.Drawing.Color.FromArgb(198, 40, 40);
            lblDiagnosa.Location = new System.Drawing.Point(12, 38);
            lblDiagnosa.Name = "lblDiagnosa";
            lblDiagnosa.Size = new System.Drawing.Size(406, 30);
            lblDiagnosa.TabIndex = 11;
            lblDiagnosa.Text = "-";
            // 
            // lblKecocokan
            // 
            lblKecocokan.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblKecocokan.Location = new System.Drawing.Point(12, 70);
            lblKecocokan.Name = "lblKecocokan";
            lblKecocokan.Size = new System.Drawing.Size(406, 22);
            lblKecocokan.TabIndex = 12;
            // 
            // lblPenyebab
            // 
            lblPenyebab.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblPenyebab.Location = new System.Drawing.Point(12, 100);
            lblPenyebab.Name = "lblPenyebab";
            lblPenyebab.Size = new System.Drawing.Size(406, 80);
            lblPenyebab.TabIndex = 13;
            // 
            // lblPenanganan
            // 
            lblPenanganan.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblPenanganan.Location = new System.Drawing.Point(12, 188);
            lblPenanganan.Name = "lblPenanganan";
            lblPenanganan.Size = new System.Drawing.Size(406, 90);
            lblPenanganan.TabIndex = 14;
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
            lblJudul.Text = "Analisis Penyakit Tanaman";
            lblJudul.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AnalisisPage
            // 
            Controls.Add(pnlGrid);
            Controls.Add(pnlForm);
            Controls.Add(lblJudul);
            Name = "AnalisisPage";
            Size = new System.Drawing.Size(940, 720);
            pnlGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvRiwayat).EndInit();
            pnlForm.ResumeLayout(false);
            pnlForm.PerformLayout();
            pnlHasil.ResumeLayout(false);
            pnlHasil.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlGrid;
        private System.Windows.Forms.DataGridView dgvRiwayat;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colWaktu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTanaman;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiagnosa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCocok;
        private System.Windows.Forms.Panel pnlForm;
        private System.Windows.Forms.Label lblTanaman;
        private System.Windows.Forms.ComboBox cmbTanaman;
        private System.Windows.Forms.Label lblGejala;
        private System.Windows.Forms.CheckedListBox clbGejala;
        private System.Windows.Forms.Button btnAnalisis;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Panel pnlHasil;
        private System.Windows.Forms.Label lblHasilJudul;
        private System.Windows.Forms.Label lblDiagnosa;
        private System.Windows.Forms.Label lblKecocokan;
        private System.Windows.Forms.Label lblPenyebab;
        private System.Windows.Forms.Label lblPenanganan;
        private System.Windows.Forms.Label lblJudul;
    }
}
