namespace WindowsFormsApplication5
{
    partial class frmAdmin
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
            this.gcAdmin = new DevExpress.XtraGrid.GridControl();
            this.gvAdmin = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btnBuscar = new DevExpress.XtraEditors.SimpleButton();
            this.btnEliminar = new DevExpress.XtraEditors.SimpleButton();
            this.cbbTablas = new DevExpress.XtraEditors.ComboBoxEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gcAdmin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvAdmin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbTablas.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gcAdmin
            // 
            this.gcAdmin.EmbeddedNavigator.Name = "";
            this.gcAdmin.FormsUseDefaultLookAndFeel = false;
            this.gcAdmin.Location = new System.Drawing.Point(12, 87);
            this.gcAdmin.MainView = this.gvAdmin;
            this.gcAdmin.Name = "gcAdmin";
            this.gcAdmin.Size = new System.Drawing.Size(579, 270);
            this.gcAdmin.TabIndex = 0;
            this.gcAdmin.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvAdmin});
            // 
            // gvAdmin
            // 
            this.gvAdmin.GridControl = this.gcAdmin;
            this.gvAdmin.Name = "gvAdmin";
            this.gvAdmin.OptionsView.ColumnAutoWidth = false;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(390, 22);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(85, 37);
            this.btnBuscar.TabIndex = 1;
            this.btnBuscar.Text = "&Buscar";
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(506, 22);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(85, 37);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "&Eliminar";
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // cbbTablas
            // 
            this.cbbTablas.EditValue = "- Elegir Tabla -";
            this.cbbTablas.Location = new System.Drawing.Point(52, 29);
            this.cbbTablas.Name = "cbbTablas";
            this.cbbTablas.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbbTablas.Properties.Items.AddRange(new object[] {
            "Cliente",
            "Casos",
            "Personal",
            "Demandado",
            "Abogado"});
            this.cbbTablas.Size = new System.Drawing.Size(228, 20);
            this.cbbTablas.TabIndex = 3;
            this.cbbTablas.SelectedIndexChanged += new System.EventHandler(this.cbbTablas_SelectedIndexChanged);
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 369);
            this.Controls.Add(this.cbbTablas);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.gcAdmin);
            this.Name = "frmAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrador";
            this.Load += new System.EventHandler(this.frmAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcAdmin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvAdmin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbTablas.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcAdmin;
        private DevExpress.XtraGrid.Views.Grid.GridView gvAdmin;
        private DevExpress.XtraEditors.SimpleButton btnBuscar;
        private DevExpress.XtraEditors.SimpleButton btnEliminar;
        private DevExpress.XtraEditors.ComboBoxEdit cbbTablas;
    }
}