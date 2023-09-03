
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
            this.btnBefore = new System.Windows.Forms.Button();
            this.btnThisMonth = new System.Windows.Forms.Button();
            this.btnAfter = new System.Windows.Forms.Button();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFinances)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Finances:";
            // 
            // dgvFinances
            // 
            this.dgvFinances.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFinances.Location = new System.Drawing.Point(29, 58);
            this.dgvFinances.Name = "dgvFinances";
            this.dgvFinances.RowHeadersWidth = 51;
            this.dgvFinances.RowTemplate.Height = 24;
            this.dgvFinances.Size = new System.Drawing.Size(1565, 503);
            this.dgvFinances.TabIndex = 1;
            // 
            // btnBefore
            // 
            this.btnBefore.Font = new System.Drawing.Font("Arial Black", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBefore.Location = new System.Drawing.Point(40, 632);
            this.btnBefore.Name = "btnBefore";
            this.btnBefore.Size = new System.Drawing.Size(166, 81);
            this.btnBefore.TabIndex = 3;
            this.btnBefore.Text = "Before";
            this.btnBefore.UseVisualStyleBackColor = true;
            // 
            // btnThisMonth
            // 
            this.btnThisMonth.Font = new System.Drawing.Font("Arial Black", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThisMonth.Location = new System.Drawing.Point(212, 632);
            this.btnThisMonth.Name = "btnThisMonth";
            this.btnThisMonth.Size = new System.Drawing.Size(166, 81);
            this.btnThisMonth.TabIndex = 4;
            this.btnThisMonth.Text = "ThisMonth";
            this.btnThisMonth.UseVisualStyleBackColor = true;
            // 
            // btnAfter
            // 
            this.btnAfter.Font = new System.Drawing.Font("Arial Black", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAfter.Location = new System.Drawing.Point(384, 632);
            this.btnAfter.Name = "btnAfter";
            this.btnAfter.Size = new System.Drawing.Size(166, 81);
            this.btnAfter.TabIndex = 5;
            this.btnAfter.Text = "After";
            this.btnAfter.UseVisualStyleBackColor = true;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(562, 573);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 6;
            // 
            // Finances
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1606, 798);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.btnAfter);
            this.Controls.Add(this.btnThisMonth);
            this.Controls.Add(this.btnBefore);
            this.Controls.Add(this.dgvFinances);
            this.Controls.Add(this.label1);
            this.Name = "Finances";
            this.Text = "Finances";
            ((System.ComponentModel.ISupportInitialize)(this.dgvFinances)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvFinances;
        private System.Windows.Forms.Button btnBefore;
        private System.Windows.Forms.Button btnThisMonth;
        private System.Windows.Forms.Button btnAfter;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
    }
}