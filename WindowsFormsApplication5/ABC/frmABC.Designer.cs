﻿namespace ABC
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
            this.tbModificar = new DevExpress.XtraTab.XtraTabPage();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.queryCliente = new System.Data.SqlClient.SqlCommand();
            this.dsDatos = new System.Data.DataSet();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.tbNuevo.SuspendLayout();
            this.tbBuscar.SuspendLayout();
            this.tbModificar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsDatos)).BeginInit();
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
            // tbModificar
            // 
            this.tbModificar.Controls.Add(this.textBox2);
            this.tbModificar.Controls.Add(this.label2);
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
            // dsDatos
            // 
            this.dsDatos.DataSetName = "NewDataSet";
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
            this.tbBuscar.PerformLayout();
            this.tbModificar.ResumeLayout(false);
            this.tbModificar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsDatos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        protected DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        protected DevExpress.XtraTab.XtraTabPage tbNuevo;
        protected DevExpress.XtraTab.XtraTabPage tbModificar;
        protected System.Windows.Forms.Button btnGuardar;
        protected System.Data.SqlClient.SqlCommand queryCliente;
        public System.Data.DataSet dsDatos;
        public DevExpress.XtraTab.XtraTabPage tbBuscar;
    }
}

