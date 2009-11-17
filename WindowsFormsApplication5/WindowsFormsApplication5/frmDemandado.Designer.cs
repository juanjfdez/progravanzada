namespace WindowsFormsApplication5
{
    partial class frmDemandado
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtNomEmp = new DevExpress.XtraEditors.TextEdit();
            this.txtDirEmp = new DevExpress.XtraEditors.TextEdit();
            this.txtTelEmp = new DevExpress.XtraEditors.TextEdit();
            this.errorCusDemandado = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.tbNuevo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNomEmp.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDirEmp.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTelEmp.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorCusDemandado)).BeginInit();
            this.SuspendLayout();
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Size = new System.Drawing.Size(708, 372);
            // 
            // tbNuevo
            // 
            this.tbNuevo.Controls.Add(this.txtTelEmp);
            this.tbNuevo.Controls.Add(this.txtDirEmp);
            this.tbNuevo.Controls.Add(this.txtNomEmp);
            this.tbNuevo.Controls.Add(this.labelControl3);
            this.tbNuevo.Controls.Add(this.labelControl2);
            this.tbNuevo.Controls.Add(this.labelControl1);
            this.tbNuevo.Size = new System.Drawing.Size(628, 363);
            this.tbNuevo.Controls.SetChildIndex(this.labelControl1, 0);
            this.tbNuevo.Controls.SetChildIndex(this.labelControl2, 0);
            this.tbNuevo.Controls.SetChildIndex(this.btnGuardar, 0);
            this.tbNuevo.Controls.SetChildIndex(this.labelControl3, 0);
            this.tbNuevo.Controls.SetChildIndex(this.txtNomEmp, 0);
            this.tbNuevo.Controls.SetChildIndex(this.txtDirEmp, 0);
            this.tbNuevo.Controls.SetChildIndex(this.txtTelEmp, 0);
            // 
            // tbModificar
            // 
            this.tbModificar.Size = new System.Drawing.Size(628, 363);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(57, 41);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(85, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Nombre Empresa:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(57, 94);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(47, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Direccion:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(57, 143);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(46, 13);
            this.labelControl3.TabIndex = 3;
            this.labelControl3.Text = "Telefono:";
            // 
            // txtNomEmp
            // 
            this.txtNomEmp.Location = new System.Drawing.Point(159, 38);
            this.txtNomEmp.Name = "txtNomEmp";
            this.txtNomEmp.Size = new System.Drawing.Size(169, 20);
            this.txtNomEmp.TabIndex = 4;
            // 
            // txtDirEmp
            // 
            this.txtDirEmp.Location = new System.Drawing.Point(159, 91);
            this.txtDirEmp.Name = "txtDirEmp";
            this.txtDirEmp.Size = new System.Drawing.Size(169, 20);
            this.txtDirEmp.TabIndex = 5;
            // 
            // txtTelEmp
            // 
            this.txtTelEmp.Location = new System.Drawing.Point(159, 140);
            this.txtTelEmp.Name = "txtTelEmp";
            this.txtTelEmp.Properties.Mask.EditMask = "(999)000-00-00";
            this.txtTelEmp.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
            this.txtTelEmp.Size = new System.Drawing.Size(169, 20);
            this.txtTelEmp.TabIndex = 6;
            // 
            // errorCusDemandado
            // 
            this.errorCusDemandado.ContainerControl = this;
            // 
            // frmDemandado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 424);
            this.Name = "frmDemandado";
            this.Text = "Empresa Demandada";
            this.Load += new System.EventHandler(this.frmDemandado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.tbNuevo.ResumeLayout(false);
            this.tbNuevo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNomEmp.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDirEmp.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTelEmp.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorCusDemandado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtNomEmp;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtTelEmp;
        private DevExpress.XtraEditors.TextEdit txtDirEmp;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider errorCusDemandado;
    }
}