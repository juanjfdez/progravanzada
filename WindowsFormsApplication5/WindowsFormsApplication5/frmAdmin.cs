using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication5
{
    public partial class frmAdmin : Form
    {
        protected string tabla = "";
        SqlCommand query = new SqlCommand();
        DataSet dsDatos = new DataSet();
        public frmAdmin()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            gvAdmin.ClearColumnErrors();
            dsDatos.Clear();
            SqlDataAdapter adaptador = new SqlDataAdapter(query);

            query.CommandText = "SELECT * FROM " + tabla;

            // limpia datos del data user
            dsDatos.Clear();
            //llena datos en el data set
            adaptador.Fill(dsDatos, tabla);
            //asigna el resultado de la consulta al grid
            gcAdmin.DataSource = dsDatos.Tables[tabla];
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (cbbTablas.Text == "Cliente")
            {

            }
            else if (cbbTablas.Text == "Casos")
            {

            }
            else if (cbbTablas.Text == "Personal")
            {

            }
            else if (cbbTablas.Text == "Demandado")
            {

            }
            else if (cbbTablas.Text == "Abogado")
            {

            }
            else if ((cbbTablas.Text == "") || (cbbTablas.Text == "- Elegir Tabla -"))
            {
                MessageBox.Show("Escoger Tabla");
            }
        }

        private void frmAdmin_Load(object sender, EventArgs e)
        {
            Program.frmSoftj.AbrirCon();
            query.Connection = Program.frmSoftj.sqlconexion;
        }

        private void cbbTablas_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbbTablas.Text)
            {
                case "Cliente":
                    {
                        tabla = "Cliente";
                        break;
                    }
                case "Casos":
                    {
                        tabla = "Casos";
                        break;
                    }
                case "Personal":
                    {
                        tabla = "Datos_Personal";
                        break;
                    }
                case "Demandado":
                    {
                        tabla = "Demandado";
                        break;
                    }
                case "Abogado":
                    {
                        tabla = "Abogado";
                        break;
                    }
                default:
                    {
                        MessageBox.Show("No ha escogido tabla");
                        break;
                    }
            }
        }
    }
}
