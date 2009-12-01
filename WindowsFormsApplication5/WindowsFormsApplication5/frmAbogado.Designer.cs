namespace WindowsFormsApplication5
{
    partial class frmAbogado
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
            this.cbbAbogado = new System.Windows.Forms.ComboBox();
            this.txtCasoAct = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gcAbog = new DevExpress.XtraGrid.GridControl();
            this.gvAbog = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcAbogMod = new DevExpress.XtraGrid.GridControl();
            this.gvAbogMod = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.tbNuevo.SuspendLayout();
            this.tbModificar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsDatos)).BeginInit();
            this.tbBuscar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.error_info)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCasoAct.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcAbog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvAbog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcAbogMod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvAbogMod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Size = new System.Drawing.Size(534, 206);
            // 
            // tbNuevo
            // 
            this.tbNuevo.Controls.Add(this.label2);
            this.tbNuevo.Controls.Add(this.label1);
            this.tbNuevo.Controls.Add(this.cbbAbogado);
            this.tbNuevo.Controls.Add(this.txtCasoAct);
            this.tbNuevo.Size = new System.Drawing.Size(454, 197);
            this.tbNuevo.Controls.SetChildIndex(this.txtCasoAct, 0);
            this.tbNuevo.Controls.SetChildIndex(this.cbbAbogado, 0);
            this.tbNuevo.Controls.SetChildIndex(this.label1, 0);
            this.tbNuevo.Controls.SetChildIndex(this.btnGuardar, 0);
            this.tbNuevo.Controls.SetChildIndex(this.btnLimpiar, 0);
            this.tbNuevo.Controls.SetChildIndex(this.label2, 0);
            // 
            // tbModificar
            // 
            this.tbModificar.Controls.Add(this.gcAbogMod);
            this.tbModificar.Size = new System.Drawing.Size(454, 197);
            this.tbModificar.Controls.SetChildIndex(this.btnBusMod, 0);
            this.tbModificar.Controls.SetChildIndex(this.btnMod, 0);
            this.tbModificar.Controls.SetChildIndex(this.gcAbogMod, 0);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(344, 20);
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // tbBuscar
            // 
            this.tbBuscar.Controls.Add(this.gcAbog);
            this.tbBuscar.Size = new System.Drawing.Size(454, 197);
            this.tbBuscar.Controls.SetChildIndex(this.btnBuscar, 0);
            this.tbBuscar.Controls.SetChildIndex(this.gcAbog, 0);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(344, 88);
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(333, 3);
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnBusMod
            // 
            this.btnBusMod.Location = new System.Drawing.Point(50, 18);
            this.btnBusMod.Click += new System.EventHandler(this.btnBusMod_Click);
            // 
            // btnMod
            // 
            this.btnMod.Location = new System.Drawing.Point(186, 18);
            // 
            // cbbAbogado
            // 
            this.cbbAbogado.BackColor = System.Drawing.Color.White;
            this.cbbAbogado.FormattingEnabled = true;
            this.cbbAbogado.Location = new System.Drawing.Point(75, 31);
            this.cbbAbogado.Name = "cbbAbogado";
            this.cbbAbogado.Size = new System.Drawing.Size(164, 21);
            this.cbbAbogado.TabIndex = 9;
            this.cbbAbogado.Text = "- Escoger Abogado -";
            this.cbbAbogado.DropDown += new System.EventHandler(this.cbbAbogado_DropDown);
            // 
            // txtCasoAct
            // 
            this.txtCasoAct.Location = new System.Drawing.Point(75, 99);
            this.txtCasoAct.Name = "txtCasoAct";
            this.txtCasoAct.Properties.Mask.EditMask = "Si|No|Indefinido";
            this.txtCasoAct.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtCasoAct.Size = new System.Drawing.Size(117, 20);
            this.txtCasoAct.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Abogado:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Activo:";
            // 
            // gcAbog
            // 
            this.gcAbog.EmbeddedNavigator.Name = "";
            this.gcAbog.FormsUseDefaultLookAndFeel = false;
            this.gcAbog.Location = new System.Drawing.Point(3, 66);
            this.gcAbog.MainView = this.gvAbog;
            this.gcAbog.Name = "gcAbog";
            this.gcAbog.Size = new System.Drawing.Size(448, 128);
            this.gcAbog.TabIndex = 1;
            this.gcAbog.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvAbog,
            this.gridView2});
            // 
            // gvAbog
            // 
            this.gvAbog.GridControl = this.gcAbog;
            this.gvAbog.Name = "gvAbog";
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.gcAbog;
            this.gridView2.Name = "gridView2";
            // 
            // gcAbogMod
            // 
            this.gcAbogMod.EmbeddedNavigator.Name = "";
            this.gcAbogMod.FormsUseDefaultLookAndFeel = false;
            this.gcAbogMod.Location = new System.Drawing.Point(3, 64);
            this.gcAbogMod.MainView = this.gvAbogMod;
            this.gcAbogMod.Name = "gcAbogMod";
            this.gcAbogMod.Size = new System.Drawing.Size(448, 128);
            this.gcAbogMod.TabIndex = 4;
            this.gcAbogMod.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvAbogMod,
            this.gridView3});
            // 
            // gvAbogMod
            // 
            this.gvAbogMod.GridControl = this.gcAbogMod;
            this.gvAbogMod.Name = "gvAbogMod";
            // 
            // gridView3
            // 
            this.gridView3.GridControl = this.gcAbogMod;
            this.gridView3.Name = "gridView3";
            // 
            // frmAbogado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 230);
            this.Name = "frmAbogado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Abogados";
            this.Load += new System.EventHandler(this.frmAbogado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.tbNuevo.ResumeLayout(false);
            this.tbNuevo.PerformLayout();
            this.tbModificar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dsDatos)).EndInit();
            this.tbBuscar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.error_info)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCasoAct.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcAbog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvAbog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcAbogMod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvAbogMod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbAbogado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit txtCasoAct;
        private DevExpress.XtraGrid.GridControl gcAbogMod;
        private DevExpress.XtraGrid.Views.Grid.GridView gvAbogMod;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraGrid.GridControl gcAbog;
        private DevExpress.XtraGrid.Views.Grid.GridView gvAbog;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
    }
}