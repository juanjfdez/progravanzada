namespace ABC
{
    partial class Mod
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
            this.btnMod = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMod
            // 
            this.btnMod.Location = new System.Drawing.Point(352, 26);
            this.btnMod.Name = "btnMod";
            this.btnMod.Size = new System.Drawing.Size(94, 40);
            this.btnMod.TabIndex = 4;
            this.btnMod.Text = "&Cambiar";
            this.btnMod.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(352, 97);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(94, 40);
            this.btnLimpiar.TabIndex = 5;
            this.btnLimpiar.Text = "&Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // Mod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 332);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnMod);
            this.Name = "Mod";
            this.Text = "Mod";
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.Button btnMod;
        protected System.Windows.Forms.Button btnLimpiar;

    }
}