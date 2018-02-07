namespace SistemaDeIdentificacionUsuarios
{
    partial class Registro_de_huella
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
            this.label1 = new System.Windows.Forms.Label();
            this.pcbHUELLA = new System.Windows.Forms.PictureBox();
            this.btnVERIFICAR = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pcbHUELLA)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registre su huella";
            // 
            // pcbHUELLA
            // 
            this.pcbHUELLA.Location = new System.Drawing.Point(12, 52);
            this.pcbHUELLA.Name = "pcbHUELLA";
            this.pcbHUELLA.Size = new System.Drawing.Size(213, 224);
            this.pcbHUELLA.TabIndex = 1;
            this.pcbHUELLA.TabStop = false;
            // 
            // btnVERIFICAR
            // 
            this.btnVERIFICAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVERIFICAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVERIFICAR.Location = new System.Drawing.Point(12, 282);
            this.btnVERIFICAR.Name = "btnVERIFICAR";
            this.btnVERIFICAR.Size = new System.Drawing.Size(213, 39);
            this.btnVERIFICAR.TabIndex = 2;
            this.btnVERIFICAR.Text = "Capturar";
            this.btnVERIFICAR.UseVisualStyleBackColor = true;
            this.btnVERIFICAR.Click += new System.EventHandler(this.btnVERIFICAR_Click);
            // 
            // Registro_de_huella
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(243, 333);
            this.Controls.Add(this.btnVERIFICAR);
            this.Controls.Add(this.pcbHUELLA);
            this.Controls.Add(this.label1);
            this.Name = "Registro_de_huella";
            this.Text = "Registro de huella";
            ((System.ComponentModel.ISupportInitialize)(this.pcbHUELLA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pcbHUELLA;
        private System.Windows.Forms.Button btnVERIFICAR;
    }
}