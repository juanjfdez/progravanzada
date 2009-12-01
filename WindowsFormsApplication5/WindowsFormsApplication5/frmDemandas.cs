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
    public partial class frmDemandas : Form
    {
        SqlCommand query = new SqlCommand();
        DataSet dsDatos = new DataSet();
        public frmDemandas()
        {
            InitializeComponent();
        }

        private void frmDemandas_Load(object sender, EventArgs e)
        {
            Program.frmSoftj.AbrirCon();
            query.Connection = Program.frmSoftj.sqlconexion;

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            SqlDataAdapter adaptador = new SqlDataAdapter(query);
            try
            {
                query.CommandText = @"SELECT     Cliente.Nombre AS Cliente, Cliente.Puesto, Cliente.Salario, Cliente.fecha_out, Cliente.fecha_in, 
                      Cliente.jefe_inmediato, Casos.tipo_caso,Cliente.Direccion, Casos.Descripcion, Demandado.Nombre AS Demandado, 
                      Demandado.Direccion AS [Dir. Empresa],Abogado.Nombre AS Abogado
                      FROM         Cliente INNER JOIN
                      Casos ON Cliente.id_cliente = Casos.id_cliente INNER JOIN
                      Demandado ON Cliente.Id_demandado = Demandado.Id_demandado INNER JOIN
                      Abogado ON Casos.id_abogado = Abogado.id_abogado";

                dsDatos.Clear();
                adaptador.Fill(dsDatos, "Demanda");
                gcDemanda.DataSource = dsDatos.Tables["Demanda"];

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Error");
            }
        }
    }
}
