namespace Blood_Bank_Management
{
    partial class StockIncrease
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StockIncrease));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtBloodGroup = new ComboBox();
            txtUnits = new ComboBox();
            btnIncrease = new Button();
            dataGridView1 = new DataGridView();
            btnPrint = new Button();
            btnClose = new Button();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(162, 9);
            label1.Name = "label1";
            label1.Size = new Size(323, 46);
            label1.TabIndex = 0;
            label1.Text = "STOCK (INCREASE)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(21, 53);
            label2.Name = "label2";
            label2.Size = new Size(130, 30);
            label2.TabIndex = 1;
            label2.Text = "Blood Group";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.BorderStyle = BorderStyle.Fixed3D;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(290, 55);
            label3.Name = "label3";
            label3.Size = new Size(61, 30);
            label3.TabIndex = 2;
            label3.Text = "Units";
            // 
            // txtBloodGroup
            // 
            txtBloodGroup.DropDownStyle = ComboBoxStyle.DropDownList;
            txtBloodGroup.FormattingEnabled = true;
            txtBloodGroup.Items.AddRange(new object[] { "A+", "B+", "AB+", "O+", "O-", "AB-", "A-", "B-" });
            txtBloodGroup.Location = new Point(157, 55);
            txtBloodGroup.Name = "txtBloodGroup";
            txtBloodGroup.Size = new Size(127, 28);
            txtBloodGroup.TabIndex = 3;
            // 
            // txtUnits
            // 
            txtUnits.DropDownStyle = ComboBoxStyle.DropDownList;
            txtUnits.FormattingEnabled = true;
            txtUnits.Items.AddRange(new object[] { "1", "2", "3 ", "4", "5", "6", "7", "8", "9", "10" });
            txtUnits.Location = new Point(357, 55);
            txtUnits.Name = "txtUnits";
            txtUnits.Size = new Size(151, 28);
            txtUnits.TabIndex = 4;
            // 
            // btnIncrease
            // 
            btnIncrease.BackColor = Color.Transparent;
            btnIncrease.FlatStyle = FlatStyle.Popup;
            btnIncrease.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnIncrease.ForeColor = Color.White;
            btnIncrease.Location = new Point(525, 47);
            btnIncrease.Name = "btnIncrease";
            btnIncrease.Size = new Size(138, 38);
            btnIncrease.TabIndex = 5;
            btnIncrease.Text = "Increase";
            btnIncrease.TextAlign = ContentAlignment.TopCenter;
            btnIncrease.UseVisualStyleBackColor = false;
            btnIncrease.Click += btnIncrease_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(24, 99);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(669, 327);
            dataGridView1.TabIndex = 6;
            // 
            // btnPrint
            // 
            btnPrint.FlatStyle = FlatStyle.Popup;
            btnPrint.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPrint.Location = new Point(21, 432);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(94, 42);
            btnPrint.TabIndex = 7;
            btnPrint.Text = "Print";
            btnPrint.UseVisualStyleBackColor = true;
            btnPrint.Click += btnPrint_Click;
            // 
            // btnClose
            // 
            btnClose.FlatStyle = FlatStyle.Popup;
            btnClose.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.Location = new Point(596, 432);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 42);
            btnClose.TabIndex = 8;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // StockIncrease
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(702, 486);
            Controls.Add(btnClose);
            Controls.Add(btnPrint);
            Controls.Add(dataGridView1);
            Controls.Add(btnIncrease);
            Controls.Add(txtUnits);
            Controls.Add(txtBloodGroup);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "StockIncrease";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "StockIncrease";
            Load += StockIncrease_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox txtBloodGroup;
        private ComboBox txtUnits;
        private Button btnIncrease;
        private DataGridView dataGridView1;
        private Button btnPrint;
        private Button btnClose;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}