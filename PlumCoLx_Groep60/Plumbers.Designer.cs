
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
            this.dgvPlumbers = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmpSurname = new System.Windows.Forms.TextBox();
            this.txtEmpNum = new System.Windows.Forms.TextBox();
            this.txtEmployeeName = new System.Windows.Forms.TextBox();
            this.txtEmployeeID = new System.Windows.Forms.TextBox();
            this.btnRemoveSup = new System.Windows.Forms.Button();
            this.btnEditSup = new System.Windows.Forms.Button();
            this.btnAddSup = new System.Windows.Forms.Button();
            this.txtPosition = new System.Windows.Forms.TextBox();
            this.txtEmergencyContact = new System.Windows.Forms.TextBox();
            this.txtMaritalStatus = new System.Windows.Forms.TextBox();
            this.txtMedicalHis = new System.Windows.Forms.TextBox();
            this.txtCriminalRec = new System.Windows.Forms.TextBox();
            this.txtAllergies = new System.Windows.Forms.TextBox();
            this.txtDriverLicense = new System.Windows.Forms.TextBox();
            this.txtEmpEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlumbers)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPlumbers
            // 
            this.dgvPlumbers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlumbers.Location = new System.Drawing.Point(12, 51);
            this.dgvPlumbers.Name = "dgvPlumbers";
            this.dgvPlumbers.RowHeadersWidth = 51;
            this.dgvPlumbers.RowTemplate.Height = 24;
            this.dgvPlumbers.Size = new System.Drawing.Size(1576, 240);
            this.dgvPlumbers.TabIndex = 11;
            this.dgvPlumbers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPlumbers_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 27);
            this.label1.TabIndex = 10;
            this.label1.Text = "Plumbers:";
            // 
            // txtEmpSurname
            // 
            this.txtEmpSurname.Font = new System.Drawing.Font("Arial Black", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpSurname.Location = new System.Drawing.Point(236, 471);
            this.txtEmpSurname.Name = "txtEmpSurname";
            this.txtEmpSurname.Size = new System.Drawing.Size(218, 26);
            this.txtEmpSurname.TabIndex = 39;
            this.txtEmpSurname.Text = "Surname";
            // 
            // txtEmpNum
            // 
            this.txtEmpNum.Font = new System.Drawing.Font("Arial Black", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpNum.Location = new System.Drawing.Point(236, 499);
            this.txtEmpNum.Name = "txtEmpNum";
            this.txtEmpNum.Size = new System.Drawing.Size(218, 26);
            this.txtEmpNum.TabIndex = 38;
            this.txtEmpNum.Text = "Phone Number";
            // 
            // txtEmployeeName
            // 
            this.txtEmployeeName.Font = new System.Drawing.Font("Arial Black", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmployeeName.Location = new System.Drawing.Point(236, 443);
            this.txtEmployeeName.Name = "txtEmployeeName";
            this.txtEmployeeName.Size = new System.Drawing.Size(218, 26);
            this.txtEmployeeName.TabIndex = 37;
            this.txtEmployeeName.Text = "Name";
            // 
            // txtEmployeeID
            // 
            this.txtEmployeeID.Font = new System.Drawing.Font("Arial Black", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmployeeID.Location = new System.Drawing.Point(236, 415);
            this.txtEmployeeID.Name = "txtEmployeeID";
            this.txtEmployeeID.Size = new System.Drawing.Size(218, 26);
            this.txtEmployeeID.TabIndex = 36;
            this.txtEmployeeID.Text = "Employee ID";
            // 
            // btnRemoveSup
            // 
            this.btnRemoveSup.Font = new System.Drawing.Font("Arial Black", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveSup.Location = new System.Drawing.Point(236, 297);
            this.btnRemoveSup.Name = "btnRemoveSup";
            this.btnRemoveSup.Size = new System.Drawing.Size(218, 85);
            this.btnRemoveSup.TabIndex = 35;
            this.btnRemoveSup.Text = "Remove supplier";
            this.btnRemoveSup.UseVisualStyleBackColor = true;
            this.btnRemoveSup.Click += new System.EventHandler(this.btnRemoveSup_Click);
            // 
            // btnEditSup
            // 
            this.btnEditSup.Font = new System.Drawing.Font("Arial Black", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditSup.Location = new System.Drawing.Point(12, 415);
            this.btnEditSup.Name = "btnEditSup";
            this.btnEditSup.Size = new System.Drawing.Size(218, 88);
            this.btnEditSup.TabIndex = 34;
            this.btnEditSup.Text = "Edit Supplier";
            this.btnEditSup.UseVisualStyleBackColor = true;
            this.btnEditSup.Click += new System.EventHandler(this.btnEditSup_Click);
            // 
            // btnAddSup
            // 
            this.btnAddSup.Font = new System.Drawing.Font("Arial Black", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSup.Location = new System.Drawing.Point(12, 297);
            this.btnAddSup.Name = "btnAddSup";
            this.btnAddSup.Size = new System.Drawing.Size(218, 85);
            this.btnAddSup.TabIndex = 33;
            this.btnAddSup.Text = "Add supplier";
            this.btnAddSup.UseVisualStyleBackColor = true;
            this.btnAddSup.Click += new System.EventHandler(this.btnAddSup_Click);
            // 
            // txtPosition
            // 
            this.txtPosition.Font = new System.Drawing.Font("Arial Black", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPosition.Location = new System.Drawing.Point(460, 563);
            this.txtPosition.Name = "txtPosition";
            this.txtPosition.Size = new System.Drawing.Size(218, 26);
            this.txtPosition.TabIndex = 40;
            this.txtPosition.Text = "Position";
            // 
            // txtEmergencyContact
            // 
            this.txtEmergencyContact.Font = new System.Drawing.Font("Arial Black", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmergencyContact.Location = new System.Drawing.Point(460, 531);
            this.txtEmergencyContact.Name = "txtEmergencyContact";
            this.txtEmergencyContact.Size = new System.Drawing.Size(218, 26);
            this.txtEmergencyContact.TabIndex = 41;
            this.txtEmergencyContact.Text = "Emergency Contact";
            // 
            // txtMaritalStatus
            // 
            this.txtMaritalStatus.Font = new System.Drawing.Font("Arial Black", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaritalStatus.Location = new System.Drawing.Point(460, 499);
            this.txtMaritalStatus.Name = "txtMaritalStatus";
            this.txtMaritalStatus.Size = new System.Drawing.Size(218, 26);
            this.txtMaritalStatus.TabIndex = 42;
            this.txtMaritalStatus.Text = "Marital Status";
            // 
            // txtMedicalHis
            // 
            this.txtMedicalHis.Font = new System.Drawing.Font("Arial Black", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMedicalHis.Location = new System.Drawing.Point(460, 471);
            this.txtMedicalHis.Name = "txtMedicalHis";
            this.txtMedicalHis.Size = new System.Drawing.Size(218, 26);
            this.txtMedicalHis.TabIndex = 43;
            this.txtMedicalHis.Text = "Medical History";
            // 
            // txtCriminalRec
            // 
            this.txtCriminalRec.Font = new System.Drawing.Font("Arial Black", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCriminalRec.Location = new System.Drawing.Point(460, 443);
            this.txtCriminalRec.Name = "txtCriminalRec";
            this.txtCriminalRec.Size = new System.Drawing.Size(218, 26);
            this.txtCriminalRec.TabIndex = 44;
            this.txtCriminalRec.Text = "Criminal Record";
            // 
            // txtAllergies
            // 
            this.txtAllergies.Font = new System.Drawing.Font("Arial Black", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAllergies.Location = new System.Drawing.Point(460, 415);
            this.txtAllergies.Name = "txtAllergies";
            this.txtAllergies.Size = new System.Drawing.Size(218, 26);
            this.txtAllergies.TabIndex = 45;
            this.txtAllergies.Text = "Allergies";
            // 
            // txtDriverLicense
            // 
            this.txtDriverLicense.Font = new System.Drawing.Font("Arial Black", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDriverLicense.Location = new System.Drawing.Point(236, 563);
            this.txtDriverLicense.Name = "txtDriverLicense";
            this.txtDriverLicense.Size = new System.Drawing.Size(218, 26);
            this.txtDriverLicense.TabIndex = 46;
            this.txtDriverLicense.Text = "Drivers License";
            // 
            // txtEmpEmail
            // 
            this.txtEmpEmail.Font = new System.Drawing.Font("Arial Black", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpEmail.Location = new System.Drawing.Point(236, 531);
            this.txtEmpEmail.Name = "txtEmpEmail";
            this.txtEmpEmail.Size = new System.Drawing.Size(218, 26);
            this.txtEmpEmail.TabIndex = 47;
            this.txtEmpEmail.Text = "Email Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(696, 415);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(455, 22);
            this.label2.TabIndex = 48;
            this.label2.Text = "To add a record insert information into the textboxes.";
            // 
            // Plumbers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1611, 801);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtEmpEmail);
            this.Controls.Add(this.txtDriverLicense);
            this.Controls.Add(this.txtAllergies);
            this.Controls.Add(this.txtCriminalRec);
            this.Controls.Add(this.txtMedicalHis);
            this.Controls.Add(this.txtMaritalStatus);
            this.Controls.Add(this.txtEmergencyContact);
            this.Controls.Add(this.txtPosition);
            this.Controls.Add(this.txtEmpSurname);
            this.Controls.Add(this.txtEmpNum);
            this.Controls.Add(this.txtEmployeeName);
            this.Controls.Add(this.txtEmployeeID);
            this.Controls.Add(this.btnRemoveSup);
            this.Controls.Add(this.btnEditSup);
            this.Controls.Add(this.btnAddSup);
            this.Controls.Add(this.dgvPlumbers);
            this.Controls.Add(this.label1);
            this.Name = "Plumbers";
            this.Text = "Plumbers";
            this.Load += new System.EventHandler(this.Plumbers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlumbers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvPlumbers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEmpSurname;
        private System.Windows.Forms.TextBox txtEmpNum;
        private System.Windows.Forms.TextBox txtEmployeeName;
        private System.Windows.Forms.TextBox txtEmployeeID;
        private System.Windows.Forms.Button btnRemoveSup;
        private System.Windows.Forms.Button btnEditSup;
        private System.Windows.Forms.Button btnAddSup;
        private System.Windows.Forms.TextBox txtPosition;
        private System.Windows.Forms.TextBox txtEmergencyContact;
        private System.Windows.Forms.TextBox txtMaritalStatus;
        private System.Windows.Forms.TextBox txtMedicalHis;
        private System.Windows.Forms.TextBox txtCriminalRec;
        private System.Windows.Forms.TextBox txtAllergies;
        private System.Windows.Forms.TextBox txtDriverLicense;
        private System.Windows.Forms.TextBox txtEmpEmail;
        private System.Windows.Forms.Label label2;
    }
}