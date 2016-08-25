using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using hms.BLL;
using hms.DAL;
namespace hms.Forms
{
    public partial class frmDoctorsInformation : Form
    {
        public frmDoctorsInformation()
        {
            InitializeComponent();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            hms.Include_Files.Utility.ComboboxItem itms = drDoctorType.SelectedItem as hms.Include_Files.Utility.ComboboxItem;
            if (itms != null)
            {
                MessageBox.Show(itms.Value.ToString());
            }
            Doctor objDoctor = new Doctor();
            objDoctor.Title = txttitle.Text.ToString();
            objDoctor.DoctorId = txtdoctorsid.Text.ToString();
            objDoctor.DoctorName = txtdoctorname.Text.ToString();
            objDoctor.Degree = txtdegree.Text.ToString();
            objDoctor.Area = txtAddress.Text.ToString();
            //objDoctor.Doctype = drDoctorType.SelectedValue.ToString();
            objDoctor.Doctype = "";
            objDoctor.Phone = txtPhone.Text.ToString();
            objDoctor.IsPC =chkbispc.Checked.ToString();
            objDoctor.Specialist = txtspecialist.Text.ToString();
            objDoctor.MarketingBy = txtMarketingBy.Text.ToString();

            DoctorDA objDoctorDA = new DoctorDA();
            objDoctorDA.SaveDoctorInfo(objDoctor);

            
        }

        private void btnedit_Click(object sender, EventArgs e)
        {

        }

        private void frmDoctorsInformation_Load(object sender, EventArgs e)
        {
            DoctorDA objDoctorDA = new DoctorDA();
            txtdoctorsid.Text = objDoctorDA.getDoctorId().ToString();

            drDoctorType.Items.Add(new hms.Include_Files.Utility.ComboboxItem ("Listed", 1));
            drDoctorType.Items.Add(new hms.Include_Files.Utility.ComboboxItem("In House", 2));
            drDoctorType.Items.Add(new hms.Include_Files.Utility.ComboboxItem("Out Source", 3));

            //to select the selected item
            drDoctorType.SelectedIndex = drDoctorType.FindStringExact("Listed");
        }

        private void drDoctorType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        
    }
}
