
namespace PlumCoLx_Groep60
{
    partial class Equipment
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
            this.dgvEquipment = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddSup = new System.Windows.Forms.Button();
            this.btnEditSup = new System.Windows.Forms.Button();
            this.btnRemoveSup = new System.Windows.Forms.Button();
            this.txtEquipmentID = new System.Windows.Forms.TextBox();
            this.txtEquipmentPrice = new System.Windows.Forms.TextBox();
            this.txtEquipmentStatus = new System.Windows.Forms.TextBox();
            this.txtEquipmentName = new System.Windows.Forms.TextBox();
            this.txtEquipmentDesc = new System.Windows.Forms.TextBox();
            this.txtEquipmentType = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquipment)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEquipment
            // 
            this.dgvEquipment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEquipment.Location = new System.Drawing.Point(12, 67);
            this.dgvEquipment.Name = "dgvEquipment";
            this.dgvEquipment.RowHeadersWidth = 51;
            this.dgvEquipment.RowTemplate.Height = 24;
            this.dgvEquipment.Size = new System.Drawing.Size(1330, 278);
            this.dgvEquipment.TabIndex = 0;
            this.dgvEquipment.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEquipment_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "Equipment:";
            // 
            // btnAddSup
            // 
            this.btnAddSup.Font = new System.Drawing.Font("Arial Black", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSup.Location = new System.Drawing.Point(12, 351);
            this.btnAddSup.Name = "btnAddSup";
            this.btnAddSup.Size = new System.Drawing.Size(218, 85);
            this.btnAddSup.TabIndex = 4;
            this.btnAddSup.Text = "Add supplier";
            this.btnAddSup.UseVisualStyleBackColor = true;
            this.btnAddSup.Click += new System.EventHandler(this.btnAddSup_Click);
            // 
            // btnEditSup
            // 
            this.btnEditSup.Font = new System.Drawing.Font("Arial Black", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditSup.Location = new System.Drawing.Point(12, 469);
            this.btnEditSup.Name = "btnEditSup";
            this.btnEditSup.Size = new System.Drawing.Size(218, 88);
            this.btnEditSup.TabIndex = 5;
            this.btnEditSup.Text = "Edit Supplier";
            this.btnEditSup.UseVisualStyleBackColor = true;
            this.btnEditSup.Click += new System.EventHandler(this.btnEditSup_Click);
            // 
            // btnRemoveSup
            // 
            this.btnRemoveSup.Font = new System.Drawing.Font("Arial Black", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveSup.Location = new System.Drawing.Point(236, 351);
            this.btnRemoveSup.Name = "btnRemoveSup";
            this.btnRemoveSup.Size = new System.Drawing.Size(218, 85);
            this.btnRemoveSup.TabIndex = 6;
            this.btnRemoveSup.Text = "Remove supplier";
            this.btnRemoveSup.UseVisualStyleBackColor = true;
            this.btnRemoveSup.Click += new System.EventHandler(this.btnRemoveSup_Click);
            // 
            // txtEquipmentID
            // 
            this.txtEquipmentID.Font = new System.Drawing.Font("Arial Black", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEquipmentID.Location = new System.Drawing.Point(236, 469);
            this.txtEquipmentID.Name = "txtEquipmentID";
            this.txtEquipmentID.Size = new System.Drawing.Size(218, 26);
            this.txtEquipmentID.TabIndex = 7;
            this.txtEquipmentID.Text = "ID";
            // 
            // txtEquipmentPrice
            // 
            this.txtEquipmentPrice.Font = new System.Drawing.Font("Arial Black", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEquipmentPrice.Location = new System.Drawing.Point(236, 497);
            this.txtEquipmentPrice.Name = "txtEquipmentPrice";
            this.txtEquipmentPrice.Size = new System.Drawing.Size(218, 26);
            this.txtEquipmentPrice.TabIndex = 8;
            this.txtEquipmentPrice.Text = "Price";
            // 
            // txtEquipmentStatus
            // 
            this.txtEquipmentStatus.Font = new System.Drawing.Font("Arial Black", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEquipmentStatus.Location = new System.Drawing.Point(236, 609);
            this.txtEquipmentStatus.Name = "txtEquipmentStatus";
            this.txtEquipmentStatus.Size = new System.Drawing.Size(218, 26);
            this.txtEquipmentStatus.TabIndex = 9;
            this.txtEquipmentStatus.Text = "Status";
            // 
            // txtEquipmentName
            // 
            this.txtEquipmentName.Font = new System.Drawing.Font("Arial Black", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEquipmentName.Location = new System.Drawing.Point(236, 581);
            this.txtEquipmentName.Name = "txtEquipmentName";
            this.txtEquipmentName.Size = new System.Drawing.Size(218, 26);
            this.txtEquipmentName.TabIndex = 10;
            this.txtEquipmentName.Text = "Name";
            // 
            // txtEquipmentDesc
            // 
            this.txtEquipmentDesc.Font = new System.Drawing.Font("Arial Black", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEquipmentDesc.Location = new System.Drawing.Point(236, 553);
            this.txtEquipmentDesc.Name = "txtEquipmentDesc";
            this.txtEquipmentDesc.Size = new System.Drawing.Size(218, 26);
            this.txtEquipmentDesc.TabIndex = 11;
            this.txtEquipmentDesc.Text = "Description";
            // 
            // txtEquipmentType
            // 
            this.txtEquipmentType.Font = new System.Drawing.Font("Arial Black", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEquipmentType.Location = new System.Drawing.Point(236, 525);
            this.txtEquipmentType.Name = "txtEquipmentType";
            this.txtEquipmentType.Size = new System.Drawing.Size(218, 26);
            this.txtEquipmentType.TabIndex = 12;
            this.txtEquipmentType.Text = "Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(482, 469);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(569, 28);
            this.label2.TabIndex = 13;
            this.label2.Text = "To add a record insert information into the textboxes.";
            // 
            // Equipment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1597, 800);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtEquipmentType);
            this.Controls.Add(this.txtEquipmentDesc);
            this.Controls.Add(this.txtEquipmentName);
            this.Controls.Add(this.txtEquipmentStatus);
            this.Controls.Add(this.txtEquipmentPrice);
            this.Controls.Add(this.txtEquipmentID);
            this.Controls.Add(this.btnRemoveSup);
            this.Controls.Add(this.btnEditSup);
            this.Controls.Add(this.btnAddSup);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvEquipment);
            this.Name = "Equipment";
            this.Text = "Equipment";
            this.Load += new System.EventHandler(this.Equipment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquipment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEquipment;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddSup;
        private System.Windows.Forms.Button btnEditSup;
        private System.Windows.Forms.Button btnRemoveSup;
        private System.Windows.Forms.TextBox txtEquipmentID;
        private System.Windows.Forms.TextBox txtEquipmentPrice;
        private System.Windows.Forms.TextBox txtEquipmentStatus;
        private System.Windows.Forms.TextBox txtEquipmentName;
        private System.Windows.Forms.TextBox txtEquipmentDesc;
        private System.Windows.Forms.TextBox txtEquipmentType;
        private System.Windows.Forms.Label label2;
    }
}