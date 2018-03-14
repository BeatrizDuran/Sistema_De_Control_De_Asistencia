namespace SistemaDeIdentificacionUsuarios
{
    partial class PruebaHuellita
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
            this.txtNOMBRE = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGUARDAR = new System.Windows.Forms.Button();
            this.pcbFOTOPRUEBA = new System.Windows.Forms.PictureBox();
            this.Prompt = new System.Windows.Forms.TextBox();
            this.StatusText = new System.Windows.Forms.TextBox();
            this.StatusLine = new System.Windows.Forms.Label();
            this.pbMuestras = new System.Windows.Forms.ProgressBar();
            this.lblEstatus = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFOTOPRUEBA)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNOMBRE
            // 
            this.txtNOMBRE.Location = new System.Drawing.Point(303, 55);
            this.txtNOMBRE.Name = "txtNOMBRE";
            this.txtNOMBRE.Size = new System.Drawing.Size(145, 20);
            this.txtNOMBRE.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(300, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre:";
            // 
            // btnGUARDAR
            // 
            this.btnGUARDAR.Location = new System.Drawing.Point(303, 81);
            this.btnGUARDAR.Name = "btnGUARDAR";
            this.btnGUARDAR.Size = new System.Drawing.Size(75, 23);
            this.btnGUARDAR.TabIndex = 3;
            this.btnGUARDAR.Text = "Guardar";
            this.btnGUARDAR.UseVisualStyleBackColor = true;
            this.btnGUARDAR.Click += new System.EventHandler(this.btnGUARDAR_Click);
            // 
            // pcbFOTOPRUEBA
            // 
            this.pcbFOTOPRUEBA.Location = new System.Drawing.Point(33, 42);
            this.pcbFOTOPRUEBA.Name = "pcbFOTOPRUEBA";
            this.pcbFOTOPRUEBA.Size = new System.Drawing.Size(173, 186);
            this.pcbFOTOPRUEBA.TabIndex = 0;
            this.pcbFOTOPRUEBA.TabStop = false;
            // 
            // Prompt
            // 
            this.Prompt.Location = new System.Drawing.Point(495, 76);
            this.Prompt.Name = "Prompt";
            this.Prompt.Size = new System.Drawing.Size(100, 20);
            this.Prompt.TabIndex = 4;
            // 
            // StatusText
            // 
            this.StatusText.Location = new System.Drawing.Point(495, 112);
            this.StatusText.Name = "StatusText";
            this.StatusText.Size = new System.Drawing.Size(100, 20);
            this.StatusText.TabIndex = 5;
            // 
            // StatusLine
            // 
            this.StatusLine.AutoSize = true;
            this.StatusLine.Location = new System.Drawing.Point(476, 145);
            this.StatusLine.Name = "StatusLine";
            this.StatusLine.Size = new System.Drawing.Size(19, 13);
            this.StatusLine.TabIndex = 6;
            this.StatusLine.Text = "....";
            // 
            // pbMuestras
            // 
            this.pbMuestras.Location = new System.Drawing.Point(33, 234);
            this.pbMuestras.Name = "pbMuestras";
            this.pbMuestras.Size = new System.Drawing.Size(173, 23);
            this.pbMuestras.TabIndex = 7;
            // 
            // lblEstatus
            // 
            this.lblEstatus.AutoSize = true;
            this.lblEstatus.Location = new System.Drawing.Point(476, 169);
            this.lblEstatus.Name = "lblEstatus";
            this.lblEstatus.Size = new System.Drawing.Size(19, 13);
            this.lblEstatus.TabIndex = 8;
            this.lblEstatus.Text = "....";
            // 
            // PruebaHuellita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 282);
            this.Controls.Add(this.lblEstatus);
            this.Controls.Add(this.pbMuestras);
            this.Controls.Add(this.StatusLine);
            this.Controls.Add(this.StatusText);
            this.Controls.Add(this.Prompt);
            this.Controls.Add(this.btnGUARDAR);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNOMBRE);
            this.Controls.Add(this.pcbFOTOPRUEBA);
            this.Name = "PruebaHuellita";
            this.Text = "PruebaHuellita";
            this.Load += new System.EventHandler(this.PruebaHuellita_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbFOTOPRUEBA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pcbFOTOPRUEBA;
        private System.Windows.Forms.TextBox txtNOMBRE;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGUARDAR;
        private System.Windows.Forms.TextBox Prompt;
        private System.Windows.Forms.TextBox StatusText;
        private System.Windows.Forms.Label StatusLine;
        private System.Windows.Forms.ProgressBar pbMuestras;
        private System.Windows.Forms.Label lblEstatus;
    }
}