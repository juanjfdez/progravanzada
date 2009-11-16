using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication5
{
    public partial class frmClientes : ABC.frmABC
    {
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

                //Empresa
            if (txtEmpresa.Text == "")
            {
                errorCusClientes.SetError(txtEmpresa, "Por favor especifique el nombre de la Empresa");
                bandera = false;
            }
            else
                errorCusClientes.SetError(txtEmpresa, "");

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

                //DireccionEmpresa
            if (txtDireccionEmpresa.Text == "")
            {
                errorCusClientes.SetError(txtDireccionEmpresa, "Por favor especifique direccion de la Empresa");
                bandera = false;
            }
            else
                errorCusClientes.SetError(txtDireccionEmpresa, "");

          queryCliente.CommandText="EXEC InsertarCliente  @Nombre,@Direccion,@Telefono,@Puesto,@Salario,@Sexo,@Curp,@Caso_Activo,@Id_demandado,@hora_in, @hora_out,@jefe_inmediato,@tipo_moneda_sal,@forma_pago,@jornada_in,@jornada_out,@fecha_in,@fecha_out,@tarjeta_asis,@puesto_jefe_inmediato	"

                
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {
            queryCliente.Connection = Program.frmSoftj.sqlconexion;

            // asignacion te errores para la insercion
            errorCusClientes.SetError(txtNombre, "");
            errorCusClientes.SetError(txtEmpresa, "");
            errorCusClientes.SetError(txtPuesto, "");
            errorCusClientes.SetError(txtSalario, "");
            errorCusClientes.SetError(txtJefe, "");
            errorCusClientes.SetError(txtPuestoJefe, "");
            errorCusClientes.SetError(txtDireccionEmpresa, "");
        }


    }

}
