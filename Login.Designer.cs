namespace Blood_Bank_Management
{
    partial class Login
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            panel1 = new Panel();
            txtForgot = new LinkLabel();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            btnHideShow = new LinkLabel();
            btnLogin = new Button();
            checkBox = new CheckBox();
            txtPassword = new TextBox();
            label2 = new Label();
            txtUsername = new TextBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            btnExit = new Button();
            guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(components);
            guna2AnimateWindow2 = new Guna.UI2.WinForms.Guna2AnimateWindow(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 128, 128);
            panel1.Controls.Add(txtForgot);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(btnHideShow);
            panel1.Controls.Add(btnLogin);
            panel1.Controls.Add(checkBox);
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtUsername);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(160, 64);
            panel1.Name = "panel1";
            panel1.Size = new Size(540, 698);
            panel1.TabIndex = 0;
            // 
            // txtForgot
            // 
            txtForgot.AutoSize = true;
            txtForgot.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtForgot.LinkColor = Color.White;
            txtForgot.Location = new Point(83, 436);
            txtForgot.Name = "txtForgot";
            txtForgot.Size = new Size(163, 28);
            txtForgot.TabIndex = 11;
            txtForgot.TabStop = true;
            txtForgot.Text = "Forgot Password";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Transparent;
            label5.Location = new Point(291, 568);
            label5.Name = "label5";
            label5.Size = new Size(84, 28);
            label5.TabIndex = 10;
            label5.Text = "Sign Up";
            label5.Click += label5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(190, 659);
            label4.Name = "label4";
            label4.Size = new Size(80, 23);
            label4.TabIndex = 9;
            label4.Text = "Read T/C";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(81, 624);
            label3.Name = "label3";
            label3.Size = new Size(326, 23);
            label3.TabIndex = 8;
            label3.Text = "Accept Our terms and Condition to Login";
            // 
            // btnHideShow
            // 
            btnHideShow.AutoSize = true;
            btnHideShow.LinkColor = Color.White;
            btnHideShow.Location = new Point(330, 374);
            btnHideShow.Name = "btnHideShow";
            btnHideShow.Size = new Size(45, 20);
            btnHideShow.TabIndex = 7;
            btnHideShow.TabStop = true;
            btnHideShow.Text = "Show";
            btnHideShow.LinkClicked += btnHideShow_LinkClicked;
            // 
            // btnLogin
            // 
            btnLogin.Cursor = Cursors.No;
            btnLogin.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.FromArgb(192, 0, 0);
            btnLogin.Location = new Point(190, 513);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(107, 43);
            btnLogin.TabIndex = 6;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // checkBox
            // 
            checkBox.AutoSize = true;
            checkBox.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkBox.Location = new Point(81, 475);
            checkBox.Name = "checkBox";
            checkBox.Size = new Size(138, 32);
            checkBox.TabIndex = 5;
            checkBox.Text = "Accept T/C";
            checkBox.UseVisualStyleBackColor = true;
            checkBox.CheckedChanged += checkBox_CheckedChanged;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = SystemColors.Info;
            txtPassword.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(81, 397);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(294, 36);
            txtPassword.TabIndex = 4;
            txtPassword.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(192, 0, 0);
            label2.Image = (Image)resources.GetObject("label2.Image");
            label2.ImageAlign = ContentAlignment.MiddleLeft;
            label2.Location = new Point(81, 336);
            label2.Name = "label2";
            label2.Size = new Size(165, 43);
            label2.TabIndex = 3;
            label2.Text = "Password";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtUsername
            // 
            txtUsername.BackColor = SystemColors.Info;
            txtUsername.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtUsername.ForeColor = Color.Black;
            txtUsername.Location = new Point(81, 263);
            txtUsername.Multiline = true;
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(294, 37);
            txtUsername.TabIndex = 2;
            txtUsername.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(192, 0, 0);
            label1.Image = (Image)resources.GetObject("label1.Image");
            label1.ImageAlign = ContentAlignment.MiddleLeft;
            label1.Location = new Point(81, 214);
            label1.Name = "label1";
            label1.Size = new Size(165, 46);
            label1.TabIndex = 1;
            label1.Text = "Username";
            label1.TextAlign = ContentAlignment.MiddleRight;
            label1.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Login_btn;
            pictureBox1.Location = new Point(81, 34);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(383, 152);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btnExit
            // 
            btnExit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnExit.BackColor = Color.FromArgb(224, 224, 224);
            btnExit.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.ForeColor = Color.DarkSlateGray;
            btnExit.Location = new Point(884, -1);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(39, 39);
            btnExit.TabIndex = 1;
            btnExit.Text = "X";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(924, 799);
            Controls.Add(btnExit);
            Controls.Add(panel1);
            Name = "Login";
            Text = "Login";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private TextBox txtPassword;
        private Label label2;
        private TextBox txtUsername;
        private Label label1;
        private CheckBox checkBox;
        private Button btnLogin;
        private LinkLabel btnHideShow;
        private Label label4;
        private Label label3;
        private Button btnExit;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow2;
        private Label label5;
        private LinkLabel txtForgot;
    }
}
