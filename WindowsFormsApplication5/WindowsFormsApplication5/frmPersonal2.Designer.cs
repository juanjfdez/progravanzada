namespace WindowsFormsApplication5
{
    partial class frmPersonal2
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
            this.btnAbogado = new System.Windows.Forms.Button();
            this.btnPersonal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAbogado
            // 
            this.btnAbogado.Location = new System.Drawing.Point(36, 40);
            this.btnAbogado.Name = "btnAbogado";
            this.btnAbogado.Size = new System.Drawing.Size(83, 37);
            this.btnAbogado.TabIndex = 0;
            this.btnAbogado.Text = "&Abogados";
            this.btnAbogado.UseVisualStyleBackColor = true;
            this.btnAbogado.Click += new System.EventHandler(this.btnAbogado_Click);
            // 
            // btnPersonal
            // 
            this.btnPersonal.Location = new System.Drawing.Point(186, 40);
            this.btnPersonal.Name = "btnPersonal";
            this.btnPersonal.Size = new System.Drawing.Size(83, 37);
            this.btnPersonal.TabIndex = 1;
            this.btnPersonal.Text = "&Personal Gral";
            this.btnPersonal.UseVisualStyleBackColor = true;
            this.btnPersonal.Click += new System.EventHandler(this.btnPersonal_Click);
            // 
            // frmPersonal2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 145);
            this.Controls.Add(this.btnPersonal);
            this.Controls.Add(this.btnAbogado);
            this.Name = "frmPersonal2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Escoger Personal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAbogado;
        private System.Windows.Forms.Button btnPersonal;
    }
}