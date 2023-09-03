
namespace PlumCoLx_Groep60
{
    partial class Plumbers
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
            this.btnRemovePlumber = new System.Windows.Forms.Button();
            this.btnEditPlumber = new System.Windows.Forms.Button();
            this.btnAddPlumber = new System.Windows.Forms.Button();
            this.dgvPlumbers = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlumbers)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRemovePlumber
            // 
            this.btnRemovePlumber.Font = new System.Drawing.Font("Arial Black", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemovePlumber.Location = new System.Drawing.Point(423, 668);
            this.btnRemovePlumber.Name = "btnRemovePlumber";
            this.btnRemovePlumber.Size = new System.Drawing.Size(201, 87);
            this.btnRemovePlumber.TabIndex = 14;
            this.btnRemovePlumber.Text = "Remove Plumber";
            this.btnRemovePlumber.UseVisualStyleBackColor = true;
            // 
            // btnEditPlumber
            // 
            this.btnEditPlumber.Font = new System.Drawing.Font("Arial Black", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditPlumber.Location = new System.Drawing.Point(216, 668);
            this.btnEditPlumber.Name = "btnEditPlumber";
            this.btnEditPlumber.Size = new System.Drawing.Size(201, 86);
            this.btnEditPlumber.TabIndex = 13;
            this.btnEditPlumber.Text = "Edit Plumber";
            this.btnEditPlumber.UseVisualStyleBackColor = true;
            this.btnEditPlumber.Click += new System.EventHandler(this.btnEditJob_Click);
            // 
            // btnAddPlumber
            // 
            this.btnAddPlumber.Font = new System.Drawing.Font("Arial Black", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPlumber.Location = new System.Drawing.Point(9, 668);
            this.btnAddPlumber.Name = "btnAddPlumber";
            this.btnAddPlumber.Size = new System.Drawing.Size(201, 86);
            this.btnAddPlumber.TabIndex = 12;
            this.btnAddPlumber.Text = "Add Plumber";
            this.btnAddPlumber.UseVisualStyleBackColor = true;
            // 
            // dgvPlumbers
            // 
            this.dgvPlumbers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlumbers.Location = new System.Drawing.Point(12, 51);
            this.dgvPlumbers.Name = "dgvPlumbers";
            this.dgvPlumbers.RowHeadersWidth = 51;
            this.dgvPlumbers.RowTemplate.Height = 24;
            this.dgvPlumbers.Size = new System.Drawing.Size(1576, 594);
            this.dgvPlumbers.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 34);
            this.label1.TabIndex = 10;
            this.label1.Text = "Plumbers:";
            // 
            // Plumbers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1611, 801);
            this.Controls.Add(this.btnRemovePlumber);
            this.Controls.Add(this.btnEditPlumber);
            this.Controls.Add(this.btnAddPlumber);
            this.Controls.Add(this.dgvPlumbers);
            this.Controls.Add(this.label1);
            this.Name = "Plumbers";
            this.Text = "Plumbers";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlumbers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRemovePlumber;
        private System.Windows.Forms.Button btnEditPlumber;
        private System.Windows.Forms.Button btnAddPlumber;
        private System.Windows.Forms.DataGridView dgvPlumbers;
        private System.Windows.Forms.Label label1;
    }
}