namespace WindowsFormsApplication5
{
    partial class frmInformacion
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
            this.btnDemInfo = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.btnTuto = new System.Windows.Forms.Button();
            this.btnRepInfo = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDemInfo
            // 
            this.btnDemInfo.Location = new System.Drawing.Point(55, 57);
            this.btnDemInfo.Name = "btnDemInfo";
            this.btnDemInfo.Size = new System.Drawing.Size(100, 40);
            this.btnDemInfo.TabIndex = 0;
            this.btnDemInfo.Text = "&Demandados";
            this.btnDemInfo.UseVisualStyleBackColor = true;
            this.btnDemInfo.Click += new System.EventHandler(this.btnDemInfo_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.Location = new System.Drawing.Point(248, 57);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(100, 40);
            this.btnAbout.TabIndex = 1;
            this.btnAbout.Text = "&About us";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // btnTuto
            // 
            this.btnTuto.Location = new System.Drawing.Point(55, 205);
            this.btnTuto.Name = "btnTuto";
            this.btnTuto.Size = new System.Drawing.Size(100, 40);
            this.btnTuto.TabIndex = 2;
            this.btnTuto.Text = "&Ayuda Gral";
            this.btnTuto.UseVisualStyleBackColor = true;
            // 
            // btnRepInfo
            // 
            this.btnRepInfo.Location = new System.Drawing.Point(248, 205);
            this.btnRepInfo.Name = "btnRepInfo";
            this.btnRepInfo.Size = new System.Drawing.Size(100, 40);
            this.btnRepInfo.TabIndex = 3;
            this.btnRepInfo.Text = "&Reportar Problema";
            this.btnRepInfo.UseVisualStyleBackColor = true;
            this.btnRepInfo.Click += new System.EventHandler(this.btnRepInfo_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(388, 290);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // frmInformacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 314);
            this.Controls.Add(this.btnRepInfo);
            this.Controls.Add(this.btnTuto);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.btnDemInfo);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmInformacion";
            this.Text = "Informacion";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDemInfo;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Button btnTuto;
        private System.Windows.Forms.Button btnRepInfo;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}