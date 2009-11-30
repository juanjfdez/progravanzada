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
        crCliente reportecliente1=new crCliente();
        crCliente2 reportecliente2 = new crCliente2();
        crCliente3 reportecliente3 = new crCliente3();
        ReportDocument Reporte = new ReportDocument();
        public frmReportes()
        {
            InitializeComponent();
        }

        private void setlogoninfo()
        {
            
             try
             {
                 //loginfo.ConnectionInfo.IntegratedSecurity = true;
                 loginfo.ConnectionInfo.ServerName=".\\SQLEXPRESS";
                 loginfo.ConnectionInfo.DatabaseName="PROYECTO";
                 loginfo.ConnectionInfo.UserID = "sa";
                 loginfo.ConnectionInfo.Password = "1234";
             }
             catch(Exception ex)
             {
                 MessageBox.Show(ex.Message);
             }

        }

        private void frmReportes_Load(object sender, EventArgs e)
        {
            setlogoninfo();
        }

            
        private void parte1ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            reportecliente1.Database.Tables[0].ApplyLogOnInfo(loginfo);
            //que el viewer se iguale al source 
            crvReportes.ReportSource = reportecliente1;
            crvReportes.Refresh();
        }

        private void parte2ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            reportecliente2.Database.Tables[0].ApplyLogOnInfo(loginfo);
            //que el viewer se iguale al source 
            crvReportes.ReportSource = reportecliente2;
            crvReportes.Refresh();
        }

        private void parte3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reportecliente3.Database.Tables[0].ApplyLogOnInfo(loginfo);
            //que el viewer se iguale al source 
            crvReportes.ReportSource = reportecliente3;
            crvReportes.Refresh();
        }

        


    }
}
