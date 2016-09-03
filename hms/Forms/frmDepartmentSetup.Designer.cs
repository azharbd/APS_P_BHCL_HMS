namespace hms.Forms
{
    partial class frmDepartmentSetup
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
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.rtbDeptDescription = new System.Windows.Forms.RichTextBox();
            this.lblDeptDescription = new System.Windows.Forms.Label();
            this.txtDeptName = new System.Windows.Forms.TextBox();
            this.lblDeptName = new System.Windows.Forms.Label();
            this.txtDeptID = new System.Windows.Forms.TextBox();
            this.lblDeptID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Image = global::hms.Properties.Resources.CLOSE;
            this.btnClose.Location = new System.Drawing.Point(497, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(23, 23);
            this.btnClose.TabIndex = 28;
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Image = global::hms.Properties.Resources.SAVE;
            this.btnSave.Location = new System.Drawing.Point(473, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(24, 23);
            this.btnSave.TabIndex = 26;
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnNew
            // 
            this.btnNew.Image = global::hms.Properties.Resources.ADD;
            this.btnNew.Location = new System.Drawing.Point(444, 4);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(28, 23);
            this.btnNew.TabIndex = 27;
            this.btnNew.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(23, 198);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(485, 78);
            this.dataGridView1.TabIndex = 25;
            // 
            // rtbDeptDescription
            // 
            this.rtbDeptDescription.Location = new System.Drawing.Point(129, 83);
            this.rtbDeptDescription.Name = "rtbDeptDescription";
            this.rtbDeptDescription.Size = new System.Drawing.Size(217, 63);
            this.rtbDeptDescription.TabIndex = 24;
            this.rtbDeptDescription.Text = "";
            // 
            // lblDeptDescription
            // 
            this.lblDeptDescription.AutoSize = true;
            this.lblDeptDescription.Location = new System.Drawing.Point(20, 83);
            this.lblDeptDescription.Name = "lblDeptDescription";
            this.lblDeptDescription.Size = new System.Drawing.Size(101, 13);
            this.lblDeptDescription.TabIndex = 20;
            this.lblDeptDescription.Text = "Department Descrip";
            // 
            // txtDeptName
            // 
            this.txtDeptName.Location = new System.Drawing.Point(129, 54);
            this.txtDeptName.Name = "txtDeptName";
            this.txtDeptName.Size = new System.Drawing.Size(217, 20);
            this.txtDeptName.TabIndex = 23;
            // 
            // lblDeptName
            // 
            this.lblDeptName.AutoSize = true;
            this.lblDeptName.Location = new System.Drawing.Point(20, 57);
            this.lblDeptName.Name = "lblDeptName";
            this.lblDeptName.Size = new System.Drawing.Size(93, 13);
            this.lblDeptName.TabIndex = 19;
            this.lblDeptName.Text = "Department Name";
            // 
            // txtDeptID
            // 
            this.txtDeptID.Enabled = false;
            this.txtDeptID.Location = new System.Drawing.Point(129, 28);
            this.txtDeptID.Name = "txtDeptID";
            this.txtDeptID.Size = new System.Drawing.Size(67, 20);
            this.txtDeptID.TabIndex = 22;
            // 
            // lblDeptID
            // 
            this.lblDeptID.AutoSize = true;
            this.lblDeptID.Location = new System.Drawing.Point(20, 31);
            this.lblDeptID.Name = "lblDeptID";
            this.lblDeptID.Size = new System.Drawing.Size(76, 13);
            this.lblDeptID.TabIndex = 21;
            this.lblDeptID.Text = "Department ID";
            // 
            // frmDepartmentSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 312);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.rtbDeptDescription);
            this.Controls.Add(this.lblDeptDescription);
            this.Controls.Add(this.txtDeptName);
            this.Controls.Add(this.lblDeptName);
            this.Controls.Add(this.txtDeptID);
            this.Controls.Add(this.lblDeptID);
            this.Name = "frmDepartmentSetup";
            this.Text = "frmDepartmentSetup";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RichTextBox rtbDeptDescription;
        private System.Windows.Forms.Label lblDeptDescription;
        private System.Windows.Forms.TextBox txtDeptName;
        private System.Windows.Forms.Label lblDeptName;
        private System.Windows.Forms.TextBox txtDeptID;
        private System.Windows.Forms.Label lblDeptID;
    }
}