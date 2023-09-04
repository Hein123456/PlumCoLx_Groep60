
namespace PlumCoLx_Groep60
{
    partial class Finances
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgvFinances = new System.Windows.Forms.DataGridView();
            this.btnPending = new System.Windows.Forms.Button();
            this.btnAll = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFinances)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Finances:";
            // 
            // dgvFinances
            // 
            this.dgvFinances.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFinances.Location = new System.Drawing.Point(22, 47);
            this.dgvFinances.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvFinances.Name = "dgvFinances";
            this.dgvFinances.RowHeadersWidth = 51;
            this.dgvFinances.RowTemplate.Height = 24;
            this.dgvFinances.Size = new System.Drawing.Size(1174, 409);
            this.dgvFinances.TabIndex = 1;
            // 
            // btnPending
            // 
            this.btnPending.Font = new System.Drawing.Font("Arial Black", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPending.Location = new System.Drawing.Point(30, 514);
            this.btnPending.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPending.Name = "btnPending";
            this.btnPending.Size = new System.Drawing.Size(124, 66);
            this.btnPending.TabIndex = 3;
            this.btnPending.Text = "Pending";
            this.btnPending.UseVisualStyleBackColor = true;
            this.btnPending.Click += new System.EventHandler(this.btnPending_Click);
            // 
            // btnAll
            // 
            this.btnAll.Font = new System.Drawing.Font("Arial Black", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAll.Location = new System.Drawing.Point(159, 514);
            this.btnAll.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(124, 66);
            this.btnAll.TabIndex = 4;
            this.btnAll.Text = "Display all";
            this.btnAll.UseVisualStyleBackColor = true;
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // Finances
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1149, 599);
            this.Controls.Add(this.btnAll);
            this.Controls.Add(this.btnPending);
            this.Controls.Add(this.dgvFinances);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Finances";
            this.Text = "Finances";
            this.Load += new System.EventHandler(this.Finances_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFinances)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvFinances;
        private System.Windows.Forms.Button btnPending;
        private System.Windows.Forms.Button btnAll;
    }
}