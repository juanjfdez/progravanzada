namespace ABC
{
    partial class frmABC
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
            this.components = new System.ComponentModel.Container();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.tbNuevo = new DevExpress.XtraTab.XtraTabPage();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.tbBuscar = new DevExpress.XtraTab.XtraTabPage();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.tbModificar = new DevExpress.XtraTab.XtraTabPage();
            this.btnMod = new System.Windows.Forms.Button();
            this.btnBusMod = new System.Windows.Forms.Button();
            this.query = new System.Data.SqlClient.SqlCommand();
            this.dsDatos = new System.Data.DataSet();
            this.error_info = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.tbNuevo.SuspendLayout();
            this.tbBuscar.SuspendLayout();
            this.tbModificar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error_info)).BeginInit();
            this.SuspendLayout();
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.HeaderLocation = DevExpress.XtraTab.TabHeaderLocation.Left;
            this.xtraTabControl1.HeaderOrientation = DevExpress.XtraTab.TabOrientation.Horizontal;
            this.xtraTabControl1.Location = new System.Drawing.Point(12, 12);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.tbNuevo;
            this.xtraTabControl1.Size = new System.Drawing.Size(790, 497);
            this.xtraTabControl1.TabIndex = 0;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tbNuevo,
            this.tbBuscar,
            this.tbModificar});
            this.xtraTabControl1.Text = "xtraTabControl1";
            // 
            // tbNuevo
            // 
            this.tbNuevo.Controls.Add(this.btnLimpiar);
            this.tbNuevo.Controls.Add(this.btnGuardar);
            this.tbNuevo.Image = global::ABC.Properties.Resources.document_new;
            this.tbNuevo.Name = "tbNuevo";
            this.tbNuevo.Size = new System.Drawing.Size(710, 488);
            this.tbNuevo.Text = "&Nuevo";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(506, 109);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(92, 41);
            this.btnLimpiar.TabIndex = 8;
            this.btnLimpiar.Text = "&Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Image = global::ABC.Properties.Resources.save2;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnGuardar.Location = new System.Drawing.Point(506, 41);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(92, 41);
            this.btnGuardar.TabIndex = 0;
            this.btnGuardar.Text = "  &Guardar";
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // tbBuscar
            // 
            this.tbBuscar.Controls.Add(this.btnBuscar);
            this.tbBuscar.Image = global::ABC.Properties.Resources.system_search;
            this.tbBuscar.Name = "tbBuscar";
            this.tbBuscar.Size = new System.Drawing.Size(710, 488);
            this.tbBuscar.Text = "&Buscar";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(581, 24);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(94, 40);
            this.btnBuscar.TabIndex = 0;
            this.btnBuscar.Text = "B&uscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // tbModificar
            // 
            this.tbModificar.Controls.Add(this.btnMod);
            this.tbModificar.Controls.Add(this.btnBusMod);
            this.tbModificar.Image = global::ABC.Properties.Resources.emblem_unreadable;
            this.tbModificar.Name = "tbModificar";
            this.tbModificar.Size = new System.Drawing.Size(710, 488);
            this.tbModificar.Text = "&Modificar";
            // 
            // btnMod
            // 
            this.btnMod.Location = new System.Drawing.Point(243, 18);
            this.btnMod.Name = "btnMod";
            this.btnMod.Size = new System.Drawing.Size(94, 40);
            this.btnMod.TabIndex = 3;
            this.btnMod.Text = "&Cambiar";
            this.btnMod.UseVisualStyleBackColor = true;
            // 
            // btnBusMod
            // 
            this.btnBusMod.Location = new System.Drawing.Point(107, 18);
            this.btnBusMod.Name = "btnBusMod";
            this.btnBusMod.Size = new System.Drawing.Size(94, 40);
            this.btnBusMod.TabIndex = 1;
            this.btnBusMod.Text = "Bu&scar";
            this.btnBusMod.UseVisualStyleBackColor = true;
            // 
            // dsDatos
            // 
            this.dsDatos.DataSetName = "NewDataSet";
            // 
            // error_info
            // 
            this.error_info.ContainerControl = this;
            // 
            // frmABC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 521);
            this.Controls.Add(this.xtraTabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmABC";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.tbNuevo.ResumeLayout(false);
            this.tbBuscar.ResumeLayout(false);
            this.tbModificar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dsDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error_info)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        protected DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        protected DevExpress.XtraTab.XtraTabPage tbNuevo;
        protected DevExpress.XtraTab.XtraTabPage tbModificar;
        protected System.Windows.Forms.Button btnGuardar;
        protected System.Data.SqlClient.SqlCommand query;
        public System.Data.DataSet dsDatos;
        public DevExpress.XtraTab.XtraTabPage tbBuscar;
        protected System.Windows.Forms.Button btnLimpiar;
        protected System.Windows.Forms.Button btnBuscar;
        protected System.Windows.Forms.ErrorProvider error_info;
        protected System.Windows.Forms.Button btnBusMod;
        protected System.Windows.Forms.Button btnMod;
    }
}

