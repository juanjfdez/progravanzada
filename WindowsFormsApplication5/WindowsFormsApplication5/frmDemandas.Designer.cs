namespace WindowsFormsApplication5
{
    partial class frmDemandas
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
            this.gcDemanda = new DevExpress.XtraGrid.GridControl();
            this.gvDemanda = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btnBuscar = new DevExpress.XtraEditors.SimpleButton();
            this.btnDemanda = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gcDemanda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDemanda)).BeginInit();
            this.SuspendLayout();
            // 
            // gcDemanda
            // 
            this.gcDemanda.EmbeddedNavigator.Name = "";
            this.gcDemanda.FormsUseDefaultLookAndFeel = false;
            this.gcDemanda.Location = new System.Drawing.Point(12, 38);
            this.gcDemanda.MainView = this.gvDemanda;
            this.gcDemanda.Name = "gcDemanda";
            this.gcDemanda.Size = new System.Drawing.Size(685, 244);
            this.gcDemanda.TabIndex = 0;
            this.gcDemanda.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDemanda});
            // 
            // gvDemanda
            // 
            this.gvDemanda.GridControl = this.gcDemanda;
            this.gvDemanda.Name = "gvDemanda";
            this.gvDemanda.OptionsBehavior.Editable = false;
            this.gvDemanda.OptionsView.ColumnAutoWidth = false;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(539, 9);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "&Buscar";
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnDemanda
            // 
            this.btnDemanda.Location = new System.Drawing.Point(445, 9);
            this.btnDemanda.Name = "btnDemanda";
            this.btnDemanda.Size = new System.Drawing.Size(75, 23);
            this.btnDemanda.TabIndex = 4;
            this.btnDemanda.Text = "&Demanda";
            // 
            // frmDemandas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 294);
            this.Controls.Add(this.btnDemanda);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.gcDemanda);
            this.Name = "frmDemandas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formato para Demandas";
            this.Load += new System.EventHandler(this.frmDemandas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcDemanda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDemanda)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcDemanda;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDemanda;
        private DevExpress.XtraEditors.SimpleButton btnBuscar;
        private DevExpress.XtraEditors.SimpleButton btnDemanda;
    }
}