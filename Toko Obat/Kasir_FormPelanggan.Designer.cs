namespace Toko_Obat
{
    partial class Kasir_FormPelanggan
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            panelHeader = new Panel();
            lblTitle = new Label();
            lblNama = new Label();
            txtNama = new TextBox();
            lblEmail = new Label();
            txtEmail = new TextBox();
            lblNomorHP = new Label();
            txtNomorHP = new TextBox();
            btnSimpan = new Button();
            btnBatal = new Button();
            panelHeader.SuspendLayout();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(15, 157, 138);
            panelHeader.Controls.Add(lblTitle);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(420, 60);
            panelHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.Dock = DockStyle.Fill;
            lblTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(0, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(420, 60);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Daftarkan Pelanggan Baru";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblNama
            // 
            lblNama.AutoSize = true;
            lblNama.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblNama.Location = new Point(30, 85);
            lblNama.Name = "lblNama";
            lblNama.Size = new Size(130, 20);
            lblNama.TabIndex = 1;
            lblNama.Text = "Nama Pelanggan *";
            // 
            // txtNama
            // 
            txtNama.Font = new Font("Segoe UI", 10F);
            txtNama.Location = new Point(30, 110);
            txtNama.Name = "txtNama";
            txtNama.Size = new Size(360, 30);
            txtNama.TabIndex = 2;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblEmail.Location = new Point(30, 155);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(59, 20);
            lblEmail.TabIndex = 3;
            lblEmail.Text = "Email *";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 10F);
            txtEmail.Location = new Point(30, 180);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(360, 30);
            txtEmail.TabIndex = 4;
            // 
            // lblNomorHP
            // 
            lblNomorHP.AutoSize = true;
            lblNomorHP.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblNomorHP.Location = new Point(30, 225);
            lblNomorHP.Name = "lblNomorHP";
            lblNomorHP.Size = new Size(160, 20);
            lblNomorHP.TabIndex = 5;
            lblNomorHP.Text = "Nomor Telepon/HP *";
            // 
            // txtNomorHP
            // 
            txtNomorHP.Font = new Font("Segoe UI", 10F);
            txtNomorHP.Location = new Point(30, 250);
            txtNomorHP.Name = "txtNomorHP";
            txtNomorHP.Size = new Size(360, 30);
            txtNomorHP.TabIndex = 6;
            // 
            // btnSimpan
            // 
            btnSimpan.BackColor = Color.FromArgb(15, 157, 138);
            btnSimpan.FlatStyle = FlatStyle.Flat;
            btnSimpan.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSimpan.ForeColor = Color.White;
            btnSimpan.Location = new Point(230, 310);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(160, 42);
            btnSimpan.TabIndex = 7;
            btnSimpan.Text = "Simpan";
            btnSimpan.UseVisualStyleBackColor = false;
            btnSimpan.Click += btnSimpan_Click;
            // 
            // btnBatal
            // 
            btnBatal.BackColor = Color.White;
            btnBatal.FlatStyle = FlatStyle.Flat;
            btnBatal.Font = new Font("Segoe UI", 10F);
            btnBatal.ForeColor = Color.DimGray;
            btnBatal.Location = new Point(30, 310);
            btnBatal.Name = "btnBatal";
            btnBatal.Size = new Size(120, 42);
            btnBatal.TabIndex = 8;
            btnBatal.Text = "Batal";
            btnBatal.UseVisualStyleBackColor = false;
            btnBatal.Click += btnBatal_Click;
            // 
            // Kasir_FormPelanggan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 249, 248);
            ClientSize = new Size(420, 380);
            Controls.Add(btnBatal);
            Controls.Add(btnSimpan);
            Controls.Add(txtNomorHP);
            Controls.Add(lblNomorHP);
            Controls.Add(txtEmail);
            Controls.Add(lblEmail);
            Controls.Add(txtNama);
            Controls.Add(lblNama);
            Controls.Add(panelHeader);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Kasir_FormPelanggan";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Daftarkan Pelanggan";
            panelHeader.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelHeader;
        private Label lblTitle;
        private Label lblNama;
        public TextBox txtNama;
        private Label lblEmail;
        public TextBox txtEmail;
        private Label lblNomorHP;
        public TextBox txtNomorHP;
        private Button btnSimpan;
        private Button btnBatal;
    }
}
