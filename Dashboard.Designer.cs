namespace Blood_Bank_Management
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            btnExit = new Button();
            menuStrip1 = new MenuStrip();
            donorToolStripMenuItem = new ToolStripMenuItem();
            addnewDonor = new ToolStripMenuItem();
            upadateDetailsToolStripMenuItem = new ToolStripMenuItem();
            allDonorDetailsToolStripMenuItem = new ToolStripMenuItem();
            searchBloodDonorToolStripMenuItem = new ToolStripMenuItem();
            locationToolStripMenuItem = new ToolStripMenuItem();
            bloodGroupToolStripMenuItem = new ToolStripMenuItem();
            stockToolStripMenuItem = new ToolStripMenuItem();
            increaseToolStripMenuItem = new ToolStripMenuItem();
            decreaseToolStripMenuItem = new ToolStripMenuItem();
            detailsToolStripMenuItem = new ToolStripMenuItem();
            deleteDonorToolStripMenuItem = new ToolStripMenuItem();
            deleteDonorToolStripMenuItem1 = new ToolStripMenuItem();
            logOToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // btnExit
            // 
            btnExit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnExit.BackColor = Color.FromArgb(224, 224, 224);
            btnExit.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.ForeColor = Color.DarkSlateGray;
            btnExit.Location = new Point(1277, 2);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(39, 39);
            btnExit.TabIndex = 2;
            btnExit.Text = "X";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.FromArgb(255, 192, 192);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { donorToolStripMenuItem, searchBloodDonorToolStripMenuItem, stockToolStripMenuItem, deleteDonorToolStripMenuItem, logOToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1318, 105);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // donorToolStripMenuItem
            // 
            donorToolStripMenuItem.BackgroundImage = (Image)resources.GetObject("donorToolStripMenuItem.BackgroundImage");
            donorToolStripMenuItem.BackgroundImageLayout = ImageLayout.Zoom;
            donorToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addnewDonor, upadateDetailsToolStripMenuItem, allDonorDetailsToolStripMenuItem });
            donorToolStripMenuItem.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            donorToolStripMenuItem.ForeColor = Color.FromArgb(192, 0, 0);
            donorToolStripMenuItem.Image = (Image)resources.GetObject("donorToolStripMenuItem.Image");
            donorToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            donorToolStripMenuItem.Name = "donorToolStripMenuItem";
            donorToolStripMenuItem.Size = new Size(181, 101);
            donorToolStripMenuItem.Text = " Donor";
            donorToolStripMenuItem.Click += donorToolStripMenuItem_Click;
            // 
            // addnewDonor
            // 
            addnewDonor.Name = "addnewDonor";
            addnewDonor.Size = new Size(261, 32);
            addnewDonor.Text = "Add New Donor";
            addnewDonor.Click += addToolStripMenuItem_Click;
            // 
            // upadateDetailsToolStripMenuItem
            // 
            upadateDetailsToolStripMenuItem.Name = "upadateDetailsToolStripMenuItem";
            upadateDetailsToolStripMenuItem.Size = new Size(261, 32);
            upadateDetailsToolStripMenuItem.Text = "Upadate details";
            upadateDetailsToolStripMenuItem.Click += upadateDetailsToolStripMenuItem_Click;
            // 
            // allDonorDetailsToolStripMenuItem
            // 
            allDonorDetailsToolStripMenuItem.Name = "allDonorDetailsToolStripMenuItem";
            allDonorDetailsToolStripMenuItem.Size = new Size(261, 32);
            allDonorDetailsToolStripMenuItem.Text = "All Donor Details";
            allDonorDetailsToolStripMenuItem.Click += allDonorDetailsToolStripMenuItem_Click;
            // 
            // searchBloodDonorToolStripMenuItem
            // 
            searchBloodDonorToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { locationToolStripMenuItem, bloodGroupToolStripMenuItem });
            searchBloodDonorToolStripMenuItem.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            searchBloodDonorToolStripMenuItem.ForeColor = Color.FromArgb(192, 0, 0);
            searchBloodDonorToolStripMenuItem.Image = (Image)resources.GetObject("searchBloodDonorToolStripMenuItem.Image");
            searchBloodDonorToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            searchBloodDonorToolStripMenuItem.Name = "searchBloodDonorToolStripMenuItem";
            searchBloodDonorToolStripMenuItem.Size = new Size(305, 101);
            searchBloodDonorToolStripMenuItem.Text = "Search Blood Donor";
            // 
            // locationToolStripMenuItem
            // 
            locationToolStripMenuItem.Name = "locationToolStripMenuItem";
            locationToolStripMenuItem.Size = new Size(217, 32);
            locationToolStripMenuItem.Text = "Location";
            locationToolStripMenuItem.Click += locationToolStripMenuItem_Click;
            // 
            // bloodGroupToolStripMenuItem
            // 
            bloodGroupToolStripMenuItem.Name = "bloodGroupToolStripMenuItem";
            bloodGroupToolStripMenuItem.Size = new Size(217, 32);
            bloodGroupToolStripMenuItem.Text = "Blood Group";
            bloodGroupToolStripMenuItem.Click += bloodGroupToolStripMenuItem_Click;
            // 
            // stockToolStripMenuItem
            // 
            stockToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { increaseToolStripMenuItem, decreaseToolStripMenuItem, detailsToolStripMenuItem });
            stockToolStripMenuItem.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            stockToolStripMenuItem.ForeColor = Color.FromArgb(192, 0, 0);
            stockToolStripMenuItem.Image = (Image)resources.GetObject("stockToolStripMenuItem.Image");
            stockToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            stockToolStripMenuItem.Name = "stockToolStripMenuItem";
            stockToolStripMenuItem.Size = new Size(168, 101);
            stockToolStripMenuItem.Text = "Stock";
            // 
            // increaseToolStripMenuItem
            // 
            increaseToolStripMenuItem.Name = "increaseToolStripMenuItem";
            increaseToolStripMenuItem.Size = new Size(184, 32);
            increaseToolStripMenuItem.Text = "Increase";
            increaseToolStripMenuItem.Click += increaseToolStripMenuItem_Click;
            // 
            // decreaseToolStripMenuItem
            // 
            decreaseToolStripMenuItem.Name = "decreaseToolStripMenuItem";
            decreaseToolStripMenuItem.Size = new Size(184, 32);
            decreaseToolStripMenuItem.Text = "Decrease";
            decreaseToolStripMenuItem.Click += decreaseToolStripMenuItem_Click;
            // 
            // detailsToolStripMenuItem
            // 
            detailsToolStripMenuItem.Name = "detailsToolStripMenuItem";
            detailsToolStripMenuItem.Size = new Size(184, 32);
            detailsToolStripMenuItem.Text = "Details";
            detailsToolStripMenuItem.Click += detailsToolStripMenuItem_Click;
            // 
            // deleteDonorToolStripMenuItem
            // 
            deleteDonorToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { deleteDonorToolStripMenuItem1 });
            deleteDonorToolStripMenuItem.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            deleteDonorToolStripMenuItem.ForeColor = Color.FromArgb(192, 0, 0);
            deleteDonorToolStripMenuItem.Image = (Image)resources.GetObject("deleteDonorToolStripMenuItem.Image");
            deleteDonorToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            deleteDonorToolStripMenuItem.Name = "deleteDonorToolStripMenuItem";
            deleteDonorToolStripMenuItem.Size = new Size(243, 101);
            deleteDonorToolStripMenuItem.Text = "Delete Donor";
            // 
            // deleteDonorToolStripMenuItem1
            // 
            deleteDonorToolStripMenuItem1.Name = "deleteDonorToolStripMenuItem1";
            deleteDonorToolStripMenuItem1.Size = new Size(225, 32);
            deleteDonorToolStripMenuItem1.Text = "Delete Donor";
            deleteDonorToolStripMenuItem1.Click += deleteDonorToolStripMenuItem1_Click;
            // 
            // logOToolStripMenuItem
            // 
            logOToolStripMenuItem.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            logOToolStripMenuItem.ForeColor = Color.FromArgb(192, 0, 0);
            logOToolStripMenuItem.Image = (Image)resources.GetObject("logOToolStripMenuItem.Image");
            logOToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            logOToolStripMenuItem.Name = "logOToolStripMenuItem";
            logOToolStripMenuItem.Size = new Size(191, 101);
            logOToolStripMenuItem.Text = "Log Out";
            logOToolStripMenuItem.Click += logOToolStripMenuItem_Click;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1318, 710);
            Controls.Add(btnExit);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Dashboard";
            Text = "Dashboard";
            WindowState = FormWindowState.Maximized;
            Load += Dashboard_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnExit;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem donorToolStripMenuItem;
        private ToolStripMenuItem searchBloodDonorToolStripMenuItem;
        private ToolStripMenuItem stockToolStripMenuItem;
        private ToolStripMenuItem deleteDonorToolStripMenuItem;
        private ToolStripMenuItem logOToolStripMenuItem;
        private ToolStripMenuItem addnewDonor;
        private ToolStripMenuItem upadateDetailsToolStripMenuItem;
        private ToolStripMenuItem allDonorDetailsToolStripMenuItem;
        private ToolStripMenuItem locationToolStripMenuItem;
        private ToolStripMenuItem bloodGroupToolStripMenuItem;
        private ToolStripMenuItem increaseToolStripMenuItem;
        private ToolStripMenuItem decreaseToolStripMenuItem;
        private ToolStripMenuItem detailsToolStripMenuItem;
        private ToolStripMenuItem deleteDonorToolStripMenuItem1;
    }
}