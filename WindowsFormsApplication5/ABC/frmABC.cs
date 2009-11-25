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

            for (int i = 0; i < this.Controls.Count; i++)
            {
                if (this.Controls[i].GetType().Name.ToUpper() == "TEXTBOX")
                    (this.Controls[i] as TextBox).Text = "";
                if (this.Controls[i].GetType().Name.ToUpper() == "TEXTEDIT")
                    (this.Controls[i] as TextBox).Text = "";
                if (this.Controls[i].GetType().Name.ToUpper() == "COMBOBOX")
                {
                    (this.Controls[i] as ComboBox).SelectedIndex = -1;
                    (this.Controls[i] as ComboBox).Text = "";

                }
                if (this.Controls[i].GetType().Name.ToUpper() == "COMBOBOXEDIT")
                {
                    (this.Controls[i] as ComboBox).SelectedIndex = -1;
                    (this.Controls[i] as ComboBox).Text = "";

                }
            }
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarControles();
        }


    }
   
}
