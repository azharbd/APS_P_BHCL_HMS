namespace hms.Forms
{
    partial class frmEmployeeProfile
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
            this.grpSalaryInfo = new System.Windows.Forms.GroupBox();
            this.chkIsCommession = new System.Windows.Forms.CheckBox();
            this.txtBasic = new System.Windows.Forms.TextBox();
            this.lblBasic = new System.Windows.Forms.Label();
            this.chkParmanent = new System.Windows.Forms.CheckBox();
            this.gbPersonalInfo = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblemployeetype = new System.Windows.Forms.Label();
            this.txtgender = new System.Windows.Forms.TextBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.cmbDesignation = new System.Windows.Forms.ComboBox();
            this.btnDesignation = new System.Windows.Forms.Button();
            this.btnDept = new System.Windows.Forms.Button();
            this.cmbDepartment = new System.Windows.Forms.ComboBox();
            this.dtpDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.dtpJoinDate = new System.Windows.Forms.DateTimePicker();
            this.rtbParmanentAddress = new System.Windows.Forms.RichTextBox();
            this.rtbPresentAddress = new System.Windows.Forms.RichTextBox();
            this.lblParmanentAddress = new System.Windows.Forms.Label();
            this.txtBloodGroup = new System.Windows.Forms.TextBox();
            this.txtMobileNo = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblDateOfJoin = new System.Windows.Forms.Label();
            this.lblJoinDate = new System.Windows.Forms.Label();
            this.txtEmployeeName = new System.Windows.Forms.TextBox();
            this.lblBloodGroup = new System.Windows.Forms.Label();
            this.lblDesignation = new System.Windows.Forms.Label();
            this.lblEmployeeMobile = new System.Windows.Forms.Label();
            this.lblEmployeeName = new System.Windows.Forms.Label();
            this.txtMotherName = new System.Windows.Forms.TextBox();
            this.lblMotherName = new System.Windows.Forms.Label();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.txtFatherName = new System.Windows.Forms.TextBox();
            this.lblFatherName = new System.Windows.Forms.Label();
            this.txtEmpployeeID = new System.Windows.Forms.TextBox();
            this.lblEmployeeID = new System.Windows.Forms.Label();
            this.grpSalaryInfo.SuspendLayout();
            this.gbPersonalInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpSalaryInfo
            // 
            this.grpSalaryInfo.Controls.Add(this.chkIsCommession);
            this.grpSalaryInfo.Controls.Add(this.txtBasic);
            this.grpSalaryInfo.Controls.Add(this.lblBasic);
            this.grpSalaryInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpSalaryInfo.Location = new System.Drawing.Point(29, 359);
            this.grpSalaryInfo.Name = "grpSalaryInfo";
            this.grpSalaryInfo.Size = new System.Drawing.Size(760, 116);
            this.grpSalaryInfo.TabIndex = 4;
            this.grpSalaryInfo.TabStop = false;
            this.grpSalaryInfo.Text = "Salary Information";
            // 
            // chkIsCommession
            // 
            this.chkIsCommession.AutoSize = true;
            this.chkIsCommession.Location = new System.Drawing.Point(388, 53);
            this.chkIsCommession.Name = "chkIsCommession";
            this.chkIsCommession.Size = new System.Drawing.Size(121, 21);
            this.chkIsCommession.TabIndex = 6;
            this.chkIsCommession.Text = "Is Commession";
            this.chkIsCommession.UseVisualStyleBackColor = true;
            // 
            // txtBasic
            // 
            this.txtBasic.Location = new System.Drawing.Point(126, 51);
            this.txtBasic.Name = "txtBasic";
            this.txtBasic.Size = new System.Drawing.Size(247, 23);
            this.txtBasic.TabIndex = 5;
            // 
            // lblBasic
            // 
            this.lblBasic.AutoSize = true;
            this.lblBasic.Location = new System.Drawing.Point(7, 51);
            this.lblBasic.Name = "lblBasic";
            this.lblBasic.Size = new System.Drawing.Size(42, 17);
            this.lblBasic.TabIndex = 0;
            this.lblBasic.Text = "Basic";
            // 
            // chkParmanent
            // 
            this.chkParmanent.AutoSize = true;
            this.chkParmanent.Location = new System.Drawing.Point(576, 88);
            this.chkParmanent.Name = "chkParmanent";
            this.chkParmanent.Size = new System.Drawing.Size(96, 21);
            this.chkParmanent.TabIndex = 2;
            this.chkParmanent.Text = "Parmanent";
            this.chkParmanent.UseVisualStyleBackColor = true;
            // 
            // gbPersonalInfo
            // 
            this.gbPersonalInfo.Controls.Add(this.comboBox1);
            this.gbPersonalInfo.Controls.Add(this.chkParmanent);
            this.gbPersonalInfo.Controls.Add(this.lblemployeetype);
            this.gbPersonalInfo.Controls.Add(this.txtgender);
            this.gbPersonalInfo.Controls.Add(this.lblGender);
            this.gbPersonalInfo.Controls.Add(this.cmbDesignation);
            this.gbPersonalInfo.Controls.Add(this.btnDesignation);
            this.gbPersonalInfo.Controls.Add(this.btnDept);
            this.gbPersonalInfo.Controls.Add(this.cmbDepartment);
            this.gbPersonalInfo.Controls.Add(this.dtpDateOfBirth);
            this.gbPersonalInfo.Controls.Add(this.dtpJoinDate);
            this.gbPersonalInfo.Controls.Add(this.rtbParmanentAddress);
            this.gbPersonalInfo.Controls.Add(this.rtbPresentAddress);
            this.gbPersonalInfo.Controls.Add(this.lblParmanentAddress);
            this.gbPersonalInfo.Controls.Add(this.txtBloodGroup);
            this.gbPersonalInfo.Controls.Add(this.txtMobileNo);
            this.gbPersonalInfo.Controls.Add(this.lblAddress);
            this.gbPersonalInfo.Controls.Add(this.lblDateOfJoin);
            this.gbPersonalInfo.Controls.Add(this.lblJoinDate);
            this.gbPersonalInfo.Controls.Add(this.txtEmployeeName);
            this.gbPersonalInfo.Controls.Add(this.lblBloodGroup);
            this.gbPersonalInfo.Controls.Add(this.lblDesignation);
            this.gbPersonalInfo.Controls.Add(this.lblEmployeeMobile);
            this.gbPersonalInfo.Controls.Add(this.lblEmployeeName);
            this.gbPersonalInfo.Controls.Add(this.txtMotherName);
            this.gbPersonalInfo.Controls.Add(this.lblMotherName);
            this.gbPersonalInfo.Controls.Add(this.lblDepartment);
            this.gbPersonalInfo.Controls.Add(this.txtFatherName);
            this.gbPersonalInfo.Controls.Add(this.lblFatherName);
            this.gbPersonalInfo.Controls.Add(this.txtEmpployeeID);
            this.gbPersonalInfo.Controls.Add(this.lblEmployeeID);
            this.gbPersonalInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPersonalInfo.Location = new System.Drawing.Point(29, 34);
            this.gbPersonalInfo.Name = "gbPersonalInfo";
            this.gbPersonalInfo.Size = new System.Drawing.Size(760, 319);
            this.gbPersonalInfo.TabIndex = 3;
            this.gbPersonalInfo.TabStop = false;
            this.gbPersonalInfo.Text = "Personal Information";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(576, 49);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(150, 24);
            this.comboBox1.TabIndex = 19;
            // 
            // lblemployeetype
            // 
            this.lblemployeetype.AutoSize = true;
            this.lblemployeetype.Location = new System.Drawing.Point(437, 49);
            this.lblemployeetype.Name = "lblemployeetype";
            this.lblemployeetype.Size = new System.Drawing.Size(106, 17);
            this.lblemployeetype.TabIndex = 18;
            this.lblemployeetype.Text = "Employee Type";
            // 
            // txtgender
            // 
            this.txtgender.Location = new System.Drawing.Point(264, 150);
            this.txtgender.Name = "txtgender";
            this.txtgender.Size = new System.Drawing.Size(108, 23);
            this.txtgender.TabIndex = 17;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(196, 152);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(56, 17);
            this.lblGender.TabIndex = 16;
            this.lblGender.Text = "Gender";
            // 
            // cmbDesignation
            // 
            this.cmbDesignation.FormattingEnabled = true;
            this.cmbDesignation.Location = new System.Drawing.Point(126, 94);
            this.cmbDesignation.Name = "cmbDesignation";
            this.cmbDesignation.Size = new System.Drawing.Size(204, 24);
            this.cmbDesignation.TabIndex = 15;
            // 
            // btnDesignation
            // 
            this.btnDesignation.Location = new System.Drawing.Point(334, 94);
            this.btnDesignation.Name = "btnDesignation";
            this.btnDesignation.Size = new System.Drawing.Size(26, 23);
            this.btnDesignation.TabIndex = 14;
            this.btnDesignation.Text = "+";
            this.btnDesignation.UseVisualStyleBackColor = true;
            // 
            // btnDept
            // 
            this.btnDept.Location = new System.Drawing.Point(731, 20);
            this.btnDept.Name = "btnDept";
            this.btnDept.Size = new System.Drawing.Size(23, 23);
            this.btnDept.TabIndex = 6;
            this.btnDept.Text = "+";
            this.btnDept.UseVisualStyleBackColor = true;
            // 
            // cmbDepartment
            // 
            this.cmbDepartment.FormattingEnabled = true;
            this.cmbDepartment.Location = new System.Drawing.Point(575, 20);
            this.cmbDepartment.Name = "cmbDepartment";
            this.cmbDepartment.Size = new System.Drawing.Size(150, 24);
            this.cmbDepartment.TabIndex = 8;
            // 
            // dtpDateOfBirth
            // 
            this.dtpDateOfBirth.Location = new System.Drawing.Point(575, 124);
            this.dtpDateOfBirth.Name = "dtpDateOfBirth";
            this.dtpDateOfBirth.Size = new System.Drawing.Size(179, 23);
            this.dtpDateOfBirth.TabIndex = 10;
            // 
            // dtpJoinDate
            // 
            this.dtpJoinDate.Location = new System.Drawing.Point(126, 121);
            this.dtpJoinDate.Name = "dtpJoinDate";
            this.dtpJoinDate.Size = new System.Drawing.Size(247, 23);
            this.dtpJoinDate.TabIndex = 3;
            // 
            // rtbParmanentAddress
            // 
            this.rtbParmanentAddress.Location = new System.Drawing.Point(575, 206);
            this.rtbParmanentAddress.Name = "rtbParmanentAddress";
            this.rtbParmanentAddress.Size = new System.Drawing.Size(179, 79);
            this.rtbParmanentAddress.TabIndex = 13;
            this.rtbParmanentAddress.Text = "";
            // 
            // rtbPresentAddress
            // 
            this.rtbPresentAddress.Location = new System.Drawing.Point(126, 210);
            this.rtbPresentAddress.Name = "rtbPresentAddress";
            this.rtbPresentAddress.Size = new System.Drawing.Size(247, 77);
            this.rtbPresentAddress.TabIndex = 7;
            this.rtbPresentAddress.Text = "";
            // 
            // lblParmanentAddress
            // 
            this.lblParmanentAddress.AutoSize = true;
            this.lblParmanentAddress.Location = new System.Drawing.Point(436, 209);
            this.lblParmanentAddress.Name = "lblParmanentAddress";
            this.lblParmanentAddress.Size = new System.Drawing.Size(133, 17);
            this.lblParmanentAddress.TabIndex = 0;
            this.lblParmanentAddress.Text = "Parmanent Address";
            // 
            // txtBloodGroup
            // 
            this.txtBloodGroup.Location = new System.Drawing.Point(126, 149);
            this.txtBloodGroup.Name = "txtBloodGroup";
            this.txtBloodGroup.Size = new System.Drawing.Size(55, 23);
            this.txtBloodGroup.TabIndex = 5;
            // 
            // txtMobileNo
            // 
            this.txtMobileNo.Location = new System.Drawing.Point(126, 178);
            this.txtMobileNo.Name = "txtMobileNo";
            this.txtMobileNo.Size = new System.Drawing.Size(179, 23);
            this.txtMobileNo.TabIndex = 6;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(7, 209);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(113, 17);
            this.lblAddress.TabIndex = 0;
            this.lblAddress.Text = "Present Address";
            // 
            // lblDateOfJoin
            // 
            this.lblDateOfJoin.AutoSize = true;
            this.lblDateOfJoin.Location = new System.Drawing.Point(432, 122);
            this.lblDateOfJoin.Name = "lblDateOfJoin";
            this.lblDateOfJoin.Size = new System.Drawing.Size(87, 17);
            this.lblDateOfJoin.TabIndex = 0;
            this.lblDateOfJoin.Text = "Date of Birth";
            // 
            // lblJoinDate
            // 
            this.lblJoinDate.AutoSize = true;
            this.lblJoinDate.Location = new System.Drawing.Point(7, 121);
            this.lblJoinDate.Name = "lblJoinDate";
            this.lblJoinDate.Size = new System.Drawing.Size(84, 17);
            this.lblJoinDate.TabIndex = 0;
            this.lblJoinDate.Text = "Date of Join";
            // 
            // txtEmployeeName
            // 
            this.txtEmployeeName.Location = new System.Drawing.Point(126, 63);
            this.txtEmployeeName.Name = "txtEmployeeName";
            this.txtEmployeeName.Size = new System.Drawing.Size(247, 23);
            this.txtEmployeeName.TabIndex = 1;
            // 
            // lblBloodGroup
            // 
            this.lblBloodGroup.AutoSize = true;
            this.lblBloodGroup.Location = new System.Drawing.Point(7, 149);
            this.lblBloodGroup.Name = "lblBloodGroup";
            this.lblBloodGroup.Size = new System.Drawing.Size(88, 17);
            this.lblBloodGroup.TabIndex = 0;
            this.lblBloodGroup.Text = "Blood Group";
            // 
            // lblDesignation
            // 
            this.lblDesignation.AutoSize = true;
            this.lblDesignation.Location = new System.Drawing.Point(7, 92);
            this.lblDesignation.Name = "lblDesignation";
            this.lblDesignation.Size = new System.Drawing.Size(83, 17);
            this.lblDesignation.TabIndex = 0;
            this.lblDesignation.Text = "Designation";
            // 
            // lblEmployeeMobile
            // 
            this.lblEmployeeMobile.AutoSize = true;
            this.lblEmployeeMobile.Location = new System.Drawing.Point(7, 178);
            this.lblEmployeeMobile.Name = "lblEmployeeMobile";
            this.lblEmployeeMobile.Size = new System.Drawing.Size(75, 17);
            this.lblEmployeeMobile.TabIndex = 0;
            this.lblEmployeeMobile.Text = "Mobile No.";
            // 
            // lblEmployeeName
            // 
            this.lblEmployeeName.AutoSize = true;
            this.lblEmployeeName.Location = new System.Drawing.Point(7, 63);
            this.lblEmployeeName.Name = "lblEmployeeName";
            this.lblEmployeeName.Size = new System.Drawing.Size(45, 17);
            this.lblEmployeeName.TabIndex = 0;
            this.lblEmployeeName.Text = "Name";
            // 
            // txtMotherName
            // 
            this.txtMotherName.Location = new System.Drawing.Point(575, 178);
            this.txtMotherName.Name = "txtMotherName";
            this.txtMotherName.Size = new System.Drawing.Size(179, 23);
            this.txtMotherName.TabIndex = 12;
            // 
            // lblMotherName
            // 
            this.lblMotherName.AutoSize = true;
            this.lblMotherName.Location = new System.Drawing.Point(436, 178);
            this.lblMotherName.Name = "lblMotherName";
            this.lblMotherName.Size = new System.Drawing.Size(93, 17);
            this.lblMotherName.TabIndex = 0;
            this.lblMotherName.Text = "Mother Name";
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Location = new System.Drawing.Point(436, 20);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(82, 17);
            this.lblDepartment.TabIndex = 0;
            this.lblDepartment.Text = "Department";
            // 
            // txtFatherName
            // 
            this.txtFatherName.Location = new System.Drawing.Point(575, 149);
            this.txtFatherName.Name = "txtFatherName";
            this.txtFatherName.Size = new System.Drawing.Size(179, 23);
            this.txtFatherName.TabIndex = 11;
            // 
            // lblFatherName
            // 
            this.lblFatherName.AutoSize = true;
            this.lblFatherName.Location = new System.Drawing.Point(436, 149);
            this.lblFatherName.Name = "lblFatherName";
            this.lblFatherName.Size = new System.Drawing.Size(90, 17);
            this.lblFatherName.TabIndex = 0;
            this.lblFatherName.Text = "Father Name";
            // 
            // txtEmpployeeID
            // 
            this.txtEmpployeeID.Enabled = false;
            this.txtEmpployeeID.Location = new System.Drawing.Point(126, 34);
            this.txtEmpployeeID.Name = "txtEmpployeeID";
            this.txtEmpployeeID.Size = new System.Drawing.Size(179, 23);
            this.txtEmpployeeID.TabIndex = 0;
            // 
            // lblEmployeeID
            // 
            this.lblEmployeeID.AutoSize = true;
            this.lblEmployeeID.Location = new System.Drawing.Point(7, 34);
            this.lblEmployeeID.Name = "lblEmployeeID";
            this.lblEmployeeID.Size = new System.Drawing.Size(87, 17);
            this.lblEmployeeID.TabIndex = 0;
            this.lblEmployeeID.Text = "Employee ID";
            // 
            // frmEmployeeProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 491);
            this.Controls.Add(this.grpSalaryInfo);
            this.Controls.Add(this.gbPersonalInfo);
            this.Name = "frmEmployeeProfile";
            this.Text = "frmEmployeeProfile";
            this.Load += new System.EventHandler(this.frmEmployeeProfile_Load);
            this.grpSalaryInfo.ResumeLayout(false);
            this.grpSalaryInfo.PerformLayout();
            this.gbPersonalInfo.ResumeLayout(false);
            this.gbPersonalInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpSalaryInfo;
        private System.Windows.Forms.CheckBox chkParmanent;
        private System.Windows.Forms.TextBox txtBasic;
        private System.Windows.Forms.Label lblBasic;
        private System.Windows.Forms.GroupBox gbPersonalInfo;
        private System.Windows.Forms.ComboBox cmbDesignation;
        private System.Windows.Forms.Button btnDesignation;
        private System.Windows.Forms.Button btnDept;
        private System.Windows.Forms.ComboBox cmbDepartment;
        private System.Windows.Forms.DateTimePicker dtpDateOfBirth;
        private System.Windows.Forms.DateTimePicker dtpJoinDate;
        private System.Windows.Forms.RichTextBox rtbParmanentAddress;
        private System.Windows.Forms.RichTextBox rtbPresentAddress;
        private System.Windows.Forms.Label lblParmanentAddress;
        private System.Windows.Forms.TextBox txtBloodGroup;
        private System.Windows.Forms.TextBox txtMobileNo;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblDateOfJoin;
        private System.Windows.Forms.Label lblJoinDate;
        private System.Windows.Forms.TextBox txtEmployeeName;
        private System.Windows.Forms.Label lblBloodGroup;
        private System.Windows.Forms.Label lblDesignation;
        private System.Windows.Forms.Label lblEmployeeMobile;
        private System.Windows.Forms.Label lblEmployeeName;
        private System.Windows.Forms.TextBox txtMotherName;
        private System.Windows.Forms.Label lblMotherName;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.TextBox txtFatherName;
        private System.Windows.Forms.Label lblFatherName;
        private System.Windows.Forms.TextBox txtEmpployeeID;
        private System.Windows.Forms.Label lblEmployeeID;
        private System.Windows.Forms.TextBox txtgender;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.CheckBox chkIsCommession;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblemployeetype;
    }
}