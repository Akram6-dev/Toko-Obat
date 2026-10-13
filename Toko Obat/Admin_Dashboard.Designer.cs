namespace Toko_Obat
{
    partial class Admin_Dashboard
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
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.btnAkun = new System.Windows.Forms.Button();
            this.btnProduk = new System.Windows.Forms.Button();
            this.btnProfil = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.pnlSidebar.SuspendLayout();
            this.SuspendLayout();

            // pnlSidebar
            this.pnlSidebar.BackColor = System.Drawing.Color.White;
            this.pnlSidebar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSidebar.Controls.Add(this.btnDashboard);
            this.pnlSidebar.Controls.Add(this.btnAkun);
            this.pnlSidebar.Controls.Add(this.btnProduk);
            this.pnlSidebar.Controls.Add(this.btnProfil);
            this.pnlSidebar.Controls.Add(this.btnLogout);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Location = new System.Drawing.Point(0, 0);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(200, 600);
            this.pnlSidebar.TabIndex = 0;

            // btnDashboard
            this.btnDashboard.BackColor = System.Drawing.Color.White;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnDashboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnDashboard.Location = new System.Drawing.Point(10, 50);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(180, 40);
            this.btnDashboard.TabIndex = 0;
            this.btnDashboard.Text = "📊 Dashboard";
            this.btnDashboard.UseVisualStyleBackColor = false;
            this.btnDashboard.Cursor = System.Windows.Forms.Cursors.Hand;

            // btnAkun
            this.btnAkun.BackColor = System.Drawing.Color.White;
            this.btnAkun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAkun.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnAkun.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnAkun.Location = new System.Drawing.Point(10, 100);
            this.btnAkun.Name = "btnAkun";
            this.btnAkun.Size = new System.Drawing.Size(180, 40);
            this.btnAkun.TabIndex = 1;
            this.btnAkun.Text = "👤 Akun";
            this.btnAkun.UseVisualStyleBackColor = false;
            this.btnAkun.Cursor = System.Windows.Forms.Cursors.Hand;

            // btnProduk
            this.btnProduk.BackColor = System.Drawing.Color.White;
            this.btnProduk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProduk.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnProduk.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnProduk.Location = new System.Drawing.Point(10, 150);
            this.btnProduk.Name = "btnProduk";
            this.btnProduk.Size = new System.Drawing.Size(180, 40);
            this.btnProduk.TabIndex = 2;
            this.btnProduk.Text = "📦 Produk";
            this.btnProduk.UseVisualStyleBackColor = false;
            this.btnProduk.Cursor = System.Windows.Forms.Cursors.Hand;

            // btnProfil
            this.btnProfil.BackColor = System.Drawing.Color.White;
            this.btnProfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfil.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnProfil.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnProfil.Location = new System.Drawing.Point(10, 200);
            this.btnProfil.Name = "btnProfil";
            this.btnProfil.Size = new System.Drawing.Size(180, 40);
            this.btnProfil.TabIndex = 3;
            this.btnProfil.Text = "⚙️ Profil";
            this.btnProfil.UseVisualStyleBackColor = false;
            this.btnProfil.Cursor = System.Windows.Forms.Cursors.Hand;

            // btnLogout
            this.btnLogout.BackColor = System.Drawing.Color.White;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnLogout.ForeColor = System.Drawing.Color.Red;
            this.btnLogout.Location = new System.Drawing.Point(10, 550);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(180, 40);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.Text = "🚪 Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnLogout.FlatAppearance.BorderSize = 1;

            // lblWelcome
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblWelcome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.lblWelcome.Location = new System.Drawing.Point(230, 50);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(350, 32);
            this.lblWelcome.TabIndex = 1;
            this.lblWelcome.Text = "Selamat datang, Admin";

            // lblSubtitle
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblSubtitle.ForeColor = System.Drawing.Color.Gray;
            this.lblSubtitle.Location = new System.Drawing.Point(230, 90);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(400, 20);
            this.lblSubtitle.TabIndex = 2;
            this.lblSubtitle.Text = "Ini adalah halaman Admin Dashboard";

            // Admin_Dashboard
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.lblSubtitle);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.pnlSidebar);
            this.Name = "Admin_Dashboard";
            this.Text = "Admin Dashboard - Toko Obat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Admin_Dashboard_Load);
            this.pnlSidebar.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnAkun;
        private System.Windows.Forms.Button btnProduk;
        private System.Windows.Forms.Button btnProfil;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblSubtitle;
    }
}