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
    public partial class frmHopitalAdmissionFront : Form
    {
        C_Data_Batch objData;
        public frmHopitalAdmissionFront()
        {
            InitializeComponent();

            string admissionid = "1";
            objData = new C_Data_Batch();
            string strErr = "";
            objData.OpenConnection("PolinPC-Office", ref strErr);
            if (strErr != "")
            {
                MessageBox.Show(strErr);
            }
            else
            {
                
                string sql = "select top 1 admission_id from dbo_Admission order by admission_id desc";
                DataTable dt = objData.RetriveData(sql, ref strErr);
                if (dt.Rows.Count > 0)
                {
                    admissionid = Convert.ToString(Convert.ToInt16(dt.Rows[0][0]) + 1);
                }
                
            }

            txtadmissionid.Text = admissionid;

            string strSQL = "";
            strSQL = "select DocID, Name from dbo_Doctor_List order by Name";
            DataTable doctorList = objData.RetriveData(strSQL, ref strErr);
            objData.CloseConnection();

            if (strErr == "")
            {
                if (doctorList.Rows.Count > 0)
                {
                    for (int i = 0; i < doctorList.Rows.Count; i++)
                    {
                        lstdoctorsinformation.Items.Add(new hms.Include_Files.Utility.ComboboxItem(doctorList.Rows[i][1].ToString(), Convert.ToInt32(doctorList.Rows[i][0].ToString())));
                    }
                }
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

        private void btnsave_Click(object sender, EventArgs e)
        {
            Include_Files.Utility objUtility=new Include_Files.Utility();
            int userid=Include_Files.Utility.userID;
            string patientName = txtPatientName.Text.ToString();
            string day = txtdd.Text.ToString();
            string month = txtmm.Text.ToString();
            string year = txtyyy.Text.ToString();
            string gender = txtgender.Text.ToString();
            bool isFathertemp = rbtnfathername.Checked;
            bool isHusbandtemp = rbtnhusbandname.Checked;
            string txtFatherOrHusband = txtFatherOrHusbandname.Text.ToString();
            string mothername = txtMotherName.Text.ToString();
            string religion = txtReligion.Text.ToString();
            string occupation = txtoccupation.Text.ToString();
            string guardian = txtguardian.Text.ToString();
            string guardianAddress = txtGuardianAddress.Text.ToString();
            string patientPresentAddress = txtpresentaddress.Text.ToString();
            string patientParmanentAddress = txtpermanetaddress.Text.ToString();
            string patientPhone = txtphone.Text.ToString();
            string birthDate = month+"/"+day+"/"+year;
            DateTime dtbirthDate=DateTime.Now;

            int isFather=1;
            if(isHusbandtemp)
            {
                isFather=0;
            }
            if (objUtility.IsDate(birthDate))
            {
                dtbirthDate = Convert.ToDateTime(birthDate);
            }

            string strErr = "";
            objData.OpenConnection("PolinPC-Office", ref strErr);
            objData.BeginTransaction(ref strErr);

            string insertPatientinfo="Insert into dbo_patient_info(Name,PresentAddress,Phone,Year,Month,Day,Gender,PatientID,BirthDate,UserID) values";
            insertPatientinfo += "('" + patientName + "','" + patientPresentAddress + "','" + patientPhone + "'," + year + "," + month + "," + day + ",'" + gender + "',1,'" + dtbirthDate + "'," + userid + ")";
            objData.ExecuteQuery(insertPatientinfo,ref strErr);
            string sqlSelectPatientId = "select p_id from dbo_patient_info where Phone='" + patientPhone + "' and Name='"+patientName+"' order by p_id desc";
            DataTable dtSelectPatientId = objData.RetriveData(sqlSelectPatientId,ref strErr);
            string sqlInsertPatientOtherInfo="";
            if (strErr == "")
            {
                sqlInsertPatientOtherInfo = "Insert into dbo_Patient_other_info(P_ID,IsFather,ForH_Name,Region,Occupation,Guardian,Parmanent_address) values";
                sqlInsertPatientOtherInfo += "(" + dtSelectPatientId.Rows[0][0] + "," + isFather + ",'" + txtFatherOrHusband + "','" + religion + "','" + occupation + "','" + guardian + "','" + patientParmanentAddress + "')";
                objData.ExecuteQuery(sqlInsertPatientOtherInfo, ref strErr);
            }
            else
            {
                MessageBox.Show(insertPatientinfo);
            }
            if (strErr != "")
            {
                MessageBox.Show(sqlInsertPatientOtherInfo);
                objData.Rollback(ref strErr);
            }
            else
            {
                objData.CommitTransaction(ref strErr);
            }
            objData.CloseConnection();

            if (strErr == "")
            {
                MessageBox.Show("Successfully admitted");
            }
            
        }
    }
}
