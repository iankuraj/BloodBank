namespace Blood_Bank_Management
{
    partial class Sign_Up
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sign_Up));
            label1 = new Label();
            label2 = new Label();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtAddress = new TextBox();
            label6 = new Label();
            txtUsername = new TextBox();
            label7 = new Label();
            txtPassword = new TextBox();
            label8 = new Label();
            txtComformPassword = new TextBox();
            label9 = new Label();
            txtDate = new DateTimePicker();
            txtGender = new ComboBox();
            checkPass = new CheckBox();
            txtbtn = new Button();
            linkLabel1 = new LinkLabel();
            btnDelete = new Button();
            label10 = new Label();
            txtID = new TextBox();
            btnSearch = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(212, 9);
            label1.Name = "label1";
            label1.Size = new Size(155, 46);
            label1.TabIndex = 0;
            label1.Text = "SIGN UP";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(51, 121);
            label2.Name = "label2";
            label2.Size = new Size(104, 28);
            label2.TabIndex = 1;
            label2.Text = "FirstName";
            // 
            // txtFirstName
            // 
            txtFirstName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFirstName.Location = new Point(51, 166);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(206, 34);
            txtFirstName.TabIndex = 2;
            // 
            // txtLastName
            // 
            txtLastName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLastName.Location = new Point(51, 263);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(206, 34);
            txtLastName.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(51, 218);
            label3.Name = "label3";
            label3.Size = new Size(102, 28);
            label3.TabIndex = 3;
            label3.Text = "LastName";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(51, 310);
            label4.Name = "label4";
            label4.Size = new Size(129, 28);
            label4.TabIndex = 5;
            label4.Text = "Date of Birth";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(51, 406);
            label5.Name = "label5";
            label5.Size = new Size(79, 28);
            label5.TabIndex = 7;
            label5.Text = "Gender";
            // 
            // txtAddress
            // 
            txtAddress.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAddress.Location = new Point(377, 166);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(206, 34);
            txtAddress.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(377, 121);
            label6.Name = "label6";
            label6.Size = new Size(85, 28);
            label6.TabIndex = 9;
            label6.Text = "Address";
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsername.Location = new Point(377, 263);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(206, 34);
            txtUsername.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(377, 218);
            label7.Name = "label7";
            label7.Size = new Size(104, 28);
            label7.TabIndex = 11;
            label7.Text = "Username";
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(377, 355);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(206, 34);
            txtPassword.TabIndex = 14;
            txtPassword.UseSystemPasswordChar = true;
            txtPassword.TextChanged += txtPassword_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.White;
            label8.Location = new Point(377, 310);
            label8.Name = "label8";
            label8.Size = new Size(97, 28);
            label8.TabIndex = 13;
            label8.Text = "Password";
            // 
            // txtComformPassword
            // 
            txtComformPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtComformPassword.Location = new Point(377, 451);
            txtComformPassword.Name = "txtComformPassword";
            txtComformPassword.Size = new Size(206, 34);
            txtComformPassword.TabIndex = 16;
            txtComformPassword.UseSystemPasswordChar = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.White;
            label9.Location = new Point(377, 406);
            label9.Name = "label9";
            label9.Size = new Size(189, 28);
            label9.TabIndex = 15;
            label9.Text = "Comform Password";
            // 
            // txtDate
            // 
            txtDate.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDate.Format = DateTimePickerFormat.Custom;
            txtDate.Location = new Point(51, 352);
            txtDate.Name = "txtDate";
            txtDate.Size = new Size(206, 31);
            txtDate.TabIndex = 17;
            txtDate.ValueChanged += txtDate_ValueChanged;
            // 
            // txtGender
            // 
            txtGender.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtGender.FormattingEnabled = true;
            txtGender.Items.AddRange(new object[] { "Male", "Female" });
            txtGender.Location = new Point(51, 451);
            txtGender.Name = "txtGender";
            txtGender.Size = new Size(206, 33);
            txtGender.TabIndex = 18;
            // 
            // checkPass
            // 
            checkPass.AutoSize = true;
            checkPass.BackColor = Color.Transparent;
            checkPass.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkPass.ForeColor = Color.White;
            checkPass.Location = new Point(377, 491);
            checkPass.Name = "checkPass";
            checkPass.Size = new Size(144, 27);
            checkPass.TabIndex = 19;
            checkPass.Text = "Remember me";
            checkPass.UseVisualStyleBackColor = false;
            checkPass.CheckedChanged += checkPass_CheckedChanged;
            // 
            // txtbtn
            // 
            txtbtn.BackColor = Color.DodgerBlue;
            txtbtn.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            txtbtn.ForeColor = Color.White;
            txtbtn.Location = new Point(195, 542);
            txtbtn.Name = "txtbtn";
            txtbtn.Size = new Size(172, 61);
            txtbtn.TabIndex = 20;
            txtbtn.Text = "Sign Up";
            txtbtn.UseVisualStyleBackColor = false;
            txtbtn.Click += button1_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.BackColor = Color.Transparent;
            linkLabel1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            linkLabel1.LinkColor = Color.DeepSkyBlue;
            linkLabel1.Location = new Point(90, 558);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(63, 28);
            linkLabel1.TabIndex = 21;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Login";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = Color.Red;
            btnDelete.Location = new Point(413, 551);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(81, 43);
            btnDelete.TabIndex = 22;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.White;
            label10.Location = new Point(136, 93);
            label10.Name = "label10";
            label10.Size = new Size(32, 28);
            label10.TabIndex = 23;
            label10.Text = "ID";
            // 
            // txtID
            // 
            txtID.Location = new Point(177, 97);
            txtID.Name = "txtID";
            txtID.Size = new Size(80, 27);
            txtID.TabIndex = 24;
            txtID.TextChanged += textBox1_TextChanged;
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.Image = (Image)resources.GetObject("btnSearch.Image");
            btnSearch.ImageAlign = ContentAlignment.MiddleLeft;
            btnSearch.Location = new Point(277, 86);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(114, 42);
            btnSearch.TabIndex = 25;
            btnSearch.Text = "search";
            btnSearch.TextAlign = ContentAlignment.MiddleRight;
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // Sign_Up
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(730, 635);
            Controls.Add(btnSearch);
            Controls.Add(txtID);
            Controls.Add(label10);
            Controls.Add(btnDelete);
            Controls.Add(linkLabel1);
            Controls.Add(txtbtn);
            Controls.Add(checkPass);
            Controls.Add(txtGender);
            Controls.Add(txtDate);
            Controls.Add(txtComformPassword);
            Controls.Add(label9);
            Controls.Add(txtPassword);
            Controls.Add(label8);
            Controls.Add(txtUsername);
            Controls.Add(label7);
            Controls.Add(txtAddress);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtLastName);
            Controls.Add(label3);
            Controls.Add(txtFirstName);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Sign_Up";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sign_Up";
            Load += Sign_Up_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtAddress;
        private Label label6;
        private TextBox txtUsername;
        private Label label7;
        private TextBox txtPassword;
        private Label label8;
        private TextBox txtComformPassword;
        private Label label9;
        private DateTimePicker txtDate;
        private ComboBox txtGender;
        private CheckBox checkPass;
        private Button txtbtn;
        private LinkLabel linkLabel1;
        private Button btnDelete;
        private Label label10;
        private TextBox txtID;
        private Button btnSearch;
    }
}