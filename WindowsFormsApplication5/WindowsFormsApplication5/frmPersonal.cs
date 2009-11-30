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
    public partial class frmPersonal : ABC.frmABC
    {
        public frmPersonal()
        {
            InitializeComponent();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarControles();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // verifica que no este ningun dato en blanco
            //PUESTO
            if (cbbPuesto.Text == "- Elija Puesto del Empleado -")
            {
                error_info.SetError(cbbPuesto, "Por favor especifique el puesto del empleado");
                bandera = false;
            }
            else
                error_info.SetError(cbbPuesto, "");
            //Sexo
            if (rdSexoEmp.Text == "")
            {
                error_info.SetError(rdSexoEmp, "Por favor especifique el sexo del cliente");
                bandera = false;
            }
            else
                error_info.SetError(rdSexoEmp, "");

            //para cuando no tiene nada escrito
            ErrorPersonalizadoEjecucion();


            //Se inicia la insercion
            if (bandera)
            {
                query.CommandText = @"EXEC InsertarPersonal
                @Nombre_emp,@Telefono_emp,@Edad_emp,@Seguro_emp,@Puesto_emp,@Direccion_emp,@Sexo_emp";

                //PARAMETROS
                query.Parameters.Clear();
                query.Parameters.AddWithValue("@Nombre_emp", txtNomEmp.Text);
                query.Parameters.AddWithValue("@Telefono_emp", txtTelEmp.Text);
                query.Parameters.AddWithValue("@Edad_emp", Convert.ToInt32(txtEdad.Text));
                query.Parameters.AddWithValue("@Seguro_emp", txtSeguro.Text);
                query.Parameters.AddWithValue("@Puesto_emp", cbbPuesto.Text);
                query.Parameters.AddWithValue("@Direccion_emp", txtDireccionEmp.Text);
                query.Parameters.AddWithValue("@Sexo_emp", rdSexoEmp.Text);

                //ejecucion del query
                if (query.ExecuteNonQuery() > 0)
                    MessageBox.Show("Empleado Agregado");
            }
            
        }

        private void frmPersonal_Load(object sender, EventArgs e)
        {
            Program.frmSoftj.AbrirCon();
            query.Connection = Program.frmSoftj.sqlconexion;

            // asignacion te errores para la insercion
            ErrorPersonalizadoInicio();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dsDatos.Clear();
            SqlDataAdapter adaptador = new SqlDataAdapter(query);

            //Se hace la busqueda
            query.CommandText = @"SELECT Nombre_emp as [Nombre Empleado], Telefono_emp as Telefono, Edad_emp as Edad, 
            Seguro_emp as Seguro, Puesto_emp as Puesto, Direccion_emp as Direccion, Sexo_emp as Sexo
            FROM Datos_Personal";

            //limpia datos del data user
            dsDatos.Clear();

            //se llena datos en el data user
            adaptador.Fill(dsDatos);

            //asigna datos al gridcontrol
            gcPersonal.DataSource = dsDatos.Tables[0];
        }


    }
}
