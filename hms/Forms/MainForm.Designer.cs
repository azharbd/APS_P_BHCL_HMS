namespace hms.Forms
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.qfqfaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.afsfToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.qfqfaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // qfqfaToolStripMenuItem
            // 
            this.qfqfaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.afsfToolStripMenuItem});
            this.qfqfaToolStripMenuItem.Name = "qfqfaToolStripMenuItem";
            this.qfqfaToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.qfqfaToolStripMenuItem.Text = "qfqfa";
            // 
            // afsfToolStripMenuItem
            // 
            this.afsfToolStripMenuItem.Name = "afsfToolStripMenuItem";
            this.afsfToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.afsfToolStripMenuItem.Text = "afsf";
            this.afsfToolStripMenuItem.Click += new System.EventHandler(this.afsfToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem qfqfaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem afsfToolStripMenuItem;
    }
}