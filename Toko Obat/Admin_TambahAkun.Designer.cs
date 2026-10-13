namespace Toko_Obat
{
    partial class Admin_TambahAkun
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

        private void InitializeComponent()
        {
            pnlContainer = new Panel();
            btnBack = new Button();
            lblTitle = new Label();
            pnlFoto = new Panel();
            lblFotoTitle = new Label();
            lblFotoDesc = new Label();
            picPreview = new PictureBox();
            btnPilihFoto = new Button();
            pnlForm = new Panel();
            lblUsernameLabel = new Label();
            txtUsername = new TextBox();
            lblPasswordLabel = new Label();
            txtPassword = new TextBox();
            lblPasswordDesc = new Label();
            lblRoleLabel = new Label();
            cmbRole = new ComboBox();
            pnlButtons = new Panel();
            lblInfo = new Label();
            btnBatal = new Button();
            btnSelesai = new Button();
            pnlContainer.SuspendLayout();
            pnlFoto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picPreview).BeginInit();
            pnlForm.SuspendLayout();
            pnlButtons.SuspendLayout();
            SuspendLayout();
            // 
            // pnlContainer
            // 
            pnlContainer.AutoScroll = true;
            pnlContainer.BackColor = Color.FromArgb(248, 248, 250);
            pnlContainer.Controls.Add(btnBack);
            pnlContainer.Controls.Add(lblTitle);
            pnlContainer.Controls.Add(pnlFoto);
            pnlContainer.Controls.Add(pnlForm);
            pnlContainer.Controls.Add(pnlButtons);
            pnlContainer.Dock = DockStyle.Fill;
            pnlContainer.Location = new Point(0, 0);
            pnlContainer.Margin = new Padding(4, 5, 4, 5);
            pnlContainer.Name = "pnlContainer";
            pnlContainer.Size = new Size(1429, 1000);
            pnlContainer.TabIndex = 0;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Transparent;
            btnBack.Cursor = Cursors.Hand;
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Segoe UI", 10F);
            btnBack.ForeColor = Color.FromArgb(0, 140, 110);
            btnBack.Location = new Point(536, 33);
            btnBack.Margin = new Padding(4, 5, 4, 5);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(214, 50);
            btnBack.TabIndex = 0;
            btnBack.Text = "◀ Kembali ke Akun";
            btnBack.UseVisualStyleBackColor = false;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(50, 50, 50);
            lblTitle.Location = new Point(536, 100);
            lblTitle.Margin = new Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(340, 48);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Tambah Akun Baru";
            // 
            // pnlFoto
            // 
            pnlFoto.BackColor = Color.White;
            pnlFoto.BorderStyle = BorderStyle.FixedSingle;
            pnlFoto.Controls.Add(lblFotoTitle);
            pnlFoto.Controls.Add(lblFotoDesc);
            pnlFoto.Controls.Add(picPreview);
            pnlFoto.Controls.Add(btnPilihFoto);
            pnlFoto.Location = new Point(536, 175);
            pnlFoto.Margin = new Padding(4, 5, 4, 5);
            pnlFoto.Name = "pnlFoto";
            pnlFoto.Size = new Size(642, 249);
            pnlFoto.TabIndex = 2;
            // 
            // lblFotoTitle
            // 
            lblFotoTitle.AutoSize = true;
            lblFotoTitle.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblFotoTitle.Location = new Point(21, 25);
            lblFotoTitle.Margin = new Padding(4, 0, 4, 0);
            lblFotoTitle.Name = "lblFotoTitle";
            lblFotoTitle.Size = new Size(158, 30);
            lblFotoTitle.TabIndex = 0;
            lblFotoTitle.Text = "👤 Foto Profil";
            // 
            // lblFotoDesc
            // 
            lblFotoDesc.AutoSize = true;
            lblFotoDesc.Font = new Font("Segoe UI", 8F);
            lblFotoDesc.ForeColor = Color.Gray;
            lblFotoDesc.Location = new Point(357, 25);
            lblFotoDesc.Margin = new Padding(4, 0, 4, 0);
            lblFotoDesc.Name = "lblFotoDesc";
            lblFotoDesc.Size = new Size(378, 21);
            lblFotoDesc.TabIndex = 1;
            lblFotoDesc.Text = "Maksimal 2 MB dengan format JPG, PNG, atau WEBP.";
            // 
            // picPreview
            // 
            picPreview.BackColor = Color.FromArgb(230, 240, 240);
            picPreview.BorderStyle = BorderStyle.FixedSingle;
            picPreview.Location = new Point(21, 75);
            picPreview.Margin = new Padding(4, 5, 4, 5);
            picPreview.Name = "picPreview";
            picPreview.Size = new Size(142, 165);
            picPreview.TabIndex = 2;
            picPreview.TabStop = false;
            // 
            // btnPilihFoto
            // 
            btnPilihFoto.BackColor = Color.FromArgb(0, 140, 110);
            btnPilihFoto.Cursor = Cursors.Hand;
            btnPilihFoto.FlatAppearance.BorderSize = 0;
            btnPilihFoto.FlatStyle = FlatStyle.Flat;
            btnPilihFoto.Font = new Font("Segoe UI", 10F);
            btnPilihFoto.ForeColor = Color.White;
            btnPilihFoto.Location = new Point(386, 117);
            btnPilihFoto.Margin = new Padding(4, 5, 4, 5);
            btnPilihFoto.Name = "btnPilihFoto";
            btnPilihFoto.Size = new Size(221, 58);
            btnPilihFoto.TabIndex = 3;
            btnPilihFoto.Text = "📁 Pilih Foto";
            btnPilihFoto.UseVisualStyleBackColor = false;
            // 
            // pnlForm
            // 
            pnlForm.BackColor = Color.White;
            pnlForm.BorderStyle = BorderStyle.FixedSingle;
            pnlForm.Controls.Add(lblUsernameLabel);
            pnlForm.Controls.Add(txtUsername);
            pnlForm.Controls.Add(lblPasswordLabel);
            pnlForm.Controls.Add(txtPassword);
            pnlForm.Controls.Add(lblPasswordDesc);
            pnlForm.Controls.Add(lblRoleLabel);
            pnlForm.Controls.Add(cmbRole);
            pnlForm.Location = new Point(536, 450);
            pnlForm.Margin = new Padding(4, 5, 4, 5);
            pnlForm.Name = "pnlForm";
            pnlForm.Size = new Size(642, 399);
            pnlForm.TabIndex = 3;
            // 
            // lblUsernameLabel
            // 
            lblUsernameLabel.AutoSize = true;
            lblUsernameLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblUsernameLabel.Location = new Point(21, 25);
            lblUsernameLabel.Margin = new Padding(4, 0, 4, 0);
            lblUsernameLabel.Name = "lblUsernameLabel";
            lblUsernameLabel.Size = new Size(121, 28);
            lblUsernameLabel.TabIndex = 0;
            lblUsernameLabel.Text = "Username *";
            // 
            // txtUsername
            // 
            txtUsername.BorderStyle = BorderStyle.FixedSingle;
            txtUsername.Font = new Font("Segoe UI", 10F);
            txtUsername.Location = new Point(21, 67);
            txtUsername.Margin = new Padding(4, 5, 4, 5);
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = "Masukkan username";
            txtUsername.Size = new Size(599, 34);
            txtUsername.TabIndex = 1;
            // 
            // lblPasswordLabel
            // 
            lblPasswordLabel.AutoSize = true;
            lblPasswordLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblPasswordLabel.Location = new Point(21, 133);
            lblPasswordLabel.Margin = new Padding(4, 0, 4, 0);
            lblPasswordLabel.Name = "lblPasswordLabel";
            lblPasswordLabel.Size = new Size(116, 28);
            lblPasswordLabel.TabIndex = 2;
            lblPasswordLabel.Text = "Password *";
            // 
            // txtPassword
            // 
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Font = new Font("Segoe UI", 10F);
            txtPassword.Location = new Point(21, 175);
            txtPassword.Margin = new Padding(4, 5, 4, 5);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Masukkan password";
            txtPassword.Size = new Size(599, 34);
            txtPassword.TabIndex = 3;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // lblPasswordDesc
            // 
            lblPasswordDesc.AutoSize = true;
            lblPasswordDesc.Font = new Font("Segoe UI", 8F);
            lblPasswordDesc.ForeColor = Color.Gray;
            lblPasswordDesc.Location = new Point(21, 225);
            lblPasswordDesc.Margin = new Padding(4, 0, 4, 0);
            lblPasswordDesc.Name = "lblPasswordDesc";
            lblPasswordDesc.Size = new Size(286, 21);
            lblPasswordDesc.TabIndex = 4;
            lblPasswordDesc.Text = "Gunakan kombinasi minimal 8 karakter.";
            // 
            // lblRoleLabel
            // 
            lblRoleLabel.AutoSize = true;
            lblRoleLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblRoleLabel.Location = new Point(21, 258);
            lblRoleLabel.Margin = new Padding(4, 0, 4, 0);
            lblRoleLabel.Name = "lblRoleLabel";
            lblRoleLabel.Size = new Size(69, 28);
            lblRoleLabel.TabIndex = 5;
            lblRoleLabel.Text = "Role *";
            // 
            // cmbRole
            // 
            cmbRole.FormattingEnabled = true;
            cmbRole.Items.AddRange(new object[] { "Pilih hak akses / role", "Admin", "Kasir", "Owner" });
            cmbRole.Location = new Point(21, 300);
            cmbRole.Margin = new Padding(4, 5, 4, 5);
            cmbRole.Name = "cmbRole";
            cmbRole.Size = new Size(598, 33);
            cmbRole.TabIndex = 6;
            // 
            // pnlButtons
            // 
            pnlButtons.BackColor = Color.FromArgb(248, 248, 250);
            pnlButtons.Controls.Add(lblInfo);
            pnlButtons.Controls.Add(btnBatal);
            pnlButtons.Controls.Add(btnSelesai);
            pnlButtons.Location = new Point(536, 867);
            pnlButtons.Margin = new Padding(4, 5, 4, 5);
            pnlButtons.Name = "pnlButtons";
            pnlButtons.Size = new Size(643, 83);
            pnlButtons.TabIndex = 4;
            // 
            // lblInfo
            // 
            lblInfo.AutoSize = true;
            lblInfo.Font = new Font("Segoe UI", 9F);
            lblInfo.ForeColor = Color.FromArgb(0, 140, 110);
            lblInfo.Location = new Point(21, 25);
            lblInfo.Margin = new Padding(4, 0, 4, 0);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(273, 25);
            lblInfo.TabIndex = 0;
            lblInfo.Text = "✓ Perubahan tersimpan otomatis";
            // 
            // btnBatal
            // 
            btnBatal.BackColor = Color.White;
            btnBatal.Cursor = Cursors.Hand;
            btnBatal.FlatAppearance.BorderColor = Color.Gray;
            btnBatal.FlatStyle = FlatStyle.Flat;
            btnBatal.Font = new Font("Segoe UI", 10F);
            btnBatal.Location = new Point(421, 17);
            btnBatal.Margin = new Padding(4, 5, 4, 5);
            btnBatal.Name = "btnBatal";
            btnBatal.Size = new Size(107, 52);
            btnBatal.TabIndex = 1;
            btnBatal.Text = "Batal";
            btnBatal.UseVisualStyleBackColor = false;
            // 
            // btnSelesai
            // 
            btnSelesai.BackColor = Color.FromArgb(0, 140, 110);
            btnSelesai.Cursor = Cursors.Hand;
            btnSelesai.FlatAppearance.BorderSize = 0;
            btnSelesai.FlatStyle = FlatStyle.Flat;
            btnSelesai.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSelesai.ForeColor = Color.White;
            btnSelesai.Location = new Point(536, 17);
            btnSelesai.Margin = new Padding(4, 5, 4, 5);
            btnSelesai.Name = "btnSelesai";
            btnSelesai.Size = new Size(86, 52);
            btnSelesai.TabIndex = 2;
            btnSelesai.Text = "✔ Selesai";
            btnSelesai.UseVisualStyleBackColor = false;
            // 
            // Admin_TambahAkun
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1429, 1000);
            Controls.Add(pnlContainer);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Admin_TambahAkun";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin - Tambah Akun Baru";
            Load += Admin_TambahAkun_Load;
            pnlContainer.ResumeLayout(false);
            pnlContainer.PerformLayout();
            pnlFoto.ResumeLayout(false);
            pnlFoto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picPreview).EndInit();
            pnlForm.ResumeLayout(false);
            pnlForm.PerformLayout();
            pnlButtons.ResumeLayout(false);
            pnlButtons.PerformLayout();
            ResumeLayout(false);
        }

        private System.Windows.Forms.Panel pnlContainer;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlFoto;
        private System.Windows.Forms.Label lblFotoDesc;
        private System.Windows.Forms.Button btnPilihFoto;
        private System.Windows.Forms.PictureBox picPreview;
        private System.Windows.Forms.Label lblFotoTitle;
        private System.Windows.Forms.Panel pnlForm;
        private System.Windows.Forms.Label lblUsernameLabel;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblPasswordLabel;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPasswordDesc;
        private System.Windows.Forms.Label lblRoleLabel;
        private System.Windows.Forms.ComboBox cmbRole;
        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Button btnBatal;
        private System.Windows.Forms.Button btnSelesai;
    }
}