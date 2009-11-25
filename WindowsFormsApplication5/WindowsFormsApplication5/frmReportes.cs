using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.Shared;
using CrystalDecisions.CrystalReports.Engine;

namespace WindowsFormsApplication5
{
    public partial class frmReportes : Form
    {
        protected TableLogOnInfo loginfo = new TableLogOnInfo();
        crCliente reportecliente=new crCliente();
        ReportDocument Reporte = new ReportDocument();
        public frmReportes()
        {
            InitializeComponent();
        }

        private void setlogoninfo()
        {
            
             try
             {
                 loginfo.ConnectionInfo.IntegratedSecurity = true;
                 loginfo.ConnectionInfo.ServerName=".\\SQLEXPRESS";
                 loginfo.ConnectionInfo.DatabaseName="PROYECTO";
                 //loginfo.ConnectionInfo.UserID = "sa";
                 //loginfo.ConnectionInfo.Password = "1234";
             }
             catch(Exception ex)
             {
                 MessageBox.Show(ex.Message);
             }

        }

        private void frmReportes_Load(object sender, EventArgs e)
        {
            setlogoninfo();
            reportecliente.Database.Tables[0].ApplyLogOnInfo(loginfo);

            //que el viewer se iguale al source 
            crvReportes.ReportSource=reportecliente;
        }

    }
}
