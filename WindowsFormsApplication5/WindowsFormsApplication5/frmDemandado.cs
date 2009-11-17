﻿using System;
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
    public partial class frmDemandado : ABC.frmABC
    {
        public frmDemandado()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            bool banderademandado;
            banderademandado = true;

            // verifica que no este ningun dato en blanco
                //Nombre
            if (txtNomEmp.Text == "")
            {
                errorCusDemandado.SetError(txtNomEmp, "Por favor especifique Nombre de la Empresa");
                banderademandado = false;
            }
            else
                errorCusDemandado.SetError(txtNomEmp, "");

            //Direccion
            if (txtDirEmp.Text == "")
            {
                errorCusDemandado.SetError(txtDirEmp, "Por favor especifique Direccion de la Empresa");
                banderademandado = false;
            }
            else
                errorCusDemandado.SetError(txtDirEmp, "");

            //Telefono
            if (txtTelEmp.Text == "")
            {
                errorCusDemandado.SetError(txtTelEmp, "Por favor especifique Telefono de la Empresa");
                banderademandado = false;
            }
            else
                errorCusDemandado.SetError(txtTelEmp, "");

            if (banderademandado == true)
            {
                //Inicia insercion
                queryCliente.CommandText = "EXEC InsertarDemandado @Nombre,@Direccion,@Telefono";

                //parametros
                queryCliente.Parameters.Clear();
                queryCliente.Parameters.AddWithValue("@Nombre", txtNomEmp.Text);
                queryCliente.Parameters.AddWithValue("@Direccion", txtDirEmp.Text);
                queryCliente.Parameters.AddWithValue("@Telefono", txtTelEmp.Text);

                //se ejecuta query
                if (queryCliente.ExecuteNonQuery() > 0)
                    MessageBox.Show("Empresa dada de Alta en el sistema");
            }

        }

        private void frmDemandado_Load(object sender, EventArgs e)
        {
            Program.frmSoftj.AbrirCon();
            queryCliente.Connection = Program.frmSoftj.sqlconexion;

            errorCusDemandado.SetError(txtDirEmp, "");
            errorCusDemandado.SetError(txtNomEmp, "");
            errorCusDemandado.SetError(txtTelEmp, "");
        }

    }
}