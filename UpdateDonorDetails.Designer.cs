namespace Blood_Bank_Management
{
    partial class UpdateDonorDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateDonorDetails));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtDonorID = new TextBox();
            btnSearch = new Button();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            txtName = new TextBox();
            txtFather = new TextBox();
            txtMother = new TextBox();
            txtEmail = new TextBox();
            txtCity = new TextBox();
            txtDOB = new DateTimePicker();
            txtBloodGroup = new ComboBox();
            txtAddress = new RichTextBox();
            btnUpdate = new Button();
            btnReset = new Button();
            btnClose = new Button();
            txtGender = new ComboBox();
            txtMobile = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(265, 20);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(113, 9);
            label2.Name = "label2";
            label2.Size = new Size(433, 46);
            label2.TabIndex = 1;
            label2.Text = "UPDATE DONOR DETAILS";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(132, 73);
            label3.Name = "label3";
            label3.Size = new Size(80, 23);
            label3.TabIndex = 2;
            label3.Text = "Donor ID";
            label3.Click += label3_Click;
            // 
            // txtDonorID
            // 
            txtDonorID.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDonorID.Location = new Point(218, 73);
            txtDonorID.Multiline = true;
            txtDonorID.Name = "txtDonorID";
            txtDonorID.Size = new Size(134, 26);
            txtDonorID.TabIndex = 3;
            txtDonorID.TextChanged += txtDonorID_TextChanged;
            // 
            // btnSearch
            // 
            btnSearch.FlatStyle = FlatStyle.Popup;
            btnSearch.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.Image = (Image)resources.GetObject("btnSearch.Image");
            btnSearch.ImageAlign = ContentAlignment.MiddleLeft;
            btnSearch.Location = new Point(358, 73);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(102, 29);
            btnSearch.TabIndex = 4;
            btnSearch.Text = "Search";
            btnSearch.TextAlign = ContentAlignment.MiddleRight;
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(32, 132);
            label4.Name = "label4";
            label4.Size = new Size(56, 23);
            label4.TabIndex = 5;
            label4.Text = "Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(32, 189);
            label5.Name = "label5";
            label5.Size = new Size(109, 23);
            label5.TabIndex = 6;
            label5.Text = "Father Name";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(32, 234);
            label6.Name = "label6";
            label6.Size = new Size(118, 23);
            label6.TabIndex = 7;
            label6.Text = "Mother Name";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(32, 280);
            label7.Name = "label7";
            label7.Size = new Size(108, 23);
            label7.TabIndex = 8;
            label7.Text = "Date of Birth";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(32, 337);
            label8.Name = "label8";
            label8.Size = new Size(91, 23);
            label8.TabIndex = 9;
            label8.Text = "Mobile No";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(32, 402);
            label9.Name = "label9";
            label9.Size = new Size(66, 23);
            label9.TabIndex = 10;
            label9.Text = "Gender";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(377, 137);
            label10.Name = "label10";
            label10.Size = new Size(51, 23);
            label10.TabIndex = 11;
            label10.Text = "Email";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(377, 184);
            label11.Name = "label11";
            label11.Size = new Size(107, 23);
            label11.TabIndex = 12;
            label11.Text = "Blood Group";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(377, 231);
            label12.Name = "label12";
            label12.Size = new Size(40, 23);
            label12.TabIndex = 13;
            label12.Text = "City";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.Transparent;
            label13.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(377, 280);
            label13.Name = "label13";
            label13.Size = new Size(70, 23);
            label13.TabIndex = 14;
            label13.Text = "Address";
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtName.Location = new Point(165, 129);
            txtName.Name = "txtName";
            txtName.Size = new Size(184, 30);
            txtName.TabIndex = 15;
            // 
            // txtFather
            // 
            txtFather.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFather.Location = new Point(165, 185);
            txtFather.Name = "txtFather";
            txtFather.Size = new Size(184, 30);
            txtFather.TabIndex = 16;
            // 
            // txtMother
            // 
            txtMother.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMother.Location = new Point(165, 234);
            txtMother.Name = "txtMother";
            txtMother.Size = new Size(184, 30);
            txtMother.TabIndex = 17;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(492, 132);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(184, 30);
            txtEmail.TabIndex = 21;
            // 
            // txtCity
            // 
            txtCity.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCity.Location = new Point(492, 231);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(184, 30);
            txtCity.TabIndex = 22;
            txtCity.TextChanged += textBox9_TextChanged;
            // 
            // txtDOB
            // 
            txtDOB.Format = DateTimePickerFormat.Short;
            txtDOB.Location = new Point(165, 280);
            txtDOB.Name = "txtDOB";
            txtDOB.Size = new Size(184, 27);
            txtDOB.TabIndex = 23;
            // 
            // txtBloodGroup
            // 
            txtBloodGroup.DropDownStyle = ComboBoxStyle.DropDownList;
            txtBloodGroup.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBloodGroup.FormattingEnabled = true;
            txtBloodGroup.Items.AddRange(new object[] { "A+", "B+", "AB+", "O+", "O-", "AB-", "A-", "B-" });
            txtBloodGroup.Location = new Point(492, 181);
            txtBloodGroup.Name = "txtBloodGroup";
            txtBloodGroup.Size = new Size(184, 31);
            txtBloodGroup.TabIndex = 25;
            // 
            // txtAddress
            // 
            txtAddress.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAddress.Location = new Point(492, 277);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(182, 139);
            txtAddress.TabIndex = 26;
            txtAddress.Text = "";
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.Location = new Point(96, 448);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 27;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnReset
            // 
            btnReset.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReset.Location = new Point(255, 448);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(94, 29);
            btnReset.TabIndex = 28;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // btnClose
            // 
            btnClose.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.Location = new Point(419, 448);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 29);
            btnClose.TabIndex = 29;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // txtGender
            // 
            txtGender.DropDownStyle = ComboBoxStyle.DropDownList;
            txtGender.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtGender.FormattingEnabled = true;
            txtGender.Items.AddRange(new object[] { "Male", "Female", "Other" });
            txtGender.Location = new Point(165, 397);
            txtGender.Name = "txtGender";
            txtGender.Size = new Size(184, 31);
            txtGender.TabIndex = 30;
            // 
            // txtMobile
            // 
            txtMobile.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMobile.Location = new Point(165, 337);
            txtMobile.Name = "txtMobile";
            txtMobile.Size = new Size(184, 30);
            txtMobile.TabIndex = 31;
            // 
            // UpdateDonorDetails
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(725, 519);
            Controls.Add(txtMobile);
            Controls.Add(txtGender);
            Controls.Add(btnClose);
            Controls.Add(btnReset);
            Controls.Add(btnUpdate);
            Controls.Add(txtAddress);
            Controls.Add(txtBloodGroup);
            Controls.Add(txtDOB);
            Controls.Add(txtCity);
            Controls.Add(txtEmail);
            Controls.Add(txtMother);
            Controls.Add(txtFather);
            Controls.Add(txtName);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(btnSearch);
            Controls.Add(txtDonorID);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UpdateDonorDetails";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UpdateDonorDetails";
            Load += UpdateDonorDetails_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtDonorID;
        private Button btnSearch;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private TextBox txtName;
        private TextBox txtFather;
        private TextBox txtMother;
        private TextBox txtEmail;
        private TextBox txtCity;
        private DateTimePicker txtDOB;
        private ComboBox txtBloodGroup;
        private RichTextBox txtAddress;
        private Button btnUpdate;
        private Button btnReset;
        private Button btnClose;
        private ComboBox txtGender;
        private TextBox txtMobile;
    }
}