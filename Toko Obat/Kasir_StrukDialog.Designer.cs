namespace Toko_Obat
{
    partial class Kasir_StrukDialog
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
            rtbStruk = new RichTextBox();
            panelFooter = new Panel();
            btnCetak = new Button();
            btnTutup = new Button();
            panelHeader.SuspendLayout();
            panelFooter.SuspendLayout();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(15, 157, 138);
            panelHeader.Controls.Add(lblTitle);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(420, 50);
            panelHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.Dock = DockStyle.Fill;
            lblTitle.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(0, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(420, 50);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Struk Pembayaran";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // rtbStruk
            // 
            rtbStruk.BackColor = Color.White;
            rtbStruk.BorderStyle = BorderStyle.None;
            rtbStruk.Dock = DockStyle.Fill;
            rtbStruk.Font = new Font("Consolas", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rtbStruk.Location = new Point(0, 50);
            rtbStruk.Name = "rtbStruk";
            rtbStruk.ReadOnly = true;
            rtbStruk.ScrollBars = RichTextBoxScrollBars.Vertical;
            rtbStruk.Size = new Size(420, 460);
            rtbStruk.TabIndex = 1;
            rtbStruk.Text = "";
            // 
            // panelFooter
            // 
            panelFooter.BackColor = Color.FromArgb(240, 240, 240);
            panelFooter.Controls.Add(btnCetak);
            panelFooter.Controls.Add(btnTutup);
            panelFooter.Dock = DockStyle.Bottom;
            panelFooter.Location = new Point(0, 510);
            panelFooter.Name = "panelFooter";
            panelFooter.Size = new Size(420, 60);
            panelFooter.TabIndex = 2;
            // 
            // btnCetak
            // 
            btnCetak.BackColor = Color.FromArgb(15, 157, 138);
            btnCetak.FlatStyle = FlatStyle.Flat;
            btnCetak.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnCetak.ForeColor = Color.White;
            btnCetak.Location = new Point(230, 10);
            btnCetak.Name = "btnCetak";
            btnCetak.Size = new Size(160, 40);
            btnCetak.TabIndex = 0;
            btnCetak.Text = "Print / Simpan";
            btnCetak.UseVisualStyleBackColor = false;
            btnCetak.Click += btnCetak_Click;
            // 
            // btnTutup
            // 
            btnTutup.BackColor = Color.White;
            btnTutup.FlatStyle = FlatStyle.Flat;
            btnTutup.Font = new Font("Segoe UI", 9.5F);
            btnTutup.ForeColor = Color.DimGray;
            btnTutup.Location = new Point(30, 10);
            btnTutup.Name = "btnTutup";
            btnTutup.Size = new Size(120, 40);
            btnTutup.TabIndex = 1;
            btnTutup.Text = "Tutup";
            btnTutup.UseVisualStyleBackColor = false;
            btnTutup.Click += btnTutup_Click;
            // 
            // Kasir_StrukDialog
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(420, 570);
            Controls.Add(rtbStruk);
            Controls.Add(panelFooter);
            Controls.Add(panelHeader);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Kasir_StrukDialog";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Struk Belanja";
            panelHeader.ResumeLayout(false);
            panelFooter.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHeader;
        private Label lblTitle;
        private RichTextBox rtbStruk;
        private Panel panelFooter;
        private Button btnCetak;
        private Button btnTutup;
    }
}
