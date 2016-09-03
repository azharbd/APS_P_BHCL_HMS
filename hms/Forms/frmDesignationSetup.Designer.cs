namespace hms.Forms
{
    partial class frmDesignationSetup
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
            this.dgvDensignati = new System.Windows.Forms.DataGridView();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtdesigID = new System.Windows.Forms.TextBox();
            this.lblDeptID = new System.Windows.Forms.Label();
            this.lblname = new System.Windows.Forms.Label();
            this.lbldesigID = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.cmbDepartID = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDensignati)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDensignati
            // 
            this.dgvDensignati.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDensignati.Location = new System.Drawing.Point(6, 99);
            this.dgvDensignati.Name = "dgvDensignati";
            this.dgvDensignati.Size = new System.Drawing.Size(471, 76);
            this.dgvDensignati.TabIndex = 13;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(109, 66);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(227, 20);
            this.txtName.TabIndex = 5;
            // 
            // txtdesigID
            // 
            this.txtdesigID.Enabled = false;
            this.txtdesigID.Location = new System.Drawing.Point(109, 17);
            this.txtdesigID.Name = "txtdesigID";
            this.txtdesigID.Size = new System.Drawing.Size(93, 20);
            this.txtdesigID.TabIndex = 10;
            // 
            // lblDeptID
            // 
            this.lblDeptID.AutoSize = true;
            this.lblDeptID.Location = new System.Drawing.Point(13, 44);
            this.lblDeptID.Name = "lblDeptID";
            this.lblDeptID.Size = new System.Drawing.Size(76, 13);
            this.lblDeptID.TabIndex = 8;
            this.lblDeptID.Text = "Department ID";
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Location = new System.Drawing.Point(12, 69);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(94, 13);
            this.lblname.TabIndex = 7;
            this.lblname.Text = "Designation Name";
            // 
            // lbldesigID
            // 
            this.lbldesigID.AutoSize = true;
            this.lbldesigID.Location = new System.Drawing.Point(12, 20);
            this.lbldesigID.Name = "lbldesigID";
            this.lbldesigID.Size = new System.Drawing.Size(77, 13);
            this.lbldesigID.TabIndex = 6;
            this.lbldesigID.Text = "Designation ID";
            // 
            // btnClose
            // 
            this.btnClose.Image = global::hms.Properties.Resources.CLOSE;
            this.btnClose.Location = new System.Drawing.Point(455, -2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(23, 23);
            this.btnClose.TabIndex = 31;
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Image = global::hms.Properties.Resources.SAVE;
            this.btnSave.Location = new System.Drawing.Point(431, -2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(24, 23);
            this.btnSave.TabIndex = 29;
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnNew
            // 
            this.btnNew.Image = global::hms.Properties.Resources.ADD;
            this.btnNew.Location = new System.Drawing.Point(402, -2);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(28, 23);
            this.btnNew.TabIndex = 30;
            this.btnNew.UseVisualStyleBackColor = true;
            // 
            // cmbDepartID
            // 
            this.cmbDepartID.FormattingEnabled = true;
            this.cmbDepartID.Location = new System.Drawing.Point(109, 40);
            this.cmbDepartID.Name = "cmbDepartID";
            this.cmbDepartID.Size = new System.Drawing.Size(121, 21);
            this.cmbDepartID.TabIndex = 32;
            // 
            // frmDesignationSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 195);
            this.Controls.Add(this.cmbDepartID);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.dgvDensignati);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtdesigID);
            this.Controls.Add(this.lblDeptID);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.lbldesigID);
            this.Name = "frmDesignationSetup";
            this.Text = "frmDesignationSetup";
            this.Load += new System.EventHandler(this.frmDesignationSetup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDensignati)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDensignati;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtdesigID;
        private System.Windows.Forms.Label lblDeptID;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lbldesigID;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.ComboBox cmbDepartID;
    }
}