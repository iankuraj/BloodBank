using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blood_Bank_Management
{
    public partial class StockDecrease : Form
    {
        function fn = new function();
        private System.Drawing.Printing.PrintDocument printDocument1;
        String query;
        public StockDecrease()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            ComponentResourceManager resources = new ComponentResourceManager(typeof(StockDecrease));
            label1 = new Label();
            label2 = new Label();
            txtBloodGroup = new ComboBox();
            label3 = new Label();
            txtUnits = new ComboBox();
            btnDecrease = new Button();
            dataGridView1 = new DataGridView();
            btnPrint = new Button();
            btnClose = new Button();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            ((ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(169, 9);
            label1.Name = "label1";
            label1.Size = new Size(320, 46);
            label1.TabIndex = 0;
            label1.Text = "STOCK(DECREASE)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 59);
            label2.Name = "label2";
            label2.Size = new Size(130, 30);
            label2.TabIndex = 1;
            label2.Text = "Blood Group";
            // 
            // txtBloodGroup
            // 
            txtBloodGroup.DropDownStyle = ComboBoxStyle.DropDownList;
            txtBloodGroup.FormattingEnabled = true;
            txtBloodGroup.Items.AddRange(new object[] { "A+", "B+", "AB+", "O+", "O-", "AB-", "A-", "B-" });
            txtBloodGroup.Location = new Point(158, 61);
            txtBloodGroup.Name = "txtBloodGroup";
            txtBloodGroup.Size = new Size(112, 28);
            txtBloodGroup.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.BorderStyle = BorderStyle.Fixed3D;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(276, 59);
            label3.Name = "label3";
            label3.Size = new Size(61, 30);
            label3.TabIndex = 3;
            label3.Text = "Units";
            // 
            // txtUnits
            // 
            txtUnits.DropDownStyle = ComboBoxStyle.DropDownList;
            txtUnits.FormattingEnabled = true;
            txtUnits.Items.AddRange(new object[] { "-1", "-2", "-3", "-4", "-5", "-6", "-7", "-8", "-9", "-10" });
            txtUnits.Location = new Point(343, 63);
            txtUnits.Name = "txtUnits";
            txtUnits.Size = new Size(120, 28);
            txtUnits.TabIndex = 4;
            // 
            // btnDecrease
            // 
            btnDecrease.FlatStyle = FlatStyle.Popup;
            btnDecrease.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDecrease.Location = new Point(516, 50);
            btnDecrease.Name = "btnDecrease";
            btnDecrease.Size = new Size(131, 43);
            btnDecrease.TabIndex = 5;
            btnDecrease.Text = "Decrease";
            btnDecrease.UseVisualStyleBackColor = true;
            btnDecrease.Click += btnDecrease_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 99);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(678, 334);
            dataGridView1.TabIndex = 6;
            // 
            // btnPrint
            // 
            btnPrint.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPrint.Location = new Point(12, 439);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(94, 37);
            btnPrint.TabIndex = 7;
            btnPrint.Text = "Print";
            btnPrint.UseVisualStyleBackColor = true;
            btnPrint.Click += btnPrint_Click;
            // 
            // btnClose
            // 
            btnClose.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.Location = new Point(596, 439);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 37);
            btnClose.TabIndex = 8;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // StockDecrease
            // 
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(702, 503);
            Controls.Add(btnClose);
            Controls.Add(btnPrint);
            Controls.Add(dataGridView1);
            Controls.Add(btnDecrease);
            Controls.Add(txtUnits);
            Controls.Add(label3);
            Controls.Add(txtBloodGroup);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "StockDecrease";
            Load += StockDecrease_Load;
            ((ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Label label1;
        private ComboBox txtBloodGroup;
        private Label label3;
        private ComboBox txtUnits;
        private Button btnDecrease;
        private DataGridView dataGridView1;
        private Button btnPrint;
        private Button btnClose;
        private Label label2;

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void StockDecrease_Load(object sender, EventArgs e)
        {
            query = "select  blood_group, quantity from stock";
            DataSet ds = fn.getData(query);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void btnDecrease_Click(object sender, EventArgs e)
        {
            query = "update stock set quantity = quantity " + txtUnits.Text + "  where   blood_group = '" + txtBloodGroup.Text + "' ";
            fn.setDate(query);
            StockDecrease_Load(this, null);
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bm = new Bitmap(this.dataGridView1.Width, this.dataGridView1.Height);
            dataGridView1.DrawToBitmap(bm, new Rectangle(0, 0, this.dataGridView1.Width, this.dataGridView1.Height));
            e.Graphics.DrawImage(bm, 0, 0);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }
    }
}
