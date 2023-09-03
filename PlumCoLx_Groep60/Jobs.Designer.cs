
namespace PlumCoLx_Groep60
{
    partial class Jobs
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
            this.dgvJobs = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtJobDesc = new System.Windows.Forms.TextBox();
            this.txtJobStatus = new System.Windows.Forms.TextBox();
            this.txtClientID = new System.Windows.Forms.TextBox();
            this.txtJobID = new System.Windows.Forms.TextBox();
            this.btnRemoveSup = new System.Windows.Forms.Button();
            this.btnEditSup = new System.Windows.Forms.Button();
            this.btnAddSup = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJobs)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvJobs
            // 
            this.dgvJobs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvJobs.Location = new System.Drawing.Point(12, 46);
            this.dgvJobs.Name = "dgvJobs";
            this.dgvJobs.RowHeadersWidth = 51;
            this.dgvJobs.RowTemplate.Height = 24;
            this.dgvJobs.Size = new System.Drawing.Size(1576, 350);
            this.dgvJobs.TabIndex = 6;
            this.dgvJobs.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvJobs_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 27);
            this.label1.TabIndex = 5;
            this.label1.Text = "Jobs:";
            // 
            // txtJobDesc
            // 
            this.txtJobDesc.Font = new System.Drawing.Font("Arial Black", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJobDesc.Location = new System.Drawing.Point(236, 576);
            this.txtJobDesc.Name = "txtJobDesc";
            this.txtJobDesc.Size = new System.Drawing.Size(218, 26);
            this.txtJobDesc.TabIndex = 32;
            this.txtJobDesc.Text = "Description";
            // 
            // txtJobStatus
            // 
            this.txtJobStatus.Font = new System.Drawing.Font("Arial Black", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJobStatus.Location = new System.Drawing.Point(236, 604);
            this.txtJobStatus.Name = "txtJobStatus";
            this.txtJobStatus.Size = new System.Drawing.Size(218, 26);
            this.txtJobStatus.TabIndex = 31;
            this.txtJobStatus.Text = "Status";
            // 
            // txtClientID
            // 
            this.txtClientID.Font = new System.Drawing.Font("Arial Black", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClientID.Location = new System.Drawing.Point(236, 548);
            this.txtClientID.Name = "txtClientID";
            this.txtClientID.Size = new System.Drawing.Size(218, 26);
            this.txtClientID.TabIndex = 28;
            this.txtClientID.Text = "Client ID";
            // 
            // txtJobID
            // 
            this.txtJobID.Font = new System.Drawing.Font("Arial Black", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJobID.Location = new System.Drawing.Point(236, 520);
            this.txtJobID.Name = "txtJobID";
            this.txtJobID.Size = new System.Drawing.Size(218, 26);
            this.txtJobID.TabIndex = 27;
            this.txtJobID.Text = "Job ID";
            // 
            // btnRemoveSup
            // 
            this.btnRemoveSup.Font = new System.Drawing.Font("Arial Black", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveSup.Location = new System.Drawing.Point(236, 402);
            this.btnRemoveSup.Name = "btnRemoveSup";
            this.btnRemoveSup.Size = new System.Drawing.Size(218, 85);
            this.btnRemoveSup.TabIndex = 26;
            this.btnRemoveSup.Text = "Remove supplier";
            this.btnRemoveSup.UseVisualStyleBackColor = true;
            this.btnRemoveSup.Click += new System.EventHandler(this.btnRemoveSup_Click);
            // 
            // btnEditSup
            // 
            this.btnEditSup.Font = new System.Drawing.Font("Arial Black", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditSup.Location = new System.Drawing.Point(12, 520);
            this.btnEditSup.Name = "btnEditSup";
            this.btnEditSup.Size = new System.Drawing.Size(218, 88);
            this.btnEditSup.TabIndex = 25;
            this.btnEditSup.Text = "Edit Supplier";
            this.btnEditSup.UseVisualStyleBackColor = true;
            this.btnEditSup.Click += new System.EventHandler(this.btnEditSup_Click);
            // 
            // btnAddSup
            // 
            this.btnAddSup.Font = new System.Drawing.Font("Arial Black", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSup.Location = new System.Drawing.Point(12, 402);
            this.btnAddSup.Name = "btnAddSup";
            this.btnAddSup.Size = new System.Drawing.Size(218, 85);
            this.btnAddSup.TabIndex = 24;
            this.btnAddSup.Text = "Add supplier";
            this.btnAddSup.UseVisualStyleBackColor = true;
            this.btnAddSup.Click += new System.EventHandler(this.btnAddSup_Click);
            // 
            // Jobs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1634, 803);
            this.Controls.Add(this.txtJobDesc);
            this.Controls.Add(this.txtJobStatus);
            this.Controls.Add(this.txtClientID);
            this.Controls.Add(this.txtJobID);
            this.Controls.Add(this.btnRemoveSup);
            this.Controls.Add(this.btnEditSup);
            this.Controls.Add(this.btnAddSup);
            this.Controls.Add(this.dgvJobs);
            this.Controls.Add(this.label1);
            this.Name = "Jobs";
            this.Text = "Jobs";
            ((System.ComponentModel.ISupportInitialize)(this.dgvJobs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvJobs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtJobDesc;
        private System.Windows.Forms.TextBox txtJobStatus;
        private System.Windows.Forms.TextBox txtClientID;
        private System.Windows.Forms.TextBox txtJobID;
        private System.Windows.Forms.Button btnRemoveSup;
        private System.Windows.Forms.Button btnEditSup;
        private System.Windows.Forms.Button btnAddSup;
    }
}