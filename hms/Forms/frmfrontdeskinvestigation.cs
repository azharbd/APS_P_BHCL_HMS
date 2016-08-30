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
            dgvInvestigation.Columns.Clear();
            dgvInvestigation.Refresh();
            DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn();
            checkBoxColumn.HeaderText = "";
            checkBoxColumn.Width = 30;
            checkBoxColumn.Name = "";
            dgvInvestigation.Columns.Insert(0, checkBoxColumn);
        }

        private void getDocList()
        {
            //throw new NotImplementedException();
            string strSQL = "";
            strSQL = "select DocID, Name from dbo_Doctor_List order by Name";
            DataTable arrDocList = objData.RetriveData(strSQL, ref strErr);
            lstdoctorsinformation.Items.Clear();
            if (arrDocList.Rows.Count > 0)
            {
                for (int i = 0; i<arrDocList.Rows.Count; i++)
                {
                    lstdoctorsinformation.Items.Add(new hms.Include_Files.Utility.ComboboxItem(arrDocList.Rows[i][1].ToString(), Convert.ToInt32(arrDocList.Rows[i][0].ToString())));
                }
            }

        }

        private void getServices()
        {
            //throw new NotImplementedException();
            string strSQL = "";
            strSQL = "select Service_ID, Service_Name from Dbo_Services order by Service_Name";
            DataTable arrDocList = objData.RetriveData(strSQL, ref strErr);
            lsttestname.Items.Clear();
            if (arrDocList.Rows.Count > 0)
            {
                for (int i = 0; i < arrDocList.Rows.Count; i++)
                {
                    lsttestname.Items.Add(new hms.Include_Files.Utility.ComboboxItem(arrDocList.Rows[i][1].ToString(), Convert.ToInt32(arrDocList.Rows[i][0].ToString())));
                }
            }
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
            txtDocNew.Text = "";
            chkbtmpsave.Checked = false;
            rbtngenaral.Checked = false;
            rbtnopd.Checked = false;
            rbtnindoor.Checked = false;
            rbtnbloodbank.Checked = false;
            rbtndental.Checked = false;
            rbtndialysis.Checked = false;
            rbtnpathology.Checked = false;
            rbtntherapy.Checked = false;
            txtdoctorid.Text = "";
            txttitle.Text = "";
            txtrefferedby.Text = "";
            txtdegree.Text = "";
            txtarea.Text = "";
            txtspecialist.Text = "";
            txttype.Text = "";
            txttotalamount.Text = "";
            txtpaidamount.Text = "";
            txtdiscount.Text = "";
            txtdiscouuntpersentnance.Text = "";
            txtvat.Text = "";
            txtpaidamount.Text = "";
            txtpc.Text = "";
            txttotaldue.Text = "";
            txtreceive.Text = "";
            txtReturn.Text = "";
            txtPayableAmount.Text = "";
            hms.Include_Files.Utility.selectTestIds = "";
            
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
            //var confirmResult = MessageBox.Show("Are you sure to delete this item ??",
            //                         "Confirm Delete!!",
            //                         MessageBoxButtons.YesNo);
            //if (confirmResult == DialogResult.Yes)
            //{
            //    MessageBox.Show("Y");
            //}
            //else
            //{
            //    // If 'No', do something here.
            //    MessageBox.Show("N");
            //}
        }

        private void btnnew_Click(object sender, EventArgs e)
        {
            //var confirmResult = MessageBox.Show("Are you sure to delete this item ??",
            //                         "Confirm Delete!!",
            //                         MessageBoxButtons.YesNo);
            //if (confirmResult == DialogResult.Yes)
            //{
            //    MessageBox.Show("Y");
            //}
            //else
            //{
            //    // If 'No', do something here.
            //    MessageBox.Show("N");
            //}

            objData = new C_Data_Batch();
            objData.OpenConnection("AzharPC-Home", ref strErr);
            frmload();
            objData.CloseConnection();
        }

        private void lsttestname_DoubleClick(object sender, EventArgs e)
        {
            string findString = "";
            hms.Include_Files.Utility.ComboboxItem itms = lsttestname.SelectedItem as hms.Include_Files.Utility.ComboboxItem;
            if (itms != null)
            {
                findString = "," + itms.Value.ToString() + ",";
                //MessageBox.Show(hms.Include_Files.Utility.selectTestIds.IndexOf(findString).ToString());
                if (hms.Include_Files.Utility.selectTestIds.IndexOf(findString) == -1)
                {
                    if (hms.Include_Files.Utility.selectTestIds == "")
                    {
                        hms.Include_Files.Utility.selectTestIds = "," + itms.Value.ToString() + ",";
                    }
                    else
                    {
                        hms.Include_Files.Utility.selectTestIds = hms.Include_Files.Utility.selectTestIds + itms.Value.ToString() + ",";
                    }
                }
                //hms.Include_Files.Utility.selectTestIds = hms.Include_Files.Utility.selectTestIds + "," + itms.Value.ToString()+",";
            }
            objData = new C_Data_Batch();
            objData.OpenConnection("AzharPC-Home", ref strErr);
            loadGrid();
            objData.CloseConnection();

            //MessageBox.Show(hms.Include_Files.Utility.selectTestIds.Substring(1, Convert.ToInt16(hms.Include_Files.Utility.selectTestIds.Length) -2).ToString());
        }

        private void loadGrid()
        {
            //throw new NotImplementedException();

            string strSQL = "";
            strSQL = "Select * from Dbo_Services where service_id in (" + hms.Include_Files.Utility.selectTestIds.Substring(1, Convert.ToInt16(hms.Include_Files.Utility.selectTestIds.Length) - 2).ToString() + ")";
            DataTable arrservice = objData.RetriveData(strSQL, ref strErr);

            DataSet ds = new DataSet();
            ds.Tables.Add(arrservice);
            dgvInvestigation.DataSource = ds.Tables["Table1"];
            getTotalCalculation();

        }

        private void getTotalCalculation()
        {
            //throw new NotImplementedException();
            int totalPayableAmount = 0;
            if (Convert.ToInt32(dgvInvestigation.Rows.Count) - 1 > 0)
            {
                for (int i = 0; i < dgvInvestigation.Rows.Count - 1; i++)
                {
                    totalPayableAmount = totalPayableAmount + Convert.ToInt32(dgvInvestigation.Rows[i].Cells[4].Value.ToString());
                }
            }

            txttotalamount.Text = totalPayableAmount.ToString();
            int discount;
            Int32.TryParse(txtdiscount.Text, out discount);

            int DiscountTaka;
            Int32.TryParse(txtdiscouuntpersentnance.Text, out DiscountTaka);

            

            //MessageBox.Show(discount.ToString());
        }

        private void lstdoctorsinformation_DoubleClick(object sender, EventArgs e)
        {
            objData = new C_Data_Batch();
            objData.OpenConnection("AzharPC-Home", ref strErr);
            loadDoctorInformation();
            objData.CloseConnection();
        }

        private void loadDoctorInformation()
        {
            //throw new NotImplementedException();
            hms.Include_Files.Utility.ComboboxItem itms = lstdoctorsinformation.SelectedItem as hms.Include_Files.Utility.ComboboxItem;

            string strSQL = "SELECT [DocID],[Title],[Name],[Degree],[Specialist],[Area],(CASE WHEN [Doctor_Type] = 1 THEN 'Listed'  WHEN [Doctor_Type] = 3 THEN 'In House' WHEN [Doctor_Type] = 3 THEN 'Out Source' end) FROM [dbo_Doctor_List] where [DocID]=" + itms.Value.ToString();
            DataTable arrDocInfo = objData.RetriveData(strSQL, ref strErr);
            if (arrDocInfo.Rows.Count > 0)
            { 
                txtdoctorid.Text=arrDocInfo.Rows[0][0].ToString();
                txttitle.Text = arrDocInfo.Rows[0][1].ToString();
                txtrefferedby.Text = arrDocInfo.Rows[0][2].ToString();
                txtdegree.Text = arrDocInfo.Rows[0][3].ToString();
                txtspecialist.Text = arrDocInfo.Rows[0][4].ToString();
                txtarea.Text = arrDocInfo.Rows[0][5].ToString();
                txttype.Text = arrDocInfo.Rows[0][6].ToString();
            }

        }

        private void btnAddDoctor_Click(object sender, EventArgs e)
        {
            frmDoctorsInformation doc = new frmDoctorsInformation();
            doc.Show();
        }

        
    }
}
