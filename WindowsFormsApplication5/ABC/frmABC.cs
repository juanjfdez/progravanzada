using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using Microsoft.Office;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ABC
{
    public partial class frmABC : Form
    {
        
        public frmABC()
        {
            InitializeComponent();
        }

        protected void LimpiarControles()
        {

            for (int i = 0; i < this.tbNuevo.Controls.Count; i++)
            {
                
                if (this.tbNuevo.Controls[i].GetType().Name.ToUpper() == "TEXTBOX")
                    (this.tbNuevo.Controls[i] as TextBox).Text = "";
                if (this.tbNuevo.Controls[i].GetType().Name.ToUpper() == "TEXTEDIT")
                    (this.tbNuevo.Controls[i] as DevExpress.XtraEditors.TextEdit).Text = "";
                if (this.tbNuevo.Controls[i].GetType().Name.ToUpper() == "COMBOBOX")
                {
                    (this.tbNuevo.Controls[i] as ComboBox).SelectedIndex = -1;
                    (this.tbNuevo.Controls[i] as ComboBox).Text = "";

                }
                if (this.tbNuevo.Controls[i].GetType().Name.ToUpper() == "COMBOBOXEDIT")
                {
                    (this.tbNuevo.Controls[i] as DevExpress.XtraEditors.ComboBoxEdit).SelectedIndex = -1;
                    (this.tbNuevo.Controls[i] as DevExpress.XtraEditors.ComboBoxEdit).Text = "";

                }
                //MessageBox.Show(this.tbNuevo.Controls[i].GetType().ToString());
            }


        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarControles();
        }


    }
   
}
