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
    public partial class frmLogin : Form
    {
        public string usuario = "";
        SqlCommand query=new SqlCommand();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                // sqlDataReader lee los datos que se llaman
                SqlDataReader sqllector = null;
                //Command realiza los comandos a la base de datos
                query.CommandText = "SELECT nombre FROM Usuario WHERE (Password=@Password) and (Puesto=@Nombre)";
                query.Parameters.Clear();
                query.Parameters.AddWithValue("@Password", txtPass.Text);
                query.Parameters.AddWithValue("@Nombre", txtUser.Text);

                sqllector = query.ExecuteReader();
                if (sqllector.HasRows)
                {
                        if (txtUser.Text.ToUpper() == "ADMINISTRADOR")
                            usuario = "administrador";
                        lblUsuario.Visible = false;
                        sqlusuario.Close();
                        this.Close();

                }
                else
                {
                        lblUsuario.Visible = true;
                        txtUser.Focus();
                }
                   
               
            }
            catch (Exception error1)
            {
                MessageBox.Show(error1.Message, "ERROR");
            }


        }
        public Boolean AbrirCon2()
        {
            if (sqlusuario.State != ConnectionState.Open)
                try
                {
                    sqlusuario.Open();
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            return sqlusuario.State == ConnectionState.Open;
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            AbrirCon2();
            query.Connection = sqlusuario;
        }
    }
}
