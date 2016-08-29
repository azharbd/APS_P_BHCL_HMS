using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace hms
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
       //Application.Run(new Froms.frmlogin());
           //Application.Run(new Froms.frmfrontdeskinvestigation());
            //Application.Run(new Froms.frmserviceiteminformation());
            //Application.Run(new hms.Forms.frmserviceiteminformation()); 
          //Application.Run(new Froms.frmDoctorsInformation());
           // Application.Run(new Froms.frmserviceiteminformation());
            //Application.Run(new Froms.frmfrontdeskinvetigationreturn());
            //Application.Run(new Forms.frmDoctorsInformation());
           // Application.Run(new Froms.frmHospitalDeposit());
            //Application.Run(new hms.Forms.frmCategory());
            Application.Run(new hms.Forms.frmfrontdeskinvestigation());
        }
    }

}
