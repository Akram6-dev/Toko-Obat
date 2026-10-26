namespace Toko_Obat
{
    partial class Admin_FormAkun
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
            label4 = new Label();
            btnSimpan = new Button();
            btnBatal = new Button();
            txtNama = new TextBox();
            cmbRole = new ComboBox();
            textPass = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(140, 32);
            label1.TabIndex = 0;
            label1.Text = "Form Akun";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(12, 56);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(120, 120);
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
            label2.Location = new Point(12, 352);
            label2.Name = "label2";
            label2.Size = new Size(46, 25);
            label2.TabIndex = 4;
            label2.Text = "Role";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 274);
            label4.Name = "label4";
            label4.Size = new Size(87, 25);
            label4.TabIndex = 6;
            label4.Text = "Password";
            // 
            // btnSimpan
            // 
            btnSimpan.BackColor = Color.FromArgb(0, 104, 91);
            btnSimpan.FlatStyle = FlatStyle.Flat;
            btnSimpan.ForeColor = Color.White;
            btnSimpan.Location = new Point(316, 452);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(100, 32);
            btnSimpan.TabIndex = 8;
            btnSimpan.Text = "Simpan";
            btnSimpan.UseVisualStyleBackColor = false;
            btnSimpan.Click += btnSimpan_Click;
            // 
            // btnBatal
            // 
            btnBatal.Location = new Point(234, 452);
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
            txtNama.Size = new Size(387, 31);
            txtNama.TabIndex = 10;
            txtNama.TextChanged += txtNama_TextChanged;
            // 
            // cmbRole
            // 
            cmbRole.FormattingEnabled = true;
            cmbRole.Location = new Point(12, 380);
            cmbRole.Name = "cmbRole";
            cmbRole.Size = new Size(209, 33);
            cmbRole.TabIndex = 13;
            cmbRole.SelectedIndexChanged += cmbRole_SelectedIndexChanged;
            // 
            // textPass
            // 
            textPass.Location = new Point(12, 302);
            textPass.Name = "textPass";
            textPass.Size = new Size(387, 31);
            textPass.TabIndex = 15;
            textPass.TextChanged += textPass_TextChanged;
            // 
            // Admin_FormAkun
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(428, 501);
            Controls.Add(textPass);
            Controls.Add(cmbRole);
            Controls.Add(txtNama);
            Controls.Add(btnBatal);
            Controls.Add(btnSimpan);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(Nama);
            Controls.Add(btnFoto);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Admin_FormAkun";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin_FormAkun";
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
        public ComboBox cmbRole;
        public DateTimePicker dtpKadaluarsa;
        public TextBox textPass;
    }
}