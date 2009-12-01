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
using System.Threading;

namespace WindowsFormsApplication5
{
    public partial class frmSoftj : Form
    {
        //conexion 
        public SqlConnection sqlconexion = new SqlConnection();
        
        public frmClientes frmClientes;
        public frmCasos frmCasos;
        public frmDemandado frmDemandado;
        public frmPersonal frmPersonal;
        public frmPersonal2 frmPersonal2;
        public frmReportes frmReportes;
        public frmInformacion frmInformacion;
        public AboutUs AboutUs;
        public frmContact frmContact;
        public frmInicializacion frmInicializacion;
        public frmDemandas frmDemandas;
        public frmAbogado frmAbogado;
        public frmAdmin frmAdmin;
        public frmLogin frmLogin;
        public frmSoftj()
        {
            Thread th = new Thread(new ThreadStart(DoSplash));
            th.Start();
            Thread.Sleep(4000);
            th.Abort();
            Thread.Sleep(1000);
            InitializeComponent();
            sqlconexion.ConnectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=PROYECTO;Integrated Security=True";
            frmLogin = new frmLogin();
            frmLogin.ShowDialog();
        }
        private void DoSplash()
        {

            frmInicializacion sp = new frmInicializacion();
            sp.ShowDialog();

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
            if (frmLogin.usuario == "administrador")
                tsbAdministrador.Enabled = true;
            else
                tsbAdministrador.Enabled = false;
        }

        private void tspPersonal_Click(object sender, EventArgs e)
        {
            if ((frmPersonal2 == null) || (frmPersonal2.IsDisposed))
            {
                frmPersonal2 = new frmPersonal2();
                frmPersonal2.MdiParent = this;
                frmPersonal2.Show();
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

        private void tspDemandas_Click(object sender, EventArgs e)
        {
            if ((frmAdmin == null) || (frmDemandas.IsDisposed))
            {
                frmDemandas = new frmDemandas();
                frmDemandas.MdiParent = this;
                frmDemandas.Show();
            }
        }

        private void tsbAdministrador_Click(object sender, EventArgs e)
        {
            if ((frmAdmin == null) || (frmAdmin.IsDisposed))
            {
                frmAdmin = new frmAdmin();
                frmAdmin.MdiParent = this;
                frmAdmin.Show();
            }
        }

        private void tspCerrarSession_Click(object sender, EventArgs e)
        {
            frmLogin.ShowDialog();
            if (frmLogin.usuario == "administrador")
                tsbAdministrador.Enabled = true;
            else
                tsbAdministrador.Enabled = false;
        }

    }
}
