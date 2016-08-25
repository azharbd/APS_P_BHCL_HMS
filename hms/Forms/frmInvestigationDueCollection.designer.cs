namespace hms.Forms
{
    partial class frmInvestigationDueCollection
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
            this.txtremarks = new System.Windows.Forms.TextBox();
            this.lblremarks = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtreturn = new System.Windows.Forms.TextBox();
            this.lblreturn = new System.Windows.Forms.Label();
            this.txtreceive = new System.Windows.Forms.TextBox();
            this.lblreceive = new System.Windows.Forms.Label();
            this.txtremainingdue = new System.Windows.Forms.TextBox();
            this.lblremainingdue = new System.Windows.Forms.Label();
            this.txtpaidamount = new System.Windows.Forms.TextBox();
            this.lblpaidamount = new System.Windows.Forms.Label();
            this.txtpayableamount = new System.Windows.Forms.TextBox();
            this.lblpayableamount = new System.Windows.Forms.Label();
            this.lstdiscountby = new System.Windows.Forms.ListBox();
            this.txtdiscountby = new System.Windows.Forms.TextBox();
            this.lbldiscountby = new System.Windows.Forms.Label();
            this.txtpersentance = new System.Windows.Forms.TextBox();
            this.lblpersentance = new System.Windows.Forms.Label();
            this.txtdiscount = new System.Windows.Forms.TextBox();
            this.lbldiscount = new System.Windows.Forms.Label();
            this.txtpaymentremaining = new System.Windows.Forms.TextBox();
            this.lblpaymentremaining = new System.Windows.Forms.Label();
            this.lstinvestigationid = new System.Windows.Forms.ListBox();
            this.lblinvestigationid = new System.Windows.Forms.Label();
            this.txtcashmemono = new System.Windows.Forms.TextBox();
            this.lblcashmemono = new System.Windows.Forms.Label();
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
            this.btnnew = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.btndelect = new System.Windows.Forms.Button();
            this.btnprint = new System.Windows.Forms.Button();
            this.btnclose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gbAccountsInformation.SuspendLayout();
            this.gbPatientInformation.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtremarks
            // 
            this.txtremarks.Location = new System.Drawing.Point(137, 253);
            this.txtremarks.Name = "txtremarks";
            this.txtremarks.Size = new System.Drawing.Size(133, 20);
            this.txtremarks.TabIndex = 51;
            // 
            // lblremarks
            // 
            this.lblremarks.AutoSize = true;
            this.lblremarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblremarks.Location = new System.Drawing.Point(66, 253);
            this.lblremarks.Name = "lblremarks";
            this.lblremarks.Size = new System.Drawing.Size(57, 15);
            this.lblremarks.TabIndex = 50;
            this.lblremarks.Text = "Remarks";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 302);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(844, 238);
            this.dataGridView1.TabIndex = 49;
            // 
            // txtreturn
            // 
            this.txtreturn.Location = new System.Drawing.Point(209, 276);
            this.txtreturn.Name = "txtreturn";
            this.txtreturn.Size = new System.Drawing.Size(61, 20);
            this.txtreturn.TabIndex = 48;
            // 
            // lblreturn
            // 
            this.lblreturn.AutoSize = true;
            this.lblreturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblreturn.Location = new System.Drawing.Point(147, 277);
            this.lblreturn.Name = "lblreturn";
            this.lblreturn.Size = new System.Drawing.Size(50, 15);
            this.lblreturn.TabIndex = 47;
            this.lblreturn.Text = "Return";
            // 
            // txtreceive
            // 
            this.txtreceive.Location = new System.Drawing.Point(87, 277);
            this.txtreceive.Name = "txtreceive";
            this.txtreceive.Size = new System.Drawing.Size(59, 20);
            this.txtreceive.TabIndex = 46;
            // 
            // lblreceive
            // 
            this.lblreceive.AutoSize = true;
            this.lblreceive.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblreceive.Location = new System.Drawing.Point(22, 278);
            this.lblreceive.Name = "lblreceive";
            this.lblreceive.Size = new System.Drawing.Size(58, 15);
            this.lblreceive.TabIndex = 45;
            this.lblreceive.Text = "Receive";
            // 
            // txtremainingdue
            // 
            this.txtremainingdue.Location = new System.Drawing.Point(138, 224);
            this.txtremainingdue.Name = "txtremainingdue";
            this.txtremainingdue.Size = new System.Drawing.Size(78, 20);
            this.txtremainingdue.TabIndex = 44;
            // 
            // lblremainingdue
            // 
            this.lblremainingdue.AutoSize = true;
            this.lblremainingdue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblremainingdue.Location = new System.Drawing.Point(30, 224);
            this.lblremainingdue.Name = "lblremainingdue";
            this.lblremainingdue.Size = new System.Drawing.Size(94, 15);
            this.lblremainingdue.TabIndex = 43;
            this.lblremainingdue.Text = "Remaining Due";
            // 
            // txtpaidamount
            // 
            this.txtpaidamount.Location = new System.Drawing.Point(139, 201);
            this.txtpaidamount.Name = "txtpaidamount";
            this.txtpaidamount.Size = new System.Drawing.Size(77, 20);
            this.txtpaidamount.TabIndex = 42;
            // 
            // lblpaidamount
            // 
            this.lblpaidamount.AutoSize = true;
            this.lblpaidamount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpaidamount.Location = new System.Drawing.Point(46, 201);
            this.lblpaidamount.Name = "lblpaidamount";
            this.lblpaidamount.Size = new System.Drawing.Size(77, 15);
            this.lblpaidamount.TabIndex = 41;
            this.lblpaidamount.Text = "Paid Amount";
            // 
            // txtpayableamount
            // 
            this.txtpayableamount.Location = new System.Drawing.Point(139, 176);
            this.txtpayableamount.Name = "txtpayableamount";
            this.txtpayableamount.Size = new System.Drawing.Size(131, 20);
            this.txtpayableamount.TabIndex = 40;
            // 
            // lblpayableamount
            // 
            this.lblpayableamount.AutoSize = true;
            this.lblpayableamount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpayableamount.Location = new System.Drawing.Point(24, 176);
            this.lblpayableamount.Name = "lblpayableamount";
            this.lblpayableamount.Size = new System.Drawing.Size(96, 15);
            this.lblpayableamount.TabIndex = 39;
            this.lblpayableamount.Text = "Payable Amount";
            // 
            // lstdiscountby
            // 
            this.lstdiscountby.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstdiscountby.FormattingEnabled = true;
            this.lstdiscountby.Location = new System.Drawing.Point(140, 145);
            this.lstdiscountby.Name = "lstdiscountby";
            this.lstdiscountby.Size = new System.Drawing.Size(130, 26);
            this.lstdiscountby.TabIndex = 38;
            // 
            // txtdiscountby
            // 
            this.txtdiscountby.Location = new System.Drawing.Point(140, 122);
            this.txtdiscountby.Name = "txtdiscountby";
            this.txtdiscountby.Size = new System.Drawing.Size(130, 20);
            this.txtdiscountby.TabIndex = 37;
            // 
            // lbldiscountby
            // 
            this.lbldiscountby.AutoSize = true;
            this.lbldiscountby.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldiscountby.Location = new System.Drawing.Point(50, 123);
            this.lbldiscountby.Name = "lbldiscountby";
            this.lbldiscountby.Size = new System.Drawing.Size(71, 15);
            this.lbldiscountby.TabIndex = 36;
            this.lbldiscountby.Text = "Discount By";
            // 
            // txtpersentance
            // 
            this.txtpersentance.Location = new System.Drawing.Point(216, 90);
            this.txtpersentance.Name = "txtpersentance";
            this.txtpersentance.Size = new System.Drawing.Size(54, 20);
            this.txtpersentance.TabIndex = 35;
            // 
            // lblpersentance
            // 
            this.lblpersentance.AutoSize = true;
            this.lblpersentance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpersentance.Location = new System.Drawing.Point(197, 92);
            this.lblpersentance.Name = "lblpersentance";
            this.lblpersentance.Size = new System.Drawing.Size(19, 15);
            this.lblpersentance.TabIndex = 34;
            this.lblpersentance.Text = "%";
            // 
            // txtdiscount
            // 
            this.txtdiscount.Location = new System.Drawing.Point(140, 90);
            this.txtdiscount.Name = "txtdiscount";
            this.txtdiscount.Size = new System.Drawing.Size(52, 20);
            this.txtdiscount.TabIndex = 33;
            // 
            // lbldiscount
            // 
            this.lbldiscount.AutoSize = true;
            this.lbldiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldiscount.Location = new System.Drawing.Point(64, 88);
            this.lbldiscount.Name = "lbldiscount";
            this.lbldiscount.Size = new System.Drawing.Size(55, 15);
            this.lbldiscount.TabIndex = 32;
            this.lbldiscount.Text = "Discount";
            // 
            // txtpaymentremaining
            // 
            this.txtpaymentremaining.Location = new System.Drawing.Point(139, 67);
            this.txtpaymentremaining.Name = "txtpaymentremaining";
            this.txtpaymentremaining.Size = new System.Drawing.Size(131, 20);
            this.txtpaymentremaining.TabIndex = 31;
            // 
            // lblpaymentremaining
            // 
            this.lblpaymentremaining.AutoSize = true;
            this.lblpaymentremaining.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpaymentremaining.Location = new System.Drawing.Point(0, 66);
            this.lblpaymentremaining.Name = "lblpaymentremaining";
            this.lblpaymentremaining.Size = new System.Drawing.Size(119, 15);
            this.lblpaymentremaining.TabIndex = 30;
            this.lblpaymentremaining.Text = "Payment Remaining";
            // 
            // lstinvestigationid
            // 
            this.lstinvestigationid.FormattingEnabled = true;
            this.lstinvestigationid.Location = new System.Drawing.Point(139, 33);
            this.lstinvestigationid.Name = "lstinvestigationid";
            this.lstinvestigationid.Size = new System.Drawing.Size(131, 30);
            this.lstinvestigationid.TabIndex = 29;
            // 
            // lblinvestigationid
            // 
            this.lblinvestigationid.AutoSize = true;
            this.lblinvestigationid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblinvestigationid.Location = new System.Drawing.Point(29, 43);
            this.lblinvestigationid.Name = "lblinvestigationid";
            this.lblinvestigationid.Size = new System.Drawing.Size(90, 15);
            this.lblinvestigationid.TabIndex = 28;
            this.lblinvestigationid.Text = "Investigation ID";
            // 
            // txtcashmemono
            // 
            this.txtcashmemono.Location = new System.Drawing.Point(139, 9);
            this.txtcashmemono.Name = "txtcashmemono";
            this.txtcashmemono.Size = new System.Drawing.Size(131, 20);
            this.txtcashmemono.TabIndex = 27;
            // 
            // lblcashmemono
            // 
            this.lblcashmemono.AutoSize = true;
            this.lblcashmemono.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcashmemono.Location = new System.Drawing.Point(30, 15);
            this.lblcashmemono.Name = "lblcashmemono";
            this.lblcashmemono.Size = new System.Drawing.Size(93, 15);
            this.lblcashmemono.TabIndex = 26;
            this.lblcashmemono.Text = "Cash Memo No";
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
            this.gbAccountsInformation.Location = new System.Drawing.Point(282, 116);
            this.gbAccountsInformation.Name = "gbAccountsInformation";
            this.gbAccountsInformation.Size = new System.Drawing.Size(289, 169);
            this.gbAccountsInformation.TabIndex = 53;
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
            this.lbltotaldue.Location = new System.Drawing.Point(83, 150);
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
            this.lbltotalreturn.Location = new System.Drawing.Point(70, 123);
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
            this.lbltotalpayamount.Location = new System.Drawing.Point(16, 86);
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
            this.lbltotalpaid.Location = new System.Drawing.Point(81, 106);
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
            this.gbPatientInformation.Location = new System.Drawing.Point(282, 3);
            this.gbPatientInformation.Name = "gbPatientInformation";
            this.gbPatientInformation.Size = new System.Drawing.Size(377, 107);
            this.gbPatientInformation.TabIndex = 52;
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
            // btnnew
            // 
            //this.btnnew.Image = global::hms.Properties.Resources.ADD1;
            this.btnnew.Location = new System.Drawing.Point(683, 2);
            this.btnnew.Name = "btnnew";
            this.btnnew.Size = new System.Drawing.Size(30, 23);
            this.btnnew.TabIndex = 54;
            this.btnnew.UseVisualStyleBackColor = true;
            // 
            // btnsave
            // 
            this.btnsave.Image = global::hms.Properties.Resources.SAVE;
            this.btnsave.Location = new System.Drawing.Point(715, 2);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(30, 23);
            this.btnsave.TabIndex = 55;
            this.btnsave.UseVisualStyleBackColor = true;
            // 
            // btndelect
            // 
            this.btndelect.Image = global::hms.Properties.Resources.DELETE;
            this.btndelect.Location = new System.Drawing.Point(752, 3);
            this.btndelect.Name = "btndelect";
            this.btndelect.Size = new System.Drawing.Size(30, 23);
            this.btndelect.TabIndex = 56;
            this.btndelect.UseVisualStyleBackColor = true;
            // 
            // btnprint
            // 
            this.btnprint.Image = global::hms.Properties.Resources.PRINTMAN;
            this.btnprint.Location = new System.Drawing.Point(788, 3);
            this.btnprint.Name = "btnprint";
            this.btnprint.Size = new System.Drawing.Size(30, 23);
            this.btnprint.TabIndex = 57;
            this.btnprint.UseVisualStyleBackColor = true;
            // 
            // btnclose
            // 
            this.btnclose.Image = global::hms.Properties.Resources.CLOSE;
            this.btnclose.Location = new System.Drawing.Point(820, 3);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(30, 23);
            this.btnclose.TabIndex = 58;
            this.btnclose.UseVisualStyleBackColor = true;
            // 
            // frmInvestigationDueCollection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 541);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.btnprint);
            this.Controls.Add(this.btndelect);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.btnnew);
            this.Controls.Add(this.gbAccountsInformation);
            this.Controls.Add(this.gbPatientInformation);
            this.Controls.Add(this.txtremarks);
            this.Controls.Add(this.lblremarks);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtreturn);
            this.Controls.Add(this.lblreturn);
            this.Controls.Add(this.txtreceive);
            this.Controls.Add(this.lblreceive);
            this.Controls.Add(this.txtremainingdue);
            this.Controls.Add(this.lblremainingdue);
            this.Controls.Add(this.txtpaidamount);
            this.Controls.Add(this.lblpaidamount);
            this.Controls.Add(this.txtpayableamount);
            this.Controls.Add(this.lblpayableamount);
            this.Controls.Add(this.lstdiscountby);
            this.Controls.Add(this.txtdiscountby);
            this.Controls.Add(this.lbldiscountby);
            this.Controls.Add(this.txtpersentance);
            this.Controls.Add(this.lblpersentance);
            this.Controls.Add(this.txtdiscount);
            this.Controls.Add(this.lbldiscount);
            this.Controls.Add(this.txtpaymentremaining);
            this.Controls.Add(this.lblpaymentremaining);
            this.Controls.Add(this.lstinvestigationid);
            this.Controls.Add(this.lblinvestigationid);
            this.Controls.Add(this.txtcashmemono);
            this.Controls.Add(this.lblcashmemono);
            this.Name = "frmInvestigationDueCollection";
            this.Text = "frmInvestigationDueCollection";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gbAccountsInformation.ResumeLayout(false);
            this.gbAccountsInformation.PerformLayout();
            this.gbPatientInformation.ResumeLayout(false);
            this.gbPatientInformation.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtremarks;
        private System.Windows.Forms.Label lblremarks;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtreturn;
        private System.Windows.Forms.Label lblreturn;
        private System.Windows.Forms.TextBox txtreceive;
        private System.Windows.Forms.Label lblreceive;
        private System.Windows.Forms.TextBox txtremainingdue;
        private System.Windows.Forms.Label lblremainingdue;
        private System.Windows.Forms.TextBox txtpaidamount;
        private System.Windows.Forms.Label lblpaidamount;
        private System.Windows.Forms.TextBox txtpayableamount;
        private System.Windows.Forms.Label lblpayableamount;
        private System.Windows.Forms.ListBox lstdiscountby;
        private System.Windows.Forms.TextBox txtdiscountby;
        private System.Windows.Forms.Label lbldiscountby;
        private System.Windows.Forms.TextBox txtpersentance;
        private System.Windows.Forms.Label lblpersentance;
        private System.Windows.Forms.TextBox txtdiscount;
        private System.Windows.Forms.Label lbldiscount;
        private System.Windows.Forms.TextBox txtpaymentremaining;
        private System.Windows.Forms.Label lblpaymentremaining;
        private System.Windows.Forms.ListBox lstinvestigationid;
        private System.Windows.Forms.Label lblinvestigationid;
        private System.Windows.Forms.TextBox txtcashmemono;
        private System.Windows.Forms.Label lblcashmemono;
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
        private System.Windows.Forms.Button btnnew;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btndelect;
        private System.Windows.Forms.Button btnprint;
        private System.Windows.Forms.Button btnclose;
    }
}