﻿namespace hms.Forms
{
    partial class frmInvestigationsamplecollection
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
            this.txtInvestigation = new System.Windows.Forms.TextBox();
            this.chkNewCollection = new System.Windows.Forms.CheckBox();
            this.lblclose = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(38, 75);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(812, 636);
            this.dataGridView1.TabIndex = 9;
            // 
            // txtInvestigation
            // 
            this.txtInvestigation.Location = new System.Drawing.Point(730, 34);
            this.txtInvestigation.Name = "txtInvestigation";
            this.txtInvestigation.Size = new System.Drawing.Size(120, 20);
            this.txtInvestigation.TabIndex = 8;
            // 
            // chkNewCollection
            // 
            this.chkNewCollection.AutoSize = true;
            this.chkNewCollection.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkNewCollection.ForeColor = System.Drawing.Color.Crimson;
            this.chkNewCollection.Location = new System.Drawing.Point(383, 34);
            this.chkNewCollection.Name = "chkNewCollection";
            this.chkNewCollection.Size = new System.Drawing.Size(131, 19);
            this.chkNewCollection.TabIndex = 7;
            this.chkNewCollection.Text = "Check New Data";
            this.chkNewCollection.UseVisualStyleBackColor = true;
            // 
            // lblclose
            // 
            this.lblclose.Image = global::hms.Properties.Resources.CLOSE;
            this.lblclose.Location = new System.Drawing.Point(69, 32);
            this.lblclose.Name = "lblclose";
            this.lblclose.Size = new System.Drawing.Size(29, 23);
            this.lblclose.TabIndex = 6;
            this.lblclose.UseVisualStyleBackColor = true;
            // 
            // btnsave
            // 
            this.btnsave.Image = global::hms.Properties.Resources.SAVE;
            this.btnsave.Location = new System.Drawing.Point(38, 32);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(30, 23);
            this.btnsave.TabIndex = 5;
            this.btnsave.UseVisualStyleBackColor = true;
            // 
            // frmInvestigationsamplecollection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 742);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtInvestigation);
            this.Controls.Add(this.chkNewCollection);
            this.Controls.Add(this.lblclose);
            this.Controls.Add(this.btnsave);
            this.Name = "frmInvestigationsamplecollection";
            this.Text = "frmInvestigationsamplecollection";
            this.Load += new System.EventHandler(this.frmInvestigationsamplecollection_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtInvestigation;
        private System.Windows.Forms.CheckBox chkNewCollection;
        private System.Windows.Forms.Button lblclose;
        private System.Windows.Forms.Button btnsave;
    }
}