namespace Toko_Obat
{
    partial class Halaman_Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            outerGrid = new TableLayoutPanel();
            panel1 = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            Username = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            LBL_Password = new Label();
            linkLabel1 = new LinkLabel();
            label4 = new Label();
            button1 = new Button();
            lblError = new Label();
            panel2 = new Panel();
            label5 = new Label();
            label3 = new Label();
            panel3 = new Panel();
            linkLabel2 = new LinkLabel();
            label6 = new Label();
            outerGrid.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tableLayoutPanel3.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // outerGrid
            // 
            outerGrid.ColumnCount = 3;
            outerGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 27.6785717F));
            outerGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 44.6428566F));
            outerGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 27.6785717F));
            outerGrid.Controls.Add(panel1, 1, 1);
            outerGrid.Dock = DockStyle.Fill;
            outerGrid.Location = new Point(0, 0);
            outerGrid.Name = "outerGrid";
            outerGrid.RowCount = 3;
            outerGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            outerGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 70F));
            outerGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            outerGrid.Size = new Size(903, 673);
            outerGrid.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(tableLayoutPanel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(252, 103);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(30, 25, 30, 25);
            panel1.Size = new Size(397, 465);
            panel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(pictureBox1, 0, 0);
            tableLayoutPanel2.Controls.Add(label1, 0, 1);
            tableLayoutPanel2.Controls.Add(label2, 0, 2);
            tableLayoutPanel2.Controls.Add(Username, 0, 3);
            tableLayoutPanel2.Controls.Add(txtUsername, 0, 4);
            tableLayoutPanel2.Controls.Add(txtPassword, 0, 6);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 0, 5);
            tableLayoutPanel2.Controls.Add(label4, 0, 7);
            tableLayoutPanel2.Controls.Add(button1, 0, 8);
            tableLayoutPanel2.Controls.Add(lblError, 0, 9);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(30, 25);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 10;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 16F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 12F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 7F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 11F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 7F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 11F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 8F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 12F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 6F));
            tableLayoutPanel2.Size = new Size(337, 415);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.BackColor = Color.FromArgb(235, 252, 237);
            pictureBox1.Image = Properties.Resources.Group_6;
            pictureBox1.Location = new Point(143, 10);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(50, 45);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label1.Location = new Point(104, 66);
            label1.Name = "label1";
            label1.Size = new Size(129, 41);
            label1.TabIndex = 1;
            label1.Text = "LOGIN";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.ForeColor = Color.DimGray;
            label2.Location = new Point(3, 107);
            label2.Name = "label2";
            label2.Size = new Size(331, 49);
            label2.TabIndex = 2;
            label2.Text = "Silakan masukkan kredensial akun Anda untuk mengakses sistem toko obat";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Username
            // 
            Username.AutoSize = true;
            Username.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Username.Location = new Point(3, 156);
            Username.Name = "Username";
            Username.Size = new Size(97, 25);
            Username.TabIndex = 3;
            Username.Text = "Username";
            // 
            // txtUsername
            // 
            txtUsername.Dock = DockStyle.Fill;
            txtUsername.Font = new Font("Segoe UI", 12F);
            txtUsername.Location = new Point(3, 188);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(331, 39);
            txtUsername.TabIndex = 4;
            // 
            // txtPassword
            // 
            txtPassword.Dock = DockStyle.Fill;
            txtPassword.Font = new Font("Segoe UI", 12F);
            txtPassword.Location = new Point(3, 262);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(331, 39);
            txtPassword.TabIndex = 5;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.AutoSize = true;
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(LBL_Password, 0, 0);
            tableLayoutPanel3.Controls.Add(linkLabel1, 1, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 233);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.Size = new Size(331, 23);
            tableLayoutPanel3.TabIndex = 6;
            // 
            // LBL_Password
            // 
            LBL_Password.Anchor = AnchorStyles.Left;
            LBL_Password.AutoSize = true;
            LBL_Password.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LBL_Password.Location = new Point(3, 0);
            LBL_Password.Name = "LBL_Password";
            LBL_Password.Size = new Size(92, 25);
            LBL_Password.TabIndex = 0;
            LBL_Password.Text = "Password";
            // 
            // linkLabel1
            // 
            linkLabel1.Anchor = AnchorStyles.Right;
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(190, 0);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(138, 25);
            linkLabel1.TabIndex = 1;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Lupa Password?";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 8.5F);
            label4.ForeColor = Color.Gray;
            label4.Location = new Point(28, 304);
            label4.Name = "label4";
            label4.Size = new Size(306, 23);
            label4.TabIndex = 7;
            label4.Text = "⏱ Sesi login Anda aktif selama 12 jam";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(132, 179, 114);
            button1.Dock = DockStyle.Fill;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(3, 340);
            button1.Name = "button1";
            button1.Size = new Size(331, 43);
            button1.TabIndex = 8;
            button1.Text = "Masuk ke Aplikasi";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.Dock = DockStyle.Fill;
            lblError.Location = new Point(3, 386);
            lblError.Name = "lblError";
            lblError.Size = new Size(331, 29);
            lblError.TabIndex = 9;
            lblError.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label3);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(903, 53);
            panel2.TabIndex = 1;
            // 
            // label5
            // 
            label5.Dock = DockStyle.Right;
            label5.ForeColor = Color.Gray;
            label5.Location = new Point(775, 0);
            label5.Name = "label5";
            label5.Size = new Size(128, 53);
            label5.TabIndex = 1;
            label5.Text = "Bantuan Teknis";
            label5.TextAlign = ContentAlignment.MiddleRight;
            label5.Click += label5_Click;
            // 
            // label3
            // 
            label3.Dock = DockStyle.Left;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(181, 53);
            label3.TabIndex = 0;
            label3.Text = "CINTA SEHAT";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            label3.Click += label3_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(linkLabel2);
            panel3.Controls.Add(label6);
            panel3.Dock = DockStyle.Bottom;
            panel3.ImeMode = ImeMode.Katakana;
            panel3.Location = new Point(0, 626);
            panel3.Name = "panel3";
            panel3.Size = new Size(903, 47);
            panel3.TabIndex = 2;
            // 
            // linkLabel2
            // 
            linkLabel2.Dock = DockStyle.Right;
            linkLabel2.Font = new Font("Segoe UI", 7F);
            linkLabel2.ForeColor = Color.Gray;
            linkLabel2.Location = new Point(768, 0);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(135, 47);
            linkLabel2.TabIndex = 1;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Kebijakan Privasi ";
            linkLabel2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            label6.Dock = DockStyle.Left;
            label6.Font = new Font("Segoe UI", 8F);
            label6.ForeColor = Color.Gray;
            label6.Location = new Point(0, 0);
            label6.Name = "label6";
            label6.Size = new Size(420, 47);
            label6.TabIndex = 0;
            label6.Text = "© 2026 CINTA SEHAT. Hak Cipta Dilindungi.";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Halaman_Login
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(903, 673);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(outerGrid);
            Name = "Halaman_Login";
            Text = "Halaman Login";
            outerGrid.ResumeLayout(false);
            panel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel outerGrid;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel2;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label Username;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private TableLayoutPanel tableLayoutPanel3;
        private Label LBL_Password;
        private LinkLabel linkLabel1;
        private Label label4;
        private Button button1;
        private Label lblError;
        private Panel panel2;
        private Label label3;
        private Label label5;
        private Panel panel3;
        private LinkLabel linkLabel2;
        private Label label6;
    }
}
