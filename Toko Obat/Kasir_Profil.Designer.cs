namespace Toko_Obat
{
    partial class Kasir_Profil
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
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlFotoProfil = new System.Windows.Forms.Panel();
            this.lblFormatFoto = new System.Windows.Forms.Label();
            this.lblFotoText = new System.Windows.Forms.Label();
            this.lblFotoProfilTitle = new System.Windows.Forms.Label();
            this.pnlKredensial = new System.Windows.Forms.Panel();
            this.lblKredensialStatus = new System.Windows.Forms.Label();
            this.lblKredensialTitle = new System.Windows.Forms.Label();
            this.lblUsernameLabel = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblPasswordLabel = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblNameLabel = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblPasswordDesc = new System.Windows.Forms.Label();
            this.pnlContainer.SuspendLayout();
            this.pnlFotoProfil.SuspendLayout();
            this.pnlKredensial.SuspendLayout();
            this.SuspendLayout();

            // pnlContainer
            this.pnlContainer.BackColor = System.Drawing.Color.FromArgb(248, 248, 250);
            this.pnlContainer.Controls.Add(this.lblTitle);
            this.pnlContainer.Controls.Add(this.pnlFotoProfil);
            this.pnlContainer.Controls.Add(this.pnlKredensial);
            this.pnlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContainer.Location = new System.Drawing.Point(0, 0);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(1000, 728);
            this.pnlContainer.TabIndex = 0;
            this.pnlContainer.AutoScroll = true;

            // lblTitle
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(50, 50, 50);
            this.lblTitle.Location = new System.Drawing.Point(325, 25);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(100, 45);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Profil";

            // pnlFotoProfil
            this.pnlFotoProfil.BackColor = System.Drawing.Color.White;
            this.pnlFotoProfil.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlFotoProfil.Controls.Add(this.lblFormatFoto);
            this.pnlFotoProfil.Controls.Add(this.lblFotoText);
            this.pnlFotoProfil.Controls.Add(this.lblFotoProfilTitle);
            this.pnlFotoProfil.Location = new System.Drawing.Point(325, 80);
            this.pnlFotoProfil.Name = "pnlFotoProfil";
            this.pnlFotoProfil.Size = new System.Drawing.Size(350, 180);
            this.pnlFotoProfil.TabIndex = 1;

            // lblFotoProfilTitle
            this.lblFotoProfilTitle.AutoSize = true;
            this.lblFotoProfilTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblFotoProfilTitle.Location = new System.Drawing.Point(15, 15);
            this.lblFotoProfilTitle.Name = "lblFotoProfilTitle";
            this.lblFotoProfilTitle.Size = new System.Drawing.Size(100, 20);
            this.lblFotoProfilTitle.TabIndex = 0;
            this.lblFotoProfilTitle.Text = "📷 Foto Profil";

            // lblFormatFoto
            this.lblFormatFoto.AutoSize = true;
            this.lblFormatFoto.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblFormatFoto.ForeColor = System.Drawing.Color.Gray;
            this.lblFormatFoto.Location = new System.Drawing.Point(200, 15);
            this.lblFormatFoto.Name = "lblFormatFoto";
            this.lblFormatFoto.Size = new System.Drawing.Size(140, 14);
            this.lblFormatFoto.TabIndex = 1;
            this.lblFormatFoto.Text = "Format: JPG, PNG (Maks 2MB)";

            // lblFotoText
            this.lblFotoText.AutoSize = false;
            this.lblFotoText.BackColor = System.Drawing.Color.FromArgb(200, 230, 230);
            this.lblFotoText.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.lblFotoText.ForeColor = System.Drawing.Color.FromArgb(0, 120, 100);
            this.lblFotoText.Location = new System.Drawing.Point(65, 55);
            this.lblFotoText.Size = new System.Drawing.Size(100, 100);
            this.lblFotoText.TabIndex = 2;
            this.lblFotoText.Text = "SR";
            this.lblFotoText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // pnlKredensial
            this.pnlKredensial.BackColor = System.Drawing.Color.White;
            this.pnlKredensial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlKredensial.Controls.Add(this.lblKredensialStatus);
            this.pnlKredensial.Controls.Add(this.lblKredensialTitle);
            this.pnlKredensial.Controls.Add(this.lblUsernameLabel);
            this.pnlKredensial.Controls.Add(this.txtUsername);
            this.pnlKredensial.Controls.Add(this.lblNameLabel);
            this.pnlKredensial.Controls.Add(this.txtName);
            this.pnlKredensial.Controls.Add(this.lblPasswordLabel);
            this.pnlKredensial.Controls.Add(this.txtPassword);
            this.pnlKredensial.Controls.Add(this.lblPasswordDesc);
            this.pnlKredensial.Location = new System.Drawing.Point(325, 275);
            this.pnlKredensial.Name = "pnlKredensial";
            this.pnlKredensial.Size = new System.Drawing.Size(350, 280);
            this.pnlKredensial.TabIndex = 2;

            // lblKredensialTitle
            this.lblKredensialTitle.AutoSize = true;
            this.lblKredensialTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblKredensialTitle.Location = new System.Drawing.Point(15, 15);
            this.lblKredensialTitle.Name = "lblKredensialTitle";
            this.lblKredensialTitle.Size = new System.Drawing.Size(150, 20);
            this.lblKredensialTitle.TabIndex = 0;
            this.lblKredensialTitle.Text = "🔐 Kredensial & Akun";

            // lblKredensialStatus
            this.lblKredensialStatus.AutoSize = true;
            this.lblKredensialStatus.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblKredensialStatus.ForeColor = System.Drawing.Color.FromArgb(0, 140, 110);
            this.lblKredensialStatus.Location = new System.Drawing.Point(220, 15);
            this.lblKredensialStatus.Name = "lblKredensialStatus";
            this.lblKredensialStatus.Size = new System.Drawing.Size(120, 14);
            this.lblKredensialStatus.TabIndex = 1;
            this.lblKredensialStatus.Text = "✓ Aman & Terverifikasi";

            // lblNameLabel
            this.lblNameLabel.AutoSize = true;
            this.lblNameLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblNameLabel.Location = new System.Drawing.Point(15, 45);
            this.lblNameLabel.Name = "lblNameLabel";
            this.lblNameLabel.Size = new System.Drawing.Size(40, 16);
            this.lblNameLabel.TabIndex = 2;
            this.lblNameLabel.Text = "Nama";

            // txtName
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtName.Location = new System.Drawing.Point(15, 65);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(320, 25);
            this.txtName.TabIndex = 3;
            this.txtName.Text = "Siti Rahma";
            this.txtName.ReadOnly = true;

            // lblUsernameLabel
            this.lblUsernameLabel.AutoSize = true;
            this.lblUsernameLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblUsernameLabel.Location = new System.Drawing.Point(15, 105);
            this.lblUsernameLabel.Name = "lblUsernameLabel";
            this.lblUsernameLabel.Size = new System.Drawing.Size(70, 16);
            this.lblUsernameLabel.TabIndex = 4;
            this.lblUsernameLabel.Text = "Username";

            // txtUsername
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtUsername.Location = new System.Drawing.Point(15, 125);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(320, 25);
            this.txtUsername.TabIndex = 5;
            this.txtUsername.Text = "Siti Rahma";
            this.txtUsername.ReadOnly = true;

            // lblPasswordLabel
            this.lblPasswordLabel.AutoSize = true;
            this.lblPasswordLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblPasswordLabel.Location = new System.Drawing.Point(15, 165);
            this.lblPasswordLabel.Name = "lblPasswordLabel";
            this.lblPasswordLabel.Size = new System.Drawing.Size(70, 16);
            this.lblPasswordLabel.TabIndex = 6;
            this.lblPasswordLabel.Text = "Password";

            // txtPassword
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPassword.Location = new System.Drawing.Point(15, 185);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(320, 25);
            this.txtPassword.TabIndex = 7;
            this.txtPassword.Text = "password123";
            this.txtPassword.ReadOnly = true;
            this.txtPassword.UseSystemPasswordChar = true;

            // lblPasswordDesc
            this.lblPasswordDesc.AutoSize = true;
            this.lblPasswordDesc.Font = new System.Drawing.Font("Segoe UI", 7F);
            this.lblPasswordDesc.ForeColor = System.Drawing.Color.Gray;
            this.lblPasswordDesc.Location = new System.Drawing.Point(15, 215);
            this.lblPasswordDesc.Name = "lblPasswordDesc";
            this.lblPasswordDesc.Size = new System.Drawing.Size(140, 12);
            this.lblPasswordDesc.TabIndex = 8;
            this.lblPasswordDesc.Text = "Terakhir diubah pada 14 Mei 2024.";

            // Kasir_Profil
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 728);
            this.Controls.Add(this.pnlContainer);
            this.Name = "Kasir_Profil";
            this.Text = "Kasir - Profil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Kasir_Profil_Load);
            this.pnlContainer.ResumeLayout(false);
            this.pnlContainer.PerformLayout();
            this.pnlFotoProfil.ResumeLayout(false);
            this.pnlFotoProfil.PerformLayout();
            this.pnlKredensial.ResumeLayout(false);
            this.pnlKredensial.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel pnlContainer;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlFotoProfil;
        private System.Windows.Forms.Label lblFormatFoto;
        private System.Windows.Forms.Label lblFotoText;
        private System.Windows.Forms.Label lblFotoProfilTitle;
        private System.Windows.Forms.Panel pnlKredensial;
        private System.Windows.Forms.Label lblKredensialStatus;
        private System.Windows.Forms.Label lblKredensialTitle;
        private System.Windows.Forms.Label lblUsernameLabel;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblPasswordLabel;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblNameLabel;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblPasswordDesc;
    }
}