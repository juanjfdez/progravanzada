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
    public partial class frmAbogado : ABC.frmABC
    {
        public frmAbogado()
        {
            InitializeComponent();
        }

        private void cbbAbogado_DropDown(object sender, EventArgs e)
        {
            SqlDataAdapter adaptador = new SqlDataAdapter(query);
            //insertacion a empresa combo box
            query.CommandText = "SELECT * FROM Datos_Personal WHERE Puesto_emp='Abogado'";
            dsDatos.Clear();
            adaptador.Fill(dsDatos, "Abogado");
            cbbAbogado.DataSource = dsDatos.Tables["Abogado"];

            cbbAbogado.DisplayMember = "Nombre_emp";
            cbbAbogado.ValueMember = "id_emp";
        }

        private void frmAbogado_Load(object sender, EventArgs e)
        {
            Program.frmSoftj.AbrirCon();
            query.Connection = Program.frmSoftj.sqlconexion;

            ErrorPersonalizadoInicio();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //Abogado
            if (cbbAbogado.Text == "- Escoger Abogado -")
            {
                error_info.SetError(cbbAbogado, "Por favor especifique el Abogado");
                bandera = false;
            }
            ErrorPersonalizadoEjecucion();

             //INICIO DE INSERCION
            if (bandera)
            {
                try
                {
                    query.CommandText = "EXEC InsertarAbogado @Nombre,@Caso_activo,@id_emp";

                    query.Parameters.Clear();
                    query.Parameters.AddWithValue("@Caso_activo", txtCasoAct.Text);
                    query.Parameters.AddWithValue("@Nombre", cbbAbogado.DisplayMember.ToString());
                    query.Parameters.AddWithValue("@id_emp", cbbAbogado.ValueMember);

                    if (query.ExecuteNonQuery() > 0)
                        MessageBox.Show("Insercion exitosa");
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message, "Error");
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarControles();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dsDatos.Clear();
            SqlDataAdapter adaptador = new SqlDataAdapter(query);

            //se hace consulta
            query.CommandText = "SELECT Nombre, Caso_activo as [Caso Activo] FROM Abogado";

            //limpia datos del data user
            dsDatos.Clear();

            //se llena datos en el data user
            adaptador.Fill(dsDatos,"AbogBus");

            //asigna datos al gridcontrol
            gcAbog.DataSource = dsDatos.Tables["AbogBus"];
        }

        private void btnBusMod_Click(object sender, EventArgs e)
        {
            dsDatos.Clear();
            SqlDataAdapter adaptador = new SqlDataAdapter(query);

            //se hace consulta
            query.CommandText = "SELECT id_abogado, Nombre, Caso_activo, id_emp FROM  Abogado";

            //limpia datos del data user
            dsDatos.Clear();

            //se llena datos en el data user
            adaptador.Fill(dsDatos, "AbogMod");

            //asigna datos al gridcontrol
            gcAbogMod.DataSource = dsDatos.Tables["AbogMod"];
        }
    }
}
