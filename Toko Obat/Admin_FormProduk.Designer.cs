namespace Toko_Obat
{
    partial class Admin_FormProduk
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            pictureBox1 = new PictureBox();
            btnFoto = new Button();
            Nama = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btnSimpan = new Button();
            btnBatal = new Button();
            txtNama = new TextBox();
            txtStok = new TextBox();
            txtHarga = new TextBox();
            cmbCategory = new ComboBox();
            dtpKadaluarsa = new DateTimePicker();
            rtbDeskripsi = new RichTextBox();
            label6 = new Label();
            label7 = new Label();
            cmbJenis = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(163, 32);
            label1.TabIndex = 0;
            label1.Text = "Form Produk";
            label1.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(12, 56);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(120, 120);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // btnFoto
            // 
            btnFoto.Location = new Point(148, 144);
            btnFoto.Name = "btnFoto";
            btnFoto.Size = new Size(122, 32);
            btnFoto.TabIndex = 2;
            btnFoto.Text = "pilih foto";
            btnFoto.UseVisualStyleBackColor = true;
            btnFoto.Click += btnFoto_Click;
            // 
            // Nama
            // 
            Nama.AutoSize = true;
            Nama.Location = new Point(12, 197);
            Nama.Name = "Nama";
            Nama.Size = new Size(59, 25);
            Nama.TabIndex = 3;
            Nama.Text = "Nama";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(234, 197);
            label2.Name = "label2";
            label2.Size = new Size(84, 25);
            label2.TabIndex = 4;
            label2.Text = "Category";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(272, 274);
            label3.Name = "label3";
            label3.Size = new Size(60, 25);
            label3.TabIndex = 5;
            label3.Text = "Harga";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 274);
            label4.Name = "label4";
            label4.Size = new Size(47, 25);
            label4.TabIndex = 6;
            label4.Text = "Stok";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 470);
            label5.Name = "label5";
            label5.Size = new Size(163, 25);
            label5.TabIndex = 7;
            label5.Text = "Tanggal Kadaluarsa";
            label5.Click += label5_Click;
            // 
            // btnSimpan
            // 
            btnSimpan.BackColor = Color.FromArgb(0, 104, 91);
            btnSimpan.FlatStyle = FlatStyle.Flat;
            btnSimpan.ForeColor = Color.White;
            btnSimpan.Location = new Point(316, 560);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(100, 32);
            btnSimpan.TabIndex = 8;
            btnSimpan.Text = "Simpan";
            btnSimpan.UseVisualStyleBackColor = false;
            btnSimpan.Click += btnSimpan_Click;
            // 
            // btnBatal
            // 
            btnBatal.Location = new Point(234, 560);
            btnBatal.Name = "btnBatal";
            btnBatal.Size = new Size(67, 32);
            btnBatal.TabIndex = 9;
            btnBatal.Text = "Batal";
            btnBatal.UseVisualStyleBackColor = true;
            btnBatal.Click += btnBatal_Click;
            // 
            // txtNama
            // 
            txtNama.Location = new Point(12, 225);
            txtNama.Name = "txtNama";
            txtNama.Size = new Size(184, 31);
            txtNama.TabIndex = 10;
            txtNama.TextChanged += txtNama_TextChanged;
            // 
            // txtStok
            // 
            txtStok.Location = new Point(12, 302);
            txtStok.Name = "txtStok";
            txtStok.Size = new Size(97, 31);
            txtStok.TabIndex = 11;
            txtStok.TextChanged += txtStok_TextChanged;
            // 
            // txtHarga
            // 
            txtHarga.Location = new Point(272, 302);
            txtHarga.Name = "txtHarga";
            txtHarga.Size = new Size(144, 31);
            txtHarga.TabIndex = 12;
            txtHarga.TextChanged += txtHarga_TextChanged;
            // 
            // cmbCategory
            // 
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(234, 225);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(182, 33);
            cmbCategory.TabIndex = 13;
            cmbCategory.SelectedIndexChanged += cmbCategory_SelectedIndexChanged;
            // 
            // dtpKadaluarsa
            // 
            dtpKadaluarsa.Location = new Point(12, 498);
            dtpKadaluarsa.Name = "dtpKadaluarsa";
            dtpKadaluarsa.Size = new Size(404, 31);
            dtpKadaluarsa.TabIndex = 14;
            // 
            // rtbDeskripsi
            // 
            rtbDeskripsi.Location = new Point(12, 374);
            rtbDeskripsi.Name = "rtbDeskripsi";
            rtbDeskripsi.Size = new Size(391, 76);
            rtbDeskripsi.TabIndex = 15;
            rtbDeskripsi.Text = "";
            rtbDeskripsi.TextChanged += rtbDeskripsi_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 346);
            label6.Name = "label6";
            label6.Size = new Size(84, 25);
            label6.TabIndex = 16;
            label6.Text = "Deskripsi";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(126, 274);
            label7.Name = "label7";
            label7.Size = new Size(49, 25);
            label7.TabIndex = 17;
            label7.Text = "Jenis";
            label7.Click += label7_Click;
            // 
            // cmbJenis
            // 
            cmbJenis.FormattingEnabled = true;
            cmbJenis.Location = new Point(126, 302);
            cmbJenis.Name = "cmbJenis";
            cmbJenis.Size = new Size(112, 33);
            cmbJenis.TabIndex = 18;
            cmbJenis.SelectedIndexChanged += cmbJenis_SelectedIndexChanged;
            // 
            // Admin_FormProduk
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(428, 609);
            Controls.Add(cmbJenis);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(rtbDeskripsi);
            Controls.Add(dtpKadaluarsa);
            Controls.Add(cmbCategory);
            Controls.Add(txtHarga);
            Controls.Add(txtStok);
            Controls.Add(txtNama);
            Controls.Add(btnBatal);
            Controls.Add(btnSimpan);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(Nama);
            Controls.Add(btnFoto);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Admin_FormProduk";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin_FormProduk";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnFoto;
        private Label Nama;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btnSimpan;
        private Button btnBatal;
        public PictureBox pictureBox1;
        public TextBox txtNama;
        public TextBox txtStok;
        public TextBox txtHarga;
        public ComboBox cmbCategory;
        public DateTimePicker dtpKadaluarsa;
        private Label label6;
        private Label label7;
        public ComboBox cmbJenis;
        public RichTextBox rtbDeskripsi;
    }
}