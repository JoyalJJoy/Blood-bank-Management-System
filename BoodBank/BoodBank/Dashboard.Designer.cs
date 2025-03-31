namespace BoodBank
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
            this.btnExit = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.donorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allDonorDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchBloodDonorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.locationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bloodGroupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.increaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.decreaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteDonorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteDonorToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.patientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewPatientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updatePatientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allPatientsDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deletePateintsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bloodTransferToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteDonorToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.xuiClock1 = new XanderUI.XUIClock();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnExit.Location = new System.Drawing.Point(906, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(41, 24);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.donorToolStripMenuItem,
            this.searchBloodDonorToolStripMenuItem,
            this.stockToolStripMenuItem,
            this.deleteDonorToolStripMenuItem,
            this.logOutToolStripMenuItem,
            this.patientsToolStripMenuItem,
            this.bloodTransferToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(947, 68);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // donorToolStripMenuItem
            // 
            this.donorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewToolStripMenuItem,
            this.updateDetailsToolStripMenuItem,
            this.allDonorDetailsToolStripMenuItem});
            this.donorToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("donorToolStripMenuItem.Image")));
            this.donorToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.donorToolStripMenuItem.Name = "donorToolStripMenuItem";
            this.donorToolStripMenuItem.Size = new System.Drawing.Size(102, 64);
            this.donorToolStripMenuItem.Text = "Donor";
            // 
            // addNewToolStripMenuItem
            // 
            this.addNewToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("addNewToolStripMenuItem.Image")));
            this.addNewToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.addNewToolStripMenuItem.Name = "addNewToolStripMenuItem";
            this.addNewToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.addNewToolStripMenuItem.Text = "Add New Donor";
            this.addNewToolStripMenuItem.Click += new System.EventHandler(this.addNewToolStripMenuItem_Click);
            // 
            // updateDetailsToolStripMenuItem
            // 
            this.updateDetailsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("updateDetailsToolStripMenuItem.Image")));
            this.updateDetailsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.updateDetailsToolStripMenuItem.Name = "updateDetailsToolStripMenuItem";
            this.updateDetailsToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.updateDetailsToolStripMenuItem.Text = "Update Details";
            this.updateDetailsToolStripMenuItem.Click += new System.EventHandler(this.updateDetailsToolStripMenuItem_Click);
            // 
            // allDonorDetailsToolStripMenuItem
            // 
            this.allDonorDetailsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("allDonorDetailsToolStripMenuItem.Image")));
            this.allDonorDetailsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.allDonorDetailsToolStripMenuItem.Name = "allDonorDetailsToolStripMenuItem";
            this.allDonorDetailsToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.allDonorDetailsToolStripMenuItem.Text = "All Donor Details";
            this.allDonorDetailsToolStripMenuItem.Click += new System.EventHandler(this.allDonorDetailsToolStripMenuItem_Click);
            // 
            // searchBloodDonorToolStripMenuItem
            // 
            this.searchBloodDonorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.locationToolStripMenuItem,
            this.bloodGroupToolStripMenuItem});
            this.searchBloodDonorToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("searchBloodDonorToolStripMenuItem.Image")));
            this.searchBloodDonorToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.searchBloodDonorToolStripMenuItem.Name = "searchBloodDonorToolStripMenuItem";
            this.searchBloodDonorToolStripMenuItem.Size = new System.Drawing.Size(174, 64);
            this.searchBloodDonorToolStripMenuItem.Text = "Search Blood Donor";
            // 
            // locationToolStripMenuItem
            // 
            this.locationToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("locationToolStripMenuItem.Image")));
            this.locationToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.locationToolStripMenuItem.Name = "locationToolStripMenuItem";
            this.locationToolStripMenuItem.Size = new System.Drawing.Size(145, 26);
            this.locationToolStripMenuItem.Text = "Location";
            this.locationToolStripMenuItem.Click += new System.EventHandler(this.locationToolStripMenuItem_Click);
            // 
            // bloodGroupToolStripMenuItem
            // 
            this.bloodGroupToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("bloodGroupToolStripMenuItem.Image")));
            this.bloodGroupToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.bloodGroupToolStripMenuItem.Name = "bloodGroupToolStripMenuItem";
            this.bloodGroupToolStripMenuItem.Size = new System.Drawing.Size(145, 26);
            this.bloodGroupToolStripMenuItem.Text = "Blood Group";
            this.bloodGroupToolStripMenuItem.Click += new System.EventHandler(this.bloodGroupToolStripMenuItem_Click);
            // 
            // stockToolStripMenuItem
            // 
            this.stockToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.increaseToolStripMenuItem,
            this.decreaseToolStripMenuItem,
            this.detailsToolStripMenuItem});
            this.stockToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("stockToolStripMenuItem.Image")));
            this.stockToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.stockToolStripMenuItem.Name = "stockToolStripMenuItem";
            this.stockToolStripMenuItem.Size = new System.Drawing.Size(98, 64);
            this.stockToolStripMenuItem.Text = "Stock";
            // 
            // increaseToolStripMenuItem
            // 
            this.increaseToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("increaseToolStripMenuItem.Image")));
            this.increaseToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.increaseToolStripMenuItem.Name = "increaseToolStripMenuItem";
            this.increaseToolStripMenuItem.Size = new System.Drawing.Size(125, 26);
            this.increaseToolStripMenuItem.Text = "Increase";
            this.increaseToolStripMenuItem.Click += new System.EventHandler(this.increaseToolStripMenuItem_Click);
            // 
            // decreaseToolStripMenuItem
            // 
            this.decreaseToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("decreaseToolStripMenuItem.Image")));
            this.decreaseToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.decreaseToolStripMenuItem.Name = "decreaseToolStripMenuItem";
            this.decreaseToolStripMenuItem.Size = new System.Drawing.Size(125, 26);
            this.decreaseToolStripMenuItem.Text = "Decrease";
            this.decreaseToolStripMenuItem.Click += new System.EventHandler(this.decreaseToolStripMenuItem_Click);
            // 
            // detailsToolStripMenuItem
            // 
            this.detailsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("detailsToolStripMenuItem.Image")));
            this.detailsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.detailsToolStripMenuItem.Name = "detailsToolStripMenuItem";
            this.detailsToolStripMenuItem.Size = new System.Drawing.Size(125, 26);
            this.detailsToolStripMenuItem.Text = "Details";
            this.detailsToolStripMenuItem.Click += new System.EventHandler(this.detailsToolStripMenuItem_Click);
            // 
            // deleteDonorToolStripMenuItem
            // 
            this.deleteDonorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteDonorToolStripMenuItem2});
            this.deleteDonorToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("deleteDonorToolStripMenuItem.Image")));
            this.deleteDonorToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.deleteDonorToolStripMenuItem.Name = "deleteDonorToolStripMenuItem";
            this.deleteDonorToolStripMenuItem.Size = new System.Drawing.Size(138, 64);
            this.deleteDonorToolStripMenuItem.Text = "Delete Donor";
            // 
            // deleteDonorToolStripMenuItem2
            // 
            this.deleteDonorToolStripMenuItem2.Image = ((System.Drawing.Image)(resources.GetObject("deleteDonorToolStripMenuItem2.Image")));
            this.deleteDonorToolStripMenuItem2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.deleteDonorToolStripMenuItem2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.deleteDonorToolStripMenuItem2.Name = "deleteDonorToolStripMenuItem2";
            this.deleteDonorToolStripMenuItem2.Size = new System.Drawing.Size(147, 26);
            this.deleteDonorToolStripMenuItem2.Text = "Delete Donor";
            this.deleteDonorToolStripMenuItem2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.deleteDonorToolStripMenuItem2.Click += new System.EventHandler(this.deleteDonorToolStripMenuItem2_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("logOutToolStripMenuItem.Image")));
            this.logOutToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(122, 64);
            this.logOutToolStripMenuItem.Text = "Log Out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // patientsToolStripMenuItem
            // 
            this.patientsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewPatientsToolStripMenuItem,
            this.updatePatientsToolStripMenuItem,
            this.allPatientsDetailsToolStripMenuItem,
            this.deletePateintsToolStripMenuItem});
            this.patientsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("patientsToolStripMenuItem.Image")));
            this.patientsToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.patientsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.patientsToolStripMenuItem.Name = "patientsToolStripMenuItem";
            this.patientsToolStripMenuItem.Size = new System.Drawing.Size(111, 64);
            this.patientsToolStripMenuItem.Text = "Patients";
            this.patientsToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // addNewPatientsToolStripMenuItem
            // 
            this.addNewPatientsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("addNewPatientsToolStripMenuItem.Image")));
            this.addNewPatientsToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addNewPatientsToolStripMenuItem.Name = "addNewPatientsToolStripMenuItem";
            this.addNewPatientsToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.addNewPatientsToolStripMenuItem.Text = "Add new Patients";
            this.addNewPatientsToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.addNewPatientsToolStripMenuItem.Click += new System.EventHandler(this.addNewPatientsToolStripMenuItem_Click);
            // 
            // updatePatientsToolStripMenuItem
            // 
            this.updatePatientsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("updatePatientsToolStripMenuItem.Image")));
            this.updatePatientsToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.updatePatientsToolStripMenuItem.Name = "updatePatientsToolStripMenuItem";
            this.updatePatientsToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.updatePatientsToolStripMenuItem.Text = "Update Patients";
            this.updatePatientsToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.updatePatientsToolStripMenuItem.Click += new System.EventHandler(this.updatePatientsToolStripMenuItem_Click);
            // 
            // allPatientsDetailsToolStripMenuItem
            // 
            this.allPatientsDetailsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("allPatientsDetailsToolStripMenuItem.Image")));
            this.allPatientsDetailsToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.allPatientsDetailsToolStripMenuItem.Name = "allPatientsDetailsToolStripMenuItem";
            this.allPatientsDetailsToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.allPatientsDetailsToolStripMenuItem.Text = "All Patients Details";
            this.allPatientsDetailsToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.allPatientsDetailsToolStripMenuItem.Click += new System.EventHandler(this.allPatientsDetailsToolStripMenuItem_Click);
            // 
            // deletePateintsToolStripMenuItem
            // 
            this.deletePateintsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("deletePateintsToolStripMenuItem.Image")));
            this.deletePateintsToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.deletePateintsToolStripMenuItem.Name = "deletePateintsToolStripMenuItem";
            this.deletePateintsToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.deletePateintsToolStripMenuItem.Text = "Delete Patients";
            this.deletePateintsToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.deletePateintsToolStripMenuItem.Click += new System.EventHandler(this.deletePateintsToolStripMenuItem_Click);
            // 
            // bloodTransferToolStripMenuItem
            // 
            this.bloodTransferToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("bloodTransferToolStripMenuItem.Image")));
            this.bloodTransferToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bloodTransferToolStripMenuItem.Name = "bloodTransferToolStripMenuItem";
            this.bloodTransferToolStripMenuItem.Size = new System.Drawing.Size(111, 64);
            this.bloodTransferToolStripMenuItem.Text = "Blood Transfer";
            this.bloodTransferToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bloodTransferToolStripMenuItem.Click += new System.EventHandler(this.bloodTransferToolStripMenuItem_Click);
            // 
            // deleteDonorToolStripMenuItem1
            // 
            this.deleteDonorToolStripMenuItem1.Name = "deleteDonorToolStripMenuItem1";
            this.deleteDonorToolStripMenuItem1.Size = new System.Drawing.Size(32, 19);
            // 
            // xuiClock1
            // 
            this.xuiClock1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.xuiClock1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.xuiClock1.CircleThickness = 6;
            this.xuiClock1.DisplayFormat = XanderUI.XUIClock.HourFormat.TwelveHour;
            this.xuiClock1.FilledHourColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(190)))), ((int)(((byte)(155)))));
            this.xuiClock1.FilledMinuteColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            this.xuiClock1.FilledSecondColor = System.Drawing.Color.DarkOrchid;
            this.xuiClock1.Font = new System.Drawing.Font("Impact", 15F);
            this.xuiClock1.HexagonColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            this.xuiClock1.Location = new System.Drawing.Point(816, 0);
            this.xuiClock1.Name = "xuiClock1";
            this.xuiClock1.ShowAmPm = false;
            this.xuiClock1.ShowHexagon = true;
            this.xuiClock1.ShowMinutesCircle = true;
            this.xuiClock1.ShowSecondsCircle = true;
            this.xuiClock1.Size = new System.Drawing.Size(84, 68);
            this.xuiClock1.TabIndex = 4;
            this.xuiClock1.Text = "xuiClock1";
            this.xuiClock1.UnfilledHourColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(70)))), ((int)(((byte)(85)))));
            this.xuiClock1.UnfilledMinuteColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            this.xuiClock1.UnfilledSecondColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(947, 508);
            this.Controls.Add(this.xuiClock1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem donorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchBloodDonorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteDonorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allDonorDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem locationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bloodGroupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem increaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem decreaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteDonorToolStripMenuItem1;
        private XanderUI.XUIClock xuiClock1;
        private System.Windows.Forms.ToolStripMenuItem deleteDonorToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem patientsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewPatientsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updatePatientsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allPatientsDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deletePateintsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bloodTransferToolStripMenuItem;
    }
}