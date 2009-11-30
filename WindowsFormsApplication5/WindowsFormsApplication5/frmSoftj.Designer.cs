namespace WindowsFormsApplication5
{
    partial class frmSoftj
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
            this.tsMenu = new System.Windows.Forms.ToolStrip();
            this.tsbAdministrador = new System.Windows.Forms.ToolStripButton();
            this.tspClientes = new System.Windows.Forms.ToolStripButton();
            this.tspCasos = new System.Windows.Forms.ToolStripButton();
            this.tspPersonal = new System.Windows.Forms.ToolStripButton();
            this.tspDemandas = new System.Windows.Forms.ToolStripButton();
            this.tspReportes = new System.Windows.Forms.ToolStripButton();
            this.tspSalir = new System.Windows.Forms.ToolStripButton();
            this.tspCerrarSession = new System.Windows.Forms.ToolStripButton();
            this.tspInfo = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ventanasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.horizontalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verticalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sqlconexion = new System.Data.SqlClient.SqlConnection();
            this.tsMenu.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tsMenu
            // 
            this.tsMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.tsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbAdministrador,
            this.tspClientes,
            this.tspCasos,
            this.tspPersonal,
            this.tspDemandas,
            this.tspReportes,
            this.tspSalir,
            this.tspCerrarSession,
            this.tspInfo});
            this.tsMenu.Location = new System.Drawing.Point(0, 24);
            this.tsMenu.Name = "tsMenu";
            this.tsMenu.Size = new System.Drawing.Size(82, 677);
            this.tsMenu.TabIndex = 2;
            this.tsMenu.Text = "ts";
            // 
            // tsbAdministrador
            // 
            this.tsbAdministrador.Image = global::WindowsFormsApplication5.Properties.Resources.Administrator_icon;
            this.tsbAdministrador.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbAdministrador.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAdministrador.Name = "tsbAdministrador";
            this.tsbAdministrador.Size = new System.Drawing.Size(79, 65);
            this.tsbAdministrador.Text = "&Administrador";
            this.tsbAdministrador.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // tspClientes
            // 
            this.tspClientes.Image = global::WindowsFormsApplication5.Properties.Resources.system_users;
            this.tspClientes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tspClientes.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tspClientes.Name = "tspClientes";
            this.tspClientes.Size = new System.Drawing.Size(79, 65);
            this.tspClientes.Text = "&Clientes";
            this.tspClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tspClientes.Click += new System.EventHandler(this.tspClientes_Click);
            // 
            // tspCasos
            // 
            this.tspCasos.Image = global::WindowsFormsApplication5.Properties.Resources.x_directory_normal;
            this.tspCasos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tspCasos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tspCasos.Name = "tspCasos";
            this.tspCasos.Size = new System.Drawing.Size(79, 65);
            this.tspCasos.Text = "C&asos";
            this.tspCasos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tspCasos.Click += new System.EventHandler(this.tspCasos_Click);
            // 
            // tspPersonal
            // 
            this.tspPersonal.Image = global::WindowsFormsApplication5.Properties.Resources.preferences_desktop_theme;
            this.tspPersonal.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tspPersonal.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tspPersonal.Name = "tspPersonal";
            this.tspPersonal.Size = new System.Drawing.Size(79, 65);
            this.tspPersonal.Text = "&Personal";
            this.tspPersonal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tspPersonal.Click += new System.EventHandler(this.tspPersonal_Click);
            // 
            // tspDemandas
            // 
            this.tspDemandas.Image = global::WindowsFormsApplication5.Properties.Resources.Contract_icon1;
            this.tspDemandas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tspDemandas.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tspDemandas.Name = "tspDemandas";
            this.tspDemandas.Size = new System.Drawing.Size(79, 65);
            this.tspDemandas.Text = "&Demandas";
            this.tspDemandas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // tspReportes
            // 
            this.tspReportes.Image = global::WindowsFormsApplication5.Properties.Resources.x_office_spreadsheet;
            this.tspReportes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tspReportes.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tspReportes.Name = "tspReportes";
            this.tspReportes.Size = new System.Drawing.Size(79, 65);
            this.tspReportes.Text = "&Reportes";
            this.tspReportes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tspReportes.Click += new System.EventHandler(this.tspReportes_Click);
            // 
            // tspSalir
            // 
            this.tspSalir.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tspSalir.Image = global::WindowsFormsApplication5.Properties.Resources.Close_48x48;
            this.tspSalir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tspSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tspSalir.Name = "tspSalir";
            this.tspSalir.Size = new System.Drawing.Size(79, 65);
            this.tspSalir.Text = "&Salir";
            this.tspSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tspSalir.Click += new System.EventHandler(this.tspSalir_Click);
            // 
            // tspCerrarSession
            // 
            this.tspCerrarSession.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tspCerrarSession.Image = global::WindowsFormsApplication5.Properties.Resources.Keychica;
            this.tspCerrarSession.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tspCerrarSession.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tspCerrarSession.Name = "tspCerrarSession";
            this.tspCerrarSession.Size = new System.Drawing.Size(79, 65);
            this.tspCerrarSession.Text = "Cerrar S&ession";
            this.tspCerrarSession.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // tspInfo
            // 
            this.tspInfo.Image = global::WindowsFormsApplication5.Properties.Resources.address_book_new;
            this.tspInfo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tspInfo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tspInfo.Name = "tspInfo";
            this.tspInfo.Size = new System.Drawing.Size(79, 65);
            this.tspInfo.Text = "&Informacion";
            this.tspInfo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tspInfo.Click += new System.EventHandler(this.tspInfo_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ventanasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.MdiWindowListItem = this.ventanasToolStripMenuItem;
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(794, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ventanasToolStripMenuItem
            // 
            this.ventanasToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.ventanasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.horizontalToolStripMenuItem,
            this.verticalToolStripMenuItem});
            this.ventanasToolStripMenuItem.Name = "ventanasToolStripMenuItem";
            this.ventanasToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.ventanasToolStripMenuItem.Text = "Ventanas";
            // 
            // horizontalToolStripMenuItem
            // 
            this.horizontalToolStripMenuItem.Name = "horizontalToolStripMenuItem";
            this.horizontalToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.horizontalToolStripMenuItem.Text = "Horizontal";
            this.horizontalToolStripMenuItem.Click += new System.EventHandler(this.horizontalToolStripMenuItem_Click);
            // 
            // verticalToolStripMenuItem
            // 
            this.verticalToolStripMenuItem.Name = "verticalToolStripMenuItem";
            this.verticalToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.verticalToolStripMenuItem.Text = "Cascada";
            // 
            // sqlconexion
            // 
            this.sqlconexion.ConnectionString = "Data Source=JUAN-PC\\SQLEXPRESS;Initial Catalog=PROYECTO;User ID=sa;Password=1234";
            this.sqlconexion.FireInfoMessageEventOnUserErrors = false;
            // 
            // frmSoftj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 701);
            this.Controls.Add(this.tsMenu);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "frmSoftj";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Softj";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmSoftj_Load);
            this.tsMenu.ResumeLayout(false);
            this.tsMenu.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsMenu;
        private System.Windows.Forms.ToolStripButton tspClientes;
        private System.Windows.Forms.ToolStripButton tspCasos;
        private System.Windows.Forms.ToolStripButton tspPersonal;
        private System.Windows.Forms.ToolStripButton tspReportes;
        private System.Windows.Forms.ToolStripButton tspCerrarSession;
        private System.Windows.Forms.ToolStripButton tspSalir;
        private System.Windows.Forms.ToolStripButton tspDemandas;
        private System.Windows.Forms.ToolStripButton tsbAdministrador;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ventanasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem horizontalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verticalToolStripMenuItem;
        public System.Data.SqlClient.SqlConnection sqlconexion;
        private System.Windows.Forms.ToolStripButton tspInfo;

    }
}