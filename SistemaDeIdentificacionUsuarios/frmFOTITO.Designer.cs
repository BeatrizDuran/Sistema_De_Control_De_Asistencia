namespace SistemaDeIdentificacionUsuarios
{
    partial class frmFOTITO
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
            this.cmbCAMARA = new System.Windows.Forms.ComboBox();
            this.btnINICIAR = new System.Windows.Forms.Button();
            this.btnCAPTURAR = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMINI = new System.Windows.Forms.Button();
            this.btnSALIR = new System.Windows.Forms.Button();
            this.pcbFOTO = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFOTO)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbCAMARA
            // 
            this.cmbCAMARA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCAMARA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbCAMARA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCAMARA.FormattingEnabled = true;
            this.cmbCAMARA.Location = new System.Drawing.Point(34, 72);
            this.cmbCAMARA.Name = "cmbCAMARA";
            this.cmbCAMARA.Size = new System.Drawing.Size(341, 28);
            this.cmbCAMARA.TabIndex = 0;
            // 
            // btnINICIAR
            // 
            this.btnINICIAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnINICIAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnINICIAR.Location = new System.Drawing.Point(381, 72);
            this.btnINICIAR.Name = "btnINICIAR";
            this.btnINICIAR.Size = new System.Drawing.Size(116, 28);
            this.btnINICIAR.TabIndex = 1;
            this.btnINICIAR.Text = "Iniciar";
            this.btnINICIAR.UseVisualStyleBackColor = true;
            this.btnINICIAR.Click += new System.EventHandler(this.btnINICIAR_Click);
            // 
            // btnCAPTURAR
            // 
            this.btnCAPTURAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCAPTURAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCAPTURAR.Location = new System.Drawing.Point(163, 403);
            this.btnCAPTURAR.Name = "btnCAPTURAR";
            this.btnCAPTURAR.Size = new System.Drawing.Size(222, 33);
            this.btnCAPTURAR.TabIndex = 3;
            this.btnCAPTURAR.Text = "Capturar";
            this.btnCAPTURAR.UseVisualStyleBackColor = true;
            this.btnCAPTURAR.Click += new System.EventHandler(this.btnCAPTURAR_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 31);
            this.label1.TabIndex = 5;
            this.label1.Text = "Capture la foto";
            // 
            // btnMINI
            // 
            this.btnMINI.FlatAppearance.BorderSize = 0;
            this.btnMINI.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnMINI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMINI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMINI.Image = global::SistemaDeIdentificacionUsuarios.Properties.Resources.if_window_minimize_1954552;
            this.btnMINI.Location = new System.Drawing.Point(424, 3);
            this.btnMINI.Name = "btnMINI";
            this.btnMINI.Size = new System.Drawing.Size(52, 50);
            this.btnMINI.TabIndex = 7;
            this.btnMINI.UseVisualStyleBackColor = true;
            this.btnMINI.Click += new System.EventHandler(this.btnMINI_Click);
            // 
            // btnSALIR
            // 
            this.btnSALIR.FlatAppearance.BorderSize = 0;
            this.btnSALIR.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnSALIR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSALIR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSALIR.Image = global::SistemaDeIdentificacionUsuarios.Properties.Resources.if_00_ELASTOFONT_STORE_READY_close_2703079;
            this.btnSALIR.Location = new System.Drawing.Point(482, 3);
            this.btnSALIR.Name = "btnSALIR";
            this.btnSALIR.Size = new System.Drawing.Size(52, 50);
            this.btnSALIR.TabIndex = 4;
            this.btnSALIR.UseVisualStyleBackColor = true;
            this.btnSALIR.Click += new System.EventHandler(this.btnSALIR_Click);
            // 
            // pcbFOTO
            // 
            this.pcbFOTO.Location = new System.Drawing.Point(34, 122);
            this.pcbFOTO.Name = "pcbFOTO";
            this.pcbFOTO.Size = new System.Drawing.Size(463, 266);
            this.pcbFOTO.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbFOTO.TabIndex = 2;
            this.pcbFOTO.TabStop = false;
            // 
            // frmFOTITO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 458);
            this.Controls.Add(this.btnMINI);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSALIR);
            this.Controls.Add(this.btnCAPTURAR);
            this.Controls.Add(this.pcbFOTO);
            this.Controls.Add(this.btnINICIAR);
            this.Controls.Add(this.cmbCAMARA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmFOTITO";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Foto";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmFOTITO_FormClosed);
            this.Load += new System.EventHandler(this.frmFOTITO_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbFOTO)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbCAMARA;
        private System.Windows.Forms.Button btnINICIAR;
        private System.Windows.Forms.PictureBox pcbFOTO;
        private System.Windows.Forms.Button btnCAPTURAR;
        private System.Windows.Forms.Button btnSALIR;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMINI;
    }
}