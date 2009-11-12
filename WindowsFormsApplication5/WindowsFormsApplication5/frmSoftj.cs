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
        public frmSoftj()
        {
            InitializeComponent();
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

        private void tsMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void verticalToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void horizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }
    }
}
