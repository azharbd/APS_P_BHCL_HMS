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
    public partial class frmInvestigationDueCollection : Form
    {
        public string strErr = "";
        C_Data_Batch objData;
        public frmInvestigationDueCollection()
        {
            InitializeComponent();
        }

        private void cmbInvestigation_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                // Enter key pressed
                //MessageBox.Show(cmbInvestigation.Text.ToString());
            }
        }

        private void frmInvestigationDueCollection_Load(object sender, EventArgs e)
        {
            objData = new C_Data_Batch();
            objData.OpenConnection("AzharPC-Home", ref strErr);
            frmlod();
            objData.CloseConnection();
        }

        private void frmlod()
        {
            //throw new NotImplementedException();

            clearFilds();
            fillgrid();
            fillcombo();

        }

        private void fillcombo()
        {
            //throw new NotImplementedException();
            investigationlist();
            discuntby();
        }

        private void discuntby()
        {
            //throw new NotImplementedException();
            cmbDiscount.Items.Clear();
            cmbDiscount.Items.Add(new hms.Include_Files.Utility.ComboboxItem("Hospital Management Staff", 1));
            cmbDiscount.Items.Add(new hms.Include_Files.Utility.ComboboxItem("MD", 2));
            cmbDiscount.Items.Add(new hms.Include_Files.Utility.ComboboxItem("ChairPerson", 3));
            cmbDiscount.Items.Add(new hms.Include_Files.Utility.ComboboxItem("Doctor", 4));

            cmbDiscount.SelectedIndex = cmbDiscount.FindStringExact("Hospital Management Staff");
        }

        private void investigationlist()
        {
            //throw new NotImplementedException();
            string strSQL = "";
            strSQL = "select InvestigationID, cast((Invetigation_SL) as varchar(10))  +'/'+ cast(month(CreatedON) as varchar(2))+'/'+ cast(year(CreatedON) as varchar(4)) as 'Name' from dbo_Investigation where TotalDue > 0 order by InvestigationID desc";
            DataTable arrInvList = objData.RetriveData(strSQL, ref strErr);

            if (arrInvList.Rows.Count > 0)
            {
                for (int i = 0; i < arrInvList.Rows.Count; i++)
                {
                    cmbInvestigation.Items.Add(new hms.Include_Files.Utility.ComboboxItem(arrInvList.Rows[i][1].ToString(), Convert.ToInt32(arrInvList.Rows[i][0].ToString())));
                }
            }

        }

        private void fillgrid()
        {
            //throw new NotImplementedException();
        }

        private void clearFilds()
        {
            //throw new NotImplementedException();
            txtcashmemono.Text = "";
            txtpaymentremaining.Text = "";
            txtdiscount.Text = "";
            txtpersentance.Text = "";
            txtpaidamount.Text = "";
            txtremainingdue.Text = "";
            txtreceive.Text = "";
            txtreturn.Text = "";
            lblNameNew.Text = "";
            lblAddress.Text = "";
            lblDoctor.Text = "";
            lbltotalamount.Text = "";
            lbltotaldiscount.Text = "";
            lblvat.Text = "";
            lbltotalpayamount.Text = "";
            lbltotalpaid.Text = "";
            lbltotaldue.Text = "";
            lbltotalreturn.Text = "";

                
        }

        private void cmbInvestigation_SelectedIndexChanged(object sender, EventArgs e)
        {
            objData = new C_Data_Batch();
            objData.OpenConnection("AzharPC-Home", ref strErr);
            loadall();
            objData.CloseConnection();
        }

        private void loadall()
        {
            //throw new NotImplementedException();

            hms.Include_Files.Utility.ComboboxItem itms = cmbInvestigation.SelectedItem as hms.Include_Files.Utility.ComboboxItem; 
            string strSQL = "";
            strSQL = "USP_INV_DUE_Collection " + itms.Value.ToString();

            DataTable arrAllInfo = objData.RetriveData(strSQL, ref strErr);

            //DataSet ds = new DataSet();
            //ds.Tables.Add(arrAllInfo);
            //dgvDueCollection.DataSource = ds.Tables["Table1"];
            

            if (arrAllInfo.Rows.Count > 0)
            {
                lblNameNew.Text = arrAllInfo.Rows[0][0].ToString();
                lblAddress.Text = arrAllInfo.Rows[0][1].ToString();
                lblDoctor.Text = arrAllInfo.Rows[0][2].ToString();

                lbltotalamount.Text = arrAllInfo.Rows[0][4].ToString();
                lbltotaldiscount.Text = "";
                lblvat.Text = arrAllInfo.Rows[0][8].ToString();
                lbltotalpayamount.Text = arrAllInfo.Rows[0][4].ToString();
                lbltotalpaid.Text = arrAllInfo.Rows[0][9].ToString();
                int totalDue = Convert.ToInt16(arrAllInfo.Rows[0][4].ToString()) - Convert.ToInt16(arrAllInfo.Rows[0][9].ToString());
                lbltotaldue.Text = totalDue.ToString();
                lbltotalreturn.Text = arrAllInfo.Rows[0][10].ToString();

                int totalDiscountAmount = 0;

                totalDiscountAmount = Convert.ToInt16(arrAllInfo.Rows[0][6].ToString()) * Convert.ToInt16(arrAllInfo.Rows[0][6].ToString()) / 100;
                totalDiscountAmount = totalDiscountAmount + Convert.ToInt16(arrAllInfo.Rows[0][7].ToString());
                lbltotaldiscount.Text = totalDiscountAmount.ToString();
                txtpaymentremaining.Text = totalDue.ToString();
                txtdiscount.Text = arrAllInfo.Rows[0][7].ToString();
                txtpersentance.Text = arrAllInfo.Rows[0][6].ToString();
                //txtpaidamount.Text = arrAllInfo.Rows[0][9].ToString();
                txtremainingdue.Text = totalDue.ToString();
                txtpayableamount.Text = arrAllInfo.Rows[0][4].ToString();
            }



        }

        private void txtdiscount_TextChanged(object sender, EventArgs e)
        {
            getcalclalculation();


        }

        private void getcalclalculation()
        {
            //throw new NotImplementedException();
            int totalDiscountTake = 0;
            int totalDiscountParsentence = 0;

            if (txtdiscount.Text.ToString() != "")
            {
                totalDiscountTake = Convert.ToInt16(txtdiscount.Text.ToString());
            }
            if (txtpersentance.Text.ToString() != "")
            {
                totalDiscountParsentence = Convert.ToInt16(txtpayableamount.Text.ToString()) * (Convert.ToInt16(txtpersentance.Text.ToString()) / 100);
            }
            int toDue = 0;
            if (txtpaidamount.Text.ToString() != "")
            {
                if (txtpayableamount.Text.ToString() != "")
                {
                    toDue  = (Convert.ToInt16(txtpayableamount.Text.ToString()) - (totalDiscountTake + totalDiscountParsentence));
                }
            }
            else
            {
                toDue = (Convert.ToInt16(txtpayableamount.Text.ToString()) - (totalDiscountTake + totalDiscountParsentence)) - Convert.ToInt16(txtpaidamount.Text.ToString());
            }

            txtremainingdue.Text = toDue.ToString();
        }
    }
}
