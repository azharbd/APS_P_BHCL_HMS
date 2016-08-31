﻿using System;
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
            string strSQL = "";
            strSQL = "select max(P_ID) from dbo_Patient_info";
            DataTable arrCatID = objData.RetriveData(strSQL, ref strErr);
            
            int CatId = 0;

            if (arrCatID.Rows.Count > 0)
            {
                if (arrCatID.Rows[0][0].ToString() == "")
                {
                    CatId = 1;
                }
                else
                {
                    CatId = Convert.ToInt32(arrCatID.Rows[0][0].ToString()) + 1;
                }
            }
            else
            {
                CatId = 1;
            }
            txtid.Text = CatId.ToString();
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

            Decimal intVat;
            Decimal.TryParse(txtvat.Text, out intVat);

            Decimal intPayableAmount = Convert.ToDecimal(totalPayableAmount);
            if (discount > 0)
            {
                intPayableAmount = Convert.ToDecimal(intPayableAmount) - ((Convert.ToDecimal(discount) / 100) * Convert.ToDecimal(totalPayableAmount));
            }

            if (DiscountTaka > 0)
            {
                intPayableAmount = intPayableAmount - Convert.ToDecimal(DiscountTaka);
            }

            intVat = ((Convert.ToDecimal(hms.Include_Files.Utility.intVat) / 100) * Convert.ToDecimal(totalPayableAmount));
            txtvat.Text = intVat.ToString();
            intPayableAmount = intPayableAmount + intVat;

            txtPayableAmount.Text = intPayableAmount.ToString();

            Decimal paidAmount;
            Decimal.TryParse(txtpaidamount.Text, out paidAmount);

            Decimal totalDue = intPayableAmount - paidAmount;

            txttotaldue.Text = totalDue.ToString();
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

        private void txtdiscount_TextChanged(object sender, EventArgs e)
        {
            string Valid = numericCheck(txtdiscount.Text.ToString());
            if (Valid == "F")
            {
                txtdiscount.Text = "";
            }
            else
            {
                getTotalCalculation();
            }
        }

        private string numericCheck(string p)
        {
            string val = "F";
            try
            {
                decimal d = Convert.ToDecimal(p);
                val = "T";
            }
            catch
            {
                MessageBox.Show("Please Enter Numeric");
            }
            return val;
        }

       

        private void txtdiscouuntpersentnance_TextChanged(object sender, EventArgs e)
        {
            string Valid = numericCheck(txtdiscouuntpersentnance.Text.ToString());
            if (Valid == "F")
            {
                txtdiscouuntpersentnance.Text = "";
            }
            else
            {
                getTotalCalculation();
            }
        }

        private void txtpaidamount_TextChanged(object sender, EventArgs e)
        {
            string Valid = numericCheck(txtpaidamount.Text.ToString());
            if (Valid == "F")
            {
                txtpaidamount.Text = "";
            }
            else
            {
                getTotalCalculation();
            }
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
     //       INSERT INTO [dbo_Patient_info]([Name],[PresentAddress],[Phone],[Year],[Month],[Day],[Gender],[PatientID],[BirthDate])
     //VALUES('',,'','',,,0,'',,'')
            objData = new C_Data_Batch();
            objData.OpenConnection("AzharPC-Home", ref strErr);
            saveData();
            objData.CloseConnection();
        }

        private void saveData()
        {
            //throw new NotImplementedException();
            objData.BeginTransaction(ref strErr);
            string strSql = "";
            int year;
            int.TryParse(txtYear.Text, out year);
            int month;
            int.TryParse(txtMonth.Text, out month);
            DateTime thisDay = DateTime.Today;
            Int64 DateDiff = Convert.ToInt64(((year * 12) + month) * 30);
            DateTime totalDays = thisDay.AddDays(-DateDiff);

            MessageBox.Show(totalDays.ToString());
            //strSql = "INSERT INTO [dbo_Patient_info]([Name],[PresentAddress],[Phone],[Year],[Month],[Day],[Gender],[PatientID],[BirthDate]) ";
            //strSql = strSql + "VALUES('" + txtname.Text.ToString() + "','" + txtaddress.Text.ToString() + "','" + txtphone.Text.ToString();
            //strSql = strSql + "',"+txtYear.Text.ToString()+","+txtMonth.Text.ToString()+",0,'"+txtsex.Text.ToString()+"',,'')";
        }

        
    }
}
