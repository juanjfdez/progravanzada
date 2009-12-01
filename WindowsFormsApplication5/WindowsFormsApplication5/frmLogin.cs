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
    public partial class frmLogin : Form
    {
        public string usuario = "";
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if ((txtUser.Text.ToUpper() == "ADMINISTRADOR") && (txtPass.Text == "asd"))
            {
                usuario = "administrador";
                this.Close();
            }
            else if ((txtUser.Text.ToUpper() == "ABOGADO") && (txtPass.Text == "zxc"))
            {
                this.Close();
            }
            else if ((txtUser.Text.ToUpper() == "ASISTENTE") && (txtPass.Text == "qwe"))
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Dato incorrecto");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
