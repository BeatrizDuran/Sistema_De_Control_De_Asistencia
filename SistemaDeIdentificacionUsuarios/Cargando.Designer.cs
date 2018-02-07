namespace SistemaDeIdentificacionUsuarios
{
    partial class Cargando
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
            this.lblCARGANDO = new System.Windows.Forms.Label();
            this.pgBCARGANDO = new System.Windows.Forms.ProgressBar();
            this.btnCANCELAR = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCARGANDO
            // 
            this.lblCARGANDO.AutoSize = true;
            this.lblCARGANDO.Location = new System.Drawing.Point(26, 22);
            this.lblCARGANDO.Name = "lblCARGANDO";
            this.lblCARGANDO.Size = new System.Drawing.Size(62, 13);
            this.lblCARGANDO.TabIndex = 0;
            this.lblCARGANDO.Text = "Cargando...";
            // 
            // pgBCARGANDO
            // 
            this.pgBCARGANDO.Location = new System.Drawing.Point(29, 53);
            this.pgBCARGANDO.Name = "pgBCARGANDO";
            this.pgBCARGANDO.Size = new System.Drawing.Size(300, 23);
            this.pgBCARGANDO.TabIndex = 1;
            // 
            // btnCANCELAR
            // 
            this.btnCANCELAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCANCELAR.Location = new System.Drawing.Point(145, 91);
            this.btnCANCELAR.Name = "btnCANCELAR";
            this.btnCANCELAR.Size = new System.Drawing.Size(75, 23);
            this.btnCANCELAR.TabIndex = 2;
            this.btnCANCELAR.Text = "Cancelar";
            this.btnCANCELAR.UseVisualStyleBackColor = true;
            // 
            // Cargando
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 138);
            this.Controls.Add(this.btnCANCELAR);
            this.Controls.Add(this.pgBCARGANDO);
            this.Controls.Add(this.lblCARGANDO);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Cargando";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cargando";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCARGANDO;
        private System.Windows.Forms.ProgressBar pgBCARGANDO;
        private System.Windows.Forms.Button btnCANCELAR;
    }
}