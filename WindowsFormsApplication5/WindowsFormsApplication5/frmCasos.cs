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
            if (cbbTipoCaso.Text == "- Escoger tipo de Caso -")
            {
                error_info.SetError(cbbTipoCaso, "Por favor especifique el Tipo de Caso");
                bandera = false;
            }
            else
                error_info.SetError(cbbTipoCaso, "");
            //Cliente
            if (cbbClienteCaso.Text == "- Escoger Cliente -")
            {
                error_info.SetError(cbbClienteCaso, "Por favor especifique el Cliente de Caso");
                bandera = false;
            }
            else
                error_info.SetError(cbbClienteCaso, "");
            //Abogado
            if (cbbAbogCaso.Text == "- Escoger Abogado -")
            {
                error_info.SetError(cbbAbogCaso, "Por favor especifique el Abogado de Caso");
                bandera = false;
            }
            else
                error_info.SetError(cbbAbogCaso, "");
            //Status Caso
            if (cbbStatusCaso.Text == "- Escoja status de caso -")
            {
                error_info.SetError(cbbStatusCaso, "Por favor especifique status de Caso");
                bandera = false;
            }
            else
                error_info.SetError(cbbStatusCaso, "");
            //verifica que no este ningun dato en blanco
            ErrorPersonalizadoEjecucion();

            if (bandera)
            {
                try
                {
                    query.CommandText = "EXEC InsertarCaso @tipo_caso,@id_cliente,@id_abogado,@Status_caso,@Descripcion";

                    //PARAMETROS
                    query.Parameters.Clear();
                    query.Parameters.AddWithValue("@tipo_caso", cbbTipoCaso.Text);
                    query.Parameters.AddWithValue("@id_cliente", cbbClienteCaso.SelectedValue.ToString());
                    query.Parameters.AddWithValue("@id_abogado", cbbAbogCaso.SelectedValue.ToString());
                    query.Parameters.AddWithValue("@Status_caso", cbbStatusCaso.Text);
                    query.Parameters.AddWithValue("@Descripcion", txtDescripcion.Text);


                    //ejecucion del query
                    if (query.ExecuteNonQuery() > 0)
                        MessageBox.Show("Caso Dado de Alta");
                }
                catch (Exception errorCasos)
                {
                    MessageBox.Show(errorCasos.Message, "Error Insercion");
                }
            }
        }

        private void cbbClienteCaso_DropDown(object sender, EventArgs e)
        {
            dsDatos.Clear();
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
            DataSet dsDatos2 = new DataSet();
            dsDatos2.Clear();
            SqlDataAdapter adaptadorAbogado = new SqlDataAdapter(query);

            // se le inserta los valores de clientes
            query.CommandText = "SELECT * FROM Abogado";
            
            adaptadorAbogado.Fill(dsDatos2,"abog");

            cbbAbogCaso.DataSource = dsDatos2.Tables["abog"];

            cbbAbogCaso.DisplayMember = "Nombre";
            cbbAbogCaso.ValueMember = "id_abogado";
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //limpia datos del data user
            dsDatos.Clear();
            SqlDataAdapter adaptador = new SqlDataAdapter(query);

            //Se hace la busqueda
            query.CommandText = @"SELECT tipo_caso,id_cliente,id_abogado,Status_caso,Descripcion FROM Casos";
            

           

            //se llena datos en el data user
            adaptador.Fill(dsDatos,"BusqCaso");

            //asigna datos al gridcontrol
            gcCasos.DataSource = dsDatos.Tables["BusqCaso"];
        }

        private void btnBusMod_Click(object sender, EventArgs e)
        {
            //limpia datos del data user
            dsDatos.Clear();
            SqlDataAdapter adaptador = new SqlDataAdapter(query);

            //Se hace la busqueda
            query.CommandText = @"SELECT id_caso as [Numero Caso],tipo_caso as [Tipo de Caso],id_cliente,id_abogado,Status_caso as [Estatus del Caso],Descripcion FROM Casos";


            

            //se llena datos en el data user
            adaptador.Fill(dsDatos,"ModCaso");

            //asigna datos al gridcontrol
            gcCasosMod.DataSource = dsDatos.Tables["ModCaso"];
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string fila = "";
            fila = gvCasosMod.GetFocusedRowCellValue("Numero Caso").ToString();
            try
            {
                query.CommandText = "DELETE FROM Casos WHERE id_caso=@id_caso";

                //parametros
                query.Parameters.Clear();
                query.Parameters.AddWithValue("@id_caso", fila);
                if (query.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Caso Eliminado");
                    btnBusMod.PerformClick();
                }
            }
            catch (Exception erroreliminar)
            {
                MessageBox.Show(erroreliminar.Message, "Error");
            }
        }
        
    }
}
