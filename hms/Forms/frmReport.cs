﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;

namespace hms.Forms
{
    public partial class frmReport : Form
    {
        public ReportDocument ReportDoc = new ReportDocument();
        public string ReportPath;
        public string ReportSQL;
        public DataSet Reportds = new DataSet();
        
        public frmReport()
        {
            InitializeComponent();
        }

        private void frmReport_Load(object sender, EventArgs e)
        {
            ReportDoc.Load(ReportPath);
            ReportDoc.SetDataSource(Reportds.Tables[0]);
            //crystalReportViewer1.ReportSource = ReportDoc;
            //.reportSource = ReportDoc;
            crvViewer.ReportSource = ReportDoc;
        }

        

        
    }
}
