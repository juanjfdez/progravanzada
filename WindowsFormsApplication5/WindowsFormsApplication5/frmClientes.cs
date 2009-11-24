﻿using System;
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
            bool bandera;
            bandera = true;

            // verifica que no este ningun dato en blanco
                //Nombre
            if (txtNombre.Text == "")
            {
                errorCusClientes.SetError(txtNombre, "Por favor especifique el nombre del cliente");
                bandera = false;
            }
            else
                errorCusClientes.SetError(txtNombre, "");

                //Direccion
            if (txtDireccion.Text == "")
            {
                errorCusClientes.SetError(txtDireccion, "Por favor especifique la Direccion del cliente");
                bandera = false;
            }
            else
                errorCusClientes.SetError(txtNombre, "");
            
                //Telefono
            if (txtTelefono.Text == "")
            {
                errorCusClientes.SetError(txtTelefono, "Por favor especifique el Telefono del cliente");
                bandera = false;
            }
            else
                errorCusClientes.SetError(txtTelefono, "");

                //Sexo
            if (rdSexo.Text=="")
            {
                errorCusClientes.SetError(rdSexo, "Por favor especifique el sexo del cliente");
                bandera = false;
            }
             else
                errorCusClientes.SetError(rdSexo,"");
                //Empresa
            if (cbbEmpresa.Text == "- Escojer Empresa -")
            {
                errorCusClientes.SetError(cbbEmpresa, "Por favor especifique el nombre de la Empresa");
                bandera = false;
            }
            else
                errorCusClientes.SetError(cbbEmpresa, "");

                //Puesto
            if (txtPuesto.Text == "")
            {
                errorCusClientes.SetError(txtPuesto, "Por favor especifique el puesto del Cliente");
                bandera = false;
            }
            else
                errorCusClientes.SetError(txtPuesto, "");

                //Salario
            if (txtSalario.Text == "")
            {
                errorCusClientes.SetError(txtSalario, "Por favor especifique el Salario del cliente");
                bandera = false;
            }
            else
                errorCusClientes.SetError(txtSalario, "");

                //Jefe
            if (txtJefe.Text == "")
            {
                errorCusClientes.SetError(txtJefe, "Por favor especifique el nombre del Jefe Inmediato");
                bandera = false;
            }
            else
                errorCusClientes.SetError(txtJefe, "");

                //Puesto Jefe Inmediato
            if (txtPuestoJefe.Text == "")
            {
                errorCusClientes.SetError(txtPuestoJefe, "Por favor especifique el Puesto del Jefe Inmediato");
                bandera = false;
            }
            else
                errorCusClientes.SetError(txtPuestoJefe, "");

                //Tarjeta Asistencia
            if ((ckdTarjetaNo.Checked == false) && (ckdTarjetaSi.Checked == false))
            {
                errorCusClientes.SetError(ckdTarjetaNo, "Por favor especifique informacion de Tarjeta de Asistencia");
                errorCusClientes.SetError(ckdTarjetaSi, "Por favor especifique informacion de Tarjeta de Asistencia");
                bandera = false;
            }
            else
            {
                errorCusClientes.SetError(ckdTarjetaNo, "");
                errorCusClientes.SetError(ckdTarjetaSi, "");
            }

            if (bandera == true)
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
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {
            Program.frmSoftj.AbrirCon();
            query.Connection = Program.frmSoftj.sqlconexion;

            // asignacion te errores para la insercion
            errorCusClientes.SetError(txtNombre, "");
            errorCusClientes.SetError(txtDireccion, "");
            errorCusClientes.SetError(cbbEmpresa, "");
            errorCusClientes.SetError(txtPuesto, "");
            errorCusClientes.SetError(txtSalario, "");
            errorCusClientes.SetError(txtJefe, "");
            errorCusClientes.SetError(txtPuestoJefe, "");

            
            
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

        private void btnEmpresaN_Click(object sender, EventArgs e)
        {
            if ((Program.frmSoftj.frmDemandado == null) || (Program.frmSoftj.frmDemandado.IsDisposed))
            {
                Program.frmSoftj.frmDemandado = new frmDemandado();
                Program.frmSoftj.frmDemandado.MdiParent = Program.frmSoftj;
                Program.frmSoftj.frmDemandado.Show();
            }
        }

        private void cbbEmpresa_DropDown(object sender, EventArgs e)
        {
            SqlDataAdapter adaptador = new SqlDataAdapter(query);
            //insertacion a empresa combo box
            query.CommandText = "SELECT * FROM Demandado";
            dsDatos.Clear();
            adaptador.Fill(dsDatos);
            cbbEmpresa.DataSource = dsDatos.Tables[0];

            cbbEmpresa.DisplayMember = "Nombre";
            cbbEmpresa.ValueMember = "Id_demandado";
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dsDatos.Clear();
            SqlDataAdapter adaptador = new SqlDataAdapter(query);

            //se hace consulta
            query.CommandText = @"SELECT     Nombre, Direccion, Telefono, Puesto, Salario, tipo_moneda_sal AS [Tipo de Moneda], forma_pago AS [Forma de Pago], Sexo, 
                      hora_in AS [Hora de Entrada], hora_out AS [Hora de Salida], jefe_inmediato AS [Jefe Inmediato], puesto_jefe_inmediato AS [Puesto de Jefe], 
                      jornada_in AS [Inicio de Jornada], jornada_out AS [Fin de Jornada], fecha_in AS [Fecha de Inicio], fecha_out AS [Fecha de Despido], 
                      tarjeta_asis AS [Tarjeta de Asis.]
                      FROM         Cliente";
  
            //limpia datos del data user
            dsDatos.Clear();

            //se llena datos en el data user
            adaptador.Fill(dsDatos);

            //asigna datos al gridcontrol
            gcCliente.DataSource = dsDatos.Tables[0];



        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarControles();
                         
        }


    }

}
