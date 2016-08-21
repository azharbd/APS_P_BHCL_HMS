using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using hms.BLL;
using BatchDLL;
namespace hms.DAL
{
    class DoctorDA
    {
        C_Data_Batch objData;
        public bool SaveDoctorInfo(Doctor objDoctor)
        {
            string strErr = "";
            objData = new C_Data_Batch();
            objData.OpenConnection("PolinPC-Home", ref strErr);
            string sql = "Insert into dbo_Doctor_list(Title,DocHospitalId,Name,Degree,Doctype,Phone,IsPc,Address,Area,Specialist,MarketingBy)";
            sql = sql + " values('"+objDoctor.Title+"','"+objDoctor.DoctorId+"','"+objDoctor.DoctorName+"','"+objDoctor.Degree+"'";
            sql = sql + " ,'" + objDoctor.Doctype + "','" + objDoctor.Phone + "'," + objDoctor.IsPC + ",'" + objDoctor.Address + "'";
            sql = sql + " ,'" + objDoctor.Area + "','" + objDoctor.Specialist + "','" + objDoctor.MarketingBy+"')";
            
            objData.ExecuteQuery(sql,ref strErr);
            objData.CloseConnection();
            //objData = null;
            if(strErr=="")
                return true; 
            else
                return false;

            
        }
    }
}
