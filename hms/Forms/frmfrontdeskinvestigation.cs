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
        }

        
    }
}
