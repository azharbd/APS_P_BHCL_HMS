namespace hms.Forms
{
    partial class frmReportDelivery
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
            this.lblInvestigationID = new System.Windows.Forms.Label();
            this.txtInvestigationID = new System.Windows.Forms.TextBox();
            this.gbAccountsInformation = new System.Windows.Forms.GroupBox();
            this.lbltotaldiscount = new System.Windows.Forms.Label();
            this.lbltotalamount = new System.Windows.Forms.Label();
            this.lbltotaldue = new System.Windows.Forms.Label();
            this.lblvat = new System.Windows.Forms.Label();
            this.lbltotalreturn = new System.Windows.Forms.Label();
            this.lbltotalpayamount = new System.Windows.Forms.Label();
            this.lbltotalpaid = new System.Windows.Forms.Label();
            this.gbPatientInformation = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnReceive = new System.Windows.Forms.Button();
            this.btnDeliver = new System.Windows.Forms.Button();
            this.btnnew = new System.Windows.Forms.Button();
            this.btnclose = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.chkAllSelect = new System.Windows.Forms.CheckBox();
            this.gbAccountsInformation.SuspendLayout();
            this.gbPatientInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblInvestigationID
            // 
            this.lblInvestigationID.AutoSize = true;
            this.lblInvestigationID.Location = new System.Drawing.Point(42, 57);
            this.lblInvestigationID.Name = "lblInvestigationID";
            this.lblInvestigationID.Size = new System.Drawing.Size(81, 13);
            this.lblInvestigationID.TabIndex = 0;
            this.lblInvestigationID.Text = "Investigation ID";
            // 
            // txtInvestigationID
            // 
            this.txtInvestigationID.Location = new System.Drawing.Point(135, 54);
            this.txtInvestigationID.Name = "txtInvestigationID";
            this.txtInvestigationID.Size = new System.Drawing.Size(100, 20);
            this.txtInvestigationID.TabIndex = 1;
            // 
            // gbAccountsInformation
            // 
            this.gbAccountsInformation.Controls.Add(this.lbltotaldiscount);
            this.gbAccountsInformation.Controls.Add(this.lbltotalamount);
            this.gbAccountsInformation.Controls.Add(this.lbltotaldue);
            this.gbAccountsInformation.Controls.Add(this.lblvat);
            this.gbAccountsInformation.Controls.Add(this.lbltotalreturn);
            this.gbAccountsInformation.Controls.Add(this.lbltotalpayamount);
            this.gbAccountsInformation.Controls.Add(this.lbltotalpaid);
            this.gbAccountsInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAccountsInformation.ForeColor = System.Drawing.Color.Red;
            this.gbAccountsInformation.Location = new System.Drawing.Point(605, 11);
            this.gbAccountsInformation.Name = "gbAccountsInformation";
            this.gbAccountsInformation.Size = new System.Drawing.Size(219, 156);
            this.gbAccountsInformation.TabIndex = 55;
            this.gbAccountsInformation.TabStop = false;
            this.gbAccountsInformation.Text = "Accounts Information";
            // 
            // lbltotaldiscount
            // 
            this.lbltotaldiscount.AutoSize = true;
            this.lbltotaldiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotaldiscount.ForeColor = System.Drawing.Color.Black;
            this.lbltotaldiscount.Location = new System.Drawing.Point(57, 36);
            this.lbltotaldiscount.Name = "lbltotaldiscount";
            this.lbltotaldiscount.Size = new System.Drawing.Size(88, 15);
            this.lbltotaldiscount.TabIndex = 44;
            this.lbltotaldiscount.Text = "Total Discount:";
            // 
            // lbltotalamount
            // 
            this.lbltotalamount.AutoSize = true;
            this.lbltotalamount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotalamount.ForeColor = System.Drawing.Color.Black;
            this.lbltotalamount.Location = new System.Drawing.Point(64, 18);
            this.lbltotalamount.Name = "lbltotalamount";
            this.lbltotalamount.Size = new System.Drawing.Size(82, 15);
            this.lbltotalamount.TabIndex = 43;
            this.lbltotalamount.Text = "Total Amount:";
            // 
            // lbltotaldue
            // 
            this.lbltotaldue.AutoSize = true;
            this.lbltotaldue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotaldue.ForeColor = System.Drawing.Color.Black;
            this.lbltotaldue.Location = new System.Drawing.Point(83, 134);
            this.lbltotaldue.Name = "lbltotaldue";
            this.lbltotaldue.Size = new System.Drawing.Size(63, 15);
            this.lbltotaldue.TabIndex = 49;
            this.lbltotaldue.Text = "Total Due:";
            // 
            // lblvat
            // 
            this.lblvat.AutoSize = true;
            this.lblvat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblvat.ForeColor = System.Drawing.Color.Black;
            this.lblvat.Location = new System.Drawing.Point(119, 54);
            this.lblvat.Name = "lblvat";
            this.lblvat.Size = new System.Drawing.Size(27, 15);
            this.lblvat.TabIndex = 45;
            this.lblvat.Text = "Vat:";
            // 
            // lbltotalreturn
            // 
            this.lbltotalreturn.AutoSize = true;
            this.lbltotalreturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotalreturn.ForeColor = System.Drawing.Color.Black;
            this.lbltotalreturn.Location = new System.Drawing.Point(70, 107);
            this.lbltotalreturn.Name = "lbltotalreturn";
            this.lbltotalreturn.Size = new System.Drawing.Size(77, 15);
            this.lbltotalreturn.TabIndex = 48;
            this.lbltotalreturn.Text = "Total Return:";
            // 
            // lbltotalpayamount
            // 
            this.lbltotalpayamount.AutoSize = true;
            this.lbltotalpayamount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotalpayamount.ForeColor = System.Drawing.Color.Black;
            this.lbltotalpayamount.Location = new System.Drawing.Point(16, 70);
            this.lbltotalpayamount.Name = "lbltotalpayamount";
            this.lbltotalpayamount.Size = new System.Drawing.Size(129, 15);
            this.lbltotalpayamount.TabIndex = 46;
            this.lbltotalpayamount.Text = "Total Payable Amount:";
            // 
            // lbltotalpaid
            // 
            this.lbltotalpaid.AutoSize = true;
            this.lbltotalpaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotalpaid.ForeColor = System.Drawing.Color.Black;
            this.lbltotalpaid.Location = new System.Drawing.Point(81, 90);
            this.lbltotalpaid.Name = "lbltotalpaid";
            this.lbltotalpaid.Size = new System.Drawing.Size(65, 15);
            this.lbltotalpaid.TabIndex = 47;
            this.lbltotalpaid.Text = "Total Paid:";
            // 
            // gbPatientInformation
            // 
            this.gbPatientInformation.Controls.Add(this.label1);
            this.gbPatientInformation.Controls.Add(this.label2);
            this.gbPatientInformation.Controls.Add(this.label3);
            this.gbPatientInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPatientInformation.ForeColor = System.Drawing.Color.Red;
            this.gbPatientInformation.Location = new System.Drawing.Point(256, 12);
            this.gbPatientInformation.Name = "gbPatientInformation";
            this.gbPatientInformation.Size = new System.Drawing.Size(343, 107);
            this.gbPatientInformation.TabIndex = 54;
            this.gbPatientInformation.TabStop = false;
            this.gbPatientInformation.Text = "Patient Information";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(13, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 15);
            this.label1.TabIndex = 44;
            this.label1.Text = "Doctor:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(4, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 15);
            this.label2.TabIndex = 43;
            this.label2.Text = "Address:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(12, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 15);
            this.label3.TabIndex = 42;
            this.label3.Text = "Name:";
            // 
            // btnReceive
            // 
            this.btnReceive.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReceive.Location = new System.Drawing.Point(339, 126);
            this.btnReceive.Name = "btnReceive";
            this.btnReceive.Size = new System.Drawing.Size(75, 23);
            this.btnReceive.TabIndex = 56;
            this.btnReceive.Text = "Receive";
            this.btnReceive.UseVisualStyleBackColor = true;
            // 
            // btnDeliver
            // 
            this.btnDeliver.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeliver.Location = new System.Drawing.Point(428, 126);
            this.btnDeliver.Name = "btnDeliver";
            this.btnDeliver.Size = new System.Drawing.Size(75, 23);
            this.btnDeliver.TabIndex = 57;
            this.btnDeliver.Text = "Deliver";
            this.btnDeliver.UseVisualStyleBackColor = true;
            // 
            // btnnew
            // 
            this.btnnew.Image = global::hms.Properties.Resources.ADD;
            this.btnnew.Location = new System.Drawing.Point(31, 11);
            this.btnnew.Name = "btnnew";
            this.btnnew.Size = new System.Drawing.Size(32, 23);
            this.btnnew.TabIndex = 58;
            this.btnnew.UseVisualStyleBackColor = true;
            // 
            // btnclose
            // 
            this.btnclose.Image = global::hms.Properties.Resources.CLOSE;
            this.btnclose.Location = new System.Drawing.Point(64, 11);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(32, 23);
            this.btnclose.TabIndex = 59;
            this.btnclose.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 173);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(812, 557);
            this.dataGridView1.TabIndex = 60;
            // 
            // chkAllSelect
            // 
            this.chkAllSelect.AutoSize = true;
            this.chkAllSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAllSelect.ForeColor = System.Drawing.Color.Red;
            this.chkAllSelect.Location = new System.Drawing.Point(13, 150);
            this.chkAllSelect.Name = "chkAllSelect";
            this.chkAllSelect.Size = new System.Drawing.Size(80, 17);
            this.chkAllSelect.TabIndex = 61;
            this.chkAllSelect.Text = "All Select";
            this.chkAllSelect.UseVisualStyleBackColor = true;
            // 
            // frmReportDelivery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 742);
            this.Controls.Add(this.chkAllSelect);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.btnnew);
            this.Controls.Add(this.btnDeliver);
            this.Controls.Add(this.btnReceive);
            this.Controls.Add(this.gbAccountsInformation);
            this.Controls.Add(this.gbPatientInformation);
            this.Controls.Add(this.txtInvestigationID);
            this.Controls.Add(this.lblInvestigationID);
            this.Name = "frmReportDelivery";
            this.Text = "frmReportDelivery";
            this.gbAccountsInformation.ResumeLayout(false);
            this.gbAccountsInformation.PerformLayout();
            this.gbPatientInformation.ResumeLayout(false);
            this.gbPatientInformation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInvestigationID;
        private System.Windows.Forms.TextBox txtInvestigationID;
        private System.Windows.Forms.GroupBox gbAccountsInformation;
        private System.Windows.Forms.Label lbltotaldiscount;
        private System.Windows.Forms.Label lbltotalamount;
        private System.Windows.Forms.Label lbltotaldue;
        private System.Windows.Forms.Label lblvat;
        private System.Windows.Forms.Label lbltotalreturn;
        private System.Windows.Forms.Label lbltotalpayamount;
        private System.Windows.Forms.Label lbltotalpaid;
        private System.Windows.Forms.GroupBox gbPatientInformation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnReceive;
        private System.Windows.Forms.Button btnDeliver;
        private System.Windows.Forms.Button btnnew;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.CheckBox chkAllSelect;
    }
}