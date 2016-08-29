using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BatchDLL;

namespace hms.Forms
{
    public partial class frmfrontdeskinvestigation : Form
    {
        C_Data_Batch objData;
        public string strErr = "";
        public string strSelectedServices = "";

        public frmfrontdeskinvestigation()
        {
            InitializeComponent();
        }

        private void frmfrontdeskinvestigation_Load(object sender, EventArgs e)
        {
            objData = new C_Data_Batch();
            objData.OpenConnection("AzharPC-Home", ref strErr);
            frmload();
            objData.CloseConnection();
        }

        private void frmload()
        {
            //throw new NotImplementedException();
            clearFileds();
            getMaxID();
            getServices();
            getDocList();
            clearGrid();

        }

        private void clearGrid()
        {
            //throw new NotImplementedException();
            DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn();
            checkBoxColumn.HeaderText = "";
            checkBoxColumn.Width = 30;
            checkBoxColumn.Name = "checkBoxColumn";
            dgvInvestigation.Columns.Insert(0, checkBoxColumn);
        }

        private void getDocList()
        {
            //throw new NotImplementedException();
        }

        private void getServices()
        {
            //throw new NotImplementedException();
        }

        private void getMaxID()
        {
            //throw new NotImplementedException();
        }

        private void clearFileds()
        {
            //throw new NotImplementedException();
            txtid.Text = "";
            txtname.Text = "";
            txtaddress.Text = "";
            txtphone.Text = "";
            txtYear.Text = "";
            txtMonth.Text = "";
            txtsex.Text = "";
            txtSearchServices.Text = "";

            
            
            
        }

        private void dgvInvestigation_Click(object sender, EventArgs e)
        {
            //string message = "";
            //foreach (DataGridViewRow row in dgvInvestigation.Rows)
            //{
            //    bool isSelected = Convert.ToBoolean(row.Cells["checkBoxColumn"].Value);
            //    if (isSelected)
            //    {
            //        message +="1,";
            //        //message += row.Cells["Name"].Value.ToString();
            //    }
            //}
            //MessageBox.Show(message.ToString());
            var confirmResult = MessageBox.Show("Are you sure to delete this item ??",
                                     "Confirm Delete!!",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                MessageBox.Show("Y");
            }
            else
            {
                // If 'No', do something here.
                MessageBox.Show("N");
            }
        }

        private void btnnew_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure to delete this item ??",
                                     "Confirm Delete!!",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                MessageBox.Show("Y");
            }
            else
            {
                // If 'No', do something here.
                MessageBox.Show("N");
            }
        }

        
    }
}
