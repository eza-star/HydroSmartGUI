namespace HydroSmart.Forms
{
    partial class DashboardPage
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
            this.colNama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colJenis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLokasi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUmur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFase = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPanen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flowKartu = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlKartuTotal = new System.Windows.Forms.Panel();
            this.pnlGarisTotal = new System.Windows.Forms.Panel();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblKetTotal = new System.Windows.Forms.Label();
            this.pnlKartuPanen = new System.Windows.Forms.Panel();
            this.pnlGarisPanen = new System.Windows.Forms.Panel();
            this.lblPanen = new System.Windows.Forms.Label();
            this.lblKetPanen = new System.Windows.Forms.Label();
            this.pnlKartuAnalisis = new System.Windows.Forms.Panel();
            this.pnlGarisAnalisis = new System.Windows.Forms.Panel();
            this.lblAnalisis = new System.Windows.Forms.Label();
            this.lblKetAnalisis = new System.Windows.Forms.Label();
            this.lblJudul = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTanaman)).BeginInit();
            this.pnlGrid.SuspendLayout();
            this.flowKartu.SuspendLayout();
            this.pnlKartuTotal.SuspendLayout();
            this.pnlKartuPanen.SuspendLayout();
            this.pnlKartuAnalisis.SuspendLayout();
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
            this.colNama,
            this.colJenis,
            this.colLokasi,
            this.colUmur,
            this.colFase,
            this.colPanen});
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
            this.dgvTanaman.Size = new System.Drawing.Size(900, 520);
            this.dgvTanaman.TabIndex = 1;
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
            // colUmur
            // 
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
            // flowKartu
            // 
            this.flowKartu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(248)))), ((int)(((byte)(244)))));
            this.flowKartu.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowKartu.Location = new System.Drawing.Point(0, 64);
            this.flowKartu.Padding = new System.Windows.Forms.Padding(20, 10, 0, 0);
            this.flowKartu.Size = new System.Drawing.Size(940, 116);
            this.flowKartu.TabIndex = 2;
            this.flowKartu.Controls.Add(this.pnlKartuTotal);
            this.flowKartu.Controls.Add(this.pnlKartuPanen);
            this.flowKartu.Controls.Add(this.pnlKartuAnalisis);
            // 
            // pnlKartuTotal
            // 
            this.pnlKartuTotal.BackColor = System.Drawing.Color.White;
            this.pnlKartuTotal.Location = new System.Drawing.Point(20, 10);
            this.pnlKartuTotal.Margin = new System.Windows.Forms.Padding(0, 0, 16, 0);
            this.pnlKartuTotal.Size = new System.Drawing.Size(210, 96);
            this.pnlKartuTotal.TabIndex = 3;
            this.pnlKartuTotal.Controls.Add(this.pnlGarisTotal);
            this.pnlKartuTotal.Controls.Add(this.lblTotal);
            this.pnlKartuTotal.Controls.Add(this.lblKetTotal);
            // 
            // pnlGarisTotal
            // 
            this.pnlGarisTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            this.pnlGarisTotal.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlGarisTotal.Location = new System.Drawing.Point(0, 0);
            this.pnlGarisTotal.Size = new System.Drawing.Size(6, 96);
            this.pnlGarisTotal.TabIndex = 4;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            this.lblTotal.Location = new System.Drawing.Point(20, 8);
            this.lblTotal.Size = new System.Drawing.Size(45, 54);
            this.lblTotal.Text = "0";
            this.lblTotal.TabIndex = 5;
            // 
            // lblKetTotal
            // 
            this.lblKetTotal.AutoSize = true;
            this.lblKetTotal.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKetTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(110)))), ((int)(((byte)(122)))));
            this.lblKetTotal.Location = new System.Drawing.Point(22, 64);
            this.lblKetTotal.Size = new System.Drawing.Size(100, 23);
            this.lblKetTotal.Text = "Total tanaman";
            this.lblKetTotal.TabIndex = 6;
            // 
            // pnlKartuPanen
            // 
            this.pnlKartuPanen.BackColor = System.Drawing.Color.White;
            this.pnlKartuPanen.Location = new System.Drawing.Point(20, 10);
            this.pnlKartuPanen.Margin = new System.Windows.Forms.Padding(0, 0, 16, 0);
            this.pnlKartuPanen.Size = new System.Drawing.Size(210, 96);
            this.pnlKartuPanen.TabIndex = 7;
            this.pnlKartuPanen.Controls.Add(this.pnlGarisPanen);
            this.pnlKartuPanen.Controls.Add(this.lblPanen);
            this.pnlKartuPanen.Controls.Add(this.lblKetPanen);
            // 
            // pnlGarisPanen
            // 
            this.pnlGarisPanen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(101)))), ((int)(((byte)(192)))));
            this.pnlGarisPanen.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlGarisPanen.Location = new System.Drawing.Point(0, 0);
            this.pnlGarisPanen.Size = new System.Drawing.Size(6, 96);
            this.pnlGarisPanen.TabIndex = 8;
            // 
            // lblPanen
            // 
            this.lblPanen.AutoSize = true;
            this.lblPanen.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPanen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(101)))), ((int)(((byte)(192)))));
            this.lblPanen.Location = new System.Drawing.Point(20, 8);
            this.lblPanen.Size = new System.Drawing.Size(45, 54);
            this.lblPanen.Text = "0";
            this.lblPanen.TabIndex = 9;
            // 
            // lblKetPanen
            // 
            this.lblKetPanen.AutoSize = true;
            this.lblKetPanen.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKetPanen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(110)))), ((int)(((byte)(122)))));
            this.lblKetPanen.Location = new System.Drawing.Point(22, 64);
            this.lblKetPanen.Size = new System.Drawing.Size(100, 23);
            this.lblKetPanen.Text = "Menjelang / siap panen";
            this.lblKetPanen.TabIndex = 10;
            // 
            // pnlKartuAnalisis
            // 
            this.pnlKartuAnalisis.BackColor = System.Drawing.Color.White;
            this.pnlKartuAnalisis.Location = new System.Drawing.Point(20, 10);
            this.pnlKartuAnalisis.Margin = new System.Windows.Forms.Padding(0, 0, 16, 0);
            this.pnlKartuAnalisis.Size = new System.Drawing.Size(210, 96);
            this.pnlKartuAnalisis.TabIndex = 11;
            this.pnlKartuAnalisis.Controls.Add(this.pnlGarisAnalisis);
            this.pnlKartuAnalisis.Controls.Add(this.lblAnalisis);
            this.pnlKartuAnalisis.Controls.Add(this.lblKetAnalisis);
            // 
            // pnlGarisAnalisis
            // 
            this.pnlGarisAnalisis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(108)))), ((int)(((byte)(0)))));
            this.pnlGarisAnalisis.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlGarisAnalisis.Location = new System.Drawing.Point(0, 0);
            this.pnlGarisAnalisis.Size = new System.Drawing.Size(6, 96);
            this.pnlGarisAnalisis.TabIndex = 12;
            // 
            // lblAnalisis
            // 
            this.lblAnalisis.AutoSize = true;
            this.lblAnalisis.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnalisis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(108)))), ((int)(((byte)(0)))));
            this.lblAnalisis.Location = new System.Drawing.Point(20, 8);
            this.lblAnalisis.Size = new System.Drawing.Size(45, 54);
            this.lblAnalisis.Text = "0";
            this.lblAnalisis.TabIndex = 13;
            // 
            // lblKetAnalisis
            // 
            this.lblKetAnalisis.AutoSize = true;
            this.lblKetAnalisis.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKetAnalisis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(110)))), ((int)(((byte)(122)))));
            this.lblKetAnalisis.Location = new System.Drawing.Point(22, 64);
            this.lblKetAnalisis.Size = new System.Drawing.Size(100, 23);
            this.lblKetAnalisis.Text = "Analisis dilakukan";
            this.lblKetAnalisis.TabIndex = 14;
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
            this.lblJudul.Text = "Dashboard";
            this.lblJudul.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblJudul.TabIndex = 15;
            // 
            // DashboardPage
            // 
            this.Size = new System.Drawing.Size(940, 720);
            this.Controls.Add(this.pnlGrid);
            this.Controls.Add(this.flowKartu);
            this.Controls.Add(this.lblJudul);
            this.Name = "DashboardPage";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTanaman)).EndInit();
            this.pnlKartuAnalisis.ResumeLayout(false);
            this.pnlKartuAnalisis.PerformLayout();
            this.pnlKartuPanen.ResumeLayout(false);
            this.pnlKartuPanen.PerformLayout();
            this.pnlKartuTotal.ResumeLayout(false);
            this.pnlKartuTotal.PerformLayout();
            this.flowKartu.ResumeLayout(false);
            this.flowKartu.PerformLayout();
            this.pnlGrid.ResumeLayout(false);
            this.pnlGrid.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlGrid;
        private System.Windows.Forms.DataGridView dgvTanaman;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNama;
        private System.Windows.Forms.DataGridViewTextBoxColumn colJenis;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLokasi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUmur;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFase;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPanen;
        private System.Windows.Forms.FlowLayoutPanel flowKartu;
        private System.Windows.Forms.Panel pnlKartuTotal;
        private System.Windows.Forms.Panel pnlGarisTotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblKetTotal;
        private System.Windows.Forms.Panel pnlKartuPanen;
        private System.Windows.Forms.Panel pnlGarisPanen;
        private System.Windows.Forms.Label lblPanen;
        private System.Windows.Forms.Label lblKetPanen;
        private System.Windows.Forms.Panel pnlKartuAnalisis;
        private System.Windows.Forms.Panel pnlGarisAnalisis;
        private System.Windows.Forms.Label lblAnalisis;
        private System.Windows.Forms.Label lblKetAnalisis;
        private System.Windows.Forms.Label lblJudul;
    }
}
