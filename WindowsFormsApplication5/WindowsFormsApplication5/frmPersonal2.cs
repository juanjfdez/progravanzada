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
    public partial class frmPersonal2 : Form
    {
        public frmPersonal2()
        {
            InitializeComponent();
        }

        private void btnPersonal_Click(object sender, EventArgs e)
        {
            if ((Program.frmSoftj.frmPersonal == null) || (Program.frmSoftj.frmPersonal.IsDisposed))
            {
                Program.frmSoftj.frmPersonal = new frmPersonal();
                Program.frmSoftj.frmPersonal.MdiParent = Program.frmSoftj;
                Program.frmSoftj.frmPersonal.Show();
            }
        }

        private void btnAbogado_Click(object sender, EventArgs e)
        {
            if ((Program.frmSoftj.frmAbogado == null) || (Program.frmSoftj.frmAbogado.IsDisposed))
            {
                Program.frmSoftj.frmAbogado = new frmAbogado();
                Program.frmSoftj.frmAbogado.MdiParent = Program.frmSoftj;
                Program.frmSoftj.frmAbogado.Show();
            }
        }
    }
}
