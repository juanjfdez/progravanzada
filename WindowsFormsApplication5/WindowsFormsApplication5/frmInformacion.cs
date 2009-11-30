using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication5
{
    public partial class frmInformacion : Form
    {
        public frmInformacion()
        {
            InitializeComponent();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            if ((Program.frmSoftj.AboutUs == null) || (Program.frmSoftj.AboutUs.IsDisposed))
            {
                Program.frmSoftj.AboutUs = new AboutUs();
                Program.frmSoftj.AboutUs.MdiParent = Program.frmSoftj;
                Program.frmSoftj.AboutUs.Show();
            }
        }

        private void btnDemInfo_Click(object sender, EventArgs e)
        {
            if ((Program.frmSoftj.frmDemandado == null) || (Program.frmSoftj.frmDemandado.IsDisposed))
            {
                Program.frmSoftj.frmDemandado = new frmDemandado();
                Program.frmSoftj.frmDemandado.MdiParent = Program.frmSoftj;
                Program.frmSoftj.frmDemandado.Show();
            }
        }

        private void btnRepInfo_Click(object sender, EventArgs e)
        {
            if ((Program.frmSoftj.frmContact == null) || (Program.frmSoftj.frmContact.IsDisposed))
            {
                Program.frmSoftj.frmContact = new frmContact();
                Program.frmSoftj.frmContact.MdiParent = Program.frmSoftj;
                Program.frmSoftj.frmContact.Show();
            }
        }
    }
}
