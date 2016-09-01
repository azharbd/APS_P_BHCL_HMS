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
    public partial class frmInvestigationsamplecollection : Form
    {
        C_Data_Batch objData;
        public string strErr = "";
        public frmInvestigationsamplecollection()
        {
            InitializeComponent();
        }

        private void frmInvestigationsamplecollection_Load(object sender, EventArgs e)
        {
            objData = new C_Data_Batch();
            objData.OpenConnection("AzharPC-Home", ref strErr);
            frmLoad();
            objData.CloseConnection();


        }

        private void frmLoad()
        {
            
        }
    }
}
