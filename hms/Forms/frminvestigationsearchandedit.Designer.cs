namespace hms.Froms
{
    partial class frminvestigationsearchandedit
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
            this.lbldaterange = new System.Windows.Forms.Label();
            this.datestart = new System.Windows.Forms.DateTimePicker();
            this.dateend = new System.Windows.Forms.DateTimePicker();
            this.lblto = new System.Windows.Forms.Label();
            this.lbldoctorsname = new System.Windows.Forms.Label();
            this.lstdoctorsinformation = new System.Windows.Forms.ListBox();
            this.txtinvestigation = new System.Windows.Forms.TextBox();
            this.lblInvestigationid = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtsex = new System.Windows.Forms.TextBox();
            this.lblsex = new System.Windows.Forms.Label();
            this.txtyear = new System.Windows.Forms.TextBox();
            this.txtday = new System.Windows.Forms.TextBox();
            this.txtmonth = new System.Windows.Forms.TextBox();
            this.lblage = new System.Windows.Forms.Label();
            this.txtphone = new System.Windows.Forms.TextBox();
            this.lblphone = new System.Windows.Forms.Label();
            this.txtaddress = new System.Windows.Forms.TextBox();
            this.lbladdress = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.lblname = new System.Windows.Forms.Label();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnfind = new System.Windows.Forms.Button();
            this.txtremark = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbldaterange
            // 
            this.lbldaterange.AutoSize = true;
            this.lbldaterange.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldaterange.Location = new System.Drawing.Point(58, 3);
            this.lbldaterange.Name = "lbldaterange";
            this.lbldaterange.Size = new System.Drawing.Size(75, 13);
            this.lbldaterange.TabIndex = 0;
            this.lbldaterange.Text = "Date Range";
            // 
            // datestart
            // 
            this.datestart.Location = new System.Drawing.Point(13, 21);
            this.datestart.Name = "datestart";
            this.datestart.Size = new System.Drawing.Size(77, 20);
            this.datestart.TabIndex = 1;
            // 
            // dateend
            // 
            this.dateend.Location = new System.Drawing.Point(124, 20);
            this.dateend.Name = "dateend";
            this.dateend.Size = new System.Drawing.Size(65, 20);
            this.dateend.TabIndex = 2;
            // 
            // lblto
            // 
            this.lblto.AutoSize = true;
            this.lblto.Location = new System.Drawing.Point(96, 26);
            this.lblto.Name = "lblto";
            this.lblto.Size = new System.Drawing.Size(20, 13);
            this.lblto.TabIndex = 3;
            this.lblto.Text = "To";
            // 
            // lbldoctorsname
            // 
            this.lbldoctorsname.AutoSize = true;
            this.lbldoctorsname.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldoctorsname.Location = new System.Drawing.Point(58, 44);
            this.lbldoctorsname.Name = "lbldoctorsname";
            this.lbldoctorsname.Size = new System.Drawing.Size(87, 13);
            this.lbldoctorsname.TabIndex = 4;
            this.lbldoctorsname.Text = "Doctors Name";
            // 
            // lstdoctorsinformation
            // 
            this.lstdoctorsinformation.FormattingEnabled = true;
            this.lstdoctorsinformation.Location = new System.Drawing.Point(13, 58);
            this.lstdoctorsinformation.Name = "lstdoctorsinformation";
            this.lstdoctorsinformation.Size = new System.Drawing.Size(176, 17);
            this.lstdoctorsinformation.TabIndex = 5;
            // 
            // txtinvestigation
            // 
            this.txtinvestigation.Location = new System.Drawing.Point(13, 107);
            this.txtinvestigation.Name = "txtinvestigation";
            this.txtinvestigation.Size = new System.Drawing.Size(176, 20);
            this.txtinvestigation.TabIndex = 6;
            // 
            // lblInvestigationid
            // 
            this.lblInvestigationid.AutoSize = true;
            this.lblInvestigationid.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvestigationid.Location = new System.Drawing.Point(58, 91);
            this.lblInvestigationid.Name = "lblInvestigationid";
            this.lblInvestigationid.Size = new System.Drawing.Size(97, 13);
            this.lblInvestigationid.TabIndex = 7;
            this.lblInvestigationid.Text = "Investigation ID";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(201, 20);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(293, 146);
            this.dataGridView1.TabIndex = 8;
            // 
            // txtsex
            // 
            this.txtsex.Location = new System.Drawing.Point(671, 112);
            this.txtsex.Name = "txtsex";
            this.txtsex.Size = new System.Drawing.Size(46, 20);
            this.txtsex.TabIndex = 78;
            // 
            // lblsex
            // 
            this.lblsex.AutoSize = true;
            this.lblsex.Location = new System.Drawing.Point(641, 116);
            this.lblsex.Name = "lblsex";
            this.lblsex.Size = new System.Drawing.Size(25, 13);
            this.lblsex.TabIndex = 77;
            this.lblsex.Text = "Sex";
            // 
            // txtyear
            // 
            this.txtyear.Location = new System.Drawing.Point(609, 113);
            this.txtyear.Name = "txtyear";
            this.txtyear.Size = new System.Drawing.Size(34, 20);
            this.txtyear.TabIndex = 76;
            // 
            // txtday
            // 
            this.txtday.Location = new System.Drawing.Point(576, 113);
            this.txtday.Name = "txtday";
            this.txtday.Size = new System.Drawing.Size(30, 20);
            this.txtday.TabIndex = 75;
            // 
            // txtmonth
            // 
            this.txtmonth.Location = new System.Drawing.Point(544, 113);
            this.txtmonth.Name = "txtmonth";
            this.txtmonth.Size = new System.Drawing.Size(31, 20);
            this.txtmonth.TabIndex = 74;
            // 
            // lblage
            // 
            this.lblage.AutoSize = true;
            this.lblage.Location = new System.Drawing.Point(497, 113);
            this.lblage.Name = "lblage";
            this.lblage.Size = new System.Drawing.Size(26, 13);
            this.lblage.TabIndex = 73;
            this.lblage.Text = "Age";
            // 
            // txtphone
            // 
            this.txtphone.Location = new System.Drawing.Point(544, 90);
            this.txtphone.Name = "txtphone";
            this.txtphone.Size = new System.Drawing.Size(210, 20);
            this.txtphone.TabIndex = 72;
            // 
            // lblphone
            // 
            this.lblphone.AutoSize = true;
            this.lblphone.Location = new System.Drawing.Point(498, 96);
            this.lblphone.Name = "lblphone";
            this.lblphone.Size = new System.Drawing.Size(41, 13);
            this.lblphone.TabIndex = 71;
            this.lblphone.Text = "Phone:";
            // 
            // txtaddress
            // 
            this.txtaddress.Location = new System.Drawing.Point(544, 39);
            this.txtaddress.Multiline = true;
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Size = new System.Drawing.Size(210, 49);
            this.txtaddress.TabIndex = 70;
            // 
            // lbladdress
            // 
            this.lbladdress.AutoSize = true;
            this.lbladdress.Location = new System.Drawing.Point(498, 72);
            this.lbladdress.Name = "lbladdress";
            this.lbladdress.Size = new System.Drawing.Size(48, 13);
            this.lbladdress.TabIndex = 69;
            this.lbladdress.Text = "Address:";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(544, 20);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(210, 20);
            this.txtname.TabIndex = 68;
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Location = new System.Drawing.Point(500, 20);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(38, 13);
            this.lblname.TabIndex = 67;
            this.lblname.Text = "Neme:";
            // 
            // btnsave
            // 
            this.btnsave.Image = global::hms.Properties.Resources.SAVE;
            this.btnsave.Location = new System.Drawing.Point(154, 129);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(37, 35);
            this.btnsave.TabIndex = 80;
            this.btnsave.UseVisualStyleBackColor = true;
            // 
            // btnfind
            // 
            this.btnfind.Image = global::hms.Properties.Resources.Search;
            this.btnfind.Location = new System.Drawing.Point(114, 129);
            this.btnfind.Name = "btnfind";
            this.btnfind.Size = new System.Drawing.Size(34, 35);
            this.btnfind.TabIndex = 79;
            this.btnfind.UseVisualStyleBackColor = true;
            // 
            // txtremark
            // 
            this.txtremark.Location = new System.Drawing.Point(544, 135);
            this.txtremark.Multiline = true;
            this.txtremark.Name = "txtremark";
            this.txtremark.Size = new System.Drawing.Size(210, 30);
            this.txtremark.TabIndex = 81;
            // 
            // frminvestigationsearchandedit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 443);
            this.Controls.Add(this.txtremark);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.btnfind);
            this.Controls.Add(this.txtsex);
            this.Controls.Add(this.lblsex);
            this.Controls.Add(this.txtyear);
            this.Controls.Add(this.txtday);
            this.Controls.Add(this.txtmonth);
            this.Controls.Add(this.lblage);
            this.Controls.Add(this.txtphone);
            this.Controls.Add(this.lblphone);
            this.Controls.Add(this.txtaddress);
            this.Controls.Add(this.lbladdress);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblInvestigationid);
            this.Controls.Add(this.txtinvestigation);
            this.Controls.Add(this.lstdoctorsinformation);
            this.Controls.Add(this.lbldoctorsname);
            this.Controls.Add(this.lblto);
            this.Controls.Add(this.dateend);
            this.Controls.Add(this.datestart);
            this.Controls.Add(this.lbldaterange);
            this.Name = "frminvestigationsearchandedit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Investigation Search & Edit";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbldaterange;
        private System.Windows.Forms.DateTimePicker datestart;
        private System.Windows.Forms.DateTimePicker dateend;
        private System.Windows.Forms.Label lblto;
        private System.Windows.Forms.Label lbldoctorsname;
        private System.Windows.Forms.ListBox lstdoctorsinformation;
        private System.Windows.Forms.TextBox txtinvestigation;
        private System.Windows.Forms.Label lblInvestigationid;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtsex;
        private System.Windows.Forms.Label lblsex;
        private System.Windows.Forms.TextBox txtyear;
        private System.Windows.Forms.TextBox txtday;
        private System.Windows.Forms.TextBox txtmonth;
        private System.Windows.Forms.Label lblage;
        private System.Windows.Forms.TextBox txtphone;
        private System.Windows.Forms.Label lblphone;
        private System.Windows.Forms.TextBox txtaddress;
        private System.Windows.Forms.Label lbladdress;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Button btnfind;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.TextBox txtremark;
    }
}