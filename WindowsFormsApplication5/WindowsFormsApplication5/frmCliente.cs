using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication5
{
    public partial class frmClientes : ABC.frmABC
    {
        private string tarjeta_asis;

        public frmClientes()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // verifica que no este ningun dato en blanco
            //Empresa
            if (cbbEmpresa.Text == "- Escoger Empresa -")
            {
                error_info.SetError(cbbEmpresa, "Por favor especifique el nombre de la Empresa");
                bandera = false;
            }
            else
                error_info.SetError(cbbEmpresa, "");
            //Entrada
            if (cbbEntrada.Text == "Entrada")
            {
                error_info.SetError(cbbEntrada, "Por favor especifique horario de entrada");
                bandera = false;
            }
            else
                error_info.SetError(cbbEntrada, "");
            //Salida
            if (cbbSalida.Text == "Salida")
            {
                error_info.SetError(cbbSalida, "Por favor especifique horario de salida");
                bandera = false;
            }
            else
                error_info.SetError(cbbSalida, "");
            //Tipo de Moneda
            if (cbbTipo.Text == "Tipo de Moneda")
            {
                error_info.SetError(cbbTipo, "Por favor especifique el Tipo de Moneda");
                bandera = false;
            }
            else
                error_info.SetError(cbbTipo, "");
            //Forma de Pago
            if (cbbFormPago.Text == "Forma de Pago")
            {
                error_info.SetError(cbbFormPago, "Por favor especifique Forma de Pago");
                bandera = false;
            }
            else
                error_info.SetError(cbbFormPago, "");
            //Inicio
            if (cbbJornadaInicio.Text == "Inicio")
            {
                error_info.SetError(cbbJornadaInicio, "Por favor especifique el Inicio de la Jornada");
                bandera = false;
            }
            else
                error_info.SetError(cbbJornadaInicio, "");
            //Final
            if (cbbJornadaFinal.Text == "Final")
            {
                error_info.SetError(cbbJornadaFinal, "Por favor especifique el Inicio de la Jornada");
                bandera = false;
            }
            else
                error_info.SetError(cbbJornadaFinal, "");
            //Tarjeta Asistencia
            if ((ckdTarjetaNo.Checked == false) && (ckdTarjetaSi.Checked == false))
            {
                error_info.SetError(ckdTarjetaNo, "Por favor especifique informacion de Tarjeta de Asistencia");
                error_info.SetError(ckdTarjetaSi, "Por favor especifique informacion de Tarjeta de Asistencia");
                bandera = false;
            }
            else
            {
                error_info.SetError(ckdTarjetaNo, "");
                error_info.SetError(ckdTarjetaSi, "");
            }
            //Sexo
            if (rdSexo.Text == "")
            {
                error_info.SetError(rdSexo, "Por favor especifique el sexo del cliente");
                bandera = false;
            }
            else
                error_info.SetError(rdSexo, "");
            //Salario
            if (txtSalario.Text == "Cantidad $$")
            {
                error_info.SetError(txtSalario, "Por favor especifique Cantidad valida");
                bandera = false;
            }
            else
                error_info.SetError(txtSalario, "");
            //para cuando no tiene nada escrito
            ErrorPersonalizadoEjecucion();


            //INICIO DE INSERCION
            if (bandera)
            {
                try
                {
                    //INICIO DE INSERCION
                    query.CommandText = @"EXEC InsertarCliente  
            @Nombre,@Direccion,@Telefono,@Puesto,@Salario,@Sexo,
            @Id_demandado,@hora_in, @hora_out,@jefe_inmediato,
            @tipo_moneda_sal,@forma_pago,@jornada_in,@jornada_out,@fecha_in,
            @fecha_out,@tarjeta_asis,@puesto_jefe_inmediato";

                    //PARAMETROS
                    query.Parameters.Clear();
                    query.Parameters.AddWithValue("@Nombre", txtNombre.Text);
                    query.Parameters.AddWithValue("@Direccion", txtDireccion.Text);
                    query.Parameters.AddWithValue("@Telefono", txtTelefono.Text);
                    query.Parameters.AddWithValue("@Puesto", txtPuesto.Text);
                    query.Parameters.AddWithValue("@Salario", Convert.ToInt32(txtSalario.Text));
                    query.Parameters.AddWithValue("@Sexo", rdSexo.Text);
                    query.Parameters.AddWithValue("@Id_demandado", cbbEmpresa.SelectedValue);
                    query.Parameters.AddWithValue("@hora_in", cbbEntrada.Text);
                    query.Parameters.AddWithValue("@hora_out", cbbSalida.Text);
                    query.Parameters.AddWithValue("@jefe_inmediato", txtJefe.Text);
                    query.Parameters.AddWithValue("@tipo_moneda_sal", cbbTipo.Text);
                    query.Parameters.AddWithValue("@forma_pago", cbbFormPago.Text);
                    query.Parameters.AddWithValue("@jornada_in", cbbJornadaInicio.Text);
                    query.Parameters.AddWithValue("@jornada_out", cbbJornadaFinal.Text);
                    query.Parameters.AddWithValue("@fecha_in", txtFechaI.Text);
                    query.Parameters.AddWithValue("@fecha_out", txtFechaD.Text);
                    query.Parameters.AddWithValue("@puesto_jefe_inmediato", txtPuestoJefe.Text);
                    query.Parameters.AddWithValue("@tarjeta_asis", tarjeta_asis);

                    //ejecuta query
                    if (query.ExecuteNonQuery() > 0)
                        MessageBox.Show("Cliente agregado");
                }
                catch (Exception errorclienteinsercion)
                {
                    MessageBox.Show(errorclienteinsercion.Message, "Error en Insercion");
                }

            }

        }

        private void frmClientes_Load(object sender, EventArgs e)
        {
            //conexion abierta a base de datos
            Program.frmSoftj.AbrirCon();
            query.Connection = Program.frmSoftj.sqlconexion;

            // asignacion te errores para la insercion
            ErrorPersonalizadoInicio();

            txtNombre.Focus();
        }

        private void ckdTarjetaNo_CheckedChanged(object sender, EventArgs e)
        {
            if (ckdTarjetaNo.Checked == true)
            {
                ckdTarjetaSi.Checked = false;
                tarjeta_asis = ckdTarjetaNo.Text;
            }
        }

        private void ckdTarjetaSi_CheckedChanged(object sender, EventArgs e)
        {
            if (ckdTarjetaSi.Checked == true)
            {
                ckdTarjetaNo.Checked = false;
                tarjeta_asis = ckdTarjetaSi.Text;
            }
        }

        private void cbbEmpresa_DropDown(object sender, EventArgs e)
        {
            SqlDataAdapter adaptador = new SqlDataAdapter(query);
            //insertacion a empresa combo box
            query.CommandText = "SELECT * FROM Demandado";
            dsDatos.Clear();
            adaptador.Fill(dsDatos,"demCliente");
            cbbEmpresa.DataSource = dsDatos.Tables["demCliente"];

            cbbEmpresa.DisplayMember = "Nombre";
            cbbEmpresa.ValueMember = "Id_demandado";
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
            query.CommandText = @"SELECT     Nombre, Direccion, Telefono, Puesto, Salario, tipo_moneda_sal AS [Tipo de Moneda], 
            forma_pago AS [Forma de Pago], Sexo,hora_in AS [Hora de Entrada], hora_out AS [Hora de Salida], jefe_inmediato AS [Jefe Inmediato], 
            puesto_jefe_inmediato AS [Puesto de Jefe],jornada_in AS [Inicio de Jornada], jornada_out AS [Fin de Jornada], 
            fecha_in AS [Fecha de Inicio], fecha_out AS [Fecha de Despido], tarjeta_asis AS [Tarjeta de Asis.]
            FROM         Cliente";

            //limpia datos del data user
            dsDatos.Clear();

            //se llena datos en el data user
            adaptador.Fill(dsDatos,"busqCliente");

            //asigna datos al gridcontrol
            gcCliente.DataSource = dsDatos.Tables["busqCliente"];
        }

        private void btnBusMod_Click(object sender, EventArgs e)
        {
            dsDatos.Clear();
            SqlDataAdapter adaptador = new SqlDataAdapter(query);

            //se hace consulta
            query.CommandText = @"SELECT     Nombre, Direccion, Telefono, Puesto, Salario, tipo_moneda_sal AS [Tipo de Moneda], 
            forma_pago AS [Forma de Pago], Sexo,hora_in AS [Hora de Entrada], hora_out AS [Hora de Salida], jefe_inmediato AS [Jefe Inmediato], 
            puesto_jefe_inmediato AS [Puesto de Jefe],jornada_in AS [Inicio de Jornada], jornada_out AS [Fin de Jornada], 
            fecha_in AS [Fecha de Inicio], fecha_out AS [Fecha de Despido], tarjeta_asis AS [Tarjeta de Asis.]
            FROM      Cliente";

            //limpia datos del data user
            dsDatos.Clear();

            //se llena datos en el data user
            adaptador.Fill(dsDatos,"ModCliente");

            //asigna datos al gridcontrol
            gcClienteMod.DataSource = dsDatos.Tables["ModCliente"];
        }
        

        private void btnEmpresaN_Click(object sender, EventArgs e)
        {
            if ((Program.frmSoftj.frmDemandado == null) || (Program.frmSoftj.frmDemandado.IsDisposed))
            {
                Program.frmSoftj.frmDemandado = new frmDemandado();
                Program.frmSoftj.frmDemandado.MdiParent = Program.frmSoftj;
                Program.frmSoftj.frmDemandado.Show();
            }
        }


    }

}
