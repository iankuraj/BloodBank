namespace Blood_Bank_Management
{
    partial class DeleteDonor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteDonor));
            label1 = new Label();
            label2 = new Label();
            txtDonorID = new TextBox();
            btnSearch = new Button();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            txtName = new TextBox();
            txtFather = new TextBox();
            txtMother = new TextBox();
            txtMobile = new TextBox();
            txtEmail = new TextBox();
            txtCity = new TextBox();
            txtAddress = new RichTextBox();
            txtGender = new TextBox();
            txtBloodGroup = new TextBox();
            txtDob = new TextBox();
            btnDelete = new Button();
            btnReset = new Button();
            btnClose = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(199, 9);
            label1.Name = "label1";
            label1.Size = new Size(273, 46);
            label1.TabIndex = 0;
            label1.Text = "DELETE DONOR";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(62, 66);
            label2.Name = "label2";
            label2.Size = new Size(106, 28);
            label2.TabIndex = 1;
            label2.Text = "Donor ID :";
            // 
            // txtDonorID
            // 
            txtDonorID.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDonorID.Location = new Point(184, 66);
            txtDonorID.Name = "txtDonorID";
            txtDonorID.Size = new Size(154, 34);
            txtDonorID.TabIndex = 2;
            txtDonorID.TextChanged += txtDonorID_TextChanged;
            // 
            // btnSearch
            // 
            btnSearch.FlatStyle = FlatStyle.Popup;
            btnSearch.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.Image = (Image)resources.GetObject("btnSearch.Image");
            btnSearch.ImageAlign = ContentAlignment.MiddleLeft;
            btnSearch.Location = new Point(390, 61);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(112, 39);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "Search";
            btnSearch.TextAlign = ContentAlignment.MiddleRight;
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 127);
            label3.Name = "label3";
            label3.Size = new Size(66, 28);
            label3.TabIndex = 4;
            label3.Text = "Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 170);
            label4.Name = "label4";
            label4.Size = new Size(128, 28);
            label4.TabIndex = 5;
            label4.Text = "Father Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(12, 220);
            label5.Name = "label5";
            label5.Size = new Size(139, 28);
            label5.TabIndex = 6;
            label5.Text = "Mother Name";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(12, 267);
            label6.Name = "label6";
            label6.Size = new Size(129, 28);
            label6.TabIndex = 7;
            label6.Text = "Date of Birth";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(12, 324);
            label7.Name = "label7";
            label7.Size = new Size(108, 28);
            label7.TabIndex = 8;
            label7.Text = "Mobile No";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(12, 373);
            label8.Name = "label8";
            label8.Size = new Size(85, 28);
            label8.TabIndex = 9;
            label8.Text = "Gender ";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(363, 123);
            label9.Name = "label9";
            label9.Size = new Size(60, 28);
            label9.TabIndex = 10;
            label9.Text = "Email";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(363, 170);
            label10.Name = "label10";
            label10.Size = new Size(128, 28);
            label10.TabIndex = 11;
            label10.Text = "Blood Group";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(363, 216);
            label11.Name = "label11";
            label11.Size = new Size(46, 28);
            label11.TabIndex = 12;
            label11.Text = "City";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(363, 267);
            label12.Name = "label12";
            label12.Size = new Size(85, 28);
            label12.TabIndex = 13;
            label12.Text = "Address";
            // 
            // txtName
            // 
            txtName.Location = new Point(158, 131);
            txtName.Name = "txtName";
            txtName.ReadOnly = true;
            txtName.Size = new Size(199, 27);
            txtName.TabIndex = 14;
            // 
            // txtFather
            // 
            txtFather.Location = new Point(158, 174);
            txtFather.Name = "txtFather";
            txtFather.Size = new Size(199, 27);
            txtFather.TabIndex = 15;
            // 
            // txtMother
            // 
            txtMother.Location = new Point(158, 221);
            txtMother.Name = "txtMother";
            txtMother.ReadOnly = true;
            txtMother.Size = new Size(199, 27);
            txtMother.TabIndex = 16;
            // 
            // txtMobile
            // 
            txtMobile.Location = new Point(158, 324);
            txtMobile.Name = "txtMobile";
            txtMobile.ReadOnly = true;
            txtMobile.Size = new Size(199, 27);
            txtMobile.TabIndex = 17;
            txtMobile.TextChanged += textBox5_TextChanged;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(491, 127);
            txtEmail.Name = "txtEmail";
            txtEmail.ReadOnly = true;
            txtEmail.Size = new Size(199, 27);
            txtEmail.TabIndex = 18;
            // 
            // txtCity
            // 
            txtCity.Location = new Point(491, 220);
            txtCity.Name = "txtCity";
            txtCity.ReadOnly = true;
            txtCity.Size = new Size(199, 27);
            txtCity.TabIndex = 20;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(491, 271);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(199, 120);
            txtAddress.TabIndex = 23;
            txtAddress.Text = "";
            // 
            // txtGender
            // 
            txtGender.Location = new Point(158, 377);
            txtGender.Name = "txtGender";
            txtGender.ReadOnly = true;
            txtGender.Size = new Size(199, 27);
            txtGender.TabIndex = 24;
            // 
            // txtBloodGroup
            // 
            txtBloodGroup.Location = new Point(491, 170);
            txtBloodGroup.Name = "txtBloodGroup";
            txtBloodGroup.ReadOnly = true;
            txtBloodGroup.Size = new Size(199, 27);
            txtBloodGroup.TabIndex = 25;
            // 
            // txtDob
            // 
            txtDob.Location = new Point(158, 271);
            txtDob.Name = "txtDob";
            txtDob.ReadOnly = true;
            txtDob.Size = new Size(199, 27);
            txtDob.TabIndex = 26;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(121, 428);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 46);
            btnDelete.TabIndex = 27;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnReset
            // 
            btnReset.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReset.Location = new Point(303, 428);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(94, 46);
            btnReset.TabIndex = 28;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // btnClose
            // 
            btnClose.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.Location = new Point(491, 428);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 46);
            btnClose.TabIndex = 29;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // DeleteDonor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(702, 486);
            Controls.Add(btnClose);
            Controls.Add(btnReset);
            Controls.Add(btnDelete);
            Controls.Add(txtDob);
            Controls.Add(txtBloodGroup);
            Controls.Add(txtGender);
            Controls.Add(txtAddress);
            Controls.Add(txtCity);
            Controls.Add(txtEmail);
            Controls.Add(txtMobile);
            Controls.Add(txtMother);
            Controls.Add(txtFather);
            Controls.Add(txtName);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(btnSearch);
            Controls.Add(txtDonorID);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DeleteDonor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DeleteDonor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtDonorID;
        private Button btnSearch;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private TextBox txtName;
        private TextBox txtFather;
        private TextBox txtMother;
        private TextBox txtMobile;
        private TextBox txtEmail;
        private TextBox txtCity;
        private RichTextBox txtAddress;
        private TextBox txtGender;
        private TextBox txtBloodGroup;
        private TextBox txtDob;
        private Button btnDelete;
        private Button btnReset;
        private Button btnClose;
    }
}