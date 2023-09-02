namespace PlumCoLx_Groep60
{
    partial class UserInfo
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
            this.components = new System.ComponentModel.Container();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Items.AddRange(new object[] {
            "Welcome to PlumbCoLX™ - Your Trusted Plumbing Partner Since 1950!",
            "",
            "At PlumbCoLX™, we have been proudly serving our valued customers in South Africa " +
                "for over ",
            "seven decades. Since our inception in 1950, we have consistently delivered unpara" +
                "lleled ",
            "plumbing services, earning us a reputation as an industry leader that South Afric" +
                "ans can rely ",
            "on. Our unwavering commitment to customer satisfaction is the cornerstone of our " +
                "success, ",
            "and we are dedicated to exceeding your expectations with every plumbing task we u" +
                "ndertake."});
            this.listBox1.Location = new System.Drawing.Point(29, 28);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(586, 132);
            this.listBox1.TabIndex = 0;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Items.AddRange(new object[] {
            "Unrivaled Quality and Expertise",
            "",
            "What sets PlumbCoLX™ apart is our unwavering dedication to quality. We believe th" +
                "at every ",
            "plumbing job, big or small, deserves the highest level of care and precision. To " +
                "achieve this, we ",
            "exclusively use top-of-the-line products and employ state-of-the-art equipment, e" +
                "nsuring that ",
            "every project is completed to the highest industry standards. Our team of experie" +
                "nced and ",
            "highly skilled plumbers is ready to tackle any plumbing challenge, no matter how " +
                "complex."});
            this.listBox2.Location = new System.Drawing.Point(29, 181);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(586, 132);
            this.listBox2.TabIndex = 1;
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 16;
            this.listBox3.Items.AddRange(new object[] {
            "Our Services",
            "",
            "Whether you need routine maintenance, emergency repairs, or plumbing installation" +
                "s, ",
            "PlumbCoLX™ has you covered. Our comprehensive range of services includes:",
            "",
            "General Plumbing: From leaky faucets to pipe replacements, we handle all your plu" +
                "mbing ",
            "needs.",
            "Emergency Repairs: We offer 24/7 emergency services to ensure that your plumbing " +
                "",
            "problems are resolved promptly.",
            "Plumbing Installations: Whether it\'s a new fixture or a complete plumbing system " +
                "installation, ",
            "our experts are here to help.",
            "Maintenance: Preventive maintenance to keep your plumbing system in excellent con" +
                "dition ",
            "and avoid costly repairs.",
            "Water Heater Services: Installation, repair, and maintenance of water heaters to " +
                "ensure a ",
            "consistent supply of hot water.",
            "Drain Cleaning: Effective solutions to clear clogged drains and prevent future bl" +
                "ockages."});
            this.listBox3.Location = new System.Drawing.Point(29, 337);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(586, 276);
            this.listBox3.TabIndex = 2;
            // 
            // UserInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(654, 685);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserInfo";
            this.Text = "UserInfo";
            this.Load += new System.EventHandler(this.UserInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox3;
    }
}