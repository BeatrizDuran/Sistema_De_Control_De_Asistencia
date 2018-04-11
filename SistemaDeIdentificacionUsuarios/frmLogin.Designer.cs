namespace SistemaDeIdentificacionUsuarios
{
    partial class frmLogin
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
            this.lblNOMBREUSUARIO = new System.Windows.Forms.Label();
            this.txtUSUARIO = new System.Windows.Forms.TextBox();
            this.lblINGRESARPASS = new System.Windows.Forms.Label();
            this.txtPASSWORD = new System.Windows.Forms.TextBox();
            this.btnACCEDER = new System.Windows.Forms.Button();
            this.btnSALIR = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTITULO1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTITULO2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNOMBREUSUARIO
            // 
            this.lblNOMBREUSUARIO.AutoSize = true;
            this.lblNOMBREUSUARIO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNOMBREUSUARIO.Location = new System.Drawing.Point(209, 118);
            this.lblNOMBREUSUARIO.Name = "lblNOMBREUSUARIO";
            this.lblNOMBREUSUARIO.Size = new System.Drawing.Size(68, 20);
            this.lblNOMBREUSUARIO.TabIndex = 0;
            this.lblNOMBREUSUARIO.Text = "Usuario:";
            // 
            // txtUSUARIO
            // 
            this.txtUSUARIO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUSUARIO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUSUARIO.Location = new System.Drawing.Point(213, 141);
            this.txtUSUARIO.Name = "txtUSUARIO";
            this.txtUSUARIO.Size = new System.Drawing.Size(360, 26);
            this.txtUSUARIO.TabIndex = 1;
            // 
            // lblINGRESARPASS
            // 
            this.lblINGRESARPASS.AutoSize = true;
            this.lblINGRESARPASS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblINGRESARPASS.Location = new System.Drawing.Point(209, 170);
            this.lblINGRESARPASS.Name = "lblINGRESARPASS";
            this.lblINGRESARPASS.Size = new System.Drawing.Size(96, 20);
            this.lblINGRESARPASS.TabIndex = 2;
            this.lblINGRESARPASS.Text = "Contraseña:";
            // 
            // txtPASSWORD
            // 
            this.txtPASSWORD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPASSWORD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPASSWORD.Location = new System.Drawing.Point(213, 193);
            this.txtPASSWORD.Name = "txtPASSWORD";
            this.txtPASSWORD.Size = new System.Drawing.Size(360, 26);
            this.txtPASSWORD.TabIndex = 3;
            this.txtPASSWORD.UseSystemPasswordChar = true;
            // 
            // btnACCEDER
            // 
            this.btnACCEDER.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnACCEDER.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnACCEDER.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnACCEDER.Location = new System.Drawing.Point(213, 225);
            this.btnACCEDER.Name = "btnACCEDER";
            this.btnACCEDER.Size = new System.Drawing.Size(179, 38);
            this.btnACCEDER.TabIndex = 4;
            this.btnACCEDER.Text = "Acceder";
            this.btnACCEDER.UseVisualStyleBackColor = false;
            this.btnACCEDER.Click += new System.EventHandler(this.btnACCEDER_Click);
            // 
            // btnSALIR
            // 
            this.btnSALIR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSALIR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSALIR.Location = new System.Drawing.Point(394, 225);
            this.btnSALIR.Name = "btnSALIR";
            this.btnSALIR.Size = new System.Drawing.Size(179, 38);
            this.btnSALIR.TabIndex = 5;
            this.btnSALIR.Text = "Salir";
            this.btnSALIR.UseVisualStyleBackColor = true;
            this.btnSALIR.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SistemaDeIdentificacionUsuarios.Properties.Resources.permiso_administrador;
            this.pictureBox1.Location = new System.Drawing.Point(36, 119);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(152, 144);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // lblTITULO1
            // 
            this.lblTITULO1.AutoSize = true;
            this.lblTITULO1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTITULO1.Location = new System.Drawing.Point(142, 55);
            this.lblTITULO1.Name = "lblTITULO1";
            this.lblTITULO1.Size = new System.Drawing.Size(329, 25);
            this.lblTITULO1.TabIndex = 7;
            this.lblTITULO1.Text = "Sistema de Control de Asistencia";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(156, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 25);
            this.label4.TabIndex = 8;
            // 
            // lblTITULO2
            // 
            this.lblTITULO2.AutoSize = true;
            this.lblTITULO2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTITULO2.Location = new System.Drawing.Point(196, 80);
            this.lblTITULO2.Name = "lblTITULO2";
            this.lblTITULO2.Size = new System.Drawing.Size(216, 25);
            this.lblTITULO2.TabIndex = 9;
            this.lblTITULO2.Text = "Sesión Administrador";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(594, 32);
            this.panel1.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel2.Location = new System.Drawing.Point(0, 290);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(595, 10);
            this.panel2.TabIndex = 11;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(593, 299);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblTITULO2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblTITULO1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSALIR);
            this.Controls.Add(this.btnACCEDER);
            this.Controls.Add(this.txtPASSWORD);
            this.Controls.Add(this.lblINGRESARPASS);
            this.Controls.Add(this.txtUSUARIO);
            this.Controls.Add(this.lblNOMBREUSUARIO);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNOMBREUSUARIO;
        private System.Windows.Forms.TextBox txtUSUARIO;
        private System.Windows.Forms.Label lblINGRESARPASS;
        private System.Windows.Forms.TextBox txtPASSWORD;
        private System.Windows.Forms.Button btnACCEDER;
        private System.Windows.Forms.Button btnSALIR;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTITULO1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTITULO2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}