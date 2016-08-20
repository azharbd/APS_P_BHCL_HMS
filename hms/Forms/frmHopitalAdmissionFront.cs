using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BatchDLL;
namespace hms.Froms
{
    public partial class frmHopitalAdmissionFront : Form
    {
        public frmHopitalAdmissionFront()
        {
            InitializeComponent();

            C_Data_Batch objData = new C_Data_Batch();
            string strErr="";
            objData.OpenConnection("PolinPC-Office",ref strErr);
            if (strErr != "")
            {
                MessageBox.Show(strErr);
            }
            else
            {
                string sql = "select * from dbo_Services";
                DataTable dt = objData.RetriveData(sql,ref strErr);

                MessageBox.Show(dt.Rows[0][0].ToString());
            }
            objData.CloseConnection();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void lblpermanetaddress_Click(object sender, EventArgs e)
        {

        }

        private void frmHopitalAdmissionFront_Load(object sender, EventArgs e)
        {

        }

        private void txtpresentaddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
