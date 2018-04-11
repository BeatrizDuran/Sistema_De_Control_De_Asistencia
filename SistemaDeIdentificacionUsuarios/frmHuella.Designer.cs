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
            this.lblTITULODACTILAR = new System.Windows.Forms.Label();
            this.btnVERIFICAR = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pcbHUELLA = new System.Windows.Forms.PictureBox();
            this.btnREGISTRAR = new System.Windows.Forms.Button();
            this.StatusLine = new System.Windows.Forms.Label();
            this.pbMuestras = new System.Windows.Forms.ProgressBar();
            this.lblEstatus = new System.Windows.Forms.Label();
            this.Prompt = new System.Windows.Forms.Label();
            this.StatusText = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pcbHUELLA)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTITULODACTILAR
            // 
            this.lblTITULODACTILAR.AutoSize = true;
            this.lblTITULODACTILAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTITULODACTILAR.Location = new System.Drawing.Point(68, 32);
            this.lblTITULODACTILAR.Name = "lblTITULODACTILAR";
            this.lblTITULODACTILAR.Size = new System.Drawing.Size(188, 20);
            this.lblTITULODACTILAR.TabIndex = 0;
            this.lblTITULODACTILAR.Text = "Capture su huella dactilar";
            // 
            // btnVERIFICAR
            // 
            this.btnVERIFICAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVERIFICAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVERIFICAR.Location = new System.Drawing.Point(157, 437);
            this.btnVERIFICAR.Name = "btnVERIFICAR";
            this.btnVERIFICAR.Size = new System.Drawing.Size(132, 39);
            this.btnVERIFICAR.TabIndex = 2;
            this.btnVERIFICAR.Text = "Verificar";
            this.btnVERIFICAR.UseVisualStyleBackColor = true;
            this.btnVERIFICAR.Click += new System.EventHandler(this.btnVERIFICAR_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::SistemaDeIdentificacionUsuarios.Properties.Resources.if_00_ELASTOFONT_STORE_READY_close_2703079;
            this.button1.Location = new System.Drawing.Point(270, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(44, 46);
            this.button1.TabIndex = 3;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pcbHUELLA
            // 
            this.pcbHUELLA.Location = new System.Drawing.Point(31, 67);
            this.pcbHUELLA.Name = "pcbHUELLA";
            this.pcbHUELLA.Size = new System.Drawing.Size(258, 224);
            this.pcbHUELLA.TabIndex = 1;
            this.pcbHUELLA.TabStop = false;
            // 
            // btnREGISTRAR
            // 
            this.btnREGISTRAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnREGISTRAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnREGISTRAR.Location = new System.Drawing.Point(31, 437);
            this.btnREGISTRAR.Name = "btnREGISTRAR";
            this.btnREGISTRAR.Size = new System.Drawing.Size(127, 39);
            this.btnREGISTRAR.TabIndex = 4;
            this.btnREGISTRAR.Text = "Capturar";
            this.btnREGISTRAR.UseVisualStyleBackColor = true;
            this.btnREGISTRAR.Click += new System.EventHandler(this.btnREGISTRAR_Click);
            // 
            // StatusLine
            // 
            this.StatusLine.AutoSize = true;
            this.StatusLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusLine.Location = new System.Drawing.Point(27, 334);
            this.StatusLine.Name = "StatusLine";
            this.StatusLine.Size = new System.Drawing.Size(17, 20);
            this.StatusLine.TabIndex = 5;
            this.StatusLine.Text = "..";
            // 
            // pbMuestras
            // 
            this.pbMuestras.Location = new System.Drawing.Point(31, 288);
            this.pbMuestras.Name = "pbMuestras";
            this.pbMuestras.Size = new System.Drawing.Size(258, 34);
            this.pbMuestras.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.pbMuestras.TabIndex = 93;
            // 
            // lblEstatus
            // 
            this.lblEstatus.AutoSize = true;
            this.lblEstatus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstatus.Location = new System.Drawing.Point(27, 334);
            this.lblEstatus.Name = "lblEstatus";
            this.lblEstatus.Size = new System.Drawing.Size(0, 21);
            this.lblEstatus.TabIndex = 95;
            // 
            // Prompt
            // 
            this.Prompt.AutoSize = true;
            this.Prompt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Prompt.Location = new System.Drawing.Point(27, 366);
            this.Prompt.Name = "Prompt";
            this.Prompt.Size = new System.Drawing.Size(17, 20);
            this.Prompt.TabIndex = 96;
            this.Prompt.Text = "..";
            // 
            // StatusText
            // 
            this.StatusText.AutoSize = true;
            this.StatusText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusText.Location = new System.Drawing.Point(27, 403);
            this.StatusText.Name = "StatusText";
            this.StatusText.Size = new System.Drawing.Size(17, 20);
            this.StatusText.TabIndex = 97;
            this.StatusText.Text = "..";
            // 
            // Registro_de_huella
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 493);
            this.Controls.Add(this.StatusText);
            this.Controls.Add(this.Prompt);
            this.Controls.Add(this.lblEstatus);
            this.Controls.Add(this.pbMuestras);
            this.Controls.Add(this.StatusLine);
            this.Controls.Add(this.btnREGISTRAR);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnVERIFICAR);
            this.Controls.Add(this.pcbHUELLA);
            this.Controls.Add(this.lblTITULODACTILAR);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Registro_de_huella";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de huella";
            this.Load += new System.EventHandler(this.Registro_de_huella_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbHUELLA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTITULODACTILAR;
        private System.Windows.Forms.PictureBox pcbHUELLA;
        private System.Windows.Forms.Button btnVERIFICAR;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnREGISTRAR;
        private System.Windows.Forms.Label StatusLine;
        private System.Windows.Forms.ProgressBar pbMuestras;
        private System.Windows.Forms.Label lblEstatus;
        private System.Windows.Forms.Label Prompt;
        private System.Windows.Forms.Label StatusText;
    }
}