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
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // verifica que no este ningun dato en blanco
            ErrorPersonalizadoEjecucion();
        }
        
    }
}
