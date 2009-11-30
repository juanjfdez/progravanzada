using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication5
{
    public partial class frmSoftj : Form
    {
        public frmClientes frmClientes;
        public frmCasos frmCasos;
        public frmUsuarios frmUsuarios;
        public frmDemandado frmDemandado;
        public frmPersonal frmPersonal;
        public frmReportes frmReportes;
        public frmInformacion frmInformacion;
        public AboutUs AboutUs;
        public frmContact frmContact;
        public frmSoftj()
        {
            InitializeComponent();
        }
        public Boolean AbrirCon()
        {
            if (sqlconexion.State != ConnectionState.Open)
                try
                {
                    sqlconexion.Open();
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            return sqlconexion.State == ConnectionState.Open;
        }
        private void tspSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tspClientes_Click(object sender, EventArgs e)
        {
            if ((frmClientes == null) || (frmClientes.IsDisposed))
            {
                frmClientes = new frmClientes();
                frmClientes.MdiParent = this;
                frmClientes.Show();
            }
        }

        private void tspCasos_Click(object sender, EventArgs e)
        {
            if ((frmCasos == null) || (frmCasos.IsDisposed))
            {
                frmCasos = new frmCasos();
                frmCasos.MdiParent = this;
                frmCasos.Show();
            }
        }

        private void horizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void frmSoftj_Load(object sender, EventArgs e)
        {
            AbrirCon();
        }

        private void tspPersonal_Click(object sender, EventArgs e)
        {
            if ((frmPersonal == null) || (frmPersonal.IsDisposed))
            {
                frmPersonal = new frmPersonal();
                frmPersonal.MdiParent = this;
                frmPersonal.Show();
            }

        }

        private void tspReportes_Click(object sender, EventArgs e)
        {
            if ((frmReportes == null) || (frmReportes.IsDisposed))
            {
                frmReportes = new frmReportes();
                frmReportes.MdiParent = this;
                frmReportes.Show();
            }
        }

        private void tspInfo_Click(object sender, EventArgs e)
        {
            if ((frmInformacion == null) || (frmInformacion.IsDisposed))
            {
                frmInformacion = new frmInformacion();
                frmInformacion.MdiParent = this;
                frmInformacion.Show();
            }
        }
    }
}
