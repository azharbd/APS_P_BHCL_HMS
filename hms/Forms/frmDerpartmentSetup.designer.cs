namespace hms.Forms
{
    partial class frmDerpartmentSetup
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.rtbDeptDes = new System.Windows.Forms.RichTextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtDeptName = new System.Windows.Forms.TextBox();
            this.lblDeptName = new System.Windows.Forms.Label();
            this.txtDeptID = new System.Windows.Forms.TextBox();
            this.lblDeptID = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 195);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(485, 124);
            this.dataGridView1.TabIndex = 26;
            // 
            // rtbDeptDes
            // 
            this.rtbDeptDes.Location = new System.Drawing.Point(121, 126);
            this.rtbDeptDes.Name = "rtbDeptDes";
            this.rtbDeptDes.Size = new System.Drawing.Size(217, 63);
            this.rtbDeptDes.TabIndex = 25;
            this.rtbDeptDes.Text = "";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(12, 150);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(84, 13);
            this.lblDescription.TabIndex = 20;
            this.lblDescription.Text = "Department Des";
            // 
            // txtDeptName
            // 
            this.txtDeptName.Location = new System.Drawing.Point(121, 97);
            this.txtDeptName.Name = "txtDeptName";
            this.txtDeptName.Size = new System.Drawing.Size(217, 20);
            this.txtDeptName.TabIndex = 24;
            // 
            // lblDeptName
            // 
            this.lblDeptName.AutoSize = true;
            this.lblDeptName.Location = new System.Drawing.Point(12, 100);
            this.lblDeptName.Name = "lblDeptName";
            this.lblDeptName.Size = new System.Drawing.Size(93, 13);
            this.lblDeptName.TabIndex = 21;
            this.lblDeptName.Text = "Department Name";
            // 
            // txtDeptID
            // 
            this.txtDeptID.Enabled = false;
            this.txtDeptID.Location = new System.Drawing.Point(121, 71);
            this.txtDeptID.Name = "txtDeptID";
            this.txtDeptID.Size = new System.Drawing.Size(67, 20);
            this.txtDeptID.TabIndex = 23;
            // 
            // lblDeptID
            // 
            this.lblDeptID.AutoSize = true;
            this.lblDeptID.Location = new System.Drawing.Point(12, 74);
            this.lblDeptID.Name = "lblDeptID";
            this.lblDeptID.Size = new System.Drawing.Size(76, 13);
            this.lblDeptID.TabIndex = 22;
            this.lblDeptID.Text = "Department ID";
            // 
            // button1
            // 
            this.button1.Image = global::hms.Properties.Resources.CLOSE;
            this.button1.Location = new System.Drawing.Point(480, -1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(23, 23);
            this.button1.TabIndex = 32;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Image = global::hms.Properties.Resources.SAVE;
            this.button2.Location = new System.Drawing.Point(461, -1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(21, 23);
            this.button2.TabIndex = 30;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Image = global::hms.Properties.Resources.ADD;
            this.button3.Location = new System.Drawing.Point(436, -1);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(26, 23);
            this.button3.TabIndex = 31;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // frmDerpartmentSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 333);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.rtbDeptDes);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.txtDeptName);
            this.Controls.Add(this.lblDeptName);
            this.Controls.Add(this.txtDeptID);
            this.Controls.Add(this.lblDeptID);
            this.Name = "frmDerpartmentSetup";
            this.Text = "frmDerpartmentSetup";
            this.Load += new System.EventHandler(this.frmDerpartmentSetup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RichTextBox rtbDeptDes;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtDeptName;
        private System.Windows.Forms.Label lblDeptName;
        private System.Windows.Forms.TextBox txtDeptID;
        private System.Windows.Forms.Label lblDeptID;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}