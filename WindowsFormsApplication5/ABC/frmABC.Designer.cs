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
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.tbNuevo = new DevExpress.XtraTab.XtraTabPage();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.tbBuscar = new DevExpress.XtraTab.XtraTabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gridBuscar = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.tbModificar = new DevExpress.XtraTab.XtraTabPage();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.queryCliente = new System.Data.SqlClient.SqlCommand();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.tbNuevo.SuspendLayout();
            this.tbBuscar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridBuscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.tbModificar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.HeaderLocation = DevExpress.XtraTab.TabHeaderLocation.Left;
            this.xtraTabControl1.HeaderOrientation = DevExpress.XtraTab.TabOrientation.Horizontal;
            this.xtraTabControl1.Location = new System.Drawing.Point(12, 32);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.tbNuevo;
            this.xtraTabControl1.Size = new System.Drawing.Size(790, 477);
            this.xtraTabControl1.TabIndex = 0;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tbNuevo,
            this.tbBuscar,
            this.tbModificar});
            this.xtraTabControl1.Text = "xtraTabControl1";
            // 
            // tbNuevo
            // 
            this.tbNuevo.Controls.Add(this.btnGuardar);
            this.tbNuevo.Image = global::ABC.Properties.Resources.document_new;
            this.tbNuevo.Name = "tbNuevo";
            this.tbNuevo.Size = new System.Drawing.Size(710, 468);
            this.tbNuevo.Text = "&Nuevo";
            this.tbNuevo.Paint += new System.Windows.Forms.PaintEventHandler(this.tbNuevo_Paint);
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
            this.tbBuscar.Controls.Add(this.textBox1);
            this.tbBuscar.Controls.Add(this.label1);
            this.tbBuscar.Controls.Add(this.gridBuscar);
            this.tbBuscar.Image = global::ABC.Properties.Resources.system_search;
            this.tbBuscar.Name = "tbBuscar";
            this.tbBuscar.Size = new System.Drawing.Size(710, 468);
            this.tbBuscar.Text = "&Buscar";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(86, 30);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(393, 20);
            this.textBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Buscar :";
            // 
            // gridBuscar
            // 
            this.gridBuscar.EmbeddedNavigator.Name = "";
            this.gridBuscar.FormsUseDefaultLookAndFeel = false;
            this.gridBuscar.Location = new System.Drawing.Point(46, 66);
            this.gridBuscar.MainView = this.gridView1;
            this.gridBuscar.Name = "gridBuscar";
            this.gridBuscar.Size = new System.Drawing.Size(432, 276);
            this.gridBuscar.TabIndex = 0;
            this.gridBuscar.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridBuscar;
            this.gridView1.Name = "gridView1";
            // 
            // tbModificar
            // 
            this.tbModificar.Controls.Add(this.textBox2);
            this.tbModificar.Controls.Add(this.label2);
            this.tbModificar.Controls.Add(this.gridControl1);
            this.tbModificar.Image = global::ABC.Properties.Resources.emblem_unreadable;
            this.tbModificar.Name = "tbModificar";
            this.tbModificar.Size = new System.Drawing.Size(710, 468);
            this.tbModificar.Text = "&Modificar";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(84, 32);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(393, 20);
            this.textBox2.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Buscar :";
            // 
            // gridControl1
            // 
            this.gridControl1.EmbeddedNavigator.Name = "";
            this.gridControl1.FormsUseDefaultLookAndFeel = false;
            this.gridControl1.Location = new System.Drawing.Point(44, 68);
            this.gridControl1.MainView = this.gridView2;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(432, 276);
            this.gridControl1.TabIndex = 3;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.gridControl1;
            this.gridView2.Name = "gridView2";
            // 
            // frmABC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 521);
            this.ControlBox = false;
            this.Controls.Add(this.xtraTabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmABC";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.tbNuevo.ResumeLayout(false);
            this.tbBuscar.ResumeLayout(false);
            this.tbBuscar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridBuscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.tbModificar.ResumeLayout(false);
            this.tbModificar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabPage tbBuscar;
        private DevExpress.XtraGrid.GridControl gridBuscar;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        protected DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        protected DevExpress.XtraTab.XtraTabPage tbNuevo;
        protected DevExpress.XtraTab.XtraTabPage tbModificar;
        protected System.Windows.Forms.Button btnGuardar;
        protected System.Data.SqlClient.SqlCommand queryCliente;
    }
}

