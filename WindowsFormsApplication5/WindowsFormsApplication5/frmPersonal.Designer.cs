namespace WindowsFormsApplication5
{
    partial class frmPersonal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.rdSexoEmp = new DevExpress.XtraEditors.RadioGroup();
            this.label24 = new System.Windows.Forms.Label();
            this.txtNomEmp = new DevExpress.XtraEditors.TextEdit();
            this.txtTelEmp = new DevExpress.XtraEditors.TextEdit();
            this.txtEdad = new DevExpress.XtraEditors.TextEdit();
            this.txtDireccionEmp = new DevExpress.XtraEditors.TextEdit();
            this.txtSeguro = new DevExpress.XtraEditors.TextEdit();
            this.cbbPuesto = new DevExpress.XtraEditors.ComboBoxEdit();
            this.gcPersonal = new DevExpress.XtraGrid.GridControl();
            this.gvPersonal = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcPersonalMod = new DevExpress.XtraGrid.GridControl();
            this.gvPersonalMod = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.tbNuevo.SuspendLayout();
            this.tbModificar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsDatos)).BeginInit();
            this.tbBuscar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.error_info)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdSexoEmp.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNomEmp.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTelEmp.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEdad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDireccionEmp.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSeguro.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbPuesto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcPersonal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPersonal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcPersonalMod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPersonalMod)).BeginInit();
            this.SuspendLayout();
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Size = new System.Drawing.Size(694, 332);
            // 
            // tbNuevo
            // 
            this.tbNuevo.Controls.Add(this.cbbPuesto);
            this.tbNuevo.Controls.Add(this.txtSeguro);
            this.tbNuevo.Controls.Add(this.txtDireccionEmp);
            this.tbNuevo.Controls.Add(this.txtEdad);
            this.tbNuevo.Controls.Add(this.txtTelEmp);
            this.tbNuevo.Controls.Add(this.txtNomEmp);
            this.tbNuevo.Controls.Add(this.label24);
            this.tbNuevo.Controls.Add(this.rdSexoEmp);
            this.tbNuevo.Controls.Add(this.label7);
            this.tbNuevo.Controls.Add(this.label6);
            this.tbNuevo.Controls.Add(this.label5);
            this.tbNuevo.Controls.Add(this.label4);
            this.tbNuevo.Controls.Add(this.label3);
            this.tbNuevo.Controls.Add(this.label1);
            this.tbNuevo.Size = new System.Drawing.Size(614, 323);
            this.tbNuevo.Controls.SetChildIndex(this.btnLimpiar, 0);
            this.tbNuevo.Controls.SetChildIndex(this.label1, 0);
            this.tbNuevo.Controls.SetChildIndex(this.btnGuardar, 0);
            this.tbNuevo.Controls.SetChildIndex(this.label3, 0);
            this.tbNuevo.Controls.SetChildIndex(this.label4, 0);
            this.tbNuevo.Controls.SetChildIndex(this.label5, 0);
            this.tbNuevo.Controls.SetChildIndex(this.label6, 0);
            this.tbNuevo.Controls.SetChildIndex(this.label7, 0);
            this.tbNuevo.Controls.SetChildIndex(this.rdSexoEmp, 0);
            this.tbNuevo.Controls.SetChildIndex(this.label24, 0);
            this.tbNuevo.Controls.SetChildIndex(this.txtNomEmp, 0);
            this.tbNuevo.Controls.SetChildIndex(this.txtTelEmp, 0);
            this.tbNuevo.Controls.SetChildIndex(this.txtEdad, 0);
            this.tbNuevo.Controls.SetChildIndex(this.txtDireccionEmp, 0);
            this.tbNuevo.Controls.SetChildIndex(this.txtSeguro, 0);
            this.tbNuevo.Controls.SetChildIndex(this.cbbPuesto, 0);
            // 
            // tbModificar
            // 
            this.tbModificar.Controls.Add(this.gcPersonalMod);
            this.tbModificar.Size = new System.Drawing.Size(614, 323);
            this.tbModificar.Controls.SetChildIndex(this.btnBusMod, 0);
            this.tbModificar.Controls.SetChildIndex(this.btnEliminar, 0);
            this.tbModificar.Controls.SetChildIndex(this.gcPersonalMod, 0);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(494, 18);
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // tbBuscar
            // 
            this.tbBuscar.Controls.Add(this.gcPersonal);
            this.tbBuscar.Size = new System.Drawing.Size(614, 323);
            this.tbBuscar.Controls.SetChildIndex(this.btnBuscar, 0);
            this.tbBuscar.Controls.SetChildIndex(this.gcPersonal, 0);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(494, 95);
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(506, 14);
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Telefono:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Edad:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(54, 238);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Seguro:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(54, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Direccion:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(54, 278);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Puesto:";
            // 
            // rdSexoEmp
            // 
            this.rdSexoEmp.Location = new System.Drawing.Point(145, 147);
            this.rdSexoEmp.Name = "rdSexoEmp";
            this.rdSexoEmp.Properties.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.rdSexoEmp.Properties.Appearance.Options.UseBackColor = true;
            this.rdSexoEmp.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem("M", "Masculino"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("F", "Femenino")});
            this.rdSexoEmp.Size = new System.Drawing.Size(180, 34);
            this.rdSexoEmp.TabIndex = 17;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(54, 159);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(34, 13);
            this.label24.TabIndex = 37;
            this.label24.Text = "Sexo:";
            // 
            // txtNomEmp
            // 
            this.txtNomEmp.Location = new System.Drawing.Point(145, 29);
            this.txtNomEmp.Name = "txtNomEmp";
            this.txtNomEmp.Size = new System.Drawing.Size(252, 20);
            this.txtNomEmp.TabIndex = 38;
            // 
            // txtTelEmp
            // 
            this.txtTelEmp.Location = new System.Drawing.Point(145, 66);
            this.txtTelEmp.Name = "txtTelEmp";
            this.txtTelEmp.Properties.Mask.EditMask = "(999)000-00-00";
            this.txtTelEmp.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
            this.txtTelEmp.Size = new System.Drawing.Size(122, 20);
            this.txtTelEmp.TabIndex = 39;
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(145, 106);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Properties.Mask.EditMask = "n0";
            this.txtEdad.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtEdad.Size = new System.Drawing.Size(72, 20);
            this.txtEdad.TabIndex = 40;
            // 
            // txtDireccionEmp
            // 
            this.txtDireccionEmp.Location = new System.Drawing.Point(145, 198);
            this.txtDireccionEmp.Name = "txtDireccionEmp";
            this.txtDireccionEmp.Size = new System.Drawing.Size(252, 20);
            this.txtDireccionEmp.TabIndex = 41;
            // 
            // txtSeguro
            // 
            this.txtSeguro.Location = new System.Drawing.Point(145, 235);
            this.txtSeguro.Name = "txtSeguro";
            this.txtSeguro.Size = new System.Drawing.Size(252, 20);
            this.txtSeguro.TabIndex = 42;
            // 
            // cbbPuesto
            // 
            this.cbbPuesto.EditValue = "- Elija Puesto del Empleado -";
            this.cbbPuesto.Location = new System.Drawing.Point(145, 275);
            this.cbbPuesto.Name = "cbbPuesto";
            this.cbbPuesto.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbbPuesto.Properties.Items.AddRange(new object[] {
            "Abogado",
            "Asistente"});
            this.cbbPuesto.Size = new System.Drawing.Size(190, 20);
            this.cbbPuesto.TabIndex = 43;
            // 
            // gcPersonal
            // 
            this.gcPersonal.EmbeddedNavigator.Name = "";
            this.gcPersonal.FormsUseDefaultLookAndFeel = false;
            this.gcPersonal.Location = new System.Drawing.Point(12, 72);
            this.gcPersonal.MainView = this.gvPersonal;
            this.gcPersonal.Name = "gcPersonal";
            this.gcPersonal.Size = new System.Drawing.Size(599, 248);
            this.gcPersonal.TabIndex = 0;
            this.gcPersonal.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvPersonal});
            // 
            // gvPersonal
            // 
            this.gvPersonal.GridControl = this.gcPersonal;
            this.gvPersonal.Name = "gvPersonal";
            this.gvPersonal.OptionsBehavior.Editable = false;
            // 
            // gcPersonalMod
            // 
            this.gcPersonalMod.EmbeddedNavigator.Name = "";
            this.gcPersonalMod.FormsUseDefaultLookAndFeel = false;
            this.gcPersonalMod.Location = new System.Drawing.Point(3, 72);
            this.gcPersonalMod.MainView = this.gvPersonalMod;
            this.gcPersonalMod.Name = "gcPersonalMod";
            this.gcPersonalMod.Size = new System.Drawing.Size(608, 248);
            this.gcPersonalMod.TabIndex = 3;
            this.gcPersonalMod.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvPersonalMod});
            // 
            // gvPersonalMod
            // 
            this.gvPersonalMod.GridControl = this.gcPersonalMod;
            this.gvPersonalMod.Name = "gvPersonalMod";
            this.gvPersonalMod.OptionsBehavior.Editable = false;
            // 
            // frmPersonal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 356);
            this.Name = "frmPersonal";
            this.Text = "Personal";
            this.Load += new System.EventHandler(this.frmPersonal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.tbNuevo.ResumeLayout(false);
            this.tbNuevo.PerformLayout();
            this.tbModificar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dsDatos)).EndInit();
            this.tbBuscar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.error_info)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdSexoEmp.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNomEmp.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTelEmp.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEdad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDireccionEmp.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSeguro.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbPuesto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcPersonal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPersonal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcPersonalMod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPersonalMod)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private DevExpress.XtraEditors.RadioGroup rdSexoEmp;
        private System.Windows.Forms.Label label24;
        private DevExpress.XtraEditors.TextEdit txtSeguro;
        private DevExpress.XtraEditors.TextEdit txtDireccionEmp;
        private DevExpress.XtraEditors.TextEdit txtEdad;
        private DevExpress.XtraEditors.TextEdit txtTelEmp;
        private DevExpress.XtraEditors.TextEdit txtNomEmp;
        private DevExpress.XtraEditors.ComboBoxEdit cbbPuesto;
        private DevExpress.XtraGrid.GridControl gcPersonal;
        private DevExpress.XtraGrid.Views.Grid.GridView gvPersonal;
        private DevExpress.XtraGrid.GridControl gcPersonalMod;
        private DevExpress.XtraGrid.Views.Grid.GridView gvPersonalMod;
    }
}