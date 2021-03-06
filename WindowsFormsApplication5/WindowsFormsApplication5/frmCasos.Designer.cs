﻿namespace WindowsFormsApplication5
{
    partial class frmCasos
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtDescripcion = new DevExpress.XtraEditors.TextEdit();
            this.cbbTipoCaso = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cbbClienteCaso = new System.Windows.Forms.ComboBox();
            this.cbbAbogCaso = new System.Windows.Forms.ComboBox();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.gcCasos = new DevExpress.XtraGrid.GridControl();
            this.gvCasos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcCasosMod = new DevExpress.XtraGrid.GridControl();
            this.gvCasosMod = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.cbbStatusCaso = new System.Windows.Forms.ComboBox();
            this.btnContrato = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.tbNuevo.SuspendLayout();
            this.tbModificar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsDatos)).BeginInit();
            this.tbBuscar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.error_info)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescripcion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbTipoCaso.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcCasos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCasos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcCasosMod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCasosMod)).BeginInit();
            this.SuspendLayout();
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Size = new System.Drawing.Size(661, 314);
            // 
            // tbNuevo
            // 
            this.tbNuevo.Controls.Add(this.btnContrato);
            this.tbNuevo.Controls.Add(this.cbbStatusCaso);
            this.tbNuevo.Controls.Add(this.labelControl5);
            this.tbNuevo.Controls.Add(this.labelControl4);
            this.tbNuevo.Controls.Add(this.cbbAbogCaso);
            this.tbNuevo.Controls.Add(this.cbbClienteCaso);
            this.tbNuevo.Controls.Add(this.cbbTipoCaso);
            this.tbNuevo.Controls.Add(this.txtDescripcion);
            this.tbNuevo.Controls.Add(this.labelControl3);
            this.tbNuevo.Controls.Add(this.labelControl2);
            this.tbNuevo.Controls.Add(this.labelControl1);
            this.tbNuevo.Size = new System.Drawing.Size(581, 305);
            this.tbNuevo.Controls.SetChildIndex(this.btnLimpiar, 0);
            this.tbNuevo.Controls.SetChildIndex(this.labelControl1, 0);
            this.tbNuevo.Controls.SetChildIndex(this.labelControl2, 0);
            this.tbNuevo.Controls.SetChildIndex(this.btnGuardar, 0);
            this.tbNuevo.Controls.SetChildIndex(this.labelControl3, 0);
            this.tbNuevo.Controls.SetChildIndex(this.txtDescripcion, 0);
            this.tbNuevo.Controls.SetChildIndex(this.cbbTipoCaso, 0);
            this.tbNuevo.Controls.SetChildIndex(this.cbbClienteCaso, 0);
            this.tbNuevo.Controls.SetChildIndex(this.cbbAbogCaso, 0);
            this.tbNuevo.Controls.SetChildIndex(this.labelControl4, 0);
            this.tbNuevo.Controls.SetChildIndex(this.labelControl5, 0);
            this.tbNuevo.Controls.SetChildIndex(this.cbbStatusCaso, 0);
            this.tbNuevo.Controls.SetChildIndex(this.btnContrato, 0);
            // 
            // tbModificar
            // 
            this.tbModificar.Controls.Add(this.gcCasosMod);
            this.tbModificar.Size = new System.Drawing.Size(581, 305);
            this.tbModificar.Controls.SetChildIndex(this.btnMod, 0);
            this.tbModificar.Controls.SetChildIndex(this.btnBusMod, 0);
            this.tbModificar.Controls.SetChildIndex(this.gcCasosMod, 0);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(423, 41);
            this.btnGuardar.TabIndex = 9;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // tbBuscar
            // 
            this.tbBuscar.Controls.Add(this.gcCasos);
            this.tbBuscar.Size = new System.Drawing.Size(581, 305);
            this.tbBuscar.Controls.SetChildIndex(this.btnBuscar, 0);
            this.tbBuscar.Controls.SetChildIndex(this.gcCasos, 0);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(423, 123);
            this.btnLimpiar.TabIndex = 10;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(464, 25);
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnBusMod
            // 
            this.btnBusMod.Location = new System.Drawing.Point(81, 18);
            this.btnBusMod.Click += new System.EventHandler(this.btnBusMod_Click);
            // 
            // btnMod
            // 
            this.btnMod.Location = new System.Drawing.Point(239, 18);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(60, 40);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(66, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Tipo de Caso:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(60, 93);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(58, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Descripcion:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(60, 151);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(79, 13);
            this.labelControl3.TabIndex = 3;
            this.labelControl3.Text = "Status del Caso:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(162, 90);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(223, 20);
            this.txtDescripcion.TabIndex = 5;
            // 
            // cbbTipoCaso
            // 
            this.cbbTipoCaso.EditValue = "- Escoger tipo de Caso -";
            this.cbbTipoCaso.Location = new System.Drawing.Point(162, 37);
            this.cbbTipoCaso.Name = "cbbTipoCaso";
            this.cbbTipoCaso.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbbTipoCaso.Properties.Items.AddRange(new object[] {
            "Despidos Injustificado",
            "Recisiones laborales",
            "Demenda de derechos de prestaciones",
            "Huelga"});
            this.cbbTipoCaso.Size = new System.Drawing.Size(223, 20);
            this.cbbTipoCaso.TabIndex = 4;
            // 
            // cbbClienteCaso
            // 
            this.cbbClienteCaso.BackColor = System.Drawing.Color.White;
            this.cbbClienteCaso.FormattingEnabled = true;
            this.cbbClienteCaso.Location = new System.Drawing.Point(162, 198);
            this.cbbClienteCaso.Name = "cbbClienteCaso";
            this.cbbClienteCaso.Size = new System.Drawing.Size(223, 21);
            this.cbbClienteCaso.TabIndex = 7;
            this.cbbClienteCaso.Text = "- Escoger Cliente -";
            this.cbbClienteCaso.DropDown += new System.EventHandler(this.cbbClienteCaso_DropDown);
            // 
            // cbbAbogCaso
            // 
            this.cbbAbogCaso.BackColor = System.Drawing.Color.White;
            this.cbbAbogCaso.FormattingEnabled = true;
            this.cbbAbogCaso.Location = new System.Drawing.Point(162, 254);
            this.cbbAbogCaso.Name = "cbbAbogCaso";
            this.cbbAbogCaso.Size = new System.Drawing.Size(223, 21);
            this.cbbAbogCaso.TabIndex = 8;
            this.cbbAbogCaso.Text = "- Escoger Abogado -";
            this.cbbAbogCaso.DropDown += new System.EventHandler(this.cbbAbogCaso_DropDown);
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(60, 201);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(37, 13);
            this.labelControl4.TabIndex = 11;
            this.labelControl4.Text = "Cliente:";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(60, 257);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(47, 13);
            this.labelControl5.TabIndex = 12;
            this.labelControl5.Text = "Abogado:";
            // 
            // gcCasos
            // 
            this.gcCasos.EmbeddedNavigator.Name = "";
            this.gcCasos.FormsUseDefaultLookAndFeel = false;
            this.gcCasos.Location = new System.Drawing.Point(3, 95);
            this.gcCasos.MainView = this.gvCasos;
            this.gcCasos.Name = "gcCasos";
            this.gcCasos.Size = new System.Drawing.Size(575, 207);
            this.gcCasos.TabIndex = 2;
            this.gcCasos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvCasos});
            // 
            // gvCasos
            // 
            this.gvCasos.GridControl = this.gcCasos;
            this.gvCasos.Name = "gvCasos";
            this.gvCasos.OptionsBehavior.Editable = false;
            this.gvCasos.OptionsView.ColumnAutoWidth = false;
            // 
            // gcCasosMod
            // 
            this.gcCasosMod.EmbeddedNavigator.Name = "";
            this.gcCasosMod.FormsUseDefaultLookAndFeel = false;
            this.gcCasosMod.Location = new System.Drawing.Point(3, 95);
            this.gcCasosMod.MainView = this.gvCasosMod;
            this.gcCasosMod.Name = "gcCasosMod";
            this.gcCasosMod.Size = new System.Drawing.Size(575, 207);
            this.gcCasosMod.TabIndex = 3;
            this.gcCasosMod.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvCasosMod});
            // 
            // gvCasosMod
            // 
            this.gvCasosMod.GridControl = this.gcCasosMod;
            this.gvCasosMod.Name = "gvCasosMod";
            this.gvCasosMod.OptionsView.ColumnAutoWidth = false;
            // 
            // cbbStatusCaso
            // 
            this.cbbStatusCaso.BackColor = System.Drawing.Color.White;
            this.cbbStatusCaso.FormattingEnabled = true;
            this.cbbStatusCaso.Items.AddRange(new object[] {
            "Inicio",
            "Notificacion en progreso",
            "Terminado"});
            this.cbbStatusCaso.Location = new System.Drawing.Point(162, 148);
            this.cbbStatusCaso.Name = "cbbStatusCaso";
            this.cbbStatusCaso.Size = new System.Drawing.Size(191, 21);
            this.cbbStatusCaso.TabIndex = 6;
            this.cbbStatusCaso.Text = "- Escoja status de caso -";
            // 
            // btnContrato
            // 
            this.btnContrato.Enabled = false;
            this.btnContrato.Location = new System.Drawing.Point(423, 213);
            this.btnContrato.Name = "btnContrato";
            this.btnContrato.Size = new System.Drawing.Size(91, 41);
            this.btnContrato.TabIndex = 13;
            this.btnContrato.Text = "G&enear Contrato";
            this.btnContrato.UseVisualStyleBackColor = true;
            this.btnContrato.Click += new System.EventHandler(this.btnContrato_Click);
            // 
            // frmCasos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 338);
            this.Name = "frmCasos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Casos";
            this.Load += new System.EventHandler(this.frmCasos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.tbNuevo.ResumeLayout(false);
            this.tbNuevo.PerformLayout();
            this.tbModificar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dsDatos)).EndInit();
            this.tbBuscar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.error_info)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescripcion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbTipoCaso.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcCasos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCasos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcCasosMod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCasosMod)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtDescripcion;
        private DevExpress.XtraEditors.ComboBoxEdit cbbTipoCaso;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private System.Windows.Forms.ComboBox cbbAbogCaso;
        private System.Windows.Forms.ComboBox cbbClienteCaso;
        private DevExpress.XtraGrid.GridControl gcCasos;
        private DevExpress.XtraGrid.Views.Grid.GridView gvCasos;
        private DevExpress.XtraGrid.GridControl gcCasosMod;
        private DevExpress.XtraGrid.Views.Grid.GridView gvCasosMod;
        private System.Windows.Forms.ComboBox cbbStatusCaso;
        private System.Windows.Forms.Button btnContrato;
    }
}