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
            gcAdmin.DataSource = null;
            
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
            if (tabla == "Cliente")
            {
                string fila1, fila2;
                try
                {
                fila1 = gvAdmin.GetFocusedRowCellValue("Nombre").ToString();
                fila2 = gvAdmin.GetFocusedRowCellValue("Direccion").ToString();
                
                    query.CommandText = "DELETE FROM Cliente WHERE Nombre=@Nombre and Direccion=@Direccion";

                    //parametros
                    query.Parameters.Clear();
                    query.Parameters.AddWithValue("@Nombre", fila1);
                    query.Parameters.AddWithValue("@Direccion", fila2);
                    if (query.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Cliente Eliminado");
                    }
                    btnBuscar.PerformClick();
                }
                catch (Exception erroreliminar)
                {
                    MessageBox.Show(erroreliminar.Message, "Error");
                }
            }
            else if (tabla == "Casos")
            {
                string fila = "";
                try
                {
                fila = gvAdmin.GetFocusedRowCellValue("Numero Caso").ToString();
                
                    query.CommandText = "DELETE FROM Casos WHERE id_caso=@id_caso";

                    //parametros
                    query.Parameters.Clear();
                    query.Parameters.AddWithValue("@id_caso", fila);
                    if (query.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Caso Eliminado");
                    }
                    btnBuscar.PerformClick();
                }
                catch (Exception erroreliminar)
                {
                    MessageBox.Show(erroreliminar.Message, "Error");
                }
            }
            else if (tabla == "Personal")
            {
                string fila1, fila2;
                try
                {
                fila1 = gvAdmin.GetFocusedRowCellValue("Nombre Empleado").ToString();
                fila2 = gvAdmin.GetFocusedRowCellValue("Direccion").ToString();
                
                    query.CommandText = "DELETE FROM Datos_Personal WHERE Nombre_emp=@Nombre and Direccion_emp=@Direccion";

                    //parametros
                    query.Parameters.Clear();
                    query.Parameters.AddWithValue("@Nombre", fila1);
                    query.Parameters.AddWithValue("@Direccion", fila2);
                    if (query.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Empleado Eliminado");
                    }
                    btnBuscar.PerformClick();
                }
                catch (Exception erroreliminar)
                {
                    MessageBox.Show(erroreliminar.Message, "Error");
                }
            }
            else if (cbbTablas.Text == "Demandado")
            {
                string fila1;
                try
                {
                fila1 = gvAdmin.GetFocusedRowCellValue("Nombre").ToString();
               
                    query.CommandText = "DELETE FROM Demandado WHERE Nombre=@Nombre";

                    //parametros
                    query.Parameters.Clear();
                    query.Parameters.AddWithValue("@Nombre", fila1);
                    if (query.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Empresa Eliminada");
                    }
                    btnBuscar.PerformClick();
                }
                catch (Exception erroreliminar)
                {
                    MessageBox.Show(erroreliminar.Message, "Error");
                }
            }
            else if (cbbTablas.Text == "Abogado")
            {
                string fila1;
                try
                {
                    fila1 = gvAdmin.GetFocusedRowCellValue("id_abogado").ToString();

                    query.CommandText = "DELETE FROM Abogado WHERE id_abogado=@id_abogado";

                    //parametros
                    query.Parameters.Clear();
                    query.Parameters.AddWithValue("@id_abogado", fila1);
                    if (query.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Empresa Eliminada");
                    }
                    btnBuscar.PerformClick();
                }
                catch (Exception erroreliminar)
                {
                    MessageBox.Show(erroreliminar.Message, "Error");
                }
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

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            gcAdmin.DataSource = null;
            gvAdmin.Columns.Clear();
        }
    }
}
