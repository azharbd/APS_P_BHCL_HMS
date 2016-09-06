using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace hms.Forms
{
    public partial class frmmainfrom : Form
    {
        public frmmainfrom()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void frontDeskInvestigationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmfrontdeskinvestigation f = new frmfrontdeskinvestigation();
            f.MdiParent = this;
            f.Show();

        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frontDeskInvestigationDueCollectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInvestigationDueCollection f = new frmInvestigationDueCollection();
            f.MdiParent = this;
            f.Show();
        }

        private void frontDeskSearchbEdToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInvestigationSearchEdit f = new frmInvestigationSearchEdit();
            f.MdiParent = this;
            f.Show();
        }

        private void investigationReturnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInvestigationReturn f = new frmInvestigationReturn();
            f.MdiParent = this;
            f.Show();
        }

        private void reportDeliveryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReportDelivery f = new frmReportDelivery();
            f.MdiParent = this;
            f.Show();
        }

        private void hospitalAdmissionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHopitalAdmissionFront f = new frmHopitalAdmissionFront();
            f.MdiParent = this;
            f.Show();
        }

        private void hospitalDepositToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHospitalDeposit f = new frmHospitalDeposit();
            f.MdiParent = this;
            f.Show();
        }

        private void hospitalOtherServiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHospitalOtherService f = new frmHospitalOtherService();
            f.MdiParent = this;
            f.Show();
        }

        private void consultantVisitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultantVisit f = new frmConsultantVisit();
            f.MdiParent = this;
            f.Show();
        }

        private void sampleCollectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInvestigationsamplecollection f = new frmInvestigationsamplecollection();
            f.MdiParent = this;
            f.Show();
        }

        private void pathologyProcessToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPathologylab f = new frmPathologylab();
            f.MdiParent = this;
            f.Show();
        }

        private void doctorsInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDoctorsInformation f = new frmDoctorsInformation();
            f.MdiParent = this;
            f.Show();
        }

        private void categoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCategory f = new frmCategory();
            f.MdiParent = this;
            f.Show();
        }

        private void serviceItemInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmserviceiteminformation f = new frmserviceiteminformation();
            f.MdiParent = this;
            f.Show();
        }

        private void serviceWiseListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmServiceWiseList f = new frmServiceWiseList();
            f.MdiParent = this;
            f.Show();
        }

        private void employeeProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEmployeeProfile f = new frmEmployeeProfile();
            f.MdiParent = this;
            f.Show();
        }
    }
}
