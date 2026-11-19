using System;
using System.Drawing;
using System.Windows.Forms;
using HydroSmart.Services;

namespace HydroSmart.Forms
{
    public class LoginForm : Form
    {
        private readonly AuthService _auth;
        private TextBox txtUser;
        private TextBox txtPass;
        private CheckBox chkLihat;
        private Label lblError;
        private Button btnLogin;
        private Label label1;
        private Panel panel1;
        private Panel panel2;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBox1;
        private TextBox textBox2;
        private CheckBox checkBox1;
        private Button button1;
        private int _gagal = 0;

        public LoginForm() : this(new AuthService())
        {
        }

        public LoginForm(AuthService auth)
        {
            _auth = auth;
            Bangun();
        }



        private void Bangun()
        {
            Text = "HydroSmart - Login";
            ClientSize = new Size(760, 460);
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.Sizable;
            MaximizeBox = true;
            MinimizeBox = true;
            MinimumSize = new Size(760, 460);
            BackColor = Color.White;
            Font = Tema.FontNormal;

            // Panel kiri (branding)
            Panel kiri = new Panel();
            kiri.Dock = DockStyle.Left;
            kiri.Width = 320;
            kiri.BackColor = Tema.Hijau;

            Label brand = new Label();
            brand.Text = "HydroSmart";
            brand.Font = new Font("Segoe UI Semibold", 28F);
            brand.ForeColor = Color.White;
            brand.AutoSize = true;
            brand.Left = 30;
            brand.Top = 160;

            Label tag = new Label();
            tag.Text = "Sistem manajemen\r\nhidroponik pintar";
            tag.Font = new Font("Segoe UI", 13F);
            tag.ForeColor = Color.FromArgb(220, 240, 220);
            tag.AutoSize = true;
            tag.Left = 34;
            tag.Top = 225;

            kiri.Controls.Add(brand);
            kiri.Controls.Add(tag);
            Controls.Add(kiri);

            // Form kanan
            Label sapa = new Label();
            sapa.Text = "Selamat Datang";
            sapa.Font = Tema.FontJudul;
            sapa.ForeColor = Tema.HijauTua;
            sapa.AutoSize = true;
            sapa.Left = 370;
            sapa.Top = 70;
            Controls.Add(sapa);

            Label sub = new Label();
            sub.Text = "Silakan login untuk melanjutkan";
            sub.ForeColor = Tema.Abu;
            sub.AutoSize = true;
            sub.Left = 372;
            sub.Top = 115;
            Controls.Add(sub);

            Controls.Add(Tema.Lbl("Username", 370, 160));
            txtUser = new TextBox();
            txtUser.Left = 370;
            txtUser.Top = 184;
            txtUser.Width = 330;
            txtUser.Font = new Font("Segoe UI", 11F);
            Controls.Add(txtUser);

            Controls.Add(Tema.Lbl("Password", 370, 226));
            txtPass = new TextBox();
            txtPass.Left = 370;
            txtPass.Top = 250;
            txtPass.Width = 330;
            txtPass.Font = new Font("Segoe UI", 11F);
            txtPass.UseSystemPasswordChar = true;
            Controls.Add(txtPass);

            chkLihat = new CheckBox();
            chkLihat.Text = "Tampilkan password";
            chkLihat.Left = 370;
            chkLihat.Top = 290;
            chkLihat.AutoSize = true;
            chkLihat.CheckedChanged += delegate { txtPass.UseSystemPasswordChar = !chkLihat.Checked; };
            Controls.Add(chkLihat);

            lblError = new Label();
            lblError.Left = 370;
            lblError.Top = 320;
            lblError.Width = 330;
            lblError.Height = 22;
            lblError.ForeColor = Tema.Merah;
            Controls.Add(lblError);

            btnLogin = Tema.Tombol("Login", Tema.Hijau, 370, 352, 330);
            btnLogin.Click += BtnLogin_Click;
            Controls.Add(btnLogin);

            Label hint = new Label();
            hint.Text = "Akun demo: admin / admin123";
            hint.ForeColor = Tema.Abu;
            hint.AutoSize = true;
            hint.Left = 370;
            hint.Top = 410;
            Controls.Add(hint);

            AcceptButton = btnLogin;
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            label1 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            checkBox1 = new CheckBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(157, 145);
            label1.Name = "label1";
            label1.Size = new Size(0, 25);
            label1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Location = new Point(175, 40);
            panel1.Name = "panel1";
            panel1.Size = new Size(26, 8);
            panel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkGreen;
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.Location = new Point(1, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(279, 403);
            panel2.TabIndex = 2;
            panel2.Paint += panel2_Paint;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Variable Text", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.ForestGreen;
            label2.Location = new Point(314, 57);
            label2.Name = "label2";
            label2.Size = new Size(227, 37);
            label2.TabIndex = 3;
            label2.Text = "Selamat Datang";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Variable Small", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.ForestGreen;
            label3.Location = new Point(314, 99);
            label3.Name = "label3";
            label3.Size = new Size(280, 24);
            label3.TabIndex = 4;
            label3.Text = "Silakan login untuk melanjutkan";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Variable Small", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(317, 145);
            label4.Name = "label4";
            label4.Size = new Size(95, 24);
            label4.TabIndex = 5;
            label4.Text = "Username";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Variable Small", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(314, 198);
            label5.Name = "label5";
            label5.Size = new Size(88, 24);
            label5.TabIndex = 6;
            label5.Text = "Password";
            label5.Click += label5_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(317, 168);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(243, 31);
            textBox1.TabIndex = 7;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(314, 221);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(243, 31);
            textBox2.TabIndex = 8;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(317, 254);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(199, 29);
            checkBox1.TabIndex = 9;
            checkBox1.Text = "Tampilkan password";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.BackColor = Color.Green;
            button1.ForeColor = Color.White;
            button1.Location = new Point(314, 295);
            button1.Name = "button1";
            button1.Size = new Size(243, 36);
            button1.TabIndex = 10;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = false;
            // 
            // LoginForm
            // 
            ClientSize = new Size(1473, 674);
            Controls.Add(button1);
            Controls.Add(checkBox1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "LoginForm";
            ResumeLayout(false);
            PerformLayout();

        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (txtUser.Text.Trim() == "" || txtPass.Text == "")
            {
                lblError.Text = "Username dan password wajib diisi.";
                return;
            }

            if (_auth.Login(txtUser.Text, txtPass.Text))
            {
                DialogResult = DialogResult.OK;   // menutup dialog login
                return;
            }

            _gagal++;
            lblError.Text = "Username atau password salah (percobaan " + _gagal + " dari 3).";
            txtPass.Clear();
            txtPass.Focus();

            if (_gagal >= 3)
            {
                MessageBox.Show("Terlalu banyak percobaan gagal. Coba lagi.", "HydroSmart",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                _gagal = 0;
                lblError.Text = "";
                txtUser.Clear();
                txtUser.Focus();
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
