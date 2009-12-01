using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Data.SqlTypes;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication5
{
    public partial class frmDemandado : ABC.frmABC
    {
        public frmDemandado()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            
            // verifica que no este ningun dato en blanco
                //Nombre
            if (txtNomEmp.Text == "")
            {
                error_info.SetError(txtNomEmp, "Por favor especifique Nombre de la Empresa");
                bandera = false;
            }
            else
                error_info.SetError(txtNomEmp, "");

            //Direccion
            if (txtDirEmp.Text == "")
            {
                error_info.SetError(txtDirEmp, "Por favor especifique Direccion de la Empresa");
                bandera = false;
            }
            else
                error_info.SetError(txtDirEmp, "");

            //Telefono
            if (txtTelEmp.Text == "")
            {
                error_info.SetError(txtTelEmp, "Por favor especifique Telefono de la Empresa");
                bandera = false;
            }
            else
                error_info.SetError(txtTelEmp, "");
            
            ErrorPersonalizadoEjecucion();

            if (bandera)
            {
                //Inicia insercion
                query.CommandText = "EXEC InsertarDemandado @Nombre,@Direccion,@Telefono";

                //parametros
                query.Parameters.Clear();
                query.Parameters.AddWithValue("@Nombre", txtNomEmp.Text);
                query.Parameters.AddWithValue("@Direccion", txtDirEmp.Text);
                query.Parameters.AddWithValue("@Telefono", txtTelEmp.Text);

                //se ejecuta query
                if (query.ExecuteNonQuery() > 0)
                    MessageBox.Show("Empresa dada de Alta en el sistema");
            }
           
        }

        private void frmDemandado_Load(object sender, EventArgs e)
        {
            Program.frmSoftj.AbrirCon();
            query.Connection = Program.frmSoftj.sqlconexion;

            // asignacion te errores para la insercion
            ErrorPersonalizadoInicio();
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
            query.CommandText = "SELECT Nombre, Direccion, Telefono FROM Demandado";

            //limpia datos del data user
            dsDatos.Clear();

            //se llena datos en el data user
            adaptador.Fill(dsDatos);

            //asigna datos al gridcontrol
            gcDemandado.DataSource = dsDatos.Tables[0];
        }

        private void btnBusMod_Click(object sender, EventArgs e)
        {
            dsDatos.Clear();
            SqlDataAdapter adaptador = new SqlDataAdapter(query);

            //se hace consulta
            query.CommandText = "SELECT Nombre, Direccion, Telefono FROM Demandado";

            //limpia datos del data user
            dsDatos.Clear();

            //se llena datos en el data user
            adaptador.Fill(dsDatos);

            //asigna datos al gridcontrol
            gcDemandadoMod.DataSource = dsDatos.Tables[0];
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string fila1;
            fila1 = gvDemandadoMod.GetFocusedRowCellValue("Nombre").ToString();
            try
            {
                query.CommandText = "DELETE FROM Demandado WHERE Nombre=@Nombre";

                //parametros
                query.Parameters.Clear();
                query.Parameters.AddWithValue("@Nombre", fila1);
                if (query.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Empresa Eliminada");
                    btnBusMod.PerformClick();
                }
            }
            catch (Exception erroreliminar)
            {
                MessageBox.Show(erroreliminar.Message, "Error");
            }
            btnBusMod.PerformClick();
        }

        private void gvDemandadoMod_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            MessageBox.Show(gvDemandadoMod.FocusedColumn.FieldName.ToString());
            MessageBox.Show(gvDemandadoMod.FocusedRowHandle.ToString());
            MessageBox.Show(gvDemandadoMod.EditingValue.ToString());           
        }

    }
}
