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
    public partial class frmInvestigationReturn : Form
    {
        string strErr = "";
        C_Data_Batch objData;

        public frmInvestigationReturn()
        {
            InitializeComponent();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmInvestigationReturn_Load(object sender, EventArgs e)
        {
            frmLOad();
        }

        private void frmLOad()
        {
            //throw new NotImplementedException();\
            DateTime dt = DateTime.Today;
            txtInvestigationID.Text = "/"+dt.Month.ToString()+"/"+dt.Year;
            txtcashmemoid.Text = "";
            dgvRetrurn.Columns.Clear();
            dgvRetrurn.Refresh();
            lblName.Text = "";
            lblAddress.Text = "";
            lblDoctor.Text = "";
            lbltotalamount.Text = "";
            lbltotaldiscount.Text = "";
            lblvat.Text = "";
            lbltotalpayamount.Text = "";
            lbltotalpaid.Text = "";
            lbltotalreturn.Text = "";
            lbltotaldue.Text = "";
            //LoadSerial();

        }

        private void LoadSerial()
        {
            if (dgvRetrurn.Rows.Count > 1)
            {
                for (int i = 0; i < dgvRetrurn.Rows.Count - 1; i++)
                {
                    dgvRetrurn.Rows[i].Cells[0].Value = (i + 1).ToString();
                }
            }
        }

        private void btnnew_Click(object sender, EventArgs e)
        {
            frmLOad();
        }

        

        private void txtInvestigationID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {


                string strVal = "";

                strVal = txtInvestigationID.Text.ToString();


                string[] arrinv = strVal.Split(new string[] { "/" }, StringSplitOptions.None);


                if (arrinv.Length.ToString() == "3")
                {
                    if (arrinv[0].ToString() == "")
                    {
                        MessageBox.Show("please enter valid investifgation no.");
                    }
                    else
                    {
                        if (arrinv[1].ToString() == "")
                        {
                            MessageBox.Show("please enter valid Month no.");
                        }
                        else
                        {
                            if (arrinv[2].ToString() == "")
                            {
                                MessageBox.Show("please enter valid year no.");
                            }
                            else
                            {
                                string strSql = "";
                                strSql = "USP_INV_RETURNCOLLECTION " + arrinv[0].ToString() + ", " + arrinv[1].ToString() + ", " + arrinv[2].ToString() ;
                                objData = new C_Data_Batch();
                                objData.OpenConnection("AzharPC-Home", ref strErr);

                                DataTable dt = objData.RetriveData(strSql, ref strErr);

                                DataSet ds = new DataSet();
                                ds.Tables.Add(dt);

                                dgvRetrurn.DataSource = ds.Tables["Table1"];

                                dgvRetrurn.Columns["Patent Name"].Visible = false;
                                dgvRetrurn.Columns["Address"].Visible = false;
                                dgvRetrurn.Columns["Doctor Name"].Visible = false;
                                dgvRetrurn.Columns["Total Amount"].Visible = false;
                                dgvRetrurn.Columns["Payment Remaining"].Visible = false;
                                dgvRetrurn.Columns["Discount Parsentence"].Visible = false;
                                dgvRetrurn.Columns["Distount taka"].Visible = false;
                                dgvRetrurn.Columns["Total Vat"].Visible = false;
                                dgvRetrurn.Columns["Patent Name"].Visible = false;
                                dgvRetrurn.Columns["Total Return"].Visible = false;
                                dgvRetrurn.Columns["Invertigation"].Visible = false;
                                dgvRetrurn.Columns["invItemID"].Visible = false;

                                dgvRetrurn.Columns["DiscountByID"].Visible = false;
                                dgvRetrurn.Columns["Totl Paid"].Visible = false;

                                lblName.Text = dt.Rows[0][5].ToString();
                                lblAddress.Text = dt.Rows[0][6].ToString();
                                lblDoctor.Text = dt.Rows[0][7].ToString();

                                int totalAmount = 0;
                                totalAmount = Convert.ToInt16(dt.Rows[0][9].ToString());

                                int totalDiscountTake = 0;
                                totalDiscountTake = Convert.ToInt16(dt.Rows[0][12].ToString());
                                int totalDiscountParsentence = 0;
                                totalDiscountParsentence = Convert.ToInt16(Math.Floor(Convert.ToDecimal(totalAmount.ToString()) * (Convert.ToDecimal(dt.Rows[0][11].ToString()) / 100)));

                                int totalDiscount = 0;

                                totalDiscount = totalDiscountTake + totalDiscountParsentence;


                                lbltotalamount.Text = dt.Rows[0][9].ToString();
                                lblvat.Text = dt.Rows[0][13].ToString();
                                lbltotalpayamount.Text = dt.Rows[0][10].ToString();
                                lbltotaldiscount.Text = totalDiscount.ToString();
                                lbltotalpaid.Text = dt.Rows[0][14].ToString();
                                lbltotalreturn.Text = dt.Rows[0][15].ToString();
                                lbltotaldue.Text = dt.Rows[0][10].ToString();
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("please enter valid investifgation no.");

                }

            }
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(dgvRetrurn.Rows[0].Cells[0].Value.ToString());
            //MessageBox.Show(dgvRetrurn.Rows[1].Cells[17].Value.ToString());
            objData = new C_Data_Batch();
            objData.OpenConnection("AzharPC-Home", ref strErr);
            string strSQL = "";
            objData.BeginTransaction(ref strErr);
            for (int i = 0; i < dgvRetrurn.Rows.Count -1; i++)
            {
                if (Convert.ToInt16(dgvRetrurn.Rows[i].Cells[3].Value.ToString()) > 0)
                {
                    strSQL = "update dbo_InvertigationServiceItem set isreturn =1, return_on = getdate(), Return_Amount = " + dgvRetrurn.Rows[i].Cells[3].Value.ToString() + " where ISI_ID=" + dgvRetrurn.Rows[i].Cells[17].Value.ToString();
                    objData.ExecuteQuery(strSQL, ref strErr);
                }
            }

            if (strErr.ToString() == "")
            {
                MessageBox.Show("Investigation return succefully done.");
                objData.CommitTransaction(ref strErr);
            }
            else
            {
                MessageBox.Show("Investigation not return.");
                objData.Rollback(ref strErr);
            }

        }
    }
}
