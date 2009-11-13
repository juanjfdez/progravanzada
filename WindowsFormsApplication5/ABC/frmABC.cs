using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using Microsoft.Office;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ABC
{
    public partial class frmABC : Form
    {
        SqlCommand querynuevo = new SqlCommand();
        SqlCommand querybuscar = new SqlCommand();
        SqlCommand querymod = new SqlCommand();
        public frmABC()
        {
            InitializeComponent();
        }

        private void tbNuevo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
