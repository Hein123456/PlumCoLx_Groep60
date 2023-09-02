namespace PlumCoLx_Groep60
{
    partial class User
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.navToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.navToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.usernameToolStripMenuItem = new System.Windows.Forms.ToolStripTextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.navToolStripMenuItem,
            this.vanToolStripMenuItem,
            this.navToolStripMenuItem1,
            this.usernameToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(0);
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.menuStrip1.Size = new System.Drawing.Size(708, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // navToolStripMenuItem
            // 
            this.navToolStripMenuItem.Name = "navToolStripMenuItem";
            this.navToolStripMenuItem.Size = new System.Drawing.Size(49, 27);
            this.navToolStripMenuItem.Text = "Info";
            this.navToolStripMenuItem.Click += new System.EventHandler(this.navToolStripMenuItem_Click);
            // 
            // vanToolStripMenuItem
            // 
            this.vanToolStripMenuItem.Name = "vanToolStripMenuItem";
            this.vanToolStripMenuItem.Size = new System.Drawing.Size(80, 27);
            this.vanToolStripMenuItem.Text = "Products";
            this.vanToolStripMenuItem.Click += new System.EventHandler(this.vanToolStripMenuItem_Click);
            // 
            // navToolStripMenuItem1
            // 
            this.navToolStripMenuItem1.Name = "navToolStripMenuItem1";
            this.navToolStripMenuItem1.Size = new System.Drawing.Size(46, 27);
            this.navToolStripMenuItem1.Text = "nav";
            // 
            // usernameToolStripMenuItem
            // 
            this.usernameToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.usernameToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.usernameToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.usernameToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.usernameToolStripMenuItem.Name = "usernameToolStripMenuItem";
            this.usernameToolStripMenuItem.ReadOnly = true;
            this.usernameToolStripMenuItem.Size = new System.Drawing.Size(87, 27);
            this.usernameToolStripMenuItem.Text = "username";
            // 
            // User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(19)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(708, 733);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "User";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InfoUser";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.User_FormClosing);
            this.Load += new System.EventHandler(this.User_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem navToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem navToolStripMenuItem1;
        private System.Windows.Forms.ToolStripTextBox usernameToolStripMenuItem;
    }
}