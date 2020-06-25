namespace DBapplication
{
    partial class Form1
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
            this.notification = new System.Windows.Forms.Button();
            this.mycourses = new System.Windows.Forms.Button();
            this.mysession = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addSpotsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editSpotsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.discoveryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allowDiscoveryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disableDiscoveryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // notification
            // 
            this.notification.Location = new System.Drawing.Point(97, 55);
            this.notification.Margin = new System.Windows.Forms.Padding(4);
            this.notification.Name = "notification";
            this.notification.Size = new System.Drawing.Size(187, 28);
            this.notification.TabIndex = 0;
            this.notification.Text = "notification";
            this.notification.UseVisualStyleBackColor = true;
            this.notification.Click += new System.EventHandler(this.button1_Click);
            // 
            // mycourses
            // 
            this.mycourses.Location = new System.Drawing.Point(97, 107);
            this.mycourses.Margin = new System.Windows.Forms.Padding(4);
            this.mycourses.Name = "mycourses";
            this.mycourses.Size = new System.Drawing.Size(187, 28);
            this.mycourses.TabIndex = 1;
            this.mycourses.Text = "mycourses";
            this.mycourses.UseVisualStyleBackColor = true;
            this.mycourses.Click += new System.EventHandler(this.button2_Click);
            // 
            // mysession
            // 
            this.mysession.Location = new System.Drawing.Point(97, 155);
            this.mysession.Margin = new System.Windows.Forms.Padding(4);
            this.mysession.Name = "mysession";
            this.mysession.Size = new System.Drawing.Size(187, 28);
            this.mysession.TabIndex = 2;
            this.mysession.Text = "my session";
            this.mysession.UseVisualStyleBackColor = true;
            this.mysession.Click += new System.EventHandler(this.mysession_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(379, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editProfileToolStripMenuItem,
            this.discoveryToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.logOutToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // editProfileToolStripMenuItem
            // 
            this.editProfileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changePasswordToolStripMenuItem,
            this.addSpotsToolStripMenuItem,
            this.editSpotsToolStripMenuItem});
            this.editProfileToolStripMenuItem.Name = "editProfileToolStripMenuItem";
            this.editProfileToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.editProfileToolStripMenuItem.Text = "Account";
            // 
            // changePasswordToolStripMenuItem
            // 
            this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(193, 24);
            this.changePasswordToolStripMenuItem.Text = "Change Password";
            // 
            // addSpotsToolStripMenuItem
            // 
            this.addSpotsToolStripMenuItem.Name = "editProfileToolStripMenuItem";
            this.addSpotsToolStripMenuItem.Size = new System.Drawing.Size(193, 24);
            this.addSpotsToolStripMenuItem.Text = "Edit profile info";
            this.addSpotsToolStripMenuItem.Click += new System.EventHandler(this.editProfileToolStripMenuItem_Click);
            // 
            // editSpotsToolStripMenuItem
            // 
            this.editSpotsToolStripMenuItem.Name = "editSpotsToolStripMenuItem";
            this.editSpotsToolStripMenuItem.Size = new System.Drawing.Size(193, 24);
            this.editSpotsToolStripMenuItem.Text = "Edit Spots";
            // 
            // discoveryToolStripMenuItem
            // 
            this.discoveryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.allowDiscoveryToolStripMenuItem,
            this.disableDiscoveryToolStripMenuItem});
            this.discoveryToolStripMenuItem.Name = "discoveryToolStripMenuItem";
            this.discoveryToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.discoveryToolStripMenuItem.Text = "Discovery";
            // 
            // allowDiscoveryToolStripMenuItem
            // 
            this.allowDiscoveryToolStripMenuItem.Name = "allowDiscoveryToolStripMenuItem";
            this.allowDiscoveryToolStripMenuItem.Size = new System.Drawing.Size(196, 24);
            this.allowDiscoveryToolStripMenuItem.Text = "Allow Discovery";
            // 
            // disableDiscoveryToolStripMenuItem
            // 
            this.disableDiscoveryToolStripMenuItem.Name = "disableDiscoveryToolStripMenuItem";
            this.disableDiscoveryToolStripMenuItem.Size = new System.Drawing.Size(196, 24);
            this.disableDiscoveryToolStripMenuItem.Text = "Disable Discovery";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.logOutToolStripMenuItem.Text = "Log out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 241);
            this.Controls.Add(this.mysession);
            this.Controls.Add(this.mycourses);
            this.Controls.Add(this.notification);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed_1);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button notification;
        private System.Windows.Forms.Button mycourses;
        private System.Windows.Forms.Button mysession;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editProfileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addSpotsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem discoveryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allowDiscoveryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disableDiscoveryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editSpotsToolStripMenuItem;
    }
}