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
    public partial class frmCasos : ABC.frmABC
    {
        
        public frmCasos()
        {
            InitializeComponent();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarControles();
        }

        private void frmCasos_Load(object sender, EventArgs e)
        {
            Program.frmSoftj.AbrirCon();
            query.Connection = Program.frmSoftj.sqlconexion;

            // asignacion te errores para la insercion
            ErrorPersonalizadoInicio();

            dsDatos.Clear();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // verifica datos
            //Caso
            if (cbbTipoCaso.Text == "- Escoja tipo de Caso -")
            {
                error_info.SetError(cbbTipoCaso, "Por favor especifique el Tipo de Caso");
                bandera = false;
            }
            else
                error_info.SetError(cbbTipoCaso, "");
            //verifica que no este ningun dato en blanco
            ErrorPersonalizadoEjecucion();
        }

        private void cbbClienteCaso_DropDown(object sender, EventArgs e)
        {
            SqlDataAdapter adaptadorCliente = new SqlDataAdapter(query);

            // se le inserta los valores de clientes
            query.CommandText = "SELECT * FROM Cliente";
            
            adaptadorCliente.Fill(dsDatos,"cliente");

            cbbClienteCaso.DataSource = dsDatos.Tables["cliente"];

            cbbClienteCaso.DisplayMember = "Nombre";
            cbbClienteCaso.ValueMember = "id_cliente";
        
        }

        private void cbbAbogCaso_DropDown(object sender, EventArgs e)
        {

            SqlDataAdapter adaptadorAbogado = new SqlDataAdapter(query);

            // se le inserta los valores de clientes
            query.CommandText = "SELECT * FROM Datos_Personal WHERE Puesto_emp = 'Abogado'";
            
            adaptadorAbogado.Fill(dsDatos,"abog");

            cbbAbogCaso.DataSource = dsDatos.Tables["abog"];

            cbbAbogCaso.DisplayMember = "Nombre_emp";
            cbbAbogCaso.ValueMember = "id_emp";
        }
        
    }
}
