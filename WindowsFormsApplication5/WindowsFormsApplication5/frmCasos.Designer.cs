namespace WindowsFormsApplication5
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
            this.txtTipoCaso = new DevExpress.XtraEditors.TextEdit();
            this.txtDescripcion = new DevExpress.XtraEditors.TextEdit();
            this.txtStatusCaso = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.tbNuevo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error_info)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTipoCaso.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescripcion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStatusCaso.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Size = new System.Drawing.Size(706, 367);
            // 
            // tbNuevo
            // 
            this.tbNuevo.Controls.Add(this.txtStatusCaso);
            this.tbNuevo.Controls.Add(this.txtDescripcion);
            this.tbNuevo.Controls.Add(this.txtTipoCaso);
            this.tbNuevo.Controls.Add(this.labelControl3);
            this.tbNuevo.Controls.Add(this.labelControl2);
            this.tbNuevo.Controls.Add(this.labelControl1);
            this.tbNuevo.Size = new System.Drawing.Size(626, 358);
            this.tbNuevo.Controls.SetChildIndex(this.btnLimpiar, 0);
            this.tbNuevo.Controls.SetChildIndex(this.labelControl1, 0);
            this.tbNuevo.Controls.SetChildIndex(this.labelControl2, 0);
            this.tbNuevo.Controls.SetChildIndex(this.btnGuardar, 0);
            this.tbNuevo.Controls.SetChildIndex(this.labelControl3, 0);
            this.tbNuevo.Controls.SetChildIndex(this.txtTipoCaso, 0);
            this.tbNuevo.Controls.SetChildIndex(this.txtDescripcion, 0);
            this.tbNuevo.Controls.SetChildIndex(this.txtStatusCaso, 0);
            // 
            // tbModificar
            // 
            this.tbModificar.Size = new System.Drawing.Size(626, 358);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(423, 41);
            // 
            // tbBuscar
            // 
            this.tbBuscar.Size = new System.Drawing.Size(626, 358);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(423, 123);
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(60, 84);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(66, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Tipo de Caso:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(60, 151);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(58, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Descripcion:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(60, 222);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(79, 13);
            this.labelControl3.TabIndex = 3;
            this.labelControl3.Text = "Status del Caso:";
            // 
            // txtTipoCaso
            // 
            this.txtTipoCaso.Location = new System.Drawing.Point(162, 81);
            this.txtTipoCaso.Name = "txtTipoCaso";
            this.txtTipoCaso.Size = new System.Drawing.Size(100, 20);
            this.txtTipoCaso.TabIndex = 4;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(162, 148);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(100, 20);
            this.txtDescripcion.TabIndex = 5;
            // 
            // txtStatusCaso
            // 
            this.txtStatusCaso.Location = new System.Drawing.Point(162, 219);
            this.txtStatusCaso.Name = "txtStatusCaso";
            this.txtStatusCaso.Size = new System.Drawing.Size(100, 20);
            this.txtStatusCaso.TabIndex = 6;
            // 
            // frmCasos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 411);
            this.Name = "frmCasos";
            this.Text = "Casos";
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.tbNuevo.ResumeLayout(false);
            this.tbNuevo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error_info)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTipoCaso.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescripcion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStatusCaso.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtStatusCaso;
        private DevExpress.XtraEditors.TextEdit txtDescripcion;
        private DevExpress.XtraEditors.TextEdit txtTipoCaso;
    }
}